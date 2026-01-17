using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Embed.Representatives;
using Models = Straddle.Models;

namespace Straddle.Tests.Models.Embed.Representatives;

public class RepresentativePagedTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new RepresentativePaged
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Dob = "1980-01-01",
                    Email = "ron.swanson@pawnee.com",
                    FirstName = "Ron",
                    LastName = "Swanson",
                    MobileNumber = "+12128675309",
                    Name = "name",
                    Relationship = new()
                    {
                        Control = true,
                        Owner = true,
                        Primary = true,
                        PercentOwnership = 0,
                        Title = "title",
                    },
                    SsnLast4 = "1234",
                    Status = RepresentativePagedDataStatus.Created,
                    StatusDetail = new()
                    {
                        Code = "code",
                        Message = "message",
                        Reason = RepresentativePagedDataStatusDetailReason.Unverified,
                        Source = RepresentativePagedDataStatusDetailSource.Watchtower,
                    },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    ExternalID = "external_id",
                    Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                    Phone = "phone",
                    UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                },
            ],
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                MaxPageSize = 0,
                PageNumber = 0,
                PageSize = 0,
                SortBy = "sort_by",
                SortOrder = Models::SortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = RepresentativePagedResponseType.Object,
        };

        List<RepresentativePagedData> expectedData =
        [
            new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Dob = "1980-01-01",
                Email = "ron.swanson@pawnee.com",
                FirstName = "Ron",
                LastName = "Swanson",
                MobileNumber = "+12128675309",
                Name = "name",
                Relationship = new()
                {
                    Control = true,
                    Owner = true,
                    Primary = true,
                    PercentOwnership = 0,
                    Title = "title",
                },
                SsnLast4 = "1234",
                Status = RepresentativePagedDataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = RepresentativePagedDataStatusDetailReason.Unverified,
                    Source = RepresentativePagedDataStatusDetailSource.Watchtower,
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                Phone = "phone",
                UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            },
        ];
        Models::PagedResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = Models::SortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };
        ApiEnum<string, RepresentativePagedResponseType> expectedResponseType =
            RepresentativePagedResponseType.Object;

        Assert.Equal(expectedData.Count, model.Data.Count);
        for (int i = 0; i < expectedData.Count; i++)
        {
            Assert.Equal(expectedData[i], model.Data[i]);
        }
        Assert.Equal(expectedMeta, model.Meta);
        Assert.Equal(expectedResponseType, model.ResponseType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new RepresentativePaged
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Dob = "1980-01-01",
                    Email = "ron.swanson@pawnee.com",
                    FirstName = "Ron",
                    LastName = "Swanson",
                    MobileNumber = "+12128675309",
                    Name = "name",
                    Relationship = new()
                    {
                        Control = true,
                        Owner = true,
                        Primary = true,
                        PercentOwnership = 0,
                        Title = "title",
                    },
                    SsnLast4 = "1234",
                    Status = RepresentativePagedDataStatus.Created,
                    StatusDetail = new()
                    {
                        Code = "code",
                        Message = "message",
                        Reason = RepresentativePagedDataStatusDetailReason.Unverified,
                        Source = RepresentativePagedDataStatusDetailSource.Watchtower,
                    },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    ExternalID = "external_id",
                    Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                    Phone = "phone",
                    UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                },
            ],
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                MaxPageSize = 0,
                PageNumber = 0,
                PageSize = 0,
                SortBy = "sort_by",
                SortOrder = Models::SortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = RepresentativePagedResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RepresentativePaged>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RepresentativePaged
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Dob = "1980-01-01",
                    Email = "ron.swanson@pawnee.com",
                    FirstName = "Ron",
                    LastName = "Swanson",
                    MobileNumber = "+12128675309",
                    Name = "name",
                    Relationship = new()
                    {
                        Control = true,
                        Owner = true,
                        Primary = true,
                        PercentOwnership = 0,
                        Title = "title",
                    },
                    SsnLast4 = "1234",
                    Status = RepresentativePagedDataStatus.Created,
                    StatusDetail = new()
                    {
                        Code = "code",
                        Message = "message",
                        Reason = RepresentativePagedDataStatusDetailReason.Unverified,
                        Source = RepresentativePagedDataStatusDetailSource.Watchtower,
                    },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    ExternalID = "external_id",
                    Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                    Phone = "phone",
                    UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                },
            ],
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                MaxPageSize = 0,
                PageNumber = 0,
                PageSize = 0,
                SortBy = "sort_by",
                SortOrder = Models::SortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = RepresentativePagedResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RepresentativePaged>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<RepresentativePagedData> expectedData =
        [
            new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Dob = "1980-01-01",
                Email = "ron.swanson@pawnee.com",
                FirstName = "Ron",
                LastName = "Swanson",
                MobileNumber = "+12128675309",
                Name = "name",
                Relationship = new()
                {
                    Control = true,
                    Owner = true,
                    Primary = true,
                    PercentOwnership = 0,
                    Title = "title",
                },
                SsnLast4 = "1234",
                Status = RepresentativePagedDataStatus.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = RepresentativePagedDataStatusDetailReason.Unverified,
                    Source = RepresentativePagedDataStatusDetailSource.Watchtower,
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                Phone = "phone",
                UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            },
        ];
        Models::PagedResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = Models::SortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };
        ApiEnum<string, RepresentativePagedResponseType> expectedResponseType =
            RepresentativePagedResponseType.Object;

        Assert.Equal(expectedData.Count, deserialized.Data.Count);
        for (int i = 0; i < expectedData.Count; i++)
        {
            Assert.Equal(expectedData[i], deserialized.Data[i]);
        }
        Assert.Equal(expectedMeta, deserialized.Meta);
        Assert.Equal(expectedResponseType, deserialized.ResponseType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new RepresentativePaged
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Dob = "1980-01-01",
                    Email = "ron.swanson@pawnee.com",
                    FirstName = "Ron",
                    LastName = "Swanson",
                    MobileNumber = "+12128675309",
                    Name = "name",
                    Relationship = new()
                    {
                        Control = true,
                        Owner = true,
                        Primary = true,
                        PercentOwnership = 0,
                        Title = "title",
                    },
                    SsnLast4 = "1234",
                    Status = RepresentativePagedDataStatus.Created,
                    StatusDetail = new()
                    {
                        Code = "code",
                        Message = "message",
                        Reason = RepresentativePagedDataStatusDetailReason.Unverified,
                        Source = RepresentativePagedDataStatusDetailSource.Watchtower,
                    },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    ExternalID = "external_id",
                    Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                    Phone = "phone",
                    UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                },
            ],
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                MaxPageSize = 0,
                PageNumber = 0,
                PageSize = 0,
                SortBy = "sort_by",
                SortOrder = Models::SortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = RepresentativePagedResponseType.Object,
        };

        model.Validate();
    }
}

