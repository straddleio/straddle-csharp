using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;
using System = System;

namespace Straddle.Models.Embed.Accounts;

[JsonConverter(typeof(JsonModelConverter<AccountPagedV1, AccountPagedV1FromRaw>))]
public sealed record class AccountPagedV1 : JsonModel
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

    /// <summary>
    /// Metadata about the API request, including an identifier, timestamp, and pagination details.
    /// </summary>
    public required PagedResponseMetadata Meta
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<PagedResponseMetadata>("meta");
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

    public AccountPagedV1() { }

    public AccountPagedV1(AccountPagedV1 accountPagedV1)
        : base(accountPagedV1) { }

    public AccountPagedV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountPagedV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountPagedV1FromRaw.FromRawUnchecked"/>
    public static AccountPagedV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountPagedV1FromRaw : IFromRawJson<AccountPagedV1>
{
    /// <inheritdoc/>
    public AccountPagedV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        AccountPagedV1.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
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
    public required ApiEnum<string, DataAccessLevel> AccessLevel
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, DataAccessLevel>>("access_level");
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
    public required ApiEnum<string, DataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, DataStatus>>("status");
        }
        init { this._rawData.Set("status", value); }
    }

    public required StatusDetail StatusDetail
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<StatusDetail>("status_detail");
        }
        init { this._rawData.Set("status_detail", value); }
    }

    /// <summary>
    /// The type of account (e.g., 'individual', 'business').
    /// </summary>
    public required ApiEnum<string, DataType> Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, DataType>>("type");
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

    public Capabilities? Capabilities
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Capabilities>("capabilities");
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

    public Settings? Settings
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Settings>("settings");
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

/// <summary>
/// The access level granted to the account. This is determined by your platform configuration.
/// Use `standard` unless instructed otherwise by Straddle.
/// </summary>
[JsonConverter(typeof(DataAccessLevelConverter))]
public enum DataAccessLevel
{
    Standard,
    Managed,
}

sealed class DataAccessLevelConverter : JsonConverter<DataAccessLevel>
{
    public override DataAccessLevel Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "standard" => DataAccessLevel.Standard,
            "managed" => DataAccessLevel.Managed,
            _ => (DataAccessLevel)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        DataAccessLevel value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                DataAccessLevel.Standard => "standard",
                DataAccessLevel.Managed => "managed",
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
[JsonConverter(typeof(DataStatusConverter))]
public enum DataStatus
{
    Created,
    Onboarding,
    Active,
    Rejected,
    Inactive,
}

sealed class DataStatusConverter : JsonConverter<DataStatus>
{
    public override DataStatus Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created" => DataStatus.Created,
            "onboarding" => DataStatus.Onboarding,
            "active" => DataStatus.Active,
            "rejected" => DataStatus.Rejected,
            "inactive" => DataStatus.Inactive,
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
                DataStatus.Created => "created",
                DataStatus.Onboarding => "onboarding",
                DataStatus.Active => "active",
                DataStatus.Rejected => "rejected",
                DataStatus.Inactive => "inactive",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<StatusDetail, StatusDetailFromRaw>))]
