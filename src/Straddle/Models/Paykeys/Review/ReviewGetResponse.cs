using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Paykeys.Review;

[JsonConverter(typeof(JsonModelConverter<ReviewGetResponse, ReviewGetResponseFromRaw>))]
public sealed record class ReviewGetResponse : JsonModel
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

    public ReviewGetResponse() { }

    public ReviewGetResponse(ReviewGetResponse reviewGetResponse)
        : base(reviewGetResponse) { }

    public ReviewGetResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ReviewGetResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ReviewGetResponseFromRaw.FromRawUnchecked"/>
    public static ReviewGetResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ReviewGetResponseFromRaw : IFromRawJson<ReviewGetResponse>
{
    /// <inheritdoc/>
    public ReviewGetResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ReviewGetResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    public required PaykeyDetails PaykeyDetails
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<PaykeyDetails>("paykey_details");
        }
        init { this._rawData.Set("paykey_details", value); }
    }

    public VerificationDetails? VerificationDetails
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<VerificationDetails>("verification_details");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("verification_details", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.PaykeyDetails.Validate();
        this.VerificationDetails?.Validate();
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

    [SetsRequiredMembers]
    public Data(PaykeyDetails paykeyDetails)
        : this()
    {
        this.PaykeyDetails = paykeyDetails;
    }
}

class DataFromRaw : IFromRawJson<Data>
{
    /// <inheritdoc/>
    public Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Data.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<PaykeyDetails, PaykeyDetailsFromRaw>))]
