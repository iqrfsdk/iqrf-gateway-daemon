//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.56.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace iqrfEmbedOs_LoadCode_Request
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class IqrfEmbedOs_LoadCode_Request 
    {
        /// <summary>Embedded peripheral OS - Load Code request.</summary>
        [Newtonsoft.Json.JsonProperty("mType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IqrfEmbedOs_LoadCode_RequestMType MType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Data Data { get; set; } = new Data();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static IqrfEmbedOs_LoadCode_Request FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IqrfEmbedOs_LoadCode_Request>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum IqrfEmbedOs_LoadCode_RequestMType
    {
        [System.Runtime.Serialization.EnumMember(Value = "iqrfEmbedOs_LoadCode")]
    
        IqrfEmbedOs_LoadCode = 0,
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
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
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
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
        public Param Param { get; set; } = new Param();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Req FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Req>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Param 
    {
        /// <summary>Action flags.</summary>
        [Newtonsoft.Json.JsonProperty("flags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Flags { get; set; }
    
        /// <summary>A physical address at external EEPROM memory to load the code image from.</summary>
        [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Address { get; set; }
    
        /// <summary>Length of the code image in bytes at the external EEPROM.</summary>
        [Newtonsoft.Json.JsonProperty("length", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Length { get; set; }
    
        /// <summary>One’s complement Fletcher-16 checksum of the code image.</summary>
        [Newtonsoft.Json.JsonProperty("checkSum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CheckSum { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Param FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Param>(data);
        }
    
    }
}