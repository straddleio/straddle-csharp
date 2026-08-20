using System.Text.Json;
using Straddle.Core;
using Straddle.Models.Embed.Accounts;

namespace Straddle.Tests.Models.Embed.Accounts;

public class AddressV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AddressV1
        {
            City = "city",
            Line1 = "line1",
            PostalCode = "21029-1360",
            State = "SE",
            Country = "country",
            Line2 = "line2",
        };

        string expectedCity = "city";
        string expectedLine1 = "line1";
        string expectedPostalCode = "21029-1360";
        string expectedState = "SE";
        string expectedCountry = "country";
        string expectedLine2 = "line2";

        Assert.Equal(expectedCity, model.City);
        Assert.Equal(expectedLine1, model.Line1);
        Assert.Equal(expectedPostalCode, model.PostalCode);
        Assert.Equal(expectedState, model.State);
        Assert.Equal(expectedCountry, model.Country);
        Assert.Equal(expectedLine2, model.Line2);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AddressV1
        {
            City = "city",
            Line1 = "line1",
            PostalCode = "21029-1360",
            State = "SE",
            Country = "country",
            Line2 = "line2",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AddressV1>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AddressV1
        {
            City = "city",
            Line1 = "line1",
            PostalCode = "21029-1360",
            State = "SE",
            Country = "country",
            Line2 = "line2",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AddressV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedCity = "city";
        string expectedLine1 = "line1";
        string expectedPostalCode = "21029-1360";
        string expectedState = "SE";
        string expectedCountry = "country";
        string expectedLine2 = "line2";

        Assert.Equal(expectedCity, deserialized.City);
        Assert.Equal(expectedLine1, deserialized.Line1);
        Assert.Equal(expectedPostalCode, deserialized.PostalCode);
        Assert.Equal(expectedState, deserialized.State);
        Assert.Equal(expectedCountry, deserialized.Country);
        Assert.Equal(expectedLine2, deserialized.Line2);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AddressV1
        {
            City = "city",
            Line1 = "line1",
            PostalCode = "21029-1360",
            State = "SE",
            Country = "country",
            Line2 = "line2",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AddressV1
        {
            City = "city",
            Line1 = "line1",
            PostalCode = "21029-1360",
            State = "SE",
        };

        Assert.Null(model.Country);
        Assert.False(model.RawData.ContainsKey("country"));
        Assert.Null(model.Line2);
        Assert.False(model.RawData.ContainsKey("line2"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new AddressV1
        {
            City = "city",
            Line1 = "line1",
            PostalCode = "21029-1360",
            State = "SE",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new AddressV1
        {
            City = "city",
            Line1 = "line1",
            PostalCode = "21029-1360",
            State = "SE",

            Country = null,
            Line2 = null,
        };

        Assert.Null(model.Country);
        Assert.True(model.RawData.ContainsKey("country"));
        Assert.Null(model.Line2);
        Assert.True(model.RawData.ContainsKey("line2"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AddressV1
        {
            City = "city",
            Line1 = "line1",
            PostalCode = "21029-1360",
            State = "SE",

            Country = null,
            Line2 = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AddressV1
        {
            City = "city",
            Line1 = "line1",
            PostalCode = "21029-1360",
            State = "SE",
            Country = "country",
            Line2 = "line2",
        };

        AddressV1 copied = new(model);

        Assert.Equal(model, copied);
    }
}
