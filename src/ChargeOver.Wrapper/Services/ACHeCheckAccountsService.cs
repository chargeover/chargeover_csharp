using ChargeOver.Wrapper.Models;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Services
{
	public sealed class ACHeCheckAccountsService : BaseService, IACHeCheckAccountsService
	{
		public ACHeCheckAccountsService(IChargeOverApiProvider provider) : base(provider)
		{
		}

		/// <summary>
		/// Store an ACH account
		/// details: https://developer.chargeover.com/apidocs/rest/#create-ach
		/// </summary>
		public IIdentityResponse StoreACHAccount(StoreACHAccount request)
		{
			var api = Provider.Create();

			var result = api.Raw(PostRequest, "/ach ", null, request);

			var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			return new IdentityResponse(resultObject);
		}

		/// <summary>
		/// Delete an ACH account
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-an-ach
		/// </summary>
		public IResponse DeleteACHAccount(int id)
		{
			var api = Provider.Create();

			var result = api.Raw("delete", "/ach", null, id);

			var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			return new IdentityResponse(resultObject);
		}
	}
}
