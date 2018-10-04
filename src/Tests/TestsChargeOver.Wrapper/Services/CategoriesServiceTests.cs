using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class CategoriesServiceTests : BaseServiceTests<CategoriesService>
	{
		protected override CategoriesService Initialize(IChargeOverAPIConfiguration config)
		{
			return new CategoriesService(config);
		}

		[Test]
		public void should_call_QueryForCategories()
		{
			//arrange
			//act
			var actual = Sut.QueryCategories();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
