using System;
using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class ItemDetails
	{
		/// <summary>
		/// Item ID #
		/// </summary>
		[JsonProperty("item_id")]
		public int? ItemId { get; set; }
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
		/// Units string pluralized
		/// </summary>
		[JsonProperty("units_plural")]
		public string UnitsPlural { get; set; }
		/// <summary>
		/// Default # of times to recur
		/// </summary>
		[JsonProperty("expire_recurs")]
		public int? ExpireRecurs { get; set; }
		/// <summary>
		/// Default # of times to skip/free trial cycles
		/// </summary>
		[JsonProperty("trial_recurs")]
		public int? TrialRecurs { get; set; }
		/// <summary>
		/// Unique token
		/// </summary>
		[JsonProperty("token")]
		public string Token { get; set; }
		/// <summary>
		/// Default pricing tierset ID #
		/// </summary>
		[JsonProperty("tierset_id")]
		public int? TiersetId { get; set; }
		/// <summary>
		/// Date/time the item was created
		/// </summary>
		[JsonProperty("write_datetime")]
		public DateTime? WriteDatetime { get; set; }
		/// <summary>
		/// Date/time the item was last updated
		/// </summary>
		[JsonProperty("mod_datetime")]
		public DateTime? ModDatetime { get; set; }
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
	}
}
