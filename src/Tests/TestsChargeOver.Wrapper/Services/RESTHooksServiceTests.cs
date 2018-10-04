using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class RESTHooksServiceTests : BaseServiceTests<RESTHooksService>
	{
		protected override RESTHooksService Initialize(IChargeOverAPIConfiguration config)
		{
			return new RESTHooksService(config);
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
			var actual = Sut.Subscribe(request);
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
			var actual = Sut.Unsubscribe(AddSubscription());
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

			return Sut.Subscribe(request).Id;
		}
	}
}
