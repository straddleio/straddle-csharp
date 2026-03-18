using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models.Paykeys.Review;
using Models = Straddle.Models;

namespace Straddle.Tests.Models.Paykeys.Review;

public class ReviewGetResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ReviewGetResponse
        {
            Data = new()
            {
                PaykeyDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Config = new()
                    {
                        ProcessingMethod = ProcessingMethod.Inline,
                        SandboxOutcome = SandboxOutcome.Standard,
                    },
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Label = "label",
                    Paykey = "paykey",
                    Source = Source.BankAccount,
                    Status = PaykeyDetailsStatus.Pending,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Balance = new()
                    {
                        Status = BalanceStatus.Pending,
                        AccountBalance = 0,
                        UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    },
                    BankData = new()
                    {
                        AccountNumber = "****1234",
                        AccountType = AccountType.Checking,
                        RoutingNumber = "021000021",
                    },
                    CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    ExternalID = "external_id",
                    InstitutionName = "Bank of America",
                    Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                    StatusDetails = new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Bank account sucesfully validated",
                        Reason = Reason.InsufficientFunds,
                        Source = StatusDetailsSource.Watchtower,
                        Code = "code",
                    },
                    UnblockEligible = true,
                },
                VerificationDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Breakdown = new()
                    {
                        AccountValidation = new()
                        {
                            Codes = ["string"],
                            Decision = Decision.Accept,
                            Reason = "reason",
                        },
                        NameMatch = new()
                        {
                            Codes = ["string"],
                            Decision = NameMatchDecision.Accept,
                            CorrelationScore = 0,
                            CustomerName = "customer_name",
                            MatchedName = "matched_name",
                            NamesOnAccount = ["string"],
                            Reason = "reason",
                        },
                    },
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Decision = VerificationDetailsDecision.Accept,
                    Messages = new Dictionary<string, string>() { { "foo", "string" } },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
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
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = ProcessingMethod.Inline,
                    SandboxOutcome = SandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = Source.BankAccount,
                Status = PaykeyDetailsStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = AccountType.Checking,
                    RoutingNumber = "021000021",
                },
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                InstitutionName = "Bank of America",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = Reason.InsufficientFunds,
                    Source = StatusDetailsSource.Watchtower,
                    Code = "code",
                },
                UnblockEligible = true,
            },
            VerificationDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Breakdown = new()
                {
                    AccountValidation = new()
                    {
                        Codes = ["string"],
                        Decision = Decision.Accept,
                        Reason = "reason",
                    },
                    NameMatch = new()
                    {
                        Codes = ["string"],
                        Decision = NameMatchDecision.Accept,
                        CorrelationScore = 0,
                        CustomerName = "customer_name",
                        MatchedName = "matched_name",
                        NamesOnAccount = ["string"],
                        Reason = "reason",
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Decision = VerificationDetailsDecision.Accept,
                Messages = new Dictionary<string, string>() { { "foo", "string" } },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
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
        var model = new ReviewGetResponse
        {
            Data = new()
            {
                PaykeyDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Config = new()
                    {
                        ProcessingMethod = ProcessingMethod.Inline,
                        SandboxOutcome = SandboxOutcome.Standard,
                    },
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Label = "label",
                    Paykey = "paykey",
                    Source = Source.BankAccount,
                    Status = PaykeyDetailsStatus.Pending,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Balance = new()
                    {
                        Status = BalanceStatus.Pending,
                        AccountBalance = 0,
                        UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    },
                    BankData = new()
                    {
                        AccountNumber = "****1234",
                        AccountType = AccountType.Checking,
                        RoutingNumber = "021000021",
                    },
                    CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    ExternalID = "external_id",
                    InstitutionName = "Bank of America",
                    Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                    StatusDetails = new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Bank account sucesfully validated",
                        Reason = Reason.InsufficientFunds,
                        Source = StatusDetailsSource.Watchtower,
                        Code = "code",
                    },
                    UnblockEligible = true,
                },
                VerificationDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Breakdown = new()
                    {
                        AccountValidation = new()
                        {
                            Codes = ["string"],
                            Decision = Decision.Accept,
                            Reason = "reason",
                        },
                        NameMatch = new()
                        {
                            Codes = ["string"],
                            Decision = NameMatchDecision.Accept,
                            CorrelationScore = 0,
                            CustomerName = "customer_name",
                            MatchedName = "matched_name",
                            NamesOnAccount = ["string"],
                            Reason = "reason",
                        },
                    },
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Decision = VerificationDetailsDecision.Accept,
                    Messages = new Dictionary<string, string>() { { "foo", "string" } },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ReviewGetResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ReviewGetResponse
        {
            Data = new()
            {
                PaykeyDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Config = new()
                    {
                        ProcessingMethod = ProcessingMethod.Inline,
                        SandboxOutcome = SandboxOutcome.Standard,
                    },
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Label = "label",
                    Paykey = "paykey",
                    Source = Source.BankAccount,
                    Status = PaykeyDetailsStatus.Pending,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Balance = new()
                    {
                        Status = BalanceStatus.Pending,
                        AccountBalance = 0,
                        UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    },
                    BankData = new()
                    {
                        AccountNumber = "****1234",
                        AccountType = AccountType.Checking,
                        RoutingNumber = "021000021",
                    },
                    CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    ExternalID = "external_id",
                    InstitutionName = "Bank of America",
                    Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                    StatusDetails = new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Bank account sucesfully validated",
                        Reason = Reason.InsufficientFunds,
                        Source = StatusDetailsSource.Watchtower,
                        Code = "code",
                    },
                    UnblockEligible = true,
                },
                VerificationDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Breakdown = new()
                    {
                        AccountValidation = new()
                        {
                            Codes = ["string"],
                            Decision = Decision.Accept,
                            Reason = "reason",
                        },
                        NameMatch = new()
                        {
                            Codes = ["string"],
                            Decision = NameMatchDecision.Accept,
                            CorrelationScore = 0,
                            CustomerName = "customer_name",
                            MatchedName = "matched_name",
                            NamesOnAccount = ["string"],
                            Reason = "reason",
                        },
                    },
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Decision = VerificationDetailsDecision.Accept,
                    Messages = new Dictionary<string, string>() { { "foo", "string" } },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ReviewGetResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        Data expectedData = new()
        {
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = ProcessingMethod.Inline,
                    SandboxOutcome = SandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = Source.BankAccount,
                Status = PaykeyDetailsStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = AccountType.Checking,
                    RoutingNumber = "021000021",
                },
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                InstitutionName = "Bank of America",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = Reason.InsufficientFunds,
                    Source = StatusDetailsSource.Watchtower,
                    Code = "code",
                },
                UnblockEligible = true,
            },
            VerificationDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Breakdown = new()
                {
                    AccountValidation = new()
                    {
                        Codes = ["string"],
                        Decision = Decision.Accept,
                        Reason = "reason",
                    },
                    NameMatch = new()
                    {
                        Codes = ["string"],
                        Decision = NameMatchDecision.Accept,
                        CorrelationScore = 0,
                        CustomerName = "customer_name",
                        MatchedName = "matched_name",
                        NamesOnAccount = ["string"],
                        Reason = "reason",
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Decision = VerificationDetailsDecision.Accept,
                Messages = new Dictionary<string, string>() { { "foo", "string" } },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
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
        var model = new ReviewGetResponse
        {
            Data = new()
            {
                PaykeyDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Config = new()
                    {
                        ProcessingMethod = ProcessingMethod.Inline,
                        SandboxOutcome = SandboxOutcome.Standard,
                    },
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Label = "label",
                    Paykey = "paykey",
                    Source = Source.BankAccount,
                    Status = PaykeyDetailsStatus.Pending,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Balance = new()
                    {
                        Status = BalanceStatus.Pending,
                        AccountBalance = 0,
                        UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    },
                    BankData = new()
                    {
                        AccountNumber = "****1234",
                        AccountType = AccountType.Checking,
                        RoutingNumber = "021000021",
                    },
                    CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    ExternalID = "external_id",
                    InstitutionName = "Bank of America",
                    Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                    StatusDetails = new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Bank account sucesfully validated",
                        Reason = Reason.InsufficientFunds,
                        Source = StatusDetailsSource.Watchtower,
                        Code = "code",
                    },
                    UnblockEligible = true,
                },
                VerificationDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Breakdown = new()
                    {
                        AccountValidation = new()
                        {
                            Codes = ["string"],
                            Decision = Decision.Accept,
                            Reason = "reason",
                        },
                        NameMatch = new()
                        {
                            Codes = ["string"],
                            Decision = NameMatchDecision.Accept,
                            CorrelationScore = 0,
                            CustomerName = "customer_name",
                            MatchedName = "matched_name",
                            NamesOnAccount = ["string"],
                            Reason = "reason",
                        },
                    },
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Decision = VerificationDetailsDecision.Accept,
                    Messages = new Dictionary<string, string>() { { "foo", "string" } },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
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
        var model = new ReviewGetResponse
        {
            Data = new()
            {
                PaykeyDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Config = new()
                    {
                        ProcessingMethod = ProcessingMethod.Inline,
                        SandboxOutcome = SandboxOutcome.Standard,
                    },
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Label = "label",
                    Paykey = "paykey",
                    Source = Source.BankAccount,
                    Status = PaykeyDetailsStatus.Pending,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Balance = new()
                    {
                        Status = BalanceStatus.Pending,
                        AccountBalance = 0,
                        UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    },
                    BankData = new()
                    {
                        AccountNumber = "****1234",
                        AccountType = AccountType.Checking,
                        RoutingNumber = "021000021",
                    },
                    CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    ExternalID = "external_id",
                    InstitutionName = "Bank of America",
                    Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                    StatusDetails = new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Bank account sucesfully validated",
                        Reason = Reason.InsufficientFunds,
                        Source = StatusDetailsSource.Watchtower,
                        Code = "code",
                    },
                    UnblockEligible = true,
                },
                VerificationDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Breakdown = new()
                    {
                        AccountValidation = new()
                        {
                            Codes = ["string"],
                            Decision = Decision.Accept,
                            Reason = "reason",
                        },
                        NameMatch = new()
                        {
                            Codes = ["string"],
                            Decision = NameMatchDecision.Accept,
                            CorrelationScore = 0,
                            CustomerName = "customer_name",
                            MatchedName = "matched_name",
                            NamesOnAccount = ["string"],
                            Reason = "reason",
                        },
                    },
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Decision = VerificationDetailsDecision.Accept,
                    Messages = new Dictionary<string, string>() { { "foo", "string" } },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = ResponseType.Object,
        };

        ReviewGetResponse copied = new(model);

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
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = ProcessingMethod.Inline,
                    SandboxOutcome = SandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = Source.BankAccount,
                Status = PaykeyDetailsStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = AccountType.Checking,
                    RoutingNumber = "021000021",
                },
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                InstitutionName = "Bank of America",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = Reason.InsufficientFunds,
                    Source = StatusDetailsSource.Watchtower,
                    Code = "code",
                },
                UnblockEligible = true,
            },
            VerificationDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Breakdown = new()
                {
                    AccountValidation = new()
                    {
                        Codes = ["string"],
                        Decision = Decision.Accept,
                        Reason = "reason",
                    },
                    NameMatch = new()
                    {
                        Codes = ["string"],
                        Decision = NameMatchDecision.Accept,
                        CorrelationScore = 0,
                        CustomerName = "customer_name",
                        MatchedName = "matched_name",
                        NamesOnAccount = ["string"],
                        Reason = "reason",
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Decision = VerificationDetailsDecision.Accept,
                Messages = new Dictionary<string, string>() { { "foo", "string" } },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
        };

        PaykeyDetails expectedPaykeyDetails = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = Source.BankAccount,
            Status = PaykeyDetailsStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = AccountType.Checking,
                RoutingNumber = "021000021",
            },
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },
            UnblockEligible = true,
        };
        VerificationDetails expectedVerificationDetails = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Breakdown = new()
            {
                AccountValidation = new()
                {
                    Codes = ["string"],
                    Decision = Decision.Accept,
                    Reason = "reason",
                },
                NameMatch = new()
                {
                    Codes = ["string"],
                    Decision = NameMatchDecision.Accept,
                    CorrelationScore = 0,
                    CustomerName = "customer_name",
                    MatchedName = "matched_name",
                    NamesOnAccount = ["string"],
                    Reason = "reason",
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = VerificationDetailsDecision.Accept,
            Messages = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        Assert.Equal(expectedPaykeyDetails, model.PaykeyDetails);
        Assert.Equal(expectedVerificationDetails, model.VerificationDetails);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
        {
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = ProcessingMethod.Inline,
                    SandboxOutcome = SandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = Source.BankAccount,
                Status = PaykeyDetailsStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = AccountType.Checking,
                    RoutingNumber = "021000021",
                },
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                InstitutionName = "Bank of America",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = Reason.InsufficientFunds,
                    Source = StatusDetailsSource.Watchtower,
                    Code = "code",
                },
                UnblockEligible = true,
            },
            VerificationDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Breakdown = new()
                {
                    AccountValidation = new()
                    {
                        Codes = ["string"],
                        Decision = Decision.Accept,
                        Reason = "reason",
                    },
                    NameMatch = new()
                    {
                        Codes = ["string"],
                        Decision = NameMatchDecision.Accept,
                        CorrelationScore = 0,
                        CustomerName = "customer_name",
                        MatchedName = "matched_name",
                        NamesOnAccount = ["string"],
                        Reason = "reason",
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Decision = VerificationDetailsDecision.Accept,
                Messages = new Dictionary<string, string>() { { "foo", "string" } },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
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
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = ProcessingMethod.Inline,
                    SandboxOutcome = SandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = Source.BankAccount,
                Status = PaykeyDetailsStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = AccountType.Checking,
                    RoutingNumber = "021000021",
                },
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                InstitutionName = "Bank of America",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = Reason.InsufficientFunds,
                    Source = StatusDetailsSource.Watchtower,
                    Code = "code",
                },
                UnblockEligible = true,
            },
            VerificationDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Breakdown = new()
                {
                    AccountValidation = new()
                    {
                        Codes = ["string"],
                        Decision = Decision.Accept,
                        Reason = "reason",
                    },
                    NameMatch = new()
                    {
                        Codes = ["string"],
                        Decision = NameMatchDecision.Accept,
                        CorrelationScore = 0,
                        CustomerName = "customer_name",
                        MatchedName = "matched_name",
                        NamesOnAccount = ["string"],
                        Reason = "reason",
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Decision = VerificationDetailsDecision.Accept,
                Messages = new Dictionary<string, string>() { { "foo", "string" } },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        PaykeyDetails expectedPaykeyDetails = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = Source.BankAccount,
            Status = PaykeyDetailsStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = AccountType.Checking,
                RoutingNumber = "021000021",
            },
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },
            UnblockEligible = true,
        };
        VerificationDetails expectedVerificationDetails = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Breakdown = new()
            {
                AccountValidation = new()
                {
                    Codes = ["string"],
                    Decision = Decision.Accept,
                    Reason = "reason",
                },
                NameMatch = new()
                {
                    Codes = ["string"],
                    Decision = NameMatchDecision.Accept,
                    CorrelationScore = 0,
                    CustomerName = "customer_name",
                    MatchedName = "matched_name",
                    NamesOnAccount = ["string"],
                    Reason = "reason",
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = VerificationDetailsDecision.Accept,
            Messages = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        Assert.Equal(expectedPaykeyDetails, deserialized.PaykeyDetails);
        Assert.Equal(expectedVerificationDetails, deserialized.VerificationDetails);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
        {
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = ProcessingMethod.Inline,
                    SandboxOutcome = SandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = Source.BankAccount,
                Status = PaykeyDetailsStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = AccountType.Checking,
                    RoutingNumber = "021000021",
                },
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                InstitutionName = "Bank of America",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = Reason.InsufficientFunds,
                    Source = StatusDetailsSource.Watchtower,
                    Code = "code",
                },
                UnblockEligible = true,
            },
            VerificationDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Breakdown = new()
                {
                    AccountValidation = new()
                    {
                        Codes = ["string"],
                        Decision = Decision.Accept,
                        Reason = "reason",
                    },
                    NameMatch = new()
                    {
                        Codes = ["string"],
                        Decision = NameMatchDecision.Accept,
                        CorrelationScore = 0,
                        CustomerName = "customer_name",
                        MatchedName = "matched_name",
                        NamesOnAccount = ["string"],
                        Reason = "reason",
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Decision = VerificationDetailsDecision.Accept,
                Messages = new Dictionary<string, string>() { { "foo", "string" } },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data
        {
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = ProcessingMethod.Inline,
                    SandboxOutcome = SandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = Source.BankAccount,
                Status = PaykeyDetailsStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = AccountType.Checking,
                    RoutingNumber = "021000021",
                },
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                InstitutionName = "Bank of America",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = Reason.InsufficientFunds,
                    Source = StatusDetailsSource.Watchtower,
                    Code = "code",
                },
                UnblockEligible = true,
            },
        };

        Assert.Null(model.VerificationDetails);
        Assert.False(model.RawData.ContainsKey("verification_details"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Data
        {
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = ProcessingMethod.Inline,
                    SandboxOutcome = SandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = Source.BankAccount,
                Status = PaykeyDetailsStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = AccountType.Checking,
                    RoutingNumber = "021000021",
                },
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                InstitutionName = "Bank of America",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = Reason.InsufficientFunds,
                    Source = StatusDetailsSource.Watchtower,
                    Code = "code",
                },
                UnblockEligible = true,
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Data
        {
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = ProcessingMethod.Inline,
                    SandboxOutcome = SandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = Source.BankAccount,
                Status = PaykeyDetailsStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = AccountType.Checking,
                    RoutingNumber = "021000021",
                },
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                InstitutionName = "Bank of America",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = Reason.InsufficientFunds,
                    Source = StatusDetailsSource.Watchtower,
                    Code = "code",
                },
                UnblockEligible = true,
            },

            // Null should be interpreted as omitted for these properties
            VerificationDetails = null,
        };

        Assert.Null(model.VerificationDetails);
        Assert.False(model.RawData.ContainsKey("verification_details"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Data
        {
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = ProcessingMethod.Inline,
                    SandboxOutcome = SandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = Source.BankAccount,
                Status = PaykeyDetailsStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = AccountType.Checking,
                    RoutingNumber = "021000021",
                },
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                InstitutionName = "Bank of America",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = Reason.InsufficientFunds,
                    Source = StatusDetailsSource.Watchtower,
                    Code = "code",
                },
                UnblockEligible = true,
            },

            // Null should be interpreted as omitted for these properties
            VerificationDetails = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Data
        {
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Config = new()
                {
                    ProcessingMethod = ProcessingMethod.Inline,
                    SandboxOutcome = SandboxOutcome.Standard,
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Label = "label",
                Paykey = "paykey",
                Source = Source.BankAccount,
                Status = PaykeyDetailsStatus.Pending,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Balance = new()
                {
                    Status = BalanceStatus.Pending,
                    AccountBalance = 0,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                },
                BankData = new()
                {
                    AccountNumber = "****1234",
                    AccountType = AccountType.Checking,
                    RoutingNumber = "021000021",
                },
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                ExternalID = "external_id",
                InstitutionName = "Bank of America",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Bank account sucesfully validated",
                    Reason = Reason.InsufficientFunds,
                    Source = StatusDetailsSource.Watchtower,
                    Code = "code",
                },
                UnblockEligible = true,
            },
            VerificationDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Breakdown = new()
                {
                    AccountValidation = new()
                    {
                        Codes = ["string"],
                        Decision = Decision.Accept,
                        Reason = "reason",
                    },
                    NameMatch = new()
                    {
                        Codes = ["string"],
                        Decision = NameMatchDecision.Accept,
                        CorrelationScore = 0,
                        CustomerName = "customer_name",
                        MatchedName = "matched_name",
                        NamesOnAccount = ["string"],
                        Reason = "reason",
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Decision = VerificationDetailsDecision.Accept,
                Messages = new Dictionary<string, string>() { { "foo", "string" } },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
        };

        Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class PaykeyDetailsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaykeyDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = Source.BankAccount,
            Status = PaykeyDetailsStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = AccountType.Checking,
                RoutingNumber = "021000021",
            },
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },
            UnblockEligible = true,
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        Config expectedConfig = new()
        {
            ProcessingMethod = ProcessingMethod.Inline,
            SandboxOutcome = SandboxOutcome.Standard,
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedLabel = "label";
        string expectedPaykey = "paykey";
        ApiEnum<string, Source> expectedSource = Source.BankAccount;
        ApiEnum<string, PaykeyDetailsStatus> expectedStatus = PaykeyDetailsStatus.Pending;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        Balance expectedBalance = new()
        {
            Status = BalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        BankData expectedBankData = new()
        {
            AccountNumber = "****1234",
            AccountType = AccountType.Checking,
            RoutingNumber = "021000021",
        };
        string expectedCustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";
        string expectedInstitutionName = "Bank of America";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        StatusDetails expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,
            Code = "code",
        };
        bool expectedUnblockEligible = true;

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedConfig, model.Config);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedLabel, model.Label);
        Assert.Equal(expectedPaykey, model.Paykey);
        Assert.Equal(expectedSource, model.Source);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
        Assert.Equal(expectedBalance, model.Balance);
        Assert.Equal(expectedBankData, model.BankData);
        Assert.Equal(expectedCustomerID, model.CustomerID);
        Assert.Equal(expectedExpiresAt, model.ExpiresAt);
        Assert.Equal(expectedExternalID, model.ExternalID);
        Assert.Equal(expectedInstitutionName, model.InstitutionName);
        Assert.NotNull(model.Metadata);
        Assert.Equal(expectedMetadata.Count, model.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(model.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Metadata[item.Key]);
        }
        Assert.Equal(expectedStatusDetails, model.StatusDetails);
        Assert.Equal(expectedUnblockEligible, model.UnblockEligible);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new PaykeyDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = Source.BankAccount,
            Status = PaykeyDetailsStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = AccountType.Checking,
                RoutingNumber = "021000021",
            },
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },
            UnblockEligible = true,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyDetails>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaykeyDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = Source.BankAccount,
            Status = PaykeyDetailsStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = AccountType.Checking,
                RoutingNumber = "021000021",
            },
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },
            UnblockEligible = true,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaykeyDetails>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        Config expectedConfig = new()
        {
            ProcessingMethod = ProcessingMethod.Inline,
            SandboxOutcome = SandboxOutcome.Standard,
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedLabel = "label";
        string expectedPaykey = "paykey";
        ApiEnum<string, Source> expectedSource = Source.BankAccount;
        ApiEnum<string, PaykeyDetailsStatus> expectedStatus = PaykeyDetailsStatus.Pending;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        Balance expectedBalance = new()
        {
            Status = BalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        BankData expectedBankData = new()
        {
            AccountNumber = "****1234",
            AccountType = AccountType.Checking,
            RoutingNumber = "021000021",
        };
        string expectedCustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedExternalID = "external_id";
        string expectedInstitutionName = "Bank of America";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };
        StatusDetails expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,
            Code = "code",
        };
        bool expectedUnblockEligible = true;

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedConfig, deserialized.Config);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedLabel, deserialized.Label);
        Assert.Equal(expectedPaykey, deserialized.Paykey);
        Assert.Equal(expectedSource, deserialized.Source);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
        Assert.Equal(expectedBalance, deserialized.Balance);
        Assert.Equal(expectedBankData, deserialized.BankData);
        Assert.Equal(expectedCustomerID, deserialized.CustomerID);
        Assert.Equal(expectedExpiresAt, deserialized.ExpiresAt);
        Assert.Equal(expectedExternalID, deserialized.ExternalID);
        Assert.Equal(expectedInstitutionName, deserialized.InstitutionName);
        Assert.NotNull(deserialized.Metadata);
        Assert.Equal(expectedMetadata.Count, deserialized.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(deserialized.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Metadata[item.Key]);
        }
        Assert.Equal(expectedStatusDetails, deserialized.StatusDetails);
        Assert.Equal(expectedUnblockEligible, deserialized.UnblockEligible);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new PaykeyDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = Source.BankAccount,
            Status = PaykeyDetailsStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = AccountType.Checking,
                RoutingNumber = "021000021",
            },
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },
            UnblockEligible = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PaykeyDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = Source.BankAccount,
            Status = PaykeyDetailsStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            UnblockEligible = true,
        };

        Assert.Null(model.Balance);
        Assert.False(model.RawData.ContainsKey("balance"));
        Assert.Null(model.BankData);
        Assert.False(model.RawData.ContainsKey("bank_data"));
        Assert.Null(model.StatusDetails);
        Assert.False(model.RawData.ContainsKey("status_details"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new PaykeyDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = Source.BankAccount,
            Status = PaykeyDetailsStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            UnblockEligible = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new PaykeyDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = Source.BankAccount,
            Status = PaykeyDetailsStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            UnblockEligible = true,

            // Null should be interpreted as omitted for these properties
            Balance = null,
            BankData = null,
            StatusDetails = null,
        };

        Assert.Null(model.Balance);
        Assert.False(model.RawData.ContainsKey("balance"));
        Assert.Null(model.BankData);
        Assert.False(model.RawData.ContainsKey("bank_data"));
        Assert.Null(model.StatusDetails);
        Assert.False(model.RawData.ContainsKey("status_details"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new PaykeyDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = Source.BankAccount,
            Status = PaykeyDetailsStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            UnblockEligible = true,

            // Null should be interpreted as omitted for these properties
            Balance = null,
            BankData = null,
            StatusDetails = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new PaykeyDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = Source.BankAccount,
            Status = PaykeyDetailsStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = AccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        Assert.Null(model.CustomerID);
        Assert.False(model.RawData.ContainsKey("customer_id"));
        Assert.Null(model.ExpiresAt);
        Assert.False(model.RawData.ContainsKey("expires_at"));
        Assert.Null(model.ExternalID);
        Assert.False(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.InstitutionName);
        Assert.False(model.RawData.ContainsKey("institution_name"));
        Assert.Null(model.Metadata);
        Assert.False(model.RawData.ContainsKey("metadata"));
        Assert.Null(model.UnblockEligible);
        Assert.False(model.RawData.ContainsKey("unblock_eligible"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new PaykeyDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = Source.BankAccount,
            Status = PaykeyDetailsStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = AccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new PaykeyDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = Source.BankAccount,
            Status = PaykeyDetailsStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = AccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },

            CustomerID = null,
            ExpiresAt = null,
            ExternalID = null,
            InstitutionName = null,
            Metadata = null,
            UnblockEligible = null,
        };

        Assert.Null(model.CustomerID);
        Assert.True(model.RawData.ContainsKey("customer_id"));
        Assert.Null(model.ExpiresAt);
        Assert.True(model.RawData.ContainsKey("expires_at"));
        Assert.Null(model.ExternalID);
        Assert.True(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.InstitutionName);
        Assert.True(model.RawData.ContainsKey("institution_name"));
        Assert.Null(model.Metadata);
        Assert.True(model.RawData.ContainsKey("metadata"));
        Assert.Null(model.UnblockEligible);
        Assert.True(model.RawData.ContainsKey("unblock_eligible"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new PaykeyDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = Source.BankAccount,
            Status = PaykeyDetailsStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = AccountType.Checking,
                RoutingNumber = "021000021",
            },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },

            CustomerID = null,
            ExpiresAt = null,
            ExternalID = null,
            InstitutionName = null,
            Metadata = null,
            UnblockEligible = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new PaykeyDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Config = new()
            {
                ProcessingMethod = ProcessingMethod.Inline,
                SandboxOutcome = SandboxOutcome.Standard,
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Label = "label",
            Paykey = "paykey",
            Source = Source.BankAccount,
            Status = PaykeyDetailsStatus.Pending,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Balance = new()
            {
                Status = BalanceStatus.Pending,
                AccountBalance = 0,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            BankData = new()
            {
                AccountNumber = "****1234",
                AccountType = AccountType.Checking,
                RoutingNumber = "021000021",
            },
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ExpiresAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            ExternalID = "external_id",
            InstitutionName = "Bank of America",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Bank account sucesfully validated",
                Reason = Reason.InsufficientFunds,
                Source = StatusDetailsSource.Watchtower,
                Code = "code",
            },
            UnblockEligible = true,
        };

        PaykeyDetails copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class ConfigTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Config
        {
            ProcessingMethod = ProcessingMethod.Inline,
            SandboxOutcome = SandboxOutcome.Standard,
        };

        ApiEnum<string, ProcessingMethod> expectedProcessingMethod = ProcessingMethod.Inline;
        ApiEnum<string, SandboxOutcome> expectedSandboxOutcome = SandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, model.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, model.SandboxOutcome);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Config
        {
            ProcessingMethod = ProcessingMethod.Inline,
            SandboxOutcome = SandboxOutcome.Standard,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Config>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Config
        {
            ProcessingMethod = ProcessingMethod.Inline,
            SandboxOutcome = SandboxOutcome.Standard,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Config>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        ApiEnum<string, ProcessingMethod> expectedProcessingMethod = ProcessingMethod.Inline;
        ApiEnum<string, SandboxOutcome> expectedSandboxOutcome = SandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, deserialized.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, deserialized.SandboxOutcome);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Config
        {
            ProcessingMethod = ProcessingMethod.Inline,
            SandboxOutcome = SandboxOutcome.Standard,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Config { };

        Assert.Null(model.ProcessingMethod);
        Assert.False(model.RawData.ContainsKey("processing_method"));
        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Config { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Config
        {
            // Null should be interpreted as omitted for these properties
            ProcessingMethod = null,
            SandboxOutcome = null,
        };

        Assert.Null(model.ProcessingMethod);
        Assert.False(model.RawData.ContainsKey("processing_method"));
        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Config
        {
            // Null should be interpreted as omitted for these properties
            ProcessingMethod = null,
            SandboxOutcome = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Config
        {
            ProcessingMethod = ProcessingMethod.Inline,
            SandboxOutcome = SandboxOutcome.Standard,
        };

        Config copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class ProcessingMethodTest : TestBase
{
    [Theory]
    [InlineData(ProcessingMethod.Inline)]
    [InlineData(ProcessingMethod.Background)]
    [InlineData(ProcessingMethod.Skip)]
    public void Validation_Works(ProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ProcessingMethod> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ProcessingMethod>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ProcessingMethod.Inline)]
    [InlineData(ProcessingMethod.Background)]
    [InlineData(ProcessingMethod.Skip)]
    public void SerializationRoundtrip_Works(ProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ProcessingMethod> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ProcessingMethod>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ProcessingMethod>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, ProcessingMethod>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class SandboxOutcomeTest : TestBase
{
    [Theory]
    [InlineData(SandboxOutcome.Standard)]
    [InlineData(SandboxOutcome.Active)]
    [InlineData(SandboxOutcome.Rejected)]
    [InlineData(SandboxOutcome.Review)]
    public void Validation_Works(SandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, SandboxOutcome> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, SandboxOutcome>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(SandboxOutcome.Standard)]
    [InlineData(SandboxOutcome.Active)]
    [InlineData(SandboxOutcome.Rejected)]
    [InlineData(SandboxOutcome.Review)]
    public void SerializationRoundtrip_Works(SandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, SandboxOutcome> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, SandboxOutcome>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, SandboxOutcome>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, SandboxOutcome>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class SourceTest : TestBase
{
    [Theory]
    [InlineData(Source.BankAccount)]
    [InlineData(Source.Straddle)]
    [InlineData(Source.Mx)]
    [InlineData(Source.Plaid)]
    [InlineData(Source.Tan)]
    [InlineData(Source.Quiltt)]
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
    [InlineData(Source.BankAccount)]
    [InlineData(Source.Straddle)]
    [InlineData(Source.Mx)]
    [InlineData(Source.Plaid)]
    [InlineData(Source.Tan)]
    [InlineData(Source.Quiltt)]
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

public class PaykeyDetailsStatusTest : TestBase
{
    [Theory]
    [InlineData(PaykeyDetailsStatus.Pending)]
    [InlineData(PaykeyDetailsStatus.Active)]
    [InlineData(PaykeyDetailsStatus.Inactive)]
    [InlineData(PaykeyDetailsStatus.Rejected)]
    [InlineData(PaykeyDetailsStatus.Review)]
    [InlineData(PaykeyDetailsStatus.Blocked)]
    public void Validation_Works(PaykeyDetailsStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyDetailsStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyDetailsStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(PaykeyDetailsStatus.Pending)]
    [InlineData(PaykeyDetailsStatus.Active)]
    [InlineData(PaykeyDetailsStatus.Inactive)]
    [InlineData(PaykeyDetailsStatus.Rejected)]
    [InlineData(PaykeyDetailsStatus.Review)]
    [InlineData(PaykeyDetailsStatus.Blocked)]
    public void SerializationRoundtrip_Works(PaykeyDetailsStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, PaykeyDetailsStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaykeyDetailsStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, PaykeyDetailsStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, PaykeyDetailsStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class BalanceTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Balance
        {
            Status = BalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        ApiEnum<string, BalanceStatus> expectedStatus = BalanceStatus.Pending;
        int expectedAccountBalance = 0;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedAccountBalance, model.AccountBalance);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Balance
        {
            Status = BalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Balance>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Balance
        {
            Status = BalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Balance>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, BalanceStatus> expectedStatus = BalanceStatus.Pending;
        int expectedAccountBalance = 0;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedAccountBalance, deserialized.AccountBalance);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Balance
        {
            Status = BalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Balance { Status = BalanceStatus.Pending };

        Assert.Null(model.AccountBalance);
        Assert.False(model.RawData.ContainsKey("account_balance"));
        Assert.Null(model.UpdatedAt);
        Assert.False(model.RawData.ContainsKey("updated_at"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new Balance { Status = BalanceStatus.Pending };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Balance
        {
            Status = BalanceStatus.Pending,

            AccountBalance = null,
            UpdatedAt = null,
        };

        Assert.Null(model.AccountBalance);
        Assert.True(model.RawData.ContainsKey("account_balance"));
        Assert.Null(model.UpdatedAt);
        Assert.True(model.RawData.ContainsKey("updated_at"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Balance
        {
            Status = BalanceStatus.Pending,

            AccountBalance = null,
            UpdatedAt = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Balance
        {
            Status = BalanceStatus.Pending,
            AccountBalance = 0,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        Balance copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class BalanceStatusTest : TestBase
{
    [Theory]
    [InlineData(BalanceStatus.Pending)]
    [InlineData(BalanceStatus.Completed)]
    [InlineData(BalanceStatus.Failed)]
    public void Validation_Works(BalanceStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, BalanceStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, BalanceStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(BalanceStatus.Pending)]
    [InlineData(BalanceStatus.Completed)]
    [InlineData(BalanceStatus.Failed)]
    public void SerializationRoundtrip_Works(BalanceStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, BalanceStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, BalanceStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, BalanceStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, BalanceStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class BankDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new BankData
        {
            AccountNumber = "****1234",
            AccountType = AccountType.Checking,
            RoutingNumber = "021000021",
        };

        string expectedAccountNumber = "****1234";
        ApiEnum<string, AccountType> expectedAccountType = AccountType.Checking;
        string expectedRoutingNumber = "021000021";

        Assert.Equal(expectedAccountNumber, model.AccountNumber);
        Assert.Equal(expectedAccountType, model.AccountType);
        Assert.Equal(expectedRoutingNumber, model.RoutingNumber);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new BankData
        {
            AccountNumber = "****1234",
            AccountType = AccountType.Checking,
            RoutingNumber = "021000021",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<BankData>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new BankData
        {
            AccountNumber = "****1234",
            AccountType = AccountType.Checking,
            RoutingNumber = "021000021",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<BankData>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedAccountNumber = "****1234";
        ApiEnum<string, AccountType> expectedAccountType = AccountType.Checking;
        string expectedRoutingNumber = "021000021";

        Assert.Equal(expectedAccountNumber, deserialized.AccountNumber);
        Assert.Equal(expectedAccountType, deserialized.AccountType);
        Assert.Equal(expectedRoutingNumber, deserialized.RoutingNumber);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new BankData
        {
            AccountNumber = "****1234",
            AccountType = AccountType.Checking,
            RoutingNumber = "021000021",
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new BankData
        {
            AccountNumber = "****1234",
            AccountType = AccountType.Checking,
            RoutingNumber = "021000021",
        };

        BankData copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountTypeTest : TestBase
{
    [Theory]
    [InlineData(AccountType.Checking)]
    [InlineData(AccountType.Savings)]
    public void Validation_Works(AccountType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, AccountType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(AccountType.Checking)]
    [InlineData(AccountType.Savings)]
    public void SerializationRoundtrip_Works(AccountType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, AccountType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, AccountType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, AccountType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class StatusDetailsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,
            Code = "code",
        };

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Bank account sucesfully validated";
        ApiEnum<string, Reason> expectedReason = Reason.InsufficientFunds;
        ApiEnum<string, StatusDetailsSource> expectedSource = StatusDetailsSource.Watchtower;
        string expectedCode = "code";

        Assert.Equal(expectedChangedAt, model.ChangedAt);
        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedReason, model.Reason);
        Assert.Equal(expectedSource, model.Source);
        Assert.Equal(expectedCode, model.Code);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,
            Code = "code",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<StatusDetails>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,
            Code = "code",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<StatusDetails>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        DateTimeOffset expectedChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedMessage = "Bank account sucesfully validated";
        ApiEnum<string, Reason> expectedReason = Reason.InsufficientFunds;
        ApiEnum<string, StatusDetailsSource> expectedSource = StatusDetailsSource.Watchtower;
        string expectedCode = "code";

        Assert.Equal(expectedChangedAt, deserialized.ChangedAt);
        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedReason, deserialized.Reason);
        Assert.Equal(expectedSource, deserialized.Source);
        Assert.Equal(expectedCode, deserialized.Code);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,
            Code = "code",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,
        };

        Assert.Null(model.Code);
        Assert.False(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,

            Code = null,
        };

        Assert.Null(model.Code);
        Assert.True(model.RawData.ContainsKey("code"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,

            Code = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new StatusDetails
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Bank account sucesfully validated",
            Reason = Reason.InsufficientFunds,
            Source = StatusDetailsSource.Watchtower,
            Code = "code",
        };

        StatusDetails copied = new(model);

        Assert.Equal(model, copied);
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

public class StatusDetailsSourceTest : TestBase
{
    [Theory]
    [InlineData(StatusDetailsSource.Watchtower)]
    [InlineData(StatusDetailsSource.BankDecline)]
    [InlineData(StatusDetailsSource.CustomerDispute)]
    [InlineData(StatusDetailsSource.UserAction)]
    [InlineData(StatusDetailsSource.System)]
    public void Validation_Works(StatusDetailsSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, StatusDetailsSource> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, StatusDetailsSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(StatusDetailsSource.Watchtower)]
    [InlineData(StatusDetailsSource.BankDecline)]
    [InlineData(StatusDetailsSource.CustomerDispute)]
    [InlineData(StatusDetailsSource.UserAction)]
    [InlineData(StatusDetailsSource.System)]
    public void SerializationRoundtrip_Works(StatusDetailsSource rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, StatusDetailsSource> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, StatusDetailsSource>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, StatusDetailsSource>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, StatusDetailsSource>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class VerificationDetailsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new VerificationDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Breakdown = new()
            {
                AccountValidation = new()
                {
                    Codes = ["string"],
                    Decision = Decision.Accept,
                    Reason = "reason",
                },
                NameMatch = new()
                {
                    Codes = ["string"],
                    Decision = NameMatchDecision.Accept,
                    CorrelationScore = 0,
                    CustomerName = "customer_name",
                    MatchedName = "matched_name",
                    NamesOnAccount = ["string"],
                    Reason = "reason",
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = VerificationDetailsDecision.Accept,
            Messages = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        Breakdown expectedBreakdown = new()
        {
            AccountValidation = new()
            {
                Codes = ["string"],
                Decision = Decision.Accept,
                Reason = "reason",
            },
            NameMatch = new()
            {
                Codes = ["string"],
                Decision = NameMatchDecision.Accept,
                CorrelationScore = 0,
                CustomerName = "customer_name",
                MatchedName = "matched_name",
                NamesOnAccount = ["string"],
                Reason = "reason",
            },
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        ApiEnum<string, VerificationDetailsDecision> expectedDecision =
            VerificationDetailsDecision.Accept;
        Dictionary<string, string> expectedMessages = new() { { "foo", "string" } };
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedBreakdown, model.Breakdown);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedDecision, model.Decision);
        Assert.Equal(expectedMessages.Count, model.Messages.Count);
        foreach (var item in expectedMessages)
        {
            Assert.True(model.Messages.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Messages[item.Key]);
        }
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new VerificationDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Breakdown = new()
            {
                AccountValidation = new()
                {
                    Codes = ["string"],
                    Decision = Decision.Accept,
                    Reason = "reason",
                },
                NameMatch = new()
                {
                    Codes = ["string"],
                    Decision = NameMatchDecision.Accept,
                    CorrelationScore = 0,
                    CustomerName = "customer_name",
                    MatchedName = "matched_name",
                    NamesOnAccount = ["string"],
                    Reason = "reason",
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = VerificationDetailsDecision.Accept,
            Messages = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<VerificationDetails>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new VerificationDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Breakdown = new()
            {
                AccountValidation = new()
                {
                    Codes = ["string"],
                    Decision = Decision.Accept,
                    Reason = "reason",
                },
                NameMatch = new()
                {
                    Codes = ["string"],
                    Decision = NameMatchDecision.Accept,
                    CorrelationScore = 0,
                    CustomerName = "customer_name",
                    MatchedName = "matched_name",
                    NamesOnAccount = ["string"],
                    Reason = "reason",
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = VerificationDetailsDecision.Accept,
            Messages = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<VerificationDetails>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        Breakdown expectedBreakdown = new()
        {
            AccountValidation = new()
            {
                Codes = ["string"],
                Decision = Decision.Accept,
                Reason = "reason",
            },
            NameMatch = new()
            {
                Codes = ["string"],
                Decision = NameMatchDecision.Accept,
                CorrelationScore = 0,
                CustomerName = "customer_name",
                MatchedName = "matched_name",
                NamesOnAccount = ["string"],
                Reason = "reason",
            },
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        ApiEnum<string, VerificationDetailsDecision> expectedDecision =
            VerificationDetailsDecision.Accept;
        Dictionary<string, string> expectedMessages = new() { { "foo", "string" } };
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedBreakdown, deserialized.Breakdown);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedDecision, deserialized.Decision);
        Assert.Equal(expectedMessages.Count, deserialized.Messages.Count);
        foreach (var item in expectedMessages)
        {
            Assert.True(deserialized.Messages.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Messages[item.Key]);
        }
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new VerificationDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Breakdown = new()
            {
                AccountValidation = new()
                {
                    Codes = ["string"],
                    Decision = Decision.Accept,
                    Reason = "reason",
                },
                NameMatch = new()
                {
                    Codes = ["string"],
                    Decision = NameMatchDecision.Accept,
                    CorrelationScore = 0,
                    CustomerName = "customer_name",
                    MatchedName = "matched_name",
                    NamesOnAccount = ["string"],
                    Reason = "reason",
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = VerificationDetailsDecision.Accept,
            Messages = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new VerificationDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Breakdown = new()
            {
                AccountValidation = new()
                {
                    Codes = ["string"],
                    Decision = Decision.Accept,
                    Reason = "reason",
                },
                NameMatch = new()
                {
                    Codes = ["string"],
                    Decision = NameMatchDecision.Accept,
                    CorrelationScore = 0,
                    CustomerName = "customer_name",
                    MatchedName = "matched_name",
                    NamesOnAccount = ["string"],
                    Reason = "reason",
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = VerificationDetailsDecision.Accept,
            Messages = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };

        VerificationDetails copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class BreakdownTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Breakdown
        {
            AccountValidation = new()
            {
                Codes = ["string"],
                Decision = Decision.Accept,
                Reason = "reason",
            },
            NameMatch = new()
            {
                Codes = ["string"],
                Decision = NameMatchDecision.Accept,
                CorrelationScore = 0,
                CustomerName = "customer_name",
                MatchedName = "matched_name",
                NamesOnAccount = ["string"],
                Reason = "reason",
            },
        };

        AccountValidation expectedAccountValidation = new()
        {
            Codes = ["string"],
            Decision = Decision.Accept,
            Reason = "reason",
        };
        NameMatch expectedNameMatch = new()
        {
            Codes = ["string"],
            Decision = NameMatchDecision.Accept,
            CorrelationScore = 0,
            CustomerName = "customer_name",
            MatchedName = "matched_name",
            NamesOnAccount = ["string"],
            Reason = "reason",
        };

        Assert.Equal(expectedAccountValidation, model.AccountValidation);
        Assert.Equal(expectedNameMatch, model.NameMatch);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Breakdown
        {
            AccountValidation = new()
            {
                Codes = ["string"],
                Decision = Decision.Accept,
                Reason = "reason",
            },
            NameMatch = new()
            {
                Codes = ["string"],
                Decision = NameMatchDecision.Accept,
                CorrelationScore = 0,
                CustomerName = "customer_name",
                MatchedName = "matched_name",
                NamesOnAccount = ["string"],
                Reason = "reason",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Breakdown>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Breakdown
        {
            AccountValidation = new()
            {
                Codes = ["string"],
                Decision = Decision.Accept,
                Reason = "reason",
            },
            NameMatch = new()
            {
                Codes = ["string"],
                Decision = NameMatchDecision.Accept,
                CorrelationScore = 0,
                CustomerName = "customer_name",
                MatchedName = "matched_name",
                NamesOnAccount = ["string"],
                Reason = "reason",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Breakdown>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        AccountValidation expectedAccountValidation = new()
        {
            Codes = ["string"],
            Decision = Decision.Accept,
            Reason = "reason",
        };
        NameMatch expectedNameMatch = new()
        {
            Codes = ["string"],
            Decision = NameMatchDecision.Accept,
            CorrelationScore = 0,
            CustomerName = "customer_name",
            MatchedName = "matched_name",
            NamesOnAccount = ["string"],
            Reason = "reason",
        };

        Assert.Equal(expectedAccountValidation, deserialized.AccountValidation);
        Assert.Equal(expectedNameMatch, deserialized.NameMatch);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Breakdown
        {
            AccountValidation = new()
            {
                Codes = ["string"],
                Decision = Decision.Accept,
                Reason = "reason",
            },
            NameMatch = new()
            {
                Codes = ["string"],
                Decision = NameMatchDecision.Accept,
                CorrelationScore = 0,
                CustomerName = "customer_name",
                MatchedName = "matched_name",
                NamesOnAccount = ["string"],
                Reason = "reason",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Breakdown { };

        Assert.Null(model.AccountValidation);
        Assert.False(model.RawData.ContainsKey("account_validation"));
        Assert.Null(model.NameMatch);
        Assert.False(model.RawData.ContainsKey("name_match"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Breakdown { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Breakdown
        {
            // Null should be interpreted as omitted for these properties
            AccountValidation = null,
            NameMatch = null,
        };

        Assert.Null(model.AccountValidation);
        Assert.False(model.RawData.ContainsKey("account_validation"));
        Assert.Null(model.NameMatch);
        Assert.False(model.RawData.ContainsKey("name_match"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Breakdown
        {
            // Null should be interpreted as omitted for these properties
            AccountValidation = null,
            NameMatch = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Breakdown
        {
            AccountValidation = new()
            {
                Codes = ["string"],
                Decision = Decision.Accept,
                Reason = "reason",
            },
            NameMatch = new()
            {
                Codes = ["string"],
                Decision = NameMatchDecision.Accept,
                CorrelationScore = 0,
                CustomerName = "customer_name",
                MatchedName = "matched_name",
                NamesOnAccount = ["string"],
                Reason = "reason",
            },
        };

        Breakdown copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountValidationTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountValidation
        {
            Codes = ["string"],
            Decision = Decision.Accept,
            Reason = "reason",
        };

        List<string> expectedCodes = ["string"];
        ApiEnum<string, Decision> expectedDecision = Decision.Accept;
        string expectedReason = "reason";

        Assert.Equal(expectedCodes.Count, model.Codes.Count);
        for (int i = 0; i < expectedCodes.Count; i++)
        {
            Assert.Equal(expectedCodes[i], model.Codes[i]);
        }
        Assert.Equal(expectedDecision, model.Decision);
        Assert.Equal(expectedReason, model.Reason);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AccountValidation
        {
            Codes = ["string"],
            Decision = Decision.Accept,
            Reason = "reason",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountValidation>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountValidation
        {
            Codes = ["string"],
            Decision = Decision.Accept,
            Reason = "reason",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountValidation>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<string> expectedCodes = ["string"];
        ApiEnum<string, Decision> expectedDecision = Decision.Accept;
        string expectedReason = "reason";

        Assert.Equal(expectedCodes.Count, deserialized.Codes.Count);
        for (int i = 0; i < expectedCodes.Count; i++)
        {
            Assert.Equal(expectedCodes[i], deserialized.Codes[i]);
        }
        Assert.Equal(expectedDecision, deserialized.Decision);
        Assert.Equal(expectedReason, deserialized.Reason);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AccountValidation
        {
            Codes = ["string"],
            Decision = Decision.Accept,
            Reason = "reason",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AccountValidation { Codes = ["string"], Decision = Decision.Accept };

        Assert.Null(model.Reason);
        Assert.False(model.RawData.ContainsKey("reason"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new AccountValidation { Codes = ["string"], Decision = Decision.Accept };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new AccountValidation
        {
            Codes = ["string"],
            Decision = Decision.Accept,

            Reason = null,
        };

        Assert.Null(model.Reason);
        Assert.True(model.RawData.ContainsKey("reason"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AccountValidation
        {
            Codes = ["string"],
            Decision = Decision.Accept,

            Reason = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AccountValidation
        {
            Codes = ["string"],
            Decision = Decision.Accept,
            Reason = "reason",
        };

        AccountValidation copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DecisionTest : TestBase
{
    [Theory]
    [InlineData(Decision.Accept)]
    [InlineData(Decision.Reject)]
    [InlineData(Decision.Review)]
    public void Validation_Works(Decision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Decision> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Decision>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Decision.Accept)]
    [InlineData(Decision.Reject)]
    [InlineData(Decision.Review)]
    public void SerializationRoundtrip_Works(Decision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Decision> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Decision>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Decision>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Decision>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class NameMatchTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new NameMatch
        {
            Codes = ["string"],
            Decision = NameMatchDecision.Accept,
            CorrelationScore = 0,
            CustomerName = "customer_name",
            MatchedName = "matched_name",
            NamesOnAccount = ["string"],
            Reason = "reason",
        };

        List<string> expectedCodes = ["string"];
        ApiEnum<string, NameMatchDecision> expectedDecision = NameMatchDecision.Accept;
        double expectedCorrelationScore = 0;
        string expectedCustomerName = "customer_name";
        string expectedMatchedName = "matched_name";
        List<string> expectedNamesOnAccount = ["string"];
        string expectedReason = "reason";

        Assert.Equal(expectedCodes.Count, model.Codes.Count);
        for (int i = 0; i < expectedCodes.Count; i++)
        {
            Assert.Equal(expectedCodes[i], model.Codes[i]);
        }
        Assert.Equal(expectedDecision, model.Decision);
        Assert.Equal(expectedCorrelationScore, model.CorrelationScore);
        Assert.Equal(expectedCustomerName, model.CustomerName);
        Assert.Equal(expectedMatchedName, model.MatchedName);
        Assert.NotNull(model.NamesOnAccount);
        Assert.Equal(expectedNamesOnAccount.Count, model.NamesOnAccount.Count);
        for (int i = 0; i < expectedNamesOnAccount.Count; i++)
        {
            Assert.Equal(expectedNamesOnAccount[i], model.NamesOnAccount[i]);
        }
        Assert.Equal(expectedReason, model.Reason);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new NameMatch
        {
            Codes = ["string"],
            Decision = NameMatchDecision.Accept,
            CorrelationScore = 0,
            CustomerName = "customer_name",
            MatchedName = "matched_name",
            NamesOnAccount = ["string"],
            Reason = "reason",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<NameMatch>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new NameMatch
        {
            Codes = ["string"],
            Decision = NameMatchDecision.Accept,
            CorrelationScore = 0,
            CustomerName = "customer_name",
            MatchedName = "matched_name",
            NamesOnAccount = ["string"],
            Reason = "reason",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<NameMatch>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<string> expectedCodes = ["string"];
        ApiEnum<string, NameMatchDecision> expectedDecision = NameMatchDecision.Accept;
        double expectedCorrelationScore = 0;
        string expectedCustomerName = "customer_name";
        string expectedMatchedName = "matched_name";
        List<string> expectedNamesOnAccount = ["string"];
        string expectedReason = "reason";

        Assert.Equal(expectedCodes.Count, deserialized.Codes.Count);
        for (int i = 0; i < expectedCodes.Count; i++)
        {
            Assert.Equal(expectedCodes[i], deserialized.Codes[i]);
        }
        Assert.Equal(expectedDecision, deserialized.Decision);
        Assert.Equal(expectedCorrelationScore, deserialized.CorrelationScore);
        Assert.Equal(expectedCustomerName, deserialized.CustomerName);
        Assert.Equal(expectedMatchedName, deserialized.MatchedName);
        Assert.NotNull(deserialized.NamesOnAccount);
        Assert.Equal(expectedNamesOnAccount.Count, deserialized.NamesOnAccount.Count);
        for (int i = 0; i < expectedNamesOnAccount.Count; i++)
        {
            Assert.Equal(expectedNamesOnAccount[i], deserialized.NamesOnAccount[i]);
        }
        Assert.Equal(expectedReason, deserialized.Reason);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new NameMatch
        {
            Codes = ["string"],
            Decision = NameMatchDecision.Accept,
            CorrelationScore = 0,
            CustomerName = "customer_name",
            MatchedName = "matched_name",
            NamesOnAccount = ["string"],
            Reason = "reason",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new NameMatch { Codes = ["string"], Decision = NameMatchDecision.Accept };

        Assert.Null(model.CorrelationScore);
        Assert.False(model.RawData.ContainsKey("correlation_score"));
        Assert.Null(model.CustomerName);
        Assert.False(model.RawData.ContainsKey("customer_name"));
        Assert.Null(model.MatchedName);
        Assert.False(model.RawData.ContainsKey("matched_name"));
        Assert.Null(model.NamesOnAccount);
        Assert.False(model.RawData.ContainsKey("names_on_account"));
        Assert.Null(model.Reason);
        Assert.False(model.RawData.ContainsKey("reason"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new NameMatch { Codes = ["string"], Decision = NameMatchDecision.Accept };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new NameMatch
        {
            Codes = ["string"],
            Decision = NameMatchDecision.Accept,

            CorrelationScore = null,
            CustomerName = null,
            MatchedName = null,
            NamesOnAccount = null,
            Reason = null,
        };

        Assert.Null(model.CorrelationScore);
        Assert.True(model.RawData.ContainsKey("correlation_score"));
        Assert.Null(model.CustomerName);
        Assert.True(model.RawData.ContainsKey("customer_name"));
        Assert.Null(model.MatchedName);
        Assert.True(model.RawData.ContainsKey("matched_name"));
        Assert.Null(model.NamesOnAccount);
        Assert.True(model.RawData.ContainsKey("names_on_account"));
        Assert.Null(model.Reason);
        Assert.True(model.RawData.ContainsKey("reason"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new NameMatch
        {
            Codes = ["string"],
            Decision = NameMatchDecision.Accept,

            CorrelationScore = null,
            CustomerName = null,
            MatchedName = null,
            NamesOnAccount = null,
            Reason = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new NameMatch
        {
            Codes = ["string"],
            Decision = NameMatchDecision.Accept,
            CorrelationScore = 0,
            CustomerName = "customer_name",
            MatchedName = "matched_name",
            NamesOnAccount = ["string"],
            Reason = "reason",
        };

        NameMatch copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class NameMatchDecisionTest : TestBase
{
    [Theory]
    [InlineData(NameMatchDecision.Accept)]
    [InlineData(NameMatchDecision.Reject)]
    [InlineData(NameMatchDecision.Review)]
    public void Validation_Works(NameMatchDecision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, NameMatchDecision> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, NameMatchDecision>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(NameMatchDecision.Accept)]
    [InlineData(NameMatchDecision.Reject)]
    [InlineData(NameMatchDecision.Review)]
    public void SerializationRoundtrip_Works(NameMatchDecision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, NameMatchDecision> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, NameMatchDecision>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, NameMatchDecision>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, NameMatchDecision>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class VerificationDetailsDecisionTest : TestBase
{
    [Theory]
    [InlineData(VerificationDetailsDecision.Accept)]
    [InlineData(VerificationDetailsDecision.Reject)]
    [InlineData(VerificationDetailsDecision.Review)]
    public void Validation_Works(VerificationDetailsDecision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, VerificationDetailsDecision> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, VerificationDetailsDecision>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(VerificationDetailsDecision.Accept)]
    [InlineData(VerificationDetailsDecision.Reject)]
    [InlineData(VerificationDetailsDecision.Review)]
    public void SerializationRoundtrip_Works(VerificationDetailsDecision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, VerificationDetailsDecision> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, VerificationDetailsDecision>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, VerificationDetailsDecision>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, VerificationDetailsDecision>>(
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
