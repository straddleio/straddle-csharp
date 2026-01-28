using System.Text.Json;
using Straddle.Core;
using Straddle.Models.Embed.Accounts;

namespace Straddle.Tests.Models.Embed.Accounts;

public class BusinessProfileV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new BusinessProfileV1
        {
            Name = "name",
            Website = "https://example.com",
            Address = new()
            {
                Address1 = "address1",
                City = "city",
                State = "SE",
                Zip = "zip",
                Address2 = "address2",
                Country = "country",
                Line1 = "line1",
                Line2 = "line2",
                PostalCode = "21029-1360",
            },
            Description = "description",
            Industry = new()
            {
                Category = "category",
                Mcc = "mcc",
                Sector = "sector",
            },
            LegalName = "legal_name",
            Phone = "+46991022",
            SupportChannels = new()
            {
                Email = "dev@stainless.com",
                Phone = "+46991022",
                Url = "https://example.com",
            },
            TaxID = "210297980",
            UseCase = "use_case",
        };

        string expectedName = "name";
        string expectedWebsite = "https://example.com";
        AddressV1 expectedAddress = new()
        {
            Address1 = "address1",
            City = "city",
            State = "SE",
            Zip = "zip",
            Address2 = "address2",
            Country = "country",
            Line1 = "line1",
            Line2 = "line2",
            PostalCode = "21029-1360",
        };
        string expectedDescription = "description";
        IndustryV1 expectedIndustry = new()
        {
            Category = "category",
            Mcc = "mcc",
            Sector = "sector",
        };
        string expectedLegalName = "legal_name";
        string expectedPhone = "+46991022";
        SupportChannelsV1 expectedSupportChannels = new()
        {
            Email = "dev@stainless.com",
            Phone = "+46991022",
            Url = "https://example.com",
        };
        string expectedTaxID = "210297980";
        string expectedUseCase = "use_case";

        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedWebsite, model.Website);
        Assert.Equal(expectedAddress, model.Address);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedIndustry, model.Industry);
        Assert.Equal(expectedLegalName, model.LegalName);
        Assert.Equal(expectedPhone, model.Phone);
        Assert.Equal(expectedSupportChannels, model.SupportChannels);
        Assert.Equal(expectedTaxID, model.TaxID);
        Assert.Equal(expectedUseCase, model.UseCase);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new BusinessProfileV1
        {
            Name = "name",
            Website = "https://example.com",
            Address = new()
            {
                Address1 = "address1",
                City = "city",
                State = "SE",
                Zip = "zip",
                Address2 = "address2",
                Country = "country",
                Line1 = "line1",
                Line2 = "line2",
                PostalCode = "21029-1360",
            },
            Description = "description",
            Industry = new()
            {
                Category = "category",
                Mcc = "mcc",
                Sector = "sector",
            },
            LegalName = "legal_name",
            Phone = "+46991022",
            SupportChannels = new()
            {
                Email = "dev@stainless.com",
                Phone = "+46991022",
                Url = "https://example.com",
            },
            TaxID = "210297980",
            UseCase = "use_case",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<BusinessProfileV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new BusinessProfileV1
        {
            Name = "name",
            Website = "https://example.com",
            Address = new()
            {
                Address1 = "address1",
                City = "city",
                State = "SE",
                Zip = "zip",
                Address2 = "address2",
                Country = "country",
                Line1 = "line1",
                Line2 = "line2",
                PostalCode = "21029-1360",
            },
            Description = "description",
            Industry = new()
            {
                Category = "category",
                Mcc = "mcc",
                Sector = "sector",
            },
            LegalName = "legal_name",
            Phone = "+46991022",
            SupportChannels = new()
            {
                Email = "dev@stainless.com",
                Phone = "+46991022",
                Url = "https://example.com",
            },
            TaxID = "210297980",
            UseCase = "use_case",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<BusinessProfileV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedName = "name";
        string expectedWebsite = "https://example.com";
        AddressV1 expectedAddress = new()
        {
            Address1 = "address1",
            City = "city",
            State = "SE",
            Zip = "zip",
            Address2 = "address2",
            Country = "country",
            Line1 = "line1",
            Line2 = "line2",
            PostalCode = "21029-1360",
        };
        string expectedDescription = "description";
        IndustryV1 expectedIndustry = new()
        {
            Category = "category",
            Mcc = "mcc",
            Sector = "sector",
        };
        string expectedLegalName = "legal_name";
        string expectedPhone = "+46991022";
        SupportChannelsV1 expectedSupportChannels = new()
        {
            Email = "dev@stainless.com",
            Phone = "+46991022",
            Url = "https://example.com",
        };
        string expectedTaxID = "210297980";
        string expectedUseCase = "use_case";

        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedWebsite, deserialized.Website);
        Assert.Equal(expectedAddress, deserialized.Address);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedIndustry, deserialized.Industry);
        Assert.Equal(expectedLegalName, deserialized.LegalName);
        Assert.Equal(expectedPhone, deserialized.Phone);
        Assert.Equal(expectedSupportChannels, deserialized.SupportChannels);
        Assert.Equal(expectedTaxID, deserialized.TaxID);
        Assert.Equal(expectedUseCase, deserialized.UseCase);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new BusinessProfileV1
        {
            Name = "name",
            Website = "https://example.com",
            Address = new()
            {
                Address1 = "address1",
                City = "city",
                State = "SE",
                Zip = "zip",
                Address2 = "address2",
                Country = "country",
                Line1 = "line1",
                Line2 = "line2",
                PostalCode = "21029-1360",
            },
            Description = "description",
            Industry = new()
            {
                Category = "category",
                Mcc = "mcc",
                Sector = "sector",
            },
            LegalName = "legal_name",
            Phone = "+46991022",
            SupportChannels = new()
            {
                Email = "dev@stainless.com",
                Phone = "+46991022",
                Url = "https://example.com",
            },
            TaxID = "210297980",
            UseCase = "use_case",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new BusinessProfileV1
        {
            Name = "name",
            Website = "https://example.com",
            Address = new()
            {
                Address1 = "address1",
                City = "city",
                State = "SE",
                Zip = "zip",
                Address2 = "address2",
                Country = "country",
                Line1 = "line1",
                Line2 = "line2",
                PostalCode = "21029-1360",
            },
            Description = "description",
            LegalName = "legal_name",
            Phone = "+46991022",
            TaxID = "210297980",
            UseCase = "use_case",
        };

        Assert.Null(model.Industry);
        Assert.False(model.RawData.ContainsKey("industry"));
        Assert.Null(model.SupportChannels);
        Assert.False(model.RawData.ContainsKey("support_channels"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new BusinessProfileV1
        {
            Name = "name",
            Website = "https://example.com",
            Address = new()
            {
                Address1 = "address1",
                City = "city",
                State = "SE",
                Zip = "zip",
                Address2 = "address2",
                Country = "country",
                Line1 = "line1",
                Line2 = "line2",
                PostalCode = "21029-1360",
            },
            Description = "description",
            LegalName = "legal_name",
            Phone = "+46991022",
            TaxID = "210297980",
            UseCase = "use_case",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new BusinessProfileV1
        {
            Name = "name",
            Website = "https://example.com",
            Address = new()
            {
                Address1 = "address1",
                City = "city",
                State = "SE",
                Zip = "zip",
                Address2 = "address2",
                Country = "country",
                Line1 = "line1",
                Line2 = "line2",
                PostalCode = "21029-1360",
            },
            Description = "description",
            LegalName = "legal_name",
            Phone = "+46991022",
            TaxID = "210297980",
            UseCase = "use_case",

            // Null should be interpreted as omitted for these properties
            Industry = null,
            SupportChannels = null,
        };

        Assert.Null(model.Industry);
        Assert.False(model.RawData.ContainsKey("industry"));
        Assert.Null(model.SupportChannels);
        Assert.False(model.RawData.ContainsKey("support_channels"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new BusinessProfileV1
        {
            Name = "name",
            Website = "https://example.com",
            Address = new()
            {
                Address1 = "address1",
                City = "city",
                State = "SE",
                Zip = "zip",
                Address2 = "address2",
                Country = "country",
                Line1 = "line1",
                Line2 = "line2",
                PostalCode = "21029-1360",
            },
            Description = "description",
            LegalName = "legal_name",
            Phone = "+46991022",
            TaxID = "210297980",
            UseCase = "use_case",

            // Null should be interpreted as omitted for these properties
            Industry = null,
            SupportChannels = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new BusinessProfileV1
        {
            Name = "name",
            Website = "https://example.com",
            Industry = new()
            {
                Category = "category",
                Mcc = "mcc",
                Sector = "sector",
            },
            SupportChannels = new()
            {
                Email = "dev@stainless.com",
                Phone = "+46991022",
                Url = "https://example.com",
            },
        };

        Assert.Null(model.Address);
        Assert.False(model.RawData.ContainsKey("address"));
        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.LegalName);
        Assert.False(model.RawData.ContainsKey("legal_name"));
        Assert.Null(model.Phone);
        Assert.False(model.RawData.ContainsKey("phone"));
        Assert.Null(model.TaxID);
        Assert.False(model.RawData.ContainsKey("tax_id"));
        Assert.Null(model.UseCase);
        Assert.False(model.RawData.ContainsKey("use_case"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new BusinessProfileV1
        {
            Name = "name",
            Website = "https://example.com",
            Industry = new()
            {
                Category = "category",
                Mcc = "mcc",
                Sector = "sector",
            },
            SupportChannels = new()
            {
                Email = "dev@stainless.com",
                Phone = "+46991022",
                Url = "https://example.com",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new BusinessProfileV1
        {
            Name = "name",
            Website = "https://example.com",
            Industry = new()
            {
                Category = "category",
                Mcc = "mcc",
                Sector = "sector",
            },
            SupportChannels = new()
            {
                Email = "dev@stainless.com",
                Phone = "+46991022",
                Url = "https://example.com",
            },

            Address = null,
            Description = null,
            LegalName = null,
            Phone = null,
            TaxID = null,
            UseCase = null,
        };

        Assert.Null(model.Address);
        Assert.True(model.RawData.ContainsKey("address"));
        Assert.Null(model.Description);
        Assert.True(model.RawData.ContainsKey("description"));
        Assert.Null(model.LegalName);
        Assert.True(model.RawData.ContainsKey("legal_name"));
        Assert.Null(model.Phone);
        Assert.True(model.RawData.ContainsKey("phone"));
        Assert.Null(model.TaxID);
        Assert.True(model.RawData.ContainsKey("tax_id"));
        Assert.Null(model.UseCase);
        Assert.True(model.RawData.ContainsKey("use_case"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new BusinessProfileV1
        {
            Name = "name",
            Website = "https://example.com",
            Industry = new()
            {
                Category = "category",
                Mcc = "mcc",
                Sector = "sector",
            },
            SupportChannels = new()
            {
                Email = "dev@stainless.com",
                Phone = "+46991022",
                Url = "https://example.com",
            },

            Address = null,
            Description = null,
            LegalName = null,
            Phone = null,
            TaxID = null,
            UseCase = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new BusinessProfileV1
        {
            Name = "name",
            Website = "https://example.com",
            Address = new()
            {
                Address1 = "address1",
                City = "city",
                State = "SE",
                Zip = "zip",
                Address2 = "address2",
                Country = "country",
                Line1 = "line1",
                Line2 = "line2",
                PostalCode = "21029-1360",
            },
            Description = "description",
            Industry = new()
            {
                Category = "category",
                Mcc = "mcc",
                Sector = "sector",
            },
            LegalName = "legal_name",
            Phone = "+46991022",
            SupportChannels = new()
            {
                Email = "dev@stainless.com",
                Phone = "+46991022",
                Url = "https://example.com",
            },
            TaxID = "210297980",
            UseCase = "use_case",
        };

        BusinessProfileV1 copied = new(model);

        Assert.Equal(model, copied);
    }
}
