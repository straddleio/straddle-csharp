using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;
using System = System;

namespace Straddle.Models.Customers;

/// <summary>
/// Updates an existing customer's information. This endpoint allows you to modify
/// the customer's contact details, PII, and metadata.
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public record class CustomerUpdateParams : ParamsBase
{
    readonly JsonDictionary _rawBodyData = new();
    public IReadOnlyDictionary<string, JsonElement> RawBodyData
    {
        get { return this._rawBodyData.Freeze(); }
    }

    public string? ID { get; init; }

    public required DeviceUnmaskedV1 Device
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<DeviceUnmaskedV1>("device");
        }
        init { this._rawBodyData.Set("device", value); }
    }

    /// <summary>
    /// The customer's email address.
    /// </summary>
    public required string Email
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("email");
        }
        init { this._rawBodyData.Set("email", value); }
    }

    /// <summary>
    /// The customer's full name or business name.
    /// </summary>
    public required string Name
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("name");
        }
        init { this._rawBodyData.Set("name", value); }
    }

    /// <summary>
    /// The customer's phone number in E.164 format.
    /// </summary>
    public required string Phone
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("phone");
        }
        init { this._rawBodyData.Set("phone", value); }
    }

    public required ApiEnum<string, Status> Status
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<ApiEnum<string, Status>>("status");
        }
        init { this._rawBodyData.Set("status", value); }
    }

    /// <summary>
    /// An object containing the customer's address. This is optional, but if provided,
    /// all required fields must be present.
    /// </summary>
    public CustomerAddressV1? Address
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<CustomerAddressV1>("address");
        }
        init { this._rawBodyData.Set("address", value); }
    }

    /// <summary>
    /// Individual PII data required to trigger Patriot Act compliant KYC verification.
    /// </summary>
    public CustomerUpdateParamsComplianceProfile? ComplianceProfile
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<CustomerUpdateParamsComplianceProfile>(
                "compliance_profile"
            );
        }
        init { this._rawBodyData.Set("compliance_profile", value); }
    }

    /// <summary>
    /// Unique identifier for the customer in your database, used for cross-referencing
    /// between Straddle and your systems.
    /// </summary>
    public string? ExternalID
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<string>("external_id");
        }
        init { this._rawBodyData.Set("external_id", value); }
    }

    /// <summary>
    /// Up to 20 additional user-defined key-value pairs. Useful for storing additional
    /// information about the customer in a structured format.
    /// </summary>
    public IReadOnlyDictionary<string, string>? Metadata
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<FrozenDictionary<string, string>>("metadata");
        }
        init
        {
            this._rawBodyData.Set<FrozenDictionary<string, string>?>(
                "metadata",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    public string? CorrelationID
    {
        get
        {
            this._rawHeaderData.Freeze();
            return this._rawHeaderData.GetNullableClass<string>("Correlation-Id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawHeaderData.Set("Correlation-Id", value);
        }
    }

    public string? IdempotencyKey
    {
        get
        {
            this._rawHeaderData.Freeze();
            return this._rawHeaderData.GetNullableClass<string>("Idempotency-Key");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawHeaderData.Set("Idempotency-Key", value);
        }
    }

    public string? RequestID
    {
        get
        {
            this._rawHeaderData.Freeze();
            return this._rawHeaderData.GetNullableClass<string>("Request-Id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawHeaderData.Set("Request-Id", value);
        }
    }

    public string? StraddleAccountID
    {
        get
        {
            this._rawHeaderData.Freeze();
            return this._rawHeaderData.GetNullableClass<string>("Straddle-Account-Id");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawHeaderData.Set("Straddle-Account-Id", value);
        }
    }

    public CustomerUpdateParams() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CustomerUpdateParams(CustomerUpdateParams customerUpdateParams)
        : base(customerUpdateParams)
    {
        this.ID = customerUpdateParams.ID;

        this._rawBodyData = new(customerUpdateParams._rawBodyData);
    }
#pragma warning restore CS8618

    public CustomerUpdateParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        IReadOnlyDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
        this._rawBodyData = new(rawBodyData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerUpdateParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData,
        FrozenDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
        this._rawBodyData = new(rawBodyData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson.FromRawUnchecked"/>
    public static CustomerUpdateParams FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        IReadOnlyDictionary<string, JsonElement> rawBodyData
    )
    {
        return new(
            FrozenDictionary.ToFrozenDictionary(rawHeaderData),
            FrozenDictionary.ToFrozenDictionary(rawQueryData),
            FrozenDictionary.ToFrozenDictionary(rawBodyData)
        );
    }

    public override string ToString() =>
        JsonSerializer.Serialize(
            new Dictionary<string, object?>()
            {
                ["ID"] = this.ID,
                ["HeaderData"] = this._rawHeaderData.Freeze(),
                ["QueryData"] = this._rawQueryData.Freeze(),
                ["BodyData"] = this._rawBodyData.Freeze(),
            },
            ModelBase.ToStringSerializerOptions
        );

    public virtual bool Equals(CustomerUpdateParams? other)
    {
        if (other == null)
        {
            return false;
        }
        return (this.ID?.Equals(other.ID) ?? other.ID == null)
            && this._rawHeaderData.Equals(other._rawHeaderData)
            && this._rawQueryData.Equals(other._rawQueryData)
            && this._rawBodyData.Equals(other._rawBodyData);
    }

    public override System::Uri Url(ClientOptions options)
    {
        return new System::UriBuilder(
            options.BaseUrl.ToString().TrimEnd('/') + string.Format("/v1/customers/{0}", this.ID)
        )
        {
            Query = this.QueryString(options),
        }.Uri;
    }

    internal override HttpContent? BodyContent()
    {
        return new StringContent(
            JsonSerializer.Serialize(this.RawBodyData, ModelBase.SerializerOptions),
            Encoding.UTF8,
            "application/json"
        );
    }

    internal override void AddHeadersToRequest(HttpRequestMessage request, ClientOptions options)
    {
        ParamsBase.AddDefaultHeaders(request, options);
        foreach (var item in this.RawHeaderData)
        {
            ParamsBase.AddHeaderElementToRequest(request, item.Key, item.Value);
        }
    }

    public override int GetHashCode()
    {
        return 0;
    }
}

[JsonConverter(typeof(StatusConverter))]
public enum Status
{
    Pending,
    Review,
    Verified,
    Inactive,
    Rejected,
}

sealed class StatusConverter : JsonConverter<Status>
{
    public override Status Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => Status.Pending,
            "review" => Status.Review,
            "verified" => Status.Verified,
            "inactive" => Status.Inactive,
            "rejected" => Status.Rejected,
            _ => (Status)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Status value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Status.Pending => "pending",
                Status.Review => "review",
                Status.Verified => "verified",
                Status.Inactive => "inactive",
                Status.Rejected => "rejected",
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
[JsonConverter(typeof(CustomerUpdateParamsComplianceProfileConverter))]
public record class CustomerUpdateParamsComplianceProfile : ModelBase
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

    public CustomerUpdateParamsComplianceProfile(
        CustomerUpdateParamsComplianceProfileIndividualComplianceProfile value,
        JsonElement? element = null
    )
    {
        this.Value = value;
        this._element = element;
    }

    public CustomerUpdateParamsComplianceProfile(
        CustomerUpdateParamsComplianceProfileBusinessComplianceProfile value,
        JsonElement? element = null
    )
    {
        this.Value = value;
        this._element = element;
    }

    public CustomerUpdateParamsComplianceProfile(JsonElement element)
    {
        this._element = element;
    }

    /// <summary>
    /// Returns true and sets the <c>out</c> parameter if the instance was constructed with a variant of
    /// type <see cref="CustomerUpdateParamsComplianceProfileIndividualComplianceProfile"/>.
    ///
    /// <para>Consider using <see cref="Switch"> or <see cref="Match"> if you need to handle every variant.</para>
    ///
    /// <example>
    /// <code>
    /// if (instance.TryPickIndividual(out var value)) {
    ///     // `value` is of type `CustomerUpdateParamsComplianceProfileIndividualComplianceProfile`
    ///     Console.WriteLine(value);
    /// }
    /// </code>
    /// </example>
    /// </summary>
    public bool TryPickIndividual(
        [NotNullWhen(true)]
            out CustomerUpdateParamsComplianceProfileIndividualComplianceProfile? value
    )
    {
        value = this.Value as CustomerUpdateParamsComplianceProfileIndividualComplianceProfile;
        return value != null;
    }

    /// <summary>
    /// Returns true and sets the <c>out</c> parameter if the instance was constructed with a variant of
    /// type <see cref="CustomerUpdateParamsComplianceProfileBusinessComplianceProfile"/>.
    ///
    /// <para>Consider using <see cref="Switch"> or <see cref="Match"> if you need to handle every variant.</para>
    ///
    /// <example>
    /// <code>
    /// if (instance.TryPickBusiness(out var value)) {
    ///     // `value` is of type `CustomerUpdateParamsComplianceProfileBusinessComplianceProfile`
    ///     Console.WriteLine(value);
    /// }
    /// </code>
    /// </example>
    /// </summary>
    public bool TryPickBusiness(
        [NotNullWhen(true)]
            out CustomerUpdateParamsComplianceProfileBusinessComplianceProfile? value
    )
    {
        value = this.Value as CustomerUpdateParamsComplianceProfileBusinessComplianceProfile;
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
    ///     (CustomerUpdateParamsComplianceProfileIndividualComplianceProfile value) => {...},
    ///     (CustomerUpdateParamsComplianceProfileBusinessComplianceProfile value) => {...}
    /// );
    /// </code>
    /// </example>
    /// </summary>
    public void Switch(
        System::Action<CustomerUpdateParamsComplianceProfileIndividualComplianceProfile> individual,
        System::Action<CustomerUpdateParamsComplianceProfileBusinessComplianceProfile> business
    )
    {
        switch (this.Value)
        {
            case CustomerUpdateParamsComplianceProfileIndividualComplianceProfile value:
                individual(value);
                break;
            case CustomerUpdateParamsComplianceProfileBusinessComplianceProfile value:
                business(value);
                break;
            default:
                throw new StraddleInvalidDataException(
                    "Data did not match any variant of CustomerUpdateParamsComplianceProfile"
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
    ///     (CustomerUpdateParamsComplianceProfileIndividualComplianceProfile value) => {...},
    ///     (CustomerUpdateParamsComplianceProfileBusinessComplianceProfile value) => {...}
    /// );
    /// </code>
    /// </example>
    /// </summary>
    public T Match<T>(
        System::Func<
            CustomerUpdateParamsComplianceProfileIndividualComplianceProfile,
            T
        > individual,
        System::Func<CustomerUpdateParamsComplianceProfileBusinessComplianceProfile, T> business
    )
    {
        return this.Value switch
        {
            CustomerUpdateParamsComplianceProfileIndividualComplianceProfile value => individual(
                value
            ),
            CustomerUpdateParamsComplianceProfileBusinessComplianceProfile value => business(value),
            _ => throw new StraddleInvalidDataException(
                "Data did not match any variant of CustomerUpdateParamsComplianceProfile"
            ),
        };
    }

    public static implicit operator CustomerUpdateParamsComplianceProfile(
        CustomerUpdateParamsComplianceProfileIndividualComplianceProfile value
    ) => new(value);

    public static implicit operator CustomerUpdateParamsComplianceProfile(
        CustomerUpdateParamsComplianceProfileBusinessComplianceProfile value
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
                "Data did not match any variant of CustomerUpdateParamsComplianceProfile"
            );
        }
        this.Switch((individual) => individual.Validate(), (business) => business.Validate());
    }

    public virtual bool Equals(CustomerUpdateParamsComplianceProfile? other)
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

sealed class CustomerUpdateParamsComplianceProfileConverter
    : JsonConverter<CustomerUpdateParamsComplianceProfile?>
{
    public override CustomerUpdateParamsComplianceProfile? Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        var element = JsonSerializer.Deserialize<JsonElement>(ref reader, options);
        try
        {
            var deserialized =
                JsonSerializer.Deserialize<CustomerUpdateParamsComplianceProfileIndividualComplianceProfile>(
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
                JsonSerializer.Deserialize<CustomerUpdateParamsComplianceProfileBusinessComplianceProfile>(
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
        CustomerUpdateParamsComplianceProfile? value,
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
        CustomerUpdateParamsComplianceProfileIndividualComplianceProfile,
        CustomerUpdateParamsComplianceProfileIndividualComplianceProfileFromRaw
    >)
)]
public sealed record class CustomerUpdateParamsComplianceProfileIndividualComplianceProfile
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

    public CustomerUpdateParamsComplianceProfileIndividualComplianceProfile() { }

    public CustomerUpdateParamsComplianceProfileIndividualComplianceProfile(
        CustomerUpdateParamsComplianceProfileIndividualComplianceProfile customerUpdateParamsComplianceProfileIndividualComplianceProfile
    )
        : base(customerUpdateParamsComplianceProfileIndividualComplianceProfile) { }

    public CustomerUpdateParamsComplianceProfileIndividualComplianceProfile(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerUpdateParamsComplianceProfileIndividualComplianceProfile(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerUpdateParamsComplianceProfileIndividualComplianceProfileFromRaw.FromRawUnchecked"/>
    public static CustomerUpdateParamsComplianceProfileIndividualComplianceProfile FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CustomerUpdateParamsComplianceProfileIndividualComplianceProfileFromRaw
    : IFromRawJson<CustomerUpdateParamsComplianceProfileIndividualComplianceProfile>
{
    /// <inheritdoc/>
    public CustomerUpdateParamsComplianceProfileIndividualComplianceProfile FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CustomerUpdateParamsComplianceProfileIndividualComplianceProfile.FromRawUnchecked(rawData);
}

/// <summary>
/// Business registration data required to trigger Patriot Act compliant KYB verification.
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        CustomerUpdateParamsComplianceProfileBusinessComplianceProfile,
        CustomerUpdateParamsComplianceProfileBusinessComplianceProfileFromRaw
    >)
)]
public sealed record class CustomerUpdateParamsComplianceProfileBusinessComplianceProfile
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
    public IReadOnlyList<CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative>? Representatives
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<
                ImmutableArray<CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative>
            >("representatives");
        }
        init
        {
            this._rawData.Set<ImmutableArray<CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative>?>(
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

    public CustomerUpdateParamsComplianceProfileBusinessComplianceProfile() { }

    public CustomerUpdateParamsComplianceProfileBusinessComplianceProfile(
        CustomerUpdateParamsComplianceProfileBusinessComplianceProfile customerUpdateParamsComplianceProfileBusinessComplianceProfile
    )
        : base(customerUpdateParamsComplianceProfileBusinessComplianceProfile) { }

    public CustomerUpdateParamsComplianceProfileBusinessComplianceProfile(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerUpdateParamsComplianceProfileBusinessComplianceProfile(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerUpdateParamsComplianceProfileBusinessComplianceProfileFromRaw.FromRawUnchecked"/>
    public static CustomerUpdateParamsComplianceProfileBusinessComplianceProfile FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CustomerUpdateParamsComplianceProfileBusinessComplianceProfileFromRaw
    : IFromRawJson<CustomerUpdateParamsComplianceProfileBusinessComplianceProfile>
{
    /// <inheritdoc/>
    public CustomerUpdateParamsComplianceProfileBusinessComplianceProfile FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CustomerUpdateParamsComplianceProfileBusinessComplianceProfile.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative,
        CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentativeFromRaw
    >)
)]
public sealed record class CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative
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

    public CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative() { }

    public CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative(
        CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative customerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative
    )
        : base(customerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative) { }

    public CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentativeFromRaw.FromRawUnchecked"/>
    public static CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative(string name)
        : this()
    {
        this.Name = name;
    }
}

class CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentativeFromRaw
    : IFromRawJson<CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative>
{
    /// <inheritdoc/>
    public CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) =>
        CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative.FromRawUnchecked(
            rawData
        );
}
