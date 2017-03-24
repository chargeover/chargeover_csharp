using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IChargeOverService
	{
		/// <summary>
		/// Get a list of pending requests
		/// details: https://developer.chargeover.com/apidocs/rest/#list-chargeoverjs
		/// </summary>
		IResponse<PendingRequestDetail> GetListPendingRequests();

		/// <summary>
		/// Commit a ChargeOver.js request
		/// details: https://developer.chargeover.com/apidocs/rest/#commit-chargeoverjs
		/// </summary>
		IIdentityResponse CommitChargeOver(CommitChargeOver request);

		/// <summary>
		/// Reject a ChargeOver.js request
		/// details: https://developer.chargeover.com/apidocs/rest/#reject-chargeoverjs
		/// </summary>
		IIdentityResponse RejectChargeOver(RejectChargeOver request);
	}
}
