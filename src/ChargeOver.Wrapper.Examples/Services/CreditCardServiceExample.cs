using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;

namespace ChargeOver.Wrapper.Examples.Services
{
	public sealed class CreditCardServiceExample : IServiceExample
	{
		private readonly ICreditCardsService _service;

		public CreditCardServiceExample()
		{
			_service = new CreditCardsService();
		}

		public void Run()
		{
			var request = new StoreCreditCard
			{
				CustomerId = 1,
				Number = "4111 1111 1111 1111",
				ExpirationDateYear = (DateTime.UtcNow.Year + 1).ToString(),
				ExpirationDateMonth = "11",
				Name = "Keith Palmer",
				Address = "72 E Blue Grass Road",
				City = "Willington",
				State = "CT",
				PostalCode = "06279",
				Country = "United States",
			};

			var result = _service.StoreCreditCard(request);

			if (!result.IsSuccess()) throw new Exception("Store credit card failed.");

			Console.WriteLine("Credit card with id: " + result.Id);
		}
	}
}