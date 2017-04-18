using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class ItemPricemodel
	{
		[JsonProperty("base")]
		public float Base { get; set; }
		[JsonProperty("paycycle")]
		public string Paycycle { get; set; }
		[JsonProperty("pricemodel")]
		public string Pricemodel { get; set; }
	}
}