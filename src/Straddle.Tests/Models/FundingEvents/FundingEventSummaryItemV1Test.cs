using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.FundingEvents;
using Models = Straddle.Models;

namespace Straddle.Tests.Models.FundingEvents;

public class FundingEventSummaryItemV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new FundingEventSummaryItemV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 100000,
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Direction = DataDirection.Deposit,
                EventType = DataEventType.ChargeDeposit,
                PaymentCount = 0,
                TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                TraceNumbers = ["string"],
                TransferDate = "2019-12-27",
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Status = DataStatus.Created,
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Code = "code",
                },
                TraceNumber = "trace_number",
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
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = DataDirection.Deposit,
            EventType = DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = Source.Watchtower,
                Code = "code",
            },
            TraceNumber = "trace_number",
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
        var model = new FundingEventSummaryItemV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 100000,
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Direction = DataDirection.Deposit,
                EventType = DataEventType.ChargeDeposit,
                PaymentCount = 0,
                TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                TraceNumbers = ["string"],
                TransferDate = "2019-12-27",
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Status = DataStatus.Created,
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Code = "code",
                },
                TraceNumber = "trace_number",
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<FundingEventSummaryItemV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new FundingEventSummaryItemV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 100000,
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Direction = DataDirection.Deposit,
                EventType = DataEventType.ChargeDeposit,
                PaymentCount = 0,
                TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                TraceNumbers = ["string"],
                TransferDate = "2019-12-27",
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Status = DataStatus.Created,
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Code = "code",
                },
                TraceNumber = "trace_number",
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<FundingEventSummaryItemV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = DataDirection.Deposit,
            EventType = DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = Source.Watchtower,
                Code = "code",
            },
            TraceNumber = "trace_number",
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
        var model = new FundingEventSummaryItemV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 100000,
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Direction = DataDirection.Deposit,
                EventType = DataEventType.ChargeDeposit,
                PaymentCount = 0,
                TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                TraceNumbers = ["string"],
                TransferDate = "2019-12-27",
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Status = DataStatus.Created,
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Code = "code",
                },
                TraceNumber = "trace_number",
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

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new FundingEventSummaryItemV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 100000,
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Direction = DataDirection.Deposit,
                EventType = DataEventType.ChargeDeposit,
                PaymentCount = 0,
                TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                TraceNumbers = ["string"],
                TransferDate = "2019-12-27",
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Status = DataStatus.Created,
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = Reason.InsufficientFunds,
                    Source = Source.Watchtower,
                    Code = "code",
                },
                TraceNumber = "trace_number",
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ResponseType.Object,
        };

        FundingEventSummaryItemV1 copied = new(model);

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
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = DataDirection.Deposit,
            EventType = DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = Source.Watchtower,
                Code = "code",
            },
            TraceNumber = "trace_number",
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedAmount = 100000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        ApiEnum<string, DataDirection> expectedDirection = DataDirection.Deposit;
        ApiEnum<string, DataEventType> expectedEventType = DataEventType.ChargeDeposit;
        int expectedPaymentCount = 0;
        Dictionary<string, string> expectedTraceIds = new() { { "foo", "string" } };
        List<string> expectedTraceNumbers = ["string"];
        string expectedTransferDate = "2019-12-27";
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        ApiEnum<string, DataStatus> expectedStatus = DataStatus.Created;
        StatusDetails expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = Source.Watchtower,
            Code = "code",
        };
        string expectedTraceNumber = "trace_number";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAmount, model.Amount);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedDirection, model.Direction);
        Assert.Equal(expectedEventType, model.EventType);
        Assert.Equal(expectedPaymentCount, model.PaymentCount);
        Assert.Equal(expectedTraceIds.Count, model.TraceIds.Count);
        foreach (var item in expectedTraceIds)
        {
            Assert.True(model.TraceIds.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.TraceIds[item.Key]);
        }
        Assert.Equal(expectedTraceNumbers.Count, model.TraceNumbers.Count);
        for (int i = 0; i < expectedTraceNumbers.Count; i++)
        {
            Assert.Equal(expectedTraceNumbers[i], model.TraceNumbers[i]);
        }
        Assert.Equal(expectedTransferDate, model.TransferDate);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedStatusDetails, model.StatusDetails);
        Assert.Equal(expectedTraceNumber, model.TraceNumber);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = DataDirection.Deposit,
            EventType = DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = Source.Watchtower,
                Code = "code",
            },
            TraceNumber = "trace_number",
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
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = DataDirection.Deposit,
            EventType = DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = Source.Watchtower,
                Code = "code",
            },
            TraceNumber = "trace_number",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedAmount = 100000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        ApiEnum<string, DataDirection> expectedDirection = DataDirection.Deposit;
        ApiEnum<string, DataEventType> expectedEventType = DataEventType.ChargeDeposit;
        int expectedPaymentCount = 0;
        Dictionary<string, string> expectedTraceIds = new() { { "foo", "string" } };
        List<string> expectedTraceNumbers = ["string"];
        string expectedTransferDate = "2019-12-27";
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        ApiEnum<string, DataStatus> expectedStatus = DataStatus.Created;
        StatusDetails expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = Source.Watchtower,
            Code = "code",
        };
        string expectedTraceNumber = "trace_number";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAmount, deserialized.Amount);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedDirection, deserialized.Direction);
        Assert.Equal(expectedEventType, deserialized.EventType);
        Assert.Equal(expectedPaymentCount, deserialized.PaymentCount);
        Assert.Equal(expectedTraceIds.Count, deserialized.TraceIds.Count);
        foreach (var item in expectedTraceIds)
        {
            Assert.True(deserialized.TraceIds.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.TraceIds[item.Key]);
        }
        Assert.Equal(expectedTraceNumbers.Count, deserialized.TraceNumbers.Count);
        for (int i = 0; i < expectedTraceNumbers.Count; i++)
        {
            Assert.Equal(expectedTraceNumbers[i], deserialized.TraceNumbers[i]);
        }
        Assert.Equal(expectedTransferDate, deserialized.TransferDate);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedStatusDetails, deserialized.StatusDetails);
        Assert.Equal(expectedTraceNumber, deserialized.TraceNumber);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = DataDirection.Deposit,
            EventType = DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = Source.Watchtower,
                Code = "code",
            },
            TraceNumber = "trace_number",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = DataDirection.Deposit,
            EventType = DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            TraceNumber = "trace_number",
        };

        Assert.Null(model.Status);
        Assert.False(model.RawData.ContainsKey("status"));
        Assert.Null(model.StatusDetails);
        Assert.False(model.RawData.ContainsKey("status_details"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = DataDirection.Deposit,
            EventType = DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            TraceNumber = "trace_number",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = DataDirection.Deposit,
            EventType = DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            TraceNumber = "trace_number",

            // Null should be interpreted as omitted for these properties
            Status = null,
            StatusDetails = null,
        };

        Assert.Null(model.Status);
        Assert.False(model.RawData.ContainsKey("status"));
        Assert.Null(model.StatusDetails);
        Assert.False(model.RawData.ContainsKey("status_details"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = DataDirection.Deposit,
            EventType = DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            TraceNumber = "trace_number",

            // Null should be interpreted as omitted for these properties
            Status = null,
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
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = DataDirection.Deposit,
            EventType = DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = Source.Watchtower,
                Code = "code",
            },
        };

        Assert.Null(model.TraceNumber);
        Assert.False(model.RawData.ContainsKey("trace_number"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = DataDirection.Deposit,
            EventType = DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = Source.Watchtower,
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
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = DataDirection.Deposit,
            EventType = DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = Source.Watchtower,
                Code = "code",
            },

            TraceNumber = null,
        };

        Assert.Null(model.TraceNumber);
        Assert.True(model.RawData.ContainsKey("trace_number"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = DataDirection.Deposit,
            EventType = DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = Source.Watchtower,
                Code = "code",
            },

            TraceNumber = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = DataDirection.Deposit,
            EventType = DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = Source.Watchtower,
                Code = "code",
            },
            TraceNumber = "trace_number",
        };

        Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DataDirectionTest : TestBase
{
    [Theory]
    [InlineData(DataDirection.Deposit)]
    [InlineData(DataDirection.Withdrawal)]
    public void Validation_Works(DataDirection rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataDirection> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataDirection>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(DataDirection.Deposit)]
    [InlineData(DataDirection.Withdrawal)]
    public void SerializationRoundtrip_Works(DataDirection rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataDirection> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataDirection>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataDirection>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataDirection>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class DataEventTypeTest : TestBase
{
    [Theory]
    [InlineData(DataEventType.ChargeDeposit)]
    [InlineData(DataEventType.ChargeReversal)]
    [InlineData(DataEventType.PayoutReturn)]
    [InlineData(DataEventType.PayoutWithdrawal)]
    public void Validation_Works(DataEventType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataEventType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataEventType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(DataEventType.ChargeDeposit)]
    [InlineData(DataEventType.ChargeReversal)]
    [InlineData(DataEventType.PayoutReturn)]
    [InlineData(DataEventType.PayoutWithdrawal)]
    public void SerializationRoundtrip_Works(DataEventType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataEventType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataEventType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataEventType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataEventType>>(
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
    [InlineData(DataStatus.Scheduled)]
    [InlineData(DataStatus.Failed)]
    [InlineData(DataStatus.Cancelled)]
    [InlineData(DataStatus.OnHold)]
    [InlineData(DataStatus.Pending)]
    [InlineData(DataStatus.Paid)]
    [InlineData(DataStatus.Reversed)]
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
    [InlineData(DataStatus.Scheduled)]
    [InlineData(DataStatus.Failed)]
    [InlineData(DataStatus.Cancelled)]
    [InlineData(DataStatus.OnHold)]
    [InlineData(DataStatus.Pending)]
    [InlineData(DataStatus.Paid)]
    [InlineData(DataStatus.Reversed)]
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
            Source = Source.Watchtower,
            Code = "code",
        };

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Bank account sucesfully validated";
        ApiEnum<string, Reason> expectedReason = Reason.InsufficientFunds;
        ApiEnum<string, Source> expectedSource = Source.Watchtower;
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
            Source = Source.Watchtower,
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
            Source = Source.Watchtower,
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
        ApiEnum<string, Source> expectedSource = Source.Watchtower;
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
            Source = Source.Watchtower,
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
            Source = Source.Watchtower,
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
            Source = Source.Watchtower,
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
            Source = Source.Watchtower,

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
            Source = Source.Watchtower,

            Code = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = Source.Watchtower,
            Code = "code",
        };

        StatusDetails copied = new(model);

        Assert.Equal(model, copied);
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