public sealed record class StatusDetail : JsonModel
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
    public required ApiEnum<string, Reason> Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Reason>>("reason");
        }
        init { this._rawData.Set("reason", value); }
    }

    /// <summary>
    /// Identifies the origin of the status change (e.g., `bank_decline`, `watchtower`).
    /// This helps in tracking the cause of status updates.
    /// </summary>
    public required ApiEnum<string, Source> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Source>>("source");
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

    public StatusDetail() { }

    public StatusDetail(StatusDetail statusDetail)
        : base(statusDetail) { }

    public StatusDetail(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    StatusDetail(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="StatusDetailFromRaw.FromRawUnchecked"/>
    public static StatusDetail FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class StatusDetailFromRaw : IFromRawJson<StatusDetail>
{
    /// <inheritdoc/>
    public StatusDetail FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        StatusDetail.FromRawUnchecked(rawData);
}

/// <summary>
/// A machine-readable identifier for the specific status, useful for programmatic handling.
/// </summary>
[JsonConverter(typeof(ReasonConverter))]
public enum Reason
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

sealed class ReasonConverter : JsonConverter<Reason>
{
    public override Reason Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "unverified" => Reason.Unverified,
            "in_review" => Reason.InReview,
            "pending" => Reason.Pending,
            "stuck" => Reason.Stuck,
            "verified" => Reason.Verified,
            "failed_verification" => Reason.FailedVerification,
            "disabled" => Reason.Disabled,
            "terminated" => Reason.Terminated,
            "new" => Reason.New,
            _ => (Reason)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Reason value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Reason.Unverified => "unverified",
                Reason.InReview => "in_review",
                Reason.Pending => "pending",
                Reason.Stuck => "stuck",
                Reason.Verified => "verified",
                Reason.FailedVerification => "failed_verification",
                Reason.Disabled => "disabled",
                Reason.Terminated => "terminated",
                Reason.New => "new",
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
[JsonConverter(typeof(SourceConverter))]
public enum Source
{
    Watchtower,
}

sealed class SourceConverter : JsonConverter<Source>
{
    public override Source Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "watchtower" => Source.Watchtower,
            _ => (Source)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Source value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Source.Watchtower => "watchtower",
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
[JsonConverter(typeof(DataTypeConverter))]
public enum DataType
{
    Business,
}

sealed class DataTypeConverter : JsonConverter<DataType>
{
    public override DataType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "business" => DataType.Business,
            _ => (DataType)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, DataType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                DataType.Business => "business",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<Capabilities, CapabilitiesFromRaw>))]
public sealed record class Capabilities : JsonModel
{
    public required ConsentTypes ConsentTypes
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ConsentTypes>("consent_types");
        }
        init { this._rawData.Set("consent_types", value); }
    }

    public required CustomerTypes CustomerTypes
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<CustomerTypes>("customer_types");
        }
        init { this._rawData.Set("customer_types", value); }
    }

    public required PaymentTypes PaymentTypes
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<PaymentTypes>("payment_types");
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

    public Capabilities() { }

    public Capabilities(Capabilities capabilities)
        : base(capabilities) { }

    public Capabilities(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Capabilities(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CapabilitiesFromRaw.FromRawUnchecked"/>
    public static Capabilities FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CapabilitiesFromRaw : IFromRawJson<Capabilities>
{
    /// <inheritdoc/>
    public Capabilities FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Capabilities.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<ConsentTypes, ConsentTypesFromRaw>))]
public sealed record class ConsentTypes : JsonModel
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

    public ConsentTypes() { }

    public ConsentTypes(ConsentTypes consentTypes)
        : base(consentTypes) { }

    public ConsentTypes(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ConsentTypes(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ConsentTypesFromRaw.FromRawUnchecked"/>
    public static ConsentTypes FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ConsentTypesFromRaw : IFromRawJson<ConsentTypes>
{
    /// <inheritdoc/>
    public ConsentTypes FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        ConsentTypes.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<CustomerTypes, CustomerTypesFromRaw>))]
public sealed record class CustomerTypes : JsonModel
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

    public CustomerTypes() { }

    public CustomerTypes(CustomerTypes customerTypes)
        : base(customerTypes) { }

    public CustomerTypes(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerTypes(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerTypesFromRaw.FromRawUnchecked"/>
    public static CustomerTypes FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CustomerTypesFromRaw : IFromRawJson<CustomerTypes>
{
    /// <inheritdoc/>
    public CustomerTypes FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        CustomerTypes.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<PaymentTypes, PaymentTypesFromRaw>))]
public sealed record class PaymentTypes : JsonModel
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

    public PaymentTypes() { }

    public PaymentTypes(PaymentTypes paymentTypes)
        : base(paymentTypes) { }

    public PaymentTypes(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaymentTypes(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaymentTypesFromRaw.FromRawUnchecked"/>
    public static PaymentTypes FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaymentTypesFromRaw : IFromRawJson<PaymentTypes>
{
    /// <inheritdoc/>
    public PaymentTypes FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        PaymentTypes.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Settings, SettingsFromRaw>))]
