namespace RelayCrm
{
	/// <summary>
	/// A view that can reload its data, e.g. when the user comes back to it from a detail page.
	/// </summary>
	public interface IRefreshable
	{
		void RefreshData();
	}
}
