using System;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.Customers;
using Straddle.Models.Customers.Review;

namespace Straddle.Services.Customers;

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
    /// Updates the status of a customer's identity decision. This endpoint allows
    /// you to modify the outcome of a customer risk screening and is useful for correcting
    /// or updating the status of a customer's verification. Note that this endpoint
    /// is only available for customers with a current status of `review`.
    /// </summary>
    Task<CustomerV1> Decision(
        ReviewDecisionParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Decision(ReviewDecisionParams, CancellationToken)"/>
    Task<CustomerV1> Decision(
        string id,
        ReviewDecisionParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves and analyzes the results of a customer's identity validation and
    /// fraud score. This endpoint provides a comprehensive breakdown of the validation
    /// outcome, including: - Risk and correlation scores - Reason codes for the
    /// decision - Results of watchlist screening - Any network alerts detected Use
    /// this endpoint to gain insights into the verification process and make informed
    /// decisions about customer onboarding.
    /// </summary>
    Task<CustomerReviewV1> Get(
        ReviewGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(ReviewGetParams, CancellationToken)"/>
    Task<CustomerReviewV1> Get(
        string id,
        ReviewGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the decision of a customer's identity validation. This endpoint allows
    /// you to modify the outcome of a customer decision and is useful for correcting
    /// or updating the status of a customer's verification.
    /// </summary>
    Task<CustomerV1> RefreshReview(
        ReviewRefreshReviewParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="RefreshReview(ReviewRefreshReviewParams, CancellationToken)"/>
    Task<CustomerV1> RefreshReview(
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
    /// Returns a raw HTTP response for `patch /v1/customers/{id}/review`, but is otherwise the
    /// same as <see cref="IReviewService.Decision(ReviewDecisionParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<CustomerV1>> Decision(
        ReviewDecisionParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Decision(ReviewDecisionParams, CancellationToken)"/>
    Task<HttpResponse<CustomerV1>> Decision(
        string id,
        ReviewDecisionParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/customers/{id}/review`, but is otherwise the
    /// same as <see cref="IReviewService.Get(ReviewGetParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<CustomerReviewV1>> Get(
        ReviewGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(ReviewGetParams, CancellationToken)"/>
    Task<HttpResponse<CustomerReviewV1>> Get(
        string id,
        ReviewGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `put /v1/customers/{id}/refresh_review`, but is otherwise the
    /// same as <see cref="IReviewService.RefreshReview(ReviewRefreshReviewParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<CustomerV1>> RefreshReview(
        ReviewRefreshReviewParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="RefreshReview(ReviewRefreshReviewParams, CancellationToken)"/>
    Task<HttpResponse<CustomerV1>> RefreshReview(
        string id,
        ReviewRefreshReviewParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
