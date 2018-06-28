//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.57.0 (Newtonsoft.Json v11.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace iqrfEmbedCoordinator_ReadRemotelyBondedMid_Request
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.57.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class IqrfEmbedCoordinator_ReadRemotelyBondedMid_Request 
    {
        /// <summary>Embedded peripheral Coordinator - Read Remotely Bonded Module ID request.</summary>
        [Newtonsoft.Json.JsonProperty("mType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IqrfEmbedCoordinator_ReadRemotelyBondedMid_RequestMType MType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Data Data { get; set; } = new Data();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static IqrfEmbedCoordinator_ReadRemotelyBondedMid_Request FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IqrfEmbedCoordinator_ReadRemotelyBondedMid_Request>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.57.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum IqrfEmbedCoordinator_ReadRemotelyBondedMid_RequestMType
    {
        [System.Runtime.Serialization.EnumMember(Value = "iqrfEmbedCoordinator_ReadRemotelyBondedMid")]
    
        IqrfEmbedCoordinator_ReadRemotelyBondedMid = 0,
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.57.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Data 
    {
        /// <summary>Message identification for binding request with response.</summary>
        [Newtonsoft.Json.JsonProperty("msgId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MsgId { get; set; }
    
        /// <summary>Timeout to wait for IQRF DPA response.</summary>
        [Newtonsoft.Json.JsonProperty("timeout", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Timeout { get; set; }
    
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
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.57.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Req 
    {
        /// <summary>Network device address.</summary>
        [Newtonsoft.Json.JsonProperty("nAdr", Required = Newtonsoft.Json.Required.Always)]
        public int NAdr { get; set; }
    
        /// <summary>Hardware profile identification.</summary>
        [Newtonsoft.Json.JsonProperty("hwpId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? HwpId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("param", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public object Param { get; set; } = new object();
    
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