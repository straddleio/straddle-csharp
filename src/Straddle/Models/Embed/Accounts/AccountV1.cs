using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;
using System = System;

namespace Straddle.Models.Embed.Accounts;

[JsonConverter(typeof(JsonModelConverter<AccountV1, AccountV1FromRaw>))]
public sealed record class AccountV1 : JsonModel
{
    public required AccountV1Data Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<AccountV1Data>("data");
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
    public required ApiEnum<string, AccountV1ResponseType> ResponseType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, AccountV1ResponseType>>(
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

    public AccountV1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountV1(AccountV1 accountV1)
        : base(accountV1) { }
#pragma warning restore CS8618

    public AccountV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountV1FromRaw.FromRawUnchecked"/>
    public static AccountV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountV1FromRaw : IFromRawJson<AccountV1>
{
    /// <inheritdoc/>
    public AccountV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        AccountV1.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<AccountV1Data, AccountV1DataFromRaw>))]
public sealed record class AccountV1Data : JsonModel
{
    /// <summary>
    /// Unique identifier for the account.
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
    /// The access level granted to the account. This is determined by your platform
    /// configuration. Use `standard` unless instructed otherwise by Straddle.
    /// </summary>
    public required ApiEnum<string, AccountV1DataAccessLevel> AccessLevel
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, AccountV1DataAccessLevel>>(
                "access_level"
            );
        }
        init { this._rawData.Set("access_level", value); }
    }

    /// <summary>
    /// The unique identifier of the organization this account belongs to.
    /// </summary>
    public required string OrganizationID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("organization_id");
        }
        init { this._rawData.Set("organization_id", value); }
    }

    /// <summary>
    /// The current status of the account (e.g., 'active', 'inactive', 'pending').
    /// </summary>
    public required ApiEnum<string, AccountV1DataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, AccountV1DataStatus>>("status");
        }
        init { this._rawData.Set("status", value); }
    }

    public required AccountV1DataStatusDetail StatusDetail
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<AccountV1DataStatusDetail>("status_detail");
        }
        init { this._rawData.Set("status_detail", value); }
    }

    /// <summary>
    /// The type of account (e.g., 'individual', 'business').
    /// </summary>
    public required ApiEnum<string, AccountV1DataType> Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, AccountV1DataType>>("type");
        }
        init { this._rawData.Set("type", value); }
    }

    public BusinessProfileV1? BusinessProfile
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<BusinessProfileV1>("business_profile");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("business_profile", value);
        }
    }

    public AccountV1DataCapabilities? Capabilities
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AccountV1DataCapabilities>("capabilities");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("capabilities", value);
        }
    }

    /// <summary>
    /// Timestamp of when the account was created.
    /// </summary>
    public System::DateTimeOffset? CreatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<System::DateTimeOffset>("created_at");
        }
        init { this._rawData.Set("created_at", value); }
    }

    /// <summary>
    /// Unique identifier for the account in your database, used for cross-referencing
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
    /// Up to 20 additional user-defined key-value pairs. Useful for storing additional
    /// information about the account in a structured format.
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

    public AccountV1DataSettings? Settings
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AccountV1DataSettings>("settings");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("settings", value);
        }
    }

    public TermsOfServiceV1? TermsOfService
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TermsOfServiceV1>("terms_of_service");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("terms_of_service", value);
        }
    }

    /// <summary>
    /// Timestamp of the most recent update to the account.
    /// </summary>
    public System::DateTimeOffset? UpdatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<System::DateTimeOffset>("updated_at");
        }
        init { this._rawData.Set("updated_at", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        this.AccessLevel.Validate();
        _ = this.OrganizationID;
        this.Status.Validate();
        this.StatusDetail.Validate();
        this.Type.Validate();
        this.BusinessProfile?.Validate();
        this.Capabilities?.Validate();
        _ = this.CreatedAt;
        _ = this.ExternalID;
        _ = this.Metadata;
        this.Settings?.Validate();
        this.TermsOfService?.Validate();
        _ = this.UpdatedAt;
    }

    public AccountV1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountV1Data(AccountV1Data accountV1Data)
        : base(accountV1Data) { }
#pragma warning restore CS8618

    public AccountV1Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountV1Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountV1DataFromRaw.FromRawUnchecked"/>
    public static AccountV1Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountV1DataFromRaw : IFromRawJson<AccountV1Data>
{
    /// <inheritdoc/>
    public AccountV1Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        AccountV1Data.FromRawUnchecked(rawData);
}

/// <summary>
/// The access level granted to the account. This is determined by your platform configuration.
/// Use `standard` unless instructed otherwise by Straddle.
/// </summary>
[JsonConverter(typeof(AccountV1DataAccessLevelConverter))]
public enum AccountV1DataAccessLevel
{
    Standard,
    Managed,
}

sealed class AccountV1DataAccessLevelConverter : JsonConverter<AccountV1DataAccessLevel>
{
    public override AccountV1DataAccessLevel Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "standard" => AccountV1DataAccessLevel.Standard,
            "managed" => AccountV1DataAccessLevel.Managed,
            _ => (AccountV1DataAccessLevel)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AccountV1DataAccessLevel value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AccountV1DataAccessLevel.Standard => "standard",
                AccountV1DataAccessLevel.Managed => "managed",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// The current status of the account (e.g., 'active', 'inactive', 'pending').
/// </summary>
[JsonConverter(typeof(AccountV1DataStatusConverter))]
public enum AccountV1DataStatus
{
    Created,
    Onboarding,
    Active,
    Rejected,
    Inactive,
}

sealed class AccountV1DataStatusConverter : JsonConverter<AccountV1DataStatus>
{
    public override AccountV1DataStatus Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created" => AccountV1DataStatus.Created,
            "onboarding" => AccountV1DataStatus.Onboarding,
            "active" => AccountV1DataStatus.Active,
            "rejected" => AccountV1DataStatus.Rejected,
            "inactive" => AccountV1DataStatus.Inactive,
            _ => (AccountV1DataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AccountV1DataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AccountV1DataStatus.Created => "created",
                AccountV1DataStatus.Onboarding => "onboarding",
                AccountV1DataStatus.Active => "active",
                AccountV1DataStatus.Rejected => "rejected",
                AccountV1DataStatus.Inactive => "inactive",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(
    typeof(JsonModelConverter<AccountV1DataStatusDetail, AccountV1DataStatusDetailFromRaw>)
)]
public sealed record class AccountV1DataStatusDetail : JsonModel
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
    public required ApiEnum<string, AccountV1DataStatusDetailReason> Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, AccountV1DataStatusDetailReason>>(
                "reason"
            );
        }
        init { this._rawData.Set("reason", value); }
    }

    /// <summary>
    /// Identifies the origin of the status change (e.g., `bank_decline`, `watchtower`).
    /// This helps in tracking the cause of status updates.
    /// </summary>
    public required ApiEnum<string, AccountV1DataStatusDetailSource> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, AccountV1DataStatusDetailSource>>(
                "source"
            );
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

    public AccountV1DataStatusDetail() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountV1DataStatusDetail(AccountV1DataStatusDetail accountV1DataStatusDetail)
        : base(accountV1DataStatusDetail) { }
#pragma warning restore CS8618

    public AccountV1DataStatusDetail(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountV1DataStatusDetail(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountV1DataStatusDetailFromRaw.FromRawUnchecked"/>
    public static AccountV1DataStatusDetail FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountV1DataStatusDetailFromRaw : IFromRawJson<AccountV1DataStatusDetail>
{
    /// <inheritdoc/>
    public AccountV1DataStatusDetail FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AccountV1DataStatusDetail.FromRawUnchecked(rawData);
}

/// <summary>
/// A machine-readable identifier for the specific status, useful for programmatic handling.
/// </summary>
[JsonConverter(typeof(AccountV1DataStatusDetailReasonConverter))]
public enum AccountV1DataStatusDetailReason
{
    Unverified,
    InReview,
    Pending,
    Stuck,
    Verified,
    FailedVerification,
    Disabled,
    Terminated,
    New,
}

sealed class AccountV1DataStatusDetailReasonConverter
    : JsonConverter<AccountV1DataStatusDetailReason>
{
    public override AccountV1DataStatusDetailReason Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "unverified" => AccountV1DataStatusDetailReason.Unverified,
            "in_review" => AccountV1DataStatusDetailReason.InReview,
            "pending" => AccountV1DataStatusDetailReason.Pending,
            "stuck" => AccountV1DataStatusDetailReason.Stuck,
            "verified" => AccountV1DataStatusDetailReason.Verified,
            "failed_verification" => AccountV1DataStatusDetailReason.FailedVerification,
            "disabled" => AccountV1DataStatusDetailReason.Disabled,
            "terminated" => AccountV1DataStatusDetailReason.Terminated,
            "new" => AccountV1DataStatusDetailReason.New,
            _ => (AccountV1DataStatusDetailReason)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AccountV1DataStatusDetailReason value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AccountV1DataStatusDetailReason.Unverified => "unverified",
                AccountV1DataStatusDetailReason.InReview => "in_review",
                AccountV1DataStatusDetailReason.Pending => "pending",
                AccountV1DataStatusDetailReason.Stuck => "stuck",
                AccountV1DataStatusDetailReason.Verified => "verified",
                AccountV1DataStatusDetailReason.FailedVerification => "failed_verification",
                AccountV1DataStatusDetailReason.Disabled => "disabled",
                AccountV1DataStatusDetailReason.Terminated => "terminated",
                AccountV1DataStatusDetailReason.New => "new",
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
[JsonConverter(typeof(AccountV1DataStatusDetailSourceConverter))]
public enum AccountV1DataStatusDetailSource
{
    Watchtower,
}

sealed class AccountV1DataStatusDetailSourceConverter
    : JsonConverter<AccountV1DataStatusDetailSource>
{
    public override AccountV1DataStatusDetailSource Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "watchtower" => AccountV1DataStatusDetailSource.Watchtower,
            _ => (AccountV1DataStatusDetailSource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AccountV1DataStatusDetailSource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AccountV1DataStatusDetailSource.Watchtower => "watchtower",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// The type of account (e.g., 'individual', 'business').
/// </summary>
[JsonConverter(typeof(AccountV1DataTypeConverter))]
public enum AccountV1DataType
{
    Business,
}

sealed class AccountV1DataTypeConverter : JsonConverter<AccountV1DataType>
{
    public override AccountV1DataType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "business" => AccountV1DataType.Business,
            _ => (AccountV1DataType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AccountV1DataType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AccountV1DataType.Business => "business",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(
    typeof(JsonModelConverter<AccountV1DataCapabilities, AccountV1DataCapabilitiesFromRaw>)
)]
public sealed record class AccountV1DataCapabilities : JsonModel
{
    public required AccountV1DataCapabilitiesConsentTypes ConsentTypes
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<AccountV1DataCapabilitiesConsentTypes>(
                "consent_types"
            );
        }
        init { this._rawData.Set("consent_types", value); }
    }

    public required AccountV1DataCapabilitiesCustomerTypes CustomerTypes
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<AccountV1DataCapabilitiesCustomerTypes>(
                "customer_types"
            );
        }
        init { this._rawData.Set("customer_types", value); }
    }

    public required AccountV1DataCapabilitiesPaymentTypes PaymentTypes
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<AccountV1DataCapabilitiesPaymentTypes>(
                "payment_types"
            );
        }
        init { this._rawData.Set("payment_types", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.ConsentTypes.Validate();
        this.CustomerTypes.Validate();
        this.PaymentTypes.Validate();
    }

    public AccountV1DataCapabilities() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountV1DataCapabilities(AccountV1DataCapabilities accountV1DataCapabilities)
        : base(accountV1DataCapabilities) { }
#pragma warning restore CS8618

    public AccountV1DataCapabilities(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountV1DataCapabilities(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountV1DataCapabilitiesFromRaw.FromRawUnchecked"/>
    public static AccountV1DataCapabilities FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountV1DataCapabilitiesFromRaw : IFromRawJson<AccountV1DataCapabilities>
{
    /// <inheritdoc/>
    public AccountV1DataCapabilities FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AccountV1DataCapabilities.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AccountV1DataCapabilitiesConsentTypes,
        AccountV1DataCapabilitiesConsentTypesFromRaw
    >)
)]
public sealed record class AccountV1DataCapabilitiesConsentTypes : JsonModel
{
    /// <summary>
    /// Whether the internet payment authorization capability is enabled for the account.
    /// </summary>
    public required CapabilityV1 Internet
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<CapabilityV1>("internet");
        }
        init { this._rawData.Set("internet", value); }
    }

    /// <summary>
    /// Whether the signed agreement payment authorization capability is enabled for
    /// the account.
    /// </summary>
    public required CapabilityV1 SignedAgreement
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<CapabilityV1>("signed_agreement");
        }
        init { this._rawData.Set("signed_agreement", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Internet.Validate();
        this.SignedAgreement.Validate();
    }

    public AccountV1DataCapabilitiesConsentTypes() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountV1DataCapabilitiesConsentTypes(
        AccountV1DataCapabilitiesConsentTypes accountV1DataCapabilitiesConsentTypes
    )
        : base(accountV1DataCapabilitiesConsentTypes) { }
#pragma warning restore CS8618

    public AccountV1DataCapabilitiesConsentTypes(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountV1DataCapabilitiesConsentTypes(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountV1DataCapabilitiesConsentTypesFromRaw.FromRawUnchecked"/>
    public static AccountV1DataCapabilitiesConsentTypes FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountV1DataCapabilitiesConsentTypesFromRaw
    : IFromRawJson<AccountV1DataCapabilitiesConsentTypes>
{
    /// <inheritdoc/>
    public AccountV1DataCapabilitiesConsentTypes FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AccountV1DataCapabilitiesConsentTypes.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AccountV1DataCapabilitiesCustomerTypes,
        AccountV1DataCapabilitiesCustomerTypesFromRaw
    >)
)]
public sealed record class AccountV1DataCapabilitiesCustomerTypes : JsonModel
{
    public required CapabilityV1 Businesses
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<CapabilityV1>("businesses");
        }
        init { this._rawData.Set("businesses", value); }
    }

    public required CapabilityV1 Individuals
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<CapabilityV1>("individuals");
        }
        init { this._rawData.Set("individuals", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Businesses.Validate();
        this.Individuals.Validate();
    }

    public AccountV1DataCapabilitiesCustomerTypes() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountV1DataCapabilitiesCustomerTypes(
        AccountV1DataCapabilitiesCustomerTypes accountV1DataCapabilitiesCustomerTypes
    )
        : base(accountV1DataCapabilitiesCustomerTypes) { }
#pragma warning restore CS8618

    public AccountV1DataCapabilitiesCustomerTypes(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountV1DataCapabilitiesCustomerTypes(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountV1DataCapabilitiesCustomerTypesFromRaw.FromRawUnchecked"/>
    public static AccountV1DataCapabilitiesCustomerTypes FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountV1DataCapabilitiesCustomerTypesFromRaw
    : IFromRawJson<AccountV1DataCapabilitiesCustomerTypes>
{
    /// <inheritdoc/>
    public AccountV1DataCapabilitiesCustomerTypes FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AccountV1DataCapabilitiesCustomerTypes.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AccountV1DataCapabilitiesPaymentTypes,
        AccountV1DataCapabilitiesPaymentTypesFromRaw
    >)
)]
public sealed record class AccountV1DataCapabilitiesPaymentTypes : JsonModel
{
    public required CapabilityV1 Charges
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<CapabilityV1>("charges");
        }
        init { this._rawData.Set("charges", value); }
    }

    public required CapabilityV1 Payouts
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<CapabilityV1>("payouts");
        }
        init { this._rawData.Set("payouts", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Charges.Validate();
        this.Payouts.Validate();
    }

    public AccountV1DataCapabilitiesPaymentTypes() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountV1DataCapabilitiesPaymentTypes(
        AccountV1DataCapabilitiesPaymentTypes accountV1DataCapabilitiesPaymentTypes
    )
        : base(accountV1DataCapabilitiesPaymentTypes) { }
#pragma warning restore CS8618

    public AccountV1DataCapabilitiesPaymentTypes(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountV1DataCapabilitiesPaymentTypes(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountV1DataCapabilitiesPaymentTypesFromRaw.FromRawUnchecked"/>
    public static AccountV1DataCapabilitiesPaymentTypes FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountV1DataCapabilitiesPaymentTypesFromRaw
    : IFromRawJson<AccountV1DataCapabilitiesPaymentTypes>
{
    /// <inheritdoc/>
    public AccountV1DataCapabilitiesPaymentTypes FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AccountV1DataCapabilitiesPaymentTypes.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<AccountV1DataSettings, AccountV1DataSettingsFromRaw>))]
public sealed record class AccountV1DataSettings : JsonModel
{
    public required AccountV1DataSettingsCharges Charges
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<AccountV1DataSettingsCharges>("charges");
        }
        init { this._rawData.Set("charges", value); }
    }

    public required AccountV1DataSettingsPayouts Payouts
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<AccountV1DataSettingsPayouts>("payouts");
        }
        init { this._rawData.Set("payouts", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Charges.Validate();
        this.Payouts.Validate();
    }

    public AccountV1DataSettings() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountV1DataSettings(AccountV1DataSettings accountV1DataSettings)
        : base(accountV1DataSettings) { }
#pragma warning restore CS8618

    public AccountV1DataSettings(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountV1DataSettings(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountV1DataSettingsFromRaw.FromRawUnchecked"/>
    public static AccountV1DataSettings FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountV1DataSettingsFromRaw : IFromRawJson<AccountV1DataSettings>
{
    /// <inheritdoc/>
    public AccountV1DataSettings FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AccountV1DataSettings.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<AccountV1DataSettingsCharges, AccountV1DataSettingsChargesFromRaw>)
)]
public sealed record class AccountV1DataSettingsCharges : JsonModel
{
    /// <summary>
    /// The maximum dollar amount of charges in a calendar day.
    /// </summary>
    public required int DailyAmount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("daily_amount");
        }
        init { this._rawData.Set("daily_amount", value); }
    }

    /// <summary>
    /// The amount of time it takes for a charge to be funded. This value is defined
    /// by Straddle.
    /// </summary>
    public required ApiEnum<string, AccountV1DataSettingsChargesFundingTime> FundingTime
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, AccountV1DataSettingsChargesFundingTime>
            >("funding_time");
        }
        init { this._rawData.Set("funding_time", value); }
    }

    /// <summary>
    /// The unique identifier of the linked bank account associated with charges.
    /// This value is defined by Straddle.
    /// </summary>
    public required string LinkedBankAccountID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("linked_bank_account_id");
        }
        init { this._rawData.Set("linked_bank_account_id", value); }
    }

    /// <summary>
    /// The maximum amount of a single charge.
    /// </summary>
    public required int MaxAmount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("max_amount");
        }
        init { this._rawData.Set("max_amount", value); }
    }

    /// <summary>
    /// The maximum dollar amount of charges in a calendar month.
    /// </summary>
    public required int MonthlyAmount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("monthly_amount");
        }
        init { this._rawData.Set("monthly_amount", value); }
    }

    /// <summary>
    /// The maximum number of charges in a calendar month.
    /// </summary>
    public required int MonthlyCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("monthly_count");
        }
        init { this._rawData.Set("monthly_count", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.DailyAmount;
        this.FundingTime.Validate();
        _ = this.LinkedBankAccountID;
        _ = this.MaxAmount;
        _ = this.MonthlyAmount;
        _ = this.MonthlyCount;
    }

    public AccountV1DataSettingsCharges() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountV1DataSettingsCharges(AccountV1DataSettingsCharges accountV1DataSettingsCharges)
        : base(accountV1DataSettingsCharges) { }
#pragma warning restore CS8618

    public AccountV1DataSettingsCharges(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountV1DataSettingsCharges(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountV1DataSettingsChargesFromRaw.FromRawUnchecked"/>
    public static AccountV1DataSettingsCharges FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountV1DataSettingsChargesFromRaw : IFromRawJson<AccountV1DataSettingsCharges>
{
    /// <inheritdoc/>
    public AccountV1DataSettingsCharges FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AccountV1DataSettingsCharges.FromRawUnchecked(rawData);
}

/// <summary>
/// The amount of time it takes for a charge to be funded. This value is defined
/// by Straddle.
/// </summary>
[JsonConverter(typeof(AccountV1DataSettingsChargesFundingTimeConverter))]
public enum AccountV1DataSettingsChargesFundingTime
{
    Immediate,
    NextDay,
    OneDay,
    TwoDay,
    ThreeDay,
}

sealed class AccountV1DataSettingsChargesFundingTimeConverter
    : JsonConverter<AccountV1DataSettingsChargesFundingTime>
{
    public override AccountV1DataSettingsChargesFundingTime Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "immediate" => AccountV1DataSettingsChargesFundingTime.Immediate,
            "next_day" => AccountV1DataSettingsChargesFundingTime.NextDay,
            "one_day" => AccountV1DataSettingsChargesFundingTime.OneDay,
            "two_day" => AccountV1DataSettingsChargesFundingTime.TwoDay,
            "three_day" => AccountV1DataSettingsChargesFundingTime.ThreeDay,
            _ => (AccountV1DataSettingsChargesFundingTime)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AccountV1DataSettingsChargesFundingTime value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AccountV1DataSettingsChargesFundingTime.Immediate => "immediate",
                AccountV1DataSettingsChargesFundingTime.NextDay => "next_day",
                AccountV1DataSettingsChargesFundingTime.OneDay => "one_day",
                AccountV1DataSettingsChargesFundingTime.TwoDay => "two_day",
                AccountV1DataSettingsChargesFundingTime.ThreeDay => "three_day",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(
    typeof(JsonModelConverter<AccountV1DataSettingsPayouts, AccountV1DataSettingsPayoutsFromRaw>)
)]
public sealed record class AccountV1DataSettingsPayouts : JsonModel
{
    /// <summary>
    /// The maximum dollar amount of payouts in a day.
    /// </summary>
    public required int DailyAmount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("daily_amount");
        }
        init { this._rawData.Set("daily_amount", value); }
    }

    /// <summary>
    /// The amount of time it takes for a payout to be funded. This value is defined
    /// by Straddle.
    /// </summary>
    public required ApiEnum<string, AccountV1DataSettingsPayoutsFundingTime> FundingTime
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, AccountV1DataSettingsPayoutsFundingTime>
            >("funding_time");
        }
        init { this._rawData.Set("funding_time", value); }
    }

    /// <summary>
    /// The unique identifier of the linked bank account to use for payouts.
    /// </summary>
    public required string LinkedBankAccountID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("linked_bank_account_id");
        }
        init { this._rawData.Set("linked_bank_account_id", value); }
    }

    /// <summary>
    /// The maximum amount of a single payout.
    /// </summary>
    public required int MaxAmount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("max_amount");
        }
        init { this._rawData.Set("max_amount", value); }
    }

    /// <summary>
    /// The maximum dollar amount of payouts in a month.
    /// </summary>
    public required int MonthlyAmount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("monthly_amount");
        }
        init { this._rawData.Set("monthly_amount", value); }
    }

    /// <summary>
    /// The maximum number of payouts in a month.
    /// </summary>
    public required int MonthlyCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<int>("monthly_count");
        }
        init { this._rawData.Set("monthly_count", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.DailyAmount;
        this.FundingTime.Validate();
        _ = this.LinkedBankAccountID;
        _ = this.MaxAmount;
        _ = this.MonthlyAmount;
        _ = this.MonthlyCount;
    }

    public AccountV1DataSettingsPayouts() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountV1DataSettingsPayouts(AccountV1DataSettingsPayouts accountV1DataSettingsPayouts)
        : base(accountV1DataSettingsPayouts) { }
#pragma warning restore CS8618

    public AccountV1DataSettingsPayouts(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountV1DataSettingsPayouts(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountV1DataSettingsPayoutsFromRaw.FromRawUnchecked"/>
    public static AccountV1DataSettingsPayouts FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountV1DataSettingsPayoutsFromRaw : IFromRawJson<AccountV1DataSettingsPayouts>
{
    /// <inheritdoc/>
    public AccountV1DataSettingsPayouts FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AccountV1DataSettingsPayouts.FromRawUnchecked(rawData);
}

/// <summary>
/// The amount of time it takes for a payout to be funded. This value is defined
/// by Straddle.
/// </summary>
[JsonConverter(typeof(AccountV1DataSettingsPayoutsFundingTimeConverter))]
public enum AccountV1DataSettingsPayoutsFundingTime
{
    Immediate,
    NextDay,
    OneDay,
    TwoDay,
    ThreeDay,
}

sealed class AccountV1DataSettingsPayoutsFundingTimeConverter
    : JsonConverter<AccountV1DataSettingsPayoutsFundingTime>
{
    public override AccountV1DataSettingsPayoutsFundingTime Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "immediate" => AccountV1DataSettingsPayoutsFundingTime.Immediate,
            "next_day" => AccountV1DataSettingsPayoutsFundingTime.NextDay,
            "one_day" => AccountV1DataSettingsPayoutsFundingTime.OneDay,
            "two_day" => AccountV1DataSettingsPayoutsFundingTime.TwoDay,
            "three_day" => AccountV1DataSettingsPayoutsFundingTime.ThreeDay,
            _ => (AccountV1DataSettingsPayoutsFundingTime)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AccountV1DataSettingsPayoutsFundingTime value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AccountV1DataSettingsPayoutsFundingTime.Immediate => "immediate",
                AccountV1DataSettingsPayoutsFundingTime.NextDay => "next_day",
                AccountV1DataSettingsPayoutsFundingTime.OneDay => "one_day",
                AccountV1DataSettingsPayoutsFundingTime.TwoDay => "two_day",
                AccountV1DataSettingsPayoutsFundingTime.ThreeDay => "three_day",
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
[JsonConverter(typeof(AccountV1ResponseTypeConverter))]
public enum AccountV1ResponseType
{
    Object,
    Array,
    Error,
    None,
}

sealed class AccountV1ResponseTypeConverter : JsonConverter<AccountV1ResponseType>
{
    public override AccountV1ResponseType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "object" => AccountV1ResponseType.Object,
            "array" => AccountV1ResponseType.Array,
            "error" => AccountV1ResponseType.Error,
            "none" => AccountV1ResponseType.None,
            _ => (AccountV1ResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AccountV1ResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AccountV1ResponseType.Object => "object",
                AccountV1ResponseType.Array => "array",
                AccountV1ResponseType.Error => "error",
                AccountV1ResponseType.None => "none",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
