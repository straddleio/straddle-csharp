using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;

namespace Straddle.Models;

/// <summary>
/// Metadata about the API request, including an identifier and timestamp.
/// </summary>
[JsonConverter(typeof(JsonModelConverter<ResponseMetadata, ResponseMetadataFromRaw>))]
public sealed record class ResponseMetadata : JsonModel
{
    /// <summary>
    /// Unique identifier for this API request, useful for troubleshooting.
    /// </summary>
    public required string ApiRequestID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("api_request_id");
        }
        init { this._rawData.Set("api_request_id", value); }
    }

    /// <summary>
    /// Timestamp for this API request, useful for troubleshooting.
    /// </summary>
    public required DateTimeOffset ApiRequestTimestamp
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<DateTimeOffset>("api_request_timestamp");
        }
        init { this._rawData.Set("api_request_timestamp", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ApiRequestID;
        _ = this.ApiRequestTimestamp;
    }

    public ResponseMetadata() { }

    public ResponseMetadata(ResponseMetadata responseMetadata)
        : base(responseMetadata) { }

    public ResponseMetadata(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ResponseMetadata(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ResponseMetadataFromRaw.FromRawUnchecked"/>
    public static ResponseMetadata FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ResponseMetadataFromRaw : IFromRawJson<ResponseMetadata>
{
    /// <inheritdoc/>
    public ResponseMetadata FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ResponseMetadata.FromRawUnchecked(rawData);
}
