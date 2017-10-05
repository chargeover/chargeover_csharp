using ChargeOver.Wrapper.Models;

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
		public IResponse QueryCategories(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return Query<Category>("item_category", queries, orders, offset, limit);
		}
	}
}
