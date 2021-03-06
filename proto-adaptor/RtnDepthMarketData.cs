// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Rtn.DepthMarketData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Evelynn.Base.Return {

  /// <summary>Holder for reflection information generated from Rtn.DepthMarketData.proto</summary>
  public static partial class RtnDepthMarketDataReflection {

    #region Descriptor
    /// <summary>File descriptor for Rtn.DepthMarketData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RtnDepthMarketDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlSdG4uRGVwdGhNYXJrZXREYXRhLnByb3RvEgNydG4ixAQKFERlcHRoTWFy",
            "a2V0RGF0YUZpZWxkEhMKC3RyYWRpbmdfZGF5GAEgASgJEhUKDWluc3RydW1l",
            "bnRfaWQYAiABKAkSEwoLZXhjaGFuZ2VfaWQYAyABKAkSEgoKbGFzdF9wcmlj",
            "ZRgEIAEoARIcChRwcmVfc2V0dGxlbWVudF9wcmljZRgFIAEoARIXCg9wcmVf",
            "Y2xvc2VfcHJpY2UYBiABKAESGQoRcHJlX29wZW5faW50ZXJlc3QYByABKAUS",
            "EgoKb3Blbl9wcmljZRgIIAEoARIVCg1oaWdoZXN0X3ByaWNlGAkgASgBEhQK",
            "DGxvd2VzdF9wcmljZRgKIAEoARIOCgZ2b2x1bWUYCyABKAUSEQoJdHVybl9v",
            "dmVyGAwgASgBEhUKDW9wZW5faW50ZXJlc3QYDSABKAUSEwoLY2xvc2VfcHJp",
            "Y2UYDiABKAESGAoQc2V0dGxlbWVudF9wcmljZRgPIAEoARIZChF1cHBlcl9s",
            "aW1pdF9wcmljZRgQIAEoARIZChFsb3dlcl9saW1pdF9wcmljZRgRIAEoARIT",
            "Cgt1cGRhdGVfdGltZRgSIAEoCRIXCg91cGRhdGVfbWlsbGlzZWMYEyABKAUS",
            "FQoNYXZlcmFnZV9wcmljZRgUIAEoARISCgphY3Rpb25fZGF5GBUgASgJEhEK",
            "CWJpZF9wcmljZRgWIAEoARISCgpiaWRfdm9sdW1lGBcgASgFEhEKCWFza19w",
            "cmljZRgYIAEoARISCgphc2tfdm9sdW1lGBkgASgFQkgKFWlvLmV2ZWx5bm4u",
            "YmFzZS5wcm90b0IZRGVwdGhNYXJrZXREYXRhRmllbGRQcm90b6oCE0V2ZWx5",
            "bm4uQmFzZS5SZXR1cm5iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Evelynn.Base.Return.DepthMarketDataField), global::Evelynn.Base.Return.DepthMarketDataField.Parser, new[]{ "TradingDay", "InstrumentId", "ExchangeId", "LastPrice", "PreSettlementPrice", "PreClosePrice", "PreOpenInterest", "OpenPrice", "HighestPrice", "LowestPrice", "Volume", "TurnOver", "OpenInterest", "ClosePrice", "SettlementPrice", "UpperLimitPrice", "LowerLimitPrice", "UpdateTime", "UpdateMillisec", "AveragePrice", "ActionDay", "BidPrice", "BidVolume", "AskPrice", "AskVolume" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DepthMarketDataField : pb::IMessage<DepthMarketDataField>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DepthMarketDataField> _parser = new pb::MessageParser<DepthMarketDataField>(() => new DepthMarketDataField());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DepthMarketDataField> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Evelynn.Base.Return.RtnDepthMarketDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DepthMarketDataField() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DepthMarketDataField(DepthMarketDataField other) : this() {
      tradingDay_ = other.tradingDay_;
      instrumentId_ = other.instrumentId_;
      exchangeId_ = other.exchangeId_;
      lastPrice_ = other.lastPrice_;
      preSettlementPrice_ = other.preSettlementPrice_;
      preClosePrice_ = other.preClosePrice_;
      preOpenInterest_ = other.preOpenInterest_;
      openPrice_ = other.openPrice_;
      highestPrice_ = other.highestPrice_;
      lowestPrice_ = other.lowestPrice_;
      volume_ = other.volume_;
      turnOver_ = other.turnOver_;
      openInterest_ = other.openInterest_;
      closePrice_ = other.closePrice_;
      settlementPrice_ = other.settlementPrice_;
      upperLimitPrice_ = other.upperLimitPrice_;
      lowerLimitPrice_ = other.lowerLimitPrice_;
      updateTime_ = other.updateTime_;
      updateMillisec_ = other.updateMillisec_;
      averagePrice_ = other.averagePrice_;
      actionDay_ = other.actionDay_;
      bidPrice_ = other.bidPrice_;
      bidVolume_ = other.bidVolume_;
      askPrice_ = other.askPrice_;
      askVolume_ = other.askVolume_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DepthMarketDataField Clone() {
      return new DepthMarketDataField(this);
    }

    /// <summary>Field number for the "trading_day" field.</summary>
    public const int TradingDayFieldNumber = 1;
    private string tradingDay_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TradingDay {
      get { return tradingDay_; }
      set {
        tradingDay_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "instrument_id" field.</summary>
    public const int InstrumentIdFieldNumber = 2;
    private string instrumentId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InstrumentId {
      get { return instrumentId_; }
      set {
        instrumentId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "exchange_id" field.</summary>
    public const int ExchangeIdFieldNumber = 3;
    private string exchangeId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExchangeId {
      get { return exchangeId_; }
      set {
        exchangeId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_price" field.</summary>
    public const int LastPriceFieldNumber = 4;
    private double lastPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double LastPrice {
      get { return lastPrice_; }
      set {
        lastPrice_ = value;
      }
    }

    /// <summary>Field number for the "pre_settlement_price" field.</summary>
    public const int PreSettlementPriceFieldNumber = 5;
    private double preSettlementPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PreSettlementPrice {
      get { return preSettlementPrice_; }
      set {
        preSettlementPrice_ = value;
      }
    }

    /// <summary>Field number for the "pre_close_price" field.</summary>
    public const int PreClosePriceFieldNumber = 6;
    private double preClosePrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PreClosePrice {
      get { return preClosePrice_; }
      set {
        preClosePrice_ = value;
      }
    }

    /// <summary>Field number for the "pre_open_interest" field.</summary>
    public const int PreOpenInterestFieldNumber = 7;
    private int preOpenInterest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PreOpenInterest {
      get { return preOpenInterest_; }
      set {
        preOpenInterest_ = value;
      }
    }

    /// <summary>Field number for the "open_price" field.</summary>
    public const int OpenPriceFieldNumber = 8;
    private double openPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double OpenPrice {
      get { return openPrice_; }
      set {
        openPrice_ = value;
      }
    }

    /// <summary>Field number for the "highest_price" field.</summary>
    public const int HighestPriceFieldNumber = 9;
    private double highestPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double HighestPrice {
      get { return highestPrice_; }
      set {
        highestPrice_ = value;
      }
    }

    /// <summary>Field number for the "lowest_price" field.</summary>
    public const int LowestPriceFieldNumber = 10;
    private double lowestPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double LowestPrice {
      get { return lowestPrice_; }
      set {
        lowestPrice_ = value;
      }
    }

    /// <summary>Field number for the "volume" field.</summary>
    public const int VolumeFieldNumber = 11;
    private int volume_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Volume {
      get { return volume_; }
      set {
        volume_ = value;
      }
    }

    /// <summary>Field number for the "turn_over" field.</summary>
    public const int TurnOverFieldNumber = 12;
    private double turnOver_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double TurnOver {
      get { return turnOver_; }
      set {
        turnOver_ = value;
      }
    }

    /// <summary>Field number for the "open_interest" field.</summary>
    public const int OpenInterestFieldNumber = 13;
    private int openInterest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int OpenInterest {
      get { return openInterest_; }
      set {
        openInterest_ = value;
      }
    }

    /// <summary>Field number for the "close_price" field.</summary>
    public const int ClosePriceFieldNumber = 14;
    private double closePrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double ClosePrice {
      get { return closePrice_; }
      set {
        closePrice_ = value;
      }
    }

    /// <summary>Field number for the "settlement_price" field.</summary>
    public const int SettlementPriceFieldNumber = 15;
    private double settlementPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double SettlementPrice {
      get { return settlementPrice_; }
      set {
        settlementPrice_ = value;
      }
    }

    /// <summary>Field number for the "upper_limit_price" field.</summary>
    public const int UpperLimitPriceFieldNumber = 16;
    private double upperLimitPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double UpperLimitPrice {
      get { return upperLimitPrice_; }
      set {
        upperLimitPrice_ = value;
      }
    }

    /// <summary>Field number for the "lower_limit_price" field.</summary>
    public const int LowerLimitPriceFieldNumber = 17;
    private double lowerLimitPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double LowerLimitPrice {
      get { return lowerLimitPrice_; }
      set {
        lowerLimitPrice_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 18;
    private string updateTime_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "update_millisec" field.</summary>
    public const int UpdateMillisecFieldNumber = 19;
    private int updateMillisec_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UpdateMillisec {
      get { return updateMillisec_; }
      set {
        updateMillisec_ = value;
      }
    }

    /// <summary>Field number for the "average_price" field.</summary>
    public const int AveragePriceFieldNumber = 20;
    private double averagePrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double AveragePrice {
      get { return averagePrice_; }
      set {
        averagePrice_ = value;
      }
    }

    /// <summary>Field number for the "action_day" field.</summary>
    public const int ActionDayFieldNumber = 21;
    private string actionDay_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ActionDay {
      get { return actionDay_; }
      set {
        actionDay_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "bid_price" field.</summary>
    public const int BidPriceFieldNumber = 22;
    private double bidPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double BidPrice {
      get { return bidPrice_; }
      set {
        bidPrice_ = value;
      }
    }

    /// <summary>Field number for the "bid_volume" field.</summary>
    public const int BidVolumeFieldNumber = 23;
    private int bidVolume_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BidVolume {
      get { return bidVolume_; }
      set {
        bidVolume_ = value;
      }
    }

    /// <summary>Field number for the "ask_price" field.</summary>
    public const int AskPriceFieldNumber = 24;
    private double askPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double AskPrice {
      get { return askPrice_; }
      set {
        askPrice_ = value;
      }
    }

    /// <summary>Field number for the "ask_volume" field.</summary>
    public const int AskVolumeFieldNumber = 25;
    private int askVolume_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int AskVolume {
      get { return askVolume_; }
      set {
        askVolume_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DepthMarketDataField);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DepthMarketDataField other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TradingDay != other.TradingDay) return false;
      if (InstrumentId != other.InstrumentId) return false;
      if (ExchangeId != other.ExchangeId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LastPrice, other.LastPrice)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PreSettlementPrice, other.PreSettlementPrice)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PreClosePrice, other.PreClosePrice)) return false;
      if (PreOpenInterest != other.PreOpenInterest) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(OpenPrice, other.OpenPrice)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(HighestPrice, other.HighestPrice)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LowestPrice, other.LowestPrice)) return false;
      if (Volume != other.Volume) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TurnOver, other.TurnOver)) return false;
      if (OpenInterest != other.OpenInterest) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ClosePrice, other.ClosePrice)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(SettlementPrice, other.SettlementPrice)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(UpperLimitPrice, other.UpperLimitPrice)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LowerLimitPrice, other.LowerLimitPrice)) return false;
      if (UpdateTime != other.UpdateTime) return false;
      if (UpdateMillisec != other.UpdateMillisec) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(AveragePrice, other.AveragePrice)) return false;
      if (ActionDay != other.ActionDay) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BidPrice, other.BidPrice)) return false;
      if (BidVolume != other.BidVolume) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(AskPrice, other.AskPrice)) return false;
      if (AskVolume != other.AskVolume) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TradingDay.Length != 0) hash ^= TradingDay.GetHashCode();
      if (InstrumentId.Length != 0) hash ^= InstrumentId.GetHashCode();
      if (ExchangeId.Length != 0) hash ^= ExchangeId.GetHashCode();
      if (LastPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LastPrice);
      if (PreSettlementPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PreSettlementPrice);
      if (PreClosePrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PreClosePrice);
      if (PreOpenInterest != 0) hash ^= PreOpenInterest.GetHashCode();
      if (OpenPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(OpenPrice);
      if (HighestPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(HighestPrice);
      if (LowestPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LowestPrice);
      if (Volume != 0) hash ^= Volume.GetHashCode();
      if (TurnOver != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TurnOver);
      if (OpenInterest != 0) hash ^= OpenInterest.GetHashCode();
      if (ClosePrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ClosePrice);
      if (SettlementPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(SettlementPrice);
      if (UpperLimitPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(UpperLimitPrice);
      if (LowerLimitPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LowerLimitPrice);
      if (UpdateTime.Length != 0) hash ^= UpdateTime.GetHashCode();
      if (UpdateMillisec != 0) hash ^= UpdateMillisec.GetHashCode();
      if (AveragePrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(AveragePrice);
      if (ActionDay.Length != 0) hash ^= ActionDay.GetHashCode();
      if (BidPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BidPrice);
      if (BidVolume != 0) hash ^= BidVolume.GetHashCode();
      if (AskPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(AskPrice);
      if (AskVolume != 0) hash ^= AskVolume.GetHashCode();
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
      if (TradingDay.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TradingDay);
      }
      if (InstrumentId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(InstrumentId);
      }
      if (ExchangeId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ExchangeId);
      }
      if (LastPrice != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(LastPrice);
      }
      if (PreSettlementPrice != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(PreSettlementPrice);
      }
      if (PreClosePrice != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(PreClosePrice);
      }
      if (PreOpenInterest != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(PreOpenInterest);
      }
      if (OpenPrice != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(OpenPrice);
      }
      if (HighestPrice != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(HighestPrice);
      }
      if (LowestPrice != 0D) {
        output.WriteRawTag(81);
        output.WriteDouble(LowestPrice);
      }
      if (Volume != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Volume);
      }
      if (TurnOver != 0D) {
        output.WriteRawTag(97);
        output.WriteDouble(TurnOver);
      }
      if (OpenInterest != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(OpenInterest);
      }
      if (ClosePrice != 0D) {
        output.WriteRawTag(113);
        output.WriteDouble(ClosePrice);
      }
      if (SettlementPrice != 0D) {
        output.WriteRawTag(121);
        output.WriteDouble(SettlementPrice);
      }
      if (UpperLimitPrice != 0D) {
        output.WriteRawTag(129, 1);
        output.WriteDouble(UpperLimitPrice);
      }
      if (LowerLimitPrice != 0D) {
        output.WriteRawTag(137, 1);
        output.WriteDouble(LowerLimitPrice);
      }
      if (UpdateTime.Length != 0) {
        output.WriteRawTag(146, 1);
        output.WriteString(UpdateTime);
      }
      if (UpdateMillisec != 0) {
        output.WriteRawTag(152, 1);
        output.WriteInt32(UpdateMillisec);
      }
      if (AveragePrice != 0D) {
        output.WriteRawTag(161, 1);
        output.WriteDouble(AveragePrice);
      }
      if (ActionDay.Length != 0) {
        output.WriteRawTag(170, 1);
        output.WriteString(ActionDay);
      }
      if (BidPrice != 0D) {
        output.WriteRawTag(177, 1);
        output.WriteDouble(BidPrice);
      }
      if (BidVolume != 0) {
        output.WriteRawTag(184, 1);
        output.WriteInt32(BidVolume);
      }
      if (AskPrice != 0D) {
        output.WriteRawTag(193, 1);
        output.WriteDouble(AskPrice);
      }
      if (AskVolume != 0) {
        output.WriteRawTag(200, 1);
        output.WriteInt32(AskVolume);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (TradingDay.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TradingDay);
      }
      if (InstrumentId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(InstrumentId);
      }
      if (ExchangeId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ExchangeId);
      }
      if (LastPrice != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(LastPrice);
      }
      if (PreSettlementPrice != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(PreSettlementPrice);
      }
      if (PreClosePrice != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(PreClosePrice);
      }
      if (PreOpenInterest != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(PreOpenInterest);
      }
      if (OpenPrice != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(OpenPrice);
      }
      if (HighestPrice != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(HighestPrice);
      }
      if (LowestPrice != 0D) {
        output.WriteRawTag(81);
        output.WriteDouble(LowestPrice);
      }
      if (Volume != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Volume);
      }
      if (TurnOver != 0D) {
        output.WriteRawTag(97);
        output.WriteDouble(TurnOver);
      }
      if (OpenInterest != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(OpenInterest);
      }
      if (ClosePrice != 0D) {
        output.WriteRawTag(113);
        output.WriteDouble(ClosePrice);
      }
      if (SettlementPrice != 0D) {
        output.WriteRawTag(121);
        output.WriteDouble(SettlementPrice);
      }
      if (UpperLimitPrice != 0D) {
        output.WriteRawTag(129, 1);
        output.WriteDouble(UpperLimitPrice);
      }
      if (LowerLimitPrice != 0D) {
        output.WriteRawTag(137, 1);
        output.WriteDouble(LowerLimitPrice);
      }
      if (UpdateTime.Length != 0) {
        output.WriteRawTag(146, 1);
        output.WriteString(UpdateTime);
      }
      if (UpdateMillisec != 0) {
        output.WriteRawTag(152, 1);
        output.WriteInt32(UpdateMillisec);
      }
      if (AveragePrice != 0D) {
        output.WriteRawTag(161, 1);
        output.WriteDouble(AveragePrice);
      }
      if (ActionDay.Length != 0) {
        output.WriteRawTag(170, 1);
        output.WriteString(ActionDay);
      }
      if (BidPrice != 0D) {
        output.WriteRawTag(177, 1);
        output.WriteDouble(BidPrice);
      }
      if (BidVolume != 0) {
        output.WriteRawTag(184, 1);
        output.WriteInt32(BidVolume);
      }
      if (AskPrice != 0D) {
        output.WriteRawTag(193, 1);
        output.WriteDouble(AskPrice);
      }
      if (AskVolume != 0) {
        output.WriteRawTag(200, 1);
        output.WriteInt32(AskVolume);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TradingDay.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TradingDay);
      }
      if (InstrumentId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InstrumentId);
      }
      if (ExchangeId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ExchangeId);
      }
      if (LastPrice != 0D) {
        size += 1 + 8;
      }
      if (PreSettlementPrice != 0D) {
        size += 1 + 8;
      }
      if (PreClosePrice != 0D) {
        size += 1 + 8;
      }
      if (PreOpenInterest != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PreOpenInterest);
      }
      if (OpenPrice != 0D) {
        size += 1 + 8;
      }
      if (HighestPrice != 0D) {
        size += 1 + 8;
      }
      if (LowestPrice != 0D) {
        size += 1 + 8;
      }
      if (Volume != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Volume);
      }
      if (TurnOver != 0D) {
        size += 1 + 8;
      }
      if (OpenInterest != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(OpenInterest);
      }
      if (ClosePrice != 0D) {
        size += 1 + 8;
      }
      if (SettlementPrice != 0D) {
        size += 1 + 8;
      }
      if (UpperLimitPrice != 0D) {
        size += 2 + 8;
      }
      if (LowerLimitPrice != 0D) {
        size += 2 + 8;
      }
      if (UpdateTime.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(UpdateTime);
      }
      if (UpdateMillisec != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(UpdateMillisec);
      }
      if (AveragePrice != 0D) {
        size += 2 + 8;
      }
      if (ActionDay.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ActionDay);
      }
      if (BidPrice != 0D) {
        size += 2 + 8;
      }
      if (BidVolume != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(BidVolume);
      }
      if (AskPrice != 0D) {
        size += 2 + 8;
      }
      if (AskVolume != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(AskVolume);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DepthMarketDataField other) {
      if (other == null) {
        return;
      }
      if (other.TradingDay.Length != 0) {
        TradingDay = other.TradingDay;
      }
      if (other.InstrumentId.Length != 0) {
        InstrumentId = other.InstrumentId;
      }
      if (other.ExchangeId.Length != 0) {
        ExchangeId = other.ExchangeId;
      }
      if (other.LastPrice != 0D) {
        LastPrice = other.LastPrice;
      }
      if (other.PreSettlementPrice != 0D) {
        PreSettlementPrice = other.PreSettlementPrice;
      }
      if (other.PreClosePrice != 0D) {
        PreClosePrice = other.PreClosePrice;
      }
      if (other.PreOpenInterest != 0) {
        PreOpenInterest = other.PreOpenInterest;
      }
      if (other.OpenPrice != 0D) {
        OpenPrice = other.OpenPrice;
      }
      if (other.HighestPrice != 0D) {
        HighestPrice = other.HighestPrice;
      }
      if (other.LowestPrice != 0D) {
        LowestPrice = other.LowestPrice;
      }
      if (other.Volume != 0) {
        Volume = other.Volume;
      }
      if (other.TurnOver != 0D) {
        TurnOver = other.TurnOver;
      }
      if (other.OpenInterest != 0) {
        OpenInterest = other.OpenInterest;
      }
      if (other.ClosePrice != 0D) {
        ClosePrice = other.ClosePrice;
      }
      if (other.SettlementPrice != 0D) {
        SettlementPrice = other.SettlementPrice;
      }
      if (other.UpperLimitPrice != 0D) {
        UpperLimitPrice = other.UpperLimitPrice;
      }
      if (other.LowerLimitPrice != 0D) {
        LowerLimitPrice = other.LowerLimitPrice;
      }
      if (other.UpdateTime.Length != 0) {
        UpdateTime = other.UpdateTime;
      }
      if (other.UpdateMillisec != 0) {
        UpdateMillisec = other.UpdateMillisec;
      }
      if (other.AveragePrice != 0D) {
        AveragePrice = other.AveragePrice;
      }
      if (other.ActionDay.Length != 0) {
        ActionDay = other.ActionDay;
      }
      if (other.BidPrice != 0D) {
        BidPrice = other.BidPrice;
      }
      if (other.BidVolume != 0) {
        BidVolume = other.BidVolume;
      }
      if (other.AskPrice != 0D) {
        AskPrice = other.AskPrice;
      }
      if (other.AskVolume != 0) {
        AskVolume = other.AskVolume;
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
            TradingDay = input.ReadString();
            break;
          }
          case 18: {
            InstrumentId = input.ReadString();
            break;
          }
          case 26: {
            ExchangeId = input.ReadString();
            break;
          }
          case 33: {
            LastPrice = input.ReadDouble();
            break;
          }
          case 41: {
            PreSettlementPrice = input.ReadDouble();
            break;
          }
          case 49: {
            PreClosePrice = input.ReadDouble();
            break;
          }
          case 56: {
            PreOpenInterest = input.ReadInt32();
            break;
          }
          case 65: {
            OpenPrice = input.ReadDouble();
            break;
          }
          case 73: {
            HighestPrice = input.ReadDouble();
            break;
          }
          case 81: {
            LowestPrice = input.ReadDouble();
            break;
          }
          case 88: {
            Volume = input.ReadInt32();
            break;
          }
          case 97: {
            TurnOver = input.ReadDouble();
            break;
          }
          case 104: {
            OpenInterest = input.ReadInt32();
            break;
          }
          case 113: {
            ClosePrice = input.ReadDouble();
            break;
          }
          case 121: {
            SettlementPrice = input.ReadDouble();
            break;
          }
          case 129: {
            UpperLimitPrice = input.ReadDouble();
            break;
          }
          case 137: {
            LowerLimitPrice = input.ReadDouble();
            break;
          }
          case 146: {
            UpdateTime = input.ReadString();
            break;
          }
          case 152: {
            UpdateMillisec = input.ReadInt32();
            break;
          }
          case 161: {
            AveragePrice = input.ReadDouble();
            break;
          }
          case 170: {
            ActionDay = input.ReadString();
            break;
          }
          case 177: {
            BidPrice = input.ReadDouble();
            break;
          }
          case 184: {
            BidVolume = input.ReadInt32();
            break;
          }
          case 193: {
            AskPrice = input.ReadDouble();
            break;
          }
          case 200: {
            AskVolume = input.ReadInt32();
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
            TradingDay = input.ReadString();
            break;
          }
          case 18: {
            InstrumentId = input.ReadString();
            break;
          }
          case 26: {
            ExchangeId = input.ReadString();
            break;
          }
          case 33: {
            LastPrice = input.ReadDouble();
            break;
          }
          case 41: {
            PreSettlementPrice = input.ReadDouble();
            break;
          }
          case 49: {
            PreClosePrice = input.ReadDouble();
            break;
          }
          case 56: {
            PreOpenInterest = input.ReadInt32();
            break;
          }
          case 65: {
            OpenPrice = input.ReadDouble();
            break;
          }
          case 73: {
            HighestPrice = input.ReadDouble();
            break;
          }
          case 81: {
            LowestPrice = input.ReadDouble();
            break;
          }
          case 88: {
            Volume = input.ReadInt32();
            break;
          }
          case 97: {
            TurnOver = input.ReadDouble();
            break;
          }
          case 104: {
            OpenInterest = input.ReadInt32();
            break;
          }
          case 113: {
            ClosePrice = input.ReadDouble();
            break;
          }
          case 121: {
            SettlementPrice = input.ReadDouble();
            break;
          }
          case 129: {
            UpperLimitPrice = input.ReadDouble();
            break;
          }
          case 137: {
            LowerLimitPrice = input.ReadDouble();
            break;
          }
          case 146: {
            UpdateTime = input.ReadString();
            break;
          }
          case 152: {
            UpdateMillisec = input.ReadInt32();
            break;
          }
          case 161: {
            AveragePrice = input.ReadDouble();
            break;
          }
          case 170: {
            ActionDay = input.ReadString();
            break;
          }
          case 177: {
            BidPrice = input.ReadDouble();
            break;
          }
          case 184: {
            BidVolume = input.ReadInt32();
            break;
          }
          case 193: {
            AskPrice = input.ReadDouble();
            break;
          }
          case 200: {
            AskVolume = input.ReadInt32();
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
