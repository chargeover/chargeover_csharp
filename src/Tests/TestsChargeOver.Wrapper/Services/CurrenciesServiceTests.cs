using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class CurrenciesServiceTests
	{
		private CurrenciesService Sut{get;set;}

		[SetUp]
		public void SetUp()
		{
			Sut = new CurrenciesService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
		}

		[Test]
		public void should_call_ListCurrencies()
		{
			//arrange
			//act
			var actual = Sut.ListCurrencies();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
