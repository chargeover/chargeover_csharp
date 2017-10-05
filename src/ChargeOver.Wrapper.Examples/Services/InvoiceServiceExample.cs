using System;
using System.Linq;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;

namespace ChargeOver.Wrapper.Examples.Services
{
	public sealed class InvoiceServiceExample : IServiceExample
	{
		private readonly IInvoicesService _service;
		private readonly IItemsService _itemsService;
		private readonly ICustomersService _customersService;

		public InvoiceServiceExample()
		{
			_service = new InvoicesService();
			_itemsService = new ItemsService();
			_customersService = new CustomersService();
		}

		public void Run()
		{
			var examples = new Action[] { CreateInvoice, QueryInvoiceByInvoiceId };

			foreach (var example in examples)
			{
				example();
			}
		}

		private void CreateInvoice()
		{
			var result = CreateNewInvoice();

			if (!result.IsSuccess()) throw new Exception("Create invoice failed.");

			Console.WriteLine("Invoice created with id: " + result.Id);
		}

		private IIdentityResponse CreateNewInvoice()
		{
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
			var result = _service.CreateInvoice(request);
			return result;
		}

		private void QueryInvoiceByInvoiceId()
		{
			var result = _service.QueryInvoices(new[] { "invoice_id:EQUALS:" + CreateNewInvoice().Id });

			Console.WriteLine($"Invoices found by id: {result.Response.Count()}");
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

		private int TakeItemId()
		{
			var id = _itemsService.CreateItem(new Item
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
	}
}