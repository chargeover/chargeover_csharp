using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ICategoriesService
	{
		/// <summary>
		/// Query for categories
		/// details: https://developer.chargeover.com/apidocs/rest/#list-category
		/// </summary>
		IResponse QueryForCategories(params string[] queries);
	}
}
