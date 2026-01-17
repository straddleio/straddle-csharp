using System.Threading.Tasks;

namespace Straddle.Tests.Services;

public class PaykeyServiceTest : TestBase
{
    [Fact]
    public async Task List_Works()
    {
        var page = await this.client.Paykeys.List(new(), TestContext.Current.CancellationToken);
        page.Validate();
    }

    [Fact]
    public async Task Cancel_Works()
    {
        var paykeyV1 = await this.client.Paykeys.Cancel(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        paykeyV1.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var paykeyV1 = await this.client.Paykeys.Get(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        paykeyV1.Validate();
    }

    [Fact]
    public async Task Reveal_Works()
    {
        var response = await this.client.Paykeys.Reveal(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }

    [Fact]
    public async Task Unmasked_Works()
    {
        var paykeyUnmaskedV1 = await this.client.Paykeys.Unmasked(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        paykeyUnmaskedV1.Validate();
    }

    [Fact]
    public async Task UpdateBalance_Works()
    {
        var paykeyV1 = await this.client.Paykeys.UpdateBalance(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        paykeyV1.Validate();
    }
}
