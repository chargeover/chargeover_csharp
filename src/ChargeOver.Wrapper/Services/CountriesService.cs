using ChargeOver.Wrapper.Models;

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
		public IResponse<Country> ListCountries()
		{
			return GetList<Country>("country");
		}
	}
}
