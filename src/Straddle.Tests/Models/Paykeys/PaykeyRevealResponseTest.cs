using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models;
using Straddle.Models.Paykeys;

namespace Straddle.Tests.Models.Paykeys;

public class PaykeyRevealResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyRevealResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                    SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "Bank of America ****1234",
                Paykey = "paykey",
                Source = PaykeyRevealResponseDataSource.Straddle,
                Status = PaykeyRevealResponseDataStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = PaykeyRevealResponseDataBalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
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
                    Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
                    Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = PaykeyRevealResponseResponseType.Object,
        };

        PaykeyRevealResponseData expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = PaykeyRevealResponseDataSource.Straddle,
            Status = PaykeyRevealResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyRevealResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
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
                Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, PaykeyRevealResponseResponseType> expectedResponseType =
            PaykeyRevealResponseResponseType.Object;

        Assert.Equal(expectedData, model.Data);
        Assert.Equal(expectedMeta, model.Meta);
        Assert.Equal(expectedResponseType, model.ResponseType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PaykeyRevealResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                    SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "Bank of America ****1234",
                Paykey = "paykey",
                Source = PaykeyRevealResponseDataSource.Straddle,
                Status = PaykeyRevealResponseDataStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = PaykeyRevealResponseDataBalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
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
                    Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
                    Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = PaykeyRevealResponseResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyRevealResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyRevealResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                    SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "Bank of America ****1234",
                Paykey = "paykey",
                Source = PaykeyRevealResponseDataSource.Straddle,
                Status = PaykeyRevealResponseDataStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = PaykeyRevealResponseDataBalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
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
                    Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
                    Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = PaykeyRevealResponseResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyRevealResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        PaykeyRevealResponseData expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = PaykeyRevealResponseDataSource.Straddle,
            Status = PaykeyRevealResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyRevealResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
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
                Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, PaykeyRevealResponseResponseType> expectedResponseType =
            PaykeyRevealResponseResponseType.Object;

        Assert.Equal(expectedData, deserialized.Data);
        Assert.Equal(expectedMeta, deserialized.Meta);
        Assert.Equal(expectedResponseType, deserialized.ResponseType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PaykeyRevealResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                    SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "Bank of America ****1234",
                Paykey = "paykey",
                Source = PaykeyRevealResponseDataSource.Straddle,
                Status = PaykeyRevealResponseDataStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = PaykeyRevealResponseDataBalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
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
                    Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
                    Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = PaykeyRevealResponseResponseType.Object,
        };

        model.Validate();
    }
}

