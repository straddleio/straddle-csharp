using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Charges;

[JsonConverter(typeof(JsonModelConverter<ChargeV1, ChargeV1FromRaw>))]
public sealed record class ChargeV1 : JsonModel
{
    public required Data Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<Data>("data");
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
    public required ApiEnum<string, ResponseType> ResponseType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, ResponseType>>("response_type");
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

    public ChargeV1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ChargeV1(ChargeV1 chargeV1)
        : base(chargeV1) { }
#pragma warning restore CS8618

    public ChargeV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ChargeV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ChargeV1FromRaw.FromRawUnchecked"/>
    public static ChargeV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ChargeV1FromRaw : IFromRawJson<ChargeV1>
{
    /// <inheritdoc/>
    public ChargeV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ChargeV1.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    /// <summary>
    /// Unique identifier for the charge.
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
    /// The amount of the charge in cents.
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

    /// <summary>
    /// Configuration options for the charge.
    /// </summary>
    public required DataConfig Config
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<DataConfig>("config");
        }
        init { this._rawData.Set("config", value); }
    }

    /// <summary>
    /// The channel or mechanism through which the payment was authorized. Use `internet`
    /// for payments made online or through a mobile app and `signed` for signed agreements
    /// where there is a consent form or contract. Use `signed` for PDF signatures.
    /// </summary>
    public required ApiEnum<string, DataConsentType> ConsentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, DataConsentType>>("consent_type");
        }
        init { this._rawData.Set("consent_type", value); }
    }

    /// <summary>
    /// Timestamp of when the charge was created.
    /// </summary>
    public required DateTimeOffset? CreatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<DateTimeOffset>("created_at");
        }
        init { this._rawData.Set("created_at", value); }
    }

    /// <summary>
    /// The currency of the charge. Only USD is supported.
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
    /// An arbitrary description for the charge.
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

    /// <summary>
    /// Information about the device used when the customer authorized the payment.
    /// </summary>
    public required DeviceInfoV1 Device
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<DeviceInfoV1>("device");
        }
        init { this._rawData.Set("device", value); }
    }

    /// <summary>
    /// Unique identifier for the charge in your database. This value must be unique
    /// across all charges.
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
    /// Value of the `paykey` used for the charge.
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
    /// The desired date on which the payment should be occur. For charges, this means
    /// the date you want the customer to be debited on.
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
    /// The current status of the charge.
    /// </summary>
    public required ApiEnum<string, Status> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Status>>("status");
        }
        init { this._rawData.Set("status", value); }
    }

    /// <summary>
    /// Additional details about the current status of the charge.
    /// </summary>
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
    public required IReadOnlyList<StatusHistory> StatusHistory
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<ImmutableArray<StatusHistory>>("status_history");
        }
        init
        {
            this._rawData.Set<ImmutableArray<StatusHistory>>(
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
    /// Timestamp of when the charge was last updated.
    /// </summary>
    public required DateTimeOffset? UpdatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<DateTimeOffset>("updated_at");
        }
        init { this._rawData.Set("updated_at", value); }
    }

    /// <summary>
    /// Information about the customer associated with the charge.
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
    /// Timestamp of when the charge was effective in the customer's bank account,
    /// otherwise known as the date on which the customer is debited.
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
    /// Up to 20 additional user-defined key-value pairs. Useful for storing additional
    /// information about the charge in a structured format.
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

    /// <summary>
    /// Information about the paykey used for the charge.
    /// </summary>
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
    /// The payment rail that the charge will be processed through.
    /// </summary>
    public ApiEnum<string, PaymentRail>? PaymentRail
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, PaymentRail>>("payment_rail");
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
    /// Timestamp of when the charge was processed by Straddle and originated to
    /// the payment rail.
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Amount;
        this.Config.Validate();
        this.ConsentType.Validate();
        _ = this.CreatedAt;
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
        _ = this.UpdatedAt;
        this.CustomerDetails?.Validate();
        _ = this.EffectiveAt;
        _ = this.Metadata;
        this.PaykeyDetails?.Validate();
        this.PaymentRail?.Validate();
        _ = this.ProcessedAt;
    }

    public Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Data(Data data)
        : base(data) { }
#pragma warning restore CS8618

    public Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataFromRaw.FromRawUnchecked"/>
    public static Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataFromRaw : IFromRawJson<Data>
{
    /// <inheritdoc/>
    public Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Data.FromRawUnchecked(rawData);
}

