using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public interface IUsageService
	{
		/// <summary>
		/// Storing Usage Data
		/// details: https://developer.chargeover.com/apidocs/rest/#create-usage
		/// </summary>
		Task<IIdentityResponse> StoreUsageData(StoringUsageData request);
	}
}
