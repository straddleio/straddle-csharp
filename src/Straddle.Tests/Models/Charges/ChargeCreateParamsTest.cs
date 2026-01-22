using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models;
using Straddle.Models.Charges;

namespace Straddle.Tests.Models.Charges;

public class ChargeCreateParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new ChargeCreateParams
        {
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = BalanceCheck.Required,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            ConsentType = ConsentType.Internet,
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        int expectedAmount = 10000;
        Config expectedConfig = new()
        {
            BalanceCheck = BalanceCheck.Required,
            SandboxOutcome = SandboxOutcome.Standard,
        };
        ApiEnum<string, ConsentType> expectedConsentType = ConsentType.Internet;
        string expectedCurrency = "currency";
        string expectedDescription = "Monthly subscription fee";
        DeviceInfoV1 expectedDevice = new("192.168.1.1");
        string expectedExternalID = "external_id";
        string expectedPaykey = "paykey";
        string expectedPaymentDate = "2019-12-27";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        string expectedCorrelationID = "Correlation-Id";
        string expectedIdempotencyKey = "xxxxxxxxxx";
        string expectedRequestID = "Request-Id";
        string expectedStraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";

        Assert.Equal(expectedAmount, parameters.Amount);
        Assert.Equal(expectedConfig, parameters.Config);
        Assert.Equal(expectedConsentType, parameters.ConsentType);
        Assert.Equal(expectedCurrency, parameters.Currency);
        Assert.Equal(expectedDescription, parameters.Description);
        Assert.Equal(expectedDevice, parameters.Device);
        Assert.Equal(expectedExternalID, parameters.ExternalID);
        Assert.Equal(expectedPaykey, parameters.Paykey);
        Assert.Equal(expectedPaymentDate, parameters.PaymentDate);
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
        var parameters = new ChargeCreateParams
        {
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = BalanceCheck.Required,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            ConsentType = ConsentType.Internet,
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

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
        var parameters = new ChargeCreateParams
        {
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = BalanceCheck.Required,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            ConsentType = ConsentType.Internet,
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },

            // Null should be interpreted as omitted for these properties
            CorrelationID = null,
            IdempotencyKey = null,
            RequestID = null,
            StraddleAccountID = null,
        };

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
        var parameters = new ChargeCreateParams
        {
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = BalanceCheck.Required,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            ConsentType = ConsentType.Internet,
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        Assert.Null(parameters.Metadata);
        Assert.False(parameters.RawBodyData.ContainsKey("metadata"));
    }

    [Fact]
    public void OptionalNullableParamsSetToNullAreSetToNull_Works()
    {
        var parameters = new ChargeCreateParams
        {
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = BalanceCheck.Required,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            ConsentType = ConsentType.Internet,
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",

            Metadata = null,
        };

        Assert.Null(parameters.Metadata);
        Assert.True(parameters.RawBodyData.ContainsKey("metadata"));
    }

    [Fact]
    public void Url_Works()
    {
        ChargeCreateParams parameters = new()
        {
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = BalanceCheck.Required,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            ConsentType = ConsentType.Internet,
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(new Uri("https://sandbox.straddle.com/v1/charges"), url);
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        ChargeCreateParams parameters = new()
        {
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = BalanceCheck.Required,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            ConsentType = ConsentType.Internet,
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
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
        var parameters = new ChargeCreateParams
        {
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = BalanceCheck.Required,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            ConsentType = ConsentType.Internet,
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        ChargeCreateParams copied = new(parameters);

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
            BalanceCheck = BalanceCheck.Required,
            SandboxOutcome = SandboxOutcome.Standard,
        };

        ApiEnum<string, BalanceCheck> expectedBalanceCheck = BalanceCheck.Required;
        ApiEnum<string, SandboxOutcome> expectedSandboxOutcome = SandboxOutcome.Standard;

        Assert.Equal(expectedBalanceCheck, model.BalanceCheck);
        Assert.Equal(expectedSandboxOutcome, model.SandboxOutcome);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Config
        {
            BalanceCheck = BalanceCheck.Required,
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
            BalanceCheck = BalanceCheck.Required,
            SandboxOutcome = SandboxOutcome.Standard,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Config>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        ApiEnum<string, BalanceCheck> expectedBalanceCheck = BalanceCheck.Required;
        ApiEnum<string, SandboxOutcome> expectedSandboxOutcome = SandboxOutcome.Standard;

        Assert.Equal(expectedBalanceCheck, deserialized.BalanceCheck);
        Assert.Equal(expectedSandboxOutcome, deserialized.SandboxOutcome);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Config
        {
            BalanceCheck = BalanceCheck.Required,
            SandboxOutcome = SandboxOutcome.Standard,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Config { BalanceCheck = BalanceCheck.Required };

        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Config { BalanceCheck = BalanceCheck.Required };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Config
        {
            BalanceCheck = BalanceCheck.Required,

            // Null should be interpreted as omitted for these properties
            SandboxOutcome = null,
        };

        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Config
        {
            BalanceCheck = BalanceCheck.Required,

            // Null should be interpreted as omitted for these properties
            SandboxOutcome = null,
        };

        model.Validate();
    }
}

public class BalanceCheckTest : TestBase
{
    [Theory]
    [InlineData(BalanceCheck.Required)]
    [InlineData(BalanceCheck.Enabled)]
    [InlineData(BalanceCheck.Disabled)]
    [InlineData(BalanceCheck.Required1)]
    [InlineData(BalanceCheck.Enabled1)]
    [InlineData(BalanceCheck.Disabled1)]
    public void Validation_Works(BalanceCheck rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, BalanceCheck> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, BalanceCheck>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(BalanceCheck.Required)]
    [InlineData(BalanceCheck.Enabled)]
    [InlineData(BalanceCheck.Disabled)]
    [InlineData(BalanceCheck.Required1)]
    [InlineData(BalanceCheck.Enabled1)]
    [InlineData(BalanceCheck.Disabled1)]
    public void SerializationRoundtrip_Works(BalanceCheck rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, BalanceCheck> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, BalanceCheck>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, BalanceCheck>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, BalanceCheck>>(
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
    [InlineData(SandboxOutcome.Paid)]
    [InlineData(SandboxOutcome.OnHoldDailyLimit)]
    [InlineData(SandboxOutcome.CancelledForFraudRisk)]
    [InlineData(SandboxOutcome.CancelledForBalanceCheck)]
    [InlineData(SandboxOutcome.FailedInsufficientFunds)]
    [InlineData(SandboxOutcome.ReversedInsufficientFunds)]
    [InlineData(SandboxOutcome.FailedCustomerDispute)]
    [InlineData(SandboxOutcome.ReversedCustomerDispute)]
    [InlineData(SandboxOutcome.FailedClosedBankAccount)]
    [InlineData(SandboxOutcome.ReversedClosedBankAccount)]
    [InlineData(SandboxOutcome.Standard1)]
    [InlineData(SandboxOutcome.Paid1)]
    [InlineData(SandboxOutcome.OnHoldDailyLimit1)]
    [InlineData(SandboxOutcome.CancelledForFraudRisk1)]
    [InlineData(SandboxOutcome.CancelledForBalanceCheck1)]
    [InlineData(SandboxOutcome.FailedInsufficientFunds1)]
    [InlineData(SandboxOutcome.ReversedInsufficientFunds1)]
    [InlineData(SandboxOutcome.FailedCustomerDispute1)]
    [InlineData(SandboxOutcome.ReversedCustomerDispute1)]
    [InlineData(SandboxOutcome.FailedClosedBankAccount1)]
    [InlineData(SandboxOutcome.ReversedClosedBankAccount1)]
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
    [InlineData(SandboxOutcome.Paid)]
    [InlineData(SandboxOutcome.OnHoldDailyLimit)]
    [InlineData(SandboxOutcome.CancelledForFraudRisk)]
    [InlineData(SandboxOutcome.CancelledForBalanceCheck)]
    [InlineData(SandboxOutcome.FailedInsufficientFunds)]
    [InlineData(SandboxOutcome.ReversedInsufficientFunds)]
    [InlineData(SandboxOutcome.FailedCustomerDispute)]
    [InlineData(SandboxOutcome.ReversedCustomerDispute)]
    [InlineData(SandboxOutcome.FailedClosedBankAccount)]
    [InlineData(SandboxOutcome.ReversedClosedBankAccount)]
    [InlineData(SandboxOutcome.Standard1)]
    [InlineData(SandboxOutcome.Paid1)]
    [InlineData(SandboxOutcome.OnHoldDailyLimit1)]
    [InlineData(SandboxOutcome.CancelledForFraudRisk1)]
    [InlineData(SandboxOutcome.CancelledForBalanceCheck1)]
    [InlineData(SandboxOutcome.FailedInsufficientFunds1)]
    [InlineData(SandboxOutcome.ReversedInsufficientFunds1)]
    [InlineData(SandboxOutcome.FailedCustomerDispute1)]
    [InlineData(SandboxOutcome.ReversedCustomerDispute1)]
    [InlineData(SandboxOutcome.FailedClosedBankAccount1)]
    [InlineData(SandboxOutcome.ReversedClosedBankAccount1)]
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

public class ConsentTypeTest : TestBase
{
    [Theory]
    [InlineData(ConsentType.Internet)]
    [InlineData(ConsentType.Signed)]
    [InlineData(ConsentType.Internet1)]
    [InlineData(ConsentType.Signed1)]
    public void Validation_Works(ConsentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ConsentType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ConsentType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ConsentType.Internet)]
    [InlineData(ConsentType.Signed)]
    [InlineData(ConsentType.Internet1)]
    [InlineData(ConsentType.Signed1)]
    public void SerializationRoundtrip_Works(ConsentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ConsentType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ConsentType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ConsentType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ConsentType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
