using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IChargeOverJsService
	{
		IFindResponse<PendingRequest> Retrieve();
		IResponse Commit(PendingRequest request);
		IResponse Reject(PendingRequest request);
	}
}