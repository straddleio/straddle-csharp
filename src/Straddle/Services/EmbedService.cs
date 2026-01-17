using System;
using Straddle.Core;
using Straddle.Services.Embed;

namespace Straddle.Services;

/// <inheritdoc/>
public sealed class EmbedService : IEmbedService
{
    readonly Lazy<IEmbedServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IEmbedServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IStraddleClient _client;

    /// <inheritdoc/>
    public IEmbedService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new EmbedService(this._client.WithOptions(modifier));
    }

    public EmbedService(IStraddleClient client)
    {
        _client = client;

        _withRawResponse = new(() => new EmbedServiceWithRawResponse(client.WithRawResponse));
        _accounts = new(() => new AccountService(client));
        _linkedBankAccounts = new(() => new LinkedBankAccountService(client));
        _organizations = new(() => new OrganizationService(client));
        _representatives = new(() => new RepresentativeService(client));
    }

    readonly Lazy<IAccountService> _accounts;
    public IAccountService Accounts
    {
        get { return _accounts.Value; }
    }

    readonly Lazy<ILinkedBankAccountService> _linkedBankAccounts;
    public ILinkedBankAccountService LinkedBankAccounts
    {
        get { return _linkedBankAccounts.Value; }
    }

    readonly Lazy<IOrganizationService> _organizations;
    public IOrganizationService Organizations
    {
        get { return _organizations.Value; }
    }

    readonly Lazy<IRepresentativeService> _representatives;
    public IRepresentativeService Representatives
    {
        get { return _representatives.Value; }
    }
}

/// <inheritdoc/>
public sealed class EmbedServiceWithRawResponse : IEmbedServiceWithRawResponse
{
    readonly IStraddleClientWithRawResponse _client;

    /// <inheritdoc/>
    public IEmbedServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new EmbedServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public EmbedServiceWithRawResponse(IStraddleClientWithRawResponse client)
    {
        _client = client;

        _accounts = new(() => new AccountServiceWithRawResponse(client));
        _linkedBankAccounts = new(() => new LinkedBankAccountServiceWithRawResponse(client));
        _organizations = new(() => new OrganizationServiceWithRawResponse(client));
        _representatives = new(() => new RepresentativeServiceWithRawResponse(client));
    }

    readonly Lazy<IAccountServiceWithRawResponse> _accounts;
    public IAccountServiceWithRawResponse Accounts
    {
        get { return _accounts.Value; }
    }

    readonly Lazy<ILinkedBankAccountServiceWithRawResponse> _linkedBankAccounts;
    public ILinkedBankAccountServiceWithRawResponse LinkedBankAccounts
    {
        get { return _linkedBankAccounts.Value; }
    }

    readonly Lazy<IOrganizationServiceWithRawResponse> _organizations;
    public IOrganizationServiceWithRawResponse Organizations
    {
        get { return _organizations.Value; }
    }

    readonly Lazy<IRepresentativeServiceWithRawResponse> _representatives;
    public IRepresentativeServiceWithRawResponse Representatives
    {
        get { return _representatives.Value; }
    }
}
