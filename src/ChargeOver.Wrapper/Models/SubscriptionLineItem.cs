using System;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class SubscriptionLineItem
	{
		[JsonProperty("item_id")]
		public int ItemId { get; set; }
		[JsonProperty("tierset_id")]
		public int TiersetId { get; set; }
		[JsonProperty("external_key")]
		public string ExternalKey { get; set; }
		[JsonProperty("nickname")]
		public string Nickname { get; set; }
		[JsonProperty("descrip")]
		public string Description { get; set; }
		[JsonProperty("trial_days")]
		public string TrialUnits { get; set; }
		[JsonProperty("custom_1")]
		public string Custom1 { get; set; }
		[JsonProperty("custom_2")]
		public string Custom2 { get; set; }
		[JsonProperty("custom_3")]
		public string Custom3 { get; set; }
		[JsonProperty("subscribe_datetime")]
		public DateTime? SubscribeDatetime { get; set; }
		[JsonProperty("cancel_datetime")]
		public DateTime? CancelDatetime { get; set; }
		[JsonProperty("expire_datetime")]
		public DateTime? ExpireDatetime { get; set; }
		[JsonProperty("expire_recurs")]
		public string ExpireRecurs { get; set; }
		[JsonProperty("license")]
		public string License { get; set; }
		[JsonProperty("item_name")]
		public string ItemName { get; set; }
		[JsonProperty("item_external_key")]
		public string ItemExternalKey { get; set; }
		[JsonProperty("item_accounting_sku")]
		public string ItemAccountingSku { get; set; }
		[JsonProperty("item_units")]
		public string ItemUnits { get; set; }
		[JsonProperty("line_item_id")]
		public int LineItemId { get; set; }
		[JsonProperty("tierset")]
		public Tierset Tierset { get; set; }
		[JsonProperty("line_quantity")]
		public int LineQuantity { get; set; }
	}
}