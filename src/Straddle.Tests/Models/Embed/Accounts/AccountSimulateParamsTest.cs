using System;
using System.Net.Http;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Embed.Accounts;

namespace Straddle.Tests.Models.Embed.Accounts;

public class AccountSimulateParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new AccountSimulateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            FinalStatus = FinalStatus.Onboarding,
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",
        };

        string expectedAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        ApiEnum<string, FinalStatus> expectedFinalStatus = FinalStatus.Onboarding;
        string expectedCorrelationID = "correlation-id";
        string expectedIdempotencyKey = "xxxxxxxxxx";
        string expectedRequestID = "request-id";

        Assert.Equal(expectedAccountID, parameters.AccountID);
        Assert.Equal(expectedFinalStatus, parameters.FinalStatus);
        Assert.Equal(expectedCorrelationID, parameters.CorrelationID);
        Assert.Equal(expectedIdempotencyKey, parameters.IdempotencyKey);
        Assert.Equal(expectedRequestID, parameters.RequestID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new AccountSimulateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        Assert.Null(parameters.FinalStatus);
        Assert.False(parameters.RawQueryData.ContainsKey("final_status"));
        Assert.Null(parameters.CorrelationID);
        Assert.False(parameters.RawHeaderData.ContainsKey("correlation-id"));
        Assert.Null(parameters.IdempotencyKey);
        Assert.False(parameters.RawHeaderData.ContainsKey("idempotency-key"));
        Assert.Null(parameters.RequestID);
        Assert.False(parameters.RawHeaderData.ContainsKey("request-id"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new AccountSimulateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",

            // Null should be interpreted as omitted for these properties
            FinalStatus = null,
            CorrelationID = null,
            IdempotencyKey = null,
            RequestID = null,
        };

        Assert.Null(parameters.FinalStatus);
        Assert.False(parameters.RawQueryData.ContainsKey("final_status"));
        Assert.Null(parameters.CorrelationID);
        Assert.False(parameters.RawHeaderData.ContainsKey("correlation-id"));
        Assert.Null(parameters.IdempotencyKey);
        Assert.False(parameters.RawHeaderData.ContainsKey("idempotency-key"));
        Assert.Null(parameters.RequestID);
        Assert.False(parameters.RawHeaderData.ContainsKey("request-id"));
    }

    [Fact]
    public void Url_Works()
    {
        AccountSimulateParams parameters = new()
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            FinalStatus = FinalStatus.Onboarding,
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://sandbox.straddle.com/v1/accounts/182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e/simulate?final_status=onboarding"
            ),
            url
        );
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        AccountSimulateParams parameters = new()
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",
        };

        parameters.AddHeadersToRequest(requestMessage, new() { ApiKey = "My API Key" });

        Assert.Equal(["correlation-id"], requestMessage.Headers.GetValues("correlation-id"));
        Assert.Equal(["xxxxxxxxxx"], requestMessage.Headers.GetValues("idempotency-key"));
        Assert.Equal(["request-id"], requestMessage.Headers.GetValues("request-id"));
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new AccountSimulateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            FinalStatus = FinalStatus.Onboarding,
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",
        };

        AccountSimulateParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class FinalStatusTest : TestBase
{
    [Theory]
    [InlineData(FinalStatus.Onboarding)]
    [InlineData(FinalStatus.Active)]
    public void Validation_Works(FinalStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FinalStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, FinalStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(FinalStatus.Onboarding)]
    [InlineData(FinalStatus.Active)]
    public void SerializationRoundtrip_Works(FinalStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FinalStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, FinalStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, FinalStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, FinalStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
