using System;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.Reports;

namespace Straddle.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IReportService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IReportServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IReportService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Sends a request to <c>post /v1/reports/total_customers_by_status<c/>.
    /// </summary>
    Task<ReportCreateTotalCustomersByStatusResponse> CreateTotalCustomersByStatus(
        ReportCreateTotalCustomersByStatusParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IReportService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IReportServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IReportServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for `post /v1/reports/total_customers_by_status`, but is otherwise the
    /// same as <see cref="IReportService.CreateTotalCustomersByStatus(ReportCreateTotalCustomersByStatusParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ReportCreateTotalCustomersByStatusResponse>> CreateTotalCustomersByStatus(
        ReportCreateTotalCustomersByStatusParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
