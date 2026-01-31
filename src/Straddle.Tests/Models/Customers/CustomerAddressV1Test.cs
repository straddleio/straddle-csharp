using System.Text.Json;
using Straddle.Core;
using Straddle.Models.Customers;

namespace Straddle.Tests.Models.Customers;

public class CustomerAddressV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerAddressV1
        {
            Address1 = "123 Main St",
            City = "Anytown",
            State = "CA",
            Zip = "12345",
            Address2 = "Apt 1",
        };

        string expectedAddress1 = "123 Main St";
        string expectedCity = "Anytown";
        string expectedState = "CA";
        string expectedZip = "12345";
        string expectedAddress2 = "Apt 1";

        Assert.Equal(expectedAddress1, model.Address1);
        Assert.Equal(expectedCity, model.City);
        Assert.Equal(expectedState, model.State);
        Assert.Equal(expectedZip, model.Zip);
        Assert.Equal(expectedAddress2, model.Address2);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CustomerAddressV1
        {
            Address1 = "123 Main St",
            City = "Anytown",
            State = "CA",
            Zip = "12345",
            Address2 = "Apt 1",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerAddressV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerAddressV1
        {
            Address1 = "123 Main St",
            City = "Anytown",
            State = "CA",
            Zip = "12345",
            Address2 = "Apt 1",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerAddressV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedAddress1 = "123 Main St";
        string expectedCity = "Anytown";
        string expectedState = "CA";
        string expectedZip = "12345";
        string expectedAddress2 = "Apt 1";

        Assert.Equal(expectedAddress1, deserialized.Address1);
        Assert.Equal(expectedCity, deserialized.City);
        Assert.Equal(expectedState, deserialized.State);
        Assert.Equal(expectedZip, deserialized.Zip);
        Assert.Equal(expectedAddress2, deserialized.Address2);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CustomerAddressV1
        {
            Address1 = "123 Main St",
            City = "Anytown",
            State = "CA",
            Zip = "12345",
            Address2 = "Apt 1",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new CustomerAddressV1
        {
            Address1 = "123 Main St",
            City = "Anytown",
            State = "CA",
            Zip = "12345",
        };

        Assert.Null(model.Address2);
        Assert.False(model.RawData.ContainsKey("address2"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new CustomerAddressV1
        {
            Address1 = "123 Main St",
            City = "Anytown",
            State = "CA",
            Zip = "12345",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new CustomerAddressV1
        {
            Address1 = "123 Main St",
            City = "Anytown",
            State = "CA",
            Zip = "12345",

            Address2 = null,
        };

        Assert.Null(model.Address2);
        Assert.True(model.RawData.ContainsKey("address2"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new CustomerAddressV1
        {
            Address1 = "123 Main St",
            City = "Anytown",
            State = "CA",
            Zip = "12345",

            Address2 = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new CustomerAddressV1
        {
            Address1 = "123 Main St",
            City = "Anytown",
            State = "CA",
            Zip = "12345",
            Address2 = "Apt 1",
        };

        CustomerAddressV1 copied = new(model);

        Assert.Equal(model, copied);
    }
}
