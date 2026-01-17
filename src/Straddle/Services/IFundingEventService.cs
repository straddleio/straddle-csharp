using System;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.FundingEvents;

namespace Straddle.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IFundingEventService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IFundingEventServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IFundingEventService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Retrieves a list of funding events for your account. This endpoint supports
    /// advanced sorting and filtering options.
    /// </summary>
    Task<FundingEventListPage> List(
        FundingEventListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the details of an existing funding event. Supply the unique funding
    /// event `id`, and Straddle will return the individual transaction items that
    /// make up the funding event.
    /// </summary>
    Task<FundingEventSummaryItemV1> Get(
        FundingEventGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(FundingEventGetParams, CancellationToken)"/>
    Task<FundingEventSummaryItemV1> Get(
        string id,
        FundingEventGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IFundingEventService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IFundingEventServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IFundingEventServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/funding_events`, but is otherwise the
    /// same as <see cref="IFundingEventService.List(FundingEventListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<FundingEventListPage>> List(
        FundingEventListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/funding_events/{id}`, but is otherwise the
    /// same as <see cref="IFundingEventService.Get(FundingEventGetParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<FundingEventSummaryItemV1>> Get(
        FundingEventGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(FundingEventGetParams, CancellationToken)"/>
    Task<HttpResponse<FundingEventSummaryItemV1>> Get(
        string id,
        FundingEventGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
