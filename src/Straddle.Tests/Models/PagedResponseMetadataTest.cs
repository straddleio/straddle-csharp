using System;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models;

namespace Straddle.Tests.Models;

public class PagedResponseMetadataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PagedResponseMetadata
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = SortOrder.Asc,
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
        ApiEnum<string, SortOrder> expectedSortOrder = SortOrder.Asc;
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
        var model = new PagedResponseMetadata
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = SortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PagedResponseMetadata>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PagedResponseMetadata
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = SortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PagedResponseMetadata>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedApiRequestTimestamp = DateTimeOffset.Parse(
            "2019-12-27T18:11:19.117Z"
        );
        int expectedMaxPageSize = 0;
        int expectedPageNumber = 0;
        int expectedPageSize = 0;
        string expectedSortBy = "sort_by";
        ApiEnum<string, SortOrder> expectedSortOrder = SortOrder.Asc;
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
        var model = new PagedResponseMetadata
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = SortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new PagedResponseMetadata
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = SortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };

        PagedResponseMetadata copied = new(model);

        Assert.Equal(model, copied);
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
