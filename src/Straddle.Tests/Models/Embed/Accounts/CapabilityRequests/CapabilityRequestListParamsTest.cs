using System;
using System.Net.Http;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using CapabilityRequests = Straddle.Models.Embed.Accounts.CapabilityRequests;

namespace Straddle.Tests.Models.Embed.Accounts.CapabilityRequests;

public class CapabilityRequestListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new CapabilityRequests::CapabilityRequestListParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Category = CapabilityRequests::Category.PaymentType,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = CapabilityRequests::SortOrder.Asc,
            Status = CapabilityRequests::Status.Active,
            Type = CapabilityRequests::Type.Charges,
            CorrelationID = "correlation-id",
            RequestID = "request-id",
        };

        string expectedAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        ApiEnum<string, CapabilityRequests::Category> expectedCategory =
            CapabilityRequests::Category.PaymentType;
        int expectedPageNumber = 0;
        int expectedPageSize = 0;
        string expectedSortBy = "sort_by";
        ApiEnum<string, CapabilityRequests::SortOrder> expectedSortOrder =
            CapabilityRequests::SortOrder.Asc;
        ApiEnum<string, CapabilityRequests::Status> expectedStatus =
            CapabilityRequests::Status.Active;
        ApiEnum<string, CapabilityRequests::Type> expectedType = CapabilityRequests::Type.Charges;
        string expectedCorrelationID = "correlation-id";
        string expectedRequestID = "request-id";

        Assert.Equal(expectedAccountID, parameters.AccountID);
        Assert.Equal(expectedCategory, parameters.Category);
        Assert.Equal(expectedPageNumber, parameters.PageNumber);
        Assert.Equal(expectedPageSize, parameters.PageSize);
        Assert.Equal(expectedSortBy, parameters.SortBy);
        Assert.Equal(expectedSortOrder, parameters.SortOrder);
        Assert.Equal(expectedStatus, parameters.Status);
        Assert.Equal(expectedType, parameters.Type);
        Assert.Equal(expectedCorrelationID, parameters.CorrelationID);
        Assert.Equal(expectedRequestID, parameters.RequestID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new CapabilityRequests::CapabilityRequestListParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        Assert.Null(parameters.Category);
        Assert.False(parameters.RawQueryData.ContainsKey("category"));
        Assert.Null(parameters.PageNumber);
        Assert.False(parameters.RawQueryData.ContainsKey("page_number"));
        Assert.Null(parameters.PageSize);
        Assert.False(parameters.RawQueryData.ContainsKey("page_size"));
        Assert.Null(parameters.SortBy);
        Assert.False(parameters.RawQueryData.ContainsKey("sort_by"));
        Assert.Null(parameters.SortOrder);
        Assert.False(parameters.RawQueryData.ContainsKey("sort_order"));
        Assert.Null(parameters.Status);
        Assert.False(parameters.RawQueryData.ContainsKey("status"));
        Assert.Null(parameters.Type);
        Assert.False(parameters.RawQueryData.ContainsKey("type"));
        Assert.Null(parameters.CorrelationID);
        Assert.False(parameters.RawHeaderData.ContainsKey("correlation-id"));
        Assert.Null(parameters.RequestID);
        Assert.False(parameters.RawHeaderData.ContainsKey("request-id"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new CapabilityRequests::CapabilityRequestListParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",

            // Null should be interpreted as omitted for these properties
            Category = null,
            PageNumber = null,
            PageSize = null,
            SortBy = null,
            SortOrder = null,
            Status = null,
            Type = null,
            CorrelationID = null,
            RequestID = null,
        };

        Assert.Null(parameters.Category);
        Assert.False(parameters.RawQueryData.ContainsKey("category"));
        Assert.Null(parameters.PageNumber);
        Assert.False(parameters.RawQueryData.ContainsKey("page_number"));
        Assert.Null(parameters.PageSize);
        Assert.False(parameters.RawQueryData.ContainsKey("page_size"));
        Assert.Null(parameters.SortBy);
        Assert.False(parameters.RawQueryData.ContainsKey("sort_by"));
        Assert.Null(parameters.SortOrder);
        Assert.False(parameters.RawQueryData.ContainsKey("sort_order"));
        Assert.Null(parameters.Status);
        Assert.False(parameters.RawQueryData.ContainsKey("status"));
        Assert.Null(parameters.Type);
        Assert.False(parameters.RawQueryData.ContainsKey("type"));
        Assert.Null(parameters.CorrelationID);
        Assert.False(parameters.RawHeaderData.ContainsKey("correlation-id"));
        Assert.Null(parameters.RequestID);
        Assert.False(parameters.RawHeaderData.ContainsKey("request-id"));
    }

    [Fact]
    public void Url_Works()
    {
        CapabilityRequests::CapabilityRequestListParams parameters = new()
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Category = CapabilityRequests::Category.PaymentType,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = CapabilityRequests::SortOrder.Asc,
            Status = CapabilityRequests::Status.Active,
            Type = CapabilityRequests::Type.Charges,
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://sandbox.straddle.com/v1/accounts/182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e/capability_requests?category=payment_type&page_number=0&page_size=0&sort_by=sort_by&sort_order=asc&status=active&type=charges"
            ),
            url
        );
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        CapabilityRequests::CapabilityRequestListParams parameters = new()
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CorrelationID = "correlation-id",
            RequestID = "request-id",
        };

        parameters.AddHeadersToRequest(requestMessage, new() { ApiKey = "My API Key" });

        Assert.Equal(["correlation-id"], requestMessage.Headers.GetValues("correlation-id"));
        Assert.Equal(["request-id"], requestMessage.Headers.GetValues("request-id"));
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new CapabilityRequests::CapabilityRequestListParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Category = CapabilityRequests::Category.PaymentType,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = CapabilityRequests::SortOrder.Asc,
            Status = CapabilityRequests::Status.Active,
            Type = CapabilityRequests::Type.Charges,
            CorrelationID = "correlation-id",
            RequestID = "request-id",
        };

        CapabilityRequests::CapabilityRequestListParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class CategoryTest : TestBase
{
    [Theory]
    [InlineData(CapabilityRequests::Category.PaymentType)]
    [InlineData(CapabilityRequests::Category.CustomerType)]
    [InlineData(CapabilityRequests::Category.ConsentType)]
    public void Validation_Works(CapabilityRequests::Category rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CapabilityRequests::Category> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CapabilityRequests::Category>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CapabilityRequests::Category.PaymentType)]
    [InlineData(CapabilityRequests::Category.CustomerType)]
    [InlineData(CapabilityRequests::Category.ConsentType)]
    public void SerializationRoundtrip_Works(CapabilityRequests::Category rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CapabilityRequests::Category> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CapabilityRequests::Category>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CapabilityRequests::Category>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CapabilityRequests::Category>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class SortOrderTest : TestBase
{
    [Theory]
    [InlineData(CapabilityRequests::SortOrder.Asc)]
    [InlineData(CapabilityRequests::SortOrder.Desc)]
    public void Validation_Works(CapabilityRequests::SortOrder rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CapabilityRequests::SortOrder> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CapabilityRequests::SortOrder>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CapabilityRequests::SortOrder.Asc)]
    [InlineData(CapabilityRequests::SortOrder.Desc)]
    public void SerializationRoundtrip_Works(CapabilityRequests::SortOrder rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CapabilityRequests::SortOrder> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CapabilityRequests::SortOrder>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CapabilityRequests::SortOrder>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CapabilityRequests::SortOrder>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class StatusTest : TestBase
{
    [Theory]
    [InlineData(CapabilityRequests::Status.Active)]
    [InlineData(CapabilityRequests::Status.Inactive)]
    [InlineData(CapabilityRequests::Status.InReview)]
    [InlineData(CapabilityRequests::Status.Rejected)]
    public void Validation_Works(CapabilityRequests::Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CapabilityRequests::Status> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CapabilityRequests::Status>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CapabilityRequests::Status.Active)]
    [InlineData(CapabilityRequests::Status.Inactive)]
    [InlineData(CapabilityRequests::Status.InReview)]
    [InlineData(CapabilityRequests::Status.Rejected)]
    public void SerializationRoundtrip_Works(CapabilityRequests::Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CapabilityRequests::Status> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CapabilityRequests::Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CapabilityRequests::Status>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CapabilityRequests::Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class TypeTest : TestBase
{
    [Theory]
    [InlineData(CapabilityRequests::Type.Charges)]
    [InlineData(CapabilityRequests::Type.Payouts)]
    [InlineData(CapabilityRequests::Type.Individuals)]
    [InlineData(CapabilityRequests::Type.Businesses)]
    [InlineData(CapabilityRequests::Type.SignedAgreement)]
    [InlineData(CapabilityRequests::Type.Internet)]
    public void Validation_Works(CapabilityRequests::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CapabilityRequests::Type> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CapabilityRequests::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CapabilityRequests::Type.Charges)]
    [InlineData(CapabilityRequests::Type.Payouts)]
    [InlineData(CapabilityRequests::Type.Individuals)]
    [InlineData(CapabilityRequests::Type.Businesses)]
    [InlineData(CapabilityRequests::Type.SignedAgreement)]
    [InlineData(CapabilityRequests::Type.Internet)]
    public void SerializationRoundtrip_Works(CapabilityRequests::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CapabilityRequests::Type> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CapabilityRequests::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CapabilityRequests::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CapabilityRequests::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
