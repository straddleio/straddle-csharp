using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Paykeys;
using Straddle.Services.Paykeys;

namespace Straddle.Services;

/// <inheritdoc/>
public sealed class PaykeyService : IPaykeyService
{
    readonly Lazy<IPaykeyServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IPaykeyServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IStraddleClient _client;

    /// <inheritdoc/>
    public IPaykeyService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new PaykeyService(this._client.WithOptions(modifier));
    }

    public PaykeyService(IStraddleClient client)
    {
        _client = client;

        _withRawResponse = new(() => new PaykeyServiceWithRawResponse(client.WithRawResponse));
        _review = new(() => new ReviewService(client));
    }

    readonly Lazy<IReviewService> _review;
    public IReviewService Review
    {
        get { return _review.Value; }
    }

    /// <inheritdoc/>
    public async Task<PaykeyListPage> List(
        PaykeyListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<PaykeyV1> Cancel(
        PaykeyCancelParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Cancel(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<PaykeyV1> Cancel(
        string id,
        PaykeyCancelParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Cancel(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<PaykeyV1> Get(
        PaykeyGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Get(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<PaykeyV1> Get(
        string id,
        PaykeyGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<PaykeyRevealResponse> Reveal(
        PaykeyRevealParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Reveal(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<PaykeyRevealResponse> Reveal(
        string id,
        PaykeyRevealParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Reveal(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<PaykeyUnmaskedV1> Unmasked(
        PaykeyUnmaskedParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Unmasked(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<PaykeyUnmaskedV1> Unmasked(
        string id,
        PaykeyUnmaskedParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Unmasked(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<PaykeyV1> UpdateBalance(
        PaykeyUpdateBalanceParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.UpdateBalance(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<PaykeyV1> UpdateBalance(
        string id,
        PaykeyUpdateBalanceParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.UpdateBalance(parameters with { ID = id }, cancellationToken);
    }
}

/// <inheritdoc/>
public sealed class PaykeyServiceWithRawResponse : IPaykeyServiceWithRawResponse
{
    readonly IStraddleClientWithRawResponse _client;

    /// <inheritdoc/>
    public IPaykeyServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new PaykeyServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public PaykeyServiceWithRawResponse(IStraddleClientWithRawResponse client)
    {
        _client = client;

        _review = new(() => new ReviewServiceWithRawResponse(client));
    }

    readonly Lazy<IReviewServiceWithRawResponse> _review;
    public IReviewServiceWithRawResponse Review
    {
        get { return _review.Value; }
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PaykeyListPage>> List(
        PaykeyListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<PaykeyListParams> request = new()
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
                    .Deserialize<PaykeySummaryPagedV1>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new PaykeyListPage(this, parameters, page);
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PaykeyV1>> Cancel(
        PaykeyCancelParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<PaykeyCancelParams> request = new()
        {
            Method = HttpMethod.Put,
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
    public Task<HttpResponse<PaykeyV1>> Cancel(
        string id,
        PaykeyCancelParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Cancel(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PaykeyV1>> Get(
        PaykeyGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<PaykeyGetParams> request = new()
        {
            Method = HttpMethod.Get,
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
    public Task<HttpResponse<PaykeyV1>> Get(
        string id,
        PaykeyGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PaykeyRevealResponse>> Reveal(
        PaykeyRevealParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<PaykeyRevealParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var deserializedResponse = await response
                    .Deserialize<PaykeyRevealResponse>(token)
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
    public Task<HttpResponse<PaykeyRevealResponse>> Reveal(
        string id,
        PaykeyRevealParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Reveal(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PaykeyUnmaskedV1>> Unmasked(
        PaykeyUnmaskedParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<PaykeyUnmaskedParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var paykeyUnmaskedV1 = await response
                    .Deserialize<PaykeyUnmaskedV1>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    paykeyUnmaskedV1.Validate();
                }
                return paykeyUnmaskedV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<PaykeyUnmaskedV1>> Unmasked(
        string id,
        PaykeyUnmaskedParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Unmasked(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PaykeyV1>> UpdateBalance(
        PaykeyUpdateBalanceParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<PaykeyUpdateBalanceParams> request = new()
        {
            Method = HttpMethod.Put,
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
    public Task<HttpResponse<PaykeyV1>> UpdateBalance(
        string id,
        PaykeyUpdateBalanceParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.UpdateBalance(parameters with { ID = id }, cancellationToken);
    }
}
