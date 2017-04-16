using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class ChargeOverServiceTests : BaseServiceTests<ChargeOverService>
	{
		protected override ChargeOverService Initialize(IChargeOverAPIConfiguration config)
		{
			return new ChargeOverService(config);
		}

		[Test]
		public void should_call_GetListPendingRequests()
		{
			//arrange
			//act
			var actual = Sut.GetListPendingRequests();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		[Ignore("we NOT be able to automate unit tests for that")]
		public void should_call_CommitChargeOver()
		{
			//arrange
			var request = new CommitChargeOver
			{
				Commit = "6KHW4JiguocfQEO2yhmq58ZsVNGlIPb0",
			};
			//act
			var actual = Sut.CommitChargeOver(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		[Ignore("we NOT be able to automate unit tests for that")]
		public void should_call_RejectChargeOver()
		{
			//arrange
			var request = new RejectChargeOver
			{
				Reject = "6m4npbichesodlur",
			};
			//act
			var actual = Sut.RejectChargeOver(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
