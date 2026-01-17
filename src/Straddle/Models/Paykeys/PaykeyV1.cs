using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Paykeys;

[JsonConverter(typeof(JsonModelConverter<PaykeyV1, PaykeyV1FromRaw>))]
public sealed record class PaykeyV1 : JsonModel
{
    public required PaykeyV1Data Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<PaykeyV1Data>("data");
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
    public required ApiEnum<string, PaykeyV1ResponseType> ResponseType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, PaykeyV1ResponseType>>(
                "response_type"
            );
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

    public PaykeyV1() { }

    public PaykeyV1(PaykeyV1 paykeyV1)
        : base(paykeyV1) { }

    public PaykeyV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyV1FromRaw.FromRawUnchecked"/>
    public static PaykeyV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeyV1FromRaw : IFromRawJson<PaykeyV1>
{
    /// <inheritdoc/>
    public PaykeyV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        PaykeyV1.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<PaykeyV1Data, PaykeyV1DataFromRaw>))]
public sealed record class PaykeyV1Data : JsonModel
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

    public required PaykeyV1DataConfig Config
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<PaykeyV1DataConfig>("config");
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

    public required ApiEnum<string, PaykeyV1DataSource> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, PaykeyV1DataSource>>("source");
        }
        init { this._rawData.Set("source", value); }
    }

    public required ApiEnum<string, PaykeyV1DataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, PaykeyV1DataStatus>>("status");
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

    public PaykeyV1DataBalance? Balance
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<PaykeyV1DataBalance>("balance");
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

    public PaykeyV1DataBankData? BankData
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<PaykeyV1DataBankData>("bank_data");
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

    public PaykeyV1DataStatusDetails? StatusDetails
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<PaykeyV1DataStatusDetails>("status_details");
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

    public PaykeyV1Data() { }

    public PaykeyV1Data(PaykeyV1Data paykeyV1Data)
        : base(paykeyV1Data) { }

    public PaykeyV1Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyV1Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyV1DataFromRaw.FromRawUnchecked"/>
    public static PaykeyV1Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeyV1DataFromRaw : IFromRawJson<PaykeyV1Data>
{
    /// <inheritdoc/>
    public PaykeyV1Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        PaykeyV1Data.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<PaykeyV1DataConfig, PaykeyV1DataConfigFromRaw>))]
public sealed record class PaykeyV1DataConfig : JsonModel
{
    public ApiEnum<string, PaykeyV1DataConfigProcessingMethod>? ProcessingMethod
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, PaykeyV1DataConfigProcessingMethod>
            >("processing_method");
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

    public ApiEnum<string, PaykeyV1DataConfigSandboxOutcome>? SandboxOutcome
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, PaykeyV1DataConfigSandboxOutcome>
            >("sandbox_outcome");
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

    public PaykeyV1DataConfig() { }

    public PaykeyV1DataConfig(PaykeyV1DataConfig paykeyV1DataConfig)
        : base(paykeyV1DataConfig) { }

