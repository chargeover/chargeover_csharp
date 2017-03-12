using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ICampaignsService
	{
		IFindResponse<Campaign> Retrieve();
	}
}