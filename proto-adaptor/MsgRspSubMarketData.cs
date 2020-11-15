// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Msg.Rsp.SubMarketData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Evelynn.Base.Response {

  /// <summary>Holder for reflection information generated from Msg.Rsp.SubMarketData.proto</summary>
  public static partial class MsgRspSubMarketDataReflection {

    #region Descriptor
    /// <summary>File descriptor for Msg.Rsp.SubMarketData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MsgRspSubMarketDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtNc2cuUnNwLlN1Yk1hcmtldERhdGEucHJvdG8SB21zZy5yc3AaHFJzcC5T",
            "cGVjaWZpY0luc3RydW1lbnQucHJvdG8aD1JzcC5FcnJvci5wcm90byKMAQoT",
            "UnNwU3ViTWFya2V0RGF0YU1zZxIwCgppbnN0cnVtZW50GAEgASgLMhwucnNw",
            "LlNwZWNpZmljSW5zdHJ1bWVudEZpZWxkEh4KBWVycm9yGAIgASgLMg8ucnNw",
            "LkVycm9yRmllbGQSEgoKcmVxdWVzdF9pZBgDIAEoBRIPCgdpc19sYXN0GAQg",
            "ASgIQkkKFWlvLmV2ZWx5bm4uYmFzZS5wcm90b0IYUnNwU3ViTWFya2V0RGF0",
            "YU1zZ1Byb3RvqgIVRXZlbHlubi5CYXNlLlJlc3BvbnNlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Evelynn.Base.Response.RspSpecificInstrumentReflection.Descriptor, global::Evelynn.Base.Response.RspErrorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Evelynn.Base.Response.RspSubMarketDataMsg), global::Evelynn.Base.Response.RspSubMarketDataMsg.Parser, new[]{ "Instrument", "Error", "RequestId", "IsLast" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RspSubMarketDataMsg : pb::IMessage<RspSubMarketDataMsg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RspSubMarketDataMsg> _parser = new pb::MessageParser<RspSubMarketDataMsg>(() => new RspSubMarketDataMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RspSubMarketDataMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Evelynn.Base.Response.MsgRspSubMarketDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspSubMarketDataMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspSubMarketDataMsg(RspSubMarketDataMsg other) : this() {
      instrument_ = other.instrument_ != null ? other.instrument_.Clone() : null;
      error_ = other.error_ != null ? other.error_.Clone() : null;
      requestId_ = other.requestId_;
      isLast_ = other.isLast_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspSubMarketDataMsg Clone() {
      return new RspSubMarketDataMsg(this);
    }

    /// <summary>Field number for the "instrument" field.</summary>
    public const int InstrumentFieldNumber = 1;
    private global::Evelynn.Base.Response.SpecificInstrumentField instrument_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Evelynn.Base.Response.SpecificInstrumentField Instrument {
      get { return instrument_; }
      set {
        instrument_ = value;
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
      return Equals(other as RspSubMarketDataMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RspSubMarketDataMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Instrument, other.Instrument)) return false;
      if (!object.Equals(Error, other.Error)) return false;
      if (RequestId != other.RequestId) return false;
      if (IsLast != other.IsLast) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (instrument_ != null) hash ^= Instrument.GetHashCode();
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
      if (instrument_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Instrument);
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
      if (instrument_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Instrument);
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
      if (instrument_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Instrument);
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
    public void MergeFrom(RspSubMarketDataMsg other) {
      if (other == null) {
        return;
      }
      if (other.instrument_ != null) {
        if (instrument_ == null) {
          Instrument = new global::Evelynn.Base.Response.SpecificInstrumentField();
        }
        Instrument.MergeFrom(other.Instrument);
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
            if (instrument_ == null) {
              Instrument = new global::Evelynn.Base.Response.SpecificInstrumentField();
            }
            input.ReadMessage(Instrument);
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
            if (instrument_ == null) {
              Instrument = new global::Evelynn.Base.Response.SpecificInstrumentField();
            }
            input.ReadMessage(Instrument);
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
