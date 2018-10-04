using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class InvoicesServiceTests : BaseServiceTests<InvoicesService>
	{
		protected override InvoicesService Initialize(IChargeOverAPIConfiguration config)
		{
			return new InvoicesService(config);
		}

		[Test]
		public void should_call_CreateInvoice()
		{
			//arrange
			var id = TakeItemId();
			var customer = TakeCustomerId();

			var request = new Invoice
			{
				CustomerId = customer,
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
				LineItems = new[]
				{
					new InvoiceLineItem
					{
						Description = "Add this new line item to the invoice.",
						ItemId = TakeItemId(),
						LineQuantity = 3,
						LineRate = 29.95F
					}
				}
			};
			//act
			var actual = Sut.UpdateInvoice(TakeInvoice(), request);
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
			var actual = Sut.GetInvoice(TakeInvoice());
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
			var actual = Sut.QueryInvoices();
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
				ExpirationDateYear = "2017",
				ExpirationDateMonth = "08",
				Name = "Keith Palmer",
				Address = "72 E Blue Grass Road",
				City = "Willington",
				State = "CT",
				PostalCode = "06279",
				Country = "United States",
			};
			//act
			var actual = Sut.CreditCardPayment(TakeInvoice(), request);
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
				Number = "856667",
				Routing = "072403004",
				Name = "Keith Palmer",
				Type = "chec",
			};
			//act
			var actual = Sut.ACHCheckpayment(TakeInvoice(), request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_ApplyOpenCustomerBalance()
		{
			//arrange
			var customerId = TakeCustomerId();
			var cardId = StoreCard(customerId);
			AttempPayment(customerId, cardId);
			var invoiceId = TakeInvoice(customerId);

			var request = new ApplyOpenCustomerBalance
			{
				UseCustomerBalance = true,
			};
			//act
			var actual = Sut.ApplyOpenCustomerBalance(invoiceId, request);
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
			var actual = Sut.VoidInvoice(TakeInvoice());
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
				Email = "mail@mail.com"
			};
			//act
			var actual = Sut.EmailInvoice(TakeInvoice(), request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_PrintInvoice()
		{
			//arrange
			var request = new PrintInvoice();
			//act
			var actual = Sut.PrintInvoice(TakeInvoice(), request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		private int TakeCustomerId()
		{
			var id = new CustomersService(Config).CreateCustomer(new Customer
			{
				Company = "Test Company Name",
				BillAddr1 = "16 Dog Lane",
				BillAddr2 = "Suite D",
				BillCity = "Storrs",
				BillState = "CT",
			}).Id;

			return id;
		}

		private int TakeItemId()
		{
			var id = new ItemsService(Config).CreateItem(new Item
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

		private int StoreCard(int customerId)
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

		private int TakeInvoice(int? customer = null)
		{
			var id = TakeItemId();
			if (!customer.HasValue)
				customer = TakeCustomerId();

			var request = new Invoice
			{
				CustomerId = customer,
				BillAddr1 = "72 E Blue Grass Road",
				BillCity = "Willington",
				BillState = "Connecticut",
				BillPostalCode = "06279",
				BillCountry = "US",
				ShipCountry = "US",
				LineItems = new[]
				{
					new InvoiceLineItem
					{
						Description = "My description goes here",
						ItemId = id,
						LineQuantity = 12,
						LineRate = 29.95F
					}
				}
			};

			return Sut.CreateInvoice(request).Id;
		}

		private void AttempPayment(int customerId, int creditcardId)
		{
			new TransactionsService(Config).AttemptPayment(new AttemptPayment
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
			});
		}
	}
}
