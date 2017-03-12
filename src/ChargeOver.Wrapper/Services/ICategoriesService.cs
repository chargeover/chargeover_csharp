using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ICategoriesService
	{
		IFindResponse<Category> Query(params string[] queries);
	}
}