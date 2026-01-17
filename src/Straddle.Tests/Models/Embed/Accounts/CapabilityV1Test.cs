using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Embed.Accounts;

namespace Straddle.Tests.Models.Embed.Accounts;

public class CapabilityV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CapabilityV1 { CapabilityStatus = CapabilityStatus.Active };

        ApiEnum<string, CapabilityStatus> expectedCapabilityStatus = CapabilityStatus.Active;

        Assert.Equal(expectedCapabilityStatus, model.CapabilityStatus);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CapabilityV1 { CapabilityStatus = CapabilityStatus.Active };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CapabilityV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CapabilityV1 { CapabilityStatus = CapabilityStatus.Active };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CapabilityV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, CapabilityStatus> expectedCapabilityStatus = CapabilityStatus.Active;

        Assert.Equal(expectedCapabilityStatus, deserialized.CapabilityStatus);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CapabilityV1 { CapabilityStatus = CapabilityStatus.Active };

        model.Validate();
    }
}

public class CapabilityStatusTest : TestBase
{
    [Theory]
    [InlineData(CapabilityStatus.Active)]
    [InlineData(CapabilityStatus.Inactive)]
    public void Validation_Works(CapabilityStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CapabilityStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CapabilityStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CapabilityStatus.Active)]
    [InlineData(CapabilityStatus.Inactive)]
    public void SerializationRoundtrip_Works(CapabilityStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CapabilityStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CapabilityStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, CapabilityStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, CapabilityStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
