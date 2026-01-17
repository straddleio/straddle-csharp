using System;
using System.Net.Http;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Accounts = Straddle.Models.Embed.Accounts;

namespace Straddle.Tests.Models.Embed.Accounts;

public class AccountListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new Accounts::AccountListParams
        {
            PageNumber = 0,
            PageSize = 0,
            SearchText = "search_text",
            SortBy = "sort_by",
            SortOrder = Accounts::SortOrder.Asc,
            Status = Accounts::Status.Created,
            Type = Accounts::Type.Business,
            CorrelationID = "correlation-id",
            RequestID = "request-id",
        };

        int expectedPageNumber = 0;
        int expectedPageSize = 0;
        string expectedSearchText = "search_text";
        string expectedSortBy = "sort_by";
        ApiEnum<string, Accounts::SortOrder> expectedSortOrder = Accounts::SortOrder.Asc;
        ApiEnum<string, Accounts::Status> expectedStatus = Accounts::Status.Created;
        ApiEnum<string, Accounts::Type> expectedType = Accounts::Type.Business;
        string expectedCorrelationID = "correlation-id";
        string expectedRequestID = "request-id";

        Assert.Equal(expectedPageNumber, parameters.PageNumber);
        Assert.Equal(expectedPageSize, parameters.PageSize);
        Assert.Equal(expectedSearchText, parameters.SearchText);
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
        var parameters = new Accounts::AccountListParams { };

        Assert.Null(parameters.PageNumber);
        Assert.False(parameters.RawQueryData.ContainsKey("page_number"));
        Assert.Null(parameters.PageSize);
        Assert.False(parameters.RawQueryData.ContainsKey("page_size"));
        Assert.Null(parameters.SearchText);
        Assert.False(parameters.RawQueryData.ContainsKey("search_text"));
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
        var parameters = new Accounts::AccountListParams
        {
            // Null should be interpreted as omitted for these properties
            PageNumber = null,
            PageSize = null,
            SearchText = null,
            SortBy = null,
            SortOrder = null,
            Status = null,
            Type = null,
            CorrelationID = null,
            RequestID = null,
        };

        Assert.Null(parameters.PageNumber);
        Assert.False(parameters.RawQueryData.ContainsKey("page_number"));
        Assert.Null(parameters.PageSize);
        Assert.False(parameters.RawQueryData.ContainsKey("page_size"));
        Assert.Null(parameters.SearchText);
        Assert.False(parameters.RawQueryData.ContainsKey("search_text"));
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
        Accounts::AccountListParams parameters = new()
        {
            PageNumber = 0,
            PageSize = 0,
            SearchText = "search_text",
            SortBy = "sort_by",
            SortOrder = Accounts::SortOrder.Asc,
            Status = Accounts::Status.Created,
            Type = Accounts::Type.Business,
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://sandbox.straddle.com/v1/accounts?page_number=0&page_size=0&search_text=search_text&sort_by=sort_by&sort_order=asc&status=created&type=business"
            ),
            url
        );
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        Accounts::AccountListParams parameters = new()
        {
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
        var parameters = new Accounts::AccountListParams
        {
            PageNumber = 0,
            PageSize = 0,
            SearchText = "search_text",
            SortBy = "sort_by",
            SortOrder = Accounts::SortOrder.Asc,
            Status = Accounts::Status.Created,
            Type = Accounts::Type.Business,
            CorrelationID = "correlation-id",
            RequestID = "request-id",
        };

        Accounts::AccountListParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class SortOrderTest : TestBase
{
    [Theory]
    [InlineData(Accounts::SortOrder.Asc)]
    [InlineData(Accounts::SortOrder.Desc)]
    public void Validation_Works(Accounts::SortOrder rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Accounts::SortOrder> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Accounts::SortOrder>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Accounts::SortOrder.Asc)]
    [InlineData(Accounts::SortOrder.Desc)]
    public void SerializationRoundtrip_Works(Accounts::SortOrder rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Accounts::SortOrder> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Accounts::SortOrder>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Accounts::SortOrder>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Accounts::SortOrder>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class StatusTest : TestBase
{
    [Theory]
    [InlineData(Accounts::Status.Created)]
    [InlineData(Accounts::Status.Onboarding)]
    [InlineData(Accounts::Status.Active)]
    [InlineData(Accounts::Status.Rejected)]
    [InlineData(Accounts::Status.Inactive)]
    public void Validation_Works(Accounts::Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Accounts::Status> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Accounts::Status>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Accounts::Status.Created)]
    [InlineData(Accounts::Status.Onboarding)]
    [InlineData(Accounts::Status.Active)]
    [InlineData(Accounts::Status.Rejected)]
    [InlineData(Accounts::Status.Inactive)]
    public void SerializationRoundtrip_Works(Accounts::Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Accounts::Status> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Accounts::Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Accounts::Status>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Accounts::Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class TypeTest : TestBase
{
    [Theory]
    [InlineData(Accounts::Type.Business)]
    public void Validation_Works(Accounts::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Accounts::Type> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Accounts::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Accounts::Type.Business)]
    public void SerializationRoundtrip_Works(Accounts::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Accounts::Type> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Accounts::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Accounts::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Accounts::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
