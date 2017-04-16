using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class TermsServiceTests : BaseServiceTests<TermsService>
	{
		protected override TermsService Initialize(IChargeOverAPIConfiguration config)
		{
			return new TermsService(config);
		}

		[Test]
		public void should_call_ListTerms()
		{
			//arrange
			//act
			var actual = Sut.ListTerms();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
