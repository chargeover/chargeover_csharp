using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class UsageService : BaseService, IUsageService
	{
		public UsageService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public UsageService()
		{
		}

		/// <summary>
		/// Storing Usage Data
		/// details: https://developer.chargeover.com/apidocs/rest/#create-usage
		/// </summary>
		public IIdentityResponse StoreUsageData(StoringUsageData request)
		{
			return Create("usage", request);
		}
	}
}
