using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Paykeys;

[JsonConverter(typeof(JsonModelConverter<PaykeyRevealResponse, PaykeyRevealResponseFromRaw>))]
public sealed record class PaykeyRevealResponse : JsonModel
{
    public required PaykeyRevealResponseData Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<PaykeyRevealResponseData>("data");
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
    public required ApiEnum<string, PaykeyRevealResponseResponseType> ResponseType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, PaykeyRevealResponseResponseType>>(
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

    public PaykeyRevealResponse() { }

    public PaykeyRevealResponse(PaykeyRevealResponse paykeyRevealResponse)
        : base(paykeyRevealResponse) { }

    public PaykeyRevealResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyRevealResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyRevealResponseFromRaw.FromRawUnchecked"/>
    public static PaykeyRevealResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeyRevealResponseFromRaw : IFromRawJson<PaykeyRevealResponse>
{
    /// <inheritdoc/>
    public PaykeyRevealResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PaykeyRevealResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<PaykeyRevealResponseData, PaykeyRevealResponseDataFromRaw>)
)]
public sealed record class PaykeyRevealResponseData : JsonModel
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

    public required PaykeyRevealResponseDataConfig Config
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<PaykeyRevealResponseDataConfig>("config");
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

    public required ApiEnum<string, PaykeyRevealResponseDataSource> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, PaykeyRevealResponseDataSource>>(
                "source"
            );
        }
        init { this._rawData.Set("source", value); }
    }

    public required ApiEnum<string, PaykeyRevealResponseDataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, PaykeyRevealResponseDataStatus>>(
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

    public PaykeyRevealResponseDataBalance? Balance
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<PaykeyRevealResponseDataBalance>("balance");
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

    public PaykeyRevealResponseDataBankData? BankData
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<PaykeyRevealResponseDataBankData>("bank_data");
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

    public PaykeyRevealResponseDataStatusDetails? StatusDetails
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<PaykeyRevealResponseDataStatusDetails>(
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

    public PaykeyRevealResponseData() { }

    public PaykeyRevealResponseData(PaykeyRevealResponseData paykeyRevealResponseData)
        : base(paykeyRevealResponseData) { }

    public PaykeyRevealResponseData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyRevealResponseData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyRevealResponseDataFromRaw.FromRawUnchecked"/>
    public static PaykeyRevealResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeyRevealResponseDataFromRaw : IFromRawJson<PaykeyRevealResponseData>
{
    /// <inheritdoc/>
    public PaykeyRevealResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PaykeyRevealResponseData.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        PaykeyRevealResponseDataConfig,
        PaykeyRevealResponseDataConfigFromRaw
    >)
)]
public sealed record class PaykeyRevealResponseDataConfig : JsonModel
{
    public ApiEnum<string, PaykeyRevealResponseDataConfigProcessingMethod>? ProcessingMethod
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, PaykeyRevealResponseDataConfigProcessingMethod>
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

    public ApiEnum<string, PaykeyRevealResponseDataConfigSandboxOutcome>? SandboxOutcome
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, PaykeyRevealResponseDataConfigSandboxOutcome>
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

    public PaykeyRevealResponseDataConfig() { }

    public PaykeyRevealResponseDataConfig(
        PaykeyRevealResponseDataConfig paykeyRevealResponseDataConfig
    )
        : base(paykeyRevealResponseDataConfig) { }

