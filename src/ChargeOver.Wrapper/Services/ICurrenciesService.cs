using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ICurrenciesService
	{
		/// <summary>
		/// List currencies
		/// details: https://developer.chargeover.com/apidocs/rest/#list-currency
		/// </summary>
		IResponse<Currency> ListCurrencies();
	}
}
