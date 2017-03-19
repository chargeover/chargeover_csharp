using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class SubscriptionsService : ISubscriptionsService
	{
		private readonly IChargeOverApiProvider _provider;

		public SubscriptionsService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Create a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#create-recurring-package
		/// </summary>
		public IIdentityResponse CreateSubscription(Subscription request)
		{
			var api = _provider.Create();

			var result = api.Raw("create", "/package ", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Update a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#update-recurring-package
		/// </summary>
		public IIdentityResponse UpdateSubscription(UpdateSubscription request)
		{
			var api = _provider.Create();

			var result = api.Raw("modify", "/package", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Get a specific subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#get-subscription
		/// </summary>
		public IResponse GetSpecificSubscription()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/package", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Querying for subscriptions
		/// details: https://developer.chargeover.com/apidocs/rest/#query-subscription
		/// </summary>
		public IResponse QueryingForSubscriptions(params string[] queries)
		{
			var api = _provider.Create();

			var result = api.Raw("find", "/package", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Upgrade/downgrade a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#subscription-upgrade-downgrade
		/// </summary>
		public IIdentityResponse UpgradeDowngradesubscription(UpgradeDowngradesubscription request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/package", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Change pricing on a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#subscription-change-pricing
		/// </summary>
		public IIdentityResponse ChangePricingOnSubscription(ChangePricingOnSubscription request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/package", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Invoice a subscription now
		/// details: https://developer.chargeover.com/apidocs/rest/#example-package-invoice
		/// </summary>
		public IResponse InvoiceSubscriptionNow()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/package", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Suspend a subscription (indefinitely)
		/// details: https://developer.chargeover.com/apidocs/rest/#suspend-recurring-package-indefinitely
		/// </summary>
		public IResponse SuspendSubscription()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/package", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Unsuspend a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#contract-unsuspend
		/// </summary>
		public IResponse UnsuspendSubscription()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/package", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Cancel a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#cancel-package
		/// </summary>
		public IResponse CancelSubscription()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/package", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Set the payment method
		/// details: https://developer.chargeover.com/apidocs/rest/#example-package-set-paymethod
		/// </summary>
		public IIdentityResponse SetThePaymentMethod(SetThePaymentMethod request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/package", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Send a welcome e-mail
		/// details: https://developer.chargeover.com/apidocs/rest/#example-package-send-welcome
		/// </summary>
		public IResponse SendWelcomeEmail()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/package", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
