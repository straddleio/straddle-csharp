using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;
using System = System;

namespace Straddle.Models.Customers.Review;

[JsonConverter(typeof(JsonModelConverter<CustomerReviewV1, CustomerReviewV1FromRaw>))]
public sealed record class CustomerReviewV1 : JsonModel
{
    public required Data Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<Data>("data");
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
        this.Data.Validate();
        this.Meta.Validate();
        this.ResponseType.Validate();
    }

    public CustomerReviewV1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CustomerReviewV1(CustomerReviewV1 customerReviewV1)
        : base(customerReviewV1) { }
#pragma warning restore CS8618

    public CustomerReviewV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerReviewV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerReviewV1FromRaw.FromRawUnchecked"/>
    public static CustomerReviewV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CustomerReviewV1FromRaw : IFromRawJson<CustomerReviewV1>
{
    /// <inheritdoc/>
    public CustomerReviewV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        CustomerReviewV1.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    public required CustomerDetails CustomerDetails
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<CustomerDetails>("customer_details");
        }
        init { this._rawData.Set("customer_details", value); }
    }

    public IdentityDetails? IdentityDetails
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<IdentityDetails>("identity_details");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("identity_details", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.CustomerDetails.Validate();
        this.IdentityDetails?.Validate();
    }

    public Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Data(Data data)
        : base(data) { }
#pragma warning restore CS8618

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

    [SetsRequiredMembers]
    public Data(CustomerDetails customerDetails)
        : this()
    {
        this.CustomerDetails = customerDetails;
    }
}

class DataFromRaw : IFromRawJson<Data>
{
    /// <inheritdoc/>
    public Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Data.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<CustomerDetails, CustomerDetailsFromRaw>))]
public sealed record class CustomerDetails : JsonModel
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

    public required ApiEnum<string, CustomerDetailsStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, CustomerDetailsStatus>>("status");
        }
        init { this._rawData.Set("status", value); }
    }

    public required ApiEnum<string, global::Straddle.Models.Customers.Review.Type> Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, global::Straddle.Models.Customers.Review.Type>
            >("type");
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
    public ComplianceProfile? ComplianceProfile
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ComplianceProfile>("compliance_profile");
        }
        init { this._rawData.Set("compliance_profile", value); }
    }

    public Config? Config
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Config>("config");
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

    public CustomerDetails() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CustomerDetails(CustomerDetails customerDetails)
        : base(customerDetails) { }
