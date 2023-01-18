using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public sealed class CountriesService : BaseService, ICountriesService
	{
		public CountriesService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public CountriesService()
		{
		}

		/// <summary>
		/// Retrieve country list
		/// details: https://developer.chargeover.com/apidocs/rest/#list-country
		/// </summary>
		public async Task<IResponse<Country>> ListCountries()
		{
			return await GetList<Country>("country");
		}
	}
}
