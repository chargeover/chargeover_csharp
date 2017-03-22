using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class ChangePricingTierset
	{
		[JsonProperty("setup")]
		public int Setup { get; set; }
		[JsonProperty("base")]
		public int Base { get; set; }
		[JsonProperty("pricemodel")]
		public string Pricemodel { get; set; }
		[JsonProperty("tiers")]
		public ChangePricingTier[] Tiers { get; set; }
	}
}