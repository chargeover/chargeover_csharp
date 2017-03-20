using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface INotesService
	{
		/// <summary>
		/// Create a note
		/// details: https://developer.chargeover.com/apidocs/rest/#create_note
		/// </summary>
		IIdentityResponse CreateNote(Note request);

		/// <summary>
		/// Query notes for an object
		/// details: https://developer.chargeover.com/apidocs/rest/#query_note
		/// </summary>
		IResponse<NoteDetails> QueryNotesForObject(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10);
	}
}