#pragma warning restore CS8618

    public CustomerDetails(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerDetails(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerDetailsFromRaw.FromRawUnchecked"/>
    public static CustomerDetails FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CustomerDetailsFromRaw : IFromRawJson<CustomerDetails>
{
    /// <inheritdoc/>
    public CustomerDetails FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        CustomerDetails.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(CustomerDetailsStatusConverter))]
public enum CustomerDetailsStatus
{
    Pending,
    Review,
    Verified,
    Inactive,
    Rejected,
}

sealed class CustomerDetailsStatusConverter : JsonConverter<CustomerDetailsStatus>
{
    public override CustomerDetailsStatus Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => CustomerDetailsStatus.Pending,
            "review" => CustomerDetailsStatus.Review,
            "verified" => CustomerDetailsStatus.Verified,
            "inactive" => CustomerDetailsStatus.Inactive,
            "rejected" => CustomerDetailsStatus.Rejected,
            _ => (CustomerDetailsStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CustomerDetailsStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CustomerDetailsStatus.Pending => "pending",
                CustomerDetailsStatus.Review => "review",
                CustomerDetailsStatus.Verified => "verified",
                CustomerDetailsStatus.Inactive => "inactive",
                CustomerDetailsStatus.Rejected => "rejected",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(TypeConverter))]
public enum Type
{
    Individual,
    Business,
}

sealed class TypeConverter : JsonConverter<global::Straddle.Models.Customers.Review.Type>
{
    public override global::Straddle.Models.Customers.Review.Type Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "individual" => global::Straddle.Models.Customers.Review.Type.Individual,
            "business" => global::Straddle.Models.Customers.Review.Type.Business,
            _ => (global::Straddle.Models.Customers.Review.Type)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        global::Straddle.Models.Customers.Review.Type value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                global::Straddle.Models.Customers.Review.Type.Individual => "individual",
                global::Straddle.Models.Customers.Review.Type.Business => "business",
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
[JsonConverter(typeof(ComplianceProfileConverter))]
public record class ComplianceProfile : ModelBase
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

    public ComplianceProfile(IndividualComplianceProfile value, JsonElement? element = null)
    {
        this.Value = value;
        this._element = element;
    }

    public ComplianceProfile(BusinessComplianceProfile value, JsonElement? element = null)
    {
        this.Value = value;
        this._element = element;
    }

    public ComplianceProfile(JsonElement element)
    {
        this._element = element;
    }

    /// <summary>
    /// Returns true and sets the <c>out</c> parameter if the instance was constructed with a variant of
    /// type <see cref="IndividualComplianceProfile"/>.
    ///
    /// <para>Consider using <see cref="Switch"> or <see cref="Match"> if you need to handle every variant.</para>
    ///
    /// <example>
    /// <code>
    /// if (instance.TryPickIndividual(out var value)) {
    ///     // `value` is of type `IndividualComplianceProfile`
    ///     Console.WriteLine(value);
    /// }
    /// </code>
    /// </example>
    /// </summary>
    public bool TryPickIndividual([NotNullWhen(true)] out IndividualComplianceProfile? value)
    {
        value = this.Value as IndividualComplianceProfile;
        return value != null;
    }

    /// <summary>
    /// Returns true and sets the <c>out</c> parameter if the instance was constructed with a variant of
    /// type <see cref="BusinessComplianceProfile"/>.
    ///
    /// <para>Consider using <see cref="Switch"> or <see cref="Match"> if you need to handle every variant.</para>
    ///
    /// <example>
    /// <code>
    /// if (instance.TryPickBusiness(out var value)) {
    ///     // `value` is of type `BusinessComplianceProfile`
    ///     Console.WriteLine(value);
    /// }
    /// </code>
    /// </example>
    /// </summary>
    public bool TryPickBusiness([NotNullWhen(true)] out BusinessComplianceProfile? value)
    {
        value = this.Value as BusinessComplianceProfile;
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
    ///     (IndividualComplianceProfile value) => {...},
    ///     (BusinessComplianceProfile value) => {...}
    /// );
    /// </code>
    /// </example>
    /// </summary>
    public void Switch(
        System::Action<IndividualComplianceProfile> individual,
        System::Action<BusinessComplianceProfile> business
    )
    {
        switch (this.Value)
        {
            case IndividualComplianceProfile value:
                individual(value);
                break;
            case BusinessComplianceProfile value:
                business(value);
                break;
            default:
                throw new StraddleInvalidDataException(
                    "Data did not match any variant of ComplianceProfile"
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
    ///     (IndividualComplianceProfile value) => {...},
    ///     (BusinessComplianceProfile value) => {...}
    /// );
    /// </code>
    /// </example>
    /// </summary>
    public T Match<T>(
        System::Func<IndividualComplianceProfile, T> individual,
        System::Func<BusinessComplianceProfile, T> business
    )
    {
        return this.Value switch
        {
            IndividualComplianceProfile value => individual(value),
            BusinessComplianceProfile value => business(value),
            _ => throw new StraddleInvalidDataException(
                "Data did not match any variant of ComplianceProfile"
            ),
        };
    }

    public static implicit operator ComplianceProfile(IndividualComplianceProfile value) =>
        new(value);

    public static implicit operator ComplianceProfile(BusinessComplianceProfile value) =>
        new(value);

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
                "Data did not match any variant of ComplianceProfile"
            );
        }
        this.Switch((individual) => individual.Validate(), (business) => business.Validate());
    }

    public virtual bool Equals(ComplianceProfile? other)
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

sealed class ComplianceProfileConverter : JsonConverter<ComplianceProfile?>
{
    public override ComplianceProfile? Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        var element = JsonSerializer.Deserialize<JsonElement>(ref reader, options);
        try
        {
            var deserialized = JsonSerializer.Deserialize<IndividualComplianceProfile>(
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
            var deserialized = JsonSerializer.Deserialize<BusinessComplianceProfile>(
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
        ComplianceProfile? value,
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
    typeof(JsonModelConverter<IndividualComplianceProfile, IndividualComplianceProfileFromRaw>)
)]
public sealed record class IndividualComplianceProfile : JsonModel
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

    public IndividualComplianceProfile() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public IndividualComplianceProfile(IndividualComplianceProfile individualComplianceProfile)
        : base(individualComplianceProfile) { }
#pragma warning restore CS8618

    public IndividualComplianceProfile(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    IndividualComplianceProfile(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IndividualComplianceProfileFromRaw.FromRawUnchecked"/>
    public static IndividualComplianceProfile FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class IndividualComplianceProfileFromRaw : IFromRawJson<IndividualComplianceProfile>
{
    /// <inheritdoc/>
    public IndividualComplianceProfile FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => IndividualComplianceProfile.FromRawUnchecked(rawData);
}

/// <summary>
/// Business registration data required to trigger Patriot Act compliant KYB verification.
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<BusinessComplianceProfile, BusinessComplianceProfileFromRaw>)
)]
public sealed record class BusinessComplianceProfile : JsonModel
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
    public IReadOnlyList<Representative>? Representatives
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Representative>>(
                "representatives"
            );
        }
        init
        {
            this._rawData.Set<ImmutableArray<Representative>?>(
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

    public BusinessComplianceProfile() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public BusinessComplianceProfile(BusinessComplianceProfile businessComplianceProfile)
        : base(businessComplianceProfile) { }
#pragma warning restore CS8618

    public BusinessComplianceProfile(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    BusinessComplianceProfile(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="BusinessComplianceProfileFromRaw.FromRawUnchecked"/>
    public static BusinessComplianceProfile FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class BusinessComplianceProfileFromRaw : IFromRawJson<BusinessComplianceProfile>
{
    /// <inheritdoc/>
    public BusinessComplianceProfile FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => BusinessComplianceProfile.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Representative, RepresentativeFromRaw>))]
public sealed record class Representative : JsonModel
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

    public Representative() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Representative(Representative representative)
        : base(representative) { }
#pragma warning restore CS8618

    public Representative(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Representative(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RepresentativeFromRaw.FromRawUnchecked"/>
    public static Representative FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public Representative(string name)
        : this()
    {
        this.Name = name;
    }
}

class RepresentativeFromRaw : IFromRawJson<Representative>
{
    /// <inheritdoc/>
    public Representative FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Representative.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Config, ConfigFromRaw>))]
public sealed record class Config : JsonModel
{
    public ApiEnum<string, ProcessingMethod>? ProcessingMethod
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, ProcessingMethod>>(
                "processing_method"
            );
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

    public ApiEnum<string, SandboxOutcome>? SandboxOutcome
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, SandboxOutcome>>(
                "sandbox_outcome"
            );
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

    public Config() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Config(Config config)
        : base(config) { }
#pragma warning restore CS8618

    public Config(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Config(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ConfigFromRaw.FromRawUnchecked"/>
    public static Config FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ConfigFromRaw : IFromRawJson<Config>
{
    /// <inheritdoc/>
    public Config FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Config.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ProcessingMethodConverter))]
public enum ProcessingMethod
{
    Inline,
    Background,
    Skip,
}

sealed class ProcessingMethodConverter : JsonConverter<ProcessingMethod>
{
    public override ProcessingMethod Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "inline" => ProcessingMethod.Inline,
            "background" => ProcessingMethod.Background,
            "skip" => ProcessingMethod.Skip,
            _ => (ProcessingMethod)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ProcessingMethod value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ProcessingMethod.Inline => "inline",
                ProcessingMethod.Background => "background",
                ProcessingMethod.Skip => "skip",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(SandboxOutcomeConverter))]
public enum SandboxOutcome
{
    Standard,
    Verified,
    Rejected,
    Review,
}

sealed class SandboxOutcomeConverter : JsonConverter<SandboxOutcome>
{
    public override SandboxOutcome Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "standard" => SandboxOutcome.Standard,
            "verified" => SandboxOutcome.Verified,
            "rejected" => SandboxOutcome.Rejected,
            "review" => SandboxOutcome.Review,
            _ => (SandboxOutcome)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        SandboxOutcome value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                SandboxOutcome.Standard => "standard",
                SandboxOutcome.Verified => "verified",
                SandboxOutcome.Rejected => "rejected",
                SandboxOutcome.Review => "review",
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

[JsonConverter(typeof(JsonModelConverter<IdentityDetails, IdentityDetailsFromRaw>))]
public sealed record class IdentityDetails : JsonModel
{
    /// <summary>
    /// Detailed breakdown of the customer verification results, including decisions,
    /// risk scores, correlation score, and more.
    /// </summary>
    public required Breakdown Breakdown
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<Breakdown>("breakdown");
        }
        init { this._rawData.Set("breakdown", value); }
    }

    /// <summary>
    /// Timestamp of when the review was initiated.
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

    public required ApiEnum<string, Decision> Decision
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Decision>>("decision");
        }
        init { this._rawData.Set("decision", value); }
    }

    /// <summary>
    /// Unique identifier for the review.
    /// </summary>
    public required string ReviewID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("review_id");
        }
        init { this._rawData.Set("review_id", value); }
    }

    /// <summary>
    /// Timestamp of the most recent update to the review.
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

    public Kyc? Kyc
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Kyc>("kyc");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("kyc", value);
        }
    }

    /// <summary>
    /// Dictionary of all messages from the customer verification process.
    /// </summary>
    public IReadOnlyDictionary<string, string>? Messages
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("messages");
        }
        init
        {
            this._rawData.Set<FrozenDictionary<string, string>?>(
                "messages",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    public NetworkAlerts? NetworkAlerts
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<NetworkAlerts>("network_alerts");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("network_alerts", value);
        }
    }

    public Reputation? Reputation
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Reputation>("reputation");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("reputation", value);
        }
    }

    public WatchList? WatchList
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<WatchList>("watch_list");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("watch_list", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Breakdown.Validate();
        _ = this.CreatedAt;
        this.Decision.Validate();
        _ = this.ReviewID;
        _ = this.UpdatedAt;
        this.Kyc?.Validate();
        _ = this.Messages;
        this.NetworkAlerts?.Validate();
        this.Reputation?.Validate();
        this.WatchList?.Validate();
    }

    public IdentityDetails() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public IdentityDetails(IdentityDetails identityDetails)
        : base(identityDetails) { }
