//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.56.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace iqmeshNetwork_ReadTrConf_Request
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class IqmeshNetwork_ReadTrConf_Request 
    {
        /// <summary>IQMESH Network management - Read TR configuration request.</summary>
        [Newtonsoft.Json.JsonProperty("mType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IqmeshNetwork_ReadTrConf_RequestMType MType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Data Data { get; set; } = new Data();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static IqmeshNetwork_ReadTrConf_Request FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IqmeshNetwork_ReadTrConf_Request>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum IqmeshNetwork_ReadTrConf_RequestMType
    {
        [System.Runtime.Serialization.EnumMember(Value = "iqmeshNetwork_ReadTrConf")]
    
        IqmeshNetwork_ReadTrConf = 0,
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Data 
    {
        /// <summary>Message identification for binding request with response.</summary>
        [Newtonsoft.Json.JsonProperty("msgId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MsgId { get; set; }
    
        /// <summary>Number of repetitions of DPA messages.</summary>
        [Newtonsoft.Json.JsonProperty("repeat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Repeat { get; set; } = 1;
    
        [Newtonsoft.Json.JsonProperty("req", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Req Req { get; set; } = new Req();
    
        /// <summary>Flag that includes additional parameters in the response.</summary>
        [Newtonsoft.Json.JsonProperty("returnVerbose", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ReturnVerbose { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Data FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Data>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Req 
    {
        /// <summary>Device address to read the configuration from.</summary>
        [Newtonsoft.Json.JsonProperty("deviceAddr", Required = Newtonsoft.Json.Required.Always)]
        public int DeviceAddr { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Req FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Req>(data);
        }
    
    }
}