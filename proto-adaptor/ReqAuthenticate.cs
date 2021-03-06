// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Req.Authenticate.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Evelynn.Base.Request {

  /// <summary>Holder for reflection information generated from Req.Authenticate.proto</summary>
  public static partial class ReqAuthenticateReflection {

    #region Descriptor
    /// <summary>File descriptor for Req.Authenticate.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReqAuthenticateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZSZXEuQXV0aGVudGljYXRlLnByb3RvEgNyZXEidQoRQXV0aGVudGljYXRl",
            "RmllbGQSEQoJYnJva2VyX2lkGAEgASgJEg8KB3VzZXJfaWQYAiABKAkSDgoG",
            "YXBwX2lkGAMgASgJEhEKCWF1dGhfY29kZRgEIAEoCRIZChF1c2VyX3Byb2R1",
            "Y3RfaW5mbxgFIAEoCUJJChVpby5ldmVseW5uLmJhc2UucHJvdG9CGVJlcUF1",
            "dGhlbnRpY2F0ZUZpZWxkUHJvdG+qAhRFdmVseW5uLkJhc2UuUmVxdWVzdGIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Evelynn.Base.Request.AuthenticateField), global::Evelynn.Base.Request.AuthenticateField.Parser, new[]{ "BrokerId", "UserId", "AppId", "AuthCode", "UserProductInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AuthenticateField : pb::IMessage<AuthenticateField>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AuthenticateField> _parser = new pb::MessageParser<AuthenticateField>(() => new AuthenticateField());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AuthenticateField> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Evelynn.Base.Request.ReqAuthenticateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthenticateField() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthenticateField(AuthenticateField other) : this() {
      brokerId_ = other.brokerId_;
      userId_ = other.userId_;
      appId_ = other.appId_;
      authCode_ = other.authCode_;
      userProductInfo_ = other.userProductInfo_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthenticateField Clone() {
      return new AuthenticateField(this);
    }

    /// <summary>Field number for the "broker_id" field.</summary>
    public const int BrokerIdFieldNumber = 1;
    private string brokerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BrokerId {
      get { return brokerId_; }
      set {
        brokerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 2;
    private string userId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "app_id" field.</summary>
    public const int AppIdFieldNumber = 3;
    private string appId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AppId {
      get { return appId_; }
      set {
        appId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "auth_code" field.</summary>
    public const int AuthCodeFieldNumber = 4;
    private string authCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AuthCode {
      get { return authCode_; }
      set {
        authCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_product_info" field.</summary>
    public const int UserProductInfoFieldNumber = 5;
    private string userProductInfo_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserProductInfo {
      get { return userProductInfo_; }
      set {
        userProductInfo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AuthenticateField);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AuthenticateField other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BrokerId != other.BrokerId) return false;
      if (UserId != other.UserId) return false;
      if (AppId != other.AppId) return false;
      if (AuthCode != other.AuthCode) return false;
      if (UserProductInfo != other.UserProductInfo) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BrokerId.Length != 0) hash ^= BrokerId.GetHashCode();
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      if (AppId.Length != 0) hash ^= AppId.GetHashCode();
      if (AuthCode.Length != 0) hash ^= AuthCode.GetHashCode();
      if (UserProductInfo.Length != 0) hash ^= UserProductInfo.GetHashCode();
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
      if (BrokerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BrokerId);
      }
      if (UserId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UserId);
      }
      if (AppId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(AppId);
      }
      if (AuthCode.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AuthCode);
      }
      if (UserProductInfo.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(UserProductInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (BrokerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BrokerId);
      }
      if (UserId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UserId);
      }
      if (AppId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(AppId);
      }
      if (AuthCode.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AuthCode);
      }
      if (UserProductInfo.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(UserProductInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BrokerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BrokerId);
      }
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      if (AppId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AppId);
      }
      if (AuthCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AuthCode);
      }
      if (UserProductInfo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserProductInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AuthenticateField other) {
      if (other == null) {
        return;
      }
      if (other.BrokerId.Length != 0) {
        BrokerId = other.BrokerId;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
      if (other.AppId.Length != 0) {
        AppId = other.AppId;
      }
      if (other.AuthCode.Length != 0) {
        AuthCode = other.AuthCode;
      }
      if (other.UserProductInfo.Length != 0) {
        UserProductInfo = other.UserProductInfo;
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
            BrokerId = input.ReadString();
            break;
          }
          case 18: {
            UserId = input.ReadString();
            break;
          }
          case 26: {
            AppId = input.ReadString();
            break;
          }
          case 34: {
            AuthCode = input.ReadString();
            break;
          }
          case 42: {
            UserProductInfo = input.ReadString();
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
            BrokerId = input.ReadString();
            break;
          }
          case 18: {
            UserId = input.ReadString();
            break;
          }
          case 26: {
            AppId = input.ReadString();
            break;
          }
          case 34: {
            AuthCode = input.ReadString();
            break;
          }
          case 42: {
            UserProductInfo = input.ReadString();
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
