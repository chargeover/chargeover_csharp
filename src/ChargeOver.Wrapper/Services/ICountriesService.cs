﻿using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ICountriesService
	{
		IFindResponse<Country> Retrieve();
	}
}