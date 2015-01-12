using System;
using System.Collections.Generic;

namespace ChargeOver
{
	public class Response
	{
		public int code;
		public string status;
		public string message;
		public List<Base> list;
		public List<Response> bulk;
		public Base obj;
		public int id;

		public Response(int code, string status, string message)
		{
			this.code = code;
			this.status = status;
			this.message = message;
		}

		public void SetList<Base>(List<ChargeOver.Base> list)
		{
			this.list = list;
		}

		public void SetObj(Base obj)
		{
			this.obj = obj;
		}

		public void SetId(int id)
		{
			this.id = id;
		}
	}
}

