using System.Threading.Tasks;

namespace Straddle.Tests.Services;

public class BridgeServiceTest : TestBase
{
    [Fact]
    public async Task Initialize_Works()
    {
        var bridgeTokenV1 = await this.client.Bridge.Initialize(
            new() { CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e" },
            TestContext.Current.CancellationToken
        );
        bridgeTokenV1.Validate();
    }
}
