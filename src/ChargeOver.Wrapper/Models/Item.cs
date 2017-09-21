using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class Item
	{
		/// <summary>
		/// Item type
		/// </summary>
		[JsonProperty("item_type")]
		public string ItemType { get; set; }
		/// <summary>
		/// Item name
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
		/// <summary>
		/// Description
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }
		/// <summary>
		/// Enabled/disabled
		/// </summary>
		[JsonProperty("enabled")]
		public bool Enabled { get; set; }
		/// <summary>
		/// Accounting SKU
		/// </summary>
		[JsonProperty("accounting_sku")]
		public string AccountingSku { get; set; }
		/// <summary>
		/// External key value
		/// </summary>
		[JsonProperty("external_key")]
		public string ExternalKey { get; set; }
		/// <summary>
		/// Units string
		/// </summary>
		[JsonProperty("units")]
		public string Units { get; set; }
		/// <summary>
		/// Custom field value #1
		/// </summary>
		[JsonProperty("custom_1")]
		public string Custom1 { get; set; }
		/// <summary>
		/// Custom field value #2
		/// </summary>
		[JsonProperty("custom_2")]
		public string Custom2 { get; set; }
		/// <summary>
		/// Custom field value #3
		/// </summary>
		[JsonProperty("custom_3")]
		public string Custom3 { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("pricemodel")]
		public ItemPriceModel PriceModel { get; set; }
	}
}
