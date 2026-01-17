using System.Threading.Tasks;

namespace Straddle.Tests.Services;

public class PayoutServiceTest : TestBase
{
    [Fact]
    public async Task Create_Works()
    {
        var payoutV1 = await this.client.Payouts.Create(
            new()
            {
                Amount = 10000,
                Currency = "currency",
                Description = "Vendor invoice payment",
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                Paykey = "paykey",
                PaymentDate = "2019-12-27",
            },
            TestContext.Current.CancellationToken
        );
        payoutV1.Validate();
    }

    [Fact]
    public async Task Update_Works()
    {
        var payoutV1 = await this.client.Payouts.Update(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new()
            {
                Amount = 10000,
                Description = "description",
                PaymentDate = "2019-12-27",
            },
            TestContext.Current.CancellationToken
        );
        payoutV1.Validate();
    }

    [Fact]
    public async Task Cancel_Works()
    {
        var payoutV1 = await this.client.Payouts.Cancel(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new() { Reason = "reason" },
            TestContext.Current.CancellationToken
        );
        payoutV1.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var payoutV1 = await this.client.Payouts.Get(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        payoutV1.Validate();
    }

    [Fact]
    public async Task Hold_Works()
    {
        var payoutV1 = await this.client.Payouts.Hold(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new() { Reason = "reason" },
            TestContext.Current.CancellationToken
        );
        payoutV1.Validate();
    }

    [Fact]
    public async Task Release_Works()
    {
        var payoutV1 = await this.client.Payouts.Release(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new() { Reason = "reason" },
            TestContext.Current.CancellationToken
        );
        payoutV1.Validate();
    }

    [Fact]
    public async Task Unmask_Works()
    {
        var response = await this.client.Payouts.Unmask(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }
}
