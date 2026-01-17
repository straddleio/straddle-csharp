using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.Bridge.Link;
using Straddle.Models.Paykeys;

namespace Straddle.Services.Bridge;

/// <inheritdoc/>
public sealed class LinkService : ILinkService
{
    readonly Lazy<ILinkServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public ILinkServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IStraddleClient _client;

    /// <inheritdoc/>
    public ILinkService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new LinkService(this._client.WithOptions(modifier));
    }

    public LinkService(IStraddleClient client)
    {
        _client = client;

        _withRawResponse = new(() => new LinkServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<PaykeyV1> BankAccount(
        LinkBankAccountParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.BankAccount(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<LinkCreatePaykeyResponse> CreatePaykey(
        LinkCreatePaykeyParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.CreatePaykey(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<LinkCreateTanResponse> CreateTan(
        LinkCreateTanParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.CreateTan(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<PaykeyV1> Plaid(
        LinkPlaidParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Plaid(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class LinkServiceWithRawResponse : ILinkServiceWithRawResponse
{
    readonly IStraddleClientWithRawResponse _client;

    /// <inheritdoc/>
    public ILinkServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new LinkServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public LinkServiceWithRawResponse(IStraddleClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PaykeyV1>> BankAccount(
        LinkBankAccountParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<LinkBankAccountParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var paykeyV1 = await response.Deserialize<PaykeyV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    paykeyV1.Validate();
                }
                return paykeyV1;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<LinkCreatePaykeyResponse>> CreatePaykey(
        LinkCreatePaykeyParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<LinkCreatePaykeyParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var deserializedResponse = await response
                    .Deserialize<LinkCreatePaykeyResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    deserializedResponse.Validate();
                }
                return deserializedResponse;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<LinkCreateTanResponse>> CreateTan(
        LinkCreateTanParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<LinkCreateTanParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var deserializedResponse = await response
                    .Deserialize<LinkCreateTanResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    deserializedResponse.Validate();
                }
                return deserializedResponse;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PaykeyV1>> Plaid(
        LinkPlaidParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<LinkPlaidParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var paykeyV1 = await response.Deserialize<PaykeyV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    paykeyV1.Validate();
                }
                return paykeyV1;
            }
        );
    }
}
