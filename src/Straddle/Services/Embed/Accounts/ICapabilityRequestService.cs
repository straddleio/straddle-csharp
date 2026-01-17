using System;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.Embed.Accounts.CapabilityRequests;

namespace Straddle.Services.Embed.Accounts;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface ICapabilityRequestService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    ICapabilityRequestServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ICapabilityRequestService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Submits a request to enable a specific capability for an account. Use this
    /// endpoint to request additional features or services for an account.
    /// </summary>
    Task<CapabilityRequestPagedV1> Create(
        CapabilityRequestCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Create(CapabilityRequestCreateParams, CancellationToken)"/>
    Task<CapabilityRequestPagedV1> Create(
        string accountID,
        CapabilityRequestCreateParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves a list of capability requests associated with an account. The requests
    /// are returned sorted by creation date, with the most recent requests appearing
    /// first. This endpoint supports advanced sorting and filtering options.
    /// </summary>
    Task<CapabilityRequestListPage> List(
        CapabilityRequestListParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="List(CapabilityRequestListParams, CancellationToken)"/>
    Task<CapabilityRequestListPage> List(
        string accountID,
        CapabilityRequestListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="ICapabilityRequestService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface ICapabilityRequestServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ICapabilityRequestServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    );

    /// <summary>
    /// Returns a raw HTTP response for `post /v1/accounts/{account_id}/capability_requests`, but is otherwise the
    /// same as <see cref="ICapabilityRequestService.Create(CapabilityRequestCreateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<CapabilityRequestPagedV1>> Create(
        CapabilityRequestCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Create(CapabilityRequestCreateParams, CancellationToken)"/>
    Task<HttpResponse<CapabilityRequestPagedV1>> Create(
        string accountID,
        CapabilityRequestCreateParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/accounts/{account_id}/capability_requests`, but is otherwise the
    /// same as <see cref="ICapabilityRequestService.List(CapabilityRequestListParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<CapabilityRequestListPage>> List(
        CapabilityRequestListParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="List(CapabilityRequestListParams, CancellationToken)"/>
    Task<HttpResponse<CapabilityRequestListPage>> List(
        string accountID,
        CapabilityRequestListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
