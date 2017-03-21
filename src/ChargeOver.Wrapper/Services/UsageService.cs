using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class UsageService : BaseService, IUsageService
	{
		public UsageService(IChargeOverApiProvider provider) : base(provider)
		{
		}

		/// <summary>
		/// Storing Usage Data
		/// details: https://developer.chargeover.com/apidocs/rest/#create-usage
		/// </summary>
		public IIdentityResponse StoringUsageData(StoringUsageData request)
		{
			return Create("/usage", request);
		}
	}
}
