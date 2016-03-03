using System;
namespace ChargeOver
{
	public class Bulk
	{
		public string request_method { get; set; }
		public string uri { get; set; }
		public Base payload { get; set; }

		public Bulk()
		{
		}

		public Bulk(string rm, string u, Base p)
		{
			this.request_method = rm;
			this.uri = u;
			this.payload = p;
		}
	}
}

