using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;

namespace ChargeOver.Wrapper.Examples.Services
{
	public sealed class ACHeCheckAccountsServiceExample : IServiceExample
	{
		private readonly IACHeCheckAccountsService _service;

		public ACHeCheckAccountsServiceExample()
		{
			_service = new ACHeCheckAccountsService();
		}

		public void Run()
		{
			var request = new StoreACHAccount
			{
				CustomerId = 1,
				Type = "chec",
				Number = "856667",
				Routing = "072403004",
			};

			var result = _service.StoreACHAccount(request);

			if (!result.IsSuccess()) throw new Exception("Store ACH failed.");

			Console.WriteLine("ACHe with id: " + result.Id);
		}
	}
}