using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class CampaignsServiceTests : BaseServiceTests<CampaignsService>
	{
		protected override CampaignsService Initialize(IChargeOverAPIConfiguration config)
		{
			return new CampaignsService(config);
		}

		[Test]
		public void should_call_RetrieveCampaignList()
		{
			//arrange
			//act
			var actual = Sut.ListCampaigns();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
