using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Paykeys;
using Straddle.Models.Paykeys.Review;

namespace Straddle.Services.Paykeys;

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
    public async Task<PaykeyV1> Decision(
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
    public Task<PaykeyV1> Decision(
        string id,
        ReviewDecisionParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Decision(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<ReviewGetResponse> Get(
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
    public Task<ReviewGetResponse> Get(
        string id,
        ReviewGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<PaykeyV1> RefreshReview(
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
    public Task<PaykeyV1> RefreshReview(
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
    public async Task<HttpResponse<PaykeyV1>> Decision(
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
    public Task<HttpResponse<PaykeyV1>> Decision(
        string id,
        ReviewDecisionParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Decision(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ReviewGetResponse>> Get(
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
                var review = await response
                    .Deserialize<ReviewGetResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    review.Validate();
                }
                return review;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<ReviewGetResponse>> Get(
        string id,
        ReviewGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<PaykeyV1>> RefreshReview(
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
    public Task<HttpResponse<PaykeyV1>> RefreshReview(
        string id,
        ReviewRefreshReviewParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.RefreshReview(parameters with { ID = id }, cancellationToken);
    }
}
