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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public PayoutUnmaskResponse(PayoutUnmaskResponse payoutUnmaskResponse)
        : base(payoutUnmaskResponse) { }
#pragma warning restore CS8618

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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public PayoutUnmaskResponseData(PayoutUnmaskResponseData payoutUnmaskResponseData)
        : base(payoutUnmaskResponseData) { }
#pragma warning restore CS8618

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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public PayoutUnmaskResponseDataConfig(
        PayoutUnmaskResponseDataConfig payoutUnmaskResponseDataConfig
    )
        : base(payoutUnmaskResponseDataConfig) { }
#pragma warning restore CS8618

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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Device(Device device)
        : base(device) { }
#pragma warning restore CS8618

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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public PayoutUnmaskResponseDataStatusHistory(
        PayoutUnmaskResponseDataStatusHistory payoutUnmaskResponseDataStatusHistory
    )
        : base(payoutUnmaskResponseDataStatusHistory) { }
#pragma warning restore CS8618

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
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
