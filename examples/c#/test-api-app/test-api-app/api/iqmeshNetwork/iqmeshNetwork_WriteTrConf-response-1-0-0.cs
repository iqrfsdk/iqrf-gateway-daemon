//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.57.0 (Newtonsoft.Json v11.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace iqmeshNetwork_WriteTrConf_Response
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.57.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class IqmeshNetwork_WriteTrConf_Response 
    {
        /// <summary>IQMESH Network management - Write TR configuration response.</summary>
        [Newtonsoft.Json.JsonProperty("mType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IqmeshNetwork_WriteTrConf_ResponseMType MType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Data Data { get; set; } = new Data();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static IqmeshNetwork_WriteTrConf_Response FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IqmeshNetwork_WriteTrConf_Response>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.57.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum IqmeshNetwork_WriteTrConf_ResponseMType
    {
        [System.Runtime.Serialization.EnumMember(Value = "iqmeshNetwork_WriteTrConf")]
    
        IqmeshNetwork_WriteTrConf = 0,
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.57.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Data 
    {
        /// <summary>Message identification for binding request with response.</summary>
        [Newtonsoft.Json.JsonProperty("msgId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MsgId { get; set; }
    
        /// <summary>Returns following values, see its description.</summary>
        [Newtonsoft.Json.JsonProperty("rsp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Rsp Rsp { get; set; }
    
        /// <summary>Returns array of objects req-cnf-rsp, see its description.</summary>
        [Newtonsoft.Json.JsonProperty("raw", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Anonymous> Raw { get; set; }
    
        /// <summary>IQRF GW daemon instance identification.</summary>
        [Newtonsoft.Json.JsonProperty("insId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InsId { get; set; }
    
        /// <summary>IQRF GW daemon API (general or mType) status.</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        public int Status { get; set; }
    
        /// <summary>IQRF GW daemon API (general or mType) status in string form.</summary>
        [Newtonsoft.Json.JsonProperty("statusStr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusStr { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Data FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Data>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.57.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Rsp 
    {
        /// <summary>Device address to write the configuration to. Broadcast address is also allowed.</summary>
        [Newtonsoft.Json.JsonProperty("deviceAddr", Required = Newtonsoft.Json.Required.Always)]
        public int DeviceAddr { get; set; }
    
        /// <summary>If sets, then configuration has been successfully written.</summary>
        [Newtonsoft.Json.JsonProperty("writeSuccess", Required = Newtonsoft.Json.Required.Always)]
        public bool WriteSuccess { get; set; }
    
        /// <summary>Restart required, but not done yet.</summary>
        [Newtonsoft.Json.JsonProperty("restartNeeded", Required = Newtonsoft.Json.Required.Always)]
        public bool RestartNeeded { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Rsp FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Rsp>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.57.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Anonymous 
    {
        /// <summary>Binary buffer with DPA request.</summary>
        [Newtonsoft.Json.JsonProperty("request", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Request { get; set; }
    
        /// <summary>YYYY-MM-DDTHH:MM:SS.MS</summary>
        [Newtonsoft.Json.JsonProperty("requestTs", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string RequestTs { get; set; }
    
        /// <summary>Binary buffer with DPA confirmation.</summary>
        [Newtonsoft.Json.JsonProperty("confirmation", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Confirmation { get; set; }
    
        /// <summary>YYYY-MM-DDTHH:MM:SS.MS</summary>
        [Newtonsoft.Json.JsonProperty("confirmationTs", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ConfirmationTs { get; set; }
    
        /// <summary>Binary buffer with DPA response.</summary>
        [Newtonsoft.Json.JsonProperty("response", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Response { get; set; }
    
        /// <summary>YYYY-MM-DDTHH:MM:SS.MS</summary>
        [Newtonsoft.Json.JsonProperty("responseTs", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ResponseTs { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Anonymous FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Anonymous>(data);
        }
    
    }
}