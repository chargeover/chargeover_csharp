using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

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
		public async Task<IResponse<Brand>> ListBrands()
		{
			return await GetList<Brand>("brand");
		}
	}
}
