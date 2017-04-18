using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IACHeCheckAccountsService
	{
		/// <summary>
		/// Store an ACH account
		/// details: https://developer.chargeover.com/apidocs/rest/#create-ach
		/// </summary>
		IIdentityResponse StoreACHAccount(StoreACHAccount request);

		/// <summary>
		/// Delete an ACH account
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-an-ach
		/// </summary>
		IResponse DeleteACHAccount(int id);
	}
}
