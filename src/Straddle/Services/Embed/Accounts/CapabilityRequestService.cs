using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Embed.Accounts.CapabilityRequests;

namespace Straddle.Services.Embed.Accounts;

/// <inheritdoc/>
public sealed class CapabilityRequestService : ICapabilityRequestService
{
    readonly Lazy<ICapabilityRequestServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public ICapabilityRequestServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IStraddleClient _client;

    /// <inheritdoc/>
    public ICapabilityRequestService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new CapabilityRequestService(this._client.WithOptions(modifier));
    }

    public CapabilityRequestService(IStraddleClient client)
    {
        _client = client;

        _withRawResponse = new(() =>
            new CapabilityRequestServiceWithRawResponse(client.WithRawResponse)
        );
    }

    /// <inheritdoc/>
    public async Task<CapabilityRequestPagedV1> Create(
        CapabilityRequestCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Create(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<CapabilityRequestPagedV1> Create(
        string accountID,
        CapabilityRequestCreateParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Create(parameters with { AccountID = accountID }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<CapabilityRequestListPage> List(
        CapabilityRequestListParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<CapabilityRequestListPage> List(
        string accountID,
        CapabilityRequestListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.List(parameters with { AccountID = accountID }, cancellationToken);
    }
}

/// <inheritdoc/>
public sealed class CapabilityRequestServiceWithRawResponse
    : ICapabilityRequestServiceWithRawResponse
{
    readonly IStraddleClientWithRawResponse _client;

    /// <inheritdoc/>
    public ICapabilityRequestServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new CapabilityRequestServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public CapabilityRequestServiceWithRawResponse(IStraddleClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<CapabilityRequestPagedV1>> Create(
        CapabilityRequestCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.AccountID == null)
        {
            throw new StraddleInvalidDataException("'parameters.AccountID' cannot be null");
        }

        HttpRequest<CapabilityRequestCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var capabilityRequestPagedV1 = await response
                    .Deserialize<CapabilityRequestPagedV1>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    capabilityRequestPagedV1.Validate();
                }
                return capabilityRequestPagedV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<CapabilityRequestPagedV1>> Create(
        string accountID,
        CapabilityRequestCreateParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Create(parameters with { AccountID = accountID }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<CapabilityRequestListPage>> List(
        CapabilityRequestListParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.AccountID == null)
        {
            throw new StraddleInvalidDataException("'parameters.AccountID' cannot be null");
        }

        HttpRequest<CapabilityRequestListParams> request = new()
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
                    .Deserialize<CapabilityRequestPagedV1>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new CapabilityRequestListPage(this, parameters, page);
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<CapabilityRequestListPage>> List(
        string accountID,
        CapabilityRequestListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.List(parameters with { AccountID = accountID }, cancellationToken);
    }
}
