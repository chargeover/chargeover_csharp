using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public interface ITokenizedPayMethodsService
	{
		/// <summary>
		/// Store a pay method token
		/// details: https://developer.chargeover.com/apidocs/rest/#create-tokenized
		/// </summary>
		Task<IIdentityResponse> StorePayMethodToken(StorePayMethodToken request);

		/// <summary>
		/// Delete tokenized pay method
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-a-tokenized
		/// </summary>
		Task<IResponse> DeleteTokenizedPayMethod(int id);
	}
}
