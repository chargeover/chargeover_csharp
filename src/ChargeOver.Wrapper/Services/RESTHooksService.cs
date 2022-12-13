using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

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
		public async Task<IIdentityResponse> Subscribe(Subscribing request)
		{
			return await Create("/_resthook", request);
		}

		/// <summary>
		/// Unsubscribing
		/// details: https://developer.chargeover.com/apidocs/rest/#unsubscribe-resthook
		/// </summary>
		public async Task<IResponse>Unsubscribe(int id)
		{
			return await Delete("_resthook", id);
		}
	}
}