public class RepresentativePagedDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new RepresentativePagedData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Dob = "1980-01-01",
            Email = "ron.swanson@pawnee.com",
            FirstName = "Ron",
            LastName = "Swanson",
            MobileNumber = "+12128675309",
            Name = "name",
            Relationship = new()
            {
                Control = true,
                Owner = true,
                Primary = true,
                PercentOwnership = 0,
                Title = "title",
            },
            SsnLast4 = "1234",
            Status = RepresentativePagedDataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = RepresentativePagedDataStatusDetailReason.Unverified,
                Source = RepresentativePagedDataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            Phone = "phone",
            UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        string expectedAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedDob = "1980-01-01";
        string expectedEmail = "ron.swanson@pawnee.com";
        string expectedFirstName = "Ron";
        string expectedLastName = "Swanson";
        string expectedMobileNumber = "+12128675309";
        string expectedName = "name";
        RepresentativePagedDataRelationship expectedRelationship = new()
        {
            Control = true,
            Owner = true,
            Primary = true,
            PercentOwnership = 0,
            Title = "title",
        };
        string expectedSsnLast4 = "1234";
        ApiEnum<string, RepresentativePagedDataStatus> expectedStatus =
            RepresentativePagedDataStatus.Created;
        RepresentativePagedDataStatusDetail expectedStatusDetail = new()
        {
            Code = "code",
            Message = "message",
            Reason = RepresentativePagedDataStatusDetailReason.Unverified,
            Source = RepresentativePagedDataStatusDetailSource.Watchtower,
        };
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        string expectedPhone = "phone";
        string expectedUserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAccountID, model.AccountID);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedDob, model.Dob);
        Assert.Equal(expectedEmail, model.Email);
        Assert.Equal(expectedFirstName, model.FirstName);
        Assert.Equal(expectedLastName, model.LastName);
        Assert.Equal(expectedMobileNumber, model.MobileNumber);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedRelationship, model.Relationship);
        Assert.Equal(expectedSsnLast4, model.SsnLast4);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedStatusDetail, model.StatusDetail);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
        Assert.Equal(expectedExternalID, model.ExternalID);
        Assert.NotNull(model.Metadata);
        Assert.Equal(expectedMetadata.Count, model.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(model.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Metadata[item.Key]);
        }
        Assert.Equal(expectedPhone, model.Phone);
        Assert.Equal(expectedUserID, model.UserID);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new RepresentativePagedData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Dob = "1980-01-01",
            Email = "ron.swanson@pawnee.com",
            FirstName = "Ron",
            LastName = "Swanson",
            MobileNumber = "+12128675309",
            Name = "name",
            Relationship = new()
            {
                Control = true,
                Owner = true,
                Primary = true,
                PercentOwnership = 0,
                Title = "title",
            },
            SsnLast4 = "1234",
            Status = RepresentativePagedDataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = RepresentativePagedDataStatusDetailReason.Unverified,
                Source = RepresentativePagedDataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            Phone = "phone",
            UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RepresentativePagedData>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RepresentativePagedData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Dob = "1980-01-01",
            Email = "ron.swanson@pawnee.com",
            FirstName = "Ron",
            LastName = "Swanson",
            MobileNumber = "+12128675309",
            Name = "name",
            Relationship = new()
            {
                Control = true,
                Owner = true,
                Primary = true,
                PercentOwnership = 0,
                Title = "title",
            },
            SsnLast4 = "1234",
            Status = RepresentativePagedDataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = RepresentativePagedDataStatusDetailReason.Unverified,
                Source = RepresentativePagedDataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            Phone = "phone",
            UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RepresentativePagedData>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        string expectedAccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedDob = "1980-01-01";
        string expectedEmail = "ron.swanson@pawnee.com";
        string expectedFirstName = "Ron";
        string expectedLastName = "Swanson";
        string expectedMobileNumber = "+12128675309";
        string expectedName = "name";
        RepresentativePagedDataRelationship expectedRelationship = new()
        {
            Control = true,
            Owner = true,
            Primary = true,
            PercentOwnership = 0,
            Title = "title",
        };
        string expectedSsnLast4 = "1234";
        ApiEnum<string, RepresentativePagedDataStatus> expectedStatus =
            RepresentativePagedDataStatus.Created;
        RepresentativePagedDataStatusDetail expectedStatusDetail = new()
        {
            Code = "code",
            Message = "message",
            Reason = RepresentativePagedDataStatusDetailReason.Unverified,
            Source = RepresentativePagedDataStatusDetailSource.Watchtower,
        };
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        string expectedPhone = "phone";
        string expectedUserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAccountID, deserialized.AccountID);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedDob, deserialized.Dob);
        Assert.Equal(expectedEmail, deserialized.Email);
        Assert.Equal(expectedFirstName, deserialized.FirstName);
        Assert.Equal(expectedLastName, deserialized.LastName);
        Assert.Equal(expectedMobileNumber, deserialized.MobileNumber);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedRelationship, deserialized.Relationship);
        Assert.Equal(expectedSsnLast4, deserialized.SsnLast4);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedStatusDetail, deserialized.StatusDetail);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
        Assert.Equal(expectedExternalID, deserialized.ExternalID);
        Assert.NotNull(deserialized.Metadata);
        Assert.Equal(expectedMetadata.Count, deserialized.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(deserialized.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Metadata[item.Key]);
        }
        Assert.Equal(expectedPhone, deserialized.Phone);
        Assert.Equal(expectedUserID, deserialized.UserID);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new RepresentativePagedData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Dob = "1980-01-01",
            Email = "ron.swanson@pawnee.com",
            FirstName = "Ron",
            LastName = "Swanson",
            MobileNumber = "+12128675309",
            Name = "name",
            Relationship = new()
            {
                Control = true,
                Owner = true,
                Primary = true,
                PercentOwnership = 0,
                Title = "title",
            },
            SsnLast4 = "1234",
            Status = RepresentativePagedDataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = RepresentativePagedDataStatusDetailReason.Unverified,
                Source = RepresentativePagedDataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            Phone = "phone",
            UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new RepresentativePagedData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Dob = "1980-01-01",
            Email = "ron.swanson@pawnee.com",
            FirstName = "Ron",
            LastName = "Swanson",
            MobileNumber = "+12128675309",
            Name = "name",
            Relationship = new()
            {
                Control = true,
                Owner = true,
                Primary = true,
                PercentOwnership = 0,
                Title = "title",
            },
            SsnLast4 = "1234",
            Status = RepresentativePagedDataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = RepresentativePagedDataStatusDetailReason.Unverified,
                Source = RepresentativePagedDataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        Assert.Null(model.ExternalID);
        Assert.False(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.Metadata);
        Assert.False(model.RawData.ContainsKey("metadata"));
        Assert.Null(model.Phone);
        Assert.False(model.RawData.ContainsKey("phone"));
        Assert.Null(model.UserID);
        Assert.False(model.RawData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new RepresentativePagedData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Dob = "1980-01-01",
            Email = "ron.swanson@pawnee.com",
            FirstName = "Ron",
            LastName = "Swanson",
            MobileNumber = "+12128675309",
            Name = "name",
            Relationship = new()
            {
                Control = true,
                Owner = true,
                Primary = true,
                PercentOwnership = 0,
                Title = "title",
            },
            SsnLast4 = "1234",
            Status = RepresentativePagedDataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = RepresentativePagedDataStatusDetailReason.Unverified,
                Source = RepresentativePagedDataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new RepresentativePagedData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Dob = "1980-01-01",
            Email = "ron.swanson@pawnee.com",
            FirstName = "Ron",
            LastName = "Swanson",
            MobileNumber = "+12128675309",
            Name = "name",
            Relationship = new()
            {
                Control = true,
                Owner = true,
                Primary = true,
                PercentOwnership = 0,
                Title = "title",
            },
            SsnLast4 = "1234",
            Status = RepresentativePagedDataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = RepresentativePagedDataStatusDetailReason.Unverified,
                Source = RepresentativePagedDataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),

            ExternalID = null,
            Metadata = null,
            Phone = null,
            UserID = null,
        };

        Assert.Null(model.ExternalID);
        Assert.True(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.Metadata);
        Assert.True(model.RawData.ContainsKey("metadata"));
        Assert.Null(model.Phone);
        Assert.True(model.RawData.ContainsKey("phone"));
        Assert.Null(model.UserID);
        Assert.True(model.RawData.ContainsKey("user_id"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new RepresentativePagedData
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            AccountID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Dob = "1980-01-01",
            Email = "ron.swanson@pawnee.com",
            FirstName = "Ron",
            LastName = "Swanson",
            MobileNumber = "+12128675309",
            Name = "name",
            Relationship = new()
            {
                Control = true,
                Owner = true,
                Primary = true,
                PercentOwnership = 0,
                Title = "title",
            },
            SsnLast4 = "1234",
            Status = RepresentativePagedDataStatus.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = RepresentativePagedDataStatusDetailReason.Unverified,
                Source = RepresentativePagedDataStatusDetailSource.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),

            ExternalID = null,
            Metadata = null,
            Phone = null,
            UserID = null,
        };

        model.Validate();
    }
}

public class RepresentativePagedDataRelationshipTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new RepresentativePagedDataRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,
            PercentOwnership = 0,
            Title = "title",
        };

        bool expectedControl = true;
        bool expectedOwner = true;
        bool expectedPrimary = true;
        double expectedPercentOwnership = 0;
        string expectedTitle = "title";

        Assert.Equal(expectedControl, model.Control);
        Assert.Equal(expectedOwner, model.Owner);
        Assert.Equal(expectedPrimary, model.Primary);
        Assert.Equal(expectedPercentOwnership, model.PercentOwnership);
        Assert.Equal(expectedTitle, model.Title);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new RepresentativePagedDataRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,
            PercentOwnership = 0,
            Title = "title",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RepresentativePagedDataRelationship>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RepresentativePagedDataRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,
            PercentOwnership = 0,
            Title = "title",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RepresentativePagedDataRelationship>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        bool expectedControl = true;
        bool expectedOwner = true;
        bool expectedPrimary = true;
        double expectedPercentOwnership = 0;
        string expectedTitle = "title";

        Assert.Equal(expectedControl, deserialized.Control);
        Assert.Equal(expectedOwner, deserialized.Owner);
        Assert.Equal(expectedPrimary, deserialized.Primary);
        Assert.Equal(expectedPercentOwnership, deserialized.PercentOwnership);
        Assert.Equal(expectedTitle, deserialized.Title);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new RepresentativePagedDataRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,
            PercentOwnership = 0,
            Title = "title",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new RepresentativePagedDataRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,
        };

        Assert.Null(model.PercentOwnership);
        Assert.False(model.RawData.ContainsKey("percent_ownership"));
        Assert.Null(model.Title);
        Assert.False(model.RawData.ContainsKey("title"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new RepresentativePagedDataRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new RepresentativePagedDataRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,

            PercentOwnership = null,
            Title = null,
        };

        Assert.Null(model.PercentOwnership);
        Assert.True(model.RawData.ContainsKey("percent_ownership"));
        Assert.Null(model.Title);
        Assert.True(model.RawData.ContainsKey("title"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new RepresentativePagedDataRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,

            PercentOwnership = null,
            Title = null,
        };

        model.Validate();
    }
}

