using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class CountriesServiceTests : BaseServiceTests<CountriesService>
	{
		protected override CountriesService Initialize(IChargeOverAPIConfiguration config)
		{
			return new CountriesService(config);
		}

		[Test]
		public void should_call_RetrieveCountryList()
		{
			//arrange
			//act
			var actual = Sut.ListCountries();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
