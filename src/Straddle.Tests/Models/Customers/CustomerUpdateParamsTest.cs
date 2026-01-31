using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Customers;

namespace Straddle.Tests.Models.Customers;

public class CustomerUpdateParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new CustomerUpdateParams
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Device = new("192.168.1.1"),
            Email = "dev@stainless.com",
            Name = "name",
            Phone = "+46991022",
            Status = Status.Pending,
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile =
                new CustomerUpdateParamsComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "1969-04-20",
                    Ssn = "123-45-6789",
                },
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DeviceUnmaskedV1 expectedDevice = new("192.168.1.1");
        string expectedEmail = "dev@stainless.com";
        string expectedName = "name";
        string expectedPhone = "+46991022";
        ApiEnum<string, Status> expectedStatus = Status.Pending;
        CustomerAddressV1 expectedAddress = new()
        {
            Address1 = "123 Main St",
            City = "Anytown",
            State = "CA",
            Zip = "12345",
            Address2 = "Apt 1",
        };
        CustomerUpdateParamsComplianceProfile expectedComplianceProfile =
            new CustomerUpdateParamsComplianceProfileIndividualComplianceProfile()
            {
                Dob = "1969-04-20",
                Ssn = "123-45-6789",
            };
        string expectedExternalID = "external_id";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        string expectedCorrelationID = "Correlation-Id";
        string expectedIdempotencyKey = "xxxxxxxxxx";
        string expectedRequestID = "Request-Id";
        string expectedStraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";

        Assert.Equal(expectedID, parameters.ID);
        Assert.Equal(expectedDevice, parameters.Device);
        Assert.Equal(expectedEmail, parameters.Email);
        Assert.Equal(expectedName, parameters.Name);
        Assert.Equal(expectedPhone, parameters.Phone);
        Assert.Equal(expectedStatus, parameters.Status);
        Assert.Equal(expectedAddress, parameters.Address);
        Assert.Equal(expectedComplianceProfile, parameters.ComplianceProfile);
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
        var parameters = new CustomerUpdateParams
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Device = new("192.168.1.1"),
            Email = "dev@stainless.com",
            Name = "name",
            Phone = "+46991022",
            Status = Status.Pending,
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile =
                new CustomerUpdateParamsComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "1969-04-20",
                    Ssn = "123-45-6789",
                },
            ExternalID = "external_id",
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
        var parameters = new CustomerUpdateParams
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Device = new("192.168.1.1"),
            Email = "dev@stainless.com",
            Name = "name",
            Phone = "+46991022",
            Status = Status.Pending,
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile =
                new CustomerUpdateParamsComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "1969-04-20",
                    Ssn = "123-45-6789",
                },
            ExternalID = "external_id",
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
        var parameters = new CustomerUpdateParams
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Device = new("192.168.1.1"),
            Email = "dev@stainless.com",
            Name = "name",
            Phone = "+46991022",
            Status = Status.Pending,
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
        var parameters = new CustomerUpdateParams
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Device = new("192.168.1.1"),
            Email = "dev@stainless.com",
            Name = "name",
            Phone = "+46991022",
            Status = Status.Pending,
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
        CustomerUpdateParams parameters = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Device = new("192.168.1.1"),
            Email = "dev@stainless.com",
            Name = "name",
            Phone = "+46991022",
            Status = Status.Pending,
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://sandbox.straddle.com/v1/customers/182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"
            ),
            url
        );
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        CustomerUpdateParams parameters = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Device = new("192.168.1.1"),
            Email = "dev@stainless.com",
            Name = "name",
            Phone = "+46991022",
            Status = Status.Pending,
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
        var parameters = new CustomerUpdateParams
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Device = new("192.168.1.1"),
            Email = "dev@stainless.com",
            Name = "name",
            Phone = "+46991022",
            Status = Status.Pending,
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile =
                new CustomerUpdateParamsComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "1969-04-20",
                    Ssn = "123-45-6789",
                },
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            CorrelationID = "Correlation-Id",
            IdempotencyKey = "xxxxxxxxxx",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        CustomerUpdateParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class StatusTest : TestBase
{
    [Theory]
    [InlineData(Status.Pending)]
    [InlineData(Status.Review)]
    [InlineData(Status.Verified)]
    [InlineData(Status.Inactive)]
    [InlineData(Status.Rejected)]
    public void Validation_Works(Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Status> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Status.Pending)]
    [InlineData(Status.Review)]
    [InlineData(Status.Verified)]
    [InlineData(Status.Inactive)]
    [InlineData(Status.Rejected)]
    public void SerializationRoundtrip_Works(Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Status> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class CustomerUpdateParamsComplianceProfileTest : TestBase
{
    [Fact]
    public void IndividualValidationWorks()
    {
        CustomerUpdateParamsComplianceProfile value =
            new CustomerUpdateParamsComplianceProfileIndividualComplianceProfile()
            {
                Dob = "1969-04-20",
                Ssn = "123-45-6789",
            };
        value.Validate();
    }

    [Fact]
    public void BusinessValidationWorks()
    {
        CustomerUpdateParamsComplianceProfile value =
            new CustomerUpdateParamsComplianceProfileBusinessComplianceProfile()
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
        CustomerUpdateParamsComplianceProfile value =
            new CustomerUpdateParamsComplianceProfileIndividualComplianceProfile()
            {
                Dob = "1969-04-20",
                Ssn = "123-45-6789",
            };
        string element = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerUpdateParamsComplianceProfile>(
            element,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void BusinessSerializationRoundtripWorks()
    {
        CustomerUpdateParamsComplianceProfile value =
            new CustomerUpdateParamsComplianceProfileBusinessComplianceProfile()
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
        var deserialized = JsonSerializer.Deserialize<CustomerUpdateParamsComplianceProfile>(
            element,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class CustomerUpdateParamsComplianceProfileIndividualComplianceProfileTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerUpdateParamsComplianceProfileIndividualComplianceProfile
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
        var model = new CustomerUpdateParamsComplianceProfileIndividualComplianceProfile
        {
            Dob = "1969-04-20",
            Ssn = "123-45-6789",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<CustomerUpdateParamsComplianceProfileIndividualComplianceProfile>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerUpdateParamsComplianceProfileIndividualComplianceProfile
        {
            Dob = "1969-04-20",
            Ssn = "123-45-6789",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<CustomerUpdateParamsComplianceProfileIndividualComplianceProfile>(
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
        var model = new CustomerUpdateParamsComplianceProfileIndividualComplianceProfile
        {
            Dob = "1969-04-20",
            Ssn = "123-45-6789",
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new CustomerUpdateParamsComplianceProfileIndividualComplianceProfile
        {
            Dob = "1969-04-20",
            Ssn = "123-45-6789",
        };

        CustomerUpdateParamsComplianceProfileIndividualComplianceProfile copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class CustomerUpdateParamsComplianceProfileBusinessComplianceProfileTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfile
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
        List<CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative> expectedRepresentatives =
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
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfile
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
        var deserialized =
            JsonSerializer.Deserialize<CustomerUpdateParamsComplianceProfileBusinessComplianceProfile>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfile
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
        var deserialized =
            JsonSerializer.Deserialize<CustomerUpdateParamsComplianceProfileBusinessComplianceProfile>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        string expectedEin = "12-3456789";
        string expectedLegalBusinessName = "Acme Corp LLC";
        List<CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative> expectedRepresentatives =
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
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfile
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
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfile
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
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfile
        {
            Ein = "12-3456789",
            LegalBusinessName = "Acme Corp LLC",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfile
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
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfile
        {
            Ein = "12-3456789",
            LegalBusinessName = "Acme Corp LLC",

            Representatives = null,
            Website = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfile
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

        CustomerUpdateParamsComplianceProfileBusinessComplianceProfile copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentativeTest
    : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative
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
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative
        {
            Name = "name",
            Email = "email",
            Phone = "phone",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative
        {
            Name = "name",
            Email = "email",
            Phone = "phone",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative>(
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
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative
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
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative
        {
            Name = "name",
        };

        Assert.Null(model.Email);
        Assert.False(model.RawData.ContainsKey("email"));
        Assert.Null(model.Phone);
        Assert.False(model.RawData.ContainsKey("phone"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative
        {
            Name = "name",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative
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
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative
        {
            Name = "name",

            Email = null,
            Phone = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative
        {
            Name = "name",
            Email = "email",
            Phone = "phone",
        };

        CustomerUpdateParamsComplianceProfileBusinessComplianceProfileRepresentative copied = new(
            model
        );

        Assert.Equal(model, copied);
    }
}
