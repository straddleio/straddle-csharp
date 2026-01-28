using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;
using System = System;

namespace Straddle.Models.Customers.Review;

[JsonConverter(
    typeof(JsonModelConverter<
        IdentityVerificationBreakdownV1,
        IdentityVerificationBreakdownV1FromRaw
    >)
)]
public sealed record class IdentityVerificationBreakdownV1 : JsonModel
{
    /// <summary>
    /// List of specific result codes from the fraud and risk screening.
    /// </summary>
    public IReadOnlyList<string>? Codes
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<string>>("codes");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>?>(
                "codes",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public ApiEnum<string, IdentityVerificationBreakdownV1Correlation>? Correlation
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, IdentityVerificationBreakdownV1Correlation>
            >("correlation");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("correlation", value);
        }
    }

    /// <summary>
    /// Represents the strength of the correlation between provided and known information.
    /// A higher score indicates a stronger correlation.
    /// </summary>
    public double? CorrelationScore
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("correlation_score");
        }
        init { this._rawData.Set("correlation_score", value); }
    }

    public ApiEnum<string, IdentityVerificationBreakdownV1Decision>? Decision
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, IdentityVerificationBreakdownV1Decision>
            >("decision");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("decision", value);
        }
    }

    /// <summary>
    /// Predicts the inherent risk associated with the customer for a given module.
    /// A higher score indicates a greater likelihood of fraud.
    /// </summary>
    public double? RiskScore
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("risk_score");
        }
        init { this._rawData.Set("risk_score", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Codes;
        this.Correlation?.Validate();
        _ = this.CorrelationScore;
        this.Decision?.Validate();
        _ = this.RiskScore;
    }

    public IdentityVerificationBreakdownV1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public IdentityVerificationBreakdownV1(
        IdentityVerificationBreakdownV1 identityVerificationBreakdownV1
    )
        : base(identityVerificationBreakdownV1) { }
#pragma warning restore CS8618

    public IdentityVerificationBreakdownV1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    IdentityVerificationBreakdownV1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IdentityVerificationBreakdownV1FromRaw.FromRawUnchecked"/>
    public static IdentityVerificationBreakdownV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class IdentityVerificationBreakdownV1FromRaw : IFromRawJson<IdentityVerificationBreakdownV1>
{
    /// <inheritdoc/>
    public IdentityVerificationBreakdownV1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => IdentityVerificationBreakdownV1.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(IdentityVerificationBreakdownV1CorrelationConverter))]
public enum IdentityVerificationBreakdownV1Correlation
{
    LowConfidence,
    PotentialMatch,
    LikelyMatch,
    HighConfidence,
}

sealed class IdentityVerificationBreakdownV1CorrelationConverter
    : JsonConverter<IdentityVerificationBreakdownV1Correlation>
{
    public override IdentityVerificationBreakdownV1Correlation Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "low_confidence" => IdentityVerificationBreakdownV1Correlation.LowConfidence,
            "potential_match" => IdentityVerificationBreakdownV1Correlation.PotentialMatch,
            "likely_match" => IdentityVerificationBreakdownV1Correlation.LikelyMatch,
            "high_confidence" => IdentityVerificationBreakdownV1Correlation.HighConfidence,
            _ => (IdentityVerificationBreakdownV1Correlation)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        IdentityVerificationBreakdownV1Correlation value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                IdentityVerificationBreakdownV1Correlation.LowConfidence => "low_confidence",
                IdentityVerificationBreakdownV1Correlation.PotentialMatch => "potential_match",
                IdentityVerificationBreakdownV1Correlation.LikelyMatch => "likely_match",
                IdentityVerificationBreakdownV1Correlation.HighConfidence => "high_confidence",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(IdentityVerificationBreakdownV1DecisionConverter))]
public enum IdentityVerificationBreakdownV1Decision
{
    Accept,
    Reject,
    Review,
}

sealed class IdentityVerificationBreakdownV1DecisionConverter
    : JsonConverter<IdentityVerificationBreakdownV1Decision>
{
    public override IdentityVerificationBreakdownV1Decision Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "accept" => IdentityVerificationBreakdownV1Decision.Accept,
            "reject" => IdentityVerificationBreakdownV1Decision.Reject,
            "review" => IdentityVerificationBreakdownV1Decision.Review,
            _ => (IdentityVerificationBreakdownV1Decision)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        IdentityVerificationBreakdownV1Decision value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                IdentityVerificationBreakdownV1Decision.Accept => "accept",
                IdentityVerificationBreakdownV1Decision.Reject => "reject",
                IdentityVerificationBreakdownV1Decision.Review => "review",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
