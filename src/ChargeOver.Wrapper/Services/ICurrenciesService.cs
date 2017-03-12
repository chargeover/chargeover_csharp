using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ICurrenciesService
	{
		IFindResponse<Currencies> Retrieve();
	}
}