#pragma warning restore CS8618

    public IdentityDetails(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    IdentityDetails(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IdentityDetailsFromRaw.FromRawUnchecked"/>
    public static IdentityDetails FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class IdentityDetailsFromRaw : IFromRawJson<IdentityDetails>
{
    /// <inheritdoc/>
    public IdentityDetails FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        IdentityDetails.FromRawUnchecked(rawData);
}

/// <summary>
/// Detailed breakdown of the customer verification results, including decisions,
/// risk scores, correlation score, and more.
/// </summary>
[JsonConverter(typeof(JsonModelConverter<Breakdown, BreakdownFromRaw>))]
public sealed record class Breakdown : JsonModel
{
    public IdentityVerificationBreakdownV1? Address
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<IdentityVerificationBreakdownV1>("address");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("address", value);
        }
    }

    public IdentityVerificationBreakdownV1? BusinessEvaluation
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<IdentityVerificationBreakdownV1>(
                "business_evaluation"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("business_evaluation", value);
        }
    }

    public IdentityVerificationBreakdownV1? BusinessIdentification
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<IdentityVerificationBreakdownV1>(
                "business_identification"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("business_identification", value);
        }
    }

    public IdentityVerificationBreakdownV1? BusinessValidation
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<IdentityVerificationBreakdownV1>(
                "business_validation"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("business_validation", value);
        }
    }

    public IdentityVerificationBreakdownV1? Email
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<IdentityVerificationBreakdownV1>("email");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("email", value);
        }
    }

    public IdentityVerificationBreakdownV1? Fraud
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<IdentityVerificationBreakdownV1>("fraud");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("fraud", value);
        }
    }

    public IdentityVerificationBreakdownV1? Phone
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<IdentityVerificationBreakdownV1>("phone");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("phone", value);
        }
    }

    public IdentityVerificationBreakdownV1? Synthetic
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<IdentityVerificationBreakdownV1>("synthetic");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("synthetic", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Address?.Validate();
        this.BusinessEvaluation?.Validate();
        this.BusinessIdentification?.Validate();
        this.BusinessValidation?.Validate();
        this.Email?.Validate();
        this.Fraud?.Validate();
        this.Phone?.Validate();
        this.Synthetic?.Validate();
    }

    public Breakdown() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Breakdown(Breakdown breakdown)
        : base(breakdown) { }
