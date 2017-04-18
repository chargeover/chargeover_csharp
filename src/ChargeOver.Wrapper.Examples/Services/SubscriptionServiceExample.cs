using System;
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
			var subscription = new Subscription
			{
				CustomerId = TakeCustomerId(),
				HolduntilDatetime = DateTime.Parse("2013-10-01")
			};
			var result = _service.CreateSubscription(subscription);

			if (!result.IsSuccess()) throw new Exception("Create subscription failed.");

			Console.WriteLine("Subscription created with id: " + result.Id);
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