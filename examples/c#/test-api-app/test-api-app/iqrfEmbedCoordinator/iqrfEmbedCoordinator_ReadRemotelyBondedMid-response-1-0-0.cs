//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.53.0 (Newtonsoft.Json v11.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace iqrfEmbedCoordinator_ReadRemotelyBondedMid_Response
{
#pragma warning disable // Disable all warnings

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.53.0 (Newtonsoft.Json v11.0.0.0)" )]
  public partial class IqrfEmbedCoordinator_ReadRemotelyBondedMid_Response : System.ComponentModel.INotifyPropertyChanged
  {
    private MType _mType;
    private Data _data = new Data();

    /// <summary>Embedded peripheral Coordinator - Read Remotely Bonded Module ID response.</summary>
    [Newtonsoft.Json.JsonProperty( "mType", Required = Newtonsoft.Json.Required.Always )]
    [System.ComponentModel.DataAnnotations.Required( AllowEmptyStrings = true )]
    [Newtonsoft.Json.JsonConverter( typeof( Newtonsoft.Json.Converters.StringEnumConverter ) )]
    public MType MType
    {
      get { return _mType; }
      set
      {
        if ( _mType != value )
        {
          _mType = value;
          RaisePropertyChanged();
        }
      }
    }

    [Newtonsoft.Json.JsonProperty( "data", Required = Newtonsoft.Json.Required.Always )]
    [System.ComponentModel.DataAnnotations.Required]
    public Data Data
    {
      get { return _data; }
      set
      {
        if ( _data != value )
        {
          _data = value;
          RaisePropertyChanged();
        }
      }
    }

    public string ToJson ()
    {
      return Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static IqrfEmbedCoordinator_ReadRemotelyBondedMid_Response FromJson ( string data )
    {
      return Newtonsoft.Json.JsonConvert.DeserializeObject<IqrfEmbedCoordinator_ReadRemotelyBondedMid_Response>( data );
    }

    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    protected virtual void RaisePropertyChanged ( [System.Runtime.CompilerServices.CallerMemberName] string propertyName = null )
    {
      var handler = PropertyChanged;
      if ( handler != null )
        handler( this, new System.ComponentModel.PropertyChangedEventArgs( propertyName ) );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.53.0 (Newtonsoft.Json v11.0.0.0)" )]
  public enum MType
  {
    [System.Runtime.Serialization.EnumMember( Value = "iqrfEmbedCoordinator_ReadRemotelyBondedMid" )]
    IqrfEmbedCoordinator_ReadRemotelyBondedMid = 0,

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.53.0 (Newtonsoft.Json v11.0.0.0)" )]
  public partial class Data : System.ComponentModel.INotifyPropertyChanged
  {
    private string _msgId;
    private int _timeout;
    private Rsp _rsp = new Rsp();
    private Raw _raw = new Raw();
    private string _insId;
    private int _status;
    private string _statusStr;

    /// <summary>Message identification for binding request with response.</summary>
    [Newtonsoft.Json.JsonProperty( "msgId", Required = Newtonsoft.Json.Required.Always )]
    [System.ComponentModel.DataAnnotations.Required( AllowEmptyStrings = true )]
    public string MsgId
    {
      get { return _msgId; }
      set
      {
        if ( _msgId != value )
        {
          _msgId = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>Timeout to wait for IQRF DPA response.</summary>
    [Newtonsoft.Json.JsonProperty( "timeout", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore )]
    public int Timeout
    {
      get { return _timeout; }
      set
      {
        if ( _timeout != value )
        {
          _timeout = value;
          RaisePropertyChanged();
        }
      }
    }

    [Newtonsoft.Json.JsonProperty( "rsp", Required = Newtonsoft.Json.Required.Always )]
    [System.ComponentModel.DataAnnotations.Required]
    public Rsp Rsp
    {
      get { return _rsp; }
      set
      {
        if ( _rsp != value )
        {
          _rsp = value;
          RaisePropertyChanged();
        }
      }
    }

    [Newtonsoft.Json.JsonProperty( "raw", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore )]
    public Raw Raw
    {
      get { return _raw; }
      set
      {
        if ( _raw != value )
        {
          _raw = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>IQRF GW daemon instance identification.</summary>
    [Newtonsoft.Json.JsonProperty( "insId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore )]
    public string InsId
    {
      get { return _insId; }
      set
      {
        if ( _insId != value )
        {
          _insId = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>IQRF GW daemon API (general or mType) status.</summary>
    [Newtonsoft.Json.JsonProperty( "status", Required = Newtonsoft.Json.Required.Always )]
    public int Status
    {
      get { return _status; }
      set
      {
        if ( _status != value )
        {
          _status = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>IQRF GW daemon API (general or mType) status in string form.</summary>
    [Newtonsoft.Json.JsonProperty( "statusStr", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore )]
    public string StatusStr
    {
      get { return _statusStr; }
      set
      {
        if ( _statusStr != value )
        {
          _statusStr = value;
          RaisePropertyChanged();
        }
      }
    }

    public string ToJson ()
    {
      return Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static Data FromJson ( string data )
    {
      return Newtonsoft.Json.JsonConvert.DeserializeObject<Data>( data );
    }

    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    protected virtual void RaisePropertyChanged ( [System.Runtime.CompilerServices.CallerMemberName] string propertyName = null )
    {
      var handler = PropertyChanged;
      if ( handler != null )
        handler( this, new System.ComponentModel.PropertyChangedEventArgs( propertyName ) );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.53.0 (Newtonsoft.Json v11.0.0.0)" )]
  public partial class Rsp : System.ComponentModel.INotifyPropertyChanged
  {
    private int _nAdr;
    private int _hwpId;
    private int _rCode;
    private int _dpaVal;
    private Result _result = new Result();
    private string _errorStr;

    /// <summary>Network device address.</summary>
    [Newtonsoft.Json.JsonProperty( "nAdr", Required = Newtonsoft.Json.Required.Always )]
    public int NAdr
    {
      get { return _nAdr; }
      set
      {
        if ( _nAdr != value )
        {
          _nAdr = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>Hardware profile identification.</summary>
    [Newtonsoft.Json.JsonProperty( "hwpId", Required = Newtonsoft.Json.Required.Always )]
    public int HwpId
    {
      get { return _hwpId; }
      set
      {
        if ( _hwpId != value )
        {
          _hwpId = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>DPA error code.</summary>
    [Newtonsoft.Json.JsonProperty( "rCode", Required = Newtonsoft.Json.Required.Always )]
    public int RCode
    {
      get { return _rCode; }
      set
      {
        if ( _rCode != value )
        {
          _rCode = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>DPA value.</summary>
    [Newtonsoft.Json.JsonProperty( "dpaVal", Required = Newtonsoft.Json.Required.Always )]
    public int DpaVal
    {
      get { return _dpaVal; }
      set
      {
        if ( _dpaVal != value )
        {
          _dpaVal = value;
          RaisePropertyChanged();
        }
      }
    }

    [Newtonsoft.Json.JsonProperty( "result", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore )]
    public Result Result
    {
      get { return _result; }
      set
      {
        if ( _result != value )
        {
          _result = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>Error description from JS drivers.</summary>
    [Newtonsoft.Json.JsonProperty( "errorStr", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore )]
    public string ErrorStr
    {
      get { return _errorStr; }
      set
      {
        if ( _errorStr != value )
        {
          _errorStr = value;
          RaisePropertyChanged();
        }
      }
    }

    public string ToJson ()
    {
      return Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static Rsp FromJson ( string data )
    {
      return Newtonsoft.Json.JsonConvert.DeserializeObject<Rsp>( data );
    }

    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    protected virtual void RaisePropertyChanged ( [System.Runtime.CompilerServices.CallerMemberName] string propertyName = null )
    {
      var handler = PropertyChanged;
      if ( handler != null )
        handler( this, new System.ComponentModel.PropertyChangedEventArgs( propertyName ) );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.53.0 (Newtonsoft.Json v11.0.0.0)" )]
  public partial class Raw : System.ComponentModel.INotifyPropertyChanged
  {
    private string _request;
    private string _requestTs;
    private string _confirmation;
    private string _confirmationTs;
    private string _response;
    private string _responseTs;

    /// <summary>Binary buffer with DPA request.</summary>
    [Newtonsoft.Json.JsonProperty( "request", Required = Newtonsoft.Json.Required.Always )]
    [System.ComponentModel.DataAnnotations.Required( AllowEmptyStrings = true )]
    public string Request
    {
      get { return _request; }
      set
      {
        if ( _request != value )
        {
          _request = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>YYYY-MM-DDTHH:MM:SS.MS</summary>
    [Newtonsoft.Json.JsonProperty( "requestTs", Required = Newtonsoft.Json.Required.Always )]
    [System.ComponentModel.DataAnnotations.Required( AllowEmptyStrings = true )]
    public string RequestTs
    {
      get { return _requestTs; }
      set
      {
        if ( _requestTs != value )
        {
          _requestTs = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>Binary buffer with DPA confirmation.</summary>
    [Newtonsoft.Json.JsonProperty( "confirmation", Required = Newtonsoft.Json.Required.Always )]
    [System.ComponentModel.DataAnnotations.Required( AllowEmptyStrings = true )]
    public string Confirmation
    {
      get { return _confirmation; }
      set
      {
        if ( _confirmation != value )
        {
          _confirmation = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>YYYY-MM-DDTHH:MM:SS.MS</summary>
    [Newtonsoft.Json.JsonProperty( "confirmationTs", Required = Newtonsoft.Json.Required.Always )]
    [System.ComponentModel.DataAnnotations.Required( AllowEmptyStrings = true )]
    public string ConfirmationTs
    {
      get { return _confirmationTs; }
      set
      {
        if ( _confirmationTs != value )
        {
          _confirmationTs = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>Binary buffer with DPA response.</summary>
    [Newtonsoft.Json.JsonProperty( "response", Required = Newtonsoft.Json.Required.Always )]
    [System.ComponentModel.DataAnnotations.Required( AllowEmptyStrings = true )]
    public string Response
    {
      get { return _response; }
      set
      {
        if ( _response != value )
        {
          _response = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>YYYY-MM-DDTHH:MM:SS.MS</summary>
    [Newtonsoft.Json.JsonProperty( "responseTs", Required = Newtonsoft.Json.Required.Always )]
    [System.ComponentModel.DataAnnotations.Required( AllowEmptyStrings = true )]
    public string ResponseTs
    {
      get { return _responseTs; }
      set
      {
        if ( _responseTs != value )
        {
          _responseTs = value;
          RaisePropertyChanged();
        }
      }
    }

    public string ToJson ()
    {
      return Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static Raw FromJson ( string data )
    {
      return Newtonsoft.Json.JsonConvert.DeserializeObject<Raw>( data );
    }

    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    protected virtual void RaisePropertyChanged ( [System.Runtime.CompilerServices.CallerMemberName] string propertyName = null )
    {
      var handler = PropertyChanged;
      if ( handler != null )
        handler( this, new System.ComponentModel.PropertyChangedEventArgs( propertyName ) );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.53.0 (Newtonsoft.Json v11.0.0.0)" )]
  public partial class Result : System.ComponentModel.INotifyPropertyChanged
  {
    private System.Collections.ObjectModel.ObservableCollection<Anonymous2> _prebondedNodes = new System.Collections.ObjectModel.ObservableCollection<Anonymous2>();

    /// <summary>Js driver response structure for given a command.</summary>
    [Newtonsoft.Json.JsonProperty( "prebondedNodes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore )]
    public System.Collections.ObjectModel.ObservableCollection<Anonymous2> PrebondedNodes
    {
      get { return _prebondedNodes; }
      set
      {
        if ( _prebondedNodes != value )
        {
          _prebondedNodes = value;
          RaisePropertyChanged();
        }
      }
    }

    public string ToJson ()
    {
      return Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static Result FromJson ( string data )
    {
      return Newtonsoft.Json.JsonConvert.DeserializeObject<Result>( data );
    }

    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    protected virtual void RaisePropertyChanged ( [System.Runtime.CompilerServices.CallerMemberName] string propertyName = null )
    {
      var handler = PropertyChanged;
      if ( handler != null )
        handler( this, new System.ComponentModel.PropertyChangedEventArgs( propertyName ) );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.53.0 (Newtonsoft.Json v11.0.0.0)" )]
  public partial class Anonymous2 : System.ComponentModel.INotifyPropertyChanged
  {
    private int _mid;
    private System.Collections.ObjectModel.ObservableCollection<int> _userData = new System.Collections.ObjectModel.ObservableCollection<int>();

    /// <summary>Module ID of the remotely pre-bonded node. It can be used later for bonding authorization later.</summary>
    [Newtonsoft.Json.JsonProperty( "mid", Required = Newtonsoft.Json.Required.Always )]
    public int Mid
    {
      get { return _mid; }
      set
      {
        if ( _mid != value )
        {
          _mid = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>Optional bonding user data specified at Reset Custom DPA Handler event.</summary>
    [Newtonsoft.Json.JsonProperty( "userData", Required = Newtonsoft.Json.Required.Always )]
    [System.ComponentModel.DataAnnotations.Required]
    public System.Collections.ObjectModel.ObservableCollection<int> UserData
    {
      get { return _userData; }
      set
      {
        if ( _userData != value )
        {
          _userData = value;
          RaisePropertyChanged();
        }
      }
    }

    public string ToJson ()
    {
      return Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static Anonymous2 FromJson ( string data )
    {
      return Newtonsoft.Json.JsonConvert.DeserializeObject<Anonymous2>( data );
    }

    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    protected virtual void RaisePropertyChanged ( [System.Runtime.CompilerServices.CallerMemberName] string propertyName = null )
    {
      var handler = PropertyChanged;
      if ( handler != null )
        handler( this, new System.ComponentModel.PropertyChangedEventArgs( propertyName ) );
    }
  }
}