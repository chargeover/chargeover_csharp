using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class CurrenciesService : BaseService, ICurrenciesService
	{
		public CurrenciesService(IChargeOverApiProvider provider) : base(provider)
		{
		}

		public CurrenciesService()
		{
		}

		/// <summary>
		/// List currencies
		/// details: https://developer.chargeover.com/apidocs/rest/#list-currency
		/// </summary>
		public IResponse<Currency> ListCurrencies()
		{
			return GetList<Currency>("currency");
		}
	}
}
