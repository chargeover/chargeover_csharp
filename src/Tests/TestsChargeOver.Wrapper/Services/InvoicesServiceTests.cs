using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class InvoicesServiceTests
	{
		private InvoicesService Sut { get; set; }

		[SetUp]
		public void SetUp()
		{
			Sut = new InvoicesService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
		}

		[Test]
		public void should_call_CreateInvoice()
		{
			//arrange
			var request = new Invoice
			{
				CustomerId = 1,
				BillAddr1 = "72 E Blue Grass Road",
				BillCity = "Willington",
				BillState = "Connecticut",
				BillPostcode = "06279",
				LineItems = new []
				{
					new InvoiceLineItem
					{
						Descrip = "My description goes here",
						ItemId = 307,
						LineQuantity = 12,
						LineRate = 29.95F
					}
				}
			};
			//act
			var actual = Sut.CreateInvoice(request);
			//assert
			Assert.AreEqual(201, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_UpdateInvoice()
		{
			//arrange
			var request = new UpdateInvoice
			{
				Date = DateTime.Parse("2015-06-08"),
				//LineItems = "[  {    "item_id": 3,    "line_rate": 29.95,    "line_quantity": 3,    "descrip": "Add this new line item to the invoice."  },  {    "line_item_id": 2575  }]"
			};
			//act
			var actual = Sut.UpdateInvoice(request);
			//assert
			Assert.AreEqual(202, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_GetSpecificInvoice()
		{
			//arrange
			//act
			var actual = Sut.GetSpecificInvoice();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_QueryForInvoices()
		{
			//arrange
			//act
			var actual = Sut.QueryForInvoices();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_CreditCardPayment()
		{
			//arrange
			var request = new CreditCardPayment
			{
				Number = "4111 1111 1111 1111",
				ExpdateYear = "2017",
				ExpdateMonth = "08",
				Name = "Keith Palmer",
				Address = "72 E Blue Grass Road",
				City = "Willington",
				State = "CT",
				Postcode = "06279",
				Country = "United States",
			};
			//act
			var actual = Sut.CreditCardPayment(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_ACHCheckpayment()
		{
			//arrange
			var request = new ACHCheckPayment
			{
				Number = "1234-1234-1234",
				Routing = "072403004",
				Name = "Keith Palmer",
				Type = "chec",
			};
			//act
			var actual = Sut.ACHCheckpayment(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_ApplyOpenCustomerBalance()
		{
			//arrange
			var request = new ApplyOpenCustomerBalance
			{
				UseCustomerBalance = "True",
			};
			//act
			var actual = Sut.ApplyOpenCustomerBalance(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_VoidInvoice()
		{
			//arrange
			//act
			var actual = Sut.VoidInvoice();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_EmailInvoice()
		{
			//arrange
			var request = new EmailInvoice
			{
			};
			//act
			var actual = Sut.EmailInvoice(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_PrintInvoice()
		{
			//arrange
			var request = new PrintInvoice
			{
			};
			//act
			var actual = Sut.PrintInvoice(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
