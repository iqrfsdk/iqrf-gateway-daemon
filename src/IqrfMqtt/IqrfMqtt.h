/*
* filename: IqrfTcp.h
* author: Karel Hanák <xhanak34@stud.fit.vutbr.cz>
* school: Brno University of Technology, Faculty of Information Technology
* bachelor's thesis: Automatic Testing of Software 
*
* Header file for the IqrfTcp component.
*
* Copyright 2020 Karel Hanák
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
#pragma once

#include "IIqrfChannelService.h"
#include "AccessControl.h"
#include "ShapeProperties.h"
#include "ITraceService.h"
#include "Trace.h"
#include "MQTTAsync.h"
#include <atomic>
#include <condition_variable>
#include <mutex>
#include <string>
#include <thread>
#include <pthread.h>

/// IQRF namespace
namespace iqrf {
	/// Component class
	class IqrfMqtt : public IIqrfChannelService {
	public:
		/**
		 * Constructor
		 */
		IqrfMqtt(): m_accessControl(this) {};

		/**
		 * Destructor
		 */
		~IqrfMqtt() {};

		/**
		 * Runs listening thread
		 */
		void startListen() override;

		/**
		 * Publishes message to broker
		 * @param message Message to publish
		 */
		void send(const std::basic_string<unsigned char>& message);

		/**
		 * Return IQRF channel state 
		 * returns Current channel state
		 */
		State getState() const override;

		/**
		 * Attempts to get access
		 * @param ReceiveFromFunc Receive handler
		 * @param access Requested access type
		 * @return Pointer to access
		 */
		std::unique_ptr<Accessor> getAccess(ReceiveFromFunc receiveFromFunc, AccesType access) override;

		/**
		 * Check if component has exclusive access to channel
		 * @return true if component has exclusive access, false otherwise
		 */
		bool hasExclusiveAccess() const override;

		/**
		 * Component life cycle activate
		 * @param props Component properties
		 */
		void activate(const shape::Properties *props = 0);

		/**
		 * Component life cycle modify
		 * @param props Component properties
		 */
		void modify(const shape::Properties *props);

		/**
		 * Component life cycle deactivate
		 */
		void deactivate();

		/**
		 * Attaches tracing interface
		 * @param iface Tracing interface
		 */
		void attachInterface(shape::ITraceService* iface);

		/**
		 * Detaches tracing interface
		 * @param iface Tracing interface
		 */
		void detachInterface(shape::ITraceService* iface);

		/**
		 * Retrieves OS information
		 * @return OS information struct
		 */
		osInfo getTrModuleInfo();

		/**
		 * Enters programming state
		 * @return true if successful, false otherwise
		 */
		bool enterProgrammingState();

		/**
		 * Terminates programming state
		 * @return true if successful, false otherwise
		 */
		bool terminateProgrammingState();

		/**
		 * Uploads data to target at specified address
		 * @param target Upload target
		 * @param data Data to upload
		 * @param addres Address to upload to
		 * @return Execution code
		 */
		UploadErrorCode upload(const IIqrfChannelService::UploadTarget target, const std::basic_string<uint8_t>& data, const uint16_t address);
	private:
		/**
		 * Initializes asynchronous mqtt client
		 */
		void initMqtt();
	
		/**
		 * Destroys mqtt client
		 */
		void teardownMqtt();

		/**
		 * Runs listening thread
		 */
		void runListeningThread();

		/**
		 * MQTT client connect success callback
		 * @param context Context
		 * @param response MQTTAsync success response
		 */
		void onConnect(void *context, MQTTAsync_successData *response);

		/**
		 * MQTT client connect failure callback
		 * @param context Context
		 * @param response MQTTAsync failure response
		 */
		void onConnectFail(void *context, MQTTAsync_failureData *response);

		/**
		 * MQTT client subscribe success callback
		 * @param context Context
		 * @param response MQTTAsync success response
		 */
		void onSubscribe(void *context, MQTTAsync_successData *response);

		/**
		 * MQTT client subscribe failure callback
		 * @param context Context
		 * @param response MQTTAsync failure response
		 */
		void onSubscribeFail(void *context, MQTTAsync_failureData *response);

		/**
		 * MQTT client publish success callback
		 * @param context Context
		 * @param response MQTTAsync success response
		 */
		void onPublish(void *context, MQTTAsync_successData *response);

		/**
		 * MQTT client publish failure callback
		 * @param context Context
		 * @param response MQTTAsync failure response
		 */
		void onPublishFail(void *context, MQTTAsync_failureData *response);

		/**
		 * MQTT client message delivered callback
		 * @param context Context
		 * @param dt Delivery token
		 */
		void onDelivered(void *context, MQTTAsync_token dt);

		/**
		 * MQTT client message received callback
		 * @param context Context
		 * @param topicName Publish topic
		 * @param topicLen Topic string length
		 * @param message Published message
		 * @returns Execution code
		 */
		int onMessage(void* context, char* topicName, int topicLen, MQTTAsync_message* message);

		/**
		 * MQTT client connection lost callback
		 * @param context Context
		 * @param cause Cause of connection loss
		 */
		void onConnectionLost(void *context, char *cause);

		/// access control
		AccessControl<IqrfMqtt> m_accessControl;
		/// thread
		std::thread m_runThread;
		/// connect mutex
		std::mutex m_connectMutex;
		/// conditional variable
		std::condition_variable m_cv;
		/// indicates that client is connected to broker
		std::atomic_bool m_connected;
		/// should client reconnect on failure?
		std::atomic_bool m_reconnect;

		///// mqtt configuration /////
		/// broker address
		std::string m_broker;
		/// client id
		std::string m_clientId;
		/// mqtt subscribe topic
		std::string m_subscribeTopic;
		/// mqtt publish topic
		std::string m_publishTopic;
		/// data persistence
		int m_persistence; 
		/// quality of service
		int m_qos;

		///// paho configuration /////
		/// mqtt client object ///
		MQTTAsync m_client = nullptr;
		/// connect options ///
		MQTTAsync_connectOptions m_connectOptions = MQTTAsync_connectOptions_initializer;
		MQTTAsync_responseOptions m_subscribeOptions = MQTTAsync_responseOptions_initializer;
		MQTTAsync_responseOptions m_publishOptions = MQTTAsync_responseOptions_initializer;
	};
}
