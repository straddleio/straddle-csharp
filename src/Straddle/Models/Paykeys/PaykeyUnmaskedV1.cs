using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Paykeys;

[JsonConverter(typeof(JsonModelConverter<PaykeyUnmaskedV1, PaykeyUnmaskedV1FromRaw>))]
public sealed record class PaykeyUnmaskedV1 : JsonModel
{
    public required PaykeyUnmaskedV1Data Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<PaykeyUnmaskedV1Data>("data");
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
    public required ApiEnum<string, PaykeyUnmaskedV1ResponseType> ResponseType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, PaykeyUnmaskedV1ResponseType>>(
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

    public PaykeyUnmaskedV1() { }

    public PaykeyUnmaskedV1(PaykeyUnmaskedV1 paykeyUnmaskedV1)
        : base(paykeyUnmaskedV1) { }

    public PaykeyUnmaskedV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyUnmaskedV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyUnmaskedV1FromRaw.FromRawUnchecked"/>
    public static PaykeyUnmaskedV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeyUnmaskedV1FromRaw : IFromRawJson<PaykeyUnmaskedV1>
{
    /// <inheritdoc/>
    public PaykeyUnmaskedV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        PaykeyUnmaskedV1.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<PaykeyUnmaskedV1Data, PaykeyUnmaskedV1DataFromRaw>))]
public sealed record class PaykeyUnmaskedV1Data : JsonModel
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

    public required PaykeyUnmaskedV1DataConfig Config
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<PaykeyUnmaskedV1DataConfig>("config");
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

    public required ApiEnum<string, PaykeyUnmaskedV1DataSource> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, PaykeyUnmaskedV1DataSource>>(
                "source"
            );
        }
        init { this._rawData.Set("source", value); }
    }

    public required ApiEnum<string, PaykeyUnmaskedV1DataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, PaykeyUnmaskedV1DataStatus>>(
                "status"
            );
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

    public PaykeyUnmaskedV1DataBankData? BankData
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<PaykeyUnmaskedV1DataBankData>("bank_data");
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

    public PaykeyUnmaskedV1DataStatusDetails? StatusDetails
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<PaykeyUnmaskedV1DataStatusDetails>(
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

    public PaykeyUnmaskedV1Data() { }

    public PaykeyUnmaskedV1Data(PaykeyUnmaskedV1Data paykeyUnmaskedV1Data)
        : base(paykeyUnmaskedV1Data) { }

    public PaykeyUnmaskedV1Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyUnmaskedV1Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyUnmaskedV1DataFromRaw.FromRawUnchecked"/>
    public static PaykeyUnmaskedV1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeyUnmaskedV1DataFromRaw : IFromRawJson<PaykeyUnmaskedV1Data>
{
    /// <inheritdoc/>
    public PaykeyUnmaskedV1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PaykeyUnmaskedV1Data.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<PaykeyUnmaskedV1DataConfig, PaykeyUnmaskedV1DataConfigFromRaw>)
)]
public sealed record class PaykeyUnmaskedV1DataConfig : JsonModel
{
    public ApiEnum<string, PaykeyUnmaskedV1DataConfigProcessingMethod>? ProcessingMethod
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, PaykeyUnmaskedV1DataConfigProcessingMethod>
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

    public ApiEnum<string, PaykeyUnmaskedV1DataConfigSandboxOutcome>? SandboxOutcome
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, PaykeyUnmaskedV1DataConfigSandboxOutcome>
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

    public PaykeyUnmaskedV1DataConfig() { }

    public PaykeyUnmaskedV1DataConfig(PaykeyUnmaskedV1DataConfig paykeyUnmaskedV1DataConfig)
        : base(paykeyUnmaskedV1DataConfig) { }

