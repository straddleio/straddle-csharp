using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models;
using Straddle.Models.Customers;

namespace Straddle.Tests.Models.Customers;

public class CustomerV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = CustomerV1DataStatus.Pending,
                Type = CustomerV1DataType.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile = new CustomerV1DataComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "2019-12-27",
                    Ssn = "***-**-****",
                },
                Config = new()
                {
                    ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
                    SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
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
            ResponseType = CustomerV1ResponseType.Object,
        };

        CustomerV1Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerV1DataStatus.Pending,
            Type = CustomerV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new CustomerV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            Config = new()
            {
                ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
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
        ApiEnum<string, CustomerV1ResponseType> expectedResponseType =
            CustomerV1ResponseType.Object;

        Assert.Equal(expectedData, model.Data);
        Assert.Equal(expectedMeta, model.Meta);
        Assert.Equal(expectedResponseType, model.ResponseType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CustomerV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = CustomerV1DataStatus.Pending,
                Type = CustomerV1DataType.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile = new CustomerV1DataComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "2019-12-27",
                    Ssn = "***-**-****",
                },
                Config = new()
                {
                    ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
                    SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
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
            ResponseType = CustomerV1ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = CustomerV1DataStatus.Pending,
                Type = CustomerV1DataType.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile = new CustomerV1DataComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "2019-12-27",
                    Ssn = "***-**-****",
                },
                Config = new()
                {
                    ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
                    SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
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
            ResponseType = CustomerV1ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        CustomerV1Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerV1DataStatus.Pending,
            Type = CustomerV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new CustomerV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            Config = new()
            {
                ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
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
        ApiEnum<string, CustomerV1ResponseType> expectedResponseType =
            CustomerV1ResponseType.Object;

        Assert.Equal(expectedData, deserialized.Data);
        Assert.Equal(expectedMeta, deserialized.Meta);
        Assert.Equal(expectedResponseType, deserialized.ResponseType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CustomerV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = CustomerV1DataStatus.Pending,
                Type = CustomerV1DataType.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile = new CustomerV1DataComplianceProfileIndividualComplianceProfile()
                {
                    Dob = "2019-12-27",
                    Ssn = "***-**-****",
                },
                Config = new()
                {
                    ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
                    SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
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
            ResponseType = CustomerV1ResponseType.Object,
        };

        model.Validate();
    }
}

public class CustomerV1DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerV1DataStatus.Pending,
            Type = CustomerV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new CustomerV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            Config = new()
            {
                ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
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
        ApiEnum<string, CustomerV1DataStatus> expectedStatus = CustomerV1DataStatus.Pending;
        ApiEnum<string, CustomerV1DataType> expectedType = CustomerV1DataType.Individual;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        CustomerAddressV1 expectedAddress = new()
        {
            Address1 = "123 Main St",
            City = "Anytown",
            State = "CA",
            Zip = "12345",
            Address2 = "Apt 1",
        };
        CustomerV1DataComplianceProfile expectedComplianceProfile =
            new CustomerV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            };
        CustomerV1DataConfig expectedConfig = new()
        {
            ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
        };
        Device expectedDevice = new("192.168.1.1");
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
        var model = new CustomerV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerV1DataStatus.Pending,
            Type = CustomerV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new CustomerV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            Config = new()
            {
                ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerV1Data>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerV1DataStatus.Pending,
            Type = CustomerV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new CustomerV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            Config = new()
            {
                ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerV1Data>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedEmail = "ron.swanson@pawnee.com";
        string expectedName = "Ron Swanson";
        string expectedPhone = "+12128675309";
        ApiEnum<string, CustomerV1DataStatus> expectedStatus = CustomerV1DataStatus.Pending;
        ApiEnum<string, CustomerV1DataType> expectedType = CustomerV1DataType.Individual;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        CustomerAddressV1 expectedAddress = new()
        {
            Address1 = "123 Main St",
            City = "Anytown",
            State = "CA",
            Zip = "12345",
            Address2 = "Apt 1",
        };
        CustomerV1DataComplianceProfile expectedComplianceProfile =
            new CustomerV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            };
        CustomerV1DataConfig expectedConfig = new()
        {
            ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
        };
        Device expectedDevice = new("192.168.1.1");
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
        var model = new CustomerV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerV1DataStatus.Pending,
            Type = CustomerV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new CustomerV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            Config = new()
            {
                ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
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
        var model = new CustomerV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerV1DataStatus.Pending,
            Type = CustomerV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new CustomerV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
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
        var model = new CustomerV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerV1DataStatus.Pending,
            Type = CustomerV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new CustomerV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new CustomerV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerV1DataStatus.Pending,
            Type = CustomerV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new CustomerV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
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
        var model = new CustomerV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerV1DataStatus.Pending,
            Type = CustomerV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new CustomerV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
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
        var model = new CustomerV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerV1DataStatus.Pending,
            Type = CustomerV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Config = new()
            {
                ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
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
        var model = new CustomerV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerV1DataStatus.Pending,
            Type = CustomerV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Config = new()
            {
                ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new CustomerV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerV1DataStatus.Pending,
            Type = CustomerV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Config = new()
            {
                ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
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
        var model = new CustomerV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = CustomerV1DataStatus.Pending,
            Type = CustomerV1DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Config = new()
            {
                ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
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

public class CustomerV1DataStatusTest : TestBase
{
    [Theory]
    [InlineData(CustomerV1DataStatus.Pending)]
    [InlineData(CustomerV1DataStatus.Review)]
    [InlineData(CustomerV1DataStatus.Verified)]
    [InlineData(CustomerV1DataStatus.Inactive)]
    [InlineData(CustomerV1DataStatus.Rejected)]
    public void Validation_Works(CustomerV1DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerV1DataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerV1DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CustomerV1DataStatus.Pending)]
    [InlineData(CustomerV1DataStatus.Review)]
    [InlineData(CustomerV1DataStatus.Verified)]
    [InlineData(CustomerV1DataStatus.Inactive)]
    [InlineData(CustomerV1DataStatus.Rejected)]
    public void SerializationRoundtrip_Works(CustomerV1DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerV1DataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CustomerV1DataStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerV1DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CustomerV1DataStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class CustomerV1DataTypeTest : TestBase
{
    [Theory]
    [InlineData(CustomerV1DataType.Individual)]
    [InlineData(CustomerV1DataType.Business)]
    [InlineData(CustomerV1DataType.Individual1)]
    [InlineData(CustomerV1DataType.Business1)]
    public void Validation_Works(CustomerV1DataType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerV1DataType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerV1DataType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CustomerV1DataType.Individual)]
    [InlineData(CustomerV1DataType.Business)]
    [InlineData(CustomerV1DataType.Individual1)]
    [InlineData(CustomerV1DataType.Business1)]
    public void SerializationRoundtrip_Works(CustomerV1DataType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerV1DataType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CustomerV1DataType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerV1DataType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CustomerV1DataType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class CustomerV1DataComplianceProfileTest : TestBase
{
    [Fact]
    public void IndividualValidationWorks()
    {
        CustomerV1DataComplianceProfile value =
            new CustomerV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            };
        value.Validate();
    }

    [Fact]
    public void BusinessValidationWorks()
    {
        CustomerV1DataComplianceProfile value =
            new CustomerV1DataComplianceProfileBusinessComplianceProfile()
            {
                Ein = "21-6051329",
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
        CustomerV1DataComplianceProfile value =
            new CustomerV1DataComplianceProfileIndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            };
        string element = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerV1DataComplianceProfile>(
            element,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void BusinessSerializationRoundtripWorks()
    {
        CustomerV1DataComplianceProfile value =
            new CustomerV1DataComplianceProfileBusinessComplianceProfile()
            {
                Ein = "21-6051329",
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
        var deserialized = JsonSerializer.Deserialize<CustomerV1DataComplianceProfile>(
            element,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class CustomerV1DataComplianceProfileIndividualComplianceProfileTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerV1DataComplianceProfileIndividualComplianceProfile
        {
            Dob = "2019-12-27",
            Ssn = "***-**-****",
        };

        string expectedDob = "2019-12-27";
        string expectedSsn = "***-**-****";

        Assert.Equal(expectedDob, model.Dob);
        Assert.Equal(expectedSsn, model.Ssn);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CustomerV1DataComplianceProfileIndividualComplianceProfile
        {
            Dob = "2019-12-27",
            Ssn = "***-**-****",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<CustomerV1DataComplianceProfileIndividualComplianceProfile>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerV1DataComplianceProfileIndividualComplianceProfile
        {
            Dob = "2019-12-27",
            Ssn = "***-**-****",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<CustomerV1DataComplianceProfileIndividualComplianceProfile>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        string expectedDob = "2019-12-27";
        string expectedSsn = "***-**-****";

        Assert.Equal(expectedDob, deserialized.Dob);
        Assert.Equal(expectedSsn, deserialized.Ssn);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CustomerV1DataComplianceProfileIndividualComplianceProfile
        {
            Dob = "2019-12-27",
            Ssn = "***-**-****",
        };

        model.Validate();
    }
}

public class CustomerV1DataComplianceProfileBusinessComplianceProfileTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerV1DataComplianceProfileBusinessComplianceProfile
        {
            Ein = "21-6051329",
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

        string expectedEin = "21-6051329";
        string expectedLegalBusinessName = "Acme Corp LLC";
        List<CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative> expectedRepresentatives =
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
        var model = new CustomerV1DataComplianceProfileBusinessComplianceProfile
        {
            Ein = "21-6051329",
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
            JsonSerializer.Deserialize<CustomerV1DataComplianceProfileBusinessComplianceProfile>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerV1DataComplianceProfileBusinessComplianceProfile
        {
            Ein = "21-6051329",
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
            JsonSerializer.Deserialize<CustomerV1DataComplianceProfileBusinessComplianceProfile>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        string expectedEin = "21-6051329";
        string expectedLegalBusinessName = "Acme Corp LLC";
        List<CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative> expectedRepresentatives =
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
        var model = new CustomerV1DataComplianceProfileBusinessComplianceProfile
        {
            Ein = "21-6051329",
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
        var model = new CustomerV1DataComplianceProfileBusinessComplianceProfile
        {
            Ein = "21-6051329",
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
        var model = new CustomerV1DataComplianceProfileBusinessComplianceProfile
        {
            Ein = "21-6051329",
            LegalBusinessName = "Acme Corp LLC",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new CustomerV1DataComplianceProfileBusinessComplianceProfile
        {
            Ein = "21-6051329",
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
        var model = new CustomerV1DataComplianceProfileBusinessComplianceProfile
        {
            Ein = "21-6051329",
            LegalBusinessName = "Acme Corp LLC",

            Representatives = null,
            Website = null,
        };

        model.Validate();
    }
}

public class CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentativeTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative
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
        var model = new CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative
        {
            Name = "name",
            Email = "email",
            Phone = "phone",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative
        {
            Name = "name",
            Email = "email",
            Phone = "phone",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative>(
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
        var model = new CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative
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
        var model = new CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative
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
        var model = new CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative
        {
            Name = "name",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative
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
        var model = new CustomerV1DataComplianceProfileBusinessComplianceProfileRepresentative
        {
            Name = "name",

            Email = null,
            Phone = null,
        };

        model.Validate();
    }
}

public class CustomerV1DataConfigTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerV1DataConfig
        {
            ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
        };

        ApiEnum<string, CustomerV1DataConfigProcessingMethod> expectedProcessingMethod =
            CustomerV1DataConfigProcessingMethod.Inline;
        ApiEnum<string, CustomerV1DataConfigSandboxOutcome> expectedSandboxOutcome =
            CustomerV1DataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, model.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, model.SandboxOutcome);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CustomerV1DataConfig
        {
            ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerV1DataConfig>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerV1DataConfig
        {
            ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerV1DataConfig>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, CustomerV1DataConfigProcessingMethod> expectedProcessingMethod =
            CustomerV1DataConfigProcessingMethod.Inline;
        ApiEnum<string, CustomerV1DataConfigSandboxOutcome> expectedSandboxOutcome =
            CustomerV1DataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, deserialized.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, deserialized.SandboxOutcome);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CustomerV1DataConfig
        {
            ProcessingMethod = CustomerV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = CustomerV1DataConfigSandboxOutcome.Standard,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new CustomerV1DataConfig { };

        Assert.Null(model.ProcessingMethod);
        Assert.False(model.RawData.ContainsKey("processing_method"));
        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new CustomerV1DataConfig { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new CustomerV1DataConfig
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
        var model = new CustomerV1DataConfig
        {
            // Null should be interpreted as omitted for these properties
            ProcessingMethod = null,
            SandboxOutcome = null,
        };

        model.Validate();
    }
}

public class CustomerV1DataConfigProcessingMethodTest : TestBase
{
    [Theory]
    [InlineData(CustomerV1DataConfigProcessingMethod.Inline)]
    [InlineData(CustomerV1DataConfigProcessingMethod.Background)]
    [InlineData(CustomerV1DataConfigProcessingMethod.Skip)]
    public void Validation_Works(CustomerV1DataConfigProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerV1DataConfigProcessingMethod> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerV1DataConfigProcessingMethod>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CustomerV1DataConfigProcessingMethod.Inline)]
    [InlineData(CustomerV1DataConfigProcessingMethod.Background)]
    [InlineData(CustomerV1DataConfigProcessingMethod.Skip)]
    public void SerializationRoundtrip_Works(CustomerV1DataConfigProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerV1DataConfigProcessingMethod> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerV1DataConfigProcessingMethod>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerV1DataConfigProcessingMethod>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerV1DataConfigProcessingMethod>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class CustomerV1DataConfigSandboxOutcomeTest : TestBase
{
    [Theory]
    [InlineData(CustomerV1DataConfigSandboxOutcome.Standard)]
    [InlineData(CustomerV1DataConfigSandboxOutcome.Verified)]
    [InlineData(CustomerV1DataConfigSandboxOutcome.Rejected)]
    [InlineData(CustomerV1DataConfigSandboxOutcome.Review)]
    public void Validation_Works(CustomerV1DataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerV1DataConfigSandboxOutcome> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerV1DataConfigSandboxOutcome>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CustomerV1DataConfigSandboxOutcome.Standard)]
    [InlineData(CustomerV1DataConfigSandboxOutcome.Verified)]
    [InlineData(CustomerV1DataConfigSandboxOutcome.Rejected)]
    [InlineData(CustomerV1DataConfigSandboxOutcome.Review)]
    public void SerializationRoundtrip_Works(CustomerV1DataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerV1DataConfigSandboxOutcome> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerV1DataConfigSandboxOutcome>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerV1DataConfigSandboxOutcome>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CustomerV1DataConfigSandboxOutcome>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class DeviceTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Device { IPAddress = "192.168.1.1" };

        string expectedIPAddress = "192.168.1.1";

        Assert.Equal(expectedIPAddress, model.IPAddress);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Device { IPAddress = "192.168.1.1" };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Device>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Device { IPAddress = "192.168.1.1" };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Device>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedIPAddress = "192.168.1.1";

        Assert.Equal(expectedIPAddress, deserialized.IPAddress);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Device { IPAddress = "192.168.1.1" };

        model.Validate();
    }
}

public class CustomerV1ResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(CustomerV1ResponseType.Object)]
    [InlineData(CustomerV1ResponseType.Array)]
    [InlineData(CustomerV1ResponseType.Error)]
    [InlineData(CustomerV1ResponseType.None)]
    [InlineData(CustomerV1ResponseType.Object1)]
    [InlineData(CustomerV1ResponseType.Array1)]
    [InlineData(CustomerV1ResponseType.Error1)]
    [InlineData(CustomerV1ResponseType.None1)]
    public void Validation_Works(CustomerV1ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerV1ResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerV1ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CustomerV1ResponseType.Object)]
    [InlineData(CustomerV1ResponseType.Array)]
    [InlineData(CustomerV1ResponseType.Error)]
    [InlineData(CustomerV1ResponseType.None)]
    [InlineData(CustomerV1ResponseType.Object1)]
    [InlineData(CustomerV1ResponseType.Array1)]
    [InlineData(CustomerV1ResponseType.Error1)]
    [InlineData(CustomerV1ResponseType.None1)]
    public void SerializationRoundtrip_Works(CustomerV1ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerV1ResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CustomerV1ResponseType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerV1ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CustomerV1ResponseType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
