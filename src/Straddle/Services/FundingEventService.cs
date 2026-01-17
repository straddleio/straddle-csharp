using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.FundingEvents;

namespace Straddle.Services;

/// <inheritdoc/>
public sealed class FundingEventService : IFundingEventService
{
    readonly Lazy<IFundingEventServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IFundingEventServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IStraddleClient _client;

    /// <inheritdoc/>
    public IFundingEventService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new FundingEventService(this._client.WithOptions(modifier));
    }

    public FundingEventService(IStraddleClient client)
    {
        _client = client;

        _withRawResponse = new(() =>
            new FundingEventServiceWithRawResponse(client.WithRawResponse)
        );
    }

    /// <inheritdoc/>
    public async Task<FundingEventListPage> List(
        FundingEventListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<FundingEventSummaryItemV1> Get(
        FundingEventGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Get(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<FundingEventSummaryItemV1> Get(
        string id,
        FundingEventGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }
}

/// <inheritdoc/>
public sealed class FundingEventServiceWithRawResponse : IFundingEventServiceWithRawResponse
{
    readonly IStraddleClientWithRawResponse _client;

    /// <inheritdoc/>
    public IFundingEventServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new FundingEventServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public FundingEventServiceWithRawResponse(IStraddleClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<FundingEventListPage>> List(
        FundingEventListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<FundingEventListParams> request = new()
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
                    .Deserialize<FundingEventSummaryPagedV1>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new FundingEventListPage(this, parameters, page);
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<FundingEventSummaryItemV1>> Get(
        FundingEventGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new StraddleInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<FundingEventGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var fundingEventSummaryItemV1 = await response
                    .Deserialize<FundingEventSummaryItemV1>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    fundingEventSummaryItemV1.Validate();
                }
                return fundingEventSummaryItemV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<FundingEventSummaryItemV1>> Get(
        string id,
        FundingEventGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { ID = id }, cancellationToken);
    }
}