public sealed record class Settings : JsonModel
{
    public required SettingsCharges Charges
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<SettingsCharges>("charges");
        }
        init { this._rawData.Set("charges", value); }
    }

    public required SettingsPayouts Payouts
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<SettingsPayouts>("payouts");
        }
        init { this._rawData.Set("payouts", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Charges.Validate();
        this.Payouts.Validate();
    }

    public Settings() { }

    public Settings(Settings settings)
        : base(settings) { }

    public Settings(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Settings(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="SettingsFromRaw.FromRawUnchecked"/>
    public static Settings FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class SettingsFromRaw : IFromRawJson<Settings>
{
    /// <inheritdoc/>
    public Settings FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Settings.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<SettingsCharges, SettingsChargesFromRaw>))]
public sealed record class SettingsCharges : JsonModel
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
    public required ApiEnum<string, FundingTime> FundingTime
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, FundingTime>>("funding_time");
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

    public SettingsCharges() { }

    public SettingsCharges(SettingsCharges settingsCharges)
        : base(settingsCharges) { }

    public SettingsCharges(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    SettingsCharges(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="SettingsChargesFromRaw.FromRawUnchecked"/>
    public static SettingsCharges FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class SettingsChargesFromRaw : IFromRawJson<SettingsCharges>
{
    /// <inheritdoc/>
    public SettingsCharges FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        SettingsCharges.FromRawUnchecked(rawData);
}

/// <summary>
/// The amount of time it takes for a charge to be funded. This value is defined
/// by Straddle.
/// </summary>
[JsonConverter(typeof(FundingTimeConverter))]
public enum FundingTime
{
    Immediate,
    NextDay,
    OneDay,
    TwoDay,
    ThreeDay,
}

sealed class FundingTimeConverter : JsonConverter<FundingTime>
{
    public override FundingTime Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "immediate" => FundingTime.Immediate,
            "next_day" => FundingTime.NextDay,
            "one_day" => FundingTime.OneDay,
            "two_day" => FundingTime.TwoDay,
            "three_day" => FundingTime.ThreeDay,
            _ => (FundingTime)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        FundingTime value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                FundingTime.Immediate => "immediate",
                FundingTime.NextDay => "next_day",
                FundingTime.OneDay => "one_day",
                FundingTime.TwoDay => "two_day",
                FundingTime.ThreeDay => "three_day",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<SettingsPayouts, SettingsPayoutsFromRaw>))]
public sealed record class SettingsPayouts : JsonModel
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
    public required ApiEnum<string, SettingsPayoutsFundingTime> FundingTime
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, SettingsPayoutsFundingTime>>(
                "funding_time"
            );
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

    public SettingsPayouts() { }

    public SettingsPayouts(SettingsPayouts settingsPayouts)
        : base(settingsPayouts) { }

    public SettingsPayouts(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    SettingsPayouts(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="SettingsPayoutsFromRaw.FromRawUnchecked"/>
    public static SettingsPayouts FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class SettingsPayoutsFromRaw : IFromRawJson<SettingsPayouts>
{
    /// <inheritdoc/>
    public SettingsPayouts FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        SettingsPayouts.FromRawUnchecked(rawData);
}

/// <summary>
/// The amount of time it takes for a payout to be funded. This value is defined
/// by Straddle.
/// </summary>
[JsonConverter(typeof(SettingsPayoutsFundingTimeConverter))]
public enum SettingsPayoutsFundingTime
{
    Immediate,
    NextDay,
    OneDay,
    TwoDay,
    ThreeDay,
}

sealed class SettingsPayoutsFundingTimeConverter : JsonConverter<SettingsPayoutsFundingTime>
{
    public override SettingsPayoutsFundingTime Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "immediate" => SettingsPayoutsFundingTime.Immediate,
            "next_day" => SettingsPayoutsFundingTime.NextDay,
            "one_day" => SettingsPayoutsFundingTime.OneDay,
            "two_day" => SettingsPayoutsFundingTime.TwoDay,
            "three_day" => SettingsPayoutsFundingTime.ThreeDay,
            _ => (SettingsPayoutsFundingTime)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        SettingsPayoutsFundingTime value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                SettingsPayoutsFundingTime.Immediate => "immediate",
                SettingsPayoutsFundingTime.NextDay => "next_day",
                SettingsPayoutsFundingTime.OneDay => "one_day",
                SettingsPayoutsFundingTime.TwoDay => "two_day",
                SettingsPayoutsFundingTime.ThreeDay => "three_day",
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
        System::Type typeToConvert,
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
