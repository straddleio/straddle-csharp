using System;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.Charges;

namespace Straddle.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IChargeService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IChargeServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IChargeService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Use charges to collect money from a customer for the sale of goods or services.
    /// </summary>
    Task<ChargeV1> Create(
        ChargeCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change the values of parameters associated with a charge prior to processing.
    /// The status of the charge must be `created`, `scheduled`, or `on_hold`.
    /// </summary>
    Task<ChargeV1> Update(
        ChargeUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Update(ChargeUpdateParams, CancellationToken)"/>
    Task<ChargeV1> Update(
        string id,
        ChargeUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancel a charge to prevent it from being originated for processing. The status
    /// of the charge must be `created`, `scheduled`, or `on_hold`.
    /// </summary>
    Task<ChargeV1> Cancel(
        ChargeCancelParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Cancel(ChargeCancelParams, CancellationToken)"/>
    Task<ChargeV1> Cancel(
        string id,
        ChargeCancelParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the details of an existing charge. Supply the unique charge `id`,
    /// and Straddle will return the corresponding charge information.
    /// </summary>
    Task<ChargeV1> Get(ChargeGetParams parameters, CancellationToken cancellationToken = default);

    /// <inheritdoc cref="Get(ChargeGetParams, CancellationToken)"/>
    Task<ChargeV1> Get(
        string id,
        ChargeGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Place a charge on hold to prevent it from being originated for processing.
    /// The status of the charge must be `created` or `scheduled`.
    /// </summary>
    Task<ChargeV1> Hold(ChargeHoldParams parameters, CancellationToken cancellationToken = default);

    /// <inheritdoc cref="Hold(ChargeHoldParams, CancellationToken)"/>
    Task<ChargeV1> Hold(
        string id,
        ChargeHoldParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Release a charge from an `on_hold` status to allow it to be rescheduled for processing.
    /// </summary>
    Task<ChargeV1> Release(
        ChargeReleaseParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Release(ChargeReleaseParams, CancellationToken)"/>
    Task<ChargeV1> Release(
        string id,
        ChargeReleaseParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a charge by id.
    /// </summary>
    Task<ChargeUnmaskResponse> Unmask(
        ChargeUnmaskParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Unmask(ChargeUnmaskParams, CancellationToken)"/>
    Task<ChargeUnmaskResponse> Unmask(
        string id,
        ChargeUnmaskParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IChargeService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IChargeServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IChargeServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `post /v1/charges`, but is otherwise the
    /// same as <see cref="IChargeService.Create(ChargeCreateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ChargeV1>> Create(
        ChargeCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `put /v1/charges/{id}`, but is otherwise the
    /// same as <see cref="IChargeService.Update(ChargeUpdateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ChargeV1>> Update(
        ChargeUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Update(ChargeUpdateParams, CancellationToken)"/>
    Task<HttpResponse<ChargeV1>> Update(
        string id,
        ChargeUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `put /v1/charges/{id}/cancel`, but is otherwise the
    /// same as <see cref="IChargeService.Cancel(ChargeCancelParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ChargeV1>> Cancel(
        ChargeCancelParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Cancel(ChargeCancelParams, CancellationToken)"/>
    Task<HttpResponse<ChargeV1>> Cancel(
        string id,
        ChargeCancelParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/charges/{id}`, but is otherwise the
    /// same as <see cref="IChargeService.Get(ChargeGetParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ChargeV1>> Get(
        ChargeGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(ChargeGetParams, CancellationToken)"/>
    Task<HttpResponse<ChargeV1>> Get(
        string id,
        ChargeGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `put /v1/charges/{id}/hold`, but is otherwise the
    /// same as <see cref="IChargeService.Hold(ChargeHoldParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ChargeV1>> Hold(
        ChargeHoldParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Hold(ChargeHoldParams, CancellationToken)"/>
    Task<HttpResponse<ChargeV1>> Hold(
        string id,
        ChargeHoldParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `put /v1/charges/{id}/release`, but is otherwise the
    /// same as <see cref="IChargeService.Release(ChargeReleaseParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ChargeV1>> Release(
        ChargeReleaseParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Release(ChargeReleaseParams, CancellationToken)"/>
    Task<HttpResponse<ChargeV1>> Release(
        string id,
        ChargeReleaseParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/charges/{id}/unmask`, but is otherwise the
    /// same as <see cref="IChargeService.Unmask(ChargeUnmaskParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ChargeUnmaskResponse>> Unmask(
        ChargeUnmaskParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Unmask(ChargeUnmaskParams, CancellationToken)"/>
    Task<HttpResponse<ChargeUnmaskResponse>> Unmask(
        string id,
        ChargeUnmaskParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
