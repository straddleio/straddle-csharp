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
    typeof(JsonModelConverter<FundingEventSummaryItemV1, FundingEventSummaryItemV1FromRaw>)
)]
public sealed record class FundingEventSummaryItemV1 : JsonModel
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

    public FundingEventSummaryItemV1() { }

    public FundingEventSummaryItemV1(FundingEventSummaryItemV1 fundingEventSummaryItemV1)
        : base(fundingEventSummaryItemV1) { }

    public FundingEventSummaryItemV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    FundingEventSummaryItemV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="FundingEventSummaryItemV1FromRaw.FromRawUnchecked"/>
    public static FundingEventSummaryItemV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class FundingEventSummaryItemV1FromRaw : IFromRawJson<FundingEventSummaryItemV1>
{
    /// <inheritdoc/>
    public FundingEventSummaryItemV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => FundingEventSummaryItemV1.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
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
    public required ApiEnum<string, DataDirection> Direction
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, DataDirection>>("direction");
        }
        init { this._rawData.Set("direction", value); }
    }

    /// <summary>
    /// The funding event types describes the direction and reason for the funding event.
    /// </summary>
    public required ApiEnum<string, DataEventType> EventType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, DataEventType>>("event_type");
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
    public ApiEnum<string, DataStatus>? Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, DataStatus>>("status");
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

    public StatusDetails? StatusDetails
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<StatusDetails>("status_details");
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
/// Describes the direction of the funding event from the perspective of the `linked_bank_account`.
/// </summary>
[JsonConverter(typeof(DataDirectionConverter))]
public enum DataDirection
{
    Deposit,
    Withdrawal,
}

sealed class DataDirectionConverter : JsonConverter<DataDirection>
{
    public override DataDirection Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "deposit" => DataDirection.Deposit,
            "withdrawal" => DataDirection.Withdrawal,
            _ => (DataDirection)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        DataDirection value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                DataDirection.Deposit => "deposit",
                DataDirection.Withdrawal => "withdrawal",
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
[JsonConverter(typeof(DataEventTypeConverter))]
public enum DataEventType
{
    ChargeDeposit,
    ChargeReversal,
    PayoutReturn,
    PayoutWithdrawal,
    ChargeDeposit1,
    ChargeReversal1,
    PayoutReturn1,
    PayoutWithdrawal1,
}

sealed class DataEventTypeConverter : JsonConverter<DataEventType>
{
    public override DataEventType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "charge_deposit" => DataEventType.ChargeDeposit,
            "charge_reversal" => DataEventType.ChargeReversal,
            "payout_return" => DataEventType.PayoutReturn,
            "payout_withdrawal" => DataEventType.PayoutWithdrawal,
            "ChargeDeposit" => DataEventType.ChargeDeposit1,
            "ChargeReversal" => DataEventType.ChargeReversal1,
            "PayoutReturn" => DataEventType.PayoutReturn1,
            "PayoutWithdrawal" => DataEventType.PayoutWithdrawal1,
            _ => (DataEventType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        DataEventType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                DataEventType.ChargeDeposit => "charge_deposit",
                DataEventType.ChargeReversal => "charge_reversal",
                DataEventType.PayoutReturn => "payout_return",
                DataEventType.PayoutWithdrawal => "payout_withdrawal",
                DataEventType.ChargeDeposit1 => "ChargeDeposit",
                DataEventType.ChargeReversal1 => "ChargeReversal",
                DataEventType.PayoutReturn1 => "PayoutReturn",
                DataEventType.PayoutWithdrawal1 => "PayoutWithdrawal",
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
[JsonConverter(typeof(DataStatusConverter))]
public enum DataStatus
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

sealed class DataStatusConverter : JsonConverter<DataStatus>
{
    public override DataStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created" => DataStatus.Created,
            "scheduled" => DataStatus.Scheduled,
            "failed" => DataStatus.Failed,
            "cancelled" => DataStatus.Cancelled,
            "on_hold" => DataStatus.OnHold,
            "pending" => DataStatus.Pending,
            "paid" => DataStatus.Paid,
            "reversed" => DataStatus.Reversed,
            "Created" => DataStatus.Created1,
            "Scheduled" => DataStatus.Scheduled1,
            "Failed" => DataStatus.Failed1,
            "Cancelled" => DataStatus.Cancelled1,
            "OnHold" => DataStatus.OnHold1,
            "Pending" => DataStatus.Pending1,
            "Paid" => DataStatus.Paid1,
            "Reversed" => DataStatus.Reversed1,
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
                DataStatus.Created => "created",
                DataStatus.Scheduled => "scheduled",
                DataStatus.Failed => "failed",
                DataStatus.Cancelled => "cancelled",
                DataStatus.OnHold => "on_hold",
                DataStatus.Pending => "pending",
                DataStatus.Paid => "paid",
                DataStatus.Reversed => "reversed",
                DataStatus.Created1 => "Created",
                DataStatus.Scheduled1 => "Scheduled",
                DataStatus.Failed1 => "Failed",
                DataStatus.Cancelled1 => "Cancelled",
                DataStatus.OnHold1 => "OnHold",
                DataStatus.Pending1 => "Pending",
                DataStatus.Paid1 => "Paid",
                DataStatus.Reversed1 => "Reversed",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<StatusDetails, StatusDetailsFromRaw>))]
public sealed record class StatusDetails : JsonModel
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

