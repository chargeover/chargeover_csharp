namespace ChargeOver.Wrapper.Models
{
	internal sealed class IdentityResponse : IIdentityResponse
	{
		public IdentityResponse(IdentityChargeOverResponse response)
		{
			Code = response.Code;
			Status = response.Status;
			Id = response.Response.Id;
		}

		public int Code { get; }
		public string Status { get; }
		public string Message { get; } = string.Empty;
		public int Id { get; }
	}
}