using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Embed.LinkedBankAccounts;

[JsonConverter(
    typeof(JsonModelConverter<LinkedBankAccountUnmaskV1, LinkedBankAccountUnmaskV1FromRaw>)
)]
public sealed record class LinkedBankAccountUnmaskV1 : JsonModel
{
    public required LinkedBankAccountUnmaskV1Data Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<LinkedBankAccountUnmaskV1Data>("data");
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
    public required ApiEnum<string, LinkedBankAccountUnmaskV1ResponseType> ResponseType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, LinkedBankAccountUnmaskV1ResponseType>
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

    public LinkedBankAccountUnmaskV1() { }

    public LinkedBankAccountUnmaskV1(LinkedBankAccountUnmaskV1 linkedBankAccountUnmaskV1)
        : base(linkedBankAccountUnmaskV1) { }

    public LinkedBankAccountUnmaskV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LinkedBankAccountUnmaskV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LinkedBankAccountUnmaskV1FromRaw.FromRawUnchecked"/>
    public static LinkedBankAccountUnmaskV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LinkedBankAccountUnmaskV1FromRaw : IFromRawJson<LinkedBankAccountUnmaskV1>
{
    /// <inheritdoc/>
    public LinkedBankAccountUnmaskV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => LinkedBankAccountUnmaskV1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<LinkedBankAccountUnmaskV1Data, LinkedBankAccountUnmaskV1DataFromRaw>)
)]
public sealed record class LinkedBankAccountUnmaskV1Data : JsonModel
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
    /// Unique identifier for the Straddle account related to this bank account.
    /// </summary>
    public required string AccountID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("account_id");
        }
        init { this._rawData.Set("account_id", value); }
    }

    /// <summary>
    /// The bank account details associated with the linked bank account.
    /// </summary>
    public required LinkedBankAccountUnmaskV1DataBankAccount BankAccount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<LinkedBankAccountUnmaskV1DataBankAccount>(
                "bank_account"
            );
        }
        init { this._rawData.Set("bank_account", value); }
    }

    /// <summary>
    /// Timestamp of when the linked bank account was created.
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
    /// The current status of the linked bank account.
    /// </summary>
    public required ApiEnum<string, LinkedBankAccountUnmaskV1DataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, LinkedBankAccountUnmaskV1DataStatus>
            >("status");
        }
        init { this._rawData.Set("status", value); }
    }

    /// <summary>
    /// Additional details about the current status of the linked bank account.
    /// </summary>
    public required LinkedBankAccountUnmaskV1DataStatusDetail StatusDetail
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<LinkedBankAccountUnmaskV1DataStatusDetail>(
                "status_detail"
            );
        }
        init { this._rawData.Set("status_detail", value); }
    }

    /// <summary>
    /// Timestamp of when the linked bank account was last updated.
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.AccountID;
        this.BankAccount.Validate();
        _ = this.CreatedAt;
        this.Status.Validate();
        this.StatusDetail.Validate();
        _ = this.UpdatedAt;
        _ = this.Metadata;
    }

    public LinkedBankAccountUnmaskV1Data() { }

    public LinkedBankAccountUnmaskV1Data(
        LinkedBankAccountUnmaskV1Data linkedBankAccountUnmaskV1Data
    )
        : base(linkedBankAccountUnmaskV1Data) { }

    public LinkedBankAccountUnmaskV1Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LinkedBankAccountUnmaskV1Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LinkedBankAccountUnmaskV1DataFromRaw.FromRawUnchecked"/>
    public static LinkedBankAccountUnmaskV1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LinkedBankAccountUnmaskV1DataFromRaw : IFromRawJson<LinkedBankAccountUnmaskV1Data>
{
    /// <inheritdoc/>
    public LinkedBankAccountUnmaskV1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => LinkedBankAccountUnmaskV1Data.FromRawUnchecked(rawData);
}

