// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Msg.Req.OrderAction.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Evelynn.Base.Proto {

  /// <summary>Holder for reflection information generated from Msg.Req.OrderAction.proto</summary>
  public static partial class MsgReqOrderActionReflection {

    #region Descriptor
    /// <summary>File descriptor for Msg.Req.OrderAction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MsgReqOrderActionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlNc2cuUmVxLk9yZGVyQWN0aW9uLnByb3RvEgdtc2cucmVxGhpSZXEuSW5w",
            "dXRPcmRlckFjdGlvbi5wcm90byJZChFSZXFPcmRlckFjdGlvbk1zZxIwCgxv",
            "cmRlcl9hY3Rpb24YASABKAsyGi5yZXEuSW5wdXRPcmRlckFjdGlvbkZpZWxk",
            "EhIKCnJlcXVlc3RfaWQYAiABKAVCRAoVaW8uZXZlbHlubi5iYXNlLnByb3Rv",
            "QhZSZXFPcmRlckFjdGlvbk1zZ1Byb3RvqgISRXZlbHlubi5CYXNlLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Evelynn.Base.Proto.ReqInputOrderActionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Evelynn.Base.Proto.ReqOrderActionMsg), global::Evelynn.Base.Proto.ReqOrderActionMsg.Parser, new[]{ "OrderAction", "RequestId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReqOrderActionMsg : pb::IMessage<ReqOrderActionMsg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReqOrderActionMsg> _parser = new pb::MessageParser<ReqOrderActionMsg>(() => new ReqOrderActionMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReqOrderActionMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Evelynn.Base.Proto.MsgReqOrderActionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqOrderActionMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqOrderActionMsg(ReqOrderActionMsg other) : this() {
      orderAction_ = other.orderAction_ != null ? other.orderAction_.Clone() : null;
      requestId_ = other.requestId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqOrderActionMsg Clone() {
      return new ReqOrderActionMsg(this);
    }

    /// <summary>Field number for the "order_action" field.</summary>
    public const int OrderActionFieldNumber = 1;
    private global::Evelynn.Base.Proto.InputOrderActionField orderAction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Evelynn.Base.Proto.InputOrderActionField OrderAction {
      get { return orderAction_; }
      set {
        orderAction_ = value;
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
      return Equals(other as ReqOrderActionMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReqOrderActionMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(OrderAction, other.OrderAction)) return false;
      if (RequestId != other.RequestId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (orderAction_ != null) hash ^= OrderAction.GetHashCode();
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
      if (orderAction_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(OrderAction);
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
      if (orderAction_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(OrderAction);
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
      if (orderAction_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OrderAction);
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
    public void MergeFrom(ReqOrderActionMsg other) {
      if (other == null) {
        return;
      }
      if (other.orderAction_ != null) {
        if (orderAction_ == null) {
          OrderAction = new global::Evelynn.Base.Proto.InputOrderActionField();
        }
        OrderAction.MergeFrom(other.OrderAction);
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
            if (orderAction_ == null) {
              OrderAction = new global::Evelynn.Base.Proto.InputOrderActionField();
            }
            input.ReadMessage(OrderAction);
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
            if (orderAction_ == null) {
              OrderAction = new global::Evelynn.Base.Proto.InputOrderActionField();
            }
            input.ReadMessage(OrderAction);
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