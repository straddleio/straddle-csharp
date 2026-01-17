using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Charges;

namespace Straddle.Services;

/// <inheritdoc/>
public sealed class ChargeService : IChargeService
{
    readonly Lazy<IChargeServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IChargeServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IStraddleClient _client;

    /// <inheritdoc/>
    public IChargeService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ChargeService(this._client.WithOptions(modifier));
    }

    public ChargeService(IStraddleClient client)
    {
        _client = client;

        _withRawResponse = new(() => new ChargeServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<ChargeV1> Create(
        ChargeCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Create(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<ChargeV1> Update(
        ChargeUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Update(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<ChargeV1> Update(
        string id,
        ChargeUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Update(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<ChargeV1> Cancel(
        ChargeCancelParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Cancel(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<ChargeV1> Cancel(
        string id,
        ChargeCancelParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Cancel(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<ChargeV1> Get(
        ChargeGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Get(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<ChargeV1> Get(
        string id,
        ChargeGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<ChargeV1> Hold(
        ChargeHoldParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Hold(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<ChargeV1> Hold(
        string id,
        ChargeHoldParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Hold(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<ChargeV1> Release(
        ChargeReleaseParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Release(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<ChargeV1> Release(
        string id,
        ChargeReleaseParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Release(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<ChargeUnmaskResponse> Unmask(
        ChargeUnmaskParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Unmask(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<ChargeUnmaskResponse> Unmask(
        string id,
        ChargeUnmaskParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Unmask(parameters with { ID = id }, cancellationToken);
    }
}

/// <inheritdoc/>
public sealed class ChargeServiceWithRawResponse : IChargeServiceWithRawResponse
{
    readonly IStraddleClientWithRawResponse _client;

    /// <inheritdoc/>
    public IChargeServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ChargeServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public ChargeServiceWithRawResponse(IStraddleClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ChargeV1>> Create(
        ChargeCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<ChargeCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var chargeV1 = await response.Deserialize<ChargeV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    chargeV1.Validate();
                }
                return chargeV1;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ChargeV1>> Update(
        ChargeUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<ChargeUpdateParams> request = new()
        {
            Method = HttpMethod.Put,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var chargeV1 = await response.Deserialize<ChargeV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    chargeV1.Validate();
                }
                return chargeV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<ChargeV1>> Update(
        string id,
        ChargeUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Update(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ChargeV1>> Cancel(
        ChargeCancelParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<ChargeCancelParams> request = new()
        {
            Method = HttpMethod.Put,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var chargeV1 = await response.Deserialize<ChargeV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    chargeV1.Validate();
                }
                return chargeV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<ChargeV1>> Cancel(
        string id,
        ChargeCancelParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Cancel(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ChargeV1>> Get(
        ChargeGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<ChargeGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var chargeV1 = await response.Deserialize<ChargeV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    chargeV1.Validate();
                }
                return chargeV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<ChargeV1>> Get(
        string id,
        ChargeGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ChargeV1>> Hold(
        ChargeHoldParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<ChargeHoldParams> request = new()
        {
            Method = HttpMethod.Put,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var chargeV1 = await response.Deserialize<ChargeV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    chargeV1.Validate();
                }
                return chargeV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<ChargeV1>> Hold(
        string id,
        ChargeHoldParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Hold(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ChargeV1>> Release(
        ChargeReleaseParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<ChargeReleaseParams> request = new()
        {
            Method = HttpMethod.Put,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var chargeV1 = await response.Deserialize<ChargeV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    chargeV1.Validate();
                }
                return chargeV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<ChargeV1>> Release(
        string id,
        ChargeReleaseParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Release(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ChargeUnmaskResponse>> Unmask(
        ChargeUnmaskParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<ChargeUnmaskParams> request = new()
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
                    .Deserialize<ChargeUnmaskResponse>(token)
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
    public Task<HttpResponse<ChargeUnmaskResponse>> Unmask(
        string id,
        ChargeUnmaskParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Unmask(parameters with { ID = id }, cancellationToken);
    }
}
