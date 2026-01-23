using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;
using System = System;

namespace Straddle.Models.Embed.Accounts;

[JsonConverter(typeof(JsonModelConverter<TermsOfServiceV1, TermsOfServiceV1FromRaw>))]
public sealed record class TermsOfServiceV1 : JsonModel
{
    /// <summary>
    /// The datetime of when the terms of service were accepted, in ISO 8601 format.
    /// </summary>
    public required System::DateTimeOffset AcceptedDate
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<System::DateTimeOffset>("accepted_date");
        }
        init { this._rawData.Set("accepted_date", value); }
    }

    /// <summary>
    /// The type or version of the agreement accepted. Use `embedded` unless your
    /// platform was specifically enabled for `direct` agreements.
    /// </summary>
    public required ApiEnum<string, AgreementType> AgreementType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, AgreementType>>("agreement_type");
        }
        init { this._rawData.Set("agreement_type", value); }
    }

    /// <summary>
    /// The URL where the full text of the accepted agreement can be found.
    /// </summary>
    public required string? AgreementUrl
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("agreement_url");
        }
        init { this._rawData.Set("agreement_url", value); }
    }

    /// <summary>
    /// The IP address from which the terms of service were accepted.
    /// </summary>
    public string? AcceptedIP
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("accepted_ip");
        }
        init { this._rawData.Set("accepted_ip", value); }
    }

    /// <summary>
    /// The user agent string of the browser or application used to accept the terms.
    /// </summary>
    public string? AcceptedUserAgent
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("accepted_user_agent");
        }
        init { this._rawData.Set("accepted_user_agent", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AcceptedDate;
        this.AgreementType.Validate();
        _ = this.AgreementUrl;
        _ = this.AcceptedIP;
        _ = this.AcceptedUserAgent;
    }

    public TermsOfServiceV1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TermsOfServiceV1(TermsOfServiceV1 termsOfServiceV1)
        : base(termsOfServiceV1) { }
#pragma warning restore CS8618

    public TermsOfServiceV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TermsOfServiceV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TermsOfServiceV1FromRaw.FromRawUnchecked"/>
    public static TermsOfServiceV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TermsOfServiceV1FromRaw : IFromRawJson<TermsOfServiceV1>
{
    /// <inheritdoc/>
    public TermsOfServiceV1 FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        TermsOfServiceV1.FromRawUnchecked(rawData);
}

/// <summary>
/// The type or version of the agreement accepted. Use `embedded` unless your platform
/// was specifically enabled for `direct` agreements.
/// </summary>
[JsonConverter(typeof(AgreementTypeConverter))]
public enum AgreementType
{
    Embedded,
    Direct,
}

sealed class AgreementTypeConverter : JsonConverter<AgreementType>
{
    public override AgreementType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "embedded" => AgreementType.Embedded,
            "direct" => AgreementType.Direct,
            _ => (AgreementType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AgreementType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AgreementType.Embedded => "embedded",
                AgreementType.Direct => "direct",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
