using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;

namespace Straddle.Models.Embed.Accounts;

[JsonConverter(typeof(JsonModelConverter<SupportChannelsV1, SupportChannelsV1FromRaw>))]
public sealed record class SupportChannelsV1 : JsonModel
{
    /// <summary>
    /// The email address for customer support inquiries.
    /// </summary>
    public string? Email
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("email");
        }
        init { this._rawData.Set("email", value); }
    }

    /// <summary>
    /// The phone number for customer support.
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

    /// <summary>
    /// The URL of the business's customer support page or contact form.
    /// </summary>
    public string? Url
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("url");
        }
        init { this._rawData.Set("url", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Email;
        _ = this.Phone;
        _ = this.Url;
    }

    public SupportChannelsV1() { }

    public SupportChannelsV1(SupportChannelsV1 supportChannelsV1)
        : base(supportChannelsV1) { }

    public SupportChannelsV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    SupportChannelsV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="SupportChannelsV1FromRaw.FromRawUnchecked"/>
    public static SupportChannelsV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class SupportChannelsV1FromRaw : IFromRawJson<SupportChannelsV1>
{
    /// <inheritdoc/>
    public SupportChannelsV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        SupportChannelsV1.FromRawUnchecked(rawData);
}
