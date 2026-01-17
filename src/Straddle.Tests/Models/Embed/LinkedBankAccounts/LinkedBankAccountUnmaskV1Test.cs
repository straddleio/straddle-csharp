using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models;
using Straddle.Models.Embed.LinkedBankAccounts;

namespace Straddle.Tests.Models.Embed.LinkedBankAccounts;

public class LinkedBankAccountUnmaskV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkedBankAccountUnmaskV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                BankAccount = new()
                {
                    AccountHolder = "account_holder",
                    AccountNumber = "account_number",
                    InstitutionName = "institution_name",
                    RoutingNumber = "routing_number",
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Status = LinkedBankAccountUnmaskV1DataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
                    Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = LinkedBankAccountUnmaskV1ResponseType.Object,
        };

        LinkedBankAccountUnmaskV1Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = LinkedBankAccountUnmaskV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, LinkedBankAccountUnmaskV1ResponseType> expectedResponseType =
            LinkedBankAccountUnmaskV1ResponseType.Object;

        Assert.Equal(expectedData, model.Data);
        Assert.Equal(expectedMeta, model.Meta);
        Assert.Equal(expectedResponseType, model.ResponseType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LinkedBankAccountUnmaskV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                BankAccount = new()
                {
                    AccountHolder = "account_holder",
                    AccountNumber = "account_number",
                    InstitutionName = "institution_name",
                    RoutingNumber = "routing_number",
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Status = LinkedBankAccountUnmaskV1DataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
                    Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = LinkedBankAccountUnmaskV1ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountUnmaskV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkedBankAccountUnmaskV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                BankAccount = new()
                {
                    AccountHolder = "account_holder",
                    AccountNumber = "account_number",
                    InstitutionName = "institution_name",
                    RoutingNumber = "routing_number",
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Status = LinkedBankAccountUnmaskV1DataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
                    Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = LinkedBankAccountUnmaskV1ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountUnmaskV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        LinkedBankAccountUnmaskV1Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = LinkedBankAccountUnmaskV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, LinkedBankAccountUnmaskV1ResponseType> expectedResponseType =
            LinkedBankAccountUnmaskV1ResponseType.Object;

        Assert.Equal(expectedData, deserialized.Data);
        Assert.Equal(expectedMeta, deserialized.Meta);
        Assert.Equal(expectedResponseType, deserialized.ResponseType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LinkedBankAccountUnmaskV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                BankAccount = new()
                {
                    AccountHolder = "account_holder",
                    AccountNumber = "account_number",
                    InstitutionName = "institution_name",
                    RoutingNumber = "routing_number",
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Status = LinkedBankAccountUnmaskV1DataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
                    Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = LinkedBankAccountUnmaskV1ResponseType.Object,
        };

        model.Validate();
    }
}

public class LinkedBankAccountUnmaskV1DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkedBankAccountUnmaskV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = LinkedBankAccountUnmaskV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        string expectedAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        LinkedBankAccountUnmaskV1DataBankAccount expectedBankAccount = new()
        {
            AccountHolder = "account_holder",
            AccountNumber = "account_number",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        ApiEnum<string, LinkedBankAccountUnmaskV1DataStatus> expectedStatus =
            LinkedBankAccountUnmaskV1DataStatus.Created;
        LinkedBankAccountUnmaskV1DataStatusDetail expectedStatusDetail = new()
        {
            Code = "code",
            Message = "message",
            Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
            Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
        };
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        Dictionary<string, string?> expectedMetadata = new() { { "foo", "string" } };

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAccountID, model.AccountID);
        Assert.Equal(expectedBankAccount, model.BankAccount);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedStatusDetail, model.StatusDetail);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
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
        var model = new LinkedBankAccountUnmaskV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = LinkedBankAccountUnmaskV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountUnmaskV1Data>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkedBankAccountUnmaskV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = LinkedBankAccountUnmaskV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountUnmaskV1Data>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        string expectedAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        LinkedBankAccountUnmaskV1DataBankAccount expectedBankAccount = new()
        {
            AccountHolder = "account_holder",
            AccountNumber = "account_number",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        ApiEnum<string, LinkedBankAccountUnmaskV1DataStatus> expectedStatus =
            LinkedBankAccountUnmaskV1DataStatus.Created;
        LinkedBankAccountUnmaskV1DataStatusDetail expectedStatusDetail = new()
        {
            Code = "code",
            Message = "message",
            Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
            Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
        };
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        Dictionary<string, string?> expectedMetadata = new() { { "foo", "string" } };

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAccountID, deserialized.AccountID);
        Assert.Equal(expectedBankAccount, deserialized.BankAccount);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedStatusDetail, deserialized.StatusDetail);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
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
        var model = new LinkedBankAccountUnmaskV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = LinkedBankAccountUnmaskV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new LinkedBankAccountUnmaskV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = LinkedBankAccountUnmaskV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        Assert.Null(model.Metadata);
        Assert.False(model.RawData.ContainsKey("metadata"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new LinkedBankAccountUnmaskV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = LinkedBankAccountUnmaskV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new LinkedBankAccountUnmaskV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = LinkedBankAccountUnmaskV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),

            Metadata = null,
        };

        Assert.Null(model.Metadata);
        Assert.True(model.RawData.ContainsKey("metadata"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new LinkedBankAccountUnmaskV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            BankAccount = new()
            {
                AccountHolder = "account_holder",
                AccountNumber = "account_number",
                InstitutionName = "institution_name",
                RoutingNumber = "routing_number",
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = LinkedBankAccountUnmaskV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
                Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),

            Metadata = null,
        };

        model.Validate();
    }
}

