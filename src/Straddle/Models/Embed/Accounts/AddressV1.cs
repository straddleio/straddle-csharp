using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;

namespace Straddle.Models.Embed.Accounts;

/// <summary>
/// The address object is optional. If provided, it must be a valid address.
/// </summary>
[JsonConverter(typeof(JsonModelConverter<AddressV1, AddressV1FromRaw>))]
public sealed record class AddressV1 : JsonModel
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
    public required string? City
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("city");
        }
        init { this._rawData.Set("city", value); }
    }

    /// <summary>
    /// Two-letter state code.
    /// </summary>
    public required string? State
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("state");
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

    /// <summary>
    /// The country of the address, in ISO 3166-1 alpha-2 format.
    /// </summary>
    public string? Country
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("country");
        }
        init { this._rawData.Set("country", value); }
    }

    /// <summary>
    /// Primary address line (e.g., street, PO Box).
    /// </summary>
    public string? Line1
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("line1");
        }
        init { this._rawData.Set("line1", value); }
    }

    /// <summary>
    /// Secondary address line (e.g., apartment, suite, unit, or building).
    /// </summary>
    public string? Line2
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("line2");
        }
        init { this._rawData.Set("line2", value); }
    }

    /// <summary>
    /// Postal or ZIP code.
    /// </summary>
    public string? PostalCode
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("postal_code");
        }
        init { this._rawData.Set("postal_code", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Address1;
        _ = this.City;
        _ = this.State;
        _ = this.Zip;
        _ = this.Address2;
        _ = this.Country;
        _ = this.Line1;
        _ = this.Line2;
        _ = this.PostalCode;
    }

    public AddressV1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AddressV1(AddressV1 addressV1)
        : base(addressV1) { }
#pragma warning restore CS8618

    public AddressV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AddressV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AddressV1FromRaw.FromRawUnchecked"/>
    public static AddressV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AddressV1FromRaw : IFromRawJson<AddressV1>
{
    /// <inheritdoc/>
    public AddressV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        AddressV1.FromRawUnchecked(rawData);
}
