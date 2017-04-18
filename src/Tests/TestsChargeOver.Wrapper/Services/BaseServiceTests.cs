using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	public abstract class BaseServiceTests
	{
		protected IChargeOverAPIConfiguration Config { get; private set; }

		[SetUp]
		public void SetUp()
		{
			Config = ChargeOverAPIConfiguration.Config;

			SetUp(Config);
		}

		protected virtual void SetUp(IChargeOverAPIConfiguration config) { }

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

		protected override void SetUp(IChargeOverAPIConfiguration config)
		{
			base.SetUp(config);

			Sut = Initialize(config);
		}

		protected abstract T Initialize(IChargeOverAPIConfiguration config);
	}
}