using System.Collections.Generic;

namespace ChargeOver.Wrapper.Models
{
	internal sealed class Response<T> : IResponse<T>
	{
		private readonly T[] _data;

		public Response(ChargeOverResponse<T> response)
		{
			Code = response.Code;
			Status = response.Status;
			_data = response.Response;
		}

		public int Code { get; }
		public string Status { get; }
		public string Message { get; } = string.Empty;
		IEnumerable<T> IResponse<T>.Response => _data;
	}

	internal sealed class Response : IResponse
	{
		public Response(ChargeOverResponse response)
		{
			Code = response.Code;
			Status = response.Status;
			Message = response.Message;
		}

		public int Code { get; }
		public string Status { get; }
		public string Message { get; }
	}
}