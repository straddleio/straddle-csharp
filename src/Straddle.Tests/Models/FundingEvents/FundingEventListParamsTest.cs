using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.FundingEvents;

namespace Straddle.Tests.Models.FundingEvents;

public class FundingEventListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new FundingEventListParams
        {
            CreatedFrom = "2019-12-27",
            CreatedTo = "2019-12-27",
            Direction = Direction.Deposit,
            EventType = EventType.ChargeDeposit,
            PageNumber = 0,
            PageSize = 0,
            SearchText = "search_text",
            SortBy = SortBy.TransferDate,
            SortOrder = SortOrder.Asc,
            Status = [Status.Created],
            StatusReason = [StatusReason.InsufficientFunds],
            StatusSource = [StatusSource.Watchtower],
            TraceID = "trace_id",
            TraceNumber = "trace_number",
            CorrelationID = "Correlation-Id",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        string expectedCreatedFrom = "2019-12-27";
        string expectedCreatedTo = "2019-12-27";
        ApiEnum<string, Direction> expectedDirection = Direction.Deposit;
        ApiEnum<string, EventType> expectedEventType = EventType.ChargeDeposit;
        int expectedPageNumber = 0;
        int expectedPageSize = 0;
        string expectedSearchText = "search_text";
        ApiEnum<string, SortBy> expectedSortBy = SortBy.TransferDate;
        ApiEnum<string, SortOrder> expectedSortOrder = SortOrder.Asc;
        List<ApiEnum<string, Status>> expectedStatus = [Status.Created];
        List<ApiEnum<string, StatusReason>> expectedStatusReason = [StatusReason.InsufficientFunds];
        List<ApiEnum<string, StatusSource>> expectedStatusSource = [StatusSource.Watchtower];
        string expectedTraceID = "trace_id";
        string expectedTraceNumber = "trace_number";
        string expectedCorrelationID = "Correlation-Id";
        string expectedRequestID = "Request-Id";
        string expectedStraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";

        Assert.Equal(expectedCreatedFrom, parameters.CreatedFrom);
        Assert.Equal(expectedCreatedTo, parameters.CreatedTo);
        Assert.Equal(expectedDirection, parameters.Direction);
        Assert.Equal(expectedEventType, parameters.EventType);
        Assert.Equal(expectedPageNumber, parameters.PageNumber);
        Assert.Equal(expectedPageSize, parameters.PageSize);
        Assert.Equal(expectedSearchText, parameters.SearchText);
        Assert.Equal(expectedSortBy, parameters.SortBy);
        Assert.Equal(expectedSortOrder, parameters.SortOrder);
        Assert.NotNull(parameters.Status);
        Assert.Equal(expectedStatus.Count, parameters.Status.Count);
        for (int i = 0; i < expectedStatus.Count; i++)
        {
            Assert.Equal(expectedStatus[i], parameters.Status[i]);
        }
        Assert.NotNull(parameters.StatusReason);
        Assert.Equal(expectedStatusReason.Count, parameters.StatusReason.Count);
        for (int i = 0; i < expectedStatusReason.Count; i++)
        {
            Assert.Equal(expectedStatusReason[i], parameters.StatusReason[i]);
        }
        Assert.NotNull(parameters.StatusSource);
        Assert.Equal(expectedStatusSource.Count, parameters.StatusSource.Count);
        for (int i = 0; i < expectedStatusSource.Count; i++)
        {
            Assert.Equal(expectedStatusSource[i], parameters.StatusSource[i]);
        }
        Assert.Equal(expectedTraceID, parameters.TraceID);
        Assert.Equal(expectedTraceNumber, parameters.TraceNumber);
        Assert.Equal(expectedCorrelationID, parameters.CorrelationID);
        Assert.Equal(expectedRequestID, parameters.RequestID);
        Assert.Equal(expectedStraddleAccountID, parameters.StraddleAccountID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new FundingEventListParams
        {
            CreatedFrom = "2019-12-27",
            CreatedTo = "2019-12-27",
            SearchText = "search_text",
            Status = [Status.Created],
            StatusReason = [StatusReason.InsufficientFunds],
            StatusSource = [StatusSource.Watchtower],
            TraceID = "trace_id",
            TraceNumber = "trace_number",
        };

        Assert.Null(parameters.Direction);
        Assert.False(parameters.RawQueryData.ContainsKey("direction"));
        Assert.Null(parameters.EventType);
        Assert.False(parameters.RawQueryData.ContainsKey("event_type"));
        Assert.Null(parameters.PageNumber);
        Assert.False(parameters.RawQueryData.ContainsKey("page_number"));
        Assert.Null(parameters.PageSize);
        Assert.False(parameters.RawQueryData.ContainsKey("page_size"));
        Assert.Null(parameters.SortBy);
        Assert.False(parameters.RawQueryData.ContainsKey("sort_by"));
        Assert.Null(parameters.SortOrder);
        Assert.False(parameters.RawQueryData.ContainsKey("sort_order"));
        Assert.Null(parameters.CorrelationID);
        Assert.False(parameters.RawHeaderData.ContainsKey("Correlation-Id"));
        Assert.Null(parameters.RequestID);
        Assert.False(parameters.RawHeaderData.ContainsKey("Request-Id"));
        Assert.Null(parameters.StraddleAccountID);
        Assert.False(parameters.RawHeaderData.ContainsKey("Straddle-Account-Id"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new FundingEventListParams
        {
            CreatedFrom = "2019-12-27",
            CreatedTo = "2019-12-27",
            SearchText = "search_text",
            Status = [Status.Created],
            StatusReason = [StatusReason.InsufficientFunds],
            StatusSource = [StatusSource.Watchtower],
            TraceID = "trace_id",
            TraceNumber = "trace_number",

            // Null should be interpreted as omitted for these properties
            Direction = null,
            EventType = null,
            PageNumber = null,
            PageSize = null,
            SortBy = null,
            SortOrder = null,
            CorrelationID = null,
            RequestID = null,
            StraddleAccountID = null,
        };

        Assert.Null(parameters.Direction);
        Assert.False(parameters.RawQueryData.ContainsKey("direction"));
        Assert.Null(parameters.EventType);
        Assert.False(parameters.RawQueryData.ContainsKey("event_type"));
        Assert.Null(parameters.PageNumber);
        Assert.False(parameters.RawQueryData.ContainsKey("page_number"));
        Assert.Null(parameters.PageSize);
        Assert.False(parameters.RawQueryData.ContainsKey("page_size"));
        Assert.Null(parameters.SortBy);
        Assert.False(parameters.RawQueryData.ContainsKey("sort_by"));
        Assert.Null(parameters.SortOrder);
        Assert.False(parameters.RawQueryData.ContainsKey("sort_order"));
        Assert.Null(parameters.CorrelationID);
        Assert.False(parameters.RawHeaderData.ContainsKey("Correlation-Id"));
        Assert.Null(parameters.RequestID);
        Assert.False(parameters.RawHeaderData.ContainsKey("Request-Id"));
        Assert.Null(parameters.StraddleAccountID);
        Assert.False(parameters.RawHeaderData.ContainsKey("Straddle-Account-Id"));
    }

    [Fact]
    public void OptionalNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new FundingEventListParams
        {
            Direction = Direction.Deposit,
            EventType = EventType.ChargeDeposit,
            PageNumber = 0,
            PageSize = 0,
            SortBy = SortBy.TransferDate,
            SortOrder = SortOrder.Asc,
            CorrelationID = "Correlation-Id",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        Assert.Null(parameters.CreatedFrom);
        Assert.False(parameters.RawQueryData.ContainsKey("created_from"));
        Assert.Null(parameters.CreatedTo);
        Assert.False(parameters.RawQueryData.ContainsKey("created_to"));
        Assert.Null(parameters.SearchText);
        Assert.False(parameters.RawQueryData.ContainsKey("search_text"));
        Assert.Null(parameters.Status);
        Assert.False(parameters.RawQueryData.ContainsKey("status"));
        Assert.Null(parameters.StatusReason);
        Assert.False(parameters.RawQueryData.ContainsKey("status_reason"));
        Assert.Null(parameters.StatusSource);
        Assert.False(parameters.RawQueryData.ContainsKey("status_source"));
        Assert.Null(parameters.TraceID);
        Assert.False(parameters.RawQueryData.ContainsKey("trace_id"));
        Assert.Null(parameters.TraceNumber);
        Assert.False(parameters.RawQueryData.ContainsKey("trace_number"));
    }

    [Fact]
    public void OptionalNullableParamsSetToNullAreSetToNull_Works()
    {
        var parameters = new FundingEventListParams
        {
            Direction = Direction.Deposit,
            EventType = EventType.ChargeDeposit,
            PageNumber = 0,
            PageSize = 0,
            SortBy = SortBy.TransferDate,
            SortOrder = SortOrder.Asc,
            CorrelationID = "Correlation-Id",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",

            CreatedFrom = null,
            CreatedTo = null,
            SearchText = null,
            Status = null,
            StatusReason = null,
            StatusSource = null,
            TraceID = null,
            TraceNumber = null,
        };

        Assert.Null(parameters.CreatedFrom);
        Assert.True(parameters.RawQueryData.ContainsKey("created_from"));
        Assert.Null(parameters.CreatedTo);
        Assert.True(parameters.RawQueryData.ContainsKey("created_to"));
        Assert.Null(parameters.SearchText);
        Assert.True(parameters.RawQueryData.ContainsKey("search_text"));
        Assert.Null(parameters.Status);
        Assert.True(parameters.RawQueryData.ContainsKey("status"));
        Assert.Null(parameters.StatusReason);
        Assert.True(parameters.RawQueryData.ContainsKey("status_reason"));
        Assert.Null(parameters.StatusSource);
        Assert.True(parameters.RawQueryData.ContainsKey("status_source"));
        Assert.Null(parameters.TraceID);
        Assert.True(parameters.RawQueryData.ContainsKey("trace_id"));
        Assert.Null(parameters.TraceNumber);
        Assert.True(parameters.RawQueryData.ContainsKey("trace_number"));
    }

    [Fact]
    public void Url_Works()
    {
        FundingEventListParams parameters = new()
        {
            CreatedFrom = "2019-12-27",
            CreatedTo = "2019-12-27",
            Direction = Direction.Deposit,
            EventType = EventType.ChargeDeposit,
            PageNumber = 0,
            PageSize = 0,
            SearchText = "search_text",
            SortBy = SortBy.TransferDate,
            SortOrder = SortOrder.Asc,
            Status = [Status.Created],
            StatusReason = [StatusReason.InsufficientFunds],
            StatusSource = [StatusSource.Watchtower],
            TraceID = "trace_id",
            TraceNumber = "trace_number",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://sandbox.straddle.com/v1/funding_events?created_from=2019-12-27&created_to=2019-12-27&direction=deposit&event_type=charge_deposit&page_number=0&page_size=0&search_text=search_text&sort_by=transfer_date&sort_order=asc&status=created&status_reason=insufficient_funds&status_source=watchtower&trace_id=trace_id&trace_number=trace_number"
            ),
            url
        );
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        FundingEventListParams parameters = new()
        {
            CorrelationID = "Correlation-Id",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        parameters.AddHeadersToRequest(requestMessage, new() { ApiKey = "My API Key" });

        Assert.Equal(["Correlation-Id"], requestMessage.Headers.GetValues("Correlation-Id"));
        Assert.Equal(["Request-Id"], requestMessage.Headers.GetValues("Request-Id"));
        Assert.Equal(
            ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            requestMessage.Headers.GetValues("Straddle-Account-Id")
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new FundingEventListParams
        {
            CreatedFrom = "2019-12-27",
            CreatedTo = "2019-12-27",
            Direction = Direction.Deposit,
            EventType = EventType.ChargeDeposit,
            PageNumber = 0,
            PageSize = 0,
            SearchText = "search_text",
            SortBy = SortBy.TransferDate,
            SortOrder = SortOrder.Asc,
            Status = [Status.Created],
            StatusReason = [StatusReason.InsufficientFunds],
            StatusSource = [StatusSource.Watchtower],
            TraceID = "trace_id",
            TraceNumber = "trace_number",
            CorrelationID = "Correlation-Id",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        FundingEventListParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class DirectionTest : TestBase
{
    [Theory]
    [InlineData(Direction.Deposit)]
    [InlineData(Direction.Withdrawal)]
    public void Validation_Works(Direction rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Direction> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Direction>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Direction.Deposit)]
    [InlineData(Direction.Withdrawal)]
    public void SerializationRoundtrip_Works(Direction rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Direction> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Direction>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Direction>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Direction>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class EventTypeTest : TestBase
{
    [Theory]
    [InlineData(EventType.ChargeDeposit)]
    [InlineData(EventType.ChargeReversal)]
    [InlineData(EventType.PayoutReturn)]
    [InlineData(EventType.PayoutWithdrawal)]
    [InlineData(EventType.ChargeDeposit1)]
    [InlineData(EventType.ChargeReversal1)]
    [InlineData(EventType.PayoutReturn1)]
    [InlineData(EventType.PayoutWithdrawal1)]
    public void Validation_Works(EventType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, EventType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, EventType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(EventType.ChargeDeposit)]
    [InlineData(EventType.ChargeReversal)]
    [InlineData(EventType.PayoutReturn)]
    [InlineData(EventType.PayoutWithdrawal)]
    [InlineData(EventType.ChargeDeposit1)]
    [InlineData(EventType.ChargeReversal1)]
    [InlineData(EventType.PayoutReturn1)]
    [InlineData(EventType.PayoutWithdrawal1)]
    public void SerializationRoundtrip_Works(EventType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, EventType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, EventType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, EventType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, EventType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class SortByTest : TestBase
{
    [Theory]
    [InlineData(SortBy.TransferDate)]
    [InlineData(SortBy.ID)]
    [InlineData(SortBy.Amount)]
    [InlineData(SortBy.TransferDate1)]
    [InlineData(SortBy.ID1)]
    [InlineData(SortBy.Amount1)]
    public void Validation_Works(SortBy rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, SortBy> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, SortBy>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(SortBy.TransferDate)]
    [InlineData(SortBy.ID)]
    [InlineData(SortBy.Amount)]
    [InlineData(SortBy.TransferDate1)]
    [InlineData(SortBy.ID1)]
    [InlineData(SortBy.Amount1)]
    public void SerializationRoundtrip_Works(SortBy rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, SortBy> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, SortBy>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, SortBy>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, SortBy>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class SortOrderTest : TestBase
{
    [Theory]
    [InlineData(SortOrder.Asc)]
    [InlineData(SortOrder.Desc)]
    [InlineData(SortOrder.Asc1)]
    [InlineData(SortOrder.Desc1)]
    public void Validation_Works(SortOrder rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, SortOrder> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, SortOrder>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(SortOrder.Asc)]
    [InlineData(SortOrder.Desc)]
    [InlineData(SortOrder.Asc1)]
    [InlineData(SortOrder.Desc1)]
    public void SerializationRoundtrip_Works(SortOrder rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, SortOrder> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, SortOrder>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, SortOrder>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, SortOrder>>(
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
    [InlineData(Status.Created1)]
    [InlineData(Status.Scheduled1)]
    [InlineData(Status.Failed1)]
    [InlineData(Status.Cancelled1)]
    [InlineData(Status.OnHold1)]
    [InlineData(Status.Pending1)]
    [InlineData(Status.Paid1)]
    [InlineData(Status.Reversed1)]
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
    [InlineData(Status.Created1)]
    [InlineData(Status.Scheduled1)]
    [InlineData(Status.Failed1)]
    [InlineData(Status.Cancelled1)]
    [InlineData(Status.OnHold1)]
    [InlineData(Status.Pending1)]
    [InlineData(Status.Paid1)]
    [InlineData(Status.Reversed1)]
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

public class StatusReasonTest : TestBase
{
    [Theory]
    [InlineData(StatusReason.InsufficientFunds)]
    [InlineData(StatusReason.ClosedBankAccount)]
    [InlineData(StatusReason.InvalidBankAccount)]
    [InlineData(StatusReason.InvalidRouting)]
    [InlineData(StatusReason.Disputed)]
    [InlineData(StatusReason.PaymentStopped)]
    [InlineData(StatusReason.OwnerDeceased)]
    [InlineData(StatusReason.FrozenBankAccount)]
    [InlineData(StatusReason.RiskReview)]
    [InlineData(StatusReason.Fraudulent)]
    [InlineData(StatusReason.DuplicateEntry)]
    [InlineData(StatusReason.InvalidPaykey)]
    [InlineData(StatusReason.PaymentBlocked)]
    [InlineData(StatusReason.AmountTooLarge)]
    [InlineData(StatusReason.TooManyAttempts)]
    [InlineData(StatusReason.InternalSystemError)]
    [InlineData(StatusReason.UserRequest)]
    [InlineData(StatusReason.Ok)]
    [InlineData(StatusReason.OtherNetworkReturn)]
    [InlineData(StatusReason.PayoutRefused)]
    [InlineData(StatusReason.CancelRequest)]
    [InlineData(StatusReason.FailedVerification)]
    [InlineData(StatusReason.RequireReview)]
    [InlineData(StatusReason.BlockedBySystem)]
    [InlineData(StatusReason.WatchtowerReview)]
    [InlineData(StatusReason.InsufficientFunds1)]
    [InlineData(StatusReason.ClosedBankAccount1)]
    [InlineData(StatusReason.InvalidBankAccount1)]
    [InlineData(StatusReason.InvalidRouting1)]
    [InlineData(StatusReason.Disputed1)]
    [InlineData(StatusReason.PaymentStopped1)]
    [InlineData(StatusReason.OwnerDeceased1)]
    [InlineData(StatusReason.FrozenBankAccount1)]
    [InlineData(StatusReason.RiskReview1)]
    [InlineData(StatusReason.Fraudulent1)]
    [InlineData(StatusReason.DuplicateEntry1)]
    [InlineData(StatusReason.InvalidPaykey1)]
    [InlineData(StatusReason.PaymentBlocked1)]
    [InlineData(StatusReason.AmountTooLarge1)]
    [InlineData(StatusReason.TooManyAttempts1)]
    [InlineData(StatusReason.InternalSystemError1)]
    [InlineData(StatusReason.UserRequest1)]
    [InlineData(StatusReason.Ok1)]
    [InlineData(StatusReason.OtherNetworkReturn1)]
    [InlineData(StatusReason.PayoutRefused1)]
    public void Validation_Works(StatusReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, StatusReason> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, StatusReason>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(StatusReason.InsufficientFunds)]
    [InlineData(StatusReason.ClosedBankAccount)]
    [InlineData(StatusReason.InvalidBankAccount)]
    [InlineData(StatusReason.InvalidRouting)]
    [InlineData(StatusReason.Disputed)]
    [InlineData(StatusReason.PaymentStopped)]
    [InlineData(StatusReason.OwnerDeceased)]
    [InlineData(StatusReason.FrozenBankAccount)]
    [InlineData(StatusReason.RiskReview)]
    [InlineData(StatusReason.Fraudulent)]
    [InlineData(StatusReason.DuplicateEntry)]
    [InlineData(StatusReason.InvalidPaykey)]
    [InlineData(StatusReason.PaymentBlocked)]
    [InlineData(StatusReason.AmountTooLarge)]
    [InlineData(StatusReason.TooManyAttempts)]
    [InlineData(StatusReason.InternalSystemError)]
    [InlineData(StatusReason.UserRequest)]
    [InlineData(StatusReason.Ok)]
    [InlineData(StatusReason.OtherNetworkReturn)]
    [InlineData(StatusReason.PayoutRefused)]
    [InlineData(StatusReason.CancelRequest)]
    [InlineData(StatusReason.FailedVerification)]
    [InlineData(StatusReason.RequireReview)]
    [InlineData(StatusReason.BlockedBySystem)]
    [InlineData(StatusReason.WatchtowerReview)]
    [InlineData(StatusReason.InsufficientFunds1)]
    [InlineData(StatusReason.ClosedBankAccount1)]
    [InlineData(StatusReason.InvalidBankAccount1)]
    [InlineData(StatusReason.InvalidRouting1)]
    [InlineData(StatusReason.Disputed1)]
    [InlineData(StatusReason.PaymentStopped1)]
    [InlineData(StatusReason.OwnerDeceased1)]
    [InlineData(StatusReason.FrozenBankAccount1)]
    [InlineData(StatusReason.RiskReview1)]
    [InlineData(StatusReason.Fraudulent1)]
    [InlineData(StatusReason.DuplicateEntry1)]
    [InlineData(StatusReason.InvalidPaykey1)]
    [InlineData(StatusReason.PaymentBlocked1)]
    [InlineData(StatusReason.AmountTooLarge1)]
    [InlineData(StatusReason.TooManyAttempts1)]
    [InlineData(StatusReason.InternalSystemError1)]
    [InlineData(StatusReason.UserRequest1)]
    [InlineData(StatusReason.Ok1)]
    [InlineData(StatusReason.OtherNetworkReturn1)]
    [InlineData(StatusReason.PayoutRefused1)]
    public void SerializationRoundtrip_Works(StatusReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, StatusReason> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, StatusReason>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, StatusReason>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, StatusReason>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class StatusSourceTest : TestBase
{
    [Theory]
    [InlineData(StatusSource.Watchtower)]
    [InlineData(StatusSource.BankDecline)]
    [InlineData(StatusSource.CustomerDispute)]
    [InlineData(StatusSource.UserAction)]
    [InlineData(StatusSource.System)]
    [InlineData(StatusSource.Watchtower1)]
    [InlineData(StatusSource.BankDecline1)]
    [InlineData(StatusSource.CustomerDispute1)]
    [InlineData(StatusSource.UserAction1)]
    [InlineData(StatusSource.System1)]
    public void Validation_Works(StatusSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, StatusSource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, StatusSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(StatusSource.Watchtower)]
    [InlineData(StatusSource.BankDecline)]
    [InlineData(StatusSource.CustomerDispute)]
    [InlineData(StatusSource.UserAction)]
    [InlineData(StatusSource.System)]
    [InlineData(StatusSource.Watchtower1)]
    [InlineData(StatusSource.BankDecline1)]
    [InlineData(StatusSource.CustomerDispute1)]
    [InlineData(StatusSource.UserAction1)]
    [InlineData(StatusSource.System1)]
    public void SerializationRoundtrip_Works(StatusSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, StatusSource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, StatusSource>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, StatusSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, StatusSource>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
