using System.Threading.Tasks;

namespace Straddle.Tests.Services;

public class ReportServiceTest : TestBase
{
    [Fact]
    public async Task CreateTotalCustomersByStatus_Works()
    {
        var response = await this.client.Reports.CreateTotalCustomersByStatus(
            new(),
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }
}
