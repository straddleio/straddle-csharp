using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Embed.LinkedBankAccounts;

namespace Straddle.Services.Embed;

/// <inheritdoc/>
public sealed class LinkedBankAccountService : ILinkedBankAccountService
{
    readonly Lazy<ILinkedBankAccountServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public ILinkedBankAccountServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IStraddleClient _client;

    /// <inheritdoc/>
    public ILinkedBankAccountService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new LinkedBankAccountService(this._client.WithOptions(modifier));
    }

    public LinkedBankAccountService(IStraddleClient client)
    {
        _client = client;

        _withRawResponse = new(() =>
            new LinkedBankAccountServiceWithRawResponse(client.WithRawResponse)
        );
    }

    /// <inheritdoc/>
    public async Task<LinkedBankAccountV1> Create(
        LinkedBankAccountCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Create(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<LinkedBankAccountV1> Update(
        LinkedBankAccountUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Update(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<LinkedBankAccountV1> Update(
        string linkedBankAccountID,
        LinkedBankAccountUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Update(
            parameters with
            {
                LinkedBankAccountID = linkedBankAccountID,
            },
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public async Task<LinkedBankAccountListPage> List(
        LinkedBankAccountListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<LinkedBankAccountV1> Cancel(
        LinkedBankAccountCancelParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Cancel(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<LinkedBankAccountV1> Cancel(
        string linkedBankAccountID,
        LinkedBankAccountCancelParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Cancel(
            parameters with
            {
                LinkedBankAccountID = linkedBankAccountID,
            },
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public async Task<LinkedBankAccountV1> Get(
        LinkedBankAccountGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Get(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<LinkedBankAccountV1> Get(
        string linkedBankAccountID,
        LinkedBankAccountGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(
            parameters with
            {
                LinkedBankAccountID = linkedBankAccountID,
            },
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public async Task<LinkedBankAccountUnmaskV1> Unmask(
        LinkedBankAccountUnmaskParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Unmask(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<LinkedBankAccountUnmaskV1> Unmask(
        string linkedBankAccountID,
        LinkedBankAccountUnmaskParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Unmask(
            parameters with
            {
                LinkedBankAccountID = linkedBankAccountID,
            },
            cancellationToken
        );
    }
}

/// <inheritdoc/>
public sealed class LinkedBankAccountServiceWithRawResponse
    : ILinkedBankAccountServiceWithRawResponse
{
    readonly IStraddleClientWithRawResponse _client;

    /// <inheritdoc/>
    public ILinkedBankAccountServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new LinkedBankAccountServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public LinkedBankAccountServiceWithRawResponse(IStraddleClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<LinkedBankAccountV1>> Create(
        LinkedBankAccountCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<LinkedBankAccountCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var linkedBankAccountV1 = await response
                    .Deserialize<LinkedBankAccountV1>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    linkedBankAccountV1.Validate();
                }
                return linkedBankAccountV1;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<LinkedBankAccountV1>> Update(
        LinkedBankAccountUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.LinkedBankAccountID == null)
        {
            throw new StraddleInvalidDataException(
                "'parameters.LinkedBankAccountID' cannot be null"
            );
        }

        HttpRequest<LinkedBankAccountUpdateParams> request = new()
        {
            Method = HttpMethod.Put,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var linkedBankAccountV1 = await response
                    .Deserialize<LinkedBankAccountV1>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    linkedBankAccountV1.Validate();
                }
                return linkedBankAccountV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<LinkedBankAccountV1>> Update(
        string linkedBankAccountID,
        LinkedBankAccountUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        return this.Update(
            parameters with
            {
                LinkedBankAccountID = linkedBankAccountID,
            },
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<LinkedBankAccountListPage>> List(
        LinkedBankAccountListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<LinkedBankAccountListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var page = await response
                    .Deserialize<LinkedBankAccountPagedV1>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    page.Validate();
                }
                return new LinkedBankAccountListPage(this, parameters, page);
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<LinkedBankAccountV1>> Cancel(
        LinkedBankAccountCancelParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.LinkedBankAccountID == null)
        {
            throw new StraddleInvalidDataException(
                "'parameters.LinkedBankAccountID' cannot be null"
            );
        }

        HttpRequest<LinkedBankAccountCancelParams> request = new()
        {
            Method = StraddleClientWithRawResponse.PatchMethod,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var linkedBankAccountV1 = await response
                    .Deserialize<LinkedBankAccountV1>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    linkedBankAccountV1.Validate();
                }
                return linkedBankAccountV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<LinkedBankAccountV1>> Cancel(
        string linkedBankAccountID,
        LinkedBankAccountCancelParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Cancel(
            parameters with
            {
                LinkedBankAccountID = linkedBankAccountID,
            },
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<LinkedBankAccountV1>> Get(
        LinkedBankAccountGetParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.LinkedBankAccountID == null)
        {
            throw new StraddleInvalidDataException(
                "'parameters.LinkedBankAccountID' cannot be null"
            );
        }

        HttpRequest<LinkedBankAccountGetParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var linkedBankAccountV1 = await response
                    .Deserialize<LinkedBankAccountV1>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    linkedBankAccountV1.Validate();
                }
                return linkedBankAccountV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<LinkedBankAccountV1>> Get(
        string linkedBankAccountID,
        LinkedBankAccountGetParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Get(
            parameters with
            {
                LinkedBankAccountID = linkedBankAccountID,
            },
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<LinkedBankAccountUnmaskV1>> Unmask(
        LinkedBankAccountUnmaskParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.LinkedBankAccountID == null)
        {
            throw new StraddleInvalidDataException(
                "'parameters.LinkedBankAccountID' cannot be null"
            );
        }

        HttpRequest<LinkedBankAccountUnmaskParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var linkedBankAccountUnmaskV1 = await response
                    .Deserialize<LinkedBankAccountUnmaskV1>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    linkedBankAccountUnmaskV1.Validate();
                }
                return linkedBankAccountUnmaskV1;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<LinkedBankAccountUnmaskV1>> Unmask(
        string linkedBankAccountID,
        LinkedBankAccountUnmaskParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Unmask(
            parameters with
            {
                LinkedBankAccountID = linkedBankAccountID,
            },
            cancellationToken
        );
    }
}
