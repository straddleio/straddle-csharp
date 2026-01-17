using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Paykeys;

[JsonConverter(typeof(JsonModelConverter<PaykeySummaryPagedV1, PaykeySummaryPagedV1FromRaw>))]
public sealed record class PaykeySummaryPagedV1 : JsonModel
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

    public PaykeySummaryPagedV1() { }

    public PaykeySummaryPagedV1(PaykeySummaryPagedV1 paykeySummaryPagedV1)
        : base(paykeySummaryPagedV1) { }

    public PaykeySummaryPagedV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeySummaryPagedV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeySummaryPagedV1FromRaw.FromRawUnchecked"/>
    public static PaykeySummaryPagedV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeySummaryPagedV1FromRaw : IFromRawJson<PaykeySummaryPagedV1>
{
    /// <inheritdoc/>
    public PaykeySummaryPagedV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PaykeySummaryPagedV1.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    /// <summary>
    /// Unique identifier for the paykey.
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

    public required Config Config
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<Config>("config");
        }
        init { this._rawData.Set("config", value); }
    }

    /// <summary>
    /// Timestamp of when the paykey was created.
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
    /// Human-readable label that combines the bank name and masked account number
    /// to help easility represent this paykey in a UI
    /// </summary>
    public required string Label
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("label");
        }
        init { this._rawData.Set("label", value); }
    }

    /// <summary>
    /// The tokenized paykey value. This value is used to create payments and should
    /// be stored securely.
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

    public required ApiEnum<string, DataSource> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, DataSource>>("source");
        }
        init { this._rawData.Set("source", value); }
    }

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
    /// Timestamp of the most recent update to the paykey.
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

    public BankData? BankData
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<BankData>("bank_data");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("bank_data", value);
        }
    }

    /// <summary>
    /// Unique identifier of the related customer object.
    /// </summary>
    public string? CustomerID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("customer_id");
        }
        init { this._rawData.Set("customer_id", value); }
    }

    /// <summary>
    /// Expiration date and time of the paykey, if applicable.
    /// </summary>
    public DateTimeOffset? ExpiresAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<DateTimeOffset>("expires_at");
        }
        init { this._rawData.Set("expires_at", value); }
    }

    /// <summary>
    /// Unique identifier for the paykey in your database, used for cross-referencing
    /// between Straddle and your systems.
    /// </summary>
    public string? ExternalID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("external_id");
        }
        init { this._rawData.Set("external_id", value); }
    }

    /// <summary>
    /// Name of the financial institution.
    /// </summary>
    public string? InstitutionName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("institution_name");
        }
        init { this._rawData.Set("institution_name", value); }
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        this.Config.Validate();
        _ = this.CreatedAt;
        _ = this.Label;
        _ = this.Paykey;
        this.Source.Validate();
        this.Status.Validate();
        _ = this.UpdatedAt;
        this.BankData?.Validate();
        _ = this.CustomerID;
        _ = this.ExpiresAt;
        _ = this.ExternalID;
        _ = this.InstitutionName;
        this.StatusDetails?.Validate();
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

[JsonConverter(typeof(JsonModelConverter<Config, ConfigFromRaw>))]
public sealed record class Config : JsonModel
{
    public ApiEnum<string, ProcessingMethod>? ProcessingMethod
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, ProcessingMethod>>(
                "processing_method"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("processing_method", value);
        }
    }

    public ApiEnum<string, SandboxOutcome>? SandboxOutcome
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, SandboxOutcome>>(
                "sandbox_outcome"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("sandbox_outcome", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.ProcessingMethod?.Validate();
        this.SandboxOutcome?.Validate();
    }

    public Config() { }

    public Config(Config config)
        : base(config) { }

    public Config(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Config(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ConfigFromRaw.FromRawUnchecked"/>
    public static Config FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ConfigFromRaw : IFromRawJson<Config>
{
    /// <inheritdoc/>
    public Config FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Config.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ProcessingMethodConverter))]
public enum ProcessingMethod
{
    Inline,
    Background,
    Skip,
}

sealed class ProcessingMethodConverter : JsonConverter<ProcessingMethod>
{
    public override ProcessingMethod Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "inline" => ProcessingMethod.Inline,
            "background" => ProcessingMethod.Background,
            "skip" => ProcessingMethod.Skip,
            _ => (ProcessingMethod)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ProcessingMethod value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ProcessingMethod.Inline => "inline",
                ProcessingMethod.Background => "background",
                ProcessingMethod.Skip => "skip",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(SandboxOutcomeConverter))]
public enum SandboxOutcome
{
    Standard,
    Active,
    Rejected,
    Review,
}

