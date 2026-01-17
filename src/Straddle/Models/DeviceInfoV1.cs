using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;

namespace Straddle.Models;

[JsonConverter(typeof(JsonModelConverter<DeviceInfoV1, DeviceInfoV1FromRaw>))]
public sealed record class DeviceInfoV1 : JsonModel
{
    /// <summary>
    /// The IP address of the device used when the customer authorized the charge
    /// or payout. Use `0.0.0.0` to represent an offline consent interaction.
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

    public DeviceInfoV1() { }

    public DeviceInfoV1(DeviceInfoV1 deviceInfoV1)
        : base(deviceInfoV1) { }

    public DeviceInfoV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    DeviceInfoV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DeviceInfoV1FromRaw.FromRawUnchecked"/>
    public static DeviceInfoV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public DeviceInfoV1(string ipAddress)
        : this()
    {
        this.IPAddress = ipAddress;
    }
}

class DeviceInfoV1FromRaw : IFromRawJson<DeviceInfoV1>
{
    /// <inheritdoc/>
    public DeviceInfoV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        DeviceInfoV1.FromRawUnchecked(rawData);
}
