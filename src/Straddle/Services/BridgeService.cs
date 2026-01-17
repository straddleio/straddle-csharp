using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.Bridge;
using Straddle.Services.Bridge;

namespace Straddle.Services;

/// <inheritdoc/>
public sealed class BridgeService : IBridgeService
{
    readonly Lazy<IBridgeServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IBridgeServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IStraddleClient _client;

    /// <inheritdoc/>
    public IBridgeService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new BridgeService(this._client.WithOptions(modifier));
    }

    public BridgeService(IStraddleClient client)
    {
        _client = client;

        _withRawResponse = new(() => new BridgeServiceWithRawResponse(client.WithRawResponse));
        _link = new(() => new LinkService(client));
    }

    readonly Lazy<ILinkService> _link;
    public ILinkService Link
    {
        get { return _link.Value; }
    }

    /// <inheritdoc/>
    public async Task<BridgeTokenV1> Initialize(
        BridgeInitializeParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Initialize(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class BridgeServiceWithRawResponse : IBridgeServiceWithRawResponse
{
    readonly IStraddleClientWithRawResponse _client;

    /// <inheritdoc/>
    public IBridgeServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new BridgeServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public BridgeServiceWithRawResponse(IStraddleClientWithRawResponse client)
    {
        _client = client;

        _link = new(() => new LinkServiceWithRawResponse(client));
    }

    readonly Lazy<ILinkServiceWithRawResponse> _link;
    public ILinkServiceWithRawResponse Link
    {
        get { return _link.Value; }
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<BridgeTokenV1>> Initialize(
        BridgeInitializeParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<BridgeInitializeParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var bridgeTokenV1 = await response
                    .Deserialize<BridgeTokenV1>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    bridgeTokenV1.Validate();
                }
                return bridgeTokenV1;
            }
        );
    }
}
