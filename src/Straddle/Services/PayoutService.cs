using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Payouts;

namespace Straddle.Services;

/// <inheritdoc/>
public sealed class PayoutService : IPayoutService
{
    readonly Lazy<IPayoutServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IPayoutServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IStraddleClient _client;

    /// <inheritdoc/>
    public IPayoutService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new PayoutService(this._client.WithOptions(modifier));
    }

    public PayoutService(IStraddleClient client)
    {
        _client = client;

        _withRawResponse = new(() => new PayoutServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<PayoutV1> Create(
        PayoutCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Create(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<PayoutV1> Update(
        PayoutUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Update(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<PayoutV1> Update(
        string id,
        PayoutUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Update(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<PayoutV1> Cancel(
        PayoutCancelParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Cancel(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<PayoutV1> Cancel(
        string id,
        PayoutCancelParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Cancel(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<PayoutV1> Get(
        PayoutGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Get(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<PayoutV1> Get(
        string id,
        PayoutGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<PayoutV1> Hold(
        PayoutHoldParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Hold(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<PayoutV1> Hold(
        string id,
        PayoutHoldParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Hold(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<PayoutV1> Release(
        PayoutReleaseParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Release(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<PayoutV1> Release(
        string id,
        PayoutReleaseParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Release(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<PayoutUnmaskResponse> Unmask(
        PayoutUnmaskParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Unmask(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<PayoutUnmaskResponse> Unmask(
        string id,
        PayoutUnmaskParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Unmask(parameters with { ID = id }, cancellationToken);
    }
}

/// <inheritdoc/>
public sealed class PayoutServiceWithRawResponse : IPayoutServiceWithRawResponse
{
    readonly IStraddleClientWithRawResponse _client;

    /// <inheritdoc/>
    public IPayoutServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new PayoutServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public PayoutServiceWithRawResponse(IStraddleClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PayoutV1>> Create(
        PayoutCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<PayoutCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var payoutV1 = await response.Deserialize<PayoutV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    payoutV1.Validate();
                }
                return payoutV1;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PayoutV1>> Update(
        PayoutUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<PayoutUpdateParams> request = new()
        {
            Method = HttpMethod.Put,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var payoutV1 = await response.Deserialize<PayoutV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    payoutV1.Validate();
                }
                return payoutV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<PayoutV1>> Update(
        string id,
        PayoutUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Update(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PayoutV1>> Cancel(
        PayoutCancelParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<PayoutCancelParams> request = new()
        {
            Method = HttpMethod.Put,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var payoutV1 = await response.Deserialize<PayoutV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    payoutV1.Validate();
                }
                return payoutV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<PayoutV1>> Cancel(
        string id,
        PayoutCancelParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Cancel(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PayoutV1>> Get(
        PayoutGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<PayoutGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var payoutV1 = await response.Deserialize<PayoutV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    payoutV1.Validate();
                }
                return payoutV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<PayoutV1>> Get(
        string id,
        PayoutGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PayoutV1>> Hold(
        PayoutHoldParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<PayoutHoldParams> request = new()
        {
            Method = HttpMethod.Put,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var payoutV1 = await response.Deserialize<PayoutV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    payoutV1.Validate();
                }
                return payoutV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<PayoutV1>> Hold(
        string id,
        PayoutHoldParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Hold(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PayoutV1>> Release(
        PayoutReleaseParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<PayoutReleaseParams> request = new()
        {
            Method = HttpMethod.Put,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var payoutV1 = await response.Deserialize<PayoutV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    payoutV1.Validate();
                }
                return payoutV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<PayoutV1>> Release(
        string id,
        PayoutReleaseParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Release(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PayoutUnmaskResponse>> Unmask(
        PayoutUnmaskParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<PayoutUnmaskParams> request = new()
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
                    .Deserialize<PayoutUnmaskResponse>(token)
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
    public Task<HttpResponse<PayoutUnmaskResponse>> Unmask(
        string id,
        PayoutUnmaskParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Unmask(parameters with { ID = id }, cancellationToken);
    }
}
