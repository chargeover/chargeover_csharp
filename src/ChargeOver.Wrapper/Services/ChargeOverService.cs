using ChargeOver.Wrapper.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;

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
		public async Task<IResponse<PendingRequestDetail>> GetListPendingRequests()
		{
			return await GetList<PendingRequestDetail>("_chargeoverjs");
		}

		/// <summary>
		/// Commit a ChargeOver.js request
		/// details: https://developer.chargeover.com/apidocs/rest/#commit-chargeoverjs
		/// </summary>
		public async Task<IIdentityResponse> CommitChargeOver(CommitChargeOver request)
		{
			return await Create("/_chargeoverjs ", request);
		}

		/// <summary>
		/// Reject a ChargeOver.js request
		/// details: https://developer.chargeover.com/apidocs/rest/#reject-chargeoverjs
		/// </summary>
		public async Task<IIdentityResponse> RejectChargeOver(RejectChargeOver request)
		{
			return await Create("/_chargeoverjs ", request);
		}
	}
}