sealed class SandboxOutcomeConverter : JsonConverter<SandboxOutcome>
{
    public override SandboxOutcome Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "standard" => SandboxOutcome.Standard,
            "active" => SandboxOutcome.Active,
            "rejected" => SandboxOutcome.Rejected,
            "review" => SandboxOutcome.Review,
            _ => (SandboxOutcome)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        SandboxOutcome value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                SandboxOutcome.Standard => "standard",
                SandboxOutcome.Active => "active",
                SandboxOutcome.Rejected => "rejected",
                SandboxOutcome.Review => "review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(DataSourceConverter))]
public enum DataSource
{
    BankAccount,
    Straddle,
    Mx,
    Plaid,
    Tan,
    Quiltt,
}

sealed class DataSourceConverter : JsonConverter<DataSource>
{
    public override DataSource Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "bank_account" => DataSource.BankAccount,
            "straddle" => DataSource.Straddle,
            "mx" => DataSource.Mx,
            "plaid" => DataSource.Plaid,
            "tan" => DataSource.Tan,
            "quiltt" => DataSource.Quiltt,
            _ => (DataSource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        DataSource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                DataSource.BankAccount => "bank_account",
                DataSource.Straddle => "straddle",
                DataSource.Mx => "mx",
                DataSource.Plaid => "plaid",
                DataSource.Tan => "tan",
                DataSource.Quiltt => "quiltt",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(DataStatusConverter))]
public enum DataStatus
{
    Pending,
    Active,
    Inactive,
    Rejected,
    Review,
    Blocked,
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
            "pending" => DataStatus.Pending,
            "active" => DataStatus.Active,
            "inactive" => DataStatus.Inactive,
            "rejected" => DataStatus.Rejected,
            "review" => DataStatus.Review,
            "blocked" => DataStatus.Blocked,
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
                DataStatus.Pending => "pending",
                DataStatus.Active => "active",
                DataStatus.Inactive => "inactive",
                DataStatus.Rejected => "rejected",
                DataStatus.Review => "review",
                DataStatus.Blocked => "blocked",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<BankData, BankDataFromRaw>))]
public sealed record class BankData : JsonModel
{
    /// <summary>
    /// Bank account number. This value is masked by default for security reasons.
    /// Use the /unmask endpoint to access the unmasked value.
    /// </summary>
    public required string AccountNumber
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("account_number");
        }
        init { this._rawData.Set("account_number", value); }
    }

    public required ApiEnum<string, AccountType> AccountType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, AccountType>>("account_type");
        }
        init { this._rawData.Set("account_type", value); }
    }

    /// <summary>
    /// The routing number of the bank account.
    /// </summary>
    public required string RoutingNumber
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("routing_number");
        }
        init { this._rawData.Set("routing_number", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AccountNumber;
        this.AccountType.Validate();
        _ = this.RoutingNumber;
    }

    public BankData() { }

    public BankData(BankData bankData)
        : base(bankData) { }

    public BankData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    BankData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="BankDataFromRaw.FromRawUnchecked"/>
    public static BankData FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class BankDataFromRaw : IFromRawJson<BankData>
{
    /// <inheritdoc/>
    public BankData FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        BankData.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(AccountTypeConverter))]
public enum AccountType
{
    Checking,
    Savings,
}

sealed class AccountTypeConverter : JsonConverter<AccountType>
{
    public override AccountType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "checking" => AccountType.Checking,
            "savings" => AccountType.Savings,
            _ => (AccountType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AccountType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AccountType.Checking => "checking",
                AccountType.Savings => "savings",
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

    public required ApiEnum<string, StatusDetailsSource> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, StatusDetailsSource>>("source");
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

[JsonConverter(typeof(StatusDetailsSourceConverter))]
public enum StatusDetailsSource
{
    Watchtower,
    BankDecline,
    CustomerDispute,
    UserAction,
    System,
}

sealed class StatusDetailsSourceConverter : JsonConverter<StatusDetailsSource>
{
    public override StatusDetailsSource Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "watchtower" => StatusDetailsSource.Watchtower,
            "bank_decline" => StatusDetailsSource.BankDecline,
            "customer_dispute" => StatusDetailsSource.CustomerDispute,
            "user_action" => StatusDetailsSource.UserAction,
            "system" => StatusDetailsSource.System,
            _ => (StatusDetailsSource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        StatusDetailsSource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                StatusDetailsSource.Watchtower => "watchtower",
                StatusDetailsSource.BankDecline => "bank_decline",
                StatusDetailsSource.CustomerDispute => "customer_dispute",
                StatusDetailsSource.UserAction => "user_action",
                StatusDetailsSource.System => "system",
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
