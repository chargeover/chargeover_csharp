using ChargeOver.Wrapper.Models;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Services
{
	public sealed class SubscriptionsService : BaseService, ISubscriptionsService
	{
		public SubscriptionsService(IChargeOverApiProvider provider) : base(provider)
		{
		}

		/// <summary>
		/// Create a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#create-recurring-package
		/// </summary>
		public IIdentityResponse CreateSubscription(Subscription request)
		{
			return Create("package", request);
		}

		/// <summary>
		/// Update a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#update-recurring-package
		/// </summary>
		public IIdentityResponse UpdateSubscription(UpdateSubscription request)
		{
			return null;
			//var api = Provider.Create();

			//var result = api.Raw("modify", "/package", null, request);

			//var resultObject = JsonConvert.DeserializeObject<ChargeOverResponse>(result.Item2);

			//return new Models.Response(resultObject);
		}

		/// <summary>
		/// Get a specific subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#get-subscription
		/// </summary>
		public ICustomResponse<SubscriptionDetails> GetSpecificSubscription(int id)
		{
			return GetCustom<SubscriptionDetails>("package", id);
		}

		/// <summary>
		/// Querying for subscriptions
		/// details: https://developer.chargeover.com/apidocs/rest/#query-subscription
		/// </summary>
		public IResponse<Subscription> QueryingForSubscriptions(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return Query<Subscription>("package", queries, orders, offset, limit);
		}

		/// <summary>
		/// Upgrade/downgrade a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#subscription-upgrade-downgrade
		/// </summary>
		public IIdentityResponse UpgradeDowngradesubscription(UpgradeDowngradesubscription request)
		{
			var api = Provider.Create();

			var result = api.Raw("", "/package", null, request);

			var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			return new IdentityResponse(resultObject);
		}

		/// <summary>
		/// Change pricing on a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#subscription-change-pricing
		/// </summary>
		public IIdentityResponse ChangePricingOnSubscription(ChangePricingOnSubscription request)
		{
			var api = Provider.Create();

			var result = api.Raw("", "/package", null, request);

			var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			return new IdentityResponse(resultObject);
		}

		/// <summary>
		/// Invoice a subscription now
		/// details: https://developer.chargeover.com/apidocs/rest/#example-package-invoice
		/// </summary>
		public IResponse InvoiceSubscriptionNow()
		{
			var api = Provider.Create();

			var result = api.Raw("", "/package", null);

			var resultObject = JsonConvert.DeserializeObject<ChargeOverResponse>(result.Item2);

			return new Models.Response(resultObject);
		}

		/// <summary>
		/// Suspend a subscription (indefinitely)
		/// details: https://developer.chargeover.com/apidocs/rest/#suspend-recurring-package-indefinitely
		/// </summary>
		public IResponse SuspendSubscription()
		{
			var api = Provider.Create();

			var result = api.Raw("", "/package", null);

			var resultObject = JsonConvert.DeserializeObject<ChargeOverResponse>(result.Item2);

			return new Models.Response(resultObject);
		}

		/// <summary>
		/// Unsuspend a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#contract-unsuspend
		/// </summary>
		public IResponse UnsuspendSubscription()
		{
			var api = Provider.Create();

			var result = api.Raw("", "/package", null);

			var resultObject = JsonConvert.DeserializeObject<ChargeOverResponse>(result.Item2);

			return new Models.Response(resultObject);
		}

		/// <summary>
		/// Cancel a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#cancel-package
		/// </summary>
		public IResponse CancelSubscription()
		{
			var api = Provider.Create();

			var result = api.Raw("", "/package", null);

			var resultObject = JsonConvert.DeserializeObject<ChargeOverResponse>(result.Item2);

			return new Models.Response(resultObject);
		}

		/// <summary>
		/// Set the payment method
		/// details: https://developer.chargeover.com/apidocs/rest/#example-package-set-paymethod
		/// </summary>
		public IIdentityResponse SetThePaymentMethod(SetThePaymentMethod request)
		{
			var api = Provider.Create();

			var result = api.Raw("", "/package", null, request);

			var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			return new IdentityResponse(resultObject);
		}

		/// <summary>
		/// Send a welcome e-mail
		/// details: https://developer.chargeover.com/apidocs/rest/#example-package-send-welcome
		/// </summary>
		public IResponse SendWelcomeEmail()
		{
			var api = Provider.Create();

			var result = api.Raw("", "/package", null);

			var resultObject = JsonConvert.DeserializeObject<ChargeOverResponse>(result.Item2);

			return new Models.Response(resultObject);
		}
	}
}
