using System.Threading.Tasks;

namespace Straddle.Tests.Services.Embed;

public class OrganizationServiceTest : TestBase
{
    [Fact]
    public async Task Create_Works()
    {
        var organizationV1 = await this.client.Embed.Organizations.Create(
            new() { Name = "name" },
            TestContext.Current.CancellationToken
        );
        organizationV1.Validate();
    }

    [Fact]
    public async Task List_Works()
    {
        var page = await this.client.Embed.Organizations.List(
            new(),
            TestContext.Current.CancellationToken
        );
        page.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var organizationV1 = await this.client.Embed.Organizations.Get(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        organizationV1.Validate();
    }
}
