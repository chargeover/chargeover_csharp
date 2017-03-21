using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	public abstract class BaseServiceTests
	{
		protected IChargeOverApiProvider Provider { get; private set; }

		[SetUp]
		public void SetUp()
		{
			Provider = new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config);

			SetUp(Provider);
		}

		protected virtual void SetUp(IChargeOverApiProvider provider) { }

		#region sealed members

		public override sealed string ToString()
		{
			return base.ToString();
		}

		public override sealed bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override sealed int GetHashCode()
		{
			return base.GetHashCode();
		}

		#endregion sealed members
	}

	public abstract class BaseServiceTests<T> : BaseServiceTests
	{
		protected T Sut { get; private set; }

		protected override void SetUp(IChargeOverApiProvider provider)
		{
			base.SetUp(provider);

			Sut = Initialize(provider);
		}

		protected abstract T Initialize(IChargeOverApiProvider provider);
	}
}