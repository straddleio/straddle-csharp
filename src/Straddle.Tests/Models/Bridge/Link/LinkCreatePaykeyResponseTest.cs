using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Bridge.Link;
using Models = Straddle.Models;

namespace Straddle.Tests.Models.Bridge.Link;

public class LinkCreatePaykeyResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new LinkCreatePaykeyResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = DataConfigProcessingMethod.Inline,
                    SandboxOutcome = DataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "Bank of America ****1234",
                Paykey = "paykey",
                Source = Source.Straddle,
                Status = Status.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = BankDataAccountType.Checking,
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
                    Reason = Reason.InsufficientFunds,
                    Source = StatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ResponseType.Object,
        };

        Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = DataConfigProcessingMethod.Inline,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = Source.Straddle,
            Status = Status.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = BankDataAccountType.Checking,
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
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },
        };
        Models::ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, ResponseType> expectedResponseType = ResponseType.Object;

        Assert.Equal(expectedData, model.Data);
        Assert.Equal(expectedMeta, model.Meta);
        Assert.Equal(expectedResponseType, model.ResponseType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new LinkCreatePaykeyResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = DataConfigProcessingMethod.Inline,
                    SandboxOutcome = DataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "Bank of America ****1234",
                Paykey = "paykey",
                Source = Source.Straddle,
                Status = Status.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = BankDataAccountType.Checking,
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
                    Reason = Reason.InsufficientFunds,
                    Source = StatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkCreatePaykeyResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new LinkCreatePaykeyResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = DataConfigProcessingMethod.Inline,
                    SandboxOutcome = DataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "Bank of America ****1234",
                Paykey = "paykey",
                Source = Source.Straddle,
                Status = Status.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = BankDataAccountType.Checking,
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
                    Reason = Reason.InsufficientFunds,
                    Source = StatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<LinkCreatePaykeyResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = DataConfigProcessingMethod.Inline,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = Source.Straddle,
            Status = Status.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = BankDataAccountType.Checking,
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
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },
        };
        Models::ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, ResponseType> expectedResponseType = ResponseType.Object;

        Assert.Equal(expectedData, deserialized.Data);
        Assert.Equal(expectedMeta, deserialized.Meta);
        Assert.Equal(expectedResponseType, deserialized.ResponseType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new LinkCreatePaykeyResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = DataConfigProcessingMethod.Inline,
                    SandboxOutcome = DataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "Bank of America ****1234",
                Paykey = "paykey",
                Source = Source.Straddle,
                Status = Status.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = BankDataAccountType.Checking,
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
                    Reason = Reason.InsufficientFunds,
                    Source = StatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ResponseType.Object,
        };

        model.Validate();
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
            Config = new()
            {
                ProcessingMethod = DataConfigProcessingMethod.Inline,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = Source.Straddle,
            Status = Status.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = BankDataAccountType.Checking,
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
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DataConfig expectedConfig = new()
        {
            ProcessingMethod = DataConfigProcessingMethod.Inline,
            SandboxOutcome = DataConfigSandboxOutcome.Standard,
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedLabel = "Bank of America ****1234";
        string expectedPaykey = "paykey";
        ApiEnum<string, Source> expectedSource = Source.Straddle;
        ApiEnum<string, Status> expectedStatus = Status.Pending;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        Balance expectedBalance = new()
        {
            Status = BalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        BankData expectedBankData = new()
        {
            AccountNumber = "****1234",
            AccountType = BankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };
        string expectedCustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";
        string expectedInstitutionName = "Bank of America";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        StatusDetails expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = DataConfigProcessingMethod.Inline,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = Source.Straddle,
            Status = Status.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = BankDataAccountType.Checking,
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
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },
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
            Config = new()
            {
                ProcessingMethod = DataConfigProcessingMethod.Inline,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = Source.Straddle,
            Status = Status.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = BankDataAccountType.Checking,
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
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DataConfig expectedConfig = new()
        {
            ProcessingMethod = DataConfigProcessingMethod.Inline,
            SandboxOutcome = DataConfigSandboxOutcome.Standard,
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedLabel = "Bank of America ****1234";
        string expectedPaykey = "paykey";
        ApiEnum<string, Source> expectedSource = Source.Straddle;
        ApiEnum<string, Status> expectedStatus = Status.Pending;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        Balance expectedBalance = new()
        {
            Status = BalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        BankData expectedBankData = new()
        {
            AccountNumber = "****1234",
            AccountType = BankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };
        string expectedCustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";
        string expectedInstitutionName = "Bank of America";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        StatusDetails expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = DataConfigProcessingMethod.Inline,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = Source.Straddle,
            Status = Status.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = BankDataAccountType.Checking,
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
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = DataConfigProcessingMethod.Inline,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = Source.Straddle,
            Status = Status.Pending,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = DataConfigProcessingMethod.Inline,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = Source.Straddle,
            Status = Status.Pending,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = DataConfigProcessingMethod.Inline,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = Source.Straddle,
            Status = Status.Pending,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = DataConfigProcessingMethod.Inline,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = Source.Straddle,
            Status = Status.Pending,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = DataConfigProcessingMethod.Inline,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = Source.Straddle,
            Status = Status.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = BankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = DataConfigProcessingMethod.Inline,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = Source.Straddle,
            Status = Status.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = BankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = DataConfigProcessingMethod.Inline,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = Source.Straddle,
            Status = Status.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = BankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = DataConfigProcessingMethod.Inline,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = Source.Straddle,
            Status = Status.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = BankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
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
}

public class DataConfigTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new DataConfig
        {
            ProcessingMethod = DataConfigProcessingMethod.Inline,
            SandboxOutcome = DataConfigSandboxOutcome.Standard,
        };

        ApiEnum<string, DataConfigProcessingMethod> expectedProcessingMethod =
            DataConfigProcessingMethod.Inline;
        ApiEnum<string, DataConfigSandboxOutcome> expectedSandboxOutcome =
            DataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, model.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, model.SandboxOutcome);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new DataConfig
        {
            ProcessingMethod = DataConfigProcessingMethod.Inline,
            SandboxOutcome = DataConfigSandboxOutcome.Standard,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<DataConfig>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new DataConfig
        {
            ProcessingMethod = DataConfigProcessingMethod.Inline,
            SandboxOutcome = DataConfigSandboxOutcome.Standard,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<DataConfig>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, DataConfigProcessingMethod> expectedProcessingMethod =
            DataConfigProcessingMethod.Inline;
        ApiEnum<string, DataConfigSandboxOutcome> expectedSandboxOutcome =
            DataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, deserialized.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, deserialized.SandboxOutcome);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new DataConfig
        {
            ProcessingMethod = DataConfigProcessingMethod.Inline,
            SandboxOutcome = DataConfigSandboxOutcome.Standard,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new DataConfig { };

        Assert.Null(model.ProcessingMethod);
        Assert.False(model.RawData.ContainsKey("processing_method"));
        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new DataConfig { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new DataConfig
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
        var model = new DataConfig
        {
            // Null should be interpreted as omitted for these properties
            ProcessingMethod = null,
            SandboxOutcome = null,
        };

        model.Validate();
    }
}

public class DataConfigProcessingMethodTest : TestBase
{
    [Theory]
    [InlineData(DataConfigProcessingMethod.Inline)]
    [InlineData(DataConfigProcessingMethod.Background)]
    [InlineData(DataConfigProcessingMethod.Skip)]
    public void Validation_Works(DataConfigProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataConfigProcessingMethod> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataConfigProcessingMethod>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(DataConfigProcessingMethod.Inline)]
    [InlineData(DataConfigProcessingMethod.Background)]
    [InlineData(DataConfigProcessingMethod.Skip)]
    public void SerializationRoundtrip_Works(DataConfigProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataConfigProcessingMethod> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataConfigProcessingMethod>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataConfigProcessingMethod>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataConfigProcessingMethod>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class DataConfigSandboxOutcomeTest : TestBase
{
    [Theory]
    [InlineData(DataConfigSandboxOutcome.Standard)]
    [InlineData(DataConfigSandboxOutcome.Active)]
    [InlineData(DataConfigSandboxOutcome.Rejected)]
    [InlineData(DataConfigSandboxOutcome.Review)]
    public void Validation_Works(DataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataConfigSandboxOutcome> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataConfigSandboxOutcome>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(DataConfigSandboxOutcome.Standard)]
    [InlineData(DataConfigSandboxOutcome.Active)]
    [InlineData(DataConfigSandboxOutcome.Rejected)]
    [InlineData(DataConfigSandboxOutcome.Review)]
    public void SerializationRoundtrip_Works(DataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataConfigSandboxOutcome> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataConfigSandboxOutcome>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataConfigSandboxOutcome>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataConfigSandboxOutcome>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class SourceTest : TestBase
{
    [Theory]
    [InlineData(Source.BankAccount)]
    [InlineData(Source.Straddle)]
    [InlineData(Source.Mx)]
    [InlineData(Source.Plaid)]
    [InlineData(Source.Tan)]
    [InlineData(Source.Quiltt)]
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
    [InlineData(Source.BankAccount)]
    [InlineData(Source.Straddle)]
    [InlineData(Source.Mx)]
    [InlineData(Source.Plaid)]
    [InlineData(Source.Tan)]
    [InlineData(Source.Quiltt)]
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

public class StatusTest : TestBase
{
    [Theory]
    [InlineData(Status.Pending)]
    [InlineData(Status.Active)]
    [InlineData(Status.Inactive)]
    [InlineData(Status.Rejected)]
    [InlineData(Status.Review)]
    [InlineData(Status.Blocked)]
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
    [InlineData(Status.Active)]
    [InlineData(Status.Inactive)]
    [InlineData(Status.Rejected)]
    [InlineData(Status.Review)]
    [InlineData(Status.Blocked)]
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

public class BalanceTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Balance
        {
            Status = BalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        ApiEnum<string, BalanceStatus> expectedStatus = BalanceStatus.Pending;
        int expectedAccountBalance = 0;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedAccountBalance, model.AccountBalance);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Balance
        {
            Status = BalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Balance>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Balance
        {
            Status = BalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Balance>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, BalanceStatus> expectedStatus = BalanceStatus.Pending;
        int expectedAccountBalance = 0;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedAccountBalance, deserialized.AccountBalance);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Balance
        {
            Status = BalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Balance { Status = BalanceStatus.Pending };

        Assert.Null(model.AccountBalance);
        Assert.False(model.RawData.ContainsKey("account_balance"));
        Assert.Null(model.UpdatedAt);
        Assert.False(model.RawData.ContainsKey("updated_at"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new Balance { Status = BalanceStatus.Pending };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Balance
        {
            Status = BalanceStatus.Pending,

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
        var model = new Balance
        {
            Status = BalanceStatus.Pending,

            AccountBalance = null,
            UpdatedAt = null,
        };

        model.Validate();
    }
}

public class BalanceStatusTest : TestBase
{
    [Theory]
    [InlineData(BalanceStatus.Pending)]
    [InlineData(BalanceStatus.Completed)]
    [InlineData(BalanceStatus.Failed)]
    public void Validation_Works(BalanceStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, BalanceStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, BalanceStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(BalanceStatus.Pending)]
    [InlineData(BalanceStatus.Completed)]
    [InlineData(BalanceStatus.Failed)]
    public void SerializationRoundtrip_Works(BalanceStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, BalanceStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, BalanceStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, BalanceStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, BalanceStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class BankDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new BankData
        {
            AccountNumber = "****1234",
            AccountType = BankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        string expectedAccountNumber = "****1234";
        ApiEnum<string, BankDataAccountType> expectedAccountType = BankDataAccountType.Checking;
        string expectedRoutingNumber = "021000021";

        Assert.Equal(expectedAccountNumber, model.AccountNumber);
        Assert.Equal(expectedAccountType, model.AccountType);
        Assert.Equal(expectedRoutingNumber, model.RoutingNumber);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new BankData
        {
            AccountNumber = "****1234",
            AccountType = BankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<BankData>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new BankData
        {
            AccountNumber = "****1234",
            AccountType = BankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<BankData>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedAccountNumber = "****1234";
        ApiEnum<string, BankDataAccountType> expectedAccountType = BankDataAccountType.Checking;
        string expectedRoutingNumber = "021000021";

        Assert.Equal(expectedAccountNumber, deserialized.AccountNumber);
        Assert.Equal(expectedAccountType, deserialized.AccountType);
        Assert.Equal(expectedRoutingNumber, deserialized.RoutingNumber);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new BankData
        {
            AccountNumber = "****1234",
            AccountType = BankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        model.Validate();
    }
}

public class BankDataAccountTypeTest : TestBase
{
    [Theory]
    [InlineData(BankDataAccountType.Checking)]
    [InlineData(BankDataAccountType.Savings)]
    public void Validation_Works(BankDataAccountType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, BankDataAccountType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, BankDataAccountType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(BankDataAccountType.Checking)]
    [InlineData(BankDataAccountType.Savings)]
    public void SerializationRoundtrip_Works(BankDataAccountType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, BankDataAccountType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, BankDataAccountType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, BankDataAccountType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, BankDataAccountType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class StatusDetailsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,
            Code = "code",
        };

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Bank account sucesfully validated";
        ApiEnum<string, Reason> expectedReason = Reason.InsufficientFunds;
        ApiEnum<string, StatusDetailsSource> expectedSource = StatusDetailsSource.Watchtower;
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
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,
            Code = "code",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<StatusDetails>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,
            Code = "code",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<StatusDetails>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Bank account sucesfully validated";
        ApiEnum<string, Reason> expectedReason = Reason.InsufficientFunds;
        ApiEnum<string, StatusDetailsSource> expectedSource = StatusDetailsSource.Watchtower;
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
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,
            Code = "code",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,
        };

        Assert.Null(model.Code);
        Assert.False(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,

            Code = null,
        };

        Assert.Null(model.Code);
        Assert.True(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,

            Code = null,
        };

        model.Validate();
    }
}

public class ReasonTest : TestBase
{
    [Theory]
    [InlineData(Reason.InsufficientFunds)]
    [InlineData(Reason.ClosedBankAccount)]
    [InlineData(Reason.InvalidBankAccount)]
    [InlineData(Reason.InvalidRouting)]
    [InlineData(Reason.Disputed)]
    [InlineData(Reason.PaymentStopped)]
    [InlineData(Reason.OwnerDeceased)]
    [InlineData(Reason.FrozenBankAccount)]
    [InlineData(Reason.RiskReview)]
    [InlineData(Reason.Fraudulent)]
    [InlineData(Reason.DuplicateEntry)]
    [InlineData(Reason.InvalidPaykey)]
    [InlineData(Reason.PaymentBlocked)]
    [InlineData(Reason.AmountTooLarge)]
    [InlineData(Reason.TooManyAttempts)]
    [InlineData(Reason.InternalSystemError)]
    [InlineData(Reason.UserRequest)]
    [InlineData(Reason.Ok)]
    [InlineData(Reason.OtherNetworkReturn)]
    [InlineData(Reason.PayoutRefused)]
    [InlineData(Reason.CancelRequest)]
    [InlineData(Reason.FailedVerification)]
    [InlineData(Reason.RequireReview)]
    [InlineData(Reason.BlockedBySystem)]
    [InlineData(Reason.WatchtowerReview)]
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
    [InlineData(Reason.InsufficientFunds)]
    [InlineData(Reason.ClosedBankAccount)]
    [InlineData(Reason.InvalidBankAccount)]
    [InlineData(Reason.InvalidRouting)]
    [InlineData(Reason.Disputed)]
    [InlineData(Reason.PaymentStopped)]
    [InlineData(Reason.OwnerDeceased)]
    [InlineData(Reason.FrozenBankAccount)]
    [InlineData(Reason.RiskReview)]
    [InlineData(Reason.Fraudulent)]
    [InlineData(Reason.DuplicateEntry)]
    [InlineData(Reason.InvalidPaykey)]
    [InlineData(Reason.PaymentBlocked)]
    [InlineData(Reason.AmountTooLarge)]
    [InlineData(Reason.TooManyAttempts)]
    [InlineData(Reason.InternalSystemError)]
    [InlineData(Reason.UserRequest)]
    [InlineData(Reason.Ok)]
    [InlineData(Reason.OtherNetworkReturn)]
    [InlineData(Reason.PayoutRefused)]
    [InlineData(Reason.CancelRequest)]
    [InlineData(Reason.FailedVerification)]
    [InlineData(Reason.RequireReview)]
    [InlineData(Reason.BlockedBySystem)]
    [InlineData(Reason.WatchtowerReview)]
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

public class StatusDetailsSourceTest : TestBase
{
    [Theory]
    [InlineData(StatusDetailsSource.Watchtower)]
    [InlineData(StatusDetailsSource.BankDecline)]
    [InlineData(StatusDetailsSource.CustomerDispute)]
    [InlineData(StatusDetailsSource.UserAction)]
    [InlineData(StatusDetailsSource.System)]
    public void Validation_Works(StatusDetailsSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, StatusDetailsSource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, StatusDetailsSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(StatusDetailsSource.Watchtower)]
    [InlineData(StatusDetailsSource.BankDecline)]
    [InlineData(StatusDetailsSource.CustomerDispute)]
    [InlineData(StatusDetailsSource.UserAction)]
    [InlineData(StatusDetailsSource.System)]
    public void SerializationRoundtrip_Works(StatusDetailsSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, StatusDetailsSource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, StatusDetailsSource>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, StatusDetailsSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, StatusDetailsSource>>(
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
