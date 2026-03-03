using System;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.Bridge;
using Straddle.Services.Bridge;

namespace Straddle.Services;

/// <summary>
/// Bridge provides a comprehensive suite of tools for connecting customer bank accounts.
/// Use it to generate secure widget sessions for instant account verification, accept
/// tokens from major providers like Plaid and Finicity, or verify accounts directly
/// via our API. Bridge handles all sensitive banking credentials and ensures secure,
/// compliant connections with support for 90% of US bank accounts.
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public interface IBridgeService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IBridgeServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IBridgeService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    ILinkService Link { get; }

    /// <summary>
    /// Use this endpoint to generate a session token for use in the Bridge widget.
    /// </summary>
    Task<BridgeTokenV1> Initialize(
        BridgeInitializeParams parameters,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IBridgeService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IBridgeServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IBridgeServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    ILinkServiceWithRawResponse Link { get; }

    /// <summary>
    /// Returns a raw HTTP response for `post /v1/bridge/initialize`, but is otherwise the
    /// same as <see cref="IBridgeService.Initialize(BridgeInitializeParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<BridgeTokenV1>> Initialize(
        BridgeInitializeParams parameters,
        CancellationToken cancellationToken = default
    );
}