    public PaykeyRevealResponseDataConfig(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyRevealResponseDataConfig(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyRevealResponseDataConfigFromRaw.FromRawUnchecked"/>
    public static PaykeyRevealResponseDataConfig FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeyRevealResponseDataConfigFromRaw : IFromRawJson<PaykeyRevealResponseDataConfig>
{
    /// <inheritdoc/>
    public PaykeyRevealResponseDataConfig FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PaykeyRevealResponseDataConfig.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(PaykeyRevealResponseDataConfigProcessingMethodConverter))]
public enum PaykeyRevealResponseDataConfigProcessingMethod
{
    Inline,
    Background,
    Skip,
}

sealed class PaykeyRevealResponseDataConfigProcessingMethodConverter
    : JsonConverter<PaykeyRevealResponseDataConfigProcessingMethod>
{
    public override PaykeyRevealResponseDataConfigProcessingMethod Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "inline" => PaykeyRevealResponseDataConfigProcessingMethod.Inline,
            "background" => PaykeyRevealResponseDataConfigProcessingMethod.Background,
            "skip" => PaykeyRevealResponseDataConfigProcessingMethod.Skip,
            _ => (PaykeyRevealResponseDataConfigProcessingMethod)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyRevealResponseDataConfigProcessingMethod value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyRevealResponseDataConfigProcessingMethod.Inline => "inline",
                PaykeyRevealResponseDataConfigProcessingMethod.Background => "background",
                PaykeyRevealResponseDataConfigProcessingMethod.Skip => "skip",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(PaykeyRevealResponseDataConfigSandboxOutcomeConverter))]
public enum PaykeyRevealResponseDataConfigSandboxOutcome
{
    Standard,
    Active,
    Rejected,
    Review,
}

sealed class PaykeyRevealResponseDataConfigSandboxOutcomeConverter
    : JsonConverter<PaykeyRevealResponseDataConfigSandboxOutcome>
{
    public override PaykeyRevealResponseDataConfigSandboxOutcome Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "standard" => PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
            "active" => PaykeyRevealResponseDataConfigSandboxOutcome.Active,
            "rejected" => PaykeyRevealResponseDataConfigSandboxOutcome.Rejected,
            "review" => PaykeyRevealResponseDataConfigSandboxOutcome.Review,
            _ => (PaykeyRevealResponseDataConfigSandboxOutcome)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyRevealResponseDataConfigSandboxOutcome value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyRevealResponseDataConfigSandboxOutcome.Standard => "standard",
                PaykeyRevealResponseDataConfigSandboxOutcome.Active => "active",
                PaykeyRevealResponseDataConfigSandboxOutcome.Rejected => "rejected",
                PaykeyRevealResponseDataConfigSandboxOutcome.Review => "review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(PaykeyRevealResponseDataSourceConverter))]
public enum PaykeyRevealResponseDataSource
{
    BankAccount,
    Straddle,
    Mx,
    Plaid,
    Tan,
    Quiltt,
}

sealed class PaykeyRevealResponseDataSourceConverter : JsonConverter<PaykeyRevealResponseDataSource>
{
    public override PaykeyRevealResponseDataSource Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "bank_account" => PaykeyRevealResponseDataSource.BankAccount,
            "straddle" => PaykeyRevealResponseDataSource.Straddle,
            "mx" => PaykeyRevealResponseDataSource.Mx,
            "plaid" => PaykeyRevealResponseDataSource.Plaid,
            "tan" => PaykeyRevealResponseDataSource.Tan,
            "quiltt" => PaykeyRevealResponseDataSource.Quiltt,
            _ => (PaykeyRevealResponseDataSource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyRevealResponseDataSource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyRevealResponseDataSource.BankAccount => "bank_account",
                PaykeyRevealResponseDataSource.Straddle => "straddle",
                PaykeyRevealResponseDataSource.Mx => "mx",
                PaykeyRevealResponseDataSource.Plaid => "plaid",
                PaykeyRevealResponseDataSource.Tan => "tan",
                PaykeyRevealResponseDataSource.Quiltt => "quiltt",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(PaykeyRevealResponseDataStatusConverter))]
public enum PaykeyRevealResponseDataStatus
{
    Pending,
    Active,
    Inactive,
    Rejected,
    Review,
    Blocked,
}

sealed class PaykeyRevealResponseDataStatusConverter : JsonConverter<PaykeyRevealResponseDataStatus>
{
    public override PaykeyRevealResponseDataStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => PaykeyRevealResponseDataStatus.Pending,
            "active" => PaykeyRevealResponseDataStatus.Active,
            "inactive" => PaykeyRevealResponseDataStatus.Inactive,
            "rejected" => PaykeyRevealResponseDataStatus.Rejected,
            "review" => PaykeyRevealResponseDataStatus.Review,
            "blocked" => PaykeyRevealResponseDataStatus.Blocked,
            _ => (PaykeyRevealResponseDataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyRevealResponseDataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyRevealResponseDataStatus.Pending => "pending",
                PaykeyRevealResponseDataStatus.Active => "active",
                PaykeyRevealResponseDataStatus.Inactive => "inactive",
                PaykeyRevealResponseDataStatus.Rejected => "rejected",
                PaykeyRevealResponseDataStatus.Review => "review",
                PaykeyRevealResponseDataStatus.Blocked => "blocked",
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
        PaykeyRevealResponseDataBalance,
        PaykeyRevealResponseDataBalanceFromRaw
    >)
)]
public sealed record class PaykeyRevealResponseDataBalance : JsonModel
{
    public required ApiEnum<string, PaykeyRevealResponseDataBalanceStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, PaykeyRevealResponseDataBalanceStatus>
            >("status");
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

