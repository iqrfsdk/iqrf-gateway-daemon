# MQTT message channel

MQTT protocol is handled by component **iqrf::MqttMessaging**. Previous implementation was based on direct usage of **paho** library. It was replaced by referencing interface **shape::IMqttService**. This approach allows better abstraction from underlying MQTT client library as well as preparation for more advanced topic usage and better MQTT handling reuse by other applications.

## General features
- **iqrf::MqttMessaging** implements general **iqrf::IMessagingService** (similar to WS, MQ, ...)
- An instance of **iqrf::MqttMessaging** requires a running instance implementing **shape::IMqttService** (MANDATORY SINGLE)
- **shape::IMqttService** is implemented by the component **shape::MqttService** from shapeware (implemented by **paho** anyway) The interface is dedicated to MQTT specific features.
- Both component instances must be properly configured
- If there is need of more MQTT channels appropriate pairs of component instances must be configured. The instances are paired via configuration of **iqrf::MqttMessaging** in its `"RequiredInterfaces": {}` section. 

## Buffering
Buffering is implemented by **shape::MqttService**. It preserves messages to be published in a dedicated buffer in case of connection disruption. The messages are send later when connection recovers. The buffer is stored just in memory and it is not persisted. The buffer size can be configured.  

## Configuration
Configuration schemes are declared in dedicated `cfgSchemas` directory and you can find there meaning of the items. As you can see it more or less split configuration used in previous implementation to IQRF and MQTT specific parts.
Instances of configurations are for example:

### iqrf__MqttMessaging.json
```json
{
  "component": "iqrf::MqttMessaging",
  "instance": "MqttMessaging",
  "ClientId": "IqrfDpaMessaging",
  "TopicRequest": "Iqrf/DpaRequest",
  "TopicResponse": "Iqrf/DpaResponse",
  "acceptAsyncMsg": true,
  "RequiredInterfaces": [
    {
      "name": "shape::IMqttService",
      "target": {
        "BrokerAddr": "tcp://127.0.0.1:1883"
      }
    }
  ]
}
```
Note the section `"RequiredInterfaces": {}` follows general **shape** interface referencing principle. It says: "give me just a instance of required interface with target properties". It narrows interface referencing in case of more instances implementing the same interface. The section is not mandatory in case of just one **iqrf::MqttMessaging** and **shape::MqttService** pair. 

### shape__MqttService.json
```json
{
  "component": "shape::MqttService",
  "instance": "MqttService",
  "BrokerAddr": "tcp://127.0.0.1:1883",
  "Persistence": 1,
  "Qos": 1,
  "User": "",
  "Password": "",
  "EnabledSSL": false,
  "KeepAliveInterval": 20,
  "ConnectTimeout": 5,
  "MinReconnect": 1,
  "MaxReconnect": 64,
  "TrustStore": "server-ca.crt",
  "KeyStore": "client.pem",
  "PrivateKey": "client-privatekey.pem",
  "PrivateKeyPassword": "",
  "EnabledCipherSuites": "",
  "EnableServerCertAuth": true,
  "Buffered": true,
  "BufferSize": 1024
}
```

## Next steps
According requirement these improvements can be implemented:
- arbitrary topic support in **iqrf::MqttMessaging** both on publish and subscribe (maybe required soon)
- persistent buffering (to filesystem - it can survive possible deamon crash or long term connection outage)
- callback to handle QoS 1,2 delivery confirmation