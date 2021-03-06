# Copyright 2015-2021 IQRF Tech s.r.o.
# Copyright 2019-2021 MICRORISC s.r.o.
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

cmake_minimum_required(VERSION 3.0)

project(iqrf-gateway-daemon)

set_property(GLOBAL PROPERTY USE_FOLDERS ON)

set(CMAKE_ARCHIVE_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/lib)
set(CMAKE_LIBRARY_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/bin)
set(CMAKE_RUNTIME_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/bin)

if(NOT CMAKE_BUILD_TOOL MATCHES "(msdev|devenv|nmake|MSBuild)")
  include(CheckCXXCompilerFlag)
  CHECK_CXX_COMPILER_FLAG("-std=c++11" COMPILER_SUPPORTS_CXX11)
  CHECK_CXX_COMPILER_FLAG("-std=c++0x" COMPILER_SUPPORTS_CXX0X)
  if(COMPILER_SUPPORTS_CXX11)
    set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -fPIC -std=c++11 -pthread")
  elseif(COMPILER_SUPPORTS_CXX0X)
    set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -fPIC -std=c++0x -pthread")
  else()
    message(STATUS "The compiler ${CMAKE_CXX_COMPILER} has no C++11 support. Please use a different C++ compiler.")
  endif()
endif()

if ("${CMAKE_CXX_COMPILER_ID}" STREQUAL "MSVC")
	set(CMAKE_C_FLAGS "${CMAKE_C_FLAGS} /W4")
	set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /W4")
else ()
	set(CMAKE_C_FLAGS "${CMAKE_C_FLAGS} -Wall -Wextra -Werror=format-security")
	set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -Wall -Wextra -Werror=format-security")
endif ()

if (${CMAKE_CXX_COMPILER_ID} STREQUAL "Clang")
	if(CMAKE_CXX_COMPILER_VERSION VERSION_GREATER 3.6 OR CMAKE_CXX_COMPILER_VERSION VERSION_EQUAL 3.6)
		set(CMAKE_C_FLAGS "${CMAKE_C_FLAGS} -fstack-protector-strong")
		set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -fstack-protector-strong")
	else()
		set(CMAKE_C_FLAGS "${CMAKE_C_FLAGS} -fstack-protector")
		set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -fstack-protector")
	endif()
endif()

if (${CMAKE_CXX_COMPILER_ID} STREQUAL "GNU")
	if(CMAKE_CXX_COMPILER_VERSION VERSION_GREATER 8.0 OR CMAKE_CXX_COMPILER_VERSION VERSION_EQUAL 8.0)
		if (CMAKE_SYSTEM_PROCESSOR MATCHES "x86_64|amd64|AMD64" OR CMAKE_SYSTEM_PROCESSOR MATCHES "i[3456]86|x86")
			set(CMAKE_C_FLAGS "${CMAKE_C_FLAGS} -fcf-protection=full")
			set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -fcf-protection=full")
		endif()
		if(CMAKE_SYSTEM_PROCESSOR MATCHES "aarch64|^armv8*" OR NOT CMAKE_SYSTEM_PROCESSOR MATCHES "^arm*")
			set(CMAKE_C_FLAGS "${CMAKE_C_FLAGS} -fstack-clash-protection")
			set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -fstack-clash-protection")
		endif()
	endif()
	if(CMAKE_CXX_COMPILER_VERSION VERSION_GREATER 4.9 OR CMAKE_CXX_COMPILER_VERSION VERSION_EQUAL 4.9)
		set(CMAKE_C_FLAGS "${CMAKE_C_FLAGS} -fstack-protector-strong")
		set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -fstack-protector-strong")
	elseif(CMAKE_CXX_COMPILER_VERSION VERSION_GREATER 4.8 OR CMAKE_CXX_COMPILER_VERSION VERSION_EQUAL 4.8)
		set(CMAKE_C_FLAGS "${CMAKE_C_FLAGS} -fstack-protector")
		set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -fstack-protector")
	endif()
endif()

if(CMAKE_SYSTEM_NAME MATCHES "Linux")
	set(CMAKE_C_FLAGS "${CMAKE_C_FLAGS} -D_FORTIFY_SOURCE=2")
	set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -D_FORTIFY_SOURCE=2")
	if(${CMAKE_VERSION} VERSION_LESS 3.13)
		set(CMAKE_EXE_LINKER_FLAGS "${CMAKE_SHARED_LINKER_FLAGS} -Wl,-z,relro -Wl,-z,now")
		set(CMAKE_MODULE_LINKER_FLAGS "${CMAKE_SHARED_LINKER_FLAGS} -Wl,-z,relro -Wl,-z,now")
		set(CMAKE_SHARED_LINKER_FLAGS "${CMAKE_SHARED_LINKER_FLAGS} -Wl,-z,relro -Wl,-z,now")
	else()
		add_link_options(-Wl,-z,relro -Wl,-z,now)
	endif()
endif()

