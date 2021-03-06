using System;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class Contact
	{
		/// <summary>
		/// The user/contact ID #
		/// </summary>
		[JsonProperty("user_id")]
		public int? UserId { get; set; }
		/// <summary>
		/// External key value
		/// </summary>
		[JsonProperty("external_key")]
		public string ExternalKey { get; set; }
		/// <summary>
		/// Unique token
		/// </summary>
		[JsonProperty("token")]
		public string Token { get; set; }
		/// <summary>
		/// Customer portal username
		/// </summary>
		[JsonProperty("username")]
		public string Username { get; set; }
		/// <summary>
		/// First and last name of the contact
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
		/// <summary>
		/// First name of contact
		/// </summary>
		[JsonProperty("first_name")]
		public string FirstName { get; set; }
		/// <summary>
		/// Middle name/initial
		/// </summary>
		[JsonProperty("middle_name_glob")]
		public string MiddleNameGlob { get; set; }
		/// <summary>
		/// Last name
		/// </summary>
		[JsonProperty("last_name")]
		public string LastName { get; set; }
		/// <summary>
		/// Suffix (e.g. "Jr.", "Sr.", "III", etc.)
		/// </summary>
		[JsonProperty("name_suffix")]
		public string NameSuffix { get; set; }
		/// <summary>
		/// (deprecated)
		/// </summary>
		[JsonProperty("display_as")]
		public string DisplayAs { get; set; }
		/// <summary>
		/// Title
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }
		/// <summary>
		/// E-mail address
		/// </summary>
		[JsonProperty("email")]
		public string Email { get; set; }
		/// <summary>
		/// Phone number
		/// </summary>
		[JsonProperty("phone")]
		public string Phone { get; set; }
		/// <summary>
		/// User type ID #
		/// </summary>
		[JsonProperty("user_type_id")]
		public int? UserTypeId { get; set; }
		/// <summary>
		/// User type
		/// </summary>
		[JsonProperty("user_type_name")]
		public string UserTypeName { get; set; }
		/// <summary>
		/// Custom field #1
		/// </summary>
		[JsonProperty("custom_1")]
		public string Custom1 { get; set; }
		/// <summary>
		/// Custom field #2
		/// </summary>
		[JsonProperty("custom_2")]
		public string Custom2 { get; set; }
		/// <summary>
		/// Custom field #3
		/// </summary>
		[JsonProperty("custom_3")]
		public string Custom3 { get; set; }
		/// <summary>
		/// Date/time the user/contact was created
		/// </summary>
		[JsonProperty("write_datetime")]
		public DateTime? WriteDatetime { get; set; }
		/// <summary>
		/// Date/time the user/contact was last modified
		/// </summary>
		[JsonProperty("mod_datetime")]
		public DateTime? ModDatetime { get; set; }
		/// <summary>
		/// URL for viewing the user/contact in the GUI
		/// </summary>
		[JsonProperty("url_self")]
		public string UrlSelf { get; set; }
	}
}
