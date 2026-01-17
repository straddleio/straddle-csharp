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

[JsonConverter(typeof(JsonModelConverter<ChargeUnmaskResponse, ChargeUnmaskResponseFromRaw>))]
public sealed record class ChargeUnmaskResponse : JsonModel
{
    public required ChargeUnmaskResponseData Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ChargeUnmaskResponseData>("data");
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
    public required ApiEnum<string, ChargeUnmaskResponseResponseType> ResponseType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, ChargeUnmaskResponseResponseType>>(
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

    public ChargeUnmaskResponse() { }

    public ChargeUnmaskResponse(ChargeUnmaskResponse chargeUnmaskResponse)
        : base(chargeUnmaskResponse) { }

    public ChargeUnmaskResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ChargeUnmaskResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ChargeUnmaskResponseFromRaw.FromRawUnchecked"/>
    public static ChargeUnmaskResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ChargeUnmaskResponseFromRaw : IFromRawJson<ChargeUnmaskResponse>
{
    /// <inheritdoc/>
    public ChargeUnmaskResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ChargeUnmaskResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<ChargeUnmaskResponseData, ChargeUnmaskResponseDataFromRaw>)
)]
public sealed record class ChargeUnmaskResponseData : JsonModel
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

    public required ChargeUnmaskResponseDataConfig Config
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ChargeUnmaskResponseDataConfig>("config");
        }
        init { this._rawData.Set("config", value); }
    }

    /// <summary>
    /// The channel or mechanism through which the payment was authorized. Use `internet`
    /// for payments made online or through a mobile app and `signed` for signed agreements
    /// where there is a consent form or contract. Use `signed` for PDF signatures.
    /// </summary>
    public required ApiEnum<string, ChargeUnmaskResponseDataConsentType> ConsentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, ChargeUnmaskResponseDataConsentType>
            >("consent_type");
        }
        init { this._rawData.Set("consent_type", value); }
    }

    /// <summary>
    /// Created at.
    /// </summary>
    public required DateTimeOffset CreatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<DateTimeOffset>("created_at");
        }
        init { this._rawData.Set("created_at", value); }
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
    public required ApiEnum<string, ChargeUnmaskResponseDataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, ChargeUnmaskResponseDataStatus>>(
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
    public required IReadOnlyList<ChargeUnmaskResponseDataStatusHistory> StatusHistory
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<
                ImmutableArray<ChargeUnmaskResponseDataStatusHistory>
            >("status_history");
        }
        init
        {
            this._rawData.Set<ImmutableArray<ChargeUnmaskResponseDataStatusHistory>>(
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
    /// Updated at.
    /// </summary>
    public required DateTimeOffset UpdatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<DateTimeOffset>("updated_at");
        }
        init { this._rawData.Set("updated_at", value); }
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
    public ApiEnum<string, ChargeUnmaskResponseDataPaymentRail>? PaymentRail
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, ChargeUnmaskResponseDataPaymentRail>
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

    public ChargeUnmaskResponseData() { }

    public ChargeUnmaskResponseData(ChargeUnmaskResponseData chargeUnmaskResponseData)
        : base(chargeUnmaskResponseData) { }

    public ChargeUnmaskResponseData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ChargeUnmaskResponseData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ChargeUnmaskResponseDataFromRaw.FromRawUnchecked"/>
    public static ChargeUnmaskResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ChargeUnmaskResponseDataFromRaw : IFromRawJson<ChargeUnmaskResponseData>
{
    /// <inheritdoc/>
    public ChargeUnmaskResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ChargeUnmaskResponseData.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        ChargeUnmaskResponseDataConfig,
        ChargeUnmaskResponseDataConfigFromRaw
    >)
)]
public sealed record class ChargeUnmaskResponseDataConfig : JsonModel
{
    /// <summary>
    /// Defines whether to check the customer's balance before processing the charge.
    /// </summary>
    public required ApiEnum<string, ChargeUnmaskResponseDataConfigBalanceCheck> BalanceCheck
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, ChargeUnmaskResponseDataConfigBalanceCheck>
            >("balance_check");
        }
        init { this._rawData.Set("balance_check", value); }
    }

    /// <summary>
    /// Payment will simulate processing if not Standard.
    /// </summary>
    public ApiEnum<string, ChargeUnmaskResponseDataConfigSandboxOutcome>? SandboxOutcome
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, ChargeUnmaskResponseDataConfigSandboxOutcome>
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
        this.BalanceCheck.Validate();
        this.SandboxOutcome?.Validate();
    }

    public ChargeUnmaskResponseDataConfig() { }

    public ChargeUnmaskResponseDataConfig(
        ChargeUnmaskResponseDataConfig chargeUnmaskResponseDataConfig
    )
        : base(chargeUnmaskResponseDataConfig) { }

    public ChargeUnmaskResponseDataConfig(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ChargeUnmaskResponseDataConfig(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ChargeUnmaskResponseDataConfigFromRaw.FromRawUnchecked"/>
    public static ChargeUnmaskResponseDataConfig FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public ChargeUnmaskResponseDataConfig(
        ApiEnum<string, ChargeUnmaskResponseDataConfigBalanceCheck> balanceCheck
    )
        : this()
    {
        this.BalanceCheck = balanceCheck;
    }
}

class ChargeUnmaskResponseDataConfigFromRaw : IFromRawJson<ChargeUnmaskResponseDataConfig>
{
    /// <inheritdoc/>
    public ChargeUnmaskResponseDataConfig FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ChargeUnmaskResponseDataConfig.FromRawUnchecked(rawData);
}

/// <summary>
/// Defines whether to check the customer's balance before processing the charge.
/// </summary>
[JsonConverter(typeof(ChargeUnmaskResponseDataConfigBalanceCheckConverter))]
public enum ChargeUnmaskResponseDataConfigBalanceCheck
{
    Required,
    Enabled,
    Disabled,
}

sealed class ChargeUnmaskResponseDataConfigBalanceCheckConverter
    : JsonConverter<ChargeUnmaskResponseDataConfigBalanceCheck>
{
    public override ChargeUnmaskResponseDataConfigBalanceCheck Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "required" => ChargeUnmaskResponseDataConfigBalanceCheck.Required,
            "enabled" => ChargeUnmaskResponseDataConfigBalanceCheck.Enabled,
            "disabled" => ChargeUnmaskResponseDataConfigBalanceCheck.Disabled,
            _ => (ChargeUnmaskResponseDataConfigBalanceCheck)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ChargeUnmaskResponseDataConfigBalanceCheck value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ChargeUnmaskResponseDataConfigBalanceCheck.Required => "required",
                ChargeUnmaskResponseDataConfigBalanceCheck.Enabled => "enabled",
                ChargeUnmaskResponseDataConfigBalanceCheck.Disabled => "disabled",
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
[JsonConverter(typeof(ChargeUnmaskResponseDataConfigSandboxOutcomeConverter))]
public enum ChargeUnmaskResponseDataConfigSandboxOutcome
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

sealed class ChargeUnmaskResponseDataConfigSandboxOutcomeConverter
    : JsonConverter<ChargeUnmaskResponseDataConfigSandboxOutcome>
{
    public override ChargeUnmaskResponseDataConfigSandboxOutcome Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "standard" => ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
            "paid" => ChargeUnmaskResponseDataConfigSandboxOutcome.Paid,
            "on_hold_daily_limit" => ChargeUnmaskResponseDataConfigSandboxOutcome.OnHoldDailyLimit,
            "cancelled_for_fraud_risk" =>
                ChargeUnmaskResponseDataConfigSandboxOutcome.CancelledForFraudRisk,
            "cancelled_for_balance_check" =>
                ChargeUnmaskResponseDataConfigSandboxOutcome.CancelledForBalanceCheck,
            "failed_insufficient_funds" =>
                ChargeUnmaskResponseDataConfigSandboxOutcome.FailedInsufficientFunds,
            "reversed_insufficient_funds" =>
                ChargeUnmaskResponseDataConfigSandboxOutcome.ReversedInsufficientFunds,
            "failed_customer_dispute" =>
                ChargeUnmaskResponseDataConfigSandboxOutcome.FailedCustomerDispute,
            "reversed_customer_dispute" =>
                ChargeUnmaskResponseDataConfigSandboxOutcome.ReversedCustomerDispute,
            "failed_closed_bank_account" =>
                ChargeUnmaskResponseDataConfigSandboxOutcome.FailedClosedBankAccount,
            "reversed_closed_bank_account" =>
                ChargeUnmaskResponseDataConfigSandboxOutcome.ReversedClosedBankAccount,
            _ => (ChargeUnmaskResponseDataConfigSandboxOutcome)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ChargeUnmaskResponseDataConfigSandboxOutcome value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ChargeUnmaskResponseDataConfigSandboxOutcome.Standard => "standard",
                ChargeUnmaskResponseDataConfigSandboxOutcome.Paid => "paid",
                ChargeUnmaskResponseDataConfigSandboxOutcome.OnHoldDailyLimit =>
                    "on_hold_daily_limit",
                ChargeUnmaskResponseDataConfigSandboxOutcome.CancelledForFraudRisk =>
                    "cancelled_for_fraud_risk",
                ChargeUnmaskResponseDataConfigSandboxOutcome.CancelledForBalanceCheck =>
                    "cancelled_for_balance_check",
                ChargeUnmaskResponseDataConfigSandboxOutcome.FailedInsufficientFunds =>
                    "failed_insufficient_funds",
                ChargeUnmaskResponseDataConfigSandboxOutcome.ReversedInsufficientFunds =>
                    "reversed_insufficient_funds",
                ChargeUnmaskResponseDataConfigSandboxOutcome.FailedCustomerDispute =>
                    "failed_customer_dispute",
                ChargeUnmaskResponseDataConfigSandboxOutcome.ReversedCustomerDispute =>
                    "reversed_customer_dispute",
                ChargeUnmaskResponseDataConfigSandboxOutcome.FailedClosedBankAccount =>
                    "failed_closed_bank_account",
                ChargeUnmaskResponseDataConfigSandboxOutcome.ReversedClosedBankAccount =>
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
[JsonConverter(typeof(ChargeUnmaskResponseDataConsentTypeConverter))]
public enum ChargeUnmaskResponseDataConsentType
{
    Internet,
    Signed,
}

sealed class ChargeUnmaskResponseDataConsentTypeConverter
    : JsonConverter<ChargeUnmaskResponseDataConsentType>
{
    public override ChargeUnmaskResponseDataConsentType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "internet" => ChargeUnmaskResponseDataConsentType.Internet,
            "signed" => ChargeUnmaskResponseDataConsentType.Signed,
            _ => (ChargeUnmaskResponseDataConsentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ChargeUnmaskResponseDataConsentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ChargeUnmaskResponseDataConsentType.Internet => "internet",
                ChargeUnmaskResponseDataConsentType.Signed => "signed",
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
[JsonConverter(typeof(ChargeUnmaskResponseDataStatusConverter))]
public enum ChargeUnmaskResponseDataStatus
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

sealed class ChargeUnmaskResponseDataStatusConverter : JsonConverter<ChargeUnmaskResponseDataStatus>
{
    public override ChargeUnmaskResponseDataStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created" => ChargeUnmaskResponseDataStatus.Created,
            "scheduled" => ChargeUnmaskResponseDataStatus.Scheduled,
            "failed" => ChargeUnmaskResponseDataStatus.Failed,
            "cancelled" => ChargeUnmaskResponseDataStatus.Cancelled,
            "on_hold" => ChargeUnmaskResponseDataStatus.OnHold,
            "pending" => ChargeUnmaskResponseDataStatus.Pending,
            "paid" => ChargeUnmaskResponseDataStatus.Paid,
            "reversed" => ChargeUnmaskResponseDataStatus.Reversed,
            _ => (ChargeUnmaskResponseDataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ChargeUnmaskResponseDataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ChargeUnmaskResponseDataStatus.Created => "created",
                ChargeUnmaskResponseDataStatus.Scheduled => "scheduled",
                ChargeUnmaskResponseDataStatus.Failed => "failed",
                ChargeUnmaskResponseDataStatus.Cancelled => "cancelled",
                ChargeUnmaskResponseDataStatus.OnHold => "on_hold",
                ChargeUnmaskResponseDataStatus.Pending => "pending",
                ChargeUnmaskResponseDataStatus.Paid => "paid",
                ChargeUnmaskResponseDataStatus.Reversed => "reversed",
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
        ChargeUnmaskResponseDataStatusHistory,
        ChargeUnmaskResponseDataStatusHistoryFromRaw
    >)
)]
public sealed record class ChargeUnmaskResponseDataStatusHistory : JsonModel
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
    public required ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryReason> Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryReason>
            >("reason");
        }
        init { this._rawData.Set("reason", value); }
    }

    /// <summary>
    /// Identifies the origin of the status change (e.g., `bank_decline`, `watchtower`).
    /// This helps in tracking the cause of status updates.
    /// </summary>
    public required ApiEnum<string, ChargeUnmaskResponseDataStatusHistorySource> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, ChargeUnmaskResponseDataStatusHistorySource>
            >("source");
        }
        init { this._rawData.Set("source", value); }
    }

    /// <summary>
    /// The current status of the `charge` or `payout`.
    /// </summary>
    public required ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryStatus>
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

    public ChargeUnmaskResponseDataStatusHistory() { }

    public ChargeUnmaskResponseDataStatusHistory(
        ChargeUnmaskResponseDataStatusHistory chargeUnmaskResponseDataStatusHistory
    )
        : base(chargeUnmaskResponseDataStatusHistory) { }

    public ChargeUnmaskResponseDataStatusHistory(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ChargeUnmaskResponseDataStatusHistory(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ChargeUnmaskResponseDataStatusHistoryFromRaw.FromRawUnchecked"/>
    public static ChargeUnmaskResponseDataStatusHistory FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ChargeUnmaskResponseDataStatusHistoryFromRaw
    : IFromRawJson<ChargeUnmaskResponseDataStatusHistory>
{
    /// <inheritdoc/>
    public ChargeUnmaskResponseDataStatusHistory FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ChargeUnmaskResponseDataStatusHistory.FromRawUnchecked(rawData);
}

/// <summary>
/// A machine-readable identifier for the specific status, useful for programmatic handling.
/// </summary>
[JsonConverter(typeof(ChargeUnmaskResponseDataStatusHistoryReasonConverter))]
public enum ChargeUnmaskResponseDataStatusHistoryReason
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

sealed class ChargeUnmaskResponseDataStatusHistoryReasonConverter
    : JsonConverter<ChargeUnmaskResponseDataStatusHistoryReason>
{
    public override ChargeUnmaskResponseDataStatusHistoryReason Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "insufficient_funds" => ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            "closed_bank_account" => ChargeUnmaskResponseDataStatusHistoryReason.ClosedBankAccount,
            "invalid_bank_account" =>
                ChargeUnmaskResponseDataStatusHistoryReason.InvalidBankAccount,
            "invalid_routing" => ChargeUnmaskResponseDataStatusHistoryReason.InvalidRouting,
            "disputed" => ChargeUnmaskResponseDataStatusHistoryReason.Disputed,
            "payment_stopped" => ChargeUnmaskResponseDataStatusHistoryReason.PaymentStopped,
            "owner_deceased" => ChargeUnmaskResponseDataStatusHistoryReason.OwnerDeceased,
            "frozen_bank_account" => ChargeUnmaskResponseDataStatusHistoryReason.FrozenBankAccount,
            "risk_review" => ChargeUnmaskResponseDataStatusHistoryReason.RiskReview,
            "fraudulent" => ChargeUnmaskResponseDataStatusHistoryReason.Fraudulent,
            "duplicate_entry" => ChargeUnmaskResponseDataStatusHistoryReason.DuplicateEntry,
            "invalid_paykey" => ChargeUnmaskResponseDataStatusHistoryReason.InvalidPaykey,
            "payment_blocked" => ChargeUnmaskResponseDataStatusHistoryReason.PaymentBlocked,
            "amount_too_large" => ChargeUnmaskResponseDataStatusHistoryReason.AmountTooLarge,
            "too_many_attempts" => ChargeUnmaskResponseDataStatusHistoryReason.TooManyAttempts,
            "internal_system_error" =>
                ChargeUnmaskResponseDataStatusHistoryReason.InternalSystemError,
            "user_request" => ChargeUnmaskResponseDataStatusHistoryReason.UserRequest,
            "ok" => ChargeUnmaskResponseDataStatusHistoryReason.Ok,
            "other_network_return" =>
                ChargeUnmaskResponseDataStatusHistoryReason.OtherNetworkReturn,
            "payout_refused" => ChargeUnmaskResponseDataStatusHistoryReason.PayoutRefused,
            "cancel_request" => ChargeUnmaskResponseDataStatusHistoryReason.CancelRequest,
            "failed_verification" => ChargeUnmaskResponseDataStatusHistoryReason.FailedVerification,
            "require_review" => ChargeUnmaskResponseDataStatusHistoryReason.RequireReview,
            "blocked_by_system" => ChargeUnmaskResponseDataStatusHistoryReason.BlockedBySystem,
            "watchtower_review" => ChargeUnmaskResponseDataStatusHistoryReason.WatchtowerReview,
            _ => (ChargeUnmaskResponseDataStatusHistoryReason)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ChargeUnmaskResponseDataStatusHistoryReason value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds =>
                    "insufficient_funds",
                ChargeUnmaskResponseDataStatusHistoryReason.ClosedBankAccount =>
                    "closed_bank_account",
                ChargeUnmaskResponseDataStatusHistoryReason.InvalidBankAccount =>
                    "invalid_bank_account",
                ChargeUnmaskResponseDataStatusHistoryReason.InvalidRouting => "invalid_routing",
                ChargeUnmaskResponseDataStatusHistoryReason.Disputed => "disputed",
                ChargeUnmaskResponseDataStatusHistoryReason.PaymentStopped => "payment_stopped",
                ChargeUnmaskResponseDataStatusHistoryReason.OwnerDeceased => "owner_deceased",
                ChargeUnmaskResponseDataStatusHistoryReason.FrozenBankAccount =>
                    "frozen_bank_account",
                ChargeUnmaskResponseDataStatusHistoryReason.RiskReview => "risk_review",
                ChargeUnmaskResponseDataStatusHistoryReason.Fraudulent => "fraudulent",
                ChargeUnmaskResponseDataStatusHistoryReason.DuplicateEntry => "duplicate_entry",
                ChargeUnmaskResponseDataStatusHistoryReason.InvalidPaykey => "invalid_paykey",
                ChargeUnmaskResponseDataStatusHistoryReason.PaymentBlocked => "payment_blocked",
                ChargeUnmaskResponseDataStatusHistoryReason.AmountTooLarge => "amount_too_large",
                ChargeUnmaskResponseDataStatusHistoryReason.TooManyAttempts => "too_many_attempts",
                ChargeUnmaskResponseDataStatusHistoryReason.InternalSystemError =>
                    "internal_system_error",
                ChargeUnmaskResponseDataStatusHistoryReason.UserRequest => "user_request",
                ChargeUnmaskResponseDataStatusHistoryReason.Ok => "ok",
                ChargeUnmaskResponseDataStatusHistoryReason.OtherNetworkReturn =>
                    "other_network_return",
                ChargeUnmaskResponseDataStatusHistoryReason.PayoutRefused => "payout_refused",
                ChargeUnmaskResponseDataStatusHistoryReason.CancelRequest => "cancel_request",
                ChargeUnmaskResponseDataStatusHistoryReason.FailedVerification =>
                    "failed_verification",
                ChargeUnmaskResponseDataStatusHistoryReason.RequireReview => "require_review",
                ChargeUnmaskResponseDataStatusHistoryReason.BlockedBySystem => "blocked_by_system",
                ChargeUnmaskResponseDataStatusHistoryReason.WatchtowerReview => "watchtower_review",
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
[JsonConverter(typeof(ChargeUnmaskResponseDataStatusHistorySourceConverter))]
public enum ChargeUnmaskResponseDataStatusHistorySource
{
    Watchtower,
    BankDecline,
    CustomerDispute,
    UserAction,
    System,
}

sealed class ChargeUnmaskResponseDataStatusHistorySourceConverter
    : JsonConverter<ChargeUnmaskResponseDataStatusHistorySource>
{
    public override ChargeUnmaskResponseDataStatusHistorySource Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "watchtower" => ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
            "bank_decline" => ChargeUnmaskResponseDataStatusHistorySource.BankDecline,
            "customer_dispute" => ChargeUnmaskResponseDataStatusHistorySource.CustomerDispute,
            "user_action" => ChargeUnmaskResponseDataStatusHistorySource.UserAction,
            "system" => ChargeUnmaskResponseDataStatusHistorySource.System,
            _ => (ChargeUnmaskResponseDataStatusHistorySource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ChargeUnmaskResponseDataStatusHistorySource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ChargeUnmaskResponseDataStatusHistorySource.Watchtower => "watchtower",
                ChargeUnmaskResponseDataStatusHistorySource.BankDecline => "bank_decline",
                ChargeUnmaskResponseDataStatusHistorySource.CustomerDispute => "customer_dispute",
                ChargeUnmaskResponseDataStatusHistorySource.UserAction => "user_action",
                ChargeUnmaskResponseDataStatusHistorySource.System => "system",
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
[JsonConverter(typeof(ChargeUnmaskResponseDataStatusHistoryStatusConverter))]
public enum ChargeUnmaskResponseDataStatusHistoryStatus
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

sealed class ChargeUnmaskResponseDataStatusHistoryStatusConverter
    : JsonConverter<ChargeUnmaskResponseDataStatusHistoryStatus>
{
    public override ChargeUnmaskResponseDataStatusHistoryStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created" => ChargeUnmaskResponseDataStatusHistoryStatus.Created,
            "scheduled" => ChargeUnmaskResponseDataStatusHistoryStatus.Scheduled,
            "failed" => ChargeUnmaskResponseDataStatusHistoryStatus.Failed,
            "cancelled" => ChargeUnmaskResponseDataStatusHistoryStatus.Cancelled,
            "on_hold" => ChargeUnmaskResponseDataStatusHistoryStatus.OnHold,
            "pending" => ChargeUnmaskResponseDataStatusHistoryStatus.Pending,
            "paid" => ChargeUnmaskResponseDataStatusHistoryStatus.Paid,
            "reversed" => ChargeUnmaskResponseDataStatusHistoryStatus.Reversed,
            _ => (ChargeUnmaskResponseDataStatusHistoryStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ChargeUnmaskResponseDataStatusHistoryStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ChargeUnmaskResponseDataStatusHistoryStatus.Created => "created",
                ChargeUnmaskResponseDataStatusHistoryStatus.Scheduled => "scheduled",
                ChargeUnmaskResponseDataStatusHistoryStatus.Failed => "failed",
                ChargeUnmaskResponseDataStatusHistoryStatus.Cancelled => "cancelled",
                ChargeUnmaskResponseDataStatusHistoryStatus.OnHold => "on_hold",
                ChargeUnmaskResponseDataStatusHistoryStatus.Pending => "pending",
                ChargeUnmaskResponseDataStatusHistoryStatus.Paid => "paid",
                ChargeUnmaskResponseDataStatusHistoryStatus.Reversed => "reversed",
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
[JsonConverter(typeof(ChargeUnmaskResponseDataPaymentRailConverter))]
public enum ChargeUnmaskResponseDataPaymentRail
{
    Ach,
}

sealed class ChargeUnmaskResponseDataPaymentRailConverter
    : JsonConverter<ChargeUnmaskResponseDataPaymentRail>
{
    public override ChargeUnmaskResponseDataPaymentRail Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "ach" => ChargeUnmaskResponseDataPaymentRail.Ach,
            _ => (ChargeUnmaskResponseDataPaymentRail)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ChargeUnmaskResponseDataPaymentRail value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ChargeUnmaskResponseDataPaymentRail.Ach => "ach",
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
[JsonConverter(typeof(ChargeUnmaskResponseResponseTypeConverter))]
public enum ChargeUnmaskResponseResponseType
{
    Object,
    Array,
    Error,
    None,
}

sealed class ChargeUnmaskResponseResponseTypeConverter
    : JsonConverter<ChargeUnmaskResponseResponseType>
{
    public override ChargeUnmaskResponseResponseType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "object" => ChargeUnmaskResponseResponseType.Object,
            "array" => ChargeUnmaskResponseResponseType.Array,
            "error" => ChargeUnmaskResponseResponseType.Error,
            "none" => ChargeUnmaskResponseResponseType.None,
            _ => (ChargeUnmaskResponseResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ChargeUnmaskResponseResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ChargeUnmaskResponseResponseType.Object => "object",
                ChargeUnmaskResponseResponseType.Array => "array",
                ChargeUnmaskResponseResponseType.Error => "error",
                ChargeUnmaskResponseResponseType.None => "none",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
