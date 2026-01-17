using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Embed.Representatives;

namespace Straddle.Services.Embed;

/// <inheritdoc/>
public sealed class RepresentativeService : IRepresentativeService
{
    readonly Lazy<IRepresentativeServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IRepresentativeServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IStraddleClient _client;

    /// <inheritdoc/>
    public IRepresentativeService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new RepresentativeService(this._client.WithOptions(modifier));
    }

    public RepresentativeService(IStraddleClient client)
    {
        _client = client;

        _withRawResponse = new(() =>
            new RepresentativeServiceWithRawResponse(client.WithRawResponse)
        );
    }

    /// <inheritdoc/>
    public async Task<Representative> Create(
        RepresentativeCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Create(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<Representative> Update(
        RepresentativeUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Update(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<Representative> Update(
        string representativeID,
        RepresentativeUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Update(
            parameters with
            {
                RepresentativeID = representativeID,
            },
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public async Task<RepresentativeListPage> List(
        RepresentativeListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<Representative> Get(
        RepresentativeGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Get(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<Representative> Get(
        string representativeID,
        RepresentativeGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { RepresentativeID = representativeID }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<Representative> Unmask(
        RepresentativeUnmaskParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Unmask(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<Representative> Unmask(
        string representativeID,
        RepresentativeUnmaskParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Unmask(
            parameters with
            {
                RepresentativeID = representativeID,
            },
            cancellationToken
        );
    }
}

/// <inheritdoc/>
public sealed class RepresentativeServiceWithRawResponse : IRepresentativeServiceWithRawResponse
{
    readonly IStraddleClientWithRawResponse _client;

    /// <inheritdoc/>
    public IRepresentativeServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new RepresentativeServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public RepresentativeServiceWithRawResponse(IStraddleClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<Representative>> Create(
        RepresentativeCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<RepresentativeCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var representative = await response
                    .Deserialize<Representative>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    representative.Validate();
                }
                return representative;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<Representative>> Update(
        RepresentativeUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.RepresentativeID == null)
        {
            throw new StraddleInvalidDataException("'parameters.RepresentativeID' cannot be null");
        }

        HttpRequest<RepresentativeUpdateParams> request = new()
        {
            Method = HttpMethod.Put,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var representative = await response
                    .Deserialize<Representative>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    representative.Validate();
                }
                return representative;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<Representative>> Update(
        string representativeID,
        RepresentativeUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Update(
            parameters with
            {
                RepresentativeID = representativeID,
            },
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<RepresentativeListPage>> List(
        RepresentativeListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<RepresentativeListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var page = await response
                    .Deserialize<RepresentativePaged>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new RepresentativeListPage(this, parameters, page);
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<Representative>> Get(
        RepresentativeGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.RepresentativeID == null)
        {
            throw new StraddleInvalidDataException("'parameters.RepresentativeID' cannot be null");
        }

        HttpRequest<RepresentativeGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var representative = await response
                    .Deserialize<Representative>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    representative.Validate();
                }
                return representative;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<Representative>> Get(
        string representativeID,
        RepresentativeGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { RepresentativeID = representativeID }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<Representative>> Unmask(
        RepresentativeUnmaskParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.RepresentativeID == null)
        {
            throw new StraddleInvalidDataException("'parameters.RepresentativeID' cannot be null");
        }

        HttpRequest<RepresentativeUnmaskParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var representative = await response
                    .Deserialize<Representative>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    representative.Validate();
                }
                return representative;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<Representative>> Unmask(
        string representativeID,
        RepresentativeUnmaskParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Unmask(
            parameters with
            {
                RepresentativeID = representativeID,
            },
            cancellationToken
        );
    }
}
