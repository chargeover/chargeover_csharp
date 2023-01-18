using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public sealed class ACHeCheckAccountsService : BaseService, IACHeCheckAccountsService
	{
		public ACHeCheckAccountsService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public ACHeCheckAccountsService()
		{
		}

		/// <summary>
		/// Store an ACH account
		/// details: https://developer.chargeover.com/apidocs/rest/#create-ach
		/// </summary>
		public async Task<IIdentityResponse> StoreACHAccount(StoreACHAccount request)
		{
			return await Create("ach", request);
		}

		/// <summary>
		/// Delete an ACH account
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-an-ach
		/// </summary>
		public async Task<IResponse> DeleteACHAccount(int id)
		{
			return await Delete("ach", id);
		}
	}
}
