using System;
using System.Drawing;
using System.Linq;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using RelayCrm.Views;
using Wisej.Web;
using Wisej.Web.Ext.NavigationBar;

namespace RelayCrm
{
	/// <summary>
	/// The main page: the navigation bar on the left, the header with the page title, the search box
	/// (Ctrl+K command palette), the New menu, the notifications and the user menu, and the current page.
	/// </summary>
	/// <remarks>
	/// The WPF main Window became a Wisej <see cref="Page"/>, the browser page of the session.
	/// Migration step 2: the menu bar, toolbar, navigation list, search popup and status bar of step 1 became the
	/// NavigationBar, a header and the CommandPalette. Status messages are AlertBox toasts (see <see cref="Notify"/>),
	/// the overdue counter is the badge of the Tasks item, and the keyboard shortcuts of the WPF window
	/// (F5, Alt+Left, Ctrl+1..8) are accelerators of the page; Ctrl+K is the shortcut of the palette.
	/// </remarks>
	public partial class MainWindow : Page
	{
		private const string InstanceKey = "RelayCrm.MainWindow";

		// colours of the navigation items (indigo accent of Themes/Relay.mixin.theme).
		private static readonly Color NavItemColor = Color.FromArgb(75, 82, 102);
		private static readonly Color NavSelectedColor = Color.FromArgb(79, 70, 229);
		private static readonly Color NavSelectedBackColor = Color.FromArgb(238, 240, 254);

		private readonly StartOptions options;

		// the list page a detail page was opened from, to go back to it.
		private Control listView;

		// true while the navigation item is changed by code, to not load the page twice.
		private bool selectingNav;

		public MainWindow()
			: this(null)
		{
		}

		public MainWindow(StartOptions options)
		{
			InitializeComponent();

			Instance = this;
			this.options = options ?? new StartOptions();

			CurrentUser.Changed += CurrentUser_Changed;
		}

		/// <summary>The main page of the session.</summary>
		/// <remarks>
		/// A static property in WPF (one window per process). A Wisej server runs every user in the same process,
		/// so the instance is kept in <see cref="Application.Session"/>: each browser session has its own main page.
		/// </remarks>
		public static MainWindow Instance
		{
			get { return Application.Session[InstanceKey] as MainWindow; }
			private set { Application.Session[InstanceKey] = value; }
		}

		/// <summary>The page or detail page shown in the content area.</summary>
		public Control CurrentView => this.contentHost.Controls.Count > 0 ? this.contentHost.Controls[0] : null;

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				CurrentUser.Changed -= CurrentUser_Changed;
				this.components?.Dispose();
			}
			base.Dispose(disposing);
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			if (this.DesignMode)
				return;

