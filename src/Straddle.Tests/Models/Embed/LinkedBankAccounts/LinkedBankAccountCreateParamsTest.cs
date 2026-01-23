using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Embed.LinkedBankAccounts;

namespace Straddle.Tests.Models.Embed.LinkedBankAccounts;

public class LinkedBankAccountCreateParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new LinkedBankAccountCreateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                RoutingNumber = "xxxxxxxxx",
            },
            Description = "description",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Purposes = [Purpose.Charges],
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",
        };

        string expectedAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        BankAccount expectedBankAccount = new()
        {
            AccountHolder = "account_holder",
            AccountNumber = "account_number",
            RoutingNumber = "xxxxxxxxx",
        };
        string expectedDescription = "description";
        Dictionary<string, string?> expectedMetadata = new() { { "foo", "string" } };
        string expectedPlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        List<ApiEnum<string, Purpose>> expectedPurposes = [Purpose.Charges];
        string expectedCorrelationID = "correlation-id";
        string expectedIdempotencyKey = "xxxxxxxxxx";
        string expectedRequestID = "request-id";

        Assert.Equal(expectedAccountID, parameters.AccountID);
        Assert.Equal(expectedBankAccount, parameters.BankAccount);
        Assert.Equal(expectedDescription, parameters.Description);
        Assert.NotNull(parameters.Metadata);
        Assert.Equal(expectedMetadata.Count, parameters.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(parameters.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, parameters.Metadata[item.Key]);
        }
        Assert.Equal(expectedPlatformID, parameters.PlatformID);
        Assert.NotNull(parameters.Purposes);
        Assert.Equal(expectedPurposes.Count, parameters.Purposes.Count);
        for (int i = 0; i < expectedPurposes.Count; i++)
        {
            Assert.Equal(expectedPurposes[i], parameters.Purposes[i]);
        }
        Assert.Equal(expectedCorrelationID, parameters.CorrelationID);
        Assert.Equal(expectedIdempotencyKey, parameters.IdempotencyKey);
        Assert.Equal(expectedRequestID, parameters.RequestID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new LinkedBankAccountCreateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                RoutingNumber = "xxxxxxxxx",
            },
            Description = "description",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Purposes = [Purpose.Charges],
        };

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
        var parameters = new LinkedBankAccountCreateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                RoutingNumber = "xxxxxxxxx",
            },
            Description = "description",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Purposes = [Purpose.Charges],

            // Null should be interpreted as omitted for these properties
            CorrelationID = null,
            IdempotencyKey = null,
            RequestID = null,
        };

        Assert.Null(parameters.CorrelationID);
        Assert.False(parameters.RawHeaderData.ContainsKey("correlation-id"));
        Assert.Null(parameters.IdempotencyKey);
        Assert.False(parameters.RawHeaderData.ContainsKey("idempotency-key"));
        Assert.Null(parameters.RequestID);
        Assert.False(parameters.RawHeaderData.ContainsKey("request-id"));
    }

    [Fact]
    public void OptionalNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new LinkedBankAccountCreateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                RoutingNumber = "xxxxxxxxx",
            },
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",
        };

        Assert.Null(parameters.Description);
        Assert.False(parameters.RawBodyData.ContainsKey("description"));
        Assert.Null(parameters.Metadata);
        Assert.False(parameters.RawBodyData.ContainsKey("metadata"));
        Assert.Null(parameters.PlatformID);
        Assert.False(parameters.RawBodyData.ContainsKey("platform_id"));
        Assert.Null(parameters.Purposes);
        Assert.False(parameters.RawBodyData.ContainsKey("purposes"));
    }

    [Fact]
    public void OptionalNullableParamsSetToNullAreSetToNull_Works()
    {
        var parameters = new LinkedBankAccountCreateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                RoutingNumber = "xxxxxxxxx",
            },
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",

            Description = null,
            Metadata = null,
            PlatformID = null,
            Purposes = null,
        };

        Assert.Null(parameters.Description);
        Assert.True(parameters.RawBodyData.ContainsKey("description"));
        Assert.Null(parameters.Metadata);
        Assert.True(parameters.RawBodyData.ContainsKey("metadata"));
        Assert.Null(parameters.PlatformID);
        Assert.True(parameters.RawBodyData.ContainsKey("platform_id"));
        Assert.Null(parameters.Purposes);
        Assert.True(parameters.RawBodyData.ContainsKey("purposes"));
    }

    [Fact]
    public void Url_Works()
    {
        LinkedBankAccountCreateParams parameters = new()
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                RoutingNumber = "xxxxxxxxx",
            },
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(new Uri("https://sandbox.straddle.com/v1/linked_bank_accounts"), url);
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        LinkedBankAccountCreateParams parameters = new()
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                RoutingNumber = "xxxxxxxxx",
            },
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
        var parameters = new LinkedBankAccountCreateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                RoutingNumber = "xxxxxxxxx",
            },
            Description = "description",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Purposes = [Purpose.Charges],
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",
        };

        LinkedBankAccountCreateParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class BankAccountTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new BankAccount
        {
            AccountHolder = "account_holder",
            AccountNumber = "account_number",
            RoutingNumber = "xxxxxxxxx",
        };

        string expectedAccountHolder = "account_holder";
        string expectedAccountNumber = "account_number";
        string expectedRoutingNumber = "xxxxxxxxx";

        Assert.Equal(expectedAccountHolder, model.AccountHolder);
        Assert.Equal(expectedAccountNumber, model.AccountNumber);
        Assert.Equal(expectedRoutingNumber, model.RoutingNumber);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new BankAccount
        {
            AccountHolder = "account_holder",
            AccountNumber = "account_number",
            RoutingNumber = "xxxxxxxxx",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<BankAccount>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new BankAccount
        {
            AccountHolder = "account_holder",
            AccountNumber = "account_number",
            RoutingNumber = "xxxxxxxxx",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<BankAccount>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedAccountHolder = "account_holder";
        string expectedAccountNumber = "account_number";
        string expectedRoutingNumber = "xxxxxxxxx";

        Assert.Equal(expectedAccountHolder, deserialized.AccountHolder);
        Assert.Equal(expectedAccountNumber, deserialized.AccountNumber);
        Assert.Equal(expectedRoutingNumber, deserialized.RoutingNumber);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new BankAccount
        {
            AccountHolder = "account_holder",
            AccountNumber = "account_number",
            RoutingNumber = "xxxxxxxxx",
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new BankAccount
        {
            AccountHolder = "account_holder",
            AccountNumber = "account_number",
            RoutingNumber = "xxxxxxxxx",
        };

        BankAccount copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class PurposeTest : TestBase
{
    [Theory]
    [InlineData(Purpose.Charges)]
    [InlineData(Purpose.Payouts)]
    [InlineData(Purpose.Billing)]
    public void Validation_Works(Purpose rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Purpose> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Purpose>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Purpose.Charges)]
    [InlineData(Purpose.Payouts)]
    [InlineData(Purpose.Billing)]
    public void SerializationRoundtrip_Works(Purpose rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Purpose> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Purpose>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Purpose>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Purpose>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
