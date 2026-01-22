using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models;
using Straddle.Models.Paykeys;

namespace Straddle.Tests.Models.Paykeys;

public class PaykeyUnmaskedV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyUnmaskedV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                    SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = PaykeyUnmaskedV1DataSource.BankAccount,
                Status = PaykeyUnmaskedV1DataStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "123456789",
                    AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
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
                    Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
                    Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = PaykeyUnmaskedV1ResponseType.Object,
        };

        PaykeyUnmaskedV1Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyUnmaskedV1DataSource.BankAccount,
            Status = PaykeyUnmaskedV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "123456789",
                AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
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
                Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, PaykeyUnmaskedV1ResponseType> expectedResponseType =
            PaykeyUnmaskedV1ResponseType.Object;

        Assert.Equal(expectedData, model.Data);
        Assert.Equal(expectedMeta, model.Meta);
        Assert.Equal(expectedResponseType, model.ResponseType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PaykeyUnmaskedV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                    SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = PaykeyUnmaskedV1DataSource.BankAccount,
                Status = PaykeyUnmaskedV1DataStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "123456789",
                    AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
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
                    Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
                    Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = PaykeyUnmaskedV1ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyUnmaskedV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyUnmaskedV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                    SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = PaykeyUnmaskedV1DataSource.BankAccount,
                Status = PaykeyUnmaskedV1DataStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "123456789",
                    AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
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
                    Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
                    Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = PaykeyUnmaskedV1ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyUnmaskedV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        PaykeyUnmaskedV1Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyUnmaskedV1DataSource.BankAccount,
            Status = PaykeyUnmaskedV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "123456789",
                AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
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
                Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, PaykeyUnmaskedV1ResponseType> expectedResponseType =
            PaykeyUnmaskedV1ResponseType.Object;

        Assert.Equal(expectedData, deserialized.Data);
        Assert.Equal(expectedMeta, deserialized.Meta);
        Assert.Equal(expectedResponseType, deserialized.ResponseType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PaykeyUnmaskedV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                    SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = PaykeyUnmaskedV1DataSource.BankAccount,
                Status = PaykeyUnmaskedV1DataStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "123456789",
                    AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
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
                    Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
                    Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = PaykeyUnmaskedV1ResponseType.Object,
        };

        model.Validate();
    }
}

