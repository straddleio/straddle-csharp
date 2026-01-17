using System;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.Bridge.Link;
using Straddle.Models.Paykeys;

namespace Straddle.Services.Bridge;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface ILinkService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    ILinkServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ILinkService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Use Bridge to create a new paykey using a bank routing and account number
    /// as the source. This endpoint allows you to create a secure payment token linked
    /// to a specific bank account.
    /// </summary>
    Task<PaykeyV1> BankAccount(
        LinkBankAccountParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a new paykey using a Quiltt token as the source. This endpoint allows
    /// you to create a secure payment token linked to a bank account authenticated
    /// through Quiltt.
    /// </summary>
    Task<LinkCreatePaykeyResponse> CreatePaykey(
        LinkCreatePaykeyParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sends a request to <c>post /v1/bridge/tan<c/>.
    /// </summary>
    Task<LinkCreateTanResponse> CreateTan(
        LinkCreateTanParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Use Bridge to create a new paykey using a Plaid token as the source. This
    /// endpoint allows you to create a secure payment token linked to a bank account
    /// authenticated through Plaid.
    /// </summary>
    Task<PaykeyV1> Plaid(LinkPlaidParams parameters, CancellationToken cancellationToken = default);
}

/// <summary>
/// A view of <see cref="ILinkService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface ILinkServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ILinkServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `post /v1/bridge/bank_account`, but is otherwise the
    /// same as <see cref="ILinkService.BankAccount(LinkBankAccountParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PaykeyV1>> BankAccount(
        LinkBankAccountParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `post /v1/bridge/quiltt`, but is otherwise the
    /// same as <see cref="ILinkService.CreatePaykey(LinkCreatePaykeyParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<LinkCreatePaykeyResponse>> CreatePaykey(
        LinkCreatePaykeyParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `post /v1/bridge/tan`, but is otherwise the
    /// same as <see cref="ILinkService.CreateTan(LinkCreateTanParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<LinkCreateTanResponse>> CreateTan(
        LinkCreateTanParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `post /v1/bridge/plaid`, but is otherwise the
    /// same as <see cref="ILinkService.Plaid(LinkPlaidParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<PaykeyV1>> Plaid(
        LinkPlaidParams parameters,
        CancellationToken cancellationToken = default
    );
}
