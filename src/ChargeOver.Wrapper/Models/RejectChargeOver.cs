using System;
using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class RejectChargeOver
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("reject")]
		public string Reject { get; set; }
	}
}