			UpdateUser();
			RefreshBadges();
			if (string.IsNullOrEmpty(this.options.Page) || SelectPage(this.options.Page) == null)
				SelectPage("DashboardView");
		}

		private void MainWindow_Appear(object sender, EventArgs e)
		{
			this.Appear -= MainWindow_Appear;
			if (this.DesignMode)
				return;

			// development switches: open a record directly, once the page is on screen (was ContentRendered).
			if (this.options.ContactId != null)
				Navigator.OpenContact(this.options.ContactId.Value);
			if (this.options.CompanyId != null)
				Navigator.OpenCompany(this.options.CompanyId.Value);
			if (this.options.DealId != null)
				RefreshAfter(Navigator.OpenDeal(this.options.DealId.Value));
		}

		#region Navigation

		/// <summary>
		/// Selects the navigation item of a page and returns the view it shows; null for an unknown page.
		/// </summary>
		public Control SelectPage(string viewName)
		{
			var item = FindItem(viewName);
			if (item == null)
				return null;

			if (this.navigationBar.SelectedItem == item)
				ShowView(viewName);
			else
				this.navigationBar.SelectedItem = item;

			return this.CurrentView;
		}

		/// <summary>
		/// Shows a detail page (a contact, a company) in place of the list it belongs to.
		/// </summary>
		public void ShowDetail(Control detail, string listViewName)
		{
			var item = FindItem(listViewName);
			if (item != null && this.navigationBar.SelectedItem != item)
			{
				// coming from another page: select the list's item without loading the list.
				this.selectingNav = true;
				try
				{
					this.navigationBar.SelectedItem = item;
				}
				finally
				{
					this.selectingNav = false;
				}
				UpdateTitle(item);
				DisposeList();
			}
			else if (this.CurrentView != null && this.listView == null)
			{
				// keep the list to come back to it with its filters.
				this.listView = this.CurrentView;
			}

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
				Mount(list);

				if (list is IRefreshable refreshable)
					refreshable.RefreshData();
			}
			else if (this.navigationBar.SelectedItem != null)
			{
				ShowView((string)this.navigationBar.SelectedItem.Tag);
			}
		}

		/// <summary>Shows the dashboard again with fresh data (after the demo data was reset or a new sign-in).</summary>
		public void Reload()
		{
			DisposeList();
			UpdateUser();
			RefreshBadges();
			SelectPage("DashboardView");
		}

		private NavigationBarItem FindItem(string viewName)
		{
			return this.navigationBar.Items.Cast<NavigationBarItem>()
				.FirstOrDefault(i => string.Equals((string)i.Tag, viewName, StringComparison.OrdinalIgnoreCase));
		}

		private void ShowView(string viewName)
		{
			DisposeList();

			var type = Type.GetType("RelayCrm.Views." + viewName);
			if (type == null)
				return;

			// Wisej shows its loader while the request runs: no wait cursor to set (Mouse.OverrideCursor).
			Mount((Control)Activator.CreateInstance(type));
		}

		private void Mount(Control view)
		{
			// a WPF ContentControl drops its old content; Wisej controls are disposed explicitly,
			// except the list kept to go back to.
			var old = this.CurrentView;
			this.contentHost.Controls.Clear();
			if (old != null && old != view && old != this.listView)
				old.Dispose();

			view.Dock = DockStyle.Fill;
			this.contentHost.Controls.Add(view);
			this.buttonBack.Visible = this.listView != null;

			// on a phone the navigation bar covers the page: close it once a page is chosen.
			if (Application.ActiveProfile?.Name == "Phone")
				this.navigationBar.Visible = false;
		}

		// forgets the list a detail page was opened from.
		private void DisposeList()
		{
			var list = this.listView;
			this.listView = null;
			if (list != null && list != this.CurrentView)
				list.Dispose();
		}

		private void UpdateTitle(NavigationBarItem item)
		{
			this.labelTitle.Text = item.Text;
			this.Text = "Relay CRM - " + item.Text;

			// the selected item in the accent colour of the theme.
			foreach (NavigationBarItem i in this.navigationBar.Items)
			{
				i.BackColor = i == item ? NavSelectedBackColor : Color.White;
				i.ForeColor = i == item ? NavSelectedColor : NavItemColor;
			}
		}

		#endregion

		#region User and badges

		/// <summary>
		/// Updates the overdue tasks counter: the badge of the Tasks item and the notifications button.
		/// </summary>
		public void RefreshBadges()
		{
			if (!CurrentUser.IsSignedIn)
				return;

			var overdue = 0;
			Notify.Try(() => overdue = TaskService.OverdueCount(CurrentUser.Id), "Loading the overdue tasks");

			this.navTasks.InfoText = overdue > 0 ? overdue.ToString() : null;
			this.buttonNotifications.Text = overdue > 0 ? overdue.ToString() : "";
			this.buttonNotifications.ToolTipText = overdue > 0 ? overdue + " overdue tasks" : "No new notifications";
		}

		private void UpdateUser()
		{
			this.avatarUser.Text = CurrentUser.Name;
			this.avatarUser.ImageSource = Avatars.Source(CurrentUser.Name, SettingsService.AvatarPalette[CurrentUser.Id % SettingsService.AvatarPalette.Length]);
			this.avatarUser.ToolTipText = CurrentUser.Name + " · " + CurrentUser.Role + "\n" + CurrentUser.Email;
		}

		private void CurrentUser_Changed(object sender, EventArgs e)
		{
			if (CurrentUser.IsSignedIn)
				UpdateUser();
		}

		private void SignOut()
		{
			Hide();
			CurrentUser.SignOut();
			if (!SignInDialog.SignIn())
			{
				Exit();
				return;
			}

			Show();
			Reload();
		}

		// a browser tab cannot be closed by the app (it was Close() in WPF): Exit hides the page,
		// signs out and offers to sign in again, which starts a new session.
		private void Exit()
		{
			Hide();
			CurrentUser.SignOut();
			SignInDialog.ShowSignedOut();
		}

		#endregion

		#region Search (command palette)

		private void textSearch_Click(object sender, EventArgs e)
		{
			this.commandPalette.Show();
		}

		private void textSearch_ToolClick(object sender, ToolClickEventArgs e)
		{
			this.commandPalette.Show();
		}

		// the palette asks the server for the results of the query (FilterMode = Server): the same search as the WPF popup.
		private void commandPalette_QueryChanged(object sender, CommandQueryEventArgs e)
		{
			var results = SearchService.Search(e.Query ?? "");
			e.Results = results.Select(r => new PaletteCommand
			{
				Text = r.Text,
				Description = r.Description,
				Icon = r.Icon,
				Category = r.Kind == SearchKind.Page ? "Pages" : r.Kind == SearchKind.Company ? "Companies" : r.Kind + "s",
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
				case SearchKind.Deal: RefreshAfter(Navigator.OpenDeal(result.Id)); break;
			}
		}

		#endregion

		#region Handlers

		// reloads the current page after a dialog changed data.
		private void RefreshAfter(bool changed)
		{
			if (changed && this.CurrentView is IRefreshable refreshable)
				refreshable.RefreshData();
		}

		// the keyboard shortcuts of the window (PreviewKeyDown in WPF), all in the Accelerators list of the page:
		// F5 refreshes, Alt+Left goes back, Ctrl+1..8 open the pages. Ctrl+K is the Shortcut of the command palette.
		private void MainWindow_Accelerator(object sender, AcceleratorEventArgs e)
		{
			if (e.KeyCode == Keys.F5)
			{
				RefreshPage();
				e.Handled = true;
			}
			else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.Left)
			{
				if (this.listView != null)
					GoBack();
				e.Handled = true;
			}
			else if (e.Modifiers == Keys.Control && e.KeyCode >= Keys.D1 && e.KeyCode <= Keys.D8)
			{
				var index = e.KeyCode - Keys.D1;
				if (index < this.navigationBar.Items.Count)
					SelectPage((string)this.navigationBar.Items[index].Tag);
				e.Handled = true;
			}
		}

		private void navigationBar_SelectedItemChanged(object sender, EventArgs e)
		{
			var item = this.navigationBar.SelectedItem;
			if (item == null)
				return;

			UpdateTitle(item);
			if (!this.selectingNav)
				ShowView((string)item.Tag);
		}

		private void navigationBar_TitleClick(object sender, EventArgs e)
		{
			SelectPage("DashboardView");
		}

		private void buttonMenu_Click(object sender, EventArgs e)
		{
			this.navigationBar.Visible = !this.navigationBar.Visible;
		}

		private void menuPage_Click(object sender, EventArgs e)
		{
			SelectPage((string)((MenuItem)sender).Tag);
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			if (this.listView != null)
				GoBack();
		}

		private void RefreshPage()
		{
			if (this.CurrentView is IRefreshable refreshable)
			{
				refreshable.RefreshData();
				RefreshBadges();
				Notify.Info("Refreshed.");
			}
		}

		private void menuNewContact_Click(object sender, EventArgs e)
		{
			RefreshAfter(ContactEditDialog.Edit(null));
		}

		private void menuNewCompany_Click(object sender, EventArgs e)
		{
			RefreshAfter(CompanyEditDialog.Edit(null));
		}

		private void menuNewDeal_Click(object sender, EventArgs e)
		{
			RefreshAfter(DealEditDialog.Edit(null));
		}

		private void menuNewTask_Click(object sender, EventArgs e)
		{
			RefreshAfter(TaskEditDialog.Edit(null));
			RefreshBadges();
		}

		private void menuLogActivity_Click(object sender, EventArgs e)
		{
			RefreshAfter(LogActivityDialog.Log());
		}

		private void avatarUser_Click(object sender, EventArgs e)
		{
			this.contextMenuUser.Show(this.avatarUser, Placement.BottomRight);
		}

		private void menuSignOut_Click(object sender, EventArgs e)
		{
			SignOut();
		}

		private void menuExit_Click(object sender, EventArgs e)
		{
			Exit();
		}

		private void menuUserProfile_Click(object sender, EventArgs e)
		{
			(Navigator.ShowPage("SettingsView") as SettingsView)?.ShowProfile();
		}

		private void menuAbout_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Relay CRM\n\nThe WPF edition of the Relay sample CRM, migrated to Wisej.NET 4.2 and modernized.\n"
				+ "Data: " + Data.RelayDbContext.DatabasePath + "\n\nAll names and companies are fictional.",
				"About Relay", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void buttonNotifications_Click(object sender, EventArgs e)
		{
			var overdue = 0;
			if (!Notify.Try(() => overdue = TaskService.OverdueCount(CurrentUser.Id), "Loading the notifications"))
				return;

			if (overdue == 0)
			{
				Notify.Info("No new notifications.");
				return;
			}

			var answer = MessageBox.Show(
				$"You have {overdue} overdue task{(overdue == 1 ? "" : "s")}.\n\nOpen your tasks now?",
				"Notifications", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (answer == DialogResult.Yes)
				Navigator.ShowPage("TasksView");
		}

		#endregion
	}
}
