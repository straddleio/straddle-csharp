using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Bridge.Link;

[JsonConverter(typeof(JsonModelConverter<LinkCreateTanResponse, LinkCreateTanResponseFromRaw>))]
public sealed record class LinkCreateTanResponse : JsonModel
{
    public required LinkCreateTanResponseData Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<LinkCreateTanResponseData>("data");
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
    public required ApiEnum<string, LinkCreateTanResponseResponseType> ResponseType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, LinkCreateTanResponseResponseType>
            >("response_type");
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

    public LinkCreateTanResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public LinkCreateTanResponse(LinkCreateTanResponse linkCreateTanResponse)
        : base(linkCreateTanResponse) { }
#pragma warning restore CS8618

    public LinkCreateTanResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LinkCreateTanResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LinkCreateTanResponseFromRaw.FromRawUnchecked"/>
    public static LinkCreateTanResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LinkCreateTanResponseFromRaw : IFromRawJson<LinkCreateTanResponse>
{
    /// <inheritdoc/>
    public LinkCreateTanResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => LinkCreateTanResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<LinkCreateTanResponseData, LinkCreateTanResponseDataFromRaw>)
)]
public sealed record class LinkCreateTanResponseData : JsonModel
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

    public required LinkCreateTanResponseDataConfig Config
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<LinkCreateTanResponseDataConfig>("config");
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

    public required ApiEnum<string, LinkCreateTanResponseDataSource> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, LinkCreateTanResponseDataSource>>(
                "source"
            );
        }
        init { this._rawData.Set("source", value); }
    }

    public required ApiEnum<string, LinkCreateTanResponseDataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, LinkCreateTanResponseDataStatus>>(
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

    public LinkCreateTanResponseDataBalance? Balance
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<LinkCreateTanResponseDataBalance>("balance");
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

    public LinkCreateTanResponseDataBankData? BankData
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<LinkCreateTanResponseDataBankData>("bank_data");
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

    public LinkCreateTanResponseDataStatusDetails? StatusDetails
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<LinkCreateTanResponseDataStatusDetails>(
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

    public LinkCreateTanResponseData() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public LinkCreateTanResponseData(LinkCreateTanResponseData linkCreateTanResponseData)
        : base(linkCreateTanResponseData) { }
#pragma warning restore CS8618

    public LinkCreateTanResponseData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LinkCreateTanResponseData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LinkCreateTanResponseDataFromRaw.FromRawUnchecked"/>
    public static LinkCreateTanResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LinkCreateTanResponseDataFromRaw : IFromRawJson<LinkCreateTanResponseData>
{
    /// <inheritdoc/>
    public LinkCreateTanResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => LinkCreateTanResponseData.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        LinkCreateTanResponseDataConfig,
        LinkCreateTanResponseDataConfigFromRaw
    >)
)]
public sealed record class LinkCreateTanResponseDataConfig : JsonModel
{
    public ApiEnum<string, LinkCreateTanResponseDataConfigProcessingMethod>? ProcessingMethod
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, LinkCreateTanResponseDataConfigProcessingMethod>
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

    public ApiEnum<string, LinkCreateTanResponseDataConfigSandboxOutcome>? SandboxOutcome
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, LinkCreateTanResponseDataConfigSandboxOutcome>
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

    public LinkCreateTanResponseDataConfig() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public LinkCreateTanResponseDataConfig(
        LinkCreateTanResponseDataConfig linkCreateTanResponseDataConfig
    )
        : base(linkCreateTanResponseDataConfig) { }
#pragma warning restore CS8618

