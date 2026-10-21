using System;
using System.Windows;
using RelayCrm.Dialogs;
using RelayCrm.Views;

namespace RelayCrm.Services
{
	/// <summary>
	/// Navigation between pages and records, used by every view, the dashboard drill-downs and the search box.
	/// </summary>
	public static class Navigator
	{
		private static MainWindow Shell => MainWindow.Instance;

		/// <summary>Shows a page by its view class name (DashboardView, ContactsView, ...).</summary>
		public static FrameworkElement ShowPage(string viewName)
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
			var dialog = new DealDetailDialog();
			dialog.LoadDeal(dealId);
			dialog.Owner = Notify.ActiveWindow;
			dialog.ShowDialog();

			// the dialog may have asked to open the company or a contact.
			dialog.RunAfterClose();
			return dialog.Changed;
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

		/// <summary>Updates the counters of the navigation list and the status bar (overdue tasks).</summary>
		public static void RefreshBadges()
		{
			Shell?.RefreshBadges();
		}

		/// <summary>Shows the dashboard again with fresh data (after the demo data was reset).</summary>
		public static void Reload()
		{
			Shell?.Reload();
		}
	}
}
