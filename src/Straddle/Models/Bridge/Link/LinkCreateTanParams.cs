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

namespace Straddle.Models.Bridge.Link;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public record class LinkCreateTanParams : ParamsBase
{
    readonly JsonDictionary _rawBodyData = new();
    public IReadOnlyDictionary<string, JsonElement> RawBodyData
    {
        get { return this._rawBodyData.Freeze(); }
    }

    public required ApiEnum<string, LinkCreateTanParamsAccountType> AccountType
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<
                ApiEnum<string, LinkCreateTanParamsAccountType>
            >("account_type");
        }
        init { this._rawBodyData.Set("account_type", value); }
    }

    /// <summary>
    /// Unique identifier of the related customer object.
    /// </summary>
    public required string CustomerID
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("customer_id");
        }
        init { this._rawBodyData.Set("customer_id", value); }
    }

    /// <summary>
    /// Bank routing number.
    /// </summary>
    public required string RoutingNumber
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("routing_number");
        }
        init { this._rawBodyData.Set("routing_number", value); }
    }

    /// <summary>
    /// Tokenized account number.
    /// </summary>
    public required string Tan
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("tan");
        }
        init { this._rawBodyData.Set("tan", value); }
    }

    public LinkCreateTanParamsConfig? Config
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<LinkCreateTanParamsConfig>("config");
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
    /// Unique identifier for the paykey in your database, used for cross-referencing
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
    /// information about the paykey in a structured format.
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

    public LinkCreateTanParams() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public LinkCreateTanParams(LinkCreateTanParams linkCreateTanParams)
        : base(linkCreateTanParams)
    {
        this._rawBodyData = new(linkCreateTanParams._rawBodyData);
    }
#pragma warning restore CS8618

    public LinkCreateTanParams(
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
    LinkCreateTanParams(
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
    public static LinkCreateTanParams FromRawUnchecked(
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

    public virtual bool Equals(LinkCreateTanParams? other)
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
        return new UriBuilder(options.BaseUrl.ToString().TrimEnd('/') + "/v1/bridge/tan")
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

[JsonConverter(typeof(LinkCreateTanParamsAccountTypeConverter))]
public enum LinkCreateTanParamsAccountType
{
    Checking,
    Savings,
}

sealed class LinkCreateTanParamsAccountTypeConverter : JsonConverter<LinkCreateTanParamsAccountType>
{
    public override LinkCreateTanParamsAccountType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "checking" => LinkCreateTanParamsAccountType.Checking,
            "savings" => LinkCreateTanParamsAccountType.Savings,
            _ => (LinkCreateTanParamsAccountType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkCreateTanParamsAccountType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkCreateTanParamsAccountType.Checking => "checking",
                LinkCreateTanParamsAccountType.Savings => "savings",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(
    typeof(JsonModelConverter<LinkCreateTanParamsConfig, LinkCreateTanParamsConfigFromRaw>)
)]
public sealed record class LinkCreateTanParamsConfig : JsonModel
{
    public ApiEnum<string, LinkCreateTanParamsConfigProcessingMethod>? ProcessingMethod
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, LinkCreateTanParamsConfigProcessingMethod>
            >("processing_method");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("processing_method", value);
        }
    }

    public ApiEnum<string, LinkCreateTanParamsConfigSandboxOutcome>? SandboxOutcome
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, LinkCreateTanParamsConfigSandboxOutcome>
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
        this.ProcessingMethod?.Validate();
        this.SandboxOutcome?.Validate();
    }

    public LinkCreateTanParamsConfig() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public LinkCreateTanParamsConfig(LinkCreateTanParamsConfig linkCreateTanParamsConfig)
        : base(linkCreateTanParamsConfig) { }
#pragma warning restore CS8618

    public LinkCreateTanParamsConfig(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LinkCreateTanParamsConfig(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LinkCreateTanParamsConfigFromRaw.FromRawUnchecked"/>
    public static LinkCreateTanParamsConfig FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LinkCreateTanParamsConfigFromRaw : IFromRawJson<LinkCreateTanParamsConfig>
{
    /// <inheritdoc/>
    public LinkCreateTanParamsConfig FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => LinkCreateTanParamsConfig.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(LinkCreateTanParamsConfigProcessingMethodConverter))]
public enum LinkCreateTanParamsConfigProcessingMethod
{
    Inline,
    Background,
    Skip,
}

sealed class LinkCreateTanParamsConfigProcessingMethodConverter
    : JsonConverter<LinkCreateTanParamsConfigProcessingMethod>
{
    public override LinkCreateTanParamsConfigProcessingMethod Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "inline" => LinkCreateTanParamsConfigProcessingMethod.Inline,
            "background" => LinkCreateTanParamsConfigProcessingMethod.Background,
            "skip" => LinkCreateTanParamsConfigProcessingMethod.Skip,
            _ => (LinkCreateTanParamsConfigProcessingMethod)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkCreateTanParamsConfigProcessingMethod value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkCreateTanParamsConfigProcessingMethod.Inline => "inline",
                LinkCreateTanParamsConfigProcessingMethod.Background => "background",
                LinkCreateTanParamsConfigProcessingMethod.Skip => "skip",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(LinkCreateTanParamsConfigSandboxOutcomeConverter))]
public enum LinkCreateTanParamsConfigSandboxOutcome
{
    Standard,
    Active,
    Rejected,
    Review,
}

sealed class LinkCreateTanParamsConfigSandboxOutcomeConverter
    : JsonConverter<LinkCreateTanParamsConfigSandboxOutcome>
{
    public override LinkCreateTanParamsConfigSandboxOutcome Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "standard" => LinkCreateTanParamsConfigSandboxOutcome.Standard,
            "active" => LinkCreateTanParamsConfigSandboxOutcome.Active,
            "rejected" => LinkCreateTanParamsConfigSandboxOutcome.Rejected,
            "review" => LinkCreateTanParamsConfigSandboxOutcome.Review,
            _ => (LinkCreateTanParamsConfigSandboxOutcome)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkCreateTanParamsConfigSandboxOutcome value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkCreateTanParamsConfigSandboxOutcome.Standard => "standard",
                LinkCreateTanParamsConfigSandboxOutcome.Active => "active",
                LinkCreateTanParamsConfigSandboxOutcome.Rejected => "rejected",
                LinkCreateTanParamsConfigSandboxOutcome.Review => "review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
