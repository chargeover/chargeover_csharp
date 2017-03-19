using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class UsageServiceTests
	{
		private UsageService Sut{get;set;}

		[SetUp]
		public void SetUp()
		{
			Sut = new UsageService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
		}

		[Test]
		public void should_call_StoringUsageData()
		{
			//arrange
			var request = new StoringUsageData
			{
				LineItemId = "609",
				UsageValue = "265.2",
				From = DateTime.Parse("2013-10-16"),
				To = DateTime.Parse("2013-10-16"),
			};
			//act
			var actual = Sut.StoringUsageData(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
