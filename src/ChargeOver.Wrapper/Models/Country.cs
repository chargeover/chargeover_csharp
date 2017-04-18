using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class Country
	{
		[JsonProperty("country_id")]
		public int CountryId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("iso2")]
		public string Iso2 { get; set; }
		[JsonProperty("iso3")]
		public string Iso3 { get; set; }
		[JsonProperty("cctld")]
		public string Cctld { get; set; }
	}
}