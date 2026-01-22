using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Charges;
using Models = Straddle.Models;

namespace Straddle.Tests.Models.Charges;

public class ChargeUnmaskResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ChargeUnmaskResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 0,
                Config = new()
                {
                    BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                    SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
                },
                ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Currency = "currency",
                Description = "description",
                Device = new("ip_address"),
                ExternalID = "external_id",
                FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                Paykey = "paykey",
                PaymentDate = "2019-12-27",
                Status = ChargeUnmaskResponseDataStatus.Created,
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = Models::Reason.InsufficientFunds,
                    Source = Models::Source.System,
                    Code = null,
                },
                StatusHistory =
                [
                    new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Payment successfully created and awaiting validation.",
                        Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                        Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                        Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                        Code = null,
                    },
                ],
                TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                CustomerDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CustomerType = Models::CustomerType.Individual,
                    Email = "ron@swanson.com",
                    Name = "Ron Swanson",
                    Phone = "+1234567890",
                },
                EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                PaykeyDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Label = "Bank of America ****1234",
                    Balance = 0,
                },
                PaymentRail = ChargeUnmaskResponseDataPaymentRail.Ach,
                ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ChargeUnmaskResponseResponseType.Object,
        };

        ChargeUnmaskResponseData expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = ChargeUnmaskResponseDataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Models::Reason.InsufficientFunds,
                Source = Models::Source.System,
                Code = null,
            },
            StatusHistory =
            [
                new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = Models::CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },
            PaymentRail = ChargeUnmaskResponseDataPaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        Models::ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, ChargeUnmaskResponseResponseType> expectedResponseType =
            ChargeUnmaskResponseResponseType.Object;

        Assert.Equal(expectedData, model.Data);
        Assert.Equal(expectedMeta, model.Meta);
        Assert.Equal(expectedResponseType, model.ResponseType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ChargeUnmaskResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 0,
                Config = new()
                {
                    BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                    SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
                },
                ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Currency = "currency",
                Description = "description",
                Device = new("ip_address"),
                ExternalID = "external_id",
                FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                Paykey = "paykey",
                PaymentDate = "2019-12-27",
                Status = ChargeUnmaskResponseDataStatus.Created,
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = Models::Reason.InsufficientFunds,
                    Source = Models::Source.System,
                    Code = null,
                },
                StatusHistory =
                [
                    new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Payment successfully created and awaiting validation.",
                        Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                        Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                        Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                        Code = null,
                    },
                ],
                TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                CustomerDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CustomerType = Models::CustomerType.Individual,
                    Email = "ron@swanson.com",
                    Name = "Ron Swanson",
                    Phone = "+1234567890",
                },
                EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                PaykeyDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Label = "Bank of America ****1234",
                    Balance = 0,
                },
                PaymentRail = ChargeUnmaskResponseDataPaymentRail.Ach,
                ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ChargeUnmaskResponseResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ChargeUnmaskResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ChargeUnmaskResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 0,
                Config = new()
                {
                    BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                    SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
                },
                ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Currency = "currency",
                Description = "description",
                Device = new("ip_address"),
                ExternalID = "external_id",
                FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                Paykey = "paykey",
                PaymentDate = "2019-12-27",
                Status = ChargeUnmaskResponseDataStatus.Created,
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = Models::Reason.InsufficientFunds,
                    Source = Models::Source.System,
                    Code = null,
                },
                StatusHistory =
                [
                    new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Payment successfully created and awaiting validation.",
                        Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                        Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                        Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                        Code = null,
                    },
                ],
                TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                CustomerDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CustomerType = Models::CustomerType.Individual,
                    Email = "ron@swanson.com",
                    Name = "Ron Swanson",
                    Phone = "+1234567890",
                },
                EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                PaykeyDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Label = "Bank of America ****1234",
                    Balance = 0,
                },
                PaymentRail = ChargeUnmaskResponseDataPaymentRail.Ach,
                ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ChargeUnmaskResponseResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ChargeUnmaskResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ChargeUnmaskResponseData expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = ChargeUnmaskResponseDataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Models::Reason.InsufficientFunds,
                Source = Models::Source.System,
                Code = null,
            },
            StatusHistory =
            [
                new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = Models::CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },
            PaymentRail = ChargeUnmaskResponseDataPaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        Models::ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, ChargeUnmaskResponseResponseType> expectedResponseType =
            ChargeUnmaskResponseResponseType.Object;

        Assert.Equal(expectedData, deserialized.Data);
        Assert.Equal(expectedMeta, deserialized.Meta);
        Assert.Equal(expectedResponseType, deserialized.ResponseType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ChargeUnmaskResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 0,
                Config = new()
                {
                    BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                    SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
                },
                ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Currency = "currency",
                Description = "description",
                Device = new("ip_address"),
                ExternalID = "external_id",
                FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                Paykey = "paykey",
                PaymentDate = "2019-12-27",
                Status = ChargeUnmaskResponseDataStatus.Created,
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = Models::Reason.InsufficientFunds,
                    Source = Models::Source.System,
                    Code = null,
                },
                StatusHistory =
                [
                    new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Payment successfully created and awaiting validation.",
                        Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                        Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                        Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                        Code = null,
                    },
                ],
                TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                CustomerDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CustomerType = Models::CustomerType.Individual,
                    Email = "ron@swanson.com",
                    Name = "Ron Swanson",
                    Phone = "+1234567890",
                },
                EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                PaykeyDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Label = "Bank of America ****1234",
                    Balance = 0,
                },
                PaymentRail = ChargeUnmaskResponseDataPaymentRail.Ach,
                ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ChargeUnmaskResponseResponseType.Object,
        };

        model.Validate();
    }
}

public class ChargeUnmaskResponseDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ChargeUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = ChargeUnmaskResponseDataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Models::Reason.InsufficientFunds,
                Source = Models::Source.System,
                Code = null,
            },
            StatusHistory =
            [
                new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = Models::CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },
            PaymentRail = ChargeUnmaskResponseDataPaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedAmount = 0;
        ChargeUnmaskResponseDataConfig expectedConfig = new()
        {
            BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
            SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
        };
        ApiEnum<string, ChargeUnmaskResponseDataConsentType> expectedConsentType =
            ChargeUnmaskResponseDataConsentType.Internet;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedCurrency = "currency";
        string expectedDescription = "description";
        Device expectedDevice = new("ip_address");
        string expectedExternalID = "external_id";
        List<string> expectedFundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"];
        string expectedPaykey = "paykey";
        string expectedPaymentDate = "2019-12-27";
        ApiEnum<string, ChargeUnmaskResponseDataStatus> expectedStatus =
            ChargeUnmaskResponseDataStatus.Created;
        Models::StatusDetailsV1 expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Models::Reason.InsufficientFunds,
            Source = Models::Source.System,
            Code = null,
        };
        List<ChargeUnmaskResponseDataStatusHistory> expectedStatusHistory =
        [
            new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                Code = null,
            },
        ];
        Dictionary<string, string> expectedTraceIds = new() { { "foo", "string" } };
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        Models::CustomerDetailsV1 expectedCustomerDetails = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerType = Models::CustomerType.Individual,
            Email = "ron@swanson.com",
            Name = "Ron Swanson",
            Phone = "+1234567890",
        };
        DateTimeOffset expectedEffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        Models::PaykeyDetailsV1 expectedPaykeyDetails = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Label = "Bank of America ****1234",
            Balance = 0,
        };
        ApiEnum<string, ChargeUnmaskResponseDataPaymentRail> expectedPaymentRail =
            ChargeUnmaskResponseDataPaymentRail.Ach;
        DateTimeOffset expectedProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAmount, model.Amount);
        Assert.Equal(expectedConfig, model.Config);
        Assert.Equal(expectedConsentType, model.ConsentType);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedCurrency, model.Currency);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedDevice, model.Device);
        Assert.Equal(expectedExternalID, model.ExternalID);
        Assert.Equal(expectedFundingIds.Count, model.FundingIds.Count);
        for (int i = 0; i < expectedFundingIds.Count; i++)
        {
            Assert.Equal(expectedFundingIds[i], model.FundingIds[i]);
        }
        Assert.Equal(expectedPaykey, model.Paykey);
        Assert.Equal(expectedPaymentDate, model.PaymentDate);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedStatusDetails, model.StatusDetails);
        Assert.Equal(expectedStatusHistory.Count, model.StatusHistory.Count);
        for (int i = 0; i < expectedStatusHistory.Count; i++)
        {
            Assert.Equal(expectedStatusHistory[i], model.StatusHistory[i]);
        }
        Assert.Equal(expectedTraceIds.Count, model.TraceIds.Count);
        foreach (var item in expectedTraceIds)
        {
            Assert.True(model.TraceIds.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.TraceIds[item.Key]);
        }
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
        Assert.Equal(expectedCustomerDetails, model.CustomerDetails);
        Assert.Equal(expectedEffectiveAt, model.EffectiveAt);
        Assert.NotNull(model.Metadata);
        Assert.Equal(expectedMetadata.Count, model.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(model.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Metadata[item.Key]);
        }
        Assert.Equal(expectedPaykeyDetails, model.PaykeyDetails);
        Assert.Equal(expectedPaymentRail, model.PaymentRail);
        Assert.Equal(expectedProcessedAt, model.ProcessedAt);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ChargeUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = ChargeUnmaskResponseDataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Models::Reason.InsufficientFunds,
                Source = Models::Source.System,
                Code = null,
            },
            StatusHistory =
            [
                new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = Models::CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },
            PaymentRail = ChargeUnmaskResponseDataPaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ChargeUnmaskResponseData>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ChargeUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = ChargeUnmaskResponseDataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Models::Reason.InsufficientFunds,
                Source = Models::Source.System,
                Code = null,
            },
            StatusHistory =
            [
                new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = Models::CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },
            PaymentRail = ChargeUnmaskResponseDataPaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ChargeUnmaskResponseData>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedAmount = 0;
        ChargeUnmaskResponseDataConfig expectedConfig = new()
        {
            BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
            SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
        };
        ApiEnum<string, ChargeUnmaskResponseDataConsentType> expectedConsentType =
            ChargeUnmaskResponseDataConsentType.Internet;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedCurrency = "currency";
        string expectedDescription = "description";
        Device expectedDevice = new("ip_address");
        string expectedExternalID = "external_id";
        List<string> expectedFundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"];
        string expectedPaykey = "paykey";
        string expectedPaymentDate = "2019-12-27";
        ApiEnum<string, ChargeUnmaskResponseDataStatus> expectedStatus =
            ChargeUnmaskResponseDataStatus.Created;
        Models::StatusDetailsV1 expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Models::Reason.InsufficientFunds,
            Source = Models::Source.System,
            Code = null,
        };
        List<ChargeUnmaskResponseDataStatusHistory> expectedStatusHistory =
        [
            new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                Code = null,
            },
        ];
        Dictionary<string, string> expectedTraceIds = new() { { "foo", "string" } };
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        Models::CustomerDetailsV1 expectedCustomerDetails = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerType = Models::CustomerType.Individual,
            Email = "ron@swanson.com",
            Name = "Ron Swanson",
            Phone = "+1234567890",
        };
        DateTimeOffset expectedEffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        Models::PaykeyDetailsV1 expectedPaykeyDetails = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Label = "Bank of America ****1234",
            Balance = 0,
        };
        ApiEnum<string, ChargeUnmaskResponseDataPaymentRail> expectedPaymentRail =
            ChargeUnmaskResponseDataPaymentRail.Ach;
        DateTimeOffset expectedProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAmount, deserialized.Amount);
        Assert.Equal(expectedConfig, deserialized.Config);
        Assert.Equal(expectedConsentType, deserialized.ConsentType);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedCurrency, deserialized.Currency);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedDevice, deserialized.Device);
        Assert.Equal(expectedExternalID, deserialized.ExternalID);
        Assert.Equal(expectedFundingIds.Count, deserialized.FundingIds.Count);
        for (int i = 0; i < expectedFundingIds.Count; i++)
        {
            Assert.Equal(expectedFundingIds[i], deserialized.FundingIds[i]);
        }
        Assert.Equal(expectedPaykey, deserialized.Paykey);
        Assert.Equal(expectedPaymentDate, deserialized.PaymentDate);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedStatusDetails, deserialized.StatusDetails);
        Assert.Equal(expectedStatusHistory.Count, deserialized.StatusHistory.Count);
        for (int i = 0; i < expectedStatusHistory.Count; i++)
        {
            Assert.Equal(expectedStatusHistory[i], deserialized.StatusHistory[i]);
        }
        Assert.Equal(expectedTraceIds.Count, deserialized.TraceIds.Count);
        foreach (var item in expectedTraceIds)
        {
            Assert.True(deserialized.TraceIds.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.TraceIds[item.Key]);
        }
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
        Assert.Equal(expectedCustomerDetails, deserialized.CustomerDetails);
        Assert.Equal(expectedEffectiveAt, deserialized.EffectiveAt);
        Assert.NotNull(deserialized.Metadata);
        Assert.Equal(expectedMetadata.Count, deserialized.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(deserialized.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Metadata[item.Key]);
        }
        Assert.Equal(expectedPaykeyDetails, deserialized.PaykeyDetails);
        Assert.Equal(expectedPaymentRail, deserialized.PaymentRail);
        Assert.Equal(expectedProcessedAt, deserialized.ProcessedAt);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ChargeUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = ChargeUnmaskResponseDataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Models::Reason.InsufficientFunds,
                Source = Models::Source.System,
                Code = null,
            },
            StatusHistory =
            [
                new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = Models::CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },
            PaymentRail = ChargeUnmaskResponseDataPaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ChargeUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = ChargeUnmaskResponseDataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Models::Reason.InsufficientFunds,
                Source = Models::Source.System,
                Code = null,
            },
            StatusHistory =
            [
                new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        Assert.Null(model.CustomerDetails);
        Assert.False(model.RawData.ContainsKey("customer_details"));
        Assert.Null(model.PaykeyDetails);
        Assert.False(model.RawData.ContainsKey("paykey_details"));
        Assert.Null(model.PaymentRail);
        Assert.False(model.RawData.ContainsKey("payment_rail"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new ChargeUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = ChargeUnmaskResponseDataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Models::Reason.InsufficientFunds,
                Source = Models::Source.System,
                Code = null,
            },
            StatusHistory =
            [
                new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ChargeUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = ChargeUnmaskResponseDataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Models::Reason.InsufficientFunds,
                Source = Models::Source.System,
                Code = null,
            },
            StatusHistory =
            [
                new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),

            // Null should be interpreted as omitted for these properties
            CustomerDetails = null,
            PaykeyDetails = null,
            PaymentRail = null,
        };

        Assert.Null(model.CustomerDetails);
        Assert.False(model.RawData.ContainsKey("customer_details"));
        Assert.Null(model.PaykeyDetails);
        Assert.False(model.RawData.ContainsKey("paykey_details"));
        Assert.Null(model.PaymentRail);
        Assert.False(model.RawData.ContainsKey("payment_rail"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ChargeUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = ChargeUnmaskResponseDataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Models::Reason.InsufficientFunds,
                Source = Models::Source.System,
                Code = null,
            },
            StatusHistory =
            [
                new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),

            // Null should be interpreted as omitted for these properties
            CustomerDetails = null,
            PaykeyDetails = null,
            PaymentRail = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ChargeUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = ChargeUnmaskResponseDataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Models::Reason.InsufficientFunds,
                Source = Models::Source.System,
                Code = null,
            },
            StatusHistory =
            [
                new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = Models::CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },
            PaymentRail = ChargeUnmaskResponseDataPaymentRail.Ach,
        };

        Assert.Null(model.EffectiveAt);
        Assert.False(model.RawData.ContainsKey("effective_at"));
        Assert.Null(model.Metadata);
        Assert.False(model.RawData.ContainsKey("metadata"));
        Assert.Null(model.ProcessedAt);
        Assert.False(model.RawData.ContainsKey("processed_at"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new ChargeUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = ChargeUnmaskResponseDataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Models::Reason.InsufficientFunds,
                Source = Models::Source.System,
                Code = null,
            },
            StatusHistory =
            [
                new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = Models::CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },
            PaymentRail = ChargeUnmaskResponseDataPaymentRail.Ach,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new ChargeUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = ChargeUnmaskResponseDataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Models::Reason.InsufficientFunds,
                Source = Models::Source.System,
                Code = null,
            },
            StatusHistory =
            [
                new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = Models::CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },
            PaymentRail = ChargeUnmaskResponseDataPaymentRail.Ach,

            EffectiveAt = null,
            Metadata = null,
            ProcessedAt = null,
        };

        Assert.Null(model.EffectiveAt);
        Assert.True(model.RawData.ContainsKey("effective_at"));
        Assert.Null(model.Metadata);
        Assert.True(model.RawData.ContainsKey("metadata"));
        Assert.Null(model.ProcessedAt);
        Assert.True(model.RawData.ContainsKey("processed_at"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ChargeUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
                SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            ConsentType = ChargeUnmaskResponseDataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = ChargeUnmaskResponseDataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Models::Reason.InsufficientFunds,
                Source = Models::Source.System,
                Code = null,
            },
            StatusHistory =
            [
                new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = Models::CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },
            PaymentRail = ChargeUnmaskResponseDataPaymentRail.Ach,

            EffectiveAt = null,
            Metadata = null,
            ProcessedAt = null,
        };

        model.Validate();
    }
}

public class ChargeUnmaskResponseDataConfigTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ChargeUnmaskResponseDataConfig
        {
            BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
            SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
        };

        ApiEnum<string, ChargeUnmaskResponseDataConfigBalanceCheck> expectedBalanceCheck =
            ChargeUnmaskResponseDataConfigBalanceCheck.Required;
        ApiEnum<string, ChargeUnmaskResponseDataConfigSandboxOutcome> expectedSandboxOutcome =
            ChargeUnmaskResponseDataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedBalanceCheck, model.BalanceCheck);
        Assert.Equal(expectedSandboxOutcome, model.SandboxOutcome);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ChargeUnmaskResponseDataConfig
        {
            BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
            SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ChargeUnmaskResponseDataConfig>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ChargeUnmaskResponseDataConfig
        {
            BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
            SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ChargeUnmaskResponseDataConfig>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, ChargeUnmaskResponseDataConfigBalanceCheck> expectedBalanceCheck =
            ChargeUnmaskResponseDataConfigBalanceCheck.Required;
        ApiEnum<string, ChargeUnmaskResponseDataConfigSandboxOutcome> expectedSandboxOutcome =
            ChargeUnmaskResponseDataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedBalanceCheck, deserialized.BalanceCheck);
        Assert.Equal(expectedSandboxOutcome, deserialized.SandboxOutcome);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ChargeUnmaskResponseDataConfig
        {
            BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
            SandboxOutcome = ChargeUnmaskResponseDataConfigSandboxOutcome.Standard,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ChargeUnmaskResponseDataConfig
        {
            BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
        };

        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new ChargeUnmaskResponseDataConfig
        {
            BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ChargeUnmaskResponseDataConfig
        {
            BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,

            // Null should be interpreted as omitted for these properties
            SandboxOutcome = null,
        };

        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ChargeUnmaskResponseDataConfig
        {
            BalanceCheck = ChargeUnmaskResponseDataConfigBalanceCheck.Required,

            // Null should be interpreted as omitted for these properties
            SandboxOutcome = null,
        };

        model.Validate();
    }
}

public class ChargeUnmaskResponseDataConfigBalanceCheckTest : TestBase
{
    [Theory]
    [InlineData(ChargeUnmaskResponseDataConfigBalanceCheck.Required)]
    [InlineData(ChargeUnmaskResponseDataConfigBalanceCheck.Enabled)]
    [InlineData(ChargeUnmaskResponseDataConfigBalanceCheck.Disabled)]
    public void Validation_Works(ChargeUnmaskResponseDataConfigBalanceCheck rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseDataConfigBalanceCheck> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataConfigBalanceCheck>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ChargeUnmaskResponseDataConfigBalanceCheck.Required)]
    [InlineData(ChargeUnmaskResponseDataConfigBalanceCheck.Enabled)]
    [InlineData(ChargeUnmaskResponseDataConfigBalanceCheck.Disabled)]
    public void SerializationRoundtrip_Works(ChargeUnmaskResponseDataConfigBalanceCheck rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseDataConfigBalanceCheck> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataConfigBalanceCheck>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataConfigBalanceCheck>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataConfigBalanceCheck>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class ChargeUnmaskResponseDataConfigSandboxOutcomeTest : TestBase
{
    [Theory]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.Standard)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.Paid)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.OnHoldDailyLimit)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.CancelledForFraudRisk)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.CancelledForBalanceCheck)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.FailedInsufficientFunds)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.ReversedInsufficientFunds)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.FailedCustomerDispute)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.ReversedCustomerDispute)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.FailedClosedBankAccount)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.ReversedClosedBankAccount)]
    public void Validation_Works(ChargeUnmaskResponseDataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseDataConfigSandboxOutcome> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataConfigSandboxOutcome>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.Standard)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.Paid)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.OnHoldDailyLimit)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.CancelledForFraudRisk)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.CancelledForBalanceCheck)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.FailedInsufficientFunds)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.ReversedInsufficientFunds)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.FailedCustomerDispute)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.ReversedCustomerDispute)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.FailedClosedBankAccount)]
    [InlineData(ChargeUnmaskResponseDataConfigSandboxOutcome.ReversedClosedBankAccount)]
    public void SerializationRoundtrip_Works(ChargeUnmaskResponseDataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseDataConfigSandboxOutcome> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataConfigSandboxOutcome>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataConfigSandboxOutcome>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataConfigSandboxOutcome>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class ChargeUnmaskResponseDataConsentTypeTest : TestBase
{
    [Theory]
    [InlineData(ChargeUnmaskResponseDataConsentType.Internet)]
    [InlineData(ChargeUnmaskResponseDataConsentType.Signed)]
    public void Validation_Works(ChargeUnmaskResponseDataConsentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseDataConsentType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataConsentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ChargeUnmaskResponseDataConsentType.Internet)]
    [InlineData(ChargeUnmaskResponseDataConsentType.Signed)]
    public void SerializationRoundtrip_Works(ChargeUnmaskResponseDataConsentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseDataConsentType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataConsentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataConsentType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataConsentType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class DeviceTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Device { IPAddress = "ip_address" };

        string expectedIPAddress = "ip_address";

        Assert.Equal(expectedIPAddress, model.IPAddress);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Device { IPAddress = "ip_address" };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Device>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Device { IPAddress = "ip_address" };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Device>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedIPAddress = "ip_address";

        Assert.Equal(expectedIPAddress, deserialized.IPAddress);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Device { IPAddress = "ip_address" };

        model.Validate();
    }
}

