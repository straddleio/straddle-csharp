using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models;
using Straddle.Models.Embed.LinkedBankAccounts;

namespace Straddle.Tests.Models.Embed.LinkedBankAccounts;

public class LinkedBankAccountV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkedBankAccountV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                BankAccount = new()
                {
                    AccountHolder = "account_holder",
                    AccountMask = "account_mask",
                    InstitutionName = "institution_name",
                    RoutingNumber = "routing_number",
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Purposes = [LinkedBankAccountV1DataPurpose.Charges],
                Status = LinkedBankAccountV1DataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
                    Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Description = "description",
                Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
                PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = LinkedBankAccountV1ResponseType.Object,
        };

        LinkedBankAccountV1Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountMask = "account_mask",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Purposes = [LinkedBankAccountV1DataPurpose.Charges],
            Status = LinkedBankAccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Description = "description",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, LinkedBankAccountV1ResponseType> expectedResponseType =
            LinkedBankAccountV1ResponseType.Object;

        Assert.Equal(expectedData, model.Data);
        Assert.Equal(expectedMeta, model.Meta);
        Assert.Equal(expectedResponseType, model.ResponseType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LinkedBankAccountV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                BankAccount = new()
                {
                    AccountHolder = "account_holder",
                    AccountMask = "account_mask",
                    InstitutionName = "institution_name",
                    RoutingNumber = "routing_number",
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Purposes = [LinkedBankAccountV1DataPurpose.Charges],
                Status = LinkedBankAccountV1DataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
                    Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Description = "description",
                Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
                PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = LinkedBankAccountV1ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkedBankAccountV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                BankAccount = new()
                {
                    AccountHolder = "account_holder",
                    AccountMask = "account_mask",
                    InstitutionName = "institution_name",
                    RoutingNumber = "routing_number",
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Purposes = [LinkedBankAccountV1DataPurpose.Charges],
                Status = LinkedBankAccountV1DataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
                    Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Description = "description",
                Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
                PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = LinkedBankAccountV1ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        LinkedBankAccountV1Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountMask = "account_mask",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Purposes = [LinkedBankAccountV1DataPurpose.Charges],
            Status = LinkedBankAccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Description = "description",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, LinkedBankAccountV1ResponseType> expectedResponseType =
            LinkedBankAccountV1ResponseType.Object;

        Assert.Equal(expectedData, deserialized.Data);
        Assert.Equal(expectedMeta, deserialized.Meta);
        Assert.Equal(expectedResponseType, deserialized.ResponseType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LinkedBankAccountV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                BankAccount = new()
                {
                    AccountHolder = "account_holder",
                    AccountMask = "account_mask",
                    InstitutionName = "institution_name",
                    RoutingNumber = "routing_number",
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Purposes = [LinkedBankAccountV1DataPurpose.Charges],
                Status = LinkedBankAccountV1DataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
                    Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Description = "description",
                Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
                PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = LinkedBankAccountV1ResponseType.Object,
        };

        model.Validate();
    }
}

public class LinkedBankAccountV1DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkedBankAccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountMask = "account_mask",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Purposes = [LinkedBankAccountV1DataPurpose.Charges],
            Status = LinkedBankAccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Description = "description",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        string expectedAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        LinkedBankAccountV1DataBankAccount expectedBankAccount = new()
        {
            AccountHolder = "account_holder",
            AccountMask = "account_mask",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        List<ApiEnum<string, LinkedBankAccountV1DataPurpose>> expectedPurposes =
        [
            LinkedBankAccountV1DataPurpose.Charges,
        ];
        ApiEnum<string, LinkedBankAccountV1DataStatus> expectedStatus =
            LinkedBankAccountV1DataStatus.Created;
        LinkedBankAccountV1DataStatusDetail expectedStatusDetail = new()
        {
            Code = "code",
            Message = "message",
            Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
            Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
        };
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedDescription = "description";
        Dictionary<string, string?> expectedMetadata = new() { { "foo", "string" } };
        string expectedPlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAccountID, model.AccountID);
        Assert.Equal(expectedBankAccount, model.BankAccount);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedPurposes.Count, model.Purposes.Count);
        for (int i = 0; i < expectedPurposes.Count; i++)
        {
            Assert.Equal(expectedPurposes[i], model.Purposes[i]);
        }
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedStatusDetail, model.StatusDetail);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
        Assert.Equal(expectedDescription, model.Description);
        Assert.NotNull(model.Metadata);
        Assert.Equal(expectedMetadata.Count, model.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(model.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Metadata[item.Key]);
        }
        Assert.Equal(expectedPlatformID, model.PlatformID);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LinkedBankAccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountMask = "account_mask",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Purposes = [LinkedBankAccountV1DataPurpose.Charges],
            Status = LinkedBankAccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Description = "description",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountV1Data>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkedBankAccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountMask = "account_mask",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Purposes = [LinkedBankAccountV1DataPurpose.Charges],
            Status = LinkedBankAccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Description = "description",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountV1Data>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        string expectedAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        LinkedBankAccountV1DataBankAccount expectedBankAccount = new()
        {
            AccountHolder = "account_holder",
            AccountMask = "account_mask",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        List<ApiEnum<string, LinkedBankAccountV1DataPurpose>> expectedPurposes =
        [
            LinkedBankAccountV1DataPurpose.Charges,
        ];
        ApiEnum<string, LinkedBankAccountV1DataStatus> expectedStatus =
            LinkedBankAccountV1DataStatus.Created;
        LinkedBankAccountV1DataStatusDetail expectedStatusDetail = new()
        {
            Code = "code",
            Message = "message",
            Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
            Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
        };
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedDescription = "description";
        Dictionary<string, string?> expectedMetadata = new() { { "foo", "string" } };
        string expectedPlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAccountID, deserialized.AccountID);
        Assert.Equal(expectedBankAccount, deserialized.BankAccount);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedPurposes.Count, deserialized.Purposes.Count);
        for (int i = 0; i < expectedPurposes.Count; i++)
        {
            Assert.Equal(expectedPurposes[i], deserialized.Purposes[i]);
        }
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedStatusDetail, deserialized.StatusDetail);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.NotNull(deserialized.Metadata);
        Assert.Equal(expectedMetadata.Count, deserialized.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(deserialized.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Metadata[item.Key]);
        }
        Assert.Equal(expectedPlatformID, deserialized.PlatformID);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LinkedBankAccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountMask = "account_mask",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Purposes = [LinkedBankAccountV1DataPurpose.Charges],
            Status = LinkedBankAccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Description = "description",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new LinkedBankAccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountMask = "account_mask",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Purposes = [LinkedBankAccountV1DataPurpose.Charges],
            Status = LinkedBankAccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Metadata);
        Assert.False(model.RawData.ContainsKey("metadata"));
        Assert.Null(model.PlatformID);
        Assert.False(model.RawData.ContainsKey("platform_id"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new LinkedBankAccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountMask = "account_mask",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Purposes = [LinkedBankAccountV1DataPurpose.Charges],
            Status = LinkedBankAccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new LinkedBankAccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountMask = "account_mask",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Purposes = [LinkedBankAccountV1DataPurpose.Charges],
            Status = LinkedBankAccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),

            Description = null,
            Metadata = null,
            PlatformID = null,
        };

        Assert.Null(model.Description);
        Assert.True(model.RawData.ContainsKey("description"));
        Assert.Null(model.Metadata);
        Assert.True(model.RawData.ContainsKey("metadata"));
        Assert.Null(model.PlatformID);
        Assert.True(model.RawData.ContainsKey("platform_id"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new LinkedBankAccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountMask = "account_mask",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Purposes = [LinkedBankAccountV1DataPurpose.Charges],
            Status = LinkedBankAccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),

            Description = null,
            Metadata = null,
            PlatformID = null,
        };

        model.Validate();
    }
}

