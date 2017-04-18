using System;
using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class NoteDetails
	{
		/// <summary>
		/// Note ID #
		/// </summary>
		[JsonProperty("note_id")]
		public int? NoteId { get; set; }
		/// <summary>
		/// User ID #
		/// </summary>
		[JsonProperty("user_id")]
		public int? UserId { get; set; }
		/// <summary>
		/// Admin ID #
		/// </summary>
		[JsonProperty("admin_id")]
		public int? AdminId { get; set; }
		/// <summary>
		/// Note text
		/// </summary>
		[JsonProperty("note")]
		public string Note { get; set; }
		/// <summary>
		/// Date/time the note was created
		/// </summary>
		[JsonProperty("note_datetime")]
		public DateTime? NoteDatetime { get; set; }
	}
}
