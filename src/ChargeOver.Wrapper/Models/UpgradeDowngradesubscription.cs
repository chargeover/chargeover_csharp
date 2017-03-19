using System;
using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class UpgradeDowngradesubscription
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("line_items")]
		public object LineItems { get; set; }
	}
}
