using System.Threading.Tasks;
using Straddle.Models.Bridge.Link;

namespace Straddle.Tests.Services.Bridge;

public class LinkServiceTest : TestBase
{
    [Fact]
    public async Task BankAccount_Works()
    {
        var paykeyV1 = await this.client.Bridge.Link.BankAccount(
            new()
            {
                AccountNumber = "account_number",
                AccountType = AccountType.Checking,
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                RoutingNumber = "xxxxxxxxx",
            },
            TestContext.Current.CancellationToken
        );
        paykeyV1.Validate();
    }

    [Fact]
    public async Task CreatePaykey_Works()
    {
        var response = await this.client.Bridge.Link.CreatePaykey(
            new()
            {
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                QuilttToken = "quiltt_token",
            },
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }

    [Fact]
    public async Task CreateTan_Works()
    {
        var response = await this.client.Bridge.Link.CreateTan(
            new()
            {
                AccountType = LinkCreateTanParamsAccountType.Checking,
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                RoutingNumber = "routing_number",
                Tan = "tan",
            },
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }

    [Fact]
    public async Task Plaid_Works()
    {
        var paykeyV1 = await this.client.Bridge.Link.Plaid(
            new()
            {
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                PlaidToken = "plaid_token",
            },
            TestContext.Current.CancellationToken
        );
        paykeyV1.Validate();
    }
}
