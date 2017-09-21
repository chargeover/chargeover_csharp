using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class ItemPriceModel
	{
		[JsonProperty("base")]
		public float Base { get; set; }
		[JsonProperty("paycycle")]
		public string PayCycle { get; set; }
		[JsonProperty("pricemodel")]
		public string PriceModel { get; set; }
		[JsonProperty("setup")]
		public float Setup { get; set; }

	}
}