public class LinkedBankAccountV1DataBankAccountTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkedBankAccountV1DataBankAccount
        {
            AccountHolder = "account_holder",
            AccountMask = "account_mask",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };

        string expectedAccountHolder = "account_holder";
        string expectedAccountMask = "account_mask";
        string expectedInstitutionName = "institution_name";
        string expectedRoutingNumber = "routing_number";

        Assert.Equal(expectedAccountHolder, model.AccountHolder);
        Assert.Equal(expectedAccountMask, model.AccountMask);
        Assert.Equal(expectedInstitutionName, model.InstitutionName);
        Assert.Equal(expectedRoutingNumber, model.RoutingNumber);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LinkedBankAccountV1DataBankAccount
        {
            AccountHolder = "account_holder",
            AccountMask = "account_mask",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountV1DataBankAccount>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkedBankAccountV1DataBankAccount
        {
            AccountHolder = "account_holder",
            AccountMask = "account_mask",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountV1DataBankAccount>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedAccountHolder = "account_holder";
        string expectedAccountMask = "account_mask";
        string expectedInstitutionName = "institution_name";
        string expectedRoutingNumber = "routing_number";

        Assert.Equal(expectedAccountHolder, deserialized.AccountHolder);
        Assert.Equal(expectedAccountMask, deserialized.AccountMask);
        Assert.Equal(expectedInstitutionName, deserialized.InstitutionName);
        Assert.Equal(expectedRoutingNumber, deserialized.RoutingNumber);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LinkedBankAccountV1DataBankAccount
        {
            AccountHolder = "account_holder",
            AccountMask = "account_mask",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };

        model.Validate();
    }
}

