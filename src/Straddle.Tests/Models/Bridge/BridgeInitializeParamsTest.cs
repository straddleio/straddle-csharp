using System;
using System.Net.Http;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Bridge;

namespace Straddle.Tests.Models.Bridge;

public class BridgeInitializeParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new BridgeInitializeParams
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            ExternalID = "external_id",
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        string expectedCustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        Config expectedConfig = new()
        {
            ProcessingMethod = ProcessingMethod.Inline,
            SandboxOutcome = SandboxOutcome.Standard,
        };
        string expectedExternalID = "external_id";
        string expectedCorrelationID = "Correlation-Id";
        string expectedIdempotencyKey = "xxxxxxxxxx";
        string expectedRequestID = "Request-Id";
        string expectedStraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";

        Assert.Equal(expectedCustomerID, parameters.CustomerID);
        Assert.Equal(expectedConfig, parameters.Config);
        Assert.Equal(expectedExternalID, parameters.ExternalID);
        Assert.Equal(expectedCorrelationID, parameters.CorrelationID);
        Assert.Equal(expectedIdempotencyKey, parameters.IdempotencyKey);
        Assert.Equal(expectedRequestID, parameters.RequestID);
        Assert.Equal(expectedStraddleAccountID, parameters.StraddleAccountID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new BridgeInitializeParams
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExternalID = "external_id",
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
        var parameters = new BridgeInitializeParams
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExternalID = "external_id",

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
        var parameters = new BridgeInitializeParams
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        Assert.Null(parameters.ExternalID);
        Assert.False(parameters.RawBodyData.ContainsKey("external_id"));
    }

    [Fact]
    public void OptionalNullableParamsSetToNullAreSetToNull_Works()
    {
        var parameters = new BridgeInitializeParams
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",

            ExternalID = null,
        };

        Assert.Null(parameters.ExternalID);
        Assert.True(parameters.RawBodyData.ContainsKey("external_id"));
    }

    [Fact]
    public void Url_Works()
    {
        BridgeInitializeParams parameters = new()
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(new Uri("https://sandbox.straddle.com/v1/bridge/initialize"), url);
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        BridgeInitializeParams parameters = new()
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
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
        var parameters = new BridgeInitializeParams
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            ExternalID = "external_id",
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        BridgeInitializeParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class ConfigTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Config
        {
            ProcessingMethod = ProcessingMethod.Inline,
            SandboxOutcome = SandboxOutcome.Standard,
        };

        ApiEnum<string, ProcessingMethod> expectedProcessingMethod = ProcessingMethod.Inline;
        ApiEnum<string, SandboxOutcome> expectedSandboxOutcome = SandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, model.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, model.SandboxOutcome);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Config
        {
            ProcessingMethod = ProcessingMethod.Inline,
            SandboxOutcome = SandboxOutcome.Standard,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Config>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Config
        {
            ProcessingMethod = ProcessingMethod.Inline,
            SandboxOutcome = SandboxOutcome.Standard,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Config>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        ApiEnum<string, ProcessingMethod> expectedProcessingMethod = ProcessingMethod.Inline;
        ApiEnum<string, SandboxOutcome> expectedSandboxOutcome = SandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, deserialized.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, deserialized.SandboxOutcome);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Config
        {
            ProcessingMethod = ProcessingMethod.Inline,
            SandboxOutcome = SandboxOutcome.Standard,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Config { };

        Assert.Null(model.ProcessingMethod);
        Assert.False(model.RawData.ContainsKey("processing_method"));
        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Config { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Config
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
        var model = new Config
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
        var model = new Config
        {
            ProcessingMethod = ProcessingMethod.Inline,
            SandboxOutcome = SandboxOutcome.Standard,
        };

        Config copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class ProcessingMethodTest : TestBase
{
    [Theory]
    [InlineData(ProcessingMethod.Inline)]
    [InlineData(ProcessingMethod.Background)]
    [InlineData(ProcessingMethod.Skip)]
    public void Validation_Works(ProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ProcessingMethod> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ProcessingMethod>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ProcessingMethod.Inline)]
    [InlineData(ProcessingMethod.Background)]
    [InlineData(ProcessingMethod.Skip)]
    public void SerializationRoundtrip_Works(ProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ProcessingMethod> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ProcessingMethod>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ProcessingMethod>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ProcessingMethod>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class SandboxOutcomeTest : TestBase
{
    [Theory]
    [InlineData(SandboxOutcome.Standard)]
    [InlineData(SandboxOutcome.Active)]
    [InlineData(SandboxOutcome.Rejected)]
    [InlineData(SandboxOutcome.Review)]
    public void Validation_Works(SandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, SandboxOutcome> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, SandboxOutcome>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(SandboxOutcome.Standard)]
    [InlineData(SandboxOutcome.Active)]
    [InlineData(SandboxOutcome.Rejected)]
    [InlineData(SandboxOutcome.Review)]
    public void SerializationRoundtrip_Works(SandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, SandboxOutcome> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, SandboxOutcome>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, SandboxOutcome>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, SandboxOutcome>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
