using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class ChargeOverService : IChargeOverService
	{
		private readonly IChargeOverApiProvider _provider;

		public ChargeOverService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Get a list of pending requests
		/// details: https://developer.chargeover.com/apidocs/rest/#list-chargeoverjs
		/// </summary>
		public IResponse<PendingRequestDetail> GetListPendingRequests()
		{
			var api = _provider.Create();

			var result = api.Raw("get", "/_chargeoverjs", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<ChargeOverResponse<PendingRequestDetail>>(result.Item2);
			
			return new Models.Response<PendingRequestDetail>(resultObject);
		}

		/// <summary>
		/// Commit a ChargeOver.js request
		/// details: https://developer.chargeover.com/apidocs/rest/#commit-chargeoverjs
		/// </summary>
		public IIdentityResponse CommitChargeOver(CommitChargeOver request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/_chargeoverjs ", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Reject a ChargeOver.js request
		/// details: https://developer.chargeover.com/apidocs/rest/#reject-chargeoverjs
		/// </summary>
		public IIdentityResponse RejectChargeOver(RejectChargeOver request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/_chargeoverjs ", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
