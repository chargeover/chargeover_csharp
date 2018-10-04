using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class BrandsServiceTests : BaseServiceTests<BrandsService>
	{
		protected override BrandsService Initialize(IChargeOverAPIConfiguration config)
		{
			return new BrandsService(config);
		}

		[Test]
		public void should_call_RetrieveBrandList()
		{
			//arrange
			//act
			var actual = Sut.ListBrands();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
