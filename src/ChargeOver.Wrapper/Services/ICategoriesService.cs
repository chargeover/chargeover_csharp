using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public interface ICategoriesService
	{
		/// <summary>
		/// Query for categories
		/// details: https://developer.chargeover.com/apidocs/rest/#list-category
		/// </summary>
		Task<IResponse> QueryCategories(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10);
	}
}
