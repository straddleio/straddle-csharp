using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Embed.LinkedBankAccounts;

[JsonConverter(typeof(JsonModelConverter<LinkedBankAccountV1, LinkedBankAccountV1FromRaw>))]
public sealed record class LinkedBankAccountV1 : JsonModel
{
    public required LinkedBankAccountV1Data Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<LinkedBankAccountV1Data>("data");
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
    public required ApiEnum<string, LinkedBankAccountV1ResponseType> ResponseType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, LinkedBankAccountV1ResponseType>>(
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

    public LinkedBankAccountV1() { }

    public LinkedBankAccountV1(LinkedBankAccountV1 linkedBankAccountV1)
        : base(linkedBankAccountV1) { }

    public LinkedBankAccountV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LinkedBankAccountV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LinkedBankAccountV1FromRaw.FromRawUnchecked"/>
    public static LinkedBankAccountV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LinkedBankAccountV1FromRaw : IFromRawJson<LinkedBankAccountV1>
{
    /// <inheritdoc/>
    public LinkedBankAccountV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        LinkedBankAccountV1.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<LinkedBankAccountV1Data, LinkedBankAccountV1DataFromRaw>))]
public sealed record class LinkedBankAccountV1Data : JsonModel
{
    /// <summary>
    /// Unique identifier for the linked bank account.
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
    /// The unique identifier of the Straddle account related to this bank account.
    /// </summary>
    public required string? AccountID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("account_id");
        }
        init { this._rawData.Set("account_id", value); }
    }

    public required LinkedBankAccountV1DataBankAccount BankAccount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<LinkedBankAccountV1DataBankAccount>(
                "bank_account"
            );
        }
        init { this._rawData.Set("bank_account", value); }
    }

    /// <summary>
    /// Timestamp of when the bank account object was created.
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
    /// The purposes for the linked bank account.
    /// </summary>
    public required IReadOnlyList<ApiEnum<string, LinkedBankAccountV1DataPurpose>> Purposes
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<
                ImmutableArray<ApiEnum<string, LinkedBankAccountV1DataPurpose>>
            >("purposes");
        }
        init
        {
            this._rawData.Set<ImmutableArray<ApiEnum<string, LinkedBankAccountV1DataPurpose>>>(
                "purposes",
                ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// The current status of the linked bank account.
    /// </summary>
    public required ApiEnum<string, LinkedBankAccountV1DataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, LinkedBankAccountV1DataStatus>>(
                "status"
            );
        }
        init { this._rawData.Set("status", value); }
    }

    public required LinkedBankAccountV1DataStatusDetail StatusDetail
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<LinkedBankAccountV1DataStatusDetail>(
                "status_detail"
            );
        }
        init { this._rawData.Set("status_detail", value); }
    }

    /// <summary>
    /// Timestamp of the most recent update to the linked bank account.
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
    /// Optional description for the bank account.
    /// </summary>
    public string? Description
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("description");
        }
        init { this._rawData.Set("description", value); }
    }

    /// <summary>
    /// Up to 20 additional user-defined key-value pairs. Useful for storing additional
    /// information about the linked bank account in a structured format.
    /// </summary>
    public IReadOnlyDictionary<string, string?>? Metadata
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string?>>("metadata");
        }
        init
        {
            this._rawData.Set<FrozenDictionary<string, string?>?>(
                "metadata",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    /// <summary>
    /// The unique identifier of the Straddle Platform relatd to this bank account.
    /// </summary>
    public string? PlatformID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("platform_id");
        }
        init { this._rawData.Set("platform_id", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.AccountID;
        this.BankAccount.Validate();
        _ = this.CreatedAt;
        foreach (var item in this.Purposes)
        {
            item.Validate();
        }
        this.Status.Validate();
        this.StatusDetail.Validate();
        _ = this.UpdatedAt;
        _ = this.Description;
        _ = this.Metadata;
        _ = this.PlatformID;
    }

    public LinkedBankAccountV1Data() { }

    public LinkedBankAccountV1Data(LinkedBankAccountV1Data linkedBankAccountV1Data)
        : base(linkedBankAccountV1Data) { }

    public LinkedBankAccountV1Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LinkedBankAccountV1Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LinkedBankAccountV1DataFromRaw.FromRawUnchecked"/>
    public static LinkedBankAccountV1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LinkedBankAccountV1DataFromRaw : IFromRawJson<LinkedBankAccountV1Data>
{
    /// <inheritdoc/>
    public LinkedBankAccountV1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => LinkedBankAccountV1Data.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        LinkedBankAccountV1DataBankAccount,
        LinkedBankAccountV1DataBankAccountFromRaw
    >)
)]
public sealed record class LinkedBankAccountV1DataBankAccount : JsonModel
{
    public required string AccountHolder
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("account_holder");
        }
        init { this._rawData.Set("account_holder", value); }
    }

    public required string AccountMask
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("account_mask");
        }
        init { this._rawData.Set("account_mask", value); }
    }

    public required string InstitutionName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("institution_name");
        }
        init { this._rawData.Set("institution_name", value); }
    }

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
        _ = this.AccountHolder;
        _ = this.AccountMask;
        _ = this.InstitutionName;
        _ = this.RoutingNumber;
    }

    public LinkedBankAccountV1DataBankAccount() { }

    public LinkedBankAccountV1DataBankAccount(
        LinkedBankAccountV1DataBankAccount linkedBankAccountV1DataBankAccount
    )
        : base(linkedBankAccountV1DataBankAccount) { }

    public LinkedBankAccountV1DataBankAccount(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LinkedBankAccountV1DataBankAccount(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LinkedBankAccountV1DataBankAccountFromRaw.FromRawUnchecked"/>
    public static LinkedBankAccountV1DataBankAccount FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LinkedBankAccountV1DataBankAccountFromRaw : IFromRawJson<LinkedBankAccountV1DataBankAccount>
{
    /// <inheritdoc/>
    public LinkedBankAccountV1DataBankAccount FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => LinkedBankAccountV1DataBankAccount.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(LinkedBankAccountV1DataPurposeConverter))]
public enum LinkedBankAccountV1DataPurpose
{
    Charges,
    Payouts,
    Billing,
}

sealed class LinkedBankAccountV1DataPurposeConverter : JsonConverter<LinkedBankAccountV1DataPurpose>
{
    public override LinkedBankAccountV1DataPurpose Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "charges" => LinkedBankAccountV1DataPurpose.Charges,
            "payouts" => LinkedBankAccountV1DataPurpose.Payouts,
            "billing" => LinkedBankAccountV1DataPurpose.Billing,
            _ => (LinkedBankAccountV1DataPurpose)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkedBankAccountV1DataPurpose value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkedBankAccountV1DataPurpose.Charges => "charges",
                LinkedBankAccountV1DataPurpose.Payouts => "payouts",
                LinkedBankAccountV1DataPurpose.Billing => "billing",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// The current status of the linked bank account.
/// </summary>
[JsonConverter(typeof(LinkedBankAccountV1DataStatusConverter))]
public enum LinkedBankAccountV1DataStatus
{
    Created,
    Onboarding,
    Active,
    Rejected,
    Inactive,
    Canceled,
}

sealed class LinkedBankAccountV1DataStatusConverter : JsonConverter<LinkedBankAccountV1DataStatus>
{
    public override LinkedBankAccountV1DataStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created" => LinkedBankAccountV1DataStatus.Created,
            "onboarding" => LinkedBankAccountV1DataStatus.Onboarding,
            "active" => LinkedBankAccountV1DataStatus.Active,
            "rejected" => LinkedBankAccountV1DataStatus.Rejected,
            "inactive" => LinkedBankAccountV1DataStatus.Inactive,
            "canceled" => LinkedBankAccountV1DataStatus.Canceled,
            _ => (LinkedBankAccountV1DataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkedBankAccountV1DataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkedBankAccountV1DataStatus.Created => "created",
                LinkedBankAccountV1DataStatus.Onboarding => "onboarding",
                LinkedBankAccountV1DataStatus.Active => "active",
                LinkedBankAccountV1DataStatus.Rejected => "rejected",
                LinkedBankAccountV1DataStatus.Inactive => "inactive",
                LinkedBankAccountV1DataStatus.Canceled => "canceled",
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
        LinkedBankAccountV1DataStatusDetail,
        LinkedBankAccountV1DataStatusDetailFromRaw
    >)
)]
public sealed record class LinkedBankAccountV1DataStatusDetail : JsonModel
{
    /// <summary>
    /// A machine-readable code for the specific status, useful for programmatic handling.
    /// </summary>
    public required string Code
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("code");
        }
        init { this._rawData.Set("code", value); }
    }

    /// <summary>
    /// A human-readable message describing the current status.
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
    public required ApiEnum<string, LinkedBankAccountV1DataStatusDetailReason> Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, LinkedBankAccountV1DataStatusDetailReason>
            >("reason");
        }
        init { this._rawData.Set("reason", value); }
    }

    /// <summary>
    /// Identifies the origin of the status change (e.g., `watchtower`). This helps
    /// in tracking the cause of status updates.
    /// </summary>
    public required ApiEnum<string, LinkedBankAccountV1DataStatusDetailSource> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, LinkedBankAccountV1DataStatusDetailSource>
            >("source");
        }
        init { this._rawData.Set("source", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Code;
        _ = this.Message;
        this.Reason.Validate();
        this.Source.Validate();
    }

    public LinkedBankAccountV1DataStatusDetail() { }

    public LinkedBankAccountV1DataStatusDetail(
        LinkedBankAccountV1DataStatusDetail linkedBankAccountV1DataStatusDetail
    )
        : base(linkedBankAccountV1DataStatusDetail) { }

    public LinkedBankAccountV1DataStatusDetail(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LinkedBankAccountV1DataStatusDetail(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LinkedBankAccountV1DataStatusDetailFromRaw.FromRawUnchecked"/>
    public static LinkedBankAccountV1DataStatusDetail FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LinkedBankAccountV1DataStatusDetailFromRaw : IFromRawJson<LinkedBankAccountV1DataStatusDetail>
{
    /// <inheritdoc/>
    public LinkedBankAccountV1DataStatusDetail FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => LinkedBankAccountV1DataStatusDetail.FromRawUnchecked(rawData);
}

/// <summary>
/// A machine-readable identifier for the specific status, useful for programmatic handling.
/// </summary>
[JsonConverter(typeof(LinkedBankAccountV1DataStatusDetailReasonConverter))]
public enum LinkedBankAccountV1DataStatusDetailReason
{
    Unverified,
    InReview,
    Pending,
    Stuck,
    Verified,
    FailedVerification,
    Disabled,
    New,
}

sealed class LinkedBankAccountV1DataStatusDetailReasonConverter
    : JsonConverter<LinkedBankAccountV1DataStatusDetailReason>
{
    public override LinkedBankAccountV1DataStatusDetailReason Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "unverified" => LinkedBankAccountV1DataStatusDetailReason.Unverified,
            "in_review" => LinkedBankAccountV1DataStatusDetailReason.InReview,
            "pending" => LinkedBankAccountV1DataStatusDetailReason.Pending,
            "stuck" => LinkedBankAccountV1DataStatusDetailReason.Stuck,
            "verified" => LinkedBankAccountV1DataStatusDetailReason.Verified,
            "failed_verification" => LinkedBankAccountV1DataStatusDetailReason.FailedVerification,
            "disabled" => LinkedBankAccountV1DataStatusDetailReason.Disabled,
            "new" => LinkedBankAccountV1DataStatusDetailReason.New,
            _ => (LinkedBankAccountV1DataStatusDetailReason)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkedBankAccountV1DataStatusDetailReason value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkedBankAccountV1DataStatusDetailReason.Unverified => "unverified",
                LinkedBankAccountV1DataStatusDetailReason.InReview => "in_review",
                LinkedBankAccountV1DataStatusDetailReason.Pending => "pending",
                LinkedBankAccountV1DataStatusDetailReason.Stuck => "stuck",
                LinkedBankAccountV1DataStatusDetailReason.Verified => "verified",
                LinkedBankAccountV1DataStatusDetailReason.FailedVerification =>
                    "failed_verification",
                LinkedBankAccountV1DataStatusDetailReason.Disabled => "disabled",
                LinkedBankAccountV1DataStatusDetailReason.New => "new",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Identifies the origin of the status change (e.g., `watchtower`). This helps in
/// tracking the cause of status updates.
/// </summary>
[JsonConverter(typeof(LinkedBankAccountV1DataStatusDetailSourceConverter))]
public enum LinkedBankAccountV1DataStatusDetailSource
{
    Watchtower,
}

sealed class LinkedBankAccountV1DataStatusDetailSourceConverter
    : JsonConverter<LinkedBankAccountV1DataStatusDetailSource>
{
    public override LinkedBankAccountV1DataStatusDetailSource Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "watchtower" => LinkedBankAccountV1DataStatusDetailSource.Watchtower,
            _ => (LinkedBankAccountV1DataStatusDetailSource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkedBankAccountV1DataStatusDetailSource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkedBankAccountV1DataStatusDetailSource.Watchtower => "watchtower",
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
[JsonConverter(typeof(LinkedBankAccountV1ResponseTypeConverter))]
public enum LinkedBankAccountV1ResponseType
{
    Object,
    Array,
    Error,
    None,
}

sealed class LinkedBankAccountV1ResponseTypeConverter
    : JsonConverter<LinkedBankAccountV1ResponseType>
{
    public override LinkedBankAccountV1ResponseType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "object" => LinkedBankAccountV1ResponseType.Object,
            "array" => LinkedBankAccountV1ResponseType.Array,
            "error" => LinkedBankAccountV1ResponseType.Error,
            "none" => LinkedBankAccountV1ResponseType.None,
            _ => (LinkedBankAccountV1ResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkedBankAccountV1ResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkedBankAccountV1ResponseType.Object => "object",
                LinkedBankAccountV1ResponseType.Array => "array",
                LinkedBankAccountV1ResponseType.Error => "error",
                LinkedBankAccountV1ResponseType.None => "none",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
