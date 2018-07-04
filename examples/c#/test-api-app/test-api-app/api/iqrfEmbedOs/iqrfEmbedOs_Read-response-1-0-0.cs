//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.56.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace iqrfEmbedOs_Read_Response
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class IqrfEmbedOs_Read_Response 
    {
        /// <summary>Embedded peripheral OS - Read response.</summary>
        [Newtonsoft.Json.JsonProperty("mType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IqrfEmbedOs_Read_ResponseMType MType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Data Data { get; set; } = new Data();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static IqrfEmbedOs_Read_Response FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IqrfEmbedOs_Read_Response>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum IqrfEmbedOs_Read_ResponseMType
    {
        [System.Runtime.Serialization.EnumMember(Value = "iqrfEmbedOs_Read")]
    
        IqrfEmbedOs_Read = 0,
    
    
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
    
        [Newtonsoft.Json.JsonProperty("rsp", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Rsp Rsp { get; set; } = new Rsp();
    
        [Newtonsoft.Json.JsonProperty("raw", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Raw Raw { get; set; }
    
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
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Rsp 
    {
        /// <summary>Network device address.</summary>
        [Newtonsoft.Json.JsonProperty("nAdr", Required = Newtonsoft.Json.Required.Always)]
        public int NAdr { get; set; }
    
        /// <summary>Hardware profile identification.</summary>
        [Newtonsoft.Json.JsonProperty("hwpId", Required = Newtonsoft.Json.Required.Always)]
        public int HwpId { get; set; }
    
        /// <summary>DPA error code.</summary>
        [Newtonsoft.Json.JsonProperty("rCode", Required = Newtonsoft.Json.Required.Always)]
        public int RCode { get; set; }
    
        /// <summary>DPA value.</summary>
        [Newtonsoft.Json.JsonProperty("dpaVal", Required = Newtonsoft.Json.Required.Always)]
        public int DpaVal { get; set; }
    
        [Newtonsoft.Json.JsonProperty("result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Result Result { get; set; }
    
        /// <summary>Error description from JS drivers.</summary>
        [Newtonsoft.Json.JsonProperty("errorStr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ErrorStr { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Rsp FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Rsp>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Raw 
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
        
        public static Raw FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Raw>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Result 
    {
        /// <summary>TR Module ID.</summary>
        [Newtonsoft.Json.JsonProperty("mid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Mid { get; set; }
    
        /// <summary>IQRF OS version.</summary>
        [Newtonsoft.Json.JsonProperty("osVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? OsVersion { get; set; }
    
        /// <summary>TR MCU type.</summary>
        [Newtonsoft.Json.JsonProperty("trMcuType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TrMcuType { get; set; }
    
        /// <summary>IQRF OS build.</summary>
        [Newtonsoft.Json.JsonProperty("osBuild", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? OsBuild { get; set; }
    
        /// <summary>See lastRSSI at IQRF OS Reference Guide.</summary>
        [Newtonsoft.Json.JsonProperty("rssi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Rssi { get; set; }
    
        /// <summary>Module supply voltage, contains real voltage value.</summary>
        [Newtonsoft.Json.JsonProperty("supplyVoltage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SupplyVoltage { get; set; }
    
        /// <summary>See DPA guide.</summary>
        [Newtonsoft.Json.JsonProperty("flags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Flags { get; set; }
    
        /// <summary>See DPA guide.</summary>
        [Newtonsoft.Json.JsonProperty("slotLimits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SlotLimits { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Result FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Result>(data);
        }
    
    }
}