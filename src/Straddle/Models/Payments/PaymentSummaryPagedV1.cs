using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Payments;

[JsonConverter(typeof(JsonModelConverter<PaymentSummaryPagedV1, PaymentSummaryPagedV1FromRaw>))]
public sealed record class PaymentSummaryPagedV1 : JsonModel
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

    public required Meta Meta
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<Meta>("meta");
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

    public PaymentSummaryPagedV1() { }

    public PaymentSummaryPagedV1(PaymentSummaryPagedV1 paymentSummaryPagedV1)
        : base(paymentSummaryPagedV1) { }

    public PaymentSummaryPagedV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaymentSummaryPagedV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaymentSummaryPagedV1FromRaw.FromRawUnchecked"/>
    public static PaymentSummaryPagedV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaymentSummaryPagedV1FromRaw : IFromRawJson<PaymentSummaryPagedV1>
{
    /// <inheritdoc/>
    public PaymentSummaryPagedV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PaymentSummaryPagedV1.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    /// <summary>
    /// Unique identifier for the `charge` or `payout`.
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
    /// The amount of the `charge` or `payout` in cents.
    /// </summary>
    public required int Amount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("amount");
        }
        init { this._rawData.Set("amount", value); }
    }

    /// <summary>
    /// The time the `charge` or `payout` was created.
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
    /// The currency of the `charge` or `payout`. Only USD is supported.
    /// </summary>
    public required string Currency
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("currency");
        }
        init { this._rawData.Set("currency", value); }
    }

    /// <summary>
    /// An arbitrary description for the `charge` or `payout`.
    /// </summary>
    public required string? Description
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("description");
        }
        init { this._rawData.Set("description", value); }
    }

    /// <summary>
    /// Unique identifier for the `charge` or `payout` in your database. This value
    /// must be unique across all charges or payouts.
    /// </summary>
    public required string ExternalID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("external_id");
        }
        init { this._rawData.Set("external_id", value); }
    }

    /// <summary>
    /// Funding ids.
    /// </summary>
    public required IReadOnlyList<string> FundingIds
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<ImmutableArray<string>>("funding_ids");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>>(
                "funding_ids",
                ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Value of the `paykey` used for the `charge` or `payout`.
    /// </summary>
    public required string Paykey
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("paykey");
        }
        init { this._rawData.Set("paykey", value); }
    }

    /// <summary>
    /// The desired date on which the payment should be occur. For charges, this means
    /// the date you want the customer to be debited on. For payouts, this means
    /// the date you want the funds to be sent from your bank account.
    /// </summary>
    public required string PaymentDate
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("payment_date");
        }
        init { this._rawData.Set("payment_date", value); }
    }

    /// <summary>
    /// The type of payment. Valid values are `charge` or `payout`.
    /// </summary>
    public required ApiEnum<string, DataPaymentType> PaymentType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, DataPaymentType>>("payment_type");
        }
        init { this._rawData.Set("payment_type", value); }
    }

    /// <summary>
    /// The current status of the `charge` or `payout`.
    /// </summary>
    public required ApiEnum<string, Status> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Status>>("status");
        }
        init { this._rawData.Set("status", value); }
    }

    /// <summary>
    /// Details about the current status of the `charge` or `payout`.
    /// </summary>
    public required StatusDetailsV1 StatusDetails
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<StatusDetailsV1>("status_details");
        }
        init { this._rawData.Set("status_details", value); }
    }

    /// <summary>
    /// Trace ids.
    /// </summary>
    public required IReadOnlyDictionary<string, string> TraceIds
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<FrozenDictionary<string, string>>("trace_ids");
        }
        init
        {
            this._rawData.Set<FrozenDictionary<string, string>>(
                "trace_ids",
                FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    /// <summary>
    /// The time the `charge` or `payout` was last updated.
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
    /// Information about the customer associated with the charge or payout.
    /// </summary>
    public CustomerDetailsV1? CustomerDetails
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<CustomerDetailsV1>("customer_details");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("customer_details", value);
        }
    }

    /// <summary>
    /// The actual date on which the payment occurred. For charges, this is the date
    /// the customer was debited. For payouts, this is the date the funds were sent
    /// from your bank account.
    /// </summary>
    public DateTimeOffset? EffectiveAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<DateTimeOffset>("effective_at");
        }
        init { this._rawData.Set("effective_at", value); }
    }

    /// <summary>
    /// Unique identifier for the funding event associated with the `charge` or `payout`.
    /// </summary>
    public string? FundingID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("funding_id");
        }
        init { this._rawData.Set("funding_id", value); }
    }

    /// <summary>
    /// Information about the paykey used for the `charge` or `payout`.
    /// </summary>
    public PaykeyDetailsV1? PaykeyDetails
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<PaykeyDetailsV1>("paykey_details");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("paykey_details", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Amount;
        _ = this.CreatedAt;
        _ = this.Currency;
        _ = this.Description;
        _ = this.ExternalID;
        _ = this.FundingIds;
        _ = this.Paykey;
        _ = this.PaymentDate;
        this.PaymentType.Validate();
        this.Status.Validate();
        this.StatusDetails.Validate();
        _ = this.TraceIds;
        _ = this.UpdatedAt;
        this.CustomerDetails?.Validate();
        _ = this.EffectiveAt;
        _ = this.FundingID;
        this.PaykeyDetails?.Validate();
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
/// The type of payment. Valid values are `charge` or `payout`.
/// </summary>
[JsonConverter(typeof(DataPaymentTypeConverter))]
public enum DataPaymentType
{
    Charge,
    Payout,
    Charge1,
    Payout1,
}

sealed class DataPaymentTypeConverter : JsonConverter<DataPaymentType>
{
    public override DataPaymentType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "charge" => DataPaymentType.Charge,
            "payout" => DataPaymentType.Payout,
            "Charge" => DataPaymentType.Charge1,
            "Payout" => DataPaymentType.Payout1,
            _ => (DataPaymentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        DataPaymentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                DataPaymentType.Charge => "charge",
                DataPaymentType.Payout => "payout",
                DataPaymentType.Charge1 => "Charge",
                DataPaymentType.Payout1 => "Payout",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// The current status of the `charge` or `payout`.
/// </summary>
[JsonConverter(typeof(StatusConverter))]
public enum Status
{
    Created,
    Scheduled,
    Failed,
    Cancelled,
    OnHold,
    Pending,
    Paid,
    Reversed,
    Created1,
    Scheduled1,
    Failed1,
    Cancelled1,
    OnHold1,
    Pending1,
    Paid1,
    Reversed1,
}

sealed class StatusConverter : JsonConverter<Status>
{
    public override Status Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created" => Status.Created,
            "scheduled" => Status.Scheduled,
            "failed" => Status.Failed,
            "cancelled" => Status.Cancelled,
            "on_hold" => Status.OnHold,
            "pending" => Status.Pending,
            "paid" => Status.Paid,
            "reversed" => Status.Reversed,
            "Created" => Status.Created1,
            "Scheduled" => Status.Scheduled1,
            "Failed" => Status.Failed1,
            "Cancelled" => Status.Cancelled1,
            "OnHold" => Status.OnHold1,
            "Pending" => Status.Pending1,
            "Paid" => Status.Paid1,
            "Reversed" => Status.Reversed1,
            _ => (Status)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Status value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Status.Created => "created",
                Status.Scheduled => "scheduled",
                Status.Failed => "failed",
                Status.Cancelled => "cancelled",
                Status.OnHold => "on_hold",
                Status.Pending => "pending",
                Status.Paid => "paid",
                Status.Reversed => "reversed",
                Status.Created1 => "Created",
                Status.Scheduled1 => "Scheduled",
                Status.Failed1 => "Failed",
                Status.Cancelled1 => "Cancelled",
                Status.OnHold1 => "OnHold",
                Status.Pending1 => "Pending",
                Status.Paid1 => "Paid",
                Status.Reversed1 => "Reversed",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<Meta, MetaFromRaw>))]
public sealed record class Meta : JsonModel
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

    public required ApiEnum<string, MetaSortOrder> SortOrder
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, MetaSortOrder>>("sort_order");
        }
        init { this._rawData.Set("sort_order", value); }
    }

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

    public Meta() { }

    public Meta(Meta meta)
        : base(meta) { }

    public Meta(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Meta(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="MetaFromRaw.FromRawUnchecked"/>
    public static Meta FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class MetaFromRaw : IFromRawJson<Meta>
{
    /// <inheritdoc/>
    public Meta FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Meta.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(MetaSortOrderConverter))]
public enum MetaSortOrder
{
    Asc,
    Desc,
    Asc1,
    Desc1,
}

sealed class MetaSortOrderConverter : JsonConverter<MetaSortOrder>
{
    public override MetaSortOrder Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "asc" => MetaSortOrder.Asc,
            "desc" => MetaSortOrder.Desc,
            "Asc" => MetaSortOrder.Asc1,
            "Desc" => MetaSortOrder.Desc1,
            _ => (MetaSortOrder)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        MetaSortOrder value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                MetaSortOrder.Asc => "asc",
                MetaSortOrder.Desc => "desc",
                MetaSortOrder.Asc1 => "Asc",
                MetaSortOrder.Desc1 => "Desc",
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
    Object1,
    Array1,
    Error1,
    None1,
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
            "Object" => ResponseType.Object1,
            "Array" => ResponseType.Array1,
            "Error" => ResponseType.Error1,
            "None" => ResponseType.None1,
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
                ResponseType.Object1 => "Object",
                ResponseType.Array1 => "Array",
                ResponseType.Error1 => "Error",
                ResponseType.None1 => "None",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
