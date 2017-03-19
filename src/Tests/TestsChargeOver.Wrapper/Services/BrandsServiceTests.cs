using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class BrandsServiceTests
	{
		private BrandsService Sut{get;set;}

		[SetUp]
		public void SetUp()
		{
			Sut = new BrandsService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
		}

		[Test]
		public void should_call_RetrieveBrandList()
		{
			//arrange
			//act
			var actual = Sut.RetrieveBrandList();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
