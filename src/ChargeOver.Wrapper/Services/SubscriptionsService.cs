using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class SubscriptionsService : BaseService, ISubscriptionsService
	{
		public SubscriptionsService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public SubscriptionsService()
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
		public IIdentityResponse UpdateSubscription(int id, UpdateSubscription request)
		{
			return new IdentityResponse(Request<UpdateSubscription, IdentityChargeOverResponse>(MethodType.PUT, "/package/" + id, request));
		}

		/// <summary>
		/// Get a specific subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#get-subscription
		/// </summary>
		public ICustomResponse<SubscriptionDetails> GetSubscription(int id)
		{
			return GetCustom<SubscriptionDetails>("package", id);
		}

		/// <summary>
		/// Querying for subscriptions
		/// details: https://developer.chargeover.com/apidocs/rest/#query-subscription
		/// </summary>
		public IResponse<Subscription> QuerySubscriptions(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return Query<Subscription>("package", queries, orders, offset, limit);
		}

		/// <summary>
		/// Upgrade/downgrade a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#subscription-upgrade-downgrade
		/// </summary>
		public ICustomResponse<bool> UpgradeDowngradeSubscription(int id, UpgradeDowngradesubscription request)
		{
			return GetCustomBool($"/package/{id}?action=upgrade", request);
		}

		/// <summary>
		/// Change pricing on a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#subscription-change-pricing
		/// </summary>
		public ICustomResponse<bool> ChangePricingOnSubscription(int subscription, ChangePricingOnSubscription request)
		{
			return GetCustomBool($"/package/{subscription}?action=upgrade", request);
		}

		/// <summary>
		/// Invoice a subscription now
		/// details: https://developer.chargeover.com/apidocs/rest/#example-package-invoice
		/// </summary>
		public IIdentityResponse InvoiceSubscriptionNow(int id)
		{
			return Create($"/package/{id}?action=invoice", string.Empty);
		}

		/// <summary>
		/// Suspend a subscription (indefinitely)
		/// details: https://developer.chargeover.com/apidocs/rest/#suspend-recurring-package-indefinitely
		/// </summary>
		public ICustomResponse<bool> SuspendSubscription(int id)
		{
			return GetCustomBool($"/package/{id}?action=suspend", string.Empty);
		}

		/// <summary>
		/// Unsuspend a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#contract-unsuspend
		/// </summary>
		public ICustomResponse<bool> UnsuspendSubscription(int id)
		{
			return GetCustomBool($"/package/{id}?action=unsuspend", string.Empty);
		}

		/// <summary>
		/// Cancel a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#cancel-package
		/// </summary>
		public ICustomResponse<bool> CancelSubscription(int id)
		{
			return GetCustomBool($"/package/{id}?action=cancel", string.Empty);
		}

		/// <summary>
		/// Set the payment method
		/// details: https://developer.chargeover.com/apidocs/rest/#example-package-set-paymethod
		/// </summary>
		public ICustomResponse<bool> SetPaymentMethod(int id, SetThePaymentMethod request)
		{
			return GetCustomBool($"/package/{id}?action=paymethod", request);
		}

		/// <summary>
		/// Send a welcome e-mail
		/// details: https://developer.chargeover.com/apidocs/rest/#example-package-send-welcome
		/// </summary>
		public ICustomResponse<bool> SendWelcomeEmail(int id)
		{
			return GetCustomBool($"/package/{id}?action=welcome", new { });
		}
	}
}
