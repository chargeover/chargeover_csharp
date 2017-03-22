using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class RESTHooksService : BaseService, IRESTHooksService
	{
		public RESTHooksService(IChargeOverApiProvider provider) : base(provider)
		{
		}

		public RESTHooksService()
		{
		}

		/// <summary>
		/// Subscribing
		/// details: https://developer.chargeover.com/apidocs/rest/#subscribe-resthook
		/// </summary>
		public IIdentityResponse Subscribing(Subscribing request)
		{
			return Create("/_resthook", request);
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
