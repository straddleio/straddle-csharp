using System;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.Paykeys;
using Straddle.Services.Paykeys;

namespace Straddle.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IPaykeyService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IPaykeyServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IPaykeyService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IReviewService Review { get; }

    /// <summary>
    /// Returns a list of paykeys associated with a Straddle account. This endpoint
    /// supports advanced sorting and filtering options.
    /// </summary>
    Task<PaykeyListPage> List(
        PaykeyListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sends a request to <c>put /v1/paykeys/{id}/cancel<c/>.
    /// </summary>
    Task<PaykeyV1> Cancel(
        PaykeyCancelParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Cancel(PaykeyCancelParams, CancellationToken)"/>
    Task<PaykeyV1> Cancel(
        string id,
        PaykeyCancelParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the details of an existing paykey. Supply the unique paykey `id`
    /// and Straddle will return the corresponding paykey record , including the `paykey`
    /// token value and masked bank account details.
    /// </summary>
    Task<PaykeyV1> Get(PaykeyGetParams parameters, CancellationToken cancellationToken = default);

    /// <inheritdoc cref="Get(PaykeyGetParams, CancellationToken)"/>
    Task<PaykeyV1> Get(
        string id,
        PaykeyGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the details of a paykey that has previously been created, including
    /// unmasked bank account fields. Supply the unique paykey ID that was returned
    /// from your previous request, and Straddle will return the corresponding paykey information.
    /// </summary>
    Task<PaykeyRevealResponse> Reveal(
        PaykeyRevealParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Reveal(PaykeyRevealParams, CancellationToken)"/>
    Task<PaykeyRevealResponse> Reveal(
        string id,
        PaykeyRevealParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the unmasked details of an existing paykey. Supply the unique paykey
    /// `id` and Straddle will return the corresponding paykey record, including
    /// the unmasked bank account details. This endpoint needs to be enabled by Straddle
    /// for your account and should only be used when absolutely necessary.
    /// </summary>
    Task<PaykeyUnmaskedV1> Unmasked(
        PaykeyUnmaskedParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Unmasked(PaykeyUnmaskedParams, CancellationToken)"/>
    Task<PaykeyUnmaskedV1> Unmasked(
        string id,
        PaykeyUnmaskedParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the balance of a paykey. This endpoint allows you to refresh the balance
    /// of a paykey.
    /// </summary>
    Task<PaykeyV1> UpdateBalance(
        PaykeyUpdateBalanceParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="UpdateBalance(PaykeyUpdateBalanceParams, CancellationToken)"/>
    Task<PaykeyV1> UpdateBalance(
        string id,
        PaykeyUpdateBalanceParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IPaykeyService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IPaykeyServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IPaykeyServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IReviewServiceWithRawResponse Review { get; }

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/paykeys`, but is otherwise the
    /// same as <see cref="IPaykeyService.List(PaykeyListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PaykeyListPage>> List(
        PaykeyListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `put /v1/paykeys/{id}/cancel`, but is otherwise the
    /// same as <see cref="IPaykeyService.Cancel(PaykeyCancelParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PaykeyV1>> Cancel(
        PaykeyCancelParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Cancel(PaykeyCancelParams, CancellationToken)"/>
    Task<HttpResponse<PaykeyV1>> Cancel(
        string id,
        PaykeyCancelParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/paykeys/{id}`, but is otherwise the
    /// same as <see cref="IPaykeyService.Get(PaykeyGetParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PaykeyV1>> Get(
        PaykeyGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(PaykeyGetParams, CancellationToken)"/>
    Task<HttpResponse<PaykeyV1>> Get(
        string id,
        PaykeyGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/paykeys/{id}/reveal`, but is otherwise the
    /// same as <see cref="IPaykeyService.Reveal(PaykeyRevealParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PaykeyRevealResponse>> Reveal(
        PaykeyRevealParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Reveal(PaykeyRevealParams, CancellationToken)"/>
    Task<HttpResponse<PaykeyRevealResponse>> Reveal(
        string id,
        PaykeyRevealParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/paykeys/{id}/unmasked`, but is otherwise the
    /// same as <see cref="IPaykeyService.Unmasked(PaykeyUnmaskedParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PaykeyUnmaskedV1>> Unmasked(
        PaykeyUnmaskedParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Unmasked(PaykeyUnmaskedParams, CancellationToken)"/>
    Task<HttpResponse<PaykeyUnmaskedV1>> Unmasked(
        string id,
        PaykeyUnmaskedParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `put /v1/paykeys/{id}/refresh_balance`, but is otherwise the
    /// same as <see cref="IPaykeyService.UpdateBalance(PaykeyUpdateBalanceParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PaykeyV1>> UpdateBalance(
        PaykeyUpdateBalanceParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="UpdateBalance(PaykeyUpdateBalanceParams, CancellationToken)"/>
    Task<HttpResponse<PaykeyV1>> UpdateBalance(
        string id,
        PaykeyUpdateBalanceParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