    public LinkCreateTanResponseDataConfig(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LinkCreateTanResponseDataConfig(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LinkCreateTanResponseDataConfigFromRaw.FromRawUnchecked"/>
    public static LinkCreateTanResponseDataConfig FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LinkCreateTanResponseDataConfigFromRaw : IFromRawJson<LinkCreateTanResponseDataConfig>
{
    /// <inheritdoc/>
    public LinkCreateTanResponseDataConfig FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => LinkCreateTanResponseDataConfig.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(LinkCreateTanResponseDataConfigProcessingMethodConverter))]
public enum LinkCreateTanResponseDataConfigProcessingMethod
{
    Inline,
    Background,
    Skip,
}

sealed class LinkCreateTanResponseDataConfigProcessingMethodConverter
    : JsonConverter<LinkCreateTanResponseDataConfigProcessingMethod>
{
    public override LinkCreateTanResponseDataConfigProcessingMethod Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "inline" => LinkCreateTanResponseDataConfigProcessingMethod.Inline,
            "background" => LinkCreateTanResponseDataConfigProcessingMethod.Background,
            "skip" => LinkCreateTanResponseDataConfigProcessingMethod.Skip,
            _ => (LinkCreateTanResponseDataConfigProcessingMethod)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkCreateTanResponseDataConfigProcessingMethod value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkCreateTanResponseDataConfigProcessingMethod.Inline => "inline",
                LinkCreateTanResponseDataConfigProcessingMethod.Background => "background",
                LinkCreateTanResponseDataConfigProcessingMethod.Skip => "skip",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(LinkCreateTanResponseDataConfigSandboxOutcomeConverter))]
public enum LinkCreateTanResponseDataConfigSandboxOutcome
{
    Standard,
    Active,
    Rejected,
    Review,
}

sealed class LinkCreateTanResponseDataConfigSandboxOutcomeConverter
    : JsonConverter<LinkCreateTanResponseDataConfigSandboxOutcome>
{
    public override LinkCreateTanResponseDataConfigSandboxOutcome Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "standard" => LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
            "active" => LinkCreateTanResponseDataConfigSandboxOutcome.Active,
            "rejected" => LinkCreateTanResponseDataConfigSandboxOutcome.Rejected,
            "review" => LinkCreateTanResponseDataConfigSandboxOutcome.Review,
            _ => (LinkCreateTanResponseDataConfigSandboxOutcome)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkCreateTanResponseDataConfigSandboxOutcome value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkCreateTanResponseDataConfigSandboxOutcome.Standard => "standard",
                LinkCreateTanResponseDataConfigSandboxOutcome.Active => "active",
                LinkCreateTanResponseDataConfigSandboxOutcome.Rejected => "rejected",
                LinkCreateTanResponseDataConfigSandboxOutcome.Review => "review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(LinkCreateTanResponseDataSourceConverter))]
public enum LinkCreateTanResponseDataSource
{
    BankAccount,
    Straddle,
    Mx,
    Plaid,
    Tan,
    Quiltt,
}

sealed class LinkCreateTanResponseDataSourceConverter
    : JsonConverter<LinkCreateTanResponseDataSource>
{
    public override LinkCreateTanResponseDataSource Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "bank_account" => LinkCreateTanResponseDataSource.BankAccount,
            "straddle" => LinkCreateTanResponseDataSource.Straddle,
            "mx" => LinkCreateTanResponseDataSource.Mx,
            "plaid" => LinkCreateTanResponseDataSource.Plaid,
            "tan" => LinkCreateTanResponseDataSource.Tan,
            "quiltt" => LinkCreateTanResponseDataSource.Quiltt,
            _ => (LinkCreateTanResponseDataSource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkCreateTanResponseDataSource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkCreateTanResponseDataSource.BankAccount => "bank_account",
                LinkCreateTanResponseDataSource.Straddle => "straddle",
                LinkCreateTanResponseDataSource.Mx => "mx",
                LinkCreateTanResponseDataSource.Plaid => "plaid",
                LinkCreateTanResponseDataSource.Tan => "tan",
                LinkCreateTanResponseDataSource.Quiltt => "quiltt",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(LinkCreateTanResponseDataStatusConverter))]
public enum LinkCreateTanResponseDataStatus
{
    Pending,
    Active,
    Inactive,
    Rejected,
    Review,
    Blocked,
}

sealed class LinkCreateTanResponseDataStatusConverter
    : JsonConverter<LinkCreateTanResponseDataStatus>
{
    public override LinkCreateTanResponseDataStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => LinkCreateTanResponseDataStatus.Pending,
            "active" => LinkCreateTanResponseDataStatus.Active,
            "inactive" => LinkCreateTanResponseDataStatus.Inactive,
            "rejected" => LinkCreateTanResponseDataStatus.Rejected,
            "review" => LinkCreateTanResponseDataStatus.Review,
            "blocked" => LinkCreateTanResponseDataStatus.Blocked,
            _ => (LinkCreateTanResponseDataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkCreateTanResponseDataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkCreateTanResponseDataStatus.Pending => "pending",
                LinkCreateTanResponseDataStatus.Active => "active",
                LinkCreateTanResponseDataStatus.Inactive => "inactive",
                LinkCreateTanResponseDataStatus.Rejected => "rejected",
                LinkCreateTanResponseDataStatus.Review => "review",
                LinkCreateTanResponseDataStatus.Blocked => "blocked",
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
        LinkCreateTanResponseDataBalance,
        LinkCreateTanResponseDataBalanceFromRaw
    >)
)]
public sealed record class LinkCreateTanResponseDataBalance : JsonModel
{
    public required ApiEnum<string, LinkCreateTanResponseDataBalanceStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, LinkCreateTanResponseDataBalanceStatus>
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

