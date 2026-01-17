using System.Text.Json;
using Straddle.Core;
using Straddle.Models.Customers;

namespace Straddle.Tests.Models.Customers;

public class DeviceUnmaskedV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new DeviceUnmaskedV1 { IPAddress = "192.168.1.1" };

        string expectedIPAddress = "192.168.1.1";

        Assert.Equal(expectedIPAddress, model.IPAddress);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new DeviceUnmaskedV1 { IPAddress = "192.168.1.1" };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<DeviceUnmaskedV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new DeviceUnmaskedV1 { IPAddress = "192.168.1.1" };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<DeviceUnmaskedV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedIPAddress = "192.168.1.1";

        Assert.Equal(expectedIPAddress, deserialized.IPAddress);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new DeviceUnmaskedV1 { IPAddress = "192.168.1.1" };

        model.Validate();
    }
}
