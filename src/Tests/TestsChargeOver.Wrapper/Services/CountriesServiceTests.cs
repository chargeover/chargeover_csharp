using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class CountriesServiceTests
	{
		private CountriesService Sut{get;set;}

		[SetUp]
		public void SetUp()
		{
			Sut = new CountriesService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
		}

		[Test]
		public void should_call_RetrieveCountryList()
		{
			//arrange
			//act
			var actual = Sut.RetrieveCountryList();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
