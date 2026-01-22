using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Payouts;

[JsonConverter(typeof(JsonModelConverter<PayoutUnmaskResponse, PayoutUnmaskResponseFromRaw>))]
public sealed record class PayoutUnmaskResponse : JsonModel
{
    public required PayoutUnmaskResponseData Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<PayoutUnmaskResponseData>("data");
        }
        init { this._rawData.Set("data", value); }
    }

    /// <summary>
    /// Metadata about the API request, including an identifier and timestamp.
    /// </summary>
    public required ResponseMetadata Meta
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ResponseMetadata>("meta");
        }
        init { this._rawData.Set("meta", value); }
    }

    /// <summary>
    /// Indicates the structure of the returned content. - "object" means the `data`
    /// field contains a single JSON object. - "array" means the `data` field contains
    /// an array of objects. - "error" means the `data` field contains an error object
    /// with details of the issue. - "none" means no data is returned.
    /// </summary>
    public required ApiEnum<string, PayoutUnmaskResponseResponseType> ResponseType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, PayoutUnmaskResponseResponseType>>(
                "response_type"
            );
        }
        init { this._rawData.Set("response_type", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Data.Validate();
        this.Meta.Validate();
        this.ResponseType.Validate();
    }

    public PayoutUnmaskResponse() { }

    public PayoutUnmaskResponse(PayoutUnmaskResponse payoutUnmaskResponse)
        : base(payoutUnmaskResponse) { }

    public PayoutUnmaskResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PayoutUnmaskResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PayoutUnmaskResponseFromRaw.FromRawUnchecked"/>
    public static PayoutUnmaskResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PayoutUnmaskResponseFromRaw : IFromRawJson<PayoutUnmaskResponse>
{
    /// <inheritdoc/>
    public PayoutUnmaskResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PayoutUnmaskResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<PayoutUnmaskResponseData, PayoutUnmaskResponseDataFromRaw>)
)]
public sealed record class PayoutUnmaskResponseData : JsonModel
{
    /// <summary>
    /// Id.
    /// </summary>
    public required string ID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("id");
        }
        init { this._rawData.Set("id", value); }
    }

    /// <summary>
    /// Amount.
    /// </summary>
    public required int Amount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("amount");
        }
        init { this._rawData.Set("amount", value); }
    }

    public required PayoutUnmaskResponseDataConfig Config
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<PayoutUnmaskResponseDataConfig>("config");
        }
        init { this._rawData.Set("config", value); }
    }

    /// <summary>
    /// Currency.
    /// </summary>
    public required string Currency
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("currency");
        }
        init { this._rawData.Set("currency", value); }
    }

    /// <summary>
    /// Description.
    /// </summary>
    public required string? Description
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("description");
        }
        init { this._rawData.Set("description", value); }
    }

    public required Device Device
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<Device>("device");
        }
        init { this._rawData.Set("device", value); }
    }

    /// <summary>
    /// External id.
    /// </summary>
    public required string ExternalID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("external_id");
        }
        init { this._rawData.Set("external_id", value); }
    }

    /// <summary>
    /// Funding Ids
    /// </summary>
    public required IReadOnlyList<string> FundingIds
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<ImmutableArray<string>>("funding_ids");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>>(
                "funding_ids",
                ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Paykey.
    /// </summary>
    public required string Paykey
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("paykey");
        }
        init { this._rawData.Set("paykey", value); }
    }

    /// <summary>
    /// Payment date.
    /// </summary>
    public required string PaymentDate
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("payment_date");
        }
        init { this._rawData.Set("payment_date", value); }
    }

    /// <summary>
    /// The current status of the `charge` or `payout`.
    /// </summary>
    public required ApiEnum<string, PayoutUnmaskResponseDataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, PayoutUnmaskResponseDataStatus>>(
                "status"
            );
        }
        init { this._rawData.Set("status", value); }
    }

    public required StatusDetailsV1 StatusDetails
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<StatusDetailsV1>("status_details");
        }
        init { this._rawData.Set("status_details", value); }
    }

    /// <summary>
    /// Status history.
    /// </summary>
    public required IReadOnlyList<PayoutUnmaskResponseDataStatusHistory> StatusHistory
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<
                ImmutableArray<PayoutUnmaskResponseDataStatusHistory>
            >("status_history");
        }
        init
        {
            this._rawData.Set<ImmutableArray<PayoutUnmaskResponseDataStatusHistory>>(
                "status_history",
                ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Trace Ids.
    /// </summary>
    public required IReadOnlyDictionary<string, string> TraceIds
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<FrozenDictionary<string, string>>("trace_ids");
        }
        init
        {
            this._rawData.Set<FrozenDictionary<string, string>>(
                "trace_ids",
                FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    /// <summary>
    /// Created at.
    /// </summary>
    public DateTimeOffset? CreatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<DateTimeOffset>("created_at");
        }
        init { this._rawData.Set("created_at", value); }
    }

    /// <summary>
    /// Information about the customer associated with the charge or payout.
    /// </summary>
    public CustomerDetailsV1? CustomerDetails
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<CustomerDetailsV1>("customer_details");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("customer_details", value);
        }
    }

    /// <summary>
    /// Effective at.
    /// </summary>
    public DateTimeOffset? EffectiveAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<DateTimeOffset>("effective_at");
        }
        init { this._rawData.Set("effective_at", value); }
    }

    /// <summary>
    /// Metadata.
    /// </summary>
    public IReadOnlyDictionary<string, string>? Metadata
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("metadata");
        }
        init
        {
            this._rawData.Set<FrozenDictionary<string, string>?>(
                "metadata",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    public PaykeyDetailsV1? PaykeyDetails
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<PaykeyDetailsV1>("paykey_details");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("paykey_details", value);
        }
    }

    /// <summary>
    /// The payment rail used for the charge or payout.
    /// </summary>
    public ApiEnum<string, PayoutUnmaskResponseDataPaymentRail>? PaymentRail
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, PayoutUnmaskResponseDataPaymentRail>
            >("payment_rail");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("payment_rail", value);
        }
    }

    /// <summary>
    /// Processed at.
    /// </summary>
    public DateTimeOffset? ProcessedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<DateTimeOffset>("processed_at");
        }
        init { this._rawData.Set("processed_at", value); }
    }

    /// <summary>
    /// Updated at.
    /// </summary>
    public DateTimeOffset? UpdatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<DateTimeOffset>("updated_at");
        }
        init { this._rawData.Set("updated_at", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Amount;
        this.Config.Validate();
        _ = this.Currency;
        _ = this.Description;
        this.Device.Validate();
        _ = this.ExternalID;
        _ = this.FundingIds;
        _ = this.Paykey;
        _ = this.PaymentDate;
        this.Status.Validate();
        this.StatusDetails.Validate();
        foreach (var item in this.StatusHistory)
        {
            item.Validate();
        }
        _ = this.TraceIds;
        _ = this.CreatedAt;
        this.CustomerDetails?.Validate();
        _ = this.EffectiveAt;
        _ = this.Metadata;
        this.PaykeyDetails?.Validate();
        this.PaymentRail?.Validate();
        _ = this.ProcessedAt;
        _ = this.UpdatedAt;
    }

    public PayoutUnmaskResponseData() { }

    public PayoutUnmaskResponseData(PayoutUnmaskResponseData payoutUnmaskResponseData)
        : base(payoutUnmaskResponseData) { }

    public PayoutUnmaskResponseData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PayoutUnmaskResponseData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PayoutUnmaskResponseDataFromRaw.FromRawUnchecked"/>
    public static PayoutUnmaskResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PayoutUnmaskResponseDataFromRaw : IFromRawJson<PayoutUnmaskResponseData>
{
    /// <inheritdoc/>
    public PayoutUnmaskResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PayoutUnmaskResponseData.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        PayoutUnmaskResponseDataConfig,
        PayoutUnmaskResponseDataConfigFromRaw
    >)
)]
public sealed record class PayoutUnmaskResponseDataConfig : JsonModel
{
    /// <summary>
    /// Payment will simulate processing if not Standard.
    /// </summary>
    public ApiEnum<string, PayoutUnmaskResponseDataConfigSandboxOutcome>? SandboxOutcome
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, PayoutUnmaskResponseDataConfigSandboxOutcome>
            >("sandbox_outcome");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("sandbox_outcome", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.SandboxOutcome?.Validate();
    }

