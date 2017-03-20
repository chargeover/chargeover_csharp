using ChargeOver.Wrapper.Models;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Services
{
	public sealed class RESTHooksService : BaseService, IRESTHooksService
	{
		public RESTHooksService(IChargeOverApiProvider provider) : base(provider)
		{
		}

		/// <summary>
		/// Subscribing
		/// details: https://developer.chargeover.com/apidocs/rest/#subscribe-resthook
		/// </summary>
		public IIdentityResponse Subscribing(Subscribing request)
		{
			var api = Provider.Create();

			var result = api.Raw(PostRequest, "/_resthook", null, request);

			var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			return new IdentityResponse(resultObject);
		}

		/// <summary>
		/// Unsubscribing
		/// details: https://developer.chargeover.com/apidocs/rest/#unsubscribe-resthook
		/// </summary>
		public IResponse Unsubscribing(int id)
		{
			return Delete("_resthook", id);
		}
	}
}
