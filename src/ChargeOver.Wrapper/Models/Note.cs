using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class Note
	{
		/// <summary>
		/// Note text
		/// </summary>
		[JsonProperty("note")]
		public string NoteDetails { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("obj_type")]
		public string ObjType { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("obj_id")]
		public int ObjId { get; set; }
	}
}
