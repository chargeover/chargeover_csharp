using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class AdminWorkersService : IAdminWorkersService
	{
		private readonly IChargeOverApiProvider _provider;

		public AdminWorkersService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Get a list of admin workers
		/// details: https://developer.chargeover.com/apidocs/rest/#list-admins
		/// </summary>
		public IResponse<AdminWorkers> GetListAdminWorkers()
		{
			var api = _provider.Create();

			var result = api.Raw("get", "/admin", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<ChargeOverResponse<AdminWorkers>>(result.Item2);
			
			return new Models.Response<AdminWorkers>(resultObject);
		}

		/// <summary>
		/// Query for admin workers
		/// details: https://developer.chargeover.com/apidocs/rest/#query-admins
		/// </summary>
		public IResponse QueryForAdminWorkers(params string[] queries)
		{
			var api = _provider.Create();

			var result = api.Raw("find", "/admin", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Get a specific admin worker
		/// details: https://developer.chargeover.com/apidocs/rest/#get-admin
		/// </summary>
		public IResponse GetSpecificAdminWorker()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/admin", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
