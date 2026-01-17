using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using Straddle.Core;
using Straddle.Models.Embed.LinkedBankAccounts;

namespace Straddle.Tests.Models.Embed.LinkedBankAccounts;

public class LinkedBankAccountUpdateParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new LinkedBankAccountUpdateParams
        {
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                RoutingNumber = "xxxxxxxxx",
            },
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",
        };

        string expectedLinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        LinkedBankAccountUpdateParamsBankAccount expectedBankAccount = new()
        {
            AccountHolder = "account_holder",
            AccountNumber = "account_number",
            RoutingNumber = "xxxxxxxxx",
        };
        Dictionary<string, string?> expectedMetadata = new() { { "foo", "string" } };
        string expectedCorrelationID = "correlation-id";
        string expectedIdempotencyKey = "xxxxxxxxxx";
        string expectedRequestID = "request-id";

        Assert.Equal(expectedLinkedBankAccountID, parameters.LinkedBankAccountID);
        Assert.Equal(expectedBankAccount, parameters.BankAccount);
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
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new LinkedBankAccountUpdateParams
        {
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                RoutingNumber = "xxxxxxxxx",
            },
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
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
        var parameters = new LinkedBankAccountUpdateParams
        {
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                RoutingNumber = "xxxxxxxxx",
            },
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },

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
        var parameters = new LinkedBankAccountUpdateParams
        {
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
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

        Assert.Null(parameters.Metadata);
        Assert.False(parameters.RawBodyData.ContainsKey("metadata"));
    }

    [Fact]
    public void OptionalNullableParamsSetToNullAreSetToNull_Works()
    {
        var parameters = new LinkedBankAccountUpdateParams
        {
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                RoutingNumber = "xxxxxxxxx",
            },
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",

            Metadata = null,
        };

        Assert.Null(parameters.Metadata);
        Assert.True(parameters.RawBodyData.ContainsKey("metadata"));
    }

    [Fact]
    public void Url_Works()
    {
        LinkedBankAccountUpdateParams parameters = new()
        {
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                RoutingNumber = "xxxxxxxxx",
            },
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://sandbox.straddle.com/v1/linked_bank_accounts/182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"
            ),
            url
        );
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        LinkedBankAccountUpdateParams parameters = new()
        {
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
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
        var parameters = new LinkedBankAccountUpdateParams
        {
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                RoutingNumber = "xxxxxxxxx",
            },
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",
        };

        LinkedBankAccountUpdateParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class LinkedBankAccountUpdateParamsBankAccountTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkedBankAccountUpdateParamsBankAccount
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
        var model = new LinkedBankAccountUpdateParamsBankAccount
        {
            AccountHolder = "account_holder",
            AccountNumber = "account_number",
            RoutingNumber = "xxxxxxxxx",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountUpdateParamsBankAccount>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkedBankAccountUpdateParamsBankAccount
        {
            AccountHolder = "account_holder",
            AccountNumber = "account_number",
            RoutingNumber = "xxxxxxxxx",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountUpdateParamsBankAccount>(
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
        var model = new LinkedBankAccountUpdateParamsBankAccount
        {
            AccountHolder = "account_holder",
            AccountNumber = "account_number",
            RoutingNumber = "xxxxxxxxx",
        };

        model.Validate();
    }
}
