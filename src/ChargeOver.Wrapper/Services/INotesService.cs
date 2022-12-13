using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public interface INotesService
	{
        /// <summary>
        /// Create a note
        /// details: https://developer.chargeover.com/apidocs/rest/#create_note
        /// </summary>
        Task<IIdentityResponse>CreateNote(Note request);

        /// <summary>
        /// Query notes for an object
        /// details: https://developer.chargeover.com/apidocs/rest/#query_note
        /// </summary>
        Task<IResponse<NoteDetails>> QueryNotesForObject(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10);
	}
}
