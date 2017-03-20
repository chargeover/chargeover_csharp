using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class Campaign
	{
		[JsonProperty("campaign_id")]
		public int CampaignId { get; set; }
		[JsonProperty("campaign")]
		public string CampaignDetails { get; set; }
	}
}