using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Straddle.Core;
using Straddle.Exceptions;

namespace Straddle.Models.Embed.Representatives;

[JsonConverter(typeof(JsonModelConverter<Representative, RepresentativeFromRaw>))]
public sealed record class Representative : JsonModel
{
    public required Data Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<Data>("data");
        }
        init { this._rawData.Set("data", value); }
    }

    /// <summary>
    /// Metadata about the API request, including an identifier and timestamp.
    /// </summary>
    public required ResponseMetadata Meta
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ResponseMetadata>("meta");
        }
        init { this._rawData.Set("meta", value); }
    }

    /// <summary>
    /// Indicates the structure of the returned content. - "object" means the `data`
    /// field contains a single JSON object. - "array" means the `data` field contains
    /// an array of objects. - "error" means the `data` field contains an error object
    /// with details of the issue. - "none" means no data is returned.
    /// </summary>
    public required ApiEnum<string, ResponseType> ResponseType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, ResponseType>>("response_type");
        }
        init { this._rawData.Set("response_type", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Data.Validate();
        this.Meta.Validate();
        this.ResponseType.Validate();
    }

    public Representative() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Representative(Representative representative)
        : base(representative) { }
#pragma warning restore CS8618

    public Representative(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Representative(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RepresentativeFromRaw.FromRawUnchecked"/>
    public static Representative FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RepresentativeFromRaw : IFromRawJson<Representative>
{
    /// <inheritdoc/>
    public Representative FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Representative.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
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

    public required DataRelationship Relationship
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<DataRelationship>("relationship");
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
    public required ApiEnum<string, Status> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Status>>("status");
        }
        init { this._rawData.Set("status", value); }
    }

    public required StatusDetail StatusDetail
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<StatusDetail>("status_detail");
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

    public Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Data(Data data)
        : base(data) { }
#pragma warning restore CS8618

    public Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataFromRaw.FromRawUnchecked"/>
    public static Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataFromRaw : IFromRawJson<Data>
{
    /// <inheritdoc/>
    public Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Data.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<DataRelationship, DataRelationshipFromRaw>))]
public sealed record class DataRelationship : JsonModel
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

    public DataRelationship() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public DataRelationship(DataRelationship dataRelationship)
        : base(dataRelationship) { }
#pragma warning restore CS8618

    public DataRelationship(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    DataRelationship(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataRelationshipFromRaw.FromRawUnchecked"/>
    public static DataRelationship FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataRelationshipFromRaw : IFromRawJson<DataRelationship>
{
    /// <inheritdoc/>
    public DataRelationship FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        DataRelationship.FromRawUnchecked(rawData);
}

/// <summary>
/// The current status of the representative.
/// </summary>
[JsonConverter(typeof(StatusConverter))]
public enum Status
{
    Created,
    Onboarding,
    Active,
    Rejected,
    Inactive,
}

sealed class StatusConverter : JsonConverter<Status>
{
    public override Status Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "created" => Status.Created,
            "onboarding" => Status.Onboarding,
            "active" => Status.Active,
            "rejected" => Status.Rejected,
            "inactive" => Status.Inactive,
            _ => (Status)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Status value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Status.Created => "created",
                Status.Onboarding => "onboarding",
                Status.Active => "active",
                Status.Rejected => "rejected",
                Status.Inactive => "inactive",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

[JsonConverter(typeof(JsonModelConverter<StatusDetail, StatusDetailFromRaw>))]
public sealed record class StatusDetail : JsonModel
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
    public required ApiEnum<string, Reason> Reason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Reason>>("reason");
        }
        init { this._rawData.Set("reason", value); }
    }

    /// <summary>
    /// Identifies the origin of the status change (e.g., `watchtower`). This helps
    /// in tracking the cause of status updates.
    /// </summary>
    public required ApiEnum<string, Source> Source
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Source>>("source");
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

    public StatusDetail() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public StatusDetail(StatusDetail statusDetail)
        : base(statusDetail) { }
#pragma warning restore CS8618

    public StatusDetail(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    StatusDetail(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="StatusDetailFromRaw.FromRawUnchecked"/>
    public static StatusDetail FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class StatusDetailFromRaw : IFromRawJson<StatusDetail>
{
    /// <inheritdoc/>
    public StatusDetail FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        StatusDetail.FromRawUnchecked(rawData);
}

/// <summary>
/// A machine-readable identifier for the specific status, useful for programmatic handling.
/// </summary>
[JsonConverter(typeof(ReasonConverter))]
public enum Reason
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

sealed class ReasonConverter : JsonConverter<Reason>
{
    public override Reason Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "unverified" => Reason.Unverified,
            "in_review" => Reason.InReview,
            "pending" => Reason.Pending,
            "stuck" => Reason.Stuck,
            "verified" => Reason.Verified,
            "failed_verification" => Reason.FailedVerification,
            "disabled" => Reason.Disabled,
            "new" => Reason.New,
            _ => (Reason)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Reason value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Reason.Unverified => "unverified",
                Reason.InReview => "in_review",
                Reason.Pending => "pending",
                Reason.Stuck => "stuck",
                Reason.Verified => "verified",
                Reason.FailedVerification => "failed_verification",
                Reason.Disabled => "disabled",
                Reason.New => "new",
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
[JsonConverter(typeof(SourceConverter))]
public enum Source
{
    Watchtower,
}

sealed class SourceConverter : JsonConverter<Source>
{
    public override Source Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "watchtower" => Source.Watchtower,
            _ => (Source)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Source value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Source.Watchtower => "watchtower",
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
[JsonConverter(typeof(ResponseTypeConverter))]
public enum ResponseType
{
    Object,
    Array,
    Error,
    None,
}

sealed class ResponseTypeConverter : JsonConverter<ResponseType>
{
    public override ResponseType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "object" => ResponseType.Object,
            "array" => ResponseType.Array,
            "error" => ResponseType.Error,
            "none" => ResponseType.None,
            _ => (ResponseType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        ResponseType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                ResponseType.Object => "object",
                ResponseType.Array => "array",
                ResponseType.Error => "error",
                ResponseType.None => "none",
                _ => throw new StraddleInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
