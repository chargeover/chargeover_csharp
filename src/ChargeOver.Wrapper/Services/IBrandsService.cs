using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IBrandsService
	{
		/// <summary>
		/// Retrieve brand list
		/// details: https://developer.chargeover.com/apidocs/rest/#list-brand
		/// </summary>
		IResponse RetrieveBrandList();
	}
}
