using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Customers;
using Straddle.Models.Customers.Review;

namespace Straddle.Services.Customers;

/// <inheritdoc/>
public sealed class ReviewService : IReviewService
{
    readonly Lazy<IReviewServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IReviewServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IStraddleClient _client;

    /// <inheritdoc/>
    public IReviewService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ReviewService(this._client.WithOptions(modifier));
    }

    public ReviewService(IStraddleClient client)
    {
        _client = client;

        _withRawResponse = new(() => new ReviewServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<CustomerV1> Decision(
        ReviewDecisionParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Decision(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<CustomerV1> Decision(
        string id,
        ReviewDecisionParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Decision(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<CustomerReviewV1> Get(
        ReviewGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Get(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<CustomerReviewV1> Get(
        string id,
        ReviewGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<CustomerV1> RefreshReview(
        ReviewRefreshReviewParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.RefreshReview(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<CustomerV1> RefreshReview(
        string id,
        ReviewRefreshReviewParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.RefreshReview(parameters with { ID = id }, cancellationToken);
    }
}

/// <inheritdoc/>
public sealed class ReviewServiceWithRawResponse : IReviewServiceWithRawResponse
{
    readonly IStraddleClientWithRawResponse _client;

    /// <inheritdoc/>
    public IReviewServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ReviewServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public ReviewServiceWithRawResponse(IStraddleClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<CustomerV1>> Decision(
        ReviewDecisionParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<ReviewDecisionParams> request = new()
        {
            Method = StraddleClientWithRawResponse.PatchMethod,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var customerV1 = await response
                    .Deserialize<CustomerV1>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    customerV1.Validate();
                }
                return customerV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<CustomerV1>> Decision(
        string id,
        ReviewDecisionParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Decision(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<CustomerReviewV1>> Get(
        ReviewGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<ReviewGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var customerReviewV1 = await response
                    .Deserialize<CustomerReviewV1>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    customerReviewV1.Validate();
                }
                return customerReviewV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<CustomerReviewV1>> Get(
        string id,
        ReviewGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<CustomerV1>> RefreshReview(
        ReviewRefreshReviewParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<ReviewRefreshReviewParams> request = new()
        {
            Method = HttpMethod.Put,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var customerV1 = await response
                    .Deserialize<CustomerV1>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    customerV1.Validate();
                }
                return customerV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<CustomerV1>> RefreshReview(
        string id,
        ReviewRefreshReviewParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.RefreshReview(parameters with { ID = id }, cancellationToken);
    }
}
