using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models;
using Straddle.Models.Paykeys;

namespace Straddle.Tests.Models.Paykeys;

public class PaykeyV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                    SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = PaykeyV1DataSource.BankAccount,
                Status = PaykeyV1DataStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = PaykeyV1DataBalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = PaykeyV1DataBankDataAccountType.Checking,
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
                    Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
                    Source = PaykeyV1DataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = PaykeyV1ResponseType.Object,
        };

        PaykeyV1Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyV1DataSource.BankAccount,
            Status = PaykeyV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyV1DataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyV1DataBankDataAccountType.Checking,
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
                Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, PaykeyV1ResponseType> expectedResponseType = PaykeyV1ResponseType.Object;

        Assert.Equal(expectedData, model.Data);
        Assert.Equal(expectedMeta, model.Meta);
        Assert.Equal(expectedResponseType, model.ResponseType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PaykeyV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                    SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = PaykeyV1DataSource.BankAccount,
                Status = PaykeyV1DataStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = PaykeyV1DataBalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = PaykeyV1DataBankDataAccountType.Checking,
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
                    Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
                    Source = PaykeyV1DataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = PaykeyV1ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyV1>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                    SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = PaykeyV1DataSource.BankAccount,
                Status = PaykeyV1DataStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = PaykeyV1DataBalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = PaykeyV1DataBankDataAccountType.Checking,
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
                    Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
                    Source = PaykeyV1DataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = PaykeyV1ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        PaykeyV1Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyV1DataSource.BankAccount,
            Status = PaykeyV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyV1DataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyV1DataBankDataAccountType.Checking,
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
                Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, PaykeyV1ResponseType> expectedResponseType = PaykeyV1ResponseType.Object;

        Assert.Equal(expectedData, deserialized.Data);
        Assert.Equal(expectedMeta, deserialized.Meta);
        Assert.Equal(expectedResponseType, deserialized.ResponseType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PaykeyV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                    SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = PaykeyV1DataSource.BankAccount,
                Status = PaykeyV1DataStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = PaykeyV1DataBalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = PaykeyV1DataBankDataAccountType.Checking,
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
                    Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
                    Source = PaykeyV1DataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = PaykeyV1ResponseType.Object,
        };

        model.Validate();
    }
}

