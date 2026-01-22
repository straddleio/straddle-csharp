using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Charges;
using Models = Straddle.Models;

namespace Straddle.Tests.Models.Charges;

public class ChargeV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ChargeV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 10000,
                Config = new()
                {
                    BalanceCheck = DataConfigBalanceCheck.Required,
                    SandboxOutcome = DataConfigSandboxOutcome.Standard,
                },
                ConsentType = DataConsentType.Internet,
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Currency = "currency",
                Description = "Monthly subscription fee",
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                Paykey = "paykey",
                PaymentDate = "2019-12-27",
                Status = Status.Created,
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
                        Reason = Reason.InsufficientFunds,
                        Source = Source.Watchtower,
                        Status = StatusHistoryStatus.Created,
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
                PaymentRail = PaymentRail.Ach,
                ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = DataConfigBalanceCheck.Required,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            ConsentType = DataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = Status.Created,
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
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Status = StatusHistoryStatus.Created,
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
            PaymentRail = PaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
        var model = new ChargeV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 10000,
                Config = new()
                {
                    BalanceCheck = DataConfigBalanceCheck.Required,
                    SandboxOutcome = DataConfigSandboxOutcome.Standard,
                },
                ConsentType = DataConsentType.Internet,
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Currency = "currency",
                Description = "Monthly subscription fee",
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                Paykey = "paykey",
                PaymentDate = "2019-12-27",
                Status = Status.Created,
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
                        Reason = Reason.InsufficientFunds,
                        Source = Source.Watchtower,
                        Status = StatusHistoryStatus.Created,
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
                PaymentRail = PaymentRail.Ach,
                ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ChargeV1>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ChargeV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 10000,
                Config = new()
                {
                    BalanceCheck = DataConfigBalanceCheck.Required,
                    SandboxOutcome = DataConfigSandboxOutcome.Standard,
                },
                ConsentType = DataConsentType.Internet,
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Currency = "currency",
                Description = "Monthly subscription fee",
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                Paykey = "paykey",
                PaymentDate = "2019-12-27",
                Status = Status.Created,
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
                        Reason = Reason.InsufficientFunds,
                        Source = Source.Watchtower,
                        Status = StatusHistoryStatus.Created,
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
                PaymentRail = PaymentRail.Ach,
                ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ChargeV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = DataConfigBalanceCheck.Required,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            ConsentType = DataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = Status.Created,
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
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Status = StatusHistoryStatus.Created,
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
            PaymentRail = PaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
        var model = new ChargeV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 10000,
                Config = new()
                {
                    BalanceCheck = DataConfigBalanceCheck.Required,
                    SandboxOutcome = DataConfigSandboxOutcome.Standard,
                },
                ConsentType = DataConsentType.Internet,
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Currency = "currency",
                Description = "Monthly subscription fee",
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                Paykey = "paykey",
                PaymentDate = "2019-12-27",
                Status = Status.Created,
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
                        Reason = Reason.InsufficientFunds,
                        Source = Source.Watchtower,
                        Status = StatusHistoryStatus.Created,
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
                PaymentRail = PaymentRail.Ach,
                ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = DataConfigBalanceCheck.Required,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            ConsentType = DataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = Status.Created,
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
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Status = StatusHistoryStatus.Created,
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
            PaymentRail = PaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedAmount = 10000;
        DataConfig expectedConfig = new()
        {
            BalanceCheck = DataConfigBalanceCheck.Required,
            SandboxOutcome = DataConfigSandboxOutcome.Standard,
        };
        ApiEnum<string, DataConsentType> expectedConsentType = DataConsentType.Internet;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedCurrency = "currency";
        string expectedDescription = "Monthly subscription fee";
        Models::DeviceInfoV1 expectedDevice = new("192.168.1.1");
        string expectedExternalID = "external_id";
        List<string> expectedFundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"];
        string expectedPaykey = "paykey";
        string expectedPaymentDate = "2019-12-27";
        ApiEnum<string, Status> expectedStatus = Status.Created;
        Models::StatusDetailsV1 expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Models::Reason.InsufficientFunds,
            Source = Models::Source.System,
            Code = null,
        };
        List<StatusHistory> expectedStatusHistory =
        [
            new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Reason.InsufficientFunds,
                Source = Source.Watchtower,
                Status = StatusHistoryStatus.Created,
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
        ApiEnum<string, PaymentRail> expectedPaymentRail = PaymentRail.Ach;
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = DataConfigBalanceCheck.Required,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            ConsentType = DataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = Status.Created,
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
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Status = StatusHistoryStatus.Created,
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
            PaymentRail = PaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = DataConfigBalanceCheck.Required,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            ConsentType = DataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = Status.Created,
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
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Status = StatusHistoryStatus.Created,
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
            PaymentRail = PaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedAmount = 10000;
        DataConfig expectedConfig = new()
        {
            BalanceCheck = DataConfigBalanceCheck.Required,
            SandboxOutcome = DataConfigSandboxOutcome.Standard,
        };
        ApiEnum<string, DataConsentType> expectedConsentType = DataConsentType.Internet;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedCurrency = "currency";
        string expectedDescription = "Monthly subscription fee";
        Models::DeviceInfoV1 expectedDevice = new("192.168.1.1");
        string expectedExternalID = "external_id";
        List<string> expectedFundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"];
        string expectedPaykey = "paykey";
        string expectedPaymentDate = "2019-12-27";
        ApiEnum<string, Status> expectedStatus = Status.Created;
        Models::StatusDetailsV1 expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Models::Reason.InsufficientFunds,
            Source = Models::Source.System,
            Code = null,
        };
        List<StatusHistory> expectedStatusHistory =
        [
            new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Reason.InsufficientFunds,
                Source = Source.Watchtower,
                Status = StatusHistoryStatus.Created,
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
        ApiEnum<string, PaymentRail> expectedPaymentRail = PaymentRail.Ach;
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = DataConfigBalanceCheck.Required,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            ConsentType = DataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = Status.Created,
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
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Status = StatusHistoryStatus.Created,
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
            PaymentRail = PaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = DataConfigBalanceCheck.Required,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            ConsentType = DataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = Status.Created,
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
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Status = StatusHistoryStatus.Created,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = DataConfigBalanceCheck.Required,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            ConsentType = DataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = Status.Created,
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
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Status = StatusHistoryStatus.Created,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = DataConfigBalanceCheck.Required,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            ConsentType = DataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = Status.Created,
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
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Status = StatusHistoryStatus.Created,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = DataConfigBalanceCheck.Required,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            ConsentType = DataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = Status.Created,
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
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Status = StatusHistoryStatus.Created,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = DataConfigBalanceCheck.Required,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            ConsentType = DataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = Status.Created,
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
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Status = StatusHistoryStatus.Created,
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
            PaymentRail = PaymentRail.Ach,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = DataConfigBalanceCheck.Required,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            ConsentType = DataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = Status.Created,
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
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Status = StatusHistoryStatus.Created,
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
            PaymentRail = PaymentRail.Ach,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = DataConfigBalanceCheck.Required,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            ConsentType = DataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = Status.Created,
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
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Status = StatusHistoryStatus.Created,
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
            PaymentRail = PaymentRail.Ach,

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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            Config = new()
            {
                BalanceCheck = DataConfigBalanceCheck.Required,
                SandboxOutcome = DataConfigSandboxOutcome.Standard,
            },
            ConsentType = DataConsentType.Internet,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Monthly subscription fee",
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = Status.Created,
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
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Status = StatusHistoryStatus.Created,
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
            PaymentRail = PaymentRail.Ach,

            EffectiveAt = null,
            Metadata = null,
            ProcessedAt = null,
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
            BalanceCheck = DataConfigBalanceCheck.Required,
            SandboxOutcome = DataConfigSandboxOutcome.Standard,
        };

        ApiEnum<string, DataConfigBalanceCheck> expectedBalanceCheck =
            DataConfigBalanceCheck.Required;
        ApiEnum<string, DataConfigSandboxOutcome> expectedSandboxOutcome =
            DataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedBalanceCheck, model.BalanceCheck);
        Assert.Equal(expectedSandboxOutcome, model.SandboxOutcome);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new DataConfig
        {
            BalanceCheck = DataConfigBalanceCheck.Required,
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
            BalanceCheck = DataConfigBalanceCheck.Required,
            SandboxOutcome = DataConfigSandboxOutcome.Standard,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<DataConfig>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, DataConfigBalanceCheck> expectedBalanceCheck =
            DataConfigBalanceCheck.Required;
        ApiEnum<string, DataConfigSandboxOutcome> expectedSandboxOutcome =
            DataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedBalanceCheck, deserialized.BalanceCheck);
        Assert.Equal(expectedSandboxOutcome, deserialized.SandboxOutcome);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new DataConfig
        {
            BalanceCheck = DataConfigBalanceCheck.Required,
            SandboxOutcome = DataConfigSandboxOutcome.Standard,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new DataConfig { BalanceCheck = DataConfigBalanceCheck.Required };

        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new DataConfig { BalanceCheck = DataConfigBalanceCheck.Required };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new DataConfig
        {
            BalanceCheck = DataConfigBalanceCheck.Required,

            // Null should be interpreted as omitted for these properties
            SandboxOutcome = null,
        };

        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new DataConfig
        {
            BalanceCheck = DataConfigBalanceCheck.Required,

            // Null should be interpreted as omitted for these properties
            SandboxOutcome = null,
        };

        model.Validate();
    }
}

