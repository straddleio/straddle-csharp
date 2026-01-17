using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models;

namespace Straddle.Tests.Models;

public class CustomerDetailsV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerDetailsV1
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerType = CustomerType.Individual,
            Email = "ron@swanson.com",
            Name = "Ron Swanson",
            Phone = "+1234567890",
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        ApiEnum<string, CustomerType> expectedCustomerType = CustomerType.Individual;
        string expectedEmail = "ron@swanson.com";
        string expectedName = "Ron Swanson";
        string expectedPhone = "+1234567890";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedCustomerType, model.CustomerType);
        Assert.Equal(expectedEmail, model.Email);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedPhone, model.Phone);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CustomerDetailsV1
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerType = CustomerType.Individual,
            Email = "ron@swanson.com",
            Name = "Ron Swanson",
            Phone = "+1234567890",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerDetailsV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerDetailsV1
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerType = CustomerType.Individual,
            Email = "ron@swanson.com",
            Name = "Ron Swanson",
            Phone = "+1234567890",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerDetailsV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        ApiEnum<string, CustomerType> expectedCustomerType = CustomerType.Individual;
        string expectedEmail = "ron@swanson.com";
        string expectedName = "Ron Swanson";
        string expectedPhone = "+1234567890";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedCustomerType, deserialized.CustomerType);
        Assert.Equal(expectedEmail, deserialized.Email);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedPhone, deserialized.Phone);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CustomerDetailsV1
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerType = CustomerType.Individual,
            Email = "ron@swanson.com",
            Name = "Ron Swanson",
            Phone = "+1234567890",
        };

        model.Validate();
    }
}

public class CustomerTypeTest : TestBase
{
    [Theory]
    [InlineData(CustomerType.Individual)]
    [InlineData(CustomerType.Business)]
    public void Validation_Works(CustomerType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CustomerType.Individual)]
    [InlineData(CustomerType.Business)]
    public void SerializationRoundtrip_Works(CustomerType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CustomerType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CustomerType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CustomerType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CustomerType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
