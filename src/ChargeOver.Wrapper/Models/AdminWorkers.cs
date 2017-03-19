using System;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class AdminWorkers
	{
		/// <summary>
		/// Admin ID #
		/// </summary>
		[JsonProperty("admin_id")]
		public int AdminId { get; set; }
		/// <summary>
		/// Username
		/// </summary>
		[JsonProperty("username")]
		public string Username { get; set; }
		/// <summary>
		/// External key value
		/// </summary>
		[JsonProperty("external_key")]
		public string ExternalKey { get; set; }
		/// <summary>
		/// Timezone
		/// </summary>
		[JsonProperty("timezone")]
		public string Timezone { get; set; }
		/// <summary>
		/// Full name
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
		/// <summary>
		/// First Name
		/// </summary>
		[JsonProperty("first_name")]
		public string FirstName { get; set; }
		/// <summary>
		/// Last Name
		/// </summary>
		[JsonProperty("last_name")]
		public string LastName { get; set; }
		/// <summary>
		/// Initials
		/// </summary>
		[JsonProperty("initials")]
		public string Initials { get; set; }
		/// <summary>
		/// Nickname
		/// </summary>
		[JsonProperty("nickname")]
		public string Nickname { get; set; }
		/// <summary>
		/// Email address
		/// </summary>
		[JsonProperty("email")]
		public string Email { get; set; }
		/// <summary>
		/// Twitter URL
		/// </summary>
		[JsonProperty("twitter")]
		public string Twitter { get; set; }
		/// <summary>
		/// Facebook URL
		/// </summary>
		[JsonProperty("facebook")]
		public string Facebook { get; set; }
		/// <summary>
		/// LinkedIn URL
		/// </summary>
		[JsonProperty("linkedin")]
		public string Linkedin { get; set; }
		/// <summary>
		/// The # of times the worker has logged in
		/// </summary>
		[JsonProperty("login_count")]
		public string LoginCount { get; set; }
		/// <summary>
		/// Last logged in
		/// </summary>
		[JsonProperty("login_datetime")]
		public string LoginDatetime { get; set; }
		/// <summary>
		/// Date/time the admin was created
		/// </summary>
		[JsonProperty("write_datetime")]
		public DateTime? WriteDatetime { get; set; }
		/// <summary>
		/// Date/time the admin was modified
		/// </summary>
		[JsonProperty("mod_datetime")]
		public DateTime? ModDatetime { get; set; }
	}
}
