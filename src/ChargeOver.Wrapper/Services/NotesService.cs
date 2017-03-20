using ChargeOver.Wrapper.Models;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Services
{
	public sealed class NotesService : BaseService, INotesService
	{
		public NotesService(IChargeOverApiProvider provider) : base(provider)
		{
		}

		/// <summary>
		/// Create a note
		/// details: https://developer.chargeover.com/apidocs/rest/#create_note
		/// </summary>
		public IIdentityResponse CreateNote(Note request)
		{
			return Create("note", request);
		}

		/// <summary>
		/// Query notes for an object
		/// details: https://developer.chargeover.com/apidocs/rest/#query_note
		/// </summary>
		public IResponse QueryNotesForObject(params string[] queries)
		{
			var api = Provider.Create();

			var result = api.Raw("find", "/note?_dummy=1", null);

			var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			return new IdentityResponse(resultObject);
		}
	}
}
