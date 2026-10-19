using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm
{
	/// <summary>
	/// Keeps the signed in user in the Wisej session, so every browser has its own user
	/// (a static is shared by all the users of a web app).
	/// </summary>
	internal sealed class WisejSessionBag : ISessionBag
	{
		public object this[string key]
		{
			get => Application.Session[key];
			set => Application.Session[key] = value;
		}
	}
}
