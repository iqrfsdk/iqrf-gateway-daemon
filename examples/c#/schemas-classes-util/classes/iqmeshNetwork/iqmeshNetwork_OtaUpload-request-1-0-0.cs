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
    
        /// <summary>IQMESH Network management - Upload hex or iqrf file request.</summary>
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
        [System.Runtime.Serialization.EnumMember(Value = "iqmeshNetwork_OtaUpload")]
    
        IqmeshNetwork_OtaUpload = 0,
    
    
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
        private System.Collections.ObjectModel.ObservableCollection<int> _deviceAddr = new System.Collections.ObjectModel.ObservableCollection<int>();
        private string _fileName;
        private int _startMemAddr;
        private string _loadingAction;
    
        /// <summary>Device address(es) to write the hex or iqrf file.</summary>
        [Newtonsoft.Json.JsonProperty("deviceAddr", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<int> DeviceAddr
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
    
        /// <summary>Full name of file with source code to load.</summary>
        [Newtonsoft.Json.JsonProperty("fileName", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string FileName
        {
            get { return _fileName; }
            set 
            {
                if (_fileName != value)
                {
                    _fileName = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Start address on which will be the data saved into memory.</summary>
        [Newtonsoft.Json.JsonProperty("startMemAddr", Required = Newtonsoft.Json.Required.Always)]
        public int StartMemAddr
        {
            get { return _startMemAddr; }
            set 
            {
                if (_startMemAddr != value)
                {
                    _startMemAddr = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Loading action - WithoutCodeLoading, WithCodeLoading.</summary>
        [Newtonsoft.Json.JsonProperty("loadingAction", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string LoadingAction
        {
            get { return _loadingAction; }
            set 
            {
                if (_loadingAction != value)
                {
                    _loadingAction = value; 
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