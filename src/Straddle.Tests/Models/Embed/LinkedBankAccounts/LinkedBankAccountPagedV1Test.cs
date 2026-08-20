using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Embed.LinkedBankAccounts;
using Models = Straddle.Models;

namespace Straddle.Tests.Models.Embed.LinkedBankAccounts;

public class LinkedBankAccountPagedV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkedBankAccountPagedV1
        {
            Data =
            [
                new()
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
                    Purposes = [DataPurpose.Charges],
                    Status = DataStatus.Created,
                    StatusDetail = new()
                    {
                        Code = "code",
                        Message = "message",
                        Reason = Reason.Unverified,
                        Source = Source.Watchtower,
                    },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Description = "description",
                    Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
                    PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                },
            ],
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                MaxPageSize = 0,
                PageNumber = 0,
                PageSize = 0,
                SortBy = "sort_by",
                SortOrder = Models::SortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = ResponseType.Object,
        };

        List<Data> expectedData =
        [
            new()
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
                Purposes = [DataPurpose.Charges],
                Status = DataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = Reason.Unverified,
                    Source = Source.Watchtower,
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Description = "description",
                Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
                PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            },
        ];
        Models::PagedResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = Models::SortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };
        ApiEnum<string, ResponseType> expectedResponseType = ResponseType.Object;

        Assert.Equal(expectedData.Count, model.Data.Count);
        for (int i = 0; i < expectedData.Count; i++)
        {
            Assert.Equal(expectedData[i], model.Data[i]);
        }
        Assert.Equal(expectedMeta, model.Meta);
        Assert.Equal(expectedResponseType, model.ResponseType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LinkedBankAccountPagedV1
        {
            Data =
            [
                new()
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
                    Purposes = [DataPurpose.Charges],
                    Status = DataStatus.Created,
                    StatusDetail = new()
                    {
                        Code = "code",
                        Message = "message",
                        Reason = Reason.Unverified,
                        Source = Source.Watchtower,
                    },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Description = "description",
                    Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
                    PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                },
            ],
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                MaxPageSize = 0,
                PageNumber = 0,
                PageSize = 0,
                SortBy = "sort_by",
                SortOrder = Models::SortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountPagedV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkedBankAccountPagedV1
        {
            Data =
            [
                new()
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
                    Purposes = [DataPurpose.Charges],
                    Status = DataStatus.Created,
                    StatusDetail = new()
                    {
                        Code = "code",
                        Message = "message",
                        Reason = Reason.Unverified,
                        Source = Source.Watchtower,
                    },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Description = "description",
                    Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
                    PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                },
            ],
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                MaxPageSize = 0,
                PageNumber = 0,
                PageSize = 0,
                SortBy = "sort_by",
                SortOrder = Models::SortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkedBankAccountPagedV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
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
                Purposes = [DataPurpose.Charges],
                Status = DataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = Reason.Unverified,
                    Source = Source.Watchtower,
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Description = "description",
                Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
                PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            },
        ];
        Models::PagedResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = Models::SortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };
        ApiEnum<string, ResponseType> expectedResponseType = ResponseType.Object;

        Assert.Equal(expectedData.Count, deserialized.Data.Count);
        for (int i = 0; i < expectedData.Count; i++)
        {
            Assert.Equal(expectedData[i], deserialized.Data[i]);
        }
        Assert.Equal(expectedMeta, deserialized.Meta);
        Assert.Equal(expectedResponseType, deserialized.ResponseType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LinkedBankAccountPagedV1
        {
            Data =
            [
                new()
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
                    Purposes = [DataPurpose.Charges],
                    Status = DataStatus.Created,
                    StatusDetail = new()
                    {
                        Code = "code",
                        Message = "message",
                        Reason = Reason.Unverified,
                        Source = Source.Watchtower,
                    },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Description = "description",
                    Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
                    PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                },
            ],
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                MaxPageSize = 0,
                PageNumber = 0,
                PageSize = 0,
                SortBy = "sort_by",
                SortOrder = Models::SortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = ResponseType.Object,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new LinkedBankAccountPagedV1
        {
            Data =
            [
                new()
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
                    Purposes = [DataPurpose.Charges],
                    Status = DataStatus.Created,
                    StatusDetail = new()
                    {
                        Code = "code",
                        Message = "message",
                        Reason = Reason.Unverified,
                        Source = Source.Watchtower,
                    },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Description = "description",
                    Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
                    PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                },
            ],
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                MaxPageSize = 0,
                PageNumber = 0,
                PageSize = 0,
                SortBy = "sort_by",
                SortOrder = Models::SortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = ResponseType.Object,
        };

        LinkedBankAccountPagedV1 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Data
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
            Purposes = [DataPurpose.Charges],
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Description = "description",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        string expectedAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DataBankAccount expectedBankAccount = new()
        {
            AccountHolder = "account_holder",
            AccountMask = "account_mask",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        List<ApiEnum<string, DataPurpose>> expectedPurposes = [DataPurpose.Charges];
        ApiEnum<string, DataStatus> expectedStatus = DataStatus.Created;
        StatusDetail expectedStatusDetail = new()
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
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
        var model = new Data
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
            Purposes = [DataPurpose.Charges],
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Description = "description",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Data
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
            Purposes = [DataPurpose.Charges],
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Description = "description",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        string expectedAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DataBankAccount expectedBankAccount = new()
        {
            AccountHolder = "account_holder",
            AccountMask = "account_mask",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        List<ApiEnum<string, DataPurpose>> expectedPurposes = [DataPurpose.Charges];
        ApiEnum<string, DataStatus> expectedStatus = DataStatus.Created;
        StatusDetail expectedStatusDetail = new()
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
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
        var model = new Data
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
            Purposes = [DataPurpose.Charges],
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
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
        var model = new Data
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
            Purposes = [DataPurpose.Charges],
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
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
        var model = new Data
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
            Purposes = [DataPurpose.Charges],
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Data
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
            Purposes = [DataPurpose.Charges],
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
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
        var model = new Data
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
            Purposes = [DataPurpose.Charges],
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),

            Description = null,
            Metadata = null,
            PlatformID = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Data
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
            Purposes = [DataPurpose.Charges],
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Description = "description",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DataBankAccountTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new DataBankAccount
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
        var model = new DataBankAccount
        {
            AccountHolder = "account_holder",
            AccountMask = "account_mask",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<DataBankAccount>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new DataBankAccount
        {
            AccountHolder = "account_holder",
            AccountMask = "account_mask",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<DataBankAccount>(
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
        var model = new DataBankAccount
        {
            AccountHolder = "account_holder",
            AccountMask = "account_mask",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new DataBankAccount
        {
            AccountHolder = "account_holder",
            AccountMask = "account_mask",
            InstitutionName = "institution_name",
            RoutingNumber = "routing_number",
        };

        DataBankAccount copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DataPurposeTest : TestBase
{
    [Theory]
    [InlineData(DataPurpose.Charges)]
    [InlineData(DataPurpose.Payouts)]
    [InlineData(DataPurpose.Billing)]
    public void Validation_Works(DataPurpose rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataPurpose> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataPurpose>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(DataPurpose.Charges)]
    [InlineData(DataPurpose.Payouts)]
    [InlineData(DataPurpose.Billing)]
    public void SerializationRoundtrip_Works(DataPurpose rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataPurpose> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataPurpose>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataPurpose>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataPurpose>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class DataStatusTest : TestBase
{
    [Theory]
    [InlineData(DataStatus.Created)]
    [InlineData(DataStatus.Onboarding)]
    [InlineData(DataStatus.Active)]
    [InlineData(DataStatus.Rejected)]
    [InlineData(DataStatus.Inactive)]
    [InlineData(DataStatus.Canceled)]
    public void Validation_Works(DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(DataStatus.Created)]
    [InlineData(DataStatus.Onboarding)]
    [InlineData(DataStatus.Active)]
    [InlineData(DataStatus.Rejected)]
    [InlineData(DataStatus.Inactive)]
    [InlineData(DataStatus.Canceled)]
    public void SerializationRoundtrip_Works(DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class StatusDetailTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new StatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
        };

        string expectedCode = "code";
        string expectedMessage = "message";
        ApiEnum<string, Reason> expectedReason = Reason.Unverified;
        ApiEnum<string, Source> expectedSource = Source.Watchtower;

        Assert.Equal(expectedCode, model.Code);
        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedReason, model.Reason);
        Assert.Equal(expectedSource, model.Source);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new StatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<StatusDetail>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new StatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<StatusDetail>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedCode = "code";
        string expectedMessage = "message";
        ApiEnum<string, Reason> expectedReason = Reason.Unverified;
        ApiEnum<string, Source> expectedSource = Source.Watchtower;

        Assert.Equal(expectedCode, deserialized.Code);
        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedReason, deserialized.Reason);
        Assert.Equal(expectedSource, deserialized.Source);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new StatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new StatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
        };

        StatusDetail copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class ReasonTest : TestBase
{
    [Theory]
    [InlineData(Reason.Unverified)]
    [InlineData(Reason.InReview)]
    [InlineData(Reason.Pending)]
    [InlineData(Reason.Stuck)]
    [InlineData(Reason.Verified)]
    [InlineData(Reason.FailedVerification)]
    [InlineData(Reason.Disabled)]
    [InlineData(Reason.New)]
    public void Validation_Works(Reason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Reason> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Reason>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Reason.Unverified)]
    [InlineData(Reason.InReview)]
    [InlineData(Reason.Pending)]
    [InlineData(Reason.Stuck)]
    [InlineData(Reason.Verified)]
    [InlineData(Reason.FailedVerification)]
    [InlineData(Reason.Disabled)]
    [InlineData(Reason.New)]
    public void SerializationRoundtrip_Works(Reason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Reason> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Reason>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Reason>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Reason>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class SourceTest : TestBase
{
    [Theory]
    [InlineData(Source.Watchtower)]
    public void Validation_Works(Source rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Source> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Source>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Source.Watchtower)]
    public void SerializationRoundtrip_Works(Source rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Source> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Source>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Source>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Source>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class ResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(ResponseType.Object)]
    [InlineData(ResponseType.Array)]
    [InlineData(ResponseType.Error)]
    [InlineData(ResponseType.None)]
    public void Validation_Works(ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ResponseType.Object)]
    [InlineData(ResponseType.Array)]
    [InlineData(ResponseType.Error)]
    [InlineData(ResponseType.None)]
    public void SerializationRoundtrip_Works(ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ResponseType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ResponseType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
