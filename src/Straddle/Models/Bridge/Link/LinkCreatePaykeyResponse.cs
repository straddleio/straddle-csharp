using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Bridge.Link;

[JsonConverter(
    typeof(JsonModelConverter<LinkCreatePaykeyResponse, LinkCreatePaykeyResponseFromRaw>)
)]
public sealed record class LinkCreatePaykeyResponse : JsonModel
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

    public LinkCreatePaykeyResponse() { }

    public LinkCreatePaykeyResponse(LinkCreatePaykeyResponse linkCreatePaykeyResponse)
        : base(linkCreatePaykeyResponse) { }

    public LinkCreatePaykeyResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LinkCreatePaykeyResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LinkCreatePaykeyResponseFromRaw.FromRawUnchecked"/>
    public static LinkCreatePaykeyResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LinkCreatePaykeyResponseFromRaw : IFromRawJson<LinkCreatePaykeyResponse>
{
    /// <inheritdoc/>
    public LinkCreatePaykeyResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => LinkCreatePaykeyResponse.FromRawUnchecked(rawData);
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

    public required DataConfig Config
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<DataConfig>("config");
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
    /// The tokenized paykey value. This token is used to create payments and should
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

    public required ApiEnum<string, Source> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Source>>("source");
        }
        init { this._rawData.Set("source", value); }
    }

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

    public Balance? Balance
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Balance>("balance");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("balance", value);
        }
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

    /// <summary>
    /// Up to 20 additional user-defined key-value pairs. Useful for storing additional
    /// information about the paykey in a structured format.
    /// </summary>
    public IReadOnlyDictionary<string, string>? Metadata
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("metadata");
        }
        init
        {
            this._rawData.Set<FrozenDictionary<string, string>?>(
                "metadata",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
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
        this.Balance?.Validate();
        this.BankData?.Validate();
        _ = this.CustomerID;
        _ = this.ExpiresAt;
        _ = this.ExternalID;
        _ = this.InstitutionName;
        _ = this.Metadata;
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

[JsonConverter(typeof(JsonModelConverter<DataConfig, DataConfigFromRaw>))]
public sealed record class DataConfig : JsonModel
{
    public ApiEnum<string, DataConfigProcessingMethod>? ProcessingMethod
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, DataConfigProcessingMethod>>(
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

    public ApiEnum<string, DataConfigSandboxOutcome>? SandboxOutcome
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, DataConfigSandboxOutcome>>(
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

    public DataConfig() { }

    public DataConfig(DataConfig dataConfig)
        : base(dataConfig) { }

    public DataConfig(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    DataConfig(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataConfigFromRaw.FromRawUnchecked"/>
    public static DataConfig FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataConfigFromRaw : IFromRawJson<DataConfig>
{
    /// <inheritdoc/>
    public DataConfig FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        DataConfig.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(DataConfigProcessingMethodConverter))]
public enum DataConfigProcessingMethod
{
    Inline,
    Background,
    Skip,
}

sealed class DataConfigProcessingMethodConverter : JsonConverter<DataConfigProcessingMethod>
{
    public override DataConfigProcessingMethod Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "inline" => DataConfigProcessingMethod.Inline,
            "background" => DataConfigProcessingMethod.Background,
            "skip" => DataConfigProcessingMethod.Skip,
            _ => (DataConfigProcessingMethod)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        DataConfigProcessingMethod value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                DataConfigProcessingMethod.Inline => "inline",
                DataConfigProcessingMethod.Background => "background",
                DataConfigProcessingMethod.Skip => "skip",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(DataConfigSandboxOutcomeConverter))]
public enum DataConfigSandboxOutcome
{
    Standard,
    Active,
    Rejected,
    Review,
}

sealed class DataConfigSandboxOutcomeConverter : JsonConverter<DataConfigSandboxOutcome>
{
    public override DataConfigSandboxOutcome Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "standard" => DataConfigSandboxOutcome.Standard,
            "active" => DataConfigSandboxOutcome.Active,
            "rejected" => DataConfigSandboxOutcome.Rejected,
            "review" => DataConfigSandboxOutcome.Review,
            _ => (DataConfigSandboxOutcome)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        DataConfigSandboxOutcome value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                DataConfigSandboxOutcome.Standard => "standard",
                DataConfigSandboxOutcome.Active => "active",
                DataConfigSandboxOutcome.Rejected => "rejected",
                DataConfigSandboxOutcome.Review => "review",
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
    BankAccount,
    Straddle,
    Mx,
    Plaid,
    Tan,
    Quiltt,
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
            "bank_account" => Source.BankAccount,
            "straddle" => Source.Straddle,
            "mx" => Source.Mx,
            "plaid" => Source.Plaid,
            "tan" => Source.Tan,
            "quiltt" => Source.Quiltt,
            _ => (Source)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Source value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Source.BankAccount => "bank_account",
                Source.Straddle => "straddle",
                Source.Mx => "mx",
                Source.Plaid => "plaid",
                Source.Tan => "tan",
                Source.Quiltt => "quiltt",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(StatusConverter))]
public enum Status
{
    Pending,
    Active,
    Inactive,
    Rejected,
    Review,
    Blocked,
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
            "pending" => Status.Pending,
            "active" => Status.Active,
            "inactive" => Status.Inactive,
            "rejected" => Status.Rejected,
            "review" => Status.Review,
            "blocked" => Status.Blocked,
            _ => (Status)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Status value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Status.Pending => "pending",
                Status.Active => "active",
                Status.Inactive => "inactive",
                Status.Rejected => "rejected",
                Status.Review => "review",
                Status.Blocked => "blocked",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<Balance, BalanceFromRaw>))]
public sealed record class Balance : JsonModel
{
    public required ApiEnum<string, BalanceStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, BalanceStatus>>("status");
        }
        init { this._rawData.Set("status", value); }
    }

    /// <summary>
    /// Account Balance when last retrieved
    /// </summary>
    public int? AccountBalance
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("account_balance");
        }
        init { this._rawData.Set("account_balance", value); }
    }

    /// <summary>
    /// Last time account balance was updated.
    /// </summary>
    public DateTimeOffset? UpdatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<DateTimeOffset>("updated_at");
        }
        init { this._rawData.Set("updated_at", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Status.Validate();
        _ = this.AccountBalance;
        _ = this.UpdatedAt;
    }

    public Balance() { }

    public Balance(Balance balance)
        : base(balance) { }

    public Balance(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Balance(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="BalanceFromRaw.FromRawUnchecked"/>
    public static Balance FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public Balance(ApiEnum<string, BalanceStatus> status)
        : this()
    {
        this.Status = status;
    }
}

class BalanceFromRaw : IFromRawJson<Balance>
{
    /// <inheritdoc/>
    public Balance FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Balance.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(BalanceStatusConverter))]
public enum BalanceStatus
{
    Pending,
    Completed,
    Failed,
}

sealed class BalanceStatusConverter : JsonConverter<BalanceStatus>
{
    public override BalanceStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => BalanceStatus.Pending,
            "completed" => BalanceStatus.Completed,
            "failed" => BalanceStatus.Failed,
            _ => (BalanceStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        BalanceStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                BalanceStatus.Pending => "pending",
                BalanceStatus.Completed => "completed",
                BalanceStatus.Failed => "failed",
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

    public required ApiEnum<string, BankDataAccountType> AccountType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, BankDataAccountType>>(
                "account_type"
            );
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

[JsonConverter(typeof(BankDataAccountTypeConverter))]
public enum BankDataAccountType
{
    Checking,
    Savings,
}

sealed class BankDataAccountTypeConverter : JsonConverter<BankDataAccountType>
{
    public override BankDataAccountType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "checking" => BankDataAccountType.Checking,
            "savings" => BankDataAccountType.Savings,
            _ => (BankDataAccountType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        BankDataAccountType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                BankDataAccountType.Checking => "checking",
                BankDataAccountType.Savings => "savings",
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