public class RepresentativePagedDataStatusTest : TestBase
{
    [Theory]
    [InlineData(RepresentativePagedDataStatus.Created)]
    [InlineData(RepresentativePagedDataStatus.Onboarding)]
    [InlineData(RepresentativePagedDataStatus.Active)]
    [InlineData(RepresentativePagedDataStatus.Rejected)]
    [InlineData(RepresentativePagedDataStatus.Inactive)]
    public void Validation_Works(RepresentativePagedDataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, RepresentativePagedDataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, RepresentativePagedDataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(RepresentativePagedDataStatus.Created)]
    [InlineData(RepresentativePagedDataStatus.Onboarding)]
    [InlineData(RepresentativePagedDataStatus.Active)]
    [InlineData(RepresentativePagedDataStatus.Rejected)]
    [InlineData(RepresentativePagedDataStatus.Inactive)]
    public void SerializationRoundtrip_Works(RepresentativePagedDataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, RepresentativePagedDataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, RepresentativePagedDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, RepresentativePagedDataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, RepresentativePagedDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class RepresentativePagedDataStatusDetailTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new RepresentativePagedDataStatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = RepresentativePagedDataStatusDetailReason.Unverified,
            Source = RepresentativePagedDataStatusDetailSource.Watchtower,
        };

        string expectedCode = "code";
        string expectedMessage = "message";
        ApiEnum<string, RepresentativePagedDataStatusDetailReason> expectedReason =
            RepresentativePagedDataStatusDetailReason.Unverified;
        ApiEnum<string, RepresentativePagedDataStatusDetailSource> expectedSource =
            RepresentativePagedDataStatusDetailSource.Watchtower;

