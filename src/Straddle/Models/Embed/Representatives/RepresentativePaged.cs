using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Embed.Representatives;

[JsonConverter(typeof(JsonModelConverter<RepresentativePaged, RepresentativePagedFromRaw>))]
public sealed record class RepresentativePaged : JsonModel
{
    public required IReadOnlyList<RepresentativePagedData> Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<ImmutableArray<RepresentativePagedData>>("data");
        }
        init
        {
            this._rawData.Set<ImmutableArray<RepresentativePagedData>>(
                "data",
                ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Metadata about the API request, including an identifier, timestamp, and pagination details.
    /// </summary>
    public required PagedResponseMetadata Meta
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<PagedResponseMetadata>("meta");
        }
        init { this._rawData.Set("meta", value); }
    }

    /// <summary>
    /// Indicates the structure of the returned content. - "object" means the `data`
    /// field contains a single JSON object. - "array" means the `data` field contains
    /// an array of objects. - "error" means the `data` field contains an error object
    /// with details of the issue. - "none" means no data is returned.
    /// </summary>
    public required ApiEnum<string, RepresentativePagedResponseType> ResponseType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, RepresentativePagedResponseType>>(
                "response_type"
            );
        }
        init { this._rawData.Set("response_type", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        foreach (var item in this.Data)
        {
            item.Validate();
        }
        this.Meta.Validate();
        this.ResponseType.Validate();
    }

    public RepresentativePaged() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public RepresentativePaged(RepresentativePaged representativePaged)
        : base(representativePaged) { }
#pragma warning restore CS8618

    public RepresentativePaged(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RepresentativePaged(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RepresentativePagedFromRaw.FromRawUnchecked"/>
    public static RepresentativePaged FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RepresentativePagedFromRaw : IFromRawJson<RepresentativePaged>
{
    /// <inheritdoc/>
    public RepresentativePaged FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        RepresentativePaged.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<RepresentativePagedData, RepresentativePagedDataFromRaw>))]
public sealed record class RepresentativePagedData : JsonModel
{
    /// <summary>
    /// Unique identifier for the representative.
    /// </summary>
    public required string ID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("id");
        }
        init { this._rawData.Set("id", value); }
    }

    /// <summary>
    /// The unique identifier of the account this representative is associated with.
    /// </summary>
    public required string AccountID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("account_id");
        }
        init { this._rawData.Set("account_id", value); }
    }

    /// <summary>
    /// Timestamp of when the representative was created.
    /// </summary>
    public required DateTimeOffset CreatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<DateTimeOffset>("created_at");
        }
        init { this._rawData.Set("created_at", value); }
    }

    /// <summary>
    /// The date of birth of the representative, in ISO 8601 format (YYYY-MM-DD).
    /// </summary>
    public required string Dob
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("dob");
        }
        init { this._rawData.Set("dob", value); }
    }

    /// <summary>
    /// The email address of the representative.
    /// </summary>
    public required string? Email
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("email");
        }
        init { this._rawData.Set("email", value); }
    }

    /// <summary>
    /// The first name of the representative.
    /// </summary>
    public required string FirstName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("first_name");
        }
        init { this._rawData.Set("first_name", value); }
    }

    /// <summary>
    /// The last name of the representative.
    /// </summary>
    public required string LastName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("last_name");
        }
        init { this._rawData.Set("last_name", value); }
    }

    /// <summary>
    /// The mobile phone number of the representative.
    /// </summary>
    public required string MobileNumber
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("mobile_number");
        }
        init { this._rawData.Set("mobile_number", value); }
    }

    public required string Name
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("name");
        }
        init { this._rawData.Set("name", value); }
    }

    public required RepresentativePagedDataRelationship Relationship
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<RepresentativePagedDataRelationship>(
                "relationship"
            );
        }
        init { this._rawData.Set("relationship", value); }
    }

    /// <summary>
    /// The last 4 digits of the representative's Social Security Number.
    /// </summary>
    public required string SsnLast4
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("ssn_last4");
        }
        init { this._rawData.Set("ssn_last4", value); }
    }

    /// <summary>
    /// The current status of the representative.
    /// </summary>
    public required ApiEnum<string, RepresentativePagedDataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, RepresentativePagedDataStatus>>(
                "status"
            );
        }
        init { this._rawData.Set("status", value); }
    }

    public required RepresentativePagedDataStatusDetail StatusDetail
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<RepresentativePagedDataStatusDetail>(
                "status_detail"
            );
        }
        init { this._rawData.Set("status_detail", value); }
    }

    /// <summary>
    /// Timestamp of the most recent update to the representative.
    /// </summary>
    public required DateTimeOffset UpdatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<DateTimeOffset>("updated_at");
        }
        init { this._rawData.Set("updated_at", value); }
    }

    /// <summary>
    /// Unique identifier for the representative in your database, used for cross-referencing
    /// between Straddle and your systems.
    /// </summary>
    public string? ExternalID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("external_id");
        }
        init { this._rawData.Set("external_id", value); }
    }

    /// <summary>
    /// Up to 20 additional user-defined key-value pairs. Useful for storing additional
    /// information about the represetative in a structured format.
    /// </summary>
    public IReadOnlyDictionary<string, string>? Metadata
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<FrozenDictionary<string, string>>("metadata");
        }
        init
        {
            this._rawData.Set<FrozenDictionary<string, string>?>(
                "metadata",
                value == null ? null : FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    public string? Phone
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("phone");
        }
        init { this._rawData.Set("phone", value); }
    }

    /// <summary>
    /// The unique identifier of the user account associated with this representative,
    /// if applicable.
    /// </summary>
    public string? UserID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("user_id");
        }
        init { this._rawData.Set("user_id", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.AccountID;
        _ = this.CreatedAt;
        _ = this.Dob;
        _ = this.Email;
        _ = this.FirstName;
        _ = this.LastName;
        _ = this.MobileNumber;
        _ = this.Name;
        this.Relationship.Validate();
        _ = this.SsnLast4;
        this.Status.Validate();
        this.StatusDetail.Validate();
        _ = this.UpdatedAt;
        _ = this.ExternalID;
        _ = this.Metadata;
        _ = this.Phone;
        _ = this.UserID;
    }

    public RepresentativePagedData() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public RepresentativePagedData(RepresentativePagedData representativePagedData)
        : base(representativePagedData) { }
#pragma warning restore CS8618

    public RepresentativePagedData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RepresentativePagedData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RepresentativePagedDataFromRaw.FromRawUnchecked"/>
    public static RepresentativePagedData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RepresentativePagedDataFromRaw : IFromRawJson<RepresentativePagedData>
{
    /// <inheritdoc/>
    public RepresentativePagedData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => RepresentativePagedData.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        RepresentativePagedDataRelationship,
        RepresentativePagedDataRelationshipFromRaw
    >)
)]
public sealed record class RepresentativePagedDataRelationship : JsonModel
{
    /// <summary>
    /// Whether the representative has significant responsibility to control, manage,
    /// or direct the organization. One representative must be identified under the
    /// control prong for each legal entity.
    /// </summary>
    public required bool Control
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<bool>("control");
        }
        init { this._rawData.Set("control", value); }
    }

    /// <summary>
    /// Whether the representative owns any percentage of of the equity interests
    /// of the legal entity.
    /// </summary>
    public required bool Owner
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<bool>("owner");
        }
        init { this._rawData.Set("owner", value); }
    }

    /// <summary>
    /// Whether the person is authorized as the primary representative of the account.
    /// This is the person chosen by the business to provide information about themselves,
    /// general information about the account, and who consented to the services agreement.
    ///
    /// <para> There can be only one primary representative for an account at a time.</para>
    /// </summary>
    public required bool Primary
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<bool>("primary");
        }
        init { this._rawData.Set("primary", value); }
    }

    /// <summary>
    /// The percentage of ownership the representative has. Required if 'Owner' is true.
    /// </summary>
    public double? PercentOwnership
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("percent_ownership");
        }
        init { this._rawData.Set("percent_ownership", value); }
    }

    /// <summary>
    /// The job title of the representative.
    /// </summary>
    public string? Title
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("title");
        }
        init { this._rawData.Set("title", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Control;
        _ = this.Owner;
        _ = this.Primary;
        _ = this.PercentOwnership;
        _ = this.Title;
    }

    public RepresentativePagedDataRelationship() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public RepresentativePagedDataRelationship(
        RepresentativePagedDataRelationship representativePagedDataRelationship
    )
        : base(representativePagedDataRelationship) { }
#pragma warning restore CS8618

    public RepresentativePagedDataRelationship(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RepresentativePagedDataRelationship(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RepresentativePagedDataRelationshipFromRaw.FromRawUnchecked"/>
    public static RepresentativePagedDataRelationship FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RepresentativePagedDataRelationshipFromRaw : IFromRawJson<RepresentativePagedDataRelationship>
{
    /// <inheritdoc/>
    public RepresentativePagedDataRelationship FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => RepresentativePagedDataRelationship.FromRawUnchecked(rawData);
}

/// <summary>
/// The current status of the representative.
/// </summary>
[JsonConverter(typeof(RepresentativePagedDataStatusConverter))]
public enum RepresentativePagedDataStatus
{
    Created,
    Onboarding,
    Active,
    Rejected,
    Inactive,
}

sealed class RepresentativePagedDataStatusConverter : JsonConverter<RepresentativePagedDataStatus>
{
    public override RepresentativePagedDataStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created" => RepresentativePagedDataStatus.Created,
            "onboarding" => RepresentativePagedDataStatus.Onboarding,
            "active" => RepresentativePagedDataStatus.Active,
            "rejected" => RepresentativePagedDataStatus.Rejected,
            "inactive" => RepresentativePagedDataStatus.Inactive,
            _ => (RepresentativePagedDataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        RepresentativePagedDataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                RepresentativePagedDataStatus.Created => "created",
                RepresentativePagedDataStatus.Onboarding => "onboarding",
                RepresentativePagedDataStatus.Active => "active",
                RepresentativePagedDataStatus.Rejected => "rejected",
                RepresentativePagedDataStatus.Inactive => "inactive",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(
    typeof(JsonModelConverter<
        RepresentativePagedDataStatusDetail,
        RepresentativePagedDataStatusDetailFromRaw
    >)
)]
public sealed record class RepresentativePagedDataStatusDetail : JsonModel
{
    /// <summary>
    /// A machine-readable code for the specific status, useful for programmatic handling.
    /// </summary>
    public required string Code
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("code");
        }
        init { this._rawData.Set("code", value); }
    }

    /// <summary>
    /// A human-readable message describing the current status.
    /// </summary>
    public required string Message
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("message");
        }
        init { this._rawData.Set("message", value); }
    }

    /// <summary>
    /// A machine-readable identifier for the specific status, useful for programmatic handling.
    /// </summary>
    public required ApiEnum<string, RepresentativePagedDataStatusDetailReason> Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, RepresentativePagedDataStatusDetailReason>
            >("reason");
        }
        init { this._rawData.Set("reason", value); }
    }

    /// <summary>
    /// Identifies the origin of the status change (e.g., `watchtower`). This helps
    /// in tracking the cause of status updates.
    /// </summary>
    public required ApiEnum<string, RepresentativePagedDataStatusDetailSource> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, RepresentativePagedDataStatusDetailSource>
            >("source");
        }
        init { this._rawData.Set("source", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Code;
        _ = this.Message;
        this.Reason.Validate();
        this.Source.Validate();
    }

    public RepresentativePagedDataStatusDetail() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public RepresentativePagedDataStatusDetail(
        RepresentativePagedDataStatusDetail representativePagedDataStatusDetail
    )
        : base(representativePagedDataStatusDetail) { }
#pragma warning restore CS8618

    public RepresentativePagedDataStatusDetail(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RepresentativePagedDataStatusDetail(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RepresentativePagedDataStatusDetailFromRaw.FromRawUnchecked"/>
    public static RepresentativePagedDataStatusDetail FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RepresentativePagedDataStatusDetailFromRaw : IFromRawJson<RepresentativePagedDataStatusDetail>
{
    /// <inheritdoc/>
    public RepresentativePagedDataStatusDetail FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => RepresentativePagedDataStatusDetail.FromRawUnchecked(rawData);
}

/// <summary>
/// A machine-readable identifier for the specific status, useful for programmatic handling.
/// </summary>
[JsonConverter(typeof(RepresentativePagedDataStatusDetailReasonConverter))]
public enum RepresentativePagedDataStatusDetailReason
{
    Unverified,
    InReview,
    Pending,
    Stuck,
    Verified,
    FailedVerification,
    Disabled,
    New,
}

sealed class RepresentativePagedDataStatusDetailReasonConverter
    : JsonConverter<RepresentativePagedDataStatusDetailReason>
{
    public override RepresentativePagedDataStatusDetailReason Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "unverified" => RepresentativePagedDataStatusDetailReason.Unverified,
            "in_review" => RepresentativePagedDataStatusDetailReason.InReview,
            "pending" => RepresentativePagedDataStatusDetailReason.Pending,
            "stuck" => RepresentativePagedDataStatusDetailReason.Stuck,
            "verified" => RepresentativePagedDataStatusDetailReason.Verified,
            "failed_verification" => RepresentativePagedDataStatusDetailReason.FailedVerification,
            "disabled" => RepresentativePagedDataStatusDetailReason.Disabled,
            "new" => RepresentativePagedDataStatusDetailReason.New,
            _ => (RepresentativePagedDataStatusDetailReason)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        RepresentativePagedDataStatusDetailReason value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                RepresentativePagedDataStatusDetailReason.Unverified => "unverified",
                RepresentativePagedDataStatusDetailReason.InReview => "in_review",
                RepresentativePagedDataStatusDetailReason.Pending => "pending",
                RepresentativePagedDataStatusDetailReason.Stuck => "stuck",
                RepresentativePagedDataStatusDetailReason.Verified => "verified",
                RepresentativePagedDataStatusDetailReason.FailedVerification =>
                    "failed_verification",
                RepresentativePagedDataStatusDetailReason.Disabled => "disabled",
                RepresentativePagedDataStatusDetailReason.New => "new",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Identifies the origin of the status change (e.g., `watchtower`). This helps in
/// tracking the cause of status updates.
/// </summary>
[JsonConverter(typeof(RepresentativePagedDataStatusDetailSourceConverter))]
public enum RepresentativePagedDataStatusDetailSource
{
    Watchtower,
}

sealed class RepresentativePagedDataStatusDetailSourceConverter
    : JsonConverter<RepresentativePagedDataStatusDetailSource>
{
    public override RepresentativePagedDataStatusDetailSource Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "watchtower" => RepresentativePagedDataStatusDetailSource.Watchtower,
            _ => (RepresentativePagedDataStatusDetailSource)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        RepresentativePagedDataStatusDetailSource value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                RepresentativePagedDataStatusDetailSource.Watchtower => "watchtower",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Indicates the structure of the returned content. - "object" means the `data`
/// field contains a single JSON object. - "array" means the `data` field contains
/// an array of objects. - "error" means the `data` field contains an error object
/// with details of the issue. - "none" means no data is returned.
/// </summary>
[JsonConverter(typeof(RepresentativePagedResponseTypeConverter))]
public enum RepresentativePagedResponseType
{
    Object,
    Array,
    Error,
    None,
}

sealed class RepresentativePagedResponseTypeConverter
    : JsonConverter<RepresentativePagedResponseType>
{
    public override RepresentativePagedResponseType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "object" => RepresentativePagedResponseType.Object,
            "array" => RepresentativePagedResponseType.Array,
            "error" => RepresentativePagedResponseType.Error,
            "none" => RepresentativePagedResponseType.None,
            _ => (RepresentativePagedResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        RepresentativePagedResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                RepresentativePagedResponseType.Object => "object",
                RepresentativePagedResponseType.Array => "array",
                RepresentativePagedResponseType.Error => "error",
                RepresentativePagedResponseType.None => "none",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
