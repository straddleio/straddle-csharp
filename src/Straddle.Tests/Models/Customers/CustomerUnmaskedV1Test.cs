using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models;
using Straddle.Models.Customers;

namespace Straddle.Tests.Models.Customers;

public class CustomerUnmaskedV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerUnmaskedV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = CustomerUnmaskedV1DataStatus.Pending,
                Type = CustomerUnmaskedV1DataType.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile =
                    new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
                    {
                        Dob = "1969-04-20",
                        Ssn = "123-45-6789",
                    },
                Config = new()
                {
                    ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
                    SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
                },
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = CustomerUnmaskedV1ResponseType.Object,
        };

        CustomerUnmaskedV1Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerUnmaskedV1DataStatus.Pending,
            Type = CustomerUnmaskedV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile =
                new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "1969-04-20",
                    Ssn = "123-45-6789",
                },
            Config = new()
            {
                ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, CustomerUnmaskedV1ResponseType> expectedResponseType =
            CustomerUnmaskedV1ResponseType.Object;

        Assert.Equal(expectedData, model.Data);
        Assert.Equal(expectedMeta, model.Meta);
        Assert.Equal(expectedResponseType, model.ResponseType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CustomerUnmaskedV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = CustomerUnmaskedV1DataStatus.Pending,
                Type = CustomerUnmaskedV1DataType.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile =
                    new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
                    {
                        Dob = "1969-04-20",
                        Ssn = "123-45-6789",
                    },
                Config = new()
                {
                    ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
                    SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
                },
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = CustomerUnmaskedV1ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerUnmaskedV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerUnmaskedV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = CustomerUnmaskedV1DataStatus.Pending,
                Type = CustomerUnmaskedV1DataType.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile =
                    new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
                    {
                        Dob = "1969-04-20",
                        Ssn = "123-45-6789",
                    },
                Config = new()
                {
                    ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
                    SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
                },
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = CustomerUnmaskedV1ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerUnmaskedV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        CustomerUnmaskedV1Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerUnmaskedV1DataStatus.Pending,
            Type = CustomerUnmaskedV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile =
                new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "1969-04-20",
                    Ssn = "123-45-6789",
                },
            Config = new()
            {
                ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, CustomerUnmaskedV1ResponseType> expectedResponseType =
            CustomerUnmaskedV1ResponseType.Object;

        Assert.Equal(expectedData, deserialized.Data);
        Assert.Equal(expectedMeta, deserialized.Meta);
        Assert.Equal(expectedResponseType, deserialized.ResponseType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CustomerUnmaskedV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = CustomerUnmaskedV1DataStatus.Pending,
                Type = CustomerUnmaskedV1DataType.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile =
                    new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
                    {
                        Dob = "1969-04-20",
                        Ssn = "123-45-6789",
                    },
                Config = new()
                {
                    ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
                    SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
                },
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = CustomerUnmaskedV1ResponseType.Object,
        };

        model.Validate();
    }
}

