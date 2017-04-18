using System;
using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class ACHCheckPayment
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("number")]
		public string Number { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("routing")]
		public string Routing { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }
	}
}
