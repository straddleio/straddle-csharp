using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Customers;

namespace Straddle.Tests.Models.Customers;

public class CustomerListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new CustomerListParams
        {
            CreatedFrom = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CreatedTo = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "email",
            ExternalID = "external_id",
            Name = "name",
            PageNumber = 0,
            PageSize = 0,
            SearchText = "search_text",
            SortBy = SortBy.Name,
            SortOrder = SortOrder.Asc,
            Status = [CustomerListParamsStatus.Pending],
            Types = [CustomerListParamsType.Individual],
            CorrelationID = "Correlation-Id",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        DateTimeOffset expectedCreatedFrom = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        DateTimeOffset expectedCreatedTo = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedEmail = "email";
        string expectedExternalID = "external_id";
        string expectedName = "name";
        int expectedPageNumber = 0;
        int expectedPageSize = 0;
        string expectedSearchText = "search_text";
        ApiEnum<string, SortBy> expectedSortBy = SortBy.Name;
        ApiEnum<string, SortOrder> expectedSortOrder = SortOrder.Asc;
        List<ApiEnum<string, CustomerListParamsStatus>> expectedStatus =
        [
            CustomerListParamsStatus.Pending,
        ];
        List<ApiEnum<string, CustomerListParamsType>> expectedTypes =
        [
            CustomerListParamsType.Individual,
        ];
        string expectedCorrelationID = "Correlation-Id";
        string expectedRequestID = "Request-Id";
        string expectedStraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";

        Assert.Equal(expectedCreatedFrom, parameters.CreatedFrom);
        Assert.Equal(expectedCreatedTo, parameters.CreatedTo);
        Assert.Equal(expectedEmail, parameters.Email);
        Assert.Equal(expectedExternalID, parameters.ExternalID);
        Assert.Equal(expectedName, parameters.Name);
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
        Assert.NotNull(parameters.Types);
        Assert.Equal(expectedTypes.Count, parameters.Types.Count);
        for (int i = 0; i < expectedTypes.Count; i++)
        {
            Assert.Equal(expectedTypes[i], parameters.Types[i]);
        }
        Assert.Equal(expectedCorrelationID, parameters.CorrelationID);
        Assert.Equal(expectedRequestID, parameters.RequestID);
        Assert.Equal(expectedStraddleAccountID, parameters.StraddleAccountID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new CustomerListParams { };

        Assert.Null(parameters.CreatedFrom);
        Assert.False(parameters.RawQueryData.ContainsKey("created_from"));
        Assert.Null(parameters.CreatedTo);
        Assert.False(parameters.RawQueryData.ContainsKey("created_to"));
        Assert.Null(parameters.Email);
        Assert.False(parameters.RawQueryData.ContainsKey("email"));
        Assert.Null(parameters.ExternalID);
        Assert.False(parameters.RawQueryData.ContainsKey("external_id"));
        Assert.Null(parameters.Name);
        Assert.False(parameters.RawQueryData.ContainsKey("name"));
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
        Assert.Null(parameters.Types);
        Assert.False(parameters.RawQueryData.ContainsKey("types"));
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
        var parameters = new CustomerListParams
        {
            // Null should be interpreted as omitted for these properties
            CreatedFrom = null,
            CreatedTo = null,
            Email = null,
            ExternalID = null,
            Name = null,
            PageNumber = null,
            PageSize = null,
            SearchText = null,
            SortBy = null,
            SortOrder = null,
            Status = null,
            Types = null,
            CorrelationID = null,
            RequestID = null,
            StraddleAccountID = null,
        };

        Assert.Null(parameters.CreatedFrom);
        Assert.False(parameters.RawQueryData.ContainsKey("created_from"));
        Assert.Null(parameters.CreatedTo);
        Assert.False(parameters.RawQueryData.ContainsKey("created_to"));
        Assert.Null(parameters.Email);
        Assert.False(parameters.RawQueryData.ContainsKey("email"));
        Assert.Null(parameters.ExternalID);
        Assert.False(parameters.RawQueryData.ContainsKey("external_id"));
        Assert.Null(parameters.Name);
        Assert.False(parameters.RawQueryData.ContainsKey("name"));
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
        Assert.Null(parameters.Types);
        Assert.False(parameters.RawQueryData.ContainsKey("types"));
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
        CustomerListParams parameters = new()
        {
            CreatedFrom = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CreatedTo = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "email",
            ExternalID = "external_id",
            Name = "name",
            PageNumber = 0,
            PageSize = 0,
            SearchText = "search_text",
            SortBy = SortBy.Name,
            SortOrder = SortOrder.Asc,
            Status = [CustomerListParamsStatus.Pending],
            Types = [CustomerListParamsType.Individual],
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://sandbox.straddle.com/v1/customers?created_from=2019-12-27T18%3a11%3a19.117%2b00%3a00&created_to=2019-12-27T18%3a11%3a19.117%2b00%3a00&email=email&external_id=external_id&name=name&page_number=0&page_size=0&search_text=search_text&sort_by=name&sort_order=asc&status=pending&types=individual"
            ),
            url
        );
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        CustomerListParams parameters = new()
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
        var parameters = new CustomerListParams
        {
            CreatedFrom = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CreatedTo = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "email",
            ExternalID = "external_id",
            Name = "name",
            PageNumber = 0,
            PageSize = 0,
            SearchText = "search_text",
            SortBy = SortBy.Name,
            SortOrder = SortOrder.Asc,
            Status = [CustomerListParamsStatus.Pending],
            Types = [CustomerListParamsType.Individual],
            CorrelationID = "Correlation-Id",
            RequestID = "Request-Id",
            StraddleAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        CustomerListParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class SortByTest : TestBase
{
    [Theory]
    [InlineData(SortBy.Name)]
    [InlineData(SortBy.CreatedAt)]
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
    [InlineData(SortBy.Name)]
    [InlineData(SortBy.CreatedAt)]
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

public class CustomerListParamsStatusTest : TestBase
{
    [Theory]
    [InlineData(CustomerListParamsStatus.Pending)]
    [InlineData(CustomerListParamsStatus.Review)]
    [InlineData(CustomerListParamsStatus.Verified)]
    [InlineData(CustomerListParamsStatus.Inactive)]
    [InlineData(CustomerListParamsStatus.Rejected)]
    public void Validation_Works(CustomerListParamsStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerListParamsStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerListParamsStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CustomerListParamsStatus.Pending)]
    [InlineData(CustomerListParamsStatus.Review)]
    [InlineData(CustomerListParamsStatus.Verified)]
    [InlineData(CustomerListParamsStatus.Inactive)]
    [InlineData(CustomerListParamsStatus.Rejected)]
    public void SerializationRoundtrip_Works(CustomerListParamsStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerListParamsStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CustomerListParamsStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerListParamsStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CustomerListParamsStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class CustomerListParamsTypeTest : TestBase
{
    [Theory]
    [InlineData(CustomerListParamsType.Individual)]
    [InlineData(CustomerListParamsType.Business)]
    [InlineData(CustomerListParamsType.Individual1)]
    [InlineData(CustomerListParamsType.Business1)]
    public void Validation_Works(CustomerListParamsType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerListParamsType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerListParamsType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CustomerListParamsType.Individual)]
    [InlineData(CustomerListParamsType.Business)]
    [InlineData(CustomerListParamsType.Individual1)]
    [InlineData(CustomerListParamsType.Business1)]
    public void SerializationRoundtrip_Works(CustomerListParamsType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerListParamsType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CustomerListParamsType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerListParamsType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CustomerListParamsType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
