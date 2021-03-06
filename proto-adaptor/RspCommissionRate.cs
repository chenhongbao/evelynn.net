// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Rsp.CommissionRate.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Evelynn.Base.Response {

  /// <summary>Holder for reflection information generated from Rsp.CommissionRate.proto</summary>
  public static partial class RspCommissionRateReflection {

    #region Descriptor
    /// <summary>File descriptor for Rsp.CommissionRate.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RspCommissionRateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhSc3AuQ29tbWlzc2lvblJhdGUucHJvdG8SA3JzcCKqAgoTQ29tbWlzc2lv",
            "blJhdGVGaWVsZBIVCg1pbnN0cnVtZW50X2lkGAEgASgJEhEKCWJyb2tlcl9p",
            "ZBgCIAEoCRITCgtpbnZlc3Rvcl9pZBgDIAEoCRIbChNvcGVuX3JhdGlvX2J5",
            "X21vbmV5GAQgASgBEhwKFG9wZW5fcmF0aW9fYnlfdm9sdW1lGAUgASgBEhwK",
            "FGNsb3NlX3JhdGlvX2J5X21vbmV5GAYgASgBEh0KFWNsb3NlX3JhdGlvX2J5",
            "X3ZvbHVtZRgHIAEoARIiChpjbG9zZV90b2RheV9yYXRpb19ieV9tb25leRgI",
            "IAEoARIjChtjbG9zZV90b2RheV9yYXRpb19ieV92b2x1bWUYCSABKAESEwoL",
            "ZXhjaGFuZ2VfaWQYCiABKAlCSQoVaW8uZXZlbHlubi5iYXNlLnByb3RvQhhD",
            "b21taXNzaW9uUmF0ZUZpZWxkUHJvdG+qAhVFdmVseW5uLkJhc2UuUmVzcG9u",
            "c2ViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Evelynn.Base.Response.CommissionRateField), global::Evelynn.Base.Response.CommissionRateField.Parser, new[]{ "InstrumentId", "BrokerId", "InvestorId", "OpenRatioByMoney", "OpenRatioByVolume", "CloseRatioByMoney", "CloseRatioByVolume", "CloseTodayRatioByMoney", "CloseTodayRatioByVolume", "ExchangeId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CommissionRateField : pb::IMessage<CommissionRateField>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CommissionRateField> _parser = new pb::MessageParser<CommissionRateField>(() => new CommissionRateField());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CommissionRateField> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Evelynn.Base.Response.RspCommissionRateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommissionRateField() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommissionRateField(CommissionRateField other) : this() {
      instrumentId_ = other.instrumentId_;
      brokerId_ = other.brokerId_;
      investorId_ = other.investorId_;
      openRatioByMoney_ = other.openRatioByMoney_;
      openRatioByVolume_ = other.openRatioByVolume_;
      closeRatioByMoney_ = other.closeRatioByMoney_;
      closeRatioByVolume_ = other.closeRatioByVolume_;
      closeTodayRatioByMoney_ = other.closeTodayRatioByMoney_;
      closeTodayRatioByVolume_ = other.closeTodayRatioByVolume_;
      exchangeId_ = other.exchangeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommissionRateField Clone() {
      return new CommissionRateField(this);
    }

    /// <summary>Field number for the "instrument_id" field.</summary>
    public const int InstrumentIdFieldNumber = 1;
    private string instrumentId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InstrumentId {
      get { return instrumentId_; }
      set {
        instrumentId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "broker_id" field.</summary>
    public const int BrokerIdFieldNumber = 2;
    private string brokerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BrokerId {
      get { return brokerId_; }
      set {
        brokerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "investor_id" field.</summary>
    public const int InvestorIdFieldNumber = 3;
    private string investorId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InvestorId {
      get { return investorId_; }
      set {
        investorId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "open_ratio_by_money" field.</summary>
    public const int OpenRatioByMoneyFieldNumber = 4;
    private double openRatioByMoney_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double OpenRatioByMoney {
      get { return openRatioByMoney_; }
      set {
        openRatioByMoney_ = value;
      }
    }

    /// <summary>Field number for the "open_ratio_by_volume" field.</summary>
    public const int OpenRatioByVolumeFieldNumber = 5;
    private double openRatioByVolume_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double OpenRatioByVolume {
      get { return openRatioByVolume_; }
      set {
        openRatioByVolume_ = value;
      }
    }

    /// <summary>Field number for the "close_ratio_by_money" field.</summary>
    public const int CloseRatioByMoneyFieldNumber = 6;
    private double closeRatioByMoney_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double CloseRatioByMoney {
      get { return closeRatioByMoney_; }
      set {
        closeRatioByMoney_ = value;
      }
    }

    /// <summary>Field number for the "close_ratio_by_volume" field.</summary>
    public const int CloseRatioByVolumeFieldNumber = 7;
    private double closeRatioByVolume_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double CloseRatioByVolume {
      get { return closeRatioByVolume_; }
      set {
        closeRatioByVolume_ = value;
      }
    }

    /// <summary>Field number for the "close_today_ratio_by_money" field.</summary>
    public const int CloseTodayRatioByMoneyFieldNumber = 8;
    private double closeTodayRatioByMoney_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double CloseTodayRatioByMoney {
      get { return closeTodayRatioByMoney_; }
      set {
        closeTodayRatioByMoney_ = value;
      }
    }

    /// <summary>Field number for the "close_today_ratio_by_volume" field.</summary>
    public const int CloseTodayRatioByVolumeFieldNumber = 9;
    private double closeTodayRatioByVolume_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double CloseTodayRatioByVolume {
      get { return closeTodayRatioByVolume_; }
      set {
        closeTodayRatioByVolume_ = value;
      }
    }

    /// <summary>Field number for the "exchange_id" field.</summary>
    public const int ExchangeIdFieldNumber = 10;
    private string exchangeId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExchangeId {
      get { return exchangeId_; }
      set {
        exchangeId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CommissionRateField);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CommissionRateField other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (InstrumentId != other.InstrumentId) return false;
      if (BrokerId != other.BrokerId) return false;
      if (InvestorId != other.InvestorId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(OpenRatioByMoney, other.OpenRatioByMoney)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(OpenRatioByVolume, other.OpenRatioByVolume)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CloseRatioByMoney, other.CloseRatioByMoney)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CloseRatioByVolume, other.CloseRatioByVolume)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CloseTodayRatioByMoney, other.CloseTodayRatioByMoney)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CloseTodayRatioByVolume, other.CloseTodayRatioByVolume)) return false;
      if (ExchangeId != other.ExchangeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (InstrumentId.Length != 0) hash ^= InstrumentId.GetHashCode();
      if (BrokerId.Length != 0) hash ^= BrokerId.GetHashCode();
      if (InvestorId.Length != 0) hash ^= InvestorId.GetHashCode();
      if (OpenRatioByMoney != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(OpenRatioByMoney);
      if (OpenRatioByVolume != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(OpenRatioByVolume);
      if (CloseRatioByMoney != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CloseRatioByMoney);
      if (CloseRatioByVolume != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CloseRatioByVolume);
      if (CloseTodayRatioByMoney != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CloseTodayRatioByMoney);
      if (CloseTodayRatioByVolume != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CloseTodayRatioByVolume);
      if (ExchangeId.Length != 0) hash ^= ExchangeId.GetHashCode();
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
      if (InstrumentId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(InstrumentId);
      }
      if (BrokerId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BrokerId);
      }
      if (InvestorId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(InvestorId);
      }
      if (OpenRatioByMoney != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(OpenRatioByMoney);
      }
      if (OpenRatioByVolume != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(OpenRatioByVolume);
      }
      if (CloseRatioByMoney != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(CloseRatioByMoney);
      }
      if (CloseRatioByVolume != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(CloseRatioByVolume);
      }
      if (CloseTodayRatioByMoney != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(CloseTodayRatioByMoney);
      }
      if (CloseTodayRatioByVolume != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(CloseTodayRatioByVolume);
      }
      if (ExchangeId.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(ExchangeId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (InstrumentId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(InstrumentId);
      }
      if (BrokerId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BrokerId);
      }
      if (InvestorId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(InvestorId);
      }
      if (OpenRatioByMoney != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(OpenRatioByMoney);
      }
      if (OpenRatioByVolume != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(OpenRatioByVolume);
      }
      if (CloseRatioByMoney != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(CloseRatioByMoney);
      }
      if (CloseRatioByVolume != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(CloseRatioByVolume);
      }
      if (CloseTodayRatioByMoney != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(CloseTodayRatioByMoney);
      }
      if (CloseTodayRatioByVolume != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(CloseTodayRatioByVolume);
      }
      if (ExchangeId.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(ExchangeId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (InstrumentId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InstrumentId);
      }
      if (BrokerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BrokerId);
      }
      if (InvestorId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InvestorId);
      }
      if (OpenRatioByMoney != 0D) {
        size += 1 + 8;
      }
      if (OpenRatioByVolume != 0D) {
        size += 1 + 8;
      }
      if (CloseRatioByMoney != 0D) {
        size += 1 + 8;
      }
      if (CloseRatioByVolume != 0D) {
        size += 1 + 8;
      }
      if (CloseTodayRatioByMoney != 0D) {
        size += 1 + 8;
      }
      if (CloseTodayRatioByVolume != 0D) {
        size += 1 + 8;
      }
      if (ExchangeId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ExchangeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CommissionRateField other) {
      if (other == null) {
        return;
      }
      if (other.InstrumentId.Length != 0) {
        InstrumentId = other.InstrumentId;
      }
      if (other.BrokerId.Length != 0) {
        BrokerId = other.BrokerId;
      }
      if (other.InvestorId.Length != 0) {
        InvestorId = other.InvestorId;
      }
      if (other.OpenRatioByMoney != 0D) {
        OpenRatioByMoney = other.OpenRatioByMoney;
      }
      if (other.OpenRatioByVolume != 0D) {
        OpenRatioByVolume = other.OpenRatioByVolume;
      }
      if (other.CloseRatioByMoney != 0D) {
        CloseRatioByMoney = other.CloseRatioByMoney;
      }
      if (other.CloseRatioByVolume != 0D) {
        CloseRatioByVolume = other.CloseRatioByVolume;
      }
      if (other.CloseTodayRatioByMoney != 0D) {
        CloseTodayRatioByMoney = other.CloseTodayRatioByMoney;
      }
      if (other.CloseTodayRatioByVolume != 0D) {
        CloseTodayRatioByVolume = other.CloseTodayRatioByVolume;
      }
      if (other.ExchangeId.Length != 0) {
        ExchangeId = other.ExchangeId;
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
            InstrumentId = input.ReadString();
            break;
          }
          case 18: {
            BrokerId = input.ReadString();
            break;
          }
          case 26: {
            InvestorId = input.ReadString();
            break;
          }
          case 33: {
            OpenRatioByMoney = input.ReadDouble();
            break;
          }
          case 41: {
            OpenRatioByVolume = input.ReadDouble();
            break;
          }
          case 49: {
            CloseRatioByMoney = input.ReadDouble();
            break;
          }
          case 57: {
            CloseRatioByVolume = input.ReadDouble();
            break;
          }
          case 65: {
            CloseTodayRatioByMoney = input.ReadDouble();
            break;
          }
          case 73: {
            CloseTodayRatioByVolume = input.ReadDouble();
            break;
          }
          case 82: {
            ExchangeId = input.ReadString();
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
            InstrumentId = input.ReadString();
            break;
          }
          case 18: {
            BrokerId = input.ReadString();
            break;
          }
          case 26: {
            InvestorId = input.ReadString();
            break;
          }
          case 33: {
            OpenRatioByMoney = input.ReadDouble();
            break;
          }
          case 41: {
            OpenRatioByVolume = input.ReadDouble();
            break;
          }
          case 49: {
            CloseRatioByMoney = input.ReadDouble();
            break;
          }
          case 57: {
            CloseRatioByVolume = input.ReadDouble();
            break;
          }
          case 65: {
            CloseTodayRatioByMoney = input.ReadDouble();
            break;
          }
          case 73: {
            CloseTodayRatioByVolume = input.ReadDouble();
            break;
          }
          case 82: {
            ExchangeId = input.ReadString();
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
