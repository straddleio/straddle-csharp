using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Services.Embed;

namespace Straddle.Models.Embed.Representatives;

/// <summary>
/// A single page from the paginated endpoint that <see cref="IRepresentativeService.List(RepresentativeListParams, CancellationToken)"/> queries.
/// </summary>
public sealed class RepresentativeListPage(
    IRepresentativeServiceWithRawResponse service,
    RepresentativeListParams parameters,
    RepresentativePaged response
) : IPage<RepresentativePagedData>
{
    /// <inheritdoc/>
    public IReadOnlyList<RepresentativePagedData> Items
    {
        get { return response.Data; }
    }

    /// <inheritdoc/>
    public bool HasNext()
    {
        return this.Items.Count > 0;
    }

    /// <inheritdoc/>
    async Task<IPage<RepresentativePagedData>> IPage<RepresentativePagedData>.Next(
        CancellationToken cancellationToken
    ) => await this.Next(cancellationToken).ConfigureAwait(false);

    /// <inheritdoc cref="IPage{T}.Next"/>
    public async Task<RepresentativeListPage> Next(CancellationToken cancellationToken = default)
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
        if (obj is not RepresentativeListPage other)
        {
            return false;
        }

        return Enumerable.SequenceEqual(this.Items, other.Items);
    }

    public override int GetHashCode() => 0;
}
