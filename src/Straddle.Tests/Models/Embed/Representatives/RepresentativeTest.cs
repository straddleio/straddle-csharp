using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Embed.Representatives;
using Models = Straddle.Models;

namespace Straddle.Tests.Models.Embed.Representatives;

public class RepresentativeTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Representative
        {
            Data = new()
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
                Status = Status.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = Reason.Unverified,
                    Source = Source.Watchtower,
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                Phone = "phone",
                UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ResponseType.Object,
        };

        Data expectedData = new()
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
            Status = Status.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            Phone = "phone",
            UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };
        Models::ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, ResponseType> expectedResponseType = ResponseType.Object;

        Assert.Equal(expectedData, model.Data);
        Assert.Equal(expectedMeta, model.Meta);
        Assert.Equal(expectedResponseType, model.ResponseType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Representative
        {
            Data = new()
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
                Status = Status.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = Reason.Unverified,
                    Source = Source.Watchtower,
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                Phone = "phone",
                UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Representative>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Representative
        {
            Data = new()
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
                Status = Status.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = Reason.Unverified,
                    Source = Source.Watchtower,
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                Phone = "phone",
                UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Representative>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        Data expectedData = new()
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
            Status = Status.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            Phone = "phone",
            UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };
        Models::ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, ResponseType> expectedResponseType = ResponseType.Object;

        Assert.Equal(expectedData, deserialized.Data);
        Assert.Equal(expectedMeta, deserialized.Meta);
        Assert.Equal(expectedResponseType, deserialized.ResponseType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Representative
        {
            Data = new()
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
                Status = Status.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = Reason.Unverified,
                    Source = Source.Watchtower,
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                Phone = "phone",
                UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ResponseType.Object,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Representative
        {
            Data = new()
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
                Status = Status.Created,
                StatusDetail = new()
                {
                    Code = "code",
                    Message = "message",
                    Reason = Reason.Unverified,
                    Source = Source.Watchtower,
                },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                Phone = "phone",
                UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ResponseType.Object,
        };

        Representative copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Data
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
            Status = Status.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
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
        DataRelationship expectedRelationship = new()
        {
            Control = true,
            Owner = true,
            Primary = true,
            PercentOwnership = 0,
            Title = "title",
        };
        string expectedSsnLast4 = "1234";
        ApiEnum<string, Status> expectedStatus = Status.Created;
        StatusDetail expectedStatusDetail = new()
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
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
        var model = new Data
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
            Status = Status.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            Phone = "phone",
            UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Data
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
            Status = Status.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            Phone = "phone",
            UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
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
        DataRelationship expectedRelationship = new()
        {
            Control = true,
            Owner = true,
            Primary = true,
            PercentOwnership = 0,
            Title = "title",
        };
        string expectedSsnLast4 = "1234";
        ApiEnum<string, Status> expectedStatus = Status.Created;
        StatusDetail expectedStatusDetail = new()
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
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
        var model = new Data
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
            Status = Status.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
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
        var model = new Data
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
            Status = Status.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
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
        var model = new Data
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
            Status = Status.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Data
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
            Status = Status.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
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
        var model = new Data
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
            Status = Status.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),

            ExternalID = null,
            Metadata = null,
            Phone = null,
            UserID = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Data
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
            Status = Status.Created,
            StatusDetail = new()
            {
                Code = "code",
                Message = "message",
                Reason = Reason.Unverified,
                Source = Source.Watchtower,
            },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            Phone = "phone",
            UserID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DataRelationshipTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new DataRelationship
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
        var model = new DataRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,
            PercentOwnership = 0,
            Title = "title",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<DataRelationship>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new DataRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,
            PercentOwnership = 0,
            Title = "title",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<DataRelationship>(
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
        var model = new DataRelationship
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
        var model = new DataRelationship
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
        var model = new DataRelationship
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
        var model = new DataRelationship
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
        var model = new DataRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,

            PercentOwnership = null,
            Title = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new DataRelationship
        {
            Control = true,
            Owner = true,
            Primary = true,
            PercentOwnership = 0,
            Title = "title",
        };

        DataRelationship copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class StatusTest : TestBase
{
    [Theory]
    [InlineData(Status.Created)]
    [InlineData(Status.Onboarding)]
    [InlineData(Status.Active)]
    [InlineData(Status.Rejected)]
    [InlineData(Status.Inactive)]
    public void Validation_Works(Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Status> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Status.Created)]
    [InlineData(Status.Onboarding)]
    [InlineData(Status.Active)]
    [InlineData(Status.Rejected)]
    [InlineData(Status.Inactive)]
    public void SerializationRoundtrip_Works(Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Status> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class StatusDetailTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new StatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
        };

        string expectedCode = "code";
        string expectedMessage = "message";
        ApiEnum<string, Reason> expectedReason = Reason.Unverified;
        ApiEnum<string, Source> expectedSource = Source.Watchtower;

        Assert.Equal(expectedCode, model.Code);
        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedReason, model.Reason);
        Assert.Equal(expectedSource, model.Source);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new StatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<StatusDetail>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new StatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<StatusDetail>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedCode = "code";
        string expectedMessage = "message";
        ApiEnum<string, Reason> expectedReason = Reason.Unverified;
        ApiEnum<string, Source> expectedSource = Source.Watchtower;

        Assert.Equal(expectedCode, deserialized.Code);
        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedReason, deserialized.Reason);
        Assert.Equal(expectedSource, deserialized.Source);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new StatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new StatusDetail
        {
            Code = "code",
            Message = "message",
            Reason = Reason.Unverified,
            Source = Source.Watchtower,
        };

        StatusDetail copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class ReasonTest : TestBase
{
    [Theory]
    [InlineData(Reason.Unverified)]
    [InlineData(Reason.InReview)]
    [InlineData(Reason.Pending)]
    [InlineData(Reason.Stuck)]
    [InlineData(Reason.Verified)]
    [InlineData(Reason.FailedVerification)]
    [InlineData(Reason.Disabled)]
    [InlineData(Reason.New)]
    public void Validation_Works(Reason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Reason> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Reason>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Reason.Unverified)]
    [InlineData(Reason.InReview)]
    [InlineData(Reason.Pending)]
    [InlineData(Reason.Stuck)]
    [InlineData(Reason.Verified)]
    [InlineData(Reason.FailedVerification)]
    [InlineData(Reason.Disabled)]
    [InlineData(Reason.New)]
    public void SerializationRoundtrip_Works(Reason rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Reason> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Reason>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Reason>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Reason>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class SourceTest : TestBase
{
    [Theory]
    [InlineData(Source.Watchtower)]
    public void Validation_Works(Source rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Source> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Source>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Source.Watchtower)]
    public void SerializationRoundtrip_Works(Source rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Source> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Source>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Source>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Source>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class ResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(ResponseType.Object)]
    [InlineData(ResponseType.Array)]
    [InlineData(ResponseType.Error)]
    [InlineData(ResponseType.None)]
    public void Validation_Works(ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ResponseType.Object)]
    [InlineData(ResponseType.Array)]
    [InlineData(ResponseType.Error)]
    [InlineData(ResponseType.None)]
    public void SerializationRoundtrip_Works(ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ResponseType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ResponseType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
