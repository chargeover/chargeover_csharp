using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public sealed class CurrenciesService : BaseService, ICurrenciesService
	{
		public CurrenciesService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public CurrenciesService()
		{
		}

		/// <summary>
		/// List currencies
		/// details: https://developer.chargeover.com/apidocs/rest/#list-currency
		/// </summary>
		public async Task<IResponse<Currency>> ListCurrencies()
		{
			return await GetList<Currency>("currency");
		}
	}
}