/// <summary>
/// The bank account details associated with the linked bank account.
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        LinkedBankAccountUnmaskV1DataBankAccount,
        LinkedBankAccountUnmaskV1DataBankAccountFromRaw
    >)
)]
public sealed record class LinkedBankAccountUnmaskV1DataBankAccount : JsonModel
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

    public required string AccountNumber
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("account_number");
        }
        init { this._rawData.Set("account_number", value); }
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
        _ = this.AccountNumber;
        _ = this.InstitutionName;
        _ = this.RoutingNumber;
    }

    public LinkedBankAccountUnmaskV1DataBankAccount() { }

    public LinkedBankAccountUnmaskV1DataBankAccount(
        LinkedBankAccountUnmaskV1DataBankAccount linkedBankAccountUnmaskV1DataBankAccount
    )
        : base(linkedBankAccountUnmaskV1DataBankAccount) { }

    public LinkedBankAccountUnmaskV1DataBankAccount(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LinkedBankAccountUnmaskV1DataBankAccount(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LinkedBankAccountUnmaskV1DataBankAccountFromRaw.FromRawUnchecked"/>
    public static LinkedBankAccountUnmaskV1DataBankAccount FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LinkedBankAccountUnmaskV1DataBankAccountFromRaw
    : IFromRawJson<LinkedBankAccountUnmaskV1DataBankAccount>
{
    /// <inheritdoc/>
    public LinkedBankAccountUnmaskV1DataBankAccount FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => LinkedBankAccountUnmaskV1DataBankAccount.FromRawUnchecked(rawData);
}

/// <summary>
/// The current status of the linked bank account.
/// </summary>
[JsonConverter(typeof(LinkedBankAccountUnmaskV1DataStatusConverter))]
public enum LinkedBankAccountUnmaskV1DataStatus
{
    Created,
    Onboarding,
    Active,
    Rejected,
    Inactive,
    Canceled,
}

sealed class LinkedBankAccountUnmaskV1DataStatusConverter
    : JsonConverter<LinkedBankAccountUnmaskV1DataStatus>
{
    public override LinkedBankAccountUnmaskV1DataStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created" => LinkedBankAccountUnmaskV1DataStatus.Created,
            "onboarding" => LinkedBankAccountUnmaskV1DataStatus.Onboarding,
            "active" => LinkedBankAccountUnmaskV1DataStatus.Active,
            "rejected" => LinkedBankAccountUnmaskV1DataStatus.Rejected,
            "inactive" => LinkedBankAccountUnmaskV1DataStatus.Inactive,
            "canceled" => LinkedBankAccountUnmaskV1DataStatus.Canceled,
            _ => (LinkedBankAccountUnmaskV1DataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkedBankAccountUnmaskV1DataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkedBankAccountUnmaskV1DataStatus.Created => "created",
                LinkedBankAccountUnmaskV1DataStatus.Onboarding => "onboarding",
                LinkedBankAccountUnmaskV1DataStatus.Active => "active",
                LinkedBankAccountUnmaskV1DataStatus.Rejected => "rejected",
                LinkedBankAccountUnmaskV1DataStatus.Inactive => "inactive",
                LinkedBankAccountUnmaskV1DataStatus.Canceled => "canceled",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Additional details about the current status of the linked bank account.
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        LinkedBankAccountUnmaskV1DataStatusDetail,
        LinkedBankAccountUnmaskV1DataStatusDetailFromRaw
    >)
)]
public sealed record class LinkedBankAccountUnmaskV1DataStatusDetail : JsonModel
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
    public required ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailReason> Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailReason>
            >("reason");
        }
        init { this._rawData.Set("reason", value); }
    }

    /// <summary>
    /// Identifies the origin of the status change (e.g., `watchtower`). This helps
    /// in tracking the cause of status updates.
    /// </summary>
    public required ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailSource> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailSource>
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

    public LinkedBankAccountUnmaskV1DataStatusDetail() { }

    public LinkedBankAccountUnmaskV1DataStatusDetail(
        LinkedBankAccountUnmaskV1DataStatusDetail linkedBankAccountUnmaskV1DataStatusDetail
    )
        : base(linkedBankAccountUnmaskV1DataStatusDetail) { }

    public LinkedBankAccountUnmaskV1DataStatusDetail(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    LinkedBankAccountUnmaskV1DataStatusDetail(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="LinkedBankAccountUnmaskV1DataStatusDetailFromRaw.FromRawUnchecked"/>
    public static LinkedBankAccountUnmaskV1DataStatusDetail FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class LinkedBankAccountUnmaskV1DataStatusDetailFromRaw
    : IFromRawJson<LinkedBankAccountUnmaskV1DataStatusDetail>
{
    /// <inheritdoc/>
    public LinkedBankAccountUnmaskV1DataStatusDetail FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => LinkedBankAccountUnmaskV1DataStatusDetail.FromRawUnchecked(rawData);
}

/// <summary>
/// A machine-readable identifier for the specific status, useful for programmatic handling.
/// </summary>
[JsonConverter(typeof(LinkedBankAccountUnmaskV1DataStatusDetailReasonConverter))]
public enum LinkedBankAccountUnmaskV1DataStatusDetailReason
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

sealed class LinkedBankAccountUnmaskV1DataStatusDetailReasonConverter
    : JsonConverter<LinkedBankAccountUnmaskV1DataStatusDetailReason>
{
    public override LinkedBankAccountUnmaskV1DataStatusDetailReason Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "unverified" => LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
            "in_review" => LinkedBankAccountUnmaskV1DataStatusDetailReason.InReview,
            "pending" => LinkedBankAccountUnmaskV1DataStatusDetailReason.Pending,
            "stuck" => LinkedBankAccountUnmaskV1DataStatusDetailReason.Stuck,
            "verified" => LinkedBankAccountUnmaskV1DataStatusDetailReason.Verified,
            "failed_verification" =>
                LinkedBankAccountUnmaskV1DataStatusDetailReason.FailedVerification,
            "disabled" => LinkedBankAccountUnmaskV1DataStatusDetailReason.Disabled,
            "new" => LinkedBankAccountUnmaskV1DataStatusDetailReason.New,
            _ => (LinkedBankAccountUnmaskV1DataStatusDetailReason)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkedBankAccountUnmaskV1DataStatusDetailReason value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified => "unverified",
                LinkedBankAccountUnmaskV1DataStatusDetailReason.InReview => "in_review",
                LinkedBankAccountUnmaskV1DataStatusDetailReason.Pending => "pending",
                LinkedBankAccountUnmaskV1DataStatusDetailReason.Stuck => "stuck",
                LinkedBankAccountUnmaskV1DataStatusDetailReason.Verified => "verified",
                LinkedBankAccountUnmaskV1DataStatusDetailReason.FailedVerification =>
                    "failed_verification",
                LinkedBankAccountUnmaskV1DataStatusDetailReason.Disabled => "disabled",
                LinkedBankAccountUnmaskV1DataStatusDetailReason.New => "new",
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
[JsonConverter(typeof(LinkedBankAccountUnmaskV1DataStatusDetailSourceConverter))]
public enum LinkedBankAccountUnmaskV1DataStatusDetailSource
{
    Watchtower,
}

sealed class LinkedBankAccountUnmaskV1DataStatusDetailSourceConverter
    : JsonConverter<LinkedBankAccountUnmaskV1DataStatusDetailSource>
{
    public override LinkedBankAccountUnmaskV1DataStatusDetailSource Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "watchtower" => LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
            _ => (LinkedBankAccountUnmaskV1DataStatusDetailSource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkedBankAccountUnmaskV1DataStatusDetailSource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower => "watchtower",
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
[JsonConverter(typeof(LinkedBankAccountUnmaskV1ResponseTypeConverter))]
public enum LinkedBankAccountUnmaskV1ResponseType
{
    Object,
    Array,
    Error,
    None,
}

sealed class LinkedBankAccountUnmaskV1ResponseTypeConverter
    : JsonConverter<LinkedBankAccountUnmaskV1ResponseType>
{
    public override LinkedBankAccountUnmaskV1ResponseType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "object" => LinkedBankAccountUnmaskV1ResponseType.Object,
            "array" => LinkedBankAccountUnmaskV1ResponseType.Array,
            "error" => LinkedBankAccountUnmaskV1ResponseType.Error,
            "none" => LinkedBankAccountUnmaskV1ResponseType.None,
            _ => (LinkedBankAccountUnmaskV1ResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        LinkedBankAccountUnmaskV1ResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                LinkedBankAccountUnmaskV1ResponseType.Object => "object",
                LinkedBankAccountUnmaskV1ResponseType.Array => "array",
                LinkedBankAccountUnmaskV1ResponseType.Error => "error",
                LinkedBankAccountUnmaskV1ResponseType.None => "none",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
