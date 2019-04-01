using System;
using System.Linq;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;

namespace ChargeOver.Wrapper.Examples.Services
{
    public sealed class TransactionsServiceExample : IServiceExample
    {
        private readonly ITransactionsService _transactionsService;
        private readonly ICustomersService _customersService;
        private readonly ICreditCardsService _creditCardsService;
        private readonly InvoicesService _invoicesService;
        private readonly IItemsService _itemsService;

        private int _customerId;

        public TransactionsServiceExample()
        {
            _transactionsService = new TransactionsService();
            _customersService = new CustomersService();
            _creditCardsService = new CreditCardsService();
            _invoicesService = new InvoicesService();
            _itemsService = new ItemsService();
        }

        public void Run()
        {
            this._customerId = AddCustomer();

            var examples = new Action[] { AttemptPaymentExample, GetTransactionByTransactionId, QueryTransactionByTransactionId };

            foreach (var example in examples)
            {
                example();
            }
        }

        public void GetTransactionByTransactionId()
        {
            var result = _transactionsService.GetTransaction(this.AttemptPayment());

            Console.WriteLine("Transaction ID we just got is: " + result.Response.TransactionId + " and is applied to " + result.Response.AppliedTo.Length + " invoices");

            for (var i = 0; i < result.Response.AppliedTo.Length; i++)
            {
                Console.WriteLine("  Applied to invoice " + result.Response.AppliedTo[i].InvoiceId);
            }


        }

        public void QueryTransactionByTransactionId()
        {
            var result = _transactionsService.QueryTransactions(new[] { "transaction_id:EQUALS:" + AttemptPayment() });

            Console.WriteLine("Transactions found by id: " + result.Response.Count());
        }

        public void AttemptPaymentExample()
        {
            var payment_id = this.AttemptPayment();

            Console.WriteLine("Transaction ID for payment is: " + payment_id);
        }

        public int AttemptPayment()
        {
            var customerId = this._customerId;
            int creditcardId = StoreCreditCard(customerId);
            int invoiceId = CreateInvoice(customerId);

            var request = new AttemptPayment
            {
                Amount = 10,
                CustomerId = customerId,
                PayMethods = new[]
                {
                    new PayMethod
                    {
                        CreditCardId = creditcardId
                    }
                },
                AppliedTo = new[]
                {
                    new TransactionAppliedTo
                    {
                        InvoiceId = invoiceId
                    }
                }
            };

            try
            {
                var result = _transactionsService.AttemptPayment(request);

                if (!result.IsSuccess()) throw new Exception("Attempt payment failed.");

                return result.Id;
            }
            catch (Exception)
            {

            }

            return 0;
        }

        private int CreateInvoice(int customerId)
        {
            var id = AddItem();

            var request = new Invoice
            {
                CustomerId = customerId,
                BillAddr1 = "72 E Blue Grass Road",
                BillCity = "Willington",
                BillState = "Connecticut",
                BillPostalCode = "06279",
                LineItems = new[]
                {
                    new InvoiceLineItem
                    {
                        Description = "My description goes here",
                        ItemId = id,
                        LineQuantity = 1,
                        LineRate = 10.00F
                    }
                }
            };
            var result = _invoicesService.CreateInvoice(request);
            return result.Id;
        }

        private int AddCustomer()
        {
            return _customersService.CreateCustomer(new Customer
            {
                Company = "Test Company Name",
                BillAddr1 = "16 Dog Lane",
                BillAddr2 = "Suite D",
                BillCity = "Storrs",
                BillState = "CT"
            }).Id;

        }

        private int AddItem()
        {
            var id = _itemsService.CreateItem(new Item
            {
                Name = "My Test Item " + Guid.NewGuid(),
                Type = "service",
                PriceModel = new ItemPriceModel
                {
                    Base = 295.95F,
                    PayCycle = "mon",
                    PriceModel = "fla"
                }
            }).Id;

            return id;
        }

        private int StoreCreditCard(int customerId)
        {
            return _creditCardsService.StoreCreditCard(new StoreCreditCard
            {
                CustomerId = customerId,
                Number = "4111 1111 1111 1111",
                ExpirationDateYear = (DateTime.UtcNow.Year + 1).ToString(),
                ExpirationDateMonth = "11",
                Name = "John Doe",
                Address = "72 E Blue Grass Road",
                City = "Willington",
                State = "CT",
                PostalCode = "06279",
                Country = "United States",
            }).Id;
        }
    }
}