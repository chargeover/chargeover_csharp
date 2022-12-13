using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public interface ICurrenciesService
	{
        /// <summary>
        /// List currencies
        /// details: https://developer.chargeover.com/apidocs/rest/#list-currency
        /// </summary>
        Task<IResponse<Currency>> ListCurrencies();
	}
}
