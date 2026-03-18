using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.FundingEvents;

namespace Straddle.Tests.Models.FundingEvents;

public class FundingEventSummaryPagedV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new FundingEventSummaryPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Amount = 100000,
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
                    EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
                    PaymentCount = 0,
                    TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                    TraceNumbers = ["string"],
                    TransferDate = "2019-12-27",
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Status = FundingEventSummaryPagedV1DataStatus.Created,
                    StatusDetails = new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Bank account sucesfully validated",
                        Reason =
                            FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
                        Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
                        Code = "code",
                    },
                    TraceNumber = "trace_number",
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
                SortOrder = MetaSortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = FundingEventSummaryPagedV1ResponseType.Object,
        };

        List<FundingEventSummaryPagedV1Data> expectedData =
        [
            new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 100000,
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
                EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
                PaymentCount = 0,
                TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                TraceNumbers = ["string"],
                TransferDate = "2019-12-27",
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Status = FundingEventSummaryPagedV1DataStatus.Created,
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
                    Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
                TraceNumber = "trace_number",
            },
        ];
        Meta expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = MetaSortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };
        ApiEnum<string, FundingEventSummaryPagedV1ResponseType> expectedResponseType =
            FundingEventSummaryPagedV1ResponseType.Object;

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
        var model = new FundingEventSummaryPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Amount = 100000,
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
                    EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
                    PaymentCount = 0,
                    TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                    TraceNumbers = ["string"],
                    TransferDate = "2019-12-27",
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Status = FundingEventSummaryPagedV1DataStatus.Created,
                    StatusDetails = new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Bank account sucesfully validated",
                        Reason =
                            FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
                        Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
                        Code = "code",
                    },
                    TraceNumber = "trace_number",
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
                SortOrder = MetaSortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = FundingEventSummaryPagedV1ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<FundingEventSummaryPagedV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new FundingEventSummaryPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Amount = 100000,
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
                    EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
                    PaymentCount = 0,
                    TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                    TraceNumbers = ["string"],
                    TransferDate = "2019-12-27",
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Status = FundingEventSummaryPagedV1DataStatus.Created,
                    StatusDetails = new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Bank account sucesfully validated",
                        Reason =
                            FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
                        Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
                        Code = "code",
                    },
                    TraceNumber = "trace_number",
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
                SortOrder = MetaSortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = FundingEventSummaryPagedV1ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<FundingEventSummaryPagedV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<FundingEventSummaryPagedV1Data> expectedData =
        [
            new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 100000,
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
                EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
                PaymentCount = 0,
                TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                TraceNumbers = ["string"],
                TransferDate = "2019-12-27",
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Status = FundingEventSummaryPagedV1DataStatus.Created,
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
                    Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
                    Code = "code",
                },
                TraceNumber = "trace_number",
            },
        ];
        Meta expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = MetaSortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };
        ApiEnum<string, FundingEventSummaryPagedV1ResponseType> expectedResponseType =
            FundingEventSummaryPagedV1ResponseType.Object;

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
        var model = new FundingEventSummaryPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Amount = 100000,
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
                    EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
                    PaymentCount = 0,
                    TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                    TraceNumbers = ["string"],
                    TransferDate = "2019-12-27",
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Status = FundingEventSummaryPagedV1DataStatus.Created,
                    StatusDetails = new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Bank account sucesfully validated",
                        Reason =
                            FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
                        Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
                        Code = "code",
                    },
                    TraceNumber = "trace_number",
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
                SortOrder = MetaSortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = FundingEventSummaryPagedV1ResponseType.Object,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new FundingEventSummaryPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Amount = 100000,
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
                    EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
                    PaymentCount = 0,
                    TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                    TraceNumbers = ["string"],
                    TransferDate = "2019-12-27",
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Status = FundingEventSummaryPagedV1DataStatus.Created,
                    StatusDetails = new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Bank account sucesfully validated",
                        Reason =
                            FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
                        Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
                        Code = "code",
                    },
                    TraceNumber = "trace_number",
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
                SortOrder = MetaSortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = FundingEventSummaryPagedV1ResponseType.Object,
        };

        FundingEventSummaryPagedV1 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class FundingEventSummaryPagedV1DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new FundingEventSummaryPagedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
            EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = FundingEventSummaryPagedV1DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
                Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
            TraceNumber = "trace_number",
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedAmount = 100000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        ApiEnum<string, FundingEventSummaryPagedV1DataDirection> expectedDirection =
            FundingEventSummaryPagedV1DataDirection.Deposit;
        ApiEnum<string, FundingEventSummaryPagedV1DataEventType> expectedEventType =
            FundingEventSummaryPagedV1DataEventType.ChargeDeposit;
        int expectedPaymentCount = 0;
        Dictionary<string, string> expectedTraceIds = new() { { "foo", "string" } };
        List<string> expectedTraceNumbers = ["string"];
        string expectedTransferDate = "2019-12-27";
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        ApiEnum<string, FundingEventSummaryPagedV1DataStatus> expectedStatus =
            FundingEventSummaryPagedV1DataStatus.Created;
        FundingEventSummaryPagedV1DataStatusDetails expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
            Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
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
        var model = new FundingEventSummaryPagedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
            EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = FundingEventSummaryPagedV1DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
                Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
            TraceNumber = "trace_number",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<FundingEventSummaryPagedV1Data>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new FundingEventSummaryPagedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
            EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = FundingEventSummaryPagedV1DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
                Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
            TraceNumber = "trace_number",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<FundingEventSummaryPagedV1Data>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedAmount = 100000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        ApiEnum<string, FundingEventSummaryPagedV1DataDirection> expectedDirection =
            FundingEventSummaryPagedV1DataDirection.Deposit;
        ApiEnum<string, FundingEventSummaryPagedV1DataEventType> expectedEventType =
            FundingEventSummaryPagedV1DataEventType.ChargeDeposit;
        int expectedPaymentCount = 0;
        Dictionary<string, string> expectedTraceIds = new() { { "foo", "string" } };
        List<string> expectedTraceNumbers = ["string"];
        string expectedTransferDate = "2019-12-27";
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        ApiEnum<string, FundingEventSummaryPagedV1DataStatus> expectedStatus =
            FundingEventSummaryPagedV1DataStatus.Created;
        FundingEventSummaryPagedV1DataStatusDetails expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
            Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
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
        var model = new FundingEventSummaryPagedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
            EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = FundingEventSummaryPagedV1DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
                Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
            TraceNumber = "trace_number",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new FundingEventSummaryPagedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
            EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
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
        var model = new FundingEventSummaryPagedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
            EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
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
        var model = new FundingEventSummaryPagedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
            EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
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
        var model = new FundingEventSummaryPagedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
            EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
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
        var model = new FundingEventSummaryPagedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
            EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = FundingEventSummaryPagedV1DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
                Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        Assert.Null(model.TraceNumber);
        Assert.False(model.RawData.ContainsKey("trace_number"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new FundingEventSummaryPagedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
            EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = FundingEventSummaryPagedV1DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
                Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new FundingEventSummaryPagedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
            EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = FundingEventSummaryPagedV1DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
                Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
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
        var model = new FundingEventSummaryPagedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
            EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = FundingEventSummaryPagedV1DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
                Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },

            TraceNumber = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new FundingEventSummaryPagedV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 100000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Direction = FundingEventSummaryPagedV1DataDirection.Deposit,
            EventType = FundingEventSummaryPagedV1DataEventType.ChargeDeposit,
            PaymentCount = 0,
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            TraceNumbers = ["string"],
            TransferDate = "2019-12-27",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Status = FundingEventSummaryPagedV1DataStatus.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
                Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
                Code = "code",
            },
            TraceNumber = "trace_number",
        };

        FundingEventSummaryPagedV1Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class FundingEventSummaryPagedV1DataDirectionTest : TestBase
{
    [Theory]
    [InlineData(FundingEventSummaryPagedV1DataDirection.Deposit)]
    [InlineData(FundingEventSummaryPagedV1DataDirection.Withdrawal)]
    public void Validation_Works(FundingEventSummaryPagedV1DataDirection rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FundingEventSummaryPagedV1DataDirection> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataDirection>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(FundingEventSummaryPagedV1DataDirection.Deposit)]
    [InlineData(FundingEventSummaryPagedV1DataDirection.Withdrawal)]
    public void SerializationRoundtrip_Works(FundingEventSummaryPagedV1DataDirection rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FundingEventSummaryPagedV1DataDirection> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataDirection>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataDirection>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataDirection>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class FundingEventSummaryPagedV1DataEventTypeTest : TestBase
{
    [Theory]
    [InlineData(FundingEventSummaryPagedV1DataEventType.ChargeDeposit)]
    [InlineData(FundingEventSummaryPagedV1DataEventType.ChargeReversal)]
    [InlineData(FundingEventSummaryPagedV1DataEventType.PayoutReturn)]
    [InlineData(FundingEventSummaryPagedV1DataEventType.PayoutWithdrawal)]
    public void Validation_Works(FundingEventSummaryPagedV1DataEventType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FundingEventSummaryPagedV1DataEventType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataEventType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(FundingEventSummaryPagedV1DataEventType.ChargeDeposit)]
    [InlineData(FundingEventSummaryPagedV1DataEventType.ChargeReversal)]
    [InlineData(FundingEventSummaryPagedV1DataEventType.PayoutReturn)]
    [InlineData(FundingEventSummaryPagedV1DataEventType.PayoutWithdrawal)]
    public void SerializationRoundtrip_Works(FundingEventSummaryPagedV1DataEventType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FundingEventSummaryPagedV1DataEventType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataEventType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataEventType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataEventType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class FundingEventSummaryPagedV1DataStatusTest : TestBase
{
    [Theory]
    [InlineData(FundingEventSummaryPagedV1DataStatus.Created)]
    [InlineData(FundingEventSummaryPagedV1DataStatus.Scheduled)]
    [InlineData(FundingEventSummaryPagedV1DataStatus.Failed)]
    [InlineData(FundingEventSummaryPagedV1DataStatus.Cancelled)]
    [InlineData(FundingEventSummaryPagedV1DataStatus.OnHold)]
    [InlineData(FundingEventSummaryPagedV1DataStatus.Pending)]
    [InlineData(FundingEventSummaryPagedV1DataStatus.Paid)]
    [InlineData(FundingEventSummaryPagedV1DataStatus.Reversed)]
    public void Validation_Works(FundingEventSummaryPagedV1DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FundingEventSummaryPagedV1DataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(FundingEventSummaryPagedV1DataStatus.Created)]
    [InlineData(FundingEventSummaryPagedV1DataStatus.Scheduled)]
    [InlineData(FundingEventSummaryPagedV1DataStatus.Failed)]
    [InlineData(FundingEventSummaryPagedV1DataStatus.Cancelled)]
    [InlineData(FundingEventSummaryPagedV1DataStatus.OnHold)]
    [InlineData(FundingEventSummaryPagedV1DataStatus.Pending)]
    [InlineData(FundingEventSummaryPagedV1DataStatus.Paid)]
    [InlineData(FundingEventSummaryPagedV1DataStatus.Reversed)]
    public void SerializationRoundtrip_Works(FundingEventSummaryPagedV1DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FundingEventSummaryPagedV1DataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class FundingEventSummaryPagedV1DataStatusDetailsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new FundingEventSummaryPagedV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
            Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Bank account sucesfully validated";
        ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsReason> expectedReason =
            FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds;
        ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsSource> expectedSource =
            FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower;
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
        var model = new FundingEventSummaryPagedV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
            Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<FundingEventSummaryPagedV1DataStatusDetails>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new FundingEventSummaryPagedV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
            Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<FundingEventSummaryPagedV1DataStatusDetails>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Bank account sucesfully validated";
        ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsReason> expectedReason =
            FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds;
        ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsSource> expectedSource =
            FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower;
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
        var model = new FundingEventSummaryPagedV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
            Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new FundingEventSummaryPagedV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
            Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
        };

        Assert.Null(model.Code);
        Assert.False(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new FundingEventSummaryPagedV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
            Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new FundingEventSummaryPagedV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
            Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,

            Code = null,
        };

        Assert.Null(model.Code);
        Assert.True(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new FundingEventSummaryPagedV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
            Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,

            Code = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new FundingEventSummaryPagedV1DataStatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds,
            Source = FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower,
            Code = "code",
        };

        FundingEventSummaryPagedV1DataStatusDetails copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class FundingEventSummaryPagedV1DataStatusDetailsReasonTest : TestBase
{
    [Theory]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.ClosedBankAccount)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.InvalidBankAccount)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.InvalidRouting)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.Disputed)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.PaymentStopped)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.OwnerDeceased)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.FrozenBankAccount)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.RiskReview)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.Fraudulent)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.DuplicateEntry)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.InvalidPaykey)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.PaymentBlocked)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.AmountTooLarge)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.TooManyAttempts)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.InternalSystemError)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.UserRequest)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.Ok)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.OtherNetworkReturn)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.PayoutRefused)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.CancelRequest)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.FailedVerification)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.RequireReview)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.BlockedBySystem)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.WatchtowerReview)]
    public void Validation_Works(FundingEventSummaryPagedV1DataStatusDetailsReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsReason> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.InsufficientFunds)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.ClosedBankAccount)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.InvalidBankAccount)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.InvalidRouting)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.Disputed)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.PaymentStopped)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.OwnerDeceased)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.FrozenBankAccount)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.RiskReview)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.Fraudulent)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.DuplicateEntry)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.InvalidPaykey)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.PaymentBlocked)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.AmountTooLarge)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.TooManyAttempts)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.InternalSystemError)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.UserRequest)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.Ok)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.OtherNetworkReturn)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.PayoutRefused)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.CancelRequest)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.FailedVerification)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.RequireReview)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.BlockedBySystem)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsReason.WatchtowerReview)]
    public void SerializationRoundtrip_Works(
        FundingEventSummaryPagedV1DataStatusDetailsReason rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsReason> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class FundingEventSummaryPagedV1DataStatusDetailsSourceTest : TestBase
{
    [Theory]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsSource.BankDecline)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsSource.CustomerDispute)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsSource.UserAction)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsSource.System)]
    public void Validation_Works(FundingEventSummaryPagedV1DataStatusDetailsSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsSource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsSource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsSource.Watchtower)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsSource.BankDecline)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsSource.CustomerDispute)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsSource.UserAction)]
    [InlineData(FundingEventSummaryPagedV1DataStatusDetailsSource.System)]
    public void SerializationRoundtrip_Works(
        FundingEventSummaryPagedV1DataStatusDetailsSource rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsSource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsSource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1DataStatusDetailsSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class MetaTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Meta
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = MetaSortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };

        string expectedApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedApiRequestTimestamp = DateTimeOffset.Parse(
            "2019-12-27T18:11:19.117Z"
        );
        int expectedMaxPageSize = 0;
        int expectedPageNumber = 0;
        int expectedPageSize = 0;
        string expectedSortBy = "sort_by";
        ApiEnum<string, MetaSortOrder> expectedSortOrder = MetaSortOrder.Asc;
        int expectedTotalItems = 0;
        int expectedTotalPages = 0;

        Assert.Equal(expectedApiRequestID, model.ApiRequestID);
        Assert.Equal(expectedApiRequestTimestamp, model.ApiRequestTimestamp);
        Assert.Equal(expectedMaxPageSize, model.MaxPageSize);
        Assert.Equal(expectedPageNumber, model.PageNumber);
        Assert.Equal(expectedPageSize, model.PageSize);
        Assert.Equal(expectedSortBy, model.SortBy);
        Assert.Equal(expectedSortOrder, model.SortOrder);
        Assert.Equal(expectedTotalItems, model.TotalItems);
        Assert.Equal(expectedTotalPages, model.TotalPages);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Meta
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = MetaSortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Meta>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Meta
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = MetaSortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Meta>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedApiRequestTimestamp = DateTimeOffset.Parse(
            "2019-12-27T18:11:19.117Z"
        );
        int expectedMaxPageSize = 0;
        int expectedPageNumber = 0;
        int expectedPageSize = 0;
        string expectedSortBy = "sort_by";
        ApiEnum<string, MetaSortOrder> expectedSortOrder = MetaSortOrder.Asc;
        int expectedTotalItems = 0;
        int expectedTotalPages = 0;

        Assert.Equal(expectedApiRequestID, deserialized.ApiRequestID);
        Assert.Equal(expectedApiRequestTimestamp, deserialized.ApiRequestTimestamp);
        Assert.Equal(expectedMaxPageSize, deserialized.MaxPageSize);
        Assert.Equal(expectedPageNumber, deserialized.PageNumber);
        Assert.Equal(expectedPageSize, deserialized.PageSize);
        Assert.Equal(expectedSortBy, deserialized.SortBy);
        Assert.Equal(expectedSortOrder, deserialized.SortOrder);
        Assert.Equal(expectedTotalItems, deserialized.TotalItems);
        Assert.Equal(expectedTotalPages, deserialized.TotalPages);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Meta
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = MetaSortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Meta
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = MetaSortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };

        Meta copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class MetaSortOrderTest : TestBase
{
    [Theory]
    [InlineData(MetaSortOrder.Asc)]
    [InlineData(MetaSortOrder.Desc)]
    public void Validation_Works(MetaSortOrder rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, MetaSortOrder> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, MetaSortOrder>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(MetaSortOrder.Asc)]
    [InlineData(MetaSortOrder.Desc)]
    public void SerializationRoundtrip_Works(MetaSortOrder rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, MetaSortOrder> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, MetaSortOrder>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, MetaSortOrder>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, MetaSortOrder>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class FundingEventSummaryPagedV1ResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(FundingEventSummaryPagedV1ResponseType.Object)]
    [InlineData(FundingEventSummaryPagedV1ResponseType.Array)]
    [InlineData(FundingEventSummaryPagedV1ResponseType.Error)]
    [InlineData(FundingEventSummaryPagedV1ResponseType.None)]
    public void Validation_Works(FundingEventSummaryPagedV1ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FundingEventSummaryPagedV1ResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1ResponseType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(FundingEventSummaryPagedV1ResponseType.Object)]
    [InlineData(FundingEventSummaryPagedV1ResponseType.Array)]
    [InlineData(FundingEventSummaryPagedV1ResponseType.Error)]
    [InlineData(FundingEventSummaryPagedV1ResponseType.None)]
    public void SerializationRoundtrip_Works(FundingEventSummaryPagedV1ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FundingEventSummaryPagedV1ResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1ResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1ResponseType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, FundingEventSummaryPagedV1ResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}