public class PaykeyRevealResponseDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyRevealResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = PaykeyRevealResponseDataSource.Straddle,
            Status = PaykeyRevealResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyRevealResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
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
                Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        PaykeyRevealResponseDataConfig expectedConfig = new()
        {
            ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedLabel = "Bank of America ****1234";
        string expectedPaykey = "paykey";
        ApiEnum<string, PaykeyRevealResponseDataSource> expectedSource =
            PaykeyRevealResponseDataSource.Straddle;
        ApiEnum<string, PaykeyRevealResponseDataStatus> expectedStatus =
            PaykeyRevealResponseDataStatus.Pending;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        PaykeyRevealResponseDataBalance expectedBalance = new()
        {
            Status = PaykeyRevealResponseDataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        PaykeyRevealResponseDataBankData expectedBankData = new()
        {
            AccountNumber = "****1234",
            AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };
        string expectedCustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";
        string expectedInstitutionName = "Bank of America";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        PaykeyRevealResponseDataStatusDetails expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
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
        var model = new PaykeyRevealResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = PaykeyRevealResponseDataSource.Straddle,
            Status = PaykeyRevealResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyRevealResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
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
                Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyRevealResponseData>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyRevealResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = PaykeyRevealResponseDataSource.Straddle,
            Status = PaykeyRevealResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyRevealResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
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
                Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyRevealResponseData>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        PaykeyRevealResponseDataConfig expectedConfig = new()
        {
            ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedLabel = "Bank of America ****1234";
        string expectedPaykey = "paykey";
        ApiEnum<string, PaykeyRevealResponseDataSource> expectedSource =
            PaykeyRevealResponseDataSource.Straddle;
        ApiEnum<string, PaykeyRevealResponseDataStatus> expectedStatus =
            PaykeyRevealResponseDataStatus.Pending;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        PaykeyRevealResponseDataBalance expectedBalance = new()
        {
            Status = PaykeyRevealResponseDataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        PaykeyRevealResponseDataBankData expectedBankData = new()
        {
            AccountNumber = "****1234",
            AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };
        string expectedCustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";
        string expectedInstitutionName = "Bank of America";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        PaykeyRevealResponseDataStatusDetails expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
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
        var model = new PaykeyRevealResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = PaykeyRevealResponseDataSource.Straddle,
            Status = PaykeyRevealResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyRevealResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
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
                Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PaykeyRevealResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = PaykeyRevealResponseDataSource.Straddle,
            Status = PaykeyRevealResponseDataStatus.Pending,
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
        var model = new PaykeyRevealResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = PaykeyRevealResponseDataSource.Straddle,
            Status = PaykeyRevealResponseDataStatus.Pending,
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
        var model = new PaykeyRevealResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = PaykeyRevealResponseDataSource.Straddle,
            Status = PaykeyRevealResponseDataStatus.Pending,
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
        var model = new PaykeyRevealResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = PaykeyRevealResponseDataSource.Straddle,
            Status = PaykeyRevealResponseDataStatus.Pending,
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
        var model = new PaykeyRevealResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = PaykeyRevealResponseDataSource.Straddle,
            Status = PaykeyRevealResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyRevealResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
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
        var model = new PaykeyRevealResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = PaykeyRevealResponseDataSource.Straddle,
            Status = PaykeyRevealResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyRevealResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new PaykeyRevealResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = PaykeyRevealResponseDataSource.Straddle,
            Status = PaykeyRevealResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyRevealResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
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
        var model = new PaykeyRevealResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
                SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "Bank of America ****1234",
            Paykey = "paykey",
            Source = PaykeyRevealResponseDataSource.Straddle,
            Status = PaykeyRevealResponseDataStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = PaykeyRevealResponseDataBalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
                Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
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

public class PaykeyRevealResponseDataConfigTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyRevealResponseDataConfig
        {
            ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
        };

        ApiEnum<string, PaykeyRevealResponseDataConfigProcessingMethod> expectedProcessingMethod =
            PaykeyRevealResponseDataConfigProcessingMethod.Inline;
        ApiEnum<string, PaykeyRevealResponseDataConfigSandboxOutcome> expectedSandboxOutcome =
            PaykeyRevealResponseDataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, model.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, model.SandboxOutcome);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PaykeyRevealResponseDataConfig
        {
            ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyRevealResponseDataConfig>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyRevealResponseDataConfig
        {
            ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyRevealResponseDataConfig>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, PaykeyRevealResponseDataConfigProcessingMethod> expectedProcessingMethod =
            PaykeyRevealResponseDataConfigProcessingMethod.Inline;
        ApiEnum<string, PaykeyRevealResponseDataConfigSandboxOutcome> expectedSandboxOutcome =
            PaykeyRevealResponseDataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, deserialized.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, deserialized.SandboxOutcome);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PaykeyRevealResponseDataConfig
        {
            ProcessingMethod = PaykeyRevealResponseDataConfigProcessingMethod.Inline,
            SandboxOutcome = PaykeyRevealResponseDataConfigSandboxOutcome.Standard,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PaykeyRevealResponseDataConfig { };

        Assert.Null(model.ProcessingMethod);
        Assert.False(model.RawData.ContainsKey("processing_method"));
        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new PaykeyRevealResponseDataConfig { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new PaykeyRevealResponseDataConfig
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
        var model = new PaykeyRevealResponseDataConfig
        {
            // Null should be interpreted as omitted for these properties
            ProcessingMethod = null,
            SandboxOutcome = null,
        };

        model.Validate();
    }
}

public class PaykeyRevealResponseDataConfigProcessingMethodTest : TestBase
{
    [Theory]
    [InlineData(PaykeyRevealResponseDataConfigProcessingMethod.Inline)]
    [InlineData(PaykeyRevealResponseDataConfigProcessingMethod.Background)]
    [InlineData(PaykeyRevealResponseDataConfigProcessingMethod.Skip)]
    public void Validation_Works(PaykeyRevealResponseDataConfigProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseDataConfigProcessingMethod> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataConfigProcessingMethod>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyRevealResponseDataConfigProcessingMethod.Inline)]
    [InlineData(PaykeyRevealResponseDataConfigProcessingMethod.Background)]
    [InlineData(PaykeyRevealResponseDataConfigProcessingMethod.Skip)]
    public void SerializationRoundtrip_Works(
        PaykeyRevealResponseDataConfigProcessingMethod rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseDataConfigProcessingMethod> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataConfigProcessingMethod>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataConfigProcessingMethod>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataConfigProcessingMethod>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyRevealResponseDataConfigSandboxOutcomeTest : TestBase
{
    [Theory]
    [InlineData(PaykeyRevealResponseDataConfigSandboxOutcome.Standard)]
    [InlineData(PaykeyRevealResponseDataConfigSandboxOutcome.Active)]
    [InlineData(PaykeyRevealResponseDataConfigSandboxOutcome.Rejected)]
    [InlineData(PaykeyRevealResponseDataConfigSandboxOutcome.Review)]
    public void Validation_Works(PaykeyRevealResponseDataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseDataConfigSandboxOutcome> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataConfigSandboxOutcome>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyRevealResponseDataConfigSandboxOutcome.Standard)]
    [InlineData(PaykeyRevealResponseDataConfigSandboxOutcome.Active)]
    [InlineData(PaykeyRevealResponseDataConfigSandboxOutcome.Rejected)]
    [InlineData(PaykeyRevealResponseDataConfigSandboxOutcome.Review)]
    public void SerializationRoundtrip_Works(PaykeyRevealResponseDataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseDataConfigSandboxOutcome> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataConfigSandboxOutcome>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataConfigSandboxOutcome>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataConfigSandboxOutcome>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyRevealResponseDataSourceTest : TestBase
{
    [Theory]
    [InlineData(PaykeyRevealResponseDataSource.BankAccount)]
    [InlineData(PaykeyRevealResponseDataSource.Straddle)]
    [InlineData(PaykeyRevealResponseDataSource.Mx)]
    [InlineData(PaykeyRevealResponseDataSource.Plaid)]
    [InlineData(PaykeyRevealResponseDataSource.Tan)]
    [InlineData(PaykeyRevealResponseDataSource.Quiltt)]
    public void Validation_Works(PaykeyRevealResponseDataSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseDataSource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyRevealResponseDataSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyRevealResponseDataSource.BankAccount)]
    [InlineData(PaykeyRevealResponseDataSource.Straddle)]
    [InlineData(PaykeyRevealResponseDataSource.Mx)]
    [InlineData(PaykeyRevealResponseDataSource.Plaid)]
    [InlineData(PaykeyRevealResponseDataSource.Tan)]
    [InlineData(PaykeyRevealResponseDataSource.Quiltt)]
    public void SerializationRoundtrip_Works(PaykeyRevealResponseDataSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseDataSource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyRevealResponseDataSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyRevealResponseDataStatusTest : TestBase
{
    [Theory]
    [InlineData(PaykeyRevealResponseDataStatus.Pending)]
    [InlineData(PaykeyRevealResponseDataStatus.Active)]
    [InlineData(PaykeyRevealResponseDataStatus.Inactive)]
    [InlineData(PaykeyRevealResponseDataStatus.Rejected)]
    [InlineData(PaykeyRevealResponseDataStatus.Review)]
    [InlineData(PaykeyRevealResponseDataStatus.Blocked)]
    public void Validation_Works(PaykeyRevealResponseDataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseDataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyRevealResponseDataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyRevealResponseDataStatus.Pending)]
    [InlineData(PaykeyRevealResponseDataStatus.Active)]
    [InlineData(PaykeyRevealResponseDataStatus.Inactive)]
    [InlineData(PaykeyRevealResponseDataStatus.Rejected)]
    [InlineData(PaykeyRevealResponseDataStatus.Review)]
    [InlineData(PaykeyRevealResponseDataStatus.Blocked)]
    public void SerializationRoundtrip_Works(PaykeyRevealResponseDataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseDataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyRevealResponseDataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyRevealResponseDataBalanceTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyRevealResponseDataBalance
        {
            Status = PaykeyRevealResponseDataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        ApiEnum<string, PaykeyRevealResponseDataBalanceStatus> expectedStatus =
            PaykeyRevealResponseDataBalanceStatus.Pending;
        int expectedAccountBalance = 0;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedAccountBalance, model.AccountBalance);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PaykeyRevealResponseDataBalance
        {
            Status = PaykeyRevealResponseDataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyRevealResponseDataBalance>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyRevealResponseDataBalance
        {
            Status = PaykeyRevealResponseDataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyRevealResponseDataBalance>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, PaykeyRevealResponseDataBalanceStatus> expectedStatus =
            PaykeyRevealResponseDataBalanceStatus.Pending;
        int expectedAccountBalance = 0;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedAccountBalance, deserialized.AccountBalance);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PaykeyRevealResponseDataBalance
        {
            Status = PaykeyRevealResponseDataBalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PaykeyRevealResponseDataBalance
        {
            Status = PaykeyRevealResponseDataBalanceStatus.Pending,
        };

        Assert.Null(model.AccountBalance);
        Assert.False(model.RawData.ContainsKey("account_balance"));
        Assert.Null(model.UpdatedAt);
        Assert.False(model.RawData.ContainsKey("updated_at"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new PaykeyRevealResponseDataBalance
        {
            Status = PaykeyRevealResponseDataBalanceStatus.Pending,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new PaykeyRevealResponseDataBalance
        {
            Status = PaykeyRevealResponseDataBalanceStatus.Pending,

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
        var model = new PaykeyRevealResponseDataBalance
        {
            Status = PaykeyRevealResponseDataBalanceStatus.Pending,

            AccountBalance = null,
            UpdatedAt = null,
        };

        model.Validate();
    }
}

public class PaykeyRevealResponseDataBalanceStatusTest : TestBase
{
    [Theory]
    [InlineData(PaykeyRevealResponseDataBalanceStatus.Pending)]
    [InlineData(PaykeyRevealResponseDataBalanceStatus.Completed)]
    [InlineData(PaykeyRevealResponseDataBalanceStatus.Failed)]
    public void Validation_Works(PaykeyRevealResponseDataBalanceStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseDataBalanceStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataBalanceStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyRevealResponseDataBalanceStatus.Pending)]
    [InlineData(PaykeyRevealResponseDataBalanceStatus.Completed)]
    [InlineData(PaykeyRevealResponseDataBalanceStatus.Failed)]
    public void SerializationRoundtrip_Works(PaykeyRevealResponseDataBalanceStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseDataBalanceStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataBalanceStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataBalanceStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataBalanceStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyRevealResponseDataBankDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyRevealResponseDataBankData
        {
            AccountNumber = "****1234",
            AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        string expectedAccountNumber = "****1234";
        ApiEnum<string, PaykeyRevealResponseDataBankDataAccountType> expectedAccountType =
            PaykeyRevealResponseDataBankDataAccountType.Checking;
        string expectedRoutingNumber = "021000021";

        Assert.Equal(expectedAccountNumber, model.AccountNumber);
        Assert.Equal(expectedAccountType, model.AccountType);
        Assert.Equal(expectedRoutingNumber, model.RoutingNumber);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PaykeyRevealResponseDataBankData
        {
            AccountNumber = "****1234",
            AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyRevealResponseDataBankData>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyRevealResponseDataBankData
        {
            AccountNumber = "****1234",
            AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyRevealResponseDataBankData>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedAccountNumber = "****1234";
        ApiEnum<string, PaykeyRevealResponseDataBankDataAccountType> expectedAccountType =
            PaykeyRevealResponseDataBankDataAccountType.Checking;
        string expectedRoutingNumber = "021000021";

        Assert.Equal(expectedAccountNumber, deserialized.AccountNumber);
        Assert.Equal(expectedAccountType, deserialized.AccountType);
        Assert.Equal(expectedRoutingNumber, deserialized.RoutingNumber);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PaykeyRevealResponseDataBankData
        {
            AccountNumber = "****1234",
            AccountType = PaykeyRevealResponseDataBankDataAccountType.Checking,
            RoutingNumber = "021000021",
        };

        model.Validate();
    }
}

public class PaykeyRevealResponseDataBankDataAccountTypeTest : TestBase
{
    [Theory]
    [InlineData(PaykeyRevealResponseDataBankDataAccountType.Checking)]
    [InlineData(PaykeyRevealResponseDataBankDataAccountType.Savings)]
    public void Validation_Works(PaykeyRevealResponseDataBankDataAccountType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseDataBankDataAccountType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataBankDataAccountType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyRevealResponseDataBankDataAccountType.Checking)]
    [InlineData(PaykeyRevealResponseDataBankDataAccountType.Savings)]
    public void SerializationRoundtrip_Works(PaykeyRevealResponseDataBankDataAccountType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseDataBankDataAccountType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataBankDataAccountType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataBankDataAccountType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataBankDataAccountType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyRevealResponseDataStatusDetailsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyRevealResponseDataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Bank account sucesfully validated";
        ApiEnum<string, PaykeyRevealResponseDataStatusDetailsReason> expectedReason =
            PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds;
        ApiEnum<string, PaykeyRevealResponseDataStatusDetailsSource> expectedSource =
            PaykeyRevealResponseDataStatusDetailsSource.Watchtower;
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
        var model = new PaykeyRevealResponseDataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyRevealResponseDataStatusDetails>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyRevealResponseDataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyRevealResponseDataStatusDetails>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Bank account sucesfully validated";
        ApiEnum<string, PaykeyRevealResponseDataStatusDetailsReason> expectedReason =
            PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds;
        ApiEnum<string, PaykeyRevealResponseDataStatusDetailsSource> expectedSource =
            PaykeyRevealResponseDataStatusDetailsSource.Watchtower;
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
        var model = new PaykeyRevealResponseDataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PaykeyRevealResponseDataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
        };

        Assert.Null(model.Code);
        Assert.False(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new PaykeyRevealResponseDataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new PaykeyRevealResponseDataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,

            Code = null,
        };

        Assert.Null(model.Code);
        Assert.True(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new PaykeyRevealResponseDataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds,
            Source = PaykeyRevealResponseDataStatusDetailsSource.Watchtower,

            Code = null,
        };

        model.Validate();
    }
}

public class PaykeyRevealResponseDataStatusDetailsReasonTest : TestBase
{
    [Theory]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.ClosedBankAccount)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InvalidBankAccount)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InvalidRouting)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.Disputed)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.PaymentStopped)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.OwnerDeceased)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.FrozenBankAccount)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.RiskReview)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.Fraudulent)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.DuplicateEntry)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InvalidPaykey)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.PaymentBlocked)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.AmountTooLarge)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.TooManyAttempts)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InternalSystemError)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.UserRequest)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.Ok)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.OtherNetworkReturn)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.PayoutRefused)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.CancelRequest)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.FailedVerification)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.RequireReview)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.BlockedBySystem)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.WatchtowerReview)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.ClosedBankAccount1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InvalidBankAccount1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InvalidRouting1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.Disputed1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.PaymentStopped1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.OwnerDeceased1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.FrozenBankAccount1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.RiskReview1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.Fraudulent1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.DuplicateEntry1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InvalidPaykey1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.PaymentBlocked1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.AmountTooLarge1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.TooManyAttempts1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InternalSystemError1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.UserRequest1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.Ok1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.OtherNetworkReturn1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.PayoutRefused1)]
    public void Validation_Works(PaykeyRevealResponseDataStatusDetailsReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseDataStatusDetailsReason> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataStatusDetailsReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.ClosedBankAccount)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InvalidBankAccount)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InvalidRouting)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.Disputed)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.PaymentStopped)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.OwnerDeceased)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.FrozenBankAccount)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.RiskReview)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.Fraudulent)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.DuplicateEntry)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InvalidPaykey)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.PaymentBlocked)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.AmountTooLarge)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.TooManyAttempts)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InternalSystemError)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.UserRequest)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.Ok)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.OtherNetworkReturn)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.PayoutRefused)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.CancelRequest)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.FailedVerification)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.RequireReview)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.BlockedBySystem)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.WatchtowerReview)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InsufficientFunds1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.ClosedBankAccount1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InvalidBankAccount1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InvalidRouting1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.Disputed1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.PaymentStopped1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.OwnerDeceased1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.FrozenBankAccount1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.RiskReview1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.Fraudulent1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.DuplicateEntry1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InvalidPaykey1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.PaymentBlocked1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.AmountTooLarge1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.TooManyAttempts1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.InternalSystemError1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.UserRequest1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.Ok1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.OtherNetworkReturn1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsReason.PayoutRefused1)]
    public void SerializationRoundtrip_Works(PaykeyRevealResponseDataStatusDetailsReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseDataStatusDetailsReason> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataStatusDetailsReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataStatusDetailsReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataStatusDetailsReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyRevealResponseDataStatusDetailsSourceTest : TestBase
{
    [Theory]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.Watchtower)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.BankDecline)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.CustomerDispute)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.UserAction)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.System)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.Watchtower1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.BankDecline1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.CustomerDispute1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.UserAction1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.System1)]
    public void Validation_Works(PaykeyRevealResponseDataStatusDetailsSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseDataStatusDetailsSource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataStatusDetailsSource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.Watchtower)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.BankDecline)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.CustomerDispute)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.UserAction)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.System)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.Watchtower1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.BankDecline1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.CustomerDispute1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.UserAction1)]
    [InlineData(PaykeyRevealResponseDataStatusDetailsSource.System1)]
    public void SerializationRoundtrip_Works(PaykeyRevealResponseDataStatusDetailsSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseDataStatusDetailsSource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataStatusDetailsSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataStatusDetailsSource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseDataStatusDetailsSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PaykeyRevealResponseResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(PaykeyRevealResponseResponseType.Object)]
    [InlineData(PaykeyRevealResponseResponseType.Array)]
    [InlineData(PaykeyRevealResponseResponseType.Error)]
    [InlineData(PaykeyRevealResponseResponseType.None)]
    [InlineData(PaykeyRevealResponseResponseType.Object1)]
    [InlineData(PaykeyRevealResponseResponseType.Array1)]
    [InlineData(PaykeyRevealResponseResponseType.Error1)]
    [InlineData(PaykeyRevealResponseResponseType.None1)]
    public void Validation_Works(PaykeyRevealResponseResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyRevealResponseResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyRevealResponseResponseType.Object)]
    [InlineData(PaykeyRevealResponseResponseType.Array)]
    [InlineData(PaykeyRevealResponseResponseType.Error)]
    [InlineData(PaykeyRevealResponseResponseType.None)]
    [InlineData(PaykeyRevealResponseResponseType.Object1)]
    [InlineData(PaykeyRevealResponseResponseType.Array1)]
    [InlineData(PaykeyRevealResponseResponseType.Error1)]
    [InlineData(PaykeyRevealResponseResponseType.None1)]
    public void SerializationRoundtrip_Works(PaykeyRevealResponseResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyRevealResponseResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyRevealResponseResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PaykeyRevealResponseResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}
