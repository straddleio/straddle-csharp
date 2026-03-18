using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;
using System = System;

namespace Straddle.Models.Embed.Accounts.CapabilityRequests;

[JsonConverter(
    typeof(JsonModelConverter<CapabilityRequestPagedV1, CapabilityRequestPagedV1FromRaw>)
)]
public sealed record class CapabilityRequestPagedV1 : JsonModel
{
    public required IReadOnlyList<Data> Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<ImmutableArray<Data>>("data");
        }
        init
        {
            this._rawData.Set<ImmutableArray<Data>>("data", ImmutableArray.ToImmutableArray(value));
        }
    }

    /// <summary>
    /// Metadata about the API request, including an identifier, timestamp, and pagination details.
    /// </summary>
    public required PagedResponseMetadata Meta
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<PagedResponseMetadata>("meta");
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
        foreach (var item in this.Data)
        {
            item.Validate();
        }
        this.Meta.Validate();
        this.ResponseType.Validate();
    }

    public CapabilityRequestPagedV1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CapabilityRequestPagedV1(CapabilityRequestPagedV1 capabilityRequestPagedV1)
        : base(capabilityRequestPagedV1) { }
#pragma warning restore CS8618

    public CapabilityRequestPagedV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CapabilityRequestPagedV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CapabilityRequestPagedV1FromRaw.FromRawUnchecked"/>
    public static CapabilityRequestPagedV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CapabilityRequestPagedV1FromRaw : IFromRawJson<CapabilityRequestPagedV1>
{
    /// <inheritdoc/>
    public CapabilityRequestPagedV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CapabilityRequestPagedV1.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    /// <summary>
    /// Unique identifier for the capability request.
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
    /// The unique identifier of the account associated with this capability request.
    /// </summary>
    public required string AccountID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("account_id");
        }
        init { this._rawData.Set("account_id", value); }
    }

    /// <summary>
    /// The category of the requested capability. Use `payment_type` for charges
    /// and payouts, `customer_type` to define `individuals` or `businesses`, and
    /// `consent_type` for `signed_agreement` or `internet` payment authorization.
    /// </summary>
    public required ApiEnum<string, DataCategory> Category
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, DataCategory>>("category");
        }
        init { this._rawData.Set("category", value); }
    }

    /// <summary>
    /// Timestamp of when the capability request was created.
    /// </summary>
    public required System::DateTimeOffset CreatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<System::DateTimeOffset>("created_at");
        }
        init { this._rawData.Set("created_at", value); }
    }

    /// <summary>
    /// The current status of the capability request.
    /// </summary>
    public required ApiEnum<string, DataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, DataStatus>>("status");
        }
        init { this._rawData.Set("status", value); }
    }

    /// <summary>
    /// The specific type of capability being requested within the category.
    /// </summary>
    public required ApiEnum<string, DataType> Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, DataType>>("type");
        }
        init { this._rawData.Set("type", value); }
    }

    /// <summary>
    /// Timestamp of the most recent update to the capability request.
    /// </summary>
    public required System::DateTimeOffset UpdatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<System::DateTimeOffset>("updated_at");
        }
        init { this._rawData.Set("updated_at", value); }
    }

    /// <summary>
    /// Any specific settings or configurations related to the requested capability.
    /// </summary>
    public IReadOnlyDictionary<string, JsonElement>? Settings
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, JsonElement>>(
                "settings"
            );
        }
        init
        {
            this._rawData.Set<FrozenDictionary<string, JsonElement>?>(
                "settings",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.AccountID;
        this.Category.Validate();
        _ = this.CreatedAt;
        this.Status.Validate();
        this.Type.Validate();
        _ = this.UpdatedAt;
        _ = this.Settings;
    }

    public Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Data(Data data)
        : base(data) { }
#pragma warning restore CS8618

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
/// The category of the requested capability. Use `payment_type` for charges and payouts,
/// `customer_type` to define `individuals` or `businesses`, and `consent_type` for
/// `signed_agreement` or `internet` payment authorization.
/// </summary>
[JsonConverter(typeof(DataCategoryConverter))]
public enum DataCategory
{
    PaymentType,
    CustomerType,
    ConsentType,
}

sealed class DataCategoryConverter : JsonConverter<DataCategory>
{
    public override DataCategory Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "payment_type" => DataCategory.PaymentType,
            "customer_type" => DataCategory.CustomerType,
            "consent_type" => DataCategory.ConsentType,
            _ => (DataCategory)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        DataCategory value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                DataCategory.PaymentType => "payment_type",
                DataCategory.CustomerType => "customer_type",
                DataCategory.ConsentType => "consent_type",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// The current status of the capability request.
/// </summary>
[JsonConverter(typeof(DataStatusConverter))]
public enum DataStatus
{
    Active,
    Inactive,
    InReview,
    Rejected,
    Approved,
    Reviewing,
}

sealed class DataStatusConverter : JsonConverter<DataStatus>
{
    public override DataStatus Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "active" => DataStatus.Active,
            "inactive" => DataStatus.Inactive,
            "in_review" => DataStatus.InReview,
            "rejected" => DataStatus.Rejected,
            "approved" => DataStatus.Approved,
            "reviewing" => DataStatus.Reviewing,
            _ => (DataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        DataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                DataStatus.Active => "active",
                DataStatus.Inactive => "inactive",
                DataStatus.InReview => "in_review",
                DataStatus.Rejected => "rejected",
                DataStatus.Approved => "approved",
                DataStatus.Reviewing => "reviewing",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// The specific type of capability being requested within the category.
/// </summary>
[JsonConverter(typeof(DataTypeConverter))]
public enum DataType
{
    Charges,
    Payouts,
    Individuals,
    Businesses,
    SignedAgreement,
    Internet,
}

sealed class DataTypeConverter : JsonConverter<DataType>
{
    public override DataType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "charges" => DataType.Charges,
            "payouts" => DataType.Payouts,
            "individuals" => DataType.Individuals,
            "businesses" => DataType.Businesses,
            "signed_agreement" => DataType.SignedAgreement,
            "internet" => DataType.Internet,
            _ => (DataType)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, DataType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                DataType.Charges => "charges",
                DataType.Payouts => "payouts",
                DataType.Individuals => "individuals",
                DataType.Businesses => "businesses",
                DataType.SignedAgreement => "signed_agreement",
                DataType.Internet => "internet",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
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
        System::Type typeToConvert,
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