    public PaykeyV1DataConfig(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyV1DataConfig(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyV1DataConfigFromRaw.FromRawUnchecked"/>
    public static PaykeyV1DataConfig FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeyV1DataConfigFromRaw : IFromRawJson<PaykeyV1DataConfig>
{
    /// <inheritdoc/>
    public PaykeyV1DataConfig FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        PaykeyV1DataConfig.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(PaykeyV1DataConfigProcessingMethodConverter))]
public enum PaykeyV1DataConfigProcessingMethod
{
    Inline,
    Background,
    Skip,
}

sealed class PaykeyV1DataConfigProcessingMethodConverter
    : JsonConverter<PaykeyV1DataConfigProcessingMethod>
{
    public override PaykeyV1DataConfigProcessingMethod Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "inline" => PaykeyV1DataConfigProcessingMethod.Inline,
            "background" => PaykeyV1DataConfigProcessingMethod.Background,
            "skip" => PaykeyV1DataConfigProcessingMethod.Skip,
            _ => (PaykeyV1DataConfigProcessingMethod)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyV1DataConfigProcessingMethod value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyV1DataConfigProcessingMethod.Inline => "inline",
                PaykeyV1DataConfigProcessingMethod.Background => "background",
                PaykeyV1DataConfigProcessingMethod.Skip => "skip",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(PaykeyV1DataConfigSandboxOutcomeConverter))]
public enum PaykeyV1DataConfigSandboxOutcome
{
    Standard,
    Active,
    Rejected,
    Review,
}

sealed class PaykeyV1DataConfigSandboxOutcomeConverter
    : JsonConverter<PaykeyV1DataConfigSandboxOutcome>
{
    public override PaykeyV1DataConfigSandboxOutcome Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "standard" => PaykeyV1DataConfigSandboxOutcome.Standard,
            "active" => PaykeyV1DataConfigSandboxOutcome.Active,
            "rejected" => PaykeyV1DataConfigSandboxOutcome.Rejected,
            "review" => PaykeyV1DataConfigSandboxOutcome.Review,
            _ => (PaykeyV1DataConfigSandboxOutcome)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyV1DataConfigSandboxOutcome value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyV1DataConfigSandboxOutcome.Standard => "standard",
                PaykeyV1DataConfigSandboxOutcome.Active => "active",
                PaykeyV1DataConfigSandboxOutcome.Rejected => "rejected",
                PaykeyV1DataConfigSandboxOutcome.Review => "review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(PaykeyV1DataSourceConverter))]
public enum PaykeyV1DataSource
{
    BankAccount,
    Straddle,
    Mx,
    Plaid,
    Tan,
    Quiltt,
}

sealed class PaykeyV1DataSourceConverter : JsonConverter<PaykeyV1DataSource>
{
    public override PaykeyV1DataSource Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "bank_account" => PaykeyV1DataSource.BankAccount,
            "straddle" => PaykeyV1DataSource.Straddle,
            "mx" => PaykeyV1DataSource.Mx,
            "plaid" => PaykeyV1DataSource.Plaid,
            "tan" => PaykeyV1DataSource.Tan,
            "quiltt" => PaykeyV1DataSource.Quiltt,
            _ => (PaykeyV1DataSource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyV1DataSource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyV1DataSource.BankAccount => "bank_account",
                PaykeyV1DataSource.Straddle => "straddle",
                PaykeyV1DataSource.Mx => "mx",
                PaykeyV1DataSource.Plaid => "plaid",
                PaykeyV1DataSource.Tan => "tan",
                PaykeyV1DataSource.Quiltt => "quiltt",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(PaykeyV1DataStatusConverter))]
public enum PaykeyV1DataStatus
{
    Pending,
    Active,
    Inactive,
    Rejected,
    Review,
    Blocked,
}

sealed class PaykeyV1DataStatusConverter : JsonConverter<PaykeyV1DataStatus>
{
    public override PaykeyV1DataStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => PaykeyV1DataStatus.Pending,
            "active" => PaykeyV1DataStatus.Active,
            "inactive" => PaykeyV1DataStatus.Inactive,
            "rejected" => PaykeyV1DataStatus.Rejected,
            "review" => PaykeyV1DataStatus.Review,
            "blocked" => PaykeyV1DataStatus.Blocked,
            _ => (PaykeyV1DataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyV1DataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyV1DataStatus.Pending => "pending",
                PaykeyV1DataStatus.Active => "active",
                PaykeyV1DataStatus.Inactive => "inactive",
                PaykeyV1DataStatus.Rejected => "rejected",
                PaykeyV1DataStatus.Review => "review",
                PaykeyV1DataStatus.Blocked => "blocked",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<PaykeyV1DataBalance, PaykeyV1DataBalanceFromRaw>))]
public sealed record class PaykeyV1DataBalance : JsonModel
{
    public required ApiEnum<string, PaykeyV1DataBalanceStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, PaykeyV1DataBalanceStatus>>(
                "status"
            );
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

