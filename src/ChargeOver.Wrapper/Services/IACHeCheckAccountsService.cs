using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public interface IACHeCheckAccountsService
	{
		/// <summary>
		/// Store an ACH account
		/// details: https://developer.chargeover.com/apidocs/rest/#create-ach
		/// </summary>
		Task<IIdentityResponse> StoreACHAccount(StoreACHAccount request);

        /// <summary>
        /// Delete an ACH account
        /// details: https://developer.chargeover.com/apidocs/rest/#delete-an-ach
        /// </summary>
        Task<IResponse> DeleteACHAccount(int id);
	}
}
