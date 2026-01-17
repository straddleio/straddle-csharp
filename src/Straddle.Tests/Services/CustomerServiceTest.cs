using System.Threading.Tasks;
using Straddle.Models.Customers;

namespace Straddle.Tests.Services;

public class CustomerServiceTest : TestBase
{
    [Fact]
    public async Task Create_Works()
    {
        var customerV1 = await this.client.Customers.Create(
            new()
            {
                Device = new("192.168.1.1"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Type = Type.Individual,
            },
            TestContext.Current.CancellationToken
        );
        customerV1.Validate();
    }

    [Fact]
    public async Task Update_Works()
    {
        var customerV1 = await this.client.Customers.Update(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new()
            {
                Device = new("192.168.1.1"),
                Email = "dev@stainless.com",
                Name = "name",
                Phone = "+46991022",
                Status = Status.Pending,
            },
            TestContext.Current.CancellationToken
        );
        customerV1.Validate();
    }

    [Fact]
    public async Task List_Works()
    {
        var page = await this.client.Customers.List(new(), TestContext.Current.CancellationToken);
        page.Validate();
    }

    [Fact]
    public async Task Delete_Works()
    {
        var customerV1 = await this.client.Customers.Delete(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        customerV1.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var customerV1 = await this.client.Customers.Get(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        customerV1.Validate();
    }

    [Fact]
    public async Task Unmasked_Works()
    {
        var customerUnmaskedV1 = await this.client.Customers.Unmasked(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        customerUnmaskedV1.Validate();
    }
}
