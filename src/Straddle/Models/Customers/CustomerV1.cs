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

[JsonConverter(typeof(JsonModelConverter<CustomerV1, CustomerV1FromRaw>))]
public sealed record class CustomerV1 : JsonModel
{
    public required CustomerV1Data Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<CustomerV1Data>("data");
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
    public required ApiEnum<string, CustomerV1ResponseType> ResponseType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, CustomerV1ResponseType>>(
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

    public CustomerV1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CustomerV1(CustomerV1 customerV1)
        : base(customerV1) { }
#pragma warning restore CS8618

    public CustomerV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerV1FromRaw.FromRawUnchecked"/>
    public static CustomerV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CustomerV1FromRaw : IFromRawJson<CustomerV1>
{
    /// <inheritdoc/>
    public CustomerV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        CustomerV1.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<CustomerV1Data, CustomerV1DataFromRaw>))]
public sealed record class CustomerV1Data : JsonModel
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

    public required ApiEnum<string, CustomerV1DataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, CustomerV1DataStatus>>("status");
        }
        init { this._rawData.Set("status", value); }
    }

    public required ApiEnum<string, CustomerV1DataType> Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, CustomerV1DataType>>("type");
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
    /// PII required to trigger Patriot Act compliant KYC verification.
    /// </summary>
    public CustomerV1DataComplianceProfile? ComplianceProfile
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<CustomerV1DataComplianceProfile>(
                "compliance_profile"
            );
        }
        init { this._rawData.Set("compliance_profile", value); }
    }

    public CustomerV1DataConfig? Config
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<CustomerV1DataConfig>("config");
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

    public Device? Device
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Device>("device");
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

    public CustomerV1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CustomerV1Data(CustomerV1Data customerV1Data)
        : base(customerV1Data) { }
#pragma warning restore CS8618

    public CustomerV1Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerV1Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerV1DataFromRaw.FromRawUnchecked"/>
    public static CustomerV1Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CustomerV1DataFromRaw : IFromRawJson<CustomerV1Data>
{
    /// <inheritdoc/>
    public CustomerV1Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        CustomerV1Data.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(CustomerV1DataStatusConverter))]
public enum CustomerV1DataStatus
{
    Pending,
    Review,
    Verified,
    Inactive,
    Rejected,
}

sealed class CustomerV1DataStatusConverter : JsonConverter<CustomerV1DataStatus>
{
    public override CustomerV1DataStatus Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => CustomerV1DataStatus.Pending,
            "review" => CustomerV1DataStatus.Review,
            "verified" => CustomerV1DataStatus.Verified,
            "inactive" => CustomerV1DataStatus.Inactive,
            "rejected" => CustomerV1DataStatus.Rejected,
            _ => (CustomerV1DataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CustomerV1DataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CustomerV1DataStatus.Pending => "pending",
                CustomerV1DataStatus.Review => "review",
                CustomerV1DataStatus.Verified => "verified",
                CustomerV1DataStatus.Inactive => "inactive",
                CustomerV1DataStatus.Rejected => "rejected",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(CustomerV1DataTypeConverter))]
public enum CustomerV1DataType
{
    Individual,
    Business,
}

