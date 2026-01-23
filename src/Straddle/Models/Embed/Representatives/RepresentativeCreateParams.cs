using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;

namespace Straddle.Models.Embed.Representatives;

/// <summary>
/// Creates a new representative associated with an account. Representatives are
/// individuals who have legal authority or significant responsibility within the business.
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public record class RepresentativeCreateParams : ParamsBase
{
    readonly JsonDictionary _rawBodyData = new();
    public IReadOnlyDictionary<string, JsonElement> RawBodyData
    {
        get { return this._rawBodyData.Freeze(); }
    }

    /// <summary>
    /// The unique identifier of the account this representative is associated with.
    /// </summary>
    public required string AccountID
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("account_id");
        }
        init { this._rawBodyData.Set("account_id", value); }
    }

    /// <summary>
    /// Date of birth for the representative in ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    public required string Dob
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("dob");
        }
        init { this._rawBodyData.Set("dob", value); }
    }

    /// <summary>
    /// The company email address of the representative.
    /// </summary>
    public required string Email
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("email");
        }
        init { this._rawBodyData.Set("email", value); }
    }

    /// <summary>
    /// The first name of the representative.
    /// </summary>
    public required string FirstName
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("first_name");
        }
        init { this._rawBodyData.Set("first_name", value); }
    }

    /// <summary>
    /// The last name of the representative.
    /// </summary>
    public required string LastName
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("last_name");
        }
        init { this._rawBodyData.Set("last_name", value); }
    }

    /// <summary>
    /// The mobile phone number of the representative.
    /// </summary>
    public required string MobileNumber
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("mobile_number");
        }
        init { this._rawBodyData.Set("mobile_number", value); }
    }

    public required Relationship Relationship
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<Relationship>("relationship");
        }
        init { this._rawBodyData.Set("relationship", value); }
    }

    /// <summary>
    /// The last 4 digits of the representative's Social Security Number.
    /// </summary>
    public required string SsnLast4
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("ssn_last4");
        }
        init { this._rawBodyData.Set("ssn_last4", value); }
    }

    /// <summary>
    /// Unique identifier for the representative in your database, used for cross-referencing
    /// between Straddle and your systems.
    /// </summary>
    public string? ExternalID
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<string>("external_id");
        }
        init { this._rawBodyData.Set("external_id", value); }
    }

    /// <summary>
    /// Up to 20 additional user-defined key-value pairs. Useful for storing additional
    /// information about the represetative in a structured format.
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

    public RepresentativeCreateParams() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public RepresentativeCreateParams(RepresentativeCreateParams representativeCreateParams)
        : base(representativeCreateParams)
    {
        this._rawBodyData = new(representativeCreateParams._rawBodyData);
    }
#pragma warning restore CS8618

    public RepresentativeCreateParams(
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
    RepresentativeCreateParams(
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
    public static RepresentativeCreateParams FromRawUnchecked(
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

    public virtual bool Equals(RepresentativeCreateParams? other)
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
        return new UriBuilder(options.BaseUrl.ToString().TrimEnd('/') + "/v1/representatives")
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

[JsonConverter(typeof(JsonModelConverter<Relationship, RelationshipFromRaw>))]
public sealed record class Relationship : JsonModel
{
    /// <summary>
    /// Whether the representative has significant responsibility to control, manage,
    /// or direct the organization. One representative must be identified under the
    /// control prong for each legal entity.
    /// </summary>
    public required bool Control
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<bool>("control");
        }
        init { this._rawData.Set("control", value); }
    }

    /// <summary>
    /// Whether the representative owns any percentage of of the equity interests
    /// of the legal entity.
    /// </summary>
    public required bool Owner
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<bool>("owner");
        }
        init { this._rawData.Set("owner", value); }
    }

    /// <summary>
    /// Whether the person is authorized as the primary representative of the account.
    /// This is the person chosen by the business to provide information about themselves,
    /// general information about the account, and who consented to the services
    /// agreement.
    ///
    /// <para> There can be only one primary representative for an account at a time.</para>
    /// </summary>
    public required bool Primary
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<bool>("primary");
        }
        init { this._rawData.Set("primary", value); }
    }

    /// <summary>
    /// The percentage of ownership the representative has. Required if 'Owner' is true.
    /// </summary>
    public double? PercentOwnership
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("percent_ownership");
        }
        init { this._rawData.Set("percent_ownership", value); }
    }

    /// <summary>
    /// The job title of the representative.
    /// </summary>
    public string? Title
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("title");
        }
        init { this._rawData.Set("title", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Control;
        _ = this.Owner;
        _ = this.Primary;
        _ = this.PercentOwnership;
        _ = this.Title;
    }

    public Relationship() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Relationship(Relationship relationship)
        : base(relationship) { }
#pragma warning restore CS8618

    public Relationship(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Relationship(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RelationshipFromRaw.FromRawUnchecked"/>
    public static Relationship FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RelationshipFromRaw : IFromRawJson<Relationship>
{
    /// <inheritdoc/>
    public Relationship FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Relationship.FromRawUnchecked(rawData);
}
