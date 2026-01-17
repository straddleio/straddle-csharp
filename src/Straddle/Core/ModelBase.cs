using System.Text.Json;
using Straddle.Exceptions;
using Straddle.Models;
using Straddle.Models.Bridge;
using Accounts = Straddle.Models.Embed.Accounts;
using CapabilityRequests = Straddle.Models.Embed.Accounts.CapabilityRequests;
using Charges = Straddle.Models.Charges;
using Customers = Straddle.Models.Customers;
using FundingEvents = Straddle.Models.FundingEvents;
using Link = Straddle.Models.Bridge.Link;
using LinkedBankAccounts = Straddle.Models.Embed.LinkedBankAccounts;
using Organizations = Straddle.Models.Embed.Organizations;
using Paykeys = Straddle.Models.Paykeys;
using PaykeysReview = Straddle.Models.Paykeys.Review;
using Payments = Straddle.Models.Payments;
using Payouts = Straddle.Models.Payouts;
using Reports = Straddle.Models.Reports;
using Representatives = Straddle.Models.Embed.Representatives;
using Review = Straddle.Models.Customers.Review;

namespace Straddle.Core;

/// <summary>
/// The base class for all API objects with properties.
///
/// <para>API objects such as enums do not inherit from this class.</para>
/// </summary>
public abstract record class ModelBase
{
    protected ModelBase(ModelBase modelBase)
    {
        // Nothing to copy. Just so that subclasses can define copy constructors.
    }

