using System;
using System.Threading.Tasks;
using Straddle.Models.Embed.Accounts;

namespace Straddle.Tests.Services.Embed;

public class AccountServiceTest : TestBase
{
    [Fact]
    public async Task Create_Works()
    {
        var accountV1 = await this.client.Embed.Accounts.Create(
            new()
            {
                AccessLevel = AccessLevel.Standard,
                AccountType = AccountType.Business,
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
                OrganizationID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            },
            TestContext.Current.CancellationToken
        );
        accountV1.Validate();
    }

    [Fact]
    public async Task Update_Works()
    {
        var accountV1 = await this.client.Embed.Accounts.Update(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new()
            {
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
            },
            TestContext.Current.CancellationToken
        );
        accountV1.Validate();
    }

    [Fact]
    public async Task List_Works()
    {
        var page = await this.client.Embed.Accounts.List(
            new(),
            TestContext.Current.CancellationToken
        );
        page.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var accountV1 = await this.client.Embed.Accounts.Get(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        accountV1.Validate();
    }

    [Fact]
    public async Task Onboard_Works()
    {
        var accountV1 = await this.client.Embed.Accounts.Onboard(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new()
            {
                TermsOfService = new()
                {
                    AcceptedDate = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    AgreementType = AgreementType.Embedded,
                    AgreementUrl = "agreement_url",
                    AcceptedIP = "accepted_ip",
                    AcceptedUserAgent = "accepted_user_agent",
                },
            },
            TestContext.Current.CancellationToken
        );
        accountV1.Validate();
    }

    [Fact]
    public async Task Simulate_Works()
    {
        var accountV1 = await this.client.Embed.Accounts.Simulate(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        accountV1.Validate();
    }
}