    public PaykeyV1DataBalance() { }

    public PaykeyV1DataBalance(PaykeyV1DataBalance paykeyV1DataBalance)
        : base(paykeyV1DataBalance) { }

    public PaykeyV1DataBalance(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyV1DataBalance(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyV1DataBalanceFromRaw.FromRawUnchecked"/>
    public static PaykeyV1DataBalance FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public PaykeyV1DataBalance(ApiEnum<string, PaykeyV1DataBalanceStatus> status)
        : this()
    {
        this.Status = status;
    }
}

class PaykeyV1DataBalanceFromRaw : IFromRawJson<PaykeyV1DataBalance>
{
    /// <inheritdoc/>
    public PaykeyV1DataBalance FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        PaykeyV1DataBalance.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(PaykeyV1DataBalanceStatusConverter))]
public enum PaykeyV1DataBalanceStatus
{
    Pending,
    Completed,
    Failed,
}

sealed class PaykeyV1DataBalanceStatusConverter : JsonConverter<PaykeyV1DataBalanceStatus>
{
    public override PaykeyV1DataBalanceStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => PaykeyV1DataBalanceStatus.Pending,
            "completed" => PaykeyV1DataBalanceStatus.Completed,
            "failed" => PaykeyV1DataBalanceStatus.Failed,
            _ => (PaykeyV1DataBalanceStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyV1DataBalanceStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyV1DataBalanceStatus.Pending => "pending",
                PaykeyV1DataBalanceStatus.Completed => "completed",
                PaykeyV1DataBalanceStatus.Failed => "failed",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<PaykeyV1DataBankData, PaykeyV1DataBankDataFromRaw>))]
public sealed record class PaykeyV1DataBankData : JsonModel
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

