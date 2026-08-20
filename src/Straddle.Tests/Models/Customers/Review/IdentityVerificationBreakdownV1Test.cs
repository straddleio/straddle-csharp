using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Customers.Review;

namespace Straddle.Tests.Models.Customers.Review;

public class IdentityVerificationBreakdownV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new IdentityVerificationBreakdownV1
        {
            Codes = ["string"],
            Correlation = IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };

        List<string> expectedCodes = ["string"];
        ApiEnum<string, IdentityVerificationBreakdownV1Correlation> expectedCorrelation =
            IdentityVerificationBreakdownV1Correlation.LowConfidence;
        double expectedCorrelationScore = 0;
        ApiEnum<string, IdentityVerificationBreakdownV1Decision> expectedDecision =
            IdentityVerificationBreakdownV1Decision.Accept;
        double expectedRiskScore = 0;

        Assert.NotNull(model.Codes);
        Assert.Equal(expectedCodes.Count, model.Codes.Count);
        for (int i = 0; i < expectedCodes.Count; i++)
        {
            Assert.Equal(expectedCodes[i], model.Codes[i]);
        }
        Assert.Equal(expectedCorrelation, model.Correlation);
        Assert.Equal(expectedCorrelationScore, model.CorrelationScore);
        Assert.Equal(expectedDecision, model.Decision);
        Assert.Equal(expectedRiskScore, model.RiskScore);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new IdentityVerificationBreakdownV1
        {
            Codes = ["string"],
            Correlation = IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<IdentityVerificationBreakdownV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new IdentityVerificationBreakdownV1
        {
            Codes = ["string"],
            Correlation = IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<IdentityVerificationBreakdownV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<string> expectedCodes = ["string"];
        ApiEnum<string, IdentityVerificationBreakdownV1Correlation> expectedCorrelation =
            IdentityVerificationBreakdownV1Correlation.LowConfidence;
        double expectedCorrelationScore = 0;
        ApiEnum<string, IdentityVerificationBreakdownV1Decision> expectedDecision =
            IdentityVerificationBreakdownV1Decision.Accept;
        double expectedRiskScore = 0;

        Assert.NotNull(deserialized.Codes);
        Assert.Equal(expectedCodes.Count, deserialized.Codes.Count);
        for (int i = 0; i < expectedCodes.Count; i++)
        {
            Assert.Equal(expectedCodes[i], deserialized.Codes[i]);
        }
        Assert.Equal(expectedCorrelation, deserialized.Correlation);
        Assert.Equal(expectedCorrelationScore, deserialized.CorrelationScore);
        Assert.Equal(expectedDecision, deserialized.Decision);
        Assert.Equal(expectedRiskScore, deserialized.RiskScore);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new IdentityVerificationBreakdownV1
        {
            Codes = ["string"],
            Correlation = IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new IdentityVerificationBreakdownV1
        {
            Codes = ["string"],
            CorrelationScore = 0,
            RiskScore = 0,
        };

        Assert.Null(model.Correlation);
        Assert.False(model.RawData.ContainsKey("correlation"));
        Assert.Null(model.Decision);
        Assert.False(model.RawData.ContainsKey("decision"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new IdentityVerificationBreakdownV1
        {
            Codes = ["string"],
            CorrelationScore = 0,
            RiskScore = 0,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new IdentityVerificationBreakdownV1
        {
            Codes = ["string"],
            CorrelationScore = 0,
            RiskScore = 0,

            // Null should be interpreted as omitted for these properties
            Correlation = null,
            Decision = null,
        };

        Assert.Null(model.Correlation);
        Assert.False(model.RawData.ContainsKey("correlation"));
        Assert.Null(model.Decision);
        Assert.False(model.RawData.ContainsKey("decision"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new IdentityVerificationBreakdownV1
        {
            Codes = ["string"],
            CorrelationScore = 0,
            RiskScore = 0,

            // Null should be interpreted as omitted for these properties
            Correlation = null,
            Decision = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new IdentityVerificationBreakdownV1
        {
            Correlation = IdentityVerificationBreakdownV1Correlation.LowConfidence,
            Decision = IdentityVerificationBreakdownV1Decision.Accept,
        };

        Assert.Null(model.Codes);
        Assert.False(model.RawData.ContainsKey("codes"));
        Assert.Null(model.CorrelationScore);
        Assert.False(model.RawData.ContainsKey("correlation_score"));
        Assert.Null(model.RiskScore);
        Assert.False(model.RawData.ContainsKey("risk_score"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new IdentityVerificationBreakdownV1
        {
            Correlation = IdentityVerificationBreakdownV1Correlation.LowConfidence,
            Decision = IdentityVerificationBreakdownV1Decision.Accept,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new IdentityVerificationBreakdownV1
        {
            Correlation = IdentityVerificationBreakdownV1Correlation.LowConfidence,
            Decision = IdentityVerificationBreakdownV1Decision.Accept,

            Codes = null,
            CorrelationScore = null,
            RiskScore = null,
        };

        Assert.Null(model.Codes);
        Assert.True(model.RawData.ContainsKey("codes"));
        Assert.Null(model.CorrelationScore);
        Assert.True(model.RawData.ContainsKey("correlation_score"));
        Assert.Null(model.RiskScore);
        Assert.True(model.RawData.ContainsKey("risk_score"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new IdentityVerificationBreakdownV1
        {
            Correlation = IdentityVerificationBreakdownV1Correlation.LowConfidence,
            Decision = IdentityVerificationBreakdownV1Decision.Accept,

            Codes = null,
            CorrelationScore = null,
            RiskScore = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new IdentityVerificationBreakdownV1
        {
            Codes = ["string"],
            Correlation = IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };

        IdentityVerificationBreakdownV1 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class IdentityVerificationBreakdownV1CorrelationTest : TestBase
{
    [Theory]
    [InlineData(IdentityVerificationBreakdownV1Correlation.LowConfidence)]
    [InlineData(IdentityVerificationBreakdownV1Correlation.PotentialMatch)]
    [InlineData(IdentityVerificationBreakdownV1Correlation.LikelyMatch)]
    [InlineData(IdentityVerificationBreakdownV1Correlation.HighConfidence)]
    public void Validation_Works(IdentityVerificationBreakdownV1Correlation rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, IdentityVerificationBreakdownV1Correlation> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, IdentityVerificationBreakdownV1Correlation>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(IdentityVerificationBreakdownV1Correlation.LowConfidence)]
    [InlineData(IdentityVerificationBreakdownV1Correlation.PotentialMatch)]
    [InlineData(IdentityVerificationBreakdownV1Correlation.LikelyMatch)]
    [InlineData(IdentityVerificationBreakdownV1Correlation.HighConfidence)]
    public void SerializationRoundtrip_Works(IdentityVerificationBreakdownV1Correlation rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, IdentityVerificationBreakdownV1Correlation> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, IdentityVerificationBreakdownV1Correlation>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, IdentityVerificationBreakdownV1Correlation>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, IdentityVerificationBreakdownV1Correlation>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class IdentityVerificationBreakdownV1DecisionTest : TestBase
{
    [Theory]
    [InlineData(IdentityVerificationBreakdownV1Decision.Accept)]
    [InlineData(IdentityVerificationBreakdownV1Decision.Reject)]
    [InlineData(IdentityVerificationBreakdownV1Decision.Review)]
    public void Validation_Works(IdentityVerificationBreakdownV1Decision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, IdentityVerificationBreakdownV1Decision> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, IdentityVerificationBreakdownV1Decision>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(IdentityVerificationBreakdownV1Decision.Accept)]
    [InlineData(IdentityVerificationBreakdownV1Decision.Reject)]
    [InlineData(IdentityVerificationBreakdownV1Decision.Review)]
    public void SerializationRoundtrip_Works(IdentityVerificationBreakdownV1Decision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, IdentityVerificationBreakdownV1Decision> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, IdentityVerificationBreakdownV1Decision>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, IdentityVerificationBreakdownV1Decision>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, IdentityVerificationBreakdownV1Decision>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}
