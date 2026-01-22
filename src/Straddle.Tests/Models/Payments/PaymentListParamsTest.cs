using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Payments;

namespace Straddle.Tests.Models.Payments;

public class PaymentListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new PaymentListParams
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            DefaultPageSize = 0,
            DefaultSort = DefaultSort.CreatedAt,
            DefaultSortOrder = DefaultSortOrder.Asc,
            ExternalID = "external_id",
            FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MaxCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxEffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPaymentDate = "2019-12-27",
            MinAmount = 0,
            MinCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MinEffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MinPaymentDate = "2019-12-27",
            PageNumber = 0,
            PageSize = 0,
            Paykey = "paykey",
            PaykeyID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            PaymentID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            PaymentStatus = [PaymentStatus.Created],
            PaymentType = [PaymentType.Charge],
            SearchText = "search_text",
            SortBy = SortBy.CreatedAt,
            SortOrder = SortOrder.Asc,
            StatusReason = [StatusReason.InsufficientFunds],
            StatusSource = [StatusSource.Watchtower],
            CorrelationID = "Correlation-Id",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        string expectedCustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedDefaultPageSize = 0;
        ApiEnum<string, DefaultSort> expectedDefaultSort = DefaultSort.CreatedAt;
        ApiEnum<string, DefaultSortOrder> expectedDefaultSortOrder = DefaultSortOrder.Asc;
        string expectedExternalID = "external_id";
        string expectedFundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedMaxAmount = 0;
        DateTimeOffset expectedMaxCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        DateTimeOffset expectedMaxEffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMaxPaymentDate = "2019-12-27";
        int expectedMinAmount = 0;
        DateTimeOffset expectedMinCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        DateTimeOffset expectedMinEffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMinPaymentDate = "2019-12-27";
        int expectedPageNumber = 0;
        int expectedPageSize = 0;
        string expectedPaykey = "paykey";
        string expectedPaykeyID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        string expectedPaymentID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        List<ApiEnum<string, PaymentStatus>> expectedPaymentStatus = [PaymentStatus.Created];
        List<ApiEnum<string, PaymentType>> expectedPaymentType = [PaymentType.Charge];
        string expectedSearchText = "search_text";
        ApiEnum<string, SortBy> expectedSortBy = SortBy.CreatedAt;
        ApiEnum<string, SortOrder> expectedSortOrder = SortOrder.Asc;
        List<ApiEnum<string, StatusReason>> expectedStatusReason = [StatusReason.InsufficientFunds];
        List<ApiEnum<string, StatusSource>> expectedStatusSource = [StatusSource.Watchtower];
        string expectedCorrelationID = "Correlation-Id";
        string expectedRequestID = "Request-Id";
        string expectedStraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";

        Assert.Equal(expectedCustomerID, parameters.CustomerID);
        Assert.Equal(expectedDefaultPageSize, parameters.DefaultPageSize);
        Assert.Equal(expectedDefaultSort, parameters.DefaultSort);
        Assert.Equal(expectedDefaultSortOrder, parameters.DefaultSortOrder);
        Assert.Equal(expectedExternalID, parameters.ExternalID);
        Assert.Equal(expectedFundingID, parameters.FundingID);
        Assert.Equal(expectedMaxAmount, parameters.MaxAmount);
        Assert.Equal(expectedMaxCreatedAt, parameters.MaxCreatedAt);
        Assert.Equal(expectedMaxEffectiveAt, parameters.MaxEffectiveAt);
        Assert.Equal(expectedMaxPaymentDate, parameters.MaxPaymentDate);
        Assert.Equal(expectedMinAmount, parameters.MinAmount);
        Assert.Equal(expectedMinCreatedAt, parameters.MinCreatedAt);
        Assert.Equal(expectedMinEffectiveAt, parameters.MinEffectiveAt);
        Assert.Equal(expectedMinPaymentDate, parameters.MinPaymentDate);
        Assert.Equal(expectedPageNumber, parameters.PageNumber);
        Assert.Equal(expectedPageSize, parameters.PageSize);
        Assert.Equal(expectedPaykey, parameters.Paykey);
        Assert.Equal(expectedPaykeyID, parameters.PaykeyID);
        Assert.Equal(expectedPaymentID, parameters.PaymentID);
        Assert.NotNull(parameters.PaymentStatus);
        Assert.Equal(expectedPaymentStatus.Count, parameters.PaymentStatus.Count);
        for (int i = 0; i < expectedPaymentStatus.Count; i++)
        {
            Assert.Equal(expectedPaymentStatus[i], parameters.PaymentStatus[i]);
        }
        Assert.NotNull(parameters.PaymentType);
        Assert.Equal(expectedPaymentType.Count, parameters.PaymentType.Count);
        for (int i = 0; i < expectedPaymentType.Count; i++)
        {
            Assert.Equal(expectedPaymentType[i], parameters.PaymentType[i]);
        }
        Assert.Equal(expectedSearchText, parameters.SearchText);
        Assert.Equal(expectedSortBy, parameters.SortBy);
        Assert.Equal(expectedSortOrder, parameters.SortOrder);
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
        Assert.Equal(expectedCorrelationID, parameters.CorrelationID);
        Assert.Equal(expectedRequestID, parameters.RequestID);
        Assert.Equal(expectedStraddleAccountID, parameters.StraddleAccountID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new PaymentListParams { };

        Assert.Null(parameters.CustomerID);
        Assert.False(parameters.RawQueryData.ContainsKey("customer_id"));
        Assert.Null(parameters.DefaultPageSize);
        Assert.False(parameters.RawQueryData.ContainsKey("default_page_size"));
        Assert.Null(parameters.DefaultSort);
        Assert.False(parameters.RawQueryData.ContainsKey("default_sort"));
        Assert.Null(parameters.DefaultSortOrder);
        Assert.False(parameters.RawQueryData.ContainsKey("default_sort_order"));
        Assert.Null(parameters.ExternalID);
        Assert.False(parameters.RawQueryData.ContainsKey("external_id"));
        Assert.Null(parameters.FundingID);
        Assert.False(parameters.RawQueryData.ContainsKey("funding_id"));
        Assert.Null(parameters.MaxAmount);
        Assert.False(parameters.RawQueryData.ContainsKey("max_amount"));
        Assert.Null(parameters.MaxCreatedAt);
        Assert.False(parameters.RawQueryData.ContainsKey("max_created_at"));
        Assert.Null(parameters.MaxEffectiveAt);
        Assert.False(parameters.RawQueryData.ContainsKey("max_effective_at"));
        Assert.Null(parameters.MaxPaymentDate);
        Assert.False(parameters.RawQueryData.ContainsKey("max_payment_date"));
        Assert.Null(parameters.MinAmount);
        Assert.False(parameters.RawQueryData.ContainsKey("min_amount"));
        Assert.Null(parameters.MinCreatedAt);
        Assert.False(parameters.RawQueryData.ContainsKey("min_created_at"));
        Assert.Null(parameters.MinEffectiveAt);
        Assert.False(parameters.RawQueryData.ContainsKey("min_effective_at"));
        Assert.Null(parameters.MinPaymentDate);
        Assert.False(parameters.RawQueryData.ContainsKey("min_payment_date"));
        Assert.Null(parameters.PageNumber);
        Assert.False(parameters.RawQueryData.ContainsKey("page_number"));
        Assert.Null(parameters.PageSize);
        Assert.False(parameters.RawQueryData.ContainsKey("page_size"));
        Assert.Null(parameters.Paykey);
        Assert.False(parameters.RawQueryData.ContainsKey("paykey"));
        Assert.Null(parameters.PaykeyID);
        Assert.False(parameters.RawQueryData.ContainsKey("paykey_id"));
        Assert.Null(parameters.PaymentID);
        Assert.False(parameters.RawQueryData.ContainsKey("payment_id"));
        Assert.Null(parameters.PaymentStatus);
        Assert.False(parameters.RawQueryData.ContainsKey("payment_status"));
        Assert.Null(parameters.PaymentType);
        Assert.False(parameters.RawQueryData.ContainsKey("payment_type"));
        Assert.Null(parameters.SearchText);
        Assert.False(parameters.RawQueryData.ContainsKey("search_text"));
        Assert.Null(parameters.SortBy);
        Assert.False(parameters.RawQueryData.ContainsKey("sort_by"));
        Assert.Null(parameters.SortOrder);
        Assert.False(parameters.RawQueryData.ContainsKey("sort_order"));
        Assert.Null(parameters.StatusReason);
        Assert.False(parameters.RawQueryData.ContainsKey("status_reason"));
        Assert.Null(parameters.StatusSource);
        Assert.False(parameters.RawQueryData.ContainsKey("status_source"));
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
        var parameters = new PaymentListParams
        {
            // Null should be interpreted as omitted for these properties
            CustomerID = null,
            DefaultPageSize = null,
            DefaultSort = null,
            DefaultSortOrder = null,
            ExternalID = null,
            FundingID = null,
            MaxAmount = null,
            MaxCreatedAt = null,
            MaxEffectiveAt = null,
            MaxPaymentDate = null,
            MinAmount = null,
            MinCreatedAt = null,
            MinEffectiveAt = null,
            MinPaymentDate = null,
            PageNumber = null,
            PageSize = null,
            Paykey = null,
            PaykeyID = null,
            PaymentID = null,
            PaymentStatus = null,
            PaymentType = null,
            SearchText = null,
            SortBy = null,
            SortOrder = null,
            StatusReason = null,
            StatusSource = null,
            CorrelationID = null,
            RequestID = null,
            StraddleAccountID = null,
        };

        Assert.Null(parameters.CustomerID);
        Assert.False(parameters.RawQueryData.ContainsKey("customer_id"));
        Assert.Null(parameters.DefaultPageSize);
        Assert.False(parameters.RawQueryData.ContainsKey("default_page_size"));
        Assert.Null(parameters.DefaultSort);
        Assert.False(parameters.RawQueryData.ContainsKey("default_sort"));
        Assert.Null(parameters.DefaultSortOrder);
        Assert.False(parameters.RawQueryData.ContainsKey("default_sort_order"));
        Assert.Null(parameters.ExternalID);
        Assert.False(parameters.RawQueryData.ContainsKey("external_id"));
        Assert.Null(parameters.FundingID);
        Assert.False(parameters.RawQueryData.ContainsKey("funding_id"));
        Assert.Null(parameters.MaxAmount);
        Assert.False(parameters.RawQueryData.ContainsKey("max_amount"));
        Assert.Null(parameters.MaxCreatedAt);
        Assert.False(parameters.RawQueryData.ContainsKey("max_created_at"));
        Assert.Null(parameters.MaxEffectiveAt);
        Assert.False(parameters.RawQueryData.ContainsKey("max_effective_at"));
        Assert.Null(parameters.MaxPaymentDate);
        Assert.False(parameters.RawQueryData.ContainsKey("max_payment_date"));
        Assert.Null(parameters.MinAmount);
        Assert.False(parameters.RawQueryData.ContainsKey("min_amount"));
        Assert.Null(parameters.MinCreatedAt);
        Assert.False(parameters.RawQueryData.ContainsKey("min_created_at"));
        Assert.Null(parameters.MinEffectiveAt);
        Assert.False(parameters.RawQueryData.ContainsKey("min_effective_at"));
        Assert.Null(parameters.MinPaymentDate);
        Assert.False(parameters.RawQueryData.ContainsKey("min_payment_date"));
        Assert.Null(parameters.PageNumber);
        Assert.False(parameters.RawQueryData.ContainsKey("page_number"));
        Assert.Null(parameters.PageSize);
        Assert.False(parameters.RawQueryData.ContainsKey("page_size"));
        Assert.Null(parameters.Paykey);
        Assert.False(parameters.RawQueryData.ContainsKey("paykey"));
        Assert.Null(parameters.PaykeyID);
        Assert.False(parameters.RawQueryData.ContainsKey("paykey_id"));
        Assert.Null(parameters.PaymentID);
        Assert.False(parameters.RawQueryData.ContainsKey("payment_id"));
        Assert.Null(parameters.PaymentStatus);
        Assert.False(parameters.RawQueryData.ContainsKey("payment_status"));
        Assert.Null(parameters.PaymentType);
        Assert.False(parameters.RawQueryData.ContainsKey("payment_type"));
        Assert.Null(parameters.SearchText);
        Assert.False(parameters.RawQueryData.ContainsKey("search_text"));
        Assert.Null(parameters.SortBy);
        Assert.False(parameters.RawQueryData.ContainsKey("sort_by"));
        Assert.Null(parameters.SortOrder);
        Assert.False(parameters.RawQueryData.ContainsKey("sort_order"));
        Assert.Null(parameters.StatusReason);
        Assert.False(parameters.RawQueryData.ContainsKey("status_reason"));
        Assert.Null(parameters.StatusSource);
        Assert.False(parameters.RawQueryData.ContainsKey("status_source"));
        Assert.Null(parameters.CorrelationID);
        Assert.False(parameters.RawHeaderData.ContainsKey("Correlation-Id"));
        Assert.Null(parameters.RequestID);
        Assert.False(parameters.RawHeaderData.ContainsKey("Request-Id"));
        Assert.Null(parameters.StraddleAccountID);
        Assert.False(parameters.RawHeaderData.ContainsKey("Straddle-Account-Id"));
    }

    [Fact]
    public void Url_Works()
    {
        PaymentListParams parameters = new()
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            DefaultPageSize = 0,
            DefaultSort = DefaultSort.CreatedAt,
            DefaultSortOrder = DefaultSortOrder.Asc,
            ExternalID = "external_id",
            FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MaxCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxEffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPaymentDate = "2019-12-27",
            MinAmount = 0,
            MinCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MinEffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MinPaymentDate = "2019-12-27",
            PageNumber = 0,
            PageSize = 0,
            Paykey = "paykey",
            PaykeyID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            PaymentID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            PaymentStatus = [PaymentStatus.Created],
            PaymentType = [PaymentType.Charge],
            SearchText = "search_text",
            SortBy = SortBy.CreatedAt,
            SortOrder = SortOrder.Asc,
            StatusReason = [StatusReason.InsufficientFunds],
            StatusSource = [StatusSource.Watchtower],
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://sandbox.straddle.com/v1/payments?customer_id=182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e&default_page_size=0&default_sort=created_at&default_sort_order=asc&external_id=external_id&funding_id=182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e&max_amount=0&max_created_at=2019-12-27T18%3a11%3a19.117%2b00%3a00&max_effective_at=2019-12-27T18%3a11%3a19.117%2b00%3a00&max_payment_date=2019-12-27&min_amount=0&min_created_at=2019-12-27T18%3a11%3a19.117%2b00%3a00&min_effective_at=2019-12-27T18%3a11%3a19.117%2b00%3a00&min_payment_date=2019-12-27&page_number=0&page_size=0&paykey=paykey&paykey_id=182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e&payment_id=182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e&payment_status=created&payment_type=charge&search_text=search_text&sort_by=created_at&sort_order=asc&status_reason=insufficient_funds&status_source=watchtower"
            ),
            url
        );
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        PaymentListParams parameters = new()
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
        var parameters = new PaymentListParams
        {
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            DefaultPageSize = 0,
            DefaultSort = DefaultSort.CreatedAt,
            DefaultSortOrder = DefaultSortOrder.Asc,
            ExternalID = "external_id",
            FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MaxCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxEffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPaymentDate = "2019-12-27",
            MinAmount = 0,
            MinCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MinEffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MinPaymentDate = "2019-12-27",
            PageNumber = 0,
            PageSize = 0,
            Paykey = "paykey",
            PaykeyID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            PaymentID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            PaymentStatus = [PaymentStatus.Created],
            PaymentType = [PaymentType.Charge],
            SearchText = "search_text",
            SortBy = SortBy.CreatedAt,
            SortOrder = SortOrder.Asc,
            StatusReason = [StatusReason.InsufficientFunds],
            StatusSource = [StatusSource.Watchtower],
            CorrelationID = "Correlation-Id",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        PaymentListParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class DefaultSortTest : TestBase
{
    [Theory]
    [InlineData(DefaultSort.CreatedAt)]
    [InlineData(DefaultSort.PaymentDate)]
    [InlineData(DefaultSort.EffectiveAt)]
    [InlineData(DefaultSort.ID)]
    [InlineData(DefaultSort.Amount)]
    [InlineData(DefaultSort.CreatedAt1)]
    [InlineData(DefaultSort.PaymentDate1)]
    [InlineData(DefaultSort.EffectiveAt1)]
    [InlineData(DefaultSort.ID1)]
    [InlineData(DefaultSort.Amount1)]
    public void Validation_Works(DefaultSort rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DefaultSort> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DefaultSort>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(DefaultSort.CreatedAt)]
    [InlineData(DefaultSort.PaymentDate)]
    [InlineData(DefaultSort.EffectiveAt)]
    [InlineData(DefaultSort.ID)]
    [InlineData(DefaultSort.Amount)]
    [InlineData(DefaultSort.CreatedAt1)]
    [InlineData(DefaultSort.PaymentDate1)]
    [InlineData(DefaultSort.EffectiveAt1)]
    [InlineData(DefaultSort.ID1)]
    [InlineData(DefaultSort.Amount1)]
    public void SerializationRoundtrip_Works(DefaultSort rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DefaultSort> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DefaultSort>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DefaultSort>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DefaultSort>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class DefaultSortOrderTest : TestBase
{
    [Theory]
    [InlineData(DefaultSortOrder.Asc)]
    [InlineData(DefaultSortOrder.Desc)]
    [InlineData(DefaultSortOrder.Asc1)]
    [InlineData(DefaultSortOrder.Desc1)]
    public void Validation_Works(DefaultSortOrder rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DefaultSortOrder> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DefaultSortOrder>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(DefaultSortOrder.Asc)]
    [InlineData(DefaultSortOrder.Desc)]
    [InlineData(DefaultSortOrder.Asc1)]
    [InlineData(DefaultSortOrder.Desc1)]
    public void SerializationRoundtrip_Works(DefaultSortOrder rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DefaultSortOrder> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DefaultSortOrder>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DefaultSortOrder>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DefaultSortOrder>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class PaymentStatusTest : TestBase
{
    [Theory]
    [InlineData(PaymentStatus.Created)]
    [InlineData(PaymentStatus.Scheduled)]
    [InlineData(PaymentStatus.Failed)]
    [InlineData(PaymentStatus.Cancelled)]
    [InlineData(PaymentStatus.OnHold)]
    [InlineData(PaymentStatus.Pending)]
    [InlineData(PaymentStatus.Paid)]
    [InlineData(PaymentStatus.Reversed)]
    [InlineData(PaymentStatus.Created1)]
    [InlineData(PaymentStatus.Scheduled1)]
    [InlineData(PaymentStatus.Failed1)]
    [InlineData(PaymentStatus.Cancelled1)]
    [InlineData(PaymentStatus.OnHold1)]
    [InlineData(PaymentStatus.Pending1)]
    [InlineData(PaymentStatus.Paid1)]
    [InlineData(PaymentStatus.Reversed1)]
    public void Validation_Works(PaymentStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaymentStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaymentStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaymentStatus.Created)]
    [InlineData(PaymentStatus.Scheduled)]
    [InlineData(PaymentStatus.Failed)]
    [InlineData(PaymentStatus.Cancelled)]
    [InlineData(PaymentStatus.OnHold)]
    [InlineData(PaymentStatus.Pending)]
    [InlineData(PaymentStatus.Paid)]
    [InlineData(PaymentStatus.Reversed)]
    [InlineData(PaymentStatus.Created1)]
    [InlineData(PaymentStatus.Scheduled1)]
    [InlineData(PaymentStatus.Failed1)]
    [InlineData(PaymentStatus.Cancelled1)]
    [InlineData(PaymentStatus.OnHold1)]
    [InlineData(PaymentStatus.Pending1)]
    [InlineData(PaymentStatus.Paid1)]
    [InlineData(PaymentStatus.Reversed1)]
    public void SerializationRoundtrip_Works(PaymentStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaymentStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaymentStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaymentStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaymentStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class PaymentTypeTest : TestBase
{
    [Theory]
    [InlineData(PaymentType.Charge)]
    [InlineData(PaymentType.Payout)]
    [InlineData(PaymentType.Charge1)]
    [InlineData(PaymentType.Payout1)]
    public void Validation_Works(PaymentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaymentType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaymentType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaymentType.Charge)]
    [InlineData(PaymentType.Payout)]
    [InlineData(PaymentType.Charge1)]
    [InlineData(PaymentType.Payout1)]
    public void SerializationRoundtrip_Works(PaymentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaymentType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaymentType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaymentType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaymentType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class SortByTest : TestBase
{
    [Theory]
    [InlineData(SortBy.CreatedAt)]
    [InlineData(SortBy.PaymentDate)]
    [InlineData(SortBy.EffectiveAt)]
    [InlineData(SortBy.ID)]
    [InlineData(SortBy.Amount)]
    [InlineData(SortBy.CreatedAt1)]
    [InlineData(SortBy.PaymentDate1)]
    [InlineData(SortBy.EffectiveAt1)]
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
    [InlineData(SortBy.CreatedAt)]
    [InlineData(SortBy.PaymentDate)]
    [InlineData(SortBy.EffectiveAt)]
    [InlineData(SortBy.ID)]
    [InlineData(SortBy.Amount)]
    [InlineData(SortBy.CreatedAt1)]
    [InlineData(SortBy.PaymentDate1)]
    [InlineData(SortBy.EffectiveAt1)]
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
