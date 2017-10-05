using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IUsageService
	{
		/// <summary>
		/// Storing Usage Data
		/// details: https://developer.chargeover.com/apidocs/rest/#create-usage
		/// </summary>
		IIdentityResponse StoreUsageData(StoringUsageData request);
	}
}