public class PaykeyUnmaskedV1DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyUnmaskedV1DataSource.BankAccount,
            Status = PaykeyUnmaskedV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "123456789",
                AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
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
                Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        PaykeyUnmaskedV1DataConfig expectedConfig = new()
        {
            ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedLabel = "label";
        string expectedPaykey = "paykey";
        ApiEnum<string, PaykeyUnmaskedV1DataSource> expectedSource =
            PaykeyUnmaskedV1DataSource.BankAccount;
        ApiEnum<string, PaykeyUnmaskedV1DataStatus> expectedStatus =
            PaykeyUnmaskedV1DataStatus.Pending;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        Balance expectedBalance = new()
        {
            Status = BalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        PaykeyUnmaskedV1DataBankData expectedBankData = new()
        {
            AccountNumber = "123456789",
            AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };
        string expectedCustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";
        string expectedInstitutionName = "Bank of America";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        PaykeyUnmaskedV1DataStatusDetails expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
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
        var model = new PaykeyUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyUnmaskedV1DataSource.BankAccount,
            Status = PaykeyUnmaskedV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "123456789",
                AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
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
                Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyUnmaskedV1Data>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyUnmaskedV1DataSource.BankAccount,
            Status = PaykeyUnmaskedV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "123456789",
                AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
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
                Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyUnmaskedV1Data>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        PaykeyUnmaskedV1DataConfig expectedConfig = new()
        {
            ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedLabel = "label";
        string expectedPaykey = "paykey";
        ApiEnum<string, PaykeyUnmaskedV1DataSource> expectedSource =
            PaykeyUnmaskedV1DataSource.BankAccount;
        ApiEnum<string, PaykeyUnmaskedV1DataStatus> expectedStatus =
            PaykeyUnmaskedV1DataStatus.Pending;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        Balance expectedBalance = new()
        {
            Status = BalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        PaykeyUnmaskedV1DataBankData expectedBankData = new()
        {
            AccountNumber = "123456789",
            AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };
        string expectedCustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";
        string expectedInstitutionName = "Bank of America";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        PaykeyUnmaskedV1DataStatusDetails expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
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
        var model = new PaykeyUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyUnmaskedV1DataSource.BankAccount,
            Status = PaykeyUnmaskedV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "123456789",
                AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
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
                Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PaykeyUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyUnmaskedV1DataSource.BankAccount,
            Status = PaykeyUnmaskedV1DataStatus.Pending,
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
        var model = new PaykeyUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyUnmaskedV1DataSource.BankAccount,
            Status = PaykeyUnmaskedV1DataStatus.Pending,
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
        var model = new PaykeyUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyUnmaskedV1DataSource.BankAccount,
            Status = PaykeyUnmaskedV1DataStatus.Pending,
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
        var model = new PaykeyUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyUnmaskedV1DataSource.BankAccount,
            Status = PaykeyUnmaskedV1DataStatus.Pending,
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
        var model = new PaykeyUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyUnmaskedV1DataSource.BankAccount,
            Status = PaykeyUnmaskedV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "123456789",
                AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
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
        var model = new PaykeyUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyUnmaskedV1DataSource.BankAccount,
            Status = PaykeyUnmaskedV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "123456789",
                AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new PaykeyUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyUnmaskedV1DataSource.BankAccount,
            Status = PaykeyUnmaskedV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "123456789",
                AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
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
        var model = new PaykeyUnmaskedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyUnmaskedV1DataSource.BankAccount,
            Status = PaykeyUnmaskedV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "123456789",
                AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
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

public class PaykeyUnmaskedV1DataConfigTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyUnmaskedV1DataConfig
        {
            ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
        };

        ApiEnum<string, PaykeyUnmaskedV1DataConfigProcessingMethod> expectedProcessingMethod =
            PaykeyUnmaskedV1DataConfigProcessingMethod.Inline;
        ApiEnum<string, PaykeyUnmaskedV1DataConfigSandboxOutcome> expectedSandboxOutcome =
            PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, model.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, model.SandboxOutcome);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PaykeyUnmaskedV1DataConfig
        {
            ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyUnmaskedV1DataConfig>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyUnmaskedV1DataConfig
        {
            ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyUnmaskedV1DataConfig>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, PaykeyUnmaskedV1DataConfigProcessingMethod> expectedProcessingMethod =
            PaykeyUnmaskedV1DataConfigProcessingMethod.Inline;
        ApiEnum<string, PaykeyUnmaskedV1DataConfigSandboxOutcome> expectedSandboxOutcome =
            PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, deserialized.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, deserialized.SandboxOutcome);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PaykeyUnmaskedV1DataConfig
        {
            ProcessingMethod = PaykeyUnmaskedV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PaykeyUnmaskedV1DataConfig { };

        Assert.Null(model.ProcessingMethod);
        Assert.False(model.RawData.ContainsKey("processing_method"));
        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new PaykeyUnmaskedV1DataConfig { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new PaykeyUnmaskedV1DataConfig
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
        var model = new PaykeyUnmaskedV1DataConfig
        {
            // Null should be interpreted as omitted for these properties
            ProcessingMethod = null,
            SandboxOutcome = null,
        };

        model.Validate();
    }
}

public class PaykeyUnmaskedV1DataConfigProcessingMethodTest : TestBase
{
    [Theory]
    [InlineData(PaykeyUnmaskedV1DataConfigProcessingMethod.Inline)]
    [InlineData(PaykeyUnmaskedV1DataConfigProcessingMethod.Background)]
    [InlineData(PaykeyUnmaskedV1DataConfigProcessingMethod.Skip)]
    public void Validation_Works(PaykeyUnmaskedV1DataConfigProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyUnmaskedV1DataConfigProcessingMethod> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataConfigProcessingMethod>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyUnmaskedV1DataConfigProcessingMethod.Inline)]
    [InlineData(PaykeyUnmaskedV1DataConfigProcessingMethod.Background)]
    [InlineData(PaykeyUnmaskedV1DataConfigProcessingMethod.Skip)]
    public void SerializationRoundtrip_Works(PaykeyUnmaskedV1DataConfigProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyUnmaskedV1DataConfigProcessingMethod> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataConfigProcessingMethod>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataConfigProcessingMethod>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataConfigProcessingMethod>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyUnmaskedV1DataConfigSandboxOutcomeTest : TestBase
{
    [Theory]
    [InlineData(PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard)]
    [InlineData(PaykeyUnmaskedV1DataConfigSandboxOutcome.Active)]
    [InlineData(PaykeyUnmaskedV1DataConfigSandboxOutcome.Rejected)]
    [InlineData(PaykeyUnmaskedV1DataConfigSandboxOutcome.Review)]
    public void Validation_Works(PaykeyUnmaskedV1DataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyUnmaskedV1DataConfigSandboxOutcome> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataConfigSandboxOutcome>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyUnmaskedV1DataConfigSandboxOutcome.Standard)]
    [InlineData(PaykeyUnmaskedV1DataConfigSandboxOutcome.Active)]
    [InlineData(PaykeyUnmaskedV1DataConfigSandboxOutcome.Rejected)]
    [InlineData(PaykeyUnmaskedV1DataConfigSandboxOutcome.Review)]
    public void SerializationRoundtrip_Works(PaykeyUnmaskedV1DataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyUnmaskedV1DataConfigSandboxOutcome> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataConfigSandboxOutcome>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataConfigSandboxOutcome>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataConfigSandboxOutcome>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyUnmaskedV1DataSourceTest : TestBase
{
    [Theory]
    [InlineData(PaykeyUnmaskedV1DataSource.BankAccount)]
    [InlineData(PaykeyUnmaskedV1DataSource.Straddle)]
    [InlineData(PaykeyUnmaskedV1DataSource.Mx)]
    [InlineData(PaykeyUnmaskedV1DataSource.Plaid)]
    [InlineData(PaykeyUnmaskedV1DataSource.Tan)]
    [InlineData(PaykeyUnmaskedV1DataSource.Quiltt)]
    public void Validation_Works(PaykeyUnmaskedV1DataSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyUnmaskedV1DataSource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyUnmaskedV1DataSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyUnmaskedV1DataSource.BankAccount)]
    [InlineData(PaykeyUnmaskedV1DataSource.Straddle)]
    [InlineData(PaykeyUnmaskedV1DataSource.Mx)]
    [InlineData(PaykeyUnmaskedV1DataSource.Plaid)]
    [InlineData(PaykeyUnmaskedV1DataSource.Tan)]
    [InlineData(PaykeyUnmaskedV1DataSource.Quiltt)]
    public void SerializationRoundtrip_Works(PaykeyUnmaskedV1DataSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyUnmaskedV1DataSource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaykeyUnmaskedV1DataSource>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyUnmaskedV1DataSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaykeyUnmaskedV1DataSource>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyUnmaskedV1DataStatusTest : TestBase
{
    [Theory]
    [InlineData(PaykeyUnmaskedV1DataStatus.Pending)]
    [InlineData(PaykeyUnmaskedV1DataStatus.Active)]
    [InlineData(PaykeyUnmaskedV1DataStatus.Inactive)]
    [InlineData(PaykeyUnmaskedV1DataStatus.Rejected)]
    [InlineData(PaykeyUnmaskedV1DataStatus.Review)]
    [InlineData(PaykeyUnmaskedV1DataStatus.Blocked)]
    public void Validation_Works(PaykeyUnmaskedV1DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyUnmaskedV1DataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyUnmaskedV1DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyUnmaskedV1DataStatus.Pending)]
    [InlineData(PaykeyUnmaskedV1DataStatus.Active)]
    [InlineData(PaykeyUnmaskedV1DataStatus.Inactive)]
    [InlineData(PaykeyUnmaskedV1DataStatus.Rejected)]
    [InlineData(PaykeyUnmaskedV1DataStatus.Review)]
    [InlineData(PaykeyUnmaskedV1DataStatus.Blocked)]
    public void SerializationRoundtrip_Works(PaykeyUnmaskedV1DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyUnmaskedV1DataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaykeyUnmaskedV1DataStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyUnmaskedV1DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaykeyUnmaskedV1DataStatus>>(
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

public class PaykeyUnmaskedV1DataBankDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyUnmaskedV1DataBankData
        {
            AccountNumber = "123456789",
            AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        string expectedAccountNumber = "123456789";
        ApiEnum<string, PaykeyUnmaskedV1DataBankDataAccountType> expectedAccountType =
            PaykeyUnmaskedV1DataBankDataAccountType.Checking;
        string expectedRoutingNumber = "021000021";

        Assert.Equal(expectedAccountNumber, model.AccountNumber);
        Assert.Equal(expectedAccountType, model.AccountType);
        Assert.Equal(expectedRoutingNumber, model.RoutingNumber);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PaykeyUnmaskedV1DataBankData
        {
            AccountNumber = "123456789",
            AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyUnmaskedV1DataBankData>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyUnmaskedV1DataBankData
        {
            AccountNumber = "123456789",
            AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyUnmaskedV1DataBankData>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedAccountNumber = "123456789";
        ApiEnum<string, PaykeyUnmaskedV1DataBankDataAccountType> expectedAccountType =
            PaykeyUnmaskedV1DataBankDataAccountType.Checking;
        string expectedRoutingNumber = "021000021";

        Assert.Equal(expectedAccountNumber, deserialized.AccountNumber);
        Assert.Equal(expectedAccountType, deserialized.AccountType);
        Assert.Equal(expectedRoutingNumber, deserialized.RoutingNumber);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PaykeyUnmaskedV1DataBankData
        {
            AccountNumber = "123456789",
            AccountType = PaykeyUnmaskedV1DataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        model.Validate();
    }
}

public class PaykeyUnmaskedV1DataBankDataAccountTypeTest : TestBase
{
    [Theory]
    [InlineData(PaykeyUnmaskedV1DataBankDataAccountType.Checking)]
    [InlineData(PaykeyUnmaskedV1DataBankDataAccountType.Savings)]
    public void Validation_Works(PaykeyUnmaskedV1DataBankDataAccountType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyUnmaskedV1DataBankDataAccountType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataBankDataAccountType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyUnmaskedV1DataBankDataAccountType.Checking)]
    [InlineData(PaykeyUnmaskedV1DataBankDataAccountType.Savings)]
    public void SerializationRoundtrip_Works(PaykeyUnmaskedV1DataBankDataAccountType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyUnmaskedV1DataBankDataAccountType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataBankDataAccountType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataBankDataAccountType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataBankDataAccountType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyUnmaskedV1DataStatusDetailsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyUnmaskedV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Bank account sucesfully validated";
        ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsReason> expectedReason =
            PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds;
        ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsSource> expectedSource =
            PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower;
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
        var model = new PaykeyUnmaskedV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyUnmaskedV1DataStatusDetails>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyUnmaskedV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyUnmaskedV1DataStatusDetails>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Bank account sucesfully validated";
        ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsReason> expectedReason =
            PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds;
        ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsSource> expectedSource =
            PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower;
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
        var model = new PaykeyUnmaskedV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PaykeyUnmaskedV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
        };

        Assert.Null(model.Code);
        Assert.False(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new PaykeyUnmaskedV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new PaykeyUnmaskedV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,

            Code = null,
        };

        Assert.Null(model.Code);
        Assert.True(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new PaykeyUnmaskedV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower,

            Code = null,
        };

        model.Validate();
    }
}

public class PaykeyUnmaskedV1DataStatusDetailsReasonTest : TestBase
{
    [Theory]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.ClosedBankAccount)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InvalidBankAccount)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InvalidRouting)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.Disputed)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.PaymentStopped)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.OwnerDeceased)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.FrozenBankAccount)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.RiskReview)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.Fraudulent)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.DuplicateEntry)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InvalidPaykey)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.PaymentBlocked)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.AmountTooLarge)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.TooManyAttempts)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InternalSystemError)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.UserRequest)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.Ok)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.OtherNetworkReturn)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.PayoutRefused)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.CancelRequest)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.FailedVerification)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.RequireReview)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.BlockedBySystem)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.WatchtowerReview)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.ClosedBankAccount1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InvalidBankAccount1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InvalidRouting1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.Disputed1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.PaymentStopped1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.OwnerDeceased1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.FrozenBankAccount1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.RiskReview1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.Fraudulent1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.DuplicateEntry1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InvalidPaykey1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.PaymentBlocked1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.AmountTooLarge1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.TooManyAttempts1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InternalSystemError1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.UserRequest1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.Ok1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.OtherNetworkReturn1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.PayoutRefused1)]
    public void Validation_Works(PaykeyUnmaskedV1DataStatusDetailsReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsReason> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.ClosedBankAccount)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InvalidBankAccount)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InvalidRouting)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.Disputed)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.PaymentStopped)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.OwnerDeceased)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.FrozenBankAccount)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.RiskReview)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.Fraudulent)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.DuplicateEntry)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InvalidPaykey)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.PaymentBlocked)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.AmountTooLarge)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.TooManyAttempts)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InternalSystemError)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.UserRequest)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.Ok)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.OtherNetworkReturn)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.PayoutRefused)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.CancelRequest)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.FailedVerification)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.RequireReview)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.BlockedBySystem)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.WatchtowerReview)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InsufficientFunds1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.ClosedBankAccount1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InvalidBankAccount1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InvalidRouting1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.Disputed1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.PaymentStopped1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.OwnerDeceased1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.FrozenBankAccount1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.RiskReview1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.Fraudulent1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.DuplicateEntry1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InvalidPaykey1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.PaymentBlocked1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.AmountTooLarge1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.TooManyAttempts1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.InternalSystemError1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.UserRequest1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.Ok1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.OtherNetworkReturn1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsReason.PayoutRefused1)]
    public void SerializationRoundtrip_Works(PaykeyUnmaskedV1DataStatusDetailsReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsReason> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyUnmaskedV1DataStatusDetailsSourceTest : TestBase
{
    [Theory]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.BankDecline)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.CustomerDispute)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.UserAction)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.System)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.BankDecline1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.CustomerDispute1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.UserAction1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.System1)]
    public void Validation_Works(PaykeyUnmaskedV1DataStatusDetailsSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsSource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsSource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.BankDecline)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.CustomerDispute)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.UserAction)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.System)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.Watchtower1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.BankDecline1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.CustomerDispute1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.UserAction1)]
    [InlineData(PaykeyUnmaskedV1DataStatusDetailsSource.System1)]
    public void SerializationRoundtrip_Works(PaykeyUnmaskedV1DataStatusDetailsSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsSource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsSource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1DataStatusDetailsSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyUnmaskedV1ResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(PaykeyUnmaskedV1ResponseType.Object)]
    [InlineData(PaykeyUnmaskedV1ResponseType.Array)]
    [InlineData(PaykeyUnmaskedV1ResponseType.Error)]
    [InlineData(PaykeyUnmaskedV1ResponseType.None)]
    [InlineData(PaykeyUnmaskedV1ResponseType.Object1)]
    [InlineData(PaykeyUnmaskedV1ResponseType.Array1)]
    [InlineData(PaykeyUnmaskedV1ResponseType.Error1)]
    [InlineData(PaykeyUnmaskedV1ResponseType.None1)]
    public void Validation_Works(PaykeyUnmaskedV1ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyUnmaskedV1ResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyUnmaskedV1ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyUnmaskedV1ResponseType.Object)]
    [InlineData(PaykeyUnmaskedV1ResponseType.Array)]
    [InlineData(PaykeyUnmaskedV1ResponseType.Error)]
    [InlineData(PaykeyUnmaskedV1ResponseType.None)]
    [InlineData(PaykeyUnmaskedV1ResponseType.Object1)]
    [InlineData(PaykeyUnmaskedV1ResponseType.Array1)]
    [InlineData(PaykeyUnmaskedV1ResponseType.Error1)]
    [InlineData(PaykeyUnmaskedV1ResponseType.None1)]
    public void SerializationRoundtrip_Works(PaykeyUnmaskedV1ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyUnmaskedV1ResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1ResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyUnmaskedV1ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyUnmaskedV1ResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}
