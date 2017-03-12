using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ITokenizedPayMethodService
	{
		IResponse Store(PayMethod method);
		IResponse Delete(int id);
	}
}