// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Msg.Rsp.Error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Evelynn.Base.Response {

  /// <summary>Holder for reflection information generated from Msg.Rsp.Error.proto</summary>
  public static partial class MsgRspErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for Msg.Rsp.Error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MsgRspErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNNc2cuUnNwLkVycm9yLnByb3RvEgdtc2cucnNwGg9Sc3AuRXJyb3IucHJv",
            "dG8iUgoLUnNwRXJyb3JNc2cSHgoFZXJyb3IYASABKAsyDy5yc3AuRXJyb3JG",
            "aWVsZBISCgpyZXF1ZXN0X2lkGAIgASgFEg8KB2lzX2xhc3QYAyABKAhCQQoV",
            "aW8uZXZlbHlubi5iYXNlLnByb3RvQhBSc3BFcnJvck1zZ1Byb3RvqgIVRXZl",
            "bHlubi5CYXNlLlJlc3BvbnNlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Evelynn.Base.Response.RspErrorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Evelynn.Base.Response.RspErrorMsg), global::Evelynn.Base.Response.RspErrorMsg.Parser, new[]{ "Error", "RequestId", "IsLast" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RspErrorMsg : pb::IMessage<RspErrorMsg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RspErrorMsg> _parser = new pb::MessageParser<RspErrorMsg>(() => new RspErrorMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RspErrorMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Evelynn.Base.Response.MsgRspErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspErrorMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspErrorMsg(RspErrorMsg other) : this() {
      error_ = other.error_ != null ? other.error_.Clone() : null;
      requestId_ = other.requestId_;
      isLast_ = other.isLast_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspErrorMsg Clone() {
      return new RspErrorMsg(this);
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 1;
    private global::Evelynn.Base.Response.ErrorField error_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Evelynn.Base.Response.ErrorField Error {
      get { return error_; }
      set {
        error_ = value;
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

    /// <summary>Field number for the "is_last" field.</summary>
    public const int IsLastFieldNumber = 3;
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
      return Equals(other as RspErrorMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RspErrorMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Error, other.Error)) return false;
      if (RequestId != other.RequestId) return false;
      if (IsLast != other.IsLast) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (error_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Error);
      }
      if (RequestId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(RequestId);
      }
      if (IsLast != false) {
        output.WriteRawTag(24);
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
      if (error_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Error);
      }
      if (RequestId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(RequestId);
      }
      if (IsLast != false) {
        output.WriteRawTag(24);
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
    public void MergeFrom(RspErrorMsg other) {
      if (other == null) {
        return;
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
            if (error_ == null) {
              Error = new global::Evelynn.Base.Response.ErrorField();
            }
            input.ReadMessage(Error);
            break;
          }
          case 16: {
            RequestId = input.ReadInt32();
            break;
          }
          case 24: {
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
            if (error_ == null) {
              Error = new global::Evelynn.Base.Response.ErrorField();
            }
            input.ReadMessage(Error);
            break;
          }
          case 16: {
            RequestId = input.ReadInt32();
            break;
          }
          case 24: {
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
