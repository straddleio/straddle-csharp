using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Services;

namespace Straddle;

/// <inheritdoc/>
public sealed class StraddleClient : IStraddleClient
{
    readonly ClientOptions _options;

    /// <inheritdoc/>
    public HttpClient HttpClient
    {
        get { return this._options.HttpClient; }
        init { this._options.HttpClient = value; }
    }

    /// <inheritdoc/>
    public string BaseUrl
    {
        get { return this._options.BaseUrl; }
        init { this._options.BaseUrl = value; }
    }

    /// <inheritdoc/>
    public bool ResponseValidation
    {
        get { return this._options.ResponseValidation; }
        init { this._options.ResponseValidation = value; }
    }

    /// <inheritdoc/>
    public int? MaxRetries
    {
        get { return this._options.MaxRetries; }
        init { this._options.MaxRetries = value; }
    }

    /// <inheritdoc/>
    public TimeSpan? Timeout
    {
        get { return this._options.Timeout; }
        init { this._options.Timeout = value; }
    }

    /// <inheritdoc/>
    public string ApiKey
    {
        get { return this._options.ApiKey; }
        init { this._options.ApiKey = value; }
    }

    readonly Lazy<IStraddleClientWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IStraddleClientWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    /// <inheritdoc/>
    public IStraddleClient WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new StraddleClient(modifier(this._options));
    }

    readonly Lazy<IEmbedService> _embed;
    public IEmbedService Embed
    {
        get { return _embed.Value; }
    }

    readonly Lazy<IBridgeService> _bridge;
    public IBridgeService Bridge
    {
        get { return _bridge.Value; }
    }

    readonly Lazy<ICustomerService> _customers;
    public ICustomerService Customers
    {
        get { return _customers.Value; }
    }

    readonly Lazy<IPaykeyService> _paykeys;
    public IPaykeyService Paykeys
    {
        get { return _paykeys.Value; }
    }

    readonly Lazy<IChargeService> _charges;
    public IChargeService Charges
    {
        get { return _charges.Value; }
    }

    readonly Lazy<IFundingEventService> _fundingEvents;
    public IFundingEventService FundingEvents
    {
        get { return _fundingEvents.Value; }
    }

    readonly Lazy<IPaymentService> _payments;
    public IPaymentService Payments
    {
        get { return _payments.Value; }
    }

    readonly Lazy<IPayoutService> _payouts;
    public IPayoutService Payouts
    {
        get { return _payouts.Value; }
    }

    readonly Lazy<IReportService> _reports;
    public IReportService Reports
    {
        get { return _reports.Value; }
    }

    public void Dispose() => this.HttpClient.Dispose();

    public StraddleClient()
    {
        _options = new();

        _withRawResponse = new(() => new StraddleClientWithRawResponse(this._options));
        _embed = new(() => new EmbedService(this));
        _bridge = new(() => new BridgeService(this));
        _customers = new(() => new CustomerService(this));
        _paykeys = new(() => new PaykeyService(this));
        _charges = new(() => new ChargeService(this));
        _fundingEvents = new(() => new FundingEventService(this));
        _payments = new(() => new PaymentService(this));
        _payouts = new(() => new PayoutService(this));
        _reports = new(() => new ReportService(this));
    }

    public StraddleClient(ClientOptions options)
        : this()
    {
        _options = options;
    }
}

/// <inheritdoc/>
public sealed class StraddleClientWithRawResponse : IStraddleClientWithRawResponse
{
#if NET
    static readonly Random Random = Random.Shared;
#else
    static readonly ThreadLocal<Random> _threadLocalRandom = new(() => new Random());

    static Random Random
    {
        get { return _threadLocalRandom.Value!; }
    }
#endif

    internal static HttpMethod PatchMethod = new("PATCH");

    readonly ClientOptions _options;

    /// <inheritdoc/>
    public HttpClient HttpClient
    {
        get { return this._options.HttpClient; }
        init { this._options.HttpClient = value; }
    }

    /// <inheritdoc/>
    public string BaseUrl
    {
        get { return this._options.BaseUrl; }
        init { this._options.BaseUrl = value; }
    }

    /// <inheritdoc/>
    public bool ResponseValidation
    {
        get { return this._options.ResponseValidation; }
        init { this._options.ResponseValidation = value; }
    }

