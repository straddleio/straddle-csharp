using System;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models;

namespace Straddle.Tests.Models;

public class StatusDetailsV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new StatusDetailsV1
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.System,
            Code = null,
        };

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Payment successfully created and awaiting validation.";
        ApiEnum<string, Reason> expectedReason = Reason.InsufficientFunds;
        ApiEnum<string, Source> expectedSource = Source.System;

        Assert.Equal(expectedChangedAt, model.ChangedAt);
        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedReason, model.Reason);
        Assert.Equal(expectedSource, model.Source);
        Assert.Null(model.Code);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new StatusDetailsV1
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.System,
            Code = null,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<StatusDetailsV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new StatusDetailsV1
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.System,
            Code = null,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<StatusDetailsV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Payment successfully created and awaiting validation.";
        ApiEnum<string, Reason> expectedReason = Reason.InsufficientFunds;
        ApiEnum<string, Source> expectedSource = Source.System;

        Assert.Equal(expectedChangedAt, deserialized.ChangedAt);
        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedReason, deserialized.Reason);
        Assert.Equal(expectedSource, deserialized.Source);
        Assert.Null(deserialized.Code);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new StatusDetailsV1
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.System,
            Code = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new StatusDetailsV1
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.System,
        };

        Assert.Null(model.Code);
        Assert.False(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new StatusDetailsV1
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.System,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new StatusDetailsV1
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.System,

            Code = null,
        };

        Assert.Null(model.Code);
        Assert.True(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new StatusDetailsV1
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.System,

            Code = null,
        };

        model.Validate();
    }
}

public class ReasonTest : TestBase
{
    [Theory]
    [InlineData(Reason.InsufficientFunds)]
    [InlineData(Reason.ClosedBankAccount)]
    [InlineData(Reason.InvalidBankAccount)]
    [InlineData(Reason.InvalidRouting)]
    [InlineData(Reason.Disputed)]
    [InlineData(Reason.PaymentStopped)]
    [InlineData(Reason.OwnerDeceased)]
    [InlineData(Reason.FrozenBankAccount)]
    [InlineData(Reason.RiskReview)]
    [InlineData(Reason.Fraudulent)]
    [InlineData(Reason.DuplicateEntry)]
    [InlineData(Reason.InvalidPaykey)]
    [InlineData(Reason.PaymentBlocked)]
    [InlineData(Reason.AmountTooLarge)]
    [InlineData(Reason.TooManyAttempts)]
    [InlineData(Reason.InternalSystemError)]
    [InlineData(Reason.UserRequest)]
    [InlineData(Reason.Ok)]
    [InlineData(Reason.OtherNetworkReturn)]
    [InlineData(Reason.PayoutRefused)]
    [InlineData(Reason.CancelRequest)]
    [InlineData(Reason.FailedVerification)]
    [InlineData(Reason.RequireReview)]
    [InlineData(Reason.BlockedBySystem)]
    [InlineData(Reason.WatchtowerReview)]
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
    [InlineData(Reason.InsufficientFunds)]
    [InlineData(Reason.ClosedBankAccount)]
    [InlineData(Reason.InvalidBankAccount)]
    [InlineData(Reason.InvalidRouting)]
    [InlineData(Reason.Disputed)]
    [InlineData(Reason.PaymentStopped)]
    [InlineData(Reason.OwnerDeceased)]
    [InlineData(Reason.FrozenBankAccount)]
    [InlineData(Reason.RiskReview)]
    [InlineData(Reason.Fraudulent)]
    [InlineData(Reason.DuplicateEntry)]
    [InlineData(Reason.InvalidPaykey)]
    [InlineData(Reason.PaymentBlocked)]
    [InlineData(Reason.AmountTooLarge)]
    [InlineData(Reason.TooManyAttempts)]
    [InlineData(Reason.InternalSystemError)]
    [InlineData(Reason.UserRequest)]
    [InlineData(Reason.Ok)]
    [InlineData(Reason.OtherNetworkReturn)]
    [InlineData(Reason.PayoutRefused)]
    [InlineData(Reason.CancelRequest)]
    [InlineData(Reason.FailedVerification)]
    [InlineData(Reason.RequireReview)]
    [InlineData(Reason.BlockedBySystem)]
    [InlineData(Reason.WatchtowerReview)]
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
    [InlineData(Source.BankDecline)]
    [InlineData(Source.CustomerDispute)]
    [InlineData(Source.UserAction)]
    [InlineData(Source.System)]
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
    [InlineData(Source.BankDecline)]
    [InlineData(Source.CustomerDispute)]
    [InlineData(Source.UserAction)]
    [InlineData(Source.System)]
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
