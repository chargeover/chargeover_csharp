using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IContractsService
	{
		IResponse Create(ContactEntity contact);
		IFindResponse<ContactEntity> Query(params string[] queries);
		IResponse ResetPassword(int id);
		IResponse SetPassword(int id, string password);
		IResponse Login(int id);
		IResponse Delete(int id);
	}
}