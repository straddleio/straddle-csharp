using System.Threading.Tasks;

namespace Straddle.Tests.Services.Embed;

public class RepresentativeServiceTest : TestBase
{
    [Fact]
    public async Task Create_Works()
    {
        var representative = await this.client.Embed.Representatives.Create(
            new()
            {
                AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Dob = "1980-01-01",
                Email = "ron.swanson@pawnee.com",
                FirstName = "first_name",
                LastName = "last_name",
                MobileNumber = "+12128675309",
                Relationship = new()
                {
                    Control = true,
                    Owner = true,
                    Primary = true,
                    PercentOwnership = 0,
                    Title = "title",
                },
                SsnLast4 = "1234",
            },
            TestContext.Current.CancellationToken
        );
        representative.Validate();
    }

    [Fact]
    public async Task Update_Works()
    {
        var representative = await this.client.Embed.Representatives.Update(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new()
            {
                Dob = "1980-01-01",
                Email = "ron.swanson@pawnee.com",
                FirstName = "Ron",
                LastName = "Swanson",
                MobileNumber = "+12128675309",
                Relationship = new()
                {
                    Control = true,
                    Owner = true,
                    Primary = true,
                    PercentOwnership = 0,
                    Title = "title",
                },
                SsnLast4 = "1234",
            },
            TestContext.Current.CancellationToken
        );
        representative.Validate();
    }

    [Fact]
    public async Task List_Works()
    {
        var page = await this.client.Embed.Representatives.List(
            new(),
            TestContext.Current.CancellationToken
        );
        page.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var representative = await this.client.Embed.Representatives.Get(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        representative.Validate();
    }

    [Fact]
    public async Task Unmask_Works()
    {
        var representative = await this.client.Embed.Representatives.Unmask(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        representative.Validate();
    }
}
