using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;
using System = System;

namespace Straddle.Models.Customers;

[JsonConverter(typeof(JsonModelConverter<CustomerUnmaskedV1, CustomerUnmaskedV1FromRaw>))]
public sealed record class CustomerUnmaskedV1 : JsonModel
{
    public required CustomerUnmaskedV1Data Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<CustomerUnmaskedV1Data>("data");
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
    public required ApiEnum<string, CustomerUnmaskedV1ResponseType> ResponseType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, CustomerUnmaskedV1ResponseType>>(
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

    public CustomerUnmaskedV1() { }

    public CustomerUnmaskedV1(CustomerUnmaskedV1 customerUnmaskedV1)
        : base(customerUnmaskedV1) { }

    public CustomerUnmaskedV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerUnmaskedV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerUnmaskedV1FromRaw.FromRawUnchecked"/>
    public static CustomerUnmaskedV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CustomerUnmaskedV1FromRaw : IFromRawJson<CustomerUnmaskedV1>
{
    /// <inheritdoc/>
    public CustomerUnmaskedV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        CustomerUnmaskedV1.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<CustomerUnmaskedV1Data, CustomerUnmaskedV1DataFromRaw>))]
public sealed record class CustomerUnmaskedV1Data : JsonModel
{
    /// <summary>
    /// Unique identifier for the customer.
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
    /// Timestamp of when the customer record was created.
    /// </summary>
    public required System::DateTimeOffset CreatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<System::DateTimeOffset>("created_at");
        }
        init { this._rawData.Set("created_at", value); }
    }

    /// <summary>
    /// The customer's email address.
    /// </summary>
    public required string Email
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("email");
        }
        init { this._rawData.Set("email", value); }
    }

    /// <summary>
    /// Full name of the individual or business name.
    /// </summary>
    public required string Name
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("name");
        }
        init { this._rawData.Set("name", value); }
    }

    /// <summary>
    /// The customer's phone number in E.164 format.
    /// </summary>
    public required string Phone
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("phone");
        }
        init { this._rawData.Set("phone", value); }
    }

    public required ApiEnum<string, CustomerUnmaskedV1DataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, CustomerUnmaskedV1DataStatus>>(
                "status"
            );
        }
        init { this._rawData.Set("status", value); }
    }

    public required ApiEnum<string, CustomerUnmaskedV1DataType> Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, CustomerUnmaskedV1DataType>>(
                "type"
            );
        }
        init { this._rawData.Set("type", value); }
    }

    /// <summary>
    /// Timestamp of the most recent update to the customer record.
    /// </summary>
    public required System::DateTimeOffset UpdatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<System::DateTimeOffset>("updated_at");
        }
        init { this._rawData.Set("updated_at", value); }
    }

    /// <summary>
    /// An object containing the customer's address. This is optional, but if provided,
    /// all required fields must be present.
    /// </summary>
    public CustomerAddressV1? Address
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<CustomerAddressV1>("address");
        }
        init { this._rawData.Set("address", value); }
    }

    /// <summary>
    /// Individual PII data required to trigger Patriot Act compliant KYC verification.
    /// </summary>
    public CustomerUnmaskedV1DataComplianceProfile? ComplianceProfile
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<CustomerUnmaskedV1DataComplianceProfile>(
                "compliance_profile"
            );
        }
        init { this._rawData.Set("compliance_profile", value); }
    }

    public CustomerUnmaskedV1DataConfig? Config
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<CustomerUnmaskedV1DataConfig>("config");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("config", value);
        }
    }

    public DeviceUnmaskedV1? Device
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<DeviceUnmaskedV1>("device");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("device", value);
        }
    }

    /// <summary>
    /// Unique identifier for the customer in your database, used for cross-referencing
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
    /// information about the customer in a structured format.
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.CreatedAt;
        _ = this.Email;
        _ = this.Name;
        _ = this.Phone;
        this.Status.Validate();
        this.Type.Validate();
        _ = this.UpdatedAt;
        this.Address?.Validate();
        this.ComplianceProfile?.Validate();
        this.Config?.Validate();
        this.Device?.Validate();
        _ = this.ExternalID;
        _ = this.Metadata;
    }

    public CustomerUnmaskedV1Data() { }

    public CustomerUnmaskedV1Data(CustomerUnmaskedV1Data customerUnmaskedV1Data)
        : base(customerUnmaskedV1Data) { }

    public CustomerUnmaskedV1Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerUnmaskedV1Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerUnmaskedV1DataFromRaw.FromRawUnchecked"/>
    public static CustomerUnmaskedV1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CustomerUnmaskedV1DataFromRaw : IFromRawJson<CustomerUnmaskedV1Data>
{
    /// <inheritdoc/>
    public CustomerUnmaskedV1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CustomerUnmaskedV1Data.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(CustomerUnmaskedV1DataStatusConverter))]
