using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models;
using Straddle.Models.Customers;
using Review = Straddle.Models.Customers.Review;

namespace Straddle.Tests.Models.Customers.Review;

public class CustomerReviewV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Review::CustomerReviewV1
        {
            Data = new()
            {
                CustomerDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Email = "ron.swanson@pawnee.com",
                    Name = "Ron Swanson",
                    Phone = "+12128675309",
                    Status = Review::CustomerDetailsStatus.Pending,
                    Type = Review::Type.Individual,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Address = new()
                    {
                        Address1 = "123 Main St",
                        City = "Anytown",
                        State = "CA",
                        Zip = "12345",
                        Address2 = "Apt 1",
                    },
                    ComplianceProfile = new Review::IndividualComplianceProfile()
                    {
                        Dob = "2019-12-27",
                        Ssn = "***-**-****",
                    },
                    Config = new()
                    {
                        ProcessingMethod = Review::ProcessingMethod.Inline,
                        SandboxOutcome = Review::SandboxOutcome.Standard,
                    },
                    Device = new("192.168.1.1"),
                    ExternalID = "external_id",
                    Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                },
                IdentityDetails = new()
                {
                    Breakdown = new()
                    {
                        Address = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        BusinessEvaluation = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        BusinessIdentification = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        BusinessValidation = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Email = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Fraud = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Phone = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Synthetic = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                    },
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Decision = Review::Decision.Accept,
                    ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Kyc = new()
                    {
                        Validations = new()
                        {
                            Address = true,
                            City = true,
                            Dob = true,
                            Email = true,
                            FirstName = true,
                            LastName = true,
                            Phone = true,
                            Ssn = true,
                            State = true,
                            Zip = true,
                        },
                        Codes = ["string"],
                        Decision = Review::KycDecision.Accept,
                    },
                    Messages = new Dictionary<string, string>() { { "foo", "string" } },
                    NetworkAlerts = new()
                    {
                        Alerts = ["string"],
                        Codes = ["string"],
                        Decision = Review::NetworkAlertsDecision.Accept,
                    },
                    Reputation = new()
                    {
                        Codes = ["string"],
                        Decision = Review::ReputationDecision.Accept,
                        Insights = new()
                        {
                            AccountsActiveCount = 0,
                            AccountsClosedCount = 0,
                            AccountsClosedDates = ["2019-12-27"],
                            AccountsCount = 0,
                            AccountsFraudCount = 0,
                            AccountsFraudLabeledDates = ["2019-12-27"],
                            AccountsFraudLossTotalAmount = 0,
                            AchFraudTransactionsCount = 0,
                            AchFraudTransactionsDates = ["2019-12-27"],
                            AchFraudTransactionsTotalAmount = 0,
                            AchReturnedTransactionsCount = 0,
                            AchReturnedTransactionsDates = ["2019-12-27"],
                            AchReturnedTransactionsTotalAmount = 0,
                            ApplicationsApprovedCount = 0,
                            ApplicationsCount = 0,
                            ApplicationsDates = ["2019-12-27"],
                            ApplicationsDeclinedCount = 0,
                            ApplicationsFraudCount = 0,
                            CardDisputedTransactionsCount = 0,
                            CardDisputedTransactionsDates = ["2019-12-27"],
                            CardDisputedTransactionsTotalAmount = 0,
                            CardFraudTransactionsCount = 0,
                            CardFraudTransactionsDates = ["2019-12-27"],
                            CardFraudTransactionsTotalAmount = 0,
                            CardStoppedTransactionsCount = 0,
                            CardStoppedTransactionsDates = ["2019-12-27"],
                            UserActiveProfileCount = 0,
                            UserAddressCount = 0,
                            UserClosedProfileCount = 0,
                            UserDobCount = 0,
                            UserEmailCount = 0,
                            UserInstitutionCount = 0,
                            UserMobileCount = 0,
                        },
                        RiskScore = 0,
                    },
                    WatchList = new()
                    {
                        Codes = ["string"],
                        Decision = Review::WatchListDecision.Accept,
                        Matched = ["string"],
                        Matches =
                        [
                            new()
                            {
                                Correlation = Review::Correlation.LowConfidence,
                                ListName = "list_name",
                                MatchFields = ["string"],
                                Urls = ["string"],
                            },
                        ],
                    },
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = Review::ResponseType.Object,
        };

        Review::Data expectedData = new()
        {
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = Review::CustomerDetailsStatus.Pending,
                Type = Review::Type.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile = new Review::IndividualComplianceProfile()
                {
                    Dob = "2019-12-27",
                    Ssn = "***-**-****",
                },
                Config = new()
                {
                    ProcessingMethod = Review::ProcessingMethod.Inline,
                    SandboxOutcome = Review::SandboxOutcome.Standard,
                },
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            },
            IdentityDetails = new()
            {
                Breakdown = new()
                {
                    Address = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessEvaluation = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessIdentification = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessValidation = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Email = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Fraud = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Phone = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Synthetic = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Decision = Review::Decision.Accept,
                ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Kyc = new()
                {
                    Validations = new()
                    {
                        Address = true,
                        City = true,
                        Dob = true,
                        Email = true,
                        FirstName = true,
                        LastName = true,
                        Phone = true,
                        Ssn = true,
                        State = true,
                        Zip = true,
                    },
                    Codes = ["string"],
                    Decision = Review::KycDecision.Accept,
                },
                Messages = new Dictionary<string, string>() { { "foo", "string" } },
                NetworkAlerts = new()
                {
                    Alerts = ["string"],
                    Codes = ["string"],
                    Decision = Review::NetworkAlertsDecision.Accept,
                },
                Reputation = new()
                {
                    Codes = ["string"],
                    Decision = Review::ReputationDecision.Accept,
                    Insights = new()
                    {
                        AccountsActiveCount = 0,
                        AccountsClosedCount = 0,
                        AccountsClosedDates = ["2019-12-27"],
                        AccountsCount = 0,
                        AccountsFraudCount = 0,
                        AccountsFraudLabeledDates = ["2019-12-27"],
                        AccountsFraudLossTotalAmount = 0,
                        AchFraudTransactionsCount = 0,
                        AchFraudTransactionsDates = ["2019-12-27"],
                        AchFraudTransactionsTotalAmount = 0,
                        AchReturnedTransactionsCount = 0,
                        AchReturnedTransactionsDates = ["2019-12-27"],
                        AchReturnedTransactionsTotalAmount = 0,
                        ApplicationsApprovedCount = 0,
                        ApplicationsCount = 0,
                        ApplicationsDates = ["2019-12-27"],
                        ApplicationsDeclinedCount = 0,
                        ApplicationsFraudCount = 0,
                        CardDisputedTransactionsCount = 0,
                        CardDisputedTransactionsDates = ["2019-12-27"],
                        CardDisputedTransactionsTotalAmount = 0,
                        CardFraudTransactionsCount = 0,
                        CardFraudTransactionsDates = ["2019-12-27"],
                        CardFraudTransactionsTotalAmount = 0,
                        CardStoppedTransactionsCount = 0,
                        CardStoppedTransactionsDates = ["2019-12-27"],
                        UserActiveProfileCount = 0,
                        UserAddressCount = 0,
                        UserClosedProfileCount = 0,
                        UserDobCount = 0,
                        UserEmailCount = 0,
                        UserInstitutionCount = 0,
                        UserMobileCount = 0,
                    },
                    RiskScore = 0,
                },
                WatchList = new()
                {
                    Codes = ["string"],
                    Decision = Review::WatchListDecision.Accept,
                    Matched = ["string"],
                    Matches =
                    [
                        new()
                        {
                            Correlation = Review::Correlation.LowConfidence,
                            ListName = "list_name",
                            MatchFields = ["string"],
                            Urls = ["string"],
                        },
                    ],
                },
            },
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, Review::ResponseType> expectedResponseType = Review::ResponseType.Object;

        Assert.Equal(expectedData, model.Data);
        Assert.Equal(expectedMeta, model.Meta);
        Assert.Equal(expectedResponseType, model.ResponseType);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Review::CustomerReviewV1
        {
            Data = new()
            {
                CustomerDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Email = "ron.swanson@pawnee.com",
                    Name = "Ron Swanson",
                    Phone = "+12128675309",
                    Status = Review::CustomerDetailsStatus.Pending,
                    Type = Review::Type.Individual,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Address = new()
                    {
                        Address1 = "123 Main St",
                        City = "Anytown",
                        State = "CA",
                        Zip = "12345",
                        Address2 = "Apt 1",
                    },
                    ComplianceProfile = new Review::IndividualComplianceProfile()
                    {
                        Dob = "2019-12-27",
                        Ssn = "***-**-****",
                    },
                    Config = new()
                    {
                        ProcessingMethod = Review::ProcessingMethod.Inline,
                        SandboxOutcome = Review::SandboxOutcome.Standard,
                    },
                    Device = new("192.168.1.1"),
                    ExternalID = "external_id",
                    Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                },
                IdentityDetails = new()
                {
                    Breakdown = new()
                    {
                        Address = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        BusinessEvaluation = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        BusinessIdentification = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        BusinessValidation = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Email = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Fraud = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Phone = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Synthetic = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                    },
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Decision = Review::Decision.Accept,
                    ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Kyc = new()
                    {
                        Validations = new()
                        {
                            Address = true,
                            City = true,
                            Dob = true,
                            Email = true,
                            FirstName = true,
                            LastName = true,
                            Phone = true,
                            Ssn = true,
                            State = true,
                            Zip = true,
                        },
                        Codes = ["string"],
                        Decision = Review::KycDecision.Accept,
                    },
                    Messages = new Dictionary<string, string>() { { "foo", "string" } },
                    NetworkAlerts = new()
                    {
                        Alerts = ["string"],
                        Codes = ["string"],
                        Decision = Review::NetworkAlertsDecision.Accept,
                    },
                    Reputation = new()
                    {
                        Codes = ["string"],
                        Decision = Review::ReputationDecision.Accept,
                        Insights = new()
                        {
                            AccountsActiveCount = 0,
                            AccountsClosedCount = 0,
                            AccountsClosedDates = ["2019-12-27"],
                            AccountsCount = 0,
                            AccountsFraudCount = 0,
                            AccountsFraudLabeledDates = ["2019-12-27"],
                            AccountsFraudLossTotalAmount = 0,
                            AchFraudTransactionsCount = 0,
                            AchFraudTransactionsDates = ["2019-12-27"],
                            AchFraudTransactionsTotalAmount = 0,
                            AchReturnedTransactionsCount = 0,
                            AchReturnedTransactionsDates = ["2019-12-27"],
                            AchReturnedTransactionsTotalAmount = 0,
                            ApplicationsApprovedCount = 0,
                            ApplicationsCount = 0,
                            ApplicationsDates = ["2019-12-27"],
                            ApplicationsDeclinedCount = 0,
                            ApplicationsFraudCount = 0,
                            CardDisputedTransactionsCount = 0,
                            CardDisputedTransactionsDates = ["2019-12-27"],
                            CardDisputedTransactionsTotalAmount = 0,
                            CardFraudTransactionsCount = 0,
                            CardFraudTransactionsDates = ["2019-12-27"],
                            CardFraudTransactionsTotalAmount = 0,
                            CardStoppedTransactionsCount = 0,
                            CardStoppedTransactionsDates = ["2019-12-27"],
                            UserActiveProfileCount = 0,
                            UserAddressCount = 0,
                            UserClosedProfileCount = 0,
                            UserDobCount = 0,
                            UserEmailCount = 0,
                            UserInstitutionCount = 0,
                            UserMobileCount = 0,
                        },
                        RiskScore = 0,
                    },
                    WatchList = new()
                    {
                        Codes = ["string"],
                        Decision = Review::WatchListDecision.Accept,
                        Matched = ["string"],
                        Matches =
                        [
                            new()
                            {
                                Correlation = Review::Correlation.LowConfidence,
                                ListName = "list_name",
                                MatchFields = ["string"],
                                Urls = ["string"],
                            },
                        ],
                    },
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = Review::ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::CustomerReviewV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Review::CustomerReviewV1
        {
            Data = new()
            {
                CustomerDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Email = "ron.swanson@pawnee.com",
                    Name = "Ron Swanson",
                    Phone = "+12128675309",
                    Status = Review::CustomerDetailsStatus.Pending,
                    Type = Review::Type.Individual,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Address = new()
                    {
                        Address1 = "123 Main St",
                        City = "Anytown",
                        State = "CA",
                        Zip = "12345",
                        Address2 = "Apt 1",
                    },
                    ComplianceProfile = new Review::IndividualComplianceProfile()
                    {
                        Dob = "2019-12-27",
                        Ssn = "***-**-****",
                    },
                    Config = new()
                    {
                        ProcessingMethod = Review::ProcessingMethod.Inline,
                        SandboxOutcome = Review::SandboxOutcome.Standard,
                    },
                    Device = new("192.168.1.1"),
                    ExternalID = "external_id",
                    Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                },
                IdentityDetails = new()
                {
                    Breakdown = new()
                    {
                        Address = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        BusinessEvaluation = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        BusinessIdentification = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        BusinessValidation = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Email = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Fraud = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Phone = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Synthetic = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                    },
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Decision = Review::Decision.Accept,
                    ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Kyc = new()
                    {
                        Validations = new()
                        {
                            Address = true,
                            City = true,
                            Dob = true,
                            Email = true,
                            FirstName = true,
                            LastName = true,
                            Phone = true,
                            Ssn = true,
                            State = true,
                            Zip = true,
                        },
                        Codes = ["string"],
                        Decision = Review::KycDecision.Accept,
                    },
                    Messages = new Dictionary<string, string>() { { "foo", "string" } },
                    NetworkAlerts = new()
                    {
                        Alerts = ["string"],
                        Codes = ["string"],
                        Decision = Review::NetworkAlertsDecision.Accept,
                    },
                    Reputation = new()
                    {
                        Codes = ["string"],
                        Decision = Review::ReputationDecision.Accept,
                        Insights = new()
                        {
                            AccountsActiveCount = 0,
                            AccountsClosedCount = 0,
                            AccountsClosedDates = ["2019-12-27"],
                            AccountsCount = 0,
                            AccountsFraudCount = 0,
                            AccountsFraudLabeledDates = ["2019-12-27"],
                            AccountsFraudLossTotalAmount = 0,
                            AchFraudTransactionsCount = 0,
                            AchFraudTransactionsDates = ["2019-12-27"],
                            AchFraudTransactionsTotalAmount = 0,
                            AchReturnedTransactionsCount = 0,
                            AchReturnedTransactionsDates = ["2019-12-27"],
                            AchReturnedTransactionsTotalAmount = 0,
                            ApplicationsApprovedCount = 0,
                            ApplicationsCount = 0,
                            ApplicationsDates = ["2019-12-27"],
                            ApplicationsDeclinedCount = 0,
                            ApplicationsFraudCount = 0,
                            CardDisputedTransactionsCount = 0,
                            CardDisputedTransactionsDates = ["2019-12-27"],
                            CardDisputedTransactionsTotalAmount = 0,
                            CardFraudTransactionsCount = 0,
                            CardFraudTransactionsDates = ["2019-12-27"],
                            CardFraudTransactionsTotalAmount = 0,
                            CardStoppedTransactionsCount = 0,
                            CardStoppedTransactionsDates = ["2019-12-27"],
                            UserActiveProfileCount = 0,
                            UserAddressCount = 0,
                            UserClosedProfileCount = 0,
                            UserDobCount = 0,
                            UserEmailCount = 0,
                            UserInstitutionCount = 0,
                            UserMobileCount = 0,
                        },
                        RiskScore = 0,
                    },
                    WatchList = new()
                    {
                        Codes = ["string"],
                        Decision = Review::WatchListDecision.Accept,
                        Matched = ["string"],
                        Matches =
                        [
                            new()
                            {
                                Correlation = Review::Correlation.LowConfidence,
                                ListName = "list_name",
                                MatchFields = ["string"],
                                Urls = ["string"],
                            },
                        ],
                    },
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = Review::ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::CustomerReviewV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        Review::Data expectedData = new()
        {
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = Review::CustomerDetailsStatus.Pending,
                Type = Review::Type.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile = new Review::IndividualComplianceProfile()
                {
                    Dob = "2019-12-27",
                    Ssn = "***-**-****",
                },
                Config = new()
                {
                    ProcessingMethod = Review::ProcessingMethod.Inline,
                    SandboxOutcome = Review::SandboxOutcome.Standard,
                },
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            },
            IdentityDetails = new()
            {
                Breakdown = new()
                {
                    Address = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessEvaluation = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessIdentification = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessValidation = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Email = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Fraud = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Phone = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Synthetic = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Decision = Review::Decision.Accept,
                ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Kyc = new()
                {
                    Validations = new()
                    {
                        Address = true,
                        City = true,
                        Dob = true,
                        Email = true,
                        FirstName = true,
                        LastName = true,
                        Phone = true,
                        Ssn = true,
                        State = true,
                        Zip = true,
                    },
                    Codes = ["string"],
                    Decision = Review::KycDecision.Accept,
                },
                Messages = new Dictionary<string, string>() { { "foo", "string" } },
                NetworkAlerts = new()
                {
                    Alerts = ["string"],
                    Codes = ["string"],
                    Decision = Review::NetworkAlertsDecision.Accept,
                },
                Reputation = new()
                {
                    Codes = ["string"],
                    Decision = Review::ReputationDecision.Accept,
                    Insights = new()
                    {
                        AccountsActiveCount = 0,
                        AccountsClosedCount = 0,
                        AccountsClosedDates = ["2019-12-27"],
                        AccountsCount = 0,
                        AccountsFraudCount = 0,
                        AccountsFraudLabeledDates = ["2019-12-27"],
                        AccountsFraudLossTotalAmount = 0,
                        AchFraudTransactionsCount = 0,
                        AchFraudTransactionsDates = ["2019-12-27"],
                        AchFraudTransactionsTotalAmount = 0,
                        AchReturnedTransactionsCount = 0,
                        AchReturnedTransactionsDates = ["2019-12-27"],
                        AchReturnedTransactionsTotalAmount = 0,
                        ApplicationsApprovedCount = 0,
                        ApplicationsCount = 0,
                        ApplicationsDates = ["2019-12-27"],
                        ApplicationsDeclinedCount = 0,
                        ApplicationsFraudCount = 0,
                        CardDisputedTransactionsCount = 0,
                        CardDisputedTransactionsDates = ["2019-12-27"],
                        CardDisputedTransactionsTotalAmount = 0,
                        CardFraudTransactionsCount = 0,
                        CardFraudTransactionsDates = ["2019-12-27"],
                        CardFraudTransactionsTotalAmount = 0,
                        CardStoppedTransactionsCount = 0,
                        CardStoppedTransactionsDates = ["2019-12-27"],
                        UserActiveProfileCount = 0,
                        UserAddressCount = 0,
                        UserClosedProfileCount = 0,
                        UserDobCount = 0,
                        UserEmailCount = 0,
                        UserInstitutionCount = 0,
                        UserMobileCount = 0,
                    },
                    RiskScore = 0,
                },
                WatchList = new()
                {
                    Codes = ["string"],
                    Decision = Review::WatchListDecision.Accept,
                    Matched = ["string"],
                    Matches =
                    [
                        new()
                        {
                            Correlation = Review::Correlation.LowConfidence,
                            ListName = "list_name",
                            MatchFields = ["string"],
                            Urls = ["string"],
                        },
                    ],
                },
            },
        };
        ResponseMetadata expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
        };
        ApiEnum<string, Review::ResponseType> expectedResponseType = Review::ResponseType.Object;

        Assert.Equal(expectedData, deserialized.Data);
        Assert.Equal(expectedMeta, deserialized.Meta);
        Assert.Equal(expectedResponseType, deserialized.ResponseType);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Review::CustomerReviewV1
        {
            Data = new()
            {
                CustomerDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Email = "ron.swanson@pawnee.com",
                    Name = "Ron Swanson",
                    Phone = "+12128675309",
                    Status = Review::CustomerDetailsStatus.Pending,
                    Type = Review::Type.Individual,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Address = new()
                    {
                        Address1 = "123 Main St",
                        City = "Anytown",
                        State = "CA",
                        Zip = "12345",
                        Address2 = "Apt 1",
                    },
                    ComplianceProfile = new Review::IndividualComplianceProfile()
                    {
                        Dob = "2019-12-27",
                        Ssn = "***-**-****",
                    },
                    Config = new()
                    {
                        ProcessingMethod = Review::ProcessingMethod.Inline,
                        SandboxOutcome = Review::SandboxOutcome.Standard,
                    },
                    Device = new("192.168.1.1"),
                    ExternalID = "external_id",
                    Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                },
                IdentityDetails = new()
                {
                    Breakdown = new()
                    {
                        Address = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        BusinessEvaluation = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        BusinessIdentification = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        BusinessValidation = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Email = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Fraud = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Phone = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Synthetic = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                    },
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Decision = Review::Decision.Accept,
                    ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Kyc = new()
                    {
                        Validations = new()
                        {
                            Address = true,
                            City = true,
                            Dob = true,
                            Email = true,
                            FirstName = true,
                            LastName = true,
                            Phone = true,
                            Ssn = true,
                            State = true,
                            Zip = true,
                        },
                        Codes = ["string"],
                        Decision = Review::KycDecision.Accept,
                    },
                    Messages = new Dictionary<string, string>() { { "foo", "string" } },
                    NetworkAlerts = new()
                    {
                        Alerts = ["string"],
                        Codes = ["string"],
                        Decision = Review::NetworkAlertsDecision.Accept,
                    },
                    Reputation = new()
                    {
                        Codes = ["string"],
                        Decision = Review::ReputationDecision.Accept,
                        Insights = new()
                        {
                            AccountsActiveCount = 0,
                            AccountsClosedCount = 0,
                            AccountsClosedDates = ["2019-12-27"],
                            AccountsCount = 0,
                            AccountsFraudCount = 0,
                            AccountsFraudLabeledDates = ["2019-12-27"],
                            AccountsFraudLossTotalAmount = 0,
                            AchFraudTransactionsCount = 0,
                            AchFraudTransactionsDates = ["2019-12-27"],
                            AchFraudTransactionsTotalAmount = 0,
                            AchReturnedTransactionsCount = 0,
                            AchReturnedTransactionsDates = ["2019-12-27"],
                            AchReturnedTransactionsTotalAmount = 0,
                            ApplicationsApprovedCount = 0,
                            ApplicationsCount = 0,
                            ApplicationsDates = ["2019-12-27"],
                            ApplicationsDeclinedCount = 0,
                            ApplicationsFraudCount = 0,
                            CardDisputedTransactionsCount = 0,
                            CardDisputedTransactionsDates = ["2019-12-27"],
                            CardDisputedTransactionsTotalAmount = 0,
                            CardFraudTransactionsCount = 0,
                            CardFraudTransactionsDates = ["2019-12-27"],
                            CardFraudTransactionsTotalAmount = 0,
                            CardStoppedTransactionsCount = 0,
                            CardStoppedTransactionsDates = ["2019-12-27"],
                            UserActiveProfileCount = 0,
                            UserAddressCount = 0,
                            UserClosedProfileCount = 0,
                            UserDobCount = 0,
                            UserEmailCount = 0,
                            UserInstitutionCount = 0,
                            UserMobileCount = 0,
                        },
                        RiskScore = 0,
                    },
                    WatchList = new()
                    {
                        Codes = ["string"],
                        Decision = Review::WatchListDecision.Accept,
                        Matched = ["string"],
                        Matches =
                        [
                            new()
                            {
                                Correlation = Review::Correlation.LowConfidence,
                                ListName = "list_name",
                                MatchFields = ["string"],
                                Urls = ["string"],
                            },
                        ],
                    },
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = Review::ResponseType.Object,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Review::CustomerReviewV1
        {
            Data = new()
            {
                CustomerDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Email = "ron.swanson@pawnee.com",
                    Name = "Ron Swanson",
                    Phone = "+12128675309",
                    Status = Review::CustomerDetailsStatus.Pending,
                    Type = Review::Type.Individual,
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Address = new()
                    {
                        Address1 = "123 Main St",
                        City = "Anytown",
                        State = "CA",
                        Zip = "12345",
                        Address2 = "Apt 1",
                    },
                    ComplianceProfile = new Review::IndividualComplianceProfile()
                    {
                        Dob = "2019-12-27",
                        Ssn = "***-**-****",
                    },
                    Config = new()
                    {
                        ProcessingMethod = Review::ProcessingMethod.Inline,
                        SandboxOutcome = Review::SandboxOutcome.Standard,
                    },
                    Device = new("192.168.1.1"),
                    ExternalID = "external_id",
                    Metadata = new Dictionary<string, string>() { { "foo", "string" } },
                },
                IdentityDetails = new()
                {
                    Breakdown = new()
                    {
                        Address = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        BusinessEvaluation = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        BusinessIdentification = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        BusinessValidation = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Email = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Fraud = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Phone = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                        Synthetic = new()
                        {
                            Codes = ["string"],
                            Correlation =
                                Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                            CorrelationScore = 0,
                            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                            RiskScore = 0,
                        },
                    },
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Decision = Review::Decision.Accept,
                    ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Kyc = new()
                    {
                        Validations = new()
                        {
                            Address = true,
                            City = true,
                            Dob = true,
                            Email = true,
                            FirstName = true,
                            LastName = true,
                            Phone = true,
                            Ssn = true,
                            State = true,
                            Zip = true,
                        },
                        Codes = ["string"],
                        Decision = Review::KycDecision.Accept,
                    },
                    Messages = new Dictionary<string, string>() { { "foo", "string" } },
                    NetworkAlerts = new()
                    {
                        Alerts = ["string"],
                        Codes = ["string"],
                        Decision = Review::NetworkAlertsDecision.Accept,
                    },
                    Reputation = new()
                    {
                        Codes = ["string"],
                        Decision = Review::ReputationDecision.Accept,
                        Insights = new()
                        {
                            AccountsActiveCount = 0,
                            AccountsClosedCount = 0,
                            AccountsClosedDates = ["2019-12-27"],
                            AccountsCount = 0,
                            AccountsFraudCount = 0,
                            AccountsFraudLabeledDates = ["2019-12-27"],
                            AccountsFraudLossTotalAmount = 0,
                            AchFraudTransactionsCount = 0,
                            AchFraudTransactionsDates = ["2019-12-27"],
                            AchFraudTransactionsTotalAmount = 0,
                            AchReturnedTransactionsCount = 0,
                            AchReturnedTransactionsDates = ["2019-12-27"],
                            AchReturnedTransactionsTotalAmount = 0,
                            ApplicationsApprovedCount = 0,
                            ApplicationsCount = 0,
                            ApplicationsDates = ["2019-12-27"],
                            ApplicationsDeclinedCount = 0,
                            ApplicationsFraudCount = 0,
                            CardDisputedTransactionsCount = 0,
                            CardDisputedTransactionsDates = ["2019-12-27"],
                            CardDisputedTransactionsTotalAmount = 0,
                            CardFraudTransactionsCount = 0,
                            CardFraudTransactionsDates = ["2019-12-27"],
                            CardFraudTransactionsTotalAmount = 0,
                            CardStoppedTransactionsCount = 0,
                            CardStoppedTransactionsDates = ["2019-12-27"],
                            UserActiveProfileCount = 0,
                            UserAddressCount = 0,
                            UserClosedProfileCount = 0,
                            UserDobCount = 0,
                            UserEmailCount = 0,
                            UserInstitutionCount = 0,
                            UserMobileCount = 0,
                        },
                        RiskScore = 0,
                    },
                    WatchList = new()
                    {
                        Codes = ["string"],
                        Decision = Review::WatchListDecision.Accept,
                        Matched = ["string"],
                        Matches =
                        [
                            new()
                            {
                                Correlation = Review::Correlation.LowConfidence,
                                ListName = "list_name",
                                MatchFields = ["string"],
                                Urls = ["string"],
                            },
                        ],
                    },
                },
            },
            Meta = new()
            {
                ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            },
            ResponseType = Review::ResponseType.Object,
        };

        Review::CustomerReviewV1 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Review::Data
        {
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = Review::CustomerDetailsStatus.Pending,
                Type = Review::Type.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile = new Review::IndividualComplianceProfile()
                {
                    Dob = "2019-12-27",
                    Ssn = "***-**-****",
                },
                Config = new()
                {
                    ProcessingMethod = Review::ProcessingMethod.Inline,
                    SandboxOutcome = Review::SandboxOutcome.Standard,
                },
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            },
            IdentityDetails = new()
            {
                Breakdown = new()
                {
                    Address = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessEvaluation = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessIdentification = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessValidation = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Email = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Fraud = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Phone = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Synthetic = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Decision = Review::Decision.Accept,
                ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Kyc = new()
                {
                    Validations = new()
                    {
                        Address = true,
                        City = true,
                        Dob = true,
                        Email = true,
                        FirstName = true,
                        LastName = true,
                        Phone = true,
                        Ssn = true,
                        State = true,
                        Zip = true,
                    },
                    Codes = ["string"],
                    Decision = Review::KycDecision.Accept,
                },
                Messages = new Dictionary<string, string>() { { "foo", "string" } },
                NetworkAlerts = new()
                {
                    Alerts = ["string"],
                    Codes = ["string"],
                    Decision = Review::NetworkAlertsDecision.Accept,
                },
                Reputation = new()
                {
                    Codes = ["string"],
                    Decision = Review::ReputationDecision.Accept,
                    Insights = new()
                    {
                        AccountsActiveCount = 0,
                        AccountsClosedCount = 0,
                        AccountsClosedDates = ["2019-12-27"],
                        AccountsCount = 0,
                        AccountsFraudCount = 0,
                        AccountsFraudLabeledDates = ["2019-12-27"],
                        AccountsFraudLossTotalAmount = 0,
                        AchFraudTransactionsCount = 0,
                        AchFraudTransactionsDates = ["2019-12-27"],
                        AchFraudTransactionsTotalAmount = 0,
                        AchReturnedTransactionsCount = 0,
                        AchReturnedTransactionsDates = ["2019-12-27"],
                        AchReturnedTransactionsTotalAmount = 0,
                        ApplicationsApprovedCount = 0,
                        ApplicationsCount = 0,
                        ApplicationsDates = ["2019-12-27"],
                        ApplicationsDeclinedCount = 0,
                        ApplicationsFraudCount = 0,
                        CardDisputedTransactionsCount = 0,
                        CardDisputedTransactionsDates = ["2019-12-27"],
                        CardDisputedTransactionsTotalAmount = 0,
                        CardFraudTransactionsCount = 0,
                        CardFraudTransactionsDates = ["2019-12-27"],
                        CardFraudTransactionsTotalAmount = 0,
                        CardStoppedTransactionsCount = 0,
                        CardStoppedTransactionsDates = ["2019-12-27"],
                        UserActiveProfileCount = 0,
                        UserAddressCount = 0,
                        UserClosedProfileCount = 0,
                        UserDobCount = 0,
                        UserEmailCount = 0,
                        UserInstitutionCount = 0,
                        UserMobileCount = 0,
                    },
                    RiskScore = 0,
                },
                WatchList = new()
                {
                    Codes = ["string"],
                    Decision = Review::WatchListDecision.Accept,
                    Matched = ["string"],
                    Matches =
                    [
                        new()
                        {
                            Correlation = Review::Correlation.LowConfidence,
                            ListName = "list_name",
                            MatchFields = ["string"],
                            Urls = ["string"],
                        },
                    ],
                },
            },
        };

        Review::CustomerDetails expectedCustomerDetails = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = Review::CustomerDetailsStatus.Pending,
            Type = Review::Type.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new Review::IndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            Config = new()
            {
                ProcessingMethod = Review::ProcessingMethod.Inline,
                SandboxOutcome = Review::SandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };
        Review::IdentityDetails expectedIdentityDetails = new()
        {
            Breakdown = new()
            {
                Address = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessEvaluation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessIdentification = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessValidation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Email = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Fraud = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Phone = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Synthetic = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = Review::Decision.Accept,
            ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Kyc = new()
            {
                Validations = new()
                {
                    Address = true,
                    City = true,
                    Dob = true,
                    Email = true,
                    FirstName = true,
                    LastName = true,
                    Phone = true,
                    Ssn = true,
                    State = true,
                    Zip = true,
                },
                Codes = ["string"],
                Decision = Review::KycDecision.Accept,
            },
            Messages = new Dictionary<string, string>() { { "foo", "string" } },
            NetworkAlerts = new()
            {
                Alerts = ["string"],
                Codes = ["string"],
                Decision = Review::NetworkAlertsDecision.Accept,
            },
            Reputation = new()
            {
                Codes = ["string"],
                Decision = Review::ReputationDecision.Accept,
                Insights = new()
                {
                    AccountsActiveCount = 0,
                    AccountsClosedCount = 0,
                    AccountsClosedDates = ["2019-12-27"],
                    AccountsCount = 0,
                    AccountsFraudCount = 0,
                    AccountsFraudLabeledDates = ["2019-12-27"],
                    AccountsFraudLossTotalAmount = 0,
                    AchFraudTransactionsCount = 0,
                    AchFraudTransactionsDates = ["2019-12-27"],
                    AchFraudTransactionsTotalAmount = 0,
                    AchReturnedTransactionsCount = 0,
                    AchReturnedTransactionsDates = ["2019-12-27"],
                    AchReturnedTransactionsTotalAmount = 0,
                    ApplicationsApprovedCount = 0,
                    ApplicationsCount = 0,
                    ApplicationsDates = ["2019-12-27"],
                    ApplicationsDeclinedCount = 0,
                    ApplicationsFraudCount = 0,
                    CardDisputedTransactionsCount = 0,
                    CardDisputedTransactionsDates = ["2019-12-27"],
                    CardDisputedTransactionsTotalAmount = 0,
                    CardFraudTransactionsCount = 0,
                    CardFraudTransactionsDates = ["2019-12-27"],
                    CardFraudTransactionsTotalAmount = 0,
                    CardStoppedTransactionsCount = 0,
                    CardStoppedTransactionsDates = ["2019-12-27"],
                    UserActiveProfileCount = 0,
                    UserAddressCount = 0,
                    UserClosedProfileCount = 0,
                    UserDobCount = 0,
                    UserEmailCount = 0,
                    UserInstitutionCount = 0,
                    UserMobileCount = 0,
                },
                RiskScore = 0,
            },
            WatchList = new()
            {
                Codes = ["string"],
                Decision = Review::WatchListDecision.Accept,
                Matched = ["string"],
                Matches =
                [
                    new()
                    {
                        Correlation = Review::Correlation.LowConfidence,
                        ListName = "list_name",
                        MatchFields = ["string"],
                        Urls = ["string"],
                    },
                ],
            },
        };

        Assert.Equal(expectedCustomerDetails, model.CustomerDetails);
        Assert.Equal(expectedIdentityDetails, model.IdentityDetails);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Review::Data
        {
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = Review::CustomerDetailsStatus.Pending,
                Type = Review::Type.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile = new Review::IndividualComplianceProfile()
                {
                    Dob = "2019-12-27",
                    Ssn = "***-**-****",
                },
                Config = new()
                {
                    ProcessingMethod = Review::ProcessingMethod.Inline,
                    SandboxOutcome = Review::SandboxOutcome.Standard,
                },
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            },
            IdentityDetails = new()
            {
                Breakdown = new()
                {
                    Address = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessEvaluation = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessIdentification = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessValidation = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Email = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Fraud = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Phone = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Synthetic = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Decision = Review::Decision.Accept,
                ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Kyc = new()
                {
                    Validations = new()
                    {
                        Address = true,
                        City = true,
                        Dob = true,
                        Email = true,
                        FirstName = true,
                        LastName = true,
                        Phone = true,
                        Ssn = true,
                        State = true,
                        Zip = true,
                    },
                    Codes = ["string"],
                    Decision = Review::KycDecision.Accept,
                },
                Messages = new Dictionary<string, string>() { { "foo", "string" } },
                NetworkAlerts = new()
                {
                    Alerts = ["string"],
                    Codes = ["string"],
                    Decision = Review::NetworkAlertsDecision.Accept,
                },
                Reputation = new()
                {
                    Codes = ["string"],
                    Decision = Review::ReputationDecision.Accept,
                    Insights = new()
                    {
                        AccountsActiveCount = 0,
                        AccountsClosedCount = 0,
                        AccountsClosedDates = ["2019-12-27"],
                        AccountsCount = 0,
                        AccountsFraudCount = 0,
                        AccountsFraudLabeledDates = ["2019-12-27"],
                        AccountsFraudLossTotalAmount = 0,
                        AchFraudTransactionsCount = 0,
                        AchFraudTransactionsDates = ["2019-12-27"],
                        AchFraudTransactionsTotalAmount = 0,
                        AchReturnedTransactionsCount = 0,
                        AchReturnedTransactionsDates = ["2019-12-27"],
                        AchReturnedTransactionsTotalAmount = 0,
                        ApplicationsApprovedCount = 0,
                        ApplicationsCount = 0,
                        ApplicationsDates = ["2019-12-27"],
                        ApplicationsDeclinedCount = 0,
                        ApplicationsFraudCount = 0,
                        CardDisputedTransactionsCount = 0,
                        CardDisputedTransactionsDates = ["2019-12-27"],
                        CardDisputedTransactionsTotalAmount = 0,
                        CardFraudTransactionsCount = 0,
                        CardFraudTransactionsDates = ["2019-12-27"],
                        CardFraudTransactionsTotalAmount = 0,
                        CardStoppedTransactionsCount = 0,
                        CardStoppedTransactionsDates = ["2019-12-27"],
                        UserActiveProfileCount = 0,
                        UserAddressCount = 0,
                        UserClosedProfileCount = 0,
                        UserDobCount = 0,
                        UserEmailCount = 0,
                        UserInstitutionCount = 0,
                        UserMobileCount = 0,
                    },
                    RiskScore = 0,
                },
                WatchList = new()
                {
                    Codes = ["string"],
                    Decision = Review::WatchListDecision.Accept,
                    Matched = ["string"],
                    Matches =
                    [
                        new()
                        {
                            Correlation = Review::Correlation.LowConfidence,
                            ListName = "list_name",
                            MatchFields = ["string"],
                            Urls = ["string"],
                        },
                    ],
                },
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Data>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Review::Data
        {
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = Review::CustomerDetailsStatus.Pending,
                Type = Review::Type.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile = new Review::IndividualComplianceProfile()
                {
                    Dob = "2019-12-27",
                    Ssn = "***-**-****",
                },
                Config = new()
                {
                    ProcessingMethod = Review::ProcessingMethod.Inline,
                    SandboxOutcome = Review::SandboxOutcome.Standard,
                },
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            },
            IdentityDetails = new()
            {
                Breakdown = new()
                {
                    Address = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessEvaluation = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessIdentification = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessValidation = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Email = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Fraud = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Phone = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Synthetic = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Decision = Review::Decision.Accept,
                ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Kyc = new()
                {
                    Validations = new()
                    {
                        Address = true,
                        City = true,
                        Dob = true,
                        Email = true,
                        FirstName = true,
                        LastName = true,
                        Phone = true,
                        Ssn = true,
                        State = true,
                        Zip = true,
                    },
                    Codes = ["string"],
                    Decision = Review::KycDecision.Accept,
                },
                Messages = new Dictionary<string, string>() { { "foo", "string" } },
                NetworkAlerts = new()
                {
                    Alerts = ["string"],
                    Codes = ["string"],
                    Decision = Review::NetworkAlertsDecision.Accept,
                },
                Reputation = new()
                {
                    Codes = ["string"],
                    Decision = Review::ReputationDecision.Accept,
                    Insights = new()
                    {
                        AccountsActiveCount = 0,
                        AccountsClosedCount = 0,
                        AccountsClosedDates = ["2019-12-27"],
                        AccountsCount = 0,
                        AccountsFraudCount = 0,
                        AccountsFraudLabeledDates = ["2019-12-27"],
                        AccountsFraudLossTotalAmount = 0,
                        AchFraudTransactionsCount = 0,
                        AchFraudTransactionsDates = ["2019-12-27"],
                        AchFraudTransactionsTotalAmount = 0,
                        AchReturnedTransactionsCount = 0,
                        AchReturnedTransactionsDates = ["2019-12-27"],
                        AchReturnedTransactionsTotalAmount = 0,
                        ApplicationsApprovedCount = 0,
                        ApplicationsCount = 0,
                        ApplicationsDates = ["2019-12-27"],
                        ApplicationsDeclinedCount = 0,
                        ApplicationsFraudCount = 0,
                        CardDisputedTransactionsCount = 0,
                        CardDisputedTransactionsDates = ["2019-12-27"],
                        CardDisputedTransactionsTotalAmount = 0,
                        CardFraudTransactionsCount = 0,
                        CardFraudTransactionsDates = ["2019-12-27"],
                        CardFraudTransactionsTotalAmount = 0,
                        CardStoppedTransactionsCount = 0,
                        CardStoppedTransactionsDates = ["2019-12-27"],
                        UserActiveProfileCount = 0,
                        UserAddressCount = 0,
                        UserClosedProfileCount = 0,
                        UserDobCount = 0,
                        UserEmailCount = 0,
                        UserInstitutionCount = 0,
                        UserMobileCount = 0,
                    },
                    RiskScore = 0,
                },
                WatchList = new()
                {
                    Codes = ["string"],
                    Decision = Review::WatchListDecision.Accept,
                    Matched = ["string"],
                    Matches =
                    [
                        new()
                        {
                            Correlation = Review::Correlation.LowConfidence,
                            ListName = "list_name",
                            MatchFields = ["string"],
                            Urls = ["string"],
                        },
                    ],
                },
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Data>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        Review::CustomerDetails expectedCustomerDetails = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = Review::CustomerDetailsStatus.Pending,
            Type = Review::Type.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new Review::IndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            Config = new()
            {
                ProcessingMethod = Review::ProcessingMethod.Inline,
                SandboxOutcome = Review::SandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };
        Review::IdentityDetails expectedIdentityDetails = new()
        {
            Breakdown = new()
            {
                Address = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessEvaluation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessIdentification = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessValidation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Email = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Fraud = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Phone = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Synthetic = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = Review::Decision.Accept,
            ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Kyc = new()
            {
                Validations = new()
                {
                    Address = true,
                    City = true,
                    Dob = true,
                    Email = true,
                    FirstName = true,
                    LastName = true,
                    Phone = true,
                    Ssn = true,
                    State = true,
                    Zip = true,
                },
                Codes = ["string"],
                Decision = Review::KycDecision.Accept,
            },
            Messages = new Dictionary<string, string>() { { "foo", "string" } },
            NetworkAlerts = new()
            {
                Alerts = ["string"],
                Codes = ["string"],
                Decision = Review::NetworkAlertsDecision.Accept,
            },
            Reputation = new()
            {
                Codes = ["string"],
                Decision = Review::ReputationDecision.Accept,
                Insights = new()
                {
                    AccountsActiveCount = 0,
                    AccountsClosedCount = 0,
                    AccountsClosedDates = ["2019-12-27"],
                    AccountsCount = 0,
                    AccountsFraudCount = 0,
                    AccountsFraudLabeledDates = ["2019-12-27"],
                    AccountsFraudLossTotalAmount = 0,
                    AchFraudTransactionsCount = 0,
                    AchFraudTransactionsDates = ["2019-12-27"],
                    AchFraudTransactionsTotalAmount = 0,
                    AchReturnedTransactionsCount = 0,
                    AchReturnedTransactionsDates = ["2019-12-27"],
                    AchReturnedTransactionsTotalAmount = 0,
                    ApplicationsApprovedCount = 0,
                    ApplicationsCount = 0,
                    ApplicationsDates = ["2019-12-27"],
                    ApplicationsDeclinedCount = 0,
                    ApplicationsFraudCount = 0,
                    CardDisputedTransactionsCount = 0,
                    CardDisputedTransactionsDates = ["2019-12-27"],
                    CardDisputedTransactionsTotalAmount = 0,
                    CardFraudTransactionsCount = 0,
                    CardFraudTransactionsDates = ["2019-12-27"],
                    CardFraudTransactionsTotalAmount = 0,
                    CardStoppedTransactionsCount = 0,
                    CardStoppedTransactionsDates = ["2019-12-27"],
                    UserActiveProfileCount = 0,
                    UserAddressCount = 0,
                    UserClosedProfileCount = 0,
                    UserDobCount = 0,
                    UserEmailCount = 0,
                    UserInstitutionCount = 0,
                    UserMobileCount = 0,
                },
                RiskScore = 0,
            },
            WatchList = new()
            {
                Codes = ["string"],
                Decision = Review::WatchListDecision.Accept,
                Matched = ["string"],
                Matches =
                [
                    new()
                    {
                        Correlation = Review::Correlation.LowConfidence,
                        ListName = "list_name",
                        MatchFields = ["string"],
                        Urls = ["string"],
                    },
                ],
            },
        };

        Assert.Equal(expectedCustomerDetails, deserialized.CustomerDetails);
        Assert.Equal(expectedIdentityDetails, deserialized.IdentityDetails);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Review::Data
        {
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = Review::CustomerDetailsStatus.Pending,
                Type = Review::Type.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile = new Review::IndividualComplianceProfile()
                {
                    Dob = "2019-12-27",
                    Ssn = "***-**-****",
                },
                Config = new()
                {
                    ProcessingMethod = Review::ProcessingMethod.Inline,
                    SandboxOutcome = Review::SandboxOutcome.Standard,
                },
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            },
            IdentityDetails = new()
            {
                Breakdown = new()
                {
                    Address = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessEvaluation = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessIdentification = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessValidation = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Email = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Fraud = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Phone = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Synthetic = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Decision = Review::Decision.Accept,
                ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Kyc = new()
                {
                    Validations = new()
                    {
                        Address = true,
                        City = true,
                        Dob = true,
                        Email = true,
                        FirstName = true,
                        LastName = true,
                        Phone = true,
                        Ssn = true,
                        State = true,
                        Zip = true,
                    },
                    Codes = ["string"],
                    Decision = Review::KycDecision.Accept,
                },
                Messages = new Dictionary<string, string>() { { "foo", "string" } },
                NetworkAlerts = new()
                {
                    Alerts = ["string"],
                    Codes = ["string"],
                    Decision = Review::NetworkAlertsDecision.Accept,
                },
                Reputation = new()
                {
                    Codes = ["string"],
                    Decision = Review::ReputationDecision.Accept,
                    Insights = new()
                    {
                        AccountsActiveCount = 0,
                        AccountsClosedCount = 0,
                        AccountsClosedDates = ["2019-12-27"],
                        AccountsCount = 0,
                        AccountsFraudCount = 0,
                        AccountsFraudLabeledDates = ["2019-12-27"],
                        AccountsFraudLossTotalAmount = 0,
                        AchFraudTransactionsCount = 0,
                        AchFraudTransactionsDates = ["2019-12-27"],
                        AchFraudTransactionsTotalAmount = 0,
                        AchReturnedTransactionsCount = 0,
                        AchReturnedTransactionsDates = ["2019-12-27"],
                        AchReturnedTransactionsTotalAmount = 0,
                        ApplicationsApprovedCount = 0,
                        ApplicationsCount = 0,
                        ApplicationsDates = ["2019-12-27"],
                        ApplicationsDeclinedCount = 0,
                        ApplicationsFraudCount = 0,
                        CardDisputedTransactionsCount = 0,
                        CardDisputedTransactionsDates = ["2019-12-27"],
                        CardDisputedTransactionsTotalAmount = 0,
                        CardFraudTransactionsCount = 0,
                        CardFraudTransactionsDates = ["2019-12-27"],
                        CardFraudTransactionsTotalAmount = 0,
                        CardStoppedTransactionsCount = 0,
                        CardStoppedTransactionsDates = ["2019-12-27"],
                        UserActiveProfileCount = 0,
                        UserAddressCount = 0,
                        UserClosedProfileCount = 0,
                        UserDobCount = 0,
                        UserEmailCount = 0,
                        UserInstitutionCount = 0,
                        UserMobileCount = 0,
                    },
                    RiskScore = 0,
                },
                WatchList = new()
                {
                    Codes = ["string"],
                    Decision = Review::WatchListDecision.Accept,
                    Matched = ["string"],
                    Matches =
                    [
                        new()
                        {
                            Correlation = Review::Correlation.LowConfidence,
                            ListName = "list_name",
                            MatchFields = ["string"],
                            Urls = ["string"],
                        },
                    ],
                },
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::Data
        {
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = Review::CustomerDetailsStatus.Pending,
                Type = Review::Type.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile = new Review::IndividualComplianceProfile()
                {
                    Dob = "2019-12-27",
                    Ssn = "***-**-****",
                },
                Config = new()
                {
                    ProcessingMethod = Review::ProcessingMethod.Inline,
                    SandboxOutcome = Review::SandboxOutcome.Standard,
                },
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            },
        };

        Assert.Null(model.IdentityDetails);
        Assert.False(model.RawData.ContainsKey("identity_details"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::Data
        {
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = Review::CustomerDetailsStatus.Pending,
                Type = Review::Type.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile = new Review::IndividualComplianceProfile()
                {
                    Dob = "2019-12-27",
                    Ssn = "***-**-****",
                },
                Config = new()
                {
                    ProcessingMethod = Review::ProcessingMethod.Inline,
                    SandboxOutcome = Review::SandboxOutcome.Standard,
                },
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Review::Data
        {
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = Review::CustomerDetailsStatus.Pending,
                Type = Review::Type.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile = new Review::IndividualComplianceProfile()
                {
                    Dob = "2019-12-27",
                    Ssn = "***-**-****",
                },
                Config = new()
                {
                    ProcessingMethod = Review::ProcessingMethod.Inline,
                    SandboxOutcome = Review::SandboxOutcome.Standard,
                },
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            },

            // Null should be interpreted as omitted for these properties
            IdentityDetails = null,
        };

        Assert.Null(model.IdentityDetails);
        Assert.False(model.RawData.ContainsKey("identity_details"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::Data
        {
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = Review::CustomerDetailsStatus.Pending,
                Type = Review::Type.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile = new Review::IndividualComplianceProfile()
                {
                    Dob = "2019-12-27",
                    Ssn = "***-**-****",
                },
                Config = new()
                {
                    ProcessingMethod = Review::ProcessingMethod.Inline,
                    SandboxOutcome = Review::SandboxOutcome.Standard,
                },
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            },

            // Null should be interpreted as omitted for these properties
            IdentityDetails = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Review::Data
        {
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Email = "ron.swanson@pawnee.com",
                Name = "Ron Swanson",
                Phone = "+12128675309",
                Status = Review::CustomerDetailsStatus.Pending,
                Type = Review::Type.Individual,
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Address = new()
                {
                    Address1 = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    Zip = "12345",
                    Address2 = "Apt 1",
                },
                ComplianceProfile = new Review::IndividualComplianceProfile()
                {
                    Dob = "2019-12-27",
                    Ssn = "***-**-****",
                },
                Config = new()
                {
                    ProcessingMethod = Review::ProcessingMethod.Inline,
                    SandboxOutcome = Review::SandboxOutcome.Standard,
                },
                Device = new("192.168.1.1"),
                ExternalID = "external_id",
                Metadata = new Dictionary<string, string>() { { "foo", "string" } },
            },
            IdentityDetails = new()
            {
                Breakdown = new()
                {
                    Address = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessEvaluation = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessIdentification = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    BusinessValidation = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Email = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Fraud = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Phone = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                    Synthetic = new()
                    {
                        Codes = ["string"],
                        Correlation =
                            Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                        CorrelationScore = 0,
                        Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                        RiskScore = 0,
                    },
                },
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Decision = Review::Decision.Accept,
                ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Kyc = new()
                {
                    Validations = new()
                    {
                        Address = true,
                        City = true,
                        Dob = true,
                        Email = true,
                        FirstName = true,
                        LastName = true,
                        Phone = true,
                        Ssn = true,
                        State = true,
                        Zip = true,
                    },
                    Codes = ["string"],
                    Decision = Review::KycDecision.Accept,
                },
                Messages = new Dictionary<string, string>() { { "foo", "string" } },
                NetworkAlerts = new()
                {
                    Alerts = ["string"],
                    Codes = ["string"],
                    Decision = Review::NetworkAlertsDecision.Accept,
                },
                Reputation = new()
                {
                    Codes = ["string"],
                    Decision = Review::ReputationDecision.Accept,
                    Insights = new()
                    {
                        AccountsActiveCount = 0,
                        AccountsClosedCount = 0,
                        AccountsClosedDates = ["2019-12-27"],
                        AccountsCount = 0,
                        AccountsFraudCount = 0,
                        AccountsFraudLabeledDates = ["2019-12-27"],
                        AccountsFraudLossTotalAmount = 0,
                        AchFraudTransactionsCount = 0,
                        AchFraudTransactionsDates = ["2019-12-27"],
                        AchFraudTransactionsTotalAmount = 0,
                        AchReturnedTransactionsCount = 0,
                        AchReturnedTransactionsDates = ["2019-12-27"],
                        AchReturnedTransactionsTotalAmount = 0,
                        ApplicationsApprovedCount = 0,
                        ApplicationsCount = 0,
                        ApplicationsDates = ["2019-12-27"],
                        ApplicationsDeclinedCount = 0,
                        ApplicationsFraudCount = 0,
                        CardDisputedTransactionsCount = 0,
                        CardDisputedTransactionsDates = ["2019-12-27"],
                        CardDisputedTransactionsTotalAmount = 0,
                        CardFraudTransactionsCount = 0,
                        CardFraudTransactionsDates = ["2019-12-27"],
                        CardFraudTransactionsTotalAmount = 0,
                        CardStoppedTransactionsCount = 0,
                        CardStoppedTransactionsDates = ["2019-12-27"],
                        UserActiveProfileCount = 0,
                        UserAddressCount = 0,
                        UserClosedProfileCount = 0,
                        UserDobCount = 0,
                        UserEmailCount = 0,
                        UserInstitutionCount = 0,
                        UserMobileCount = 0,
                    },
                    RiskScore = 0,
                },
                WatchList = new()
                {
                    Codes = ["string"],
                    Decision = Review::WatchListDecision.Accept,
                    Matched = ["string"],
                    Matches =
                    [
                        new()
                        {
                            Correlation = Review::Correlation.LowConfidence,
                            ListName = "list_name",
                            MatchFields = ["string"],
                            Urls = ["string"],
                        },
                    ],
                },
            },
        };

        Review::Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class CustomerDetailsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Review::CustomerDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = Review::CustomerDetailsStatus.Pending,
            Type = Review::Type.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new Review::IndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            Config = new()
            {
                ProcessingMethod = Review::ProcessingMethod.Inline,
                SandboxOutcome = Review::SandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedEmail = "ron.swanson@pawnee.com";
        string expectedName = "Ron Swanson";
        string expectedPhone = "+12128675309";
        ApiEnum<string, Review::CustomerDetailsStatus> expectedStatus =
            Review::CustomerDetailsStatus.Pending;
        ApiEnum<string, Review::Type> expectedType = Review::Type.Individual;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        CustomerAddressV1 expectedAddress = new()
        {
            Address1 = "123 Main St",
            City = "Anytown",
            State = "CA",
            Zip = "12345",
            Address2 = "Apt 1",
        };
        Review::ComplianceProfile expectedComplianceProfile =
            new Review::IndividualComplianceProfile() { Dob = "2019-12-27", Ssn = "***-**-****" };
        Review::Config expectedConfig = new()
        {
            ProcessingMethod = Review::ProcessingMethod.Inline,
            SandboxOutcome = Review::SandboxOutcome.Standard,
        };
        Review::Device expectedDevice = new("192.168.1.1");
        string expectedExternalID = "external_id";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedEmail, model.Email);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedPhone, model.Phone);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
        Assert.Equal(expectedAddress, model.Address);
        Assert.Equal(expectedComplianceProfile, model.ComplianceProfile);
        Assert.Equal(expectedConfig, model.Config);
        Assert.Equal(expectedDevice, model.Device);
        Assert.Equal(expectedExternalID, model.ExternalID);
        Assert.NotNull(model.Metadata);
        Assert.Equal(expectedMetadata.Count, model.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(model.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Metadata[item.Key]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Review::CustomerDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = Review::CustomerDetailsStatus.Pending,
            Type = Review::Type.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new Review::IndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            Config = new()
            {
                ProcessingMethod = Review::ProcessingMethod.Inline,
                SandboxOutcome = Review::SandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::CustomerDetails>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Review::CustomerDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = Review::CustomerDetailsStatus.Pending,
            Type = Review::Type.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new Review::IndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            Config = new()
            {
                ProcessingMethod = Review::ProcessingMethod.Inline,
                SandboxOutcome = Review::SandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::CustomerDetails>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedEmail = "ron.swanson@pawnee.com";
        string expectedName = "Ron Swanson";
        string expectedPhone = "+12128675309";
        ApiEnum<string, Review::CustomerDetailsStatus> expectedStatus =
            Review::CustomerDetailsStatus.Pending;
        ApiEnum<string, Review::Type> expectedType = Review::Type.Individual;
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        CustomerAddressV1 expectedAddress = new()
        {
            Address1 = "123 Main St",
            City = "Anytown",
            State = "CA",
            Zip = "12345",
            Address2 = "Apt 1",
        };
        Review::ComplianceProfile expectedComplianceProfile =
            new Review::IndividualComplianceProfile() { Dob = "2019-12-27", Ssn = "***-**-****" };
        Review::Config expectedConfig = new()
        {
            ProcessingMethod = Review::ProcessingMethod.Inline,
            SandboxOutcome = Review::SandboxOutcome.Standard,
        };
        Review::Device expectedDevice = new("192.168.1.1");
        string expectedExternalID = "external_id";
        Dictionary<string, string> expectedMetadata = new() { { "foo", "string" } };

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedEmail, deserialized.Email);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedPhone, deserialized.Phone);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
        Assert.Equal(expectedAddress, deserialized.Address);
        Assert.Equal(expectedComplianceProfile, deserialized.ComplianceProfile);
        Assert.Equal(expectedConfig, deserialized.Config);
        Assert.Equal(expectedDevice, deserialized.Device);
        Assert.Equal(expectedExternalID, deserialized.ExternalID);
        Assert.NotNull(deserialized.Metadata);
        Assert.Equal(expectedMetadata.Count, deserialized.Metadata.Count);
        foreach (var item in expectedMetadata)
        {
            Assert.True(deserialized.Metadata.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Metadata[item.Key]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Review::CustomerDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = Review::CustomerDetailsStatus.Pending,
            Type = Review::Type.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new Review::IndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            Config = new()
            {
                ProcessingMethod = Review::ProcessingMethod.Inline,
                SandboxOutcome = Review::SandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::CustomerDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = Review::CustomerDetailsStatus.Pending,
            Type = Review::Type.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new Review::IndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        Assert.Null(model.Config);
        Assert.False(model.RawData.ContainsKey("config"));
        Assert.Null(model.Device);
        Assert.False(model.RawData.ContainsKey("device"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::CustomerDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = Review::CustomerDetailsStatus.Pending,
            Type = Review::Type.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new Review::IndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Review::CustomerDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = Review::CustomerDetailsStatus.Pending,
            Type = Review::Type.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new Review::IndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },

            // Null should be interpreted as omitted for these properties
            Config = null,
            Device = null,
        };

        Assert.Null(model.Config);
        Assert.False(model.RawData.ContainsKey("config"));
        Assert.Null(model.Device);
        Assert.False(model.RawData.ContainsKey("device"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::CustomerDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = Review::CustomerDetailsStatus.Pending,
            Type = Review::Type.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new Review::IndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },

            // Null should be interpreted as omitted for these properties
            Config = null,
            Device = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::CustomerDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = Review::CustomerDetailsStatus.Pending,
            Type = Review::Type.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Config = new()
            {
                ProcessingMethod = Review::ProcessingMethod.Inline,
                SandboxOutcome = Review::SandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
        };

        Assert.Null(model.Address);
        Assert.False(model.RawData.ContainsKey("address"));
        Assert.Null(model.ComplianceProfile);
        Assert.False(model.RawData.ContainsKey("compliance_profile"));
        Assert.Null(model.ExternalID);
        Assert.False(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.Metadata);
        Assert.False(model.RawData.ContainsKey("metadata"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::CustomerDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = Review::CustomerDetailsStatus.Pending,
            Type = Review::Type.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Config = new()
            {
                ProcessingMethod = Review::ProcessingMethod.Inline,
                SandboxOutcome = Review::SandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Review::CustomerDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = Review::CustomerDetailsStatus.Pending,
            Type = Review::Type.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Config = new()
            {
                ProcessingMethod = Review::ProcessingMethod.Inline,
                SandboxOutcome = Review::SandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),

            Address = null,
            ComplianceProfile = null,
            ExternalID = null,
            Metadata = null,
        };

        Assert.Null(model.Address);
        Assert.True(model.RawData.ContainsKey("address"));
        Assert.Null(model.ComplianceProfile);
        Assert.True(model.RawData.ContainsKey("compliance_profile"));
        Assert.Null(model.ExternalID);
        Assert.True(model.RawData.ContainsKey("external_id"));
        Assert.Null(model.Metadata);
        Assert.True(model.RawData.ContainsKey("metadata"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::CustomerDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = Review::CustomerDetailsStatus.Pending,
            Type = Review::Type.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Config = new()
            {
                ProcessingMethod = Review::ProcessingMethod.Inline,
                SandboxOutcome = Review::SandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),

            Address = null,
            ComplianceProfile = null,
            ExternalID = null,
            Metadata = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Review::CustomerDetails
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Email = "ron.swanson@pawnee.com",
            Name = "Ron Swanson",
            Phone = "+12128675309",
            Status = Review::CustomerDetailsStatus.Pending,
            Type = Review::Type.Individual,
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Address = new()
            {
                Address1 = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Address2 = "Apt 1",
            },
            ComplianceProfile = new Review::IndividualComplianceProfile()
            {
                Dob = "2019-12-27",
                Ssn = "***-**-****",
            },
            Config = new()
            {
                ProcessingMethod = Review::ProcessingMethod.Inline,
                SandboxOutcome = Review::SandboxOutcome.Standard,
            },
            Device = new("192.168.1.1"),
            ExternalID = "external_id",
            Metadata = new Dictionary<string, string>() { { "foo", "string" } },
        };

        Review::CustomerDetails copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class CustomerDetailsStatusTest : TestBase
{
    [Theory]
    [InlineData(Review::CustomerDetailsStatus.Pending)]
    [InlineData(Review::CustomerDetailsStatus.Review)]
    [InlineData(Review::CustomerDetailsStatus.Verified)]
    [InlineData(Review::CustomerDetailsStatus.Inactive)]
    [InlineData(Review::CustomerDetailsStatus.Rejected)]
    public void Validation_Works(Review::CustomerDetailsStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::CustomerDetailsStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::CustomerDetailsStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Review::CustomerDetailsStatus.Pending)]
    [InlineData(Review::CustomerDetailsStatus.Review)]
    [InlineData(Review::CustomerDetailsStatus.Verified)]
    [InlineData(Review::CustomerDetailsStatus.Inactive)]
    [InlineData(Review::CustomerDetailsStatus.Rejected)]
    public void SerializationRoundtrip_Works(Review::CustomerDetailsStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::CustomerDetailsStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, Review::CustomerDetailsStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::CustomerDetailsStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, Review::CustomerDetailsStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class TypeTest : TestBase
{
    [Theory]
    [InlineData(Review::Type.Individual)]
    [InlineData(Review::Type.Business)]
    public void Validation_Works(Review::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::Type> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Review::Type.Individual)]
    [InlineData(Review::Type.Business)]
    public void SerializationRoundtrip_Works(Review::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::Type> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class ComplianceProfileTest : TestBase
{
    [Fact]
    public void IndividualValidationWorks()
    {
        Review::ComplianceProfile value = new Review::IndividualComplianceProfile()
        {
            Dob = "2019-12-27",
            Ssn = "***-**-****",
        };
        value.Validate();
    }

    [Fact]
    public void BusinessValidationWorks()
    {
        Review::ComplianceProfile value = new Review::BusinessComplianceProfile()
        {
            Ein = "21-6051329",
            LegalBusinessName = "Acme Corp LLC",
            Representatives =
            [
                new()
                {
                    Name = "name",
                    Email = "email",
                    Phone = "phone",
                },
            ],
            Website = "https://example.com",
        };
        value.Validate();
    }

    [Fact]
    public void IndividualSerializationRoundtripWorks()
    {
        Review::ComplianceProfile value = new Review::IndividualComplianceProfile()
        {
            Dob = "2019-12-27",
            Ssn = "***-**-****",
        };
        string element = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::ComplianceProfile>(
            element,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void BusinessSerializationRoundtripWorks()
    {
        Review::ComplianceProfile value = new Review::BusinessComplianceProfile()
        {
            Ein = "21-6051329",
            LegalBusinessName = "Acme Corp LLC",
            Representatives =
            [
                new()
                {
                    Name = "name",
                    Email = "email",
                    Phone = "phone",
                },
            ],
            Website = "https://example.com",
        };
        string element = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::ComplianceProfile>(
            element,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class IndividualComplianceProfileTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Review::IndividualComplianceProfile
        {
            Dob = "2019-12-27",
            Ssn = "***-**-****",
        };

        string expectedDob = "2019-12-27";
        string expectedSsn = "***-**-****";

        Assert.Equal(expectedDob, model.Dob);
        Assert.Equal(expectedSsn, model.Ssn);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Review::IndividualComplianceProfile
        {
            Dob = "2019-12-27",
            Ssn = "***-**-****",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::IndividualComplianceProfile>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Review::IndividualComplianceProfile
        {
            Dob = "2019-12-27",
            Ssn = "***-**-****",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::IndividualComplianceProfile>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedDob = "2019-12-27";
        string expectedSsn = "***-**-****";

        Assert.Equal(expectedDob, deserialized.Dob);
        Assert.Equal(expectedSsn, deserialized.Ssn);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Review::IndividualComplianceProfile
        {
            Dob = "2019-12-27",
            Ssn = "***-**-****",
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Review::IndividualComplianceProfile
        {
            Dob = "2019-12-27",
            Ssn = "***-**-****",
        };

        Review::IndividualComplianceProfile copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class BusinessComplianceProfileTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Review::BusinessComplianceProfile
        {
            Ein = "21-6051329",
            LegalBusinessName = "Acme Corp LLC",
            Representatives =
            [
                new()
                {
                    Name = "name",
                    Email = "email",
                    Phone = "phone",
                },
            ],
            Website = "https://example.com",
        };

        string expectedEin = "21-6051329";
        string expectedLegalBusinessName = "Acme Corp LLC";
        List<Review::Representative> expectedRepresentatives =
        [
            new()
            {
                Name = "name",
                Email = "email",
                Phone = "phone",
            },
        ];
        string expectedWebsite = "https://example.com";

        Assert.Equal(expectedEin, model.Ein);
        Assert.Equal(expectedLegalBusinessName, model.LegalBusinessName);
        Assert.NotNull(model.Representatives);
        Assert.Equal(expectedRepresentatives.Count, model.Representatives.Count);
        for (int i = 0; i < expectedRepresentatives.Count; i++)
        {
            Assert.Equal(expectedRepresentatives[i], model.Representatives[i]);
        }
        Assert.Equal(expectedWebsite, model.Website);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Review::BusinessComplianceProfile
        {
            Ein = "21-6051329",
            LegalBusinessName = "Acme Corp LLC",
            Representatives =
            [
                new()
                {
                    Name = "name",
                    Email = "email",
                    Phone = "phone",
                },
            ],
            Website = "https://example.com",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::BusinessComplianceProfile>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Review::BusinessComplianceProfile
        {
            Ein = "21-6051329",
            LegalBusinessName = "Acme Corp LLC",
            Representatives =
            [
                new()
                {
                    Name = "name",
                    Email = "email",
                    Phone = "phone",
                },
            ],
            Website = "https://example.com",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::BusinessComplianceProfile>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedEin = "21-6051329";
        string expectedLegalBusinessName = "Acme Corp LLC";
        List<Review::Representative> expectedRepresentatives =
        [
            new()
            {
                Name = "name",
                Email = "email",
                Phone = "phone",
            },
        ];
        string expectedWebsite = "https://example.com";

        Assert.Equal(expectedEin, deserialized.Ein);
        Assert.Equal(expectedLegalBusinessName, deserialized.LegalBusinessName);
        Assert.NotNull(deserialized.Representatives);
        Assert.Equal(expectedRepresentatives.Count, deserialized.Representatives.Count);
        for (int i = 0; i < expectedRepresentatives.Count; i++)
        {
            Assert.Equal(expectedRepresentatives[i], deserialized.Representatives[i]);
        }
        Assert.Equal(expectedWebsite, deserialized.Website);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Review::BusinessComplianceProfile
        {
            Ein = "21-6051329",
            LegalBusinessName = "Acme Corp LLC",
            Representatives =
            [
                new()
                {
                    Name = "name",
                    Email = "email",
                    Phone = "phone",
                },
            ],
            Website = "https://example.com",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::BusinessComplianceProfile
        {
            Ein = "21-6051329",
            LegalBusinessName = "Acme Corp LLC",
        };

        Assert.Null(model.Representatives);
        Assert.False(model.RawData.ContainsKey("representatives"));
        Assert.Null(model.Website);
        Assert.False(model.RawData.ContainsKey("website"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::BusinessComplianceProfile
        {
            Ein = "21-6051329",
            LegalBusinessName = "Acme Corp LLC",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Review::BusinessComplianceProfile
        {
            Ein = "21-6051329",
            LegalBusinessName = "Acme Corp LLC",

            Representatives = null,
            Website = null,
        };

        Assert.Null(model.Representatives);
        Assert.True(model.RawData.ContainsKey("representatives"));
        Assert.Null(model.Website);
        Assert.True(model.RawData.ContainsKey("website"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::BusinessComplianceProfile
        {
            Ein = "21-6051329",
            LegalBusinessName = "Acme Corp LLC",

            Representatives = null,
            Website = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Review::BusinessComplianceProfile
        {
            Ein = "21-6051329",
            LegalBusinessName = "Acme Corp LLC",
            Representatives =
            [
                new()
                {
                    Name = "name",
                    Email = "email",
                    Phone = "phone",
                },
            ],
            Website = "https://example.com",
        };

        Review::BusinessComplianceProfile copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class RepresentativeTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Review::Representative
        {
            Name = "name",
            Email = "email",
            Phone = "phone",
        };

        string expectedName = "name";
        string expectedEmail = "email";
        string expectedPhone = "phone";

        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedEmail, model.Email);
        Assert.Equal(expectedPhone, model.Phone);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Review::Representative
        {
            Name = "name",
            Email = "email",
            Phone = "phone",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Representative>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Review::Representative
        {
            Name = "name",
            Email = "email",
            Phone = "phone",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Representative>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedName = "name";
        string expectedEmail = "email";
        string expectedPhone = "phone";

        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedEmail, deserialized.Email);
        Assert.Equal(expectedPhone, deserialized.Phone);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Review::Representative
        {
            Name = "name",
            Email = "email",
            Phone = "phone",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::Representative { Name = "name" };

        Assert.Null(model.Email);
        Assert.False(model.RawData.ContainsKey("email"));
        Assert.Null(model.Phone);
        Assert.False(model.RawData.ContainsKey("phone"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::Representative { Name = "name" };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Review::Representative
        {
            Name = "name",

            Email = null,
            Phone = null,
        };

        Assert.Null(model.Email);
        Assert.True(model.RawData.ContainsKey("email"));
        Assert.Null(model.Phone);
        Assert.True(model.RawData.ContainsKey("phone"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::Representative
        {
            Name = "name",

            Email = null,
            Phone = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Review::Representative
        {
            Name = "name",
            Email = "email",
            Phone = "phone",
        };

        Review::Representative copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class ConfigTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Review::Config
        {
            ProcessingMethod = Review::ProcessingMethod.Inline,
            SandboxOutcome = Review::SandboxOutcome.Standard,
        };

        ApiEnum<string, Review::ProcessingMethod> expectedProcessingMethod =
            Review::ProcessingMethod.Inline;
        ApiEnum<string, Review::SandboxOutcome> expectedSandboxOutcome =
            Review::SandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, model.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, model.SandboxOutcome);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Review::Config
        {
            ProcessingMethod = Review::ProcessingMethod.Inline,
            SandboxOutcome = Review::SandboxOutcome.Standard,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Config>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Review::Config
        {
            ProcessingMethod = Review::ProcessingMethod.Inline,
            SandboxOutcome = Review::SandboxOutcome.Standard,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Config>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, Review::ProcessingMethod> expectedProcessingMethod =
            Review::ProcessingMethod.Inline;
        ApiEnum<string, Review::SandboxOutcome> expectedSandboxOutcome =
            Review::SandboxOutcome.Standard;

        Assert.Equal(expectedProcessingMethod, deserialized.ProcessingMethod);
        Assert.Equal(expectedSandboxOutcome, deserialized.SandboxOutcome);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Review::Config
        {
            ProcessingMethod = Review::ProcessingMethod.Inline,
            SandboxOutcome = Review::SandboxOutcome.Standard,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::Config { };

        Assert.Null(model.ProcessingMethod);
        Assert.False(model.RawData.ContainsKey("processing_method"));
        Assert.Null(model.SandboxOutcome);
        Assert.False(model.RawData.ContainsKey("sandbox_outcome"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::Config { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Review::Config
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
        var model = new Review::Config
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
        var model = new Review::Config
        {
            ProcessingMethod = Review::ProcessingMethod.Inline,
            SandboxOutcome = Review::SandboxOutcome.Standard,
        };

        Review::Config copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class ProcessingMethodTest : TestBase
{
    [Theory]
    [InlineData(Review::ProcessingMethod.Inline)]
    [InlineData(Review::ProcessingMethod.Background)]
    [InlineData(Review::ProcessingMethod.Skip)]
    public void Validation_Works(Review::ProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::ProcessingMethod> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::ProcessingMethod>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Review::ProcessingMethod.Inline)]
    [InlineData(Review::ProcessingMethod.Background)]
    [InlineData(Review::ProcessingMethod.Skip)]
    public void SerializationRoundtrip_Works(Review::ProcessingMethod rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::ProcessingMethod> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::ProcessingMethod>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::ProcessingMethod>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::ProcessingMethod>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class SandboxOutcomeTest : TestBase
{
    [Theory]
    [InlineData(Review::SandboxOutcome.Standard)]
    [InlineData(Review::SandboxOutcome.Verified)]
    [InlineData(Review::SandboxOutcome.Rejected)]
    [InlineData(Review::SandboxOutcome.Review)]
    public void Validation_Works(Review::SandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::SandboxOutcome> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::SandboxOutcome>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Review::SandboxOutcome.Standard)]
    [InlineData(Review::SandboxOutcome.Verified)]
    [InlineData(Review::SandboxOutcome.Rejected)]
    [InlineData(Review::SandboxOutcome.Review)]
    public void SerializationRoundtrip_Works(Review::SandboxOutcome rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::SandboxOutcome> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::SandboxOutcome>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::SandboxOutcome>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::SandboxOutcome>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class DeviceTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Review::Device { IPAddress = "192.168.1.1" };

        string expectedIPAddress = "192.168.1.1";

        Assert.Equal(expectedIPAddress, model.IPAddress);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Review::Device { IPAddress = "192.168.1.1" };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Device>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Review::Device { IPAddress = "192.168.1.1" };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Device>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedIPAddress = "192.168.1.1";

        Assert.Equal(expectedIPAddress, deserialized.IPAddress);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Review::Device { IPAddress = "192.168.1.1" };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Review::Device { IPAddress = "192.168.1.1" };

        Review::Device copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class IdentityDetailsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Review::IdentityDetails
        {
            Breakdown = new()
            {
                Address = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessEvaluation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessIdentification = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessValidation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Email = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Fraud = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Phone = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Synthetic = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = Review::Decision.Accept,
            ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Kyc = new()
            {
                Validations = new()
                {
                    Address = true,
                    City = true,
                    Dob = true,
                    Email = true,
                    FirstName = true,
                    LastName = true,
                    Phone = true,
                    Ssn = true,
                    State = true,
                    Zip = true,
                },
                Codes = ["string"],
                Decision = Review::KycDecision.Accept,
            },
            Messages = new Dictionary<string, string>() { { "foo", "string" } },
            NetworkAlerts = new()
            {
                Alerts = ["string"],
                Codes = ["string"],
                Decision = Review::NetworkAlertsDecision.Accept,
            },
            Reputation = new()
            {
                Codes = ["string"],
                Decision = Review::ReputationDecision.Accept,
                Insights = new()
                {
                    AccountsActiveCount = 0,
                    AccountsClosedCount = 0,
                    AccountsClosedDates = ["2019-12-27"],
                    AccountsCount = 0,
                    AccountsFraudCount = 0,
                    AccountsFraudLabeledDates = ["2019-12-27"],
                    AccountsFraudLossTotalAmount = 0,
                    AchFraudTransactionsCount = 0,
                    AchFraudTransactionsDates = ["2019-12-27"],
                    AchFraudTransactionsTotalAmount = 0,
                    AchReturnedTransactionsCount = 0,
                    AchReturnedTransactionsDates = ["2019-12-27"],
                    AchReturnedTransactionsTotalAmount = 0,
                    ApplicationsApprovedCount = 0,
                    ApplicationsCount = 0,
                    ApplicationsDates = ["2019-12-27"],
                    ApplicationsDeclinedCount = 0,
                    ApplicationsFraudCount = 0,
                    CardDisputedTransactionsCount = 0,
                    CardDisputedTransactionsDates = ["2019-12-27"],
                    CardDisputedTransactionsTotalAmount = 0,
                    CardFraudTransactionsCount = 0,
                    CardFraudTransactionsDates = ["2019-12-27"],
                    CardFraudTransactionsTotalAmount = 0,
                    CardStoppedTransactionsCount = 0,
                    CardStoppedTransactionsDates = ["2019-12-27"],
                    UserActiveProfileCount = 0,
                    UserAddressCount = 0,
                    UserClosedProfileCount = 0,
                    UserDobCount = 0,
                    UserEmailCount = 0,
                    UserInstitutionCount = 0,
                    UserMobileCount = 0,
                },
                RiskScore = 0,
            },
            WatchList = new()
            {
                Codes = ["string"],
                Decision = Review::WatchListDecision.Accept,
                Matched = ["string"],
                Matches =
                [
                    new()
                    {
                        Correlation = Review::Correlation.LowConfidence,
                        ListName = "list_name",
                        MatchFields = ["string"],
                        Urls = ["string"],
                    },
                ],
            },
        };

        Review::Breakdown expectedBreakdown = new()
        {
            Address = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessEvaluation = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessIdentification = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessValidation = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Email = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Fraud = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Phone = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Synthetic = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        ApiEnum<string, Review::Decision> expectedDecision = Review::Decision.Accept;
        string expectedReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        Review::Kyc expectedKyc = new()
        {
            Validations = new()
            {
                Address = true,
                City = true,
                Dob = true,
                Email = true,
                FirstName = true,
                LastName = true,
                Phone = true,
                Ssn = true,
                State = true,
                Zip = true,
            },
            Codes = ["string"],
            Decision = Review::KycDecision.Accept,
        };
        Dictionary<string, string> expectedMessages = new() { { "foo", "string" } };
        Review::NetworkAlerts expectedNetworkAlerts = new()
        {
            Alerts = ["string"],
            Codes = ["string"],
            Decision = Review::NetworkAlertsDecision.Accept,
        };
        Review::Reputation expectedReputation = new()
        {
            Codes = ["string"],
            Decision = Review::ReputationDecision.Accept,
            Insights = new()
            {
                AccountsActiveCount = 0,
                AccountsClosedCount = 0,
                AccountsClosedDates = ["2019-12-27"],
                AccountsCount = 0,
                AccountsFraudCount = 0,
                AccountsFraudLabeledDates = ["2019-12-27"],
                AccountsFraudLossTotalAmount = 0,
                AchFraudTransactionsCount = 0,
                AchFraudTransactionsDates = ["2019-12-27"],
                AchFraudTransactionsTotalAmount = 0,
                AchReturnedTransactionsCount = 0,
                AchReturnedTransactionsDates = ["2019-12-27"],
                AchReturnedTransactionsTotalAmount = 0,
                ApplicationsApprovedCount = 0,
                ApplicationsCount = 0,
                ApplicationsDates = ["2019-12-27"],
                ApplicationsDeclinedCount = 0,
                ApplicationsFraudCount = 0,
                CardDisputedTransactionsCount = 0,
                CardDisputedTransactionsDates = ["2019-12-27"],
                CardDisputedTransactionsTotalAmount = 0,
                CardFraudTransactionsCount = 0,
                CardFraudTransactionsDates = ["2019-12-27"],
                CardFraudTransactionsTotalAmount = 0,
                CardStoppedTransactionsCount = 0,
                CardStoppedTransactionsDates = ["2019-12-27"],
                UserActiveProfileCount = 0,
                UserAddressCount = 0,
                UserClosedProfileCount = 0,
                UserDobCount = 0,
                UserEmailCount = 0,
                UserInstitutionCount = 0,
                UserMobileCount = 0,
            },
            RiskScore = 0,
        };
        Review::WatchList expectedWatchList = new()
        {
            Codes = ["string"],
            Decision = Review::WatchListDecision.Accept,
            Matched = ["string"],
            Matches =
            [
                new()
                {
                    Correlation = Review::Correlation.LowConfidence,
                    ListName = "list_name",
                    MatchFields = ["string"],
                    Urls = ["string"],
                },
            ],
        };

        Assert.Equal(expectedBreakdown, model.Breakdown);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedDecision, model.Decision);
        Assert.Equal(expectedReviewID, model.ReviewID);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
        Assert.Equal(expectedKyc, model.Kyc);
        Assert.NotNull(model.Messages);
        Assert.Equal(expectedMessages.Count, model.Messages.Count);
        foreach (var item in expectedMessages)
        {
            Assert.True(model.Messages.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.Messages[item.Key]);
        }
        Assert.Equal(expectedNetworkAlerts, model.NetworkAlerts);
        Assert.Equal(expectedReputation, model.Reputation);
        Assert.Equal(expectedWatchList, model.WatchList);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Review::IdentityDetails
        {
            Breakdown = new()
            {
                Address = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessEvaluation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessIdentification = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessValidation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Email = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Fraud = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Phone = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Synthetic = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = Review::Decision.Accept,
            ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Kyc = new()
            {
                Validations = new()
                {
                    Address = true,
                    City = true,
                    Dob = true,
                    Email = true,
                    FirstName = true,
                    LastName = true,
                    Phone = true,
                    Ssn = true,
                    State = true,
                    Zip = true,
                },
                Codes = ["string"],
                Decision = Review::KycDecision.Accept,
            },
            Messages = new Dictionary<string, string>() { { "foo", "string" } },
            NetworkAlerts = new()
            {
                Alerts = ["string"],
                Codes = ["string"],
                Decision = Review::NetworkAlertsDecision.Accept,
            },
            Reputation = new()
            {
                Codes = ["string"],
                Decision = Review::ReputationDecision.Accept,
                Insights = new()
                {
                    AccountsActiveCount = 0,
                    AccountsClosedCount = 0,
                    AccountsClosedDates = ["2019-12-27"],
                    AccountsCount = 0,
                    AccountsFraudCount = 0,
                    AccountsFraudLabeledDates = ["2019-12-27"],
                    AccountsFraudLossTotalAmount = 0,
                    AchFraudTransactionsCount = 0,
                    AchFraudTransactionsDates = ["2019-12-27"],
                    AchFraudTransactionsTotalAmount = 0,
                    AchReturnedTransactionsCount = 0,
                    AchReturnedTransactionsDates = ["2019-12-27"],
                    AchReturnedTransactionsTotalAmount = 0,
                    ApplicationsApprovedCount = 0,
                    ApplicationsCount = 0,
                    ApplicationsDates = ["2019-12-27"],
                    ApplicationsDeclinedCount = 0,
                    ApplicationsFraudCount = 0,
                    CardDisputedTransactionsCount = 0,
                    CardDisputedTransactionsDates = ["2019-12-27"],
                    CardDisputedTransactionsTotalAmount = 0,
                    CardFraudTransactionsCount = 0,
                    CardFraudTransactionsDates = ["2019-12-27"],
                    CardFraudTransactionsTotalAmount = 0,
                    CardStoppedTransactionsCount = 0,
                    CardStoppedTransactionsDates = ["2019-12-27"],
                    UserActiveProfileCount = 0,
                    UserAddressCount = 0,
                    UserClosedProfileCount = 0,
                    UserDobCount = 0,
                    UserEmailCount = 0,
                    UserInstitutionCount = 0,
                    UserMobileCount = 0,
                },
                RiskScore = 0,
            },
            WatchList = new()
            {
                Codes = ["string"],
                Decision = Review::WatchListDecision.Accept,
                Matched = ["string"],
                Matches =
                [
                    new()
                    {
                        Correlation = Review::Correlation.LowConfidence,
                        ListName = "list_name",
                        MatchFields = ["string"],
                        Urls = ["string"],
                    },
                ],
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::IdentityDetails>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Review::IdentityDetails
        {
            Breakdown = new()
            {
                Address = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessEvaluation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessIdentification = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessValidation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Email = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Fraud = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Phone = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Synthetic = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = Review::Decision.Accept,
            ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Kyc = new()
            {
                Validations = new()
                {
                    Address = true,
                    City = true,
                    Dob = true,
                    Email = true,
                    FirstName = true,
                    LastName = true,
                    Phone = true,
                    Ssn = true,
                    State = true,
                    Zip = true,
                },
                Codes = ["string"],
                Decision = Review::KycDecision.Accept,
            },
            Messages = new Dictionary<string, string>() { { "foo", "string" } },
            NetworkAlerts = new()
            {
                Alerts = ["string"],
                Codes = ["string"],
                Decision = Review::NetworkAlertsDecision.Accept,
            },
            Reputation = new()
            {
                Codes = ["string"],
                Decision = Review::ReputationDecision.Accept,
                Insights = new()
                {
                    AccountsActiveCount = 0,
                    AccountsClosedCount = 0,
                    AccountsClosedDates = ["2019-12-27"],
                    AccountsCount = 0,
                    AccountsFraudCount = 0,
                    AccountsFraudLabeledDates = ["2019-12-27"],
                    AccountsFraudLossTotalAmount = 0,
                    AchFraudTransactionsCount = 0,
                    AchFraudTransactionsDates = ["2019-12-27"],
                    AchFraudTransactionsTotalAmount = 0,
                    AchReturnedTransactionsCount = 0,
                    AchReturnedTransactionsDates = ["2019-12-27"],
                    AchReturnedTransactionsTotalAmount = 0,
                    ApplicationsApprovedCount = 0,
                    ApplicationsCount = 0,
                    ApplicationsDates = ["2019-12-27"],
                    ApplicationsDeclinedCount = 0,
                    ApplicationsFraudCount = 0,
                    CardDisputedTransactionsCount = 0,
                    CardDisputedTransactionsDates = ["2019-12-27"],
                    CardDisputedTransactionsTotalAmount = 0,
                    CardFraudTransactionsCount = 0,
                    CardFraudTransactionsDates = ["2019-12-27"],
                    CardFraudTransactionsTotalAmount = 0,
                    CardStoppedTransactionsCount = 0,
                    CardStoppedTransactionsDates = ["2019-12-27"],
                    UserActiveProfileCount = 0,
                    UserAddressCount = 0,
                    UserClosedProfileCount = 0,
                    UserDobCount = 0,
                    UserEmailCount = 0,
                    UserInstitutionCount = 0,
                    UserMobileCount = 0,
                },
                RiskScore = 0,
            },
            WatchList = new()
            {
                Codes = ["string"],
                Decision = Review::WatchListDecision.Accept,
                Matched = ["string"],
                Matches =
                [
                    new()
                    {
                        Correlation = Review::Correlation.LowConfidence,
                        ListName = "list_name",
                        MatchFields = ["string"],
                        Urls = ["string"],
                    },
                ],
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::IdentityDetails>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        Review::Breakdown expectedBreakdown = new()
        {
            Address = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessEvaluation = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessIdentification = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessValidation = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Email = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Fraud = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Phone = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Synthetic = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
        };
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        ApiEnum<string, Review::Decision> expectedDecision = Review::Decision.Accept;
        string expectedReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        Review::Kyc expectedKyc = new()
        {
            Validations = new()
            {
                Address = true,
                City = true,
                Dob = true,
                Email = true,
                FirstName = true,
                LastName = true,
                Phone = true,
                Ssn = true,
                State = true,
                Zip = true,
            },
            Codes = ["string"],
            Decision = Review::KycDecision.Accept,
        };
        Dictionary<string, string> expectedMessages = new() { { "foo", "string" } };
        Review::NetworkAlerts expectedNetworkAlerts = new()
        {
            Alerts = ["string"],
            Codes = ["string"],
            Decision = Review::NetworkAlertsDecision.Accept,
        };
        Review::Reputation expectedReputation = new()
        {
            Codes = ["string"],
            Decision = Review::ReputationDecision.Accept,
            Insights = new()
            {
                AccountsActiveCount = 0,
                AccountsClosedCount = 0,
                AccountsClosedDates = ["2019-12-27"],
                AccountsCount = 0,
                AccountsFraudCount = 0,
                AccountsFraudLabeledDates = ["2019-12-27"],
                AccountsFraudLossTotalAmount = 0,
                AchFraudTransactionsCount = 0,
                AchFraudTransactionsDates = ["2019-12-27"],
                AchFraudTransactionsTotalAmount = 0,
                AchReturnedTransactionsCount = 0,
                AchReturnedTransactionsDates = ["2019-12-27"],
                AchReturnedTransactionsTotalAmount = 0,
                ApplicationsApprovedCount = 0,
                ApplicationsCount = 0,
                ApplicationsDates = ["2019-12-27"],
                ApplicationsDeclinedCount = 0,
                ApplicationsFraudCount = 0,
                CardDisputedTransactionsCount = 0,
                CardDisputedTransactionsDates = ["2019-12-27"],
                CardDisputedTransactionsTotalAmount = 0,
                CardFraudTransactionsCount = 0,
                CardFraudTransactionsDates = ["2019-12-27"],
                CardFraudTransactionsTotalAmount = 0,
                CardStoppedTransactionsCount = 0,
                CardStoppedTransactionsDates = ["2019-12-27"],
                UserActiveProfileCount = 0,
                UserAddressCount = 0,
                UserClosedProfileCount = 0,
                UserDobCount = 0,
                UserEmailCount = 0,
                UserInstitutionCount = 0,
                UserMobileCount = 0,
            },
            RiskScore = 0,
        };
        Review::WatchList expectedWatchList = new()
        {
            Codes = ["string"],
            Decision = Review::WatchListDecision.Accept,
            Matched = ["string"],
            Matches =
            [
                new()
                {
                    Correlation = Review::Correlation.LowConfidence,
                    ListName = "list_name",
                    MatchFields = ["string"],
                    Urls = ["string"],
                },
            ],
        };

        Assert.Equal(expectedBreakdown, deserialized.Breakdown);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedDecision, deserialized.Decision);
        Assert.Equal(expectedReviewID, deserialized.ReviewID);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
        Assert.Equal(expectedKyc, deserialized.Kyc);
        Assert.NotNull(deserialized.Messages);
        Assert.Equal(expectedMessages.Count, deserialized.Messages.Count);
        foreach (var item in expectedMessages)
        {
            Assert.True(deserialized.Messages.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.Messages[item.Key]);
        }
        Assert.Equal(expectedNetworkAlerts, deserialized.NetworkAlerts);
        Assert.Equal(expectedReputation, deserialized.Reputation);
        Assert.Equal(expectedWatchList, deserialized.WatchList);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Review::IdentityDetails
        {
            Breakdown = new()
            {
                Address = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessEvaluation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessIdentification = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessValidation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Email = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Fraud = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Phone = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Synthetic = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = Review::Decision.Accept,
            ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Kyc = new()
            {
                Validations = new()
                {
                    Address = true,
                    City = true,
                    Dob = true,
                    Email = true,
                    FirstName = true,
                    LastName = true,
                    Phone = true,
                    Ssn = true,
                    State = true,
                    Zip = true,
                },
                Codes = ["string"],
                Decision = Review::KycDecision.Accept,
            },
            Messages = new Dictionary<string, string>() { { "foo", "string" } },
            NetworkAlerts = new()
            {
                Alerts = ["string"],
                Codes = ["string"],
                Decision = Review::NetworkAlertsDecision.Accept,
            },
            Reputation = new()
            {
                Codes = ["string"],
                Decision = Review::ReputationDecision.Accept,
                Insights = new()
                {
                    AccountsActiveCount = 0,
                    AccountsClosedCount = 0,
                    AccountsClosedDates = ["2019-12-27"],
                    AccountsCount = 0,
                    AccountsFraudCount = 0,
                    AccountsFraudLabeledDates = ["2019-12-27"],
                    AccountsFraudLossTotalAmount = 0,
                    AchFraudTransactionsCount = 0,
                    AchFraudTransactionsDates = ["2019-12-27"],
                    AchFraudTransactionsTotalAmount = 0,
                    AchReturnedTransactionsCount = 0,
                    AchReturnedTransactionsDates = ["2019-12-27"],
                    AchReturnedTransactionsTotalAmount = 0,
                    ApplicationsApprovedCount = 0,
                    ApplicationsCount = 0,
                    ApplicationsDates = ["2019-12-27"],
                    ApplicationsDeclinedCount = 0,
                    ApplicationsFraudCount = 0,
                    CardDisputedTransactionsCount = 0,
                    CardDisputedTransactionsDates = ["2019-12-27"],
                    CardDisputedTransactionsTotalAmount = 0,
                    CardFraudTransactionsCount = 0,
                    CardFraudTransactionsDates = ["2019-12-27"],
                    CardFraudTransactionsTotalAmount = 0,
                    CardStoppedTransactionsCount = 0,
                    CardStoppedTransactionsDates = ["2019-12-27"],
                    UserActiveProfileCount = 0,
                    UserAddressCount = 0,
                    UserClosedProfileCount = 0,
                    UserDobCount = 0,
                    UserEmailCount = 0,
                    UserInstitutionCount = 0,
                    UserMobileCount = 0,
                },
                RiskScore = 0,
            },
            WatchList = new()
            {
                Codes = ["string"],
                Decision = Review::WatchListDecision.Accept,
                Matched = ["string"],
                Matches =
                [
                    new()
                    {
                        Correlation = Review::Correlation.LowConfidence,
                        ListName = "list_name",
                        MatchFields = ["string"],
                        Urls = ["string"],
                    },
                ],
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::IdentityDetails
        {
            Breakdown = new()
            {
                Address = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessEvaluation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessIdentification = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessValidation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Email = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Fraud = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Phone = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Synthetic = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = Review::Decision.Accept,
            ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Messages = new Dictionary<string, string>() { { "foo", "string" } },
        };

        Assert.Null(model.Kyc);
        Assert.False(model.RawData.ContainsKey("kyc"));
        Assert.Null(model.NetworkAlerts);
        Assert.False(model.RawData.ContainsKey("network_alerts"));
        Assert.Null(model.Reputation);
        Assert.False(model.RawData.ContainsKey("reputation"));
        Assert.Null(model.WatchList);
        Assert.False(model.RawData.ContainsKey("watch_list"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::IdentityDetails
        {
            Breakdown = new()
            {
                Address = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessEvaluation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessIdentification = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessValidation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Email = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Fraud = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Phone = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Synthetic = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = Review::Decision.Accept,
            ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Messages = new Dictionary<string, string>() { { "foo", "string" } },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Review::IdentityDetails
        {
            Breakdown = new()
            {
                Address = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessEvaluation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessIdentification = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessValidation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Email = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Fraud = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Phone = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Synthetic = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = Review::Decision.Accept,
            ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Messages = new Dictionary<string, string>() { { "foo", "string" } },

            // Null should be interpreted as omitted for these properties
            Kyc = null,
            NetworkAlerts = null,
            Reputation = null,
            WatchList = null,
        };

        Assert.Null(model.Kyc);
        Assert.False(model.RawData.ContainsKey("kyc"));
        Assert.Null(model.NetworkAlerts);
        Assert.False(model.RawData.ContainsKey("network_alerts"));
        Assert.Null(model.Reputation);
        Assert.False(model.RawData.ContainsKey("reputation"));
        Assert.Null(model.WatchList);
        Assert.False(model.RawData.ContainsKey("watch_list"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::IdentityDetails
        {
            Breakdown = new()
            {
                Address = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessEvaluation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessIdentification = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessValidation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Email = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Fraud = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Phone = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Synthetic = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = Review::Decision.Accept,
            ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Messages = new Dictionary<string, string>() { { "foo", "string" } },

            // Null should be interpreted as omitted for these properties
            Kyc = null,
            NetworkAlerts = null,
            Reputation = null,
            WatchList = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::IdentityDetails
        {
            Breakdown = new()
            {
                Address = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessEvaluation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessIdentification = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessValidation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Email = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Fraud = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Phone = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Synthetic = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = Review::Decision.Accept,
            ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Kyc = new()
            {
                Validations = new()
                {
                    Address = true,
                    City = true,
                    Dob = true,
                    Email = true,
                    FirstName = true,
                    LastName = true,
                    Phone = true,
                    Ssn = true,
                    State = true,
                    Zip = true,
                },
                Codes = ["string"],
                Decision = Review::KycDecision.Accept,
            },
            NetworkAlerts = new()
            {
                Alerts = ["string"],
                Codes = ["string"],
                Decision = Review::NetworkAlertsDecision.Accept,
            },
            Reputation = new()
            {
                Codes = ["string"],
                Decision = Review::ReputationDecision.Accept,
                Insights = new()
                {
                    AccountsActiveCount = 0,
                    AccountsClosedCount = 0,
                    AccountsClosedDates = ["2019-12-27"],
                    AccountsCount = 0,
                    AccountsFraudCount = 0,
                    AccountsFraudLabeledDates = ["2019-12-27"],
                    AccountsFraudLossTotalAmount = 0,
                    AchFraudTransactionsCount = 0,
                    AchFraudTransactionsDates = ["2019-12-27"],
                    AchFraudTransactionsTotalAmount = 0,
                    AchReturnedTransactionsCount = 0,
                    AchReturnedTransactionsDates = ["2019-12-27"],
                    AchReturnedTransactionsTotalAmount = 0,
                    ApplicationsApprovedCount = 0,
                    ApplicationsCount = 0,
                    ApplicationsDates = ["2019-12-27"],
                    ApplicationsDeclinedCount = 0,
                    ApplicationsFraudCount = 0,
                    CardDisputedTransactionsCount = 0,
                    CardDisputedTransactionsDates = ["2019-12-27"],
                    CardDisputedTransactionsTotalAmount = 0,
                    CardFraudTransactionsCount = 0,
                    CardFraudTransactionsDates = ["2019-12-27"],
                    CardFraudTransactionsTotalAmount = 0,
                    CardStoppedTransactionsCount = 0,
                    CardStoppedTransactionsDates = ["2019-12-27"],
                    UserActiveProfileCount = 0,
                    UserAddressCount = 0,
                    UserClosedProfileCount = 0,
                    UserDobCount = 0,
                    UserEmailCount = 0,
                    UserInstitutionCount = 0,
                    UserMobileCount = 0,
                },
                RiskScore = 0,
            },
            WatchList = new()
            {
                Codes = ["string"],
                Decision = Review::WatchListDecision.Accept,
                Matched = ["string"],
                Matches =
                [
                    new()
                    {
                        Correlation = Review::Correlation.LowConfidence,
                        ListName = "list_name",
                        MatchFields = ["string"],
                        Urls = ["string"],
                    },
                ],
            },
        };

        Assert.Null(model.Messages);
        Assert.False(model.RawData.ContainsKey("messages"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::IdentityDetails
        {
            Breakdown = new()
            {
                Address = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessEvaluation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessIdentification = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessValidation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Email = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Fraud = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Phone = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Synthetic = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = Review::Decision.Accept,
            ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Kyc = new()
            {
                Validations = new()
                {
                    Address = true,
                    City = true,
                    Dob = true,
                    Email = true,
                    FirstName = true,
                    LastName = true,
                    Phone = true,
                    Ssn = true,
                    State = true,
                    Zip = true,
                },
                Codes = ["string"],
                Decision = Review::KycDecision.Accept,
            },
            NetworkAlerts = new()
            {
                Alerts = ["string"],
                Codes = ["string"],
                Decision = Review::NetworkAlertsDecision.Accept,
            },
            Reputation = new()
            {
                Codes = ["string"],
                Decision = Review::ReputationDecision.Accept,
                Insights = new()
                {
                    AccountsActiveCount = 0,
                    AccountsClosedCount = 0,
                    AccountsClosedDates = ["2019-12-27"],
                    AccountsCount = 0,
                    AccountsFraudCount = 0,
                    AccountsFraudLabeledDates = ["2019-12-27"],
                    AccountsFraudLossTotalAmount = 0,
                    AchFraudTransactionsCount = 0,
                    AchFraudTransactionsDates = ["2019-12-27"],
                    AchFraudTransactionsTotalAmount = 0,
                    AchReturnedTransactionsCount = 0,
                    AchReturnedTransactionsDates = ["2019-12-27"],
                    AchReturnedTransactionsTotalAmount = 0,
                    ApplicationsApprovedCount = 0,
                    ApplicationsCount = 0,
                    ApplicationsDates = ["2019-12-27"],
                    ApplicationsDeclinedCount = 0,
                    ApplicationsFraudCount = 0,
                    CardDisputedTransactionsCount = 0,
                    CardDisputedTransactionsDates = ["2019-12-27"],
                    CardDisputedTransactionsTotalAmount = 0,
                    CardFraudTransactionsCount = 0,
                    CardFraudTransactionsDates = ["2019-12-27"],
                    CardFraudTransactionsTotalAmount = 0,
                    CardStoppedTransactionsCount = 0,
                    CardStoppedTransactionsDates = ["2019-12-27"],
                    UserActiveProfileCount = 0,
                    UserAddressCount = 0,
                    UserClosedProfileCount = 0,
                    UserDobCount = 0,
                    UserEmailCount = 0,
                    UserInstitutionCount = 0,
                    UserMobileCount = 0,
                },
                RiskScore = 0,
            },
            WatchList = new()
            {
                Codes = ["string"],
                Decision = Review::WatchListDecision.Accept,
                Matched = ["string"],
                Matches =
                [
                    new()
                    {
                        Correlation = Review::Correlation.LowConfidence,
                        ListName = "list_name",
                        MatchFields = ["string"],
                        Urls = ["string"],
                    },
                ],
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Review::IdentityDetails
        {
            Breakdown = new()
            {
                Address = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessEvaluation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessIdentification = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessValidation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Email = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Fraud = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Phone = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Synthetic = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = Review::Decision.Accept,
            ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Kyc = new()
            {
                Validations = new()
                {
                    Address = true,
                    City = true,
                    Dob = true,
                    Email = true,
                    FirstName = true,
                    LastName = true,
                    Phone = true,
                    Ssn = true,
                    State = true,
                    Zip = true,
                },
                Codes = ["string"],
                Decision = Review::KycDecision.Accept,
            },
            NetworkAlerts = new()
            {
                Alerts = ["string"],
                Codes = ["string"],
                Decision = Review::NetworkAlertsDecision.Accept,
            },
            Reputation = new()
            {
                Codes = ["string"],
                Decision = Review::ReputationDecision.Accept,
                Insights = new()
                {
                    AccountsActiveCount = 0,
                    AccountsClosedCount = 0,
                    AccountsClosedDates = ["2019-12-27"],
                    AccountsCount = 0,
                    AccountsFraudCount = 0,
                    AccountsFraudLabeledDates = ["2019-12-27"],
                    AccountsFraudLossTotalAmount = 0,
                    AchFraudTransactionsCount = 0,
                    AchFraudTransactionsDates = ["2019-12-27"],
                    AchFraudTransactionsTotalAmount = 0,
                    AchReturnedTransactionsCount = 0,
                    AchReturnedTransactionsDates = ["2019-12-27"],
                    AchReturnedTransactionsTotalAmount = 0,
                    ApplicationsApprovedCount = 0,
                    ApplicationsCount = 0,
                    ApplicationsDates = ["2019-12-27"],
                    ApplicationsDeclinedCount = 0,
                    ApplicationsFraudCount = 0,
                    CardDisputedTransactionsCount = 0,
                    CardDisputedTransactionsDates = ["2019-12-27"],
                    CardDisputedTransactionsTotalAmount = 0,
                    CardFraudTransactionsCount = 0,
                    CardFraudTransactionsDates = ["2019-12-27"],
                    CardFraudTransactionsTotalAmount = 0,
                    CardStoppedTransactionsCount = 0,
                    CardStoppedTransactionsDates = ["2019-12-27"],
                    UserActiveProfileCount = 0,
                    UserAddressCount = 0,
                    UserClosedProfileCount = 0,
                    UserDobCount = 0,
                    UserEmailCount = 0,
                    UserInstitutionCount = 0,
                    UserMobileCount = 0,
                },
                RiskScore = 0,
            },
            WatchList = new()
            {
                Codes = ["string"],
                Decision = Review::WatchListDecision.Accept,
                Matched = ["string"],
                Matches =
                [
                    new()
                    {
                        Correlation = Review::Correlation.LowConfidence,
                        ListName = "list_name",
                        MatchFields = ["string"],
                        Urls = ["string"],
                    },
                ],
            },

            Messages = null,
        };

        Assert.Null(model.Messages);
        Assert.True(model.RawData.ContainsKey("messages"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::IdentityDetails
        {
            Breakdown = new()
            {
                Address = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessEvaluation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessIdentification = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessValidation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Email = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Fraud = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Phone = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Synthetic = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = Review::Decision.Accept,
            ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Kyc = new()
            {
                Validations = new()
                {
                    Address = true,
                    City = true,
                    Dob = true,
                    Email = true,
                    FirstName = true,
                    LastName = true,
                    Phone = true,
                    Ssn = true,
                    State = true,
                    Zip = true,
                },
                Codes = ["string"],
                Decision = Review::KycDecision.Accept,
            },
            NetworkAlerts = new()
            {
                Alerts = ["string"],
                Codes = ["string"],
                Decision = Review::NetworkAlertsDecision.Accept,
            },
            Reputation = new()
            {
                Codes = ["string"],
                Decision = Review::ReputationDecision.Accept,
                Insights = new()
                {
                    AccountsActiveCount = 0,
                    AccountsClosedCount = 0,
                    AccountsClosedDates = ["2019-12-27"],
                    AccountsCount = 0,
                    AccountsFraudCount = 0,
                    AccountsFraudLabeledDates = ["2019-12-27"],
                    AccountsFraudLossTotalAmount = 0,
                    AchFraudTransactionsCount = 0,
                    AchFraudTransactionsDates = ["2019-12-27"],
                    AchFraudTransactionsTotalAmount = 0,
                    AchReturnedTransactionsCount = 0,
                    AchReturnedTransactionsDates = ["2019-12-27"],
                    AchReturnedTransactionsTotalAmount = 0,
                    ApplicationsApprovedCount = 0,
                    ApplicationsCount = 0,
                    ApplicationsDates = ["2019-12-27"],
                    ApplicationsDeclinedCount = 0,
                    ApplicationsFraudCount = 0,
                    CardDisputedTransactionsCount = 0,
                    CardDisputedTransactionsDates = ["2019-12-27"],
                    CardDisputedTransactionsTotalAmount = 0,
                    CardFraudTransactionsCount = 0,
                    CardFraudTransactionsDates = ["2019-12-27"],
                    CardFraudTransactionsTotalAmount = 0,
                    CardStoppedTransactionsCount = 0,
                    CardStoppedTransactionsDates = ["2019-12-27"],
                    UserActiveProfileCount = 0,
                    UserAddressCount = 0,
                    UserClosedProfileCount = 0,
                    UserDobCount = 0,
                    UserEmailCount = 0,
                    UserInstitutionCount = 0,
                    UserMobileCount = 0,
                },
                RiskScore = 0,
            },
            WatchList = new()
            {
                Codes = ["string"],
                Decision = Review::WatchListDecision.Accept,
                Matched = ["string"],
                Matches =
                [
                    new()
                    {
                        Correlation = Review::Correlation.LowConfidence,
                        ListName = "list_name",
                        MatchFields = ["string"],
                        Urls = ["string"],
                    },
                ],
            },

            Messages = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Review::IdentityDetails
        {
            Breakdown = new()
            {
                Address = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessEvaluation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessIdentification = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                BusinessValidation = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Email = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Fraud = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Phone = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
                Synthetic = new()
                {
                    Codes = ["string"],
                    Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                    CorrelationScore = 0,
                    Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                    RiskScore = 0,
                },
            },
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Decision = Review::Decision.Accept,
            ReviewID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Kyc = new()
            {
                Validations = new()
                {
                    Address = true,
                    City = true,
                    Dob = true,
                    Email = true,
                    FirstName = true,
                    LastName = true,
                    Phone = true,
                    Ssn = true,
                    State = true,
                    Zip = true,
                },
                Codes = ["string"],
                Decision = Review::KycDecision.Accept,
            },
            Messages = new Dictionary<string, string>() { { "foo", "string" } },
            NetworkAlerts = new()
            {
                Alerts = ["string"],
                Codes = ["string"],
                Decision = Review::NetworkAlertsDecision.Accept,
            },
            Reputation = new()
            {
                Codes = ["string"],
                Decision = Review::ReputationDecision.Accept,
                Insights = new()
                {
                    AccountsActiveCount = 0,
                    AccountsClosedCount = 0,
                    AccountsClosedDates = ["2019-12-27"],
                    AccountsCount = 0,
                    AccountsFraudCount = 0,
                    AccountsFraudLabeledDates = ["2019-12-27"],
                    AccountsFraudLossTotalAmount = 0,
                    AchFraudTransactionsCount = 0,
                    AchFraudTransactionsDates = ["2019-12-27"],
                    AchFraudTransactionsTotalAmount = 0,
                    AchReturnedTransactionsCount = 0,
                    AchReturnedTransactionsDates = ["2019-12-27"],
                    AchReturnedTransactionsTotalAmount = 0,
                    ApplicationsApprovedCount = 0,
                    ApplicationsCount = 0,
                    ApplicationsDates = ["2019-12-27"],
                    ApplicationsDeclinedCount = 0,
                    ApplicationsFraudCount = 0,
                    CardDisputedTransactionsCount = 0,
                    CardDisputedTransactionsDates = ["2019-12-27"],
                    CardDisputedTransactionsTotalAmount = 0,
                    CardFraudTransactionsCount = 0,
                    CardFraudTransactionsDates = ["2019-12-27"],
                    CardFraudTransactionsTotalAmount = 0,
                    CardStoppedTransactionsCount = 0,
                    CardStoppedTransactionsDates = ["2019-12-27"],
                    UserActiveProfileCount = 0,
                    UserAddressCount = 0,
                    UserClosedProfileCount = 0,
                    UserDobCount = 0,
                    UserEmailCount = 0,
                    UserInstitutionCount = 0,
                    UserMobileCount = 0,
                },
                RiskScore = 0,
            },
            WatchList = new()
            {
                Codes = ["string"],
                Decision = Review::WatchListDecision.Accept,
                Matched = ["string"],
                Matches =
                [
                    new()
                    {
                        Correlation = Review::Correlation.LowConfidence,
                        ListName = "list_name",
                        MatchFields = ["string"],
                        Urls = ["string"],
                    },
                ],
            },
        };

        Review::IdentityDetails copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class BreakdownTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Review::Breakdown
        {
            Address = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessEvaluation = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessIdentification = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessValidation = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Email = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Fraud = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Phone = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Synthetic = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
        };

        Review::IdentityVerificationBreakdownV1 expectedAddress = new()
        {
            Codes = ["string"],
            Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };
        Review::IdentityVerificationBreakdownV1 expectedBusinessEvaluation = new()
        {
            Codes = ["string"],
            Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };
        Review::IdentityVerificationBreakdownV1 expectedBusinessIdentification = new()
        {
            Codes = ["string"],
            Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };
        Review::IdentityVerificationBreakdownV1 expectedBusinessValidation = new()
        {
            Codes = ["string"],
            Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };
        Review::IdentityVerificationBreakdownV1 expectedEmail = new()
        {
            Codes = ["string"],
            Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };
        Review::IdentityVerificationBreakdownV1 expectedFraud = new()
        {
            Codes = ["string"],
            Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };
        Review::IdentityVerificationBreakdownV1 expectedPhone = new()
        {
            Codes = ["string"],
            Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };
        Review::IdentityVerificationBreakdownV1 expectedSynthetic = new()
        {
            Codes = ["string"],
            Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };

        Assert.Equal(expectedAddress, model.Address);
        Assert.Equal(expectedBusinessEvaluation, model.BusinessEvaluation);
        Assert.Equal(expectedBusinessIdentification, model.BusinessIdentification);
        Assert.Equal(expectedBusinessValidation, model.BusinessValidation);
        Assert.Equal(expectedEmail, model.Email);
        Assert.Equal(expectedFraud, model.Fraud);
        Assert.Equal(expectedPhone, model.Phone);
        Assert.Equal(expectedSynthetic, model.Synthetic);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Review::Breakdown
        {
            Address = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessEvaluation = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessIdentification = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessValidation = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Email = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Fraud = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Phone = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Synthetic = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Breakdown>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Review::Breakdown
        {
            Address = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessEvaluation = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessIdentification = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessValidation = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Email = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Fraud = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Phone = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Synthetic = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Breakdown>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        Review::IdentityVerificationBreakdownV1 expectedAddress = new()
        {
            Codes = ["string"],
            Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };
        Review::IdentityVerificationBreakdownV1 expectedBusinessEvaluation = new()
        {
            Codes = ["string"],
            Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };
        Review::IdentityVerificationBreakdownV1 expectedBusinessIdentification = new()
        {
            Codes = ["string"],
            Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };
        Review::IdentityVerificationBreakdownV1 expectedBusinessValidation = new()
        {
            Codes = ["string"],
            Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };
        Review::IdentityVerificationBreakdownV1 expectedEmail = new()
        {
            Codes = ["string"],
            Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };
        Review::IdentityVerificationBreakdownV1 expectedFraud = new()
        {
            Codes = ["string"],
            Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };
        Review::IdentityVerificationBreakdownV1 expectedPhone = new()
        {
            Codes = ["string"],
            Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };
        Review::IdentityVerificationBreakdownV1 expectedSynthetic = new()
        {
            Codes = ["string"],
            Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
            CorrelationScore = 0,
            Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
            RiskScore = 0,
        };

        Assert.Equal(expectedAddress, deserialized.Address);
        Assert.Equal(expectedBusinessEvaluation, deserialized.BusinessEvaluation);
        Assert.Equal(expectedBusinessIdentification, deserialized.BusinessIdentification);
        Assert.Equal(expectedBusinessValidation, deserialized.BusinessValidation);
        Assert.Equal(expectedEmail, deserialized.Email);
        Assert.Equal(expectedFraud, deserialized.Fraud);
        Assert.Equal(expectedPhone, deserialized.Phone);
        Assert.Equal(expectedSynthetic, deserialized.Synthetic);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Review::Breakdown
        {
            Address = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessEvaluation = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessIdentification = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessValidation = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Email = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Fraud = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Phone = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Synthetic = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::Breakdown { };

        Assert.Null(model.Address);
        Assert.False(model.RawData.ContainsKey("address"));
        Assert.Null(model.BusinessEvaluation);
        Assert.False(model.RawData.ContainsKey("business_evaluation"));
        Assert.Null(model.BusinessIdentification);
        Assert.False(model.RawData.ContainsKey("business_identification"));
        Assert.Null(model.BusinessValidation);
        Assert.False(model.RawData.ContainsKey("business_validation"));
        Assert.Null(model.Email);
        Assert.False(model.RawData.ContainsKey("email"));
        Assert.Null(model.Fraud);
        Assert.False(model.RawData.ContainsKey("fraud"));
        Assert.Null(model.Phone);
        Assert.False(model.RawData.ContainsKey("phone"));
        Assert.Null(model.Synthetic);
        Assert.False(model.RawData.ContainsKey("synthetic"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::Breakdown { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Review::Breakdown
        {
            // Null should be interpreted as omitted for these properties
            Address = null,
            BusinessEvaluation = null,
            BusinessIdentification = null,
            BusinessValidation = null,
            Email = null,
            Fraud = null,
            Phone = null,
            Synthetic = null,
        };

        Assert.Null(model.Address);
        Assert.False(model.RawData.ContainsKey("address"));
        Assert.Null(model.BusinessEvaluation);
        Assert.False(model.RawData.ContainsKey("business_evaluation"));
        Assert.Null(model.BusinessIdentification);
        Assert.False(model.RawData.ContainsKey("business_identification"));
        Assert.Null(model.BusinessValidation);
        Assert.False(model.RawData.ContainsKey("business_validation"));
        Assert.Null(model.Email);
        Assert.False(model.RawData.ContainsKey("email"));
        Assert.Null(model.Fraud);
        Assert.False(model.RawData.ContainsKey("fraud"));
        Assert.Null(model.Phone);
        Assert.False(model.RawData.ContainsKey("phone"));
        Assert.Null(model.Synthetic);
        Assert.False(model.RawData.ContainsKey("synthetic"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::Breakdown
        {
            // Null should be interpreted as omitted for these properties
            Address = null,
            BusinessEvaluation = null,
            BusinessIdentification = null,
            BusinessValidation = null,
            Email = null,
            Fraud = null,
            Phone = null,
            Synthetic = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Review::Breakdown
        {
            Address = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessEvaluation = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessIdentification = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            BusinessValidation = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Email = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Fraud = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Phone = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
            Synthetic = new()
            {
                Codes = ["string"],
                Correlation = Review::IdentityVerificationBreakdownV1Correlation.LowConfidence,
                CorrelationScore = 0,
                Decision = Review::IdentityVerificationBreakdownV1Decision.Accept,
                RiskScore = 0,
            },
        };

        Review::Breakdown copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DecisionTest : TestBase
{
    [Theory]
    [InlineData(Review::Decision.Accept)]
    [InlineData(Review::Decision.Reject)]
    [InlineData(Review::Decision.Review)]
    public void Validation_Works(Review::Decision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::Decision> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::Decision>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Review::Decision.Accept)]
    [InlineData(Review::Decision.Reject)]
    [InlineData(Review::Decision.Review)]
    public void SerializationRoundtrip_Works(Review::Decision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::Decision> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::Decision>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::Decision>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::Decision>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class KycTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Review::Kyc
        {
            Validations = new()
            {
                Address = true,
                City = true,
                Dob = true,
                Email = true,
                FirstName = true,
                LastName = true,
                Phone = true,
                Ssn = true,
                State = true,
                Zip = true,
            },
            Codes = ["string"],
            Decision = Review::KycDecision.Accept,
        };

        Review::Validations expectedValidations = new()
        {
            Address = true,
            City = true,
            Dob = true,
            Email = true,
            FirstName = true,
            LastName = true,
            Phone = true,
            Ssn = true,
            State = true,
            Zip = true,
        };
        List<string> expectedCodes = ["string"];
        ApiEnum<string, Review::KycDecision> expectedDecision = Review::KycDecision.Accept;

        Assert.Equal(expectedValidations, model.Validations);
        Assert.NotNull(model.Codes);
        Assert.Equal(expectedCodes.Count, model.Codes.Count);
        for (int i = 0; i < expectedCodes.Count; i++)
        {
            Assert.Equal(expectedCodes[i], model.Codes[i]);
        }
        Assert.Equal(expectedDecision, model.Decision);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Review::Kyc
        {
            Validations = new()
            {
                Address = true,
                City = true,
                Dob = true,
                Email = true,
                FirstName = true,
                LastName = true,
                Phone = true,
                Ssn = true,
                State = true,
                Zip = true,
            },
            Codes = ["string"],
            Decision = Review::KycDecision.Accept,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Kyc>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Review::Kyc
        {
            Validations = new()
            {
                Address = true,
                City = true,
                Dob = true,
                Email = true,
                FirstName = true,
                LastName = true,
                Phone = true,
                Ssn = true,
                State = true,
                Zip = true,
            },
            Codes = ["string"],
            Decision = Review::KycDecision.Accept,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Kyc>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        Review::Validations expectedValidations = new()
        {
            Address = true,
            City = true,
            Dob = true,
            Email = true,
            FirstName = true,
            LastName = true,
            Phone = true,
            Ssn = true,
            State = true,
            Zip = true,
        };
        List<string> expectedCodes = ["string"];
        ApiEnum<string, Review::KycDecision> expectedDecision = Review::KycDecision.Accept;

        Assert.Equal(expectedValidations, deserialized.Validations);
        Assert.NotNull(deserialized.Codes);
        Assert.Equal(expectedCodes.Count, deserialized.Codes.Count);
        for (int i = 0; i < expectedCodes.Count; i++)
        {
            Assert.Equal(expectedCodes[i], deserialized.Codes[i]);
        }
        Assert.Equal(expectedDecision, deserialized.Decision);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Review::Kyc
        {
            Validations = new()
            {
                Address = true,
                City = true,
                Dob = true,
                Email = true,
                FirstName = true,
                LastName = true,
                Phone = true,
                Ssn = true,
                State = true,
                Zip = true,
            },
            Codes = ["string"],
            Decision = Review::KycDecision.Accept,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::Kyc
        {
            Validations = new()
            {
                Address = true,
                City = true,
                Dob = true,
                Email = true,
                FirstName = true,
                LastName = true,
                Phone = true,
                Ssn = true,
                State = true,
                Zip = true,
            },
            Codes = ["string"],
        };

        Assert.Null(model.Decision);
        Assert.False(model.RawData.ContainsKey("decision"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::Kyc
        {
            Validations = new()
            {
                Address = true,
                City = true,
                Dob = true,
                Email = true,
                FirstName = true,
                LastName = true,
                Phone = true,
                Ssn = true,
                State = true,
                Zip = true,
            },
            Codes = ["string"],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Review::Kyc
        {
            Validations = new()
            {
                Address = true,
                City = true,
                Dob = true,
                Email = true,
                FirstName = true,
                LastName = true,
                Phone = true,
                Ssn = true,
                State = true,
                Zip = true,
            },
            Codes = ["string"],

            // Null should be interpreted as omitted for these properties
            Decision = null,
        };

        Assert.Null(model.Decision);
        Assert.False(model.RawData.ContainsKey("decision"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::Kyc
        {
            Validations = new()
            {
                Address = true,
                City = true,
                Dob = true,
                Email = true,
                FirstName = true,
                LastName = true,
                Phone = true,
                Ssn = true,
                State = true,
                Zip = true,
            },
            Codes = ["string"],

            // Null should be interpreted as omitted for these properties
            Decision = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::Kyc
        {
            Validations = new()
            {
                Address = true,
                City = true,
                Dob = true,
                Email = true,
                FirstName = true,
                LastName = true,
                Phone = true,
                Ssn = true,
                State = true,
                Zip = true,
            },
            Decision = Review::KycDecision.Accept,
        };

        Assert.Null(model.Codes);
        Assert.False(model.RawData.ContainsKey("codes"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::Kyc
        {
            Validations = new()
            {
                Address = true,
                City = true,
                Dob = true,
                Email = true,
                FirstName = true,
                LastName = true,
                Phone = true,
                Ssn = true,
                State = true,
                Zip = true,
            },
            Decision = Review::KycDecision.Accept,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Review::Kyc
        {
            Validations = new()
            {
                Address = true,
                City = true,
                Dob = true,
                Email = true,
                FirstName = true,
                LastName = true,
                Phone = true,
                Ssn = true,
                State = true,
                Zip = true,
            },
            Decision = Review::KycDecision.Accept,

            Codes = null,
        };

        Assert.Null(model.Codes);
        Assert.True(model.RawData.ContainsKey("codes"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::Kyc
        {
            Validations = new()
            {
                Address = true,
                City = true,
                Dob = true,
                Email = true,
                FirstName = true,
                LastName = true,
                Phone = true,
                Ssn = true,
                State = true,
                Zip = true,
            },
            Decision = Review::KycDecision.Accept,

            Codes = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Review::Kyc
        {
            Validations = new()
            {
                Address = true,
                City = true,
                Dob = true,
                Email = true,
                FirstName = true,
                LastName = true,
                Phone = true,
                Ssn = true,
                State = true,
                Zip = true,
            },
            Codes = ["string"],
            Decision = Review::KycDecision.Accept,
        };

        Review::Kyc copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class ValidationsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Review::Validations
        {
            Address = true,
            City = true,
            Dob = true,
            Email = true,
            FirstName = true,
            LastName = true,
            Phone = true,
            Ssn = true,
            State = true,
            Zip = true,
        };

        bool expectedAddress = true;
        bool expectedCity = true;
        bool expectedDob = true;
        bool expectedEmail = true;
        bool expectedFirstName = true;
        bool expectedLastName = true;
        bool expectedPhone = true;
        bool expectedSsn = true;
        bool expectedState = true;
        bool expectedZip = true;

        Assert.Equal(expectedAddress, model.Address);
        Assert.Equal(expectedCity, model.City);
        Assert.Equal(expectedDob, model.Dob);
        Assert.Equal(expectedEmail, model.Email);
        Assert.Equal(expectedFirstName, model.FirstName);
        Assert.Equal(expectedLastName, model.LastName);
        Assert.Equal(expectedPhone, model.Phone);
        Assert.Equal(expectedSsn, model.Ssn);
        Assert.Equal(expectedState, model.State);
        Assert.Equal(expectedZip, model.Zip);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Review::Validations
        {
            Address = true,
            City = true,
            Dob = true,
            Email = true,
            FirstName = true,
            LastName = true,
            Phone = true,
            Ssn = true,
            State = true,
            Zip = true,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Validations>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Review::Validations
        {
            Address = true,
            City = true,
            Dob = true,
            Email = true,
            FirstName = true,
            LastName = true,
            Phone = true,
            Ssn = true,
            State = true,
            Zip = true,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Validations>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        bool expectedAddress = true;
        bool expectedCity = true;
        bool expectedDob = true;
        bool expectedEmail = true;
        bool expectedFirstName = true;
        bool expectedLastName = true;
        bool expectedPhone = true;
        bool expectedSsn = true;
        bool expectedState = true;
        bool expectedZip = true;

        Assert.Equal(expectedAddress, deserialized.Address);
        Assert.Equal(expectedCity, deserialized.City);
        Assert.Equal(expectedDob, deserialized.Dob);
        Assert.Equal(expectedEmail, deserialized.Email);
        Assert.Equal(expectedFirstName, deserialized.FirstName);
        Assert.Equal(expectedLastName, deserialized.LastName);
        Assert.Equal(expectedPhone, deserialized.Phone);
        Assert.Equal(expectedSsn, deserialized.Ssn);
        Assert.Equal(expectedState, deserialized.State);
        Assert.Equal(expectedZip, deserialized.Zip);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Review::Validations
        {
            Address = true,
            City = true,
            Dob = true,
            Email = true,
            FirstName = true,
            LastName = true,
            Phone = true,
            Ssn = true,
            State = true,
            Zip = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::Validations { };

        Assert.Null(model.Address);
        Assert.False(model.RawData.ContainsKey("address"));
        Assert.Null(model.City);
        Assert.False(model.RawData.ContainsKey("city"));
        Assert.Null(model.Dob);
        Assert.False(model.RawData.ContainsKey("dob"));
        Assert.Null(model.Email);
        Assert.False(model.RawData.ContainsKey("email"));
        Assert.Null(model.FirstName);
        Assert.False(model.RawData.ContainsKey("first_name"));
        Assert.Null(model.LastName);
        Assert.False(model.RawData.ContainsKey("last_name"));
        Assert.Null(model.Phone);
        Assert.False(model.RawData.ContainsKey("phone"));
        Assert.Null(model.Ssn);
        Assert.False(model.RawData.ContainsKey("ssn"));
        Assert.Null(model.State);
        Assert.False(model.RawData.ContainsKey("state"));
        Assert.Null(model.Zip);
        Assert.False(model.RawData.ContainsKey("zip"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::Validations { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Review::Validations
        {
            // Null should be interpreted as omitted for these properties
            Address = null,
            City = null,
            Dob = null,
            Email = null,
            FirstName = null,
            LastName = null,
            Phone = null,
            Ssn = null,
            State = null,
            Zip = null,
        };

        Assert.Null(model.Address);
        Assert.False(model.RawData.ContainsKey("address"));
        Assert.Null(model.City);
        Assert.False(model.RawData.ContainsKey("city"));
        Assert.Null(model.Dob);
        Assert.False(model.RawData.ContainsKey("dob"));
        Assert.Null(model.Email);
        Assert.False(model.RawData.ContainsKey("email"));
        Assert.Null(model.FirstName);
        Assert.False(model.RawData.ContainsKey("first_name"));
        Assert.Null(model.LastName);
        Assert.False(model.RawData.ContainsKey("last_name"));
        Assert.Null(model.Phone);
        Assert.False(model.RawData.ContainsKey("phone"));
        Assert.Null(model.Ssn);
        Assert.False(model.RawData.ContainsKey("ssn"));
        Assert.Null(model.State);
        Assert.False(model.RawData.ContainsKey("state"));
        Assert.Null(model.Zip);
        Assert.False(model.RawData.ContainsKey("zip"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::Validations
        {
            // Null should be interpreted as omitted for these properties
            Address = null,
            City = null,
            Dob = null,
            Email = null,
            FirstName = null,
            LastName = null,
            Phone = null,
            Ssn = null,
            State = null,
            Zip = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Review::Validations
        {
            Address = true,
            City = true,
            Dob = true,
            Email = true,
            FirstName = true,
            LastName = true,
            Phone = true,
            Ssn = true,
            State = true,
            Zip = true,
        };

        Review::Validations copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class KycDecisionTest : TestBase
{
    [Theory]
    [InlineData(Review::KycDecision.Accept)]
    [InlineData(Review::KycDecision.Reject)]
    [InlineData(Review::KycDecision.Review)]
    public void Validation_Works(Review::KycDecision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::KycDecision> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::KycDecision>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Review::KycDecision.Accept)]
    [InlineData(Review::KycDecision.Reject)]
    [InlineData(Review::KycDecision.Review)]
    public void SerializationRoundtrip_Works(Review::KycDecision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::KycDecision> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::KycDecision>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::KycDecision>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::KycDecision>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class NetworkAlertsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Review::NetworkAlerts
        {
            Alerts = ["string"],
            Codes = ["string"],
            Decision = Review::NetworkAlertsDecision.Accept,
        };

        List<string> expectedAlerts = ["string"];
        List<string> expectedCodes = ["string"];
        ApiEnum<string, Review::NetworkAlertsDecision> expectedDecision =
            Review::NetworkAlertsDecision.Accept;

        Assert.NotNull(model.Alerts);
        Assert.Equal(expectedAlerts.Count, model.Alerts.Count);
        for (int i = 0; i < expectedAlerts.Count; i++)
        {
            Assert.Equal(expectedAlerts[i], model.Alerts[i]);
        }
        Assert.NotNull(model.Codes);
        Assert.Equal(expectedCodes.Count, model.Codes.Count);
        for (int i = 0; i < expectedCodes.Count; i++)
        {
            Assert.Equal(expectedCodes[i], model.Codes[i]);
        }
        Assert.Equal(expectedDecision, model.Decision);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Review::NetworkAlerts
        {
            Alerts = ["string"],
            Codes = ["string"],
            Decision = Review::NetworkAlertsDecision.Accept,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::NetworkAlerts>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Review::NetworkAlerts
        {
            Alerts = ["string"],
            Codes = ["string"],
            Decision = Review::NetworkAlertsDecision.Accept,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::NetworkAlerts>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<string> expectedAlerts = ["string"];
        List<string> expectedCodes = ["string"];
        ApiEnum<string, Review::NetworkAlertsDecision> expectedDecision =
            Review::NetworkAlertsDecision.Accept;

        Assert.NotNull(deserialized.Alerts);
        Assert.Equal(expectedAlerts.Count, deserialized.Alerts.Count);
        for (int i = 0; i < expectedAlerts.Count; i++)
        {
            Assert.Equal(expectedAlerts[i], deserialized.Alerts[i]);
        }
        Assert.NotNull(deserialized.Codes);
        Assert.Equal(expectedCodes.Count, deserialized.Codes.Count);
        for (int i = 0; i < expectedCodes.Count; i++)
        {
            Assert.Equal(expectedCodes[i], deserialized.Codes[i]);
        }
        Assert.Equal(expectedDecision, deserialized.Decision);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Review::NetworkAlerts
        {
            Alerts = ["string"],
            Codes = ["string"],
            Decision = Review::NetworkAlertsDecision.Accept,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::NetworkAlerts { Alerts = ["string"], Codes = ["string"] };

        Assert.Null(model.Decision);
        Assert.False(model.RawData.ContainsKey("decision"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::NetworkAlerts { Alerts = ["string"], Codes = ["string"] };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Review::NetworkAlerts
        {
            Alerts = ["string"],
            Codes = ["string"],

            // Null should be interpreted as omitted for these properties
            Decision = null,
        };

        Assert.Null(model.Decision);
        Assert.False(model.RawData.ContainsKey("decision"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::NetworkAlerts
        {
            Alerts = ["string"],
            Codes = ["string"],

            // Null should be interpreted as omitted for these properties
            Decision = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::NetworkAlerts { Decision = Review::NetworkAlertsDecision.Accept };

        Assert.Null(model.Alerts);
        Assert.False(model.RawData.ContainsKey("alerts"));
        Assert.Null(model.Codes);
        Assert.False(model.RawData.ContainsKey("codes"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::NetworkAlerts { Decision = Review::NetworkAlertsDecision.Accept };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Review::NetworkAlerts
        {
            Decision = Review::NetworkAlertsDecision.Accept,

            Alerts = null,
            Codes = null,
        };

        Assert.Null(model.Alerts);
        Assert.True(model.RawData.ContainsKey("alerts"));
        Assert.Null(model.Codes);
        Assert.True(model.RawData.ContainsKey("codes"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::NetworkAlerts
        {
            Decision = Review::NetworkAlertsDecision.Accept,

            Alerts = null,
            Codes = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Review::NetworkAlerts
        {
            Alerts = ["string"],
            Codes = ["string"],
            Decision = Review::NetworkAlertsDecision.Accept,
        };

        Review::NetworkAlerts copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class NetworkAlertsDecisionTest : TestBase
{
    [Theory]
    [InlineData(Review::NetworkAlertsDecision.Accept)]
    [InlineData(Review::NetworkAlertsDecision.Reject)]
    [InlineData(Review::NetworkAlertsDecision.Review)]
    public void Validation_Works(Review::NetworkAlertsDecision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::NetworkAlertsDecision> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::NetworkAlertsDecision>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Review::NetworkAlertsDecision.Accept)]
    [InlineData(Review::NetworkAlertsDecision.Reject)]
    [InlineData(Review::NetworkAlertsDecision.Review)]
    public void SerializationRoundtrip_Works(Review::NetworkAlertsDecision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::NetworkAlertsDecision> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, Review::NetworkAlertsDecision>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::NetworkAlertsDecision>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, Review::NetworkAlertsDecision>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class ReputationTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Review::Reputation
        {
            Codes = ["string"],
            Decision = Review::ReputationDecision.Accept,
            Insights = new()
            {
                AccountsActiveCount = 0,
                AccountsClosedCount = 0,
                AccountsClosedDates = ["2019-12-27"],
                AccountsCount = 0,
                AccountsFraudCount = 0,
                AccountsFraudLabeledDates = ["2019-12-27"],
                AccountsFraudLossTotalAmount = 0,
                AchFraudTransactionsCount = 0,
                AchFraudTransactionsDates = ["2019-12-27"],
                AchFraudTransactionsTotalAmount = 0,
                AchReturnedTransactionsCount = 0,
                AchReturnedTransactionsDates = ["2019-12-27"],
                AchReturnedTransactionsTotalAmount = 0,
                ApplicationsApprovedCount = 0,
                ApplicationsCount = 0,
                ApplicationsDates = ["2019-12-27"],
                ApplicationsDeclinedCount = 0,
                ApplicationsFraudCount = 0,
                CardDisputedTransactionsCount = 0,
                CardDisputedTransactionsDates = ["2019-12-27"],
                CardDisputedTransactionsTotalAmount = 0,
                CardFraudTransactionsCount = 0,
                CardFraudTransactionsDates = ["2019-12-27"],
                CardFraudTransactionsTotalAmount = 0,
                CardStoppedTransactionsCount = 0,
                CardStoppedTransactionsDates = ["2019-12-27"],
                UserActiveProfileCount = 0,
                UserAddressCount = 0,
                UserClosedProfileCount = 0,
                UserDobCount = 0,
                UserEmailCount = 0,
                UserInstitutionCount = 0,
                UserMobileCount = 0,
            },
            RiskScore = 0,
        };

        List<string> expectedCodes = ["string"];
        ApiEnum<string, Review::ReputationDecision> expectedDecision =
            Review::ReputationDecision.Accept;
        Review::Insights expectedInsights = new()
        {
            AccountsActiveCount = 0,
            AccountsClosedCount = 0,
            AccountsClosedDates = ["2019-12-27"],
            AccountsCount = 0,
            AccountsFraudCount = 0,
            AccountsFraudLabeledDates = ["2019-12-27"],
            AccountsFraudLossTotalAmount = 0,
            AchFraudTransactionsCount = 0,
            AchFraudTransactionsDates = ["2019-12-27"],
            AchFraudTransactionsTotalAmount = 0,
            AchReturnedTransactionsCount = 0,
            AchReturnedTransactionsDates = ["2019-12-27"],
            AchReturnedTransactionsTotalAmount = 0,
            ApplicationsApprovedCount = 0,
            ApplicationsCount = 0,
            ApplicationsDates = ["2019-12-27"],
            ApplicationsDeclinedCount = 0,
            ApplicationsFraudCount = 0,
            CardDisputedTransactionsCount = 0,
            CardDisputedTransactionsDates = ["2019-12-27"],
            CardDisputedTransactionsTotalAmount = 0,
            CardFraudTransactionsCount = 0,
            CardFraudTransactionsDates = ["2019-12-27"],
            CardFraudTransactionsTotalAmount = 0,
            CardStoppedTransactionsCount = 0,
            CardStoppedTransactionsDates = ["2019-12-27"],
            UserActiveProfileCount = 0,
            UserAddressCount = 0,
            UserClosedProfileCount = 0,
            UserDobCount = 0,
            UserEmailCount = 0,
            UserInstitutionCount = 0,
            UserMobileCount = 0,
        };
        double expectedRiskScore = 0;

        Assert.NotNull(model.Codes);
        Assert.Equal(expectedCodes.Count, model.Codes.Count);
        for (int i = 0; i < expectedCodes.Count; i++)
        {
            Assert.Equal(expectedCodes[i], model.Codes[i]);
        }
        Assert.Equal(expectedDecision, model.Decision);
        Assert.Equal(expectedInsights, model.Insights);
        Assert.Equal(expectedRiskScore, model.RiskScore);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Review::Reputation
        {
            Codes = ["string"],
            Decision = Review::ReputationDecision.Accept,
            Insights = new()
            {
                AccountsActiveCount = 0,
                AccountsClosedCount = 0,
                AccountsClosedDates = ["2019-12-27"],
                AccountsCount = 0,
                AccountsFraudCount = 0,
                AccountsFraudLabeledDates = ["2019-12-27"],
                AccountsFraudLossTotalAmount = 0,
                AchFraudTransactionsCount = 0,
                AchFraudTransactionsDates = ["2019-12-27"],
                AchFraudTransactionsTotalAmount = 0,
                AchReturnedTransactionsCount = 0,
                AchReturnedTransactionsDates = ["2019-12-27"],
                AchReturnedTransactionsTotalAmount = 0,
                ApplicationsApprovedCount = 0,
                ApplicationsCount = 0,
                ApplicationsDates = ["2019-12-27"],
                ApplicationsDeclinedCount = 0,
                ApplicationsFraudCount = 0,
                CardDisputedTransactionsCount = 0,
                CardDisputedTransactionsDates = ["2019-12-27"],
                CardDisputedTransactionsTotalAmount = 0,
                CardFraudTransactionsCount = 0,
                CardFraudTransactionsDates = ["2019-12-27"],
                CardFraudTransactionsTotalAmount = 0,
                CardStoppedTransactionsCount = 0,
                CardStoppedTransactionsDates = ["2019-12-27"],
                UserActiveProfileCount = 0,
                UserAddressCount = 0,
                UserClosedProfileCount = 0,
                UserDobCount = 0,
                UserEmailCount = 0,
                UserInstitutionCount = 0,
                UserMobileCount = 0,
            },
            RiskScore = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Reputation>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Review::Reputation
        {
            Codes = ["string"],
            Decision = Review::ReputationDecision.Accept,
            Insights = new()
            {
                AccountsActiveCount = 0,
                AccountsClosedCount = 0,
                AccountsClosedDates = ["2019-12-27"],
                AccountsCount = 0,
                AccountsFraudCount = 0,
                AccountsFraudLabeledDates = ["2019-12-27"],
                AccountsFraudLossTotalAmount = 0,
                AchFraudTransactionsCount = 0,
                AchFraudTransactionsDates = ["2019-12-27"],
                AchFraudTransactionsTotalAmount = 0,
                AchReturnedTransactionsCount = 0,
                AchReturnedTransactionsDates = ["2019-12-27"],
                AchReturnedTransactionsTotalAmount = 0,
                ApplicationsApprovedCount = 0,
                ApplicationsCount = 0,
                ApplicationsDates = ["2019-12-27"],
                ApplicationsDeclinedCount = 0,
                ApplicationsFraudCount = 0,
                CardDisputedTransactionsCount = 0,
                CardDisputedTransactionsDates = ["2019-12-27"],
                CardDisputedTransactionsTotalAmount = 0,
                CardFraudTransactionsCount = 0,
                CardFraudTransactionsDates = ["2019-12-27"],
                CardFraudTransactionsTotalAmount = 0,
                CardStoppedTransactionsCount = 0,
                CardStoppedTransactionsDates = ["2019-12-27"],
                UserActiveProfileCount = 0,
                UserAddressCount = 0,
                UserClosedProfileCount = 0,
                UserDobCount = 0,
                UserEmailCount = 0,
                UserInstitutionCount = 0,
                UserMobileCount = 0,
            },
            RiskScore = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Reputation>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<string> expectedCodes = ["string"];
        ApiEnum<string, Review::ReputationDecision> expectedDecision =
            Review::ReputationDecision.Accept;
        Review::Insights expectedInsights = new()
        {
            AccountsActiveCount = 0,
            AccountsClosedCount = 0,
            AccountsClosedDates = ["2019-12-27"],
            AccountsCount = 0,
            AccountsFraudCount = 0,
            AccountsFraudLabeledDates = ["2019-12-27"],
            AccountsFraudLossTotalAmount = 0,
            AchFraudTransactionsCount = 0,
            AchFraudTransactionsDates = ["2019-12-27"],
            AchFraudTransactionsTotalAmount = 0,
            AchReturnedTransactionsCount = 0,
            AchReturnedTransactionsDates = ["2019-12-27"],
            AchReturnedTransactionsTotalAmount = 0,
            ApplicationsApprovedCount = 0,
            ApplicationsCount = 0,
            ApplicationsDates = ["2019-12-27"],
            ApplicationsDeclinedCount = 0,
            ApplicationsFraudCount = 0,
            CardDisputedTransactionsCount = 0,
            CardDisputedTransactionsDates = ["2019-12-27"],
            CardDisputedTransactionsTotalAmount = 0,
            CardFraudTransactionsCount = 0,
            CardFraudTransactionsDates = ["2019-12-27"],
            CardFraudTransactionsTotalAmount = 0,
            CardStoppedTransactionsCount = 0,
            CardStoppedTransactionsDates = ["2019-12-27"],
            UserActiveProfileCount = 0,
            UserAddressCount = 0,
            UserClosedProfileCount = 0,
            UserDobCount = 0,
            UserEmailCount = 0,
            UserInstitutionCount = 0,
            UserMobileCount = 0,
        };
        double expectedRiskScore = 0;

        Assert.NotNull(deserialized.Codes);
        Assert.Equal(expectedCodes.Count, deserialized.Codes.Count);
        for (int i = 0; i < expectedCodes.Count; i++)
        {
            Assert.Equal(expectedCodes[i], deserialized.Codes[i]);
        }
        Assert.Equal(expectedDecision, deserialized.Decision);
        Assert.Equal(expectedInsights, deserialized.Insights);
        Assert.Equal(expectedRiskScore, deserialized.RiskScore);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Review::Reputation
        {
            Codes = ["string"],
            Decision = Review::ReputationDecision.Accept,
            Insights = new()
            {
                AccountsActiveCount = 0,
                AccountsClosedCount = 0,
                AccountsClosedDates = ["2019-12-27"],
                AccountsCount = 0,
                AccountsFraudCount = 0,
                AccountsFraudLabeledDates = ["2019-12-27"],
                AccountsFraudLossTotalAmount = 0,
                AchFraudTransactionsCount = 0,
                AchFraudTransactionsDates = ["2019-12-27"],
                AchFraudTransactionsTotalAmount = 0,
                AchReturnedTransactionsCount = 0,
                AchReturnedTransactionsDates = ["2019-12-27"],
                AchReturnedTransactionsTotalAmount = 0,
                ApplicationsApprovedCount = 0,
                ApplicationsCount = 0,
                ApplicationsDates = ["2019-12-27"],
                ApplicationsDeclinedCount = 0,
                ApplicationsFraudCount = 0,
                CardDisputedTransactionsCount = 0,
                CardDisputedTransactionsDates = ["2019-12-27"],
                CardDisputedTransactionsTotalAmount = 0,
                CardFraudTransactionsCount = 0,
                CardFraudTransactionsDates = ["2019-12-27"],
                CardFraudTransactionsTotalAmount = 0,
                CardStoppedTransactionsCount = 0,
                CardStoppedTransactionsDates = ["2019-12-27"],
                UserActiveProfileCount = 0,
                UserAddressCount = 0,
                UserClosedProfileCount = 0,
                UserDobCount = 0,
                UserEmailCount = 0,
                UserInstitutionCount = 0,
                UserMobileCount = 0,
            },
            RiskScore = 0,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::Reputation { Codes = ["string"], RiskScore = 0 };

        Assert.Null(model.Decision);
        Assert.False(model.RawData.ContainsKey("decision"));
        Assert.Null(model.Insights);
        Assert.False(model.RawData.ContainsKey("insights"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::Reputation { Codes = ["string"], RiskScore = 0 };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Review::Reputation
        {
            Codes = ["string"],
            RiskScore = 0,

            // Null should be interpreted as omitted for these properties
            Decision = null,
            Insights = null,
        };

        Assert.Null(model.Decision);
        Assert.False(model.RawData.ContainsKey("decision"));
        Assert.Null(model.Insights);
        Assert.False(model.RawData.ContainsKey("insights"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::Reputation
        {
            Codes = ["string"],
            RiskScore = 0,

            // Null should be interpreted as omitted for these properties
            Decision = null,
            Insights = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::Reputation
        {
            Decision = Review::ReputationDecision.Accept,
            Insights = new()
            {
                AccountsActiveCount = 0,
                AccountsClosedCount = 0,
                AccountsClosedDates = ["2019-12-27"],
                AccountsCount = 0,
                AccountsFraudCount = 0,
                AccountsFraudLabeledDates = ["2019-12-27"],
                AccountsFraudLossTotalAmount = 0,
                AchFraudTransactionsCount = 0,
                AchFraudTransactionsDates = ["2019-12-27"],
                AchFraudTransactionsTotalAmount = 0,
                AchReturnedTransactionsCount = 0,
                AchReturnedTransactionsDates = ["2019-12-27"],
                AchReturnedTransactionsTotalAmount = 0,
                ApplicationsApprovedCount = 0,
                ApplicationsCount = 0,
                ApplicationsDates = ["2019-12-27"],
                ApplicationsDeclinedCount = 0,
                ApplicationsFraudCount = 0,
                CardDisputedTransactionsCount = 0,
                CardDisputedTransactionsDates = ["2019-12-27"],
                CardDisputedTransactionsTotalAmount = 0,
                CardFraudTransactionsCount = 0,
                CardFraudTransactionsDates = ["2019-12-27"],
                CardFraudTransactionsTotalAmount = 0,
                CardStoppedTransactionsCount = 0,
                CardStoppedTransactionsDates = ["2019-12-27"],
                UserActiveProfileCount = 0,
                UserAddressCount = 0,
                UserClosedProfileCount = 0,
                UserDobCount = 0,
                UserEmailCount = 0,
                UserInstitutionCount = 0,
                UserMobileCount = 0,
            },
        };

        Assert.Null(model.Codes);
        Assert.False(model.RawData.ContainsKey("codes"));
        Assert.Null(model.RiskScore);
        Assert.False(model.RawData.ContainsKey("risk_score"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::Reputation
        {
            Decision = Review::ReputationDecision.Accept,
            Insights = new()
            {
                AccountsActiveCount = 0,
                AccountsClosedCount = 0,
                AccountsClosedDates = ["2019-12-27"],
                AccountsCount = 0,
                AccountsFraudCount = 0,
                AccountsFraudLabeledDates = ["2019-12-27"],
                AccountsFraudLossTotalAmount = 0,
                AchFraudTransactionsCount = 0,
                AchFraudTransactionsDates = ["2019-12-27"],
                AchFraudTransactionsTotalAmount = 0,
                AchReturnedTransactionsCount = 0,
                AchReturnedTransactionsDates = ["2019-12-27"],
                AchReturnedTransactionsTotalAmount = 0,
                ApplicationsApprovedCount = 0,
                ApplicationsCount = 0,
                ApplicationsDates = ["2019-12-27"],
                ApplicationsDeclinedCount = 0,
                ApplicationsFraudCount = 0,
                CardDisputedTransactionsCount = 0,
                CardDisputedTransactionsDates = ["2019-12-27"],
                CardDisputedTransactionsTotalAmount = 0,
                CardFraudTransactionsCount = 0,
                CardFraudTransactionsDates = ["2019-12-27"],
                CardFraudTransactionsTotalAmount = 0,
                CardStoppedTransactionsCount = 0,
                CardStoppedTransactionsDates = ["2019-12-27"],
                UserActiveProfileCount = 0,
                UserAddressCount = 0,
                UserClosedProfileCount = 0,
                UserDobCount = 0,
                UserEmailCount = 0,
                UserInstitutionCount = 0,
                UserMobileCount = 0,
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Review::Reputation
        {
            Decision = Review::ReputationDecision.Accept,
            Insights = new()
            {
                AccountsActiveCount = 0,
                AccountsClosedCount = 0,
                AccountsClosedDates = ["2019-12-27"],
                AccountsCount = 0,
                AccountsFraudCount = 0,
                AccountsFraudLabeledDates = ["2019-12-27"],
                AccountsFraudLossTotalAmount = 0,
                AchFraudTransactionsCount = 0,
                AchFraudTransactionsDates = ["2019-12-27"],
                AchFraudTransactionsTotalAmount = 0,
                AchReturnedTransactionsCount = 0,
                AchReturnedTransactionsDates = ["2019-12-27"],
                AchReturnedTransactionsTotalAmount = 0,
                ApplicationsApprovedCount = 0,
                ApplicationsCount = 0,
                ApplicationsDates = ["2019-12-27"],
                ApplicationsDeclinedCount = 0,
                ApplicationsFraudCount = 0,
                CardDisputedTransactionsCount = 0,
                CardDisputedTransactionsDates = ["2019-12-27"],
                CardDisputedTransactionsTotalAmount = 0,
                CardFraudTransactionsCount = 0,
                CardFraudTransactionsDates = ["2019-12-27"],
                CardFraudTransactionsTotalAmount = 0,
                CardStoppedTransactionsCount = 0,
                CardStoppedTransactionsDates = ["2019-12-27"],
                UserActiveProfileCount = 0,
                UserAddressCount = 0,
                UserClosedProfileCount = 0,
                UserDobCount = 0,
                UserEmailCount = 0,
                UserInstitutionCount = 0,
                UserMobileCount = 0,
            },

            Codes = null,
            RiskScore = null,
        };

        Assert.Null(model.Codes);
        Assert.True(model.RawData.ContainsKey("codes"));
        Assert.Null(model.RiskScore);
        Assert.True(model.RawData.ContainsKey("risk_score"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::Reputation
        {
            Decision = Review::ReputationDecision.Accept,
            Insights = new()
            {
                AccountsActiveCount = 0,
                AccountsClosedCount = 0,
                AccountsClosedDates = ["2019-12-27"],
                AccountsCount = 0,
                AccountsFraudCount = 0,
                AccountsFraudLabeledDates = ["2019-12-27"],
                AccountsFraudLossTotalAmount = 0,
                AchFraudTransactionsCount = 0,
                AchFraudTransactionsDates = ["2019-12-27"],
                AchFraudTransactionsTotalAmount = 0,
                AchReturnedTransactionsCount = 0,
                AchReturnedTransactionsDates = ["2019-12-27"],
                AchReturnedTransactionsTotalAmount = 0,
                ApplicationsApprovedCount = 0,
                ApplicationsCount = 0,
                ApplicationsDates = ["2019-12-27"],
                ApplicationsDeclinedCount = 0,
                ApplicationsFraudCount = 0,
                CardDisputedTransactionsCount = 0,
                CardDisputedTransactionsDates = ["2019-12-27"],
                CardDisputedTransactionsTotalAmount = 0,
                CardFraudTransactionsCount = 0,
                CardFraudTransactionsDates = ["2019-12-27"],
                CardFraudTransactionsTotalAmount = 0,
                CardStoppedTransactionsCount = 0,
                CardStoppedTransactionsDates = ["2019-12-27"],
                UserActiveProfileCount = 0,
                UserAddressCount = 0,
                UserClosedProfileCount = 0,
                UserDobCount = 0,
                UserEmailCount = 0,
                UserInstitutionCount = 0,
                UserMobileCount = 0,
            },

            Codes = null,
            RiskScore = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Review::Reputation
        {
            Codes = ["string"],
            Decision = Review::ReputationDecision.Accept,
            Insights = new()
            {
                AccountsActiveCount = 0,
                AccountsClosedCount = 0,
                AccountsClosedDates = ["2019-12-27"],
                AccountsCount = 0,
                AccountsFraudCount = 0,
                AccountsFraudLabeledDates = ["2019-12-27"],
                AccountsFraudLossTotalAmount = 0,
                AchFraudTransactionsCount = 0,
                AchFraudTransactionsDates = ["2019-12-27"],
                AchFraudTransactionsTotalAmount = 0,
                AchReturnedTransactionsCount = 0,
                AchReturnedTransactionsDates = ["2019-12-27"],
                AchReturnedTransactionsTotalAmount = 0,
                ApplicationsApprovedCount = 0,
                ApplicationsCount = 0,
                ApplicationsDates = ["2019-12-27"],
                ApplicationsDeclinedCount = 0,
                ApplicationsFraudCount = 0,
                CardDisputedTransactionsCount = 0,
                CardDisputedTransactionsDates = ["2019-12-27"],
                CardDisputedTransactionsTotalAmount = 0,
                CardFraudTransactionsCount = 0,
                CardFraudTransactionsDates = ["2019-12-27"],
                CardFraudTransactionsTotalAmount = 0,
                CardStoppedTransactionsCount = 0,
                CardStoppedTransactionsDates = ["2019-12-27"],
                UserActiveProfileCount = 0,
                UserAddressCount = 0,
                UserClosedProfileCount = 0,
                UserDobCount = 0,
                UserEmailCount = 0,
                UserInstitutionCount = 0,
                UserMobileCount = 0,
            },
            RiskScore = 0,
        };

        Review::Reputation copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class ReputationDecisionTest : TestBase
{
    [Theory]
    [InlineData(Review::ReputationDecision.Accept)]
    [InlineData(Review::ReputationDecision.Reject)]
    [InlineData(Review::ReputationDecision.Review)]
    public void Validation_Works(Review::ReputationDecision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::ReputationDecision> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::ReputationDecision>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Review::ReputationDecision.Accept)]
    [InlineData(Review::ReputationDecision.Reject)]
    [InlineData(Review::ReputationDecision.Review)]
    public void SerializationRoundtrip_Works(Review::ReputationDecision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::ReputationDecision> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::ReputationDecision>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::ReputationDecision>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::ReputationDecision>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class InsightsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Review::Insights
        {
            AccountsActiveCount = 0,
            AccountsClosedCount = 0,
            AccountsClosedDates = ["2019-12-27"],
            AccountsCount = 0,
            AccountsFraudCount = 0,
            AccountsFraudLabeledDates = ["2019-12-27"],
            AccountsFraudLossTotalAmount = 0,
            AchFraudTransactionsCount = 0,
            AchFraudTransactionsDates = ["2019-12-27"],
            AchFraudTransactionsTotalAmount = 0,
            AchReturnedTransactionsCount = 0,
            AchReturnedTransactionsDates = ["2019-12-27"],
            AchReturnedTransactionsTotalAmount = 0,
            ApplicationsApprovedCount = 0,
            ApplicationsCount = 0,
            ApplicationsDates = ["2019-12-27"],
            ApplicationsDeclinedCount = 0,
            ApplicationsFraudCount = 0,
            CardDisputedTransactionsCount = 0,
            CardDisputedTransactionsDates = ["2019-12-27"],
            CardDisputedTransactionsTotalAmount = 0,
            CardFraudTransactionsCount = 0,
            CardFraudTransactionsDates = ["2019-12-27"],
            CardFraudTransactionsTotalAmount = 0,
            CardStoppedTransactionsCount = 0,
            CardStoppedTransactionsDates = ["2019-12-27"],
            UserActiveProfileCount = 0,
            UserAddressCount = 0,
            UserClosedProfileCount = 0,
            UserDobCount = 0,
            UserEmailCount = 0,
            UserInstitutionCount = 0,
            UserMobileCount = 0,
        };

        int expectedAccountsActiveCount = 0;
        int expectedAccountsClosedCount = 0;
        List<string> expectedAccountsClosedDates = ["2019-12-27"];
        int expectedAccountsCount = 0;
        int expectedAccountsFraudCount = 0;
        List<string> expectedAccountsFraudLabeledDates = ["2019-12-27"];
        double expectedAccountsFraudLossTotalAmount = 0;
        int expectedAchFraudTransactionsCount = 0;
        List<string> expectedAchFraudTransactionsDates = ["2019-12-27"];
        double expectedAchFraudTransactionsTotalAmount = 0;
        int expectedAchReturnedTransactionsCount = 0;
        List<string> expectedAchReturnedTransactionsDates = ["2019-12-27"];
        double expectedAchReturnedTransactionsTotalAmount = 0;
        int expectedApplicationsApprovedCount = 0;
        int expectedApplicationsCount = 0;
        List<string> expectedApplicationsDates = ["2019-12-27"];
        int expectedApplicationsDeclinedCount = 0;
        int expectedApplicationsFraudCount = 0;
        int expectedCardDisputedTransactionsCount = 0;
        List<string> expectedCardDisputedTransactionsDates = ["2019-12-27"];
        double expectedCardDisputedTransactionsTotalAmount = 0;
        int expectedCardFraudTransactionsCount = 0;
        List<string> expectedCardFraudTransactionsDates = ["2019-12-27"];
        double expectedCardFraudTransactionsTotalAmount = 0;
        int expectedCardStoppedTransactionsCount = 0;
        List<string> expectedCardStoppedTransactionsDates = ["2019-12-27"];
        int expectedUserActiveProfileCount = 0;
        int expectedUserAddressCount = 0;
        int expectedUserClosedProfileCount = 0;
        int expectedUserDobCount = 0;
        int expectedUserEmailCount = 0;
        int expectedUserInstitutionCount = 0;
        int expectedUserMobileCount = 0;

        Assert.Equal(expectedAccountsActiveCount, model.AccountsActiveCount);
        Assert.Equal(expectedAccountsClosedCount, model.AccountsClosedCount);
        Assert.NotNull(model.AccountsClosedDates);
        Assert.Equal(expectedAccountsClosedDates.Count, model.AccountsClosedDates.Count);
        for (int i = 0; i < expectedAccountsClosedDates.Count; i++)
        {
            Assert.Equal(expectedAccountsClosedDates[i], model.AccountsClosedDates[i]);
        }
        Assert.Equal(expectedAccountsCount, model.AccountsCount);
        Assert.Equal(expectedAccountsFraudCount, model.AccountsFraudCount);
        Assert.NotNull(model.AccountsFraudLabeledDates);
        Assert.Equal(
            expectedAccountsFraudLabeledDates.Count,
            model.AccountsFraudLabeledDates.Count
        );
        for (int i = 0; i < expectedAccountsFraudLabeledDates.Count; i++)
        {
            Assert.Equal(expectedAccountsFraudLabeledDates[i], model.AccountsFraudLabeledDates[i]);
        }
        Assert.Equal(expectedAccountsFraudLossTotalAmount, model.AccountsFraudLossTotalAmount);
        Assert.Equal(expectedAchFraudTransactionsCount, model.AchFraudTransactionsCount);
        Assert.NotNull(model.AchFraudTransactionsDates);
        Assert.Equal(
            expectedAchFraudTransactionsDates.Count,
            model.AchFraudTransactionsDates.Count
        );
        for (int i = 0; i < expectedAchFraudTransactionsDates.Count; i++)
        {
            Assert.Equal(expectedAchFraudTransactionsDates[i], model.AchFraudTransactionsDates[i]);
        }
        Assert.Equal(
            expectedAchFraudTransactionsTotalAmount,
            model.AchFraudTransactionsTotalAmount
        );
        Assert.Equal(expectedAchReturnedTransactionsCount, model.AchReturnedTransactionsCount);
        Assert.NotNull(model.AchReturnedTransactionsDates);
        Assert.Equal(
            expectedAchReturnedTransactionsDates.Count,
            model.AchReturnedTransactionsDates.Count
        );
        for (int i = 0; i < expectedAchReturnedTransactionsDates.Count; i++)
        {
            Assert.Equal(
                expectedAchReturnedTransactionsDates[i],
                model.AchReturnedTransactionsDates[i]
            );
        }
        Assert.Equal(
            expectedAchReturnedTransactionsTotalAmount,
            model.AchReturnedTransactionsTotalAmount
        );
        Assert.Equal(expectedApplicationsApprovedCount, model.ApplicationsApprovedCount);
        Assert.Equal(expectedApplicationsCount, model.ApplicationsCount);
        Assert.NotNull(model.ApplicationsDates);
        Assert.Equal(expectedApplicationsDates.Count, model.ApplicationsDates.Count);
        for (int i = 0; i < expectedApplicationsDates.Count; i++)
        {
            Assert.Equal(expectedApplicationsDates[i], model.ApplicationsDates[i]);
        }
        Assert.Equal(expectedApplicationsDeclinedCount, model.ApplicationsDeclinedCount);
        Assert.Equal(expectedApplicationsFraudCount, model.ApplicationsFraudCount);
        Assert.Equal(expectedCardDisputedTransactionsCount, model.CardDisputedTransactionsCount);
        Assert.NotNull(model.CardDisputedTransactionsDates);
        Assert.Equal(
            expectedCardDisputedTransactionsDates.Count,
            model.CardDisputedTransactionsDates.Count
        );
        for (int i = 0; i < expectedCardDisputedTransactionsDates.Count; i++)
        {
            Assert.Equal(
                expectedCardDisputedTransactionsDates[i],
                model.CardDisputedTransactionsDates[i]
            );
        }
        Assert.Equal(
            expectedCardDisputedTransactionsTotalAmount,
            model.CardDisputedTransactionsTotalAmount
        );
        Assert.Equal(expectedCardFraudTransactionsCount, model.CardFraudTransactionsCount);
        Assert.NotNull(model.CardFraudTransactionsDates);
        Assert.Equal(
            expectedCardFraudTransactionsDates.Count,
            model.CardFraudTransactionsDates.Count
        );
        for (int i = 0; i < expectedCardFraudTransactionsDates.Count; i++)
        {
            Assert.Equal(
                expectedCardFraudTransactionsDates[i],
                model.CardFraudTransactionsDates[i]
            );
        }
        Assert.Equal(
            expectedCardFraudTransactionsTotalAmount,
            model.CardFraudTransactionsTotalAmount
        );
        Assert.Equal(expectedCardStoppedTransactionsCount, model.CardStoppedTransactionsCount);
        Assert.NotNull(model.CardStoppedTransactionsDates);
        Assert.Equal(
            expectedCardStoppedTransactionsDates.Count,
            model.CardStoppedTransactionsDates.Count
        );
        for (int i = 0; i < expectedCardStoppedTransactionsDates.Count; i++)
        {
            Assert.Equal(
                expectedCardStoppedTransactionsDates[i],
                model.CardStoppedTransactionsDates[i]
            );
        }
        Assert.Equal(expectedUserActiveProfileCount, model.UserActiveProfileCount);
        Assert.Equal(expectedUserAddressCount, model.UserAddressCount);
        Assert.Equal(expectedUserClosedProfileCount, model.UserClosedProfileCount);
        Assert.Equal(expectedUserDobCount, model.UserDobCount);
        Assert.Equal(expectedUserEmailCount, model.UserEmailCount);
        Assert.Equal(expectedUserInstitutionCount, model.UserInstitutionCount);
        Assert.Equal(expectedUserMobileCount, model.UserMobileCount);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Review::Insights
        {
            AccountsActiveCount = 0,
            AccountsClosedCount = 0,
            AccountsClosedDates = ["2019-12-27"],
            AccountsCount = 0,
            AccountsFraudCount = 0,
            AccountsFraudLabeledDates = ["2019-12-27"],
            AccountsFraudLossTotalAmount = 0,
            AchFraudTransactionsCount = 0,
            AchFraudTransactionsDates = ["2019-12-27"],
            AchFraudTransactionsTotalAmount = 0,
            AchReturnedTransactionsCount = 0,
            AchReturnedTransactionsDates = ["2019-12-27"],
            AchReturnedTransactionsTotalAmount = 0,
            ApplicationsApprovedCount = 0,
            ApplicationsCount = 0,
            ApplicationsDates = ["2019-12-27"],
            ApplicationsDeclinedCount = 0,
            ApplicationsFraudCount = 0,
            CardDisputedTransactionsCount = 0,
            CardDisputedTransactionsDates = ["2019-12-27"],
            CardDisputedTransactionsTotalAmount = 0,
            CardFraudTransactionsCount = 0,
            CardFraudTransactionsDates = ["2019-12-27"],
            CardFraudTransactionsTotalAmount = 0,
            CardStoppedTransactionsCount = 0,
            CardStoppedTransactionsDates = ["2019-12-27"],
            UserActiveProfileCount = 0,
            UserAddressCount = 0,
            UserClosedProfileCount = 0,
            UserDobCount = 0,
            UserEmailCount = 0,
            UserInstitutionCount = 0,
            UserMobileCount = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Insights>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Review::Insights
        {
            AccountsActiveCount = 0,
            AccountsClosedCount = 0,
            AccountsClosedDates = ["2019-12-27"],
            AccountsCount = 0,
            AccountsFraudCount = 0,
            AccountsFraudLabeledDates = ["2019-12-27"],
            AccountsFraudLossTotalAmount = 0,
            AchFraudTransactionsCount = 0,
            AchFraudTransactionsDates = ["2019-12-27"],
            AchFraudTransactionsTotalAmount = 0,
            AchReturnedTransactionsCount = 0,
            AchReturnedTransactionsDates = ["2019-12-27"],
            AchReturnedTransactionsTotalAmount = 0,
            ApplicationsApprovedCount = 0,
            ApplicationsCount = 0,
            ApplicationsDates = ["2019-12-27"],
            ApplicationsDeclinedCount = 0,
            ApplicationsFraudCount = 0,
            CardDisputedTransactionsCount = 0,
            CardDisputedTransactionsDates = ["2019-12-27"],
            CardDisputedTransactionsTotalAmount = 0,
            CardFraudTransactionsCount = 0,
            CardFraudTransactionsDates = ["2019-12-27"],
            CardFraudTransactionsTotalAmount = 0,
            CardStoppedTransactionsCount = 0,
            CardStoppedTransactionsDates = ["2019-12-27"],
            UserActiveProfileCount = 0,
            UserAddressCount = 0,
            UserClosedProfileCount = 0,
            UserDobCount = 0,
            UserEmailCount = 0,
            UserInstitutionCount = 0,
            UserMobileCount = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Insights>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        int expectedAccountsActiveCount = 0;
        int expectedAccountsClosedCount = 0;
        List<string> expectedAccountsClosedDates = ["2019-12-27"];
        int expectedAccountsCount = 0;
        int expectedAccountsFraudCount = 0;
        List<string> expectedAccountsFraudLabeledDates = ["2019-12-27"];
        double expectedAccountsFraudLossTotalAmount = 0;
        int expectedAchFraudTransactionsCount = 0;
        List<string> expectedAchFraudTransactionsDates = ["2019-12-27"];
        double expectedAchFraudTransactionsTotalAmount = 0;
        int expectedAchReturnedTransactionsCount = 0;
        List<string> expectedAchReturnedTransactionsDates = ["2019-12-27"];
        double expectedAchReturnedTransactionsTotalAmount = 0;
        int expectedApplicationsApprovedCount = 0;
        int expectedApplicationsCount = 0;
        List<string> expectedApplicationsDates = ["2019-12-27"];
        int expectedApplicationsDeclinedCount = 0;
        int expectedApplicationsFraudCount = 0;
        int expectedCardDisputedTransactionsCount = 0;
        List<string> expectedCardDisputedTransactionsDates = ["2019-12-27"];
        double expectedCardDisputedTransactionsTotalAmount = 0;
        int expectedCardFraudTransactionsCount = 0;
        List<string> expectedCardFraudTransactionsDates = ["2019-12-27"];
        double expectedCardFraudTransactionsTotalAmount = 0;
        int expectedCardStoppedTransactionsCount = 0;
        List<string> expectedCardStoppedTransactionsDates = ["2019-12-27"];
        int expectedUserActiveProfileCount = 0;
        int expectedUserAddressCount = 0;
        int expectedUserClosedProfileCount = 0;
        int expectedUserDobCount = 0;
        int expectedUserEmailCount = 0;
        int expectedUserInstitutionCount = 0;
        int expectedUserMobileCount = 0;

        Assert.Equal(expectedAccountsActiveCount, deserialized.AccountsActiveCount);
        Assert.Equal(expectedAccountsClosedCount, deserialized.AccountsClosedCount);
        Assert.NotNull(deserialized.AccountsClosedDates);
        Assert.Equal(expectedAccountsClosedDates.Count, deserialized.AccountsClosedDates.Count);
        for (int i = 0; i < expectedAccountsClosedDates.Count; i++)
        {
            Assert.Equal(expectedAccountsClosedDates[i], deserialized.AccountsClosedDates[i]);
        }
        Assert.Equal(expectedAccountsCount, deserialized.AccountsCount);
        Assert.Equal(expectedAccountsFraudCount, deserialized.AccountsFraudCount);
        Assert.NotNull(deserialized.AccountsFraudLabeledDates);
        Assert.Equal(
            expectedAccountsFraudLabeledDates.Count,
            deserialized.AccountsFraudLabeledDates.Count
        );
        for (int i = 0; i < expectedAccountsFraudLabeledDates.Count; i++)
        {
            Assert.Equal(
                expectedAccountsFraudLabeledDates[i],
                deserialized.AccountsFraudLabeledDates[i]
            );
        }
        Assert.Equal(
            expectedAccountsFraudLossTotalAmount,
            deserialized.AccountsFraudLossTotalAmount
        );
        Assert.Equal(expectedAchFraudTransactionsCount, deserialized.AchFraudTransactionsCount);
        Assert.NotNull(deserialized.AchFraudTransactionsDates);
        Assert.Equal(
            expectedAchFraudTransactionsDates.Count,
            deserialized.AchFraudTransactionsDates.Count
        );
        for (int i = 0; i < expectedAchFraudTransactionsDates.Count; i++)
        {
            Assert.Equal(
                expectedAchFraudTransactionsDates[i],
                deserialized.AchFraudTransactionsDates[i]
            );
        }
        Assert.Equal(
            expectedAchFraudTransactionsTotalAmount,
            deserialized.AchFraudTransactionsTotalAmount
        );
        Assert.Equal(
            expectedAchReturnedTransactionsCount,
            deserialized.AchReturnedTransactionsCount
        );
        Assert.NotNull(deserialized.AchReturnedTransactionsDates);
        Assert.Equal(
            expectedAchReturnedTransactionsDates.Count,
            deserialized.AchReturnedTransactionsDates.Count
        );
        for (int i = 0; i < expectedAchReturnedTransactionsDates.Count; i++)
        {
            Assert.Equal(
                expectedAchReturnedTransactionsDates[i],
                deserialized.AchReturnedTransactionsDates[i]
            );
        }
        Assert.Equal(
            expectedAchReturnedTransactionsTotalAmount,
            deserialized.AchReturnedTransactionsTotalAmount
        );
        Assert.Equal(expectedApplicationsApprovedCount, deserialized.ApplicationsApprovedCount);
        Assert.Equal(expectedApplicationsCount, deserialized.ApplicationsCount);
        Assert.NotNull(deserialized.ApplicationsDates);
        Assert.Equal(expectedApplicationsDates.Count, deserialized.ApplicationsDates.Count);
        for (int i = 0; i < expectedApplicationsDates.Count; i++)
        {
            Assert.Equal(expectedApplicationsDates[i], deserialized.ApplicationsDates[i]);
        }
        Assert.Equal(expectedApplicationsDeclinedCount, deserialized.ApplicationsDeclinedCount);
        Assert.Equal(expectedApplicationsFraudCount, deserialized.ApplicationsFraudCount);
        Assert.Equal(
            expectedCardDisputedTransactionsCount,
            deserialized.CardDisputedTransactionsCount
        );
        Assert.NotNull(deserialized.CardDisputedTransactionsDates);
        Assert.Equal(
            expectedCardDisputedTransactionsDates.Count,
            deserialized.CardDisputedTransactionsDates.Count
        );
        for (int i = 0; i < expectedCardDisputedTransactionsDates.Count; i++)
        {
            Assert.Equal(
                expectedCardDisputedTransactionsDates[i],
                deserialized.CardDisputedTransactionsDates[i]
            );
        }
        Assert.Equal(
            expectedCardDisputedTransactionsTotalAmount,
            deserialized.CardDisputedTransactionsTotalAmount
        );
        Assert.Equal(expectedCardFraudTransactionsCount, deserialized.CardFraudTransactionsCount);
        Assert.NotNull(deserialized.CardFraudTransactionsDates);
        Assert.Equal(
            expectedCardFraudTransactionsDates.Count,
            deserialized.CardFraudTransactionsDates.Count
        );
        for (int i = 0; i < expectedCardFraudTransactionsDates.Count; i++)
        {
            Assert.Equal(
                expectedCardFraudTransactionsDates[i],
                deserialized.CardFraudTransactionsDates[i]
            );
        }
        Assert.Equal(
            expectedCardFraudTransactionsTotalAmount,
            deserialized.CardFraudTransactionsTotalAmount
        );
        Assert.Equal(
            expectedCardStoppedTransactionsCount,
            deserialized.CardStoppedTransactionsCount
        );
        Assert.NotNull(deserialized.CardStoppedTransactionsDates);
        Assert.Equal(
            expectedCardStoppedTransactionsDates.Count,
            deserialized.CardStoppedTransactionsDates.Count
        );
        for (int i = 0; i < expectedCardStoppedTransactionsDates.Count; i++)
        {
            Assert.Equal(
                expectedCardStoppedTransactionsDates[i],
                deserialized.CardStoppedTransactionsDates[i]
            );
        }
        Assert.Equal(expectedUserActiveProfileCount, deserialized.UserActiveProfileCount);
        Assert.Equal(expectedUserAddressCount, deserialized.UserAddressCount);
        Assert.Equal(expectedUserClosedProfileCount, deserialized.UserClosedProfileCount);
        Assert.Equal(expectedUserDobCount, deserialized.UserDobCount);
        Assert.Equal(expectedUserEmailCount, deserialized.UserEmailCount);
        Assert.Equal(expectedUserInstitutionCount, deserialized.UserInstitutionCount);
        Assert.Equal(expectedUserMobileCount, deserialized.UserMobileCount);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Review::Insights
        {
            AccountsActiveCount = 0,
            AccountsClosedCount = 0,
            AccountsClosedDates = ["2019-12-27"],
            AccountsCount = 0,
            AccountsFraudCount = 0,
            AccountsFraudLabeledDates = ["2019-12-27"],
            AccountsFraudLossTotalAmount = 0,
            AchFraudTransactionsCount = 0,
            AchFraudTransactionsDates = ["2019-12-27"],
            AchFraudTransactionsTotalAmount = 0,
            AchReturnedTransactionsCount = 0,
            AchReturnedTransactionsDates = ["2019-12-27"],
            AchReturnedTransactionsTotalAmount = 0,
            ApplicationsApprovedCount = 0,
            ApplicationsCount = 0,
            ApplicationsDates = ["2019-12-27"],
            ApplicationsDeclinedCount = 0,
            ApplicationsFraudCount = 0,
            CardDisputedTransactionsCount = 0,
            CardDisputedTransactionsDates = ["2019-12-27"],
            CardDisputedTransactionsTotalAmount = 0,
            CardFraudTransactionsCount = 0,
            CardFraudTransactionsDates = ["2019-12-27"],
            CardFraudTransactionsTotalAmount = 0,
            CardStoppedTransactionsCount = 0,
            CardStoppedTransactionsDates = ["2019-12-27"],
            UserActiveProfileCount = 0,
            UserAddressCount = 0,
            UserClosedProfileCount = 0,
            UserDobCount = 0,
            UserEmailCount = 0,
            UserInstitutionCount = 0,
            UserMobileCount = 0,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::Insights { };

        Assert.Null(model.AccountsActiveCount);
        Assert.False(model.RawData.ContainsKey("accounts_active_count"));
        Assert.Null(model.AccountsClosedCount);
        Assert.False(model.RawData.ContainsKey("accounts_closed_count"));
        Assert.Null(model.AccountsClosedDates);
        Assert.False(model.RawData.ContainsKey("accounts_closed_dates"));
        Assert.Null(model.AccountsCount);
        Assert.False(model.RawData.ContainsKey("accounts_count"));
        Assert.Null(model.AccountsFraudCount);
        Assert.False(model.RawData.ContainsKey("accounts_fraud_count"));
        Assert.Null(model.AccountsFraudLabeledDates);
        Assert.False(model.RawData.ContainsKey("accounts_fraud_labeled_dates"));
        Assert.Null(model.AccountsFraudLossTotalAmount);
        Assert.False(model.RawData.ContainsKey("accounts_fraud_loss_total_amount"));
        Assert.Null(model.AchFraudTransactionsCount);
        Assert.False(model.RawData.ContainsKey("ach_fraud_transactions_count"));
        Assert.Null(model.AchFraudTransactionsDates);
        Assert.False(model.RawData.ContainsKey("ach_fraud_transactions_dates"));
        Assert.Null(model.AchFraudTransactionsTotalAmount);
        Assert.False(model.RawData.ContainsKey("ach_fraud_transactions_total_amount"));
        Assert.Null(model.AchReturnedTransactionsCount);
        Assert.False(model.RawData.ContainsKey("ach_returned_transactions_count"));
        Assert.Null(model.AchReturnedTransactionsDates);
        Assert.False(model.RawData.ContainsKey("ach_returned_transactions_dates"));
        Assert.Null(model.AchReturnedTransactionsTotalAmount);
        Assert.False(model.RawData.ContainsKey("ach_returned_transactions_total_amount"));
        Assert.Null(model.ApplicationsApprovedCount);
        Assert.False(model.RawData.ContainsKey("applications_approved_count"));
        Assert.Null(model.ApplicationsCount);
        Assert.False(model.RawData.ContainsKey("applications_count"));
        Assert.Null(model.ApplicationsDates);
        Assert.False(model.RawData.ContainsKey("applications_dates"));
        Assert.Null(model.ApplicationsDeclinedCount);
        Assert.False(model.RawData.ContainsKey("applications_declined_count"));
        Assert.Null(model.ApplicationsFraudCount);
        Assert.False(model.RawData.ContainsKey("applications_fraud_count"));
        Assert.Null(model.CardDisputedTransactionsCount);
        Assert.False(model.RawData.ContainsKey("card_disputed_transactions_count"));
        Assert.Null(model.CardDisputedTransactionsDates);
        Assert.False(model.RawData.ContainsKey("card_disputed_transactions_dates"));
        Assert.Null(model.CardDisputedTransactionsTotalAmount);
        Assert.False(model.RawData.ContainsKey("card_disputed_transactions_total_amount"));
        Assert.Null(model.CardFraudTransactionsCount);
        Assert.False(model.RawData.ContainsKey("card_fraud_transactions_count"));
        Assert.Null(model.CardFraudTransactionsDates);
        Assert.False(model.RawData.ContainsKey("card_fraud_transactions_dates"));
        Assert.Null(model.CardFraudTransactionsTotalAmount);
        Assert.False(model.RawData.ContainsKey("card_fraud_transactions_total_amount"));
        Assert.Null(model.CardStoppedTransactionsCount);
        Assert.False(model.RawData.ContainsKey("card_stopped_transactions_count"));
        Assert.Null(model.CardStoppedTransactionsDates);
        Assert.False(model.RawData.ContainsKey("card_stopped_transactions_dates"));
        Assert.Null(model.UserActiveProfileCount);
        Assert.False(model.RawData.ContainsKey("user_active_profile_count"));
        Assert.Null(model.UserAddressCount);
        Assert.False(model.RawData.ContainsKey("user_address_count"));
        Assert.Null(model.UserClosedProfileCount);
        Assert.False(model.RawData.ContainsKey("user_closed_profile_count"));
        Assert.Null(model.UserDobCount);
        Assert.False(model.RawData.ContainsKey("user_dob_count"));
        Assert.Null(model.UserEmailCount);
        Assert.False(model.RawData.ContainsKey("user_email_count"));
        Assert.Null(model.UserInstitutionCount);
        Assert.False(model.RawData.ContainsKey("user_institution_count"));
        Assert.Null(model.UserMobileCount);
        Assert.False(model.RawData.ContainsKey("user_mobile_count"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::Insights { };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Review::Insights
        {
            AccountsActiveCount = null,
            AccountsClosedCount = null,
            AccountsClosedDates = null,
            AccountsCount = null,
            AccountsFraudCount = null,
            AccountsFraudLabeledDates = null,
            AccountsFraudLossTotalAmount = null,
            AchFraudTransactionsCount = null,
            AchFraudTransactionsDates = null,
            AchFraudTransactionsTotalAmount = null,
            AchReturnedTransactionsCount = null,
            AchReturnedTransactionsDates = null,
            AchReturnedTransactionsTotalAmount = null,
            ApplicationsApprovedCount = null,
            ApplicationsCount = null,
            ApplicationsDates = null,
            ApplicationsDeclinedCount = null,
            ApplicationsFraudCount = null,
            CardDisputedTransactionsCount = null,
            CardDisputedTransactionsDates = null,
            CardDisputedTransactionsTotalAmount = null,
            CardFraudTransactionsCount = null,
            CardFraudTransactionsDates = null,
            CardFraudTransactionsTotalAmount = null,
            CardStoppedTransactionsCount = null,
            CardStoppedTransactionsDates = null,
            UserActiveProfileCount = null,
            UserAddressCount = null,
            UserClosedProfileCount = null,
            UserDobCount = null,
            UserEmailCount = null,
            UserInstitutionCount = null,
            UserMobileCount = null,
        };

        Assert.Null(model.AccountsActiveCount);
        Assert.True(model.RawData.ContainsKey("accounts_active_count"));
        Assert.Null(model.AccountsClosedCount);
        Assert.True(model.RawData.ContainsKey("accounts_closed_count"));
        Assert.Null(model.AccountsClosedDates);
        Assert.True(model.RawData.ContainsKey("accounts_closed_dates"));
        Assert.Null(model.AccountsCount);
        Assert.True(model.RawData.ContainsKey("accounts_count"));
        Assert.Null(model.AccountsFraudCount);
        Assert.True(model.RawData.ContainsKey("accounts_fraud_count"));
        Assert.Null(model.AccountsFraudLabeledDates);
        Assert.True(model.RawData.ContainsKey("accounts_fraud_labeled_dates"));
        Assert.Null(model.AccountsFraudLossTotalAmount);
        Assert.True(model.RawData.ContainsKey("accounts_fraud_loss_total_amount"));
        Assert.Null(model.AchFraudTransactionsCount);
        Assert.True(model.RawData.ContainsKey("ach_fraud_transactions_count"));
        Assert.Null(model.AchFraudTransactionsDates);
        Assert.True(model.RawData.ContainsKey("ach_fraud_transactions_dates"));
        Assert.Null(model.AchFraudTransactionsTotalAmount);
        Assert.True(model.RawData.ContainsKey("ach_fraud_transactions_total_amount"));
        Assert.Null(model.AchReturnedTransactionsCount);
        Assert.True(model.RawData.ContainsKey("ach_returned_transactions_count"));
        Assert.Null(model.AchReturnedTransactionsDates);
        Assert.True(model.RawData.ContainsKey("ach_returned_transactions_dates"));
        Assert.Null(model.AchReturnedTransactionsTotalAmount);
        Assert.True(model.RawData.ContainsKey("ach_returned_transactions_total_amount"));
        Assert.Null(model.ApplicationsApprovedCount);
        Assert.True(model.RawData.ContainsKey("applications_approved_count"));
        Assert.Null(model.ApplicationsCount);
        Assert.True(model.RawData.ContainsKey("applications_count"));
        Assert.Null(model.ApplicationsDates);
        Assert.True(model.RawData.ContainsKey("applications_dates"));
        Assert.Null(model.ApplicationsDeclinedCount);
        Assert.True(model.RawData.ContainsKey("applications_declined_count"));
        Assert.Null(model.ApplicationsFraudCount);
        Assert.True(model.RawData.ContainsKey("applications_fraud_count"));
        Assert.Null(model.CardDisputedTransactionsCount);
        Assert.True(model.RawData.ContainsKey("card_disputed_transactions_count"));
        Assert.Null(model.CardDisputedTransactionsDates);
        Assert.True(model.RawData.ContainsKey("card_disputed_transactions_dates"));
        Assert.Null(model.CardDisputedTransactionsTotalAmount);
        Assert.True(model.RawData.ContainsKey("card_disputed_transactions_total_amount"));
        Assert.Null(model.CardFraudTransactionsCount);
        Assert.True(model.RawData.ContainsKey("card_fraud_transactions_count"));
        Assert.Null(model.CardFraudTransactionsDates);
        Assert.True(model.RawData.ContainsKey("card_fraud_transactions_dates"));
        Assert.Null(model.CardFraudTransactionsTotalAmount);
        Assert.True(model.RawData.ContainsKey("card_fraud_transactions_total_amount"));
        Assert.Null(model.CardStoppedTransactionsCount);
        Assert.True(model.RawData.ContainsKey("card_stopped_transactions_count"));
        Assert.Null(model.CardStoppedTransactionsDates);
        Assert.True(model.RawData.ContainsKey("card_stopped_transactions_dates"));
        Assert.Null(model.UserActiveProfileCount);
        Assert.True(model.RawData.ContainsKey("user_active_profile_count"));
        Assert.Null(model.UserAddressCount);
        Assert.True(model.RawData.ContainsKey("user_address_count"));
        Assert.Null(model.UserClosedProfileCount);
        Assert.True(model.RawData.ContainsKey("user_closed_profile_count"));
        Assert.Null(model.UserDobCount);
        Assert.True(model.RawData.ContainsKey("user_dob_count"));
        Assert.Null(model.UserEmailCount);
        Assert.True(model.RawData.ContainsKey("user_email_count"));
        Assert.Null(model.UserInstitutionCount);
        Assert.True(model.RawData.ContainsKey("user_institution_count"));
        Assert.Null(model.UserMobileCount);
        Assert.True(model.RawData.ContainsKey("user_mobile_count"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::Insights
        {
            AccountsActiveCount = null,
            AccountsClosedCount = null,
            AccountsClosedDates = null,
            AccountsCount = null,
            AccountsFraudCount = null,
            AccountsFraudLabeledDates = null,
            AccountsFraudLossTotalAmount = null,
            AchFraudTransactionsCount = null,
            AchFraudTransactionsDates = null,
            AchFraudTransactionsTotalAmount = null,
            AchReturnedTransactionsCount = null,
            AchReturnedTransactionsDates = null,
            AchReturnedTransactionsTotalAmount = null,
            ApplicationsApprovedCount = null,
            ApplicationsCount = null,
            ApplicationsDates = null,
            ApplicationsDeclinedCount = null,
            ApplicationsFraudCount = null,
            CardDisputedTransactionsCount = null,
            CardDisputedTransactionsDates = null,
            CardDisputedTransactionsTotalAmount = null,
            CardFraudTransactionsCount = null,
            CardFraudTransactionsDates = null,
            CardFraudTransactionsTotalAmount = null,
            CardStoppedTransactionsCount = null,
            CardStoppedTransactionsDates = null,
            UserActiveProfileCount = null,
            UserAddressCount = null,
            UserClosedProfileCount = null,
            UserDobCount = null,
            UserEmailCount = null,
            UserInstitutionCount = null,
            UserMobileCount = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Review::Insights
        {
            AccountsActiveCount = 0,
            AccountsClosedCount = 0,
            AccountsClosedDates = ["2019-12-27"],
            AccountsCount = 0,
            AccountsFraudCount = 0,
            AccountsFraudLabeledDates = ["2019-12-27"],
            AccountsFraudLossTotalAmount = 0,
            AchFraudTransactionsCount = 0,
            AchFraudTransactionsDates = ["2019-12-27"],
            AchFraudTransactionsTotalAmount = 0,
            AchReturnedTransactionsCount = 0,
            AchReturnedTransactionsDates = ["2019-12-27"],
            AchReturnedTransactionsTotalAmount = 0,
            ApplicationsApprovedCount = 0,
            ApplicationsCount = 0,
            ApplicationsDates = ["2019-12-27"],
            ApplicationsDeclinedCount = 0,
            ApplicationsFraudCount = 0,
            CardDisputedTransactionsCount = 0,
            CardDisputedTransactionsDates = ["2019-12-27"],
            CardDisputedTransactionsTotalAmount = 0,
            CardFraudTransactionsCount = 0,
            CardFraudTransactionsDates = ["2019-12-27"],
            CardFraudTransactionsTotalAmount = 0,
            CardStoppedTransactionsCount = 0,
            CardStoppedTransactionsDates = ["2019-12-27"],
            UserActiveProfileCount = 0,
            UserAddressCount = 0,
            UserClosedProfileCount = 0,
            UserDobCount = 0,
            UserEmailCount = 0,
            UserInstitutionCount = 0,
            UserMobileCount = 0,
        };

        Review::Insights copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class WatchListTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Review::WatchList
        {
            Codes = ["string"],
            Decision = Review::WatchListDecision.Accept,
            Matched = ["string"],
            Matches =
            [
                new()
                {
                    Correlation = Review::Correlation.LowConfidence,
                    ListName = "list_name",
                    MatchFields = ["string"],
                    Urls = ["string"],
                },
            ],
        };

        List<string> expectedCodes = ["string"];
        ApiEnum<string, Review::WatchListDecision> expectedDecision =
            Review::WatchListDecision.Accept;
        List<string> expectedMatched = ["string"];
        List<Review::Match> expectedMatches =
        [
            new()
            {
                Correlation = Review::Correlation.LowConfidence,
                ListName = "list_name",
                MatchFields = ["string"],
                Urls = ["string"],
            },
        ];

        Assert.NotNull(model.Codes);
        Assert.Equal(expectedCodes.Count, model.Codes.Count);
        for (int i = 0; i < expectedCodes.Count; i++)
        {
            Assert.Equal(expectedCodes[i], model.Codes[i]);
        }
        Assert.Equal(expectedDecision, model.Decision);
        Assert.NotNull(model.Matched);
        Assert.Equal(expectedMatched.Count, model.Matched.Count);
        for (int i = 0; i < expectedMatched.Count; i++)
        {
            Assert.Equal(expectedMatched[i], model.Matched[i]);
        }
        Assert.NotNull(model.Matches);
        Assert.Equal(expectedMatches.Count, model.Matches.Count);
        for (int i = 0; i < expectedMatches.Count; i++)
        {
            Assert.Equal(expectedMatches[i], model.Matches[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Review::WatchList
        {
            Codes = ["string"],
            Decision = Review::WatchListDecision.Accept,
            Matched = ["string"],
            Matches =
            [
                new()
                {
                    Correlation = Review::Correlation.LowConfidence,
                    ListName = "list_name",
                    MatchFields = ["string"],
                    Urls = ["string"],
                },
            ],
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::WatchList>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Review::WatchList
        {
            Codes = ["string"],
            Decision = Review::WatchListDecision.Accept,
            Matched = ["string"],
            Matches =
            [
                new()
                {
                    Correlation = Review::Correlation.LowConfidence,
                    ListName = "list_name",
                    MatchFields = ["string"],
                    Urls = ["string"],
                },
            ],
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::WatchList>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<string> expectedCodes = ["string"];
        ApiEnum<string, Review::WatchListDecision> expectedDecision =
            Review::WatchListDecision.Accept;
        List<string> expectedMatched = ["string"];
        List<Review::Match> expectedMatches =
        [
            new()
            {
                Correlation = Review::Correlation.LowConfidence,
                ListName = "list_name",
                MatchFields = ["string"],
                Urls = ["string"],
            },
        ];

        Assert.NotNull(deserialized.Codes);
        Assert.Equal(expectedCodes.Count, deserialized.Codes.Count);
        for (int i = 0; i < expectedCodes.Count; i++)
        {
            Assert.Equal(expectedCodes[i], deserialized.Codes[i]);
        }
        Assert.Equal(expectedDecision, deserialized.Decision);
        Assert.NotNull(deserialized.Matched);
        Assert.Equal(expectedMatched.Count, deserialized.Matched.Count);
        for (int i = 0; i < expectedMatched.Count; i++)
        {
            Assert.Equal(expectedMatched[i], deserialized.Matched[i]);
        }
        Assert.NotNull(deserialized.Matches);
        Assert.Equal(expectedMatches.Count, deserialized.Matches.Count);
        for (int i = 0; i < expectedMatches.Count; i++)
        {
            Assert.Equal(expectedMatches[i], deserialized.Matches[i]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Review::WatchList
        {
            Codes = ["string"],
            Decision = Review::WatchListDecision.Accept,
            Matched = ["string"],
            Matches =
            [
                new()
                {
                    Correlation = Review::Correlation.LowConfidence,
                    ListName = "list_name",
                    MatchFields = ["string"],
                    Urls = ["string"],
                },
            ],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::WatchList
        {
            Codes = ["string"],
            Matched = ["string"],
            Matches =
            [
                new()
                {
                    Correlation = Review::Correlation.LowConfidence,
                    ListName = "list_name",
                    MatchFields = ["string"],
                    Urls = ["string"],
                },
            ],
        };

        Assert.Null(model.Decision);
        Assert.False(model.RawData.ContainsKey("decision"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::WatchList
        {
            Codes = ["string"],
            Matched = ["string"],
            Matches =
            [
                new()
                {
                    Correlation = Review::Correlation.LowConfidence,
                    ListName = "list_name",
                    MatchFields = ["string"],
                    Urls = ["string"],
                },
            ],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Review::WatchList
        {
            Codes = ["string"],
            Matched = ["string"],
            Matches =
            [
                new()
                {
                    Correlation = Review::Correlation.LowConfidence,
                    ListName = "list_name",
                    MatchFields = ["string"],
                    Urls = ["string"],
                },
            ],

            // Null should be interpreted as omitted for these properties
            Decision = null,
        };

        Assert.Null(model.Decision);
        Assert.False(model.RawData.ContainsKey("decision"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::WatchList
        {
            Codes = ["string"],
            Matched = ["string"],
            Matches =
            [
                new()
                {
                    Correlation = Review::Correlation.LowConfidence,
                    ListName = "list_name",
                    MatchFields = ["string"],
                    Urls = ["string"],
                },
            ],

            // Null should be interpreted as omitted for these properties
            Decision = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Review::WatchList { Decision = Review::WatchListDecision.Accept };

        Assert.Null(model.Codes);
        Assert.False(model.RawData.ContainsKey("codes"));
        Assert.Null(model.Matched);
        Assert.False(model.RawData.ContainsKey("matched"));
        Assert.Null(model.Matches);
        Assert.False(model.RawData.ContainsKey("matches"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new Review::WatchList { Decision = Review::WatchListDecision.Accept };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Review::WatchList
        {
            Decision = Review::WatchListDecision.Accept,

            Codes = null,
            Matched = null,
            Matches = null,
        };

        Assert.Null(model.Codes);
        Assert.True(model.RawData.ContainsKey("codes"));
        Assert.Null(model.Matched);
        Assert.True(model.RawData.ContainsKey("matched"));
        Assert.Null(model.Matches);
        Assert.True(model.RawData.ContainsKey("matches"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Review::WatchList
        {
            Decision = Review::WatchListDecision.Accept,

            Codes = null,
            Matched = null,
            Matches = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Review::WatchList
        {
            Codes = ["string"],
            Decision = Review::WatchListDecision.Accept,
            Matched = ["string"],
            Matches =
            [
                new()
                {
                    Correlation = Review::Correlation.LowConfidence,
                    ListName = "list_name",
                    MatchFields = ["string"],
                    Urls = ["string"],
                },
            ],
        };

        Review::WatchList copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class WatchListDecisionTest : TestBase
{
    [Theory]
    [InlineData(Review::WatchListDecision.Accept)]
    [InlineData(Review::WatchListDecision.Reject)]
    [InlineData(Review::WatchListDecision.Review)]
    public void Validation_Works(Review::WatchListDecision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::WatchListDecision> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::WatchListDecision>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Review::WatchListDecision.Accept)]
    [InlineData(Review::WatchListDecision.Reject)]
    [InlineData(Review::WatchListDecision.Review)]
    public void SerializationRoundtrip_Works(Review::WatchListDecision rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::WatchListDecision> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::WatchListDecision>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::WatchListDecision>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::WatchListDecision>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class MatchTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Review::Match
        {
            Correlation = Review::Correlation.LowConfidence,
            ListName = "list_name",
            MatchFields = ["string"],
            Urls = ["string"],
        };

        ApiEnum<string, Review::Correlation> expectedCorrelation =
            Review::Correlation.LowConfidence;
        string expectedListName = "list_name";
        List<string> expectedMatchFields = ["string"];
        List<string> expectedUrls = ["string"];

        Assert.Equal(expectedCorrelation, model.Correlation);
        Assert.Equal(expectedListName, model.ListName);
        Assert.Equal(expectedMatchFields.Count, model.MatchFields.Count);
        for (int i = 0; i < expectedMatchFields.Count; i++)
        {
            Assert.Equal(expectedMatchFields[i], model.MatchFields[i]);
        }
        Assert.Equal(expectedUrls.Count, model.Urls.Count);
        for (int i = 0; i < expectedUrls.Count; i++)
        {
            Assert.Equal(expectedUrls[i], model.Urls[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Review::Match
        {
            Correlation = Review::Correlation.LowConfidence,
            ListName = "list_name",
            MatchFields = ["string"],
            Urls = ["string"],
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Match>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Review::Match
        {
            Correlation = Review::Correlation.LowConfidence,
            ListName = "list_name",
            MatchFields = ["string"],
            Urls = ["string"],
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Review::Match>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        ApiEnum<string, Review::Correlation> expectedCorrelation =
            Review::Correlation.LowConfidence;
        string expectedListName = "list_name";
        List<string> expectedMatchFields = ["string"];
        List<string> expectedUrls = ["string"];

        Assert.Equal(expectedCorrelation, deserialized.Correlation);
        Assert.Equal(expectedListName, deserialized.ListName);
        Assert.Equal(expectedMatchFields.Count, deserialized.MatchFields.Count);
        for (int i = 0; i < expectedMatchFields.Count; i++)
        {
            Assert.Equal(expectedMatchFields[i], deserialized.MatchFields[i]);
        }
        Assert.Equal(expectedUrls.Count, deserialized.Urls.Count);
        for (int i = 0; i < expectedUrls.Count; i++)
        {
            Assert.Equal(expectedUrls[i], deserialized.Urls[i]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Review::Match
        {
            Correlation = Review::Correlation.LowConfidence,
            ListName = "list_name",
            MatchFields = ["string"],
            Urls = ["string"],
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Review::Match
        {
            Correlation = Review::Correlation.LowConfidence,
            ListName = "list_name",
            MatchFields = ["string"],
            Urls = ["string"],
        };

        Review::Match copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class CorrelationTest : TestBase
{
    [Theory]
    [InlineData(Review::Correlation.LowConfidence)]
    [InlineData(Review::Correlation.PotentialMatch)]
    [InlineData(Review::Correlation.LikelyMatch)]
    [InlineData(Review::Correlation.HighConfidence)]
    public void Validation_Works(Review::Correlation rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::Correlation> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::Correlation>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Review::Correlation.LowConfidence)]
    [InlineData(Review::Correlation.PotentialMatch)]
    [InlineData(Review::Correlation.LikelyMatch)]
    [InlineData(Review::Correlation.HighConfidence)]
    public void SerializationRoundtrip_Works(Review::Correlation rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::Correlation> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::Correlation>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::Correlation>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::Correlation>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class ResponseTypeTest : TestBase
{
    [Theory]
    [InlineData(Review::ResponseType.Object)]
    [InlineData(Review::ResponseType.Array)]
    [InlineData(Review::ResponseType.Error)]
    [InlineData(Review::ResponseType.None)]
    public void Validation_Works(Review::ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::ResponseType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Review::ResponseType.Object)]
    [InlineData(Review::ResponseType.Array)]
    [InlineData(Review::ResponseType.Error)]
    [InlineData(Review::ResponseType.None)]
    public void SerializationRoundtrip_Works(Review::ResponseType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Review::ResponseType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::ResponseType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Review::ResponseType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Review::ResponseType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
