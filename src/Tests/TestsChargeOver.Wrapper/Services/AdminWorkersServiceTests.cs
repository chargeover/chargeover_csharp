using System.Linq;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class AdminWorkersServiceTests : BaseServiceTests<AdminWorkersService>
	{
		protected override AdminWorkersService Initialize(IChargeOverAPIConfiguration config)
		{
			return new AdminWorkersService(config);
		}

		[Test]
		public async void should_call_GetListAdminWorkers()
		{
			//arrange
			//act
			var actual = await Sut.ListAdminWorkers();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public async void should_call_QueryForAdminWorkers()
		{
			//arrange
			//act
			var actual = await Sut.QueryAdminWorkers();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public async void should_call_GetSpecificAdminWorker()
		{
			//arrange
			var adminWorkers = (await Sut.ListAdminWorkers()).Response.First();
			//act
			var actual = await Sut.GetAdminWorker(adminWorkers.AdminId);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
			Assert.AreEqual(adminWorkers.Email, actual.Response.Email);
		}
	}
}
