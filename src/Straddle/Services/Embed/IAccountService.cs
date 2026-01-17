using System;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.Embed.Accounts;
using Straddle.Services.Embed.Accounts;

namespace Straddle.Services.Embed;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IAccountService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IAccountServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IAccountService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    ICapabilityRequestService CapabilityRequests { get; }

    /// <summary>
    /// Creates a new account associated with your Straddle platform integration.
    /// This endpoint allows you to set up an account with specified details, including
    /// business information and access levels.
    /// </summary>
    Task<AccountV1> Create(
        AccountCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates an existing account's information. This endpoint allows you to update
    /// various account details during onboarding or after the account has been created.
    /// </summary>
    Task<AccountV1> Update(
        AccountUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Update(AccountUpdateParams, CancellationToken)"/>
    Task<AccountV1> Update(
        string accountID,
        AccountUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a list of accounts associated with your Straddle platform integration.
    /// The accounts are returned sorted by creation date, with the most recently
    /// created accounts appearing first. This endpoint supports advanced sorting
    /// and filtering options.
    /// </summary>
    Task<AccountListPage> List(
        AccountListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the details of an account that has previously been created. Supply
    /// the unique account ID that was returned from your previous request, and Straddle
    /// will return the corresponding account information.
    /// </summary>
    Task<AccountV1> Get(AccountGetParams parameters, CancellationToken cancellationToken = default);

    /// <inheritdoc cref="Get(AccountGetParams, CancellationToken)"/>
    Task<AccountV1> Get(
        string accountID,
        AccountGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Initiates the onboarding process for a new account. This endpoint can only
    /// be used for accounts where at least one representative and one bank account
    /// have already been created.
    /// </summary>
    Task<AccountV1> Onboard(
        AccountOnboardParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Onboard(AccountOnboardParams, CancellationToken)"/>
    Task<AccountV1> Onboard(
        string accountID,
        AccountOnboardParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Simulate the status transitions for sandbox accounts. This endpoint can only
    /// be used for sandbox accounts.
    /// </summary>
    Task<AccountV1> Simulate(
        AccountSimulateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Simulate(AccountSimulateParams, CancellationToken)"/>
    Task<AccountV1> Simulate(
        string accountID,
        AccountSimulateParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IAccountService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IAccountServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IAccountServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    ICapabilityRequestServiceWithRawResponse CapabilityRequests { get; }

    /// <summary>
    /// Returns a raw HTTP response for `post /v1/accounts`, but is otherwise the
    /// same as <see cref="IAccountService.Create(AccountCreateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AccountV1>> Create(
        AccountCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `put /v1/accounts/{account_id}`, but is otherwise the
    /// same as <see cref="IAccountService.Update(AccountUpdateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AccountV1>> Update(
        AccountUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Update(AccountUpdateParams, CancellationToken)"/>
    Task<HttpResponse<AccountV1>> Update(
        string accountID,
        AccountUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/accounts`, but is otherwise the
    /// same as <see cref="IAccountService.List(AccountListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AccountListPage>> List(
        AccountListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/accounts/{account_id}`, but is otherwise the
    /// same as <see cref="IAccountService.Get(AccountGetParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AccountV1>> Get(
        AccountGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(AccountGetParams, CancellationToken)"/>
    Task<HttpResponse<AccountV1>> Get(
        string accountID,
        AccountGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `post /v1/accounts/{account_id}/onboard`, but is otherwise the
    /// same as <see cref="IAccountService.Onboard(AccountOnboardParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AccountV1>> Onboard(
        AccountOnboardParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Onboard(AccountOnboardParams, CancellationToken)"/>
    Task<HttpResponse<AccountV1>> Onboard(
        string accountID,
        AccountOnboardParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `post /v1/accounts/{account_id}/simulate`, but is otherwise the
    /// same as <see cref="IAccountService.Simulate(AccountSimulateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AccountV1>> Simulate(
        AccountSimulateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Simulate(AccountSimulateParams, CancellationToken)"/>
    Task<HttpResponse<AccountV1>> Simulate(
        string accountID,
        AccountSimulateParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