public enum CustomerUnmaskedV1DataStatus
{
    Pending,
    Review,
    Verified,
    Inactive,
    Rejected,
}

sealed class CustomerUnmaskedV1DataStatusConverter : JsonConverter<CustomerUnmaskedV1DataStatus>
{
    public override CustomerUnmaskedV1DataStatus Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => CustomerUnmaskedV1DataStatus.Pending,
            "review" => CustomerUnmaskedV1DataStatus.Review,
            "verified" => CustomerUnmaskedV1DataStatus.Verified,
            "inactive" => CustomerUnmaskedV1DataStatus.Inactive,
            "rejected" => CustomerUnmaskedV1DataStatus.Rejected,
            _ => (CustomerUnmaskedV1DataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CustomerUnmaskedV1DataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CustomerUnmaskedV1DataStatus.Pending => "pending",
                CustomerUnmaskedV1DataStatus.Review => "review",
                CustomerUnmaskedV1DataStatus.Verified => "verified",
                CustomerUnmaskedV1DataStatus.Inactive => "inactive",
                CustomerUnmaskedV1DataStatus.Rejected => "rejected",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(CustomerUnmaskedV1DataTypeConverter))]
public enum CustomerUnmaskedV1DataType
{
    Individual,
    Business,
    Individual1,
    Business1,
}

