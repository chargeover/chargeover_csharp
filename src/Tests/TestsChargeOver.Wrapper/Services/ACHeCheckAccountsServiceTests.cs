using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class ACHeCheckAccountsServiceTests
	{
		private ACHeCheckAccountsService Sut{get;set;}

		[SetUp]
		public void SetUp()
		{
			Sut = new ACHeCheckAccountsService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
		}

		[Test]
		public void should_call_StoreACHAccount()
		{
			//arrange
			var request = new StoreACHAccount
			{
				CustomerId = 2,
				Type = "chec",
				Number = "45678123789",
				Routing = "062346234",
			};
			//act
			var actual = Sut.StoreACHAccount(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_DeleteACHAccount()
		{
			//arrange
			var request = new int
			{
			};
			//act
			var actual = Sut.DeleteACHAccount(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
