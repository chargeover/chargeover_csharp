using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ISystemLogService
	{
		IFindResponse<SystemLog> Retrieve();
	}
}