using System.Threading.Tasks;
using Straddle.Models.Paykeys.Review;

namespace Straddle.Tests.Services.Paykeys;

public class ReviewServiceTest : TestBase
{
    [Fact]
    public async Task Decision_Works()
    {
        var paykeyV1 = await this.client.Paykeys.Review.Decision(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new() { Status = Status.Active },
            TestContext.Current.CancellationToken
        );
        paykeyV1.Validate();
    }

    [Fact]
    public async Task Get_Works()
    {
        var review = await this.client.Paykeys.Review.Get(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        review.Validate();
    }

    [Fact]
    public async Task RefreshReview_Works()
    {
        var paykeyV1 = await this.client.Paykeys.Review.RefreshReview(
            "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            new(),
            TestContext.Current.CancellationToken
        );
        paykeyV1.Validate();
    }
}
