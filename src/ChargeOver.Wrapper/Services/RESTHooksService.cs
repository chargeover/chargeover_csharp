using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class RESTHooksService : IRESTHooksService
	{
		private readonly IChargeOverApiProvider _provider;

		public RESTHooksService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Subscribing
		/// details: https://developer.chargeover.com/apidocs/rest/#subscribe-resthook
		/// </summary>
		public IIdentityResponse Subscribing(Subscribing request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/_resthook", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Unsubscribing
		/// details: https://developer.chargeover.com/apidocs/rest/#unsubscribe-resthook
		/// </summary>
		public IResponse Unsubscribing()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/_resthook", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
