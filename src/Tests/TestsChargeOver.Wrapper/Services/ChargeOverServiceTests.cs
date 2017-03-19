using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class ChargeOverServiceTests
	{
		private ChargeOverService Sut{get;set;}

		[SetUp]
		public void SetUp()
		{
			Sut = new ChargeOverService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
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
		public void should_call_CommitChargeOver()
		{
			//arrange
			var request = new CommitChargeOver
			{
				Commit = "9w5jdiqz1pf7h8ga",
			};
			//act
			var actual = Sut.CommitChargeOver(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
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
