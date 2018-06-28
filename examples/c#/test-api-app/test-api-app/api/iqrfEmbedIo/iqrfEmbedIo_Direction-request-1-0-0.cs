//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.57.0 (Newtonsoft.Json v11.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace iqrfEmbedIo_Direction_Request
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.57.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class IqrfEmbedIo_Direction_Request 
    {
        /// <summary>Embedded peripheral IO - Direction request.</summary>
        [Newtonsoft.Json.JsonProperty("mType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IqrfEmbedIo_Direction_RequestMType MType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Data Data { get; set; } = new Data();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static IqrfEmbedIo_Direction_Request FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IqrfEmbedIo_Direction_Request>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.57.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum IqrfEmbedIo_Direction_RequestMType
    {
        [System.Runtime.Serialization.EnumMember(Value = "iqrfEmbedIo_Direction")]
    
        IqrfEmbedIo_Direction = 0,
    
    
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
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.57.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Param 
    {
        /// <summary>Array of ports.</summary>
        [Newtonsoft.Json.JsonProperty("ports", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Anonymous> Ports { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Param FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Param>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.57.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Anonymous 
    {
        /// <summary> Specifies port to setup a direction.</summary>
        [Newtonsoft.Json.JsonProperty("port", Required = Newtonsoft.Json.Required.Always)]
        public int Port { get; set; }
    
        /// <summary>Masks pins of the port.</summary>
        [Newtonsoft.Json.JsonProperty("mask", Required = Newtonsoft.Json.Required.Always)]
        public int Mask { get; set; }
    
        /// <summary>Actual direction.</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
        public int Value { get; set; }
    
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