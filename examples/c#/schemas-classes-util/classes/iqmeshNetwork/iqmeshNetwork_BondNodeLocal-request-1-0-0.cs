//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.56.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace iqmeshNetwork_BondNodeLocal_Request
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class iqmeshNetwork_BondNodeLocal_Request : System.ComponentModel.INotifyPropertyChanged
    {
        public IqmeshNetwork_BondNodeLocal_Request ( string msgId, int deviceAddr, int repeat, bool verbose )
        {
            this.Data.MsgId = msgId;
            this.Data.Req.DeviceAddr = deviceAddr;
            this.Data.Repeat = repeat;
            this.Data.ReturnVerbose = verbose;
        }

        private MType _mType;
        private Data _data = new Data();
    
        /// <summary>IQMESH Network management - Bond Node Local request.</summary>
        [Newtonsoft.Json.JsonProperty("mType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MType MType
        {
            get { return _mType; }
            set 
            {
                if (_mType != value)
                {
                    _mType = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Data Data
        {
            get { return _data; }
            set 
            {
                if (_data != value)
                {
                    _data = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static iqmeshNetwork_BondNodeLocal_Request FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<iqmeshNetwork_BondNodeLocal_Request>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum MType
    {
        [System.Runtime.Serialization.EnumMember(Value = "iqmeshNetwork_BondNodeLocal")]
    
        IqmeshNetwork_BondNodeLocal = 0,
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Data : System.ComponentModel.INotifyPropertyChanged
    {
        private string _msgId;
        private int _repeat = 1;
        private Req _req = new Req();
        private bool _returnVerbose;
    
        /// <summary>Message identification for binding request with response.</summary>
        [Newtonsoft.Json.JsonProperty("msgId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string MsgId
        {
            get { return _msgId; }
            set 
            {
                if (_msgId != value)
                {
                    _msgId = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Number of repetitions of DPA messages.</summary>
        [Newtonsoft.Json.JsonProperty("repeat", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Repeat
        {
            get { return _repeat; }
            set 
            {
                if (_repeat != value)
                {
                    _repeat = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("req", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Req Req
        {
            get { return _req; }
            set 
            {
                if (_req != value)
                {
                    _req = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Flag that includes additional parameters in the response.</summary>
        [Newtonsoft.Json.JsonProperty("returnVerbose", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool ReturnVerbose
        {
            get { return _returnVerbose; }
            set 
            {
                if (_returnVerbose != value)
                {
                    _returnVerbose = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Data FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Data>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Req : System.ComponentModel.INotifyPropertyChanged
    {
        private int _deviceAddr;
    
        /// <summary>Address to bond the device to.</summary>
        [Newtonsoft.Json.JsonProperty("deviceAddr", Required = Newtonsoft.Json.Required.Always)]
        public int DeviceAddr
        {
            get { return _deviceAddr; }
            set 
            {
                if (_deviceAddr != value)
                {
                    _deviceAddr = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Req FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Req>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
}