    public PayoutUnmaskResponseDataConfig() { }

    public PayoutUnmaskResponseDataConfig(
        PayoutUnmaskResponseDataConfig payoutUnmaskResponseDataConfig
    )
        : base(payoutUnmaskResponseDataConfig) { }

    public PayoutUnmaskResponseDataConfig(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PayoutUnmaskResponseDataConfig(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PayoutUnmaskResponseDataConfigFromRaw.FromRawUnchecked"/>
    public static PayoutUnmaskResponseDataConfig FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PayoutUnmaskResponseDataConfigFromRaw : IFromRawJson<PayoutUnmaskResponseDataConfig>
{
    /// <inheritdoc/>
    public PayoutUnmaskResponseDataConfig FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PayoutUnmaskResponseDataConfig.FromRawUnchecked(rawData);
}

/// <summary>
/// Payment will simulate processing if not Standard.
/// </summary>
[JsonConverter(typeof(PayoutUnmaskResponseDataConfigSandboxOutcomeConverter))]
public enum PayoutUnmaskResponseDataConfigSandboxOutcome
{
    Standard,
    Paid,
    OnHoldDailyLimit,
    CancelledForFraudRisk,
    CancelledForBalanceCheck,
    FailedInsufficientFunds,
    ReversedInsufficientFunds,
    FailedCustomerDispute,
    ReversedCustomerDispute,
    FailedClosedBankAccount,
    ReversedClosedBankAccount,
    Standard1,
    Paid1,
    OnHoldDailyLimit1,
    CancelledForFraudRisk1,
    CancelledForBalanceCheck1,
    FailedInsufficientFunds1,
    ReversedInsufficientFunds1,
    FailedCustomerDispute1,
    ReversedCustomerDispute1,
    FailedClosedBankAccount1,
    ReversedClosedBankAccount1,
}

sealed class PayoutUnmaskResponseDataConfigSandboxOutcomeConverter
    : JsonConverter<PayoutUnmaskResponseDataConfigSandboxOutcome>
{
    public override PayoutUnmaskResponseDataConfigSandboxOutcome Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "standard" => PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
            "paid" => PayoutUnmaskResponseDataConfigSandboxOutcome.Paid,
            "on_hold_daily_limit" => PayoutUnmaskResponseDataConfigSandboxOutcome.OnHoldDailyLimit,
            "cancelled_for_fraud_risk" =>
                PayoutUnmaskResponseDataConfigSandboxOutcome.CancelledForFraudRisk,
            "cancelled_for_balance_check" =>
                PayoutUnmaskResponseDataConfigSandboxOutcome.CancelledForBalanceCheck,
            "failed_insufficient_funds" =>
                PayoutUnmaskResponseDataConfigSandboxOutcome.FailedInsufficientFunds,
            "reversed_insufficient_funds" =>
                PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedInsufficientFunds,
            "failed_customer_dispute" =>
                PayoutUnmaskResponseDataConfigSandboxOutcome.FailedCustomerDispute,
            "reversed_customer_dispute" =>
                PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedCustomerDispute,
            "failed_closed_bank_account" =>
                PayoutUnmaskResponseDataConfigSandboxOutcome.FailedClosedBankAccount,
            "reversed_closed_bank_account" =>
                PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedClosedBankAccount,
            "Standard" => PayoutUnmaskResponseDataConfigSandboxOutcome.Standard1,
            "Paid" => PayoutUnmaskResponseDataConfigSandboxOutcome.Paid1,
            "OnHoldDailyLimit" => PayoutUnmaskResponseDataConfigSandboxOutcome.OnHoldDailyLimit1,
            "CancelledForFraudRisk" =>
                PayoutUnmaskResponseDataConfigSandboxOutcome.CancelledForFraudRisk1,
            "CancelledForBalanceCheck" =>
                PayoutUnmaskResponseDataConfigSandboxOutcome.CancelledForBalanceCheck1,
            "FailedInsufficientFunds" =>
                PayoutUnmaskResponseDataConfigSandboxOutcome.FailedInsufficientFunds1,
            "ReversedInsufficientFunds" =>
                PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedInsufficientFunds1,
            "FailedCustomerDispute" =>
                PayoutUnmaskResponseDataConfigSandboxOutcome.FailedCustomerDispute1,
            "ReversedCustomerDispute" =>
                PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedCustomerDispute1,
            "FailedClosedBankAccount" =>
                PayoutUnmaskResponseDataConfigSandboxOutcome.FailedClosedBankAccount1,
            "ReversedClosedBankAccount" =>
                PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedClosedBankAccount1,
            _ => (PayoutUnmaskResponseDataConfigSandboxOutcome)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PayoutUnmaskResponseDataConfigSandboxOutcome value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PayoutUnmaskResponseDataConfigSandboxOutcome.Standard => "standard",
                PayoutUnmaskResponseDataConfigSandboxOutcome.Paid => "paid",
                PayoutUnmaskResponseDataConfigSandboxOutcome.OnHoldDailyLimit =>
                    "on_hold_daily_limit",
                PayoutUnmaskResponseDataConfigSandboxOutcome.CancelledForFraudRisk =>
                    "cancelled_for_fraud_risk",
                PayoutUnmaskResponseDataConfigSandboxOutcome.CancelledForBalanceCheck =>
                    "cancelled_for_balance_check",
                PayoutUnmaskResponseDataConfigSandboxOutcome.FailedInsufficientFunds =>
                    "failed_insufficient_funds",
                PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedInsufficientFunds =>
                    "reversed_insufficient_funds",
                PayoutUnmaskResponseDataConfigSandboxOutcome.FailedCustomerDispute =>
                    "failed_customer_dispute",
                PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedCustomerDispute =>
                    "reversed_customer_dispute",
                PayoutUnmaskResponseDataConfigSandboxOutcome.FailedClosedBankAccount =>
                    "failed_closed_bank_account",
                PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedClosedBankAccount =>
                    "reversed_closed_bank_account",
                PayoutUnmaskResponseDataConfigSandboxOutcome.Standard1 => "Standard",
                PayoutUnmaskResponseDataConfigSandboxOutcome.Paid1 => "Paid",
                PayoutUnmaskResponseDataConfigSandboxOutcome.OnHoldDailyLimit1 =>
                    "OnHoldDailyLimit",
                PayoutUnmaskResponseDataConfigSandboxOutcome.CancelledForFraudRisk1 =>
                    "CancelledForFraudRisk",
                PayoutUnmaskResponseDataConfigSandboxOutcome.CancelledForBalanceCheck1 =>
                    "CancelledForBalanceCheck",
                PayoutUnmaskResponseDataConfigSandboxOutcome.FailedInsufficientFunds1 =>
                    "FailedInsufficientFunds",
                PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedInsufficientFunds1 =>
                    "ReversedInsufficientFunds",
                PayoutUnmaskResponseDataConfigSandboxOutcome.FailedCustomerDispute1 =>
                    "FailedCustomerDispute",
                PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedCustomerDispute1 =>
                    "ReversedCustomerDispute",
                PayoutUnmaskResponseDataConfigSandboxOutcome.FailedClosedBankAccount1 =>
                    "FailedClosedBankAccount",
                PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedClosedBankAccount1 =>
                    "ReversedClosedBankAccount",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<Device, DeviceFromRaw>))]
public sealed record class Device : JsonModel
{
    /// <summary>
    /// Ip address.
    /// </summary>
    public required string IPAddress
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("ip_address");
        }
        init { this._rawData.Set("ip_address", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.IPAddress;
    }

    public Device() { }

    public Device(Device device)
        : base(device) { }

    public Device(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Device(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DeviceFromRaw.FromRawUnchecked"/>
    public static Device FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public Device(string ipAddress)
        : this()
    {
        this.IPAddress = ipAddress;
    }
}

class DeviceFromRaw : IFromRawJson<Device>
{
    /// <inheritdoc/>
    public Device FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Device.FromRawUnchecked(rawData);
}

/// <summary>
/// The current status of the `charge` or `payout`.
/// </summary>
[JsonConverter(typeof(PayoutUnmaskResponseDataStatusConverter))]
public enum PayoutUnmaskResponseDataStatus
{
    Created,
    Scheduled,
    Failed,
    Cancelled,
    OnHold,
    Pending,
    Paid,
    Reversed,
    Created1,
    Scheduled1,
    Failed1,
    Cancelled1,
    OnHold1,
    Pending1,
    Paid1,
    Reversed1,
}

sealed class PayoutUnmaskResponseDataStatusConverter : JsonConverter<PayoutUnmaskResponseDataStatus>
{
    public override PayoutUnmaskResponseDataStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created" => PayoutUnmaskResponseDataStatus.Created,
            "scheduled" => PayoutUnmaskResponseDataStatus.Scheduled,
            "failed" => PayoutUnmaskResponseDataStatus.Failed,
            "cancelled" => PayoutUnmaskResponseDataStatus.Cancelled,
            "on_hold" => PayoutUnmaskResponseDataStatus.OnHold,
            "pending" => PayoutUnmaskResponseDataStatus.Pending,
            "paid" => PayoutUnmaskResponseDataStatus.Paid,
            "reversed" => PayoutUnmaskResponseDataStatus.Reversed,
            "Created" => PayoutUnmaskResponseDataStatus.Created1,
            "Scheduled" => PayoutUnmaskResponseDataStatus.Scheduled1,
            "Failed" => PayoutUnmaskResponseDataStatus.Failed1,
            "Cancelled" => PayoutUnmaskResponseDataStatus.Cancelled1,
            "OnHold" => PayoutUnmaskResponseDataStatus.OnHold1,
            "Pending" => PayoutUnmaskResponseDataStatus.Pending1,
            "Paid" => PayoutUnmaskResponseDataStatus.Paid1,
            "Reversed" => PayoutUnmaskResponseDataStatus.Reversed1,
            _ => (PayoutUnmaskResponseDataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PayoutUnmaskResponseDataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PayoutUnmaskResponseDataStatus.Created => "created",
                PayoutUnmaskResponseDataStatus.Scheduled => "scheduled",
                PayoutUnmaskResponseDataStatus.Failed => "failed",
                PayoutUnmaskResponseDataStatus.Cancelled => "cancelled",
                PayoutUnmaskResponseDataStatus.OnHold => "on_hold",
                PayoutUnmaskResponseDataStatus.Pending => "pending",
                PayoutUnmaskResponseDataStatus.Paid => "paid",
                PayoutUnmaskResponseDataStatus.Reversed => "reversed",
                PayoutUnmaskResponseDataStatus.Created1 => "Created",
                PayoutUnmaskResponseDataStatus.Scheduled1 => "Scheduled",
                PayoutUnmaskResponseDataStatus.Failed1 => "Failed",
                PayoutUnmaskResponseDataStatus.Cancelled1 => "Cancelled",
                PayoutUnmaskResponseDataStatus.OnHold1 => "OnHold",
                PayoutUnmaskResponseDataStatus.Pending1 => "Pending",
                PayoutUnmaskResponseDataStatus.Paid1 => "Paid",
                PayoutUnmaskResponseDataStatus.Reversed1 => "Reversed",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(
    typeof(JsonModelConverter<
        PayoutUnmaskResponseDataStatusHistory,
        PayoutUnmaskResponseDataStatusHistoryFromRaw
    >)
)]
public sealed record class PayoutUnmaskResponseDataStatusHistory : JsonModel
{
    /// <summary>
    /// The time the status change occurred.
    /// </summary>
    public required DateTimeOffset ChangedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<DateTimeOffset>("changed_at");
        }
        init { this._rawData.Set("changed_at", value); }
    }

    /// <summary>
    /// A human-readable description of the status.
    /// </summary>
    public required string Message
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("message");
        }
        init { this._rawData.Set("message", value); }
    }