    public LinkCreateTanResponseDataBalance() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public LinkCreateTanResponseDataBalance(
        LinkCreateTanResponseDataBalance linkCreateTanResponseDataBalance
    )
        : base(linkCreateTanResponseDataBalance) { }
#pragma warning restore CS8618

    public LinkCreateTanResponseDataBalance(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LinkCreateTanResponseDataBalance(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LinkCreateTanResponseDataBalanceFromRaw.FromRawUnchecked"/>
    public static LinkCreateTanResponseDataBalance FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public LinkCreateTanResponseDataBalance(
        ApiEnum<string, LinkCreateTanResponseDataBalanceStatus> status
    )
        : this()
    {
        this.Status = status;
    }
}

class LinkCreateTanResponseDataBalanceFromRaw : IFromRawJson<LinkCreateTanResponseDataBalance>
{
    /// <inheritdoc/>
    public LinkCreateTanResponseDataBalance FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => LinkCreateTanResponseDataBalance.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(LinkCreateTanResponseDataBalanceStatusConverter))]
public enum LinkCreateTanResponseDataBalanceStatus
{
    Pending,
    Completed,
    Failed,
}

sealed class LinkCreateTanResponseDataBalanceStatusConverter
    : JsonConverter<LinkCreateTanResponseDataBalanceStatus>
{
    public override LinkCreateTanResponseDataBalanceStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => LinkCreateTanResponseDataBalanceStatus.Pending,
            "completed" => LinkCreateTanResponseDataBalanceStatus.Completed,
            "failed" => LinkCreateTanResponseDataBalanceStatus.Failed,
            _ => (LinkCreateTanResponseDataBalanceStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkCreateTanResponseDataBalanceStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkCreateTanResponseDataBalanceStatus.Pending => "pending",
                LinkCreateTanResponseDataBalanceStatus.Completed => "completed",
                LinkCreateTanResponseDataBalanceStatus.Failed => "failed",
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
        LinkCreateTanResponseDataBankData,
        LinkCreateTanResponseDataBankDataFromRaw
    >)
)]
public sealed record class LinkCreateTanResponseDataBankData : JsonModel
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

    public required ApiEnum<string, LinkCreateTanResponseDataBankDataAccountType> AccountType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, LinkCreateTanResponseDataBankDataAccountType>
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

    public LinkCreateTanResponseDataBankData() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public LinkCreateTanResponseDataBankData(
        LinkCreateTanResponseDataBankData linkCreateTanResponseDataBankData
    )
        : base(linkCreateTanResponseDataBankData) { }
#pragma warning restore CS8618

    public LinkCreateTanResponseDataBankData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LinkCreateTanResponseDataBankData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LinkCreateTanResponseDataBankDataFromRaw.FromRawUnchecked"/>
    public static LinkCreateTanResponseDataBankData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LinkCreateTanResponseDataBankDataFromRaw : IFromRawJson<LinkCreateTanResponseDataBankData>
{
    /// <inheritdoc/>
    public LinkCreateTanResponseDataBankData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => LinkCreateTanResponseDataBankData.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(LinkCreateTanResponseDataBankDataAccountTypeConverter))]
public enum LinkCreateTanResponseDataBankDataAccountType
{
    Checking,
    Savings,
}

sealed class LinkCreateTanResponseDataBankDataAccountTypeConverter
    : JsonConverter<LinkCreateTanResponseDataBankDataAccountType>
{
    public override LinkCreateTanResponseDataBankDataAccountType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "checking" => LinkCreateTanResponseDataBankDataAccountType.Checking,
            "savings" => LinkCreateTanResponseDataBankDataAccountType.Savings,
            _ => (LinkCreateTanResponseDataBankDataAccountType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkCreateTanResponseDataBankDataAccountType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkCreateTanResponseDataBankDataAccountType.Checking => "checking",
                LinkCreateTanResponseDataBankDataAccountType.Savings => "savings",
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
        LinkCreateTanResponseDataStatusDetails,
        LinkCreateTanResponseDataStatusDetailsFromRaw
    >)
)]
public sealed record class LinkCreateTanResponseDataStatusDetails : JsonModel
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

    public required ApiEnum<string, LinkCreateTanResponseDataStatusDetailsReason> Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, LinkCreateTanResponseDataStatusDetailsReason>
            >("reason");
        }
        init { this._rawData.Set("reason", value); }
    }

    public required ApiEnum<string, LinkCreateTanResponseDataStatusDetailsSource> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, LinkCreateTanResponseDataStatusDetailsSource>
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

    public LinkCreateTanResponseDataStatusDetails() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public LinkCreateTanResponseDataStatusDetails(
        LinkCreateTanResponseDataStatusDetails linkCreateTanResponseDataStatusDetails
    )
        : base(linkCreateTanResponseDataStatusDetails) { }
