using System;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.Paykeys;
using Straddle.Models.Paykeys.Review;

namespace Straddle.Services.Paykeys;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IReviewService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IReviewServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IReviewService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Update the status of a paykey when in review status
    /// </summary>
    Task<PaykeyV1> Decision(
        ReviewDecisionParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Decision(ReviewDecisionParams, CancellationToken)"/>
    Task<PaykeyV1> Decision(
        string id,
        ReviewDecisionParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get additional details about a paykey.
    /// </summary>
    Task<ReviewGetResponse> Get(
        ReviewGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(ReviewGetParams, CancellationToken)"/>
    Task<ReviewGetResponse> Get(
        string id,
        ReviewGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the decision of a paykey's review validation. This endpoint allows
    /// you to refresh the outcome of a paykey's decision and is useful for correcting
    /// or updating the status of a paykey's verification.
    /// </summary>
    Task<PaykeyV1> RefreshReview(
        ReviewRefreshReviewParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="RefreshReview(ReviewRefreshReviewParams, CancellationToken)"/>
    Task<PaykeyV1> RefreshReview(
        string id,
        ReviewRefreshReviewParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IReviewService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IReviewServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IReviewServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `patch /v1/paykeys/{id}/review`, but is otherwise the
    /// same as <see cref="IReviewService.Decision(ReviewDecisionParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PaykeyV1>> Decision(
        ReviewDecisionParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Decision(ReviewDecisionParams, CancellationToken)"/>
    Task<HttpResponse<PaykeyV1>> Decision(
        string id,
        ReviewDecisionParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/paykeys/{id}/review`, but is otherwise the
    /// same as <see cref="IReviewService.Get(ReviewGetParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ReviewGetResponse>> Get(
        ReviewGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(ReviewGetParams, CancellationToken)"/>
    Task<HttpResponse<ReviewGetResponse>> Get(
        string id,
        ReviewGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `put /v1/paykeys/{id}/refresh_review`, but is otherwise the
    /// same as <see cref="IReviewService.RefreshReview(ReviewRefreshReviewParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PaykeyV1>> RefreshReview(
        ReviewRefreshReviewParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="RefreshReview(ReviewRefreshReviewParams, CancellationToken)"/>
    Task<HttpResponse<PaykeyV1>> RefreshReview(
        string id,
        ReviewRefreshReviewParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
