using System;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Models.Customers;
using Straddle.Services.Customers;

namespace Straddle.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface ICustomerService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    ICustomerServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ICustomerService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IReviewService Review { get; }

    /// <summary>
    /// Creates a new customer record and automatically initiates identity, fraud,
    /// and risk assessment scores. This endpoint allows you to create a customer
    /// profile and associate it with paykeys and payments.
    /// </summary>
    Task<CustomerV1> Create(
        CustomerCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates an existing customer's information. This endpoint allows you to modify
    /// the customer's contact details, PII, and metadata.
    /// </summary>
    Task<CustomerV1> Update(
        CustomerUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Update(CustomerUpdateParams, CancellationToken)"/>
    Task<CustomerV1> Update(
        string id,
        CustomerUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists or searches customers connected to your account. All supported query
    /// parameters are optional. If none are provided, the response will include
    /// all customers connected to your account. This endpoint supports advanced
    /// sorting and filtering options.
    /// </summary>
    Task<CustomerListPage> List(
        CustomerListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Permanently removes a customer record from Straddle. This action cannot be
    /// undone and should only be used to satisfy regulatory requirements or for privacy compliance.
    /// </summary>
    Task<CustomerV1> Delete(
        CustomerDeleteParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Delete(CustomerDeleteParams, CancellationToken)"/>
    Task<CustomerV1> Delete(
        string id,
        CustomerDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the details of an existing customer. Supply the unique customer
    /// ID that was returned from your 'create customer' request, and Straddle will
    /// return the corresponding customer information.
    /// </summary>
    Task<CustomerV1> Get(
        CustomerGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(CustomerGetParams, CancellationToken)"/>
    Task<CustomerV1> Get(
        string id,
        CustomerGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the unmasked details, including PII, of an existing customer. Supply
    /// the unique customer ID that was returned from your 'create customer' request,
    /// and Straddle will return the corresponding customer information. This endpoint
    /// needs to be enabled by Straddle and should only be used when absolutely necessary.
    /// </summary>
    Task<CustomerUnmaskedV1> Unmasked(
        CustomerUnmaskedParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Unmasked(CustomerUnmaskedParams, CancellationToken)"/>
    Task<CustomerUnmaskedV1> Unmasked(
        string id,
        CustomerUnmaskedParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="ICustomerService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface ICustomerServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ICustomerServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IReviewServiceWithRawResponse Review { get; }

    /// <summary>
    /// Returns a raw HTTP response for `post /v1/customers`, but is otherwise the
    /// same as <see cref="ICustomerService.Create(CustomerCreateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<CustomerV1>> Create(
        CustomerCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `put /v1/customers/{id}`, but is otherwise the
    /// same as <see cref="ICustomerService.Update(CustomerUpdateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<CustomerV1>> Update(
        CustomerUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Update(CustomerUpdateParams, CancellationToken)"/>
    Task<HttpResponse<CustomerV1>> Update(
        string id,
        CustomerUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/customers`, but is otherwise the
    /// same as <see cref="ICustomerService.List(CustomerListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<CustomerListPage>> List(
        CustomerListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `delete /v1/customers/{id}`, but is otherwise the
    /// same as <see cref="ICustomerService.Delete(CustomerDeleteParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<CustomerV1>> Delete(
        CustomerDeleteParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Delete(CustomerDeleteParams, CancellationToken)"/>
    Task<HttpResponse<CustomerV1>> Delete(
        string id,
        CustomerDeleteParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/customers/{id}`, but is otherwise the
    /// same as <see cref="ICustomerService.Get(CustomerGetParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<CustomerV1>> Get(
        CustomerGetParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Get(CustomerGetParams, CancellationToken)"/>
    Task<HttpResponse<CustomerV1>> Get(
        string id,
        CustomerGetParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for `get /v1/customers/{id}/unmasked`, but is otherwise the
    /// same as <see cref="ICustomerService.Unmasked(CustomerUnmaskedParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<CustomerUnmaskedV1>> Unmasked(
        CustomerUnmaskedParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Unmasked(CustomerUnmaskedParams, CancellationToken)"/>
    Task<HttpResponse<CustomerUnmaskedV1>> Unmasked(
        string id,
        CustomerUnmaskedParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
