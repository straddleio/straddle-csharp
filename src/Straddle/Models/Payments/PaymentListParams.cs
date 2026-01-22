using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Payments;

/// <summary>
/// Search for payments, including `charges` and `payouts`, using a variety of criteria.
/// This endpoint supports advanced sorting and filtering options.
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public record class PaymentListParams : ParamsBase
{
    /// <summary>
    /// Search using the `customer_id` of a `charge` or `payout`.
    /// </summary>
    public string? CustomerID
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("customer_id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("customer_id", value);
        }
    }

    public int? DefaultPageSize
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<int>("default_page_size");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("default_page_size", value);
        }
    }

    /// <summary>
    /// The field to sort the results by.
    /// </summary>
    public ApiEnum<string, DefaultSort>? DefaultSort
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<ApiEnum<string, DefaultSort>>(
                "default_sort"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("default_sort", value);
        }
    }

    public ApiEnum<string, DefaultSortOrder>? DefaultSortOrder
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<ApiEnum<string, DefaultSortOrder>>(
                "default_sort_order"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("default_sort_order", value);
        }
    }

    /// <summary>
    /// Search using the `external_id` of a `charge` or `payout`.
    /// </summary>
    public string? ExternalID
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("external_id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("external_id", value);
        }
    }

    /// <summary>
    /// Search using the `funding_id` of a `charge` or `payout`.
    /// </summary>
    public string? FundingID
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("funding_id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("funding_id", value);
        }
    }

    /// <summary>
    /// Search using a maximum `amount` of a `charge` or `payout`.
    /// </summary>
    public int? MaxAmount
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<int>("max_amount");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("max_amount", value);
        }
    }

    /// <summary>
    /// Search using the latest `created_at` date of a `charge` or `payout`.
    /// </summary>
    public DateTimeOffset? MaxCreatedAt
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<DateTimeOffset>("max_created_at");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("max_created_at", value);
        }
    }

    /// <summary>
    /// Search using the latest `effective_date` of a `charge` or `payout`.
    /// </summary>
    public DateTimeOffset? MaxEffectiveAt
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<DateTimeOffset>("max_effective_at");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("max_effective_at", value);
        }
    }

    /// <summary>
    /// Search using the latest `payment_date` of a `charge` or `payout`.
    /// </summary>
    public string? MaxPaymentDate
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("max_payment_date");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("max_payment_date", value);
        }
    }

    /// <summary>
    /// Search using the minimum `amount of a `charge` or `payout`.
    /// </summary>
    public int? MinAmount
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<int>("min_amount");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("min_amount", value);
        }
    }

    /// <summary>
    /// Search using the earliest `created_at` date of a `charge` or `payout`.
    /// </summary>
    public DateTimeOffset? MinCreatedAt
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<DateTimeOffset>("min_created_at");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("min_created_at", value);
        }
    }

    /// <summary>
    /// Search using the earliest `effective_date` of a `charge` or `payout`.
    /// </summary>
    public DateTimeOffset? MinEffectiveAt
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<DateTimeOffset>("min_effective_at");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("min_effective_at", value);
        }
    }

    /// <summary>
    /// Search using the earliest ` `of a `charge` or `payout`.
    /// </summary>
    public string? MinPaymentDate
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("min_payment_date");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("min_payment_date", value);
        }
    }

    /// <summary>
    /// Results page number. Starts at page 1.
    /// </summary>
    public int? PageNumber
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<int>("page_number");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("page_number", value);
        }
    }

    /// <summary>
    /// Results page size. Max value: 1000
    /// </summary>
    public int? PageSize
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<int>("page_size");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("page_size", value);
        }
    }

    /// <summary>
    /// Search using the `paykey` of a `charge` or `payout`.
    /// </summary>
    public string? Paykey
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("paykey");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("paykey", value);
        }
    }

    /// <summary>
    /// Search using the `paykey_id` of a `charge` or `payout`.
    /// </summary>
    public string? PaykeyID
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("paykey_id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("paykey_id", value);
        }
    }

    /// <summary>
    /// Search using the `id` of a `charge` or `payout`.
    /// </summary>
    public string? PaymentID
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("payment_id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("payment_id", value);
        }
    }

    /// <summary>
    /// Search by the status of a `charge` or `payout`.
    /// </summary>
    public IReadOnlyList<ApiEnum<string, PaymentStatus>>? PaymentStatus
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<
                ImmutableArray<ApiEnum<string, PaymentStatus>>
            >("payment_status");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set<ImmutableArray<ApiEnum<string, PaymentStatus>>?>(
                "payment_status",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Search by the type of a `charge` or `payout`.
    /// </summary>
    public IReadOnlyList<ApiEnum<string, PaymentType>>? PaymentType
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<
                ImmutableArray<ApiEnum<string, PaymentType>>
            >("payment_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set<ImmutableArray<ApiEnum<string, PaymentType>>?>(
                "payment_type",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Search using a text string associated with a `charge` or `payout`.
    /// </summary>
    public string? SearchText
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("search_text");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("search_text", value);
        }
    }

    /// <summary>
    /// The field to sort the results by.
    /// </summary>
    public ApiEnum<string, SortBy>? SortBy
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<ApiEnum<string, SortBy>>("sort_by");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("sort_by", value);
        }
    }

    public ApiEnum<string, SortOrder>? SortOrder
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<ApiEnum<string, SortOrder>>("sort_order");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("sort_order", value);
        }
    }

    /// <summary>
    /// Reason for latest payment status change.
    /// </summary>
    public IReadOnlyList<ApiEnum<string, StatusReason>>? StatusReason
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<
                ImmutableArray<ApiEnum<string, StatusReason>>
            >("status_reason");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set<ImmutableArray<ApiEnum<string, StatusReason>>?>(
                "status_reason",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Source of latest payment status change.
    /// </summary>
    public IReadOnlyList<ApiEnum<string, StatusSource>>? StatusSource
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<
                ImmutableArray<ApiEnum<string, StatusSource>>
            >("status_source");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set<ImmutableArray<ApiEnum<string, StatusSource>>?>(
                "status_source",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
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

    public PaymentListParams() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public PaymentListParams(PaymentListParams paymentListParams)
        : base(paymentListParams) { }
#pragma warning restore CS8618

    public PaymentListParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaymentListParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
    public static PaymentListParams FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        return new(
            FrozenDictionary.ToFrozenDictionary(rawHeaderData),
            FrozenDictionary.ToFrozenDictionary(rawQueryData)
        );
    }

    public override string ToString() =>
        JsonSerializer.Serialize(
            new Dictionary<string, object?>()
            {
                ["HeaderData"] = this._rawHeaderData.Freeze(),
                ["QueryData"] = this._rawQueryData.Freeze(),
            },
            ModelBase.ToStringSerializerOptions
        );

    public virtual bool Equals(PaymentListParams? other)
    {
        if (other == null)
        {
            return false;
        }
        return this._rawHeaderData.Equals(other._rawHeaderData)
            && this._rawQueryData.Equals(other._rawQueryData);
    }

    public override Uri Url(ClientOptions options)
    {
        return new UriBuilder(options.BaseUrl.ToString().TrimEnd('/') + "/v1/payments")
        {
            Query = this.QueryString(options),
        }.Uri;
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
/// The field to sort the results by.
/// </summary>
[JsonConverter(typeof(DefaultSortConverter))]
public enum DefaultSort
{
    CreatedAt,
    PaymentDate,
    EffectiveAt,
    ID,
    Amount,
}

sealed class DefaultSortConverter : JsonConverter<DefaultSort>
{
    public override DefaultSort Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created_at" => DefaultSort.CreatedAt,
            "payment_date" => DefaultSort.PaymentDate,
            "effective_at" => DefaultSort.EffectiveAt,
            "id" => DefaultSort.ID,
            "amount" => DefaultSort.Amount,
            _ => (DefaultSort)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        DefaultSort value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                DefaultSort.CreatedAt => "created_at",
                DefaultSort.PaymentDate => "payment_date",
                DefaultSort.EffectiveAt => "effective_at",
                DefaultSort.ID => "id",
                DefaultSort.Amount => "amount",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(DefaultSortOrderConverter))]
public enum DefaultSortOrder
{
    Asc,
    Desc,
}

sealed class DefaultSortOrderConverter : JsonConverter<DefaultSortOrder>
{
    public override DefaultSortOrder Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "asc" => DefaultSortOrder.Asc,
            "desc" => DefaultSortOrder.Desc,
            _ => (DefaultSortOrder)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        DefaultSortOrder value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                DefaultSortOrder.Asc => "asc",
                DefaultSortOrder.Desc => "desc",
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
[JsonConverter(typeof(PaymentStatusConverter))]
public enum PaymentStatus
{
    Created,
    Scheduled,
    Failed,
    Cancelled,
    OnHold,
    Pending,
    Paid,
    Reversed,
}

sealed class PaymentStatusConverter : JsonConverter<PaymentStatus>
{
    public override PaymentStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created" => PaymentStatus.Created,
            "scheduled" => PaymentStatus.Scheduled,
            "failed" => PaymentStatus.Failed,
            "cancelled" => PaymentStatus.Cancelled,
            "on_hold" => PaymentStatus.OnHold,
            "pending" => PaymentStatus.Pending,
            "paid" => PaymentStatus.Paid,
            "reversed" => PaymentStatus.Reversed,
            _ => (PaymentStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaymentStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaymentStatus.Created => "created",
                PaymentStatus.Scheduled => "scheduled",
                PaymentStatus.Failed => "failed",
                PaymentStatus.Cancelled => "cancelled",
                PaymentStatus.OnHold => "on_hold",
                PaymentStatus.Pending => "pending",
                PaymentStatus.Paid => "paid",
                PaymentStatus.Reversed => "reversed",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// The type of payment.
/// </summary>
[JsonConverter(typeof(PaymentTypeConverter))]
public enum PaymentType
{
    Charge,
    Payout,
}

sealed class PaymentTypeConverter : JsonConverter<PaymentType>
{
    public override PaymentType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "charge" => PaymentType.Charge,
            "payout" => PaymentType.Payout,
            _ => (PaymentType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaymentType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaymentType.Charge => "charge",
                PaymentType.Payout => "payout",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// The field to sort the results by.
/// </summary>
[JsonConverter(typeof(SortByConverter))]
public enum SortBy
{
    CreatedAt,
    PaymentDate,
    EffectiveAt,
    ID,
    Amount,
}

sealed class SortByConverter : JsonConverter<SortBy>
{
    public override SortBy Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created_at" => SortBy.CreatedAt,
            "payment_date" => SortBy.PaymentDate,
            "effective_at" => SortBy.EffectiveAt,
            "id" => SortBy.ID,
            "amount" => SortBy.Amount,
            _ => (SortBy)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, SortBy value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                SortBy.CreatedAt => "created_at",
                SortBy.PaymentDate => "payment_date",
                SortBy.EffectiveAt => "effective_at",
                SortBy.ID => "id",
                SortBy.Amount => "amount",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
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

[JsonConverter(typeof(StatusReasonConverter))]
public enum StatusReason
{
    InsufficientFunds,
    ClosedBankAccount,
    InvalidBankAccount,
    InvalidRouting,
    Disputed,
    PaymentStopped,
    OwnerDeceased,
    FrozenBankAccount,
    RiskReview,
    Fraudulent,
    DuplicateEntry,
    InvalidPaykey,
    PaymentBlocked,
    AmountTooLarge,
    TooManyAttempts,
    InternalSystemError,
    UserRequest,
    Ok,
    OtherNetworkReturn,
    PayoutRefused,
    CancelRequest,
    FailedVerification,
    RequireReview,
    BlockedBySystem,
    WatchtowerReview,
}

sealed class StatusReasonConverter : JsonConverter<StatusReason>
{
    public override StatusReason Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "insufficient_funds" => StatusReason.InsufficientFunds,
            "closed_bank_account" => StatusReason.ClosedBankAccount,
            "invalid_bank_account" => StatusReason.InvalidBankAccount,
            "invalid_routing" => StatusReason.InvalidRouting,
            "disputed" => StatusReason.Disputed,
            "payment_stopped" => StatusReason.PaymentStopped,
            "owner_deceased" => StatusReason.OwnerDeceased,
            "frozen_bank_account" => StatusReason.FrozenBankAccount,
            "risk_review" => StatusReason.RiskReview,
            "fraudulent" => StatusReason.Fraudulent,
            "duplicate_entry" => StatusReason.DuplicateEntry,
            "invalid_paykey" => StatusReason.InvalidPaykey,
            "payment_blocked" => StatusReason.PaymentBlocked,
            "amount_too_large" => StatusReason.AmountTooLarge,
            "too_many_attempts" => StatusReason.TooManyAttempts,
            "internal_system_error" => StatusReason.InternalSystemError,
            "user_request" => StatusReason.UserRequest,
            "ok" => StatusReason.Ok,
            "other_network_return" => StatusReason.OtherNetworkReturn,
            "payout_refused" => StatusReason.PayoutRefused,
            "cancel_request" => StatusReason.CancelRequest,
            "failed_verification" => StatusReason.FailedVerification,
            "require_review" => StatusReason.RequireReview,
            "blocked_by_system" => StatusReason.BlockedBySystem,
            "watchtower_review" => StatusReason.WatchtowerReview,
            _ => (StatusReason)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        StatusReason value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                StatusReason.InsufficientFunds => "insufficient_funds",
                StatusReason.ClosedBankAccount => "closed_bank_account",
                StatusReason.InvalidBankAccount => "invalid_bank_account",
                StatusReason.InvalidRouting => "invalid_routing",
                StatusReason.Disputed => "disputed",
                StatusReason.PaymentStopped => "payment_stopped",
                StatusReason.OwnerDeceased => "owner_deceased",
                StatusReason.FrozenBankAccount => "frozen_bank_account",
                StatusReason.RiskReview => "risk_review",
                StatusReason.Fraudulent => "fraudulent",
                StatusReason.DuplicateEntry => "duplicate_entry",
                StatusReason.InvalidPaykey => "invalid_paykey",
                StatusReason.PaymentBlocked => "payment_blocked",
                StatusReason.AmountTooLarge => "amount_too_large",
                StatusReason.TooManyAttempts => "too_many_attempts",
                StatusReason.InternalSystemError => "internal_system_error",
                StatusReason.UserRequest => "user_request",
                StatusReason.Ok => "ok",
                StatusReason.OtherNetworkReturn => "other_network_return",
                StatusReason.PayoutRefused => "payout_refused",
                StatusReason.CancelRequest => "cancel_request",
                StatusReason.FailedVerification => "failed_verification",
                StatusReason.RequireReview => "require_review",
                StatusReason.BlockedBySystem => "blocked_by_system",
                StatusReason.WatchtowerReview => "watchtower_review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(StatusSourceConverter))]
public enum StatusSource
{
    Watchtower,
    BankDecline,
    CustomerDispute,
    UserAction,
    System,
}

sealed class StatusSourceConverter : JsonConverter<StatusSource>
{
    public override StatusSource Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "watchtower" => StatusSource.Watchtower,
            "bank_decline" => StatusSource.BankDecline,
            "customer_dispute" => StatusSource.CustomerDispute,
            "user_action" => StatusSource.UserAction,
            "system" => StatusSource.System,
            _ => (StatusSource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        StatusSource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                StatusSource.Watchtower => "watchtower",
                StatusSource.BankDecline => "bank_decline",
                StatusSource.CustomerDispute => "customer_dispute",
                StatusSource.UserAction => "user_action",
                StatusSource.System => "system",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
