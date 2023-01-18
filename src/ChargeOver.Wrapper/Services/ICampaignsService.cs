using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public interface ICampaignsService
	{
		/// <summary>
		/// Retrieve campaign list
		/// details: https://developer.chargeover.com/apidocs/rest/#list-campaign
		/// </summary>
		Task<IResponse<Campaign>> ListCampaigns();
	}
}
