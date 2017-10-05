using System;
using System.Linq;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;

namespace ChargeOver.Wrapper.Examples.Services
{
	public sealed class SubscriptionServiceExample : IServiceExample
	{
		private readonly ISubscriptionsService _service;
		private readonly ICustomersService _customersService;

		public SubscriptionServiceExample()
		{
			_service = new SubscriptionsService();
			_customersService = new CustomersService();
		}

		public void Run()
		{
			var examples = new Action[] { CreateSubscription, GetSubscriptionByPackageId };

			foreach (var example in examples)
			{
				example();
			}
		}

		private void CreateSubscription()
		{
			var result = CreateNewSubscription();

			if (!result.IsSuccess()) throw new Exception("Create subscription failed.");

			Console.WriteLine("Subscription created with id: " + result.Id);
		}

		private IIdentityResponse CreateNewSubscription()
		{
			var subscription = new Subscription
			{
				CustomerId = TakeCustomerId(),
				HoldUntilDatetime = DateTime.Parse("2018-10-01")
			};

			var line1 = new SubscriptionLineItem
			{
				LineQuantity = 5, 
				ItemId = 1,
				Tierset = new Tierset
				{
					Base = 25.95, 
					PriceModel = "vol", 
					Setup = 100.0,
					Tiers = new[] {
						new Tier
						{
							UnitFrom = 1, 
							UnitTo = 10, 
							Amount = 2.95
						},
						new Tier
						{
							UnitFrom = 11,
							UnitTo = 20,
							Amount = 1.95
						}
					}
				}
			};

			var line2 = new SubscriptionLineItem
			{
				ItemId = 2
			};

			subscription.LineItems = new[] { line1, line2 };

			var result = _service.CreateSubscription(subscription);
			return result;
		}

		private void GetSubscriptionByPackageId()
		{
			var subscription = CreateNewSubscription();
			var result = _service.QuerySubscriptions(new[] { "package_id:EQUALS:" + subscription.Id });

			Console.WriteLine($"Subscriptions found 'by id': {result.Response.Count()}");
		}

		private int TakeCustomerId()
		{
			var id = _customersService.CreateCustomer(new Customer
			{
				Company = "Test Company Name",
				BillAddr1 = "16 Dog Lane",
				BillAddr2 = "Suite D",
				BillCity = "Storrs",
				BillState = "CT",
			}).Id;

			return id;
		}
	}
}