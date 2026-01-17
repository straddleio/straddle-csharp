using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;

namespace Straddle.Models.Embed.Accounts.CapabilityRequests;

/// <summary>
/// Submits a request to enable a specific capability for an account. Use this endpoint
/// to request additional features or services for an account.
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public record class CapabilityRequestCreateParams : ParamsBase
{
    readonly JsonDictionary _rawBodyData = new();
    public IReadOnlyDictionary<string, JsonElement> RawBodyData
    {
        get { return this._rawBodyData.Freeze(); }
    }

    public string? AccountID { get; init; }

    /// <summary>
    /// Allows the account to accept payments from businesses.
    /// </summary>
    public Businesses? Businesses
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<Businesses>("businesses");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("businesses", value);
        }
    }

    /// <summary>
    /// The charges capability settings for the account.
    /// </summary>
    public CapabilityRequestCreateParamsCharges? Charges
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<CapabilityRequestCreateParamsCharges>(
                "charges"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("charges", value);
        }
    }

    /// <summary>
    /// Allows the account to accept payments from individuals.
    /// </summary>
    public Individuals? Individuals
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<Individuals>("individuals");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("individuals", value);
        }
    }

    /// <summary>
    /// Allows the account to accept payments authorized via the internet or mobile applications.
    /// </summary>
    public Internet? Internet
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<Internet>("internet");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("internet", value);
        }
    }

    /// <summary>
    /// The payouts capability settings for the account.
    /// </summary>
    public CapabilityRequestCreateParamsPayouts? Payouts
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<CapabilityRequestCreateParamsPayouts>(
                "payouts"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("payouts", value);
        }
    }

    /// <summary>
    /// Allows the account to accept payments authorized by signed agreements or contracts.
    /// </summary>
    public SignedAgreement? SignedAgreement
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<SignedAgreement>("signed_agreement");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("signed_agreement", value);
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

    public CapabilityRequestCreateParams() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CapabilityRequestCreateParams(
        CapabilityRequestCreateParams capabilityRequestCreateParams
    )
        : base(capabilityRequestCreateParams)
    {
        this.AccountID = capabilityRequestCreateParams.AccountID;

        this._rawBodyData = new(capabilityRequestCreateParams._rawBodyData);
    }
