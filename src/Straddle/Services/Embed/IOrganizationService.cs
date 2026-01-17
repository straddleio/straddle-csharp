using System;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.Embed.Organizations;

namespace Straddle.Services.Embed;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IOrganizationService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IOrganizationServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IOrganizationService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Creates a new organization related to your Straddle integration. Organizations
    /// can be used to group related accounts and manage permissions across multiple users.
    /// </summary>
    Task<OrganizationV1> Create(
        OrganizationCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves a list of organizations associated with your Straddle integration.
    /// The organizations are returned sorted by creation date, with the most recently
    /// created organizations appearing first. This endpoint supports advanced sorting
    /// and filtering options to help you find specific organizations.
    /// </summary>
    Task<OrganizationListPage> List(
        OrganizationListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the details of an Organization that has previously been created.
    /// Supply the unique organization ID that was returned from your previous request,
    /// and Straddle will return the corresponding organization information.
    /// </summary>
    Task<OrganizationV1> Get(
        OrganizationGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(OrganizationGetParams, CancellationToken)"/>
    Task<OrganizationV1> Get(
        string organizationID,
        OrganizationGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IOrganizationService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IOrganizationServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IOrganizationServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `post /v1/organizations`, but is otherwise the
    /// same as <see cref="IOrganizationService.Create(OrganizationCreateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<OrganizationV1>> Create(
        OrganizationCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/organizations`, but is otherwise the
    /// same as <see cref="IOrganizationService.List(OrganizationListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<OrganizationListPage>> List(
        OrganizationListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/organizations/{organization_id}`, but is otherwise the
    /// same as <see cref="IOrganizationService.Get(OrganizationGetParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<OrganizationV1>> Get(
        OrganizationGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(OrganizationGetParams, CancellationToken)"/>
    Task<HttpResponse<OrganizationV1>> Get(
        string organizationID,
        OrganizationGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
