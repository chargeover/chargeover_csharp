using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class TransactionsServiceTests : BaseServiceTests<TransactionsService>
	{
		protected override TransactionsService Initialize(IChargeOverApiProvider provider)
		{
			return new TransactionsService(provider);
		}

		[Test]
		public void should_call_CreatePayment()
		{
			//arrange
			var request = new Payment
			{
				CustomerId = 1,
				GatewayId = 1,
				GatewayStatus = 1,
				GatewayTransid = "abcd1234",
				GatewayMsg = "test gateway message",
				GatewayMethod = "check",
				Amount = 15.95F,
				TransactionType = "pay",
				TransactionDetail = "here are some details",
				TransactionDatetime = DateTime.Parse("2013-06-20 18:48:17"),
				Comment = "	newest, or 'best fit' invoices (based on amount/date).",
				//AppliedTo = new[]
				//{
				//	new AppliedInvoide
				//	{
				//		InvoiceId = 10071,
				//		Applied = 10.95F
				//	}
				//},
				AutoApply = "best_fit"
			};
			//act
			var actual = Sut.CreatePayment(request);
			//assert
			Assert.AreEqual(201, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_GetSpecificTransaction()
		{
			//arrange
			//act
			var actual = Sut.GetSpecificTransaction(AddTransaction());
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_ListTransactions()
		{
			//arrange
			//act
			var actual = Sut.ListTransactions();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_QueryForTransactions()
		{
			//arrange
			//act
			var actual = Sut.QueryForTransactions(limit: 5);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_AttemptPayment()
		{
			//arrange
			var customerId = AddCustomer();
			AddPayment(customerId);
			var request = new AttemptPayment
			{
				CustomerId = customerId,
				Comment = "Optional: You can optionally specify a list of payment methods to attempt, otherwise the already stored credit cards/bank accounts for the customer will be used",
				Amount = 15.95F,
				AppliedTo = new[]
				{
					new AttemptInvoiceData
					{
						InvoiceId = TakeInvoice(customerId)
					}
				}
			};
			//act
			var actual = Sut.AttemptPayment(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_CreateRefund()
		{
			//arrange
			var request = new Refund
			{
				CustomerId = 1,
				GatewayStatus = 1,
				GatewayTransid = "abcd1234",
				GatewayMsg = "My test message",
				GatewayMethod = "visa",
				Amount = -50F,
				TransactionType = "ref",
				TransactionMethod = "Visa",
				TransactionDetail = "",
				TransactionDate = DateTime.Parse("2016-08-16"),
				//AppliedTo = new[]
				//{
				//	new AppliedInvoide
				//	{
				//		InvoiceId = 10099,
				//		Applied = -50
				//	}
				//}
			};
			//act
			var actual = Sut.CreateRefund(request);
			//assert
			Assert.AreEqual(201, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_RefundPayment()
		{
			//arrange
			var request = new RefundPayment
			{
				Amount = 10
			};
			//act
			var actual = Sut.RefundPayment(AddTransaction(), request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_VoidTransaction()
		{
			//arrange
			//act
			var actual = Sut.VoidTransaction(AddTransaction());
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_EmailReceipt()
		{
			//arrange
			var request = new EmailInvoice
			{
				Email = "mail@mail.com"
			};
			//act
			var actual = Sut.EmailReceipt(AddTransaction(), request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		private int AddTransaction()
		{
			return Sut.CreatePayment(new Payment
			{
				CustomerId = 1,
				GatewayId = 1,
				GatewayStatus = 1,
				GatewayTransid = "abcd1234",
				GatewayMsg = "test gateway message",
				GatewayMethod = "check",
				Amount = 15.95F,
				TransactionType = "pay",
				TransactionDetail = "here are some details",
				TransactionDatetime = DateTime.Parse("2013-06-20 18:48:17"),
				Comment = "	newest, or 'best fit' invoices (based on amount/date).",
				//AppliedTo = new[]
				//{
				//	new AppliedInvoide
				//	{
				//		InvoiceId = 10071,
				//		Applied = 10.95F
				//	}
				//},
				AutoApply = "best_fit"
			}).Id;
		}

		private int AddCustomer()
		{
			return new CustomersService(Provider).CreateCustomer(new Customer
			{
				Company = "Test Company Name",
				BillAddr1 = "16 Dog Lane",
				BillAddr2 = "Suite D",
				BillCity = "Storrs",
				BillState = "CT"
			}).Id;
		}

		private int TakeInvoice(int customer)
		{
			return new InvoicesService(Provider).CreateInvoice(new Invoice
			{
				CustomerId = customer,
				BillAddr1 = "72 E Blue Grass Road",
				BillCity = "Willington",
				BillState = "Connecticut",
				BillPostcode = "06279",
				LineItems = new[]
				{
					new InvoiceLineItem
					{
						Descrip = "My description goes here",
						ItemId = TakeItemId(),
						LineQuantity = 12,
						LineRate = 29.95F
					}
				}
			}).Id;
		}

		private int TakeItemId()
		{
			var id = new ItemsService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config)).CreateItem(new Item
			{
				Name = "My Test Item " + Guid.NewGuid(),
				Type = "service",
				Pricemodel = new ItemPricemodel
				{
					Base = 295.95F,
					Paycycle = "mon",
					Pricemodel = "fla"
				}
			}).Id;
			return id;
		}

		private void AddPayment(int customer)
		{
			Sut.CreatePayment(new Payment
			{
				CustomerId = customer,
				GatewayId = 1,
				GatewayStatus = 1,
				GatewayTransid = "abcd1234",
				GatewayMsg = "test gateway message",
				GatewayMethod = "check",
				Amount = 15.95F,
				TransactionType = "pay",
				TransactionDetail = "here are some details",
				TransactionDatetime = DateTime.Parse("2013-06-20 18:48:17"),
				Comment = "	newest, or 'best fit' invoices (based on amount/date).",
			});
		}
	}
}
