using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public sealed class CampaignsService : BaseService, ICampaignsService
	{
		public CampaignsService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public CampaignsService()
		{
		}

		/// <summary>
		/// Retrieve campaign list
		/// details: https://developer.chargeover.com/apidocs/rest/#list-campaign
		/// </summary>
		public async Task<IResponse<Campaign>> ListCampaigns()
		{
			return await GetList<Campaign>("campaign");
		}
	}
}
