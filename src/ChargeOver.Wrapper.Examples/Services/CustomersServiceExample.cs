using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;

namespace ChargeOver.Wrapper.Examples.Services
{
	public sealed class CustomersServiceExample : IServiceExample
	{
		private readonly ICustomersService _service;

		public CustomersServiceExample()
		{
			_service = new CustomersService();
		}

		public void Run()
		{
			var customer = new Customer
			{
				Company = "Test Company Name",
				BillAddr1 = "16 Dog Lane",
				BillAddr2 = "Suite D",
				BillCity = "Storrs",
			};

			var result = _service.CreateCustomer(customer);

			if (!result.IsSuccess()) throw new Exception("Create customer failed.");

			Console.WriteLine("Customer created with id: " + result.Id);
		}
	}
}
