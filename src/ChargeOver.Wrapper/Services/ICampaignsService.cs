using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ICampaignsService
	{
		/// <summary>
		/// Retrieve campaign list
		/// details: https://developer.chargeover.com/apidocs/rest/#list-campaign
		/// </summary>
		IResponse<Campaign> ListCampaigns();
	}
}
