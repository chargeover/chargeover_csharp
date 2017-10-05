using System;
using System.Collections.Generic;
using System.Linq;
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
			var examples = new List<Action>
			{
				CreateCustomer,QueryCustomerByName,QueryCustomerByEmail
			};

			foreach (var example in examples)
			{
				example();
			}
		}

		private void CreateCustomer()
		{
			var customer = new Customer
			{
				Company = "Test Company Name",
				BillAddr1 = "16 Dog Lane",
				BillAddr2 = "Suite D",
				BillCity = "Storrs",
				SuperUserName = "Name",
				SuperUserEmail = "mail@mail.com"
			};

			var result = _service.CreateCustomer(customer);

			if (!result.IsSuccess()) throw new Exception("Create customer failed.");

			Console.WriteLine("Customer created with id: " + result.Id);
		}

		private void QueryCustomerByName()
		{
			var result = _service.QueryCustomers(new[] { "company:EQUALS:Name" });

			Console.WriteLine($"Customers found 'by name': {result.Response.Count()}");
		}

		private void QueryCustomerByEmail()
		{
			var result = _service.QueryCustomers(new[] { "superuser_email:EQUALS:mail@mail.com" });

			Console.WriteLine($"Customers found 'by email': {result.Response.Count()}");
		}
	}
}
