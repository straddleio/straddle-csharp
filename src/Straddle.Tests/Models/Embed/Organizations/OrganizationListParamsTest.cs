using System;
using System.Net.Http;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Embed.Organizations;

namespace Straddle.Tests.Models.Embed.Organizations;

public class OrganizationListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new OrganizationListParams
        {
            ExternalID = "external_id",
            Name = "name",
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = SortOrder.Asc,
            CorrelationID = "correlation-id",
            RequestID = "request-id",
        };

        string expectedExternalID = "external_id";
        string expectedName = "name";
        int expectedPageNumber = 0;
        int expectedPageSize = 0;
        string expectedSortBy = "sort_by";
        ApiEnum<string, SortOrder> expectedSortOrder = SortOrder.Asc;
        string expectedCorrelationID = "correlation-id";
        string expectedRequestID = "request-id";

        Assert.Equal(expectedExternalID, parameters.ExternalID);
        Assert.Equal(expectedName, parameters.Name);
        Assert.Equal(expectedPageNumber, parameters.PageNumber);
        Assert.Equal(expectedPageSize, parameters.PageSize);
        Assert.Equal(expectedSortBy, parameters.SortBy);
        Assert.Equal(expectedSortOrder, parameters.SortOrder);
        Assert.Equal(expectedCorrelationID, parameters.CorrelationID);
        Assert.Equal(expectedRequestID, parameters.RequestID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new OrganizationListParams { };

        Assert.Null(parameters.ExternalID);
        Assert.False(parameters.RawQueryData.ContainsKey("external_id"));
        Assert.Null(parameters.Name);
        Assert.False(parameters.RawQueryData.ContainsKey("name"));
        Assert.Null(parameters.PageNumber);
        Assert.False(parameters.RawQueryData.ContainsKey("page_number"));
        Assert.Null(parameters.PageSize);
        Assert.False(parameters.RawQueryData.ContainsKey("page_size"));
        Assert.Null(parameters.SortBy);
        Assert.False(parameters.RawQueryData.ContainsKey("sort_by"));
        Assert.Null(parameters.SortOrder);
        Assert.False(parameters.RawQueryData.ContainsKey("sort_order"));
        Assert.Null(parameters.CorrelationID);
        Assert.False(parameters.RawHeaderData.ContainsKey("correlation-id"));
        Assert.Null(parameters.RequestID);
        Assert.False(parameters.RawHeaderData.ContainsKey("request-id"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new OrganizationListParams
        {
            // Null should be interpreted as omitted for these properties
            ExternalID = null,
            Name = null,
            PageNumber = null,
            PageSize = null,
            SortBy = null,
            SortOrder = null,
            CorrelationID = null,
            RequestID = null,
        };

        Assert.Null(parameters.ExternalID);
        Assert.False(parameters.RawQueryData.ContainsKey("external_id"));
        Assert.Null(parameters.Name);
        Assert.False(parameters.RawQueryData.ContainsKey("name"));
        Assert.Null(parameters.PageNumber);
        Assert.False(parameters.RawQueryData.ContainsKey("page_number"));
        Assert.Null(parameters.PageSize);
        Assert.False(parameters.RawQueryData.ContainsKey("page_size"));
        Assert.Null(parameters.SortBy);
        Assert.False(parameters.RawQueryData.ContainsKey("sort_by"));
        Assert.Null(parameters.SortOrder);
        Assert.False(parameters.RawQueryData.ContainsKey("sort_order"));
        Assert.Null(parameters.CorrelationID);
        Assert.False(parameters.RawHeaderData.ContainsKey("correlation-id"));
        Assert.Null(parameters.RequestID);
        Assert.False(parameters.RawHeaderData.ContainsKey("request-id"));
    }

    [Fact]
    public void Url_Works()
    {
        OrganizationListParams parameters = new()
        {
            ExternalID = "external_id",
            Name = "name",
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = SortOrder.Asc,
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://sandbox.straddle.com/v1/organizations?external_id=external_id&name=name&page_number=0&page_size=0&sort_by=sort_by&sort_order=asc"
            ),
            url
        );
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        OrganizationListParams parameters = new()
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
        var parameters = new OrganizationListParams
        {
            ExternalID = "external_id",
            Name = "name",
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = SortOrder.Asc,
            CorrelationID = "correlation-id",
            RequestID = "request-id",
        };

        OrganizationListParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class SortOrderTest : TestBase
{
    [Theory]
    [InlineData(SortOrder.Asc)]
    [InlineData(SortOrder.Desc)]
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
