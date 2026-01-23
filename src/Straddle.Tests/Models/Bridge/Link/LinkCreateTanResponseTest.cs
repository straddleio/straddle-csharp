using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models;
using Straddle.Models.Bridge.Link;

namespace Straddle.Tests.Models.Bridge.Link;

public class LinkCreateTanResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkCreateTanResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                    SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "Bank of America ****1234",
                Paykey = "paykey",
                Source = LinkCreateTanResponseDataSource.Straddle,
                Status = LinkCreateTanResponseDataStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = LinkCreateTanResponseDataBalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
                    RoutingNumber = "021000021",
                },
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                InstitutionName = "Bank of America",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
                    Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = LinkCreateTanResponseResponseType.Object,
        };

        LinkCreateTanResponseData expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = LinkCreateTanResponseDataSource.Straddle,
            Status = LinkCreateTanResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = LinkCreateTanResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
                Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, LinkCreateTanResponseResponseType> expectedResponseType =
            LinkCreateTanResponseResponseType.Object;

        Assert.Equal(expectedData, model.Data);
        Assert.Equal(expectedMeta, model.Meta);
        Assert.Equal(expectedResponseType, model.ResponseType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LinkCreateTanResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                    SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "Bank of America ****1234",
                Paykey = "paykey",
                Source = LinkCreateTanResponseDataSource.Straddle,
                Status = LinkCreateTanResponseDataStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = LinkCreateTanResponseDataBalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
                    RoutingNumber = "021000021",
                },
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                InstitutionName = "Bank of America",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
                    Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = LinkCreateTanResponseResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkCreateTanResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkCreateTanResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                    SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "Bank of America ****1234",
                Paykey = "paykey",
                Source = LinkCreateTanResponseDataSource.Straddle,
                Status = LinkCreateTanResponseDataStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = LinkCreateTanResponseDataBalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
                    RoutingNumber = "021000021",
                },
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                InstitutionName = "Bank of America",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
                    Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = LinkCreateTanResponseResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkCreateTanResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        LinkCreateTanResponseData expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = LinkCreateTanResponseDataSource.Straddle,
            Status = LinkCreateTanResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = LinkCreateTanResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
                Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, LinkCreateTanResponseResponseType> expectedResponseType =
            LinkCreateTanResponseResponseType.Object;

        Assert.Equal(expectedData, deserialized.Data);
        Assert.Equal(expectedMeta, deserialized.Meta);
        Assert.Equal(expectedResponseType, deserialized.ResponseType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LinkCreateTanResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                    SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "Bank of America ****1234",
                Paykey = "paykey",
                Source = LinkCreateTanResponseDataSource.Straddle,
                Status = LinkCreateTanResponseDataStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = LinkCreateTanResponseDataBalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
                    RoutingNumber = "021000021",
                },
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                InstitutionName = "Bank of America",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
                    Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = LinkCreateTanResponseResponseType.Object,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new LinkCreateTanResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                    SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "Bank of America ****1234",
                Paykey = "paykey",
                Source = LinkCreateTanResponseDataSource.Straddle,
                Status = LinkCreateTanResponseDataStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = LinkCreateTanResponseDataBalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
                    RoutingNumber = "021000021",
                },
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                InstitutionName = "Bank of America",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
                    Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = LinkCreateTanResponseResponseType.Object,
        };

        LinkCreateTanResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class LinkCreateTanResponseDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkCreateTanResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = LinkCreateTanResponseDataSource.Straddle,
            Status = LinkCreateTanResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = LinkCreateTanResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
                Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        LinkCreateTanResponseDataConfig expectedConfig = new()
        {
            ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
            SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedLabel = "Bank of America ****1234";
        string expectedPaykey = "paykey";
        ApiEnum<string, LinkCreateTanResponseDataSource> expectedSource =
            LinkCreateTanResponseDataSource.Straddle;
        ApiEnum<string, LinkCreateTanResponseDataStatus> expectedStatus =
            LinkCreateTanResponseDataStatus.Pending;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        LinkCreateTanResponseDataBalance expectedBalance = new()
        {
            Status = LinkCreateTanResponseDataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        LinkCreateTanResponseDataBankData expectedBankData = new()
        {
            AccountNumber = "****1234",
            AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };
        string expectedCustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";
        string expectedInstitutionName = "Bank of America";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        LinkCreateTanResponseDataStatusDetails expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
            Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedConfig, model.Config);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedLabel, model.Label);
        Assert.Equal(expectedPaykey, model.Paykey);
        Assert.Equal(expectedSource, model.Source);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
        Assert.Equal(expectedBalance, model.Balance);
        Assert.Equal(expectedBankData, model.BankData);
        Assert.Equal(expectedCustomerID, model.CustomerID);
        Assert.Equal(expectedExpiresAt, model.ExpiresAt);
        Assert.Equal(expectedExternalID, model.ExternalID);
        Assert.Equal(expectedInstitutionName, model.InstitutionName);
        Assert.NotNull(model.Metadata);
        Assert.Equal(expectedMetadata.Count, model.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(model.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Metadata[item.Key]);
        }
        Assert.Equal(expectedStatusDetails, model.StatusDetails);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LinkCreateTanResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = LinkCreateTanResponseDataSource.Straddle,
            Status = LinkCreateTanResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = LinkCreateTanResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
                Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkCreateTanResponseData>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkCreateTanResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = LinkCreateTanResponseDataSource.Straddle,
            Status = LinkCreateTanResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = LinkCreateTanResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
                Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkCreateTanResponseData>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        LinkCreateTanResponseDataConfig expectedConfig = new()
        {
            ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
            SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedLabel = "Bank of America ****1234";
        string expectedPaykey = "paykey";
        ApiEnum<string, LinkCreateTanResponseDataSource> expectedSource =
            LinkCreateTanResponseDataSource.Straddle;
        ApiEnum<string, LinkCreateTanResponseDataStatus> expectedStatus =
            LinkCreateTanResponseDataStatus.Pending;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        LinkCreateTanResponseDataBalance expectedBalance = new()
        {
            Status = LinkCreateTanResponseDataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        LinkCreateTanResponseDataBankData expectedBankData = new()
        {
            AccountNumber = "****1234",
            AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };
        string expectedCustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";
        string expectedInstitutionName = "Bank of America";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        LinkCreateTanResponseDataStatusDetails expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
            Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedConfig, deserialized.Config);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedLabel, deserialized.Label);
        Assert.Equal(expectedPaykey, deserialized.Paykey);
        Assert.Equal(expectedSource, deserialized.Source);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
        Assert.Equal(expectedBalance, deserialized.Balance);
        Assert.Equal(expectedBankData, deserialized.BankData);
        Assert.Equal(expectedCustomerID, deserialized.CustomerID);
        Assert.Equal(expectedExpiresAt, deserialized.ExpiresAt);
        Assert.Equal(expectedExternalID, deserialized.ExternalID);
        Assert.Equal(expectedInstitutionName, deserialized.InstitutionName);
        Assert.NotNull(deserialized.Metadata);
        Assert.Equal(expectedMetadata.Count, deserialized.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(deserialized.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Metadata[item.Key]);
        }
        Assert.Equal(expectedStatusDetails, deserialized.StatusDetails);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LinkCreateTanResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = LinkCreateTanResponseDataSource.Straddle,
            Status = LinkCreateTanResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = LinkCreateTanResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
                Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new LinkCreateTanResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = LinkCreateTanResponseDataSource.Straddle,
            Status = LinkCreateTanResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        Assert.Null(model.Balance);
        Assert.False(model.RawData.ContainsKey("balance"));
        Assert.Null(model.BankData);
        Assert.False(model.RawData.ContainsKey("bank_data"));
        Assert.Null(model.StatusDetails);
        Assert.False(model.RawData.ContainsKey("status_details"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new LinkCreateTanResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = LinkCreateTanResponseDataSource.Straddle,
            Status = LinkCreateTanResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new LinkCreateTanResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = LinkCreateTanResponseDataSource.Straddle,
            Status = LinkCreateTanResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },

            // Null should be interpreted as omitted for these properties
            Balance = null,
            BankData = null,
            StatusDetails = null,
        };

        Assert.Null(model.Balance);
        Assert.False(model.RawData.ContainsKey("balance"));
        Assert.Null(model.BankData);
        Assert.False(model.RawData.ContainsKey("bank_data"));
        Assert.Null(model.StatusDetails);
        Assert.False(model.RawData.ContainsKey("status_details"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new LinkCreateTanResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = LinkCreateTanResponseDataSource.Straddle,
            Status = LinkCreateTanResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },

            // Null should be interpreted as omitted for these properties
            Balance = null,
            BankData = null,
            StatusDetails = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new LinkCreateTanResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = LinkCreateTanResponseDataSource.Straddle,
            Status = LinkCreateTanResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = LinkCreateTanResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
                Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        Assert.Null(model.CustomerID);
        Assert.False(model.RawData.ContainsKey("customer_id"));
        Assert.Null(model.ExpiresAt);
        Assert.False(model.RawData.ContainsKey("expires_at"));
        Assert.Null(model.ExternalID);
        Assert.False(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.InstitutionName);
        Assert.False(model.RawData.ContainsKey("institution_name"));
        Assert.Null(model.Metadata);
        Assert.False(model.RawData.ContainsKey("metadata"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new LinkCreateTanResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = LinkCreateTanResponseDataSource.Straddle,
            Status = LinkCreateTanResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = LinkCreateTanResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
                Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new LinkCreateTanResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = LinkCreateTanResponseDataSource.Straddle,
            Status = LinkCreateTanResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = LinkCreateTanResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
                Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },

            CustomerID = null,
            ExpiresAt = null,
            ExternalID = null,
            InstitutionName = null,
            Metadata = null,
        };

        Assert.Null(model.CustomerID);
        Assert.True(model.RawData.ContainsKey("customer_id"));
        Assert.Null(model.ExpiresAt);
        Assert.True(model.RawData.ContainsKey("expires_at"));
        Assert.Null(model.ExternalID);
        Assert.True(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.InstitutionName);
        Assert.True(model.RawData.ContainsKey("institution_name"));
        Assert.Null(model.Metadata);
        Assert.True(model.RawData.ContainsKey("metadata"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new LinkCreateTanResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = LinkCreateTanResponseDataSource.Straddle,
            Status = LinkCreateTanResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = LinkCreateTanResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
                Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },

            CustomerID = null,
            ExpiresAt = null,
            ExternalID = null,
            InstitutionName = null,
            Metadata = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new LinkCreateTanResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = LinkCreateTanResponseDataSource.Straddle,
            Status = LinkCreateTanResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = LinkCreateTanResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
                Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        LinkCreateTanResponseData copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class LinkCreateTanResponseDataConfigTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkCreateTanResponseDataConfig
        {
            ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
            SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
        };

        ApiEnum<string, LinkCreateTanResponseDataConfigProcessingMethod> expectedProcessingMethod =
            LinkCreateTanResponseDataConfigProcessingMethod.Inline;
        ApiEnum<string, LinkCreateTanResponseDataConfigSandboxOutcome> expectedSandboxOutcome =
            LinkCreateTanResponseDataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, model.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, model.SandboxOutcome);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LinkCreateTanResponseDataConfig
        {
            ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
            SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkCreateTanResponseDataConfig>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkCreateTanResponseDataConfig
        {
            ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
            SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkCreateTanResponseDataConfig>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, LinkCreateTanResponseDataConfigProcessingMethod> expectedProcessingMethod =
            LinkCreateTanResponseDataConfigProcessingMethod.Inline;
        ApiEnum<string, LinkCreateTanResponseDataConfigSandboxOutcome> expectedSandboxOutcome =
            LinkCreateTanResponseDataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, deserialized.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, deserialized.SandboxOutcome);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LinkCreateTanResponseDataConfig
        {
            ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
            SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new LinkCreateTanResponseDataConfig { };

        Assert.Null(model.ProcessingMethod);
        Assert.False(model.RawData.ContainsKey("processing_method"));
        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new LinkCreateTanResponseDataConfig { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new LinkCreateTanResponseDataConfig
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
        var model = new LinkCreateTanResponseDataConfig
        {
            // Null should be interpreted as omitted for these properties
            ProcessingMethod = null,
            SandboxOutcome = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new LinkCreateTanResponseDataConfig
        {
            ProcessingMethod = LinkCreateTanResponseDataConfigProcessingMethod.Inline,
            SandboxOutcome = LinkCreateTanResponseDataConfigSandboxOutcome.Standard,
        };

        LinkCreateTanResponseDataConfig copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class LinkCreateTanResponseDataConfigProcessingMethodTest : TestBase
{
    [Theory]
    [InlineData(LinkCreateTanResponseDataConfigProcessingMethod.Inline)]
    [InlineData(LinkCreateTanResponseDataConfigProcessingMethod.Background)]
    [InlineData(LinkCreateTanResponseDataConfigProcessingMethod.Skip)]
    public void Validation_Works(LinkCreateTanResponseDataConfigProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseDataConfigProcessingMethod> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataConfigProcessingMethod>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkCreateTanResponseDataConfigProcessingMethod.Inline)]
    [InlineData(LinkCreateTanResponseDataConfigProcessingMethod.Background)]
    [InlineData(LinkCreateTanResponseDataConfigProcessingMethod.Skip)]
    public void SerializationRoundtrip_Works(
        LinkCreateTanResponseDataConfigProcessingMethod rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseDataConfigProcessingMethod> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataConfigProcessingMethod>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataConfigProcessingMethod>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataConfigProcessingMethod>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class LinkCreateTanResponseDataConfigSandboxOutcomeTest : TestBase
{
    [Theory]
    [InlineData(LinkCreateTanResponseDataConfigSandboxOutcome.Standard)]
    [InlineData(LinkCreateTanResponseDataConfigSandboxOutcome.Active)]
    [InlineData(LinkCreateTanResponseDataConfigSandboxOutcome.Rejected)]
    [InlineData(LinkCreateTanResponseDataConfigSandboxOutcome.Review)]
    public void Validation_Works(LinkCreateTanResponseDataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseDataConfigSandboxOutcome> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataConfigSandboxOutcome>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkCreateTanResponseDataConfigSandboxOutcome.Standard)]
    [InlineData(LinkCreateTanResponseDataConfigSandboxOutcome.Active)]
    [InlineData(LinkCreateTanResponseDataConfigSandboxOutcome.Rejected)]
    [InlineData(LinkCreateTanResponseDataConfigSandboxOutcome.Review)]
    public void SerializationRoundtrip_Works(LinkCreateTanResponseDataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseDataConfigSandboxOutcome> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataConfigSandboxOutcome>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataConfigSandboxOutcome>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataConfigSandboxOutcome>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class LinkCreateTanResponseDataSourceTest : TestBase
{
    [Theory]
    [InlineData(LinkCreateTanResponseDataSource.BankAccount)]
    [InlineData(LinkCreateTanResponseDataSource.Straddle)]
    [InlineData(LinkCreateTanResponseDataSource.Mx)]
    [InlineData(LinkCreateTanResponseDataSource.Plaid)]
    [InlineData(LinkCreateTanResponseDataSource.Tan)]
    [InlineData(LinkCreateTanResponseDataSource.Quiltt)]
    public void Validation_Works(LinkCreateTanResponseDataSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseDataSource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, LinkCreateTanResponseDataSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkCreateTanResponseDataSource.BankAccount)]
    [InlineData(LinkCreateTanResponseDataSource.Straddle)]
    [InlineData(LinkCreateTanResponseDataSource.Mx)]
    [InlineData(LinkCreateTanResponseDataSource.Plaid)]
    [InlineData(LinkCreateTanResponseDataSource.Tan)]
    [InlineData(LinkCreateTanResponseDataSource.Quiltt)]
    public void SerializationRoundtrip_Works(LinkCreateTanResponseDataSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseDataSource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, LinkCreateTanResponseDataSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class LinkCreateTanResponseDataStatusTest : TestBase
{
    [Theory]
    [InlineData(LinkCreateTanResponseDataStatus.Pending)]
    [InlineData(LinkCreateTanResponseDataStatus.Active)]
    [InlineData(LinkCreateTanResponseDataStatus.Inactive)]
    [InlineData(LinkCreateTanResponseDataStatus.Rejected)]
    [InlineData(LinkCreateTanResponseDataStatus.Review)]
    [InlineData(LinkCreateTanResponseDataStatus.Blocked)]
    public void Validation_Works(LinkCreateTanResponseDataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseDataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, LinkCreateTanResponseDataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkCreateTanResponseDataStatus.Pending)]
    [InlineData(LinkCreateTanResponseDataStatus.Active)]
    [InlineData(LinkCreateTanResponseDataStatus.Inactive)]
    [InlineData(LinkCreateTanResponseDataStatus.Rejected)]
    [InlineData(LinkCreateTanResponseDataStatus.Review)]
    [InlineData(LinkCreateTanResponseDataStatus.Blocked)]
    public void SerializationRoundtrip_Works(LinkCreateTanResponseDataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseDataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, LinkCreateTanResponseDataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class LinkCreateTanResponseDataBalanceTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkCreateTanResponseDataBalance
        {
            Status = LinkCreateTanResponseDataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        ApiEnum<string, LinkCreateTanResponseDataBalanceStatus> expectedStatus =
            LinkCreateTanResponseDataBalanceStatus.Pending;
        int expectedAccountBalance = 0;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedAccountBalance, model.AccountBalance);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LinkCreateTanResponseDataBalance
        {
            Status = LinkCreateTanResponseDataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkCreateTanResponseDataBalance>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkCreateTanResponseDataBalance
        {
            Status = LinkCreateTanResponseDataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkCreateTanResponseDataBalance>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, LinkCreateTanResponseDataBalanceStatus> expectedStatus =
            LinkCreateTanResponseDataBalanceStatus.Pending;
        int expectedAccountBalance = 0;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedAccountBalance, deserialized.AccountBalance);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LinkCreateTanResponseDataBalance
        {
            Status = LinkCreateTanResponseDataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new LinkCreateTanResponseDataBalance
        {
            Status = LinkCreateTanResponseDataBalanceStatus.Pending,
        };

        Assert.Null(model.AccountBalance);
        Assert.False(model.RawData.ContainsKey("account_balance"));
        Assert.Null(model.UpdatedAt);
        Assert.False(model.RawData.ContainsKey("updated_at"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new LinkCreateTanResponseDataBalance
        {
            Status = LinkCreateTanResponseDataBalanceStatus.Pending,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new LinkCreateTanResponseDataBalance
        {
            Status = LinkCreateTanResponseDataBalanceStatus.Pending,

            AccountBalance = null,
            UpdatedAt = null,
        };

        Assert.Null(model.AccountBalance);
        Assert.True(model.RawData.ContainsKey("account_balance"));
        Assert.Null(model.UpdatedAt);
        Assert.True(model.RawData.ContainsKey("updated_at"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new LinkCreateTanResponseDataBalance
        {
            Status = LinkCreateTanResponseDataBalanceStatus.Pending,

            AccountBalance = null,
            UpdatedAt = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new LinkCreateTanResponseDataBalance
        {
            Status = LinkCreateTanResponseDataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        LinkCreateTanResponseDataBalance copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class LinkCreateTanResponseDataBalanceStatusTest : TestBase
{
    [Theory]
    [InlineData(LinkCreateTanResponseDataBalanceStatus.Pending)]
    [InlineData(LinkCreateTanResponseDataBalanceStatus.Completed)]
    [InlineData(LinkCreateTanResponseDataBalanceStatus.Failed)]
    public void Validation_Works(LinkCreateTanResponseDataBalanceStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseDataBalanceStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataBalanceStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkCreateTanResponseDataBalanceStatus.Pending)]
    [InlineData(LinkCreateTanResponseDataBalanceStatus.Completed)]
    [InlineData(LinkCreateTanResponseDataBalanceStatus.Failed)]
    public void SerializationRoundtrip_Works(LinkCreateTanResponseDataBalanceStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseDataBalanceStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataBalanceStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataBalanceStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataBalanceStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class LinkCreateTanResponseDataBankDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkCreateTanResponseDataBankData
        {
            AccountNumber = "****1234",
            AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        string expectedAccountNumber = "****1234";
        ApiEnum<string, LinkCreateTanResponseDataBankDataAccountType> expectedAccountType =
            LinkCreateTanResponseDataBankDataAccountType.Checking;
        string expectedRoutingNumber = "021000021";

        Assert.Equal(expectedAccountNumber, model.AccountNumber);
        Assert.Equal(expectedAccountType, model.AccountType);
        Assert.Equal(expectedRoutingNumber, model.RoutingNumber);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LinkCreateTanResponseDataBankData
        {
            AccountNumber = "****1234",
            AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkCreateTanResponseDataBankData>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkCreateTanResponseDataBankData
        {
            AccountNumber = "****1234",
            AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkCreateTanResponseDataBankData>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedAccountNumber = "****1234";
        ApiEnum<string, LinkCreateTanResponseDataBankDataAccountType> expectedAccountType =
            LinkCreateTanResponseDataBankDataAccountType.Checking;
        string expectedRoutingNumber = "021000021";

        Assert.Equal(expectedAccountNumber, deserialized.AccountNumber);
        Assert.Equal(expectedAccountType, deserialized.AccountType);
        Assert.Equal(expectedRoutingNumber, deserialized.RoutingNumber);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LinkCreateTanResponseDataBankData
        {
            AccountNumber = "****1234",
            AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new LinkCreateTanResponseDataBankData
        {
            AccountNumber = "****1234",
            AccountType = LinkCreateTanResponseDataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        LinkCreateTanResponseDataBankData copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class LinkCreateTanResponseDataBankDataAccountTypeTest : TestBase
{
    [Theory]
    [InlineData(LinkCreateTanResponseDataBankDataAccountType.Checking)]
    [InlineData(LinkCreateTanResponseDataBankDataAccountType.Savings)]
    public void Validation_Works(LinkCreateTanResponseDataBankDataAccountType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseDataBankDataAccountType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataBankDataAccountType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkCreateTanResponseDataBankDataAccountType.Checking)]
    [InlineData(LinkCreateTanResponseDataBankDataAccountType.Savings)]
    public void SerializationRoundtrip_Works(LinkCreateTanResponseDataBankDataAccountType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseDataBankDataAccountType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataBankDataAccountType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataBankDataAccountType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataBankDataAccountType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class LinkCreateTanResponseDataStatusDetailsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkCreateTanResponseDataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
            Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Bank account sucesfully validated";
        ApiEnum<string, LinkCreateTanResponseDataStatusDetailsReason> expectedReason =
            LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds;
        ApiEnum<string, LinkCreateTanResponseDataStatusDetailsSource> expectedSource =
            LinkCreateTanResponseDataStatusDetailsSource.Watchtower;
        string expectedCode = "code";

        Assert.Equal(expectedChangedAt, model.ChangedAt);
        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedReason, model.Reason);
        Assert.Equal(expectedSource, model.Source);
        Assert.Equal(expectedCode, model.Code);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LinkCreateTanResponseDataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
            Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkCreateTanResponseDataStatusDetails>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkCreateTanResponseDataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
            Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkCreateTanResponseDataStatusDetails>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Bank account sucesfully validated";
        ApiEnum<string, LinkCreateTanResponseDataStatusDetailsReason> expectedReason =
            LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds;
        ApiEnum<string, LinkCreateTanResponseDataStatusDetailsSource> expectedSource =
            LinkCreateTanResponseDataStatusDetailsSource.Watchtower;
        string expectedCode = "code";

        Assert.Equal(expectedChangedAt, deserialized.ChangedAt);
        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedReason, deserialized.Reason);
        Assert.Equal(expectedSource, deserialized.Source);
        Assert.Equal(expectedCode, deserialized.Code);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LinkCreateTanResponseDataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
            Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new LinkCreateTanResponseDataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
            Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
        };

        Assert.Null(model.Code);
        Assert.False(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new LinkCreateTanResponseDataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
            Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new LinkCreateTanResponseDataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
            Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,

            Code = null,
        };

        Assert.Null(model.Code);
        Assert.True(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new LinkCreateTanResponseDataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
            Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,

            Code = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new LinkCreateTanResponseDataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds,
            Source = LinkCreateTanResponseDataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        LinkCreateTanResponseDataStatusDetails copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class LinkCreateTanResponseDataStatusDetailsReasonTest : TestBase
{
    [Theory]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.ClosedBankAccount)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.InvalidBankAccount)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.InvalidRouting)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.Disputed)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.PaymentStopped)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.OwnerDeceased)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.FrozenBankAccount)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.RiskReview)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.Fraudulent)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.DuplicateEntry)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.InvalidPaykey)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.PaymentBlocked)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.AmountTooLarge)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.TooManyAttempts)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.InternalSystemError)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.UserRequest)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.Ok)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.OtherNetworkReturn)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.PayoutRefused)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.CancelRequest)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.FailedVerification)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.RequireReview)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.BlockedBySystem)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.WatchtowerReview)]
    public void Validation_Works(LinkCreateTanResponseDataStatusDetailsReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseDataStatusDetailsReason> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataStatusDetailsReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.InsufficientFunds)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.ClosedBankAccount)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.InvalidBankAccount)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.InvalidRouting)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.Disputed)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.PaymentStopped)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.OwnerDeceased)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.FrozenBankAccount)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.RiskReview)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.Fraudulent)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.DuplicateEntry)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.InvalidPaykey)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.PaymentBlocked)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.AmountTooLarge)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.TooManyAttempts)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.InternalSystemError)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.UserRequest)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.Ok)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.OtherNetworkReturn)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.PayoutRefused)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.CancelRequest)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.FailedVerification)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.RequireReview)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.BlockedBySystem)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsReason.WatchtowerReview)]
    public void SerializationRoundtrip_Works(LinkCreateTanResponseDataStatusDetailsReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseDataStatusDetailsReason> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataStatusDetailsReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataStatusDetailsReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataStatusDetailsReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class LinkCreateTanResponseDataStatusDetailsSourceTest : TestBase
{
    [Theory]
    [InlineData(LinkCreateTanResponseDataStatusDetailsSource.Watchtower)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsSource.BankDecline)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsSource.CustomerDispute)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsSource.UserAction)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsSource.System)]
    public void Validation_Works(LinkCreateTanResponseDataStatusDetailsSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseDataStatusDetailsSource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataStatusDetailsSource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkCreateTanResponseDataStatusDetailsSource.Watchtower)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsSource.BankDecline)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsSource.CustomerDispute)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsSource.UserAction)]
    [InlineData(LinkCreateTanResponseDataStatusDetailsSource.System)]
    public void SerializationRoundtrip_Works(LinkCreateTanResponseDataStatusDetailsSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseDataStatusDetailsSource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataStatusDetailsSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataStatusDetailsSource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseDataStatusDetailsSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class LinkCreateTanResponseResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(LinkCreateTanResponseResponseType.Object)]
    [InlineData(LinkCreateTanResponseResponseType.Array)]
    [InlineData(LinkCreateTanResponseResponseType.Error)]
    [InlineData(LinkCreateTanResponseResponseType.None)]
    public void Validation_Works(LinkCreateTanResponseResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, LinkCreateTanResponseResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(LinkCreateTanResponseResponseType.Object)]
    [InlineData(LinkCreateTanResponseResponseType.Array)]
    [InlineData(LinkCreateTanResponseResponseType.Error)]
    [InlineData(LinkCreateTanResponseResponseType.None)]
    public void SerializationRoundtrip_Works(LinkCreateTanResponseResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, LinkCreateTanResponseResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, LinkCreateTanResponseResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, LinkCreateTanResponseResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}
