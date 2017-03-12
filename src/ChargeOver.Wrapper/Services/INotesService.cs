using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface INotesService
	{
		IResponse Create(Note note);
		IFindResponse<Note> Query(params string[] queries);
	}
}