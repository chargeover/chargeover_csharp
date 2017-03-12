using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IACHAccountService
	{
		IResponse Store(ACHAccount account);
		IResponse Delete(int id);
	}
}