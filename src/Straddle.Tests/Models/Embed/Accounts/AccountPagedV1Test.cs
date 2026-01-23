using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Embed.Accounts;
using Models = Straddle.Models;

namespace Straddle.Tests.Models.Embed.Accounts;

public class AccountPagedV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    AccessLevel = DataAccessLevel.Standard,
                    OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Status = DataStatus.Created,
                    StatusDetail = new()
                    {
                        Code = "code",
                        Message = "message",
                        Reason = Reason.Unverified,
                        Source = Source.Watchtower,
                    },
                    Type = DataType.Business,
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
                            FundingTime = FundingTime.Immediate,
                            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                            MaxAmount = 0,
                            MonthlyAmount = 0,
                            MonthlyCount = 0,
                        },
                        Payouts = new()
                        {
                            DailyAmount = 0,
                            FundingTime = SettingsPayoutsFundingTime.Immediate,
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
            ],
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                MaxPageSize = 0,
                PageNumber = 0,
                PageSize = 0,
                SortBy = "sort_by",
                SortOrder = Models::SortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = ResponseType.Object,
        };

        List<Data> expectedData =
        [
            new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                AccessLevel = DataAccessLevel.Standard,
                OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Status = DataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = Reason.Unverified,
                    Source = Source.Watchtower,
                },
                Type = DataType.Business,
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
                        FundingTime = FundingTime.Immediate,
                        LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        MaxAmount = 0,
                        MonthlyAmount = 0,
                        MonthlyCount = 0,
                    },
                    Payouts = new()
                    {
                        DailyAmount = 0,
                        FundingTime = SettingsPayoutsFundingTime.Immediate,
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
        ];
        Models::PagedResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = Models::SortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };
        ApiEnum<string, ResponseType> expectedResponseType = ResponseType.Object;

        Assert.Equal(expectedData.Count, model.Data.Count);
        for (int i = 0; i < expectedData.Count; i++)
        {
            Assert.Equal(expectedData[i], model.Data[i]);
        }
        Assert.Equal(expectedMeta, model.Meta);
        Assert.Equal(expectedResponseType, model.ResponseType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AccountPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    AccessLevel = DataAccessLevel.Standard,
                    OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Status = DataStatus.Created,
                    StatusDetail = new()
                    {
                        Code = "code",
                        Message = "message",
                        Reason = Reason.Unverified,
                        Source = Source.Watchtower,
                    },
                    Type = DataType.Business,
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
                            FundingTime = FundingTime.Immediate,
                            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                            MaxAmount = 0,
                            MonthlyAmount = 0,
                            MonthlyCount = 0,
                        },
                        Payouts = new()
                        {
                            DailyAmount = 0,
                            FundingTime = SettingsPayoutsFundingTime.Immediate,
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
            ],
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                MaxPageSize = 0,
                PageNumber = 0,
                PageSize = 0,
                SortBy = "sort_by",
                SortOrder = Models::SortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountPagedV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    AccessLevel = DataAccessLevel.Standard,
                    OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Status = DataStatus.Created,
                    StatusDetail = new()
                    {
                        Code = "code",
                        Message = "message",
                        Reason = Reason.Unverified,
                        Source = Source.Watchtower,
                    },
                    Type = DataType.Business,
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
                            FundingTime = FundingTime.Immediate,
                            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                            MaxAmount = 0,
                            MonthlyAmount = 0,
                            MonthlyCount = 0,
                        },
                        Payouts = new()
                        {
                            DailyAmount = 0,
                            FundingTime = SettingsPayoutsFundingTime.Immediate,
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
            ],
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                MaxPageSize = 0,
                PageNumber = 0,
                PageSize = 0,
                SortBy = "sort_by",
                SortOrder = Models::SortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountPagedV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                AccessLevel = DataAccessLevel.Standard,
                OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Status = DataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = Reason.Unverified,
                    Source = Source.Watchtower,
                },
                Type = DataType.Business,
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
                        FundingTime = FundingTime.Immediate,
                        LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        MaxAmount = 0,
                        MonthlyAmount = 0,
                        MonthlyCount = 0,
                    },
                    Payouts = new()
                    {
                        DailyAmount = 0,
                        FundingTime = SettingsPayoutsFundingTime.Immediate,
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
        ];
        Models::PagedResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = Models::SortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };
        ApiEnum<string, ResponseType> expectedResponseType = ResponseType.Object;

        Assert.Equal(expectedData.Count, deserialized.Data.Count);
        for (int i = 0; i < expectedData.Count; i++)
        {
            Assert.Equal(expectedData[i], deserialized.Data[i]);
        }
        Assert.Equal(expectedMeta, deserialized.Meta);
        Assert.Equal(expectedResponseType, deserialized.ResponseType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AccountPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    AccessLevel = DataAccessLevel.Standard,
                    OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Status = DataStatus.Created,
                    StatusDetail = new()
                    {
                        Code = "code",
                        Message = "message",
                        Reason = Reason.Unverified,
                        Source = Source.Watchtower,
                    },
                    Type = DataType.Business,
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
                            FundingTime = FundingTime.Immediate,
                            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                            MaxAmount = 0,
                            MonthlyAmount = 0,
                            MonthlyCount = 0,
                        },
                        Payouts = new()
                        {
                            DailyAmount = 0,
                            FundingTime = SettingsPayoutsFundingTime.Immediate,
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
            ],
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                MaxPageSize = 0,
                PageNumber = 0,
                PageSize = 0,
                SortBy = "sort_by",
                SortOrder = Models::SortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = ResponseType.Object,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AccountPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    AccessLevel = DataAccessLevel.Standard,
                    OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Status = DataStatus.Created,
                    StatusDetail = new()
                    {
                        Code = "code",
                        Message = "message",
                        Reason = Reason.Unverified,
                        Source = Source.Watchtower,
                    },
                    Type = DataType.Business,
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
                            FundingTime = FundingTime.Immediate,
                            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                            MaxAmount = 0,
                            MonthlyAmount = 0,
                            MonthlyCount = 0,
                        },
                        Payouts = new()
                        {
                            DailyAmount = 0,
                            FundingTime = SettingsPayoutsFundingTime.Immediate,
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
            ],
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                MaxPageSize = 0,
                PageNumber = 0,
                PageSize = 0,
                SortBy = "sort_by",
                SortOrder = Models::SortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = ResponseType.Object,
        };

        AccountPagedV1 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            Type = DataType.Business,
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
                    FundingTime = FundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = SettingsPayoutsFundingTime.Immediate,
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
        ApiEnum<string, DataAccessLevel> expectedAccessLevel = DataAccessLevel.Standard;
        string expectedOrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        ApiEnum<string, DataStatus> expectedStatus = DataStatus.Created;
        StatusDetail expectedStatusDetail = new()
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
        };
        ApiEnum<string, DataType> expectedType = DataType.Business;
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
        Capabilities expectedCapabilities = new()
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
        Settings expectedSettings = new()
        {
            Charges = new()
            {
                DailyAmount = 0,
                FundingTime = FundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            Payouts = new()
            {
                DailyAmount = 0,
                FundingTime = SettingsPayoutsFundingTime.Immediate,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            Type = DataType.Business,
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
                    FundingTime = FundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = SettingsPayoutsFundingTime.Immediate,
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
        var deserialized = JsonSerializer.Deserialize<Data>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            Type = DataType.Business,
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
                    FundingTime = FundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = SettingsPayoutsFundingTime.Immediate,
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
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        ApiEnum<string, DataAccessLevel> expectedAccessLevel = DataAccessLevel.Standard;
        string expectedOrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        ApiEnum<string, DataStatus> expectedStatus = DataStatus.Created;
        StatusDetail expectedStatusDetail = new()
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
        };
        ApiEnum<string, DataType> expectedType = DataType.Business;
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
        Capabilities expectedCapabilities = new()
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
        Settings expectedSettings = new()
        {
            Charges = new()
            {
                DailyAmount = 0,
                FundingTime = FundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            Payouts = new()
            {
                DailyAmount = 0,
                FundingTime = SettingsPayoutsFundingTime.Immediate,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            Type = DataType.Business,
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
                    FundingTime = FundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = SettingsPayoutsFundingTime.Immediate,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            Type = DataType.Business,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            Type = DataType.Business,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            Type = DataType.Business,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            Type = DataType.Business,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            Type = DataType.Business,
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
                    FundingTime = FundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = SettingsPayoutsFundingTime.Immediate,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            Type = DataType.Business,
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
                    FundingTime = FundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = SettingsPayoutsFundingTime.Immediate,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            Type = DataType.Business,
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
                    FundingTime = FundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = SettingsPayoutsFundingTime.Immediate,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            Type = DataType.Business,
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
                    FundingTime = FundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = SettingsPayoutsFundingTime.Immediate,
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
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccessLevel = DataAccessLevel.Standard,
            OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Status = DataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            Type = DataType.Business,
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
                    FundingTime = FundingTime.Immediate,
                    LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    MaxAmount = 0,
                    MonthlyAmount = 0,
                    MonthlyCount = 0,
                },
                Payouts = new()
                {
                    DailyAmount = 0,
                    FundingTime = SettingsPayoutsFundingTime.Immediate,
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

        Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DataAccessLevelTest : TestBase
{
    [Theory]
    [InlineData(DataAccessLevel.Standard)]
    [InlineData(DataAccessLevel.Managed)]
    public void Validation_Works(DataAccessLevel rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataAccessLevel> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataAccessLevel>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(DataAccessLevel.Standard)]
    [InlineData(DataAccessLevel.Managed)]
    public void SerializationRoundtrip_Works(DataAccessLevel rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataAccessLevel> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataAccessLevel>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataAccessLevel>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataAccessLevel>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class DataStatusTest : TestBase
{
    [Theory]
    [InlineData(DataStatus.Created)]
    [InlineData(DataStatus.Onboarding)]
    [InlineData(DataStatus.Active)]
    [InlineData(DataStatus.Rejected)]
    [InlineData(DataStatus.Inactive)]
    public void Validation_Works(DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(DataStatus.Created)]
    [InlineData(DataStatus.Onboarding)]
    [InlineData(DataStatus.Active)]
    [InlineData(DataStatus.Rejected)]
    [InlineData(DataStatus.Inactive)]
    public void SerializationRoundtrip_Works(DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class StatusDetailTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new StatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
        };

        string expectedCode = "code";
        string expectedMessage = "message";
        ApiEnum<string, Reason> expectedReason = Reason.Unverified;
        ApiEnum<string, Source> expectedSource = Source.Watchtower;

        Assert.Equal(expectedCode, model.Code);
        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedReason, model.Reason);
        Assert.Equal(expectedSource, model.Source);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new StatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<StatusDetail>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new StatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<StatusDetail>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedCode = "code";
        string expectedMessage = "message";
        ApiEnum<string, Reason> expectedReason = Reason.Unverified;
        ApiEnum<string, Source> expectedSource = Source.Watchtower;

        Assert.Equal(expectedCode, deserialized.Code);
        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedReason, deserialized.Reason);
        Assert.Equal(expectedSource, deserialized.Source);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new StatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new StatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
        };

        StatusDetail copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class ReasonTest : TestBase
{
    [Theory]
    [InlineData(Reason.Unverified)]
    [InlineData(Reason.InReview)]
    [InlineData(Reason.Pending)]
    [InlineData(Reason.Stuck)]
    [InlineData(Reason.Verified)]
    [InlineData(Reason.FailedVerification)]
    [InlineData(Reason.Disabled)]
    [InlineData(Reason.Terminated)]
    [InlineData(Reason.New)]
    public void Validation_Works(Reason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Reason> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Reason>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Reason.Unverified)]
    [InlineData(Reason.InReview)]
    [InlineData(Reason.Pending)]
    [InlineData(Reason.Stuck)]
    [InlineData(Reason.Verified)]
    [InlineData(Reason.FailedVerification)]
    [InlineData(Reason.Disabled)]
    [InlineData(Reason.Terminated)]
    [InlineData(Reason.New)]
    public void SerializationRoundtrip_Works(Reason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Reason> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Reason>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Reason>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Reason>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class SourceTest : TestBase
{
    [Theory]
    [InlineData(Source.Watchtower)]
    public void Validation_Works(Source rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Source> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Source>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Source.Watchtower)]
    public void SerializationRoundtrip_Works(Source rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Source> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Source>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Source>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Source>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class DataTypeTest : TestBase
{
    [Theory]
    [InlineData(DataType.Business)]
    public void Validation_Works(DataType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(DataType.Business)]
    public void SerializationRoundtrip_Works(DataType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class CapabilitiesTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Capabilities
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

        ConsentTypes expectedConsentTypes = new()
        {
            Internet = new(CapabilityStatus.Active),
            SignedAgreement = new(CapabilityStatus.Active),
        };
        CustomerTypes expectedCustomerTypes = new()
        {
            Businesses = new(CapabilityStatus.Active),
            Individuals = new(CapabilityStatus.Active),
        };
        PaymentTypes expectedPaymentTypes = new()
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
        var model = new Capabilities
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
        var deserialized = JsonSerializer.Deserialize<Capabilities>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Capabilities
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
        var deserialized = JsonSerializer.Deserialize<Capabilities>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ConsentTypes expectedConsentTypes = new()
        {
            Internet = new(CapabilityStatus.Active),
            SignedAgreement = new(CapabilityStatus.Active),
        };
        CustomerTypes expectedCustomerTypes = new()
        {
            Businesses = new(CapabilityStatus.Active),
            Individuals = new(CapabilityStatus.Active),
        };
        PaymentTypes expectedPaymentTypes = new()
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
        var model = new Capabilities
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
        var model = new Capabilities
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

        Capabilities copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class ConsentTypesTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ConsentTypes
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
        var model = new ConsentTypes
        {
            Internet = new(CapabilityStatus.Active),
            SignedAgreement = new(CapabilityStatus.Active),
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ConsentTypes>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ConsentTypes
        {
            Internet = new(CapabilityStatus.Active),
            SignedAgreement = new(CapabilityStatus.Active),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ConsentTypes>(
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
        var model = new ConsentTypes
        {
            Internet = new(CapabilityStatus.Active),
            SignedAgreement = new(CapabilityStatus.Active),
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new ConsentTypes
        {
            Internet = new(CapabilityStatus.Active),
            SignedAgreement = new(CapabilityStatus.Active),
        };

        ConsentTypes copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class CustomerTypesTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CustomerTypes
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
        var model = new CustomerTypes
        {
            Businesses = new(CapabilityStatus.Active),
            Individuals = new(CapabilityStatus.Active),
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerTypes>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CustomerTypes
        {
            Businesses = new(CapabilityStatus.Active),
            Individuals = new(CapabilityStatus.Active),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CustomerTypes>(
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
        var model = new CustomerTypes
        {
            Businesses = new(CapabilityStatus.Active),
            Individuals = new(CapabilityStatus.Active),
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new CustomerTypes
        {
            Businesses = new(CapabilityStatus.Active),
            Individuals = new(CapabilityStatus.Active),
        };

        CustomerTypes copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class PaymentTypesTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaymentTypes
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
        var model = new PaymentTypes
        {
            Charges = new(CapabilityStatus.Active),
            Payouts = new(CapabilityStatus.Active),
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaymentTypes>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaymentTypes
        {
            Charges = new(CapabilityStatus.Active),
            Payouts = new(CapabilityStatus.Active),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaymentTypes>(
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
        var model = new PaymentTypes
        {
            Charges = new(CapabilityStatus.Active),
            Payouts = new(CapabilityStatus.Active),
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new PaymentTypes
        {
            Charges = new(CapabilityStatus.Active),
            Payouts = new(CapabilityStatus.Active),
        };

        PaymentTypes copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class SettingsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Settings
        {
            Charges = new()
            {
                DailyAmount = 0,
                FundingTime = FundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            Payouts = new()
            {
                DailyAmount = 0,
                FundingTime = SettingsPayoutsFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
        };

        SettingsCharges expectedCharges = new()
        {
            DailyAmount = 0,
            FundingTime = FundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };
        SettingsPayouts expectedPayouts = new()
        {
            DailyAmount = 0,
            FundingTime = SettingsPayoutsFundingTime.Immediate,
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
        var model = new Settings
        {
            Charges = new()
            {
                DailyAmount = 0,
                FundingTime = FundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            Payouts = new()
            {
                DailyAmount = 0,
                FundingTime = SettingsPayoutsFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Settings>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Settings
        {
            Charges = new()
            {
                DailyAmount = 0,
                FundingTime = FundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            Payouts = new()
            {
                DailyAmount = 0,
                FundingTime = SettingsPayoutsFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Settings>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        SettingsCharges expectedCharges = new()
        {
            DailyAmount = 0,
            FundingTime = FundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };
        SettingsPayouts expectedPayouts = new()
        {
            DailyAmount = 0,
            FundingTime = SettingsPayoutsFundingTime.Immediate,
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
        var model = new Settings
        {
            Charges = new()
            {
                DailyAmount = 0,
                FundingTime = FundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            Payouts = new()
            {
                DailyAmount = 0,
                FundingTime = SettingsPayoutsFundingTime.Immediate,
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
        var model = new Settings
        {
            Charges = new()
            {
                DailyAmount = 0,
                FundingTime = FundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
            Payouts = new()
            {
                DailyAmount = 0,
                FundingTime = SettingsPayoutsFundingTime.Immediate,
                LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                MaxAmount = 0,
                MonthlyAmount = 0,
                MonthlyCount = 0,
            },
        };

        Settings copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class SettingsChargesTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new SettingsCharges
        {
            DailyAmount = 0,
            FundingTime = FundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        int expectedDailyAmount = 0;
        ApiEnum<string, FundingTime> expectedFundingTime = FundingTime.Immediate;
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
        var model = new SettingsCharges
        {
            DailyAmount = 0,
            FundingTime = FundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<SettingsCharges>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new SettingsCharges
        {
            DailyAmount = 0,
            FundingTime = FundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<SettingsCharges>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        int expectedDailyAmount = 0;
        ApiEnum<string, FundingTime> expectedFundingTime = FundingTime.Immediate;
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
        var model = new SettingsCharges
        {
            DailyAmount = 0,
            FundingTime = FundingTime.Immediate,
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
        var model = new SettingsCharges
        {
            DailyAmount = 0,
            FundingTime = FundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        SettingsCharges copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class FundingTimeTest : TestBase
{
    [Theory]
    [InlineData(FundingTime.Immediate)]
    [InlineData(FundingTime.NextDay)]
    [InlineData(FundingTime.OneDay)]
    [InlineData(FundingTime.TwoDay)]
    [InlineData(FundingTime.ThreeDay)]
    public void Validation_Works(FundingTime rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FundingTime> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, FundingTime>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(FundingTime.Immediate)]
    [InlineData(FundingTime.NextDay)]
    [InlineData(FundingTime.OneDay)]
    [InlineData(FundingTime.TwoDay)]
    [InlineData(FundingTime.ThreeDay)]
    public void SerializationRoundtrip_Works(FundingTime rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FundingTime> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, FundingTime>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, FundingTime>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, FundingTime>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class SettingsPayoutsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new SettingsPayouts
        {
            DailyAmount = 0,
            FundingTime = SettingsPayoutsFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        int expectedDailyAmount = 0;
        ApiEnum<string, SettingsPayoutsFundingTime> expectedFundingTime =
            SettingsPayoutsFundingTime.Immediate;
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
        var model = new SettingsPayouts
        {
            DailyAmount = 0,
            FundingTime = SettingsPayoutsFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<SettingsPayouts>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new SettingsPayouts
        {
            DailyAmount = 0,
            FundingTime = SettingsPayoutsFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<SettingsPayouts>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        int expectedDailyAmount = 0;
        ApiEnum<string, SettingsPayoutsFundingTime> expectedFundingTime =
            SettingsPayoutsFundingTime.Immediate;
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
        var model = new SettingsPayouts
        {
            DailyAmount = 0,
            FundingTime = SettingsPayoutsFundingTime.Immediate,
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
        var model = new SettingsPayouts
        {
            DailyAmount = 0,
            FundingTime = SettingsPayoutsFundingTime.Immediate,
            LinkedBankAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            MaxAmount = 0,
            MonthlyAmount = 0,
            MonthlyCount = 0,
        };

        SettingsPayouts copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class SettingsPayoutsFundingTimeTest : TestBase
{
    [Theory]
    [InlineData(SettingsPayoutsFundingTime.Immediate)]
    [InlineData(SettingsPayoutsFundingTime.NextDay)]
    [InlineData(SettingsPayoutsFundingTime.OneDay)]
    [InlineData(SettingsPayoutsFundingTime.TwoDay)]
    [InlineData(SettingsPayoutsFundingTime.ThreeDay)]
    public void Validation_Works(SettingsPayoutsFundingTime rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, SettingsPayoutsFundingTime> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, SettingsPayoutsFundingTime>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(SettingsPayoutsFundingTime.Immediate)]
    [InlineData(SettingsPayoutsFundingTime.NextDay)]
    [InlineData(SettingsPayoutsFundingTime.OneDay)]
    [InlineData(SettingsPayoutsFundingTime.TwoDay)]
    [InlineData(SettingsPayoutsFundingTime.ThreeDay)]
    public void SerializationRoundtrip_Works(SettingsPayoutsFundingTime rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, SettingsPayoutsFundingTime> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, SettingsPayoutsFundingTime>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, SettingsPayoutsFundingTime>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, SettingsPayoutsFundingTime>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class ResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(ResponseType.Object)]
    [InlineData(ResponseType.Array)]
    [InlineData(ResponseType.Error)]
    [InlineData(ResponseType.None)]
    public void Validation_Works(ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ResponseType.Object)]
    [InlineData(ResponseType.Array)]
    [InlineData(ResponseType.Error)]
    [InlineData(ResponseType.None)]
    public void SerializationRoundtrip_Works(ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ResponseType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ResponseType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
