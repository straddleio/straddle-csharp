using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Embed.Accounts;
using Straddle.Services.Embed.Accounts;

namespace Straddle.Services.Embed;

/// <inheritdoc/>
public sealed class AccountService : IAccountService
{
    readonly Lazy<IAccountServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IAccountServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IStraddleClient _client;

    /// <inheritdoc/>
    public IAccountService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AccountService(this._client.WithOptions(modifier));
    }

    public AccountService(IStraddleClient client)
    {
        _client = client;

        _withRawResponse = new(() => new AccountServiceWithRawResponse(client.WithRawResponse));
        _capabilityRequests = new(() => new CapabilityRequestService(client));
    }

    readonly Lazy<ICapabilityRequestService> _capabilityRequests;
    public ICapabilityRequestService CapabilityRequests
    {
        get { return _capabilityRequests.Value; }
    }

    /// <inheritdoc/>
    public async Task<AccountV1> Create(
        AccountCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Create(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<AccountV1> Update(
        AccountUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Update(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<AccountV1> Update(
        string accountID,
        AccountUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Update(parameters with { AccountID = accountID }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<AccountListPage> List(
        AccountListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<AccountV1> Get(
        AccountGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Get(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<AccountV1> Get(
        string accountID,
        AccountGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { AccountID = accountID }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<AccountV1> Onboard(
        AccountOnboardParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Onboard(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<AccountV1> Onboard(
        string accountID,
        AccountOnboardParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Onboard(parameters with { AccountID = accountID }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<AccountV1> Simulate(
        AccountSimulateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Simulate(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<AccountV1> Simulate(
        string accountID,
        AccountSimulateParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Simulate(parameters with { AccountID = accountID }, cancellationToken);
    }
}

/// <inheritdoc/>
public sealed class AccountServiceWithRawResponse : IAccountServiceWithRawResponse
{
    readonly IStraddleClientWithRawResponse _client;

    /// <inheritdoc/>
    public IAccountServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AccountServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public AccountServiceWithRawResponse(IStraddleClientWithRawResponse client)
    {
        _client = client;

        _capabilityRequests = new(() => new CapabilityRequestServiceWithRawResponse(client));
    }

    readonly Lazy<ICapabilityRequestServiceWithRawResponse> _capabilityRequests;
    public ICapabilityRequestServiceWithRawResponse CapabilityRequests
    {
        get { return _capabilityRequests.Value; }
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AccountV1>> Create(
        AccountCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<AccountCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var accountV1 = await response.Deserialize<AccountV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    accountV1.Validate();
                }
                return accountV1;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AccountV1>> Update(
        AccountUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.AccountID == null)
        {
            throw new StraddleInvalidDataException("'parameters.AccountID' cannot be null");
        }

        HttpRequest<AccountUpdateParams> request = new()
        {
            Method = HttpMethod.Put,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var accountV1 = await response.Deserialize<AccountV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    accountV1.Validate();
                }
                return accountV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<AccountV1>> Update(
        string accountID,
        AccountUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Update(parameters with { AccountID = accountID }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AccountListPage>> List(
        AccountListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<AccountListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var page = await response.Deserialize<AccountPagedV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new AccountListPage(this, parameters, page);
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AccountV1>> Get(
        AccountGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.AccountID == null)
        {
            throw new StraddleInvalidDataException("'parameters.AccountID' cannot be null");
        }

        HttpRequest<AccountGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var accountV1 = await response.Deserialize<AccountV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    accountV1.Validate();
                }
                return accountV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<AccountV1>> Get(
        string accountID,
        AccountGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(parameters with { AccountID = accountID }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AccountV1>> Onboard(
        AccountOnboardParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.AccountID == null)
        {
            throw new StraddleInvalidDataException("'parameters.AccountID' cannot be null");
        }

        HttpRequest<AccountOnboardParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var accountV1 = await response.Deserialize<AccountV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    accountV1.Validate();
                }
                return accountV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<AccountV1>> Onboard(
        string accountID,
        AccountOnboardParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Onboard(parameters with { AccountID = accountID }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AccountV1>> Simulate(
        AccountSimulateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.AccountID == null)
        {
            throw new StraddleInvalidDataException("'parameters.AccountID' cannot be null");
        }

        HttpRequest<AccountSimulateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var accountV1 = await response.Deserialize<AccountV1>(token).ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    accountV1.Validate();
                }
                return accountV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<AccountV1>> Simulate(
        string accountID,
        AccountSimulateParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Simulate(parameters with { AccountID = accountID }, cancellationToken);
    }
}
