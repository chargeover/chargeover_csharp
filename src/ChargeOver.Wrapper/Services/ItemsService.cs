using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class ItemsService : IItemsService
	{
		private readonly IChargeOverApiProvider _provider;

		public ItemsService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Create an item
		/// details: https://developer.chargeover.com/apidocs/rest/#create-item
		/// </summary>
		public IIdentityResponse CreateItem(Models.Item request)
		{
			var api = _provider.Create();

			var result = api.Raw("create", "/item ", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Querying for items
		/// details: https://developer.chargeover.com/apidocs/rest/#query-item
		/// </summary>
		public IResponse QueryingForItems(params string[] queries)
		{
			var api = _provider.Create();

			var result = api.Raw("find", "/item", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
