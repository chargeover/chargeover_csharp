using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class CampaignsServiceTests
	{
		private CampaignsService Sut{get;set;}

		[SetUp]
		public void SetUp()
		{
			Sut = new CampaignsService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
		}

		[Test]
		public void should_call_RetrieveCampaignList()
		{
			//arrange
			//act
			var actual = Sut.RetrieveCampaignList();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
