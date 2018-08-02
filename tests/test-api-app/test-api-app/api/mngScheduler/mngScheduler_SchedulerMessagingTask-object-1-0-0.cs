//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.56.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace mngScheduler_SchedulerMessagingTask
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class MngScheduler_SchedulerMessagingTask 
    {
        /// <summary>Scheduler messaging task.</summary>
        [Newtonsoft.Json.JsonProperty("messaging", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MngScheduler_SchedulerMessagingTaskMessaging Messaging { get; set; }
    
        /// <summary>Particular JSON request with supported mType type.</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public object Message { get; set; } = new object();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static MngScheduler_SchedulerMessagingTask FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MngScheduler_SchedulerMessagingTask>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum MngScheduler_SchedulerMessagingTaskMessaging
    {
        [System.Runtime.Serialization.EnumMember(Value = "WebsocketMessaging")]
    
        WebsocketMessaging = 0,
    
    
        [System.Runtime.Serialization.EnumMember(Value = "MqttMessaging")]
    
        MqttMessaging = 1,
    
    
        [System.Runtime.Serialization.EnumMember(Value = "MqMessaging")]
    
        MqMessaging = 2,
    
    
    }
}