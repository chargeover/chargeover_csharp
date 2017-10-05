using ChargeOver.Wrapper.Models;

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
		public IResponse<Campaign> ListCampaigns()
		{
			return GetList<Campaign>("campaign");
		}
	}
}
