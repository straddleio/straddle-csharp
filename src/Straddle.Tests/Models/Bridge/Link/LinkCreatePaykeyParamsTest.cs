using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Bridge.Link;

namespace Straddle.Tests.Models.Bridge.Link;

public class LinkCreatePaykeyParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new LinkCreatePaykeyParams
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            QuilttToken = "quiltt_token",
            Config = new()
            {
                ProcessingMethod = LinkCreatePaykeyParamsConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreatePaykeyParamsConfigSandboxOutcome.Standard,
            },
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        string expectedCustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        string expectedQuilttToken = "quiltt_token";
        LinkCreatePaykeyParamsConfig expectedConfig = new()
        {
            ProcessingMethod = LinkCreatePaykeyParamsConfigProcessingMethod.Inline,
            SandboxOutcome = LinkCreatePaykeyParamsConfigSandboxOutcome.Standard,
        };
        string expectedExternalID = "external_id";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        string expectedCorrelationID = "Correlation-Id";
        string expectedIdempotencyKey = "xxxxxxxxxx";
        string expectedRequestID = "Request-Id";
        string expectedStraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";

        Assert.Equal(expectedCustomerID, parameters.CustomerID);
        Assert.Equal(expectedQuilttToken, parameters.QuilttToken);
        Assert.Equal(expectedConfig, parameters.Config);
        Assert.Equal(expectedExternalID, parameters.ExternalID);
        Assert.NotNull(parameters.Metadata);
        Assert.Equal(expectedMetadata.Count, parameters.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(parameters.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, parameters.Metadata[item.Key]);
        }
        Assert.Equal(expectedCorrelationID, parameters.CorrelationID);
        Assert.Equal(expectedIdempotencyKey, parameters.IdempotencyKey);
        Assert.Equal(expectedRequestID, parameters.RequestID);
        Assert.Equal(expectedStraddleAccountID, parameters.StraddleAccountID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new LinkCreatePaykeyParams
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            QuilttToken = "quiltt_token",
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        Assert.Null(parameters.Config);
        Assert.False(parameters.RawBodyData.ContainsKey("config"));
        Assert.Null(parameters.CorrelationID);
        Assert.False(parameters.RawHeaderData.ContainsKey("Correlation-Id"));
        Assert.Null(parameters.IdempotencyKey);
        Assert.False(parameters.RawHeaderData.ContainsKey("Idempotency-Key"));
        Assert.Null(parameters.RequestID);
        Assert.False(parameters.RawHeaderData.ContainsKey("Request-Id"));
        Assert.Null(parameters.StraddleAccountID);
        Assert.False(parameters.RawHeaderData.ContainsKey("Straddle-Account-Id"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new LinkCreatePaykeyParams
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            QuilttToken = "quiltt_token",
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },

            // Null should be interpreted as omitted for these properties
            Config = null,
            CorrelationID = null,
            IdempotencyKey = null,
            RequestID = null,
            StraddleAccountID = null,
        };

        Assert.Null(parameters.Config);
        Assert.False(parameters.RawBodyData.ContainsKey("config"));
        Assert.Null(parameters.CorrelationID);
        Assert.False(parameters.RawHeaderData.ContainsKey("Correlation-Id"));
        Assert.Null(parameters.IdempotencyKey);
        Assert.False(parameters.RawHeaderData.ContainsKey("Idempotency-Key"));
        Assert.Null(parameters.RequestID);
        Assert.False(parameters.RawHeaderData.ContainsKey("Request-Id"));
        Assert.Null(parameters.StraddleAccountID);
        Assert.False(parameters.RawHeaderData.ContainsKey("Straddle-Account-Id"));
    }

    [Fact]
    public void OptionalNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new LinkCreatePaykeyParams
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            QuilttToken = "quiltt_token",
            Config = new()
            {
                ProcessingMethod = LinkCreatePaykeyParamsConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreatePaykeyParamsConfigSandboxOutcome.Standard,
            },
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        Assert.Null(parameters.ExternalID);
        Assert.False(parameters.RawBodyData.ContainsKey("external_id"));
        Assert.Null(parameters.Metadata);
        Assert.False(parameters.RawBodyData.ContainsKey("metadata"));
    }

    [Fact]
    public void OptionalNullableParamsSetToNullAreSetToNull_Works()
    {
        var parameters = new LinkCreatePaykeyParams
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            QuilttToken = "quiltt_token",
            Config = new()
            {
                ProcessingMethod = LinkCreatePaykeyParamsConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreatePaykeyParamsConfigSandboxOutcome.Standard,
            },
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",

            ExternalID = null,
            Metadata = null,
        };

        Assert.Null(parameters.ExternalID);
        Assert.True(parameters.RawBodyData.ContainsKey("external_id"));
        Assert.Null(parameters.Metadata);
        Assert.True(parameters.RawBodyData.ContainsKey("metadata"));
    }

    [Fact]
    public void Url_Works()
    {
        LinkCreatePaykeyParams parameters = new()
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            QuilttToken = "quiltt_token",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(new Uri("https://sandbox.straddle.com/v1/bridge/quiltt"), url);
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        LinkCreatePaykeyParams parameters = new()
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            QuilttToken = "quiltt_token",
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        parameters.AddHeadersToRequest(requestMessage, new() { ApiKey = "My API Key" });

        Assert.Equal(["Correlation-Id"], requestMessage.Headers.GetValues("Correlation-Id"));
        Assert.Equal(["xxxxxxxxxx"], requestMessage.Headers.GetValues("Idempotency-Key"));
        Assert.Equal(["Request-Id"], requestMessage.Headers.GetValues("Request-Id"));
        Assert.Equal(
            ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            requestMessage.Headers.GetValues("Straddle-Account-Id")
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new LinkCreatePaykeyParams
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            QuilttToken = "quiltt_token",
            Config = new()
            {
                ProcessingMethod = LinkCreatePaykeyParamsConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreatePaykeyParamsConfigSandboxOutcome.Standard,
            },
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        LinkCreatePaykeyParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class LinkCreatePaykeyParamsConfigTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkCreatePaykeyParamsConfig
        {
            ProcessingMethod = LinkCreatePaykeyParamsConfigProcessingMethod.Inline,
            SandboxOutcome = LinkCreatePaykeyParamsConfigSandboxOutcome.Standard,
        };

        ApiEnum<string, LinkCreatePaykeyParamsConfigProcessingMethod> expectedProcessingMethod =
            LinkCreatePaykeyParamsConfigProcessingMethod.Inline;
        ApiEnum<string, LinkCreatePaykeyParamsConfigSandboxOutcome> expectedSandboxOutcome =
            LinkCreatePaykeyParamsConfigSandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, model.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, model.SandboxOutcome);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LinkCreatePaykeyParamsConfig
        {
            ProcessingMethod = LinkCreatePaykeyParamsConfigProcessingMethod.Inline,
            SandboxOutcome = LinkCreatePaykeyParamsConfigSandboxOutcome.Standard,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkCreatePaykeyParamsConfig>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkCreatePaykeyParamsConfig
        {
            ProcessingMethod = LinkCreatePaykeyParamsConfigProcessingMethod.Inline,
            SandboxOutcome = LinkCreatePaykeyParamsConfigSandboxOutcome.Standard,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkCreatePaykeyParamsConfig>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, LinkCreatePaykeyParamsConfigProcessingMethod> expectedProcessingMethod =
            LinkCreatePaykeyParamsConfigProcessingMethod.Inline;
        ApiEnum<string, LinkCreatePaykeyParamsConfigSandboxOutcome> expectedSandboxOutcome =
            LinkCreatePaykeyParamsConfigSandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, deserialized.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, deserialized.SandboxOutcome);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LinkCreatePaykeyParamsConfig
        {
            ProcessingMethod = LinkCreatePaykeyParamsConfigProcessingMethod.Inline,
            SandboxOutcome = LinkCreatePaykeyParamsConfigSandboxOutcome.Standard,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new LinkCreatePaykeyParamsConfig { };

        Assert.Null(model.ProcessingMethod);
        Assert.False(model.RawData.ContainsKey("processing_method"));
        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new LinkCreatePaykeyParamsConfig { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new LinkCreatePaykeyParamsConfig
        {
            // Null should be interpreted as omitted for these properties
            ProcessingMethod = null,
            SandboxOutcome = null,
        };

        Assert.Null(model.ProcessingMethod);
        Assert.False(model.RawData.ContainsKey("processing_method"));
        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new LinkCreatePaykeyParamsConfig
        {
            // Null should be interpreted as omitted for these properties
            ProcessingMethod = null,
            SandboxOutcome = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new LinkCreatePaykeyParamsConfig
        {
            ProcessingMethod = LinkCreatePaykeyParamsConfigProcessingMethod.Inline,
            SandboxOutcome = LinkCreatePaykeyParamsConfigSandboxOutcome.Standard,
        };

        LinkCreatePaykeyParamsConfig copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class LinkCreatePaykeyParamsConfigProcessingMethodTest : TestBase
{
    [Theory]
    [InlineData(LinkCreatePaykeyParamsConfigProcessingMethod.Inline)]
    [InlineData(LinkCreatePaykeyParamsConfigProcessingMethod.Background)]
    [InlineData(LinkCreatePaykeyParamsConfigProcessingMethod.Skip)]
    public void Validation_Works(LinkCreatePaykeyParamsConfigProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreatePaykeyParamsConfigProcessingMethod> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreatePaykeyParamsConfigProcessingMethod>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkCreatePaykeyParamsConfigProcessingMethod.Inline)]
    [InlineData(LinkCreatePaykeyParamsConfigProcessingMethod.Background)]
    [InlineData(LinkCreatePaykeyParamsConfigProcessingMethod.Skip)]
    public void SerializationRoundtrip_Works(LinkCreatePaykeyParamsConfigProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreatePaykeyParamsConfigProcessingMethod> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreatePaykeyParamsConfigProcessingMethod>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreatePaykeyParamsConfigProcessingMethod>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreatePaykeyParamsConfigProcessingMethod>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class LinkCreatePaykeyParamsConfigSandboxOutcomeTest : TestBase
{
    [Theory]
    [InlineData(LinkCreatePaykeyParamsConfigSandboxOutcome.Standard)]
    [InlineData(LinkCreatePaykeyParamsConfigSandboxOutcome.Active)]
    [InlineData(LinkCreatePaykeyParamsConfigSandboxOutcome.Rejected)]
    [InlineData(LinkCreatePaykeyParamsConfigSandboxOutcome.Review)]
    public void Validation_Works(LinkCreatePaykeyParamsConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreatePaykeyParamsConfigSandboxOutcome> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreatePaykeyParamsConfigSandboxOutcome>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkCreatePaykeyParamsConfigSandboxOutcome.Standard)]
    [InlineData(LinkCreatePaykeyParamsConfigSandboxOutcome.Active)]
    [InlineData(LinkCreatePaykeyParamsConfigSandboxOutcome.Rejected)]
    [InlineData(LinkCreatePaykeyParamsConfigSandboxOutcome.Review)]
    public void SerializationRoundtrip_Works(LinkCreatePaykeyParamsConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreatePaykeyParamsConfigSandboxOutcome> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreatePaykeyParamsConfigSandboxOutcome>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreatePaykeyParamsConfigSandboxOutcome>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreatePaykeyParamsConfigSandboxOutcome>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}