    public required ApiEnum<string, PaykeyV1DataBankDataAccountType> AccountType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, PaykeyV1DataBankDataAccountType>>(
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

    public PaykeyV1DataBankData() { }

    public PaykeyV1DataBankData(PaykeyV1DataBankData paykeyV1DataBankData)
        : base(paykeyV1DataBankData) { }

    public PaykeyV1DataBankData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyV1DataBankData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyV1DataBankDataFromRaw.FromRawUnchecked"/>
    public static PaykeyV1DataBankData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeyV1DataBankDataFromRaw : IFromRawJson<PaykeyV1DataBankData>
{
    /// <inheritdoc/>
    public PaykeyV1DataBankData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PaykeyV1DataBankData.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(PaykeyV1DataBankDataAccountTypeConverter))]
public enum PaykeyV1DataBankDataAccountType
{
    Checking,
    Savings,
}

sealed class PaykeyV1DataBankDataAccountTypeConverter
    : JsonConverter<PaykeyV1DataBankDataAccountType>
{
    public override PaykeyV1DataBankDataAccountType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "checking" => PaykeyV1DataBankDataAccountType.Checking,
            "savings" => PaykeyV1DataBankDataAccountType.Savings,
            _ => (PaykeyV1DataBankDataAccountType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyV1DataBankDataAccountType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyV1DataBankDataAccountType.Checking => "checking",
                PaykeyV1DataBankDataAccountType.Savings => "savings",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(
    typeof(JsonModelConverter<PaykeyV1DataStatusDetails, PaykeyV1DataStatusDetailsFromRaw>)
)]
public sealed record class PaykeyV1DataStatusDetails : JsonModel
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

    public required ApiEnum<string, PaykeyV1DataStatusDetailsReason> Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, PaykeyV1DataStatusDetailsReason>>(
                "reason"
            );
        }
        init { this._rawData.Set("reason", value); }
    }

    public required ApiEnum<string, PaykeyV1DataStatusDetailsSource> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, PaykeyV1DataStatusDetailsSource>>(
                "source"
            );
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

    public PaykeyV1DataStatusDetails() { }

    public PaykeyV1DataStatusDetails(PaykeyV1DataStatusDetails paykeyV1DataStatusDetails)
        : base(paykeyV1DataStatusDetails) { }

    public PaykeyV1DataStatusDetails(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyV1DataStatusDetails(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyV1DataStatusDetailsFromRaw.FromRawUnchecked"/>
    public static PaykeyV1DataStatusDetails FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeyV1DataStatusDetailsFromRaw : IFromRawJson<PaykeyV1DataStatusDetails>
{
    /// <inheritdoc/>
    public PaykeyV1DataStatusDetails FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PaykeyV1DataStatusDetails.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(PaykeyV1DataStatusDetailsReasonConverter))]
public enum PaykeyV1DataStatusDetailsReason
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

sealed class PaykeyV1DataStatusDetailsReasonConverter
    : JsonConverter<PaykeyV1DataStatusDetailsReason>
{
    public override PaykeyV1DataStatusDetailsReason Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "insufficient_funds" => PaykeyV1DataStatusDetailsReason.InsufficientFunds,
            "closed_bank_account" => PaykeyV1DataStatusDetailsReason.ClosedBankAccount,
            "invalid_bank_account" => PaykeyV1DataStatusDetailsReason.InvalidBankAccount,
            "invalid_routing" => PaykeyV1DataStatusDetailsReason.InvalidRouting,
            "disputed" => PaykeyV1DataStatusDetailsReason.Disputed,
            "payment_stopped" => PaykeyV1DataStatusDetailsReason.PaymentStopped,
            "owner_deceased" => PaykeyV1DataStatusDetailsReason.OwnerDeceased,
            "frozen_bank_account" => PaykeyV1DataStatusDetailsReason.FrozenBankAccount,
            "risk_review" => PaykeyV1DataStatusDetailsReason.RiskReview,
            "fraudulent" => PaykeyV1DataStatusDetailsReason.Fraudulent,
            "duplicate_entry" => PaykeyV1DataStatusDetailsReason.DuplicateEntry,
            "invalid_paykey" => PaykeyV1DataStatusDetailsReason.InvalidPaykey,
            "payment_blocked" => PaykeyV1DataStatusDetailsReason.PaymentBlocked,
            "amount_too_large" => PaykeyV1DataStatusDetailsReason.AmountTooLarge,
            "too_many_attempts" => PaykeyV1DataStatusDetailsReason.TooManyAttempts,
            "internal_system_error" => PaykeyV1DataStatusDetailsReason.InternalSystemError,
            "user_request" => PaykeyV1DataStatusDetailsReason.UserRequest,
            "ok" => PaykeyV1DataStatusDetailsReason.Ok,
            "other_network_return" => PaykeyV1DataStatusDetailsReason.OtherNetworkReturn,
            "payout_refused" => PaykeyV1DataStatusDetailsReason.PayoutRefused,
            "cancel_request" => PaykeyV1DataStatusDetailsReason.CancelRequest,
            "failed_verification" => PaykeyV1DataStatusDetailsReason.FailedVerification,
            "require_review" => PaykeyV1DataStatusDetailsReason.RequireReview,
            "blocked_by_system" => PaykeyV1DataStatusDetailsReason.BlockedBySystem,
            "watchtower_review" => PaykeyV1DataStatusDetailsReason.WatchtowerReview,
            _ => (PaykeyV1DataStatusDetailsReason)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyV1DataStatusDetailsReason value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyV1DataStatusDetailsReason.InsufficientFunds => "insufficient_funds",
                PaykeyV1DataStatusDetailsReason.ClosedBankAccount => "closed_bank_account",
                PaykeyV1DataStatusDetailsReason.InvalidBankAccount => "invalid_bank_account",
                PaykeyV1DataStatusDetailsReason.InvalidRouting => "invalid_routing",
                PaykeyV1DataStatusDetailsReason.Disputed => "disputed",
                PaykeyV1DataStatusDetailsReason.PaymentStopped => "payment_stopped",
                PaykeyV1DataStatusDetailsReason.OwnerDeceased => "owner_deceased",
                PaykeyV1DataStatusDetailsReason.FrozenBankAccount => "frozen_bank_account",
                PaykeyV1DataStatusDetailsReason.RiskReview => "risk_review",
                PaykeyV1DataStatusDetailsReason.Fraudulent => "fraudulent",
                PaykeyV1DataStatusDetailsReason.DuplicateEntry => "duplicate_entry",
                PaykeyV1DataStatusDetailsReason.InvalidPaykey => "invalid_paykey",
                PaykeyV1DataStatusDetailsReason.PaymentBlocked => "payment_blocked",
                PaykeyV1DataStatusDetailsReason.AmountTooLarge => "amount_too_large",
                PaykeyV1DataStatusDetailsReason.TooManyAttempts => "too_many_attempts",
                PaykeyV1DataStatusDetailsReason.InternalSystemError => "internal_system_error",
                PaykeyV1DataStatusDetailsReason.UserRequest => "user_request",
                PaykeyV1DataStatusDetailsReason.Ok => "ok",
                PaykeyV1DataStatusDetailsReason.OtherNetworkReturn => "other_network_return",
                PaykeyV1DataStatusDetailsReason.PayoutRefused => "payout_refused",
                PaykeyV1DataStatusDetailsReason.CancelRequest => "cancel_request",
                PaykeyV1DataStatusDetailsReason.FailedVerification => "failed_verification",
                PaykeyV1DataStatusDetailsReason.RequireReview => "require_review",
                PaykeyV1DataStatusDetailsReason.BlockedBySystem => "blocked_by_system",
                PaykeyV1DataStatusDetailsReason.WatchtowerReview => "watchtower_review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(PaykeyV1DataStatusDetailsSourceConverter))]
public enum PaykeyV1DataStatusDetailsSource
{
    Watchtower,
    BankDecline,
    CustomerDispute,
    UserAction,
    System,
}

sealed class PaykeyV1DataStatusDetailsSourceConverter
    : JsonConverter<PaykeyV1DataStatusDetailsSource>
{
    public override PaykeyV1DataStatusDetailsSource Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "watchtower" => PaykeyV1DataStatusDetailsSource.Watchtower,
            "bank_decline" => PaykeyV1DataStatusDetailsSource.BankDecline,
            "customer_dispute" => PaykeyV1DataStatusDetailsSource.CustomerDispute,
            "user_action" => PaykeyV1DataStatusDetailsSource.UserAction,
            "system" => PaykeyV1DataStatusDetailsSource.System,
            _ => (PaykeyV1DataStatusDetailsSource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyV1DataStatusDetailsSource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyV1DataStatusDetailsSource.Watchtower => "watchtower",
                PaykeyV1DataStatusDetailsSource.BankDecline => "bank_decline",
                PaykeyV1DataStatusDetailsSource.CustomerDispute => "customer_dispute",
                PaykeyV1DataStatusDetailsSource.UserAction => "user_action",
                PaykeyV1DataStatusDetailsSource.System => "system",
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
[JsonConverter(typeof(PaykeyV1ResponseTypeConverter))]
public enum PaykeyV1ResponseType
{
    Object,
    Array,
    Error,
    None,
}

sealed class PaykeyV1ResponseTypeConverter : JsonConverter<PaykeyV1ResponseType>
{
    public override PaykeyV1ResponseType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "object" => PaykeyV1ResponseType.Object,
            "array" => PaykeyV1ResponseType.Array,
            "error" => PaykeyV1ResponseType.Error,
            "none" => PaykeyV1ResponseType.None,
            _ => (PaykeyV1ResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyV1ResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyV1ResponseType.Object => "object",
                PaykeyV1ResponseType.Array => "array",
                PaykeyV1ResponseType.Error => "error",
                PaykeyV1ResponseType.None => "none",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