    internal static readonly JsonSerializerOptions SerializerOptions = new()
    {
        Converters =
        {
            new FrozenDictionaryConverterFactory(),
            new ApiEnumConverter<string, CustomerType>(),
            new ApiEnumConverter<string, SortOrder>(),
            new ApiEnumConverter<string, Reason>(),
            new ApiEnumConverter<string, Source>(),
            new ApiEnumConverter<string, Accounts::DataAccessLevel>(),
            new ApiEnumConverter<string, Accounts::DataStatus>(),
            new ApiEnumConverter<string, Accounts::Reason>(),
            new ApiEnumConverter<string, Accounts::Source>(),
            new ApiEnumConverter<string, Accounts::DataType>(),
            new ApiEnumConverter<string, Accounts::FundingTime>(),
            new ApiEnumConverter<string, Accounts::SettingsPayoutsFundingTime>(),
            new ApiEnumConverter<string, Accounts::ResponseType>(),
            new ApiEnumConverter<string, Accounts::AccountV1DataAccessLevel>(),
            new ApiEnumConverter<string, Accounts::AccountV1DataStatus>(),
            new ApiEnumConverter<string, Accounts::AccountV1DataStatusDetailReason>(),
            new ApiEnumConverter<string, Accounts::AccountV1DataStatusDetailSource>(),
            new ApiEnumConverter<string, Accounts::AccountV1DataType>(),
            new ApiEnumConverter<string, Accounts::AccountV1DataSettingsChargesFundingTime>(),
            new ApiEnumConverter<string, Accounts::AccountV1DataSettingsPayoutsFundingTime>(),
            new ApiEnumConverter<string, Accounts::AccountV1ResponseType>(),
            new ApiEnumConverter<string, Accounts::CapabilityStatus>(),
            new ApiEnumConverter<string, Accounts::AgreementType>(),
            new ApiEnumConverter<string, Accounts::AccessLevel>(),
            new ApiEnumConverter<string, Accounts::AccountType>(),
            new ApiEnumConverter<string, Accounts::SortOrder>(),
            new ApiEnumConverter<string, Accounts::Status>(),
            new ApiEnumConverter<string, Accounts::Type>(),
            new ApiEnumConverter<string, Accounts::FinalStatus>(),
            new ApiEnumConverter<string, CapabilityRequests::DataCategory>(),
            new ApiEnumConverter<string, CapabilityRequests::DataStatus>(),
            new ApiEnumConverter<string, CapabilityRequests::DataType>(),
            new ApiEnumConverter<string, CapabilityRequests::ResponseType>(),
            new ApiEnumConverter<string, CapabilityRequests::Category>(),
            new ApiEnumConverter<string, CapabilityRequests::SortOrder>(),
            new ApiEnumConverter<string, CapabilityRequests::Status>(),
            new ApiEnumConverter<string, CapabilityRequests::Type>(),
            new ApiEnumConverter<string, LinkedBankAccounts::DataPurpose>(),
            new ApiEnumConverter<string, LinkedBankAccounts::DataStatus>(),
            new ApiEnumConverter<string, LinkedBankAccounts::Reason>(),
            new ApiEnumConverter<string, LinkedBankAccounts::Source>(),
            new ApiEnumConverter<string, LinkedBankAccounts::ResponseType>(),
            new ApiEnumConverter<string, LinkedBankAccounts::LinkedBankAccountUnmaskV1DataStatus>(),
            new ApiEnumConverter<
                string,
                LinkedBankAccounts::LinkedBankAccountUnmaskV1DataStatusDetailReason
            >(),
            new ApiEnumConverter<
                string,
                LinkedBankAccounts::LinkedBankAccountUnmaskV1DataStatusDetailSource
            >(),
            new ApiEnumConverter<
                string,
                LinkedBankAccounts::LinkedBankAccountUnmaskV1ResponseType
            >(),
            new ApiEnumConverter<string, LinkedBankAccounts::LinkedBankAccountV1DataPurpose>(),
            new ApiEnumConverter<string, LinkedBankAccounts::LinkedBankAccountV1DataStatus>(),
            new ApiEnumConverter<
                string,
                LinkedBankAccounts::LinkedBankAccountV1DataStatusDetailReason
            >(),
            new ApiEnumConverter<
                string,
                LinkedBankAccounts::LinkedBankAccountV1DataStatusDetailSource
            >(),
            new ApiEnumConverter<string, LinkedBankAccounts::LinkedBankAccountV1ResponseType>(),
            new ApiEnumConverter<string, LinkedBankAccounts::Purpose>(),
            new ApiEnumConverter<string, LinkedBankAccounts::Level>(),
            new ApiEnumConverter<string, LinkedBankAccounts::LinkedBankAccountListParamsPurpose>(),
            new ApiEnumConverter<string, LinkedBankAccounts::SortOrder>(),
            new ApiEnumConverter<string, LinkedBankAccounts::Status>(),
            new ApiEnumConverter<string, Organizations::ResponseType>(),
            new ApiEnumConverter<string, Organizations::OrganizationV1ResponseType>(),
            new ApiEnumConverter<string, Organizations::SortOrder>(),
            new ApiEnumConverter<string, Representatives::Status>(),
            new ApiEnumConverter<string, Representatives::Reason>(),
            new ApiEnumConverter<string, Representatives::Source>(),
            new ApiEnumConverter<string, Representatives::ResponseType>(),
            new ApiEnumConverter<string, Representatives::RepresentativePagedDataStatus>(),
            new ApiEnumConverter<
                string,
                Representatives::RepresentativePagedDataStatusDetailReason
            >(),
            new ApiEnumConverter<
                string,
                Representatives::RepresentativePagedDataStatusDetailSource
            >(),
            new ApiEnumConverter<string, Representatives::RepresentativePagedResponseType>(),
            new ApiEnumConverter<string, Representatives::Level>(),
            new ApiEnumConverter<string, Representatives::SortOrder>(),
            new ApiEnumConverter<string, ResponseType>(),
            new ApiEnumConverter<string, ProcessingMethod>(),
            new ApiEnumConverter<string, SandboxOutcome>(),
            new ApiEnumConverter<string, Link::DataConfigProcessingMethod>(),
            new ApiEnumConverter<string, Link::DataConfigSandboxOutcome>(),
            new ApiEnumConverter<string, Link::Source>(),
            new ApiEnumConverter<string, Link::Status>(),
            new ApiEnumConverter<string, Link::BalanceStatus>(),
            new ApiEnumConverter<string, Link::BankDataAccountType>(),
            new ApiEnumConverter<string, Link::Reason>(),
            new ApiEnumConverter<string, Link::StatusDetailsSource>(),
            new ApiEnumConverter<string, Link::ResponseType>(),
            new ApiEnumConverter<string, Link::LinkCreateTanResponseDataConfigProcessingMethod>(),
            new ApiEnumConverter<string, Link::LinkCreateTanResponseDataConfigSandboxOutcome>(),
            new ApiEnumConverter<string, Link::LinkCreateTanResponseDataSource>(),
            new ApiEnumConverter<string, Link::LinkCreateTanResponseDataStatus>(),
            new ApiEnumConverter<string, Link::LinkCreateTanResponseDataBalanceStatus>(),
            new ApiEnumConverter<string, Link::LinkCreateTanResponseDataBankDataAccountType>(),
            new ApiEnumConverter<string, Link::LinkCreateTanResponseDataStatusDetailsReason>(),
            new ApiEnumConverter<string, Link::LinkCreateTanResponseDataStatusDetailsSource>(),
            new ApiEnumConverter<string, Link::LinkCreateTanResponseResponseType>(),
            new ApiEnumConverter<string, Link::AccountType>(),
            new ApiEnumConverter<string, Link::ProcessingMethod>(),
            new ApiEnumConverter<string, Link::SandboxOutcome>(),
            new ApiEnumConverter<string, Link::LinkCreatePaykeyParamsConfigProcessingMethod>(),
            new ApiEnumConverter<string, Link::LinkCreatePaykeyParamsConfigSandboxOutcome>(),
            new ApiEnumConverter<string, Link::LinkCreateTanParamsAccountType>(),
            new ApiEnumConverter<string, Link::LinkCreateTanParamsConfigProcessingMethod>(),
            new ApiEnumConverter<string, Link::LinkCreateTanParamsConfigSandboxOutcome>(),
            new ApiEnumConverter<string, Link::LinkPlaidParamsConfigProcessingMethod>(),
            new ApiEnumConverter<string, Link::LinkPlaidParamsConfigSandboxOutcome>(),
            new ApiEnumConverter<string, Customers::DataStatus>(),
            new ApiEnumConverter<string, Customers::DataType>(),
            new ApiEnumConverter<string, Customers::MetaSortOrder>(),
            new ApiEnumConverter<string, Customers::ResponseType>(),
            new ApiEnumConverter<string, Customers::CustomerUnmaskedV1DataStatus>(),
            new ApiEnumConverter<string, Customers::CustomerUnmaskedV1DataType>(),
            new ApiEnumConverter<string, Customers::CustomerUnmaskedV1DataConfigProcessingMethod>(),
            new ApiEnumConverter<string, Customers::CustomerUnmaskedV1DataConfigSandboxOutcome>(),
            new ApiEnumConverter<string, Customers::CustomerUnmaskedV1ResponseType>(),
            new ApiEnumConverter<string, Customers::CustomerV1DataStatus>(),
            new ApiEnumConverter<string, Customers::CustomerV1DataType>(),
            new ApiEnumConverter<string, Customers::CustomerV1DataConfigProcessingMethod>(),
            new ApiEnumConverter<string, Customers::CustomerV1DataConfigSandboxOutcome>(),
            new ApiEnumConverter<string, Customers::CustomerV1ResponseType>(),
            new ApiEnumConverter<string, Customers::Type>(),
            new ApiEnumConverter<string, Customers::ProcessingMethod>(),
            new ApiEnumConverter<string, Customers::SandboxOutcome>(),
            new ApiEnumConverter<string, Customers::Status>(),
            new ApiEnumConverter<string, Customers::SortBy>(),
            new ApiEnumConverter<string, Customers::SortOrder>(),
            new ApiEnumConverter<string, Customers::CustomerListParamsStatus>(),
            new ApiEnumConverter<string, Customers::CustomerListParamsType>(),
            new ApiEnumConverter<string, Review::CustomerDetailsStatus>(),
            new ApiEnumConverter<string, Review::Type>(),
            new ApiEnumConverter<string, Review::ProcessingMethod>(),
            new ApiEnumConverter<string, Review::SandboxOutcome>(),
            new ApiEnumConverter<string, Review::Decision>(),
            new ApiEnumConverter<string, Review::KycDecision>(),
            new ApiEnumConverter<string, Review::NetworkAlertsDecision>(),
            new ApiEnumConverter<string, Review::ReputationDecision>(),
            new ApiEnumConverter<string, Review::WatchListDecision>(),
            new ApiEnumConverter<string, Review::Correlation>(),
            new ApiEnumConverter<string, Review::ResponseType>(),
            new ApiEnumConverter<string, Review::IdentityVerificationBreakdownV1Correlation>(),
            new ApiEnumConverter<string, Review::IdentityVerificationBreakdownV1Decision>(),
            new ApiEnumConverter<string, Review::Status>(),
            new ApiEnumConverter<string, Paykeys::ProcessingMethod>(),
            new ApiEnumConverter<string, Paykeys::SandboxOutcome>(),
            new ApiEnumConverter<string, Paykeys::DataSource>(),
            new ApiEnumConverter<string, Paykeys::DataStatus>(),
            new ApiEnumConverter<string, Paykeys::AccountType>(),
            new ApiEnumConverter<string, Paykeys::Reason>(),
            new ApiEnumConverter<string, Paykeys::StatusDetailsSource>(),
            new ApiEnumConverter<string, Paykeys::MetaSortOrder>(),
            new ApiEnumConverter<string, Paykeys::ResponseType>(),
            new ApiEnumConverter<string, Paykeys::PaykeyUnmaskedV1DataConfigProcessingMethod>(),
            new ApiEnumConverter<string, Paykeys::PaykeyUnmaskedV1DataConfigSandboxOutcome>(),
            new ApiEnumConverter<string, Paykeys::PaykeyUnmaskedV1DataSource>(),
            new ApiEnumConverter<string, Paykeys::PaykeyUnmaskedV1DataStatus>(),
            new ApiEnumConverter<string, Paykeys::BalanceStatus>(),
            new ApiEnumConverter<string, Paykeys::PaykeyUnmaskedV1DataBankDataAccountType>(),
            new ApiEnumConverter<string, Paykeys::PaykeyUnmaskedV1DataStatusDetailsReason>(),
            new ApiEnumConverter<string, Paykeys::PaykeyUnmaskedV1DataStatusDetailsSource>(),
            new ApiEnumConverter<string, Paykeys::PaykeyUnmaskedV1ResponseType>(),
            new ApiEnumConverter<string, Paykeys::PaykeyV1DataConfigProcessingMethod>(),
            new ApiEnumConverter<string, Paykeys::PaykeyV1DataConfigSandboxOutcome>(),
            new ApiEnumConverter<string, Paykeys::PaykeyV1DataSource>(),
            new ApiEnumConverter<string, Paykeys::PaykeyV1DataStatus>(),
            new ApiEnumConverter<string, Paykeys::PaykeyV1DataBalanceStatus>(),
            new ApiEnumConverter<string, Paykeys::PaykeyV1DataBankDataAccountType>(),
            new ApiEnumConverter<string, Paykeys::PaykeyV1DataStatusDetailsReason>(),
            new ApiEnumConverter<string, Paykeys::PaykeyV1DataStatusDetailsSource>(),
            new ApiEnumConverter<string, Paykeys::PaykeyV1ResponseType>(),
            new ApiEnumConverter<string, Paykeys::PaykeyRevealResponseDataConfigProcessingMethod>(),
            new ApiEnumConverter<string, Paykeys::PaykeyRevealResponseDataConfigSandboxOutcome>(),
            new ApiEnumConverter<string, Paykeys::PaykeyRevealResponseDataSource>(),
            new ApiEnumConverter<string, Paykeys::PaykeyRevealResponseDataStatus>(),
            new ApiEnumConverter<string, Paykeys::PaykeyRevealResponseDataBalanceStatus>(),
            new ApiEnumConverter<string, Paykeys::PaykeyRevealResponseDataBankDataAccountType>(),
            new ApiEnumConverter<string, Paykeys::PaykeyRevealResponseDataStatusDetailsReason>(),
            new ApiEnumConverter<string, Paykeys::PaykeyRevealResponseDataStatusDetailsSource>(),
            new ApiEnumConverter<string, Paykeys::PaykeyRevealResponseResponseType>(),
            new ApiEnumConverter<string, Paykeys::SortBy>(),
            new ApiEnumConverter<string, Paykeys::SortOrder>(),
            new ApiEnumConverter<string, Paykeys::Source>(),
            new ApiEnumConverter<string, Paykeys::Status>(),
            new ApiEnumConverter<string, PaykeysReview::ProcessingMethod>(),
            new ApiEnumConverter<string, PaykeysReview::SandboxOutcome>(),
            new ApiEnumConverter<string, PaykeysReview::Source>(),
            new ApiEnumConverter<string, PaykeysReview::PaykeyDetailsStatus>(),
            new ApiEnumConverter<string, PaykeysReview::BalanceStatus>(),
            new ApiEnumConverter<string, PaykeysReview::AccountType>(),
            new ApiEnumConverter<string, PaykeysReview::Reason>(),
            new ApiEnumConverter<string, PaykeysReview::StatusDetailsSource>(),
            new ApiEnumConverter<string, PaykeysReview::Decision>(),
            new ApiEnumConverter<string, PaykeysReview::NameMatchDecision>(),
            new ApiEnumConverter<string, PaykeysReview::VerificationDetailsDecision>(),
            new ApiEnumConverter<string, PaykeysReview::ResponseType>(),
            new ApiEnumConverter<string, PaykeysReview::Status>(),
            new ApiEnumConverter<string, Charges::DataConfigBalanceCheck>(),
            new ApiEnumConverter<string, Charges::DataConfigSandboxOutcome>(),
            new ApiEnumConverter<string, Charges::DataConsentType>(),
            new ApiEnumConverter<string, Charges::Status>(),
            new ApiEnumConverter<string, Charges::Reason>(),
            new ApiEnumConverter<string, Charges::Source>(),
            new ApiEnumConverter<string, Charges::StatusHistoryStatus>(),
            new ApiEnumConverter<string, Charges::PaymentRail>(),
            new ApiEnumConverter<string, Charges::ResponseType>(),
            new ApiEnumConverter<string, Charges::ChargeUnmaskResponseDataConfigBalanceCheck>(),
            new ApiEnumConverter<string, Charges::ChargeUnmaskResponseDataConfigSandboxOutcome>(),
            new ApiEnumConverter<string, Charges::ChargeUnmaskResponseDataConsentType>(),
            new ApiEnumConverter<string, Charges::ChargeUnmaskResponseDataStatus>(),
            new ApiEnumConverter<string, Charges::ChargeUnmaskResponseDataStatusHistoryReason>(),
            new ApiEnumConverter<string, Charges::ChargeUnmaskResponseDataStatusHistorySource>(),
            new ApiEnumConverter<string, Charges::ChargeUnmaskResponseDataStatusHistoryStatus>(),
            new ApiEnumConverter<string, Charges::ChargeUnmaskResponseDataPaymentRail>(),
            new ApiEnumConverter<string, Charges::ChargeUnmaskResponseResponseType>(),
            new ApiEnumConverter<string, Charges::BalanceCheck>(),
            new ApiEnumConverter<string, Charges::SandboxOutcome>(),
            new ApiEnumConverter<string, Charges::ConsentType>(),
            new ApiEnumConverter<string, FundingEvents::DataDirection>(),
            new ApiEnumConverter<string, FundingEvents::DataEventType>(),
            new ApiEnumConverter<string, FundingEvents::DataStatus>(),
            new ApiEnumConverter<string, FundingEvents::Reason>(),
            new ApiEnumConverter<string, FundingEvents::Source>(),
            new ApiEnumConverter<string, FundingEvents::ResponseType>(),
            new ApiEnumConverter<string, FundingEvents::FundingEventSummaryPagedV1DataDirection>(),
            new ApiEnumConverter<string, FundingEvents::FundingEventSummaryPagedV1DataEventType>(),
            new ApiEnumConverter<string, FundingEvents::FundingEventSummaryPagedV1DataStatus>(),
            new ApiEnumConverter<
                string,
                FundingEvents::FundingEventSummaryPagedV1DataStatusDetailsReason
            >(),
            new ApiEnumConverter<
                string,
                FundingEvents::FundingEventSummaryPagedV1DataStatusDetailsSource
            >(),
            new ApiEnumConverter<string, FundingEvents::MetaSortOrder>(),
            new ApiEnumConverter<string, FundingEvents::FundingEventSummaryPagedV1ResponseType>(),
            new ApiEnumConverter<string, FundingEvents::Direction>(),
            new ApiEnumConverter<string, FundingEvents::EventType>(),
            new ApiEnumConverter<string, FundingEvents::SortBy>(),
            new ApiEnumConverter<string, FundingEvents::SortOrder>(),
            new ApiEnumConverter<string, FundingEvents::Status>(),
            new ApiEnumConverter<string, FundingEvents::StatusReason>(),
            new ApiEnumConverter<string, FundingEvents::StatusSource>(),
            new ApiEnumConverter<string, Payments::DataPaymentType>(),
            new ApiEnumConverter<string, Payments::Status>(),
            new ApiEnumConverter<string, Payments::MetaSortOrder>(),
            new ApiEnumConverter<string, Payments::ResponseType>(),
            new ApiEnumConverter<string, Payments::DefaultSort>(),
            new ApiEnumConverter<string, Payments::DefaultSortOrder>(),
            new ApiEnumConverter<string, Payments::PaymentStatus>(),
            new ApiEnumConverter<string, Payments::PaymentType>(),
            new ApiEnumConverter<string, Payments::SortBy>(),
            new ApiEnumConverter<string, Payments::SortOrder>(),
            new ApiEnumConverter<string, Payments::StatusReason>(),
            new ApiEnumConverter<string, Payments::StatusSource>(),
            new ApiEnumConverter<string, Payouts::DataConfigSandboxOutcome>(),
            new ApiEnumConverter<string, Payouts::Status>(),
            new ApiEnumConverter<string, Payouts::Reason>(),
            new ApiEnumConverter<string, Payouts::Source>(),
            new ApiEnumConverter<string, Payouts::StatusHistoryStatus>(),
            new ApiEnumConverter<string, Payouts::PaymentRail>(),
            new ApiEnumConverter<string, Payouts::ResponseType>(),
            new ApiEnumConverter<string, Payouts::PayoutUnmaskResponseDataConfigSandboxOutcome>(),
            new ApiEnumConverter<string, Payouts::PayoutUnmaskResponseDataStatus>(),
            new ApiEnumConverter<string, Payouts::PayoutUnmaskResponseDataStatusHistoryReason>(),
            new ApiEnumConverter<string, Payouts::PayoutUnmaskResponseDataStatusHistorySource>(),
            new ApiEnumConverter<string, Payouts::PayoutUnmaskResponseDataStatusHistoryStatus>(),
            new ApiEnumConverter<string, Payouts::PayoutUnmaskResponseDataPaymentRail>(),
            new ApiEnumConverter<string, Payouts::PayoutUnmaskResponseResponseType>(),
            new ApiEnumConverter<string, Payouts::SandboxOutcome>(),
            new ApiEnumConverter<string, Reports::ResponseType>(),
        },
    };

    internal static readonly JsonSerializerOptions ToStringSerializerOptions = new(
        SerializerOptions
    )
    {
        WriteIndented = true,
    };

    /// <summary>
    /// Validates that all required fields are set and that each field's value is of the expected type.
    ///
    /// <para>This is useful for instances constructed from raw JSON data (e.g. deserialized from an API response).</para>
    ///
    /// <exception cref="StraddleInvalidDataException">
    /// Thrown when the instance does not pass validation.
    /// </exception>
    /// </summary>
    public abstract void Validate();
}
