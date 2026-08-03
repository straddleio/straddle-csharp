using System;
using System.Net.Http;
using System.Text;
using Straddle.Core;
using Straddle.Models.Payouts;

namespace Straddle.Tests.Models.Payouts;

public class PayoutUploadAuthorizationDocumentParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        BinaryContent file = Encoding.UTF8.GetBytes("Example data");

        var parameters = new PayoutUploadAuthorizationDocumentParams
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            File = file,
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        BinaryContent expectedFile = file;
        string expectedCorrelationID = "Correlation-Id";
        string expectedIdempotencyKey = "xxxxxxxxxx";
        string expectedRequestID = "Request-Id";
        string expectedStraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";

        Assert.Equal(expectedID, parameters.ID);
        Assert.Equal(expectedFile, parameters.File);
        Assert.Equal(expectedCorrelationID, parameters.CorrelationID);
        Assert.Equal(expectedIdempotencyKey, parameters.IdempotencyKey);
        Assert.Equal(expectedRequestID, parameters.RequestID);
        Assert.Equal(expectedStraddleAccountID, parameters.StraddleAccountID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        BinaryContent file = Encoding.UTF8.GetBytes("Example data");

        var parameters = new PayoutUploadAuthorizationDocumentParams
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            File = file,
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
        BinaryContent file = Encoding.UTF8.GetBytes("Example data");

        var parameters = new PayoutUploadAuthorizationDocumentParams
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            File = file,

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
    public void Url_Works()
    {
        PayoutUploadAuthorizationDocumentParams parameters = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            File = Encoding.UTF8.GetBytes("Example data"),
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri(
                    "https://sandbox.straddle.com/v1/payouts/182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e/authorization"
                ),
                url
            )
        );
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        PayoutUploadAuthorizationDocumentParams parameters = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            File = Encoding.UTF8.GetBytes("Example data"),
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
        var parameters = new PayoutUploadAuthorizationDocumentParams
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            File = Encoding.UTF8.GetBytes("Example data"),
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        PayoutUploadAuthorizationDocumentParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
