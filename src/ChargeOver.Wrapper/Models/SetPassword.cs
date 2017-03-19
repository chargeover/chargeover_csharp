using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class SetPassword
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("password")]
		public string Password { get; set; }
	}
}
