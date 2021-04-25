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
			IqrfMqtt();

			/**
			 * Destructor
			 */
			virtual ~IqrfMqtt();

			/**
			 * Runs listening thread
			 */
			void startListen() override;

			/**
			 * Return IQRF channel state 
			 */
			State getState() const override;

			/**
			 * Attempts to get access
			 * @param ReceiveFromFunc Receive handler
			 * @param access Requested access type
			 */
			std::unique_ptr<Accessor> getAccess(ReceiveFromFunc receiveFromFunc, AccesType access) override;

			/**
			 * Check if component has exclusive access to channel
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
		private:
			/// Implementation class
			class Imp;
			/// Implementation object
			Imp *m_imp = nullptr;
	};
}
