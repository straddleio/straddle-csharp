using System;
using System.Collections.Generic;
using System.Net.Http;
using Straddle.Models.Embed.Accounts;

namespace Straddle.Tests.Models.Embed.Accounts;

public class AccountUpdateParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new AccountUpdateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BusinessProfile = new()
            {
                Name = "name",
                Website = "https://example.com",
                Address = new()
                {
                    Address1 = "address1",
                    City = "city",
                    State = "SE",
                    Zip = "zip",
                    Address2 = "address2",
                    Country = "country",
                    Line1 = "line1",
                    Line2 = "line2",
                    PostalCode = "21029-1360",
                },
                Description = "description",
                Industry = new()
                {
                    Category = "category",
                    Mcc = "mcc",
                    Sector = "sector",
                },
                LegalName = "legal_name",
                Phone = "+46991022",
                SupportChannels = new()
                {
                    Email = "dev@stainless.com",
                    Phone = "+46991022",
                    Url = "https://example.com",
                },
                TaxID = "210297980",
                UseCase = "use_case",
            },
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",
        };

        string expectedAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        BusinessProfileV1 expectedBusinessProfile = new()
        {
            Name = "name",
            Website = "https://example.com",
            Address = new()
            {
                Address1 = "address1",
                City = "city",
                State = "SE",
                Zip = "zip",
                Address2 = "address2",
                Country = "country",
                Line1 = "line1",
                Line2 = "line2",
                PostalCode = "21029-1360",
            },
            Description = "description",
            Industry = new()
            {
                Category = "category",
                Mcc = "mcc",
                Sector = "sector",
            },
            LegalName = "legal_name",
            Phone = "+46991022",
            SupportChannels = new()
            {
                Email = "dev@stainless.com",
                Phone = "+46991022",
                Url = "https://example.com",
            },
            TaxID = "210297980",
            UseCase = "use_case",
        };
        string expectedExternalID = "external_id";
        Dictionary<string, string?> expectedMetadata = new() { { "foo", "string" } };
        string expectedCorrelationID = "correlation-id";
        string expectedIdempotencyKey = "xxxxxxxxxx";
        string expectedRequestID = "request-id";

        Assert.Equal(expectedAccountID, parameters.AccountID);
        Assert.Equal(expectedBusinessProfile, parameters.BusinessProfile);
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
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new AccountUpdateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BusinessProfile = new()
            {
                Name = "name",
                Website = "https://example.com",
                Address = new()
                {
                    Address1 = "address1",
                    City = "city",
                    State = "SE",
                    Zip = "zip",
                    Address2 = "address2",
                    Country = "country",
                    Line1 = "line1",
                    Line2 = "line2",
                    PostalCode = "21029-1360",
                },
                Description = "description",
                Industry = new()
                {
                    Category = "category",
                    Mcc = "mcc",
                    Sector = "sector",
                },
                LegalName = "legal_name",
                Phone = "+46991022",
                SupportChannels = new()
                {
                    Email = "dev@stainless.com",
                    Phone = "+46991022",
                    Url = "https://example.com",
                },
                TaxID = "210297980",
                UseCase = "use_case",
            },
            ExternalID = "external_id",
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
        var parameters = new AccountUpdateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BusinessProfile = new()
            {
                Name = "name",
                Website = "https://example.com",
                Address = new()
                {
                    Address1 = "address1",
                    City = "city",
                    State = "SE",
                    Zip = "zip",
                    Address2 = "address2",
                    Country = "country",
                    Line1 = "line1",
                    Line2 = "line2",
                    PostalCode = "21029-1360",
                },
                Description = "description",
                Industry = new()
                {
                    Category = "category",
                    Mcc = "mcc",
                    Sector = "sector",
                },
                LegalName = "legal_name",
                Phone = "+46991022",
                SupportChannels = new()
                {
                    Email = "dev@stainless.com",
                    Phone = "+46991022",
                    Url = "https://example.com",
                },
                TaxID = "210297980",
                UseCase = "use_case",
            },
            ExternalID = "external_id",
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
        var parameters = new AccountUpdateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BusinessProfile = new()
            {
                Name = "name",
                Website = "https://example.com",
                Address = new()
                {
                    Address1 = "address1",
                    City = "city",
                    State = "SE",
                    Zip = "zip",
                    Address2 = "address2",
                    Country = "country",
                    Line1 = "line1",
                    Line2 = "line2",
                    PostalCode = "21029-1360",
                },
                Description = "description",
                Industry = new()
                {
                    Category = "category",
                    Mcc = "mcc",
                    Sector = "sector",
                },
                LegalName = "legal_name",
                Phone = "+46991022",
                SupportChannels = new()
                {
                    Email = "dev@stainless.com",
                    Phone = "+46991022",
                    Url = "https://example.com",
                },
                TaxID = "210297980",
                UseCase = "use_case",
            },
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",
        };

        Assert.Null(parameters.ExternalID);
        Assert.False(parameters.RawBodyData.ContainsKey("external_id"));
        Assert.Null(parameters.Metadata);
        Assert.False(parameters.RawBodyData.ContainsKey("metadata"));
    }

    [Fact]
    public void OptionalNullableParamsSetToNullAreSetToNull_Works()
    {
        var parameters = new AccountUpdateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BusinessProfile = new()
            {
                Name = "name",
                Website = "https://example.com",
                Address = new()
                {
                    Address1 = "address1",
                    City = "city",
                    State = "SE",
                    Zip = "zip",
                    Address2 = "address2",
                    Country = "country",
                    Line1 = "line1",
                    Line2 = "line2",
                    PostalCode = "21029-1360",
                },
                Description = "description",
                Industry = new()
                {
                    Category = "category",
                    Mcc = "mcc",
                    Sector = "sector",
                },
                LegalName = "legal_name",
                Phone = "+46991022",
                SupportChannels = new()
                {
                    Email = "dev@stainless.com",
                    Phone = "+46991022",
                    Url = "https://example.com",
                },
                TaxID = "210297980",
                UseCase = "use_case",
            },
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",

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
        AccountUpdateParams parameters = new()
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BusinessProfile = new()
            {
                Name = "name",
                Website = "https://example.com",
                Address = new()
                {
                    Address1 = "address1",
                    City = "city",
                    State = "SE",
                    Zip = "zip",
                    Address2 = "address2",
                    Country = "country",
                    Line1 = "line1",
                    Line2 = "line2",
                    PostalCode = "21029-1360",
                },
                Description = "description",
                Industry = new()
                {
                    Category = "category",
                    Mcc = "mcc",
                    Sector = "sector",
                },
                LegalName = "legal_name",
                Phone = "+46991022",
                SupportChannels = new()
                {
                    Email = "dev@stainless.com",
                    Phone = "+46991022",
                    Url = "https://example.com",
                },
                TaxID = "210297980",
                UseCase = "use_case",
            },
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://sandbox.straddle.com/v1/accounts/182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"
            ),
            url
        );
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        AccountUpdateParams parameters = new()
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BusinessProfile = new()
            {
                Name = "name",
                Website = "https://example.com",
                Address = new()
                {
                    Address1 = "address1",
                    City = "city",
                    State = "SE",
                    Zip = "zip",
                    Address2 = "address2",
                    Country = "country",
                    Line1 = "line1",
                    Line2 = "line2",
                    PostalCode = "21029-1360",
                },
                Description = "description",
                Industry = new()
                {
                    Category = "category",
                    Mcc = "mcc",
                    Sector = "sector",
                },
                LegalName = "legal_name",
                Phone = "+46991022",
                SupportChannels = new()
                {
                    Email = "dev@stainless.com",
                    Phone = "+46991022",
                    Url = "https://example.com",
                },
                TaxID = "210297980",
                UseCase = "use_case",
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
        var parameters = new AccountUpdateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BusinessProfile = new()
            {
                Name = "name",
                Website = "https://example.com",
                Address = new()
                {
                    Address1 = "address1",
                    City = "city",
                    State = "SE",
                    Zip = "zip",
                    Address2 = "address2",
                    Country = "country",
                    Line1 = "line1",
                    Line2 = "line2",
                    PostalCode = "21029-1360",
                },
                Description = "description",
                Industry = new()
                {
                    Category = "category",
                    Mcc = "mcc",
                    Sector = "sector",
                },
                LegalName = "legal_name",
                Phone = "+46991022",
                SupportChannels = new()
                {
                    Email = "dev@stainless.com",
                    Phone = "+46991022",
                    Url = "https://example.com",
                },
                TaxID = "210297980",
                UseCase = "use_case",
            },
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",
        };

        AccountUpdateParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
