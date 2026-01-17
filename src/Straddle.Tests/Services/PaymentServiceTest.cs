using System.Threading.Tasks;

namespace Straddle.Tests.Services;

public class PaymentServiceTest : TestBase
{
    [Fact]
    public async Task List_Works()
    {
        var page = await this.client.Payments.List(new(), TestContext.Current.CancellationToken);
        page.Validate();
    }
}