public class LinkedBankAccountV1DataPurposeTest : TestBase
{
    [Theory]
    [InlineData(LinkedBankAccountV1DataPurpose.Charges)]
    [InlineData(LinkedBankAccountV1DataPurpose.Payouts)]
    [InlineData(LinkedBankAccountV1DataPurpose.Billing)]
    public void Validation_Works(LinkedBankAccountV1DataPurpose rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountV1DataPurpose> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, LinkedBankAccountV1DataPurpose>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkedBankAccountV1DataPurpose.Charges)]
    [InlineData(LinkedBankAccountV1DataPurpose.Payouts)]
    [InlineData(LinkedBankAccountV1DataPurpose.Billing)]
    public void SerializationRoundtrip_Works(LinkedBankAccountV1DataPurpose rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountV1DataPurpose> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountV1DataPurpose>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, LinkedBankAccountV1DataPurpose>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountV1DataPurpose>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class LinkedBankAccountV1DataStatusTest : TestBase
{
    [Theory]
    [InlineData(LinkedBankAccountV1DataStatus.Created)]
    [InlineData(LinkedBankAccountV1DataStatus.Onboarding)]
    [InlineData(LinkedBankAccountV1DataStatus.Active)]
    [InlineData(LinkedBankAccountV1DataStatus.Rejected)]
    [InlineData(LinkedBankAccountV1DataStatus.Inactive)]
    [InlineData(LinkedBankAccountV1DataStatus.Canceled)]
    public void Validation_Works(LinkedBankAccountV1DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountV1DataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, LinkedBankAccountV1DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkedBankAccountV1DataStatus.Created)]
    [InlineData(LinkedBankAccountV1DataStatus.Onboarding)]
    [InlineData(LinkedBankAccountV1DataStatus.Active)]
    [InlineData(LinkedBankAccountV1DataStatus.Rejected)]
    [InlineData(LinkedBankAccountV1DataStatus.Inactive)]
    [InlineData(LinkedBankAccountV1DataStatus.Canceled)]
    public void SerializationRoundtrip_Works(LinkedBankAccountV1DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountV1DataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountV1DataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, LinkedBankAccountV1DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountV1DataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class LinkedBankAccountV1DataStatusDetailTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkedBankAccountV1DataStatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
            Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
        };

        string expectedCode = "code";
        string expectedMessage = "message";
        ApiEnum<string, LinkedBankAccountV1DataStatusDetailReason> expectedReason =
            LinkedBankAccountV1DataStatusDetailReason.Unverified;
        ApiEnum<string, LinkedBankAccountV1DataStatusDetailSource> expectedSource =
            LinkedBankAccountV1DataStatusDetailSource.Watchtower;

        Assert.Equal(expectedCode, model.Code);
        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedReason, model.Reason);
        Assert.Equal(expectedSource, model.Source);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LinkedBankAccountV1DataStatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
            Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountV1DataStatusDetail>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkedBankAccountV1DataStatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
            Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountV1DataStatusDetail>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedCode = "code";
        string expectedMessage = "message";
        ApiEnum<string, LinkedBankAccountV1DataStatusDetailReason> expectedReason =
            LinkedBankAccountV1DataStatusDetailReason.Unverified;
        ApiEnum<string, LinkedBankAccountV1DataStatusDetailSource> expectedSource =
            LinkedBankAccountV1DataStatusDetailSource.Watchtower;

        Assert.Equal(expectedCode, deserialized.Code);
        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedReason, deserialized.Reason);
        Assert.Equal(expectedSource, deserialized.Source);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LinkedBankAccountV1DataStatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = LinkedBankAccountV1DataStatusDetailReason.Unverified,
            Source = LinkedBankAccountV1DataStatusDetailSource.Watchtower,
        };

        model.Validate();
    }
}

