using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class UsageServiceTests : BaseServiceTests<UsageService>
	{
		protected override UsageService Initialize(IChargeOverAPIConfiguration config)
		{
			return new UsageService(config);
		}

		[Test]
		public void should_call_StoringUsageData()
		{
			//arrange
			var customerId = CreateCustomer();
			var itemId = TakeItemId();
			var lineItemId = CreateLineItemFromSubscription(customerId, itemId);

			var request = new StoringUsageData
			{
				LineItemId = lineItemId,
				UsageValue = 265.2F,
				From = DateTime.Parse("2013-10-16"),
				To = DateTime.Parse("2013-10-16")
			};
			//act
			var actual = Sut.StoringUsageData(request);
			//assert
			Assert.AreEqual(201, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		private int CreateCustomer()
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

		private int CreateLineItemFromSubscription(int customerId, int itemId)
		{
			var subscriptionsService = new SubscriptionsService(Config);
			var subscriptionId = subscriptionsService.CreateSubscription(new Subscription
			{
				CustomerId = customerId,
				HolduntilDatetime = DateTime.Parse("2013-10-01"),
				LineItems = new[]
				{
					new InvoiceLineItem
					{
						Descrip = "desc",
						ItemId = itemId
					}
				}
			}).Id;

			return subscriptionsService.GetSpecificSubscription(subscriptionId).Response.LineItems[0].LineItemId;
		}

		private int TakeItemId()
		{
			return new ItemsService(Config).CreateItem(new Item
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
		}
	}
}
