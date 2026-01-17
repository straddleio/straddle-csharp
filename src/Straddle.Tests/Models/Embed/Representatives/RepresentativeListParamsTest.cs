using System;
using System.Net.Http;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Embed.Representatives;

namespace Straddle.Tests.Models.Embed.Representatives;

public class RepresentativeListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new RepresentativeListParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Level = Level.Account,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            PageNumber = 0,
            PageSize = 0,
            PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            SortBy = "sort_by",
            SortOrder = SortOrder.Asc,
            CorrelationID = "correlation-id",
            RequestID = "request-id",
        };

        string expectedAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        ApiEnum<string, Level> expectedLevel = Level.Account;
        string expectedOrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedPageNumber = 0;
        int expectedPageSize = 0;
        string expectedPlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        string expectedSortBy = "sort_by";
        ApiEnum<string, SortOrder> expectedSortOrder = SortOrder.Asc;
        string expectedCorrelationID = "correlation-id";
        string expectedRequestID = "request-id";

        Assert.Equal(expectedAccountID, parameters.AccountID);
        Assert.Equal(expectedLevel, parameters.Level);
        Assert.Equal(expectedOrganizationID, parameters.OrganizationID);
        Assert.Equal(expectedPageNumber, parameters.PageNumber);
        Assert.Equal(expectedPageSize, parameters.PageSize);
        Assert.Equal(expectedPlatformID, parameters.PlatformID);
        Assert.Equal(expectedSortBy, parameters.SortBy);
        Assert.Equal(expectedSortOrder, parameters.SortOrder);
        Assert.Equal(expectedCorrelationID, parameters.CorrelationID);
        Assert.Equal(expectedRequestID, parameters.RequestID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new RepresentativeListParams { };

        Assert.Null(parameters.AccountID);
        Assert.False(parameters.RawQueryData.ContainsKey("account_id"));
        Assert.Null(parameters.Level);
        Assert.False(parameters.RawQueryData.ContainsKey("level"));
        Assert.Null(parameters.OrganizationID);
        Assert.False(parameters.RawQueryData.ContainsKey("organization_id"));
        Assert.Null(parameters.PageNumber);
        Assert.False(parameters.RawQueryData.ContainsKey("page_number"));
        Assert.Null(parameters.PageSize);
        Assert.False(parameters.RawQueryData.ContainsKey("page_size"));
        Assert.Null(parameters.PlatformID);
        Assert.False(parameters.RawQueryData.ContainsKey("platform_id"));
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
        var parameters = new RepresentativeListParams
        {
            // Null should be interpreted as omitted for these properties
            AccountID = null,
            Level = null,
            OrganizationID = null,
            PageNumber = null,
            PageSize = null,
            PlatformID = null,
            SortBy = null,
            SortOrder = null,
            CorrelationID = null,
            RequestID = null,
        };

        Assert.Null(parameters.AccountID);
        Assert.False(parameters.RawQueryData.ContainsKey("account_id"));
        Assert.Null(parameters.Level);
        Assert.False(parameters.RawQueryData.ContainsKey("level"));
        Assert.Null(parameters.OrganizationID);
        Assert.False(parameters.RawQueryData.ContainsKey("organization_id"));
        Assert.Null(parameters.PageNumber);
        Assert.False(parameters.RawQueryData.ContainsKey("page_number"));
        Assert.Null(parameters.PageSize);
        Assert.False(parameters.RawQueryData.ContainsKey("page_size"));
        Assert.Null(parameters.PlatformID);
        Assert.False(parameters.RawQueryData.ContainsKey("platform_id"));
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
        RepresentativeListParams parameters = new()
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Level = Level.Account,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            PageNumber = 0,
            PageSize = 0,
            PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            SortBy = "sort_by",
            SortOrder = SortOrder.Asc,
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.Equal(
            new Uri(
                "https://sandbox.straddle.com/v1/representatives?account_id=182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e&level=account&organization_id=182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e&page_number=0&page_size=0&platform_id=182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e&sort_by=sort_by&sort_order=asc"
            ),
            url
        );
    }

    [Fact]
    public void AddHeadersToRequest_Works()
    {
        HttpRequestMessage requestMessage = new();
        RepresentativeListParams parameters = new()
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
        var parameters = new RepresentativeListParams
        {
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Level = Level.Account,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            PageNumber = 0,
            PageSize = 0,
            PlatformID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            SortBy = "sort_by",
            SortOrder = SortOrder.Asc,
            CorrelationID = "correlation-id",
            RequestID = "request-id",
        };

        RepresentativeListParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class LevelTest : TestBase
{
    [Theory]
    [InlineData(Level.Account)]
    [InlineData(Level.Platform)]
    public void Validation_Works(Level rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Level> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Level>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Level.Account)]
    [InlineData(Level.Platform)]
    public void SerializationRoundtrip_Works(Level rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Level> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Level>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Level>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Level>>(
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
