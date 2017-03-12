using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IAdminWorkersService
	{
		IFindResponse<Admin> Query(params string[] queries);
	}
}