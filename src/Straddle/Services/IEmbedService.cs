using System;
using Straddle.Core;
using Straddle.Services.Embed;

namespace Straddle.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IEmbedService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IEmbedServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IEmbedService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IAccountService Accounts { get; }

    ILinkedBankAccountService LinkedBankAccounts { get; }

    IOrganizationService Organizations { get; }

    IRepresentativeService Representatives { get; }
}

/// <summary>
/// A view of <see cref="IEmbedService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IEmbedServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IEmbedServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IAccountServiceWithRawResponse Accounts { get; }

    ILinkedBankAccountServiceWithRawResponse LinkedBankAccounts { get; }

    IOrganizationServiceWithRawResponse Organizations { get; }

    IRepresentativeServiceWithRawResponse Representatives { get; }
}