        Assert.Equal(expectedCode, model.Code);
        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedReason, model.Reason);
        Assert.Equal(expectedSource, model.Source);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new RepresentativePagedDataStatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = RepresentativePagedDataStatusDetailReason.Unverified,
            Source = RepresentativePagedDataStatusDetailSource.Watchtower,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RepresentativePagedDataStatusDetail>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RepresentativePagedDataStatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = RepresentativePagedDataStatusDetailReason.Unverified,
            Source = RepresentativePagedDataStatusDetailSource.Watchtower,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RepresentativePagedDataStatusDetail>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedCode = "code";
        string expectedMessage = "message";
        ApiEnum<string, RepresentativePagedDataStatusDetailReason> expectedReason =
            RepresentativePagedDataStatusDetailReason.Unverified;
        ApiEnum<string, RepresentativePagedDataStatusDetailSource> expectedSource =
            RepresentativePagedDataStatusDetailSource.Watchtower;

        Assert.Equal(expectedCode, deserialized.Code);
        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedReason, deserialized.Reason);
        Assert.Equal(expectedSource, deserialized.Source);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new RepresentativePagedDataStatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = RepresentativePagedDataStatusDetailReason.Unverified,
            Source = RepresentativePagedDataStatusDetailSource.Watchtower,
        };

        model.Validate();
    }
}

