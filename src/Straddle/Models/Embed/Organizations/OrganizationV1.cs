using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Embed.Organizations;

[JsonConverter(typeof(JsonModelConverter<OrganizationV1, OrganizationV1FromRaw>))]
public sealed record class OrganizationV1 : JsonModel
{
    public required OrganizationV1Data Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<OrganizationV1Data>("data");
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
    public required ApiEnum<string, OrganizationV1ResponseType> ResponseType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, OrganizationV1ResponseType>>(
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

    public OrganizationV1() { }

    public OrganizationV1(OrganizationV1 organizationV1)
        : base(organizationV1) { }

    public OrganizationV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    OrganizationV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="OrganizationV1FromRaw.FromRawUnchecked"/>
    public static OrganizationV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class OrganizationV1FromRaw : IFromRawJson<OrganizationV1>
{
    /// <inheritdoc/>
    public OrganizationV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        OrganizationV1.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<OrganizationV1Data, OrganizationV1DataFromRaw>))]
public sealed record class OrganizationV1Data : JsonModel
{
    /// <summary>
    /// Straddle's unique identifier for the organization.
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
    /// Timestamp of when the organization was created.
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
    /// The name of the organization.
    /// </summary>
    public required string Name
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("name");
        }
        init { this._rawData.Set("name", value); }
    }

    /// <summary>
    /// Timestamp of the most recent update to the organization.
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
    /// Unique identifier for the organization in your database, used for cross-referencing
    /// between Straddle and your systems.
    /// </summary>
    public string? ExternalID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("external_id");
        }
        init { this._rawData.Set("external_id", value); }
    }

    /// <summary>
    /// Up to 20 additional user-defined key-value pairs. Useful for storing additional
    /// information about the organization in a structured format.
    /// </summary>
    public IReadOnlyDictionary<string, string?>? Metadata
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string?>>("metadata");
        }
        init
        {
            this._rawData.Set<FrozenDictionary<string, string?>?>(
                "metadata",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.CreatedAt;
        _ = this.Name;
        _ = this.UpdatedAt;
        _ = this.ExternalID;
        _ = this.Metadata;
    }

    public OrganizationV1Data() { }

    public OrganizationV1Data(OrganizationV1Data organizationV1Data)
        : base(organizationV1Data) { }

    public OrganizationV1Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    OrganizationV1Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="OrganizationV1DataFromRaw.FromRawUnchecked"/>
    public static OrganizationV1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class OrganizationV1DataFromRaw : IFromRawJson<OrganizationV1Data>
{
    /// <inheritdoc/>
    public OrganizationV1Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        OrganizationV1Data.FromRawUnchecked(rawData);
}

/// <summary>
/// Indicates the structure of the returned content. - "object" means the `data`
/// field contains a single JSON object. - "array" means the `data` field contains
/// an array of objects. - "error" means the `data` field contains an error object
/// with details of the issue. - "none" means no data is returned.
/// </summary>
[JsonConverter(typeof(OrganizationV1ResponseTypeConverter))]
public enum OrganizationV1ResponseType
{
    Object,
    Array,
    Error,
    None,
}

sealed class OrganizationV1ResponseTypeConverter : JsonConverter<OrganizationV1ResponseType>
{
    public override OrganizationV1ResponseType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "object" => OrganizationV1ResponseType.Object,
            "array" => OrganizationV1ResponseType.Array,
            "error" => OrganizationV1ResponseType.Error,
            "none" => OrganizationV1ResponseType.None,
            _ => (OrganizationV1ResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        OrganizationV1ResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                OrganizationV1ResponseType.Object => "object",
                OrganizationV1ResponseType.Array => "array",
                OrganizationV1ResponseType.Error => "error",
                OrganizationV1ResponseType.None => "none",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
