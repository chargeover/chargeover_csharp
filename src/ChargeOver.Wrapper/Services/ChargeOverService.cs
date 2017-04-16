using ChargeOver.Wrapper.Models;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Services
{
	public sealed class ChargeOverService : BaseService, IChargeOverService
	{
		public ChargeOverService(IChargeOverAPIConfiguration config) : base(config)
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
			return Create("/_chargeoverjs ", request);
		}

		/// <summary>
		/// Reject a ChargeOver.js request
		/// details: https://developer.chargeover.com/apidocs/rest/#reject-chargeoverjs
		/// </summary>
		public IIdentityResponse RejectChargeOver(RejectChargeOver request)
		{
			return Create("/_chargeoverjs ", request);
		}
	}
}
