using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class Currency
	{
		/// <summary>
		/// Currency ID #
		/// </summary>
		[JsonProperty("currency_id")]
		public int? CurrencyId { get; set; }
		/// <summary>
		/// Currency name
		/// </summary>
		[JsonProperty("currency")]
		public string Name { get; set; }
		/// <summary>
		/// ISO 4217 currency code
		/// </summary>
		[JsonProperty("iso4217")]
		public string Iso4217 { get; set; }
		/// <summary>
		/// Currency symbol
		/// </summary>
		[JsonProperty("symbol")]
		public string Symbol { get; set; }
		/// <summary>
		/// Number of decimal places to round currency fractions to
		/// </summary>
		[JsonProperty("rounding")]
		public int? Rounding { get; set; }
	}
}
