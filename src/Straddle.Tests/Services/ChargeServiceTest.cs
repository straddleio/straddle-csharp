using System.Threading.Tasks;
using Straddle.Models.Charges;

namespace Straddle.Tests.Services;

public class ChargeServiceTest : TestBase
{
    [Fact]
    public async Task Create_Works()
    {
        var chargeV1 = await this.client.Charges.Create(
            new()
            {
                Amount = 10000,
                Config = new()
                {
                    BalanceCheck = BalanceCheck.Required,
                    SandboxOutcome = SandboxOutcome.Standard,
                },
                ConsentType = ConsentType.Internet,
                Currency = "currency",
                Description = "Monthly subscription fee",
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                Paykey = "paykey",
                PaymentDate = "2019-12-27",
            },
            TestContext.Current.CancellationToken
        );
        chargeV1.Validate();
    }

    [Fact]
    public async Task Update_Works()
    {
        var chargeV1 = await this.client.Charges.Update(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new()
            {
                Amount = 10000,
                Description = "Monthly subscription fee",
                PaymentDate = "2019-12-27",
            },
            TestContext.Current.CancellationToken
        );
        chargeV1.Validate();
    }

    [Fact]
    public async Task Cancel_Works()
    {
        var chargeV1 = await this.client.Charges.Cancel(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        chargeV1.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var chargeV1 = await this.client.Charges.Get(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        chargeV1.Validate();
    }

    [Fact]
    public async Task Hold_Works()
    {
        var chargeV1 = await this.client.Charges.Hold(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        chargeV1.Validate();
    }

    [Fact]
    public async Task Release_Works()
    {
        var chargeV1 = await this.client.Charges.Release(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        chargeV1.Validate();
    }

    [Fact]
    public async Task Unmask_Works()
    {
        var response = await this.client.Charges.Unmask(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }
}
