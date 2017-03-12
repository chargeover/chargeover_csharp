using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ICreditCardService
	{
		IResponse Store(CrediCard crediCard);
		IFindResponse<CrediCard> Query(params string[] queries);
		IResponse Delete(int id);
	}
}