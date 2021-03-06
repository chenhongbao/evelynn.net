// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Req.InputOrder.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Evelynn.Base.Request {

  /// <summary>Holder for reflection information generated from Req.InputOrder.proto</summary>
  public static partial class ReqInputOrderReflection {

    #region Descriptor
    /// <summary>File descriptor for Req.InputOrder.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReqInputOrderReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRSZXEuSW5wdXRPcmRlci5wcm90bxIDcmVxIrYDCg9JbnB1dE9yZGVyRmll",
            "bGQSEQoJYnJva2VyX2lkGAEgASgJEhMKC2ludmVzdG9yX2lkGAIgASgJEg8K",
            "B3VzZXJfaWQYAyABKAkSFQoNaW5zdHJ1bWVudF9pZBgEIAEoCRITCgtleGNo",
            "YW5nZV9pZBgFIAEoCRIYChBvcmRlcl9wcmljZV90eXBlGAYgASgFEhEKCWRp",
            "cmVjdGlvbhgHIAEoBRIYChBjb21iX29mZnNldF9mbGFnGAggASgFEhcKD2Nv",
            "bWJfaGVkZ2VfZmxhZxgJIAEoBRITCgtsaW1pdF9wcmljZRgKIAEoARIdChV2",
            "b2x1bWVfdG90YWxfb3JpZ2luYWwYCyABKAUSFgoOdGltZV9jb25kaXRpb24Y",
            "DCABKAUSGAoQdm9sdW1lX2NvbmRpdGlvbhgNIAEoBRISCgptaW5fdm9sdW1l",
            "GA4gASgFEhsKE2NvbnRpZ2VudF9jb25kaXRpb24YDyABKAUSEgoKc3RvcF9w",
            "cmljZRgQIAEoARIaChJmb3JjZV9jbG9zZV9yZWFzb24YESABKAUSFwoPaXNf",
            "YXV0b19zdXNwZW5kGBIgASgFQkQKFWlvLmV2ZWx5bm4uYmFzZS5wcm90b0IU",
            "SW5wdXRPcmRlckZpZWxkUHJvdG+qAhRFdmVseW5uLkJhc2UuUmVxdWVzdGIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Evelynn.Base.Request.InputOrderField), global::Evelynn.Base.Request.InputOrderField.Parser, new[]{ "BrokerId", "InvestorId", "UserId", "InstrumentId", "ExchangeId", "OrderPriceType", "Direction", "CombOffsetFlag", "CombHedgeFlag", "LimitPrice", "VolumeTotalOriginal", "TimeCondition", "VolumeCondition", "MinVolume", "ContigentCondition", "StopPrice", "ForceCloseReason", "IsAutoSuspend" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InputOrderField : pb::IMessage<InputOrderField>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InputOrderField> _parser = new pb::MessageParser<InputOrderField>(() => new InputOrderField());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InputOrderField> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Evelynn.Base.Request.ReqInputOrderReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InputOrderField() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InputOrderField(InputOrderField other) : this() {
      brokerId_ = other.brokerId_;
      investorId_ = other.investorId_;
      userId_ = other.userId_;
      instrumentId_ = other.instrumentId_;
      exchangeId_ = other.exchangeId_;
      orderPriceType_ = other.orderPriceType_;
      direction_ = other.direction_;
      combOffsetFlag_ = other.combOffsetFlag_;
      combHedgeFlag_ = other.combHedgeFlag_;
      limitPrice_ = other.limitPrice_;
      volumeTotalOriginal_ = other.volumeTotalOriginal_;
      timeCondition_ = other.timeCondition_;
      volumeCondition_ = other.volumeCondition_;
      minVolume_ = other.minVolume_;
      contigentCondition_ = other.contigentCondition_;
      stopPrice_ = other.stopPrice_;
      forceCloseReason_ = other.forceCloseReason_;
      isAutoSuspend_ = other.isAutoSuspend_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InputOrderField Clone() {
      return new InputOrderField(this);
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

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 3;
    private string userId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "instrument_id" field.</summary>
    public const int InstrumentIdFieldNumber = 4;
    private string instrumentId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InstrumentId {
      get { return instrumentId_; }
      set {
        instrumentId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "exchange_id" field.</summary>
    public const int ExchangeIdFieldNumber = 5;
    private string exchangeId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExchangeId {
      get { return exchangeId_; }
      set {
        exchangeId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "order_price_type" field.</summary>
    public const int OrderPriceTypeFieldNumber = 6;
    private int orderPriceType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int OrderPriceType {
      get { return orderPriceType_; }
      set {
        orderPriceType_ = value;
      }
    }

    /// <summary>Field number for the "direction" field.</summary>
    public const int DirectionFieldNumber = 7;
    private int direction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Direction {
      get { return direction_; }
      set {
        direction_ = value;
      }
    }

    /// <summary>Field number for the "comb_offset_flag" field.</summary>
    public const int CombOffsetFlagFieldNumber = 8;
    private int combOffsetFlag_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CombOffsetFlag {
      get { return combOffsetFlag_; }
      set {
        combOffsetFlag_ = value;
      }
    }

    /// <summary>Field number for the "comb_hedge_flag" field.</summary>
    public const int CombHedgeFlagFieldNumber = 9;
    private int combHedgeFlag_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CombHedgeFlag {
      get { return combHedgeFlag_; }
      set {
        combHedgeFlag_ = value;
      }
    }

    /// <summary>Field number for the "limit_price" field.</summary>
    public const int LimitPriceFieldNumber = 10;
    private double limitPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double LimitPrice {
      get { return limitPrice_; }
      set {
        limitPrice_ = value;
      }
    }

    /// <summary>Field number for the "volume_total_original" field.</summary>
    public const int VolumeTotalOriginalFieldNumber = 11;
    private int volumeTotalOriginal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int VolumeTotalOriginal {
      get { return volumeTotalOriginal_; }
      set {
        volumeTotalOriginal_ = value;
      }
    }

    /// <summary>Field number for the "time_condition" field.</summary>
    public const int TimeConditionFieldNumber = 12;
    private int timeCondition_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TimeCondition {
      get { return timeCondition_; }
      set {
        timeCondition_ = value;
      }
    }

    /// <summary>Field number for the "volume_condition" field.</summary>
    public const int VolumeConditionFieldNumber = 13;
    private int volumeCondition_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int VolumeCondition {
      get { return volumeCondition_; }
      set {
        volumeCondition_ = value;
      }
    }

    /// <summary>Field number for the "min_volume" field.</summary>
    public const int MinVolumeFieldNumber = 14;
    private int minVolume_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MinVolume {
      get { return minVolume_; }
      set {
        minVolume_ = value;
      }
    }

    /// <summary>Field number for the "contigent_condition" field.</summary>
    public const int ContigentConditionFieldNumber = 15;
    private int contigentCondition_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ContigentCondition {
      get { return contigentCondition_; }
      set {
        contigentCondition_ = value;
      }
    }

    /// <summary>Field number for the "stop_price" field.</summary>
    public const int StopPriceFieldNumber = 16;
    private double stopPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double StopPrice {
      get { return stopPrice_; }
      set {
        stopPrice_ = value;
      }
    }

    /// <summary>Field number for the "force_close_reason" field.</summary>
    public const int ForceCloseReasonFieldNumber = 17;
    private int forceCloseReason_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ForceCloseReason {
      get { return forceCloseReason_; }
      set {
        forceCloseReason_ = value;
      }
    }

    /// <summary>Field number for the "is_auto_suspend" field.</summary>
    public const int IsAutoSuspendFieldNumber = 18;
    private int isAutoSuspend_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int IsAutoSuspend {
      get { return isAutoSuspend_; }
      set {
        isAutoSuspend_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InputOrderField);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InputOrderField other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BrokerId != other.BrokerId) return false;
      if (InvestorId != other.InvestorId) return false;
      if (UserId != other.UserId) return false;
      if (InstrumentId != other.InstrumentId) return false;
      if (ExchangeId != other.ExchangeId) return false;
      if (OrderPriceType != other.OrderPriceType) return false;
      if (Direction != other.Direction) return false;
      if (CombOffsetFlag != other.CombOffsetFlag) return false;
      if (CombHedgeFlag != other.CombHedgeFlag) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LimitPrice, other.LimitPrice)) return false;
      if (VolumeTotalOriginal != other.VolumeTotalOriginal) return false;
      if (TimeCondition != other.TimeCondition) return false;
      if (VolumeCondition != other.VolumeCondition) return false;
      if (MinVolume != other.MinVolume) return false;
      if (ContigentCondition != other.ContigentCondition) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(StopPrice, other.StopPrice)) return false;
      if (ForceCloseReason != other.ForceCloseReason) return false;
      if (IsAutoSuspend != other.IsAutoSuspend) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BrokerId.Length != 0) hash ^= BrokerId.GetHashCode();
      if (InvestorId.Length != 0) hash ^= InvestorId.GetHashCode();
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      if (InstrumentId.Length != 0) hash ^= InstrumentId.GetHashCode();
      if (ExchangeId.Length != 0) hash ^= ExchangeId.GetHashCode();
      if (OrderPriceType != 0) hash ^= OrderPriceType.GetHashCode();
      if (Direction != 0) hash ^= Direction.GetHashCode();
      if (CombOffsetFlag != 0) hash ^= CombOffsetFlag.GetHashCode();
      if (CombHedgeFlag != 0) hash ^= CombHedgeFlag.GetHashCode();
      if (LimitPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LimitPrice);
      if (VolumeTotalOriginal != 0) hash ^= VolumeTotalOriginal.GetHashCode();
      if (TimeCondition != 0) hash ^= TimeCondition.GetHashCode();
      if (VolumeCondition != 0) hash ^= VolumeCondition.GetHashCode();
      if (MinVolume != 0) hash ^= MinVolume.GetHashCode();
      if (ContigentCondition != 0) hash ^= ContigentCondition.GetHashCode();
      if (StopPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(StopPrice);
      if (ForceCloseReason != 0) hash ^= ForceCloseReason.GetHashCode();
      if (IsAutoSuspend != 0) hash ^= IsAutoSuspend.GetHashCode();
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
      if (UserId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(UserId);
      }
      if (InstrumentId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(InstrumentId);
      }
      if (ExchangeId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ExchangeId);
      }
      if (OrderPriceType != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(OrderPriceType);
      }
      if (Direction != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Direction);
      }
      if (CombOffsetFlag != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(CombOffsetFlag);
      }
      if (CombHedgeFlag != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(CombHedgeFlag);
      }
      if (LimitPrice != 0D) {
        output.WriteRawTag(81);
        output.WriteDouble(LimitPrice);
      }
      if (VolumeTotalOriginal != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(VolumeTotalOriginal);
      }
      if (TimeCondition != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(TimeCondition);
      }
      if (VolumeCondition != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(VolumeCondition);
      }
      if (MinVolume != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(MinVolume);
      }
      if (ContigentCondition != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(ContigentCondition);
      }
      if (StopPrice != 0D) {
        output.WriteRawTag(129, 1);
        output.WriteDouble(StopPrice);
      }
      if (ForceCloseReason != 0) {
        output.WriteRawTag(136, 1);
        output.WriteInt32(ForceCloseReason);
      }
      if (IsAutoSuspend != 0) {
        output.WriteRawTag(144, 1);
        output.WriteInt32(IsAutoSuspend);
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
      if (UserId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(UserId);
      }
      if (InstrumentId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(InstrumentId);
      }
      if (ExchangeId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ExchangeId);
      }
      if (OrderPriceType != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(OrderPriceType);
      }
      if (Direction != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Direction);
      }
      if (CombOffsetFlag != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(CombOffsetFlag);
      }
      if (CombHedgeFlag != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(CombHedgeFlag);
      }
      if (LimitPrice != 0D) {
        output.WriteRawTag(81);
        output.WriteDouble(LimitPrice);
      }
      if (VolumeTotalOriginal != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(VolumeTotalOriginal);
      }
      if (TimeCondition != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(TimeCondition);
      }
      if (VolumeCondition != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(VolumeCondition);
      }
      if (MinVolume != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(MinVolume);
      }
      if (ContigentCondition != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(ContigentCondition);
      }
      if (StopPrice != 0D) {
        output.WriteRawTag(129, 1);
        output.WriteDouble(StopPrice);
      }
      if (ForceCloseReason != 0) {
        output.WriteRawTag(136, 1);
        output.WriteInt32(ForceCloseReason);
      }
      if (IsAutoSuspend != 0) {
        output.WriteRawTag(144, 1);
        output.WriteInt32(IsAutoSuspend);
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
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      if (InstrumentId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InstrumentId);
      }
      if (ExchangeId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ExchangeId);
      }
      if (OrderPriceType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(OrderPriceType);
      }
      if (Direction != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Direction);
      }
      if (CombOffsetFlag != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CombOffsetFlag);
      }
      if (CombHedgeFlag != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CombHedgeFlag);
      }
      if (LimitPrice != 0D) {
        size += 1 + 8;
      }
      if (VolumeTotalOriginal != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(VolumeTotalOriginal);
      }
      if (TimeCondition != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TimeCondition);
      }
      if (VolumeCondition != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(VolumeCondition);
      }
      if (MinVolume != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MinVolume);
      }
      if (ContigentCondition != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ContigentCondition);
      }
      if (StopPrice != 0D) {
        size += 2 + 8;
      }
      if (ForceCloseReason != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(ForceCloseReason);
      }
      if (IsAutoSuspend != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(IsAutoSuspend);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InputOrderField other) {
      if (other == null) {
        return;
      }
      if (other.BrokerId.Length != 0) {
        BrokerId = other.BrokerId;
      }
      if (other.InvestorId.Length != 0) {
        InvestorId = other.InvestorId;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
      if (other.InstrumentId.Length != 0) {
        InstrumentId = other.InstrumentId;
      }
      if (other.ExchangeId.Length != 0) {
        ExchangeId = other.ExchangeId;
      }
      if (other.OrderPriceType != 0) {
        OrderPriceType = other.OrderPriceType;
      }
      if (other.Direction != 0) {
        Direction = other.Direction;
      }
      if (other.CombOffsetFlag != 0) {
        CombOffsetFlag = other.CombOffsetFlag;
      }
      if (other.CombHedgeFlag != 0) {
        CombHedgeFlag = other.CombHedgeFlag;
      }
      if (other.LimitPrice != 0D) {
        LimitPrice = other.LimitPrice;
      }
      if (other.VolumeTotalOriginal != 0) {
        VolumeTotalOriginal = other.VolumeTotalOriginal;
      }
      if (other.TimeCondition != 0) {
        TimeCondition = other.TimeCondition;
      }
      if (other.VolumeCondition != 0) {
        VolumeCondition = other.VolumeCondition;
      }
      if (other.MinVolume != 0) {
        MinVolume = other.MinVolume;
      }
      if (other.ContigentCondition != 0) {
        ContigentCondition = other.ContigentCondition;
      }
      if (other.StopPrice != 0D) {
        StopPrice = other.StopPrice;
      }
      if (other.ForceCloseReason != 0) {
        ForceCloseReason = other.ForceCloseReason;
      }
      if (other.IsAutoSuspend != 0) {
        IsAutoSuspend = other.IsAutoSuspend;
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
            UserId = input.ReadString();
            break;
          }
          case 34: {
            InstrumentId = input.ReadString();
            break;
          }
          case 42: {
            ExchangeId = input.ReadString();
            break;
          }
          case 48: {
            OrderPriceType = input.ReadInt32();
            break;
          }
          case 56: {
            Direction = input.ReadInt32();
            break;
          }
          case 64: {
            CombOffsetFlag = input.ReadInt32();
            break;
          }
          case 72: {
            CombHedgeFlag = input.ReadInt32();
            break;
          }
          case 81: {
            LimitPrice = input.ReadDouble();
            break;
          }
          case 88: {
            VolumeTotalOriginal = input.ReadInt32();
            break;
          }
          case 96: {
            TimeCondition = input.ReadInt32();
            break;
          }
          case 104: {
            VolumeCondition = input.ReadInt32();
            break;
          }
          case 112: {
            MinVolume = input.ReadInt32();
            break;
          }
          case 120: {
            ContigentCondition = input.ReadInt32();
            break;
          }
          case 129: {
            StopPrice = input.ReadDouble();
            break;
          }
          case 136: {
            ForceCloseReason = input.ReadInt32();
            break;
          }
          case 144: {
            IsAutoSuspend = input.ReadInt32();
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
            UserId = input.ReadString();
            break;
          }
          case 34: {
            InstrumentId = input.ReadString();
            break;
          }
          case 42: {
            ExchangeId = input.ReadString();
            break;
          }
          case 48: {
            OrderPriceType = input.ReadInt32();
            break;
          }
          case 56: {
            Direction = input.ReadInt32();
            break;
          }
          case 64: {
            CombOffsetFlag = input.ReadInt32();
            break;
          }
          case 72: {
            CombHedgeFlag = input.ReadInt32();
            break;
          }
          case 81: {
            LimitPrice = input.ReadDouble();
            break;
          }
          case 88: {
            VolumeTotalOriginal = input.ReadInt32();
            break;
          }
          case 96: {
            TimeCondition = input.ReadInt32();
            break;
          }
          case 104: {
            VolumeCondition = input.ReadInt32();
            break;
          }
          case 112: {
            MinVolume = input.ReadInt32();
            break;
          }
          case 120: {
            ContigentCondition = input.ReadInt32();
            break;
          }
          case 129: {
            StopPrice = input.ReadDouble();
            break;
          }
          case 136: {
            ForceCloseReason = input.ReadInt32();
            break;
          }
          case 144: {
            IsAutoSuspend = input.ReadInt32();
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
