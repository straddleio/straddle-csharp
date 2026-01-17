using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;

namespace Straddle.Models.Embed.Accounts;

[JsonConverter(typeof(JsonModelConverter<BusinessProfileV1, BusinessProfileV1FromRaw>))]
public sealed record class BusinessProfileV1 : JsonModel
{
    /// <summary>
    /// The operating or trade name of the business.
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
    /// URL of the business's primary marketing website.
    /// </summary>
    public required string Website
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("website");
        }
        init { this._rawData.Set("website", value); }
    }

    /// <summary>
    /// The address object is optional. If provided, it must be a valid address.
    /// </summary>
    public AddressV1? Address
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AddressV1>("address");
        }
        init { this._rawData.Set("address", value); }
    }

    /// <summary>
    /// A brief description of the business and its products or services.
    /// </summary>
    public string? Description
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("description");
        }
        init { this._rawData.Set("description", value); }
    }

    public IndustryV1? Industry
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<IndustryV1>("industry");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("industry", value);
        }
    }

    /// <summary>
    /// The official registered name of the business.
    /// </summary>
    public string? LegalName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("legal_name");
        }
        init { this._rawData.Set("legal_name", value); }
    }

    /// <summary>
    /// The primary contact phone number for the business.
    /// </summary>
    public string? Phone
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("phone");
        }
        init { this._rawData.Set("phone", value); }
    }

    public SupportChannelsV1? SupportChannels
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<SupportChannelsV1>("support_channels");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("support_channels", value);
        }
    }

    /// <summary>
    /// The business's tax identification number (e.g., EIN in the US).
    /// </summary>
    public string? TaxID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("tax_id");
        }
        init { this._rawData.Set("tax_id", value); }
    }

    /// <summary>
    /// A description of how the business intends to use Straddle's services.
    /// </summary>
    public string? UseCase
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("use_case");
        }
        init { this._rawData.Set("use_case", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Name;
        _ = this.Website;
        this.Address?.Validate();
        _ = this.Description;
        this.Industry?.Validate();
        _ = this.LegalName;
        _ = this.Phone;
        this.SupportChannels?.Validate();
        _ = this.TaxID;
        _ = this.UseCase;
    }

    public BusinessProfileV1() { }

    public BusinessProfileV1(BusinessProfileV1 businessProfileV1)
        : base(businessProfileV1) { }

    public BusinessProfileV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    BusinessProfileV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="BusinessProfileV1FromRaw.FromRawUnchecked"/>
    public static BusinessProfileV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class BusinessProfileV1FromRaw : IFromRawJson<BusinessProfileV1>
{
    /// <inheritdoc/>
    public BusinessProfileV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        BusinessProfileV1.FromRawUnchecked(rawData);
}