public class CustomerUnmaskedV1DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerUnmaskedV1DataStatus.Pending,
            Type = CustomerUnmaskedV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile =
                new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "1969-04-20",
                    Ssn = "123-45-6789",
                },
            Config = new()
            {
                ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedEmail = "ron.swanson@pawnee.com";
        string expectedName = "Ron Swanson";
        string expectedPhone = "+12128675309";
        ApiEnum<string, CustomerUnmaskedV1DataStatus> expectedStatus =
            CustomerUnmaskedV1DataStatus.Pending;
        ApiEnum<string, CustomerUnmaskedV1DataType> expectedType =
            CustomerUnmaskedV1DataType.Individual;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        CustomerAddressV1 expectedAddress = new()
        {
            Address1 = "123 Main St",
            City = "Anytown",
            State = "CA",
            Zip = "12345",
            Address2 = "Apt 1",
        };
        CustomerUnmaskedV1DataComplianceProfile expectedComplianceProfile =
            new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "1969-04-20",
                Ssn = "123-45-6789",
            };
        CustomerUnmaskedV1DataConfig expectedConfig = new()
        {
            ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
        };
        DeviceUnmaskedV1 expectedDevice = new("192.168.1.1");
        string expectedExternalID = "external_id";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedEmail, model.Email);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedPhone, model.Phone);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
        Assert.Equal(expectedAddress, model.Address);
        Assert.Equal(expectedComplianceProfile, model.ComplianceProfile);
        Assert.Equal(expectedConfig, model.Config);
        Assert.Equal(expectedDevice, model.Device);
        Assert.Equal(expectedExternalID, model.ExternalID);
        Assert.NotNull(model.Metadata);
        Assert.Equal(expectedMetadata.Count, model.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(model.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Metadata[item.Key]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CustomerUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerUnmaskedV1DataStatus.Pending,
            Type = CustomerUnmaskedV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile =
                new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "1969-04-20",
                    Ssn = "123-45-6789",
                },
            Config = new()
            {
                ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerUnmaskedV1Data>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerUnmaskedV1DataStatus.Pending,
            Type = CustomerUnmaskedV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile =
                new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "1969-04-20",
                    Ssn = "123-45-6789",
                },
            Config = new()
            {
                ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerUnmaskedV1Data>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedEmail = "ron.swanson@pawnee.com";
        string expectedName = "Ron Swanson";
        string expectedPhone = "+12128675309";
        ApiEnum<string, CustomerUnmaskedV1DataStatus> expectedStatus =
            CustomerUnmaskedV1DataStatus.Pending;
        ApiEnum<string, CustomerUnmaskedV1DataType> expectedType =
            CustomerUnmaskedV1DataType.Individual;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        CustomerAddressV1 expectedAddress = new()
        {
            Address1 = "123 Main St",
            City = "Anytown",
            State = "CA",
            Zip = "12345",
            Address2 = "Apt 1",
        };
        CustomerUnmaskedV1DataComplianceProfile expectedComplianceProfile =
            new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "1969-04-20",
                Ssn = "123-45-6789",
            };
        CustomerUnmaskedV1DataConfig expectedConfig = new()
        {
            ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
        };
        DeviceUnmaskedV1 expectedDevice = new("192.168.1.1");
        string expectedExternalID = "external_id";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedEmail, deserialized.Email);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedPhone, deserialized.Phone);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
        Assert.Equal(expectedAddress, deserialized.Address);
        Assert.Equal(expectedComplianceProfile, deserialized.ComplianceProfile);
        Assert.Equal(expectedConfig, deserialized.Config);
        Assert.Equal(expectedDevice, deserialized.Device);
        Assert.Equal(expectedExternalID, deserialized.ExternalID);
        Assert.NotNull(deserialized.Metadata);
        Assert.Equal(expectedMetadata.Count, deserialized.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(deserialized.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Metadata[item.Key]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CustomerUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerUnmaskedV1DataStatus.Pending,
            Type = CustomerUnmaskedV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile =
                new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "1969-04-20",
                    Ssn = "123-45-6789",
                },
            Config = new()
            {
                ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new CustomerUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerUnmaskedV1DataStatus.Pending,
            Type = CustomerUnmaskedV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile =
                new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "1969-04-20",
                    Ssn = "123-45-6789",
                },
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        Assert.Null(model.Config);
        Assert.False(model.RawData.ContainsKey("config"));
        Assert.Null(model.Device);
        Assert.False(model.RawData.ContainsKey("device"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new CustomerUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerUnmaskedV1DataStatus.Pending,
            Type = CustomerUnmaskedV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile =
                new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "1969-04-20",
                    Ssn = "123-45-6789",
                },
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new CustomerUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerUnmaskedV1DataStatus.Pending,
            Type = CustomerUnmaskedV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile =
                new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "1969-04-20",
                    Ssn = "123-45-6789",
                },
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },

            // Null should be interpreted as omitted for these properties
            Config = null,
            Device = null,
        };

        Assert.Null(model.Config);
        Assert.False(model.RawData.ContainsKey("config"));
        Assert.Null(model.Device);
        Assert.False(model.RawData.ContainsKey("device"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new CustomerUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerUnmaskedV1DataStatus.Pending,
            Type = CustomerUnmaskedV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile =
                new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "1969-04-20",
                    Ssn = "123-45-6789",
                },
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },

            // Null should be interpreted as omitted for these properties
            Config = null,
            Device = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new CustomerUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerUnmaskedV1DataStatus.Pending,
            Type = CustomerUnmaskedV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Config = new()
            {
                ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
        };

        Assert.Null(model.Address);
        Assert.False(model.RawData.ContainsKey("address"));
        Assert.Null(model.ComplianceProfile);
        Assert.False(model.RawData.ContainsKey("compliance_profile"));
        Assert.Null(model.ExternalID);
        Assert.False(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.Metadata);
        Assert.False(model.RawData.ContainsKey("metadata"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new CustomerUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerUnmaskedV1DataStatus.Pending,
            Type = CustomerUnmaskedV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Config = new()
            {
                ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new CustomerUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerUnmaskedV1DataStatus.Pending,
            Type = CustomerUnmaskedV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Config = new()
            {
                ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),

            Address = null,
            ComplianceProfile = null,
            ExternalID = null,
            Metadata = null,
        };

        Assert.Null(model.Address);
        Assert.True(model.RawData.ContainsKey("address"));
        Assert.Null(model.ComplianceProfile);
        Assert.True(model.RawData.ContainsKey("compliance_profile"));
        Assert.Null(model.ExternalID);
        Assert.True(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.Metadata);
        Assert.True(model.RawData.ContainsKey("metadata"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new CustomerUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerUnmaskedV1DataStatus.Pending,
            Type = CustomerUnmaskedV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Config = new()
            {
                ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),

            Address = null,
            ComplianceProfile = null,
            ExternalID = null,
            Metadata = null,
        };

        model.Validate();
    }
}

public class CustomerUnmaskedV1DataStatusTest : TestBase
{
    [Theory]
    [InlineData(CustomerUnmaskedV1DataStatus.Pending)]
    [InlineData(CustomerUnmaskedV1DataStatus.Review)]
    [InlineData(CustomerUnmaskedV1DataStatus.Verified)]
    [InlineData(CustomerUnmaskedV1DataStatus.Inactive)]
    [InlineData(CustomerUnmaskedV1DataStatus.Rejected)]
    public void Validation_Works(CustomerUnmaskedV1DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerUnmaskedV1DataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerUnmaskedV1DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CustomerUnmaskedV1DataStatus.Pending)]
    [InlineData(CustomerUnmaskedV1DataStatus.Review)]
    [InlineData(CustomerUnmaskedV1DataStatus.Verified)]
    [InlineData(CustomerUnmaskedV1DataStatus.Inactive)]
    [InlineData(CustomerUnmaskedV1DataStatus.Rejected)]
    public void SerializationRoundtrip_Works(CustomerUnmaskedV1DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerUnmaskedV1DataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerUnmaskedV1DataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerUnmaskedV1DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerUnmaskedV1DataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class CustomerUnmaskedV1DataTypeTest : TestBase
{
    [Theory]
    [InlineData(CustomerUnmaskedV1DataType.Individual)]
    [InlineData(CustomerUnmaskedV1DataType.Business)]
    public void Validation_Works(CustomerUnmaskedV1DataType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerUnmaskedV1DataType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerUnmaskedV1DataType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CustomerUnmaskedV1DataType.Individual)]
    [InlineData(CustomerUnmaskedV1DataType.Business)]
    public void SerializationRoundtrip_Works(CustomerUnmaskedV1DataType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerUnmaskedV1DataType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CustomerUnmaskedV1DataType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerUnmaskedV1DataType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CustomerUnmaskedV1DataType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class CustomerUnmaskedV1DataComplianceProfileTest : TestBase
{
    [Fact]
    public void IndividualValidationWorks()
    {
        CustomerUnmaskedV1DataComplianceProfile value =
            new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "1969-04-20",
                Ssn = "123-45-6789",
            };
        value.Validate();
    }

    [Fact]
    public void BusinessValidationWorks()
    {
        CustomerUnmaskedV1DataComplianceProfile value =
            new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile()
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
        CustomerUnmaskedV1DataComplianceProfile value =
            new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "1969-04-20",
                Ssn = "123-45-6789",
            };
        string element = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerUnmaskedV1DataComplianceProfile>(
            element,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void BusinessSerializationRoundtripWorks()
    {
        CustomerUnmaskedV1DataComplianceProfile value =
            new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile()
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
        var deserialized = JsonSerializer.Deserialize<CustomerUnmaskedV1DataComplianceProfile>(
            element,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfileTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile
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
        var model = new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile
        {
            Dob = "1969-04-20",
            Ssn = "123-45-6789",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile
        {
            Dob = "1969-04-20",
            Ssn = "123-45-6789",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile>(
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
        var model = new CustomerUnmaskedV1DataComplianceProfileIndividualComplianceProfile
        {
            Dob = "1969-04-20",
            Ssn = "123-45-6789",
        };

        model.Validate();
    }
}

public class CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile
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
        List<CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative> expectedRepresentatives =
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
        var model = new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile
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
            JsonSerializer.Deserialize<CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile
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
            JsonSerializer.Deserialize<CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        string expectedEin = "12-3456789";
        string expectedLegalBusinessName = "Acme Corp LLC";
        List<CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative> expectedRepresentatives =
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
        var model = new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile
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
        var model = new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile
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
        var model = new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile
        {
            Ein = "12-3456789",
            LegalBusinessName = "Acme Corp LLC",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile
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
        var model = new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfile
        {
            Ein = "12-3456789",
            LegalBusinessName = "Acme Corp LLC",

            Representatives = null,
            Website = null,
        };

        model.Validate();
    }
}

public class CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentativeTest
    : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model =
            new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative
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
        var model =
            new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative
            {
                Name = "name",
                Email = "email",
                Phone = "phone",
            };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model =
            new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative
            {
                Name = "name",
                Email = "email",
                Phone = "phone",
            };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative>(
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
        var model =
            new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative
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
        var model =
            new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative
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
        var model =
            new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative
            {
                Name = "name",
            };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model =
            new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative
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
        var model =
            new CustomerUnmaskedV1DataComplianceProfileBusinessComplianceProfileRepresentative
            {
                Name = "name",

                Email = null,
                Phone = null,
            };

        model.Validate();
    }
}

public class CustomerUnmaskedV1DataConfigTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerUnmaskedV1DataConfig
        {
            ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
        };

        ApiEnum<string, CustomerUnmaskedV1DataConfigProcessingMethod> expectedProcessingMethod =
            CustomerUnmaskedV1DataConfigProcessingMethod.Inline;
        ApiEnum<string, CustomerUnmaskedV1DataConfigSandboxOutcome> expectedSandboxOutcome =
            CustomerUnmaskedV1DataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, model.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, model.SandboxOutcome);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CustomerUnmaskedV1DataConfig
        {
            ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerUnmaskedV1DataConfig>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerUnmaskedV1DataConfig
        {
            ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerUnmaskedV1DataConfig>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, CustomerUnmaskedV1DataConfigProcessingMethod> expectedProcessingMethod =
            CustomerUnmaskedV1DataConfigProcessingMethod.Inline;
        ApiEnum<string, CustomerUnmaskedV1DataConfigSandboxOutcome> expectedSandboxOutcome =
            CustomerUnmaskedV1DataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, deserialized.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, deserialized.SandboxOutcome);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CustomerUnmaskedV1DataConfig
        {
            ProcessingMethod = CustomerUnmaskedV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = CustomerUnmaskedV1DataConfigSandboxOutcome.Standard,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new CustomerUnmaskedV1DataConfig { };

        Assert.Null(model.ProcessingMethod);
        Assert.False(model.RawData.ContainsKey("processing_method"));
        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new CustomerUnmaskedV1DataConfig { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new CustomerUnmaskedV1DataConfig
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
        var model = new CustomerUnmaskedV1DataConfig
        {
            // Null should be interpreted as omitted for these properties
            ProcessingMethod = null,
            SandboxOutcome = null,
        };

        model.Validate();
    }
}

public class CustomerUnmaskedV1DataConfigProcessingMethodTest : TestBase
{
    [Theory]
    [InlineData(CustomerUnmaskedV1DataConfigProcessingMethod.Inline)]
    [InlineData(CustomerUnmaskedV1DataConfigProcessingMethod.Background)]
    [InlineData(CustomerUnmaskedV1DataConfigProcessingMethod.Skip)]
    public void Validation_Works(CustomerUnmaskedV1DataConfigProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerUnmaskedV1DataConfigProcessingMethod> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerUnmaskedV1DataConfigProcessingMethod>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CustomerUnmaskedV1DataConfigProcessingMethod.Inline)]
    [InlineData(CustomerUnmaskedV1DataConfigProcessingMethod.Background)]
    [InlineData(CustomerUnmaskedV1DataConfigProcessingMethod.Skip)]
    public void SerializationRoundtrip_Works(CustomerUnmaskedV1DataConfigProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerUnmaskedV1DataConfigProcessingMethod> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerUnmaskedV1DataConfigProcessingMethod>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerUnmaskedV1DataConfigProcessingMethod>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerUnmaskedV1DataConfigProcessingMethod>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class CustomerUnmaskedV1DataConfigSandboxOutcomeTest : TestBase
{
    [Theory]
    [InlineData(CustomerUnmaskedV1DataConfigSandboxOutcome.Standard)]
    [InlineData(CustomerUnmaskedV1DataConfigSandboxOutcome.Verified)]
    [InlineData(CustomerUnmaskedV1DataConfigSandboxOutcome.Rejected)]
    [InlineData(CustomerUnmaskedV1DataConfigSandboxOutcome.Review)]
    public void Validation_Works(CustomerUnmaskedV1DataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerUnmaskedV1DataConfigSandboxOutcome> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerUnmaskedV1DataConfigSandboxOutcome>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CustomerUnmaskedV1DataConfigSandboxOutcome.Standard)]
    [InlineData(CustomerUnmaskedV1DataConfigSandboxOutcome.Verified)]
    [InlineData(CustomerUnmaskedV1DataConfigSandboxOutcome.Rejected)]
    [InlineData(CustomerUnmaskedV1DataConfigSandboxOutcome.Review)]
    public void SerializationRoundtrip_Works(CustomerUnmaskedV1DataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerUnmaskedV1DataConfigSandboxOutcome> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerUnmaskedV1DataConfigSandboxOutcome>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerUnmaskedV1DataConfigSandboxOutcome>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerUnmaskedV1DataConfigSandboxOutcome>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class CustomerUnmaskedV1ResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(CustomerUnmaskedV1ResponseType.Object)]
    [InlineData(CustomerUnmaskedV1ResponseType.Array)]
    [InlineData(CustomerUnmaskedV1ResponseType.Error)]
    [InlineData(CustomerUnmaskedV1ResponseType.None)]
    public void Validation_Works(CustomerUnmaskedV1ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerUnmaskedV1ResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerUnmaskedV1ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CustomerUnmaskedV1ResponseType.Object)]
    [InlineData(CustomerUnmaskedV1ResponseType.Array)]
    [InlineData(CustomerUnmaskedV1ResponseType.Error)]
    [InlineData(CustomerUnmaskedV1ResponseType.None)]
    public void SerializationRoundtrip_Works(CustomerUnmaskedV1ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerUnmaskedV1ResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerUnmaskedV1ResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerUnmaskedV1ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerUnmaskedV1ResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}
