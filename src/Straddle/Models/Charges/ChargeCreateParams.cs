using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Charges;

/// <summary>
/// Use charges to collect money from a customer for the sale of goods or services.
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public record class ChargeCreateParams : ParamsBase
{
    readonly JsonDictionary _rawBodyData = new();
    public IReadOnlyDictionary<string, JsonElement> RawBodyData
    {
        get { return this._rawBodyData.Freeze(); }
    }

    /// <summary>
    /// The amount of the charge in cents.
    /// </summary>
    public required int Amount
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullStruct<int>("amount");
        }
        init { this._rawBodyData.Set("amount", value); }
    }

    public required Config Config
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<Config>("config");
        }
        init { this._rawBodyData.Set("config", value); }
    }

    /// <summary>
    /// The channel or mechanism through which the payment was authorized. Use `internet`
    /// for payments made online or through a mobile app and `signed` for signed agreements
    /// where there is a consent form or contract. Use `signed` for PDF signatures.
    /// </summary>
    public required ApiEnum<string, ConsentType> ConsentType
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<ApiEnum<string, ConsentType>>("consent_type");
        }
        init { this._rawBodyData.Set("consent_type", value); }
    }

    /// <summary>
    /// The currency of the charge. Only USD is supported.
    /// </summary>
    public required string Currency
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("currency");
        }
        init { this._rawBodyData.Set("currency", value); }
    }

    /// <summary>
    /// An arbitrary description for the charge.
    /// </summary>
    public required string? Description
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<string>("description");
        }
        init { this._rawBodyData.Set("description", value); }
    }

    public required DeviceInfoV1 Device
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<DeviceInfoV1>("device");
        }
        init { this._rawBodyData.Set("device", value); }
    }

    /// <summary>
    /// Unique identifier for the charge in your database. This value must be unique
    /// across all charges.
    /// </summary>
    public required string ExternalID
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("external_id");
        }
        init { this._rawBodyData.Set("external_id", value); }
    }

    /// <summary>
    /// Value of the `paykey` used for the charge.
    /// </summary>
    public required string Paykey
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("paykey");
        }
        init { this._rawBodyData.Set("paykey", value); }
    }

    /// <summary>
    /// The desired date on which the payment should be occur. For charges, this means
    /// the date you want the customer to be debited on.
    /// </summary>
    public required string PaymentDate
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("payment_date");
        }
        init { this._rawBodyData.Set("payment_date", value); }
    }

    /// <summary>
    /// Up to 20 additional user-defined key-value pairs. Useful for storing additional
    /// information about the charge in a structured format.
    /// </summary>
    public IReadOnlyDictionary<string, string>? Metadata
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<FrozenDictionary<string, string>>("metadata");
        }
        init
        {
            this._rawBodyData.Set<FrozenDictionary<string, string>?>(
                "metadata",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    public string? CorrelationID
    {
        get
        {
            this._rawHeaderData.Freeze();
            return this._rawHeaderData.GetNullableClass<string>("Correlation-Id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawHeaderData.Set("Correlation-Id", value);
        }
    }

    public string? IdempotencyKey
    {
        get
        {
            this._rawHeaderData.Freeze();
            return this._rawHeaderData.GetNullableClass<string>("Idempotency-Key");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawHeaderData.Set("Idempotency-Key", value);
        }
    }

    public string? RequestID
    {
        get
        {
            this._rawHeaderData.Freeze();
            return this._rawHeaderData.GetNullableClass<string>("Request-Id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawHeaderData.Set("Request-Id", value);
        }
    }

    public string? StraddleAccountID
    {
        get
        {
            this._rawHeaderData.Freeze();
            return this._rawHeaderData.GetNullableClass<string>("Straddle-Account-Id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawHeaderData.Set("Straddle-Account-Id", value);
        }
    }

    public ChargeCreateParams() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ChargeCreateParams(ChargeCreateParams chargeCreateParams)
        : base(chargeCreateParams)
    {
        this._rawBodyData = new(chargeCreateParams._rawBodyData);
    }
#pragma warning restore CS8618

    public ChargeCreateParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        IReadOnlyDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
        this._rawBodyData = new(rawBodyData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ChargeCreateParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData,
        FrozenDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
        this._rawBodyData = new(rawBodyData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
    public static ChargeCreateParams FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        IReadOnlyDictionary<string, JsonElement> rawBodyData
    )
    {
        return new(
            FrozenDictionary.ToFrozenDictionary(rawHeaderData),
            FrozenDictionary.ToFrozenDictionary(rawQueryData),
            FrozenDictionary.ToFrozenDictionary(rawBodyData)
        );
    }

    public override string ToString() =>
        JsonSerializer.Serialize(
            new Dictionary<string, object?>()
            {
                ["HeaderData"] = this._rawHeaderData.Freeze(),
                ["QueryData"] = this._rawQueryData.Freeze(),
                ["BodyData"] = this._rawBodyData.Freeze(),
            },
            ModelBase.ToStringSerializerOptions
        );

    public virtual bool Equals(ChargeCreateParams? other)
    {
        if (other == null)
        {
            return false;
        }
        return this._rawHeaderData.Equals(other._rawHeaderData)
            && this._rawQueryData.Equals(other._rawQueryData)
            && this._rawBodyData.Equals(other._rawBodyData);
    }

    public override Uri Url(ClientOptions options)
    {
        return new UriBuilder(options.BaseUrl.ToString().TrimEnd('/') + "/v1/charges")
        {
            Query = this.QueryString(options),
        }.Uri;
    }

    internal override HttpContent? BodyContent()
    {
        return new StringContent(
            JsonSerializer.Serialize(this.RawBodyData, ModelBase.SerializerOptions),
            Encoding.UTF8,
            "application/json"
        );
    }

    internal override void AddHeadersToRequest(HttpRequestMessage request, ClientOptions options)
    {
        ParamsBase.AddDefaultHeaders(request, options);
        foreach (var item in this.RawHeaderData)
        {
            ParamsBase.AddHeaderElementToRequest(request, item.Key, item.Value);
        }
    }

    public override int GetHashCode()
    {
        return 0;
    }
}

[JsonConverter(typeof(JsonModelConverter<Config, ConfigFromRaw>))]
public sealed record class Config : JsonModel
{
    /// <summary>
    /// Defines whether to check the customer's balance before processing the charge.
    /// </summary>
    public required ApiEnum<string, BalanceCheck> BalanceCheck
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, BalanceCheck>>("balance_check");
        }
        init { this._rawData.Set("balance_check", value); }
    }

    /// <summary>
    /// Payment will simulate processing if not Standard.
    /// </summary>
    public ApiEnum<string, SandboxOutcome>? SandboxOutcome
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, SandboxOutcome>>(
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

    public Config() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Config(Config config)
        : base(config) { }
#pragma warning restore CS8618

    public Config(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Config(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ConfigFromRaw.FromRawUnchecked"/>
    public static Config FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public Config(ApiEnum<string, BalanceCheck> balanceCheck)
        : this()
    {
        this.BalanceCheck = balanceCheck;
    }
}

class ConfigFromRaw : IFromRawJson<Config>
{
    /// <inheritdoc/>
    public Config FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Config.FromRawUnchecked(rawData);
}

/// <summary>
/// Defines whether to check the customer's balance before processing the charge.
/// </summary>
[JsonConverter(typeof(BalanceCheckConverter))]
public enum BalanceCheck
{
    Required,
    Enabled,
    Disabled,
}

sealed class BalanceCheckConverter : JsonConverter<BalanceCheck>
{
    public override BalanceCheck Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "required" => BalanceCheck.Required,
            "enabled" => BalanceCheck.Enabled,
            "disabled" => BalanceCheck.Disabled,
            _ => (BalanceCheck)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        BalanceCheck value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                BalanceCheck.Required => "required",
                BalanceCheck.Enabled => "enabled",
                BalanceCheck.Disabled => "disabled",
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
[JsonConverter(typeof(SandboxOutcomeConverter))]
public enum SandboxOutcome
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

sealed class SandboxOutcomeConverter : JsonConverter<SandboxOutcome>
{
    public override SandboxOutcome Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "standard" => SandboxOutcome.Standard,
            "paid" => SandboxOutcome.Paid,
            "on_hold_daily_limit" => SandboxOutcome.OnHoldDailyLimit,
            "cancelled_for_fraud_risk" => SandboxOutcome.CancelledForFraudRisk,
            "cancelled_for_balance_check" => SandboxOutcome.CancelledForBalanceCheck,
            "failed_insufficient_funds" => SandboxOutcome.FailedInsufficientFunds,
            "reversed_insufficient_funds" => SandboxOutcome.ReversedInsufficientFunds,
            "failed_customer_dispute" => SandboxOutcome.FailedCustomerDispute,
            "reversed_customer_dispute" => SandboxOutcome.ReversedCustomerDispute,
            "failed_closed_bank_account" => SandboxOutcome.FailedClosedBankAccount,
            "reversed_closed_bank_account" => SandboxOutcome.ReversedClosedBankAccount,
            _ => (SandboxOutcome)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        SandboxOutcome value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                SandboxOutcome.Standard => "standard",
                SandboxOutcome.Paid => "paid",
                SandboxOutcome.OnHoldDailyLimit => "on_hold_daily_limit",
                SandboxOutcome.CancelledForFraudRisk => "cancelled_for_fraud_risk",
                SandboxOutcome.CancelledForBalanceCheck => "cancelled_for_balance_check",
                SandboxOutcome.FailedInsufficientFunds => "failed_insufficient_funds",
                SandboxOutcome.ReversedInsufficientFunds => "reversed_insufficient_funds",
                SandboxOutcome.FailedCustomerDispute => "failed_customer_dispute",
                SandboxOutcome.ReversedCustomerDispute => "reversed_customer_dispute",
                SandboxOutcome.FailedClosedBankAccount => "failed_closed_bank_account",
                SandboxOutcome.ReversedClosedBankAccount => "reversed_closed_bank_account",
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
[JsonConverter(typeof(ConsentTypeConverter))]
public enum ConsentType
{
    Internet,
    Signed,
}

sealed class ConsentTypeConverter : JsonConverter<ConsentType>
{
    public override ConsentType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "internet" => ConsentType.Internet,
            "signed" => ConsentType.Signed,
            _ => (ConsentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ConsentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ConsentType.Internet => "internet",
                ConsentType.Signed => "signed",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
