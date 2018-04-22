/*
* Copyright 2018 MICRORISC s.r.o.
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

#include "ShapeDefines.h"

#ifdef IReadTrConfigService_EXPORTS
#define IReadTrConfigService_DECLSPEC SHAPE_ABI_EXPORT
#else
#define IReadTrConfigService_DECLSPEC SHAPE_ABI_IMPORT
#endif

namespace iqrf {

	/// \class IReadTrConfigService
	/// \brief IReadTrConfigService interface
	class IReadTrConfigService_DECLSPEC IReadTrConfigService
	{
	public:

	/// \brief Destructor
    virtual ~IReadTrConfigService() {};
	};
}