using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ICountriesService
	{
		/// <summary>
		/// Retrieve country list
		/// details: https://developer.chargeover.com/apidocs/rest/#list-country
		/// </summary>
		IResponse<Country> ListCountries();
	}
}