#pragma warning restore CS8618

    public LinkCreateTanResponseDataStatusDetails(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LinkCreateTanResponseDataStatusDetails(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LinkCreateTanResponseDataStatusDetailsFromRaw.FromRawUnchecked"/>
    public static LinkCreateTanResponseDataStatusDetails FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LinkCreateTanResponseDataStatusDetailsFromRaw
    : IFromRawJson<LinkCreateTanResponseDataStatusDetails>
{
    /// <inheritdoc/>
    public LinkCreateTanResponseDataStatusDetails FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => LinkCreateTanResponseDataStatusDetails.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(LinkCreateTanResponseDataStatusDetailsReasonConverter))]
public enum LinkCreateTanResponseDataStatusDetailsReason
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

sealed class LinkCreateTanResponseDataStatusDetailsReasonConverter
    : JsonConverter<LinkCreateTanResponseDataStatusDetailsReason>
{
    public override LinkCreateTanResponseDataStatusDetailsReason Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "insufficient_funds" => LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
            "closed_bank_account" => LinkCreateTanResponseDataStatusDetailsReason.ClosedBankAccount,
            "invalid_bank_account" =>
                LinkCreateTanResponseDataStatusDetailsReason.InvalidBankAccount,
            "invalid_routing" => LinkCreateTanResponseDataStatusDetailsReason.InvalidRouting,
            "disputed" => LinkCreateTanResponseDataStatusDetailsReason.Disputed,
            "payment_stopped" => LinkCreateTanResponseDataStatusDetailsReason.PaymentStopped,
            "owner_deceased" => LinkCreateTanResponseDataStatusDetailsReason.OwnerDeceased,
            "frozen_bank_account" => LinkCreateTanResponseDataStatusDetailsReason.FrozenBankAccount,
            "risk_review" => LinkCreateTanResponseDataStatusDetailsReason.RiskReview,
            "fraudulent" => LinkCreateTanResponseDataStatusDetailsReason.Fraudulent,
            "duplicate_entry" => LinkCreateTanResponseDataStatusDetailsReason.DuplicateEntry,
            "invalid_paykey" => LinkCreateTanResponseDataStatusDetailsReason.InvalidPaykey,
            "payment_blocked" => LinkCreateTanResponseDataStatusDetailsReason.PaymentBlocked,
            "amount_too_large" => LinkCreateTanResponseDataStatusDetailsReason.AmountTooLarge,
            "too_many_attempts" => LinkCreateTanResponseDataStatusDetailsReason.TooManyAttempts,
            "internal_system_error" =>
                LinkCreateTanResponseDataStatusDetailsReason.InternalSystemError,
            "user_request" => LinkCreateTanResponseDataStatusDetailsReason.UserRequest,
            "ok" => LinkCreateTanResponseDataStatusDetailsReason.Ok,
            "other_network_return" =>
                LinkCreateTanResponseDataStatusDetailsReason.OtherNetworkReturn,
            "payout_refused" => LinkCreateTanResponseDataStatusDetailsReason.PayoutRefused,
            "cancel_request" => LinkCreateTanResponseDataStatusDetailsReason.CancelRequest,
            "failed_verification" =>
                LinkCreateTanResponseDataStatusDetailsReason.FailedVerification,
            "require_review" => LinkCreateTanResponseDataStatusDetailsReason.RequireReview,
            "blocked_by_system" => LinkCreateTanResponseDataStatusDetailsReason.BlockedBySystem,
            "watchtower_review" => LinkCreateTanResponseDataStatusDetailsReason.WatchtowerReview,
            _ => (LinkCreateTanResponseDataStatusDetailsReason)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkCreateTanResponseDataStatusDetailsReason value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds =>
                    "insufficient_funds",
                LinkCreateTanResponseDataStatusDetailsReason.ClosedBankAccount =>
                    "closed_bank_account",
                LinkCreateTanResponseDataStatusDetailsReason.InvalidBankAccount =>
                    "invalid_bank_account",
                LinkCreateTanResponseDataStatusDetailsReason.InvalidRouting => "invalid_routing",
                LinkCreateTanResponseDataStatusDetailsReason.Disputed => "disputed",
                LinkCreateTanResponseDataStatusDetailsReason.PaymentStopped => "payment_stopped",
                LinkCreateTanResponseDataStatusDetailsReason.OwnerDeceased => "owner_deceased",
                LinkCreateTanResponseDataStatusDetailsReason.FrozenBankAccount =>
                    "frozen_bank_account",
                LinkCreateTanResponseDataStatusDetailsReason.RiskReview => "risk_review",
                LinkCreateTanResponseDataStatusDetailsReason.Fraudulent => "fraudulent",
                LinkCreateTanResponseDataStatusDetailsReason.DuplicateEntry => "duplicate_entry",
                LinkCreateTanResponseDataStatusDetailsReason.InvalidPaykey => "invalid_paykey",
                LinkCreateTanResponseDataStatusDetailsReason.PaymentBlocked => "payment_blocked",
                LinkCreateTanResponseDataStatusDetailsReason.AmountTooLarge => "amount_too_large",
                LinkCreateTanResponseDataStatusDetailsReason.TooManyAttempts => "too_many_attempts",
                LinkCreateTanResponseDataStatusDetailsReason.InternalSystemError =>
                    "internal_system_error",
                LinkCreateTanResponseDataStatusDetailsReason.UserRequest => "user_request",
                LinkCreateTanResponseDataStatusDetailsReason.Ok => "ok",
                LinkCreateTanResponseDataStatusDetailsReason.OtherNetworkReturn =>
                    "other_network_return",
                LinkCreateTanResponseDataStatusDetailsReason.PayoutRefused => "payout_refused",
                LinkCreateTanResponseDataStatusDetailsReason.CancelRequest => "cancel_request",
                LinkCreateTanResponseDataStatusDetailsReason.FailedVerification =>
                    "failed_verification",
                LinkCreateTanResponseDataStatusDetailsReason.RequireReview => "require_review",
                LinkCreateTanResponseDataStatusDetailsReason.BlockedBySystem => "blocked_by_system",
                LinkCreateTanResponseDataStatusDetailsReason.WatchtowerReview =>
                    "watchtower_review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(LinkCreateTanResponseDataStatusDetailsSourceConverter))]
public enum LinkCreateTanResponseDataStatusDetailsSource
{
    Watchtower,
    BankDecline,
    CustomerDispute,
    UserAction,
    System,
}

sealed class LinkCreateTanResponseDataStatusDetailsSourceConverter
    : JsonConverter<LinkCreateTanResponseDataStatusDetailsSource>
{
    public override LinkCreateTanResponseDataStatusDetailsSource Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "watchtower" => LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
            "bank_decline" => LinkCreateTanResponseDataStatusDetailsSource.BankDecline,
            "customer_dispute" => LinkCreateTanResponseDataStatusDetailsSource.CustomerDispute,
            "user_action" => LinkCreateTanResponseDataStatusDetailsSource.UserAction,
            "system" => LinkCreateTanResponseDataStatusDetailsSource.System,
            _ => (LinkCreateTanResponseDataStatusDetailsSource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkCreateTanResponseDataStatusDetailsSource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkCreateTanResponseDataStatusDetailsSource.Watchtower => "watchtower",
                LinkCreateTanResponseDataStatusDetailsSource.BankDecline => "bank_decline",
                LinkCreateTanResponseDataStatusDetailsSource.CustomerDispute => "customer_dispute",
                LinkCreateTanResponseDataStatusDetailsSource.UserAction => "user_action",
                LinkCreateTanResponseDataStatusDetailsSource.System => "system",
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
[JsonConverter(typeof(LinkCreateTanResponseResponseTypeConverter))]
public enum LinkCreateTanResponseResponseType
{
    Object,
    Array,
    Error,
    None,
}

sealed class LinkCreateTanResponseResponseTypeConverter
    : JsonConverter<LinkCreateTanResponseResponseType>
{
    public override LinkCreateTanResponseResponseType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "object" => LinkCreateTanResponseResponseType.Object,
            "array" => LinkCreateTanResponseResponseType.Array,
            "error" => LinkCreateTanResponseResponseType.Error,
            "none" => LinkCreateTanResponseResponseType.None,
            _ => (LinkCreateTanResponseResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkCreateTanResponseResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkCreateTanResponseResponseType.Object => "object",
                LinkCreateTanResponseResponseType.Array => "array",
                LinkCreateTanResponseResponseType.Error => "error",
                LinkCreateTanResponseResponseType.None => "none",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
