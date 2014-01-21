using System;

namespace ChargeOver
{
	public class Date:IEquatable<Date>,IEquatable<DateTime>
	{
		private DateTime value;

		public Date(DateTime date)
		{
			value = date.Date;
		}

		public Date(string date)
		{
			value = Convert.ToDateTime (date);
		}

		public static Date Parse(string date)
		{
			return new Date (DateTime.Parse (date));
		}

		public bool Equals(Date other)
		{
			return other != null && value.Equals(other.value);
		}

		public bool Equals(DateTime other)
		{
			return value.Equals(other);
		}

		public override string ToString()
		{
			return value.ToString("yyyy-MM-dd");
		}

		public string ToString(string format)
		{
			return value.ToString (format);
		}

		public static implicit operator DateTime(Date date)
		{
			return date.value;
		}

		public static explicit operator Date(DateTime dateTime)
		{
			return new Date(dateTime);
		}
	}
}

