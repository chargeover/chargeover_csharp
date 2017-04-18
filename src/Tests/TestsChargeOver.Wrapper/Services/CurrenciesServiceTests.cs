using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class CurrenciesServiceTests : BaseServiceTests<CurrenciesService>
	{
		protected override CurrenciesService Initialize(IChargeOverAPIConfiguration config)
		{
			return new CurrenciesService(config);
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
