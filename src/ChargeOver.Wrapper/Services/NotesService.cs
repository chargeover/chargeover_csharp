using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public sealed class NotesService : BaseService, INotesService
	{
		public NotesService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public NotesService()
		{
		}

		/// <summary>
		/// Create a note
		/// details: https://developer.chargeover.com/apidocs/rest/#create_note
		/// </summary>
		public async Task<IIdentityResponse> CreateNote(Note request)
		{
			return await Create("note", request);
		}

		/// <summary>
		/// Query notes for an object
		/// details: https://developer.chargeover.com/apidocs/rest/#query_note
		/// </summary>
		public async Task<IResponse<NoteDetails>> QueryNotesForObject(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return await Query<NoteDetails>("note", queries, orders, offset, limit);
		}
	}
}
