using System;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.Embed.LinkedBankAccounts;

namespace Straddle.Services.Embed;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface ILinkedBankAccountService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    ILinkedBankAccountServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ILinkedBankAccountService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Creates a new linked bank account associated with a Straddle account. This
    /// endpoint allows you to associate external bank accounts with a Straddle account
    /// for various payment operations such as payment deposits, payout withdrawals,
    /// and more.
    /// </summary>
    Task<LinkedBankAccountV1> Create(
        LinkedBankAccountCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates an existing linked bank account's information. This can be used to
    /// update account details during onboarding or to update metadata associated
    /// with the linked account. The linked bank account must be in 'created' or 'onboarding' status.
    /// </summary>
    Task<LinkedBankAccountV1> Update(
        LinkedBankAccountUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Update(LinkedBankAccountUpdateParams, CancellationToken)"/>
    Task<LinkedBankAccountV1> Update(
        string linkedBankAccountID,
        LinkedBankAccountUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a list of bank accounts associated with a specific Straddle account.
    /// The linked bank accounts are returned sorted by creation date, with the most
    /// recently created appearing first. This endpoint supports pagination to handle
    /// accounts with multiple linked bank accounts.
    /// </summary>
    Task<LinkedBankAccountListPage> List(
        LinkedBankAccountListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancels an existing linked bank account. This can be used to cancel a linked
    /// bank account before it has been reviewed. The linked bank account must be
    /// in 'created' status.
    /// </summary>
    Task<LinkedBankAccountV1> Cancel(
        LinkedBankAccountCancelParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Cancel(LinkedBankAccountCancelParams, CancellationToken)"/>
    Task<LinkedBankAccountV1> Cancel(
        string linkedBankAccountID,
        LinkedBankAccountCancelParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the details of a linked bank account that has previously been created.
    /// Supply the unique linked bank account `id`, and Straddle will return the corresponding
    /// information. The response includes masked account details for security purposes.
    /// </summary>
    Task<LinkedBankAccountV1> Get(
        LinkedBankAccountGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(LinkedBankAccountGetParams, CancellationToken)"/>
    Task<LinkedBankAccountV1> Get(
        string linkedBankAccountID,
        LinkedBankAccountGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the unmasked details of a linked bank account that has previously
    /// been created. Supply the unique linked bank account `id`, and Straddle will
    /// return the corresponding information, including sensitive details. This endpoint
    /// needs to be enabled by Straddle for your account and should only be used when
    /// absolutely necessary.
    /// </summary>
    Task<LinkedBankAccountUnmaskV1> Unmask(
        LinkedBankAccountUnmaskParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Unmask(LinkedBankAccountUnmaskParams, CancellationToken)"/>
    Task<LinkedBankAccountUnmaskV1> Unmask(
        string linkedBankAccountID,
        LinkedBankAccountUnmaskParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="ILinkedBankAccountService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface ILinkedBankAccountServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ILinkedBankAccountServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    );

    /// <summary>
    /// Returns a raw HTTP response for `post /v1/linked_bank_accounts`, but is otherwise the
    /// same as <see cref="ILinkedBankAccountService.Create(LinkedBankAccountCreateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<LinkedBankAccountV1>> Create(
        LinkedBankAccountCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `put /v1/linked_bank_accounts/{linked_bank_account_id}`, but is otherwise the
    /// same as <see cref="ILinkedBankAccountService.Update(LinkedBankAccountUpdateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<LinkedBankAccountV1>> Update(
        LinkedBankAccountUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Update(LinkedBankAccountUpdateParams, CancellationToken)"/>
    Task<HttpResponse<LinkedBankAccountV1>> Update(
        string linkedBankAccountID,
        LinkedBankAccountUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/linked_bank_accounts`, but is otherwise the
    /// same as <see cref="ILinkedBankAccountService.List(LinkedBankAccountListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<LinkedBankAccountListPage>> List(
        LinkedBankAccountListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `patch /v1/linked_bank_accounts/{linked_bank_account_id}/cancel`, but is otherwise the
    /// same as <see cref="ILinkedBankAccountService.Cancel(LinkedBankAccountCancelParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<LinkedBankAccountV1>> Cancel(
        LinkedBankAccountCancelParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Cancel(LinkedBankAccountCancelParams, CancellationToken)"/>
    Task<HttpResponse<LinkedBankAccountV1>> Cancel(
        string linkedBankAccountID,
        LinkedBankAccountCancelParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/linked_bank_accounts/{linked_bank_account_id}`, but is otherwise the
    /// same as <see cref="ILinkedBankAccountService.Get(LinkedBankAccountGetParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<LinkedBankAccountV1>> Get(
        LinkedBankAccountGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(LinkedBankAccountGetParams, CancellationToken)"/>
    Task<HttpResponse<LinkedBankAccountV1>> Get(
        string linkedBankAccountID,
        LinkedBankAccountGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/linked_bank_accounts/{linked_bank_account_id}/unmask`, but is otherwise the
    /// same as <see cref="ILinkedBankAccountService.Unmask(LinkedBankAccountUnmaskParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<LinkedBankAccountUnmaskV1>> Unmask(
        LinkedBankAccountUnmaskParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Unmask(LinkedBankAccountUnmaskParams, CancellationToken)"/>
    Task<HttpResponse<LinkedBankAccountUnmaskV1>> Unmask(
        string linkedBankAccountID,
        LinkedBankAccountUnmaskParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
