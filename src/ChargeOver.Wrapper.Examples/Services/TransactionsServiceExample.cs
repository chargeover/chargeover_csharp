using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;

namespace ChargeOver.Wrapper.Examples.Services
{
	public sealed class TransactionsServiceExample : IServiceExample
	{
		private readonly ITransactionsService _transactionsService;
		private readonly ICustomersService _customersService;
		private readonly ICreditCardsService _creditCardsService;

		public TransactionsServiceExample()
		{
			_transactionsService = new TransactionsService();
			_customersService = new CustomersService();
			_creditCardsService = new CreditCardsService();
		}

		public void Run()
		{
			var customerId = AddCustomer();
			int creditcardId = StoreCreditCard(customerId);
			var request = new AttemptPayment
			{
				Amount = 10,
				CustomerId = customerId,
				Paymentods = new[]
				{
					new Paymentod
					{
						CreditcardId = creditcardId
					}
				}
			};

			var result = _transactionsService.AttemptPayment(request);

			if (!result.IsSuccess()) throw new Exception("Attempt payment failed.");

			Console.WriteLine("Payment attempt with id: " + result.Id);
		}

		private int AddCustomer()
		{
			return _customersService.CreateCustomer(new Customer
			{
				Company = "Test Company Name",
				BillAddr1 = "16 Dog Lane",
				BillAddr2 = "Suite D",
				BillCity = "Storrs",
				BillState = "CT"
			}).Id;
		}

		private int StoreCreditCard(int customerId)
		{
			return _creditCardsService.StoreCreditCard(new StoreCreditCard
			{
				CustomerId = customerId,
				Number = "4111 1111 1111 1111",
				ExpdateYear = (DateTime.UtcNow.Year + 1).ToString(),
				ExpdateMonth = "11",
				Name = "Keith Palmer",
				Address = "72 E Blue Grass Road",
				City = "Willington",
				//state = "CT"
				Postcode = "06279",
				Country = "United States",
			}).Id;
		}
	}
}