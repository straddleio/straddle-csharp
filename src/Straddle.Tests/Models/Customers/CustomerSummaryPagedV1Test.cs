using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Customers;

namespace Straddle.Tests.Models.Customers;

public class CustomerSummaryPagedV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerSummaryPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Email = "dev@stainless.com",
                    Name = "name",
                    Phone = "+46991022",
                    Status = DataStatus.Pending,
                    Type = DataType.Individual,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    ExternalID = "external_id",
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
            ResponseType = ResponseType.Object,
        };

        List<Data> expectedData =
        [
            new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "dev@stainless.com",
                Name = "name",
                Phone = "+46991022",
                Status = DataStatus.Pending,
                Type = DataType.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
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
        ApiEnum<string, ResponseType> expectedResponseType = ResponseType.Object;

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
        var model = new CustomerSummaryPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Email = "dev@stainless.com",
                    Name = "name",
                    Phone = "+46991022",
                    Status = DataStatus.Pending,
                    Type = DataType.Individual,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    ExternalID = "external_id",
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
            ResponseType = ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerSummaryPagedV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerSummaryPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Email = "dev@stainless.com",
                    Name = "name",
                    Phone = "+46991022",
                    Status = DataStatus.Pending,
                    Type = DataType.Individual,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    ExternalID = "external_id",
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
            ResponseType = ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerSummaryPagedV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "dev@stainless.com",
                Name = "name",
                Phone = "+46991022",
                Status = DataStatus.Pending,
                Type = DataType.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
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
        ApiEnum<string, ResponseType> expectedResponseType = ResponseType.Object;

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
        var model = new CustomerSummaryPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Email = "dev@stainless.com",
                    Name = "name",
                    Phone = "+46991022",
                    Status = DataStatus.Pending,
                    Type = DataType.Individual,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    ExternalID = "external_id",
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
            ResponseType = ResponseType.Object,
        };

        model.Validate();
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
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "dev@stainless.com",
            Name = "name",
            Phone = "+46991022",
            Status = DataStatus.Pending,
            Type = DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedEmail = "dev@stainless.com";
        string expectedName = "name";
        string expectedPhone = "+46991022";
        ApiEnum<string, DataStatus> expectedStatus = DataStatus.Pending;
        ApiEnum<string, DataType> expectedType = DataType.Individual;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedEmail, model.Email);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedPhone, model.Phone);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
        Assert.Equal(expectedExternalID, model.ExternalID);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "dev@stainless.com",
            Name = "name",
            Phone = "+46991022",
            Status = DataStatus.Pending,
            Type = DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
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
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "dev@stainless.com",
            Name = "name",
            Phone = "+46991022",
            Status = DataStatus.Pending,
            Type = DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedEmail = "dev@stainless.com";
        string expectedName = "name";
        string expectedPhone = "+46991022";
        ApiEnum<string, DataStatus> expectedStatus = DataStatus.Pending;
        ApiEnum<string, DataType> expectedType = DataType.Individual;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedEmail, deserialized.Email);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedPhone, deserialized.Phone);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
        Assert.Equal(expectedExternalID, deserialized.ExternalID);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "dev@stainless.com",
            Name = "name",
            Phone = "+46991022",
            Status = DataStatus.Pending,
            Type = DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "dev@stainless.com",
            Name = "name",
            Phone = "+46991022",
            Status = DataStatus.Pending,
            Type = DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        Assert.Null(model.ExternalID);
        Assert.False(model.RawData.ContainsKey("external_id"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "dev@stainless.com",
            Name = "name",
            Phone = "+46991022",
            Status = DataStatus.Pending,
            Type = DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "dev@stainless.com",
            Name = "name",
            Phone = "+46991022",
            Status = DataStatus.Pending,
            Type = DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),

            ExternalID = null,
        };

        Assert.Null(model.ExternalID);
        Assert.True(model.RawData.ContainsKey("external_id"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "dev@stainless.com",
            Name = "name",
            Phone = "+46991022",
            Status = DataStatus.Pending,
            Type = DataType.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),

            ExternalID = null,
        };

        model.Validate();
    }
}

public class DataStatusTest : TestBase
{
    [Theory]
    [InlineData(DataStatus.Pending)]
    [InlineData(DataStatus.Review)]
    [InlineData(DataStatus.Verified)]
    [InlineData(DataStatus.Inactive)]
    [InlineData(DataStatus.Rejected)]
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
    [InlineData(DataStatus.Pending)]
    [InlineData(DataStatus.Review)]
    [InlineData(DataStatus.Verified)]
    [InlineData(DataStatus.Inactive)]
    [InlineData(DataStatus.Rejected)]
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

public class DataTypeTest : TestBase
{
    [Theory]
    [InlineData(DataType.Individual)]
    [InlineData(DataType.Business)]
    [InlineData(DataType.Individual1)]
    [InlineData(DataType.Business1)]
    public void Validation_Works(DataType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(DataType.Individual)]
    [InlineData(DataType.Business)]
    [InlineData(DataType.Individual1)]
    [InlineData(DataType.Business1)]
    public void SerializationRoundtrip_Works(DataType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataType>>(
            json,
            ModelBase.SerializerOptions
        );

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
}

public class MetaSortOrderTest : TestBase
{
    [Theory]
    [InlineData(MetaSortOrder.Asc)]
    [InlineData(MetaSortOrder.Desc)]
    [InlineData(MetaSortOrder.Asc1)]
    [InlineData(MetaSortOrder.Desc1)]
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
    [InlineData(MetaSortOrder.Asc1)]
    [InlineData(MetaSortOrder.Desc1)]
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

public class ResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(ResponseType.Object)]
    [InlineData(ResponseType.Array)]
    [InlineData(ResponseType.Error)]
    [InlineData(ResponseType.None)]
    [InlineData(ResponseType.Object1)]
    [InlineData(ResponseType.Array1)]
    [InlineData(ResponseType.Error1)]
    [InlineData(ResponseType.None1)]
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
    [InlineData(ResponseType.Object1)]
    [InlineData(ResponseType.Array1)]
    [InlineData(ResponseType.Error1)]
    [InlineData(ResponseType.None1)]
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
