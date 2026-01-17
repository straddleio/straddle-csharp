using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.Reports;

namespace Straddle.Services;

/// <inheritdoc/>
public sealed class ReportService : IReportService
{
    readonly Lazy<IReportServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IReportServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IStraddleClient _client;

    /// <inheritdoc/>
    public IReportService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ReportService(this._client.WithOptions(modifier));
    }

    public ReportService(IStraddleClient client)
    {
        _client = client;

        _withRawResponse = new(() => new ReportServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<ReportCreateTotalCustomersByStatusResponse> CreateTotalCustomersByStatus(
        ReportCreateTotalCustomersByStatusParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.CreateTotalCustomersByStatus(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class ReportServiceWithRawResponse : IReportServiceWithRawResponse
{
    readonly IStraddleClientWithRawResponse _client;

    /// <inheritdoc/>
    public IReportServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ReportServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public ReportServiceWithRawResponse(IStraddleClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<
        HttpResponse<ReportCreateTotalCustomersByStatusResponse>
    > CreateTotalCustomersByStatus(
        ReportCreateTotalCustomersByStatusParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<ReportCreateTotalCustomersByStatusParams> request = new()
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
                    .Deserialize<ReportCreateTotalCustomersByStatusResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    deserializedResponse.Validate();
                }
                return deserializedResponse;
            }
        );
    }
}
