using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Payouts;
using Models = Straddle.Models;

namespace Straddle.Tests.Models.Payouts;

public class PayoutUnmaskResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PayoutUnmaskResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 0,
                Config = new()
                {
                    SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
                },
                Currency = "currency",
                Description = "description",
                Device = new("ip_address"),
                ExternalID = "external_id",
                FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                Paykey = "paykey",
                PaymentDate = "2019-12-27",
                Status = PayoutUnmaskResponseDataStatus.Created,
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
                        Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                        Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                        Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                        Code = null,
                    },
                ],
                TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
                PaymentRail = PayoutUnmaskResponseDataPaymentRail.Ach,
                ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = PayoutUnmaskResponseResponseType.Object,
        };

        PayoutUnmaskResponseData expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = PayoutUnmaskResponseDataStatus.Created,
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
                    Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
            PaymentRail = PayoutUnmaskResponseDataPaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        Models::ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, PayoutUnmaskResponseResponseType> expectedResponseType =
            PayoutUnmaskResponseResponseType.Object;

        Assert.Equal(expectedData, model.Data);
        Assert.Equal(expectedMeta, model.Meta);
        Assert.Equal(expectedResponseType, model.ResponseType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PayoutUnmaskResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 0,
                Config = new()
                {
                    SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
                },
                Currency = "currency",
                Description = "description",
                Device = new("ip_address"),
                ExternalID = "external_id",
                FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                Paykey = "paykey",
                PaymentDate = "2019-12-27",
                Status = PayoutUnmaskResponseDataStatus.Created,
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
                        Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                        Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                        Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                        Code = null,
                    },
                ],
                TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
                PaymentRail = PayoutUnmaskResponseDataPaymentRail.Ach,
                ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = PayoutUnmaskResponseResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PayoutUnmaskResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PayoutUnmaskResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 0,
                Config = new()
                {
                    SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
                },
                Currency = "currency",
                Description = "description",
                Device = new("ip_address"),
                ExternalID = "external_id",
                FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                Paykey = "paykey",
                PaymentDate = "2019-12-27",
                Status = PayoutUnmaskResponseDataStatus.Created,
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
                        Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                        Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                        Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                        Code = null,
                    },
                ],
                TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
                PaymentRail = PayoutUnmaskResponseDataPaymentRail.Ach,
                ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = PayoutUnmaskResponseResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PayoutUnmaskResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        PayoutUnmaskResponseData expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = PayoutUnmaskResponseDataStatus.Created,
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
                    Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
            PaymentRail = PayoutUnmaskResponseDataPaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        Models::ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, PayoutUnmaskResponseResponseType> expectedResponseType =
            PayoutUnmaskResponseResponseType.Object;

        Assert.Equal(expectedData, deserialized.Data);
        Assert.Equal(expectedMeta, deserialized.Meta);
        Assert.Equal(expectedResponseType, deserialized.ResponseType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PayoutUnmaskResponse
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 0,
                Config = new()
                {
                    SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
                },
                Currency = "currency",
                Description = "description",
                Device = new("ip_address"),
                ExternalID = "external_id",
                FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                Paykey = "paykey",
                PaymentDate = "2019-12-27",
                Status = PayoutUnmaskResponseDataStatus.Created,
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
                        Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                        Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                        Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                        Code = null,
                    },
                ],
                TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
                PaymentRail = PayoutUnmaskResponseDataPaymentRail.Ach,
                ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = PayoutUnmaskResponseResponseType.Object,
        };

        model.Validate();
    }
}

public class PayoutUnmaskResponseDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PayoutUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = PayoutUnmaskResponseDataStatus.Created,
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
                    Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
            PaymentRail = PayoutUnmaskResponseDataPaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedAmount = 0;
        PayoutUnmaskResponseDataConfig expectedConfig = new()
        {
            SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
        };
        string expectedCurrency = "currency";
        string expectedDescription = "description";
        Device expectedDevice = new("ip_address");
        string expectedExternalID = "external_id";
        List<string> expectedFundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"];
        string expectedPaykey = "paykey";
        string expectedPaymentDate = "2019-12-27";
        ApiEnum<string, PayoutUnmaskResponseDataStatus> expectedStatus =
            PayoutUnmaskResponseDataStatus.Created;
        Models::StatusDetailsV1 expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Models::Reason.InsufficientFunds,
            Source = Models::Source.System,
            Code = null,
        };
        List<PayoutUnmaskResponseDataStatusHistory> expectedStatusHistory =
        [
            new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                Code = null,
            },
        ];
        Dictionary<string, string> expectedTraceIds = new() { { "foo", "string" } };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
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
        ApiEnum<string, PayoutUnmaskResponseDataPaymentRail> expectedPaymentRail =
            PayoutUnmaskResponseDataPaymentRail.Ach;
        DateTimeOffset expectedProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAmount, model.Amount);
        Assert.Equal(expectedConfig, model.Config);
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
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
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
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PayoutUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = PayoutUnmaskResponseDataStatus.Created,
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
                    Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
            PaymentRail = PayoutUnmaskResponseDataPaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PayoutUnmaskResponseData>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PayoutUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = PayoutUnmaskResponseDataStatus.Created,
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
                    Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
            PaymentRail = PayoutUnmaskResponseDataPaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PayoutUnmaskResponseData>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedAmount = 0;
        PayoutUnmaskResponseDataConfig expectedConfig = new()
        {
            SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
        };
        string expectedCurrency = "currency";
        string expectedDescription = "description";
        Device expectedDevice = new("ip_address");
        string expectedExternalID = "external_id";
        List<string> expectedFundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"];
        string expectedPaykey = "paykey";
        string expectedPaymentDate = "2019-12-27";
        ApiEnum<string, PayoutUnmaskResponseDataStatus> expectedStatus =
            PayoutUnmaskResponseDataStatus.Created;
        Models::StatusDetailsV1 expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Models::Reason.InsufficientFunds,
            Source = Models::Source.System,
            Code = null,
        };
        List<PayoutUnmaskResponseDataStatusHistory> expectedStatusHistory =
        [
            new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                Code = null,
            },
        ];
        Dictionary<string, string> expectedTraceIds = new() { { "foo", "string" } };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
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
        ApiEnum<string, PayoutUnmaskResponseDataPaymentRail> expectedPaymentRail =
            PayoutUnmaskResponseDataPaymentRail.Ach;
        DateTimeOffset expectedProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAmount, deserialized.Amount);
        Assert.Equal(expectedConfig, deserialized.Config);
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
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
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
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PayoutUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = PayoutUnmaskResponseDataStatus.Created,
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
                    Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
            PaymentRail = PayoutUnmaskResponseDataPaymentRail.Ach,
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PayoutUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = PayoutUnmaskResponseDataStatus.Created,
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
                    Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
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
        var model = new PayoutUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = PayoutUnmaskResponseDataStatus.Created,
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
                    Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new PayoutUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = PayoutUnmaskResponseDataStatus.Created,
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
                    Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),

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
        var model = new PayoutUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = PayoutUnmaskResponseDataStatus.Created,
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
                    Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            ProcessedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),

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
        var model = new PayoutUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = PayoutUnmaskResponseDataStatus.Created,
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
                    Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
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
            PaymentRail = PayoutUnmaskResponseDataPaymentRail.Ach,
        };

        Assert.Null(model.CreatedAt);
        Assert.False(model.RawData.ContainsKey("created_at"));
        Assert.Null(model.EffectiveAt);
        Assert.False(model.RawData.ContainsKey("effective_at"));
        Assert.Null(model.Metadata);
        Assert.False(model.RawData.ContainsKey("metadata"));
        Assert.Null(model.ProcessedAt);
        Assert.False(model.RawData.ContainsKey("processed_at"));
        Assert.Null(model.UpdatedAt);
        Assert.False(model.RawData.ContainsKey("updated_at"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new PayoutUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = PayoutUnmaskResponseDataStatus.Created,
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
                    Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
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
            PaymentRail = PayoutUnmaskResponseDataPaymentRail.Ach,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new PayoutUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = PayoutUnmaskResponseDataStatus.Created,
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
                    Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
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
            PaymentRail = PayoutUnmaskResponseDataPaymentRail.Ach,

            CreatedAt = null,
            EffectiveAt = null,
            Metadata = null,
            ProcessedAt = null,
            UpdatedAt = null,
        };

        Assert.Null(model.CreatedAt);
        Assert.True(model.RawData.ContainsKey("created_at"));
        Assert.Null(model.EffectiveAt);
        Assert.True(model.RawData.ContainsKey("effective_at"));
        Assert.Null(model.Metadata);
        Assert.True(model.RawData.ContainsKey("metadata"));
        Assert.Null(model.ProcessedAt);
        Assert.True(model.RawData.ContainsKey("processed_at"));
        Assert.Null(model.UpdatedAt);
        Assert.True(model.RawData.ContainsKey("updated_at"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new PayoutUnmaskResponseData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 0,
            Config = new()
            {
                SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
            },
            Currency = "currency",
            Description = "description",
            Device = new("ip_address"),
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            Status = PayoutUnmaskResponseDataStatus.Created,
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
                    Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
                    Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
                    Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
                    Code = null,
                },
            ],
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
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
            PaymentRail = PayoutUnmaskResponseDataPaymentRail.Ach,

            CreatedAt = null,
            EffectiveAt = null,
            Metadata = null,
            ProcessedAt = null,
            UpdatedAt = null,
        };

        model.Validate();
    }
}

public class PayoutUnmaskResponseDataConfigTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PayoutUnmaskResponseDataConfig
        {
            SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
        };

        ApiEnum<string, PayoutUnmaskResponseDataConfigSandboxOutcome> expectedSandboxOutcome =
            PayoutUnmaskResponseDataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedSandboxOutcome, model.SandboxOutcome);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PayoutUnmaskResponseDataConfig
        {
            SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PayoutUnmaskResponseDataConfig>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PayoutUnmaskResponseDataConfig
        {
            SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PayoutUnmaskResponseDataConfig>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, PayoutUnmaskResponseDataConfigSandboxOutcome> expectedSandboxOutcome =
            PayoutUnmaskResponseDataConfigSandboxOutcome.Standard;

        Assert.Equal(expectedSandboxOutcome, deserialized.SandboxOutcome);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PayoutUnmaskResponseDataConfig
        {
            SandboxOutcome = PayoutUnmaskResponseDataConfigSandboxOutcome.Standard,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PayoutUnmaskResponseDataConfig { };

        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new PayoutUnmaskResponseDataConfig { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new PayoutUnmaskResponseDataConfig
        {
            // Null should be interpreted as omitted for these properties
            SandboxOutcome = null,
        };

        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new PayoutUnmaskResponseDataConfig
        {
            // Null should be interpreted as omitted for these properties
            SandboxOutcome = null,
        };

        model.Validate();
    }
}

public class PayoutUnmaskResponseDataConfigSandboxOutcomeTest : TestBase
{
    [Theory]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.Standard)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.Paid)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.OnHoldDailyLimit)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.CancelledForFraudRisk)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.CancelledForBalanceCheck)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.FailedInsufficientFunds)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedInsufficientFunds)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.FailedCustomerDispute)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedCustomerDispute)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.FailedClosedBankAccount)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedClosedBankAccount)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.Standard1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.Paid1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.OnHoldDailyLimit1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.CancelledForFraudRisk1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.CancelledForBalanceCheck1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.FailedInsufficientFunds1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedInsufficientFunds1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.FailedCustomerDispute1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedCustomerDispute1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.FailedClosedBankAccount1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedClosedBankAccount1)]
    public void Validation_Works(PayoutUnmaskResponseDataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PayoutUnmaskResponseDataConfigSandboxOutcome> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataConfigSandboxOutcome>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.Standard)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.Paid)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.OnHoldDailyLimit)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.CancelledForFraudRisk)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.CancelledForBalanceCheck)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.FailedInsufficientFunds)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedInsufficientFunds)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.FailedCustomerDispute)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedCustomerDispute)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.FailedClosedBankAccount)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedClosedBankAccount)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.Standard1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.Paid1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.OnHoldDailyLimit1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.CancelledForFraudRisk1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.CancelledForBalanceCheck1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.FailedInsufficientFunds1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedInsufficientFunds1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.FailedCustomerDispute1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedCustomerDispute1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.FailedClosedBankAccount1)]
    [InlineData(PayoutUnmaskResponseDataConfigSandboxOutcome.ReversedClosedBankAccount1)]
    public void SerializationRoundtrip_Works(PayoutUnmaskResponseDataConfigSandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PayoutUnmaskResponseDataConfigSandboxOutcome> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataConfigSandboxOutcome>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataConfigSandboxOutcome>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataConfigSandboxOutcome>
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

public class PayoutUnmaskResponseDataStatusTest : TestBase
{
    [Theory]
    [InlineData(PayoutUnmaskResponseDataStatus.Created)]
    [InlineData(PayoutUnmaskResponseDataStatus.Scheduled)]
    [InlineData(PayoutUnmaskResponseDataStatus.Failed)]
    [InlineData(PayoutUnmaskResponseDataStatus.Cancelled)]
    [InlineData(PayoutUnmaskResponseDataStatus.OnHold)]
    [InlineData(PayoutUnmaskResponseDataStatus.Pending)]
    [InlineData(PayoutUnmaskResponseDataStatus.Paid)]
    [InlineData(PayoutUnmaskResponseDataStatus.Reversed)]
    [InlineData(PayoutUnmaskResponseDataStatus.Created1)]
    [InlineData(PayoutUnmaskResponseDataStatus.Scheduled1)]
    [InlineData(PayoutUnmaskResponseDataStatus.Failed1)]
    [InlineData(PayoutUnmaskResponseDataStatus.Cancelled1)]
    [InlineData(PayoutUnmaskResponseDataStatus.OnHold1)]
    [InlineData(PayoutUnmaskResponseDataStatus.Pending1)]
    [InlineData(PayoutUnmaskResponseDataStatus.Paid1)]
    [InlineData(PayoutUnmaskResponseDataStatus.Reversed1)]
    public void Validation_Works(PayoutUnmaskResponseDataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PayoutUnmaskResponseDataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PayoutUnmaskResponseDataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PayoutUnmaskResponseDataStatus.Created)]
    [InlineData(PayoutUnmaskResponseDataStatus.Scheduled)]
    [InlineData(PayoutUnmaskResponseDataStatus.Failed)]
    [InlineData(PayoutUnmaskResponseDataStatus.Cancelled)]
    [InlineData(PayoutUnmaskResponseDataStatus.OnHold)]
    [InlineData(PayoutUnmaskResponseDataStatus.Pending)]
    [InlineData(PayoutUnmaskResponseDataStatus.Paid)]
    [InlineData(PayoutUnmaskResponseDataStatus.Reversed)]
    [InlineData(PayoutUnmaskResponseDataStatus.Created1)]
    [InlineData(PayoutUnmaskResponseDataStatus.Scheduled1)]
    [InlineData(PayoutUnmaskResponseDataStatus.Failed1)]
    [InlineData(PayoutUnmaskResponseDataStatus.Cancelled1)]
    [InlineData(PayoutUnmaskResponseDataStatus.OnHold1)]
    [InlineData(PayoutUnmaskResponseDataStatus.Pending1)]
    [InlineData(PayoutUnmaskResponseDataStatus.Paid1)]
    [InlineData(PayoutUnmaskResponseDataStatus.Reversed1)]
    public void SerializationRoundtrip_Works(PayoutUnmaskResponseDataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PayoutUnmaskResponseDataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PayoutUnmaskResponseDataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PayoutUnmaskResponseDataStatusHistoryTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PayoutUnmaskResponseDataStatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
            Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
            Code = null,
        };

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Payment successfully created and awaiting validation.";
        ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryReason> expectedReason =
            PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds;
        ApiEnum<string, PayoutUnmaskResponseDataStatusHistorySource> expectedSource =
            PayoutUnmaskResponseDataStatusHistorySource.Watchtower;
        ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryStatus> expectedStatus =
            PayoutUnmaskResponseDataStatusHistoryStatus.Created;

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
        var model = new PayoutUnmaskResponseDataStatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
            Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
            Code = null,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PayoutUnmaskResponseDataStatusHistory>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PayoutUnmaskResponseDataStatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
            Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
            Code = null,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PayoutUnmaskResponseDataStatusHistory>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Payment successfully created and awaiting validation.";
        ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryReason> expectedReason =
            PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds;
        ApiEnum<string, PayoutUnmaskResponseDataStatusHistorySource> expectedSource =
            PayoutUnmaskResponseDataStatusHistorySource.Watchtower;
        ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryStatus> expectedStatus =
            PayoutUnmaskResponseDataStatusHistoryStatus.Created;

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
        var model = new PayoutUnmaskResponseDataStatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
            Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
            Code = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PayoutUnmaskResponseDataStatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
            Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
        };

        Assert.Null(model.Code);
        Assert.False(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new PayoutUnmaskResponseDataStatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
            Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new PayoutUnmaskResponseDataStatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
            Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,

            Code = null,
        };

        Assert.Null(model.Code);
        Assert.True(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new PayoutUnmaskResponseDataStatusHistory
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds,
            Source = PayoutUnmaskResponseDataStatusHistorySource.Watchtower,
            Status = PayoutUnmaskResponseDataStatusHistoryStatus.Created,

            Code = null,
        };

        model.Validate();
    }
}

