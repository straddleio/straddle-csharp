using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using Straddle.Core;
using Straddle.Models.Embed.Representatives;

namespace Straddle.Tests.Models.Embed.Representatives;

public class RepresentativeUpdateParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new RepresentativeUpdateParams
        {
            RepresentativeID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Dob = "1980-01-01",
            Email = "ron.swanson@pawnee.com",
            FirstName = "Ron",
            LastName = "Swanson",
            MobileNumber = "+12128675309",
            Relationship = new()
            {
                Control = true,
                Owner = true,
                Primary = true,
                PercentOwnership = 0,
                Title = "title",
            },
            SsnLast4 = "1234",
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",
        };

        string expectedRepresentativeID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        string expectedDob = "1980-01-01";
        string expectedEmail = "ron.swanson@pawnee.com";
        string expectedFirstName = "Ron";
        string expectedLastName = "Swanson";
        string expectedMobileNumber = "+12128675309";
        RepresentativeUpdateParamsRelationship expectedRelationship = new()
        {
            Control = true,
            Owner = true,
            Primary = true,
            PercentOwnership = 0,
            Title = "title",
        };
        string expectedSsnLast4 = "1234";
        string expectedExternalID = "external_id";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        string expectedCorrelationID = "correlation-id";
        string expectedIdempotencyKey = "xxxxxxxxxx";
        string expectedRequestID = "request-id";

        Assert.Equal(expectedRepresentativeID, parameters.RepresentativeID);
        Assert.Equal(expectedDob, parameters.Dob);
        Assert.Equal(expectedEmail, parameters.Email);
        Assert.Equal(expectedFirstName, parameters.FirstName);
        Assert.Equal(expectedLastName, parameters.LastName);
        Assert.Equal(expectedMobileNumber, parameters.MobileNumber);
        Assert.Equal(expectedRelationship, parameters.Relationship);
        Assert.Equal(expectedSsnLast4, parameters.SsnLast4);
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
        var parameters = new RepresentativeUpdateParams
        {
            RepresentativeID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Dob = "1980-01-01",
            Email = "ron.swanson@pawnee.com",
            FirstName = "Ron",
            LastName = "Swanson",
            MobileNumber = "+12128675309",
            Relationship = new()
            {
                Control = true,
                Owner = true,
                Primary = true,
                PercentOwnership = 0,
                Title = "title",
            },
            SsnLast4 = "1234",
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
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
        var parameters = new RepresentativeUpdateParams
        {
            RepresentativeID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Dob = "1980-01-01",
            Email = "ron.swanson@pawnee.com",
            FirstName = "Ron",
            LastName = "Swanson",
            MobileNumber = "+12128675309",
            Relationship = new()
            {
                Control = true,
                Owner = true,
                Primary = true,
                PercentOwnership = 0,
                Title = "title",
            },
            SsnLast4 = "1234",
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },

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
        var parameters = new RepresentativeUpdateParams
        {
            RepresentativeID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Dob = "1980-01-01",
            Email = "ron.swanson@pawnee.com",
            FirstName = "Ron",
            LastName = "Swanson",
            MobileNumber = "+12128675309",
            Relationship = new()
            {
                Control = true,
                Owner = true,
                Primary = true,
                PercentOwnership = 0,
                Title = "title",
            },
            SsnLast4 = "1234",
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
        var parameters = new RepresentativeUpdateParams
        {
            RepresentativeID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Dob = "1980-01-01",
            Email = "ron.swanson@pawnee.com",
            FirstName = "Ron",
            LastName = "Swanson",
            MobileNumber = "+12128675309",
            Relationship = new()
            {
                Control = true,
                Owner = true,
                Primary = true,
                PercentOwnership = 0,
                Title = "title",
            },
            SsnLast4 = "1234",
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
        RepresentativeUpdateParams parameters = new()
        {
            RepresentativeID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Dob = "1980-01-01",
            Email = "ron.swanson@pawnee.com",
            FirstName = "Ron",
            LastName = "Swanson",
            MobileNumber = "+12128675309",
            Relationship = new()
            {
                Control = true,
                Owner = true,
                Primary = true,
                PercentOwnership = 0,
                Title = "title",
            },
            SsnLast4 = "1234",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://sandbox.straddle.com/v1/representatives/182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"
            ),
            url
        );
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        RepresentativeUpdateParams parameters = new()
        {
            RepresentativeID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Dob = "1980-01-01",
            Email = "ron.swanson@pawnee.com",
            FirstName = "Ron",
            LastName = "Swanson",
            MobileNumber = "+12128675309",
            Relationship = new()
            {
                Control = true,
                Owner = true,
                Primary = true,
                PercentOwnership = 0,
                Title = "title",
            },
            SsnLast4 = "1234",
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
        var parameters = new RepresentativeUpdateParams
        {
            RepresentativeID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Dob = "1980-01-01",
            Email = "ron.swanson@pawnee.com",
            FirstName = "Ron",
            LastName = "Swanson",
            MobileNumber = "+12128675309",
            Relationship = new()
            {
                Control = true,
                Owner = true,
                Primary = true,
                PercentOwnership = 0,
                Title = "title",
            },
            SsnLast4 = "1234",
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            CorrelationID = "correlation-id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "request-id",
        };

        RepresentativeUpdateParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class RepresentativeUpdateParamsRelationshipTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new RepresentativeUpdateParamsRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,
            PercentOwnership = 0,
            Title = "title",
        };

        bool expectedControl = true;
        bool expectedOwner = true;
        bool expectedPrimary = true;
        double expectedPercentOwnership = 0;
        string expectedTitle = "title";

        Assert.Equal(expectedControl, model.Control);
        Assert.Equal(expectedOwner, model.Owner);
        Assert.Equal(expectedPrimary, model.Primary);
        Assert.Equal(expectedPercentOwnership, model.PercentOwnership);
        Assert.Equal(expectedTitle, model.Title);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new RepresentativeUpdateParamsRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,
            PercentOwnership = 0,
            Title = "title",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RepresentativeUpdateParamsRelationship>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RepresentativeUpdateParamsRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,
            PercentOwnership = 0,
            Title = "title",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RepresentativeUpdateParamsRelationship>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        bool expectedControl = true;
        bool expectedOwner = true;
        bool expectedPrimary = true;
        double expectedPercentOwnership = 0;
        string expectedTitle = "title";

        Assert.Equal(expectedControl, deserialized.Control);
        Assert.Equal(expectedOwner, deserialized.Owner);
        Assert.Equal(expectedPrimary, deserialized.Primary);
        Assert.Equal(expectedPercentOwnership, deserialized.PercentOwnership);
        Assert.Equal(expectedTitle, deserialized.Title);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new RepresentativeUpdateParamsRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,
            PercentOwnership = 0,
            Title = "title",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new RepresentativeUpdateParamsRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,
        };

        Assert.Null(model.PercentOwnership);
        Assert.False(model.RawData.ContainsKey("percent_ownership"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new RepresentativeUpdateParamsRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new RepresentativeUpdateParamsRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,

            PercentOwnership = null,
            Title = null,
        };

        Assert.Null(model.PercentOwnership);
        Assert.True(model.RawData.ContainsKey("percent_ownership"));
        Assert.Null(model.Title);
        Assert.True(model.RawData.ContainsKey("title"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new RepresentativeUpdateParamsRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,

            PercentOwnership = null,
            Title = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new RepresentativeUpdateParamsRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,
            PercentOwnership = 0,
            Title = "title",
        };

        RepresentativeUpdateParamsRelationship copied = new(model);

        Assert.Equal(model, copied);
    }
}
