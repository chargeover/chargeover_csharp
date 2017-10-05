using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class RESTHooksService : BaseService, IRESTHooksService
	{
		public RESTHooksService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public RESTHooksService()
		{
		}

		/// <summary>
		/// Subscribing
		/// details: https://developer.chargeover.com/apidocs/rest/#subscribe-resthook
		/// </summary>
		public IIdentityResponse Subscribe(Subscribing request)
		{
			return Create("/_resthook", request);
		}

		/// <summary>
		/// Unsubscribing
		/// details: https://developer.chargeover.com/apidocs/rest/#unsubscribe-resthook
		/// </summary>
		public IResponse Unsubscribe(int id)
		{
			return Delete("_resthook", id);
		}
	}
}
