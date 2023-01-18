using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public interface IChargeOverService
	{
		/// <summary>
		/// Get a list of pending requests
		/// details: https://developer.chargeover.com/apidocs/rest/#list-chargeoverjs
		/// </summary>
		Task<IResponse<PendingRequestDetail>> GetListPendingRequests();

		/// <summary>
		/// Commit a ChargeOver.js request
		/// details: https://developer.chargeover.com/apidocs/rest/#commit-chargeoverjs
		/// </summary>
		Task<IIdentityResponse> CommitChargeOver(CommitChargeOver request);

		/// <summary>
		/// Reject a ChargeOver.js request
		/// details: https://developer.chargeover.com/apidocs/rest/#reject-chargeoverjs
		/// </summary>
		Task<IIdentityResponse> RejectChargeOver(RejectChargeOver request);
	}
}
