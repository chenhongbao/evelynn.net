// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Rsp.UserLogin.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Evelynn.Base.Proto.Response {

  /// <summary>Holder for reflection information generated from Rsp.UserLogin.proto</summary>
  public static partial class RspUserLoginReflection {

    #region Descriptor
    /// <summary>File descriptor for Rsp.UserLogin.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RspUserLoginReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNSc3AuVXNlckxvZ2luLnByb3RvEgNyc3AijAIKDlVzZXJMb2dpbkZpZWxk",
            "EhMKC3RyYWRpbmdfZGF5GAEgASgJEhIKCmxvZ2luX3RpbWUYAiABKAkSEQoJ",
            "YnJva2VyX2lkGAMgASgJEg8KB3VzZXJfaWQYBCABKAkSEwoLc3lzdGVtX25h",
            "bWUYBSABKAkSEAoIZnJvbnRfaWQYBiABKAUSEgoKc2Vzc2lvbl9pZBgHIAEo",
            "BRIVCg1tYXhfb3JkZXJfcmVmGAggASgJEhEKCXNoZmVfdGltZRgJIAEoCRIQ",
            "CghkY2VfdGltZRgKIAEoCRIRCgljemNlX3RpbWUYCyABKAkSEQoJZmZleF90",
            "aW1lGAwgASgJEhAKCGluZV90aW1lGA0gASgJQk0KFWlvLmV2ZWx5bm4uYmFz",
            "ZS5wcm90b0IWUnNwVXNlckxvZ2luRmllbGRQcm90b6oCG0V2ZWx5bm4uQmFz",
            "ZS5Qcm90by5SZXNwb25zZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Evelynn.Base.Proto.Response.UserLoginField), global::Evelynn.Base.Proto.Response.UserLoginField.Parser, new[]{ "TradingDay", "LoginTime", "BrokerId", "UserId", "SystemName", "FrontId", "SessionId", "MaxOrderRef", "ShfeTime", "DceTime", "CzceTime", "FfexTime", "IneTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UserLoginField : pb::IMessage<UserLoginField>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserLoginField> _parser = new pb::MessageParser<UserLoginField>(() => new UserLoginField());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserLoginField> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Evelynn.Base.Proto.Response.RspUserLoginReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLoginField() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLoginField(UserLoginField other) : this() {
      tradingDay_ = other.tradingDay_;
      loginTime_ = other.loginTime_;
      brokerId_ = other.brokerId_;
      userId_ = other.userId_;
      systemName_ = other.systemName_;
      frontId_ = other.frontId_;
      sessionId_ = other.sessionId_;
      maxOrderRef_ = other.maxOrderRef_;
      shfeTime_ = other.shfeTime_;
      dceTime_ = other.dceTime_;
      czceTime_ = other.czceTime_;
      ffexTime_ = other.ffexTime_;
      ineTime_ = other.ineTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLoginField Clone() {
      return new UserLoginField(this);
    }

    /// <summary>Field number for the "trading_day" field.</summary>
    public const int TradingDayFieldNumber = 1;
    private string tradingDay_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TradingDay {
      get { return tradingDay_; }
      set {
        tradingDay_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "login_time" field.</summary>
    public const int LoginTimeFieldNumber = 2;
    private string loginTime_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LoginTime {
      get { return loginTime_; }
      set {
        loginTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "broker_id" field.</summary>
    public const int BrokerIdFieldNumber = 3;
    private string brokerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BrokerId {
      get { return brokerId_; }
      set {
        brokerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 4;
    private string userId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "system_name" field.</summary>
    public const int SystemNameFieldNumber = 5;
    private string systemName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SystemName {
      get { return systemName_; }
      set {
        systemName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "front_id" field.</summary>
    public const int FrontIdFieldNumber = 6;
    private int frontId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FrontId {
      get { return frontId_; }
      set {
        frontId_ = value;
      }
    }

    /// <summary>Field number for the "session_id" field.</summary>
    public const int SessionIdFieldNumber = 7;
    private int sessionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SessionId {
      get { return sessionId_; }
      set {
        sessionId_ = value;
      }
    }

    /// <summary>Field number for the "max_order_ref" field.</summary>
    public const int MaxOrderRefFieldNumber = 8;
    private string maxOrderRef_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MaxOrderRef {
      get { return maxOrderRef_; }
      set {
        maxOrderRef_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "shfe_time" field.</summary>
    public const int ShfeTimeFieldNumber = 9;
    private string shfeTime_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ShfeTime {
      get { return shfeTime_; }
      set {
        shfeTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "dce_time" field.</summary>
    public const int DceTimeFieldNumber = 10;
    private string dceTime_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DceTime {
      get { return dceTime_; }
      set {
        dceTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "czce_time" field.</summary>
    public const int CzceTimeFieldNumber = 11;
    private string czceTime_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CzceTime {
      get { return czceTime_; }
      set {
        czceTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ffex_time" field.</summary>
    public const int FfexTimeFieldNumber = 12;
    private string ffexTime_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FfexTime {
      get { return ffexTime_; }
      set {
        ffexTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ine_time" field.</summary>
    public const int IneTimeFieldNumber = 13;
    private string ineTime_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string IneTime {
      get { return ineTime_; }
      set {
        ineTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserLoginField);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserLoginField other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TradingDay != other.TradingDay) return false;
      if (LoginTime != other.LoginTime) return false;
      if (BrokerId != other.BrokerId) return false;
      if (UserId != other.UserId) return false;
      if (SystemName != other.SystemName) return false;
      if (FrontId != other.FrontId) return false;
      if (SessionId != other.SessionId) return false;
      if (MaxOrderRef != other.MaxOrderRef) return false;
      if (ShfeTime != other.ShfeTime) return false;
      if (DceTime != other.DceTime) return false;
      if (CzceTime != other.CzceTime) return false;
      if (FfexTime != other.FfexTime) return false;
      if (IneTime != other.IneTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TradingDay.Length != 0) hash ^= TradingDay.GetHashCode();
      if (LoginTime.Length != 0) hash ^= LoginTime.GetHashCode();
      if (BrokerId.Length != 0) hash ^= BrokerId.GetHashCode();
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      if (SystemName.Length != 0) hash ^= SystemName.GetHashCode();
      if (FrontId != 0) hash ^= FrontId.GetHashCode();
      if (SessionId != 0) hash ^= SessionId.GetHashCode();
      if (MaxOrderRef.Length != 0) hash ^= MaxOrderRef.GetHashCode();
      if (ShfeTime.Length != 0) hash ^= ShfeTime.GetHashCode();
      if (DceTime.Length != 0) hash ^= DceTime.GetHashCode();
      if (CzceTime.Length != 0) hash ^= CzceTime.GetHashCode();
      if (FfexTime.Length != 0) hash ^= FfexTime.GetHashCode();
      if (IneTime.Length != 0) hash ^= IneTime.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (TradingDay.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TradingDay);
      }
      if (LoginTime.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LoginTime);
      }
      if (BrokerId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(BrokerId);
      }
      if (UserId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(UserId);
      }
      if (SystemName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(SystemName);
      }
      if (FrontId != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(FrontId);
      }
      if (SessionId != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(SessionId);
      }
      if (MaxOrderRef.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(MaxOrderRef);
      }
      if (ShfeTime.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(ShfeTime);
      }
      if (DceTime.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(DceTime);
      }
      if (CzceTime.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(CzceTime);
      }
      if (FfexTime.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(FfexTime);
      }
      if (IneTime.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(IneTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (TradingDay.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TradingDay);
      }
      if (LoginTime.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LoginTime);
      }
      if (BrokerId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(BrokerId);
      }
      if (UserId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(UserId);
      }
      if (SystemName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(SystemName);
      }
      if (FrontId != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(FrontId);
      }
      if (SessionId != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(SessionId);
      }
      if (MaxOrderRef.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(MaxOrderRef);
      }
      if (ShfeTime.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(ShfeTime);
      }
      if (DceTime.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(DceTime);
      }
      if (CzceTime.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(CzceTime);
      }
      if (FfexTime.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(FfexTime);
      }
      if (IneTime.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(IneTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TradingDay.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TradingDay);
      }
      if (LoginTime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LoginTime);
      }
      if (BrokerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BrokerId);
      }
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      if (SystemName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SystemName);
      }
      if (FrontId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FrontId);
      }
      if (SessionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SessionId);
      }
      if (MaxOrderRef.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MaxOrderRef);
      }
      if (ShfeTime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ShfeTime);
      }
      if (DceTime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DceTime);
      }
      if (CzceTime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CzceTime);
      }
      if (FfexTime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FfexTime);
      }
      if (IneTime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IneTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserLoginField other) {
      if (other == null) {
        return;
      }
      if (other.TradingDay.Length != 0) {
        TradingDay = other.TradingDay;
      }
      if (other.LoginTime.Length != 0) {
        LoginTime = other.LoginTime;
      }
      if (other.BrokerId.Length != 0) {
        BrokerId = other.BrokerId;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
      if (other.SystemName.Length != 0) {
        SystemName = other.SystemName;
      }
      if (other.FrontId != 0) {
        FrontId = other.FrontId;
      }
      if (other.SessionId != 0) {
        SessionId = other.SessionId;
      }
      if (other.MaxOrderRef.Length != 0) {
        MaxOrderRef = other.MaxOrderRef;
      }
      if (other.ShfeTime.Length != 0) {
        ShfeTime = other.ShfeTime;
      }
      if (other.DceTime.Length != 0) {
        DceTime = other.DceTime;
      }
      if (other.CzceTime.Length != 0) {
        CzceTime = other.CzceTime;
      }
      if (other.FfexTime.Length != 0) {
        FfexTime = other.FfexTime;
      }
      if (other.IneTime.Length != 0) {
        IneTime = other.IneTime;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            TradingDay = input.ReadString();
            break;
          }
          case 18: {
            LoginTime = input.ReadString();
            break;
          }
          case 26: {
            BrokerId = input.ReadString();
            break;
          }
          case 34: {
            UserId = input.ReadString();
            break;
          }
          case 42: {
            SystemName = input.ReadString();
            break;
          }
          case 48: {
            FrontId = input.ReadInt32();
            break;
          }
          case 56: {
            SessionId = input.ReadInt32();
            break;
          }
          case 66: {
            MaxOrderRef = input.ReadString();
            break;
          }
          case 74: {
            ShfeTime = input.ReadString();
            break;
          }
          case 82: {
            DceTime = input.ReadString();
            break;
          }
          case 90: {
            CzceTime = input.ReadString();
            break;
          }
          case 98: {
            FfexTime = input.ReadString();
            break;
          }
          case 106: {
            IneTime = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            TradingDay = input.ReadString();
            break;
          }
          case 18: {
            LoginTime = input.ReadString();
            break;
          }
          case 26: {
            BrokerId = input.ReadString();
            break;
          }
          case 34: {
            UserId = input.ReadString();
            break;
          }
          case 42: {
            SystemName = input.ReadString();
            break;
          }
          case 48: {
            FrontId = input.ReadInt32();
            break;
          }
          case 56: {
            SessionId = input.ReadInt32();
            break;
          }
          case 66: {
            MaxOrderRef = input.ReadString();
            break;
          }
          case 74: {
            ShfeTime = input.ReadString();
            break;
          }
          case 82: {
            DceTime = input.ReadString();
            break;
          }
          case 90: {
            CzceTime = input.ReadString();
            break;
          }
          case 98: {
            FfexTime = input.ReadString();
            break;
          }
          case 106: {
            IneTime = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