    public required ApiEnum<string, Reason> Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Reason>>("reason");
        }
        init { this._rawData.Set("reason", value); }
    }

    public required ApiEnum<string, Source> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Source>>("source");
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

    public StatusDetails() { }

    public StatusDetails(StatusDetails statusDetails)
        : base(statusDetails) { }

    public StatusDetails(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    StatusDetails(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="StatusDetailsFromRaw.FromRawUnchecked"/>
    public static StatusDetails FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class StatusDetailsFromRaw : IFromRawJson<StatusDetails>
{
    /// <inheritdoc/>
    public StatusDetails FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        StatusDetails.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ReasonConverter))]
public enum Reason
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
    InsufficientFunds1,
    ClosedBankAccount1,
    InvalidBankAccount1,
    InvalidRouting1,
    Disputed1,
    PaymentStopped1,
    OwnerDeceased1,
    FrozenBankAccount1,
    RiskReview1,
    Fraudulent1,
    DuplicateEntry1,
    InvalidPaykey1,
    PaymentBlocked1,
    AmountTooLarge1,
    TooManyAttempts1,
    InternalSystemError1,
    UserRequest1,
    Ok1,
    OtherNetworkReturn1,
    PayoutRefused1,
}

sealed class ReasonConverter : JsonConverter<Reason>
{
    public override Reason Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "insufficient_funds" => Reason.InsufficientFunds,
            "closed_bank_account" => Reason.ClosedBankAccount,
            "invalid_bank_account" => Reason.InvalidBankAccount,
            "invalid_routing" => Reason.InvalidRouting,
            "disputed" => Reason.Disputed,
            "payment_stopped" => Reason.PaymentStopped,
            "owner_deceased" => Reason.OwnerDeceased,
            "frozen_bank_account" => Reason.FrozenBankAccount,
            "risk_review" => Reason.RiskReview,
            "fraudulent" => Reason.Fraudulent,
            "duplicate_entry" => Reason.DuplicateEntry,
            "invalid_paykey" => Reason.InvalidPaykey,
            "payment_blocked" => Reason.PaymentBlocked,
            "amount_too_large" => Reason.AmountTooLarge,
            "too_many_attempts" => Reason.TooManyAttempts,
            "internal_system_error" => Reason.InternalSystemError,
            "user_request" => Reason.UserRequest,
            "ok" => Reason.Ok,
            "other_network_return" => Reason.OtherNetworkReturn,
            "payout_refused" => Reason.PayoutRefused,
            "cancel_request" => Reason.CancelRequest,
            "failed_verification" => Reason.FailedVerification,
            "require_review" => Reason.RequireReview,
            "blocked_by_system" => Reason.BlockedBySystem,
            "watchtower_review" => Reason.WatchtowerReview,
            "InsufficientFunds" => Reason.InsufficientFunds1,
            "ClosedBankAccount" => Reason.ClosedBankAccount1,
            "InvalidBankAccount" => Reason.InvalidBankAccount1,
            "InvalidRouting" => Reason.InvalidRouting1,
            "Disputed" => Reason.Disputed1,
            "PaymentStopped" => Reason.PaymentStopped1,
            "OwnerDeceased" => Reason.OwnerDeceased1,
            "FrozenBankAccount" => Reason.FrozenBankAccount1,
            "RiskReview" => Reason.RiskReview1,
            "Fraudulent" => Reason.Fraudulent1,
            "DuplicateEntry" => Reason.DuplicateEntry1,
            "InvalidPaykey" => Reason.InvalidPaykey1,
            "PaymentBlocked" => Reason.PaymentBlocked1,
            "AmountTooLarge" => Reason.AmountTooLarge1,
            "TooManyAttempts" => Reason.TooManyAttempts1,
            "InternalSystemError" => Reason.InternalSystemError1,
            "UserRequest" => Reason.UserRequest1,
            "Ok" => Reason.Ok1,
            "OtherNetworkReturn" => Reason.OtherNetworkReturn1,
            "PayoutRefused" => Reason.PayoutRefused1,
            _ => (Reason)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Reason value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Reason.InsufficientFunds => "insufficient_funds",
                Reason.ClosedBankAccount => "closed_bank_account",
                Reason.InvalidBankAccount => "invalid_bank_account",
                Reason.InvalidRouting => "invalid_routing",
                Reason.Disputed => "disputed",
                Reason.PaymentStopped => "payment_stopped",
                Reason.OwnerDeceased => "owner_deceased",
                Reason.FrozenBankAccount => "frozen_bank_account",
                Reason.RiskReview => "risk_review",
                Reason.Fraudulent => "fraudulent",
                Reason.DuplicateEntry => "duplicate_entry",
                Reason.InvalidPaykey => "invalid_paykey",
                Reason.PaymentBlocked => "payment_blocked",
                Reason.AmountTooLarge => "amount_too_large",
                Reason.TooManyAttempts => "too_many_attempts",
                Reason.InternalSystemError => "internal_system_error",
                Reason.UserRequest => "user_request",
                Reason.Ok => "ok",
                Reason.OtherNetworkReturn => "other_network_return",
                Reason.PayoutRefused => "payout_refused",
                Reason.CancelRequest => "cancel_request",
                Reason.FailedVerification => "failed_verification",
                Reason.RequireReview => "require_review",
                Reason.BlockedBySystem => "blocked_by_system",
                Reason.WatchtowerReview => "watchtower_review",
                Reason.InsufficientFunds1 => "InsufficientFunds",
                Reason.ClosedBankAccount1 => "ClosedBankAccount",
                Reason.InvalidBankAccount1 => "InvalidBankAccount",
                Reason.InvalidRouting1 => "InvalidRouting",
                Reason.Disputed1 => "Disputed",
                Reason.PaymentStopped1 => "PaymentStopped",
                Reason.OwnerDeceased1 => "OwnerDeceased",
                Reason.FrozenBankAccount1 => "FrozenBankAccount",
                Reason.RiskReview1 => "RiskReview",
                Reason.Fraudulent1 => "Fraudulent",
                Reason.DuplicateEntry1 => "DuplicateEntry",
                Reason.InvalidPaykey1 => "InvalidPaykey",
                Reason.PaymentBlocked1 => "PaymentBlocked",
                Reason.AmountTooLarge1 => "AmountTooLarge",
                Reason.TooManyAttempts1 => "TooManyAttempts",
                Reason.InternalSystemError1 => "InternalSystemError",
                Reason.UserRequest1 => "UserRequest",
                Reason.Ok1 => "Ok",
                Reason.OtherNetworkReturn1 => "OtherNetworkReturn",
                Reason.PayoutRefused1 => "PayoutRefused",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(SourceConverter))]
public enum Source
{
    Watchtower,
    BankDecline,
    CustomerDispute,
    UserAction,
    System,
    Watchtower1,
    BankDecline1,
    CustomerDispute1,
    UserAction1,
    System1,
}

sealed class SourceConverter : JsonConverter<Source>
{
    public override Source Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "watchtower" => Source.Watchtower,
            "bank_decline" => Source.BankDecline,
            "customer_dispute" => Source.CustomerDispute,
            "user_action" => Source.UserAction,
            "system" => Source.System,
            "Watchtower" => Source.Watchtower1,
            "BankDecline" => Source.BankDecline1,
            "CustomerDispute" => Source.CustomerDispute1,
            "UserAction" => Source.UserAction1,
            "System" => Source.System1,
            _ => (Source)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Source value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Source.Watchtower => "watchtower",
                Source.BankDecline => "bank_decline",
                Source.CustomerDispute => "customer_dispute",
                Source.UserAction => "user_action",
                Source.System => "system",
                Source.Watchtower1 => "Watchtower",
                Source.BankDecline1 => "BankDecline",
                Source.CustomerDispute1 => "CustomerDispute",
                Source.UserAction1 => "UserAction",
                Source.System1 => "System",
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
