using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;

namespace Straddle.Models.Embed.Accounts;

[JsonConverter(typeof(JsonModelConverter<IndustryV1, IndustryV1FromRaw>))]
public sealed record class IndustryV1 : JsonModel
{
    /// <summary>
    /// The general category of the industry. Required if not providing MCC.
    /// </summary>
    public string? Category
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("category");
        }
        init { this._rawData.Set("category", value); }
    }

    /// <summary>
    /// The Merchant Category Code (MCC) that best describes the business. Optional.
    /// </summary>
    public string? Mcc
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("mcc");
        }
        init { this._rawData.Set("mcc", value); }
    }

    /// <summary>
    /// The specific sector within the industry category. Required if not providing MCC.
    /// </summary>
    public string? Sector
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("sector");
        }
        init { this._rawData.Set("sector", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Category;
        _ = this.Mcc;
        _ = this.Sector;
    }

    public IndustryV1() { }

    public IndustryV1(IndustryV1 industryV1)
        : base(industryV1) { }

    public IndustryV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    IndustryV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IndustryV1FromRaw.FromRawUnchecked"/>
    public static IndustryV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class IndustryV1FromRaw : IFromRawJson<IndustryV1>
{
    /// <inheritdoc/>
    public IndustryV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        IndustryV1.FromRawUnchecked(rawData);
}
