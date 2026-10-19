using System;
using System.Drawing;
using System.Linq;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using Wisej.Web;
using Wisej.Web.Ext.NavigationBar;

namespace RelayCrm
{
	public partial class Page1 : Page
	{
		// Sidebar item colours of the preview. They move to Themes/Relay.mixin.theme in Step 2.
		private static readonly Color NavItemColor = Color.FromArgb(75, 82, 102);
		private static readonly Color NavSelectedColor = Color.FromArgb(79, 70, 229);
		private static readonly Color NavSelectedBackColor = Color.FromArgb(238, 240, 254);

		// the list page a detail page was opened from, to go back to it.
		private Control listView;

		public Page1()
		{
			InitializeComponent();

			CurrentUser.Changed += CurrentUser_Changed;
		}

		private void Page1_Load(object sender, EventArgs e)
		{
#if DEBUG
			// development shortcut: Default.html?user=1&page=DealsView signs in and opens a page directly.
			if (!CurrentUser.IsSignedIn && int.TryParse(Application.QueryString["user"], out var userId))
				CurrentUser.SignIn(userId);
#endif
			if (!CurrentUser.IsSignedIn)
				SignInDialog.SignIn();

			UpdateUser();
			RefreshBadges();
			this.navigationBar.SelectedItem = this.navigationBarDashboard;

#if DEBUG
			// ...&contact=5, &company=5 or &deal=5 opens that record.
			var page = Application.QueryString["page"];
			if (!string.IsNullOrEmpty(page))
				SelectPage(page);
			if (int.TryParse(Application.QueryString["contact"], out var contactId))
				Navigator.OpenContact(contactId);
			if (int.TryParse(Application.QueryString["company"], out var companyId))
				Navigator.OpenCompany(companyId);
			if (int.TryParse(Application.QueryString["deal"], out var dealId))
				Navigator.OpenDeal(dealId);
#endif
		}

		/// <summary>
		/// Selects the sidebar item of a page and returns the view it shows.
		/// </summary>
		public Control SelectPage(string viewName)
		{
			var item = this.navigationBar.Items.Cast<NavigationBarItem>().FirstOrDefault(i => (string)i.Tag == viewName);
			if (item == null)
				return null;

			if (this.navigationBar.SelectedItem == item)
				ShowView(viewName);
			else
				this.navigationBar.SelectedItem = item;

			return this.panelMain.Controls.Count > 0 ? this.panelMain.Controls[0] : null;
		}

		/// <summary>
		/// Shows a detail page (a contact, a company) in place of the list it belongs to.
		/// </summary>
		public void ShowDetail(Control detail, string listViewName)
		{
			var item = this.navigationBar.Items.Cast<NavigationBarItem>().FirstOrDefault(i => (string)i.Tag == listViewName);
			if (item != null && this.navigationBar.SelectedItem != item)
			{
				// coming from another page: select the list's sidebar item without loading the list.
				this.navigationBar.SelectedItemChanged -= navigationBar_SelectedItemChanged;
				this.navigationBar.SelectedItem = item;
				this.navigationBar.SelectedItemChanged += navigationBar_SelectedItemChanged;
				HighlightSelectedItem();
				UpdateTitles(item.Text);
				this.listView?.Dispose();
				this.listView = null;
			}
			else if (this.panelMain.Controls.Count > 0 && this.listView == null)
			{
				// keep the list to come back to it with its filters.
				this.listView = this.panelMain.Controls[0];
				this.panelMain.Controls.Remove(this.listView);
			}

			ClearContent();
			Mount(detail);
		}

		/// <summary>
		/// Returns from a detail page to its list.
		/// </summary>
		public void GoBack()
		{
			if (this.listView != null)
			{
				var list = this.listView;
				this.listView = null;
				ClearContent();
				Mount(list);

				if (list is IRefreshable refreshable)
					refreshable.RefreshData();
			}
			else if (this.navigationBar.SelectedItem != null)
			{
				ShowView((string)this.navigationBar.SelectedItem.Tag);
			}
		}