public class LinkedBankAccountV1DataStatusDetailReasonTest : TestBase
{
    [Theory]
    [InlineData(LinkedBankAccountV1DataStatusDetailReason.Unverified)]
    [InlineData(LinkedBankAccountV1DataStatusDetailReason.InReview)]
    [InlineData(LinkedBankAccountV1DataStatusDetailReason.Pending)]
    [InlineData(LinkedBankAccountV1DataStatusDetailReason.Stuck)]
    [InlineData(LinkedBankAccountV1DataStatusDetailReason.Verified)]
    [InlineData(LinkedBankAccountV1DataStatusDetailReason.FailedVerification)]
    [InlineData(LinkedBankAccountV1DataStatusDetailReason.Disabled)]
    [InlineData(LinkedBankAccountV1DataStatusDetailReason.New)]
    public void Validation_Works(LinkedBankAccountV1DataStatusDetailReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountV1DataStatusDetailReason> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountV1DataStatusDetailReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkedBankAccountV1DataStatusDetailReason.Unverified)]
    [InlineData(LinkedBankAccountV1DataStatusDetailReason.InReview)]
    [InlineData(LinkedBankAccountV1DataStatusDetailReason.Pending)]
    [InlineData(LinkedBankAccountV1DataStatusDetailReason.Stuck)]
    [InlineData(LinkedBankAccountV1DataStatusDetailReason.Verified)]
    [InlineData(LinkedBankAccountV1DataStatusDetailReason.FailedVerification)]
    [InlineData(LinkedBankAccountV1DataStatusDetailReason.Disabled)]
    [InlineData(LinkedBankAccountV1DataStatusDetailReason.New)]
    public void SerializationRoundtrip_Works(LinkedBankAccountV1DataStatusDetailReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountV1DataStatusDetailReason> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountV1DataStatusDetailReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountV1DataStatusDetailReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountV1DataStatusDetailReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class LinkedBankAccountV1DataStatusDetailSourceTest : TestBase
{
    [Theory]
    [InlineData(LinkedBankAccountV1DataStatusDetailSource.Watchtower)]
    public void Validation_Works(LinkedBankAccountV1DataStatusDetailSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountV1DataStatusDetailSource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountV1DataStatusDetailSource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkedBankAccountV1DataStatusDetailSource.Watchtower)]
    public void SerializationRoundtrip_Works(LinkedBankAccountV1DataStatusDetailSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountV1DataStatusDetailSource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountV1DataStatusDetailSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountV1DataStatusDetailSource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountV1DataStatusDetailSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class LinkedBankAccountV1ResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(LinkedBankAccountV1ResponseType.Object)]
    [InlineData(LinkedBankAccountV1ResponseType.Array)]
    [InlineData(LinkedBankAccountV1ResponseType.Error)]
    [InlineData(LinkedBankAccountV1ResponseType.None)]
    public void Validation_Works(LinkedBankAccountV1ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountV1ResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, LinkedBankAccountV1ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkedBankAccountV1ResponseType.Object)]
    [InlineData(LinkedBankAccountV1ResponseType.Array)]
    [InlineData(LinkedBankAccountV1ResponseType.Error)]
    [InlineData(LinkedBankAccountV1ResponseType.None)]
    public void SerializationRoundtrip_Works(LinkedBankAccountV1ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountV1ResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountV1ResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, LinkedBankAccountV1ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountV1ResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}
