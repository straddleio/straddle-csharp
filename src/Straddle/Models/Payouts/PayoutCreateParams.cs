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

namespace Straddle.Models.Payouts;

/// <summary>
/// Use payouts to send money to your customers.
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public record class PayoutCreateParams : ParamsBase
{
    readonly JsonDictionary _rawBodyData = new();
    public IReadOnlyDictionary<string, JsonElement> RawBodyData
    {
        get { return this._rawBodyData.Freeze(); }
    }

    /// <summary>
    /// The amount of the payout in cents.
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

    /// <summary>
    /// The currency of the payout. Only USD is supported.
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
    /// An arbitrary description for the payout.
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

    /// <summary>
    /// Information about the device used when the customer authorized the payout.
    /// </summary>
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
    /// Unique identifier for the payout in your database. This value must be unique
    /// across all payouts.
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
    /// Value of the `paykey` used for the payout.
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
    /// The desired date on which the payout should be occur. For payouts, this means
    /// the date you want the funds to be sent from your bank account.
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

    public Config? Config
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<Config>("config");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("config", value);
        }
    }

    /// <summary>
    /// Up to 20 additional user-defined key-value pairs. Useful for storing additional
    /// information about the payout in a structured format.
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

    public PayoutCreateParams() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public PayoutCreateParams(PayoutCreateParams payoutCreateParams)
        : base(payoutCreateParams)
    {
        this._rawBodyData = new(payoutCreateParams._rawBodyData);
    }
#pragma warning restore CS8618

    public PayoutCreateParams(
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
    PayoutCreateParams(
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
    public static PayoutCreateParams FromRawUnchecked(
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

    public virtual bool Equals(PayoutCreateParams? other)
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
        return new UriBuilder(options.BaseUrl.ToString().TrimEnd('/') + "/v1/payouts")
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
        this.SandboxOutcome?.Validate();
    }

    public Config() { }

    public Config(Config config)
        : base(config) { }

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
}

class ConfigFromRaw : IFromRawJson<Config>
{
    /// <inheritdoc/>
    public Config FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Config.FromRawUnchecked(rawData);
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
            "Standard" => SandboxOutcome.Standard1,
            "Paid" => SandboxOutcome.Paid1,
            "OnHoldDailyLimit" => SandboxOutcome.OnHoldDailyLimit1,
            "CancelledForFraudRisk" => SandboxOutcome.CancelledForFraudRisk1,
            "CancelledForBalanceCheck" => SandboxOutcome.CancelledForBalanceCheck1,
            "FailedInsufficientFunds" => SandboxOutcome.FailedInsufficientFunds1,
            "ReversedInsufficientFunds" => SandboxOutcome.ReversedInsufficientFunds1,
            "FailedCustomerDispute" => SandboxOutcome.FailedCustomerDispute1,
            "ReversedCustomerDispute" => SandboxOutcome.ReversedCustomerDispute1,
            "FailedClosedBankAccount" => SandboxOutcome.FailedClosedBankAccount1,
            "ReversedClosedBankAccount" => SandboxOutcome.ReversedClosedBankAccount1,
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
                SandboxOutcome.Standard1 => "Standard",
                SandboxOutcome.Paid1 => "Paid",
                SandboxOutcome.OnHoldDailyLimit1 => "OnHoldDailyLimit",
                SandboxOutcome.CancelledForFraudRisk1 => "CancelledForFraudRisk",
                SandboxOutcome.CancelledForBalanceCheck1 => "CancelledForBalanceCheck",
                SandboxOutcome.FailedInsufficientFunds1 => "FailedInsufficientFunds",
                SandboxOutcome.ReversedInsufficientFunds1 => "ReversedInsufficientFunds",
                SandboxOutcome.FailedCustomerDispute1 => "FailedCustomerDispute",
                SandboxOutcome.ReversedCustomerDispute1 => "ReversedCustomerDispute",
                SandboxOutcome.FailedClosedBankAccount1 => "FailedClosedBankAccount",
                SandboxOutcome.ReversedClosedBankAccount1 => "ReversedClosedBankAccount",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