public class ChargeUnmaskResponseDataStatusTest : TestBase
{
    [Theory]
    [InlineData(ChargeUnmaskResponseDataStatus.Created)]
    [InlineData(ChargeUnmaskResponseDataStatus.Scheduled)]
    [InlineData(ChargeUnmaskResponseDataStatus.Failed)]
    [InlineData(ChargeUnmaskResponseDataStatus.Cancelled)]
    [InlineData(ChargeUnmaskResponseDataStatus.OnHold)]
    [InlineData(ChargeUnmaskResponseDataStatus.Pending)]
    [InlineData(ChargeUnmaskResponseDataStatus.Paid)]
    [InlineData(ChargeUnmaskResponseDataStatus.Reversed)]
    public void Validation_Works(ChargeUnmaskResponseDataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseDataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ChargeUnmaskResponseDataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ChargeUnmaskResponseDataStatus.Created)]
    [InlineData(ChargeUnmaskResponseDataStatus.Scheduled)]
    [InlineData(ChargeUnmaskResponseDataStatus.Failed)]
    [InlineData(ChargeUnmaskResponseDataStatus.Cancelled)]
    [InlineData(ChargeUnmaskResponseDataStatus.OnHold)]
    [InlineData(ChargeUnmaskResponseDataStatus.Pending)]
    [InlineData(ChargeUnmaskResponseDataStatus.Paid)]
    [InlineData(ChargeUnmaskResponseDataStatus.Reversed)]
    public void SerializationRoundtrip_Works(ChargeUnmaskResponseDataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseDataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ChargeUnmaskResponseDataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class ChargeUnmaskResponseDataStatusHistoryTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ChargeUnmaskResponseDataStatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
            Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
            Code = null,
        };

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Payment successfully created and awaiting validation.";
        ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryReason> expectedReason =
            ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds;
        ApiEnum<string, ChargeUnmaskResponseDataStatusHistorySource> expectedSource =
            ChargeUnmaskResponseDataStatusHistorySource.Watchtower;
        ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryStatus> expectedStatus =
            ChargeUnmaskResponseDataStatusHistoryStatus.Created;

        Assert.Equal(expectedChangedAt, model.ChangedAt);
        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedReason, model.Reason);
        Assert.Equal(expectedSource, model.Source);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Null(model.Code);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ChargeUnmaskResponseDataStatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
            Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
            Code = null,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ChargeUnmaskResponseDataStatusHistory>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ChargeUnmaskResponseDataStatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
            Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
            Code = null,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ChargeUnmaskResponseDataStatusHistory>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Payment successfully created and awaiting validation.";
        ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryReason> expectedReason =
            ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds;
        ApiEnum<string, ChargeUnmaskResponseDataStatusHistorySource> expectedSource =
            ChargeUnmaskResponseDataStatusHistorySource.Watchtower;
        ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryStatus> expectedStatus =
            ChargeUnmaskResponseDataStatusHistoryStatus.Created;

        Assert.Equal(expectedChangedAt, deserialized.ChangedAt);
        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedReason, deserialized.Reason);
        Assert.Equal(expectedSource, deserialized.Source);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Null(deserialized.Code);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ChargeUnmaskResponseDataStatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
            Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
            Code = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ChargeUnmaskResponseDataStatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
            Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
        };

        Assert.Null(model.Code);
        Assert.False(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new ChargeUnmaskResponseDataStatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
            Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new ChargeUnmaskResponseDataStatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
            Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,

            Code = null,
        };

        Assert.Null(model.Code);
        Assert.True(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new ChargeUnmaskResponseDataStatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            Source = ChargeUnmaskResponseDataStatusHistorySource.Watchtower,
            Status = ChargeUnmaskResponseDataStatusHistoryStatus.Created,

            Code = null,
        };

        model.Validate();
    }
}

