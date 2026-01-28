using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Embed.LinkedBankAccounts;

/// <summary>
/// Creates a new linked bank account associated with a Straddle account. This endpoint
/// allows you to associate external bank accounts with a Straddle account for various
/// payment operations such as payment deposits, payout withdrawals, and more.
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public record class LinkedBankAccountCreateParams : ParamsBase
{
    readonly JsonDictionary _rawBodyData = new();
    public IReadOnlyDictionary<string, JsonElement> RawBodyData
    {
        get { return this._rawBodyData.Freeze(); }
    }

    /// <summary>
    /// The unique identifier of the Straddle account to associate this bank account with.
    /// </summary>
    public required string? AccountID
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<string>("account_id");
        }
        init { this._rawBodyData.Set("account_id", value); }
    }

    public required BankAccount BankAccount
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<BankAccount>("bank_account");
        }
        init { this._rawBodyData.Set("bank_account", value); }
    }

    /// <summary>
    /// Optional description for the bank account.
    /// </summary>
    public string? Description
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<string>("description");
        }
        init { this._rawBodyData.Set("description", value); }
    }

    /// <summary>
    /// Up to 20 additional user-defined key-value pairs. Useful for storing additional
    /// information about the linked bank account in a structured format.
    /// </summary>
    public IReadOnlyDictionary<string, string?>? Metadata
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<FrozenDictionary<string, string?>>(
                "metadata"
            );
        }
        init
        {
            this._rawBodyData.Set<FrozenDictionary<string, string?>?>(
                "metadata",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    /// <summary>
    /// The unique identifier of the Straddle Platform to associate this bank account with.
    /// </summary>
    public string? PlatformID
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<string>("platform_id");
        }
        init { this._rawBodyData.Set("platform_id", value); }
    }

    /// <summary>
    /// The purposes for the linked bank account.
    /// </summary>
    public IReadOnlyList<ApiEnum<string, Purpose>>? Purposes
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<ImmutableArray<ApiEnum<string, Purpose>>>(
                "purposes"
            );
        }
        init
        {
            this._rawBodyData.Set<ImmutableArray<ApiEnum<string, Purpose>>?>(
                "purposes",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? CorrelationID
    {
        get
        {
            this._rawHeaderData.Freeze();
            return this._rawHeaderData.GetNullableClass<string>("correlation-id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawHeaderData.Set("correlation-id", value);
        }
    }

    public string? IdempotencyKey
    {
        get
        {
            this._rawHeaderData.Freeze();
            return this._rawHeaderData.GetNullableClass<string>("idempotency-key");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawHeaderData.Set("idempotency-key", value);
        }
    }

    public string? RequestID
    {
        get
        {
            this._rawHeaderData.Freeze();
            return this._rawHeaderData.GetNullableClass<string>("request-id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawHeaderData.Set("request-id", value);
        }
    }

    public LinkedBankAccountCreateParams() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public LinkedBankAccountCreateParams(
        LinkedBankAccountCreateParams linkedBankAccountCreateParams
    )
        : base(linkedBankAccountCreateParams)
    {
        this._rawBodyData = new(linkedBankAccountCreateParams._rawBodyData);
    }
#pragma warning restore CS8618

    public LinkedBankAccountCreateParams(
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
    LinkedBankAccountCreateParams(
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
    public static LinkedBankAccountCreateParams FromRawUnchecked(
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

    public virtual bool Equals(LinkedBankAccountCreateParams? other)
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
        return new UriBuilder(options.BaseUrl.ToString().TrimEnd('/') + "/v1/linked_bank_accounts")
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

[JsonConverter(typeof(JsonModelConverter<BankAccount, BankAccountFromRaw>))]
public sealed record class BankAccount : JsonModel
{
    /// <summary>
    /// The name of the account holder as it appears on the bank account. Typically,
    /// this is the legal name of the business associated with the account.
    /// </summary>
    public required string AccountHolder
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("account_holder");
        }
        init { this._rawData.Set("account_holder", value); }
    }

    /// <summary>
    /// The bank account number.
    /// </summary>
    public required string AccountNumber
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("account_number");
        }
        init { this._rawData.Set("account_number", value); }
    }

    /// <summary>
    /// The routing number of the bank account.
    /// </summary>
    public required string RoutingNumber
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("routing_number");
        }
        init { this._rawData.Set("routing_number", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AccountHolder;
        _ = this.AccountNumber;
        _ = this.RoutingNumber;
    }

    public BankAccount() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public BankAccount(BankAccount bankAccount)
        : base(bankAccount) { }
#pragma warning restore CS8618

    public BankAccount(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    BankAccount(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="BankAccountFromRaw.FromRawUnchecked"/>
    public static BankAccount FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class BankAccountFromRaw : IFromRawJson<BankAccount>
{
    /// <inheritdoc/>
    public BankAccount FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        BankAccount.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(PurposeConverter))]
public enum Purpose
{
    Charges,
    Payouts,
    Billing,
}

sealed class PurposeConverter : JsonConverter<Purpose>
{
    public override Purpose Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "charges" => Purpose.Charges,
            "payouts" => Purpose.Payouts,
            "billing" => Purpose.Billing,
            _ => (Purpose)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Purpose value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Purpose.Charges => "charges",
                Purpose.Payouts => "payouts",
                Purpose.Billing => "billing",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