    public PaykeyRevealResponseDataBalance() { }

    public PaykeyRevealResponseDataBalance(
        PaykeyRevealResponseDataBalance paykeyRevealResponseDataBalance
    )
        : base(paykeyRevealResponseDataBalance) { }

    public PaykeyRevealResponseDataBalance(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyRevealResponseDataBalance(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyRevealResponseDataBalanceFromRaw.FromRawUnchecked"/>
    public static PaykeyRevealResponseDataBalance FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public PaykeyRevealResponseDataBalance(
        ApiEnum<string, PaykeyRevealResponseDataBalanceStatus> status
    )
        : this()
    {
        this.Status = status;
    }
}

class PaykeyRevealResponseDataBalanceFromRaw : IFromRawJson<PaykeyRevealResponseDataBalance>
{
    /// <inheritdoc/>
    public PaykeyRevealResponseDataBalance FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PaykeyRevealResponseDataBalance.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(PaykeyRevealResponseDataBalanceStatusConverter))]
public enum PaykeyRevealResponseDataBalanceStatus
{
    Pending,
    Completed,
    Failed,
}

sealed class PaykeyRevealResponseDataBalanceStatusConverter
    : JsonConverter<PaykeyRevealResponseDataBalanceStatus>
{
    public override PaykeyRevealResponseDataBalanceStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => PaykeyRevealResponseDataBalanceStatus.Pending,
            "completed" => PaykeyRevealResponseDataBalanceStatus.Completed,
            "failed" => PaykeyRevealResponseDataBalanceStatus.Failed,
            _ => (PaykeyRevealResponseDataBalanceStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyRevealResponseDataBalanceStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyRevealResponseDataBalanceStatus.Pending => "pending",
                PaykeyRevealResponseDataBalanceStatus.Completed => "completed",
                PaykeyRevealResponseDataBalanceStatus.Failed => "failed",
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
        PaykeyRevealResponseDataBankData,
        PaykeyRevealResponseDataBankDataFromRaw
    >)
)]
public sealed record class PaykeyRevealResponseDataBankData : JsonModel
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

    public required ApiEnum<string, PaykeyRevealResponseDataBankDataAccountType> AccountType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, PaykeyRevealResponseDataBankDataAccountType>
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

    public PaykeyRevealResponseDataBankData() { }

    public PaykeyRevealResponseDataBankData(
        PaykeyRevealResponseDataBankData paykeyRevealResponseDataBankData
    )
        : base(paykeyRevealResponseDataBankData) { }

    public PaykeyRevealResponseDataBankData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyRevealResponseDataBankData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyRevealResponseDataBankDataFromRaw.FromRawUnchecked"/>
    public static PaykeyRevealResponseDataBankData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeyRevealResponseDataBankDataFromRaw : IFromRawJson<PaykeyRevealResponseDataBankData>
{
    /// <inheritdoc/>
    public PaykeyRevealResponseDataBankData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PaykeyRevealResponseDataBankData.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(PaykeyRevealResponseDataBankDataAccountTypeConverter))]
public enum PaykeyRevealResponseDataBankDataAccountType
{
    Checking,
    Savings,
}

