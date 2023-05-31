namespace HireMeNow_BlazorApp.Interfaces
{
	public interface IApplicationService
	{
		void AddApplication(Guid JobId, Guid UserId);
	}
}
