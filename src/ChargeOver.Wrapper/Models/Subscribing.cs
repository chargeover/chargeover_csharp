using System;
using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class Subscribing
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("target_url")]
		public string TargetUrl { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("event")]
		public string Event { get; set; }
	}
}
