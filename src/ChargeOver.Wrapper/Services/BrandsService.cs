using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class BrandsService : BaseService, IBrandsService
	{
		public BrandsService(IChargeOverApiProvider provider) : base(provider)
		{
		}

		/// <summary>
		/// Retrieve brand list
		/// details: https://developer.chargeover.com/apidocs/rest/#list-brand
		/// </summary>
		public IResponse<Brand> RetrieveBrandList()
		{
			return GetList<Brand>("brand");
		}
	}
}
