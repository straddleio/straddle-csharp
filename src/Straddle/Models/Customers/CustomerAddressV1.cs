using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;

namespace Straddle.Models.Customers;

/// <summary>
/// An object containing the customer's address. This is optional, but if provided,
/// all required fields must be present.
/// </summary>
[JsonConverter(typeof(JsonModelConverter<CustomerAddressV1, CustomerAddressV1FromRaw>))]
public sealed record class CustomerAddressV1 : JsonModel
{
    /// <summary>
    /// Primary address line (e.g., street, PO Box).
    /// </summary>
    public required string Address1
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("address1");
        }
        init { this._rawData.Set("address1", value); }
    }

    /// <summary>
    /// City, district, suburb, town, or village.
    /// </summary>
    public required string City
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("city");
        }
        init { this._rawData.Set("city", value); }
    }

    /// <summary>
    /// Two-letter state code.
    /// </summary>
    public required string State
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("state");
        }
        init { this._rawData.Set("state", value); }
    }

    /// <summary>
    /// Zip or postal code.
    /// </summary>
    public required string Zip
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("zip");
        }
        init { this._rawData.Set("zip", value); }
    }

    /// <summary>
    /// Secondary address line (e.g., apartment, suite, unit, or building).
    /// </summary>
    public string? Address2
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("address2");
        }
        init { this._rawData.Set("address2", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Address1;
        _ = this.City;
        _ = this.State;
        _ = this.Zip;
        _ = this.Address2;
    }

    public CustomerAddressV1() { }

    public CustomerAddressV1(CustomerAddressV1 customerAddressV1)
        : base(customerAddressV1) { }

    public CustomerAddressV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CustomerAddressV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CustomerAddressV1FromRaw.FromRawUnchecked"/>
    public static CustomerAddressV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CustomerAddressV1FromRaw : IFromRawJson<CustomerAddressV1>
{
    /// <inheritdoc/>
    public CustomerAddressV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        CustomerAddressV1.FromRawUnchecked(rawData);
}
