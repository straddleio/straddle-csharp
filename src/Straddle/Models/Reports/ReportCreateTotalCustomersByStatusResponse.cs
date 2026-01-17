using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Reports;

[JsonConverter(
    typeof(JsonModelConverter<
        ReportCreateTotalCustomersByStatusResponse,
        ReportCreateTotalCustomersByStatusResponseFromRaw
    >)
)]
public sealed record class ReportCreateTotalCustomersByStatusResponse : JsonModel
{
    public required Data Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<Data>("data");
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
    public required ApiEnum<string, ResponseType> ResponseType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, ResponseType>>("response_type");
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

    public ReportCreateTotalCustomersByStatusResponse() { }

    public ReportCreateTotalCustomersByStatusResponse(
        ReportCreateTotalCustomersByStatusResponse reportCreateTotalCustomersByStatusResponse
    )
        : base(reportCreateTotalCustomersByStatusResponse) { }

    public ReportCreateTotalCustomersByStatusResponse(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ReportCreateTotalCustomersByStatusResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ReportCreateTotalCustomersByStatusResponseFromRaw.FromRawUnchecked"/>
    public static ReportCreateTotalCustomersByStatusResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ReportCreateTotalCustomersByStatusResponseFromRaw
    : IFromRawJson<ReportCreateTotalCustomersByStatusResponse>
{
    /// <inheritdoc/>
    public ReportCreateTotalCustomersByStatusResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ReportCreateTotalCustomersByStatusResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    public required int Inactive
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("inactive");
        }
        init { this._rawData.Set("inactive", value); }
    }

    public required int Pending
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("pending");
        }
        init { this._rawData.Set("pending", value); }
    }

    public required int Rejected
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("rejected");
        }
        init { this._rawData.Set("rejected", value); }
    }

    public required int Review
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("review");
        }
        init { this._rawData.Set("review", value); }
    }

    public required int Verified
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("verified");
        }
        init { this._rawData.Set("verified", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Inactive;
        _ = this.Pending;
        _ = this.Rejected;
        _ = this.Review;
        _ = this.Verified;
    }

    public Data() { }

    public Data(Data data)
        : base(data) { }

    public Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataFromRaw.FromRawUnchecked"/>
    public static Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataFromRaw : IFromRawJson<Data>
{
    /// <inheritdoc/>
    public Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Data.FromRawUnchecked(rawData);
}

/// <summary>
/// Indicates the structure of the returned content. - "object" means the `data`
/// field contains a single JSON object. - "array" means the `data` field contains
/// an array of objects. - "error" means the `data` field contains an error object
/// with details of the issue. - "none" means no data is returned.
/// </summary>
[JsonConverter(typeof(ResponseTypeConverter))]
public enum ResponseType
{
    Object,
    Array,
    Error,
    None,
}

sealed class ResponseTypeConverter : JsonConverter<ResponseType>
{
    public override ResponseType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "object" => ResponseType.Object,
            "array" => ResponseType.Array,
            "error" => ResponseType.Error,
            "none" => ResponseType.None,
            _ => (ResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ResponseType.Object => "object",
                ResponseType.Array => "array",
                ResponseType.Error => "error",
                ResponseType.None => "none",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
