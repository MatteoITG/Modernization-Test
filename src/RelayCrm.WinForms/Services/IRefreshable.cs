namespace RelayCrm
{
	/// <summary>
	/// A view that can reload its data, e.g. when the user comes back to it from a detail page or presses F5.
	/// </summary>
	public interface IRefreshable
	{
		void RefreshData();
	}
}
