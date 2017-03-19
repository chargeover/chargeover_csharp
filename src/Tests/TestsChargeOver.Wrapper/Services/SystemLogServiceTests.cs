using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class SystemLogServiceTests
	{
		private SystemLogService Sut{get;set;}

		[SetUp]
		public void SetUp()
		{
			Sut = new SystemLogService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
		}

		[Test]
		public void should_call_RetrieveTheSystemLog()
		{
			//arrange
			//act
			var actual = Sut.RetrieveTheSystemLog();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