sealed class PaykeyRevealResponseDataBankDataAccountTypeConverter
    : JsonConverter<PaykeyRevealResponseDataBankDataAccountType>
{
    public override PaykeyRevealResponseDataBankDataAccountType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "checking" => PaykeyRevealResponseDataBankDataAccountType.Checking,
            "savings" => PaykeyRevealResponseDataBankDataAccountType.Savings,
            _ => (PaykeyRevealResponseDataBankDataAccountType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyRevealResponseDataBankDataAccountType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyRevealResponseDataBankDataAccountType.Checking => "checking",
                PaykeyRevealResponseDataBankDataAccountType.Savings => "savings",
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
        PaykeyRevealResponseDataStatusDetails,
        PaykeyRevealResponseDataStatusDetailsFromRaw
    >)
)]
public sealed record class PaykeyRevealResponseDataStatusDetails : JsonModel
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

    public required ApiEnum<string, PaykeyRevealResponseDataStatusDetailsReason> Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, PaykeyRevealResponseDataStatusDetailsReason>
            >("reason");
        }
        init { this._rawData.Set("reason", value); }
    }

    public required ApiEnum<string, PaykeyRevealResponseDataStatusDetailsSource> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, PaykeyRevealResponseDataStatusDetailsSource>
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

    public PaykeyRevealResponseDataStatusDetails() { }

    public PaykeyRevealResponseDataStatusDetails(
        PaykeyRevealResponseDataStatusDetails paykeyRevealResponseDataStatusDetails
    )
        : base(paykeyRevealResponseDataStatusDetails) { }

    public PaykeyRevealResponseDataStatusDetails(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyRevealResponseDataStatusDetails(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyRevealResponseDataStatusDetailsFromRaw.FromRawUnchecked"/>
    public static PaykeyRevealResponseDataStatusDetails FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeyRevealResponseDataStatusDetailsFromRaw
    : IFromRawJson<PaykeyRevealResponseDataStatusDetails>
{
    /// <inheritdoc/>
    public PaykeyRevealResponseDataStatusDetails FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => PaykeyRevealResponseDataStatusDetails.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(PaykeyRevealResponseDataStatusDetailsReasonConverter))]
public enum PaykeyRevealResponseDataStatusDetailsReason
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

sealed class PaykeyRevealResponseDataStatusDetailsReasonConverter
    : JsonConverter<PaykeyRevealResponseDataStatusDetailsReason>
{
    public override PaykeyRevealResponseDataStatusDetailsReason Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "insufficient_funds" => PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
            "closed_bank_account" => PaykeyRevealResponseDataStatusDetailsReason.ClosedBankAccount,
            "invalid_bank_account" =>
                PaykeyRevealResponseDataStatusDetailsReason.InvalidBankAccount,
            "invalid_routing" => PaykeyRevealResponseDataStatusDetailsReason.InvalidRouting,
            "disputed" => PaykeyRevealResponseDataStatusDetailsReason.Disputed,
            "payment_stopped" => PaykeyRevealResponseDataStatusDetailsReason.PaymentStopped,
            "owner_deceased" => PaykeyRevealResponseDataStatusDetailsReason.OwnerDeceased,
            "frozen_bank_account" => PaykeyRevealResponseDataStatusDetailsReason.FrozenBankAccount,
            "risk_review" => PaykeyRevealResponseDataStatusDetailsReason.RiskReview,
            "fraudulent" => PaykeyRevealResponseDataStatusDetailsReason.Fraudulent,
            "duplicate_entry" => PaykeyRevealResponseDataStatusDetailsReason.DuplicateEntry,
            "invalid_paykey" => PaykeyRevealResponseDataStatusDetailsReason.InvalidPaykey,
            "payment_blocked" => PaykeyRevealResponseDataStatusDetailsReason.PaymentBlocked,
            "amount_too_large" => PaykeyRevealResponseDataStatusDetailsReason.AmountTooLarge,
            "too_many_attempts" => PaykeyRevealResponseDataStatusDetailsReason.TooManyAttempts,
            "internal_system_error" =>
                PaykeyRevealResponseDataStatusDetailsReason.InternalSystemError,
            "user_request" => PaykeyRevealResponseDataStatusDetailsReason.UserRequest,
            "ok" => PaykeyRevealResponseDataStatusDetailsReason.Ok,
            "other_network_return" =>
                PaykeyRevealResponseDataStatusDetailsReason.OtherNetworkReturn,
            "payout_refused" => PaykeyRevealResponseDataStatusDetailsReason.PayoutRefused,
            "cancel_request" => PaykeyRevealResponseDataStatusDetailsReason.CancelRequest,
            "failed_verification" => PaykeyRevealResponseDataStatusDetailsReason.FailedVerification,
            "require_review" => PaykeyRevealResponseDataStatusDetailsReason.RequireReview,
            "blocked_by_system" => PaykeyRevealResponseDataStatusDetailsReason.BlockedBySystem,
            "watchtower_review" => PaykeyRevealResponseDataStatusDetailsReason.WatchtowerReview,
            _ => (PaykeyRevealResponseDataStatusDetailsReason)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyRevealResponseDataStatusDetailsReason value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds =>
                    "insufficient_funds",
                PaykeyRevealResponseDataStatusDetailsReason.ClosedBankAccount =>
                    "closed_bank_account",
                PaykeyRevealResponseDataStatusDetailsReason.InvalidBankAccount =>
                    "invalid_bank_account",
                PaykeyRevealResponseDataStatusDetailsReason.InvalidRouting => "invalid_routing",
                PaykeyRevealResponseDataStatusDetailsReason.Disputed => "disputed",
                PaykeyRevealResponseDataStatusDetailsReason.PaymentStopped => "payment_stopped",
                PaykeyRevealResponseDataStatusDetailsReason.OwnerDeceased => "owner_deceased",
                PaykeyRevealResponseDataStatusDetailsReason.FrozenBankAccount =>
                    "frozen_bank_account",
                PaykeyRevealResponseDataStatusDetailsReason.RiskReview => "risk_review",
                PaykeyRevealResponseDataStatusDetailsReason.Fraudulent => "fraudulent",
                PaykeyRevealResponseDataStatusDetailsReason.DuplicateEntry => "duplicate_entry",
                PaykeyRevealResponseDataStatusDetailsReason.InvalidPaykey => "invalid_paykey",
                PaykeyRevealResponseDataStatusDetailsReason.PaymentBlocked => "payment_blocked",
                PaykeyRevealResponseDataStatusDetailsReason.AmountTooLarge => "amount_too_large",
                PaykeyRevealResponseDataStatusDetailsReason.TooManyAttempts => "too_many_attempts",
                PaykeyRevealResponseDataStatusDetailsReason.InternalSystemError =>
                    "internal_system_error",
                PaykeyRevealResponseDataStatusDetailsReason.UserRequest => "user_request",
                PaykeyRevealResponseDataStatusDetailsReason.Ok => "ok",
                PaykeyRevealResponseDataStatusDetailsReason.OtherNetworkReturn =>
                    "other_network_return",
                PaykeyRevealResponseDataStatusDetailsReason.PayoutRefused => "payout_refused",
                PaykeyRevealResponseDataStatusDetailsReason.CancelRequest => "cancel_request",
                PaykeyRevealResponseDataStatusDetailsReason.FailedVerification =>
                    "failed_verification",
                PaykeyRevealResponseDataStatusDetailsReason.RequireReview => "require_review",
                PaykeyRevealResponseDataStatusDetailsReason.BlockedBySystem => "blocked_by_system",
                PaykeyRevealResponseDataStatusDetailsReason.WatchtowerReview => "watchtower_review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(PaykeyRevealResponseDataStatusDetailsSourceConverter))]
public enum PaykeyRevealResponseDataStatusDetailsSource
{
    Watchtower,
    BankDecline,
    CustomerDispute,
    UserAction,
    System,
}

sealed class PaykeyRevealResponseDataStatusDetailsSourceConverter
    : JsonConverter<PaykeyRevealResponseDataStatusDetailsSource>
{
    public override PaykeyRevealResponseDataStatusDetailsSource Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "watchtower" => PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
            "bank_decline" => PaykeyRevealResponseDataStatusDetailsSource.BankDecline,
            "customer_dispute" => PaykeyRevealResponseDataStatusDetailsSource.CustomerDispute,
            "user_action" => PaykeyRevealResponseDataStatusDetailsSource.UserAction,
            "system" => PaykeyRevealResponseDataStatusDetailsSource.System,
            _ => (PaykeyRevealResponseDataStatusDetailsSource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyRevealResponseDataStatusDetailsSource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyRevealResponseDataStatusDetailsSource.Watchtower => "watchtower",
                PaykeyRevealResponseDataStatusDetailsSource.BankDecline => "bank_decline",
                PaykeyRevealResponseDataStatusDetailsSource.CustomerDispute => "customer_dispute",
                PaykeyRevealResponseDataStatusDetailsSource.UserAction => "user_action",
                PaykeyRevealResponseDataStatusDetailsSource.System => "system",
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
[JsonConverter(typeof(PaykeyRevealResponseResponseTypeConverter))]
public enum PaykeyRevealResponseResponseType
{
    Object,
    Array,
    Error,
    None,
}

sealed class PaykeyRevealResponseResponseTypeConverter
    : JsonConverter<PaykeyRevealResponseResponseType>
{
    public override PaykeyRevealResponseResponseType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "object" => PaykeyRevealResponseResponseType.Object,
            "array" => PaykeyRevealResponseResponseType.Array,
            "error" => PaykeyRevealResponseResponseType.Error,
            "none" => PaykeyRevealResponseResponseType.None,
            _ => (PaykeyRevealResponseResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        PaykeyRevealResponseResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                PaykeyRevealResponseResponseType.Object => "object",
                PaykeyRevealResponseResponseType.Array => "array",
                PaykeyRevealResponseResponseType.Error => "error",
                PaykeyRevealResponseResponseType.None => "none",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
