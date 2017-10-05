using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class BrandsService : BaseService, IBrandsService
	{
		public BrandsService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public BrandsService()
		{
		}

		/// <summary>
		/// Retrieve brand list
		/// details: https://developer.chargeover.com/apidocs/rest/#list-brand
		/// </summary>
		public IResponse<Brand> ListBrands()
		{
			return GetList<Brand>("brand");
		}
	}
}
