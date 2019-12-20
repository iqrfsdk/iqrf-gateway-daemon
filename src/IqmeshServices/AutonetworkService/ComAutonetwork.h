#pragma once

#include "ComBase.h"

namespace iqrf {

  // Autonetwork input paramaters
  typedef struct
  {
    uint8_t discoveryTxPower;
    bool discoveryBeforeStart;
    bool discovery;
    uint8_t actionRetries;
    struct 
    {
      uint8_t networks;
      uint8_t network;
    }overlappingNetworks;
    std::vector<uint16_t> hwpidFiltering;
    struct 
    {
      uint8_t waves;
      uint8_t networkSize;
      uint8_t newNetworkNodes;
      uint8_t emptyWaves;
    }stopConditions;
  }TAutonetworkInputParams;

  class ComAutonetwork : public ComBase
  {
  public:
    ComAutonetwork() = delete;
    ComAutonetwork( rapidjson::Document& doc ) : ComBase( doc )
    {
      parse( doc );
    }

    virtual ~ComAutonetwork()
    {
    }

    const TAutonetworkInputParams getAutonetworkParams() const
    {
      return m_autonetworkParams;
    }

  protected:
    void createResponsePayload( rapidjson::Document& doc, const IDpaTransactionResult2& res ) override
    {
      rapidjson::Pointer( "/data/rsp/response" ).Set( doc, encodeBinary( res.getResponse().DpaPacket().Buffer, res.getResponse().GetLength() ) );
    }

  private:
    TAutonetworkInputParams m_autonetworkParams;
    
    // Parse autonetwork service parameters
    void parseRequest( rapidjson::Document& doc )
    {
      rapidjson::Value* jsonValue;

      // discoveryTxPower
      m_autonetworkParams.discoveryTxPower = 7;
      if ( jsonValue = rapidjson::Pointer( "/data/req/discoveryTxPower" ).Get( doc ) )
      {
        uint32_t txPower = jsonValue->GetInt();
        if ( txPower > 7 )
          txPower = 7;
        m_autonetworkParams.discoveryTxPower = (uint8_t)txPower;
      }

      // discoveryBeforeStart
      if ( jsonValue = rapidjson::Pointer( "/data/req/discoveryBeforeStart" ).Get( doc ) )
        m_autonetworkParams.discoveryBeforeStart = jsonValue->GetBool();
      else
        m_autonetworkParams.discoveryBeforeStart = false;

      // discovery
      if ( jsonValue = rapidjson::Pointer( "/data/req/discovery" ).Get( doc ) )
        m_autonetworkParams.discovery = jsonValue->GetBool();
      else
        m_autonetworkParams.discovery = false;

      // actionRetries
      if ( jsonValue = rapidjson::Pointer( "/data/req/actionRetries" ).Get( doc ) )
        m_autonetworkParams.actionRetries = (uint8_t)jsonValue->GetInt();
      else
        m_autonetworkParams.actionRetries = 1;

      // overlappingNetworks/networks
      if ( jsonValue = rapidjson::Pointer( "/data/req/overlappingNetworks/networks" ).Get( doc ) )
        m_autonetworkParams.overlappingNetworks.networks = (uint8_t)jsonValue->GetInt();
      else
        m_autonetworkParams.overlappingNetworks.networks = 0;

      // overlappingNetworks/network
      if ( jsonValue = rapidjson::Pointer( "/data/req/overlappingNetworks/network" ).Get( doc ) )
        m_autonetworkParams.overlappingNetworks.network = (uint8_t)jsonValue->GetInt();
      else
        m_autonetworkParams.overlappingNetworks.network = 0;

      // hwpidFiltering
      m_autonetworkParams.hwpidFiltering.clear();
      if ( jsonValue = rapidjson::Pointer( "/data/req/hwpidFiltering" ).Get( doc ) )
      {
        const auto val = jsonValue->GetArray();
        for ( auto itr = val.Begin(); itr != val.End(); ++itr )
        {
          if ( itr->IsNull() == false )
            m_autonetworkParams.hwpidFiltering.push_back((uint16_t)itr->GetUint());
        }
      }

      // stopConditions/waves
      if ( jsonValue = rapidjson::Pointer( "/data/req/stopConditions/waves" ).Get( doc ) )
        m_autonetworkParams.stopConditions.waves = (uint8_t)jsonValue->GetInt();
      else
        m_autonetworkParams.stopConditions.waves = 0;

      // stopConditions/emptyWaves
      if ( jsonValue = rapidjson::Pointer( "/data/req/stopConditions/emptyWaves" ).Get( doc ) )
        m_autonetworkParams.stopConditions.emptyWaves = (uint8_t)jsonValue->GetInt();
      else
        m_autonetworkParams.stopConditions.emptyWaves = 1;

      // stopConditions/networkSize
      if ( jsonValue = rapidjson::Pointer( "/data/req/stopConditions/networkSize" ).Get( doc ) )
        m_autonetworkParams.stopConditions.networkSize = (uint8_t)jsonValue->GetInt();
      else
        m_autonetworkParams.stopConditions.networkSize = 0;

      // stopConditions/networkSize
      if ( jsonValue = rapidjson::Pointer( "/data/req/stopConditions/newNetworkNodes" ).Get( doc ) )
        m_autonetworkParams.stopConditions.newNetworkNodes = (uint8_t)jsonValue->GetInt();
      else
        m_autonetworkParams.stopConditions.newNetworkNodes = 0;
    }

    // Parses document into data fields
    void parse( rapidjson::Document& doc )
    {
      parseRequest( doc );
    }
  };
}
