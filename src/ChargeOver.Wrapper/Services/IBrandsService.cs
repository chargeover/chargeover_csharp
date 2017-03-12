using System.Collections.Generic;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IBrandsService
	{
		IEnumerable<Brand> Retrieve();
	}
}