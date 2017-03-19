using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class LanguagesServiceTests
	{
		private LanguagesService Sut{get;set;}

		[SetUp]
		public void SetUp()
		{
			Sut = new LanguagesService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
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
