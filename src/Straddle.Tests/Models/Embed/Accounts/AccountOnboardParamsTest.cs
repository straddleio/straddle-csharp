using System;
using System.Net.Http;
using Straddle.Models.Embed.Accounts;

namespace Straddle.Tests.Models.Embed.Accounts;

public class AccountOnboardParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new AccountOnboardParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            TermsOfService = new()
            {
                AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                AgreementType = AgreementType.Embedded,
                AgreementUrl = "agreement_url",
                AcceptedIP = "accepted_ip",
                AcceptedUserAgent = "accepted_user_agent",
            },
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",
        };

        string expectedAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        TermsOfServiceV1 expectedTermsOfService = new()
        {
            AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            AgreementType = AgreementType.Embedded,
            AgreementUrl = "agreement_url",
            AcceptedIP = "accepted_ip",
            AcceptedUserAgent = "accepted_user_agent",
        };
        string expectedCorrelationID = "correlation-id";
        string expectedIdempotencyKey = "xxxxxxxxxx";
        string expectedRequestID = "request-id";

        Assert.Equal(expectedAccountID, parameters.AccountID);
        Assert.Equal(expectedTermsOfService, parameters.TermsOfService);
        Assert.Equal(expectedCorrelationID, parameters.CorrelationID);
        Assert.Equal(expectedIdempotencyKey, parameters.IdempotencyKey);
        Assert.Equal(expectedRequestID, parameters.RequestID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new AccountOnboardParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            TermsOfService = new()
            {
                AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                AgreementType = AgreementType.Embedded,
                AgreementUrl = "agreement_url",
                AcceptedIP = "accepted_ip",
                AcceptedUserAgent = "accepted_user_agent",
            },
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
        var parameters = new AccountOnboardParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            TermsOfService = new()
            {
                AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                AgreementType = AgreementType.Embedded,
                AgreementUrl = "agreement_url",
                AcceptedIP = "accepted_ip",
                AcceptedUserAgent = "accepted_user_agent",
            },

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
    public void Url_Works()
    {
        AccountOnboardParams parameters = new()
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            TermsOfService = new()
            {
                AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                AgreementType = AgreementType.Embedded,
                AgreementUrl = "agreement_url",
                AcceptedIP = "accepted_ip",
                AcceptedUserAgent = "accepted_user_agent",
            },
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://sandbox.straddle.com/v1/accounts/182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e/onboard"
            ),
            url
        );
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        AccountOnboardParams parameters = new()
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            TermsOfService = new()
            {
                AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                AgreementType = AgreementType.Embedded,
                AgreementUrl = "agreement_url",
                AcceptedIP = "accepted_ip",
                AcceptedUserAgent = "accepted_user_agent",
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
        var parameters = new AccountOnboardParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            TermsOfService = new()
            {
                AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                AgreementType = AgreementType.Embedded,
                AgreementUrl = "agreement_url",
                AcceptedIP = "accepted_ip",
                AcceptedUserAgent = "accepted_user_agent",
            },
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",
        };

        AccountOnboardParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
