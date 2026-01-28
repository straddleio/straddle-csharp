using System;
using System.Net.Http;
using System.Text.Json;
using Straddle.Core;
using Straddle.Models.Embed.Accounts.CapabilityRequests;

namespace Straddle.Tests.Models.Embed.Accounts.CapabilityRequests;

public class CapabilityRequestCreateParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new CapabilityRequestCreateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Businesses = new(true),
            Charges = new()
            {
                DailyAmount = 0,
                Enable = true,
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            Individuals = new(true),
            Internet = new(true),
            Payouts = new()
            {
                DailyAmount = 0,
                Enable = true,
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            SignedAgreement = new(true),
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",
        };

        string expectedAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        Businesses expectedBusinesses = new(true);
        CapabilityRequestCreateParamsCharges expectedCharges = new()
        {
            DailyAmount = 0,
            Enable = true,
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };
        Individuals expectedIndividuals = new(true);
        Internet expectedInternet = new(true);
        CapabilityRequestCreateParamsPayouts expectedPayouts = new()
        {
            DailyAmount = 0,
            Enable = true,
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };
        SignedAgreement expectedSignedAgreement = new(true);
        string expectedCorrelationID = "correlation-id";
        string expectedIdempotencyKey = "xxxxxxxxxx";
        string expectedRequestID = "request-id";

        Assert.Equal(expectedAccountID, parameters.AccountID);
        Assert.Equal(expectedBusinesses, parameters.Businesses);
        Assert.Equal(expectedCharges, parameters.Charges);
        Assert.Equal(expectedIndividuals, parameters.Individuals);
        Assert.Equal(expectedInternet, parameters.Internet);
        Assert.Equal(expectedPayouts, parameters.Payouts);
        Assert.Equal(expectedSignedAgreement, parameters.SignedAgreement);
        Assert.Equal(expectedCorrelationID, parameters.CorrelationID);
        Assert.Equal(expectedIdempotencyKey, parameters.IdempotencyKey);
        Assert.Equal(expectedRequestID, parameters.RequestID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new CapabilityRequestCreateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        Assert.Null(parameters.Businesses);
        Assert.False(parameters.RawBodyData.ContainsKey("businesses"));
        Assert.Null(parameters.Charges);
        Assert.False(parameters.RawBodyData.ContainsKey("charges"));
        Assert.Null(parameters.Individuals);
        Assert.False(parameters.RawBodyData.ContainsKey("individuals"));
        Assert.Null(parameters.Internet);
        Assert.False(parameters.RawBodyData.ContainsKey("internet"));
        Assert.Null(parameters.Payouts);
        Assert.False(parameters.RawBodyData.ContainsKey("payouts"));
        Assert.Null(parameters.SignedAgreement);
        Assert.False(parameters.RawBodyData.ContainsKey("signed_agreement"));
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
        var parameters = new CapabilityRequestCreateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",

            // Null should be interpreted as omitted for these properties
            Businesses = null,
            Charges = null,
            Individuals = null,
            Internet = null,
            Payouts = null,
            SignedAgreement = null,
            CorrelationID = null,
            IdempotencyKey = null,
            RequestID = null,
        };

        Assert.Null(parameters.Businesses);
        Assert.False(parameters.RawBodyData.ContainsKey("businesses"));
        Assert.Null(parameters.Charges);
        Assert.False(parameters.RawBodyData.ContainsKey("charges"));
        Assert.Null(parameters.Individuals);
        Assert.False(parameters.RawBodyData.ContainsKey("individuals"));
        Assert.Null(parameters.Internet);
        Assert.False(parameters.RawBodyData.ContainsKey("internet"));
        Assert.Null(parameters.Payouts);
        Assert.False(parameters.RawBodyData.ContainsKey("payouts"));
        Assert.Null(parameters.SignedAgreement);
        Assert.False(parameters.RawBodyData.ContainsKey("signed_agreement"));
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
        CapabilityRequestCreateParams parameters = new()
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://sandbox.straddle.com/v1/accounts/182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e/capability_requests"
            ),
            url
        );
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        CapabilityRequestCreateParams parameters = new()
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
        var parameters = new CapabilityRequestCreateParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Businesses = new(true),
            Charges = new()
            {
                DailyAmount = 0,
                Enable = true,
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            Individuals = new(true),
            Internet = new(true),
            Payouts = new()
            {
                DailyAmount = 0,
                Enable = true,
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            SignedAgreement = new(true),
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",
        };

        CapabilityRequestCreateParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class BusinessesTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Businesses { Enable = true };

        bool expectedEnable = true;

        Assert.Equal(expectedEnable, model.Enable);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Businesses { Enable = true };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Businesses>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Businesses { Enable = true };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Businesses>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        bool expectedEnable = true;

        Assert.Equal(expectedEnable, deserialized.Enable);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Businesses { Enable = true };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Businesses { Enable = true };

        Businesses copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class CapabilityRequestCreateParamsChargesTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CapabilityRequestCreateParamsCharges
        {
            DailyAmount = 0,
            Enable = true,
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        double expectedDailyAmount = 0;
        bool expectedEnable = true;
        double expectedMaxAmount = 0;
        double expectedMonthlyAmount = 0;
        int expectedMonthlyCount = 0;

        Assert.Equal(expectedDailyAmount, model.DailyAmount);
        Assert.Equal(expectedEnable, model.Enable);
        Assert.Equal(expectedMaxAmount, model.MaxAmount);
        Assert.Equal(expectedMonthlyAmount, model.MonthlyAmount);
        Assert.Equal(expectedMonthlyCount, model.MonthlyCount);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CapabilityRequestCreateParamsCharges
        {
            DailyAmount = 0,
            Enable = true,
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CapabilityRequestCreateParamsCharges>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CapabilityRequestCreateParamsCharges
        {
            DailyAmount = 0,
            Enable = true,
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CapabilityRequestCreateParamsCharges>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        double expectedDailyAmount = 0;
        bool expectedEnable = true;
        double expectedMaxAmount = 0;
        double expectedMonthlyAmount = 0;
        int expectedMonthlyCount = 0;

        Assert.Equal(expectedDailyAmount, deserialized.DailyAmount);
        Assert.Equal(expectedEnable, deserialized.Enable);
        Assert.Equal(expectedMaxAmount, deserialized.MaxAmount);
        Assert.Equal(expectedMonthlyAmount, deserialized.MonthlyAmount);
        Assert.Equal(expectedMonthlyCount, deserialized.MonthlyCount);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CapabilityRequestCreateParamsCharges
        {
            DailyAmount = 0,
            Enable = true,
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new CapabilityRequestCreateParamsCharges
        {
            DailyAmount = 0,
            Enable = true,
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        CapabilityRequestCreateParamsCharges copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class IndividualsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Individuals { Enable = true };

        bool expectedEnable = true;

        Assert.Equal(expectedEnable, model.Enable);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Individuals { Enable = true };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Individuals>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Individuals { Enable = true };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Individuals>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        bool expectedEnable = true;

        Assert.Equal(expectedEnable, deserialized.Enable);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Individuals { Enable = true };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Individuals { Enable = true };

        Individuals copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class InternetTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Internet { Enable = true };

        bool expectedEnable = true;

        Assert.Equal(expectedEnable, model.Enable);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Internet { Enable = true };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Internet>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Internet { Enable = true };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Internet>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        bool expectedEnable = true;

        Assert.Equal(expectedEnable, deserialized.Enable);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Internet { Enable = true };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Internet { Enable = true };

        Internet copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class CapabilityRequestCreateParamsPayoutsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CapabilityRequestCreateParamsPayouts
        {
            DailyAmount = 0,
            Enable = true,
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        double expectedDailyAmount = 0;
        bool expectedEnable = true;
        double expectedMaxAmount = 0;
        double expectedMonthlyAmount = 0;
        int expectedMonthlyCount = 0;

        Assert.Equal(expectedDailyAmount, model.DailyAmount);
        Assert.Equal(expectedEnable, model.Enable);
        Assert.Equal(expectedMaxAmount, model.MaxAmount);
        Assert.Equal(expectedMonthlyAmount, model.MonthlyAmount);
        Assert.Equal(expectedMonthlyCount, model.MonthlyCount);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CapabilityRequestCreateParamsPayouts
        {
            DailyAmount = 0,
            Enable = true,
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CapabilityRequestCreateParamsPayouts>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CapabilityRequestCreateParamsPayouts
        {
            DailyAmount = 0,
            Enable = true,
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CapabilityRequestCreateParamsPayouts>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        double expectedDailyAmount = 0;
        bool expectedEnable = true;
        double expectedMaxAmount = 0;
        double expectedMonthlyAmount = 0;
        int expectedMonthlyCount = 0;

        Assert.Equal(expectedDailyAmount, deserialized.DailyAmount);
        Assert.Equal(expectedEnable, deserialized.Enable);
        Assert.Equal(expectedMaxAmount, deserialized.MaxAmount);
        Assert.Equal(expectedMonthlyAmount, deserialized.MonthlyAmount);
        Assert.Equal(expectedMonthlyCount, deserialized.MonthlyCount);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CapabilityRequestCreateParamsPayouts
        {
            DailyAmount = 0,
            Enable = true,
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new CapabilityRequestCreateParamsPayouts
        {
            DailyAmount = 0,
            Enable = true,
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        CapabilityRequestCreateParamsPayouts copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class SignedAgreementTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new SignedAgreement { Enable = true };

        bool expectedEnable = true;

        Assert.Equal(expectedEnable, model.Enable);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new SignedAgreement { Enable = true };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<SignedAgreement>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new SignedAgreement { Enable = true };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<SignedAgreement>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        bool expectedEnable = true;

        Assert.Equal(expectedEnable, deserialized.Enable);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new SignedAgreement { Enable = true };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new SignedAgreement { Enable = true };

        SignedAgreement copied = new(model);

        Assert.Equal(model, copied);
    }
}
