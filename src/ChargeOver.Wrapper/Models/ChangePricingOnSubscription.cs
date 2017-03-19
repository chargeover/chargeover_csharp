using System;
using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class ChangePricingOnSubscription
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("line_items2")]
		public object LineItems2 { get; set; }
	}
}
