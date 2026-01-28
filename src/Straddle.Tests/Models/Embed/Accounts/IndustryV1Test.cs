using System.Text.Json;
using Straddle.Core;
using Straddle.Models.Embed.Accounts;

namespace Straddle.Tests.Models.Embed.Accounts;

public class IndustryV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new IndustryV1
        {
            Category = "category",
            Mcc = "mcc",
            Sector = "sector",
        };

        string expectedCategory = "category";
        string expectedMcc = "mcc";
        string expectedSector = "sector";

        Assert.Equal(expectedCategory, model.Category);
        Assert.Equal(expectedMcc, model.Mcc);
        Assert.Equal(expectedSector, model.Sector);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new IndustryV1
        {
            Category = "category",
            Mcc = "mcc",
            Sector = "sector",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<IndustryV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new IndustryV1
        {
            Category = "category",
            Mcc = "mcc",
            Sector = "sector",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<IndustryV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedCategory = "category";
        string expectedMcc = "mcc";
        string expectedSector = "sector";

        Assert.Equal(expectedCategory, deserialized.Category);
        Assert.Equal(expectedMcc, deserialized.Mcc);
        Assert.Equal(expectedSector, deserialized.Sector);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new IndustryV1
        {
            Category = "category",
            Mcc = "mcc",
            Sector = "sector",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new IndustryV1 { };

        Assert.Null(model.Category);
        Assert.False(model.RawData.ContainsKey("category"));
        Assert.Null(model.Mcc);
        Assert.False(model.RawData.ContainsKey("mcc"));
        Assert.Null(model.Sector);
        Assert.False(model.RawData.ContainsKey("sector"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new IndustryV1 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new IndustryV1
        {
            Category = null,
            Mcc = null,
            Sector = null,
        };

        Assert.Null(model.Category);
        Assert.True(model.RawData.ContainsKey("category"));
        Assert.Null(model.Mcc);
        Assert.True(model.RawData.ContainsKey("mcc"));
        Assert.Null(model.Sector);
        Assert.True(model.RawData.ContainsKey("sector"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new IndustryV1
        {
            Category = null,
            Mcc = null,
            Sector = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new IndustryV1
        {
            Category = "category",
            Mcc = "mcc",
            Sector = "sector",
        };

        IndustryV1 copied = new(model);

        Assert.Equal(model, copied);
    }
}
