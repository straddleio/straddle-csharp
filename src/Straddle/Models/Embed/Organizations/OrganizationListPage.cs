using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Services.Embed;

namespace Straddle.Models.Embed.Organizations;

/// <summary>
/// A single page from the paginated endpoint that <see cref="IOrganizationService.List(OrganizationListParams, CancellationToken)"/> queries.
/// </summary>
public sealed class OrganizationListPage(
    IOrganizationServiceWithRawResponse service,
    OrganizationListParams parameters,
    OrganizationPagedV1 response
) : IPage<Data>
{
    /// <inheritdoc/>
    public IReadOnlyList<Data> Items
    {
        get { return response.Data; }
    }

    /// <inheritdoc/>
    public bool HasNext()
    {
        return this.Items.Count > 0;
    }

    /// <inheritdoc/>
    async Task<IPage<Data>> IPage<Data>.Next(CancellationToken cancellationToken) =>
        await this.Next(cancellationToken).ConfigureAwait(false);

    /// <inheritdoc cref="IPage{T}.Next"/>
    public async Task<OrganizationListPage> Next(CancellationToken cancellationToken = default)
    {
        var currentPageNumber = parameters.PageNumber ?? 1;
        using var nextResponse = await service
            .List(parameters with { PageNumber = currentPageNumber + 1 }, cancellationToken)
            .ConfigureAwait(false);
        return await nextResponse.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public void Validate()
    {
        response.Validate();
    }

    public override string ToString() =>
        JsonSerializer.Serialize(this.Items, ModelBase.ToStringSerializerOptions);

    public override bool Equals(object? obj)
    {
        if (obj is not OrganizationListPage other)
        {
            return false;
        }

        return Enumerable.SequenceEqual(this.Items, other.Items);
    }

    public override int GetHashCode() => 0;
}
