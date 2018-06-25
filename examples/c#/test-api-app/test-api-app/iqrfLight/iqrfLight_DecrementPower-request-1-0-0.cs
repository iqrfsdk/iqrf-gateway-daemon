//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.53.0 (Newtonsoft.Json v11.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace MyNamespace
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.53.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Anonymous : System.ComponentModel.INotifyPropertyChanged
    {
        private MType _mType;
        private Data _data = new Data();
    
        /// <summary>Standard peripheral Light - Decrement Power request.</summary>
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
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.53.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum MType
    {
        [System.Runtime.Serialization.EnumMember(Value = "iqrfLight_DecrementPower")]
        IqrfLight_DecrementPower = 0,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.53.0 (Newtonsoft.Json v11.0.0.0)")]
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
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.53.0 (Newtonsoft.Json v11.0.0.0)")]
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
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.53.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Param : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<Anonymous2> _lights = new System.Collections.ObjectModel.ObservableCollection<Anonymous2>();
    
        /// <summary>Array of objects with the following fields.</summary>
        [Newtonsoft.Json.JsonProperty("lights", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Anonymous2> Lights
        {
            get { return _lights; }
            set 
            {
                if (_lights != value)
                {
                    _lights = value; 
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
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.53.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Anonymous2 : System.ComponentModel.INotifyPropertyChanged
    {
        private int _index;
        private int _power;
        private int _time;
    
        /// <summary>Zero based index of the light to set.</summary>
        [Newtonsoft.Json.JsonProperty("index", Required = Newtonsoft.Json.Required.Always)]
        public int Index
        {
            get { return _index; }
            set 
            {
                if (_index != value)
                {
                    _index = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Increases power level.</summary>
        [Newtonsoft.Json.JsonProperty("power", Required = Newtonsoft.Json.Required.Always)]
        public int Power
        {
            get { return _power; }
            set 
            {
                if (_power != value)
                {
                    _power = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Time in seconds. Allowed values are <1;127> or 60*<1;127>.</summary>
        [Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Time
        {
            get { return _time; }
            set 
            {
                if (_time != value)
                {
                    _time = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Anonymous2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Anonymous2>(data);
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