/// <summary>
/// Configuration options for the charge.
/// </summary>
[JsonConverter(typeof(JsonModelConverter<DataConfig, DataConfigFromRaw>))]
public sealed record class DataConfig : JsonModel
{
    /// <summary>
    /// Defines whether to check the customer's balance before processing the charge.
    /// </summary>
    public required ApiEnum<string, DataConfigBalanceCheck> BalanceCheck
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, DataConfigBalanceCheck>>(
                "balance_check"
            );
        }
        init { this._rawData.Set("balance_check", value); }
    }

    /// <summary>
    /// Payment will simulate processing if not Standard.
    /// </summary>
    public ApiEnum<string, DataConfigSandboxOutcome>? SandboxOutcome
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, DataConfigSandboxOutcome>>(
                "sandbox_outcome"
            );
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
        this.BalanceCheck.Validate();
        this.SandboxOutcome?.Validate();
    }

    public DataConfig() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public DataConfig(DataConfig dataConfig)
        : base(dataConfig) { }
#pragma warning restore CS8618

    public DataConfig(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    DataConfig(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataConfigFromRaw.FromRawUnchecked"/>
    public static DataConfig FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public DataConfig(ApiEnum<string, DataConfigBalanceCheck> balanceCheck)
        : this()
    {
        this.BalanceCheck = balanceCheck;
    }
}

class DataConfigFromRaw : IFromRawJson<DataConfig>
{
    /// <inheritdoc/>
    public DataConfig FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        DataConfig.FromRawUnchecked(rawData);
}

/// <summary>
/// Defines whether to check the customer's balance before processing the charge.
/// </summary>
[JsonConverter(typeof(DataConfigBalanceCheckConverter))]
public enum DataConfigBalanceCheck
{
    Required,
    Enabled,
    Disabled,
}

sealed class DataConfigBalanceCheckConverter : JsonConverter<DataConfigBalanceCheck>
{
    public override DataConfigBalanceCheck Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "required" => DataConfigBalanceCheck.Required,
            "enabled" => DataConfigBalanceCheck.Enabled,
            "disabled" => DataConfigBalanceCheck.Disabled,
            _ => (DataConfigBalanceCheck)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        DataConfigBalanceCheck value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                DataConfigBalanceCheck.Required => "required",
                DataConfigBalanceCheck.Enabled => "enabled",
                DataConfigBalanceCheck.Disabled => "disabled",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Payment will simulate processing if not Standard.
/// </summary>
[JsonConverter(typeof(DataConfigSandboxOutcomeConverter))]
public enum DataConfigSandboxOutcome
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

sealed class DataConfigSandboxOutcomeConverter : JsonConverter<DataConfigSandboxOutcome>
{
    public override DataConfigSandboxOutcome Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "standard" => DataConfigSandboxOutcome.Standard,
            "paid" => DataConfigSandboxOutcome.Paid,
            "on_hold_daily_limit" => DataConfigSandboxOutcome.OnHoldDailyLimit,
            "cancelled_for_fraud_risk" => DataConfigSandboxOutcome.CancelledForFraudRisk,
            "cancelled_for_balance_check" => DataConfigSandboxOutcome.CancelledForBalanceCheck,
            "failed_insufficient_funds" => DataConfigSandboxOutcome.FailedInsufficientFunds,
            "reversed_insufficient_funds" => DataConfigSandboxOutcome.ReversedInsufficientFunds,
            "failed_customer_dispute" => DataConfigSandboxOutcome.FailedCustomerDispute,
            "reversed_customer_dispute" => DataConfigSandboxOutcome.ReversedCustomerDispute,
            "failed_closed_bank_account" => DataConfigSandboxOutcome.FailedClosedBankAccount,
            "reversed_closed_bank_account" => DataConfigSandboxOutcome.ReversedClosedBankAccount,
            _ => (DataConfigSandboxOutcome)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        DataConfigSandboxOutcome value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                DataConfigSandboxOutcome.Standard => "standard",
                DataConfigSandboxOutcome.Paid => "paid",
                DataConfigSandboxOutcome.OnHoldDailyLimit => "on_hold_daily_limit",
                DataConfigSandboxOutcome.CancelledForFraudRisk => "cancelled_for_fraud_risk",
                DataConfigSandboxOutcome.CancelledForBalanceCheck => "cancelled_for_balance_check",
                DataConfigSandboxOutcome.FailedInsufficientFunds => "failed_insufficient_funds",
                DataConfigSandboxOutcome.ReversedInsufficientFunds => "reversed_insufficient_funds",
                DataConfigSandboxOutcome.FailedCustomerDispute => "failed_customer_dispute",
                DataConfigSandboxOutcome.ReversedCustomerDispute => "reversed_customer_dispute",
                DataConfigSandboxOutcome.FailedClosedBankAccount => "failed_closed_bank_account",
                DataConfigSandboxOutcome.ReversedClosedBankAccount =>
                    "reversed_closed_bank_account",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// The channel or mechanism through which the payment was authorized. Use `internet`
/// for payments made online or through a mobile app and `signed` for signed agreements
/// where there is a consent form or contract. Use `signed` for PDF signatures.
/// </summary>
[JsonConverter(typeof(DataConsentTypeConverter))]
public enum DataConsentType
{
    Internet,
    Signed,
}

sealed class DataConsentTypeConverter : JsonConverter<DataConsentType>
{
    public override DataConsentType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "internet" => DataConsentType.Internet,
            "signed" => DataConsentType.Signed,
            _ => (DataConsentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        DataConsentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                DataConsentType.Internet => "internet",
                DataConsentType.Signed => "signed",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// The current status of the charge.
/// </summary>
[JsonConverter(typeof(StatusConverter))]
public enum Status
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

sealed class StatusConverter : JsonConverter<Status>
{
    public override Status Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created" => Status.Created,
            "scheduled" => Status.Scheduled,
            "failed" => Status.Failed,
            "cancelled" => Status.Cancelled,
            "on_hold" => Status.OnHold,
            "pending" => Status.Pending,
            "paid" => Status.Paid,
            "reversed" => Status.Reversed,
            _ => (Status)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Status value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Status.Created => "created",
                Status.Scheduled => "scheduled",
                Status.Failed => "failed",
                Status.Cancelled => "cancelled",
                Status.OnHold => "on_hold",
                Status.Pending => "pending",
                Status.Paid => "paid",
                Status.Reversed => "reversed",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// A record of the charge's status changes over time.
/// </summary>
[JsonConverter(typeof(JsonModelConverter<StatusHistory, StatusHistoryFromRaw>))]
public sealed record class StatusHistory : JsonModel
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
    public required ApiEnum<string, Reason> Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Reason>>("reason");
        }
        init { this._rawData.Set("reason", value); }
    }

    /// <summary>
    /// Identifies the origin of the status change (e.g., `bank_decline`, `watchtower`).
    /// This helps in tracking the cause of status updates.
    /// </summary>
    public required ApiEnum<string, Source> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Source>>("source");
        }
        init { this._rawData.Set("source", value); }
    }

    /// <summary>
    /// The current status of the `charge` or `payout`.
    /// </summary>
    public required ApiEnum<string, StatusHistoryStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, StatusHistoryStatus>>("status");
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

    public StatusHistory() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public StatusHistory(StatusHistory statusHistory)
        : base(statusHistory) { }
#pragma warning restore CS8618

    public StatusHistory(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    StatusHistory(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="StatusHistoryFromRaw.FromRawUnchecked"/>
    public static StatusHistory FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class StatusHistoryFromRaw : IFromRawJson<StatusHistory>
{
    /// <inheritdoc/>
    public StatusHistory FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        StatusHistory.FromRawUnchecked(rawData);
}

/// <summary>
/// A machine-readable identifier for the specific status, useful for programmatic handling.
/// </summary>
[JsonConverter(typeof(ReasonConverter))]
public enum Reason
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

sealed class ReasonConverter : JsonConverter<Reason>
{
    public override Reason Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "insufficient_funds" => Reason.InsufficientFunds,
            "closed_bank_account" => Reason.ClosedBankAccount,
            "invalid_bank_account" => Reason.InvalidBankAccount,
            "invalid_routing" => Reason.InvalidRouting,
            "disputed" => Reason.Disputed,
            "payment_stopped" => Reason.PaymentStopped,
            "owner_deceased" => Reason.OwnerDeceased,
            "frozen_bank_account" => Reason.FrozenBankAccount,
            "risk_review" => Reason.RiskReview,
            "fraudulent" => Reason.Fraudulent,
            "duplicate_entry" => Reason.DuplicateEntry,
            "invalid_paykey" => Reason.InvalidPaykey,
            "payment_blocked" => Reason.PaymentBlocked,
            "amount_too_large" => Reason.AmountTooLarge,
            "too_many_attempts" => Reason.TooManyAttempts,
            "internal_system_error" => Reason.InternalSystemError,
            "user_request" => Reason.UserRequest,
            "ok" => Reason.Ok,
            "other_network_return" => Reason.OtherNetworkReturn,
            "payout_refused" => Reason.PayoutRefused,
            "cancel_request" => Reason.CancelRequest,
            "failed_verification" => Reason.FailedVerification,
            "require_review" => Reason.RequireReview,
            "blocked_by_system" => Reason.BlockedBySystem,
            "watchtower_review" => Reason.WatchtowerReview,
            _ => (Reason)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Reason value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Reason.InsufficientFunds => "insufficient_funds",
                Reason.ClosedBankAccount => "closed_bank_account",
                Reason.InvalidBankAccount => "invalid_bank_account",
                Reason.InvalidRouting => "invalid_routing",
                Reason.Disputed => "disputed",
                Reason.PaymentStopped => "payment_stopped",
                Reason.OwnerDeceased => "owner_deceased",
                Reason.FrozenBankAccount => "frozen_bank_account",
                Reason.RiskReview => "risk_review",
                Reason.Fraudulent => "fraudulent",
                Reason.DuplicateEntry => "duplicate_entry",
                Reason.InvalidPaykey => "invalid_paykey",
                Reason.PaymentBlocked => "payment_blocked",
                Reason.AmountTooLarge => "amount_too_large",
                Reason.TooManyAttempts => "too_many_attempts",
                Reason.InternalSystemError => "internal_system_error",
                Reason.UserRequest => "user_request",
                Reason.Ok => "ok",
                Reason.OtherNetworkReturn => "other_network_return",
                Reason.PayoutRefused => "payout_refused",
                Reason.CancelRequest => "cancel_request",
                Reason.FailedVerification => "failed_verification",
                Reason.RequireReview => "require_review",
                Reason.BlockedBySystem => "blocked_by_system",
                Reason.WatchtowerReview => "watchtower_review",
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
[JsonConverter(typeof(SourceConverter))]
public enum Source
{
    Watchtower,
    BankDecline,
    CustomerDispute,
    UserAction,
    System,
}

sealed class SourceConverter : JsonConverter<Source>
{
    public override Source Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "watchtower" => Source.Watchtower,
            "bank_decline" => Source.BankDecline,
            "customer_dispute" => Source.CustomerDispute,
            "user_action" => Source.UserAction,
            "system" => Source.System,
            _ => (Source)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Source value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Source.Watchtower => "watchtower",
                Source.BankDecline => "bank_decline",
                Source.CustomerDispute => "customer_dispute",
                Source.UserAction => "user_action",
                Source.System => "system",
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
[JsonConverter(typeof(StatusHistoryStatusConverter))]
public enum StatusHistoryStatus
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

sealed class StatusHistoryStatusConverter : JsonConverter<StatusHistoryStatus>
{
    public override StatusHistoryStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created" => StatusHistoryStatus.Created,
            "scheduled" => StatusHistoryStatus.Scheduled,
            "failed" => StatusHistoryStatus.Failed,
            "cancelled" => StatusHistoryStatus.Cancelled,
            "on_hold" => StatusHistoryStatus.OnHold,
            "pending" => StatusHistoryStatus.Pending,
            "paid" => StatusHistoryStatus.Paid,
            "reversed" => StatusHistoryStatus.Reversed,
            _ => (StatusHistoryStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        StatusHistoryStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                StatusHistoryStatus.Created => "created",
                StatusHistoryStatus.Scheduled => "scheduled",
                StatusHistoryStatus.Failed => "failed",
                StatusHistoryStatus.Cancelled => "cancelled",
                StatusHistoryStatus.OnHold => "on_hold",
                StatusHistoryStatus.Pending => "pending",
                StatusHistoryStatus.Paid => "paid",
                StatusHistoryStatus.Reversed => "reversed",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// The payment rail that the charge will be processed through.
/// </summary>
[JsonConverter(typeof(PaymentRailConverter))]
public enum PaymentRail
{
    Ach,
}

sealed class PaymentRailConverter : JsonConverter<PaymentRail>
{
    public override PaymentRail Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "ach" => PaymentRail.Ach,
            _ => (PaymentRail)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaymentRail value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaymentRail.Ach => "ach",
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
[JsonConverter(typeof(ResponseTypeConverter))]
public enum ResponseType
{
    Object,
    Array,
    Error,
    None,
}

sealed class ResponseTypeConverter : JsonConverter<ResponseType>
{
    public override ResponseType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "object" => ResponseType.Object,
            "array" => ResponseType.Array,
            "error" => ResponseType.Error,
            "none" => ResponseType.None,
            _ => (ResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ResponseType.Object => "object",
                ResponseType.Array => "array",
                ResponseType.Error => "error",
                ResponseType.None => "none",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
