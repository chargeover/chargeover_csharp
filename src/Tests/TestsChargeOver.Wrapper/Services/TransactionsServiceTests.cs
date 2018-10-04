using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class TransactionsServiceTests : BaseServiceTests<TransactionsService>
	{
		protected override TransactionsService Initialize(IChargeOverAPIConfiguration config)
		{
			return new TransactionsService(config);
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

				// newest, or 'best fit' invoices (based on amount/date).
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
			var actual = Sut.GetTransaction(AddTransaction());
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
			var actual = Sut.QueryTransactions(limit: 5);
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
			int creditcardId = StoreCreditCard(customerId);
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
				TransactionDate = DateTime.Parse("2016-08-16")
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
			var customer = AddCustomer();
			var cardId = StoreCreditCard(customer);
			var payment = AttemptPayment(customer, cardId);
			//act
			var actual = Sut.RefundPayment(payment, request);
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
			var customer = AddCustomer();
			//act
			var actual = Sut.EmailReceipt(AddTransaction(customer), request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		private int AddTransaction(int? customer = null)
		{
			if (!customer.HasValue)
				customer = AddCustomer();

			return Sut.CreatePayment(new Payment
			{
				CustomerId = customer,
				GatewayId = 1,
				GatewayStatus = 1,
				GatewayTransid = "abcd1234",
				GatewayMsg = "test gateway message",
				GatewayMethod = "credit",
				Amount = 15.95F,
				TransactionType = "pay",
				TransactionDetail = "here are some details",
				TransactionDatetime = DateTime.Parse("2013-06-20 18:48:17"),

				// newest, or 'best fit' invoices (based on amount/date).
				AutoApply = "best_fit"
			}).Id;
		}

		private int AddCustomer()
		{
			return new CustomersService(Config).CreateCustomer(new Customer
			{
				Company = "Test Company Name",
				BillAddr1 = "16 Dog Lane",
				BillAddr2 = "Suite D",
				BillCity = "Storrs",
				BillState = "CT"
			}).Id;
		}

		private int StoreCreditCard(int customerId)
		{
			return new CreditCardsService(Config).StoreCreditCard(new StoreCreditCard
			{
				CustomerId = customerId,
				Number = "4111 1111 1111 1111",
				ExpirationDateYear = (DateTime.UtcNow.Year + 1).ToString(),
				ExpirationDateMonth = "11",
				Name = "Keith Palmer",
				Address = "72 E Blue Grass Road",
				City = "Willington",
				//state = "CT"
				PostalCode = "06279",
				Country = "United States",
			}).Id;
		}

		private int AttemptPayment(int customerId, int crediCardId)
		{
			return Sut.AttemptPayment(new AttemptPayment
			{
				Amount = 10,
				CustomerId = customerId,
				PayMethods = new[]
				{
					new PayMethod
					{
						CreditCardId = crediCardId
					}
				}
			}).Id;
		}
	}
}
