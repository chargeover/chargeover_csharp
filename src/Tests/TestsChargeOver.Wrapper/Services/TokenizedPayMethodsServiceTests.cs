using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class TokenizedPayMethodsServiceTests : BaseServiceTests<TokenizedPayMethodsService>
	{
		protected override TokenizedPayMethodsService Initialize(IChargeOverAPIConfiguration config)
		{
			return new TokenizedPayMethodsService(config);
		}

		[Test]
		public void should_call_StorePayMethodToken()
		{
			//arrange
			var request = new StorePayMethodToken
			{
				CustomerId = 1,
				Token = "cus_5tSkoQ6mDrXOMQ",
				Type = "customer",
			};
			//act
			var actual = Sut.StorePayMethodToken(request);
			//assert
			Assert.AreEqual(201, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_DeleteTokenizedPayMethod()
		{
			//arrange
			//act
			var actual = Sut.DeleteTokenizedPayMethod(AddPayMethod());
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		private int AddPayMethod()
		{
			var request = new StorePayMethodToken
			{
				CustomerId = 1,
				Token = "cus_5tSkoQ6mDrXOMQ",
				Type = "customer",
			};
			return Sut.StorePayMethodToken(request).Id;
		}
	}
}
