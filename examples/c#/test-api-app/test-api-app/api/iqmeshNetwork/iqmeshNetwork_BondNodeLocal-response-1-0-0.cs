//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.56.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace iqmeshNetwork_BondNodeLocal_Response
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class IqmeshNetwork_BondNodeLocal_Response 
    {
        /// <summary>IQMESH Network management - Bond Node Local response.</summary>
        [Newtonsoft.Json.JsonProperty("mType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IqmeshNetwork_BondNodeLocal_ResponseMType MType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Data Data { get; set; } = new Data();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static IqmeshNetwork_BondNodeLocal_Response FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IqmeshNetwork_BondNodeLocal_Response>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum IqmeshNetwork_BondNodeLocal_ResponseMType
    {
        [System.Runtime.Serialization.EnumMember(Value = "iqmeshNetwork_BondNodeLocal")]
    
        IqmeshNetwork_BondNodeLocal = 0,
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
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
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Rsp 
    {
        /// <summary>Assigned address to the node.</summary>
        [Newtonsoft.Json.JsonProperty("assignedAddr", Required = Newtonsoft.Json.Required.Always)]
        public int AssignedAddr { get; set; }
    
        /// <summary>Number of nodes in the network.</summary>
        [Newtonsoft.Json.JsonProperty("nodesNr", Required = Newtonsoft.Json.Required.Always)]
        public int NodesNr { get; set; }
    
        /// <summary>Hardware profile identification.</summary>
        [Newtonsoft.Json.JsonProperty("hwpId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? HwpId { get; set; }
    
        /// <summary>Manufacture name.</summary>
        [Newtonsoft.Json.JsonProperty("manufacturer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Manufacturer { get; set; }
    
        /// <summary>Product name.</summary>
        [Newtonsoft.Json.JsonProperty("product", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Product { get; set; }
    
        /// <summary>Supported standards by the device.</summary>
        [Newtonsoft.Json.JsonProperty("standards", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Standards { get; set; }
    
        /// <summary>Returns Embedded peripheral OS - Read response.</summary>
        [Newtonsoft.Json.JsonProperty("osRead", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OsRead OsRead { get; set; }
    
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
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class OsRead 
    {
        /// <summary>TR Module ID.</summary>
        [Newtonsoft.Json.JsonProperty("mid", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Mid { get; set; }
    
        /// <summary>IQRF OS version.</summary>
        [Newtonsoft.Json.JsonProperty("osVersion", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string OsVersion { get; set; }
    
        /// <summary>See DPA guide.</summary>
        [Newtonsoft.Json.JsonProperty("trMcuType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public TrMcuType TrMcuType { get; set; } = new TrMcuType();
    
        /// <summary>IQRF OS build.</summary>
        [Newtonsoft.Json.JsonProperty("osBuild", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string OsBuild { get; set; }
    
        /// <summary>See lastRSSI at IQRF OS Reference Guide.</summary>
        [Newtonsoft.Json.JsonProperty("rssi", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Rssi { get; set; }
    
        /// <summary>Module supply voltage</summary>
        [Newtonsoft.Json.JsonProperty("supplyVoltage", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string SupplyVoltage { get; set; }
    
        /// <summary>See DPA guide.</summary>
        [Newtonsoft.Json.JsonProperty("flags", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Flags Flags { get; set; } = new Flags();
    
        /// <summary>See DPA guide.</summary>
        [Newtonsoft.Json.JsonProperty("slotLimits", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public SlotLimits SlotLimits { get; set; } = new SlotLimits();
    
        /// <summary>Individual Bonding Key.</summary>
        [Newtonsoft.Json.JsonProperty("ibk", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<int> Ibk { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static OsRead FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<OsRead>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class TrMcuType 
    {
        /// <summary>TR&McuType value.</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Value { get; set; }
    
        /// <summary>TR module type.</summary>
        [Newtonsoft.Json.JsonProperty("trType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TrType { get; set; }
    
        /// <summary>TR module is FCC certified.</summary>
        [Newtonsoft.Json.JsonProperty("fccCertified", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? FccCertified { get; set; }
    
        /// <summary>TR module MCU type.</summary>
        [Newtonsoft.Json.JsonProperty("mcuType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string McuType { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static TrMcuType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TrMcuType>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Flags 
    {
        /// <summary>Flags value.</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Value { get; set; }
    
        /// <summary>Flags.0 - Insufficient OsBuild.</summary>
        [Newtonsoft.Json.JsonProperty("insufficientOsBuild", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? InsufficientOsBuild { get; set; }
    
        /// <summary>Flags.1 - Interface type.</summary>
        [Newtonsoft.Json.JsonProperty("interface", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Interface { get; set; }
    
        /// <summary>Flags.2 - Custom DPA handler was detected.</summary>
        [Newtonsoft.Json.JsonProperty("dpaHandlerDetected", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? DpaHandlerDetected { get; set; }
    
        /// <summary>Flags.3 - Custom DPA Handler is not detected but enabled.</summary>
        [Newtonsoft.Json.JsonProperty("dpaHandlerNotDetectedButEnabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? DpaHandlerNotDetectedButEnabled { get; set; }
    
        /// <summary>Flags.4 - No interface supported.</summary>
        [Newtonsoft.Json.JsonProperty("noInterfaceSupported", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? NoInterfaceSupported { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Flags FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Flags>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SlotLimits 
    {
        /// <summary>Slot limits value.</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Value { get; set; }
    
        /// <summary>Shortest timeslot length in 10 ms units.</summary>
        [Newtonsoft.Json.JsonProperty("shortestTimeslot", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShortestTimeslot { get; set; }
    
        /// <summary>Longets timeslot length in 10 ms units.</summary>
        [Newtonsoft.Json.JsonProperty("longestTimeslot", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LongestTimeslot { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static SlotLimits FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SlotLimits>(data);
        }
    
    }
}