using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models;

/// <summary>
/// Metadata about the API request, including an identifier, timestamp, and pagination details.
/// </summary>
[JsonConverter(typeof(JsonModelConverter<PagedResponseMetadata, PagedResponseMetadataFromRaw>))]
public sealed record class PagedResponseMetadata : JsonModel
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

    /// <summary>
    /// Maximum allowed page size for this endpoint.
    /// </summary>
    public required int MaxPageSize
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("max_page_size");
        }
        init { this._rawData.Set("max_page_size", value); }
    }

    /// <summary>
    /// Page number for paginated results.
    /// </summary>
    public required int PageNumber
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("page_number");
        }
        init { this._rawData.Set("page_number", value); }
    }

    /// <summary>
    /// Number of items per page in this response.
    /// </summary>
    public required int PageSize
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("page_size");
        }
        init { this._rawData.Set("page_size", value); }
    }

    /// <summary>
    /// The field that the results were sorted by.
    /// </summary>
    public required string SortBy
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("sort_by");
        }
        init { this._rawData.Set("sort_by", value); }
    }

    public required ApiEnum<string, SortOrder> SortOrder
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, SortOrder>>("sort_order");
        }
        init { this._rawData.Set("sort_order", value); }
    }

    /// <summary>
    /// Total number of items returned in this response.
    /// </summary>
    public required int TotalItems
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("total_items");
        }
        init { this._rawData.Set("total_items", value); }
    }

    /// <summary>
    /// The number of pages available.
    /// </summary>
    public required int TotalPages
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("total_pages");
        }
        init { this._rawData.Set("total_pages", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ApiRequestID;
        _ = this.ApiRequestTimestamp;
        _ = this.MaxPageSize;
        _ = this.PageNumber;
        _ = this.PageSize;
        _ = this.SortBy;
        this.SortOrder.Validate();
        _ = this.TotalItems;
        _ = this.TotalPages;
    }

    public PagedResponseMetadata() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public PagedResponseMetadata(PagedResponseMetadata pagedResponseMetadata)
        : base(pagedResponseMetadata) { }
#pragma warning restore CS8618

    public PagedResponseMetadata(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PagedResponseMetadata(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PagedResponseMetadataFromRaw.FromRawUnchecked"/>
    public static PagedResponseMetadata FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PagedResponseMetadataFromRaw : IFromRawJson<PagedResponseMetadata>
{
    /// <inheritdoc/>
    public PagedResponseMetadata FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PagedResponseMetadata.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(SortOrderConverter))]
public enum SortOrder
{
    Asc,
    Desc,
}

sealed class SortOrderConverter : JsonConverter<SortOrder>
{
    public override SortOrder Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "asc" => SortOrder.Asc,
            "desc" => SortOrder.Desc,
            _ => (SortOrder)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        SortOrder value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                SortOrder.Asc => "asc",
                SortOrder.Desc => "desc",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
