/**
 * Copyright 2015 MICRORISC s.r.o.
 * Copyright 2017 IQRF Tech s.r.o.
 * Copyright 2020 MICRORISC s.r.o.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#define IIqrfChannelService_EXPORTS

#include "IqrfMqtt.h"

#ifdef TRC_CHANNEL
#undef TRC_CHANNEL
#endif
#define TRC_CHANNEL 0

#include "iqrf__IqrfMqtt.hxx"

TRC_INIT_MODULE(iqrf::IqrfMqtt);

namespace iqrf {
	///// IIqrfChannel methods /////

	void IqrfMqtt::startListen() {
		TRC_INFORMATION("Starting MQTT thread");
		m_connected = false;
		m_reconnect = true;
		if (m_runThread.joinable()) {
			m_runThread.join();
		}
		m_runThread = std::thread([this] {this->runListeningThread();});
		pthread_setname_np(m_runThread.native_handle(), "iqrfMqttConnect");
	}

	void IqrfMqtt::send(const std::basic_string<unsigned char>& message) {
		if (m_connected) {
			int ret;
			MQTTAsync_message msg = MQTTAsync_message_initializer;

			msg.payload = (void *)message.data();
			msg.payloadlen = (int)message.size();
			msg.qos = m_qos;
			msg.retained = 0;

			ret = MQTTAsync_sendMessage(m_client, m_publishTopic.c_str(), &msg, &m_publishOptions);
			if (ret != MQTTASYNC_SUCCESS) {
				TRC_WARNING("MQTTAsync_sendMessage() failed: " << ret);
			}
		}
	}

	IIqrfChannelService::State IqrfMqtt::getState() const {
		IIqrfChannelService::State state = State::NotReady;
		if (m_accessControl.hasExclusiveAccess()) {
			state = State::ExclusiveAccess;
		}
		return state;
	}

	std::unique_ptr<IIqrfChannelService::Accessor> IqrfMqtt::getAccess(ReceiveFromFunc receiveFromFunc, AccesType access) {
		return m_accessControl.getAccess(receiveFromFunc, access);
	}

	bool IqrfMqtt::hasExclusiveAccess() const {
		return m_accessControl.hasExclusiveAccess();
	}

	void IqrfMqtt::activate(const shape::Properties *props) {
		TRC_INFORMATION(std::endl <<
			"******************************" << std::endl <<
			"IqrfMqtt instance activate" << std::endl <<
			"******************************"
		);
		modify(props);
		initMqtt();
	}

	void IqrfMqtt::modify(const shape::Properties *props) {
		TRC_INFORMATION("Updating MQTT configuration.");
		props->getMemberAsString("broker", m_broker);
		props->getMemberAsString("clientId", m_clientId);
		props->getMemberAsString("requestTopic", m_subscribeTopic);
		props->getMemberAsString("responseTopic", m_publishTopic);
		props->getMemberAsInt("persistence", m_persistence);
		props->getMemberAsInt("qos", m_qos);
	}

	void IqrfMqtt::deactivate() {
		TRC_INFORMATION(std::endl <<
			"******************************" << std::endl <<
			"IqrfMqtt instance deactivate" << std::endl <<
			"******************************"
		);
		teardownMqtt();
	}

	void IqrfMqtt::attachInterface(shape::ITraceService* iface) {
		shape::Tracer::get().addTracerService(iface);
	}

	void IqrfMqtt::detachInterface(shape::ITraceService* iface) {
		shape::Tracer::get().removeTracerService(iface);
	}

	///// dummy methods /////

	IIqrfChannelService::osInfo IqrfMqtt::getTrModuleInfo() {
		IIqrfChannelService::osInfo myOsInfo;
		memset(&myOsInfo, 0, sizeof(myOsInfo));
		return myOsInfo;
	}

	bool IqrfMqtt::enterProgrammingState() {
		TRC_WARNING("Enter programming state not implemented.");
		return false;
	}

	bool IqrfMqtt::terminateProgrammingState() {
		TRC_WARNING("Terminate programming state not implemented.");
		return false;
	}

	IIqrfChannelService::UploadErrorCode IqrfMqtt::upload(const IIqrfChannelService::UploadTarget target, const std::basic_string<uint8_t>& data, const uint16_t address) {
		(void)target;
		(void)data;
		(void)address;
		return IIqrfChannelService::UploadErrorCode::UPLOAD_ERROR_NOT_SUPPORTED;
	}
		
	///// callbacks /////
	static void connectCallback(void* context, MQTTAsync_successData* response) {
		((IqrfMqtt *)context)->onConnect(response);
	}

	void IqrfMqtt::onConnect(MQTTAsync_successData *response) {
		MQTTAsync_token token = 0;
		std::string serverUri = "";
		int version = 0;

		if (response) {
			token = response->token;
			if (response->alt.connect.serverURI) {
				serverUri = std::string(response->alt.connect.serverURI);
			}
			version = response->alt.connect.MQTTVersion;
		}

		TRC_INFORMATION("Successfully connected to " << m_broker <<
			" as " << m_clientId << " with token " << token <<
			". MQTT version: " << version 
		);

		{
			std::unique_lock<std::mutex> lck(m_connectMutex);
			m_connected = true;
			m_cv.notify_one();
		}

		int ret = MQTTAsync_subscribe(m_client, m_subscribeTopic.c_str(), m_qos, &m_subscribeOptions);
		if (ret != MQTTASYNC_SUCCESS) {
			TRC_WARNING("Subscribe method failed: " << PAR(ret) << PAR(m_subscribeTopic) << PAR(m_qos));
		}
	}

	static void connectFailCallback(void *context, MQTTAsync_failureData *response) {
		((IqrfMqtt *)context)->onConnectFail(response);
	}

	void IqrfMqtt::onConnectFail(MQTTAsync_failureData *response) {
		int code = -1;
		std::string message("No message");

		if (response) {
			code = response->code;
			message = response->message;
		}
		TRC_WARNING("Failed to connect to MQTT broker " << m_broker <<
			":[" << code << "] " << MQTTAsync_strerror(code) << ": " << message
		);

		{
			std::unique_lock<std::mutex> lck(m_connectMutex);
			m_connected = false;
			m_cv.notify_one();
		}	
	}

	static void disconnectCallback(void *context, MQTTAsync_successData *response) {
		((IqrfMqtt *)context)->onDisconnect(response);
	}

	void IqrfMqtt::onDisconnect(MQTTAsync_successData *response) {
		MQTTAsync_token token = 0;
		if (response->token) {
			token = response->token;
		}
		TRC_INFORMATION("Successfully disconnected with token " << token);
		m_disconnect_promise.set_value(true);
	}

	static void disconnectFailCallback(void *context, MQTTAsync_failureData *response) {
		((IqrfMqtt *)context)->onDisconnectFail(response);
	}

	void IqrfMqtt::onDisconnectFail(MQTTAsync_failureData *response) {
		int code = -1;
		std::string message("No message");

		if (response) {
			code = response->code;
			message = response->message;
		}
		TRC_WARNING("Failed to disconnect: [" << code << "] " <<
			MQTTAsync_strerror(code) << ": " << message
		);
	}

	static void subscribeCallback(void *context, MQTTAsync_successData *response) {
		((IqrfMqtt *)context)->onSubscribe(response);
	}

	void IqrfMqtt::onSubscribe(MQTTAsync_successData *response) {
		MQTTAsync_token token = 0;
		int qos = 0;

		if (response) {
			token = response->token;
			qos = response->alt.qos;
		}
	
		TRC_INFORMATION("Successfully subscribed to topic: " <<
			m_subscribeTopic << " with token: " << token <<
			", requested qos: " << m_qos << ", qos: " << qos
		);
	}

	static void subscribeFailCallback(void *context, MQTTAsync_failureData *response) {
		((IqrfMqtt *)context)->onSubscribeFail(response);
	}

	void IqrfMqtt::onSubscribeFail(MQTTAsync_failureData *response) {
		MQTTAsync_token token = 0;
		int code = -1;
		std::string message("No message");
		
		if (response) {
			token = response->token;
			code = response->code;
			message = response->message;
		}

		TRC_WARNING("Failed to subscribe to topic " << m_subscribeTopic <<
			", qos " << m_qos << ", token " << token <<
			": [" << code << "] " << MQTTAsync_strerror(code) << ": " << message
		);
	}

	static void publishCallback(void *context, MQTTAsync_successData *response) {
		((IqrfMqtt *)context)->onPublish(response);
	}

	void IqrfMqtt::onPublish(MQTTAsync_successData *response) {
		MQTTAsync_token token = 0;
		if (response) {
			token = response->token;
		}
		TRC_INFORMATION("Message successfully published with token: " << token);
	}

	static void publishFailCallback(void *context, MQTTAsync_failureData *response) {
		((IqrfMqtt *)context)->onPublishFail(response);
	}

	void IqrfMqtt::onPublishFail(MQTTAsync_failureData *response) {
		int code = -1;
		std::string message("No message");

		if (response) {
			code = response->code;
			message = response->message;
		}
		TRC_WARNING("Failed to publish message : [" << code << "] " <<
		MQTTAsync_strerror(code) << ": " << message);
	}

	static void deliveredCallback(void *context, MQTTAsync_token dt) {
		((IqrfMqtt *)context)->onDelivered(dt);
	}

	void IqrfMqtt::onDelivered(MQTTAsync_token dt) {
		TRC_INFORMATION("Message delivery confirmed" << PAR(dt));
	}

	static int messageCallback(void* context, char* topicName, int topicLen, MQTTAsync_message* message) {
		return ((IqrfMqtt *)context)->onMessage(topicName, topicLen, message);
	}

	int IqrfMqtt::onMessage(char* topicName, int topicLen, MQTTAsync_message* message) {
		(void)topicLen;
		std::basic_string<uint8_t> payload((uint8_t *)message->payload, message->payloadlen);
		m_accessControl.messageHandler(payload);
		MQTTAsync_freeMessage(&message);
		MQTTAsync_free(topicName);
		return 1;
	}

	static void connectionLostCallback(void *context, char *cause) {
		((IqrfMqtt *)context)->onConnectionLost(cause);
	}

	void IqrfMqtt::onConnectionLost(char *cause) {
		std::string errorMsg("unknown");
		if (cause) {
			errorMsg = std::string(cause);
		}
		TRC_WARNING("Connection lost: " <<  errorMsg);
		startListen();
	}

	///// MQTT client methods /////

	void IqrfMqtt::initMqtt() {
		TRC_INFORMATION("Initializing MQTT client configuration");
		int ret;

		ret = MQTTAsync_create(&m_client, m_broker.c_str(), m_clientId.c_str(), MQTTCLIENT_PERSISTENCE_NONE, NULL);
		if (ret != MQTTASYNC_SUCCESS) {
			THROW_EXC_TRC_WAR(std::logic_error, "Failed to create MQTT client: " << PAR(ret));
		}

		m_connectOptions.keepAliveInterval = 25;
		m_connectOptions.cleansession = 1;
		m_connectOptions.connectTimeout = 5;
		m_connectOptions.automaticReconnect = 1;
		m_connectOptions.onSuccess = connectCallback;
		m_connectOptions.onFailure = connectFailCallback;
		m_connectOptions.context = this;

		m_subscribeOptions.onSuccess = subscribeCallback;
		m_subscribeOptions.onFailure = subscribeFailCallback;
		m_subscribeOptions.context = this;

		m_publishOptions.onSuccess = publishCallback;
		m_publishOptions.onFailure = publishFailCallback;
		m_publishOptions.context = this;

		ret = MQTTAsync_setCallbacks(m_client, this, connectionLostCallback, messageCallback, deliveredCallback);
		if (ret != MQTTASYNC_SUCCESS) {
			THROW_EXC_TRC_WAR(std::logic_error, "Failed to set client callbacks: " << PAR(ret));
		}
	}

	void IqrfMqtt::teardownMqtt() {
		TRC_INFORMATION("Tearing down MQTT client");

		m_reconnect = false;
		onConnectFail(nullptr);
		if (m_runThread.joinable()) {
			m_runThread.join();
		}

		m_disconnectOptions.onSuccess = disconnectCallback;
		m_disconnectOptions.onFailure = disconnectFailCallback;
		m_disconnectOptions.context = this;

		int ret = MQTTAsync_disconnect(m_client, &m_disconnectOptions);
		if (ret != MQTTASYNC_SUCCESS) {
			TRC_WARNING("Disconnect method failed: [" << ret << "]");
			m_disconnect_promise.set_value(true);
		}

		std::chrono::seconds timeout(5);
		if (m_disconnect_future.wait_for(timeout) == std::future_status::timeout) {
			TRC_WARNING("Disconnect future timed out.");
		}

		MQTTAsync_setCallbacks(m_client, nullptr, nullptr, nullptr, nullptr);
		MQTTAsync_destroy(&m_client);

		TRC_INFORMATION("MQTT client terminated");
	}

	void IqrfMqtt::runListeningThread() {
		int ret;
		while (true) {
			ret = MQTTAsync_connect(m_client, &m_connectOptions);
			if (ret != MQTTASYNC_SUCCESS) {
				TRC_WARNING("Connect method failed: " << PAR(ret));
			}
			TRC_DEBUG("Sleeping...");
			{
				std::unique_lock<std::mutex> lck(m_connectMutex);
				if (m_cv.wait_for(lck, std::chrono::seconds(5), 
				[this] {return m_connected == true || m_reconnect == false;})) {
					break;
				}
			}
		}
	}
}
