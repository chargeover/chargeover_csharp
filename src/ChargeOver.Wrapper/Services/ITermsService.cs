using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public interface ITermsService
	{
		/// <summary>
		/// List terms
		/// details: https://developer.chargeover.com/apidocs/rest/#list-terms
		/// </summary>
		Task<IResponse<Term>> ListTerms();
	}
}
