// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Qry.MarginRate.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Evelynn.Base.Query {

  /// <summary>Holder for reflection information generated from Qry.MarginRate.proto</summary>
  public static partial class QryMarginRateReflection {

    #region Descriptor
    /// <summary>File descriptor for Qry.MarginRate.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QryMarginRateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRRcnkuTWFyZ2luUmF0ZS5wcm90bxIDcXJ5InwKElFyeU1hcmdpblJhdGVG",
            "aWVsZBIRCglicm9rZXJfaWQYASABKAkSEwoLaW52ZXN0b3JfaWQYAiABKAkS",
            "FQoNaW5zdHJ1bWVudF9pZBgDIAEoCRITCgtleGNoYW5nZV9pZBgEIAEoCRIS",
            "CgpoZWRnZV9mbGFnGAUgASgFQkUKFWlvLmV2ZWx5bm4uYmFzZS5wcm90b0IX",
            "UXJ5TWFyZ2luUmF0ZUZpZWxkUHJvdG+qAhJFdmVseW5uLkJhc2UuUXVlcnli",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Evelynn.Base.Query.QryMarginRateField), global::Evelynn.Base.Query.QryMarginRateField.Parser, new[]{ "BrokerId", "InvestorId", "InstrumentId", "ExchangeId", "HedgeFlag" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class QryMarginRateField : pb::IMessage<QryMarginRateField>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QryMarginRateField> _parser = new pb::MessageParser<QryMarginRateField>(() => new QryMarginRateField());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QryMarginRateField> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Evelynn.Base.Query.QryMarginRateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QryMarginRateField() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QryMarginRateField(QryMarginRateField other) : this() {
      brokerId_ = other.brokerId_;
      investorId_ = other.investorId_;
      instrumentId_ = other.instrumentId_;
      exchangeId_ = other.exchangeId_;
      hedgeFlag_ = other.hedgeFlag_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QryMarginRateField Clone() {
      return new QryMarginRateField(this);
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

    /// <summary>Field number for the "investor_id" field.</summary>
    public const int InvestorIdFieldNumber = 2;
    private string investorId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InvestorId {
      get { return investorId_; }
      set {
        investorId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "instrument_id" field.</summary>
    public const int InstrumentIdFieldNumber = 3;
    private string instrumentId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InstrumentId {
      get { return instrumentId_; }
      set {
        instrumentId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "exchange_id" field.</summary>
    public const int ExchangeIdFieldNumber = 4;
    private string exchangeId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExchangeId {
      get { return exchangeId_; }
      set {
        exchangeId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hedge_flag" field.</summary>
    public const int HedgeFlagFieldNumber = 5;
    private int hedgeFlag_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int HedgeFlag {
      get { return hedgeFlag_; }
      set {
        hedgeFlag_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QryMarginRateField);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QryMarginRateField other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BrokerId != other.BrokerId) return false;
      if (InvestorId != other.InvestorId) return false;
      if (InstrumentId != other.InstrumentId) return false;
      if (ExchangeId != other.ExchangeId) return false;
      if (HedgeFlag != other.HedgeFlag) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BrokerId.Length != 0) hash ^= BrokerId.GetHashCode();
      if (InvestorId.Length != 0) hash ^= InvestorId.GetHashCode();
      if (InstrumentId.Length != 0) hash ^= InstrumentId.GetHashCode();
      if (ExchangeId.Length != 0) hash ^= ExchangeId.GetHashCode();
      if (HedgeFlag != 0) hash ^= HedgeFlag.GetHashCode();
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
      if (InvestorId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(InvestorId);
      }
      if (InstrumentId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(InstrumentId);
      }
      if (ExchangeId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ExchangeId);
      }
      if (HedgeFlag != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(HedgeFlag);
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
      if (InvestorId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(InvestorId);
      }
      if (InstrumentId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(InstrumentId);
      }
      if (ExchangeId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ExchangeId);
      }
      if (HedgeFlag != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(HedgeFlag);
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
      if (InvestorId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InvestorId);
      }
      if (InstrumentId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InstrumentId);
      }
      if (ExchangeId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ExchangeId);
      }
      if (HedgeFlag != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(HedgeFlag);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QryMarginRateField other) {
      if (other == null) {
        return;
      }
      if (other.BrokerId.Length != 0) {
        BrokerId = other.BrokerId;
      }
      if (other.InvestorId.Length != 0) {
        InvestorId = other.InvestorId;
      }
      if (other.InstrumentId.Length != 0) {
        InstrumentId = other.InstrumentId;
      }
      if (other.ExchangeId.Length != 0) {
        ExchangeId = other.ExchangeId;
      }
      if (other.HedgeFlag != 0) {
        HedgeFlag = other.HedgeFlag;
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
            InvestorId = input.ReadString();
            break;
          }
          case 26: {
            InstrumentId = input.ReadString();
            break;
          }
          case 34: {
            ExchangeId = input.ReadString();
            break;
          }
          case 40: {
            HedgeFlag = input.ReadInt32();
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
            InvestorId = input.ReadString();
            break;
          }
          case 26: {
            InstrumentId = input.ReadString();
            break;
          }
          case 34: {
            ExchangeId = input.ReadString();
            break;
          }
          case 40: {
            HedgeFlag = input.ReadInt32();
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
