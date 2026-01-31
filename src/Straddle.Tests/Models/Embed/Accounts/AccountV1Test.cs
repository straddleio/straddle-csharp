using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models;
using Straddle.Models.Embed.Accounts;

namespace Straddle.Tests.Models.Embed.Accounts;

public class AccountV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                AccessLevel = AccountV1DataAccessLevel.Standard,
                OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Status = AccountV1DataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = AccountV1DataStatusDetailReason.Unverified,
                    Source = AccountV1DataStatusDetailSource.Watchtower,
                },
                Type = AccountV1DataType.Business,
                BusinessProfile = new()
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
                },
                Capabilities = new()
                {
                    ConsentTypes = new()
                    {
                        Internet = new(CapabilityStatus.Active),
                        SignedAgreement = new(CapabilityStatus.Active),
                    },
                    CustomerTypes = new()
                    {
                        Businesses = new(CapabilityStatus.Active),
                        Individuals = new(CapabilityStatus.Active),
                    },
                    PaymentTypes = new()
                    {
                        Charges = new(CapabilityStatus.Active),
                        Payouts = new(CapabilityStatus.Active),
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
                Settings = new()
                {
                    Charges = new()
                    {
                        DailyAmount = 0,
                        FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                        LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        MaxAmount = 0,
                        MonthlyAmount = 0,
                        MonthlyCount = 0,
                    },
                    Payouts = new()
                    {
                        DailyAmount = 0,
                        FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                        LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        MaxAmount = 0,
                        MonthlyAmount = 0,
                        MonthlyCount = 0,
                    },
                },
                TermsOfService = new()
                {
                    AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    AgreementType = AgreementType.Embedded,
                    AgreementUrl = "agreement_url",
                    AcceptedIP = "accepted_ip",
                    AcceptedUserAgent = "accepted_user_agent",
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = AccountV1ResponseType.Object,
        };

        AccountV1Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = AccountV1DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = AccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = AccountV1DataStatusDetailReason.Unverified,
                Source = AccountV1DataStatusDetailSource.Watchtower,
            },
            Type = AccountV1DataType.Business,
            BusinessProfile = new()
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
            },
            Capabilities = new()
            {
                ConsentTypes = new()
                {
                    Internet = new(CapabilityStatus.Active),
                    SignedAgreement = new(CapabilityStatus.Active),
                },
                CustomerTypes = new()
                {
                    Businesses = new(CapabilityStatus.Active),
                    Individuals = new(CapabilityStatus.Active),
                },
                PaymentTypes = new()
                {
                    Charges = new(CapabilityStatus.Active),
                    Payouts = new(CapabilityStatus.Active),
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            Settings = new()
            {
                Charges = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
            },
            TermsOfService = new()
            {
                AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                AgreementType = AgreementType.Embedded,
                AgreementUrl = "agreement_url",
                AcceptedIP = "accepted_ip",
                AcceptedUserAgent = "accepted_user_agent",
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, AccountV1ResponseType> expectedResponseType = AccountV1ResponseType.Object;

        Assert.Equal(expectedData, model.Data);
        Assert.Equal(expectedMeta, model.Meta);
        Assert.Equal(expectedResponseType, model.ResponseType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AccountV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                AccessLevel = AccountV1DataAccessLevel.Standard,
                OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Status = AccountV1DataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = AccountV1DataStatusDetailReason.Unverified,
                    Source = AccountV1DataStatusDetailSource.Watchtower,
                },
                Type = AccountV1DataType.Business,
                BusinessProfile = new()
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
                },
                Capabilities = new()
                {
                    ConsentTypes = new()
                    {
                        Internet = new(CapabilityStatus.Active),
                        SignedAgreement = new(CapabilityStatus.Active),
                    },
                    CustomerTypes = new()
                    {
                        Businesses = new(CapabilityStatus.Active),
                        Individuals = new(CapabilityStatus.Active),
                    },
                    PaymentTypes = new()
                    {
                        Charges = new(CapabilityStatus.Active),
                        Payouts = new(CapabilityStatus.Active),
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
                Settings = new()
                {
                    Charges = new()
                    {
                        DailyAmount = 0,
                        FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                        LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        MaxAmount = 0,
                        MonthlyAmount = 0,
                        MonthlyCount = 0,
                    },
                    Payouts = new()
                    {
                        DailyAmount = 0,
                        FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                        LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        MaxAmount = 0,
                        MonthlyAmount = 0,
                        MonthlyCount = 0,
                    },
                },
                TermsOfService = new()
                {
                    AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    AgreementType = AgreementType.Embedded,
                    AgreementUrl = "agreement_url",
                    AcceptedIP = "accepted_ip",
                    AcceptedUserAgent = "accepted_user_agent",
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = AccountV1ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                AccessLevel = AccountV1DataAccessLevel.Standard,
                OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Status = AccountV1DataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = AccountV1DataStatusDetailReason.Unverified,
                    Source = AccountV1DataStatusDetailSource.Watchtower,
                },
                Type = AccountV1DataType.Business,
                BusinessProfile = new()
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
                },
                Capabilities = new()
                {
                    ConsentTypes = new()
                    {
                        Internet = new(CapabilityStatus.Active),
                        SignedAgreement = new(CapabilityStatus.Active),
                    },
                    CustomerTypes = new()
                    {
                        Businesses = new(CapabilityStatus.Active),
                        Individuals = new(CapabilityStatus.Active),
                    },
                    PaymentTypes = new()
                    {
                        Charges = new(CapabilityStatus.Active),
                        Payouts = new(CapabilityStatus.Active),
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
                Settings = new()
                {
                    Charges = new()
                    {
                        DailyAmount = 0,
                        FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                        LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        MaxAmount = 0,
                        MonthlyAmount = 0,
                        MonthlyCount = 0,
                    },
                    Payouts = new()
                    {
                        DailyAmount = 0,
                        FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                        LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        MaxAmount = 0,
                        MonthlyAmount = 0,
                        MonthlyCount = 0,
                    },
                },
                TermsOfService = new()
                {
                    AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    AgreementType = AgreementType.Embedded,
                    AgreementUrl = "agreement_url",
                    AcceptedIP = "accepted_ip",
                    AcceptedUserAgent = "accepted_user_agent",
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = AccountV1ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        AccountV1Data expectedData = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = AccountV1DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = AccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = AccountV1DataStatusDetailReason.Unverified,
                Source = AccountV1DataStatusDetailSource.Watchtower,
            },
            Type = AccountV1DataType.Business,
            BusinessProfile = new()
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
            },
            Capabilities = new()
            {
                ConsentTypes = new()
                {
                    Internet = new(CapabilityStatus.Active),
                    SignedAgreement = new(CapabilityStatus.Active),
                },
                CustomerTypes = new()
                {
                    Businesses = new(CapabilityStatus.Active),
                    Individuals = new(CapabilityStatus.Active),
                },
                PaymentTypes = new()
                {
                    Charges = new(CapabilityStatus.Active),
                    Payouts = new(CapabilityStatus.Active),
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            Settings = new()
            {
                Charges = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
            },
            TermsOfService = new()
            {
                AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                AgreementType = AgreementType.Embedded,
                AgreementUrl = "agreement_url",
                AcceptedIP = "accepted_ip",
                AcceptedUserAgent = "accepted_user_agent",
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, AccountV1ResponseType> expectedResponseType = AccountV1ResponseType.Object;

        Assert.Equal(expectedData, deserialized.Data);
        Assert.Equal(expectedMeta, deserialized.Meta);
        Assert.Equal(expectedResponseType, deserialized.ResponseType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AccountV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                AccessLevel = AccountV1DataAccessLevel.Standard,
                OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Status = AccountV1DataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = AccountV1DataStatusDetailReason.Unverified,
                    Source = AccountV1DataStatusDetailSource.Watchtower,
                },
                Type = AccountV1DataType.Business,
                BusinessProfile = new()
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
                },
                Capabilities = new()
                {
                    ConsentTypes = new()
                    {
                        Internet = new(CapabilityStatus.Active),
                        SignedAgreement = new(CapabilityStatus.Active),
                    },
                    CustomerTypes = new()
                    {
                        Businesses = new(CapabilityStatus.Active),
                        Individuals = new(CapabilityStatus.Active),
                    },
                    PaymentTypes = new()
                    {
                        Charges = new(CapabilityStatus.Active),
                        Payouts = new(CapabilityStatus.Active),
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
                Settings = new()
                {
                    Charges = new()
                    {
                        DailyAmount = 0,
                        FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                        LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        MaxAmount = 0,
                        MonthlyAmount = 0,
                        MonthlyCount = 0,
                    },
                    Payouts = new()
                    {
                        DailyAmount = 0,
                        FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                        LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        MaxAmount = 0,
                        MonthlyAmount = 0,
                        MonthlyCount = 0,
                    },
                },
                TermsOfService = new()
                {
                    AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    AgreementType = AgreementType.Embedded,
                    AgreementUrl = "agreement_url",
                    AcceptedIP = "accepted_ip",
                    AcceptedUserAgent = "accepted_user_agent",
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = AccountV1ResponseType.Object,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AccountV1
        {
            Data = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                AccessLevel = AccountV1DataAccessLevel.Standard,
                OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Status = AccountV1DataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = AccountV1DataStatusDetailReason.Unverified,
                    Source = AccountV1DataStatusDetailSource.Watchtower,
                },
                Type = AccountV1DataType.Business,
                BusinessProfile = new()
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
                },
                Capabilities = new()
                {
                    ConsentTypes = new()
                    {
                        Internet = new(CapabilityStatus.Active),
                        SignedAgreement = new(CapabilityStatus.Active),
                    },
                    CustomerTypes = new()
                    {
                        Businesses = new(CapabilityStatus.Active),
                        Individuals = new(CapabilityStatus.Active),
                    },
                    PaymentTypes = new()
                    {
                        Charges = new(CapabilityStatus.Active),
                        Payouts = new(CapabilityStatus.Active),
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
                Settings = new()
                {
                    Charges = new()
                    {
                        DailyAmount = 0,
                        FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                        LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        MaxAmount = 0,
                        MonthlyAmount = 0,
                        MonthlyCount = 0,
                    },
                    Payouts = new()
                    {
                        DailyAmount = 0,
                        FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                        LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        MaxAmount = 0,
                        MonthlyAmount = 0,
                        MonthlyCount = 0,
                    },
                },
                TermsOfService = new()
                {
                    AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    AgreementType = AgreementType.Embedded,
                    AgreementUrl = "agreement_url",
                    AcceptedIP = "accepted_ip",
                    AcceptedUserAgent = "accepted_user_agent",
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = AccountV1ResponseType.Object,
        };

        AccountV1 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountV1DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = AccountV1DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = AccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = AccountV1DataStatusDetailReason.Unverified,
                Source = AccountV1DataStatusDetailSource.Watchtower,
            },
            Type = AccountV1DataType.Business,
            BusinessProfile = new()
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
            },
            Capabilities = new()
            {
                ConsentTypes = new()
                {
                    Internet = new(CapabilityStatus.Active),
                    SignedAgreement = new(CapabilityStatus.Active),
                },
                CustomerTypes = new()
                {
                    Businesses = new(CapabilityStatus.Active),
                    Individuals = new(CapabilityStatus.Active),
                },
                PaymentTypes = new()
                {
                    Charges = new(CapabilityStatus.Active),
                    Payouts = new(CapabilityStatus.Active),
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            Settings = new()
            {
                Charges = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
            },
            TermsOfService = new()
            {
                AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                AgreementType = AgreementType.Embedded,
                AgreementUrl = "agreement_url",
                AcceptedIP = "accepted_ip",
                AcceptedUserAgent = "accepted_user_agent",
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        ApiEnum<string, AccountV1DataAccessLevel> expectedAccessLevel =
            AccountV1DataAccessLevel.Standard;
        string expectedOrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        ApiEnum<string, AccountV1DataStatus> expectedStatus = AccountV1DataStatus.Created;
        AccountV1DataStatusDetail expectedStatusDetail = new()
        {
            Code = "code",
            Message = "message",
            Reason = AccountV1DataStatusDetailReason.Unverified,
            Source = AccountV1DataStatusDetailSource.Watchtower,
        };
        ApiEnum<string, AccountV1DataType> expectedType = AccountV1DataType.Business;
        BusinessProfileV1 expectedBusinessProfile = new()
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
        AccountV1DataCapabilities expectedCapabilities = new()
        {
            ConsentTypes = new()
            {
                Internet = new(CapabilityStatus.Active),
                SignedAgreement = new(CapabilityStatus.Active),
            },
            CustomerTypes = new()
            {
                Businesses = new(CapabilityStatus.Active),
                Individuals = new(CapabilityStatus.Active),
            },
            PaymentTypes = new()
            {
                Charges = new(CapabilityStatus.Active),
                Payouts = new(CapabilityStatus.Active),
            },
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";
        Dictionary<string, string?> expectedMetadata = new() { { "foo", "string" } };
        AccountV1DataSettings expectedSettings = new()
        {
            Charges = new()
            {
                DailyAmount = 0,
                FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            Payouts = new()
            {
                DailyAmount = 0,
                FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
        };
        TermsOfServiceV1 expectedTermsOfService = new()
        {
            AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            AgreementType = AgreementType.Embedded,
            AgreementUrl = "agreement_url",
            AcceptedIP = "accepted_ip",
            AcceptedUserAgent = "accepted_user_agent",
        };
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAccessLevel, model.AccessLevel);
        Assert.Equal(expectedOrganizationID, model.OrganizationID);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedStatusDetail, model.StatusDetail);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedBusinessProfile, model.BusinessProfile);
        Assert.Equal(expectedCapabilities, model.Capabilities);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedExternalID, model.ExternalID);
        Assert.NotNull(model.Metadata);
        Assert.Equal(expectedMetadata.Count, model.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(model.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Metadata[item.Key]);
        }
        Assert.Equal(expectedSettings, model.Settings);
        Assert.Equal(expectedTermsOfService, model.TermsOfService);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = AccountV1DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = AccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = AccountV1DataStatusDetailReason.Unverified,
                Source = AccountV1DataStatusDetailSource.Watchtower,
            },
            Type = AccountV1DataType.Business,
            BusinessProfile = new()
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
            },
            Capabilities = new()
            {
                ConsentTypes = new()
                {
                    Internet = new(CapabilityStatus.Active),
                    SignedAgreement = new(CapabilityStatus.Active),
                },
                CustomerTypes = new()
                {
                    Businesses = new(CapabilityStatus.Active),
                    Individuals = new(CapabilityStatus.Active),
                },
                PaymentTypes = new()
                {
                    Charges = new(CapabilityStatus.Active),
                    Payouts = new(CapabilityStatus.Active),
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            Settings = new()
            {
                Charges = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
            },
            TermsOfService = new()
            {
                AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                AgreementType = AgreementType.Embedded,
                AgreementUrl = "agreement_url",
                AcceptedIP = "accepted_ip",
                AcceptedUserAgent = "accepted_user_agent",
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1Data>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = AccountV1DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = AccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = AccountV1DataStatusDetailReason.Unverified,
                Source = AccountV1DataStatusDetailSource.Watchtower,
            },
            Type = AccountV1DataType.Business,
            BusinessProfile = new()
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
            },
            Capabilities = new()
            {
                ConsentTypes = new()
                {
                    Internet = new(CapabilityStatus.Active),
                    SignedAgreement = new(CapabilityStatus.Active),
                },
                CustomerTypes = new()
                {
                    Businesses = new(CapabilityStatus.Active),
                    Individuals = new(CapabilityStatus.Active),
                },
                PaymentTypes = new()
                {
                    Charges = new(CapabilityStatus.Active),
                    Payouts = new(CapabilityStatus.Active),
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            Settings = new()
            {
                Charges = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
            },
            TermsOfService = new()
            {
                AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                AgreementType = AgreementType.Embedded,
                AgreementUrl = "agreement_url",
                AcceptedIP = "accepted_ip",
                AcceptedUserAgent = "accepted_user_agent",
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1Data>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        ApiEnum<string, AccountV1DataAccessLevel> expectedAccessLevel =
            AccountV1DataAccessLevel.Standard;
        string expectedOrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        ApiEnum<string, AccountV1DataStatus> expectedStatus = AccountV1DataStatus.Created;
        AccountV1DataStatusDetail expectedStatusDetail = new()
        {
            Code = "code",
            Message = "message",
            Reason = AccountV1DataStatusDetailReason.Unverified,
            Source = AccountV1DataStatusDetailSource.Watchtower,
        };
        ApiEnum<string, AccountV1DataType> expectedType = AccountV1DataType.Business;
        BusinessProfileV1 expectedBusinessProfile = new()
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
        AccountV1DataCapabilities expectedCapabilities = new()
        {
            ConsentTypes = new()
            {
                Internet = new(CapabilityStatus.Active),
                SignedAgreement = new(CapabilityStatus.Active),
            },
            CustomerTypes = new()
            {
                Businesses = new(CapabilityStatus.Active),
                Individuals = new(CapabilityStatus.Active),
            },
            PaymentTypes = new()
            {
                Charges = new(CapabilityStatus.Active),
                Payouts = new(CapabilityStatus.Active),
            },
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";
        Dictionary<string, string?> expectedMetadata = new() { { "foo", "string" } };
        AccountV1DataSettings expectedSettings = new()
        {
            Charges = new()
            {
                DailyAmount = 0,
                FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            Payouts = new()
            {
                DailyAmount = 0,
                FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
        };
        TermsOfServiceV1 expectedTermsOfService = new()
        {
            AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            AgreementType = AgreementType.Embedded,
            AgreementUrl = "agreement_url",
            AcceptedIP = "accepted_ip",
            AcceptedUserAgent = "accepted_user_agent",
        };
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAccessLevel, deserialized.AccessLevel);
        Assert.Equal(expectedOrganizationID, deserialized.OrganizationID);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedStatusDetail, deserialized.StatusDetail);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedBusinessProfile, deserialized.BusinessProfile);
        Assert.Equal(expectedCapabilities, deserialized.Capabilities);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedExternalID, deserialized.ExternalID);
        Assert.NotNull(deserialized.Metadata);
        Assert.Equal(expectedMetadata.Count, deserialized.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(deserialized.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Metadata[item.Key]);
        }
        Assert.Equal(expectedSettings, deserialized.Settings);
        Assert.Equal(expectedTermsOfService, deserialized.TermsOfService);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = AccountV1DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = AccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = AccountV1DataStatusDetailReason.Unverified,
                Source = AccountV1DataStatusDetailSource.Watchtower,
            },
            Type = AccountV1DataType.Business,
            BusinessProfile = new()
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
            },
            Capabilities = new()
            {
                ConsentTypes = new()
                {
                    Internet = new(CapabilityStatus.Active),
                    SignedAgreement = new(CapabilityStatus.Active),
                },
                CustomerTypes = new()
                {
                    Businesses = new(CapabilityStatus.Active),
                    Individuals = new(CapabilityStatus.Active),
                },
                PaymentTypes = new()
                {
                    Charges = new(CapabilityStatus.Active),
                    Payouts = new(CapabilityStatus.Active),
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            Settings = new()
            {
                Charges = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
            },
            TermsOfService = new()
            {
                AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                AgreementType = AgreementType.Embedded,
                AgreementUrl = "agreement_url",
                AcceptedIP = "accepted_ip",
                AcceptedUserAgent = "accepted_user_agent",
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = AccountV1DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = AccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = AccountV1DataStatusDetailReason.Unverified,
                Source = AccountV1DataStatusDetailSource.Watchtower,
            },
            Type = AccountV1DataType.Business,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        Assert.Null(model.BusinessProfile);
        Assert.False(model.RawData.ContainsKey("business_profile"));
        Assert.Null(model.Capabilities);
        Assert.False(model.RawData.ContainsKey("capabilities"));
        Assert.Null(model.Settings);
        Assert.False(model.RawData.ContainsKey("settings"));
        Assert.Null(model.TermsOfService);
        Assert.False(model.RawData.ContainsKey("terms_of_service"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = AccountV1DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = AccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = AccountV1DataStatusDetailReason.Unverified,
                Source = AccountV1DataStatusDetailSource.Watchtower,
            },
            Type = AccountV1DataType.Business,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = AccountV1DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = AccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = AccountV1DataStatusDetailReason.Unverified,
                Source = AccountV1DataStatusDetailSource.Watchtower,
            },
            Type = AccountV1DataType.Business,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),

            // Null should be interpreted as omitted for these properties
            BusinessProfile = null,
            Capabilities = null,
            Settings = null,
            TermsOfService = null,
        };

        Assert.Null(model.BusinessProfile);
        Assert.False(model.RawData.ContainsKey("business_profile"));
        Assert.Null(model.Capabilities);
        Assert.False(model.RawData.ContainsKey("capabilities"));
        Assert.Null(model.Settings);
        Assert.False(model.RawData.ContainsKey("settings"));
        Assert.Null(model.TermsOfService);
        Assert.False(model.RawData.ContainsKey("terms_of_service"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = AccountV1DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = AccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = AccountV1DataStatusDetailReason.Unverified,
                Source = AccountV1DataStatusDetailSource.Watchtower,
            },
            Type = AccountV1DataType.Business,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),

            // Null should be interpreted as omitted for these properties
            BusinessProfile = null,
            Capabilities = null,
            Settings = null,
            TermsOfService = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = AccountV1DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = AccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = AccountV1DataStatusDetailReason.Unverified,
                Source = AccountV1DataStatusDetailSource.Watchtower,
            },
            Type = AccountV1DataType.Business,
            BusinessProfile = new()
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
            },
            Capabilities = new()
            {
                ConsentTypes = new()
                {
                    Internet = new(CapabilityStatus.Active),
                    SignedAgreement = new(CapabilityStatus.Active),
                },
                CustomerTypes = new()
                {
                    Businesses = new(CapabilityStatus.Active),
                    Individuals = new(CapabilityStatus.Active),
                },
                PaymentTypes = new()
                {
                    Charges = new(CapabilityStatus.Active),
                    Payouts = new(CapabilityStatus.Active),
                },
            },
            Settings = new()
            {
                Charges = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
            },
            TermsOfService = new()
            {
                AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                AgreementType = AgreementType.Embedded,
                AgreementUrl = "agreement_url",
                AcceptedIP = "accepted_ip",
                AcceptedUserAgent = "accepted_user_agent",
            },
        };

        Assert.Null(model.CreatedAt);
        Assert.False(model.RawData.ContainsKey("created_at"));
        Assert.Null(model.ExternalID);
        Assert.False(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.Metadata);
        Assert.False(model.RawData.ContainsKey("metadata"));
        Assert.Null(model.UpdatedAt);
        Assert.False(model.RawData.ContainsKey("updated_at"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new AccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = AccountV1DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = AccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = AccountV1DataStatusDetailReason.Unverified,
                Source = AccountV1DataStatusDetailSource.Watchtower,
            },
            Type = AccountV1DataType.Business,
            BusinessProfile = new()
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
            },
            Capabilities = new()
            {
                ConsentTypes = new()
                {
                    Internet = new(CapabilityStatus.Active),
                    SignedAgreement = new(CapabilityStatus.Active),
                },
                CustomerTypes = new()
                {
                    Businesses = new(CapabilityStatus.Active),
                    Individuals = new(CapabilityStatus.Active),
                },
                PaymentTypes = new()
                {
                    Charges = new(CapabilityStatus.Active),
                    Payouts = new(CapabilityStatus.Active),
                },
            },
            Settings = new()
            {
                Charges = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
            },
            TermsOfService = new()
            {
                AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                AgreementType = AgreementType.Embedded,
                AgreementUrl = "agreement_url",
                AcceptedIP = "accepted_ip",
                AcceptedUserAgent = "accepted_user_agent",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new AccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = AccountV1DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = AccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = AccountV1DataStatusDetailReason.Unverified,
                Source = AccountV1DataStatusDetailSource.Watchtower,
            },
            Type = AccountV1DataType.Business,
            BusinessProfile = new()
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
            },
            Capabilities = new()
            {
                ConsentTypes = new()
                {
                    Internet = new(CapabilityStatus.Active),
                    SignedAgreement = new(CapabilityStatus.Active),
                },
                CustomerTypes = new()
                {
                    Businesses = new(CapabilityStatus.Active),
                    Individuals = new(CapabilityStatus.Active),
                },
                PaymentTypes = new()
                {
                    Charges = new(CapabilityStatus.Active),
                    Payouts = new(CapabilityStatus.Active),
                },
            },
            Settings = new()
            {
                Charges = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
            },
            TermsOfService = new()
            {
                AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                AgreementType = AgreementType.Embedded,
                AgreementUrl = "agreement_url",
                AcceptedIP = "accepted_ip",
                AcceptedUserAgent = "accepted_user_agent",
            },

            CreatedAt = null,
            ExternalID = null,
            Metadata = null,
            UpdatedAt = null,
        };

        Assert.Null(model.CreatedAt);
        Assert.True(model.RawData.ContainsKey("created_at"));
        Assert.Null(model.ExternalID);
        Assert.True(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.Metadata);
        Assert.True(model.RawData.ContainsKey("metadata"));
        Assert.Null(model.UpdatedAt);
        Assert.True(model.RawData.ContainsKey("updated_at"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = AccountV1DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = AccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = AccountV1DataStatusDetailReason.Unverified,
                Source = AccountV1DataStatusDetailSource.Watchtower,
            },
            Type = AccountV1DataType.Business,
            BusinessProfile = new()
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
            },
            Capabilities = new()
            {
                ConsentTypes = new()
                {
                    Internet = new(CapabilityStatus.Active),
                    SignedAgreement = new(CapabilityStatus.Active),
                },
                CustomerTypes = new()
                {
                    Businesses = new(CapabilityStatus.Active),
                    Individuals = new(CapabilityStatus.Active),
                },
                PaymentTypes = new()
                {
                    Charges = new(CapabilityStatus.Active),
                    Payouts = new(CapabilityStatus.Active),
                },
            },
            Settings = new()
            {
                Charges = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
            },
            TermsOfService = new()
            {
                AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                AgreementType = AgreementType.Embedded,
                AgreementUrl = "agreement_url",
                AcceptedIP = "accepted_ip",
                AcceptedUserAgent = "accepted_user_agent",
            },

            CreatedAt = null,
            ExternalID = null,
            Metadata = null,
            UpdatedAt = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AccountV1Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = AccountV1DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = AccountV1DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = AccountV1DataStatusDetailReason.Unverified,
                Source = AccountV1DataStatusDetailSource.Watchtower,
            },
            Type = AccountV1DataType.Business,
            BusinessProfile = new()
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
            },
            Capabilities = new()
            {
                ConsentTypes = new()
                {
                    Internet = new(CapabilityStatus.Active),
                    SignedAgreement = new(CapabilityStatus.Active),
                },
                CustomerTypes = new()
                {
                    Businesses = new(CapabilityStatus.Active),
                    Individuals = new(CapabilityStatus.Active),
                },
                PaymentTypes = new()
                {
                    Charges = new(CapabilityStatus.Active),
                    Payouts = new(CapabilityStatus.Active),
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string?>() { { "foo", "string" } },
            Settings = new()
            {
                Charges = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
            },
            TermsOfService = new()
            {
                AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                AgreementType = AgreementType.Embedded,
                AgreementUrl = "agreement_url",
                AcceptedIP = "accepted_ip",
                AcceptedUserAgent = "accepted_user_agent",
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        AccountV1Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountV1DataAccessLevelTest : TestBase
{
    [Theory]
    [InlineData(AccountV1DataAccessLevel.Standard)]
    [InlineData(AccountV1DataAccessLevel.Managed)]
    public void Validation_Works(AccountV1DataAccessLevel rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountV1DataAccessLevel> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, AccountV1DataAccessLevel>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(AccountV1DataAccessLevel.Standard)]
    [InlineData(AccountV1DataAccessLevel.Managed)]
    public void SerializationRoundtrip_Works(AccountV1DataAccessLevel rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountV1DataAccessLevel> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, AccountV1DataAccessLevel>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, AccountV1DataAccessLevel>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, AccountV1DataAccessLevel>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class AccountV1DataStatusTest : TestBase
{
    [Theory]
    [InlineData(AccountV1DataStatus.Created)]
    [InlineData(AccountV1DataStatus.Onboarding)]
    [InlineData(AccountV1DataStatus.Active)]
    [InlineData(AccountV1DataStatus.Rejected)]
    [InlineData(AccountV1DataStatus.Inactive)]
    public void Validation_Works(AccountV1DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountV1DataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, AccountV1DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(AccountV1DataStatus.Created)]
    [InlineData(AccountV1DataStatus.Onboarding)]
    [InlineData(AccountV1DataStatus.Active)]
    [InlineData(AccountV1DataStatus.Rejected)]
    [InlineData(AccountV1DataStatus.Inactive)]
    public void SerializationRoundtrip_Works(AccountV1DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountV1DataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, AccountV1DataStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, AccountV1DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, AccountV1DataStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class AccountV1DataStatusDetailTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountV1DataStatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = AccountV1DataStatusDetailReason.Unverified,
            Source = AccountV1DataStatusDetailSource.Watchtower,
        };

        string expectedCode = "code";
        string expectedMessage = "message";
        ApiEnum<string, AccountV1DataStatusDetailReason> expectedReason =
            AccountV1DataStatusDetailReason.Unverified;
        ApiEnum<string, AccountV1DataStatusDetailSource> expectedSource =
            AccountV1DataStatusDetailSource.Watchtower;

        Assert.Equal(expectedCode, model.Code);
        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedReason, model.Reason);
        Assert.Equal(expectedSource, model.Source);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AccountV1DataStatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = AccountV1DataStatusDetailReason.Unverified,
            Source = AccountV1DataStatusDetailSource.Watchtower,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1DataStatusDetail>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountV1DataStatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = AccountV1DataStatusDetailReason.Unverified,
            Source = AccountV1DataStatusDetailSource.Watchtower,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1DataStatusDetail>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedCode = "code";
        string expectedMessage = "message";
        ApiEnum<string, AccountV1DataStatusDetailReason> expectedReason =
            AccountV1DataStatusDetailReason.Unverified;
        ApiEnum<string, AccountV1DataStatusDetailSource> expectedSource =
            AccountV1DataStatusDetailSource.Watchtower;

        Assert.Equal(expectedCode, deserialized.Code);
        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedReason, deserialized.Reason);
        Assert.Equal(expectedSource, deserialized.Source);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AccountV1DataStatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = AccountV1DataStatusDetailReason.Unverified,
            Source = AccountV1DataStatusDetailSource.Watchtower,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AccountV1DataStatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = AccountV1DataStatusDetailReason.Unverified,
            Source = AccountV1DataStatusDetailSource.Watchtower,
        };

        AccountV1DataStatusDetail copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountV1DataStatusDetailReasonTest : TestBase
{
    [Theory]
    [InlineData(AccountV1DataStatusDetailReason.Unverified)]
    [InlineData(AccountV1DataStatusDetailReason.InReview)]
    [InlineData(AccountV1DataStatusDetailReason.Pending)]
    [InlineData(AccountV1DataStatusDetailReason.Stuck)]
    [InlineData(AccountV1DataStatusDetailReason.Verified)]
    [InlineData(AccountV1DataStatusDetailReason.FailedVerification)]
    [InlineData(AccountV1DataStatusDetailReason.Disabled)]
    [InlineData(AccountV1DataStatusDetailReason.Terminated)]
    [InlineData(AccountV1DataStatusDetailReason.New)]
    public void Validation_Works(AccountV1DataStatusDetailReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountV1DataStatusDetailReason> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, AccountV1DataStatusDetailReason>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(AccountV1DataStatusDetailReason.Unverified)]
    [InlineData(AccountV1DataStatusDetailReason.InReview)]
    [InlineData(AccountV1DataStatusDetailReason.Pending)]
    [InlineData(AccountV1DataStatusDetailReason.Stuck)]
    [InlineData(AccountV1DataStatusDetailReason.Verified)]
    [InlineData(AccountV1DataStatusDetailReason.FailedVerification)]
    [InlineData(AccountV1DataStatusDetailReason.Disabled)]
    [InlineData(AccountV1DataStatusDetailReason.Terminated)]
    [InlineData(AccountV1DataStatusDetailReason.New)]
    public void SerializationRoundtrip_Works(AccountV1DataStatusDetailReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountV1DataStatusDetailReason> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AccountV1DataStatusDetailReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, AccountV1DataStatusDetailReason>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AccountV1DataStatusDetailReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AccountV1DataStatusDetailSourceTest : TestBase
{
    [Theory]
    [InlineData(AccountV1DataStatusDetailSource.Watchtower)]
    public void Validation_Works(AccountV1DataStatusDetailSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountV1DataStatusDetailSource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, AccountV1DataStatusDetailSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(AccountV1DataStatusDetailSource.Watchtower)]
    public void SerializationRoundtrip_Works(AccountV1DataStatusDetailSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountV1DataStatusDetailSource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AccountV1DataStatusDetailSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, AccountV1DataStatusDetailSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AccountV1DataStatusDetailSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AccountV1DataTypeTest : TestBase
{
    [Theory]
    [InlineData(AccountV1DataType.Business)]
    public void Validation_Works(AccountV1DataType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountV1DataType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, AccountV1DataType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(AccountV1DataType.Business)]
    public void SerializationRoundtrip_Works(AccountV1DataType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountV1DataType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, AccountV1DataType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, AccountV1DataType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, AccountV1DataType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class AccountV1DataCapabilitiesTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountV1DataCapabilities
        {
            ConsentTypes = new()
            {
                Internet = new(CapabilityStatus.Active),
                SignedAgreement = new(CapabilityStatus.Active),
            },
            CustomerTypes = new()
            {
                Businesses = new(CapabilityStatus.Active),
                Individuals = new(CapabilityStatus.Active),
            },
            PaymentTypes = new()
            {
                Charges = new(CapabilityStatus.Active),
                Payouts = new(CapabilityStatus.Active),
            },
        };

        AccountV1DataCapabilitiesConsentTypes expectedConsentTypes = new()
        {
            Internet = new(CapabilityStatus.Active),
            SignedAgreement = new(CapabilityStatus.Active),
        };
        AccountV1DataCapabilitiesCustomerTypes expectedCustomerTypes = new()
        {
            Businesses = new(CapabilityStatus.Active),
            Individuals = new(CapabilityStatus.Active),
        };
        AccountV1DataCapabilitiesPaymentTypes expectedPaymentTypes = new()
        {
            Charges = new(CapabilityStatus.Active),
            Payouts = new(CapabilityStatus.Active),
        };

        Assert.Equal(expectedConsentTypes, model.ConsentTypes);
        Assert.Equal(expectedCustomerTypes, model.CustomerTypes);
        Assert.Equal(expectedPaymentTypes, model.PaymentTypes);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AccountV1DataCapabilities
        {
            ConsentTypes = new()
            {
                Internet = new(CapabilityStatus.Active),
                SignedAgreement = new(CapabilityStatus.Active),
            },
            CustomerTypes = new()
            {
                Businesses = new(CapabilityStatus.Active),
                Individuals = new(CapabilityStatus.Active),
            },
            PaymentTypes = new()
            {
                Charges = new(CapabilityStatus.Active),
                Payouts = new(CapabilityStatus.Active),
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1DataCapabilities>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountV1DataCapabilities
        {
            ConsentTypes = new()
            {
                Internet = new(CapabilityStatus.Active),
                SignedAgreement = new(CapabilityStatus.Active),
            },
            CustomerTypes = new()
            {
                Businesses = new(CapabilityStatus.Active),
                Individuals = new(CapabilityStatus.Active),
            },
            PaymentTypes = new()
            {
                Charges = new(CapabilityStatus.Active),
                Payouts = new(CapabilityStatus.Active),
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1DataCapabilities>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        AccountV1DataCapabilitiesConsentTypes expectedConsentTypes = new()
        {
            Internet = new(CapabilityStatus.Active),
            SignedAgreement = new(CapabilityStatus.Active),
        };
        AccountV1DataCapabilitiesCustomerTypes expectedCustomerTypes = new()
        {
            Businesses = new(CapabilityStatus.Active),
            Individuals = new(CapabilityStatus.Active),
        };
        AccountV1DataCapabilitiesPaymentTypes expectedPaymentTypes = new()
        {
            Charges = new(CapabilityStatus.Active),
            Payouts = new(CapabilityStatus.Active),
        };

        Assert.Equal(expectedConsentTypes, deserialized.ConsentTypes);
        Assert.Equal(expectedCustomerTypes, deserialized.CustomerTypes);
        Assert.Equal(expectedPaymentTypes, deserialized.PaymentTypes);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AccountV1DataCapabilities
        {
            ConsentTypes = new()
            {
                Internet = new(CapabilityStatus.Active),
                SignedAgreement = new(CapabilityStatus.Active),
            },
            CustomerTypes = new()
            {
                Businesses = new(CapabilityStatus.Active),
                Individuals = new(CapabilityStatus.Active),
            },
            PaymentTypes = new()
            {
                Charges = new(CapabilityStatus.Active),
                Payouts = new(CapabilityStatus.Active),
            },
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AccountV1DataCapabilities
        {
            ConsentTypes = new()
            {
                Internet = new(CapabilityStatus.Active),
                SignedAgreement = new(CapabilityStatus.Active),
            },
            CustomerTypes = new()
            {
                Businesses = new(CapabilityStatus.Active),
                Individuals = new(CapabilityStatus.Active),
            },
            PaymentTypes = new()
            {
                Charges = new(CapabilityStatus.Active),
                Payouts = new(CapabilityStatus.Active),
            },
        };

        AccountV1DataCapabilities copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountV1DataCapabilitiesConsentTypesTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountV1DataCapabilitiesConsentTypes
        {
            Internet = new(CapabilityStatus.Active),
            SignedAgreement = new(CapabilityStatus.Active),
        };

        CapabilityV1 expectedInternet = new(CapabilityStatus.Active);
        CapabilityV1 expectedSignedAgreement = new(CapabilityStatus.Active);

        Assert.Equal(expectedInternet, model.Internet);
        Assert.Equal(expectedSignedAgreement, model.SignedAgreement);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AccountV1DataCapabilitiesConsentTypes
        {
            Internet = new(CapabilityStatus.Active),
            SignedAgreement = new(CapabilityStatus.Active),
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1DataCapabilitiesConsentTypes>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountV1DataCapabilitiesConsentTypes
        {
            Internet = new(CapabilityStatus.Active),
            SignedAgreement = new(CapabilityStatus.Active),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1DataCapabilitiesConsentTypes>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        CapabilityV1 expectedInternet = new(CapabilityStatus.Active);
        CapabilityV1 expectedSignedAgreement = new(CapabilityStatus.Active);

        Assert.Equal(expectedInternet, deserialized.Internet);
        Assert.Equal(expectedSignedAgreement, deserialized.SignedAgreement);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AccountV1DataCapabilitiesConsentTypes
        {
            Internet = new(CapabilityStatus.Active),
            SignedAgreement = new(CapabilityStatus.Active),
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AccountV1DataCapabilitiesConsentTypes
        {
            Internet = new(CapabilityStatus.Active),
            SignedAgreement = new(CapabilityStatus.Active),
        };

        AccountV1DataCapabilitiesConsentTypes copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountV1DataCapabilitiesCustomerTypesTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountV1DataCapabilitiesCustomerTypes
        {
            Businesses = new(CapabilityStatus.Active),
            Individuals = new(CapabilityStatus.Active),
        };

        CapabilityV1 expectedBusinesses = new(CapabilityStatus.Active);
        CapabilityV1 expectedIndividuals = new(CapabilityStatus.Active);

        Assert.Equal(expectedBusinesses, model.Businesses);
        Assert.Equal(expectedIndividuals, model.Individuals);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AccountV1DataCapabilitiesCustomerTypes
        {
            Businesses = new(CapabilityStatus.Active),
            Individuals = new(CapabilityStatus.Active),
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1DataCapabilitiesCustomerTypes>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountV1DataCapabilitiesCustomerTypes
        {
            Businesses = new(CapabilityStatus.Active),
            Individuals = new(CapabilityStatus.Active),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1DataCapabilitiesCustomerTypes>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        CapabilityV1 expectedBusinesses = new(CapabilityStatus.Active);
        CapabilityV1 expectedIndividuals = new(CapabilityStatus.Active);

        Assert.Equal(expectedBusinesses, deserialized.Businesses);
        Assert.Equal(expectedIndividuals, deserialized.Individuals);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AccountV1DataCapabilitiesCustomerTypes
        {
            Businesses = new(CapabilityStatus.Active),
            Individuals = new(CapabilityStatus.Active),
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AccountV1DataCapabilitiesCustomerTypes
        {
            Businesses = new(CapabilityStatus.Active),
            Individuals = new(CapabilityStatus.Active),
        };

        AccountV1DataCapabilitiesCustomerTypes copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountV1DataCapabilitiesPaymentTypesTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountV1DataCapabilitiesPaymentTypes
        {
            Charges = new(CapabilityStatus.Active),
            Payouts = new(CapabilityStatus.Active),
        };

        CapabilityV1 expectedCharges = new(CapabilityStatus.Active);
        CapabilityV1 expectedPayouts = new(CapabilityStatus.Active);

        Assert.Equal(expectedCharges, model.Charges);
        Assert.Equal(expectedPayouts, model.Payouts);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AccountV1DataCapabilitiesPaymentTypes
        {
            Charges = new(CapabilityStatus.Active),
            Payouts = new(CapabilityStatus.Active),
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1DataCapabilitiesPaymentTypes>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountV1DataCapabilitiesPaymentTypes
        {
            Charges = new(CapabilityStatus.Active),
            Payouts = new(CapabilityStatus.Active),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1DataCapabilitiesPaymentTypes>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        CapabilityV1 expectedCharges = new(CapabilityStatus.Active);
        CapabilityV1 expectedPayouts = new(CapabilityStatus.Active);

        Assert.Equal(expectedCharges, deserialized.Charges);
        Assert.Equal(expectedPayouts, deserialized.Payouts);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AccountV1DataCapabilitiesPaymentTypes
        {
            Charges = new(CapabilityStatus.Active),
            Payouts = new(CapabilityStatus.Active),
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AccountV1DataCapabilitiesPaymentTypes
        {
            Charges = new(CapabilityStatus.Active),
            Payouts = new(CapabilityStatus.Active),
        };

        AccountV1DataCapabilitiesPaymentTypes copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountV1DataSettingsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountV1DataSettings
        {
            Charges = new()
            {
                DailyAmount = 0,
                FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            Payouts = new()
            {
                DailyAmount = 0,
                FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
        };

        AccountV1DataSettingsCharges expectedCharges = new()
        {
            DailyAmount = 0,
            FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };
        AccountV1DataSettingsPayouts expectedPayouts = new()
        {
            DailyAmount = 0,
            FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        Assert.Equal(expectedCharges, model.Charges);
        Assert.Equal(expectedPayouts, model.Payouts);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AccountV1DataSettings
        {
            Charges = new()
            {
                DailyAmount = 0,
                FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            Payouts = new()
            {
                DailyAmount = 0,
                FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1DataSettings>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountV1DataSettings
        {
            Charges = new()
            {
                DailyAmount = 0,
                FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            Payouts = new()
            {
                DailyAmount = 0,
                FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1DataSettings>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        AccountV1DataSettingsCharges expectedCharges = new()
        {
            DailyAmount = 0,
            FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };
        AccountV1DataSettingsPayouts expectedPayouts = new()
        {
            DailyAmount = 0,
            FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        Assert.Equal(expectedCharges, deserialized.Charges);
        Assert.Equal(expectedPayouts, deserialized.Payouts);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AccountV1DataSettings
        {
            Charges = new()
            {
                DailyAmount = 0,
                FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            Payouts = new()
            {
                DailyAmount = 0,
                FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AccountV1DataSettings
        {
            Charges = new()
            {
                DailyAmount = 0,
                FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            Payouts = new()
            {
                DailyAmount = 0,
                FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
        };

        AccountV1DataSettings copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountV1DataSettingsChargesTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountV1DataSettingsCharges
        {
            DailyAmount = 0,
            FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        int expectedDailyAmount = 0;
        ApiEnum<string, AccountV1DataSettingsChargesFundingTime> expectedFundingTime =
            AccountV1DataSettingsChargesFundingTime.Immediate;
        string expectedLinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedMaxAmount = 0;
        int expectedMonthlyAmount = 0;
        int expectedMonthlyCount = 0;

        Assert.Equal(expectedDailyAmount, model.DailyAmount);
        Assert.Equal(expectedFundingTime, model.FundingTime);
        Assert.Equal(expectedLinkedBankAccountID, model.LinkedBankAccountID);
        Assert.Equal(expectedMaxAmount, model.MaxAmount);
        Assert.Equal(expectedMonthlyAmount, model.MonthlyAmount);
        Assert.Equal(expectedMonthlyCount, model.MonthlyCount);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AccountV1DataSettingsCharges
        {
            DailyAmount = 0,
            FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1DataSettingsCharges>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountV1DataSettingsCharges
        {
            DailyAmount = 0,
            FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1DataSettingsCharges>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        int expectedDailyAmount = 0;
        ApiEnum<string, AccountV1DataSettingsChargesFundingTime> expectedFundingTime =
            AccountV1DataSettingsChargesFundingTime.Immediate;
        string expectedLinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedMaxAmount = 0;
        int expectedMonthlyAmount = 0;
        int expectedMonthlyCount = 0;

        Assert.Equal(expectedDailyAmount, deserialized.DailyAmount);
        Assert.Equal(expectedFundingTime, deserialized.FundingTime);
        Assert.Equal(expectedLinkedBankAccountID, deserialized.LinkedBankAccountID);
        Assert.Equal(expectedMaxAmount, deserialized.MaxAmount);
        Assert.Equal(expectedMonthlyAmount, deserialized.MonthlyAmount);
        Assert.Equal(expectedMonthlyCount, deserialized.MonthlyCount);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AccountV1DataSettingsCharges
        {
            DailyAmount = 0,
            FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AccountV1DataSettingsCharges
        {
            DailyAmount = 0,
            FundingTime = AccountV1DataSettingsChargesFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        AccountV1DataSettingsCharges copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountV1DataSettingsChargesFundingTimeTest : TestBase
{
    [Theory]
    [InlineData(AccountV1DataSettingsChargesFundingTime.Immediate)]
    [InlineData(AccountV1DataSettingsChargesFundingTime.NextDay)]
    [InlineData(AccountV1DataSettingsChargesFundingTime.OneDay)]
    [InlineData(AccountV1DataSettingsChargesFundingTime.TwoDay)]
    [InlineData(AccountV1DataSettingsChargesFundingTime.ThreeDay)]
    public void Validation_Works(AccountV1DataSettingsChargesFundingTime rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountV1DataSettingsChargesFundingTime> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AccountV1DataSettingsChargesFundingTime>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(AccountV1DataSettingsChargesFundingTime.Immediate)]
    [InlineData(AccountV1DataSettingsChargesFundingTime.NextDay)]
    [InlineData(AccountV1DataSettingsChargesFundingTime.OneDay)]
    [InlineData(AccountV1DataSettingsChargesFundingTime.TwoDay)]
    [InlineData(AccountV1DataSettingsChargesFundingTime.ThreeDay)]
    public void SerializationRoundtrip_Works(AccountV1DataSettingsChargesFundingTime rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountV1DataSettingsChargesFundingTime> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AccountV1DataSettingsChargesFundingTime>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AccountV1DataSettingsChargesFundingTime>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AccountV1DataSettingsChargesFundingTime>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AccountV1DataSettingsPayoutsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountV1DataSettingsPayouts
        {
            DailyAmount = 0,
            FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        int expectedDailyAmount = 0;
        ApiEnum<string, AccountV1DataSettingsPayoutsFundingTime> expectedFundingTime =
            AccountV1DataSettingsPayoutsFundingTime.Immediate;
        string expectedLinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedMaxAmount = 0;
        int expectedMonthlyAmount = 0;
        int expectedMonthlyCount = 0;

        Assert.Equal(expectedDailyAmount, model.DailyAmount);
        Assert.Equal(expectedFundingTime, model.FundingTime);
        Assert.Equal(expectedLinkedBankAccountID, model.LinkedBankAccountID);
        Assert.Equal(expectedMaxAmount, model.MaxAmount);
        Assert.Equal(expectedMonthlyAmount, model.MonthlyAmount);
        Assert.Equal(expectedMonthlyCount, model.MonthlyCount);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AccountV1DataSettingsPayouts
        {
            DailyAmount = 0,
            FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1DataSettingsPayouts>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountV1DataSettingsPayouts
        {
            DailyAmount = 0,
            FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountV1DataSettingsPayouts>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        int expectedDailyAmount = 0;
        ApiEnum<string, AccountV1DataSettingsPayoutsFundingTime> expectedFundingTime =
            AccountV1DataSettingsPayoutsFundingTime.Immediate;
        string expectedLinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedMaxAmount = 0;
        int expectedMonthlyAmount = 0;
        int expectedMonthlyCount = 0;

        Assert.Equal(expectedDailyAmount, deserialized.DailyAmount);
        Assert.Equal(expectedFundingTime, deserialized.FundingTime);
        Assert.Equal(expectedLinkedBankAccountID, deserialized.LinkedBankAccountID);
        Assert.Equal(expectedMaxAmount, deserialized.MaxAmount);
        Assert.Equal(expectedMonthlyAmount, deserialized.MonthlyAmount);
        Assert.Equal(expectedMonthlyCount, deserialized.MonthlyCount);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AccountV1DataSettingsPayouts
        {
            DailyAmount = 0,
            FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AccountV1DataSettingsPayouts
        {
            DailyAmount = 0,
            FundingTime = AccountV1DataSettingsPayoutsFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        AccountV1DataSettingsPayouts copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountV1DataSettingsPayoutsFundingTimeTest : TestBase
{
    [Theory]
    [InlineData(AccountV1DataSettingsPayoutsFundingTime.Immediate)]
    [InlineData(AccountV1DataSettingsPayoutsFundingTime.NextDay)]
    [InlineData(AccountV1DataSettingsPayoutsFundingTime.OneDay)]
    [InlineData(AccountV1DataSettingsPayoutsFundingTime.TwoDay)]
    [InlineData(AccountV1DataSettingsPayoutsFundingTime.ThreeDay)]
    public void Validation_Works(AccountV1DataSettingsPayoutsFundingTime rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountV1DataSettingsPayoutsFundingTime> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AccountV1DataSettingsPayoutsFundingTime>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(AccountV1DataSettingsPayoutsFundingTime.Immediate)]
    [InlineData(AccountV1DataSettingsPayoutsFundingTime.NextDay)]
    [InlineData(AccountV1DataSettingsPayoutsFundingTime.OneDay)]
    [InlineData(AccountV1DataSettingsPayoutsFundingTime.TwoDay)]
    [InlineData(AccountV1DataSettingsPayoutsFundingTime.ThreeDay)]
    public void SerializationRoundtrip_Works(AccountV1DataSettingsPayoutsFundingTime rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountV1DataSettingsPayoutsFundingTime> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AccountV1DataSettingsPayoutsFundingTime>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AccountV1DataSettingsPayoutsFundingTime>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AccountV1DataSettingsPayoutsFundingTime>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AccountV1ResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(AccountV1ResponseType.Object)]
    [InlineData(AccountV1ResponseType.Array)]
    [InlineData(AccountV1ResponseType.Error)]
    [InlineData(AccountV1ResponseType.None)]
    public void Validation_Works(AccountV1ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountV1ResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, AccountV1ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(AccountV1ResponseType.Object)]
    [InlineData(AccountV1ResponseType.Array)]
    [InlineData(AccountV1ResponseType.Error)]
    [InlineData(AccountV1ResponseType.None)]
    public void SerializationRoundtrip_Works(AccountV1ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountV1ResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, AccountV1ResponseType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, AccountV1ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, AccountV1ResponseType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
