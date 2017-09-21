using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class Brand
	{
		/// <summary>
		/// Brand ID #
		/// </summary>
		[JsonProperty("brand_id")]
		public int? BrandId { get; set; }
		/// <summary>
		/// Brand name
		/// </summary>
		[JsonProperty("brand")]
		public string Name { get; set; }
		/// <summary>
		/// Street address 1
		/// </summary>
		[JsonProperty("brand_addr1")]
		public string BrandAddr1 { get; set; }
		/// <summary>
		/// Street address 1
		/// </summary>
		[JsonProperty("brand_addr2")]
		public string BrandAddr2 { get; set; }
		/// <summary>
		/// City
		/// </summary>
		[JsonProperty("brand_city")]
		public string BrandCity { get; set; }
		/// <summary>
		/// State/province
		/// </summary>
		[JsonProperty("brand_state")]
		public string BrandState { get; set; }
		/// <summary>
		/// Postal code
		/// </summary>
		[JsonProperty("brand_postcode")]
		public string BrandPostalCode { get; set; }
		/// <summary>
		/// Country
		/// </summary>
		[JsonProperty("brand_country")]
		public string BrandCountry { get; set; }
		/// <summary>
		/// Printable brand address
		/// </summary>
		[JsonProperty("brand_block")]
		public string BrandBlock { get; set; }
		/// <summary>
		/// Custom field 1
		/// </summary>
		[JsonProperty("custom_1")]
		public string Custom1 { get; set; }
		/// <summary>
		/// Custom field 2
		/// </summary>
		[JsonProperty("custom_2")]
		public string Custom2 { get; set; }
		/// <summary>
		/// Custom field 3
		/// </summary>
		[JsonProperty("custom_3")]
		public string Custom3 { get; set; }
		/// <summary>
		/// Custom field 4
		/// </summary>
		[JsonProperty("custom_4")]
		public string Custom4 { get; set; }
		/// <summary>
		/// Custom field 5
		/// </summary>
		[JsonProperty("custom_5")]
		public string Custom5 { get; set; }
	}
}