public class LinkedBankAccountUnmaskV1DataBankAccountTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkedBankAccountUnmaskV1DataBankAccount
        {
            AccountHolder = "account_holder",
            AccountNumber = "account_number",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };

        string expectedAccountHolder = "account_holder";
        string expectedAccountNumber = "account_number";
        string expectedInstitutionName = "institution_name";
        string expectedRoutingNumber = "routing_number";

        Assert.Equal(expectedAccountHolder, model.AccountHolder);
        Assert.Equal(expectedAccountNumber, model.AccountNumber);
        Assert.Equal(expectedInstitutionName, model.InstitutionName);
        Assert.Equal(expectedRoutingNumber, model.RoutingNumber);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LinkedBankAccountUnmaskV1DataBankAccount
        {
            AccountHolder = "account_holder",
            AccountNumber = "account_number",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountUnmaskV1DataBankAccount>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkedBankAccountUnmaskV1DataBankAccount
        {
            AccountHolder = "account_holder",
            AccountNumber = "account_number",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountUnmaskV1DataBankAccount>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedAccountHolder = "account_holder";
        string expectedAccountNumber = "account_number";
        string expectedInstitutionName = "institution_name";
        string expectedRoutingNumber = "routing_number";

        Assert.Equal(expectedAccountHolder, deserialized.AccountHolder);
        Assert.Equal(expectedAccountNumber, deserialized.AccountNumber);
        Assert.Equal(expectedInstitutionName, deserialized.InstitutionName);
        Assert.Equal(expectedRoutingNumber, deserialized.RoutingNumber);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LinkedBankAccountUnmaskV1DataBankAccount
        {
            AccountHolder = "account_holder",
            AccountNumber = "account_number",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };

        model.Validate();
    }
}

public class LinkedBankAccountUnmaskV1DataStatusTest : TestBase
{
    [Theory]
    [InlineData(LinkedBankAccountUnmaskV1DataStatus.Created)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatus.Onboarding)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatus.Active)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatus.Rejected)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatus.Inactive)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatus.Canceled)]
    public void Validation_Works(LinkedBankAccountUnmaskV1DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountUnmaskV1DataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountUnmaskV1DataStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkedBankAccountUnmaskV1DataStatus.Created)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatus.Onboarding)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatus.Active)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatus.Rejected)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatus.Inactive)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatus.Canceled)]
    public void SerializationRoundtrip_Works(LinkedBankAccountUnmaskV1DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountUnmaskV1DataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountUnmaskV1DataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountUnmaskV1DataStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountUnmaskV1DataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class LinkedBankAccountUnmaskV1DataStatusDetailTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkedBankAccountUnmaskV1DataStatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
            Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
        };

        string expectedCode = "code";
        string expectedMessage = "message";
        ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailReason> expectedReason =
            LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified;
        ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailSource> expectedSource =
            LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower;

        Assert.Equal(expectedCode, model.Code);
        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedReason, model.Reason);
        Assert.Equal(expectedSource, model.Source);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LinkedBankAccountUnmaskV1DataStatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
            Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountUnmaskV1DataStatusDetail>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkedBankAccountUnmaskV1DataStatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
            Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountUnmaskV1DataStatusDetail>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedCode = "code";
        string expectedMessage = "message";
        ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailReason> expectedReason =
            LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified;
        ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailSource> expectedSource =
            LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower;

        Assert.Equal(expectedCode, deserialized.Code);
        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedReason, deserialized.Reason);
        Assert.Equal(expectedSource, deserialized.Source);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LinkedBankAccountUnmaskV1DataStatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified,
            Source = LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower,
        };

        model.Validate();
    }
}

public class LinkedBankAccountUnmaskV1DataStatusDetailReasonTest : TestBase
{
    [Theory]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailReason.InReview)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailReason.Pending)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailReason.Stuck)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailReason.Verified)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailReason.FailedVerification)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailReason.Disabled)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailReason.New)]
    public void Validation_Works(LinkedBankAccountUnmaskV1DataStatusDetailReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailReason> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailReason.Unverified)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailReason.InReview)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailReason.Pending)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailReason.Stuck)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailReason.Verified)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailReason.FailedVerification)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailReason.Disabled)]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailReason.New)]
    public void SerializationRoundtrip_Works(
        LinkedBankAccountUnmaskV1DataStatusDetailReason rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailReason> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class LinkedBankAccountUnmaskV1DataStatusDetailSourceTest : TestBase
{
    [Theory]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower)]
    public void Validation_Works(LinkedBankAccountUnmaskV1DataStatusDetailSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailSource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailSource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkedBankAccountUnmaskV1DataStatusDetailSource.Watchtower)]
    public void SerializationRoundtrip_Works(
        LinkedBankAccountUnmaskV1DataStatusDetailSource rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailSource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailSource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountUnmaskV1DataStatusDetailSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class LinkedBankAccountUnmaskV1ResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(LinkedBankAccountUnmaskV1ResponseType.Object)]
    [InlineData(LinkedBankAccountUnmaskV1ResponseType.Array)]
    [InlineData(LinkedBankAccountUnmaskV1ResponseType.Error)]
    [InlineData(LinkedBankAccountUnmaskV1ResponseType.None)]
    public void Validation_Works(LinkedBankAccountUnmaskV1ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountUnmaskV1ResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountUnmaskV1ResponseType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkedBankAccountUnmaskV1ResponseType.Object)]
    [InlineData(LinkedBankAccountUnmaskV1ResponseType.Array)]
    [InlineData(LinkedBankAccountUnmaskV1ResponseType.Error)]
    [InlineData(LinkedBankAccountUnmaskV1ResponseType.None)]
    public void SerializationRoundtrip_Works(LinkedBankAccountUnmaskV1ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkedBankAccountUnmaskV1ResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountUnmaskV1ResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountUnmaskV1ResponseType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkedBankAccountUnmaskV1ResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}
