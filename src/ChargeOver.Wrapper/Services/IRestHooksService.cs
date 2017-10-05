using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IRESTHooksService
	{
		/// <summary>
		/// Subscribing
		/// details: https://developer.chargeover.com/apidocs/rest/#subscribe-resthook
		/// </summary>
		IIdentityResponse Subscribe(Subscribing request);

		/// <summary>
		/// Unsubscribing
		/// details: https://developer.chargeover.com/apidocs/rest/#unsubscribe-resthook
		/// </summary>
		IResponse Unsubscribe(int id);
	}
}