public sealed record class PaykeyDetails : JsonModel
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
    /// Human-readable label used to represent this paykey in a UI.
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

    public required ApiEnum<string, Source> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Source>>("source");
        }
        init { this._rawData.Set("source", value); }
    }

    public required ApiEnum<string, PaykeyDetailsStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, PaykeyDetailsStatus>>("status");
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

    public PaykeyDetails() { }

    public PaykeyDetails(PaykeyDetails paykeyDetails)
        : base(paykeyDetails) { }

    public PaykeyDetails(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyDetails(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyDetailsFromRaw.FromRawUnchecked"/>
    public static PaykeyDetails FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeyDetailsFromRaw : IFromRawJson<PaykeyDetails>
{
    /// <inheritdoc/>
    public PaykeyDetails FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        PaykeyDetails.FromRawUnchecked(rawData);
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

[JsonConverter(typeof(PaykeyDetailsStatusConverter))]
public enum PaykeyDetailsStatus
{
    Pending,
    Active,
    Inactive,
    Rejected,
    Review,
    Blocked,
}

sealed class PaykeyDetailsStatusConverter : JsonConverter<PaykeyDetailsStatus>
{
    public override PaykeyDetailsStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => PaykeyDetailsStatus.Pending,
            "active" => PaykeyDetailsStatus.Active,
            "inactive" => PaykeyDetailsStatus.Inactive,
            "rejected" => PaykeyDetailsStatus.Rejected,
            "review" => PaykeyDetailsStatus.Review,
            "blocked" => PaykeyDetailsStatus.Blocked,
            _ => (PaykeyDetailsStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyDetailsStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyDetailsStatus.Pending => "pending",
                PaykeyDetailsStatus.Active => "active",
                PaykeyDetailsStatus.Inactive => "inactive",
                PaykeyDetailsStatus.Rejected => "rejected",
                PaykeyDetailsStatus.Review => "review",
                PaykeyDetailsStatus.Blocked => "blocked",
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

[JsonConverter(typeof(JsonModelConverter<VerificationDetails, VerificationDetailsFromRaw>))]
public sealed record class VerificationDetails : JsonModel
{
    /// <summary>
    /// Unique identifier for the verification details.
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

    public required Breakdown Breakdown
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<Breakdown>("breakdown");
        }
        init { this._rawData.Set("breakdown", value); }
    }

    /// <summary>
    /// Timestamp of when the verification was initiated.
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

    public required ApiEnum<string, VerificationDetailsDecision> Decision
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, VerificationDetailsDecision>>(
                "decision"
            );
        }
        init { this._rawData.Set("decision", value); }
    }

    /// <summary>
    /// Dictionary of all messages from the paykey verification process.
    /// </summary>
    public required IReadOnlyDictionary<string, string> Messages
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<FrozenDictionary<string, string>>("messages");
        }
        init
        {
            this._rawData.Set<FrozenDictionary<string, string>>(
                "messages",
                FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    /// <summary>
    /// Timestamp of the most recent update to the verification details.
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        this.Breakdown.Validate();
        _ = this.CreatedAt;
        this.Decision.Validate();
        _ = this.Messages;
        _ = this.UpdatedAt;
    }

    public VerificationDetails() { }

    public VerificationDetails(VerificationDetails verificationDetails)
        : base(verificationDetails) { }

    public VerificationDetails(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    VerificationDetails(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="VerificationDetailsFromRaw.FromRawUnchecked"/>
    public static VerificationDetails FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class VerificationDetailsFromRaw : IFromRawJson<VerificationDetails>
{
    /// <inheritdoc/>
    public VerificationDetails FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        VerificationDetails.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Breakdown, BreakdownFromRaw>))]
public sealed record class Breakdown : JsonModel
{
    public AccountValidation? AccountValidation
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AccountValidation>("account_validation");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("account_validation", value);
        }
    }

    public NameMatch? NameMatch
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<NameMatch>("name_match");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("name_match", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.AccountValidation?.Validate();
        this.NameMatch?.Validate();
    }

    public Breakdown() { }

    public Breakdown(Breakdown breakdown)
        : base(breakdown) { }

    public Breakdown(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Breakdown(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="BreakdownFromRaw.FromRawUnchecked"/>
    public static Breakdown FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class BreakdownFromRaw : IFromRawJson<Breakdown>
{
    /// <inheritdoc/>
    public Breakdown FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Breakdown.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<AccountValidation, AccountValidationFromRaw>))]
public sealed record class AccountValidation : JsonModel
{
    public required IReadOnlyList<string> Codes
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<ImmutableArray<string>>("codes");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>>(
                "codes",
                ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public required ApiEnum<string, Decision> Decision
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Decision>>("decision");
        }
        init { this._rawData.Set("decision", value); }
    }

    public string? Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("reason");
        }
        init { this._rawData.Set("reason", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Codes;
        this.Decision.Validate();
        _ = this.Reason;
    }

    public AccountValidation() { }

    public AccountValidation(AccountValidation accountValidation)
        : base(accountValidation) { }

    public AccountValidation(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountValidation(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountValidationFromRaw.FromRawUnchecked"/>
    public static AccountValidation FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountValidationFromRaw : IFromRawJson<AccountValidation>
{
    /// <inheritdoc/>
    public AccountValidation FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        AccountValidation.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(DecisionConverter))]
public enum Decision
{
    Accept,
    Reject,
    Review,
}

sealed class DecisionConverter : JsonConverter<Decision>
{
    public override Decision Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "accept" => Decision.Accept,
            "reject" => Decision.Reject,
            "review" => Decision.Review,
            _ => (Decision)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Decision value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Decision.Accept => "accept",
                Decision.Reject => "reject",
                Decision.Review => "review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<NameMatch, NameMatchFromRaw>))]
public sealed record class NameMatch : JsonModel
{
    public required IReadOnlyList<string> Codes
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<ImmutableArray<string>>("codes");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>>(
                "codes",
                ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public required ApiEnum<string, NameMatchDecision> Decision
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, NameMatchDecision>>("decision");
        }
        init { this._rawData.Set("decision", value); }
    }

    public double? CorrelationScore
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("correlation_score");
        }
        init { this._rawData.Set("correlation_score", value); }
    }

    public string? CustomerName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("customer_name");
        }
        init { this._rawData.Set("customer_name", value); }
    }

    public string? MatchedName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("matched_name");
        }
        init { this._rawData.Set("matched_name", value); }
    }

    public IReadOnlyList<string>? NamesOnAccount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("names_on_account");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>?>(
                "names_on_account",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public string? Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("reason");
        }
        init { this._rawData.Set("reason", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Codes;
        this.Decision.Validate();
        _ = this.CorrelationScore;
        _ = this.CustomerName;
        _ = this.MatchedName;
        _ = this.NamesOnAccount;
        _ = this.Reason;
    }

    public NameMatch() { }

    public NameMatch(NameMatch nameMatch)
        : base(nameMatch) { }

    public NameMatch(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    NameMatch(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="NameMatchFromRaw.FromRawUnchecked"/>
    public static NameMatch FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class NameMatchFromRaw : IFromRawJson<NameMatch>
{
    /// <inheritdoc/>
    public NameMatch FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        NameMatch.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(NameMatchDecisionConverter))]
public enum NameMatchDecision
{
    Accept,
    Reject,
    Review,
}

sealed class NameMatchDecisionConverter : JsonConverter<NameMatchDecision>
{
    public override NameMatchDecision Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "accept" => NameMatchDecision.Accept,
            "reject" => NameMatchDecision.Reject,
            "review" => NameMatchDecision.Review,
            _ => (NameMatchDecision)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        NameMatchDecision value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                NameMatchDecision.Accept => "accept",
                NameMatchDecision.Reject => "reject",
                NameMatchDecision.Review => "review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(VerificationDetailsDecisionConverter))]
public enum VerificationDetailsDecision
{
    Accept,
    Reject,
    Review,
}

sealed class VerificationDetailsDecisionConverter : JsonConverter<VerificationDetailsDecision>
{
    public override VerificationDetailsDecision Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "accept" => VerificationDetailsDecision.Accept,
            "reject" => VerificationDetailsDecision.Reject,
            "review" => VerificationDetailsDecision.Review,
            _ => (VerificationDetailsDecision)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        VerificationDetailsDecision value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                VerificationDetailsDecision.Accept => "accept",
                VerificationDetailsDecision.Reject => "reject",
                VerificationDetailsDecision.Review => "review",
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
