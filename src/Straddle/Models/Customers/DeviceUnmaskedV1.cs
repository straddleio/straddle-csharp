using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;

namespace Straddle.Models.Customers;

[JsonConverter(typeof(JsonModelConverter<DeviceUnmaskedV1, DeviceUnmaskedV1FromRaw>))]
public sealed record class DeviceUnmaskedV1 : JsonModel
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

    public DeviceUnmaskedV1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public DeviceUnmaskedV1(DeviceUnmaskedV1 deviceUnmaskedV1)
        : base(deviceUnmaskedV1) { }
#pragma warning restore CS8618

    public DeviceUnmaskedV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    DeviceUnmaskedV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DeviceUnmaskedV1FromRaw.FromRawUnchecked"/>
    public static DeviceUnmaskedV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public DeviceUnmaskedV1(string ipAddress)
        : this()
    {
        this.IPAddress = ipAddress;
    }
}

class DeviceUnmaskedV1FromRaw : IFromRawJson<DeviceUnmaskedV1>
{
    /// <inheritdoc/>
    public DeviceUnmaskedV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        DeviceUnmaskedV1.FromRawUnchecked(rawData);
}
