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

namespace Straddle.Models.FundingEvents;

/// <summary>
/// Retrieves a list of funding events for your account. This endpoint supports advanced
/// sorting and filtering options.
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public record class FundingEventListParams : ParamsBase
{
    /// <summary>
    /// The start date of the range to filter by using the `YYYY-MM-DD` format.
    /// </summary>
    public string? CreatedFrom
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("created_from");
        }
        init { this._rawQueryData.Set("created_from", value); }
    }

    /// <summary>
    /// The end date of the range to filter by using the `YYYY-MM-DD` format.
    /// </summary>
    public string? CreatedTo
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("created_to");
        }
        init { this._rawQueryData.Set("created_to", value); }
    }

    /// <summary>
    /// Describes the direction of the funding event from the perspective of the `linked_bank_account`.
    /// </summary>
    public ApiEnum<string, Direction>? Direction
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<ApiEnum<string, Direction>>("direction");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("direction", value);
        }
    }

    /// <summary>
    /// The funding event types describes the direction and reason for the funding event.
    /// </summary>
    public ApiEnum<string, EventType>? EventType
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<ApiEnum<string, EventType>>("event_type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("event_type", value);
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
    /// Search text.
    /// </summary>
    public string? SearchText
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("search_text");
        }
        init { this._rawQueryData.Set("search_text", value); }
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

    /// <summary>
    /// The order in which to sort the results.
    /// </summary>
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
    /// Funding Event status.
    /// </summary>
    public IReadOnlyList<ApiEnum<string, Status>>? Status
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<ImmutableArray<ApiEnum<string, Status>>>(
                "status"
            );
        }
        init
        {
            this._rawQueryData.Set<ImmutableArray<ApiEnum<string, Status>>?>(
                "status",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
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
            this._rawQueryData.Set<ImmutableArray<ApiEnum<string, StatusSource>>?>(
                "status_source",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Trace Id.
    /// </summary>
    public string? TraceID
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("trace_id");
        }
        init { this._rawQueryData.Set("trace_id", value); }
    }

    /// <summary>
    /// Trace number.
    /// </summary>
    public string? TraceNumber
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("trace_number");
        }
        init { this._rawQueryData.Set("trace_number", value); }
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

    public FundingEventListParams() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public FundingEventListParams(FundingEventListParams fundingEventListParams)
        : base(fundingEventListParams) { }
#pragma warning restore CS8618

    public FundingEventListParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    FundingEventListParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
    public static FundingEventListParams FromRawUnchecked(
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

    public virtual bool Equals(FundingEventListParams? other)
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
        return new UriBuilder(options.BaseUrl.ToString().TrimEnd('/') + "/v1/funding_events")
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
/// Describes the direction of the funding event from the perspective of the `linked_bank_account`.
/// </summary>
[JsonConverter(typeof(DirectionConverter))]
public enum Direction
{
    Deposit,
    Withdrawal,
}

sealed class DirectionConverter : JsonConverter<Direction>
{
    public override Direction Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "deposit" => Direction.Deposit,
            "withdrawal" => Direction.Withdrawal,
            _ => (Direction)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        Direction value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Direction.Deposit => "deposit",
                Direction.Withdrawal => "withdrawal",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// The funding event types describes the direction and reason for the funding event.
/// </summary>
[JsonConverter(typeof(EventTypeConverter))]
public enum EventType
{
    ChargeDeposit,
    ChargeReversal,
    PayoutReturn,
    PayoutWithdrawal,
}

sealed class EventTypeConverter : JsonConverter<EventType>
{
    public override EventType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "charge_deposit" => EventType.ChargeDeposit,
            "charge_reversal" => EventType.ChargeReversal,
            "payout_return" => EventType.PayoutReturn,
            "payout_withdrawal" => EventType.PayoutWithdrawal,
            _ => (EventType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        EventType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                EventType.ChargeDeposit => "charge_deposit",
                EventType.ChargeReversal => "charge_reversal",
                EventType.PayoutReturn => "payout_return",
                EventType.PayoutWithdrawal => "payout_withdrawal",
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
    TransferDate,
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
            "transfer_date" => SortBy.TransferDate,
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
                SortBy.TransferDate => "transfer_date",
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

/// <summary>
/// The order in which to sort the results.
/// </summary>
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
