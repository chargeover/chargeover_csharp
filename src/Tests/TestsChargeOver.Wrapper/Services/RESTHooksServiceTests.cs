using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class RESTHooksServiceTests
	{
		private RESTHooksService Sut { get; set; }

		[SetUp]
		public void SetUp()
		{
			Sut = new RESTHooksService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
		}

		[Test]
		public void should_call_Subscribing()
		{
			//arrange
			var request = new Subscribing
			{
				TargetUrl = "http://example.org/your_webhook_url",
				Event = "customer.insert",
			};
			//act
			var actual = Sut.Subscribing(request);
			//assert
			Assert.AreEqual(201, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_Unsubscribing()
		{
			//arrange
			//act
			var actual = Sut.Unsubscribing(AddSubscription());
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		private int AddSubscription()
		{
			var request = new Subscribing
			{
				TargetUrl = "http://example.org/your_webhook_url",
				Event = "customer.insert",
			};

			return Sut.Subscribing(request).Id;
		}
	}
}
