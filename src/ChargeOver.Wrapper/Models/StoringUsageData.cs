using System;
using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class StoringUsageData
	{
		/// <summary>
		/// Line Item ID Usage is associated to
		/// </summary>
		[JsonProperty("line_item_id")]
		public int LineItemId { get; set; }
		/// <summary>
		/// Usage value
		/// </summary>
		[JsonProperty("usage_value")]
		public float UsageValue { get; set; }
		/// <summary>
		/// Starting Date/time for the usage period
		/// </summary>
		[JsonProperty("from")]
		public DateTime? From { get; set; }
		/// <summary>
		/// Ending Date/time for the usage period
		/// </summary>
		[JsonProperty("to")]
		public DateTime? To { get; set; }
		/// <summary>
		/// External key value
		/// </summary>
		[JsonProperty("external_key")]
		public string ExternalKey { get; set; }
	}
}
