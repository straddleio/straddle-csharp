using System;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.Payouts;

namespace Straddle.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IPayoutService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IPayoutServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IPayoutService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Use payouts to send money to your customers.
    /// </summary>
    Task<PayoutV1> Create(
        PayoutCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update the details of a payout prior to processing. The status of the payout
    /// must be `created`, `scheduled`, or `on_hold`.
    /// </summary>
    Task<PayoutV1> Update(
        PayoutUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Update(PayoutUpdateParams, CancellationToken)"/>
    Task<PayoutV1> Update(
        string id,
        PayoutUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancel a payout to prevent it from being processed. The status of the payout
    /// must be `created`, `scheduled`, or `on_hold`.
    /// </summary>
    Task<PayoutV1> Cancel(
        PayoutCancelParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Cancel(PayoutCancelParams, CancellationToken)"/>
    Task<PayoutV1> Cancel(
        string id,
        PayoutCancelParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the details of an existing payout. Supply the unique payout `id`
    /// to retrieve the corresponding payout information.
    /// </summary>
    Task<PayoutV1> Get(PayoutGetParams parameters, CancellationToken cancellationToken = default);

    /// <inheritdoc cref="Get(PayoutGetParams, CancellationToken)"/>
    Task<PayoutV1> Get(
        string id,
        PayoutGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Hold a payout to prevent it from being processed. The status of the payout
    /// must be `created`, `scheduled`, or `on_hold`.
    /// </summary>
    Task<PayoutV1> Hold(PayoutHoldParams parameters, CancellationToken cancellationToken = default);

    /// <inheritdoc cref="Hold(PayoutHoldParams, CancellationToken)"/>
    Task<PayoutV1> Hold(
        string id,
        PayoutHoldParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Release a payout from a `hold` status to allow it to be rescheduled for processing.
    /// </summary>
    Task<PayoutV1> Release(
        PayoutReleaseParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Release(PayoutReleaseParams, CancellationToken)"/>
    Task<PayoutV1> Release(
        string id,
        PayoutReleaseParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a payout by id.
    /// </summary>
    Task<PayoutUnmaskResponse> Unmask(
        PayoutUnmaskParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Unmask(PayoutUnmaskParams, CancellationToken)"/>
    Task<PayoutUnmaskResponse> Unmask(
        string id,
        PayoutUnmaskParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IPayoutService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IPayoutServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IPayoutServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `post /v1/payouts`, but is otherwise the
    /// same as <see cref="IPayoutService.Create(PayoutCreateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PayoutV1>> Create(
        PayoutCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `put /v1/payouts/{id}`, but is otherwise the
    /// same as <see cref="IPayoutService.Update(PayoutUpdateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PayoutV1>> Update(
        PayoutUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Update(PayoutUpdateParams, CancellationToken)"/>
    Task<HttpResponse<PayoutV1>> Update(
        string id,
        PayoutUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `put /v1/payouts/{id}/cancel`, but is otherwise the
    /// same as <see cref="IPayoutService.Cancel(PayoutCancelParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PayoutV1>> Cancel(
        PayoutCancelParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Cancel(PayoutCancelParams, CancellationToken)"/>
    Task<HttpResponse<PayoutV1>> Cancel(
        string id,
        PayoutCancelParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/payouts/{id}`, but is otherwise the
    /// same as <see cref="IPayoutService.Get(PayoutGetParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PayoutV1>> Get(
        PayoutGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(PayoutGetParams, CancellationToken)"/>
    Task<HttpResponse<PayoutV1>> Get(
        string id,
        PayoutGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `put /v1/payouts/{id}/hold`, but is otherwise the
    /// same as <see cref="IPayoutService.Hold(PayoutHoldParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PayoutV1>> Hold(
        PayoutHoldParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Hold(PayoutHoldParams, CancellationToken)"/>
    Task<HttpResponse<PayoutV1>> Hold(
        string id,
        PayoutHoldParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `put /v1/payouts/{id}/release`, but is otherwise the
    /// same as <see cref="IPayoutService.Release(PayoutReleaseParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PayoutV1>> Release(
        PayoutReleaseParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Release(PayoutReleaseParams, CancellationToken)"/>
    Task<HttpResponse<PayoutV1>> Release(
        string id,
        PayoutReleaseParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/payouts/{id}/unmask`, but is otherwise the
    /// same as <see cref="IPayoutService.Unmask(PayoutUnmaskParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PayoutUnmaskResponse>> Unmask(
        PayoutUnmaskParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Unmask(PayoutUnmaskParams, CancellationToken)"/>
    Task<HttpResponse<PayoutUnmaskResponse>> Unmask(
        string id,
        PayoutUnmaskParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