    /// <inheritdoc/>
    public int? MaxRetries
    {
        get { return this._options.MaxRetries; }
        init { this._options.MaxRetries = value; }
    }

    /// <inheritdoc/>
    public TimeSpan? Timeout
    {
        get { return this._options.Timeout; }
        init { this._options.Timeout = value; }
    }

    /// <inheritdoc/>
    public string ApiKey
    {
        get { return this._options.ApiKey; }
        init { this._options.ApiKey = value; }
    }

    /// <inheritdoc/>
    public IStraddleClientWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new StraddleClientWithRawResponse(modifier(this._options));
    }

    readonly Lazy<IEmbedServiceWithRawResponse> _embed;
    public IEmbedServiceWithRawResponse Embed
    {
        get { return _embed.Value; }
    }

    readonly Lazy<IBridgeServiceWithRawResponse> _bridge;
    public IBridgeServiceWithRawResponse Bridge
    {
        get { return _bridge.Value; }
    }

    readonly Lazy<ICustomerServiceWithRawResponse> _customers;
    public ICustomerServiceWithRawResponse Customers
    {
        get { return _customers.Value; }
    }

    readonly Lazy<IPaykeyServiceWithRawResponse> _paykeys;
    public IPaykeyServiceWithRawResponse Paykeys
    {
        get { return _paykeys.Value; }
    }

    readonly Lazy<IChargeServiceWithRawResponse> _charges;
    public IChargeServiceWithRawResponse Charges
    {
        get { return _charges.Value; }
    }

    readonly Lazy<IFundingEventServiceWithRawResponse> _fundingEvents;
    public IFundingEventServiceWithRawResponse FundingEvents
    {
        get { return _fundingEvents.Value; }
    }

    readonly Lazy<IPaymentServiceWithRawResponse> _payments;
    public IPaymentServiceWithRawResponse Payments
    {
        get { return _payments.Value; }
    }

    readonly Lazy<IPayoutServiceWithRawResponse> _payouts;
    public IPayoutServiceWithRawResponse Payouts
    {
        get { return _payouts.Value; }
    }

    readonly Lazy<IReportServiceWithRawResponse> _reports;
    public IReportServiceWithRawResponse Reports
    {
        get { return _reports.Value; }
    }

    /// <inheritdoc/>
    public async Task<HttpResponse> Execute<T>(
        HttpRequest<T> request,
        CancellationToken cancellationToken = default
    )
        where T : ParamsBase
    {
        var maxRetries = this.MaxRetries ?? ClientOptions.DefaultMaxRetries;
        var retries = 0;
        while (true)
        {
            HttpResponse? response = null;
            try
            {
                response = await ExecuteOnce(request, retries, cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception e)
            {
                if (++retries > maxRetries || !ShouldRetry(e))
                {
                    throw;
                }
            }

            if (response != null && (++retries > maxRetries || !ShouldRetry(response)))
            {
                if (response.IsSuccessStatusCode)
                {
                    return response;
                }

                try
                {
                    throw StraddleExceptionFactory.CreateApiException(
                        response.StatusCode,
                        await response.ReadAsString(cancellationToken).ConfigureAwait(false)
                    );
                }
                catch (HttpRequestException e)
                {
                    throw new StraddleIOException("I/O Exception", e);
                }
                finally
                {
                    response.Dispose();
                }
            }

            var backoff = ComputeRetryBackoff(retries, response);
            response?.Dispose();
            await Task.Delay(backoff, cancellationToken).ConfigureAwait(false);
        }
    }

    async Task<HttpResponse> ExecuteOnce<T>(
        HttpRequest<T> request,
        int retryCount,
        CancellationToken cancellationToken = default
    )
        where T : ParamsBase
    {
        using HttpRequestMessage requestMessage = new(
            request.Method,
            request.Params.Url(this._options)
        )
        {
            Content = request.Params.BodyContent(),
        };
        request.Params.AddHeadersToRequest(requestMessage, this._options);
        if (!requestMessage.Headers.Contains("x-stainless-retry-count"))
        {
            requestMessage.Headers.Add("x-stainless-retry-count", retryCount.ToString());
        }
        using CancellationTokenSource timeoutCts = new(
            this.Timeout ?? ClientOptions.DefaultTimeout
        );
        using var cts = CancellationTokenSource.CreateLinkedTokenSource(
            timeoutCts.Token,
            cancellationToken
        );
        HttpResponseMessage responseMessage;
        try
        {
            responseMessage = await this
                .HttpClient.SendAsync(
                    requestMessage,
                    HttpCompletionOption.ResponseHeadersRead,
                    cts.Token
                )
                .ConfigureAwait(false);
        }
        catch (HttpRequestException e)
        {
            throw new StraddleIOException("I/O exception", e);
        }
        return new() { RawMessage = responseMessage, CancellationToken = cts.Token };
    }

    static TimeSpan ComputeRetryBackoff(int retries, HttpResponse? response)
    {
        TimeSpan? apiBackoff = ParseRetryAfterMsHeader(response) ?? ParseRetryAfterHeader(response);
        if (apiBackoff != null && apiBackoff < TimeSpan.FromMinutes(1))
        {
            // If the API asks us to wait a certain amount of time (and it's a reasonable amount), then just
            // do what it says.
            return (TimeSpan)apiBackoff;
        }

        // Apply exponential backoff, but not more than the max.
        var backoffSeconds = Math.Min(0.5 * Math.Pow(2.0, retries - 1), 8.0);
        var jitter = 1.0 - 0.25 * Random.NextDouble();
        return TimeSpan.FromSeconds(backoffSeconds * jitter);
    }

    static TimeSpan? ParseRetryAfterMsHeader(HttpResponse? response)
    {
        IEnumerable<string>? headerValues = null;
        response?.TryGetHeaderValues("Retry-After-Ms", out headerValues);
        var headerValue = headerValues == null ? null : Enumerable.FirstOrDefault(headerValues);
        if (headerValue == null)
        {
            return null;
        }

        if (float.TryParse(headerValue, out var retryAfterMs))
        {
            return TimeSpan.FromMilliseconds(retryAfterMs);
        }

        return null;
    }

    static TimeSpan? ParseRetryAfterHeader(HttpResponse? response)
    {
        IEnumerable<string>? headerValues = null;
        response?.TryGetHeaderValues("Retry-After", out headerValues);
        var headerValue = headerValues == null ? null : Enumerable.FirstOrDefault(headerValues);
        if (headerValue == null)
        {
            return null;
        }

        if (float.TryParse(headerValue, out var retryAfterSeconds))
        {
            return TimeSpan.FromSeconds(retryAfterSeconds);
        }
        else if (DateTimeOffset.TryParse(headerValue, out var retryAfterDate))
        {
            return retryAfterDate - DateTimeOffset.Now;
        }

        return null;
    }

    static bool ShouldRetry(HttpResponse response)
    {
        if (
            response.TryGetHeaderValues("X-Should-Retry", out var headerValues)
            && bool.TryParse(Enumerable.FirstOrDefault(headerValues), out var shouldRetry)
        )
        {
            // If the server explicitly says whether to retry, then we obey.
            return shouldRetry;
        }

        return (int)response.StatusCode switch
        {
            // Retry on request timeouts
            408
            or
            // Retry on lock timeouts
            409
            or
            // Retry on rate limits
            429
            or
            // Retry internal errors
            >= 500 => true,
            _ => false,
        };
    }

    static bool ShouldRetry(Exception e)
    {
        return e is IOException || e is StraddleIOException;
    }

    public void Dispose() => this.HttpClient.Dispose();

    public StraddleClientWithRawResponse()
    {
        _options = new();

        _embed = new(() => new EmbedServiceWithRawResponse(this));
        _bridge = new(() => new BridgeServiceWithRawResponse(this));
        _customers = new(() => new CustomerServiceWithRawResponse(this));
        _paykeys = new(() => new PaykeyServiceWithRawResponse(this));
        _charges = new(() => new ChargeServiceWithRawResponse(this));
        _fundingEvents = new(() => new FundingEventServiceWithRawResponse(this));
        _payments = new(() => new PaymentServiceWithRawResponse(this));
        _payouts = new(() => new PayoutServiceWithRawResponse(this));
        _reports = new(() => new ReportServiceWithRawResponse(this));
    }

    public StraddleClientWithRawResponse(ClientOptions options)
        : this()
    {
        _options = options;
    }
}
