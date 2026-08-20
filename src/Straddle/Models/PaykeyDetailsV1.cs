using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;

namespace Straddle.Models;

[JsonConverter(typeof(JsonModelConverter<PaykeyDetailsV1, PaykeyDetailsV1FromRaw>))]
public sealed record class PaykeyDetailsV1 : JsonModel
{
    /// <summary>
    /// Unique identifier for the paykey.
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
    /// Unique identifier for the customer associated with the paykey.
    /// </summary>
    public required string CustomerID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("customer_id");
        }
        init { this._rawData.Set("customer_id", value); }
    }

    /// <summary>
    /// Human-readable label that combines the bank name and masked account number
    /// to help easility represent this paykey in a UI
    /// </summary>
    public required string Label
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("label");
        }
        init { this._rawData.Set("label", value); }
    }

    /// <summary>
    /// The most recent balance of the bank account associated with the paykey in dollars.
    /// </summary>
    public int? Balance
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<int>("balance");
        }
        init { this._rawData.Set("balance", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.CustomerID;
        _ = this.Label;
        _ = this.Balance;
    }

    public PaykeyDetailsV1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public PaykeyDetailsV1(PaykeyDetailsV1 paykeyDetailsV1)
        : base(paykeyDetailsV1) { }
#pragma warning restore CS8618

    public PaykeyDetailsV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaykeyDetailsV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaykeyDetailsV1FromRaw.FromRawUnchecked"/>
    public static PaykeyDetailsV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaykeyDetailsV1FromRaw : IFromRawJson<PaykeyDetailsV1>
{
    /// <inheritdoc/>
    public PaykeyDetailsV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        PaykeyDetailsV1.FromRawUnchecked(rawData);
}
