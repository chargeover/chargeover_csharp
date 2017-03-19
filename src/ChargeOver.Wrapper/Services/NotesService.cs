using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class NotesService : INotesService
	{
		private readonly IChargeOverApiProvider _provider;

		public NotesService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Create a note
		/// details: https://developer.chargeover.com/apidocs/rest/#create_note
		/// </summary>
		public IIdentityResponse CreateNote(Note request)
		{
			var api = _provider.Create();

			var result = api.Raw("create", "/note ", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Query notes for an object
		/// details: https://developer.chargeover.com/apidocs/rest/#query_note
		/// </summary>
		public IResponse QueryNotesForObject(params string[] queries)
		{
			var api = _provider.Create();

			var result = api.Raw("find", "/note?_dummy=1", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