public class DataConfigBalanceCheckTest : TestBase
{
    [Theory]
    [InlineData(DataConfigBalanceCheck.Required)]
    [InlineData(DataConfigBalanceCheck.Enabled)]
    [InlineData(DataConfigBalanceCheck.Disabled)]
    public void Validation_Works(DataConfigBalanceCheck rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataConfigBalanceCheck> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataConfigBalanceCheck>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(DataConfigBalanceCheck.Required)]
    [InlineData(DataConfigBalanceCheck.Enabled)]
    [InlineData(DataConfigBalanceCheck.Disabled)]
    public void SerializationRoundtrip_Works(DataConfigBalanceCheck rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataConfigBalanceCheck> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataConfigBalanceCheck>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataConfigBalanceCheck>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataConfigBalanceCheck>>(
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
    [InlineData(DataConfigSandboxOutcome.Paid)]
    [InlineData(DataConfigSandboxOutcome.OnHoldDailyLimit)]
    [InlineData(DataConfigSandboxOutcome.CancelledForFraudRisk)]
    [InlineData(DataConfigSandboxOutcome.CancelledForBalanceCheck)]
    [InlineData(DataConfigSandboxOutcome.FailedInsufficientFunds)]
    [InlineData(DataConfigSandboxOutcome.ReversedInsufficientFunds)]
    [InlineData(DataConfigSandboxOutcome.FailedCustomerDispute)]
    [InlineData(DataConfigSandboxOutcome.ReversedCustomerDispute)]
    [InlineData(DataConfigSandboxOutcome.FailedClosedBankAccount)]
    [InlineData(DataConfigSandboxOutcome.ReversedClosedBankAccount)]
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
    [InlineData(DataConfigSandboxOutcome.Paid)]
    [InlineData(DataConfigSandboxOutcome.OnHoldDailyLimit)]
    [InlineData(DataConfigSandboxOutcome.CancelledForFraudRisk)]
    [InlineData(DataConfigSandboxOutcome.CancelledForBalanceCheck)]
    [InlineData(DataConfigSandboxOutcome.FailedInsufficientFunds)]
    [InlineData(DataConfigSandboxOutcome.ReversedInsufficientFunds)]
    [InlineData(DataConfigSandboxOutcome.FailedCustomerDispute)]
    [InlineData(DataConfigSandboxOutcome.ReversedCustomerDispute)]
    [InlineData(DataConfigSandboxOutcome.FailedClosedBankAccount)]
    [InlineData(DataConfigSandboxOutcome.ReversedClosedBankAccount)]
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

public class DataConsentTypeTest : TestBase
{
    [Theory]
    [InlineData(DataConsentType.Internet)]
    [InlineData(DataConsentType.Signed)]
    public void Validation_Works(DataConsentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataConsentType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataConsentType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(DataConsentType.Internet)]
    [InlineData(DataConsentType.Signed)]
    public void SerializationRoundtrip_Works(DataConsentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataConsentType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataConsentType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataConsentType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataConsentType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class StatusTest : TestBase
{
    [Theory]
    [InlineData(Status.Created)]
    [InlineData(Status.Scheduled)]
    [InlineData(Status.Failed)]
    [InlineData(Status.Cancelled)]
    [InlineData(Status.OnHold)]
    [InlineData(Status.Pending)]
    [InlineData(Status.Paid)]
    [InlineData(Status.Reversed)]
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
    [InlineData(Status.Created)]
    [InlineData(Status.Scheduled)]
    [InlineData(Status.Failed)]
    [InlineData(Status.Cancelled)]
    [InlineData(Status.OnHold)]
    [InlineData(Status.Pending)]
    [InlineData(Status.Paid)]
    [InlineData(Status.Reversed)]
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

public class StatusHistoryTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new StatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.Watchtower,
            Status = StatusHistoryStatus.Created,
            Code = null,
        };

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Payment successfully created and awaiting validation.";
        ApiEnum<string, Reason> expectedReason = Reason.InsufficientFunds;
        ApiEnum<string, Source> expectedSource = Source.Watchtower;
        ApiEnum<string, StatusHistoryStatus> expectedStatus = StatusHistoryStatus.Created;

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
        var model = new StatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.Watchtower,
            Status = StatusHistoryStatus.Created,
            Code = null,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<StatusHistory>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new StatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.Watchtower,
            Status = StatusHistoryStatus.Created,
            Code = null,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<StatusHistory>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Payment successfully created and awaiting validation.";
        ApiEnum<string, Reason> expectedReason = Reason.InsufficientFunds;
        ApiEnum<string, Source> expectedSource = Source.Watchtower;
        ApiEnum<string, StatusHistoryStatus> expectedStatus = StatusHistoryStatus.Created;

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
        var model = new StatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.Watchtower,
            Status = StatusHistoryStatus.Created,
            Code = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new StatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.Watchtower,
            Status = StatusHistoryStatus.Created,
        };

        Assert.Null(model.Code);
        Assert.False(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new StatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.Watchtower,
            Status = StatusHistoryStatus.Created,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new StatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.Watchtower,
            Status = StatusHistoryStatus.Created,

            Code = null,
        };

        Assert.Null(model.Code);
        Assert.True(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new StatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.Watchtower,
            Status = StatusHistoryStatus.Created,

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

public class SourceTest : TestBase
{
    [Theory]
    [InlineData(Source.Watchtower)]
    [InlineData(Source.BankDecline)]
    [InlineData(Source.CustomerDispute)]
    [InlineData(Source.UserAction)]
    [InlineData(Source.System)]
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
    [InlineData(Source.BankDecline)]
    [InlineData(Source.CustomerDispute)]
    [InlineData(Source.UserAction)]
    [InlineData(Source.System)]
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

public class StatusHistoryStatusTest : TestBase
{
    [Theory]
    [InlineData(StatusHistoryStatus.Created)]
    [InlineData(StatusHistoryStatus.Scheduled)]
    [InlineData(StatusHistoryStatus.Failed)]
    [InlineData(StatusHistoryStatus.Cancelled)]
    [InlineData(StatusHistoryStatus.OnHold)]
    [InlineData(StatusHistoryStatus.Pending)]
    [InlineData(StatusHistoryStatus.Paid)]
    [InlineData(StatusHistoryStatus.Reversed)]
    public void Validation_Works(StatusHistoryStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, StatusHistoryStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, StatusHistoryStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(StatusHistoryStatus.Created)]
    [InlineData(StatusHistoryStatus.Scheduled)]
    [InlineData(StatusHistoryStatus.Failed)]
    [InlineData(StatusHistoryStatus.Cancelled)]
    [InlineData(StatusHistoryStatus.OnHold)]
    [InlineData(StatusHistoryStatus.Pending)]
    [InlineData(StatusHistoryStatus.Paid)]
    [InlineData(StatusHistoryStatus.Reversed)]
    public void SerializationRoundtrip_Works(StatusHistoryStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, StatusHistoryStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, StatusHistoryStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, StatusHistoryStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, StatusHistoryStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class PaymentRailTest : TestBase
{
    [Theory]
    [InlineData(PaymentRail.Ach)]
    public void Validation_Works(PaymentRail rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaymentRail> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaymentRail>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaymentRail.Ach)]
    public void SerializationRoundtrip_Works(PaymentRail rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaymentRail> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaymentRail>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaymentRail>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaymentRail>>(
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
