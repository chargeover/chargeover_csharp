using System;
using System.Linq;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class TransactionsServiceTests
	{
		private TransactionsService Sut { get; set; }

		[SetUp]
		public void SetUp()
		{
			Sut = new TransactionsService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
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
			var request = new AttemptPayment
			{
				CustomerId = 1,
				Comment = "Optional: You can optionally specify a list of payment methods to attempt, otherwise the already stored credit cards/bank accounts for the customer will be used",
				Amount = 15.95F,
				//AppliedTo = "[  {    "invoice_id": 16891  }]"
				//Paymethods = "[  {    "creditcard_id": 1234  },  {    "ach_id": 1235  }]"
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
				CustomerId = 83,
				GatewayStatus = 1,
				GatewayTransid = "abcd1234",
				GatewayMsg = "My test message",
				GatewayMethod = "visa",
				Amount = -50F,
				TransactionType = "ref",
				TransactionMethod = "Visa",
				TransactionDetail = "",
				TransactionDate = DateTime.Parse("2016-08-16"),
				//AppliedTo = "[  {    "invoice_id": 10099,    "applied": -50  }]"
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
			};
			//act
			var actual = Sut.RefundPayment(request);
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
			var actual = Sut.VoidTransaction();
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
			};
			//act
			var actual = Sut.EmailReceipt(request);
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
	}
}