sealed class CustomerUnmaskedV1DataTypeConverter : JsonConverter<CustomerUnmaskedV1DataType>
{
    public override CustomerUnmaskedV1DataType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "individual" => CustomerUnmaskedV1DataType.Individual,
            "business" => CustomerUnmaskedV1DataType.Business,
            "Individual" => CustomerUnmaskedV1DataType.Individual1,
            "Business" => CustomerUnmaskedV1DataType.Business1,
            _ => (CustomerUnmaskedV1DataType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CustomerUnmaskedV1DataType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CustomerUnmaskedV1DataType.Individual => "individual",
                CustomerUnmaskedV1DataType.Business => "business",
                CustomerUnmaskedV1DataType.Individual1 => "Individual",
                CustomerUnmaskedV1DataType.Business1 => "Business",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Individual PII data required to trigger Patriot Act compliant KYC verification.
/// </summary>
[JsonConverter(typeof(CustomerUnmaskedV1DataComplianceProfileConverter))]
public record class CustomerUnmaskedV1DataComplianceProfile : ModelBase
{
    public object? Value { get; } = null;

    JsonElement? _element = null;

    public JsonElement Json
    {
        get
        {
            return this._element ??= JsonSerializer.SerializeToElement(
                this.Value,
                ModelBase.SerializerOptions
            );
        }
    }

    public CustomerUnmaskedV1DataComplianceProfile(
        CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile value,
        JsonElement? element = null
    )
    {
        this.Value = value;
        this._element = element;
    }

    public CustomerUnmaskedV1DataComplianceProfile(
        CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile value,
        JsonElement? element = null
    )
    {
        this.Value = value;
        this._element = element;
    }

    public CustomerUnmaskedV1DataComplianceProfile(JsonElement element)
    {
        this._element = element;
    }

    /// <summary>
    /// Returns true and sets the <c>out</c> parameter if the instance was constructed with a variant of
    /// type <see cref="CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile"/>.
    ///
    /// <para>Consider using <see cref="Switch"> or <see cref="Match"> if you need to handle every variant.</para>
    ///
    /// <example>
    /// <code>
    /// if (instance.TryPickIndividual(out var value)) {
    ///     // `value` is of type `CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile`
    ///     Console.WriteLine(value);
    /// }
    /// </code>
    /// </example>
    /// </summary>
    public bool TryPickIndividual(
        [NotNullWhen(true)]
            out CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile? value
    )
    {
        value = this.Value as CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile;
        return value != null;
    }

    /// <summary>
    /// Returns true and sets the <c>out</c> parameter if the instance was constructed with a variant of
    /// type <see cref="CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile"/>.
    ///
    /// <para>Consider using <see cref="Switch"> or <see cref="Match"> if you need to handle every variant.</para>
    ///
    /// <example>
    /// <code>
    /// if (instance.TryPickBusiness(out var value)) {
    ///     // `value` is of type `CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile`
    ///     Console.WriteLine(value);
    /// }
    /// </code>
    /// </example>
    /// </summary>
    public bool TryPickBusiness(
        [NotNullWhen(true)]
            out CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile? value
    )
    {
        value = this.Value as CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile;
        return value != null;
    }

    /// <summary>
    /// Calls the function parameter corresponding to the variant the instance was constructed with.
    ///
    /// <para>Use the <c>TryPick</c> method(s) if you don't need to handle every variant, or <see cref="Match">
    /// if you need your function parameters to return something.</para>
    ///
    /// <exception cref="StraddleInvalidDataException">
    /// Thrown when the instance was constructed with an unknown variant (e.g. deserialized from raw data
    /// that doesn't match any variant's expected shape).
    /// </exception>
    ///
    /// <example>
    /// <code>
    /// instance.Switch(
    ///     (CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile value) => {...},
    ///     (CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile value) => {...}
    /// );
    /// </code>
    /// </example>
    /// </summary>
    public void Switch(
        System::Action<CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile> individual,
        System::Action<CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile> business
    )
    {
        switch (this.Value)
        {
            case CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile value:
                individual(value);
                break;
            case CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile value:
                business(value);
                break;
            default:
                throw new StraddleInvalidDataException(
                    "Data did not match any variant of CustomerUnmaskedV1DataComplianceProfile"
                );
        }
    }

    /// <summary>
    /// Calls the function parameter corresponding to the variant the instance was constructed with and
    /// returns its result.
    ///
    /// <para>Use the <c>TryPick</c> method(s) if you don't need to handle every variant, or <see cref="Switch">
    /// if you don't need your function parameters to return a value.</para>
    ///
    /// <exception cref="StraddleInvalidDataException">
    /// Thrown when the instance was constructed with an unknown variant (e.g. deserialized from raw data
    /// that doesn't match any variant's expected shape).
    /// </exception>
    ///
    /// <example>
    /// <code>
    /// var result = instance.Match(
    ///     (CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile value) => {...},
    ///     (CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile value) => {...}
    /// );
    /// </code>
    /// </example>
    /// </summary>
    public T Match<T>(
        System::Func<
            CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile,
            T
        > individual,
        System::Func<CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile, T> business
    )
    {
        return this.Value switch
        {
            CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile value => individual(
                value
            ),
            CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile value => business(
                value
            ),
            _ => throw new StraddleInvalidDataException(
                "Data did not match any variant of CustomerUnmaskedV1DataComplianceProfile"
            ),
        };
    }

    public static implicit operator CustomerUnmaskedV1DataComplianceProfile(
        CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile value
    ) => new(value);

    public static implicit operator CustomerUnmaskedV1DataComplianceProfile(
        CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile value
    ) => new(value);

    /// <summary>
    /// Validates that the instance was constructed with a known variant and that this variant is valid
    /// (based on its own <c>Validate</c> method).
    ///
    /// <para>This is useful for instances constructed from raw JSON data (e.g. deserialized from an API response).</para>
    ///
    /// <exception cref="StraddleInvalidDataException">
    /// Thrown when the instance does not pass validation.
    /// </exception>
    /// </summary>
    public override void Validate()
    {
        if (this.Value == null)
        {
            throw new StraddleInvalidDataException(
                "Data did not match any variant of CustomerUnmaskedV1DataComplianceProfile"
            );
        }
        this.Switch((individual) => individual.Validate(), (business) => business.Validate());
    }

    public virtual bool Equals(CustomerUnmaskedV1DataComplianceProfile? other)
    {
        return other != null && JsonElement.DeepEquals(this.Json, other.Json);
    }

    public override int GetHashCode()
    {
        return 0;
    }

    public override string ToString() =>
        JsonSerializer.Serialize(this._element, ModelBase.ToStringSerializerOptions);
}

sealed class CustomerUnmaskedV1DataComplianceProfileConverter
    : JsonConverter<CustomerUnmaskedV1DataComplianceProfile?>
{
    public override CustomerUnmaskedV1DataComplianceProfile? Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        var element = JsonSerializer.Deserialize<JsonElement>(ref reader, options);
        try
        {
            var deserialized =
                JsonSerializer.Deserialize<CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile>(
                    element,
                    options
                );
            if (deserialized != null)
            {
                deserialized.Validate();
                return new(deserialized, element);
            }
        }
        catch (System::Exception e) when (e is JsonException || e is StraddleInvalidDataException)
        {
            // ignore
        }

        try
        {
            var deserialized =
                JsonSerializer.Deserialize<CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile>(
                    element,
                    options
                );
            if (deserialized != null)
            {
                deserialized.Validate();
                return new(deserialized, element);
            }
        }
        catch (System::Exception e) when (e is JsonException || e is StraddleInvalidDataException)
        {
            // ignore
        }

        return new(element);
    }

    public override void Write(
        Utf8JsonWriter writer,
        CustomerUnmaskedV1DataComplianceProfile? value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(writer, value?.Json, options);
    }
}

/// <summary>
/// Individual PII data required to trigger Patriot Act compliant KYC verification.
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile,
        CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfileFromRaw
    >)
)]
public sealed record class CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile
    : JsonModel
{
    /// <summary>
    /// Date of birth (YYYY-MM-DD). Required for Patriot Act-compliant KYC verification.
    /// </summary>
    public required string? Dob
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("dob");
        }
        init { this._rawData.Set("dob", value); }
    }

    /// <summary>
    /// Social Security Number (format XXX-XX-XXXX). Required for Patriot Act-compliant
    /// KYC verification.
    /// </summary>
    public required string? Ssn
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("ssn");
        }
        init { this._rawData.Set("ssn", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Dob;
        _ = this.Ssn;
    }

    public CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile() { }

    public CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile(
        CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile customerUnmaskedV1DataComplianceProfileIndividualComplianceProfile
    )
        : base(customerUnmaskedV1DataComplianceProfileIndividualComplianceProfile) { }

    public CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfileFromRaw.FromRawUnchecked"/>
    public static CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfileFromRaw
    : IFromRawJson<CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile>
{
    /// <inheritdoc/>
    public CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) =>
        CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile.FromRawUnchecked(
            rawData
        );
}

