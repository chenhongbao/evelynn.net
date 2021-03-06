// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Msg.Qry.MarginRate.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Evelynn.Base.Query {

  /// <summary>Holder for reflection information generated from Msg.Qry.MarginRate.proto</summary>
  public static partial class MsgQryMarginRateReflection {

    #region Descriptor
    /// <summary>File descriptor for Msg.Qry.MarginRate.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MsgQryMarginRateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhNc2cuUXJ5Lk1hcmdpblJhdGUucHJvdG8SB21zZy5xcnkaFFFyeS5NYXJn",
            "aW5SYXRlLnByb3RvIlQKEFFyeU1hcmdpblJhdGVNc2cSLAoLbWFyZ2luX3Jh",
            "dGUYASABKAsyFy5xcnkuUXJ5TWFyZ2luUmF0ZUZpZWxkEhIKCnJlcXVlc3Rf",
            "aWQYAiABKAVCQwoVaW8uZXZlbHlubi5iYXNlLnByb3RvQhVRcnlNYXJnaW5S",
            "YXRlTXNnUHJvdG+qAhJFdmVseW5uLkJhc2UuUXVlcnliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Evelynn.Base.Query.QryMarginRateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Evelynn.Base.Query.QryMarginRateMsg), global::Evelynn.Base.Query.QryMarginRateMsg.Parser, new[]{ "MarginRate", "RequestId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class QryMarginRateMsg : pb::IMessage<QryMarginRateMsg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QryMarginRateMsg> _parser = new pb::MessageParser<QryMarginRateMsg>(() => new QryMarginRateMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QryMarginRateMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Evelynn.Base.Query.MsgQryMarginRateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QryMarginRateMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QryMarginRateMsg(QryMarginRateMsg other) : this() {
      marginRate_ = other.marginRate_ != null ? other.marginRate_.Clone() : null;
      requestId_ = other.requestId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QryMarginRateMsg Clone() {
      return new QryMarginRateMsg(this);
    }

    /// <summary>Field number for the "margin_rate" field.</summary>
    public const int MarginRateFieldNumber = 1;
    private global::Evelynn.Base.Query.QryMarginRateField marginRate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Evelynn.Base.Query.QryMarginRateField MarginRate {
      get { return marginRate_; }
      set {
        marginRate_ = value;
      }
    }

    /// <summary>Field number for the "request_id" field.</summary>
    public const int RequestIdFieldNumber = 2;
    private int requestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RequestId {
      get { return requestId_; }
      set {
        requestId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QryMarginRateMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QryMarginRateMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(MarginRate, other.MarginRate)) return false;
      if (RequestId != other.RequestId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (marginRate_ != null) hash ^= MarginRate.GetHashCode();
      if (RequestId != 0) hash ^= RequestId.GetHashCode();
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
      if (marginRate_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MarginRate);
      }
      if (RequestId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(RequestId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (marginRate_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MarginRate);
      }
      if (RequestId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(RequestId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (marginRate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MarginRate);
      }
      if (RequestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RequestId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QryMarginRateMsg other) {
      if (other == null) {
        return;
      }
      if (other.marginRate_ != null) {
        if (marginRate_ == null) {
          MarginRate = new global::Evelynn.Base.Query.QryMarginRateField();
        }
        MarginRate.MergeFrom(other.MarginRate);
      }
      if (other.RequestId != 0) {
        RequestId = other.RequestId;
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
            if (marginRate_ == null) {
              MarginRate = new global::Evelynn.Base.Query.QryMarginRateField();
            }
            input.ReadMessage(MarginRate);
            break;
          }
          case 16: {
            RequestId = input.ReadInt32();
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
            if (marginRate_ == null) {
              MarginRate = new global::Evelynn.Base.Query.QryMarginRateField();
            }
            input.ReadMessage(MarginRate);
            break;
          }
          case 16: {
            RequestId = input.ReadInt32();
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
