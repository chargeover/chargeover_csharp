using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class Tierset
	{
		[JsonProperty("tierset_id")]
		public int TiersetId { get; set; }
		[JsonProperty("setup")]
		public double Setup { get; set; }
		[JsonProperty("base")]
		public double Base { get; set; }
		[JsonProperty("paycycle")]
		public string PayCycle { get; set; }
		[JsonProperty("pricemodel")]
		public string PriceModel { get; set; }
		[JsonProperty("write_datetime")]
		public string WriteDatetime { get; set; }
		[JsonProperty("mod_datetime")]
		public string ModDatetime { get; set; }
		[JsonProperty("setup_formatted")]
		public string SetupFormatted { get; set; }
		[JsonProperty("base_formatted")]
		public string BaseFormatted { get; set; }
		[JsonProperty("pricemodel_desc")]
		public string PricemodelDesc { get; set; }
		[JsonProperty("tiers")]
		public Tier[] Tiers { get; set; }
	}
}