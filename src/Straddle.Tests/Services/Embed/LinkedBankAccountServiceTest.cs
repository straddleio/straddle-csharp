using System.Threading.Tasks;

namespace Straddle.Tests.Services.Embed;

public class LinkedBankAccountServiceTest : TestBase
{
    [Fact]
    public async Task Create_Works()
    {
        var linkedBankAccountV1 = await this.client.Embed.LinkedBankAccounts.Create(
            new()
            {
                AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                BankAccount = new()
                {
                    AccountHolder = "account_holder",
                    AccountNumber = "account_number",
                    RoutingNumber = "xxxxxxxxx",
                },
            },
            TestContext.Current.CancellationToken
        );
        linkedBankAccountV1.Validate();
    }

    [Fact]
    public async Task Update_Works()
    {
        var linkedBankAccountV1 = await this.client.Embed.LinkedBankAccounts.Update(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new()
            {
                BankAccount = new()
                {
                    AccountHolder = "account_holder",
                    AccountNumber = "account_number",
                    RoutingNumber = "xxxxxxxxx",
                },
            },
            TestContext.Current.CancellationToken
        );
        linkedBankAccountV1.Validate();
    }

    [Fact]
    public async Task List_Works()
    {
        var page = await this.client.Embed.LinkedBankAccounts.List(
            new(),
            TestContext.Current.CancellationToken
        );
        page.Validate();
    }

    [Fact]
    public async Task Cancel_Works()
    {
        var linkedBankAccountV1 = await this.client.Embed.LinkedBankAccounts.Cancel(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        linkedBankAccountV1.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var linkedBankAccountV1 = await this.client.Embed.LinkedBankAccounts.Get(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        linkedBankAccountV1.Validate();
    }

    [Fact]
    public async Task Unmask_Works()
    {
        var linkedBankAccountUnmaskV1 = await this.client.Embed.LinkedBankAccounts.Unmask(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        linkedBankAccountUnmaskV1.Validate();
    }
}
