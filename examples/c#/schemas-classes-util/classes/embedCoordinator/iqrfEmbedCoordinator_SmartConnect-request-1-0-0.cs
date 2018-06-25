//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.56.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace MyNamespace
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Anonymous : System.ComponentModel.INotifyPropertyChanged
    {
        private MType _mType;
        private Data _data = new Data();
    
        /// <summary>Embedded peripheral Coordinator - Smart Connect request.</summary>
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
        
        public static Anonymous FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Anonymous>(data);
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
        [System.Runtime.Serialization.EnumMember(Value = "iqrfEmbedCoordinator_SmartConnect")]
    
        IqrfEmbedCoordinator_SmartConnect = 0,
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Data : System.ComponentModel.INotifyPropertyChanged
    {
        private string _msgId;
        private int _timeout;
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
    
        /// <summary>Timeout to wait for IQRF DPA response.</summary>
        [Newtonsoft.Json.JsonProperty("timeout", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Timeout
        {
            get { return _timeout; }
            set 
            {
                if (_timeout != value)
                {
                    _timeout = value; 
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
        private int _nAdr;
        private int _hwpId;
        private Param _param = new Param();
    
        /// <summary>Network device address.</summary>
        [Newtonsoft.Json.JsonProperty("nAdr", Required = Newtonsoft.Json.Required.Always)]
        public int NAdr
        {
            get { return _nAdr; }
            set 
            {
                if (_nAdr != value)
                {
                    _nAdr = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Hardware profile identification.</summary>
        [Newtonsoft.Json.JsonProperty("hwpId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int HwpId
        {
            get { return _hwpId; }
            set 
            {
                if (_hwpId != value)
                {
                    _hwpId = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        [Newtonsoft.Json.JsonProperty("param", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Param Param
        {
            get { return _param; }
            set 
            {
                if (_param != value)
                {
                    _param = value; 
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
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.56.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Param : System.ComponentModel.INotifyPropertyChanged
    {
        private int _reqAddr;
        private int _bondingTestRetries;
        private System.Collections.ObjectModel.ObservableCollection<int> _ibk = new System.Collections.ObjectModel.ObservableCollection<int>();
        private System.Collections.ObjectModel.ObservableCollection<int> _mid = new System.Collections.ObjectModel.ObservableCollection<int>();
        private int _bondingChannel;
        private int _virtualDeviceAddress;
        private System.Collections.ObjectModel.ObservableCollection<int> _userData = new System.Collections.ObjectModel.ObservableCollection<int>();
    
        /// <summary>A requested address for the bonded node. The address must not be used (bonded) yet. If this parameter equals to 0, then the 1st free address is assigned to the node.</summary>
        [Newtonsoft.Json.JsonProperty("reqAddr", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ReqAddr
        {
            get { return _reqAddr; }
            set 
            {
                if (_reqAddr != value)
                {
                    _reqAddr = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Maximum number of FRCs used to test whether the Node was successfully bonded. If value is 0, then no test is performed and the command always succeeds.</summary>
        [Newtonsoft.Json.JsonProperty("bondingTestRetries", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int BondingTestRetries
        {
            get { return _bondingTestRetries; }
            set 
            {
                if (_bondingTestRetries != value)
                {
                    _bondingTestRetries = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Individual Bonding Key of the Node to bond.</summary>
        [Newtonsoft.Json.JsonProperty("ibk", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<int> Ibk
        {
            get { return _ibk; }
            set 
            {
                if (_ibk != value)
                {
                    _ibk = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>MID of the Node to bond.</summary>
        [Newtonsoft.Json.JsonProperty("mid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<int> Mid
        {
            get { return _mid; }
            set 
            {
                if (_mid != value)
                {
                    _mid = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>RF channel used for bonding.</summary>
        [Newtonsoft.Json.JsonProperty("bondingChannel", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int BondingChannel
        {
            get { return _bondingChannel; }
            set 
            {
                if (_bondingChannel != value)
                {
                    _bondingChannel = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Virtual device address. Must equal to 0xFF if not used.</summary>
        [Newtonsoft.Json.JsonProperty("virtualDeviceAddress", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int VirtualDeviceAddress
        {
            get { return _virtualDeviceAddress; }
            set 
            {
                if (_virtualDeviceAddress != value)
                {
                    _virtualDeviceAddress = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Optional data passed to the bonded node.</summary>
        [Newtonsoft.Json.JsonProperty("userData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<int> UserData
        {
            get { return _userData; }
            set 
            {
                if (_userData != value)
                {
                    _userData = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Param FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Param>(data);
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