using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models;

/// <summary>
/// Information about the customer associated with the charge or payout.
/// </summary>
[JsonConverter(typeof(JsonModelConverter<CustomerDetailsV1, CustomerDetailsV1FromRaw>))]
public sealed record class CustomerDetailsV1 : JsonModel
{
    /// <summary>
    /// Unique identifier for the customer
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
    /// The type of customer
    /// </summary>
    public required ApiEnum<string, CustomerType> CustomerType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, CustomerType>>("customer_type");
        }
        init { this._rawData.Set("customer_type", value); }
    }

    /// <summary>
    /// The customer's email address
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
    /// The name of the customer
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
    /// The customer's phone number in E.164 format
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        this.CustomerType.Validate();
        _ = this.Email;
        _ = this.Name;
        _ = this.Phone;
    }

    public CustomerDetailsV1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CustomerDetailsV1(CustomerDetailsV1 customerDetailsV1)
        : base(customerDetailsV1) { }
#pragma warning restore CS8618

    public CustomerDetailsV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerDetailsV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerDetailsV1FromRaw.FromRawUnchecked"/>
    public static CustomerDetailsV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CustomerDetailsV1FromRaw : IFromRawJson<CustomerDetailsV1>
{
    /// <inheritdoc/>
    public CustomerDetailsV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        CustomerDetailsV1.FromRawUnchecked(rawData);
}

/// <summary>
/// The type of customer
/// </summary>
[JsonConverter(typeof(CustomerTypeConverter))]
public enum CustomerType
{
    Individual,
    Business,
}

sealed class CustomerTypeConverter : JsonConverter<CustomerType>
{
    public override CustomerType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "individual" => CustomerType.Individual,
            "business" => CustomerType.Business,
            _ => (CustomerType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CustomerType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CustomerType.Individual => "individual",
                CustomerType.Business => "business",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
