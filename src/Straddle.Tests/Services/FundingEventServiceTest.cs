using System.Threading.Tasks;

namespace Straddle.Tests.Services;

public class FundingEventServiceTest : TestBase
{
    [Fact]
    public async Task List_Works()
    {
        var page = await this.client.FundingEvents.List(
            new(),
            TestContext.Current.CancellationToken
        );
        page.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var fundingEventSummaryItemV1 = await this.client.FundingEvents.Get(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        fundingEventSummaryItemV1.Validate();
    }
}