#pragma warning restore CS8618

    public CapabilityRequestCreateParams(
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
    CapabilityRequestCreateParams(
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
    public static CapabilityRequestCreateParams FromRawUnchecked(
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
                ["AccountID"] = this.AccountID,
                ["HeaderData"] = this._rawHeaderData.Freeze(),
                ["QueryData"] = this._rawQueryData.Freeze(),
                ["BodyData"] = this._rawBodyData.Freeze(),
            },
            ModelBase.ToStringSerializerOptions
        );

    public virtual bool Equals(CapabilityRequestCreateParams? other)
    {
        if (other == null)
        {
            return false;
        }
        return (this.AccountID?.Equals(other.AccountID) ?? other.AccountID == null)
            && this._rawHeaderData.Equals(other._rawHeaderData)
            && this._rawQueryData.Equals(other._rawQueryData)
            && this._rawBodyData.Equals(other._rawBodyData);
    }

    public override Uri Url(ClientOptions options)
    {
        return new UriBuilder(
            options.BaseUrl.ToString().TrimEnd('/')
                + string.Format("/v1/accounts/{0}/capability_requests", this.AccountID)
        )
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

/// <summary>
/// Allows the account to accept payments from businesses.
/// </summary>
[JsonConverter(typeof(JsonModelConverter<Businesses, BusinessesFromRaw>))]
public sealed record class Businesses : JsonModel
{
    public required bool Enable
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<bool>("enable");
        }
        init { this._rawData.Set("enable", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Enable;
    }

    public Businesses() { }

    public Businesses(Businesses businesses)
        : base(businesses) { }

    public Businesses(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Businesses(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="BusinessesFromRaw.FromRawUnchecked"/>
    public static Businesses FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public Businesses(bool enable)
        : this()
    {
        this.Enable = enable;
    }
}

class BusinessesFromRaw : IFromRawJson<Businesses>
{
    /// <inheritdoc/>
    public Businesses FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Businesses.FromRawUnchecked(rawData);
}

/// <summary>
/// The charges capability settings for the account.
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        CapabilityRequestCreateParamsCharges,
        CapabilityRequestCreateParamsChargesFromRaw
    >)
)]
public sealed record class CapabilityRequestCreateParamsCharges : JsonModel
{
    /// <summary>
    /// The maximum dollar amount of charges in a calendar day.
    /// </summary>
    public required double DailyAmount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("daily_amount");
        }
        init { this._rawData.Set("daily_amount", value); }
    }

    /// <summary>
    /// Determines whether `charges` are enabled for the account.
    /// </summary>
    public required bool Enable
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<bool>("enable");
        }
        init { this._rawData.Set("enable", value); }
    }

    /// <summary>
    /// The maximum amount of a single charge.
    /// </summary>
    public required double MaxAmount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("max_amount");
        }
        init { this._rawData.Set("max_amount", value); }
    }

    /// <summary>
    /// The maximum dollar amount of charges in a calendar month.
    /// </summary>
    public required double MonthlyAmount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("monthly_amount");
        }
        init { this._rawData.Set("monthly_amount", value); }
    }

    /// <summary>
    /// The maximum number of charges in a calendar month.
    /// </summary>
    public required int MonthlyCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("monthly_count");
        }
        init { this._rawData.Set("monthly_count", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.DailyAmount;
        _ = this.Enable;
        _ = this.MaxAmount;
        _ = this.MonthlyAmount;
        _ = this.MonthlyCount;
    }

    public CapabilityRequestCreateParamsCharges() { }

    public CapabilityRequestCreateParamsCharges(
        CapabilityRequestCreateParamsCharges capabilityRequestCreateParamsCharges
    )
        : base(capabilityRequestCreateParamsCharges) { }

    public CapabilityRequestCreateParamsCharges(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CapabilityRequestCreateParamsCharges(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CapabilityRequestCreateParamsChargesFromRaw.FromRawUnchecked"/>
    public static CapabilityRequestCreateParamsCharges FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CapabilityRequestCreateParamsChargesFromRaw
    : IFromRawJson<CapabilityRequestCreateParamsCharges>
{
    /// <inheritdoc/>
    public CapabilityRequestCreateParamsCharges FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CapabilityRequestCreateParamsCharges.FromRawUnchecked(rawData);
}

/// <summary>
/// Allows the account to accept payments from individuals.
/// </summary>
[JsonConverter(typeof(JsonModelConverter<Individuals, IndividualsFromRaw>))]
public sealed record class Individuals : JsonModel
{
    public required bool Enable
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<bool>("enable");
        }
        init { this._rawData.Set("enable", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Enable;
    }

    public Individuals() { }

    public Individuals(Individuals individuals)
        : base(individuals) { }

    public Individuals(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Individuals(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IndividualsFromRaw.FromRawUnchecked"/>
    public static Individuals FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public Individuals(bool enable)
        : this()
    {
        this.Enable = enable;
    }
}

class IndividualsFromRaw : IFromRawJson<Individuals>
{
    /// <inheritdoc/>
    public Individuals FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Individuals.FromRawUnchecked(rawData);
}

/// <summary>
/// Allows the account to accept payments authorized via the internet or mobile applications.
/// </summary>
[JsonConverter(typeof(JsonModelConverter<Internet, InternetFromRaw>))]
public sealed record class Internet : JsonModel
{
    public required bool Enable
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<bool>("enable");
        }
        init { this._rawData.Set("enable", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Enable;
    }

    public Internet() { }

    public Internet(Internet internet)
        : base(internet) { }

    public Internet(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Internet(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="InternetFromRaw.FromRawUnchecked"/>
    public static Internet FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public Internet(bool enable)
        : this()
    {
        this.Enable = enable;
    }
}

class InternetFromRaw : IFromRawJson<Internet>
{
    /// <inheritdoc/>
    public Internet FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Internet.FromRawUnchecked(rawData);
}

/// <summary>
/// The payouts capability settings for the account.
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        CapabilityRequestCreateParamsPayouts,
        CapabilityRequestCreateParamsPayoutsFromRaw
    >)
)]
public sealed record class CapabilityRequestCreateParamsPayouts : JsonModel
{
    /// <summary>
    /// The maximum dollar amount of payouts in a day.
    /// </summary>
    public required double DailyAmount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("daily_amount");
        }
        init { this._rawData.Set("daily_amount", value); }
    }

    /// <summary>
    /// Determines whether `payouts` are enabled for the account.
    /// </summary>
    public required bool Enable
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<bool>("enable");
        }
        init { this._rawData.Set("enable", value); }
    }

    /// <summary>
    /// The maximum amount of a single payout.
    /// </summary>
    public required double MaxAmount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("max_amount");
        }
        init { this._rawData.Set("max_amount", value); }
    }

    /// <summary>
    /// The maximum dollar amount of payouts in a month.
    /// </summary>
    public required double MonthlyAmount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("monthly_amount");
        }
        init { this._rawData.Set("monthly_amount", value); }
    }

    /// <summary>
    /// The maximum number of payouts in a month.
    /// </summary>
    public required int MonthlyCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("monthly_count");
        }
        init { this._rawData.Set("monthly_count", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.DailyAmount;
        _ = this.Enable;
        _ = this.MaxAmount;
        _ = this.MonthlyAmount;
        _ = this.MonthlyCount;
    }

    public CapabilityRequestCreateParamsPayouts() { }

    public CapabilityRequestCreateParamsPayouts(
        CapabilityRequestCreateParamsPayouts capabilityRequestCreateParamsPayouts
    )
        : base(capabilityRequestCreateParamsPayouts) { }

    public CapabilityRequestCreateParamsPayouts(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CapabilityRequestCreateParamsPayouts(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CapabilityRequestCreateParamsPayoutsFromRaw.FromRawUnchecked"/>
    public static CapabilityRequestCreateParamsPayouts FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CapabilityRequestCreateParamsPayoutsFromRaw
    : IFromRawJson<CapabilityRequestCreateParamsPayouts>
{
    /// <inheritdoc/>
    public CapabilityRequestCreateParamsPayouts FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CapabilityRequestCreateParamsPayouts.FromRawUnchecked(rawData);
}

/// <summary>
/// Allows the account to accept payments authorized by signed agreements or contracts.
/// </summary>
[JsonConverter(typeof(JsonModelConverter<SignedAgreement, SignedAgreementFromRaw>))]
public sealed record class SignedAgreement : JsonModel
{
    public required bool Enable
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<bool>("enable");
        }
        init { this._rawData.Set("enable", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Enable;
    }

    public SignedAgreement() { }

    public SignedAgreement(SignedAgreement signedAgreement)
        : base(signedAgreement) { }

    public SignedAgreement(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    SignedAgreement(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="SignedAgreementFromRaw.FromRawUnchecked"/>
    public static SignedAgreement FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public SignedAgreement(bool enable)
        : this()
    {
        this.Enable = enable;
    }
}

class SignedAgreementFromRaw : IFromRawJson<SignedAgreement>
{
    /// <inheritdoc/>
    public SignedAgreement FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        SignedAgreement.FromRawUnchecked(rawData);
}
