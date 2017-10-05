using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ISubscriptionsService
	{
		/// <summary>
		/// Create a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#create-recurring-package
		/// </summary>
		IIdentityResponse CreateSubscription(Subscription request);

		/// <summary>
		/// Update a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#update-recurring-package
		/// </summary>
		IIdentityResponse UpdateSubscription(int id, UpdateSubscription request);

		/// <summary>
		/// Get a specific subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#get-subscription
		/// </summary>
		ICustomResponse<SubscriptionDetails> GetSubscription(int id);

		/// <summary>
		/// Querying for subscriptions
		/// details: https://developer.chargeover.com/apidocs/rest/#query-subscription
		/// </summary>
		IResponse<Subscription> QuerySubscriptions(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10);

		/// <summary>
		/// Upgrade/downgrade a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#subscription-upgrade-downgrade
		/// </summary>
		ICustomResponse<bool> UpgradeDowngradeSubscription(int id, UpgradeDowngradesubscription request);

		/// <summary>
		/// Change pricing on a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#subscription-change-pricing
		/// </summary>
		ICustomResponse<bool> ChangePricingOnSubscription(int subscriptionId, ChangePricingOnSubscription request);

		/// <summary>
		/// Invoice a subscription now
		/// details: https://developer.chargeover.com/apidocs/rest/#example-package-invoice
		/// </summary>
		IIdentityResponse InvoiceSubscriptionNow(int id);

		/// <summary>
		/// Suspend a subscription (indefinitely)
		/// details: https://developer.chargeover.com/apidocs/rest/#suspend-recurring-package-indefinitely
		/// </summary>
		ICustomResponse<bool> SuspendSubscription(int id);

		/// <summary>
		/// Unsuspend a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#contract-unsuspend
		/// </summary>
		ICustomResponse<bool> UnsuspendSubscription(int id);

		/// <summary>
		/// Cancel a subscription
		/// details: https://developer.chargeover.com/apidocs/rest/#cancel-package
		/// </summary>
		ICustomResponse<bool> CancelSubscription(int id);

		/// <summary>
		/// Set the payment method
		/// details: https://developer.chargeover.com/apidocs/rest/#example-package-set-paymethod
		/// </summary>
		ICustomResponse<bool> SetPaymentMethod(int id, SetThePaymentMethod request);

		/// <summary>
		/// Send a welcome e-mail
		/// details: https://developer.chargeover.com/apidocs/rest/#example-package-send-welcome
		/// </summary>
		ICustomResponse<bool> SendWelcomeEmail(int id);
	}
}