public class ChargeUnmaskResponseDataStatusHistoryReasonTest : TestBase
{
    [Theory]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.ClosedBankAccount)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.InvalidBankAccount)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.InvalidRouting)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.Disputed)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.PaymentStopped)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.OwnerDeceased)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.FrozenBankAccount)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.RiskReview)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.Fraudulent)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.DuplicateEntry)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.InvalidPaykey)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.PaymentBlocked)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.AmountTooLarge)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.TooManyAttempts)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.InternalSystemError)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.UserRequest)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.Ok)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.OtherNetworkReturn)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.PayoutRefused)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.CancelRequest)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.FailedVerification)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.RequireReview)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.BlockedBySystem)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.WatchtowerReview)]
    public void Validation_Works(ChargeUnmaskResponseDataStatusHistoryReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryReason> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.InsufficientFunds)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.ClosedBankAccount)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.InvalidBankAccount)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.InvalidRouting)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.Disputed)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.PaymentStopped)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.OwnerDeceased)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.FrozenBankAccount)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.RiskReview)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.Fraudulent)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.DuplicateEntry)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.InvalidPaykey)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.PaymentBlocked)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.AmountTooLarge)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.TooManyAttempts)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.InternalSystemError)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.UserRequest)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.Ok)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.OtherNetworkReturn)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.PayoutRefused)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.CancelRequest)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.FailedVerification)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.RequireReview)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.BlockedBySystem)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryReason.WatchtowerReview)]
    public void SerializationRoundtrip_Works(ChargeUnmaskResponseDataStatusHistoryReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryReason> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class ChargeUnmaskResponseDataStatusHistorySourceTest : TestBase
{
    [Theory]
    [InlineData(ChargeUnmaskResponseDataStatusHistorySource.Watchtower)]
    [InlineData(ChargeUnmaskResponseDataStatusHistorySource.BankDecline)]
    [InlineData(ChargeUnmaskResponseDataStatusHistorySource.CustomerDispute)]
    [InlineData(ChargeUnmaskResponseDataStatusHistorySource.UserAction)]
    [InlineData(ChargeUnmaskResponseDataStatusHistorySource.System)]
    public void Validation_Works(ChargeUnmaskResponseDataStatusHistorySource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseDataStatusHistorySource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataStatusHistorySource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ChargeUnmaskResponseDataStatusHistorySource.Watchtower)]
    [InlineData(ChargeUnmaskResponseDataStatusHistorySource.BankDecline)]
    [InlineData(ChargeUnmaskResponseDataStatusHistorySource.CustomerDispute)]
    [InlineData(ChargeUnmaskResponseDataStatusHistorySource.UserAction)]
    [InlineData(ChargeUnmaskResponseDataStatusHistorySource.System)]
    public void SerializationRoundtrip_Works(ChargeUnmaskResponseDataStatusHistorySource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseDataStatusHistorySource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataStatusHistorySource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataStatusHistorySource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataStatusHistorySource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class ChargeUnmaskResponseDataStatusHistoryStatusTest : TestBase
{
    [Theory]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryStatus.Created)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryStatus.Scheduled)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryStatus.Failed)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryStatus.Cancelled)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryStatus.OnHold)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryStatus.Pending)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryStatus.Paid)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryStatus.Reversed)]
    public void Validation_Works(ChargeUnmaskResponseDataStatusHistoryStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryStatus.Created)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryStatus.Scheduled)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryStatus.Failed)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryStatus.Cancelled)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryStatus.OnHold)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryStatus.Pending)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryStatus.Paid)]
    [InlineData(ChargeUnmaskResponseDataStatusHistoryStatus.Reversed)]
    public void SerializationRoundtrip_Works(ChargeUnmaskResponseDataStatusHistoryStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataStatusHistoryStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class ChargeUnmaskResponseDataPaymentRailTest : TestBase
{
    [Theory]
    [InlineData(ChargeUnmaskResponseDataPaymentRail.Ach)]
    public void Validation_Works(ChargeUnmaskResponseDataPaymentRail rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseDataPaymentRail> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataPaymentRail>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ChargeUnmaskResponseDataPaymentRail.Ach)]
    public void SerializationRoundtrip_Works(ChargeUnmaskResponseDataPaymentRail rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseDataPaymentRail> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataPaymentRail>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataPaymentRail>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseDataPaymentRail>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class ChargeUnmaskResponseResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(ChargeUnmaskResponseResponseType.Object)]
    [InlineData(ChargeUnmaskResponseResponseType.Array)]
    [InlineData(ChargeUnmaskResponseResponseType.Error)]
    [InlineData(ChargeUnmaskResponseResponseType.None)]
    public void Validation_Works(ChargeUnmaskResponseResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ChargeUnmaskResponseResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ChargeUnmaskResponseResponseType.Object)]
    [InlineData(ChargeUnmaskResponseResponseType.Array)]
    [InlineData(ChargeUnmaskResponseResponseType.Error)]
    [InlineData(ChargeUnmaskResponseResponseType.None)]
    public void SerializationRoundtrip_Works(ChargeUnmaskResponseResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ChargeUnmaskResponseResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ChargeUnmaskResponseResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ChargeUnmaskResponseResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}
