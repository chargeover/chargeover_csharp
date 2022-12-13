using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public sealed class CategoriesService : BaseService, ICategoriesService
	{
		public CategoriesService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public CategoriesService()
		{
		}

		/// <summary>
		/// Query for categories
		/// details: https://developer.chargeover.com/apidocs/rest/#list-category
		/// </summary>
		public async Task<IResponse>QueryCategories(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return await Query<Category>("item_category", queries, orders, offset, limit);
		}
	}
}