/// <summary>
/// Business registration data required to trigger Patriot Act compliant KYB verification.
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile,
        CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileFromRaw
    >)
)]
public sealed record class CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile
    : JsonModel
{
    /// <summary>
    /// Employer Identification Number (format XX-XXXXXXX). Required for Patriot
    /// Act-compliant KYB verification.
    /// </summary>
    public required string? Ein
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("ein");
        }
        init { this._rawData.Set("ein", value); }
    }

    /// <summary>
    /// Official registered business name as listed with the IRS. This value will
    /// be matched against the 'legal_business name'.
    /// </summary>
    public required string? LegalBusinessName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("legal_business_name");
        }
        init { this._rawData.Set("legal_business_name", value); }
    }

    /// <summary>
    /// A list of people related to the company. Only valid where customer type is 'business'.
    /// </summary>
    public IReadOnlyList<CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative>? Representatives
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<
                ImmutableArray<CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative>
            >("representatives");
        }
        init
        {
            this._rawData.Set<ImmutableArray<CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative>?>(
                "representatives",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Official business website URL. Optional but recommended for enhanced KYB.
    /// </summary>
    public string? Website
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("website");
        }
        init { this._rawData.Set("website", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Ein;
        _ = this.LegalBusinessName;
        foreach (var item in this.Representatives ?? [])
        {
            item.Validate();
        }
        _ = this.Website;
    }

    public CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile() { }

    public CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile(
        CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile customerUnmaskedV1DataComplianceProfileBusinessComplianceProfile
    )
        : base(customerUnmaskedV1DataComplianceProfileBusinessComplianceProfile) { }

    public CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileFromRaw.FromRawUnchecked"/>
    public static CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileFromRaw
    : IFromRawJson<CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile>
{
    /// <inheritdoc/>
    public CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative,
        CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentativeFromRaw
    >)
)]
public sealed record class CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative
    : JsonModel
{
    public required string Name
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("name");
        }
        init { this._rawData.Set("name", value); }
    }

    public string? Email
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("email");
        }
        init { this._rawData.Set("email", value); }
    }

    public string? Phone
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("phone");
        }
        init { this._rawData.Set("phone", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Name;
        _ = this.Email;
        _ = this.Phone;
    }

    public CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative() { }

    public CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative(
        CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative customerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative
    )
        : base(customerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative) { }

    public CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentativeFromRaw.FromRawUnchecked"/>
    public static CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative(
        string name
    )
        : this()
    {
        this.Name = name;
    }
}

class CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentativeFromRaw
    : IFromRawJson<CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative>
{
    /// <inheritdoc/>
    public CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) =>
        CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative.FromRawUnchecked(
            rawData
        );
}

[JsonConverter(
    typeof(JsonModelConverter<CustomerUnmaskedV1DataConfig, CustomerUnmaskedV1DataConfigFromRaw>)
)]
public sealed record class CustomerUnmaskedV1DataConfig : JsonModel
{
    public ApiEnum<string, CustomerUnmaskedV1DataConfigProcessingMethod>? ProcessingMethod
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, CustomerUnmaskedV1DataConfigProcessingMethod>
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

    public ApiEnum<string, CustomerUnmaskedV1DataConfigSandboxOutcome>? SandboxOutcome
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, CustomerUnmaskedV1DataConfigSandboxOutcome>
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

    public CustomerUnmaskedV1DataConfig() { }

    public CustomerUnmaskedV1DataConfig(CustomerUnmaskedV1DataConfig customerUnmaskedV1DataConfig)
        : base(customerUnmaskedV1DataConfig) { }

    public CustomerUnmaskedV1DataConfig(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerUnmaskedV1DataConfig(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerUnmaskedV1DataConfigFromRaw.FromRawUnchecked"/>
    public static CustomerUnmaskedV1DataConfig FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CustomerUnmaskedV1DataConfigFromRaw : IFromRawJson<CustomerUnmaskedV1DataConfig>
{
    /// <inheritdoc/>
    public CustomerUnmaskedV1DataConfig FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CustomerUnmaskedV1DataConfig.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(CustomerUnmaskedV1DataConfigProcessingMethodConverter))]
public enum CustomerUnmaskedV1DataConfigProcessingMethod
{
    Inline,
    Background,
    Skip,
}

sealed class CustomerUnmaskedV1DataConfigProcessingMethodConverter
    : JsonConverter<CustomerUnmaskedV1DataConfigProcessingMethod>
{
    public override CustomerUnmaskedV1DataConfigProcessingMethod Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "inline" => CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
            "background" => CustomerUnmaskedV1DataConfigProcessingMethod.Background,
            "skip" => CustomerUnmaskedV1DataConfigProcessingMethod.Skip,
            _ => (CustomerUnmaskedV1DataConfigProcessingMethod)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CustomerUnmaskedV1DataConfigProcessingMethod value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CustomerUnmaskedV1DataConfigProcessingMethod.Inline => "inline",
                CustomerUnmaskedV1DataConfigProcessingMethod.Background => "background",
                CustomerUnmaskedV1DataConfigProcessingMethod.Skip => "skip",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(CustomerUnmaskedV1DataConfigSandboxOutcomeConverter))]
public enum CustomerUnmaskedV1DataConfigSandboxOutcome
{
    Standard,
    Verified,
    Rejected,
    Review,
}

sealed class CustomerUnmaskedV1DataConfigSandboxOutcomeConverter
    : JsonConverter<CustomerUnmaskedV1DataConfigSandboxOutcome>
{
    public override CustomerUnmaskedV1DataConfigSandboxOutcome Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "standard" => CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
            "verified" => CustomerUnmaskedV1DataConfigSandboxOutcome.Verified,
            "rejected" => CustomerUnmaskedV1DataConfigSandboxOutcome.Rejected,
            "review" => CustomerUnmaskedV1DataConfigSandboxOutcome.Review,
            _ => (CustomerUnmaskedV1DataConfigSandboxOutcome)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CustomerUnmaskedV1DataConfigSandboxOutcome value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CustomerUnmaskedV1DataConfigSandboxOutcome.Standard => "standard",
                CustomerUnmaskedV1DataConfigSandboxOutcome.Verified => "verified",
                CustomerUnmaskedV1DataConfigSandboxOutcome.Rejected => "rejected",
                CustomerUnmaskedV1DataConfigSandboxOutcome.Review => "review",
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
[JsonConverter(typeof(CustomerUnmaskedV1ResponseTypeConverter))]
public enum CustomerUnmaskedV1ResponseType
{
    Object,
    Array,
    Error,
    None,
    Object1,
    Array1,
    Error1,
    None1,
}

sealed class CustomerUnmaskedV1ResponseTypeConverter : JsonConverter<CustomerUnmaskedV1ResponseType>
{
    public override CustomerUnmaskedV1ResponseType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "object" => CustomerUnmaskedV1ResponseType.Object,
            "array" => CustomerUnmaskedV1ResponseType.Array,
            "error" => CustomerUnmaskedV1ResponseType.Error,
            "none" => CustomerUnmaskedV1ResponseType.None,
            "Object" => CustomerUnmaskedV1ResponseType.Object1,
            "Array" => CustomerUnmaskedV1ResponseType.Array1,
            "Error" => CustomerUnmaskedV1ResponseType.Error1,
            "None" => CustomerUnmaskedV1ResponseType.None1,
            _ => (CustomerUnmaskedV1ResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CustomerUnmaskedV1ResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CustomerUnmaskedV1ResponseType.Object => "object",
                CustomerUnmaskedV1ResponseType.Array => "array",
                CustomerUnmaskedV1ResponseType.Error => "error",
                CustomerUnmaskedV1ResponseType.None => "none",
                CustomerUnmaskedV1ResponseType.Object1 => "Object",
                CustomerUnmaskedV1ResponseType.Array1 => "Array",
                CustomerUnmaskedV1ResponseType.Error1 => "Error",
                CustomerUnmaskedV1ResponseType.None1 => "None",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