sealed class CustomerV1DataTypeConverter : JsonConverter<CustomerV1DataType>
{
    public override CustomerV1DataType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "individual" => CustomerV1DataType.Individual,
            "business" => CustomerV1DataType.Business,
            _ => (CustomerV1DataType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CustomerV1DataType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CustomerV1DataType.Individual => "individual",
                CustomerV1DataType.Business => "business",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// PII required to trigger Patriot Act compliant KYC verification.
/// </summary>
[JsonConverter(typeof(CustomerV1DataComplianceProfileConverter))]
public record class CustomerV1DataComplianceProfile : ModelBase
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

    public CustomerV1DataComplianceProfile(
        CustomerV1DataComplianceProfileIndividualComplianceProfile value,
        JsonElement? element = null
    )
    {
        this.Value = value;
        this._element = element;
    }

    public CustomerV1DataComplianceProfile(
        CustomerV1DataComplianceProfileBusinessComplianceProfile value,
        JsonElement? element = null
    )
    {
        this.Value = value;
        this._element = element;
    }

    public CustomerV1DataComplianceProfile(JsonElement element)
    {
        this._element = element;
    }

    /// <summary>
    /// Returns true and sets the <c>out</c> parameter if the instance was constructed with a variant of
    /// type <see cref="CustomerV1DataComplianceProfileIndividualComplianceProfile"/>.
    ///
    /// <para>Consider using <see cref="Switch"> or <see cref="Match"> if you need to handle every variant.</para>
    ///
    /// <example>
    /// <code>
    /// if (instance.TryPickIndividual(out var value)) {
    ///     // `value` is of type `CustomerV1DataComplianceProfileIndividualComplianceProfile`
    ///     Console.WriteLine(value);
    /// }
    /// </code>
    /// </example>
    /// </summary>
    public bool TryPickIndividual(
        [NotNullWhen(true)] out CustomerV1DataComplianceProfileIndividualComplianceProfile? value
    )
    {
        value = this.Value as CustomerV1DataComplianceProfileIndividualComplianceProfile;
        return value != null;
    }

    /// <summary>
    /// Returns true and sets the <c>out</c> parameter if the instance was constructed with a variant of
    /// type <see cref="CustomerV1DataComplianceProfileBusinessComplianceProfile"/>.
    ///
    /// <para>Consider using <see cref="Switch"> or <see cref="Match"> if you need to handle every variant.</para>
    ///
    /// <example>
    /// <code>
    /// if (instance.TryPickBusiness(out var value)) {
    ///     // `value` is of type `CustomerV1DataComplianceProfileBusinessComplianceProfile`
    ///     Console.WriteLine(value);
    /// }
    /// </code>
    /// </example>
    /// </summary>
    public bool TryPickBusiness(
        [NotNullWhen(true)] out CustomerV1DataComplianceProfileBusinessComplianceProfile? value
    )
    {
        value = this.Value as CustomerV1DataComplianceProfileBusinessComplianceProfile;
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
    ///     (CustomerV1DataComplianceProfileIndividualComplianceProfile value) => {...},
    ///     (CustomerV1DataComplianceProfileBusinessComplianceProfile value) => {...}
    /// );
    /// </code>
    /// </example>
    /// </summary>
    public void Switch(
        System::Action<CustomerV1DataComplianceProfileIndividualComplianceProfile> individual,
        System::Action<CustomerV1DataComplianceProfileBusinessComplianceProfile> business
    )
    {
        switch (this.Value)
        {
            case CustomerV1DataComplianceProfileIndividualComplianceProfile value:
                individual(value);
                break;
            case CustomerV1DataComplianceProfileBusinessComplianceProfile value:
                business(value);
                break;
            default:
                throw new StraddleInvalidDataException(
                    "Data did not match any variant of CustomerV1DataComplianceProfile"
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
    ///     (CustomerV1DataComplianceProfileIndividualComplianceProfile value) => {...},
    ///     (CustomerV1DataComplianceProfileBusinessComplianceProfile value) => {...}
    /// );
    /// </code>
    /// </example>
    /// </summary>
    public T Match<T>(
        System::Func<CustomerV1DataComplianceProfileIndividualComplianceProfile, T> individual,
        System::Func<CustomerV1DataComplianceProfileBusinessComplianceProfile, T> business
    )
    {
        return this.Value switch
        {
            CustomerV1DataComplianceProfileIndividualComplianceProfile value => individual(value),
            CustomerV1DataComplianceProfileBusinessComplianceProfile value => business(value),
            _ => throw new StraddleInvalidDataException(
                "Data did not match any variant of CustomerV1DataComplianceProfile"
            ),
        };
    }

    public static implicit operator CustomerV1DataComplianceProfile(
        CustomerV1DataComplianceProfileIndividualComplianceProfile value
    ) => new(value);

    public static implicit operator CustomerV1DataComplianceProfile(
        CustomerV1DataComplianceProfileBusinessComplianceProfile value
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
                "Data did not match any variant of CustomerV1DataComplianceProfile"
            );
        }
        this.Switch((individual) => individual.Validate(), (business) => business.Validate());
    }

    public virtual bool Equals(CustomerV1DataComplianceProfile? other)
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

sealed class CustomerV1DataComplianceProfileConverter
    : JsonConverter<CustomerV1DataComplianceProfile?>
{
    public override CustomerV1DataComplianceProfile? Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        var element = JsonSerializer.Deserialize<JsonElement>(ref reader, options);
        try
        {
            var deserialized =
                JsonSerializer.Deserialize<CustomerV1DataComplianceProfileIndividualComplianceProfile>(
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
                JsonSerializer.Deserialize<CustomerV1DataComplianceProfileBusinessComplianceProfile>(
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
        CustomerV1DataComplianceProfile? value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(writer, value?.Json, options);
    }
}

/// <summary>
/// PII required to trigger Patriot Act compliant KYC verification.
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        CustomerV1DataComplianceProfileIndividualComplianceProfile,
        CustomerV1DataComplianceProfileIndividualComplianceProfileFromRaw
    >)
)]
public sealed record class CustomerV1DataComplianceProfileIndividualComplianceProfile : JsonModel
{
    /// <summary>
    /// Masked date of birth in ****-**-** format.
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
    /// Masked Social Security Number in the format ***-**-****.
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

    public CustomerV1DataComplianceProfileIndividualComplianceProfile() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CustomerV1DataComplianceProfileIndividualComplianceProfile(
        CustomerV1DataComplianceProfileIndividualComplianceProfile customerV1DataComplianceProfileIndividualComplianceProfile
    )
        : base(customerV1DataComplianceProfileIndividualComplianceProfile) { }
#pragma warning restore CS8618

    public CustomerV1DataComplianceProfileIndividualComplianceProfile(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerV1DataComplianceProfileIndividualComplianceProfile(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerV1DataComplianceProfileIndividualComplianceProfileFromRaw.FromRawUnchecked"/>
    public static CustomerV1DataComplianceProfileIndividualComplianceProfile FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CustomerV1DataComplianceProfileIndividualComplianceProfileFromRaw
    : IFromRawJson<CustomerV1DataComplianceProfileIndividualComplianceProfile>
{
    /// <inheritdoc/>
    public CustomerV1DataComplianceProfileIndividualComplianceProfile FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CustomerV1DataComplianceProfileIndividualComplianceProfile.FromRawUnchecked(rawData);
}

/// <summary>
/// Business registration data required to trigger Patriot Act compliant KYB verification.
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        CustomerV1DataComplianceProfileBusinessComplianceProfile,
        CustomerV1DataComplianceProfileBusinessComplianceProfileFromRaw
    >)
)]
public sealed record class CustomerV1DataComplianceProfileBusinessComplianceProfile : JsonModel
{
    /// <summary>
    /// Masked Employer Identification Number in the format **-*******
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
    /// The official registered name of the business. This name should be correlated
    /// with the `ein` value.
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
    public IReadOnlyList<CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative>? Representatives
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<
                ImmutableArray<CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative>
            >("representatives");
        }
        init
        {
            this._rawData.Set<ImmutableArray<CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative>?>(
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

    public CustomerV1DataComplianceProfileBusinessComplianceProfile() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CustomerV1DataComplianceProfileBusinessComplianceProfile(
        CustomerV1DataComplianceProfileBusinessComplianceProfile customerV1DataComplianceProfileBusinessComplianceProfile
    )
        : base(customerV1DataComplianceProfileBusinessComplianceProfile) { }
#pragma warning restore CS8618

    public CustomerV1DataComplianceProfileBusinessComplianceProfile(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerV1DataComplianceProfileBusinessComplianceProfile(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerV1DataComplianceProfileBusinessComplianceProfileFromRaw.FromRawUnchecked"/>
    public static CustomerV1DataComplianceProfileBusinessComplianceProfile FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CustomerV1DataComplianceProfileBusinessComplianceProfileFromRaw
    : IFromRawJson<CustomerV1DataComplianceProfileBusinessComplianceProfile>
{
    /// <inheritdoc/>
    public CustomerV1DataComplianceProfileBusinessComplianceProfile FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CustomerV1DataComplianceProfileBusinessComplianceProfile.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative,
        CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentativeFromRaw
    >)
)]
public sealed record class CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative
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

    public CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative(
        CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative customerV1DataComplianceProfileBusinessComplianceProfileRepresentative
    )
        : base(customerV1DataComplianceProfileBusinessComplianceProfileRepresentative) { }
#pragma warning restore CS8618

    public CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentativeFromRaw.FromRawUnchecked"/>
    public static CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative(string name)
        : this()
    {
        this.Name = name;
    }
}

class CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentativeFromRaw
    : IFromRawJson<CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative>
{
    /// <inheritdoc/>
    public CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) =>
        CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative.FromRawUnchecked(
            rawData
        );
}

[JsonConverter(typeof(JsonModelConverter<CustomerV1DataConfig, CustomerV1DataConfigFromRaw>))]
public sealed record class CustomerV1DataConfig : JsonModel
{
    public ApiEnum<string, CustomerV1DataConfigProcessingMethod>? ProcessingMethod
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, CustomerV1DataConfigProcessingMethod>
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

    public ApiEnum<string, CustomerV1DataConfigSandboxOutcome>? SandboxOutcome
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, CustomerV1DataConfigSandboxOutcome>
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

    public CustomerV1DataConfig() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CustomerV1DataConfig(CustomerV1DataConfig customerV1DataConfig)
        : base(customerV1DataConfig) { }
#pragma warning restore CS8618

    public CustomerV1DataConfig(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerV1DataConfig(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerV1DataConfigFromRaw.FromRawUnchecked"/>
    public static CustomerV1DataConfig FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CustomerV1DataConfigFromRaw : IFromRawJson<CustomerV1DataConfig>
{
    /// <inheritdoc/>
    public CustomerV1DataConfig FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CustomerV1DataConfig.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(CustomerV1DataConfigProcessingMethodConverter))]
public enum CustomerV1DataConfigProcessingMethod
{
    Inline,
    Background,
    Skip,
}

sealed class CustomerV1DataConfigProcessingMethodConverter
    : JsonConverter<CustomerV1DataConfigProcessingMethod>
{
    public override CustomerV1DataConfigProcessingMethod Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "inline" => CustomerV1DataConfigProcessingMethod.Inline,
            "background" => CustomerV1DataConfigProcessingMethod.Background,
            "skip" => CustomerV1DataConfigProcessingMethod.Skip,
            _ => (CustomerV1DataConfigProcessingMethod)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CustomerV1DataConfigProcessingMethod value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CustomerV1DataConfigProcessingMethod.Inline => "inline",
                CustomerV1DataConfigProcessingMethod.Background => "background",
                CustomerV1DataConfigProcessingMethod.Skip => "skip",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(CustomerV1DataConfigSandboxOutcomeConverter))]
public enum CustomerV1DataConfigSandboxOutcome
{
    Standard,
    Verified,
    Rejected,
    Review,
}

sealed class CustomerV1DataConfigSandboxOutcomeConverter
    : JsonConverter<CustomerV1DataConfigSandboxOutcome>
{
    public override CustomerV1DataConfigSandboxOutcome Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "standard" => CustomerV1DataConfigSandboxOutcome.Standard,
            "verified" => CustomerV1DataConfigSandboxOutcome.Verified,
            "rejected" => CustomerV1DataConfigSandboxOutcome.Rejected,
            "review" => CustomerV1DataConfigSandboxOutcome.Review,
            _ => (CustomerV1DataConfigSandboxOutcome)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CustomerV1DataConfigSandboxOutcome value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CustomerV1DataConfigSandboxOutcome.Standard => "standard",
                CustomerV1DataConfigSandboxOutcome.Verified => "verified",
                CustomerV1DataConfigSandboxOutcome.Rejected => "rejected",
                CustomerV1DataConfigSandboxOutcome.Review => "review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<Device, DeviceFromRaw>))]
public sealed record class Device : JsonModel
{
    /// <summary>
    /// The customer's IP address at the time of profile creation. Use `0.0.0.0`
    /// to represent an offline customer registration.
    /// </summary>
    public required string IPAddress
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("ip_address");
        }
        init { this._rawData.Set("ip_address", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.IPAddress;
    }

    public Device() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Device(Device device)
        : base(device) { }
#pragma warning restore CS8618

    public Device(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Device(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DeviceFromRaw.FromRawUnchecked"/>
    public static Device FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public Device(string ipAddress)
        : this()
    {
        this.IPAddress = ipAddress;
    }
}

class DeviceFromRaw : IFromRawJson<Device>
{
    /// <inheritdoc/>
    public Device FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Device.FromRawUnchecked(rawData);
}

/// <summary>
/// Indicates the structure of the returned content. - "object" means the `data`
/// field contains a single JSON object. - "array" means the `data` field contains
/// an array of objects. - "error" means the `data` field contains an error object
/// with details of the issue. - "none" means no data is returned.
/// </summary>
[JsonConverter(typeof(CustomerV1ResponseTypeConverter))]
public enum CustomerV1ResponseType
{
    Object,
    Array,
    Error,
    None,
}

sealed class CustomerV1ResponseTypeConverter : JsonConverter<CustomerV1ResponseType>
{
    public override CustomerV1ResponseType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "object" => CustomerV1ResponseType.Object,
            "array" => CustomerV1ResponseType.Array,
            "error" => CustomerV1ResponseType.Error,
            "none" => CustomerV1ResponseType.None,
            _ => (CustomerV1ResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CustomerV1ResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CustomerV1ResponseType.Object => "object",
                CustomerV1ResponseType.Array => "array",
                CustomerV1ResponseType.Error => "error",
                CustomerV1ResponseType.None => "none",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
