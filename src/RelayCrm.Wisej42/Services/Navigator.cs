using System;
using RelayCrm.Views;
using RelayCrm.Dialogs;
using Wisej.Web;

namespace RelayCrm.Services
{
	/// <summary>
	/// Navigation between pages and records, used by every view, the dashboard drill-downs and Ctrl+K.
	/// </summary>
	public static class Navigator
	{
		private static Page1 Shell => Application.MainPage as Page1;

		/// <summary>Shows a page by its view class name (DashboardView, ContactsView, ...).</summary>
		public static Control ShowPage(string viewName)
		{
			return Shell?.SelectPage(viewName);
		}

		public static void OpenContact(int contactId)
		{
			var view = new ContactDetailView();
			view.LoadContact(contactId);
			Shell?.ShowDetail(view, "ContactsView");
		}

		public static void OpenCompany(int companyId)
		{
			var view = new CompanyDetailView();
			view.LoadCompany(companyId);
			Shell?.ShowDetail(view, "CompaniesView");
		}

		/// <summary>Opens the deal detail dialog; returns true when the deal was changed.</summary>
		public static bool OpenDeal(int dealId)
		{
			using (var dialog = new DealDetailDialog())
			{
				dialog.LoadDeal(dealId);
				dialog.ShowDialog();
				return dialog.Changed;
			}
		}

		/// <summary>Opens the deals page as a list filtered by <paramref name="filter"/> (dashboard drill-down).</summary>
		public static void OpenDeals(DealFilter filter)
		{
			(ShowPage("DealsView") as DealsView)?.ShowList(filter);
		}

		/// <summary>Opens the contacts page with a quick filter selected.</summary>
		public static void OpenContacts(ContactQuickFilter quickFilter)
		{
			(ShowPage("ContactsView") as ContactsView)?.SelectQuickFilter(quickFilter);
		}

		/// <summary>Goes back to the list page a detail page was opened from.</summary>
		public static void Back()
		{
			Shell?.GoBack();
		}

		/// <summary>Updates the counters shown on the sidebar (overdue tasks).</summary>
		public static void RefreshBadges()
		{
			Shell?.RefreshBadges();
		}
	}
}
