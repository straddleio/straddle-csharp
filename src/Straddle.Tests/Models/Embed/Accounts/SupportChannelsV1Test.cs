using System.Text.Json;
using Straddle.Core;
using Straddle.Models.Embed.Accounts;

namespace Straddle.Tests.Models.Embed.Accounts;

public class SupportChannelsV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new SupportChannelsV1
        {
            Email = "dev@stainless.com",
            Phone = "+46991022",
            Url = "https://example.com",
        };

        string expectedEmail = "dev@stainless.com";
        string expectedPhone = "+46991022";
        string expectedUrl = "https://example.com";

        Assert.Equal(expectedEmail, model.Email);
        Assert.Equal(expectedPhone, model.Phone);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new SupportChannelsV1
        {
            Email = "dev@stainless.com",
            Phone = "+46991022",
            Url = "https://example.com",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<SupportChannelsV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new SupportChannelsV1
        {
            Email = "dev@stainless.com",
            Phone = "+46991022",
            Url = "https://example.com",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<SupportChannelsV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedEmail = "dev@stainless.com";
        string expectedPhone = "+46991022";
        string expectedUrl = "https://example.com";

        Assert.Equal(expectedEmail, deserialized.Email);
        Assert.Equal(expectedPhone, deserialized.Phone);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new SupportChannelsV1
        {
            Email = "dev@stainless.com",
            Phone = "+46991022",
            Url = "https://example.com",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new SupportChannelsV1 { };

        Assert.Null(model.Email);
        Assert.False(model.RawData.ContainsKey("email"));
        Assert.Null(model.Phone);
        Assert.False(model.RawData.ContainsKey("phone"));
        Assert.Null(model.Url);
        Assert.False(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new SupportChannelsV1 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new SupportChannelsV1
        {
            Email = null,
            Phone = null,
            Url = null,
        };

        Assert.Null(model.Email);
        Assert.True(model.RawData.ContainsKey("email"));
        Assert.Null(model.Phone);
        Assert.True(model.RawData.ContainsKey("phone"));
        Assert.Null(model.Url);
        Assert.True(model.RawData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new SupportChannelsV1
        {
            Email = null,
            Phone = null,
            Url = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new SupportChannelsV1
        {
            Email = "dev@stainless.com",
            Phone = "+46991022",
            Url = "https://example.com",
        };

        SupportChannelsV1 copied = new(model);

        Assert.Equal(model, copied);
    }
}
