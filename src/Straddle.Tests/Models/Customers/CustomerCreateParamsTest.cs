using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Customers = Straddle.Models.Customers;

namespace Straddle.Tests.Models.Customers;

public class CustomerCreateParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new Customers::CustomerCreateParams
        {
            Device = new("192.168.1.1"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Type = Customers::Type.Individual,
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new Customers::IndividualComplianceProfile()
            {
                Dob = "1969-04-20",
                Ssn = "123-45-6789",
            },
            Config = new()
            {
                ProcessingMethod = Customers::ProcessingMethod.Inline,
                SandboxOutcome = Customers::SandboxOutcome.Standard,
            },
            ExternalID = "customer_123",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        Customers::DeviceUnmaskedV1 expectedDevice = new("192.168.1.1");
        string expectedEmail = "ron.swanson@pawnee.com";
        string expectedName = "Ron Swanson";
        string expectedPhone = "+12128675309";
        ApiEnum<string, Customers::Type> expectedType = Customers::Type.Individual;
        Customers::CustomerAddressV1 expectedAddress = new()
        {
            Address1 = "123 Main St",
            City = "Anytown",
            State = "CA",
            Zip = "12345",
            Address2 = "Apt 1",
        };
        Customers::ComplianceProfile expectedComplianceProfile =
            new Customers::IndividualComplianceProfile()
            {
                Dob = "1969-04-20",
                Ssn = "123-45-6789",
            };
        Customers::Config expectedConfig = new()
        {
            ProcessingMethod = Customers::ProcessingMethod.Inline,
            SandboxOutcome = Customers::SandboxOutcome.Standard,
        };
        string expectedExternalID = "customer_123";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        string expectedCorrelationID = "Correlation-Id";
        string expectedIdempotencyKey = "xxxxxxxxxx";
        string expectedRequestID = "Request-Id";
        string expectedStraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";

        Assert.Equal(expectedDevice, parameters.Device);
        Assert.Equal(expectedEmail, parameters.Email);
        Assert.Equal(expectedName, parameters.Name);
        Assert.Equal(expectedPhone, parameters.Phone);
        Assert.Equal(expectedType, parameters.Type);
        Assert.Equal(expectedAddress, parameters.Address);
        Assert.Equal(expectedComplianceProfile, parameters.ComplianceProfile);
        Assert.Equal(expectedConfig, parameters.Config);
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
        Assert.Equal(expectedStraddleAccountID, parameters.StraddleAccountID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new Customers::CustomerCreateParams
        {
            Device = new("192.168.1.1"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Type = Customers::Type.Individual,
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new Customers::IndividualComplianceProfile()
            {
                Dob = "1969-04-20",
                Ssn = "123-45-6789",
            },
            ExternalID = "customer_123",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
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
        var parameters = new Customers::CustomerCreateParams
        {
            Device = new("192.168.1.1"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Type = Customers::Type.Individual,
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new Customers::IndividualComplianceProfile()
            {
                Dob = "1969-04-20",
                Ssn = "123-45-6789",
            },
            ExternalID = "customer_123",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },

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
        var parameters = new Customers::CustomerCreateParams
        {
            Device = new("192.168.1.1"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Type = Customers::Type.Individual,
            Config = new()
            {
                ProcessingMethod = Customers::ProcessingMethod.Inline,
                SandboxOutcome = Customers::SandboxOutcome.Standard,
            },
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        Assert.Null(parameters.Address);
        Assert.False(parameters.RawBodyData.ContainsKey("address"));
        Assert.Null(parameters.ComplianceProfile);
        Assert.False(parameters.RawBodyData.ContainsKey("compliance_profile"));
        Assert.Null(parameters.ExternalID);
        Assert.False(parameters.RawBodyData.ContainsKey("external_id"));
        Assert.Null(parameters.Metadata);
        Assert.False(parameters.RawBodyData.ContainsKey("metadata"));
    }

    [Fact]
    public void OptionalNullableParamsSetToNullAreSetToNull_Works()
    {
        var parameters = new Customers::CustomerCreateParams
        {
            Device = new("192.168.1.1"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Type = Customers::Type.Individual,
            Config = new()
            {
                ProcessingMethod = Customers::ProcessingMethod.Inline,
                SandboxOutcome = Customers::SandboxOutcome.Standard,
            },
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",

            Address = null,
            ComplianceProfile = null,
            ExternalID = null,
            Metadata = null,
        };

        Assert.Null(parameters.Address);
        Assert.True(parameters.RawBodyData.ContainsKey("address"));
        Assert.Null(parameters.ComplianceProfile);
        Assert.True(parameters.RawBodyData.ContainsKey("compliance_profile"));
        Assert.Null(parameters.ExternalID);
        Assert.True(parameters.RawBodyData.ContainsKey("external_id"));
        Assert.Null(parameters.Metadata);
        Assert.True(parameters.RawBodyData.ContainsKey("metadata"));
    }

    [Fact]
    public void Url_Works()
    {
        Customers::CustomerCreateParams parameters = new()
        {
            Device = new("192.168.1.1"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Type = Customers::Type.Individual,
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(new Uri("https://sandbox.straddle.com/v1/customers"), url);
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        Customers::CustomerCreateParams parameters = new()
        {
            Device = new("192.168.1.1"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Type = Customers::Type.Individual,
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
        var parameters = new Customers::CustomerCreateParams
        {
            Device = new("192.168.1.1"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Type = Customers::Type.Individual,
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new Customers::IndividualComplianceProfile()
            {
                Dob = "1969-04-20",
                Ssn = "123-45-6789",
            },
            Config = new()
            {
                ProcessingMethod = Customers::ProcessingMethod.Inline,
                SandboxOutcome = Customers::SandboxOutcome.Standard,
            },
            ExternalID = "customer_123",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        Customers::CustomerCreateParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class TypeTest : TestBase
{
    [Theory]
    [InlineData(Customers::Type.Individual)]
    [InlineData(Customers::Type.Business)]
    [InlineData(Customers::Type.Individual1)]
    [InlineData(Customers::Type.Business1)]
    public void Validation_Works(Customers::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Customers::Type> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Customers::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Customers::Type.Individual)]
    [InlineData(Customers::Type.Business)]
    [InlineData(Customers::Type.Individual1)]
    [InlineData(Customers::Type.Business1)]
    public void SerializationRoundtrip_Works(Customers::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Customers::Type> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Customers::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Customers::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Customers::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class ComplianceProfileTest : TestBase
{
    [Fact]
    public void IndividualValidationWorks()
    {
        Customers::ComplianceProfile value = new Customers::IndividualComplianceProfile()
        {
            Dob = "1969-04-20",
            Ssn = "123-45-6789",
        };
        value.Validate();
    }

    [Fact]
    public void BusinessValidationWorks()
    {
        Customers::ComplianceProfile value = new Customers::BusinessComplianceProfile()
        {
            Ein = "12-3456789",
            LegalBusinessName = "Acme Corp LLC",
            Representatives =
            [
                new()
                {
                    Name = "name",
                    Email = "email",
                    Phone = "phone",
                },
            ],
            Website = "https://example.com",
        };
        value.Validate();
    }

    [Fact]
    public void IndividualSerializationRoundtripWorks()
    {
        Customers::ComplianceProfile value = new Customers::IndividualComplianceProfile()
        {
            Dob = "1969-04-20",
            Ssn = "123-45-6789",
        };
        string element = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Customers::ComplianceProfile>(
            element,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void BusinessSerializationRoundtripWorks()
    {
        Customers::ComplianceProfile value = new Customers::BusinessComplianceProfile()
        {
            Ein = "12-3456789",
            LegalBusinessName = "Acme Corp LLC",
            Representatives =
            [
                new()
                {
                    Name = "name",
                    Email = "email",
                    Phone = "phone",
                },
            ],
            Website = "https://example.com",
        };
        string element = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Customers::ComplianceProfile>(
            element,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class IndividualComplianceProfileTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Customers::IndividualComplianceProfile
        {
            Dob = "1969-04-20",
            Ssn = "123-45-6789",
        };

        string expectedDob = "1969-04-20";
        string expectedSsn = "123-45-6789";

        Assert.Equal(expectedDob, model.Dob);
        Assert.Equal(expectedSsn, model.Ssn);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Customers::IndividualComplianceProfile
        {
            Dob = "1969-04-20",
            Ssn = "123-45-6789",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Customers::IndividualComplianceProfile>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Customers::IndividualComplianceProfile
        {
            Dob = "1969-04-20",
            Ssn = "123-45-6789",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Customers::IndividualComplianceProfile>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedDob = "1969-04-20";
        string expectedSsn = "123-45-6789";

        Assert.Equal(expectedDob, deserialized.Dob);
        Assert.Equal(expectedSsn, deserialized.Ssn);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Customers::IndividualComplianceProfile
        {
            Dob = "1969-04-20",
            Ssn = "123-45-6789",
        };

        model.Validate();
    }
}

public class BusinessComplianceProfileTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Customers::BusinessComplianceProfile
        {
            Ein = "12-3456789",
            LegalBusinessName = "Acme Corp LLC",
            Representatives =
            [
                new()
                {
                    Name = "name",
                    Email = "email",
                    Phone = "phone",
                },
            ],
            Website = "https://example.com",
        };

        string expectedEin = "12-3456789";
        string expectedLegalBusinessName = "Acme Corp LLC";
        List<Customers::Representative> expectedRepresentatives =
        [
            new()
            {
                Name = "name",
                Email = "email",
                Phone = "phone",
            },
        ];
        string expectedWebsite = "https://example.com";

        Assert.Equal(expectedEin, model.Ein);
        Assert.Equal(expectedLegalBusinessName, model.LegalBusinessName);
        Assert.NotNull(model.Representatives);
        Assert.Equal(expectedRepresentatives.Count, model.Representatives.Count);
        for (int i = 0; i < expectedRepresentatives.Count; i++)
        {
            Assert.Equal(expectedRepresentatives[i], model.Representatives[i]);
        }
        Assert.Equal(expectedWebsite, model.Website);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Customers::BusinessComplianceProfile
        {
            Ein = "12-3456789",
            LegalBusinessName = "Acme Corp LLC",
            Representatives =
            [
                new()
                {
                    Name = "name",
                    Email = "email",
                    Phone = "phone",
                },
            ],
            Website = "https://example.com",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Customers::BusinessComplianceProfile>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Customers::BusinessComplianceProfile
        {
            Ein = "12-3456789",
            LegalBusinessName = "Acme Corp LLC",
            Representatives =
            [
                new()
                {
                    Name = "name",
                    Email = "email",
                    Phone = "phone",
                },
            ],
            Website = "https://example.com",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Customers::BusinessComplianceProfile>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedEin = "12-3456789";
        string expectedLegalBusinessName = "Acme Corp LLC";
        List<Customers::Representative> expectedRepresentatives =
        [
            new()
            {
                Name = "name",
                Email = "email",
                Phone = "phone",
            },
        ];
        string expectedWebsite = "https://example.com";

        Assert.Equal(expectedEin, deserialized.Ein);
        Assert.Equal(expectedLegalBusinessName, deserialized.LegalBusinessName);
        Assert.NotNull(deserialized.Representatives);
        Assert.Equal(expectedRepresentatives.Count, deserialized.Representatives.Count);
        for (int i = 0; i < expectedRepresentatives.Count; i++)
        {
            Assert.Equal(expectedRepresentatives[i], deserialized.Representatives[i]);
        }
        Assert.Equal(expectedWebsite, deserialized.Website);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Customers::BusinessComplianceProfile
        {
            Ein = "12-3456789",
            LegalBusinessName = "Acme Corp LLC",
            Representatives =
            [
                new()
                {
                    Name = "name",
                    Email = "email",
                    Phone = "phone",
                },
            ],
            Website = "https://example.com",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Customers::BusinessComplianceProfile
        {
            Ein = "12-3456789",
            LegalBusinessName = "Acme Corp LLC",
        };

        Assert.Null(model.Representatives);
        Assert.False(model.RawData.ContainsKey("representatives"));
        Assert.Null(model.Website);
        Assert.False(model.RawData.ContainsKey("website"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new Customers::BusinessComplianceProfile
        {
            Ein = "12-3456789",
            LegalBusinessName = "Acme Corp LLC",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Customers::BusinessComplianceProfile
        {
            Ein = "12-3456789",
            LegalBusinessName = "Acme Corp LLC",

            Representatives = null,
            Website = null,
        };

        Assert.Null(model.Representatives);
        Assert.True(model.RawData.ContainsKey("representatives"));
        Assert.Null(model.Website);
        Assert.True(model.RawData.ContainsKey("website"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Customers::BusinessComplianceProfile
        {
            Ein = "12-3456789",
            LegalBusinessName = "Acme Corp LLC",

            Representatives = null,
            Website = null,
        };

        model.Validate();
    }
}

public class RepresentativeTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Customers::Representative
        {
            Name = "name",
            Email = "email",
            Phone = "phone",
        };

        string expectedName = "name";
        string expectedEmail = "email";
        string expectedPhone = "phone";

        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedEmail, model.Email);
        Assert.Equal(expectedPhone, model.Phone);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Customers::Representative
        {
            Name = "name",
            Email = "email",
            Phone = "phone",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Customers::Representative>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Customers::Representative
        {
            Name = "name",
            Email = "email",
            Phone = "phone",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Customers::Representative>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedName = "name";
        string expectedEmail = "email";
        string expectedPhone = "phone";

        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedEmail, deserialized.Email);
        Assert.Equal(expectedPhone, deserialized.Phone);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Customers::Representative
        {
            Name = "name",
            Email = "email",
            Phone = "phone",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Customers::Representative { Name = "name" };

        Assert.Null(model.Email);
        Assert.False(model.RawData.ContainsKey("email"));
        Assert.Null(model.Phone);
        Assert.False(model.RawData.ContainsKey("phone"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new Customers::Representative { Name = "name" };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Customers::Representative
        {
            Name = "name",

            Email = null,
            Phone = null,
        };

        Assert.Null(model.Email);
        Assert.True(model.RawData.ContainsKey("email"));
        Assert.Null(model.Phone);
        Assert.True(model.RawData.ContainsKey("phone"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Customers::Representative
        {
            Name = "name",

            Email = null,
            Phone = null,
        };

        model.Validate();
    }
}

public class ConfigTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Customers::Config
        {
            ProcessingMethod = Customers::ProcessingMethod.Inline,
            SandboxOutcome = Customers::SandboxOutcome.Standard,
        };

        ApiEnum<string, Customers::ProcessingMethod> expectedProcessingMethod =
            Customers::ProcessingMethod.Inline;
        ApiEnum<string, Customers::SandboxOutcome> expectedSandboxOutcome =
            Customers::SandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, model.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, model.SandboxOutcome);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Customers::Config
        {
            ProcessingMethod = Customers::ProcessingMethod.Inline,
            SandboxOutcome = Customers::SandboxOutcome.Standard,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Customers::Config>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Customers::Config
        {
            ProcessingMethod = Customers::ProcessingMethod.Inline,
            SandboxOutcome = Customers::SandboxOutcome.Standard,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Customers::Config>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, Customers::ProcessingMethod> expectedProcessingMethod =
            Customers::ProcessingMethod.Inline;
        ApiEnum<string, Customers::SandboxOutcome> expectedSandboxOutcome =
            Customers::SandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, deserialized.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, deserialized.SandboxOutcome);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Customers::Config
        {
            ProcessingMethod = Customers::ProcessingMethod.Inline,
            SandboxOutcome = Customers::SandboxOutcome.Standard,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Customers::Config { };

        Assert.Null(model.ProcessingMethod);
        Assert.False(model.RawData.ContainsKey("processing_method"));
        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Customers::Config { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Customers::Config
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
        var model = new Customers::Config
        {
            // Null should be interpreted as omitted for these properties
            ProcessingMethod = null,
            SandboxOutcome = null,
        };

        model.Validate();
    }
}

public class ProcessingMethodTest : TestBase
{
    [Theory]
    [InlineData(Customers::ProcessingMethod.Inline)]
    [InlineData(Customers::ProcessingMethod.Background)]
    [InlineData(Customers::ProcessingMethod.Skip)]
    public void Validation_Works(Customers::ProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Customers::ProcessingMethod> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Customers::ProcessingMethod>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Customers::ProcessingMethod.Inline)]
    [InlineData(Customers::ProcessingMethod.Background)]
    [InlineData(Customers::ProcessingMethod.Skip)]
    public void SerializationRoundtrip_Works(Customers::ProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Customers::ProcessingMethod> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Customers::ProcessingMethod>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Customers::ProcessingMethod>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Customers::ProcessingMethod>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class SandboxOutcomeTest : TestBase
{
    [Theory]
    [InlineData(Customers::SandboxOutcome.Standard)]
    [InlineData(Customers::SandboxOutcome.Verified)]
    [InlineData(Customers::SandboxOutcome.Rejected)]
    [InlineData(Customers::SandboxOutcome.Review)]
    public void Validation_Works(Customers::SandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Customers::SandboxOutcome> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Customers::SandboxOutcome>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Customers::SandboxOutcome.Standard)]
    [InlineData(Customers::SandboxOutcome.Verified)]
    [InlineData(Customers::SandboxOutcome.Rejected)]
    [InlineData(Customers::SandboxOutcome.Review)]
    public void SerializationRoundtrip_Works(Customers::SandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Customers::SandboxOutcome> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Customers::SandboxOutcome>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Customers::SandboxOutcome>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Customers::SandboxOutcome>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