		/// <summary>
		/// Updates the overdue tasks badge of the sidebar.
		/// </summary>
		public void RefreshBadges()
		{
			if (!CurrentUser.IsSignedIn)
				return;

			var overdue = 0;
			Notify.Try(() => overdue = TaskService.OverdueCount(CurrentUser.Id), "Loading the overdue tasks");
			this.navigationBarTasks.InfoText = overdue > 0 ? overdue.ToString() : null;
		}

		private void ShowView(string viewName)
		{
			this.listView?.Dispose();
			this.listView = null;
			ClearContent();

			var view = (Control)Activator.CreateInstance(Type.GetType($"RelayCrm.Views.{viewName}"));
			Mount(view);
		}

		private void ClearContent()
		{
			// detach without disposing the list page that is kept to go back to it.
			while (this.panelMain.Controls.Count > 0)
			{
				var child = this.panelMain.Controls[0];
				this.panelMain.Controls.Remove(child);
				if (child != this.listView)
					child.Dispose();
			}
		}

		private void Mount(Control view)
		{
			view.Dock = DockStyle.Fill;
			view.Parent = this.panelMain;

			var animationIn = this.animationIn.GetAnimation(view);
			animationIn.Event = "appear";
			animationIn.Name = "fadeIn";
		}

		private void UpdateTitles(string pageName)
		{
			this.labelTitle.Text = pageName;
			Application.Title = "Relay · " + pageName;
		}

		private void UpdateUser()
		{
			this.avatarUser.Text = CurrentUser.Initials;
			this.avatarUser.ToolTipText = CurrentUser.Name;
		}

		private void HighlightSelectedItem()
		{
			foreach (NavigationBarItem item in this.navigationBar.Items)
			{
				item.BackColor = item.Selected ? NavSelectedBackColor : Color.White;
				item.ForeColor = item.Selected ? NavSelectedColor : NavItemColor;
			}
		}

		private void CurrentUser_Changed(object sender, EventArgs e)
		{
			UpdateUser();
		}

		private void navigationBar_SelectedItemChanged(object sender, EventArgs e)
		{
			var item = this.navigationBar.SelectedItem;
			if (item == null)
				return;

			ShowView((string)item.Tag);
			UpdateTitles(item.Text);
			HighlightSelectedItem();
		}

		private void navigationBar_TitleClick(object sender, EventArgs e)
		{
			this.navigationBar.SelectedItem = this.navigationBarDashboard;
		}

		private void textBoxSearch_Click(object sender, EventArgs e)
		{
			this.commandPalette.Show();
		}

		private void commandPalette_QueryChanged(object sender, CommandQueryEventArgs e)
		{
			e.Results = SearchService.Search(e.Query).Select(r => new PaletteCommand
			{
				Text = r.Text,
				Description = r.Description,
				Icon = r.Icon,
				Category = r.Kind == SearchKind.Page ? "Pages" : r.Kind + "s",
				Tag = r,
			}).ToList();
		}

		private void commandPalette_CommandExecuted(object sender, CommandEventArgs e)
		{
			if (!(e.Command?.Tag is SearchResult result))
				return;

			switch (result.Kind)
			{
				case SearchKind.Page: Navigator.ShowPage(result.Target); break;
				case SearchKind.Contact: Navigator.OpenContact(result.Id); break;
				case SearchKind.Company: Navigator.OpenCompany(result.Id); break;
				case SearchKind.Deal: Navigator.OpenDeal(result.Id); break;
			}
		}

		private void avatarUser_Click(object sender, EventArgs e)
		{
			this.contextMenuUser.Show(this.avatarUser, Placement.BottomRight);
		}

		private void buttonNotifications_Click(object sender, EventArgs e)
		{
			var overdue = TaskService.OverdueCount(CurrentUser.Id);
			if (overdue > 0)
				Notify.Warning($"You have {overdue} overdue task{(overdue == 1 ? "" : "s")}.");
			else
				Notify.Info("No new notifications.");
		}

		private void menuItemProfile_Click(object sender, EventArgs e)
		{
			(Navigator.ShowPage("SettingsView") as Views.SettingsView)?.ShowProfile();
		}

		private void menuItemSettings_Click(object sender, EventArgs e)
		{
			this.navigationBar.SelectedItem = this.navigationBarSettings;
		}

		private void menuItemSignOut_Click(object sender, EventArgs e)
		{
			CurrentUser.SignOut();
			Application.Reload();
		}
	}

}