public class PaykeyV1DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyV1DataSource.BankAccount,
            Status = PaykeyV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyV1DataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyV1DataBankDataAccountType.Checking,
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
                Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        PaykeyV1DataConfig expectedConfig = new()
        {
            ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedLabel = "label";
        string expectedPaykey = "paykey";
        ApiEnum<string, PaykeyV1DataSource> expectedSource = PaykeyV1DataSource.BankAccount;
        ApiEnum<string, PaykeyV1DataStatus> expectedStatus = PaykeyV1DataStatus.Pending;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        PaykeyV1DataBalance expectedBalance = new()
        {
            Status = PaykeyV1DataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        PaykeyV1DataBankData expectedBankData = new()
        {
            AccountNumber = "****1234",
            AccountType = PaykeyV1DataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };
        string expectedCustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";
        string expectedInstitutionName = "Bank of America";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        PaykeyV1DataStatusDetails expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyV1DataStatusDetailsSource.Watchtower,
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
        var model = new PaykeyV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyV1DataSource.BankAccount,
            Status = PaykeyV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyV1DataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyV1DataBankDataAccountType.Checking,
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
                Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyV1Data>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyV1DataSource.BankAccount,
            Status = PaykeyV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyV1DataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyV1DataBankDataAccountType.Checking,
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
                Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyV1Data>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        PaykeyV1DataConfig expectedConfig = new()
        {
            ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedLabel = "label";
        string expectedPaykey = "paykey";
        ApiEnum<string, PaykeyV1DataSource> expectedSource = PaykeyV1DataSource.BankAccount;
        ApiEnum<string, PaykeyV1DataStatus> expectedStatus = PaykeyV1DataStatus.Pending;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        PaykeyV1DataBalance expectedBalance = new()
        {
            Status = PaykeyV1DataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        PaykeyV1DataBankData expectedBankData = new()
        {
            AccountNumber = "****1234",
            AccountType = PaykeyV1DataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };
        string expectedCustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";
        string expectedInstitutionName = "Bank of America";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        PaykeyV1DataStatusDetails expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyV1DataStatusDetailsSource.Watchtower,
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
        var model = new PaykeyV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyV1DataSource.BankAccount,
            Status = PaykeyV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyV1DataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyV1DataBankDataAccountType.Checking,
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
                Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PaykeyV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyV1DataSource.BankAccount,
            Status = PaykeyV1DataStatus.Pending,
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
        var model = new PaykeyV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyV1DataSource.BankAccount,
            Status = PaykeyV1DataStatus.Pending,
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
        var model = new PaykeyV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyV1DataSource.BankAccount,
            Status = PaykeyV1DataStatus.Pending,
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
        var model = new PaykeyV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyV1DataSource.BankAccount,
            Status = PaykeyV1DataStatus.Pending,
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
        var model = new PaykeyV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyV1DataSource.BankAccount,
            Status = PaykeyV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyV1DataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyV1DataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyV1DataStatusDetailsSource.Watchtower,
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
        var model = new PaykeyV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyV1DataSource.BankAccount,
            Status = PaykeyV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyV1DataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyV1DataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new PaykeyV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyV1DataSource.BankAccount,
            Status = PaykeyV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyV1DataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyV1DataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyV1DataStatusDetailsSource.Watchtower,
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
        var model = new PaykeyV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = PaykeyV1DataSource.BankAccount,
            Status = PaykeyV1DataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyV1DataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyV1DataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyV1DataStatusDetailsSource.Watchtower,
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

public class PaykeyV1DataConfigTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyV1DataConfig
        {
            ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
        };

        ApiEnum<string, PaykeyV1DataConfigProcessingMethod> expectedProcessingMethod =
            PaykeyV1DataConfigProcessingMethod.Inline;
        ApiEnum<string, PaykeyV1DataConfigSandboxOutcome> expectedSandboxOutcome =
            PaykeyV1DataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, model.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, model.SandboxOutcome);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PaykeyV1DataConfig
        {
            ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyV1DataConfig>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyV1DataConfig
        {
            ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyV1DataConfig>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, PaykeyV1DataConfigProcessingMethod> expectedProcessingMethod =
            PaykeyV1DataConfigProcessingMethod.Inline;
        ApiEnum<string, PaykeyV1DataConfigSandboxOutcome> expectedSandboxOutcome =
            PaykeyV1DataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, deserialized.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, deserialized.SandboxOutcome);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PaykeyV1DataConfig
        {
            ProcessingMethod = PaykeyV1DataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyV1DataConfigSandboxOutcome.Standard,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PaykeyV1DataConfig { };

        Assert.Null(model.ProcessingMethod);
        Assert.False(model.RawData.ContainsKey("processing_method"));
        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new PaykeyV1DataConfig { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new PaykeyV1DataConfig
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
        var model = new PaykeyV1DataConfig
        {
            // Null should be interpreted as omitted for these properties
            ProcessingMethod = null,
            SandboxOutcome = null,
        };

        model.Validate();
    }
}

public class PaykeyV1DataConfigProcessingMethodTest : TestBase
{
    [Theory]
    [InlineData(PaykeyV1DataConfigProcessingMethod.Inline)]
    [InlineData(PaykeyV1DataConfigProcessingMethod.Background)]
    [InlineData(PaykeyV1DataConfigProcessingMethod.Skip)]
    public void Validation_Works(PaykeyV1DataConfigProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1DataConfigProcessingMethod> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataConfigProcessingMethod>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyV1DataConfigProcessingMethod.Inline)]
    [InlineData(PaykeyV1DataConfigProcessingMethod.Background)]
    [InlineData(PaykeyV1DataConfigProcessingMethod.Skip)]
    public void SerializationRoundtrip_Works(PaykeyV1DataConfigProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1DataConfigProcessingMethod> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyV1DataConfigProcessingMethod>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataConfigProcessingMethod>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyV1DataConfigProcessingMethod>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyV1DataConfigSandboxOutcomeTest : TestBase
{
    [Theory]
    [InlineData(PaykeyV1DataConfigSandboxOutcome.Standard)]
    [InlineData(PaykeyV1DataConfigSandboxOutcome.Active)]
    [InlineData(PaykeyV1DataConfigSandboxOutcome.Rejected)]
    [InlineData(PaykeyV1DataConfigSandboxOutcome.Review)]
    public void Validation_Works(PaykeyV1DataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1DataConfigSandboxOutcome> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataConfigSandboxOutcome>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyV1DataConfigSandboxOutcome.Standard)]
    [InlineData(PaykeyV1DataConfigSandboxOutcome.Active)]
    [InlineData(PaykeyV1DataConfigSandboxOutcome.Rejected)]
    [InlineData(PaykeyV1DataConfigSandboxOutcome.Review)]
    public void SerializationRoundtrip_Works(PaykeyV1DataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1DataConfigSandboxOutcome> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyV1DataConfigSandboxOutcome>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataConfigSandboxOutcome>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyV1DataConfigSandboxOutcome>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyV1DataSourceTest : TestBase
{
    [Theory]
    [InlineData(PaykeyV1DataSource.BankAccount)]
    [InlineData(PaykeyV1DataSource.Straddle)]
    [InlineData(PaykeyV1DataSource.Mx)]
    [InlineData(PaykeyV1DataSource.Plaid)]
    [InlineData(PaykeyV1DataSource.Tan)]
    [InlineData(PaykeyV1DataSource.Quiltt)]
    public void Validation_Works(PaykeyV1DataSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1DataSource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyV1DataSource.BankAccount)]
    [InlineData(PaykeyV1DataSource.Straddle)]
    [InlineData(PaykeyV1DataSource.Mx)]
    [InlineData(PaykeyV1DataSource.Plaid)]
    [InlineData(PaykeyV1DataSource.Tan)]
    [InlineData(PaykeyV1DataSource.Quiltt)]
    public void SerializationRoundtrip_Works(PaykeyV1DataSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1DataSource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataSource>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataSource>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyV1DataStatusTest : TestBase
{
    [Theory]
    [InlineData(PaykeyV1DataStatus.Pending)]
    [InlineData(PaykeyV1DataStatus.Active)]
    [InlineData(PaykeyV1DataStatus.Inactive)]
    [InlineData(PaykeyV1DataStatus.Rejected)]
    [InlineData(PaykeyV1DataStatus.Review)]
    [InlineData(PaykeyV1DataStatus.Blocked)]
    public void Validation_Works(PaykeyV1DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1DataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyV1DataStatus.Pending)]
    [InlineData(PaykeyV1DataStatus.Active)]
    [InlineData(PaykeyV1DataStatus.Inactive)]
    [InlineData(PaykeyV1DataStatus.Rejected)]
    [InlineData(PaykeyV1DataStatus.Review)]
    [InlineData(PaykeyV1DataStatus.Blocked)]
    public void SerializationRoundtrip_Works(PaykeyV1DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1DataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyV1DataBalanceTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyV1DataBalance
        {
            Status = PaykeyV1DataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        ApiEnum<string, PaykeyV1DataBalanceStatus> expectedStatus =
            PaykeyV1DataBalanceStatus.Pending;
        int expectedAccountBalance = 0;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedAccountBalance, model.AccountBalance);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PaykeyV1DataBalance
        {
            Status = PaykeyV1DataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyV1DataBalance>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyV1DataBalance
        {
            Status = PaykeyV1DataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyV1DataBalance>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, PaykeyV1DataBalanceStatus> expectedStatus =
            PaykeyV1DataBalanceStatus.Pending;
        int expectedAccountBalance = 0;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedAccountBalance, deserialized.AccountBalance);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PaykeyV1DataBalance
        {
            Status = PaykeyV1DataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PaykeyV1DataBalance { Status = PaykeyV1DataBalanceStatus.Pending };

        Assert.Null(model.AccountBalance);
        Assert.False(model.RawData.ContainsKey("account_balance"));
        Assert.Null(model.UpdatedAt);
        Assert.False(model.RawData.ContainsKey("updated_at"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new PaykeyV1DataBalance { Status = PaykeyV1DataBalanceStatus.Pending };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new PaykeyV1DataBalance
        {
            Status = PaykeyV1DataBalanceStatus.Pending,

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
        var model = new PaykeyV1DataBalance
        {
            Status = PaykeyV1DataBalanceStatus.Pending,

            AccountBalance = null,
            UpdatedAt = null,
        };

        model.Validate();
    }
}

public class PaykeyV1DataBalanceStatusTest : TestBase
{
    [Theory]
    [InlineData(PaykeyV1DataBalanceStatus.Pending)]
    [InlineData(PaykeyV1DataBalanceStatus.Completed)]
    [InlineData(PaykeyV1DataBalanceStatus.Failed)]
    public void Validation_Works(PaykeyV1DataBalanceStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1DataBalanceStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataBalanceStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyV1DataBalanceStatus.Pending)]
    [InlineData(PaykeyV1DataBalanceStatus.Completed)]
    [InlineData(PaykeyV1DataBalanceStatus.Failed)]
    public void SerializationRoundtrip_Works(PaykeyV1DataBalanceStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1DataBalanceStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataBalanceStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataBalanceStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataBalanceStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyV1DataBankDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyV1DataBankData
        {
            AccountNumber = "****1234",
            AccountType = PaykeyV1DataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        string expectedAccountNumber = "****1234";
        ApiEnum<string, PaykeyV1DataBankDataAccountType> expectedAccountType =
            PaykeyV1DataBankDataAccountType.Checking;
        string expectedRoutingNumber = "021000021";

        Assert.Equal(expectedAccountNumber, model.AccountNumber);
        Assert.Equal(expectedAccountType, model.AccountType);
        Assert.Equal(expectedRoutingNumber, model.RoutingNumber);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PaykeyV1DataBankData
        {
            AccountNumber = "****1234",
            AccountType = PaykeyV1DataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyV1DataBankData>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyV1DataBankData
        {
            AccountNumber = "****1234",
            AccountType = PaykeyV1DataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyV1DataBankData>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedAccountNumber = "****1234";
        ApiEnum<string, PaykeyV1DataBankDataAccountType> expectedAccountType =
            PaykeyV1DataBankDataAccountType.Checking;
        string expectedRoutingNumber = "021000021";

        Assert.Equal(expectedAccountNumber, deserialized.AccountNumber);
        Assert.Equal(expectedAccountType, deserialized.AccountType);
        Assert.Equal(expectedRoutingNumber, deserialized.RoutingNumber);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PaykeyV1DataBankData
        {
            AccountNumber = "****1234",
            AccountType = PaykeyV1DataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        model.Validate();
    }
}

public class PaykeyV1DataBankDataAccountTypeTest : TestBase
{
    [Theory]
    [InlineData(PaykeyV1DataBankDataAccountType.Checking)]
    [InlineData(PaykeyV1DataBankDataAccountType.Savings)]
    public void Validation_Works(PaykeyV1DataBankDataAccountType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1DataBankDataAccountType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataBankDataAccountType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyV1DataBankDataAccountType.Checking)]
    [InlineData(PaykeyV1DataBankDataAccountType.Savings)]
    public void SerializationRoundtrip_Works(PaykeyV1DataBankDataAccountType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1DataBankDataAccountType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyV1DataBankDataAccountType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataBankDataAccountType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyV1DataBankDataAccountType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyV1DataStatusDetailsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyV1DataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Bank account sucesfully validated";
        ApiEnum<string, PaykeyV1DataStatusDetailsReason> expectedReason =
            PaykeyV1DataStatusDetailsReason.InsufficientFunds;
        ApiEnum<string, PaykeyV1DataStatusDetailsSource> expectedSource =
            PaykeyV1DataStatusDetailsSource.Watchtower;
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
        var model = new PaykeyV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyV1DataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyV1DataStatusDetails>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyV1DataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyV1DataStatusDetails>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Bank account sucesfully validated";
        ApiEnum<string, PaykeyV1DataStatusDetailsReason> expectedReason =
            PaykeyV1DataStatusDetailsReason.InsufficientFunds;
        ApiEnum<string, PaykeyV1DataStatusDetailsSource> expectedSource =
            PaykeyV1DataStatusDetailsSource.Watchtower;
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
        var model = new PaykeyV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyV1DataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PaykeyV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyV1DataStatusDetailsSource.Watchtower,
        };

        Assert.Null(model.Code);
        Assert.False(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new PaykeyV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyV1DataStatusDetailsSource.Watchtower,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new PaykeyV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyV1DataStatusDetailsSource.Watchtower,

            Code = null,
        };

        Assert.Null(model.Code);
        Assert.True(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new PaykeyV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyV1DataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyV1DataStatusDetailsSource.Watchtower,

            Code = null,
        };

        model.Validate();
    }
}

public class PaykeyV1DataStatusDetailsReasonTest : TestBase
{
    [Theory]
    [InlineData(PaykeyV1DataStatusDetailsReason.InsufficientFunds)]
    [InlineData(PaykeyV1DataStatusDetailsReason.ClosedBankAccount)]
    [InlineData(PaykeyV1DataStatusDetailsReason.InvalidBankAccount)]
    [InlineData(PaykeyV1DataStatusDetailsReason.InvalidRouting)]
    [InlineData(PaykeyV1DataStatusDetailsReason.Disputed)]
    [InlineData(PaykeyV1DataStatusDetailsReason.PaymentStopped)]
    [InlineData(PaykeyV1DataStatusDetailsReason.OwnerDeceased)]
    [InlineData(PaykeyV1DataStatusDetailsReason.FrozenBankAccount)]
    [InlineData(PaykeyV1DataStatusDetailsReason.RiskReview)]
    [InlineData(PaykeyV1DataStatusDetailsReason.Fraudulent)]
    [InlineData(PaykeyV1DataStatusDetailsReason.DuplicateEntry)]
    [InlineData(PaykeyV1DataStatusDetailsReason.InvalidPaykey)]
    [InlineData(PaykeyV1DataStatusDetailsReason.PaymentBlocked)]
    [InlineData(PaykeyV1DataStatusDetailsReason.AmountTooLarge)]
    [InlineData(PaykeyV1DataStatusDetailsReason.TooManyAttempts)]
    [InlineData(PaykeyV1DataStatusDetailsReason.InternalSystemError)]
    [InlineData(PaykeyV1DataStatusDetailsReason.UserRequest)]
    [InlineData(PaykeyV1DataStatusDetailsReason.Ok)]
    [InlineData(PaykeyV1DataStatusDetailsReason.OtherNetworkReturn)]
    [InlineData(PaykeyV1DataStatusDetailsReason.PayoutRefused)]
    [InlineData(PaykeyV1DataStatusDetailsReason.CancelRequest)]
    [InlineData(PaykeyV1DataStatusDetailsReason.FailedVerification)]
    [InlineData(PaykeyV1DataStatusDetailsReason.RequireReview)]
    [InlineData(PaykeyV1DataStatusDetailsReason.BlockedBySystem)]
    [InlineData(PaykeyV1DataStatusDetailsReason.WatchtowerReview)]
    public void Validation_Works(PaykeyV1DataStatusDetailsReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1DataStatusDetailsReason> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataStatusDetailsReason>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyV1DataStatusDetailsReason.InsufficientFunds)]
    [InlineData(PaykeyV1DataStatusDetailsReason.ClosedBankAccount)]
    [InlineData(PaykeyV1DataStatusDetailsReason.InvalidBankAccount)]
    [InlineData(PaykeyV1DataStatusDetailsReason.InvalidRouting)]
    [InlineData(PaykeyV1DataStatusDetailsReason.Disputed)]
    [InlineData(PaykeyV1DataStatusDetailsReason.PaymentStopped)]
    [InlineData(PaykeyV1DataStatusDetailsReason.OwnerDeceased)]
    [InlineData(PaykeyV1DataStatusDetailsReason.FrozenBankAccount)]
    [InlineData(PaykeyV1DataStatusDetailsReason.RiskReview)]
    [InlineData(PaykeyV1DataStatusDetailsReason.Fraudulent)]
    [InlineData(PaykeyV1DataStatusDetailsReason.DuplicateEntry)]
    [InlineData(PaykeyV1DataStatusDetailsReason.InvalidPaykey)]
    [InlineData(PaykeyV1DataStatusDetailsReason.PaymentBlocked)]
    [InlineData(PaykeyV1DataStatusDetailsReason.AmountTooLarge)]
    [InlineData(PaykeyV1DataStatusDetailsReason.TooManyAttempts)]
    [InlineData(PaykeyV1DataStatusDetailsReason.InternalSystemError)]
    [InlineData(PaykeyV1DataStatusDetailsReason.UserRequest)]
    [InlineData(PaykeyV1DataStatusDetailsReason.Ok)]
    [InlineData(PaykeyV1DataStatusDetailsReason.OtherNetworkReturn)]
    [InlineData(PaykeyV1DataStatusDetailsReason.PayoutRefused)]
    [InlineData(PaykeyV1DataStatusDetailsReason.CancelRequest)]
    [InlineData(PaykeyV1DataStatusDetailsReason.FailedVerification)]
    [InlineData(PaykeyV1DataStatusDetailsReason.RequireReview)]
    [InlineData(PaykeyV1DataStatusDetailsReason.BlockedBySystem)]
    [InlineData(PaykeyV1DataStatusDetailsReason.WatchtowerReview)]
    public void SerializationRoundtrip_Works(PaykeyV1DataStatusDetailsReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1DataStatusDetailsReason> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyV1DataStatusDetailsReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataStatusDetailsReason>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyV1DataStatusDetailsReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyV1DataStatusDetailsSourceTest : TestBase
{
    [Theory]
    [InlineData(PaykeyV1DataStatusDetailsSource.Watchtower)]
    [InlineData(PaykeyV1DataStatusDetailsSource.BankDecline)]
    [InlineData(PaykeyV1DataStatusDetailsSource.CustomerDispute)]
    [InlineData(PaykeyV1DataStatusDetailsSource.UserAction)]
    [InlineData(PaykeyV1DataStatusDetailsSource.System)]
    public void Validation_Works(PaykeyV1DataStatusDetailsSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1DataStatusDetailsSource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataStatusDetailsSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyV1DataStatusDetailsSource.Watchtower)]
    [InlineData(PaykeyV1DataStatusDetailsSource.BankDecline)]
    [InlineData(PaykeyV1DataStatusDetailsSource.CustomerDispute)]
    [InlineData(PaykeyV1DataStatusDetailsSource.UserAction)]
    [InlineData(PaykeyV1DataStatusDetailsSource.System)]
    public void SerializationRoundtrip_Works(PaykeyV1DataStatusDetailsSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1DataStatusDetailsSource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyV1DataStatusDetailsSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1DataStatusDetailsSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyV1DataStatusDetailsSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyV1ResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(PaykeyV1ResponseType.Object)]
    [InlineData(PaykeyV1ResponseType.Array)]
    [InlineData(PaykeyV1ResponseType.Error)]
    [InlineData(PaykeyV1ResponseType.None)]
    public void Validation_Works(PaykeyV1ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1ResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyV1ResponseType.Object)]
    [InlineData(PaykeyV1ResponseType.Array)]
    [InlineData(PaykeyV1ResponseType.Error)]
    [InlineData(PaykeyV1ResponseType.None)]
    public void SerializationRoundtrip_Works(PaykeyV1ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyV1ResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1ResponseType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaykeyV1ResponseType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
