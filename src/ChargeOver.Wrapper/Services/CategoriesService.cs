using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class CategoriesService : ICategoriesService
	{
		private readonly IChargeOverApiProvider _provider;

		public CategoriesService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Query for categories
		/// details: https://developer.chargeover.com/apidocs/rest/#list-category
		/// </summary>
		public IResponse QueryForCategories(params string[] queries)
		{
			var api = _provider.Create();

			var result = api.Raw("find", "/item_category", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
