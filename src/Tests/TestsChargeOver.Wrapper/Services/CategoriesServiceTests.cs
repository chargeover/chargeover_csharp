using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class CategoriesServiceTests
	{
		private CategoriesService Sut{get;set;}

		[SetUp]
		public void SetUp()
		{
			Sut = new CategoriesService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
		}

		[Test]
		public void should_call_QueryForCategories()
		{
			//arrange
			//act
			var actual = Sut.QueryForCategories();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