public class PayoutUnmaskResponseDataStatusHistoryReasonTest : TestBase
{
    [Theory]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.ClosedBankAccount)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InvalidBankAccount)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InvalidRouting)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.Disputed)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.PaymentStopped)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.OwnerDeceased)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.FrozenBankAccount)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.RiskReview)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.Fraudulent)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.DuplicateEntry)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InvalidPaykey)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.PaymentBlocked)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.AmountTooLarge)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.TooManyAttempts)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InternalSystemError)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.UserRequest)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.Ok)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.OtherNetworkReturn)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.PayoutRefused)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.CancelRequest)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.FailedVerification)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.RequireReview)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.BlockedBySystem)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.WatchtowerReview)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.ClosedBankAccount1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InvalidBankAccount1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InvalidRouting1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.Disputed1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.PaymentStopped1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.OwnerDeceased1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.FrozenBankAccount1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.RiskReview1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.Fraudulent1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.DuplicateEntry1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InvalidPaykey1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.PaymentBlocked1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.AmountTooLarge1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.TooManyAttempts1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InternalSystemError1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.UserRequest1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.Ok1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.OtherNetworkReturn1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.PayoutRefused1)]
    public void Validation_Works(PayoutUnmaskResponseDataStatusHistoryReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryReason> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.ClosedBankAccount)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InvalidBankAccount)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InvalidRouting)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.Disputed)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.PaymentStopped)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.OwnerDeceased)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.FrozenBankAccount)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.RiskReview)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.Fraudulent)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.DuplicateEntry)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InvalidPaykey)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.PaymentBlocked)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.AmountTooLarge)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.TooManyAttempts)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InternalSystemError)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.UserRequest)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.Ok)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.OtherNetworkReturn)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.PayoutRefused)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.CancelRequest)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.FailedVerification)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.RequireReview)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.BlockedBySystem)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.WatchtowerReview)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InsufficientFunds1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.ClosedBankAccount1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InvalidBankAccount1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InvalidRouting1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.Disputed1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.PaymentStopped1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.OwnerDeceased1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.FrozenBankAccount1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.RiskReview1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.Fraudulent1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.DuplicateEntry1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InvalidPaykey1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.PaymentBlocked1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.AmountTooLarge1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.TooManyAttempts1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.InternalSystemError1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.UserRequest1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.Ok1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.OtherNetworkReturn1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryReason.PayoutRefused1)]
    public void SerializationRoundtrip_Works(PayoutUnmaskResponseDataStatusHistoryReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryReason> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PayoutUnmaskResponseDataStatusHistorySourceTest : TestBase
{
    [Theory]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.Watchtower)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.BankDecline)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.CustomerDispute)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.UserAction)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.System)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.Watchtower1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.BankDecline1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.CustomerDispute1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.UserAction1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.System1)]
    public void Validation_Works(PayoutUnmaskResponseDataStatusHistorySource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PayoutUnmaskResponseDataStatusHistorySource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataStatusHistorySource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.Watchtower)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.BankDecline)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.CustomerDispute)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.UserAction)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.System)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.Watchtower1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.BankDecline1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.CustomerDispute1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.UserAction1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistorySource.System1)]
    public void SerializationRoundtrip_Works(PayoutUnmaskResponseDataStatusHistorySource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PayoutUnmaskResponseDataStatusHistorySource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataStatusHistorySource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataStatusHistorySource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataStatusHistorySource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PayoutUnmaskResponseDataStatusHistoryStatusTest : TestBase
{
    [Theory]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Created)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Scheduled)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Failed)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Cancelled)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.OnHold)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Pending)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Paid)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Reversed)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Created1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Scheduled1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Failed1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Cancelled1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.OnHold1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Pending1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Paid1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Reversed1)]
    public void Validation_Works(PayoutUnmaskResponseDataStatusHistoryStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Created)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Scheduled)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Failed)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Cancelled)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.OnHold)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Pending)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Paid)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Reversed)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Created1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Scheduled1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Failed1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Cancelled1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.OnHold1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Pending1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Paid1)]
    [InlineData(PayoutUnmaskResponseDataStatusHistoryStatus.Reversed1)]
    public void SerializationRoundtrip_Works(PayoutUnmaskResponseDataStatusHistoryStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataStatusHistoryStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PayoutUnmaskResponseDataPaymentRailTest : TestBase
{
    [Theory]
    [InlineData(PayoutUnmaskResponseDataPaymentRail.Ach)]
    [InlineData(PayoutUnmaskResponseDataPaymentRail.Ach1)]
    public void Validation_Works(PayoutUnmaskResponseDataPaymentRail rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PayoutUnmaskResponseDataPaymentRail> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataPaymentRail>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PayoutUnmaskResponseDataPaymentRail.Ach)]
    [InlineData(PayoutUnmaskResponseDataPaymentRail.Ach1)]
    public void SerializationRoundtrip_Works(PayoutUnmaskResponseDataPaymentRail rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PayoutUnmaskResponseDataPaymentRail> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataPaymentRail>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataPaymentRail>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseDataPaymentRail>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class PayoutUnmaskResponseResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(PayoutUnmaskResponseResponseType.Object)]
    [InlineData(PayoutUnmaskResponseResponseType.Array)]
    [InlineData(PayoutUnmaskResponseResponseType.Error)]
    [InlineData(PayoutUnmaskResponseResponseType.None)]
    [InlineData(PayoutUnmaskResponseResponseType.Object1)]
    [InlineData(PayoutUnmaskResponseResponseType.Array1)]
    [InlineData(PayoutUnmaskResponseResponseType.Error1)]
    [InlineData(PayoutUnmaskResponseResponseType.None1)]
    public void Validation_Works(PayoutUnmaskResponseResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PayoutUnmaskResponseResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PayoutUnmaskResponseResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PayoutUnmaskResponseResponseType.Object)]
    [InlineData(PayoutUnmaskResponseResponseType.Array)]
    [InlineData(PayoutUnmaskResponseResponseType.Error)]
    [InlineData(PayoutUnmaskResponseResponseType.None)]
    [InlineData(PayoutUnmaskResponseResponseType.Object1)]
    [InlineData(PayoutUnmaskResponseResponseType.Array1)]
    [InlineData(PayoutUnmaskResponseResponseType.Error1)]
    [InlineData(PayoutUnmaskResponseResponseType.None1)]
    public void SerializationRoundtrip_Works(PayoutUnmaskResponseResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PayoutUnmaskResponseResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PayoutUnmaskResponseResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, PayoutUnmaskResponseResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}
