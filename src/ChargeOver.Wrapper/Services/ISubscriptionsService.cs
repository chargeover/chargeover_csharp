using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ISubscriptionsService
	{
		IResponse Create(Subscription subscription);
		IResponse Update(Subscription subscription);
		IFindResponse<Subscription> Query(params string[] queries);
		/// <summary>
		/// Upgrade/downgrade subscription
		/// </summary>
		/// <returns></returns>
		IResponse Upgrade(UpgradeSubscription request);
		IResponse Invoice(int id);
		IResponse Suspend(int id);
		IResponse Unsuspend(int id);
		IResponse Cancel(int id);
		IResponse Paymenthod(Paymenthod paymenthod);
		IResponse SendWelcomeEmail(int id);
	}
}