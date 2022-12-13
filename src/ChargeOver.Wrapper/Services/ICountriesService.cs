using ChargeOver.Wrapper.Models;

using System.Threading.Tasks;
namespace ChargeOver.Wrapper.Services
{
	public interface ICountriesService
	{
		/// <summary>
		/// Retrieve country list
		/// details: https://developer.chargeover.com/apidocs/rest/#list-country
		/// </summary>
		Task<IResponse<Country>> ListCountries();
	}
}
