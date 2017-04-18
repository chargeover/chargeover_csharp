using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class LanguagesServiceTests : BaseServiceTests<LanguagesService>
	{
		protected override LanguagesService Initialize(IChargeOverAPIConfiguration config)
		{
			return new LanguagesService(config);
		}

		[Test]
		public void should_call_ListLanguages()
		{
			//arrange
			//act
			var actual = Sut.ListLanguages();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