if(${USE_CCACHE})
	find_program(CCACHE_PROGRAM ccache)
	if(CCACHE_PROGRAM)
		set(CMAKE_C_COMPILER_LAUNCHER "${CCACHE_PROGRAM}")
		set(CMAKE_CXX_COMPILER_LAUNCHER "${CCACHE_PROGRAM}")
	endif()
endif()

set_directory_properties(PROPERTIES COMPILE_DEFINITIONS $<$<CONFIG:Debug>:_DEBUG>)

find_package(shape REQUIRED)

message(STATUS "CMAKE_MODULE_PATH: ${CMAKE_MODULE_PATH}")
include(${CMAKE_MODULE_PATH}/ShapeComponentDeclaration.cmake)

set(PROJECT_INSTALL_PREFIX ${PROJECT_NAME})
set(CMAKE_INSTALL_PREFIX ${shape_DEPLOY})

add_definitions(
  -DRAPIDJSON_HAS_STDSTRING
  -D_CRT_SECURE_NO_WARNINGS
)

set(DEFAULT_DAEMON_VERSION v2.4.0dev)

if(DEFINED DAEMON_VERSION)
  message(STATUS "DAEMON_VERSION = " ${DAEMON_VERSION})
else()
  message(STATUS "Set to default DAEMON_VERSION = " ${DEFAULT_DAEMON_VERSION})
  set(DAEMON_VERSION ${DEFAULT_DAEMON_VERSION})
endif()

add_subdirectory(libraries/clibspi  EXCLUDE_FROM_ALL)
add_subdirectory(libraries/clibcdc  EXCLUDE_FROM_ALL)
add_subdirectory(libraries/clibdpa  EXCLUDE_FROM_ALL)
add_subdirectory(libraries/clibuart EXCLUDE_FROM_ALL)
add_subdirectory(libraries/iqrf-header-parser EXCLUDE_FROM_ALL)

#add_subdirectory(src)

enable_testing()

include_directories(${CMAKE_CURRENT_SOURCE_DIR}/src/include)

add_subdirectory(src/include)
add_subdirectory(src/start-IqrfDaemon)
add_subdirectory(src/Scheduler)
add_subdirectory(src/IqrfCdc)
if (WIN32)
 add_subdirectory(src/IqrfUartWin)
endif()
add_subdirectory(src/IqrfSpi)
add_subdirectory(src/IqrfTcp)
#if (NOT WIN32)
  add_subdirectory(src/IqrfUart)
#endif()
add_subdirectory(src/IqrfDpa)
add_subdirectory(src/LegacyApiSupport)
add_subdirectory(src/MqMessaging)
add_subdirectory(src/MqttMessaging)
add_subdirectory(src/BufferedMqttMessaging)
add_subdirectory(src/WebsocketMessaging)
add_subdirectory(src/UdpMessaging)
add_subdirectory(src/IdeCounterpart)
add_subdirectory(src/JsonSplitter)
add_subdirectory(src/JsonDpaApiRaw)
add_subdirectory(src/JsonMngApi)
add_subdirectory(src/JsonCfgApi)
add_subdirectory(src/JsCache)
add_subdirectory(src/JsRenderDuktape)
add_subdirectory(src/JsonDpaApiIqrfStandard)
add_subdirectory(src/JsonDpaApiIqrfStdExt)
add_subdirectory(src/JsonIqrfInfoApi)
add_subdirectory(src/SchedulerMessaging)
add_subdirectory(src/IqrfInfo)
add_subdirectory(src/IqrfBackup)
add_subdirectory(src/IqrfRestore)
add_subdirectory(src/MonitorService)
add_subdirectory(src/DpaParser)
if (NOT WIN32)
  add_subdirectory(src/SyslogLogger)
endif()

# IDE folder for IQMesh services
set(IQMESH_SERVICES_FOLDER "iqmesh")
add_subdirectory(src/IqmeshServices/BondNodeLocalService)
add_subdirectory(src/IqmeshServices/SmartConnectService)
add_subdirectory(src/IqmeshServices/OtaUploadService)
add_subdirectory(src/IqmeshServices/ReadTrConfService)
add_subdirectory(src/IqmeshServices/WriteTrConfService)
add_subdirectory(src/IqmeshServices/EnumerateDeviceService)
add_subdirectory(src/NativeUpload)
add_subdirectory(src/IqmeshServices/AutonetworkService)
add_subdirectory(src/IqmeshServices/BackupService)
add_subdirectory(src/IqmeshServices/RestoreService)
add_subdirectory(src/IqmeshServices/RemoveBondService)

if(${BUILD_TESTING})
  add_subdirectory(src/tests)
endif()

configure_file(${CMAKE_CURRENT_SOURCE_DIR}/${PROJECT_NAME}Config.cmake.in ${PROJECT_BINARY_DIR}/${PROJECT_NAME}Config.cmake @ONLY)
configure_file(${CMAKE_CURRENT_SOURCE_DIR}/src/VersionInfo.h.in ${CMAKE_BINARY_DIR}/VersionInfo.h @ONLY)