    /// <summary>
    /// A machine-readable identifier for the specific status, useful for programmatic handling.
    /// </summary>
    public required ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryReason> Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryReason>
            >("reason");
        }
        init { this._rawData.Set("reason", value); }
    }

    /// <summary>
    /// Identifies the origin of the status change (e.g., `bank_decline`, `watchtower`).
    /// This helps in tracking the cause of status updates.
    /// </summary>
    public required ApiEnum<string, PayoutUnmaskResponseDataStatusHistorySource> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, PayoutUnmaskResponseDataStatusHistorySource>
            >("source");
        }
        init { this._rawData.Set("source", value); }
    }

    /// <summary>
    /// The current status of the `charge` or `payout`.
    /// </summary>
    public required ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryStatus>
            >("status");
        }
        init { this._rawData.Set("status", value); }
    }

    /// <summary>
    /// The status code if applicable.
    /// </summary>
    public string? Code
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("code");
        }
        init { this._rawData.Set("code", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ChangedAt;
        _ = this.Message;
        this.Reason.Validate();
        this.Source.Validate();
        this.Status.Validate();
        _ = this.Code;
    }

    public PayoutUnmaskResponseDataStatusHistory() { }

    public PayoutUnmaskResponseDataStatusHistory(
        PayoutUnmaskResponseDataStatusHistory payoutUnmaskResponseDataStatusHistory
    )
        : base(payoutUnmaskResponseDataStatusHistory) { }

    public PayoutUnmaskResponseDataStatusHistory(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PayoutUnmaskResponseDataStatusHistory(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PayoutUnmaskResponseDataStatusHistoryFromRaw.FromRawUnchecked"/>
    public static PayoutUnmaskResponseDataStatusHistory FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PayoutUnmaskResponseDataStatusHistoryFromRaw
    : IFromRawJson<PayoutUnmaskResponseDataStatusHistory>
{
    /// <inheritdoc/>
    public PayoutUnmaskResponseDataStatusHistory FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PayoutUnmaskResponseDataStatusHistory.FromRawUnchecked(rawData);
}

/// <summary>
/// A machine-readable identifier for the specific status, useful for programmatic handling.
/// </summary>
[JsonConverter(typeof(PayoutUnmaskResponseDataStatusHistoryReasonConverter))]
public enum PayoutUnmaskResponseDataStatusHistoryReason
{
    InsufficientFunds,
    ClosedBankAccount,
    InvalidBankAccount,
    InvalidRouting,
    Disputed,
    PaymentStopped,
    OwnerDeceased,
    FrozenBankAccount,
    RiskReview,
    Fraudulent,
    DuplicateEntry,
    InvalidPaykey,
    PaymentBlocked,
    AmountTooLarge,
    TooManyAttempts,
    InternalSystemError,
    UserRequest,
    Ok,
    OtherNetworkReturn,
    PayoutRefused,
    CancelRequest,
    FailedVerification,
    RequireReview,
    BlockedBySystem,
    WatchtowerReview,
    InsufficientFunds1,
    ClosedBankAccount1,
    InvalidBankAccount1,
    InvalidRouting1,
    Disputed1,
    PaymentStopped1,
    OwnerDeceased1,
    FrozenBankAccount1,
    RiskReview1,
    Fraudulent1,
    DuplicateEntry1,
    InvalidPaykey1,
    PaymentBlocked1,
    AmountTooLarge1,
    TooManyAttempts1,
    InternalSystemError1,
    UserRequest1,
    Ok1,
    OtherNetworkReturn1,
    PayoutRefused1,
}

sealed class PayoutUnmaskResponseDataStatusHistoryReasonConverter
    : JsonConverter<PayoutUnmaskResponseDataStatusHistoryReason>
{
    public override PayoutUnmaskResponseDataStatusHistoryReason Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "insufficient_funds" => PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            "closed_bank_account" => PayoutUnmaskResponseDataStatusHistoryReason.ClosedBankAccount,
            "invalid_bank_account" =>
                PayoutUnmaskResponseDataStatusHistoryReason.InvalidBankAccount,
            "invalid_routing" => PayoutUnmaskResponseDataStatusHistoryReason.InvalidRouting,
            "disputed" => PayoutUnmaskResponseDataStatusHistoryReason.Disputed,
            "payment_stopped" => PayoutUnmaskResponseDataStatusHistoryReason.PaymentStopped,
            "owner_deceased" => PayoutUnmaskResponseDataStatusHistoryReason.OwnerDeceased,
            "frozen_bank_account" => PayoutUnmaskResponseDataStatusHistoryReason.FrozenBankAccount,
            "risk_review" => PayoutUnmaskResponseDataStatusHistoryReason.RiskReview,
            "fraudulent" => PayoutUnmaskResponseDataStatusHistoryReason.Fraudulent,
            "duplicate_entry" => PayoutUnmaskResponseDataStatusHistoryReason.DuplicateEntry,
            "invalid_paykey" => PayoutUnmaskResponseDataStatusHistoryReason.InvalidPaykey,
            "payment_blocked" => PayoutUnmaskResponseDataStatusHistoryReason.PaymentBlocked,
            "amount_too_large" => PayoutUnmaskResponseDataStatusHistoryReason.AmountTooLarge,
            "too_many_attempts" => PayoutUnmaskResponseDataStatusHistoryReason.TooManyAttempts,
            "internal_system_error" =>
                PayoutUnmaskResponseDataStatusHistoryReason.InternalSystemError,
            "user_request" => PayoutUnmaskResponseDataStatusHistoryReason.UserRequest,
            "ok" => PayoutUnmaskResponseDataStatusHistoryReason.Ok,
            "other_network_return" =>
                PayoutUnmaskResponseDataStatusHistoryReason.OtherNetworkReturn,
            "payout_refused" => PayoutUnmaskResponseDataStatusHistoryReason.PayoutRefused,
            "cancel_request" => PayoutUnmaskResponseDataStatusHistoryReason.CancelRequest,
            "failed_verification" => PayoutUnmaskResponseDataStatusHistoryReason.FailedVerification,
            "require_review" => PayoutUnmaskResponseDataStatusHistoryReason.RequireReview,
            "blocked_by_system" => PayoutUnmaskResponseDataStatusHistoryReason.BlockedBySystem,
            "watchtower_review" => PayoutUnmaskResponseDataStatusHistoryReason.WatchtowerReview,
            "InsufficientFunds" => PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds1,
            "ClosedBankAccount" => PayoutUnmaskResponseDataStatusHistoryReason.ClosedBankAccount1,
            "InvalidBankAccount" => PayoutUnmaskResponseDataStatusHistoryReason.InvalidBankAccount1,
            "InvalidRouting" => PayoutUnmaskResponseDataStatusHistoryReason.InvalidRouting1,
            "Disputed" => PayoutUnmaskResponseDataStatusHistoryReason.Disputed1,
            "PaymentStopped" => PayoutUnmaskResponseDataStatusHistoryReason.PaymentStopped1,
            "OwnerDeceased" => PayoutUnmaskResponseDataStatusHistoryReason.OwnerDeceased1,
            "FrozenBankAccount" => PayoutUnmaskResponseDataStatusHistoryReason.FrozenBankAccount1,
            "RiskReview" => PayoutUnmaskResponseDataStatusHistoryReason.RiskReview1,
            "Fraudulent" => PayoutUnmaskResponseDataStatusHistoryReason.Fraudulent1,
            "DuplicateEntry" => PayoutUnmaskResponseDataStatusHistoryReason.DuplicateEntry1,
            "InvalidPaykey" => PayoutUnmaskResponseDataStatusHistoryReason.InvalidPaykey1,
            "PaymentBlocked" => PayoutUnmaskResponseDataStatusHistoryReason.PaymentBlocked1,
            "AmountTooLarge" => PayoutUnmaskResponseDataStatusHistoryReason.AmountTooLarge1,
            "TooManyAttempts" => PayoutUnmaskResponseDataStatusHistoryReason.TooManyAttempts1,
            "InternalSystemError" =>
                PayoutUnmaskResponseDataStatusHistoryReason.InternalSystemError1,
            "UserRequest" => PayoutUnmaskResponseDataStatusHistoryReason.UserRequest1,
            "Ok" => PayoutUnmaskResponseDataStatusHistoryReason.Ok1,
            "OtherNetworkReturn" => PayoutUnmaskResponseDataStatusHistoryReason.OtherNetworkReturn1,
            "PayoutRefused" => PayoutUnmaskResponseDataStatusHistoryReason.PayoutRefused1,
            _ => (PayoutUnmaskResponseDataStatusHistoryReason)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PayoutUnmaskResponseDataStatusHistoryReason value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds =>
                    "insufficient_funds",
                PayoutUnmaskResponseDataStatusHistoryReason.ClosedBankAccount =>
                    "closed_bank_account",
                PayoutUnmaskResponseDataStatusHistoryReason.InvalidBankAccount =>
                    "invalid_bank_account",
                PayoutUnmaskResponseDataStatusHistoryReason.InvalidRouting => "invalid_routing",
                PayoutUnmaskResponseDataStatusHistoryReason.Disputed => "disputed",
                PayoutUnmaskResponseDataStatusHistoryReason.PaymentStopped => "payment_stopped",
                PayoutUnmaskResponseDataStatusHistoryReason.OwnerDeceased => "owner_deceased",
                PayoutUnmaskResponseDataStatusHistoryReason.FrozenBankAccount =>
                    "frozen_bank_account",
                PayoutUnmaskResponseDataStatusHistoryReason.RiskReview => "risk_review",
                PayoutUnmaskResponseDataStatusHistoryReason.Fraudulent => "fraudulent",
                PayoutUnmaskResponseDataStatusHistoryReason.DuplicateEntry => "duplicate_entry",
                PayoutUnmaskResponseDataStatusHistoryReason.InvalidPaykey => "invalid_paykey",
                PayoutUnmaskResponseDataStatusHistoryReason.PaymentBlocked => "payment_blocked",
                PayoutUnmaskResponseDataStatusHistoryReason.AmountTooLarge => "amount_too_large",
                PayoutUnmaskResponseDataStatusHistoryReason.TooManyAttempts => "too_many_attempts",
                PayoutUnmaskResponseDataStatusHistoryReason.InternalSystemError =>
                    "internal_system_error",
                PayoutUnmaskResponseDataStatusHistoryReason.UserRequest => "user_request",
                PayoutUnmaskResponseDataStatusHistoryReason.Ok => "ok",
                PayoutUnmaskResponseDataStatusHistoryReason.OtherNetworkReturn =>
                    "other_network_return",
                PayoutUnmaskResponseDataStatusHistoryReason.PayoutRefused => "payout_refused",
                PayoutUnmaskResponseDataStatusHistoryReason.CancelRequest => "cancel_request",
                PayoutUnmaskResponseDataStatusHistoryReason.FailedVerification =>
                    "failed_verification",
                PayoutUnmaskResponseDataStatusHistoryReason.RequireReview => "require_review",
                PayoutUnmaskResponseDataStatusHistoryReason.BlockedBySystem => "blocked_by_system",
                PayoutUnmaskResponseDataStatusHistoryReason.WatchtowerReview => "watchtower_review",
                PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds1 =>
                    "InsufficientFunds",
                PayoutUnmaskResponseDataStatusHistoryReason.ClosedBankAccount1 =>
                    "ClosedBankAccount",
                PayoutUnmaskResponseDataStatusHistoryReason.InvalidBankAccount1 =>
                    "InvalidBankAccount",
                PayoutUnmaskResponseDataStatusHistoryReason.InvalidRouting1 => "InvalidRouting",
                PayoutUnmaskResponseDataStatusHistoryReason.Disputed1 => "Disputed",
                PayoutUnmaskResponseDataStatusHistoryReason.PaymentStopped1 => "PaymentStopped",
                PayoutUnmaskResponseDataStatusHistoryReason.OwnerDeceased1 => "OwnerDeceased",
                PayoutUnmaskResponseDataStatusHistoryReason.FrozenBankAccount1 =>
                    "FrozenBankAccount",
                PayoutUnmaskResponseDataStatusHistoryReason.RiskReview1 => "RiskReview",
                PayoutUnmaskResponseDataStatusHistoryReason.Fraudulent1 => "Fraudulent",
                PayoutUnmaskResponseDataStatusHistoryReason.DuplicateEntry1 => "DuplicateEntry",
                PayoutUnmaskResponseDataStatusHistoryReason.InvalidPaykey1 => "InvalidPaykey",
                PayoutUnmaskResponseDataStatusHistoryReason.PaymentBlocked1 => "PaymentBlocked",
                PayoutUnmaskResponseDataStatusHistoryReason.AmountTooLarge1 => "AmountTooLarge",
                PayoutUnmaskResponseDataStatusHistoryReason.TooManyAttempts1 => "TooManyAttempts",
                PayoutUnmaskResponseDataStatusHistoryReason.InternalSystemError1 =>
                    "InternalSystemError",
                PayoutUnmaskResponseDataStatusHistoryReason.UserRequest1 => "UserRequest",
                PayoutUnmaskResponseDataStatusHistoryReason.Ok1 => "Ok",
                PayoutUnmaskResponseDataStatusHistoryReason.OtherNetworkReturn1 =>
                    "OtherNetworkReturn",
                PayoutUnmaskResponseDataStatusHistoryReason.PayoutRefused1 => "PayoutRefused",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Identifies the origin of the status change (e.g., `bank_decline`, `watchtower`).
/// This helps in tracking the cause of status updates.
/// </summary>
[JsonConverter(typeof(PayoutUnmaskResponseDataStatusHistorySourceConverter))]
public enum PayoutUnmaskResponseDataStatusHistorySource
{
    Watchtower,
    BankDecline,
    CustomerDispute,
    UserAction,
    System,
    Watchtower1,
    BankDecline1,
    CustomerDispute1,
    UserAction1,
    System1,
}

sealed class PayoutUnmaskResponseDataStatusHistorySourceConverter
    : JsonConverter<PayoutUnmaskResponseDataStatusHistorySource>
{
    public override PayoutUnmaskResponseDataStatusHistorySource Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "watchtower" => PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
            "bank_decline" => PayoutUnmaskResponseDataStatusHistorySource.BankDecline,
            "customer_dispute" => PayoutUnmaskResponseDataStatusHistorySource.CustomerDispute,
            "user_action" => PayoutUnmaskResponseDataStatusHistorySource.UserAction,
            "system" => PayoutUnmaskResponseDataStatusHistorySource.System,
            "Watchtower" => PayoutUnmaskResponseDataStatusHistorySource.Watchtower1,
            "BankDecline" => PayoutUnmaskResponseDataStatusHistorySource.BankDecline1,
            "CustomerDispute" => PayoutUnmaskResponseDataStatusHistorySource.CustomerDispute1,
            "UserAction" => PayoutUnmaskResponseDataStatusHistorySource.UserAction1,
            "System" => PayoutUnmaskResponseDataStatusHistorySource.System1,
            _ => (PayoutUnmaskResponseDataStatusHistorySource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PayoutUnmaskResponseDataStatusHistorySource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PayoutUnmaskResponseDataStatusHistorySource.Watchtower => "watchtower",
                PayoutUnmaskResponseDataStatusHistorySource.BankDecline => "bank_decline",
                PayoutUnmaskResponseDataStatusHistorySource.CustomerDispute => "customer_dispute",
                PayoutUnmaskResponseDataStatusHistorySource.UserAction => "user_action",
                PayoutUnmaskResponseDataStatusHistorySource.System => "system",
                PayoutUnmaskResponseDataStatusHistorySource.Watchtower1 => "Watchtower",
                PayoutUnmaskResponseDataStatusHistorySource.BankDecline1 => "BankDecline",
                PayoutUnmaskResponseDataStatusHistorySource.CustomerDispute1 => "CustomerDispute",
                PayoutUnmaskResponseDataStatusHistorySource.UserAction1 => "UserAction",
                PayoutUnmaskResponseDataStatusHistorySource.System1 => "System",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// The current status of the `charge` or `payout`.
/// </summary>
[JsonConverter(typeof(PayoutUnmaskResponseDataStatusHistoryStatusConverter))]
public enum PayoutUnmaskResponseDataStatusHistoryStatus
{
    Created,
    Scheduled,
    Failed,
    Cancelled,
    OnHold,
    Pending,
    Paid,
    Reversed,
    Created1,
    Scheduled1,
    Failed1,
    Cancelled1,
    OnHold1,
    Pending1,
    Paid1,
    Reversed1,
}

sealed class PayoutUnmaskResponseDataStatusHistoryStatusConverter
    : JsonConverter<PayoutUnmaskResponseDataStatusHistoryStatus>
{
    public override PayoutUnmaskResponseDataStatusHistoryStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created" => PayoutUnmaskResponseDataStatusHistoryStatus.Created,
            "scheduled" => PayoutUnmaskResponseDataStatusHistoryStatus.Scheduled,
            "failed" => PayoutUnmaskResponseDataStatusHistoryStatus.Failed,
            "cancelled" => PayoutUnmaskResponseDataStatusHistoryStatus.Cancelled,
            "on_hold" => PayoutUnmaskResponseDataStatusHistoryStatus.OnHold,
            "pending" => PayoutUnmaskResponseDataStatusHistoryStatus.Pending,
            "paid" => PayoutUnmaskResponseDataStatusHistoryStatus.Paid,
            "reversed" => PayoutUnmaskResponseDataStatusHistoryStatus.Reversed,
            "Created" => PayoutUnmaskResponseDataStatusHistoryStatus.Created1,
            "Scheduled" => PayoutUnmaskResponseDataStatusHistoryStatus.Scheduled1,
            "Failed" => PayoutUnmaskResponseDataStatusHistoryStatus.Failed1,
            "Cancelled" => PayoutUnmaskResponseDataStatusHistoryStatus.Cancelled1,
            "OnHold" => PayoutUnmaskResponseDataStatusHistoryStatus.OnHold1,
            "Pending" => PayoutUnmaskResponseDataStatusHistoryStatus.Pending1,
            "Paid" => PayoutUnmaskResponseDataStatusHistoryStatus.Paid1,
            "Reversed" => PayoutUnmaskResponseDataStatusHistoryStatus.Reversed1,
            _ => (PayoutUnmaskResponseDataStatusHistoryStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PayoutUnmaskResponseDataStatusHistoryStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PayoutUnmaskResponseDataStatusHistoryStatus.Created => "created",
                PayoutUnmaskResponseDataStatusHistoryStatus.Scheduled => "scheduled",
                PayoutUnmaskResponseDataStatusHistoryStatus.Failed => "failed",
                PayoutUnmaskResponseDataStatusHistoryStatus.Cancelled => "cancelled",
                PayoutUnmaskResponseDataStatusHistoryStatus.OnHold => "on_hold",
                PayoutUnmaskResponseDataStatusHistoryStatus.Pending => "pending",
                PayoutUnmaskResponseDataStatusHistoryStatus.Paid => "paid",
                PayoutUnmaskResponseDataStatusHistoryStatus.Reversed => "reversed",
                PayoutUnmaskResponseDataStatusHistoryStatus.Created1 => "Created",
                PayoutUnmaskResponseDataStatusHistoryStatus.Scheduled1 => "Scheduled",
                PayoutUnmaskResponseDataStatusHistoryStatus.Failed1 => "Failed",
                PayoutUnmaskResponseDataStatusHistoryStatus.Cancelled1 => "Cancelled",
                PayoutUnmaskResponseDataStatusHistoryStatus.OnHold1 => "OnHold",
                PayoutUnmaskResponseDataStatusHistoryStatus.Pending1 => "Pending",
                PayoutUnmaskResponseDataStatusHistoryStatus.Paid1 => "Paid",
                PayoutUnmaskResponseDataStatusHistoryStatus.Reversed1 => "Reversed",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// The payment rail used for the charge or payout.
/// </summary>
[JsonConverter(typeof(PayoutUnmaskResponseDataPaymentRailConverter))]
public enum PayoutUnmaskResponseDataPaymentRail
{
    Ach,
    Ach1,
}

sealed class PayoutUnmaskResponseDataPaymentRailConverter
    : JsonConverter<PayoutUnmaskResponseDataPaymentRail>
{
    public override PayoutUnmaskResponseDataPaymentRail Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "ach" => PayoutUnmaskResponseDataPaymentRail.Ach,
            "ACH" => PayoutUnmaskResponseDataPaymentRail.Ach1,
            _ => (PayoutUnmaskResponseDataPaymentRail)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PayoutUnmaskResponseDataPaymentRail value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PayoutUnmaskResponseDataPaymentRail.Ach => "ach",
                PayoutUnmaskResponseDataPaymentRail.Ach1 => "ACH",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Indicates the structure of the returned content. - "object" means the `data`
/// field contains a single JSON object. - "array" means the `data` field contains
/// an array of objects. - "error" means the `data` field contains an error object
/// with details of the issue. - "none" means no data is returned.
/// </summary>
[JsonConverter(typeof(PayoutUnmaskResponseResponseTypeConverter))]
public enum PayoutUnmaskResponseResponseType
{
    Object,
    Array,
    Error,
    None,
    Object1,
    Array1,
    Error1,
    None1,
}

sealed class PayoutUnmaskResponseResponseTypeConverter
    : JsonConverter<PayoutUnmaskResponseResponseType>
{
    public override PayoutUnmaskResponseResponseType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "object" => PayoutUnmaskResponseResponseType.Object,
            "array" => PayoutUnmaskResponseResponseType.Array,
            "error" => PayoutUnmaskResponseResponseType.Error,
            "none" => PayoutUnmaskResponseResponseType.None,
            "Object" => PayoutUnmaskResponseResponseType.Object1,
            "Array" => PayoutUnmaskResponseResponseType.Array1,
            "Error" => PayoutUnmaskResponseResponseType.Error1,
            "None" => PayoutUnmaskResponseResponseType.None1,
            _ => (PayoutUnmaskResponseResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PayoutUnmaskResponseResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PayoutUnmaskResponseResponseType.Object => "object",
                PayoutUnmaskResponseResponseType.Array => "array",
                PayoutUnmaskResponseResponseType.Error => "error",
                PayoutUnmaskResponseResponseType.None => "none",
                PayoutUnmaskResponseResponseType.Object1 => "Object",
                PayoutUnmaskResponseResponseType.Array1 => "Array",
                PayoutUnmaskResponseResponseType.Error1 => "Error",
                PayoutUnmaskResponseResponseType.None1 => "None",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
