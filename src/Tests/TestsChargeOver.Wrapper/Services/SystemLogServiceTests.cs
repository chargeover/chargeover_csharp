using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class SystemLogServiceTests : BaseServiceTests<SystemLogService>
	{
		protected override SystemLogService Initialize(IChargeOverAPIConfiguration config)
		{
			return new SystemLogService(config);
		}

		[Test]
		public void should_call_RetrieveTheSystemLog()
		{
			//arrange
			//act
			var actual = Sut.ListSystemLogs();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
