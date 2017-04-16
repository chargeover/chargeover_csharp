using System;
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
			var id = TakeItemId();
			var customer = TakeCustomerId();

			var request = new Invoice
			{
				CustomerId = customer,
				BillAddr1 = "72 E Blue Grass Road",
				BillCity = "Willington",
				BillState = "Connecticut",
				BillPostcode = "06279",
				LineItems = new[]
				{
					new InvoiceLineItem
					{
						Descrip = "My description goes here",
						ItemId = id,
						LineQuantity = 12,
						LineRate = 29.95F
					}
				}
			};
			var result = _service.CreateInvoice(request);

			if (!result.IsSuccess()) throw new Exception("Create invoice failed.");

			Console.WriteLine("Invoice created with id: " + result.Id);
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
				Pricemodel = new ItemPricemodel
				{
					Base = 295.95F,
					Paycycle = "mon",
					Pricemodel = "fla"
				}
			}).Id;

			return id;
		}
	}
}