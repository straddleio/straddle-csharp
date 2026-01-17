using System;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.Embed.Representatives;

namespace Straddle.Services.Embed;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IRepresentativeService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IRepresentativeServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IRepresentativeService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Creates a new representative associated with an account. Representatives are
    /// individuals who have legal authority or significant responsibility within
    /// the business.
    /// </summary>
    Task<Representative> Create(
        RepresentativeCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates an existing representative's information. This can be used to update
    /// personal details, contact information, or the relationship to the account
    /// or organization.
    /// </summary>
    Task<Representative> Update(
        RepresentativeUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Update(RepresentativeUpdateParams, CancellationToken)"/>
    Task<Representative> Update(
        string representativeID,
        RepresentativeUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a list of representatives associated with a specific account or organization.
    /// The representatives are returned sorted by creation date, with the most recently
    /// created representatives appearing first. This endpoint supports advanced
    /// sorting and filtering options.
    /// </summary>
    Task<RepresentativeListPage> List(
        RepresentativeListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the details of an existing representative. Supply the unique representative
    /// ID, and Straddle will return the corresponding representative information.
    /// </summary>
    Task<Representative> Get(
        RepresentativeGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(RepresentativeGetParams, CancellationToken)"/>
    Task<Representative> Get(
        string representativeID,
        RepresentativeGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the unmasked details of a representative that has previously been
    /// created. Supply the unique representative ID, and Straddle will return the
    /// corresponding representative information, including sensitive details. This
    /// endpoint requires additional authentication and should be used with caution.
    /// </summary>
    Task<Representative> Unmask(
        RepresentativeUnmaskParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Unmask(RepresentativeUnmaskParams, CancellationToken)"/>
    Task<Representative> Unmask(
        string representativeID,
        RepresentativeUnmaskParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IRepresentativeService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IRepresentativeServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IRepresentativeServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `post /v1/representatives`, but is otherwise the
    /// same as <see cref="IRepresentativeService.Create(RepresentativeCreateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<Representative>> Create(
        RepresentativeCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `put /v1/representatives/{representative_id}`, but is otherwise the
    /// same as <see cref="IRepresentativeService.Update(RepresentativeUpdateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<Representative>> Update(
        RepresentativeUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Update(RepresentativeUpdateParams, CancellationToken)"/>
    Task<HttpResponse<Representative>> Update(
        string representativeID,
        RepresentativeUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/representatives`, but is otherwise the
    /// same as <see cref="IRepresentativeService.List(RepresentativeListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<RepresentativeListPage>> List(
        RepresentativeListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/representatives/{representative_id}`, but is otherwise the
    /// same as <see cref="IRepresentativeService.Get(RepresentativeGetParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<Representative>> Get(
        RepresentativeGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(RepresentativeGetParams, CancellationToken)"/>
    Task<HttpResponse<Representative>> Get(
        string representativeID,
        RepresentativeGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/representatives/{representative_id}/unmask`, but is otherwise the
    /// same as <see cref="IRepresentativeService.Unmask(RepresentativeUnmaskParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<Representative>> Unmask(
        RepresentativeUnmaskParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Unmask(RepresentativeUnmaskParams, CancellationToken)"/>
    Task<HttpResponse<Representative>> Unmask(
        string representativeID,
        RepresentativeUnmaskParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