public class RepresentativePagedDataStatusDetailReasonTest : TestBase
{
    [Theory]
    [InlineData(RepresentativePagedDataStatusDetailReason.Unverified)]
    [InlineData(RepresentativePagedDataStatusDetailReason.InReview)]
    [InlineData(RepresentativePagedDataStatusDetailReason.Pending)]
    [InlineData(RepresentativePagedDataStatusDetailReason.Stuck)]
    [InlineData(RepresentativePagedDataStatusDetailReason.Verified)]
    [InlineData(RepresentativePagedDataStatusDetailReason.FailedVerification)]
    [InlineData(RepresentativePagedDataStatusDetailReason.Disabled)]
    [InlineData(RepresentativePagedDataStatusDetailReason.New)]
    public void Validation_Works(RepresentativePagedDataStatusDetailReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, RepresentativePagedDataStatusDetailReason> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, RepresentativePagedDataStatusDetailReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(RepresentativePagedDataStatusDetailReason.Unverified)]
    [InlineData(RepresentativePagedDataStatusDetailReason.InReview)]
    [InlineData(RepresentativePagedDataStatusDetailReason.Pending)]
    [InlineData(RepresentativePagedDataStatusDetailReason.Stuck)]
    [InlineData(RepresentativePagedDataStatusDetailReason.Verified)]
    [InlineData(RepresentativePagedDataStatusDetailReason.FailedVerification)]
    [InlineData(RepresentativePagedDataStatusDetailReason.Disabled)]
    [InlineData(RepresentativePagedDataStatusDetailReason.New)]
    public void SerializationRoundtrip_Works(RepresentativePagedDataStatusDetailReason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, RepresentativePagedDataStatusDetailReason> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, RepresentativePagedDataStatusDetailReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, RepresentativePagedDataStatusDetailReason>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, RepresentativePagedDataStatusDetailReason>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class RepresentativePagedDataStatusDetailSourceTest : TestBase
{
    [Theory]
    [InlineData(RepresentativePagedDataStatusDetailSource.Watchtower)]
    public void Validation_Works(RepresentativePagedDataStatusDetailSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, RepresentativePagedDataStatusDetailSource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, RepresentativePagedDataStatusDetailSource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(RepresentativePagedDataStatusDetailSource.Watchtower)]
    public void SerializationRoundtrip_Works(RepresentativePagedDataStatusDetailSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, RepresentativePagedDataStatusDetailSource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, RepresentativePagedDataStatusDetailSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, RepresentativePagedDataStatusDetailSource>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, RepresentativePagedDataStatusDetailSource>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class RepresentativePagedResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(RepresentativePagedResponseType.Object)]
    [InlineData(RepresentativePagedResponseType.Array)]
    [InlineData(RepresentativePagedResponseType.Error)]
    [InlineData(RepresentativePagedResponseType.None)]
    public void Validation_Works(RepresentativePagedResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, RepresentativePagedResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, RepresentativePagedResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(RepresentativePagedResponseType.Object)]
    [InlineData(RepresentativePagedResponseType.Array)]
    [InlineData(RepresentativePagedResponseType.Error)]
    [InlineData(RepresentativePagedResponseType.None)]
    public void SerializationRoundtrip_Works(RepresentativePagedResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, RepresentativePagedResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, RepresentativePagedResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, RepresentativePagedResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, RepresentativePagedResponseType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}
