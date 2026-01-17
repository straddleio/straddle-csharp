using System.Threading.Tasks;
using Straddle.Models.Customers.Review;

namespace Straddle.Tests.Services.Customers;

public class ReviewServiceTest : TestBase
{
    [Fact]
    public async Task Decision_Works()
    {
        var customerV1 = await this.client.Customers.Review.Decision(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new() { Status = Status.Verified },
            TestContext.Current.CancellationToken
        );
        customerV1.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var customerReviewV1 = await this.client.Customers.Review.Get(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        customerReviewV1.Validate();
    }

    [Fact]
    public async Task RefreshReview_Works()
    {
        var customerV1 = await this.client.Customers.Review.RefreshReview(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        customerV1.Validate();
    }
}
