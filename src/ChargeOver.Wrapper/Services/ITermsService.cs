using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ITermsService
	{
		IFindResponse<Terms> Retrieve();
	}
}