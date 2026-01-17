using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;
using System = System;

namespace Straddle.Models.Embed.Accounts;

[JsonConverter(typeof(JsonModelConverter<CapabilityV1, CapabilityV1FromRaw>))]
public sealed record class CapabilityV1 : JsonModel
{
    public required ApiEnum<string, CapabilityStatus> CapabilityStatus
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, CapabilityStatus>>(
                "capability_status"
            );
        }
        init { this._rawData.Set("capability_status", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.CapabilityStatus.Validate();
    }

    public CapabilityV1() { }

    public CapabilityV1(CapabilityV1 capabilityV1)
        : base(capabilityV1) { }

    public CapabilityV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CapabilityV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CapabilityV1FromRaw.FromRawUnchecked"/>
    public static CapabilityV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public CapabilityV1(ApiEnum<string, CapabilityStatus> capabilityStatus)
        : this()
    {
        this.CapabilityStatus = capabilityStatus;
    }
}

class CapabilityV1FromRaw : IFromRawJson<CapabilityV1>
{
    /// <inheritdoc/>
    public CapabilityV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        CapabilityV1.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(CapabilityStatusConverter))]
public enum CapabilityStatus
{
    Active,
    Inactive,
}

sealed class CapabilityStatusConverter : JsonConverter<CapabilityStatus>
{
    public override CapabilityStatus Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "active" => CapabilityStatus.Active,
            "inactive" => CapabilityStatus.Inactive,
            _ => (CapabilityStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CapabilityStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CapabilityStatus.Active => "active",
                CapabilityStatus.Inactive => "inactive",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
