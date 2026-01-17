using System.Threading.Tasks;

namespace Straddle.Tests.Services.Embed.Accounts;

public class CapabilityRequestServiceTest : TestBase
{
    [Fact]
    public async Task Create_Works()
    {
        var capabilityRequestPagedV1 = await this.client.Embed.Accounts.CapabilityRequests.Create(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        capabilityRequestPagedV1.Validate();
    }

    [Fact]
    public async Task List_Works()
    {
        var page = await this.client.Embed.Accounts.CapabilityRequests.List(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        page.Validate();
    }
}
