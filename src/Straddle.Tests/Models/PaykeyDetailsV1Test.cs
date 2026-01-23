using System.Text.Json;
using Straddle.Core;
using Straddle.Models;

namespace Straddle.Tests.Models;

public class PaykeyDetailsV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyDetailsV1
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Label = "Bank of America ****1234",
            Balance = 0,
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        string expectedCustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        string expectedLabel = "Bank of America ****1234";
        int expectedBalance = 0;

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedCustomerID, model.CustomerID);
        Assert.Equal(expectedLabel, model.Label);
        Assert.Equal(expectedBalance, model.Balance);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PaykeyDetailsV1
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Label = "Bank of America ****1234",
            Balance = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyDetailsV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyDetailsV1
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Label = "Bank of America ****1234",
            Balance = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyDetailsV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        string expectedCustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        string expectedLabel = "Bank of America ****1234";
        int expectedBalance = 0;

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedCustomerID, deserialized.CustomerID);
        Assert.Equal(expectedLabel, deserialized.Label);
        Assert.Equal(expectedBalance, deserialized.Balance);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PaykeyDetailsV1
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Label = "Bank of America ****1234",
            Balance = 0,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PaykeyDetailsV1
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Label = "Bank of America ****1234",
        };

        Assert.Null(model.Balance);
        Assert.False(model.RawData.ContainsKey("balance"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new PaykeyDetailsV1
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Label = "Bank of America ****1234",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new PaykeyDetailsV1
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Label = "Bank of America ****1234",

            Balance = null,
        };

        Assert.Null(model.Balance);
        Assert.True(model.RawData.ContainsKey("balance"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new PaykeyDetailsV1
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Label = "Bank of America ****1234",

            Balance = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new PaykeyDetailsV1
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Label = "Bank of America ****1234",
            Balance = 0,
        };

        PaykeyDetailsV1 copied = new(model);

        Assert.Equal(model, copied);
    }
}
