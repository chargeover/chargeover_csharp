using ChargeOver.Wrapper.Models;

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
		public IIdentityResponse StoreACHAccount(StoreACHAccount request)
		{
			return Create("ach", request);
		}

		/// <summary>
		/// Delete an ACH account
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-an-ach
		/// </summary>
		public IResponse DeleteACHAccount(int id)
		{
			return Delete("ach", id);
		}
	}
}