#pragma warning restore CS8618

    public Breakdown(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Breakdown(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="BreakdownFromRaw.FromRawUnchecked"/>
    public static Breakdown FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class BreakdownFromRaw : IFromRawJson<Breakdown>
{
    /// <inheritdoc/>
    public Breakdown FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Breakdown.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(DecisionConverter))]
public enum Decision
{
    Accept,
    Reject,
    Review,
}

sealed class DecisionConverter : JsonConverter<Decision>
{
    public override Decision Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "accept" => Decision.Accept,
            "reject" => Decision.Reject,
            "review" => Decision.Review,
            _ => (Decision)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Decision value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Decision.Accept => "accept",
                Decision.Reject => "reject",
                Decision.Review => "review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<Kyc, KycFromRaw>))]
public sealed record class Kyc : JsonModel
{
    /// <summary>
    /// Boolean values indicating the result of each validation in the KYC process.
    /// </summary>
    public required Validations Validations
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<Validations>("validations");
        }
        init { this._rawData.Set("validations", value); }
    }

    /// <summary>
    /// List of specific result codes from the KYC screening process.
    /// </summary>
    public IReadOnlyList<string>? Codes
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("codes");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>?>(
                "codes",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public ApiEnum<string, KycDecision>? Decision
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, KycDecision>>("decision");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("decision", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Validations.Validate();
        _ = this.Codes;
        this.Decision?.Validate();
    }

    public Kyc() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Kyc(Kyc kyc)
        : base(kyc) { }
#pragma warning restore CS8618

    public Kyc(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Kyc(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="KycFromRaw.FromRawUnchecked"/>
    public static Kyc FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public Kyc(Validations validations)
        : this()
    {
        this.Validations = validations;
    }
}

class KycFromRaw : IFromRawJson<Kyc>
{
    /// <inheritdoc/>
    public Kyc FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Kyc.FromRawUnchecked(rawData);
}

/// <summary>
/// Boolean values indicating the result of each validation in the KYC process.
/// </summary>
[JsonConverter(typeof(JsonModelConverter<Validations, ValidationsFromRaw>))]
public sealed record class Validations : JsonModel
{
    public bool? Address
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("address");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("address", value);
        }
    }

    public bool? City
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("city");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("city", value);
        }
    }

    public bool? Dob
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("dob");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("dob", value);
        }
    }

    public bool? Email
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("email");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("email", value);
        }
    }

    public bool? FirstName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("first_name");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("first_name", value);
        }
    }

    public bool? LastName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("last_name");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("last_name", value);
        }
    }

    public bool? Phone
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("phone");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("phone", value);
        }
    }

    public bool? Ssn
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("ssn");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("ssn", value);
        }
    }

    public bool? State
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("state");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("state", value);
        }
    }

    public bool? Zip
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<bool>("zip");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("zip", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Address;
        _ = this.City;
        _ = this.Dob;
        _ = this.Email;
        _ = this.FirstName;
        _ = this.LastName;
        _ = this.Phone;
        _ = this.Ssn;
        _ = this.State;
        _ = this.Zip;
    }

    public Validations() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Validations(Validations validations)
        : base(validations) { }