    public PaykeyUnmaskedV1DataConfig(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyUnmaskedV1DataConfig(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyUnmaskedV1DataConfigFromRaw.FromRawUnchecked"/>
    public static PaykeyUnmaskedV1DataConfig FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeyUnmaskedV1DataConfigFromRaw : IFromRawJson<PaykeyUnmaskedV1DataConfig>
{
    /// <inheritdoc/>
    public PaykeyUnmaskedV1DataConfig FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PaykeyUnmaskedV1DataConfig.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(PaykeyUnmaskedV1DataConfigProcessingMethodConverter))]
public enum PaykeyUnmaskedV1DataConfigProcessingMethod
{
    Inline,
    Background,
    Skip,
}

sealed class PaykeyUnmaskedV1DataConfigProcessingMethodConverter
    : JsonConverter<PaykeyUnmaskedV1DataConfigProcessingMethod>
{
    public override PaykeyUnmaskedV1DataConfigProcessingMethod Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "inline" => PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
            "background" => PaykeyUnmaskedV1DataConfigProcessingMethod.Background,
            "skip" => PaykeyUnmaskedV1DataConfigProcessingMethod.Skip,
            _ => (PaykeyUnmaskedV1DataConfigProcessingMethod)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyUnmaskedV1DataConfigProcessingMethod value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyUnmaskedV1DataConfigProcessingMethod.Inline => "inline",
                PaykeyUnmaskedV1DataConfigProcessingMethod.Background => "background",
                PaykeyUnmaskedV1DataConfigProcessingMethod.Skip => "skip",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(PaykeyUnmaskedV1DataConfigSandboxOutcomeConverter))]
public enum PaykeyUnmaskedV1DataConfigSandboxOutcome
{
    Standard,
    Active,
    Rejected,
    Review,
}

sealed class PaykeyUnmaskedV1DataConfigSandboxOutcomeConverter
    : JsonConverter<PaykeyUnmaskedV1DataConfigSandboxOutcome>
{
    public override PaykeyUnmaskedV1DataConfigSandboxOutcome Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "standard" => PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
            "active" => PaykeyUnmaskedV1DataConfigSandboxOutcome.Active,
            "rejected" => PaykeyUnmaskedV1DataConfigSandboxOutcome.Rejected,
            "review" => PaykeyUnmaskedV1DataConfigSandboxOutcome.Review,
            _ => (PaykeyUnmaskedV1DataConfigSandboxOutcome)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyUnmaskedV1DataConfigSandboxOutcome value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard => "standard",
                PaykeyUnmaskedV1DataConfigSandboxOutcome.Active => "active",
                PaykeyUnmaskedV1DataConfigSandboxOutcome.Rejected => "rejected",
                PaykeyUnmaskedV1DataConfigSandboxOutcome.Review => "review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(PaykeyUnmaskedV1DataSourceConverter))]
public enum PaykeyUnmaskedV1DataSource
{
    BankAccount,
    Straddle,
    Mx,
    Plaid,
    Tan,
    Quiltt,
}

sealed class PaykeyUnmaskedV1DataSourceConverter : JsonConverter<PaykeyUnmaskedV1DataSource>
{
    public override PaykeyUnmaskedV1DataSource Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "bank_account" => PaykeyUnmaskedV1DataSource.BankAccount,
            "straddle" => PaykeyUnmaskedV1DataSource.Straddle,
            "mx" => PaykeyUnmaskedV1DataSource.Mx,
            "plaid" => PaykeyUnmaskedV1DataSource.Plaid,
            "tan" => PaykeyUnmaskedV1DataSource.Tan,
            "quiltt" => PaykeyUnmaskedV1DataSource.Quiltt,
            _ => (PaykeyUnmaskedV1DataSource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyUnmaskedV1DataSource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyUnmaskedV1DataSource.BankAccount => "bank_account",
                PaykeyUnmaskedV1DataSource.Straddle => "straddle",
                PaykeyUnmaskedV1DataSource.Mx => "mx",
                PaykeyUnmaskedV1DataSource.Plaid => "plaid",
                PaykeyUnmaskedV1DataSource.Tan => "tan",
                PaykeyUnmaskedV1DataSource.Quiltt => "quiltt",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(PaykeyUnmaskedV1DataStatusConverter))]
public enum PaykeyUnmaskedV1DataStatus
{
    Pending,
    Active,
    Inactive,
    Rejected,
    Review,
    Blocked,
}

sealed class PaykeyUnmaskedV1DataStatusConverter : JsonConverter<PaykeyUnmaskedV1DataStatus>
{
    public override PaykeyUnmaskedV1DataStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => PaykeyUnmaskedV1DataStatus.Pending,
            "active" => PaykeyUnmaskedV1DataStatus.Active,
            "inactive" => PaykeyUnmaskedV1DataStatus.Inactive,
            "rejected" => PaykeyUnmaskedV1DataStatus.Rejected,
            "review" => PaykeyUnmaskedV1DataStatus.Review,
            "blocked" => PaykeyUnmaskedV1DataStatus.Blocked,
            _ => (PaykeyUnmaskedV1DataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyUnmaskedV1DataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyUnmaskedV1DataStatus.Pending => "pending",
                PaykeyUnmaskedV1DataStatus.Active => "active",
                PaykeyUnmaskedV1DataStatus.Inactive => "inactive",
                PaykeyUnmaskedV1DataStatus.Rejected => "rejected",
                PaykeyUnmaskedV1DataStatus.Review => "review",
                PaykeyUnmaskedV1DataStatus.Blocked => "blocked",
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

[JsonConverter(
    typeof(JsonModelConverter<PaykeyUnmaskedV1DataBankData, PaykeyUnmaskedV1DataBankDataFromRaw>)
)]
public sealed record class PaykeyUnmaskedV1DataBankData : JsonModel
{
    /// <summary>
    /// The bank account number
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

    public required ApiEnum<string, PaykeyUnmaskedV1DataBankDataAccountType> AccountType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, PaykeyUnmaskedV1DataBankDataAccountType>
            >("account_type");
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

    public PaykeyUnmaskedV1DataBankData() { }

    public PaykeyUnmaskedV1DataBankData(PaykeyUnmaskedV1DataBankData paykeyUnmaskedV1DataBankData)
        : base(paykeyUnmaskedV1DataBankData) { }

    public PaykeyUnmaskedV1DataBankData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyUnmaskedV1DataBankData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyUnmaskedV1DataBankDataFromRaw.FromRawUnchecked"/>
    public static PaykeyUnmaskedV1DataBankData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeyUnmaskedV1DataBankDataFromRaw : IFromRawJson<PaykeyUnmaskedV1DataBankData>
{
    /// <inheritdoc/>
    public PaykeyUnmaskedV1DataBankData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PaykeyUnmaskedV1DataBankData.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(PaykeyUnmaskedV1DataBankDataAccountTypeConverter))]
public enum PaykeyUnmaskedV1DataBankDataAccountType
{
    Checking,
    Savings,
}

sealed class PaykeyUnmaskedV1DataBankDataAccountTypeConverter
    : JsonConverter<PaykeyUnmaskedV1DataBankDataAccountType>
{
    public override PaykeyUnmaskedV1DataBankDataAccountType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "checking" => PaykeyUnmaskedV1DataBankDataAccountType.Checking,
            "savings" => PaykeyUnmaskedV1DataBankDataAccountType.Savings,
            _ => (PaykeyUnmaskedV1DataBankDataAccountType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyUnmaskedV1DataBankDataAccountType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyUnmaskedV1DataBankDataAccountType.Checking => "checking",
                PaykeyUnmaskedV1DataBankDataAccountType.Savings => "savings",
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
        PaykeyUnmaskedV1DataStatusDetails,
        PaykeyUnmaskedV1DataStatusDetailsFromRaw
    >)
)]
public sealed record class PaykeyUnmaskedV1DataStatusDetails : JsonModel
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

    public required ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsReason> Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsReason>
            >("reason");
        }
        init { this._rawData.Set("reason", value); }
    }

