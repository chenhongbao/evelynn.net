// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Msg.Rtn.Trade.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Evelynn.Base.Proto {

  /// <summary>Holder for reflection information generated from Msg.Rtn.Trade.proto</summary>
  public static partial class MsgRtnTradeReflection {

    #region Descriptor
    /// <summary>File descriptor for Msg.Rtn.Trade.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MsgRtnTradeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNNc2cuUnRuLlRyYWRlLnByb3RvEgdtc2cucnRuGg9SdG4uVHJhZGUucHJv",
            "dG8iLQoLUnRuVHJhZGVNc2cSHgoFdHJhZGUYASABKAsyDy5ydG4uVHJhZGVG",
            "aWVsZEI+ChVpby5ldmVseW5uLmJhc2UucHJvdG9CEFJ0blRyYWRlTXNnUHJv",
            "dG+qAhJFdmVseW5uLkJhc2UuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Evelynn.Base.Proto.RtnTradeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Evelynn.Base.Proto.RtnTradeMsg), global::Evelynn.Base.Proto.RtnTradeMsg.Parser, new[]{ "Trade" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RtnTradeMsg : pb::IMessage<RtnTradeMsg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RtnTradeMsg> _parser = new pb::MessageParser<RtnTradeMsg>(() => new RtnTradeMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RtnTradeMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Evelynn.Base.Proto.MsgRtnTradeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RtnTradeMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RtnTradeMsg(RtnTradeMsg other) : this() {
      trade_ = other.trade_ != null ? other.trade_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RtnTradeMsg Clone() {
      return new RtnTradeMsg(this);
    }

    /// <summary>Field number for the "trade" field.</summary>
    public const int TradeFieldNumber = 1;
    private global::Evelynn.Base.Proto.TradeField trade_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Evelynn.Base.Proto.TradeField Trade {
      get { return trade_; }
      set {
        trade_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RtnTradeMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RtnTradeMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Trade, other.Trade)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (trade_ != null) hash ^= Trade.GetHashCode();
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
      if (trade_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Trade);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (trade_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Trade);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (trade_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Trade);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RtnTradeMsg other) {
      if (other == null) {
        return;
      }
      if (other.trade_ != null) {
        if (trade_ == null) {
          Trade = new global::Evelynn.Base.Proto.TradeField();
        }
        Trade.MergeFrom(other.Trade);
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
            if (trade_ == null) {
              Trade = new global::Evelynn.Base.Proto.TradeField();
            }
            input.ReadMessage(Trade);
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
            if (trade_ == null) {
              Trade = new global::Evelynn.Base.Proto.TradeField();
            }
            input.ReadMessage(Trade);
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