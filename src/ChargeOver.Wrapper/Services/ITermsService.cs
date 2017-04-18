using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ITermsService
	{
		/// <summary>
		/// List terms
		/// details: https://developer.chargeover.com/apidocs/rest/#list-terms
		/// </summary>
		IResponse<Term> ListTerms();
	}
}
