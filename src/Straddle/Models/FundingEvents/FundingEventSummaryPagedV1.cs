using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.FundingEvents;

[JsonConverter(
    typeof(JsonModelConverter<FundingEventSummaryPagedV1, FundingEventSummaryPagedV1FromRaw>)
)]
public sealed record class FundingEventSummaryPagedV1 : JsonModel
{
    public required IReadOnlyList<FundingEventSummaryPagedV1Data> Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<ImmutableArray<FundingEventSummaryPagedV1Data>>(
                "data"
            );
        }
        init
        {
            this._rawData.Set<ImmutableArray<FundingEventSummaryPagedV1Data>>(
                "data",
                ImmutableArray.ToImmutableArray(value)
            );
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
    public required ApiEnum<string, FundingEventSummaryPagedV1ResponseType> ResponseType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, FundingEventSummaryPagedV1ResponseType>
            >("response_type");
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

    public FundingEventSummaryPagedV1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public FundingEventSummaryPagedV1(FundingEventSummaryPagedV1 fundingEventSummaryPagedV1)
        : base(fundingEventSummaryPagedV1) { }
#pragma warning restore CS8618

    public FundingEventSummaryPagedV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    FundingEventSummaryPagedV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="FundingEventSummaryPagedV1FromRaw.FromRawUnchecked"/>
    public static FundingEventSummaryPagedV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class FundingEventSummaryPagedV1FromRaw : IFromRawJson<FundingEventSummaryPagedV1>
{
    /// <inheritdoc/>
    public FundingEventSummaryPagedV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => FundingEventSummaryPagedV1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        FundingEventSummaryPagedV1Data,
        FundingEventSummaryPagedV1DataFromRaw
    >)
)]
public sealed record class FundingEventSummaryPagedV1Data : JsonModel
{
    /// <summary>
    /// Unique identifier for the funding event.
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
    /// The amount of the funding event in cents.
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
    /// Created at.
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
    /// Describes the direction of the funding event from the perspective of the `linked_bank_account`.
    /// </summary>
    public required ApiEnum<string, FundingEventSummaryPagedV1DataDirection> Direction
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, FundingEventSummaryPagedV1DataDirection>
            >("direction");
        }
        init { this._rawData.Set("direction", value); }
    }

    /// <summary>
    /// The funding event types describes the direction and reason for the funding event.
    /// </summary>
    public required ApiEnum<string, FundingEventSummaryPagedV1DataEventType> EventType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, FundingEventSummaryPagedV1DataEventType>
            >("event_type");
        }
        init { this._rawData.Set("event_type", value); }
    }

    /// <summary>
    /// The number of payments associated with the funding event.
    /// </summary>
    public required int PaymentCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("payment_count");
        }
        init { this._rawData.Set("payment_count", value); }
    }

    /// <summary>
    /// Trace Ids.
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
    /// Trace number.
    /// </summary>
    public required IReadOnlyList<string> TraceNumbers
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<ImmutableArray<string>>("trace_numbers");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>>(
                "trace_numbers",
                ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// The date on which the funding event occurred. For `deposits` and `returns`,
    /// this is the date the funds were credited to your bank account. For `withdrawals`
    /// and `reversals`, this is the date the funds were debited from your bank account.
    /// </summary>
    public required string TransferDate
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("transfer_date");
        }
        init { this._rawData.Set("transfer_date", value); }
    }

    /// <summary>
    /// Updated at.
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
    /// The current status of the `charge` or `payout`.
    /// </summary>
    public ApiEnum<string, FundingEventSummaryPagedV1DataStatus>? Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, FundingEventSummaryPagedV1DataStatus>
            >("status");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("status", value);
        }
    }

    public FundingEventSummaryPagedV1DataStatusDetails? StatusDetails
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FundingEventSummaryPagedV1DataStatusDetails>(
                "status_details"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("status_details", value);
        }
    }

    /// <summary>
    /// The trace number of the funding event.
    /// </summary>
    public string? TraceNumber
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("trace_number");
        }
        init { this._rawData.Set("trace_number", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Amount;
        _ = this.CreatedAt;
        this.Direction.Validate();
        this.EventType.Validate();
        _ = this.PaymentCount;
        _ = this.TraceIds;
        _ = this.TraceNumbers;
        _ = this.TransferDate;
        _ = this.UpdatedAt;
        this.Status?.Validate();
        this.StatusDetails?.Validate();
        _ = this.TraceNumber;
    }

    public FundingEventSummaryPagedV1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public FundingEventSummaryPagedV1Data(
        FundingEventSummaryPagedV1Data fundingEventSummaryPagedV1Data
    )
        : base(fundingEventSummaryPagedV1Data) { }
#pragma warning restore CS8618

    public FundingEventSummaryPagedV1Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    FundingEventSummaryPagedV1Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="FundingEventSummaryPagedV1DataFromRaw.FromRawUnchecked"/>
    public static FundingEventSummaryPagedV1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class FundingEventSummaryPagedV1DataFromRaw : IFromRawJson<FundingEventSummaryPagedV1Data>
{
    /// <inheritdoc/>
    public FundingEventSummaryPagedV1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => FundingEventSummaryPagedV1Data.FromRawUnchecked(rawData);
}

/// <summary>
/// Describes the direction of the funding event from the perspective of the `linked_bank_account`.
/// </summary>
[JsonConverter(typeof(FundingEventSummaryPagedV1DataDirectionConverter))]
public enum FundingEventSummaryPagedV1DataDirection
{
    Deposit,
    Withdrawal,
}

sealed class FundingEventSummaryPagedV1DataDirectionConverter
    : JsonConverter<FundingEventSummaryPagedV1DataDirection>
{
    public override FundingEventSummaryPagedV1DataDirection Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "deposit" => FundingEventSummaryPagedV1DataDirection.Deposit,
            "withdrawal" => FundingEventSummaryPagedV1DataDirection.Withdrawal,
            _ => (FundingEventSummaryPagedV1DataDirection)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        FundingEventSummaryPagedV1DataDirection value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                FundingEventSummaryPagedV1DataDirection.Deposit => "deposit",
                FundingEventSummaryPagedV1DataDirection.Withdrawal => "withdrawal",
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
[JsonConverter(typeof(FundingEventSummaryPagedV1DataEventTypeConverter))]
public enum FundingEventSummaryPagedV1DataEventType
{
    ChargeDeposit,
    ChargeReversal,
    PayoutReturn,
    PayoutWithdrawal,
}

sealed class FundingEventSummaryPagedV1DataEventTypeConverter
    : JsonConverter<FundingEventSummaryPagedV1DataEventType>
{
    public override FundingEventSummaryPagedV1DataEventType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "charge_deposit" => FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
            "charge_reversal" => FundingEventSummaryPagedV1DataEventType.ChargeReversal,
            "payout_return" => FundingEventSummaryPagedV1DataEventType.PayoutReturn,
            "payout_withdrawal" => FundingEventSummaryPagedV1DataEventType.PayoutWithdrawal,
            _ => (FundingEventSummaryPagedV1DataEventType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        FundingEventSummaryPagedV1DataEventType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                FundingEventSummaryPagedV1DataEventType.ChargeDeposit => "charge_deposit",
                FundingEventSummaryPagedV1DataEventType.ChargeReversal => "charge_reversal",
                FundingEventSummaryPagedV1DataEventType.PayoutReturn => "payout_return",
                FundingEventSummaryPagedV1DataEventType.PayoutWithdrawal => "payout_withdrawal",
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
[JsonConverter(typeof(FundingEventSummaryPagedV1DataStatusConverter))]
public enum FundingEventSummaryPagedV1DataStatus
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

sealed class FundingEventSummaryPagedV1DataStatusConverter
    : JsonConverter<FundingEventSummaryPagedV1DataStatus>
{
    public override FundingEventSummaryPagedV1DataStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created" => FundingEventSummaryPagedV1DataStatus.Created,
            "scheduled" => FundingEventSummaryPagedV1DataStatus.Scheduled,
            "failed" => FundingEventSummaryPagedV1DataStatus.Failed,
            "cancelled" => FundingEventSummaryPagedV1DataStatus.Cancelled,
            "on_hold" => FundingEventSummaryPagedV1DataStatus.OnHold,
            "pending" => FundingEventSummaryPagedV1DataStatus.Pending,
            "paid" => FundingEventSummaryPagedV1DataStatus.Paid,
            "reversed" => FundingEventSummaryPagedV1DataStatus.Reversed,
            _ => (FundingEventSummaryPagedV1DataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        FundingEventSummaryPagedV1DataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                FundingEventSummaryPagedV1DataStatus.Created => "created",
                FundingEventSummaryPagedV1DataStatus.Scheduled => "scheduled",
                FundingEventSummaryPagedV1DataStatus.Failed => "failed",
                FundingEventSummaryPagedV1DataStatus.Cancelled => "cancelled",
                FundingEventSummaryPagedV1DataStatus.OnHold => "on_hold",
                FundingEventSummaryPagedV1DataStatus.Pending => "pending",
                FundingEventSummaryPagedV1DataStatus.Paid => "paid",
                FundingEventSummaryPagedV1DataStatus.Reversed => "reversed",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(
    typeof(JsonModelConverter<
        FundingEventSummaryPagedV1DataStatusDetails,
        FundingEventSummaryPagedV1DataStatusDetailsFromRaw
    >)
)]
public sealed record class FundingEventSummaryPagedV1DataStatusDetails : JsonModel
{
    /// <summary>
    /// The time the status change occurred.
    /// </summary>
    public required DateTimeOffset ChangedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<DateTimeOffset>("changed_at");
        }
        init { this._rawData.Set("changed_at", value); }
    }

    /// <summary>
    /// A human-readable description of the current status.
    /// </summary>
    public required string Message
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("message");
        }
        init { this._rawData.Set("message", value); }
    }

    public required ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsReason> Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsReason>
            >("reason");
        }
        init { this._rawData.Set("reason", value); }
    }

    public required ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsSource> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsSource>
            >("source");
        }
        init { this._rawData.Set("source", value); }
    }

    /// <summary>
    /// The status code if applicable.
    /// </summary>
    public string? Code
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("code");
        }
        init { this._rawData.Set("code", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ChangedAt;
        _ = this.Message;
        this.Reason.Validate();
        this.Source.Validate();
        _ = this.Code;
    }

    public FundingEventSummaryPagedV1DataStatusDetails() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public FundingEventSummaryPagedV1DataStatusDetails(
        FundingEventSummaryPagedV1DataStatusDetails fundingEventSummaryPagedV1DataStatusDetails
    )
        : base(fundingEventSummaryPagedV1DataStatusDetails) { }
#pragma warning restore CS8618

    public FundingEventSummaryPagedV1DataStatusDetails(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    FundingEventSummaryPagedV1DataStatusDetails(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="FundingEventSummaryPagedV1DataStatusDetailsFromRaw.FromRawUnchecked"/>
    public static FundingEventSummaryPagedV1DataStatusDetails FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class FundingEventSummaryPagedV1DataStatusDetailsFromRaw
    : IFromRawJson<FundingEventSummaryPagedV1DataStatusDetails>
{
    /// <inheritdoc/>
    public FundingEventSummaryPagedV1DataStatusDetails FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => FundingEventSummaryPagedV1DataStatusDetails.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(FundingEventSummaryPagedV1DataStatusDetailsReasonConverter))]
public enum FundingEventSummaryPagedV1DataStatusDetailsReason
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

sealed class FundingEventSummaryPagedV1DataStatusDetailsReasonConverter
    : JsonConverter<FundingEventSummaryPagedV1DataStatusDetailsReason>
{
    public override FundingEventSummaryPagedV1DataStatusDetailsReason Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "insufficient_funds" =>
                FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
            "closed_bank_account" =>
                FundingEventSummaryPagedV1DataStatusDetailsReason.ClosedBankAccount,
            "invalid_bank_account" =>
                FundingEventSummaryPagedV1DataStatusDetailsReason.InvalidBankAccount,
            "invalid_routing" => FundingEventSummaryPagedV1DataStatusDetailsReason.InvalidRouting,
            "disputed" => FundingEventSummaryPagedV1DataStatusDetailsReason.Disputed,
            "payment_stopped" => FundingEventSummaryPagedV1DataStatusDetailsReason.PaymentStopped,
            "owner_deceased" => FundingEventSummaryPagedV1DataStatusDetailsReason.OwnerDeceased,
            "frozen_bank_account" =>
                FundingEventSummaryPagedV1DataStatusDetailsReason.FrozenBankAccount,
            "risk_review" => FundingEventSummaryPagedV1DataStatusDetailsReason.RiskReview,
            "fraudulent" => FundingEventSummaryPagedV1DataStatusDetailsReason.Fraudulent,
            "duplicate_entry" => FundingEventSummaryPagedV1DataStatusDetailsReason.DuplicateEntry,
            "invalid_paykey" => FundingEventSummaryPagedV1DataStatusDetailsReason.InvalidPaykey,
            "payment_blocked" => FundingEventSummaryPagedV1DataStatusDetailsReason.PaymentBlocked,
            "amount_too_large" => FundingEventSummaryPagedV1DataStatusDetailsReason.AmountTooLarge,
            "too_many_attempts" =>
                FundingEventSummaryPagedV1DataStatusDetailsReason.TooManyAttempts,
            "internal_system_error" =>
                FundingEventSummaryPagedV1DataStatusDetailsReason.InternalSystemError,
            "user_request" => FundingEventSummaryPagedV1DataStatusDetailsReason.UserRequest,
            "ok" => FundingEventSummaryPagedV1DataStatusDetailsReason.Ok,
            "other_network_return" =>
                FundingEventSummaryPagedV1DataStatusDetailsReason.OtherNetworkReturn,
            "payout_refused" => FundingEventSummaryPagedV1DataStatusDetailsReason.PayoutRefused,
            "cancel_request" => FundingEventSummaryPagedV1DataStatusDetailsReason.CancelRequest,
            "failed_verification" =>
                FundingEventSummaryPagedV1DataStatusDetailsReason.FailedVerification,
            "require_review" => FundingEventSummaryPagedV1DataStatusDetailsReason.RequireReview,
            "blocked_by_system" =>
                FundingEventSummaryPagedV1DataStatusDetailsReason.BlockedBySystem,
            "watchtower_review" =>
                FundingEventSummaryPagedV1DataStatusDetailsReason.WatchtowerReview,
            _ => (FundingEventSummaryPagedV1DataStatusDetailsReason)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        FundingEventSummaryPagedV1DataStatusDetailsReason value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds =>
                    "insufficient_funds",
                FundingEventSummaryPagedV1DataStatusDetailsReason.ClosedBankAccount =>
                    "closed_bank_account",
                FundingEventSummaryPagedV1DataStatusDetailsReason.InvalidBankAccount =>
                    "invalid_bank_account",
                FundingEventSummaryPagedV1DataStatusDetailsReason.InvalidRouting =>
                    "invalid_routing",
                FundingEventSummaryPagedV1DataStatusDetailsReason.Disputed => "disputed",
                FundingEventSummaryPagedV1DataStatusDetailsReason.PaymentStopped =>
                    "payment_stopped",
                FundingEventSummaryPagedV1DataStatusDetailsReason.OwnerDeceased => "owner_deceased",
                FundingEventSummaryPagedV1DataStatusDetailsReason.FrozenBankAccount =>
                    "frozen_bank_account",
                FundingEventSummaryPagedV1DataStatusDetailsReason.RiskReview => "risk_review",
                FundingEventSummaryPagedV1DataStatusDetailsReason.Fraudulent => "fraudulent",
                FundingEventSummaryPagedV1DataStatusDetailsReason.DuplicateEntry =>
                    "duplicate_entry",
                FundingEventSummaryPagedV1DataStatusDetailsReason.InvalidPaykey => "invalid_paykey",
                FundingEventSummaryPagedV1DataStatusDetailsReason.PaymentBlocked =>
                    "payment_blocked",
                FundingEventSummaryPagedV1DataStatusDetailsReason.AmountTooLarge =>
                    "amount_too_large",
                FundingEventSummaryPagedV1DataStatusDetailsReason.TooManyAttempts =>
                    "too_many_attempts",
                FundingEventSummaryPagedV1DataStatusDetailsReason.InternalSystemError =>
                    "internal_system_error",
                FundingEventSummaryPagedV1DataStatusDetailsReason.UserRequest => "user_request",
                FundingEventSummaryPagedV1DataStatusDetailsReason.Ok => "ok",
                FundingEventSummaryPagedV1DataStatusDetailsReason.OtherNetworkReturn =>
                    "other_network_return",
                FundingEventSummaryPagedV1DataStatusDetailsReason.PayoutRefused => "payout_refused",
                FundingEventSummaryPagedV1DataStatusDetailsReason.CancelRequest => "cancel_request",
                FundingEventSummaryPagedV1DataStatusDetailsReason.FailedVerification =>
                    "failed_verification",
                FundingEventSummaryPagedV1DataStatusDetailsReason.RequireReview => "require_review",
                FundingEventSummaryPagedV1DataStatusDetailsReason.BlockedBySystem =>
                    "blocked_by_system",
                FundingEventSummaryPagedV1DataStatusDetailsReason.WatchtowerReview =>
                    "watchtower_review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(FundingEventSummaryPagedV1DataStatusDetailsSourceConverter))]
public enum FundingEventSummaryPagedV1DataStatusDetailsSource
{
    Watchtower,
    BankDecline,
    CustomerDispute,
    UserAction,
    System,
}

sealed class FundingEventSummaryPagedV1DataStatusDetailsSourceConverter
    : JsonConverter<FundingEventSummaryPagedV1DataStatusDetailsSource>
{
    public override FundingEventSummaryPagedV1DataStatusDetailsSource Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "watchtower" => FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
            "bank_decline" => FundingEventSummaryPagedV1DataStatusDetailsSource.BankDecline,
            "customer_dispute" => FundingEventSummaryPagedV1DataStatusDetailsSource.CustomerDispute,
            "user_action" => FundingEventSummaryPagedV1DataStatusDetailsSource.UserAction,
            "system" => FundingEventSummaryPagedV1DataStatusDetailsSource.System,
            _ => (FundingEventSummaryPagedV1DataStatusDetailsSource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        FundingEventSummaryPagedV1DataStatusDetailsSource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower => "watchtower",
                FundingEventSummaryPagedV1DataStatusDetailsSource.BankDecline => "bank_decline",
                FundingEventSummaryPagedV1DataStatusDetailsSource.CustomerDispute =>
                    "customer_dispute",
                FundingEventSummaryPagedV1DataStatusDetailsSource.UserAction => "user_action",
                FundingEventSummaryPagedV1DataStatusDetailsSource.System => "system",
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

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Meta(Meta meta)
        : base(meta) { }
#pragma warning restore CS8618

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
[JsonConverter(typeof(FundingEventSummaryPagedV1ResponseTypeConverter))]
public enum FundingEventSummaryPagedV1ResponseType
{
    Object,
    Array,
    Error,
    None,
}

sealed class FundingEventSummaryPagedV1ResponseTypeConverter
    : JsonConverter<FundingEventSummaryPagedV1ResponseType>
{
    public override FundingEventSummaryPagedV1ResponseType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "object" => FundingEventSummaryPagedV1ResponseType.Object,
            "array" => FundingEventSummaryPagedV1ResponseType.Array,
            "error" => FundingEventSummaryPagedV1ResponseType.Error,
            "none" => FundingEventSummaryPagedV1ResponseType.None,
            _ => (FundingEventSummaryPagedV1ResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        FundingEventSummaryPagedV1ResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                FundingEventSummaryPagedV1ResponseType.Object => "object",
                FundingEventSummaryPagedV1ResponseType.Array => "array",
                FundingEventSummaryPagedV1ResponseType.Error => "error",
                FundingEventSummaryPagedV1ResponseType.None => "none",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
