using System;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Embed.Accounts;

namespace Straddle.Tests.Models.Embed.Accounts;

public class TermsOfServiceV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TermsOfServiceV1
        {
            AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            AgreementType = AgreementType.Embedded,
            AgreementUrl = "agreement_url",
            AcceptedIP = "accepted_ip",
            AcceptedUserAgent = "accepted_user_agent",
        };

        DateTimeOffset expectedAcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        ApiEnum<string, AgreementType> expectedAgreementType = AgreementType.Embedded;
        string expectedAgreementUrl = "agreement_url";
        string expectedAcceptedIP = "accepted_ip";
        string expectedAcceptedUserAgent = "accepted_user_agent";

        Assert.Equal(expectedAcceptedDate, model.AcceptedDate);
        Assert.Equal(expectedAgreementType, model.AgreementType);
        Assert.Equal(expectedAgreementUrl, model.AgreementUrl);
        Assert.Equal(expectedAcceptedIP, model.AcceptedIP);
        Assert.Equal(expectedAcceptedUserAgent, model.AcceptedUserAgent);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new TermsOfServiceV1
        {
            AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            AgreementType = AgreementType.Embedded,
            AgreementUrl = "agreement_url",
            AcceptedIP = "accepted_ip",
            AcceptedUserAgent = "accepted_user_agent",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TermsOfServiceV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TermsOfServiceV1
        {
            AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            AgreementType = AgreementType.Embedded,
            AgreementUrl = "agreement_url",
            AcceptedIP = "accepted_ip",
            AcceptedUserAgent = "accepted_user_agent",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TermsOfServiceV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        DateTimeOffset expectedAcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        ApiEnum<string, AgreementType> expectedAgreementType = AgreementType.Embedded;
        string expectedAgreementUrl = "agreement_url";
        string expectedAcceptedIP = "accepted_ip";
        string expectedAcceptedUserAgent = "accepted_user_agent";

        Assert.Equal(expectedAcceptedDate, deserialized.AcceptedDate);
        Assert.Equal(expectedAgreementType, deserialized.AgreementType);
        Assert.Equal(expectedAgreementUrl, deserialized.AgreementUrl);
        Assert.Equal(expectedAcceptedIP, deserialized.AcceptedIP);
        Assert.Equal(expectedAcceptedUserAgent, deserialized.AcceptedUserAgent);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new TermsOfServiceV1
        {
            AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            AgreementType = AgreementType.Embedded,
            AgreementUrl = "agreement_url",
            AcceptedIP = "accepted_ip",
            AcceptedUserAgent = "accepted_user_agent",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TermsOfServiceV1
        {
            AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            AgreementType = AgreementType.Embedded,
            AgreementUrl = "agreement_url",
        };

        Assert.Null(model.AcceptedIP);
        Assert.False(model.RawData.ContainsKey("accepted_ip"));
        Assert.Null(model.AcceptedUserAgent);
        Assert.False(model.RawData.ContainsKey("accepted_user_agent"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new TermsOfServiceV1
        {
            AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            AgreementType = AgreementType.Embedded,
            AgreementUrl = "agreement_url",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new TermsOfServiceV1
        {
            AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            AgreementType = AgreementType.Embedded,
            AgreementUrl = "agreement_url",

            AcceptedIP = null,
            AcceptedUserAgent = null,
        };

        Assert.Null(model.AcceptedIP);
        Assert.True(model.RawData.ContainsKey("accepted_ip"));
        Assert.Null(model.AcceptedUserAgent);
        Assert.True(model.RawData.ContainsKey("accepted_user_agent"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new TermsOfServiceV1
        {
            AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            AgreementType = AgreementType.Embedded,
            AgreementUrl = "agreement_url",

            AcceptedIP = null,
            AcceptedUserAgent = null,
        };

        model.Validate();
    }
}

public class AgreementTypeTest : TestBase
{
    [Theory]
    [InlineData(AgreementType.Embedded)]
    [InlineData(AgreementType.Direct)]
    public void Validation_Works(AgreementType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AgreementType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, AgreementType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(AgreementType.Embedded)]
    [InlineData(AgreementType.Direct)]
    public void SerializationRoundtrip_Works(AgreementType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AgreementType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, AgreementType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, AgreementType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, AgreementType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
