using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class ACHeCheckAccountsService : IACHeCheckAccountsService
	{
		private readonly IChargeOverApiProvider _provider;

		public ACHeCheckAccountsService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Store an ACH account
		/// details: https://developer.chargeover.com/apidocs/rest/#create-ach
		/// </summary>
		public IIdentityResponse StoreACHAccount(StoreACHAccount request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/ach ", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Delete an ACH account
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-an-ach
		/// </summary>
		public IResponse DeleteACHAccount(int id)
		{
			var api = _provider.Create();

			var result = api.Raw("delete", "/ach", null, id);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
