using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models;

[JsonConverter(typeof(JsonModelConverter<StatusDetailsV1, StatusDetailsV1FromRaw>))]
public sealed record class StatusDetailsV1 : JsonModel
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

    /// <summary>
    /// A machine-readable identifier for the specific status, useful for programmatic handling.
    /// </summary>
    public required ApiEnum<string, Reason> Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Reason>>("reason");
        }
        init { this._rawData.Set("reason", value); }
    }

    /// <summary>
    /// Identifies the origin of the status change (e.g., `bank_decline`, `watchtower`).
    /// This helps in tracking the cause of status updates.
    /// </summary>
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

    public StatusDetailsV1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public StatusDetailsV1(StatusDetailsV1 statusDetailsV1)
        : base(statusDetailsV1) { }
#pragma warning restore CS8618

    public StatusDetailsV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    StatusDetailsV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="StatusDetailsV1FromRaw.FromRawUnchecked"/>
    public static StatusDetailsV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class StatusDetailsV1FromRaw : IFromRawJson<StatusDetailsV1>
{
    /// <inheritdoc/>
    public StatusDetailsV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        StatusDetailsV1.FromRawUnchecked(rawData);
}

/// <summary>
/// A machine-readable identifier for the specific status, useful for programmatic handling.
/// </summary>
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
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Identifies the origin of the status change (e.g., `bank_decline`, `watchtower`).
/// This helps in tracking the cause of status updates.
/// </summary>
[JsonConverter(typeof(SourceConverter))]
public enum Source
{
    Watchtower,
    BankDecline,
    CustomerDispute,
    UserAction,
    System,
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
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
