using System.Linq;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class AdminWorkersServiceTests
	{
		private AdminWorkersService Sut { get; set; }

		[SetUp]
		public void SetUp()
		{
			Sut = new AdminWorkersService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
		}

		[Test]
		public void should_call_GetListAdminWorkers()
		{
			//arrange
			//act
			var actual = Sut.GetListAdminWorkers();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_QueryForAdminWorkers()
		{
			//arrange
			//act
			var actual = Sut.QueryForAdminWorkers();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_GetSpecificAdminWorker()
		{
			//arrange
			//act
			var actual = Sut.GetSpecificAdminWorker(Sut.GetListAdminWorkers().Response.First().AdminId);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
