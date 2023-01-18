using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

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
		public async Task<IIdentityResponse> StoreUsageData(StoringUsageData request)
		{
			return await Create("usage", request);
		}
	}
}
