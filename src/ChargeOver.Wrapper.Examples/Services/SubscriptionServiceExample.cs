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
				HolduntilDatetime = DateTime.Parse("2013-10-01")
			};
			var result = _service.CreateSubscription(subscription);
			return result;
		}

		private void GetSubscriptionByPackageId()
		{
			var subscription = CreateNewSubscription();
			var result = _service.QueryingForSubscriptions(new[] { "package_id:EQUALS:" + subscription.Id });

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