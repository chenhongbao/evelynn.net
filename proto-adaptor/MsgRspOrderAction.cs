// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Msg.Rsp.OrderAction.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Evelynn.Base.Response {

  /// <summary>Holder for reflection information generated from Msg.Rsp.OrderAction.proto</summary>
  public static partial class MsgRspOrderActionReflection {

    #region Descriptor
    /// <summary>File descriptor for Msg.Rsp.OrderAction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MsgRspOrderActionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlNc2cuUnNwLk9yZGVyQWN0aW9uLnByb3RvEgdtc2cucnNwGhpSZXEuSW5w",
            "dXRPcmRlckFjdGlvbi5wcm90bxoPUnNwLkVycm9yLnByb3RvIooBChFSc3BP",
            "cmRlckFjdGlvbk1zZxIwCgxvcmRlcl9hY3Rpb24YASABKAsyGi5yZXEuSW5w",
            "dXRPcmRlckFjdGlvbkZpZWxkEh4KBWVycm9yGAIgASgLMg8ucnNwLkVycm9y",
            "RmllbGQSEgoKcmVxdWVzdF9pZBgDIAEoBRIPCgdpc19sYXN0GAQgASgIQkcK",
            "FWlvLmV2ZWx5bm4uYmFzZS5wcm90b0IWUnNwT3JkZXJBY3Rpb25Nc2dQcm90",
            "b6oCFUV2ZWx5bm4uQmFzZS5SZXNwb25zZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Evelynn.Base.Request.ReqInputOrderActionReflection.Descriptor, global::Evelynn.Base.Response.RspErrorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Evelynn.Base.Response.RspOrderActionMsg), global::Evelynn.Base.Response.RspOrderActionMsg.Parser, new[]{ "OrderAction", "Error", "RequestId", "IsLast" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RspOrderActionMsg : pb::IMessage<RspOrderActionMsg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RspOrderActionMsg> _parser = new pb::MessageParser<RspOrderActionMsg>(() => new RspOrderActionMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RspOrderActionMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Evelynn.Base.Response.MsgRspOrderActionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspOrderActionMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspOrderActionMsg(RspOrderActionMsg other) : this() {
      orderAction_ = other.orderAction_ != null ? other.orderAction_.Clone() : null;
      error_ = other.error_ != null ? other.error_.Clone() : null;
      requestId_ = other.requestId_;
      isLast_ = other.isLast_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspOrderActionMsg Clone() {
      return new RspOrderActionMsg(this);
    }

    /// <summary>Field number for the "order_action" field.</summary>
    public const int OrderActionFieldNumber = 1;
    private global::Evelynn.Base.Request.InputOrderActionField orderAction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Evelynn.Base.Request.InputOrderActionField OrderAction {
      get { return orderAction_; }
      set {
        orderAction_ = value;
      }
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 2;
    private global::Evelynn.Base.Response.ErrorField error_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Evelynn.Base.Response.ErrorField Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    /// <summary>Field number for the "request_id" field.</summary>
    public const int RequestIdFieldNumber = 3;
    private int requestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RequestId {
      get { return requestId_; }
      set {
        requestId_ = value;
      }
    }

    /// <summary>Field number for the "is_last" field.</summary>
    public const int IsLastFieldNumber = 4;
    private bool isLast_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsLast {
      get { return isLast_; }
      set {
        isLast_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RspOrderActionMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RspOrderActionMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(OrderAction, other.OrderAction)) return false;
      if (!object.Equals(Error, other.Error)) return false;
      if (RequestId != other.RequestId) return false;
      if (IsLast != other.IsLast) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (orderAction_ != null) hash ^= OrderAction.GetHashCode();
      if (error_ != null) hash ^= Error.GetHashCode();
      if (RequestId != 0) hash ^= RequestId.GetHashCode();
      if (IsLast != false) hash ^= IsLast.GetHashCode();
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
      if (orderAction_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(OrderAction);
      }
      if (error_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Error);
      }
      if (RequestId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(RequestId);
      }
      if (IsLast != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsLast);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (orderAction_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(OrderAction);
      }
      if (error_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Error);
      }
      if (RequestId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(RequestId);
      }
      if (IsLast != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsLast);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (orderAction_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OrderAction);
      }
      if (error_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Error);
      }
      if (RequestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RequestId);
      }
      if (IsLast != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RspOrderActionMsg other) {
      if (other == null) {
        return;
      }
      if (other.orderAction_ != null) {
        if (orderAction_ == null) {
          OrderAction = new global::Evelynn.Base.Request.InputOrderActionField();
        }
        OrderAction.MergeFrom(other.OrderAction);
      }
      if (other.error_ != null) {
        if (error_ == null) {
          Error = new global::Evelynn.Base.Response.ErrorField();
        }
        Error.MergeFrom(other.Error);
      }
      if (other.RequestId != 0) {
        RequestId = other.RequestId;
      }
      if (other.IsLast != false) {
        IsLast = other.IsLast;
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
            if (orderAction_ == null) {
              OrderAction = new global::Evelynn.Base.Request.InputOrderActionField();
            }
            input.ReadMessage(OrderAction);
            break;
          }
          case 18: {
            if (error_ == null) {
              Error = new global::Evelynn.Base.Response.ErrorField();
            }
            input.ReadMessage(Error);
            break;
          }
          case 24: {
            RequestId = input.ReadInt32();
            break;
          }
          case 32: {
            IsLast = input.ReadBool();
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
            if (orderAction_ == null) {
              OrderAction = new global::Evelynn.Base.Request.InputOrderActionField();
            }
            input.ReadMessage(OrderAction);
            break;
          }
          case 18: {
            if (error_ == null) {
              Error = new global::Evelynn.Base.Response.ErrorField();
            }
            input.ReadMessage(Error);
            break;
          }
          case 24: {
            RequestId = input.ReadInt32();
            break;
          }
          case 32: {
            IsLast = input.ReadBool();
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