#pragma warning restore CS8618

    public Validations(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Validations(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ValidationsFromRaw.FromRawUnchecked"/>
    public static Validations FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ValidationsFromRaw : IFromRawJson<Validations>
{
    /// <inheritdoc/>
    public Validations FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Validations.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(KycDecisionConverter))]
public enum KycDecision
{
    Accept,
    Reject,
    Review,
}

sealed class KycDecisionConverter : JsonConverter<KycDecision>
{
    public override KycDecision Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "accept" => KycDecision.Accept,
            "reject" => KycDecision.Reject,
            "review" => KycDecision.Review,
            _ => (KycDecision)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        KycDecision value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                KycDecision.Accept => "accept",
                KycDecision.Reject => "reject",
                KycDecision.Review => "review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<NetworkAlerts, NetworkAlertsFromRaw>))]
public sealed record class NetworkAlerts : JsonModel
{
    /// <summary>
    /// Any alerts or flags raised during the consortium alert screening.
    /// </summary>
    public IReadOnlyList<string>? Alerts
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("alerts");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>?>(
                "alerts",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// List of specific result codes from the consortium alert screening.
    /// </summary>
    public IReadOnlyList<string>? Codes
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("codes");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>?>(
                "codes",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public ApiEnum<string, NetworkAlertsDecision>? Decision
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, NetworkAlertsDecision>>(
                "decision"
            );
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("decision", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Alerts;
        _ = this.Codes;
        this.Decision?.Validate();
    }

    public NetworkAlerts() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public NetworkAlerts(NetworkAlerts networkAlerts)
        : base(networkAlerts) { }
#pragma warning restore CS8618

    public NetworkAlerts(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    NetworkAlerts(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="NetworkAlertsFromRaw.FromRawUnchecked"/>
    public static NetworkAlerts FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class NetworkAlertsFromRaw : IFromRawJson<NetworkAlerts>
{
    /// <inheritdoc/>
    public NetworkAlerts FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        NetworkAlerts.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(NetworkAlertsDecisionConverter))]
public enum NetworkAlertsDecision
{
    Accept,
    Reject,
    Review,
}

sealed class NetworkAlertsDecisionConverter : JsonConverter<NetworkAlertsDecision>
{
    public override NetworkAlertsDecision Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "accept" => NetworkAlertsDecision.Accept,
            "reject" => NetworkAlertsDecision.Reject,
            "review" => NetworkAlertsDecision.Review,
            _ => (NetworkAlertsDecision)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        NetworkAlertsDecision value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                NetworkAlertsDecision.Accept => "accept",
                NetworkAlertsDecision.Reject => "reject",
                NetworkAlertsDecision.Review => "review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<Reputation, ReputationFromRaw>))]
public sealed record class Reputation : JsonModel
{
    /// <summary>
    /// Specific codes related to the Straddle reputation screening results.
    /// </summary>
    public IReadOnlyList<string>? Codes
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("codes");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>?>(
                "codes",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public ApiEnum<string, ReputationDecision>? Decision
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, ReputationDecision>>("decision");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("decision", value);
        }
    }

    public Insights? Insights
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Insights>("insights");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("insights", value);
        }
    }

    public double? RiskScore
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("risk_score");
        }
        init { this._rawData.Set("risk_score", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Codes;
        this.Decision?.Validate();
        this.Insights?.Validate();
        _ = this.RiskScore;
    }

    public Reputation() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Reputation(Reputation reputation)
        : base(reputation) { }
#pragma warning restore CS8618

    public Reputation(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Reputation(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ReputationFromRaw.FromRawUnchecked"/>
    public static Reputation FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ReputationFromRaw : IFromRawJson<Reputation>
{
    /// <inheritdoc/>
    public Reputation FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Reputation.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(ReputationDecisionConverter))]
public enum ReputationDecision
{
    Accept,
    Reject,
    Review,
}

sealed class ReputationDecisionConverter : JsonConverter<ReputationDecision>
{
    public override ReputationDecision Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "accept" => ReputationDecision.Accept,
            "reject" => ReputationDecision.Reject,
            "review" => ReputationDecision.Review,
            _ => (ReputationDecision)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ReputationDecision value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ReputationDecision.Accept => "accept",
                ReputationDecision.Reject => "reject",
                ReputationDecision.Review => "review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<Insights, InsightsFromRaw>))]
public sealed record class Insights : JsonModel
{
    public int? AccountsActiveCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("accounts_active_count");
        }
        init { this._rawData.Set("accounts_active_count", value); }
    }

    public int? AccountsClosedCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("accounts_closed_count");
        }
        init { this._rawData.Set("accounts_closed_count", value); }
    }

    public IReadOnlyList<string>? AccountsClosedDates
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("accounts_closed_dates");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>?>(
                "accounts_closed_dates",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public int? AccountsCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("accounts_count");
        }
        init { this._rawData.Set("accounts_count", value); }
    }

    public int? AccountsFraudCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("accounts_fraud_count");
        }
        init { this._rawData.Set("accounts_fraud_count", value); }
    }

    public IReadOnlyList<string>? AccountsFraudLabeledDates
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>(
                "accounts_fraud_labeled_dates"
            );
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>?>(
                "accounts_fraud_labeled_dates",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public double? AccountsFraudLossTotalAmount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("accounts_fraud_loss_total_amount");
        }
        init { this._rawData.Set("accounts_fraud_loss_total_amount", value); }
    }

    public int? AchFraudTransactionsCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("ach_fraud_transactions_count");
        }
        init { this._rawData.Set("ach_fraud_transactions_count", value); }
    }

    public IReadOnlyList<string>? AchFraudTransactionsDates
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>(
                "ach_fraud_transactions_dates"
            );
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>?>(
                "ach_fraud_transactions_dates",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public double? AchFraudTransactionsTotalAmount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("ach_fraud_transactions_total_amount");
        }
        init { this._rawData.Set("ach_fraud_transactions_total_amount", value); }
    }

    public int? AchReturnedTransactionsCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("ach_returned_transactions_count");
        }
        init { this._rawData.Set("ach_returned_transactions_count", value); }
    }

    public IReadOnlyList<string>? AchReturnedTransactionsDates
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>(
                "ach_returned_transactions_dates"
            );
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>?>(
                "ach_returned_transactions_dates",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public double? AchReturnedTransactionsTotalAmount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>(
                "ach_returned_transactions_total_amount"
            );
        }
        init { this._rawData.Set("ach_returned_transactions_total_amount", value); }
    }

    public int? ApplicationsApprovedCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("applications_approved_count");
        }
        init { this._rawData.Set("applications_approved_count", value); }
    }

    public int? ApplicationsCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("applications_count");
        }
        init { this._rawData.Set("applications_count", value); }
    }

    public IReadOnlyList<string>? ApplicationsDates
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("applications_dates");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>?>(
                "applications_dates",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public int? ApplicationsDeclinedCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("applications_declined_count");
        }
        init { this._rawData.Set("applications_declined_count", value); }
    }

    public int? ApplicationsFraudCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("applications_fraud_count");
        }
        init { this._rawData.Set("applications_fraud_count", value); }
    }

    public int? CardDisputedTransactionsCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("card_disputed_transactions_count");
        }
        init { this._rawData.Set("card_disputed_transactions_count", value); }
    }

    public IReadOnlyList<string>? CardDisputedTransactionsDates
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>(
                "card_disputed_transactions_dates"
            );
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>?>(
                "card_disputed_transactions_dates",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public double? CardDisputedTransactionsTotalAmount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>(
                "card_disputed_transactions_total_amount"
            );
        }
        init { this._rawData.Set("card_disputed_transactions_total_amount", value); }
    }

    public int? CardFraudTransactionsCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("card_fraud_transactions_count");
        }
        init { this._rawData.Set("card_fraud_transactions_count", value); }
    }

    public IReadOnlyList<string>? CardFraudTransactionsDates
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>(
                "card_fraud_transactions_dates"
            );
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>?>(
                "card_fraud_transactions_dates",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public double? CardFraudTransactionsTotalAmount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("card_fraud_transactions_total_amount");
        }
        init { this._rawData.Set("card_fraud_transactions_total_amount", value); }
    }

    public int? CardStoppedTransactionsCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("card_stopped_transactions_count");
        }
        init { this._rawData.Set("card_stopped_transactions_count", value); }
    }

    public IReadOnlyList<string>? CardStoppedTransactionsDates
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>(
                "card_stopped_transactions_dates"
            );
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>?>(
                "card_stopped_transactions_dates",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public int? UserActiveProfileCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("user_active_profile_count");
        }
        init { this._rawData.Set("user_active_profile_count", value); }
    }

    public int? UserAddressCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("user_address_count");
        }
        init { this._rawData.Set("user_address_count", value); }
    }

    public int? UserClosedProfileCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("user_closed_profile_count");
        }
        init { this._rawData.Set("user_closed_profile_count", value); }
    }

    public int? UserDobCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("user_dob_count");
        }
        init { this._rawData.Set("user_dob_count", value); }
    }

    public int? UserEmailCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("user_email_count");
        }
        init { this._rawData.Set("user_email_count", value); }
    }

    public int? UserInstitutionCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("user_institution_count");
        }
        init { this._rawData.Set("user_institution_count", value); }
    }

    public int? UserMobileCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("user_mobile_count");
        }
        init { this._rawData.Set("user_mobile_count", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AccountsActiveCount;
        _ = this.AccountsClosedCount;
        _ = this.AccountsClosedDates;
        _ = this.AccountsCount;
        _ = this.AccountsFraudCount;
        _ = this.AccountsFraudLabeledDates;
        _ = this.AccountsFraudLossTotalAmount;
        _ = this.AchFraudTransactionsCount;
        _ = this.AchFraudTransactionsDates;
        _ = this.AchFraudTransactionsTotalAmount;
        _ = this.AchReturnedTransactionsCount;
        _ = this.AchReturnedTransactionsDates;
        _ = this.AchReturnedTransactionsTotalAmount;
        _ = this.ApplicationsApprovedCount;
        _ = this.ApplicationsCount;
        _ = this.ApplicationsDates;
        _ = this.ApplicationsDeclinedCount;
        _ = this.ApplicationsFraudCount;
        _ = this.CardDisputedTransactionsCount;
        _ = this.CardDisputedTransactionsDates;
        _ = this.CardDisputedTransactionsTotalAmount;
        _ = this.CardFraudTransactionsCount;
        _ = this.CardFraudTransactionsDates;
        _ = this.CardFraudTransactionsTotalAmount;
        _ = this.CardStoppedTransactionsCount;
        _ = this.CardStoppedTransactionsDates;
        _ = this.UserActiveProfileCount;
        _ = this.UserAddressCount;
        _ = this.UserClosedProfileCount;
        _ = this.UserDobCount;
        _ = this.UserEmailCount;
        _ = this.UserInstitutionCount;
        _ = this.UserMobileCount;
    }

    public Insights() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Insights(Insights insights)
        : base(insights) { }
#pragma warning restore CS8618

    public Insights(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Insights(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="InsightsFromRaw.FromRawUnchecked"/>
    public static Insights FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class InsightsFromRaw : IFromRawJson<Insights>
{
    /// <inheritdoc/>
    public Insights FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Insights.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<WatchList, WatchListFromRaw>))]
public sealed record class WatchList : JsonModel
{
    /// <summary>
    /// Specific codes related to the Straddle watchlist screening results.
    /// </summary>
    public IReadOnlyList<string>? Codes
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("codes");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>?>(
                "codes",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public ApiEnum<string, WatchListDecision>? Decision
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, WatchListDecision>>("decision");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("decision", value);
        }
    }

    /// <summary>
    /// Information about any matches found during screening.
    /// </summary>
    public IReadOnlyList<string>? Matched
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("matched");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>?>(
                "matched",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Information about any matches found during screening.
    /// </summary>
    public IReadOnlyList<Match>? Matches
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<Match>>("matches");
        }
        init
        {
            this._rawData.Set<ImmutableArray<Match>?>(
                "matches",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Codes;
        this.Decision?.Validate();
        _ = this.Matched;
        foreach (var item in this.Matches ?? [])
        {
            item.Validate();
        }
    }

    public WatchList() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WatchList(WatchList watchList)
        : base(watchList) { }
#pragma warning restore CS8618

    public WatchList(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WatchList(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WatchListFromRaw.FromRawUnchecked"/>
    public static WatchList FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WatchListFromRaw : IFromRawJson<WatchList>
{
    /// <inheritdoc/>
    public WatchList FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        WatchList.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(WatchListDecisionConverter))]
public enum WatchListDecision
{
    Accept,
    Reject,
    Review,
}

sealed class WatchListDecisionConverter : JsonConverter<WatchListDecision>
{
    public override WatchListDecision Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "accept" => WatchListDecision.Accept,
            "reject" => WatchListDecision.Reject,
            "review" => WatchListDecision.Review,
            _ => (WatchListDecision)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        WatchListDecision value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                WatchListDecision.Accept => "accept",
                WatchListDecision.Reject => "reject",
                WatchListDecision.Review => "review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<Match, MatchFromRaw>))]
public sealed record class Match : JsonModel
{
    public required ApiEnum<string, Correlation> Correlation
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Correlation>>("correlation");
        }
        init { this._rawData.Set("correlation", value); }
    }

    /// <summary>
    /// The name of the list the match was found.
    /// </summary>
    public required string ListName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("list_name");
        }
        init { this._rawData.Set("list_name", value); }
    }

    /// <summary>
    /// Data fields that matched.
    /// </summary>
    public required IReadOnlyList<string> MatchFields
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<ImmutableArray<string>>("match_fields");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>>(
                "match_fields",
                ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Relevent Urls to review.
    /// </summary>
    public required IReadOnlyList<string> Urls
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<ImmutableArray<string>>("urls");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>>(
                "urls",
                ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Correlation.Validate();
        _ = this.ListName;
        _ = this.MatchFields;
        _ = this.Urls;
    }

    public Match() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Match(Match match)
        : base(match) { }
#pragma warning restore CS8618

    public Match(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Match(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="MatchFromRaw.FromRawUnchecked"/>
    public static Match FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class MatchFromRaw : IFromRawJson<Match>
{
    /// <inheritdoc/>
    public Match FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Match.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(CorrelationConverter))]
public enum Correlation
{
    LowConfidence,
    PotentialMatch,
    LikelyMatch,
    HighConfidence,
}

sealed class CorrelationConverter : JsonConverter<Correlation>
{
    public override Correlation Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "low_confidence" => Correlation.LowConfidence,
            "potential_match" => Correlation.PotentialMatch,
            "likely_match" => Correlation.LikelyMatch,
            "high_confidence" => Correlation.HighConfidence,
            _ => (Correlation)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        Correlation value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Correlation.LowConfidence => "low_confidence",
                Correlation.PotentialMatch => "potential_match",
                Correlation.LikelyMatch => "likely_match",
                Correlation.HighConfidence => "high_confidence",
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
