using System;
using System.Collections.Generic;
using System.Text.Json;
using Straddle.Core;
using Straddle.Exceptions;
using Straddle.Models;
using Straddle.Models.Payments;

namespace Straddle.Tests.Models.Payments;

public class PaymentSummaryPagedV1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new PaymentSummaryPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Amount = 10000,
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Currency = "currency",
                    Description = "Invoice payment for 100 widgets",
                    ExternalID = "external_id",
                    FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                    Paykey = "paykey",
                    PaymentDate = "2019-12-27",
                    PaymentType = DataPaymentType.Charge,
                    Status = Status.Created,
                    StatusDetails = new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Payment successfully created and awaiting validation.",
                        Reason = Reason.InsufficientFunds,
                        Source = Source.System,
                        Code = null,
                    },
                    TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    CustomerDetails = new()
                    {
                        ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        CustomerType = CustomerType.Individual,
                        Email = "ron@swanson.com",
                        Name = "Ron Swanson",
                        Phone = "+1234567890",
                    },
                    EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    PaykeyDetails = new()
                    {
                        ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        Label = "Bank of America ****1234",
                        Balance = 0,
                    },
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
                SortOrder = MetaSortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = ResponseType.Object,
        };

        List<Data> expectedData =
        [
            new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 10000,
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Currency = "currency",
                Description = "Invoice payment for 100 widgets",
                ExternalID = "external_id",
                FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                Paykey = "paykey",
                PaymentDate = "2019-12-27",
                PaymentType = DataPaymentType.Charge,
                Status = Status.Created,
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = Reason.InsufficientFunds,
                    Source = Source.System,
                    Code = null,
                },
                TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                CustomerDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CustomerType = CustomerType.Individual,
                    Email = "ron@swanson.com",
                    Name = "Ron Swanson",
                    Phone = "+1234567890",
                },
                EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                PaykeyDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Label = "Bank of America ****1234",
                    Balance = 0,
                },
            },
        ];
        Meta expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = MetaSortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };
        ApiEnum<string, ResponseType> expectedResponseType = ResponseType.Object;

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
        var model = new PaymentSummaryPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Amount = 10000,
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Currency = "currency",
                    Description = "Invoice payment for 100 widgets",
                    ExternalID = "external_id",
                    FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                    Paykey = "paykey",
                    PaymentDate = "2019-12-27",
                    PaymentType = DataPaymentType.Charge,
                    Status = Status.Created,
                    StatusDetails = new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Payment successfully created and awaiting validation.",
                        Reason = Reason.InsufficientFunds,
                        Source = Source.System,
                        Code = null,
                    },
                    TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    CustomerDetails = new()
                    {
                        ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        CustomerType = CustomerType.Individual,
                        Email = "ron@swanson.com",
                        Name = "Ron Swanson",
                        Phone = "+1234567890",
                    },
                    EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    PaykeyDetails = new()
                    {
                        ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        Label = "Bank of America ****1234",
                        Balance = 0,
                    },
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
                SortOrder = MetaSortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = ResponseType.Object,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaymentSummaryPagedV1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new PaymentSummaryPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Amount = 10000,
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Currency = "currency",
                    Description = "Invoice payment for 100 widgets",
                    ExternalID = "external_id",
                    FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                    Paykey = "paykey",
                    PaymentDate = "2019-12-27",
                    PaymentType = DataPaymentType.Charge,
                    Status = Status.Created,
                    StatusDetails = new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Payment successfully created and awaiting validation.",
                        Reason = Reason.InsufficientFunds,
                        Source = Source.System,
                        Code = null,
                    },
                    TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    CustomerDetails = new()
                    {
                        ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        CustomerType = CustomerType.Individual,
                        Email = "ron@swanson.com",
                        Name = "Ron Swanson",
                        Phone = "+1234567890",
                    },
                    EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    PaykeyDetails = new()
                    {
                        ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        Label = "Bank of America ****1234",
                        Balance = 0,
                    },
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
                SortOrder = MetaSortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = ResponseType.Object,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<PaymentSummaryPagedV1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Amount = 10000,
                CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Currency = "currency",
                Description = "Invoice payment for 100 widgets",
                ExternalID = "external_id",
                FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                Paykey = "paykey",
                PaymentDate = "2019-12-27",
                PaymentType = DataPaymentType.Charge,
                Status = Status.Created,
                StatusDetails = new()
                {
                    ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Message = "Payment successfully created and awaiting validation.",
                    Reason = Reason.InsufficientFunds,
                    Source = Source.System,
                    Code = null,
                },
                TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                CustomerDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CustomerType = CustomerType.Individual,
                    Email = "ron@swanson.com",
                    Name = "Ron Swanson",
                    Phone = "+1234567890",
                },
                EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                PaykeyDetails = new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Label = "Bank of America ****1234",
                    Balance = 0,
                },
            },
        ];
        Meta expectedMeta = new()
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = MetaSortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };
        ApiEnum<string, ResponseType> expectedResponseType = ResponseType.Object;

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
        var model = new PaymentSummaryPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Amount = 10000,
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Currency = "currency",
                    Description = "Invoice payment for 100 widgets",
                    ExternalID = "external_id",
                    FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                    Paykey = "paykey",
                    PaymentDate = "2019-12-27",
                    PaymentType = DataPaymentType.Charge,
                    Status = Status.Created,
                    StatusDetails = new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Payment successfully created and awaiting validation.",
                        Reason = Reason.InsufficientFunds,
                        Source = Source.System,
                        Code = null,
                    },
                    TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    CustomerDetails = new()
                    {
                        ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        CustomerType = CustomerType.Individual,
                        Email = "ron@swanson.com",
                        Name = "Ron Swanson",
                        Phone = "+1234567890",
                    },
                    EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    PaykeyDetails = new()
                    {
                        ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        Label = "Bank of America ****1234",
                        Balance = 0,
                    },
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
                SortOrder = MetaSortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = ResponseType.Object,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new PaymentSummaryPagedV1
        {
            Data =
            [
                new()
                {
                    ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    Amount = 10000,
                    CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    Currency = "currency",
                    Description = "Invoice payment for 100 widgets",
                    ExternalID = "external_id",
                    FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
                    Paykey = "paykey",
                    PaymentDate = "2019-12-27",
                    PaymentType = DataPaymentType.Charge,
                    Status = Status.Created,
                    StatusDetails = new()
                    {
                        ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                        Message = "Payment successfully created and awaiting validation.",
                        Reason = Reason.InsufficientFunds,
                        Source = Source.System,
                        Code = null,
                    },
                    TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
                    UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    CustomerDetails = new()
                    {
                        ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        CustomerType = CustomerType.Individual,
                        Email = "ron@swanson.com",
                        Name = "Ron Swanson",
                        Phone = "+1234567890",
                    },
                    EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                    FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                    PaykeyDetails = new()
                    {
                        ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                        Label = "Bank of America ****1234",
                        Balance = 0,
                    },
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
                SortOrder = MetaSortOrder.Asc,
                TotalItems = 0,
                TotalPages = 0,
            },
            ResponseType = ResponseType.Object,
        };

        PaymentSummaryPagedV1 copied = new(model);

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
            Amount = 10000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Invoice payment for 100 widgets",
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            PaymentType = DataPaymentType.Charge,
            Status = Status.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Reason.InsufficientFunds,
                Source = Source.System,
                Code = null,
            },
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },
        };

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedAmount = 10000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedCurrency = "currency";
        string expectedDescription = "Invoice payment for 100 widgets";
        string expectedExternalID = "external_id";
        List<string> expectedFundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"];
        string expectedPaykey = "paykey";
        string expectedPaymentDate = "2019-12-27";
        ApiEnum<string, DataPaymentType> expectedPaymentType = DataPaymentType.Charge;
        ApiEnum<string, Status> expectedStatus = Status.Created;
        StatusDetailsV1 expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.System,
            Code = null,
        };
        Dictionary<string, string> expectedTraceIds = new() { { "foo", "string" } };
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        CustomerDetailsV1 expectedCustomerDetails = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerType = CustomerType.Individual,
            Email = "ron@swanson.com",
            Name = "Ron Swanson",
            Phone = "+1234567890",
        };
        DateTimeOffset expectedEffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedFundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        PaykeyDetailsV1 expectedPaykeyDetails = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Label = "Bank of America ****1234",
            Balance = 0,
        };

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAmount, model.Amount);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedCurrency, model.Currency);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedExternalID, model.ExternalID);
        Assert.Equal(expectedFundingIds.Count, model.FundingIds.Count);
        for (int i = 0; i < expectedFundingIds.Count; i++)
        {
            Assert.Equal(expectedFundingIds[i], model.FundingIds[i]);
        }
        Assert.Equal(expectedPaykey, model.Paykey);
        Assert.Equal(expectedPaymentDate, model.PaymentDate);
        Assert.Equal(expectedPaymentType, model.PaymentType);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedStatusDetails, model.StatusDetails);
        Assert.Equal(expectedTraceIds.Count, model.TraceIds.Count);
        foreach (var item in expectedTraceIds)
        {
            Assert.True(model.TraceIds.TryGetValue(item.Key, out var value));

            Assert.Equal(value, model.TraceIds[item.Key]);
        }
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
        Assert.Equal(expectedCustomerDetails, model.CustomerDetails);
        Assert.Equal(expectedEffectiveAt, model.EffectiveAt);
        Assert.Equal(expectedFundingID, model.FundingID);
        Assert.Equal(expectedPaykeyDetails, model.PaykeyDetails);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Invoice payment for 100 widgets",
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            PaymentType = DataPaymentType.Charge,
            Status = Status.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Reason.InsufficientFunds,
                Source = Source.System,
                Code = null,
            },
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
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
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Invoice payment for 100 widgets",
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            PaymentType = DataPaymentType.Charge,
            Status = Status.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Reason.InsufficientFunds,
                Source = Source.System,
                Code = null,
            },
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        int expectedAmount = 10000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedCurrency = "currency";
        string expectedDescription = "Invoice payment for 100 widgets";
        string expectedExternalID = "external_id";
        List<string> expectedFundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"];
        string expectedPaykey = "paykey";
        string expectedPaymentDate = "2019-12-27";
        ApiEnum<string, DataPaymentType> expectedPaymentType = DataPaymentType.Charge;
        ApiEnum<string, Status> expectedStatus = Status.Created;
        StatusDetailsV1 expectedStatusDetails = new()
        {
            ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Message = "Payment successfully created and awaiting validation.",
            Reason = Reason.InsufficientFunds,
            Source = Source.System,
            Code = null,
        };
        Dictionary<string, string> expectedTraceIds = new() { { "foo", "string" } };
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        CustomerDetailsV1 expectedCustomerDetails = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerType = CustomerType.Individual,
            Email = "ron@swanson.com",
            Name = "Ron Swanson",
            Phone = "+1234567890",
        };
        DateTimeOffset expectedEffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z");
        string expectedFundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        PaykeyDetailsV1 expectedPaykeyDetails = new()
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Label = "Bank of America ****1234",
            Balance = 0,
        };

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAmount, deserialized.Amount);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedCurrency, deserialized.Currency);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedExternalID, deserialized.ExternalID);
        Assert.Equal(expectedFundingIds.Count, deserialized.FundingIds.Count);
        for (int i = 0; i < expectedFundingIds.Count; i++)
        {
            Assert.Equal(expectedFundingIds[i], deserialized.FundingIds[i]);
        }
        Assert.Equal(expectedPaykey, deserialized.Paykey);
        Assert.Equal(expectedPaymentDate, deserialized.PaymentDate);
        Assert.Equal(expectedPaymentType, deserialized.PaymentType);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedStatusDetails, deserialized.StatusDetails);
        Assert.Equal(expectedTraceIds.Count, deserialized.TraceIds.Count);
        foreach (var item in expectedTraceIds)
        {
            Assert.True(deserialized.TraceIds.TryGetValue(item.Key, out var value));

            Assert.Equal(value, deserialized.TraceIds[item.Key]);
        }
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
        Assert.Equal(expectedCustomerDetails, deserialized.CustomerDetails);
        Assert.Equal(expectedEffectiveAt, deserialized.EffectiveAt);
        Assert.Equal(expectedFundingID, deserialized.FundingID);
        Assert.Equal(expectedPaykeyDetails, deserialized.PaykeyDetails);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Invoice payment for 100 widgets",
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            PaymentType = DataPaymentType.Charge,
            Status = Status.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Reason.InsufficientFunds,
                Source = Source.System,
                Code = null,
            },
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Invoice payment for 100 widgets",
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            PaymentType = DataPaymentType.Charge,
            Status = Status.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Reason.InsufficientFunds,
                Source = Source.System,
                Code = null,
            },
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        Assert.Null(model.CustomerDetails);
        Assert.False(model.RawData.ContainsKey("customer_details"));
        Assert.Null(model.PaykeyDetails);
        Assert.False(model.RawData.ContainsKey("paykey_details"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Invoice payment for 100 widgets",
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            PaymentType = DataPaymentType.Charge,
            Status = Status.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Reason.InsufficientFunds,
                Source = Source.System,
                Code = null,
            },
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Invoice payment for 100 widgets",
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            PaymentType = DataPaymentType.Charge,
            Status = Status.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Reason.InsufficientFunds,
                Source = Source.System,
                Code = null,
            },
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",

            // Null should be interpreted as omitted for these properties
            CustomerDetails = null,
            PaykeyDetails = null,
        };

        Assert.Null(model.CustomerDetails);
        Assert.False(model.RawData.ContainsKey("customer_details"));
        Assert.Null(model.PaykeyDetails);
        Assert.False(model.RawData.ContainsKey("paykey_details"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Invoice payment for 100 widgets",
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            PaymentType = DataPaymentType.Charge,
            Status = Status.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Reason.InsufficientFunds,
                Source = Source.System,
                Code = null,
            },
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",

            // Null should be interpreted as omitted for these properties
            CustomerDetails = null,
            PaykeyDetails = null,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Invoice payment for 100 widgets",
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            PaymentType = DataPaymentType.Charge,
            Status = Status.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Reason.InsufficientFunds,
                Source = Source.System,
                Code = null,
            },
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },
        };

        Assert.Null(model.EffectiveAt);
        Assert.False(model.RawData.ContainsKey("effective_at"));
        Assert.Null(model.FundingID);
        Assert.False(model.RawData.ContainsKey("funding_id"));
    }

    [Fact]
    public void OptionalNullablePropertiesUnsetValidation_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Invoice payment for 100 widgets",
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            PaymentType = DataPaymentType.Charge,
            Status = Status.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Reason.InsufficientFunds,
                Source = Source.System,
                Code = null,
            },
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullAreSetToNull_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Invoice payment for 100 widgets",
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            PaymentType = DataPaymentType.Charge,
            Status = Status.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Reason.InsufficientFunds,
                Source = Source.System,
                Code = null,
            },
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },

            EffectiveAt = null,
            FundingID = null,
        };

        Assert.Null(model.EffectiveAt);
        Assert.True(model.RawData.ContainsKey("effective_at"));
        Assert.Null(model.FundingID);
        Assert.True(model.RawData.ContainsKey("funding_id"));
    }

    [Fact]
    public void OptionalNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Invoice payment for 100 widgets",
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            PaymentType = DataPaymentType.Charge,
            Status = Status.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Reason.InsufficientFunds,
                Source = Source.System,
                Code = null,
            },
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },

            EffectiveAt = null,
            FundingID = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Data
        {
            ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            Amount = 10000,
            CreatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            Currency = "currency",
            Description = "Invoice payment for 100 widgets",
            ExternalID = "external_id",
            FundingIds = ["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],
            Paykey = "paykey",
            PaymentDate = "2019-12-27",
            PaymentType = DataPaymentType.Charge,
            Status = Status.Created,
            StatusDetails = new()
            {
                ChangedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
                Message = "Payment successfully created and awaiting validation.",
                Reason = Reason.InsufficientFunds,
                Source = Source.System,
                Code = null,
            },
            TraceIds = new Dictionary<string, string>() { { "foo", "string" } },
            UpdatedAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            CustomerDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerType = CustomerType.Individual,
                Email = "ron@swanson.com",
                Name = "Ron Swanson",
                Phone = "+1234567890",
            },
            EffectiveAt = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            FundingID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            PaykeyDetails = new()
            {
                ID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                CustomerID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
                Label = "Bank of America ****1234",
                Balance = 0,
            },
        };

        Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DataPaymentTypeTest : TestBase
{
    [Theory]
    [InlineData(DataPaymentType.Charge)]
    [InlineData(DataPaymentType.Payout)]
    public void Validation_Works(DataPaymentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataPaymentType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataPaymentType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(DataPaymentType.Charge)]
    [InlineData(DataPaymentType.Payout)]
    public void SerializationRoundtrip_Works(DataPaymentType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataPaymentType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataPaymentType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataPaymentType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataPaymentType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class StatusTest : TestBase
{
    [Theory]
    [InlineData(Status.Created)]
    [InlineData(Status.Scheduled)]
    [InlineData(Status.Failed)]
    [InlineData(Status.Cancelled)]
    [InlineData(Status.OnHold)]
    [InlineData(Status.Pending)]
    [InlineData(Status.Paid)]
    [InlineData(Status.Reversed)]
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
    [InlineData(Status.Scheduled)]
    [InlineData(Status.Failed)]
    [InlineData(Status.Cancelled)]
    [InlineData(Status.OnHold)]
    [InlineData(Status.Pending)]
    [InlineData(Status.Paid)]
    [InlineData(Status.Reversed)]
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

public class MetaTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Meta
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = MetaSortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };

        string expectedApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedApiRequestTimestamp = DateTimeOffset.Parse(
            "2019-12-27T18:11:19.117Z"
        );
        int expectedMaxPageSize = 0;
        int expectedPageNumber = 0;
        int expectedPageSize = 0;
        string expectedSortBy = "sort_by";
        ApiEnum<string, MetaSortOrder> expectedSortOrder = MetaSortOrder.Asc;
        int expectedTotalItems = 0;
        int expectedTotalPages = 0;

        Assert.Equal(expectedApiRequestID, model.ApiRequestID);
        Assert.Equal(expectedApiRequestTimestamp, model.ApiRequestTimestamp);
        Assert.Equal(expectedMaxPageSize, model.MaxPageSize);
        Assert.Equal(expectedPageNumber, model.PageNumber);
        Assert.Equal(expectedPageSize, model.PageSize);
        Assert.Equal(expectedSortBy, model.SortBy);
        Assert.Equal(expectedSortOrder, model.SortOrder);
        Assert.Equal(expectedTotalItems, model.TotalItems);
        Assert.Equal(expectedTotalPages, model.TotalPages);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Meta
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = MetaSortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Meta>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Meta
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = MetaSortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Meta>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e";
        DateTimeOffset expectedApiRequestTimestamp = DateTimeOffset.Parse(
            "2019-12-27T18:11:19.117Z"
        );
        int expectedMaxPageSize = 0;
        int expectedPageNumber = 0;
        int expectedPageSize = 0;
        string expectedSortBy = "sort_by";
        ApiEnum<string, MetaSortOrder> expectedSortOrder = MetaSortOrder.Asc;
        int expectedTotalItems = 0;
        int expectedTotalPages = 0;

        Assert.Equal(expectedApiRequestID, deserialized.ApiRequestID);
        Assert.Equal(expectedApiRequestTimestamp, deserialized.ApiRequestTimestamp);
        Assert.Equal(expectedMaxPageSize, deserialized.MaxPageSize);
        Assert.Equal(expectedPageNumber, deserialized.PageNumber);
        Assert.Equal(expectedPageSize, deserialized.PageSize);
        Assert.Equal(expectedSortBy, deserialized.SortBy);
        Assert.Equal(expectedSortOrder, deserialized.SortOrder);
        Assert.Equal(expectedTotalItems, deserialized.TotalItems);
        Assert.Equal(expectedTotalPages, deserialized.TotalPages);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Meta
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = MetaSortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Meta
        {
            ApiRequestID = "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e",
            ApiRequestTimestamp = DateTimeOffset.Parse("2019-12-27T18:11:19.117Z"),
            MaxPageSize = 0,
            PageNumber = 0,
            PageSize = 0,
            SortBy = "sort_by",
            SortOrder = MetaSortOrder.Asc,
            TotalItems = 0,
            TotalPages = 0,
        };

        Meta copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class MetaSortOrderTest : TestBase
{
    [Theory]
    [InlineData(MetaSortOrder.Asc)]
    [InlineData(MetaSortOrder.Desc)]
    public void Validation_Works(MetaSortOrder rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, MetaSortOrder> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, MetaSortOrder>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<StraddleInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(MetaSortOrder.Asc)]
    [InlineData(MetaSortOrder.Desc)]
    public void SerializationRoundtrip_Works(MetaSortOrder rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, MetaSortOrder> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, MetaSortOrder>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, MetaSortOrder>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, MetaSortOrder>>(
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
