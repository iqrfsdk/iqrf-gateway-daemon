#pragma once

#include "IIqrfDpaService.h"
#include "rapidjson/rapidjson.h"
#include "rapidjson/document.h"
#include "Sensor.h"
#include "BinaryOutput.h"
#include "Dali.h"
#include "Light.h"
#include "EmbedNode.h"
#include <map>

namespace iqrf
{
  class IIqrfInfo
  {
  public:
    virtual std::map<int, sensor::EnumeratePtr> getSensors() const = 0;
    virtual std::map<int, binaryoutput::EnumeratePtr> getBinaryOutputs() const = 0;
    virtual std::map<int, dali::EnumeratePtr> getDalis() const = 0;
    virtual std::map<int, light::EnumeratePtr> getLights() const = 0;
    virtual std::map<int, embed::node::BriefInfoPtr> getNodes() const = 0;

    // for AutoNetwork usage
    virtual void insertNodes(const std::map<int, embed::node::BriefInfo> & nodes) = 0;
    
    // start enumeration thread
    virtual void startEnumeration() = 0;
    // stop enumeration thread
    virtual void stopEnumeration() = 0;
    // stop enumerate now (must be started to take effect)
    virtual void enumerate() = 0;
    // get enumeration period
    virtual int getPeriodEnumerate() const = 0;
    // set enumeration period (must be started to take periodic effect)
    virtual void setPeriodEnumerate(int period) = 0;
    // get non bonded nodes
    virtual std::vector<uint32_t> getUnbondMids() const = 0;
    // remove unbond nodes from DB - nodes are not by default deleted if unbonded
    virtual void removeUnbondNodes(const std::vector<uint32_t> & unbondVec) = 0;

    // for Mid meta data
    // gets the flag to control if messages are anotaded by metadata 
    virtual bool getMidMetaDataToMessages() const = 0;
    // sets the flag to control if messages are anotaded by metadata 
    virtual void setMidMetaDataToMessages(bool val) = 0;

    virtual rapidjson::Document getMidMetaData(uint32_t mid) const = 0;
    virtual void setMidMetaData(uint32_t mid, const rapidjson::Value & metaData) = 0;

    virtual rapidjson::Document getNodeMetaData(int nadr) const = 0;
    virtual void setNodeMetaData(int nadr, const rapidjson::Value & metaData) = 0;

    virtual ~IIqrfInfo() {}
  };
}
