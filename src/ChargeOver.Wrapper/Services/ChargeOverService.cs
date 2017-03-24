using ChargeOver.Wrapper.Models;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Services
{
	public sealed class ChargeOverService : BaseService, IChargeOverService
	{
		public ChargeOverService(IChargeOverApiProvider provider) : base(provider)
		{
		}

		public ChargeOverService()
		{
		}

		/// <summary>
		/// Get a list of pending requests
		/// details: https://developer.chargeover.com/apidocs/rest/#list-chargeoverjs
		/// </summary>
		public IResponse<PendingRequestDetail> GetListPendingRequests()
		{
			return GetList<PendingRequestDetail>("_chargeoverjs");
		}

		/// <summary>
		/// Commit a ChargeOver.js request
		/// details: https://developer.chargeover.com/apidocs/rest/#commit-chargeoverjs
		/// </summary>
		public IIdentityResponse CommitChargeOver(CommitChargeOver request)
		{
			var api = Provider.Create();

			var result = api.Raw(PostRequest, "/_chargeoverjs ", null, request);

			var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			return new IdentityResponse(resultObject);
		}

		/// <summary>
		/// Reject a ChargeOver.js request
		/// details: https://developer.chargeover.com/apidocs/rest/#reject-chargeoverjs
		/// </summary>
		public IIdentityResponse RejectChargeOver(RejectChargeOver request)
		{
			var api = Provider.Create();

			var result = api.Raw(PostRequest, "/_chargeoverjs ", null, request);

			var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			return new IdentityResponse(resultObject);
		}
	}
}