    public required ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsSource> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsSource>
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

    public PaykeyUnmaskedV1DataStatusDetails() { }

    public PaykeyUnmaskedV1DataStatusDetails(
        PaykeyUnmaskedV1DataStatusDetails paykeyUnmaskedV1DataStatusDetails
    )
        : base(paykeyUnmaskedV1DataStatusDetails) { }

    public PaykeyUnmaskedV1DataStatusDetails(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyUnmaskedV1DataStatusDetails(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyUnmaskedV1DataStatusDetailsFromRaw.FromRawUnchecked"/>
    public static PaykeyUnmaskedV1DataStatusDetails FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeyUnmaskedV1DataStatusDetailsFromRaw : IFromRawJson<PaykeyUnmaskedV1DataStatusDetails>
{
    /// <inheritdoc/>
    public PaykeyUnmaskedV1DataStatusDetails FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PaykeyUnmaskedV1DataStatusDetails.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(PaykeyUnmaskedV1DataStatusDetailsReasonConverter))]
public enum PaykeyUnmaskedV1DataStatusDetailsReason
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

sealed class PaykeyUnmaskedV1DataStatusDetailsReasonConverter
    : JsonConverter<PaykeyUnmaskedV1DataStatusDetailsReason>
{
    public override PaykeyUnmaskedV1DataStatusDetailsReason Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "insufficient_funds" => PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
            "closed_bank_account" => PaykeyUnmaskedV1DataStatusDetailsReason.ClosedBankAccount,
            "invalid_bank_account" => PaykeyUnmaskedV1DataStatusDetailsReason.InvalidBankAccount,
            "invalid_routing" => PaykeyUnmaskedV1DataStatusDetailsReason.InvalidRouting,
            "disputed" => PaykeyUnmaskedV1DataStatusDetailsReason.Disputed,
            "payment_stopped" => PaykeyUnmaskedV1DataStatusDetailsReason.PaymentStopped,
            "owner_deceased" => PaykeyUnmaskedV1DataStatusDetailsReason.OwnerDeceased,
            "frozen_bank_account" => PaykeyUnmaskedV1DataStatusDetailsReason.FrozenBankAccount,
            "risk_review" => PaykeyUnmaskedV1DataStatusDetailsReason.RiskReview,
            "fraudulent" => PaykeyUnmaskedV1DataStatusDetailsReason.Fraudulent,
            "duplicate_entry" => PaykeyUnmaskedV1DataStatusDetailsReason.DuplicateEntry,
            "invalid_paykey" => PaykeyUnmaskedV1DataStatusDetailsReason.InvalidPaykey,
            "payment_blocked" => PaykeyUnmaskedV1DataStatusDetailsReason.PaymentBlocked,
            "amount_too_large" => PaykeyUnmaskedV1DataStatusDetailsReason.AmountTooLarge,
            "too_many_attempts" => PaykeyUnmaskedV1DataStatusDetailsReason.TooManyAttempts,
            "internal_system_error" => PaykeyUnmaskedV1DataStatusDetailsReason.InternalSystemError,
            "user_request" => PaykeyUnmaskedV1DataStatusDetailsReason.UserRequest,
            "ok" => PaykeyUnmaskedV1DataStatusDetailsReason.Ok,
            "other_network_return" => PaykeyUnmaskedV1DataStatusDetailsReason.OtherNetworkReturn,
            "payout_refused" => PaykeyUnmaskedV1DataStatusDetailsReason.PayoutRefused,
            "cancel_request" => PaykeyUnmaskedV1DataStatusDetailsReason.CancelRequest,
            "failed_verification" => PaykeyUnmaskedV1DataStatusDetailsReason.FailedVerification,
            "require_review" => PaykeyUnmaskedV1DataStatusDetailsReason.RequireReview,
            "blocked_by_system" => PaykeyUnmaskedV1DataStatusDetailsReason.BlockedBySystem,
            "watchtower_review" => PaykeyUnmaskedV1DataStatusDetailsReason.WatchtowerReview,
            _ => (PaykeyUnmaskedV1DataStatusDetailsReason)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyUnmaskedV1DataStatusDetailsReason value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds => "insufficient_funds",
                PaykeyUnmaskedV1DataStatusDetailsReason.ClosedBankAccount => "closed_bank_account",
                PaykeyUnmaskedV1DataStatusDetailsReason.InvalidBankAccount =>
                    "invalid_bank_account",
                PaykeyUnmaskedV1DataStatusDetailsReason.InvalidRouting => "invalid_routing",
                PaykeyUnmaskedV1DataStatusDetailsReason.Disputed => "disputed",
                PaykeyUnmaskedV1DataStatusDetailsReason.PaymentStopped => "payment_stopped",
                PaykeyUnmaskedV1DataStatusDetailsReason.OwnerDeceased => "owner_deceased",
                PaykeyUnmaskedV1DataStatusDetailsReason.FrozenBankAccount => "frozen_bank_account",
                PaykeyUnmaskedV1DataStatusDetailsReason.RiskReview => "risk_review",
                PaykeyUnmaskedV1DataStatusDetailsReason.Fraudulent => "fraudulent",
                PaykeyUnmaskedV1DataStatusDetailsReason.DuplicateEntry => "duplicate_entry",
                PaykeyUnmaskedV1DataStatusDetailsReason.InvalidPaykey => "invalid_paykey",
                PaykeyUnmaskedV1DataStatusDetailsReason.PaymentBlocked => "payment_blocked",
                PaykeyUnmaskedV1DataStatusDetailsReason.AmountTooLarge => "amount_too_large",
                PaykeyUnmaskedV1DataStatusDetailsReason.TooManyAttempts => "too_many_attempts",
                PaykeyUnmaskedV1DataStatusDetailsReason.InternalSystemError =>
                    "internal_system_error",
                PaykeyUnmaskedV1DataStatusDetailsReason.UserRequest => "user_request",
                PaykeyUnmaskedV1DataStatusDetailsReason.Ok => "ok",
                PaykeyUnmaskedV1DataStatusDetailsReason.OtherNetworkReturn =>
                    "other_network_return",
                PaykeyUnmaskedV1DataStatusDetailsReason.PayoutRefused => "payout_refused",
                PaykeyUnmaskedV1DataStatusDetailsReason.CancelRequest => "cancel_request",
                PaykeyUnmaskedV1DataStatusDetailsReason.FailedVerification => "failed_verification",
                PaykeyUnmaskedV1DataStatusDetailsReason.RequireReview => "require_review",
                PaykeyUnmaskedV1DataStatusDetailsReason.BlockedBySystem => "blocked_by_system",
                PaykeyUnmaskedV1DataStatusDetailsReason.WatchtowerReview => "watchtower_review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(PaykeyUnmaskedV1DataStatusDetailsSourceConverter))]
public enum PaykeyUnmaskedV1DataStatusDetailsSource
{
    Watchtower,
    BankDecline,
    CustomerDispute,
    UserAction,
    System,
}

sealed class PaykeyUnmaskedV1DataStatusDetailsSourceConverter
    : JsonConverter<PaykeyUnmaskedV1DataStatusDetailsSource>
{
    public override PaykeyUnmaskedV1DataStatusDetailsSource Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "watchtower" => PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
            "bank_decline" => PaykeyUnmaskedV1DataStatusDetailsSource.BankDecline,
            "customer_dispute" => PaykeyUnmaskedV1DataStatusDetailsSource.CustomerDispute,
            "user_action" => PaykeyUnmaskedV1DataStatusDetailsSource.UserAction,
            "system" => PaykeyUnmaskedV1DataStatusDetailsSource.System,
            _ => (PaykeyUnmaskedV1DataStatusDetailsSource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyUnmaskedV1DataStatusDetailsSource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower => "watchtower",
                PaykeyUnmaskedV1DataStatusDetailsSource.BankDecline => "bank_decline",
                PaykeyUnmaskedV1DataStatusDetailsSource.CustomerDispute => "customer_dispute",
                PaykeyUnmaskedV1DataStatusDetailsSource.UserAction => "user_action",
                PaykeyUnmaskedV1DataStatusDetailsSource.System => "system",
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
[JsonConverter(typeof(PaykeyUnmaskedV1ResponseTypeConverter))]
public enum PaykeyUnmaskedV1ResponseType
{
    Object,
    Array,
    Error,
    None,
}

sealed class PaykeyUnmaskedV1ResponseTypeConverter : JsonConverter<PaykeyUnmaskedV1ResponseType>
{
    public override PaykeyUnmaskedV1ResponseType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "object" => PaykeyUnmaskedV1ResponseType.Object,
            "array" => PaykeyUnmaskedV1ResponseType.Array,
            "error" => PaykeyUnmaskedV1ResponseType.Error,
            "none" => PaykeyUnmaskedV1ResponseType.None,
            _ => (PaykeyUnmaskedV1ResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyUnmaskedV1ResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyUnmaskedV1ResponseType.Object => "object",
                PaykeyUnmaskedV1ResponseType.Array => "array",
                PaykeyUnmaskedV1ResponseType.Error => "error",
                PaykeyUnmaskedV1ResponseType.None => "none",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
