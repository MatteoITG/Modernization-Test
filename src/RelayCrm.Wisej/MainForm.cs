using System;
using System.Drawing;
using System.Linq;
using Wisej.Web;
using Wisej.Web.Ext.NavigationBar;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using RelayCrm.Views;

namespace RelayCrm
{
	/// <summary>
	/// The main window: the navigation bar on the left, the header with the page title, the search box
	/// (Ctrl+K command palette), the New menu, the notifications and the user menu, and the current page.
	/// </summary>
	/// <remarks>
	/// Migration step 2: the menu bar, toolbar, page tree and status bar of the WinForms window became the
	/// NavigationBar, a header and the CommandPalette; status messages are AlertBox toasts (see Notify) and the
	/// overdue counter is the badge of the Tasks item. The keyboard shortcuts are accelerators of the form.
	/// </remarks>
	public partial class MainForm : Form
	{
		// colours of the navigation items (indigo accent of Themes/Relay.mixin.theme).
		private static readonly Color NavItemColor = Color.FromArgb(75, 82, 102);
		private static readonly Color NavSelectedColor = Color.FromArgb(79, 70, 229);
		private static readonly Color NavSelectedBackColor = Color.FromArgb(238, 240, 254);

		// the list page a detail page was opened from, to go back to it.
		private Control listView;

		private readonly StartOptions options;

		public MainForm()
			: this(null)
		{
		}

		public MainForm(StartOptions options)
		{
			InitializeComponent();

			Instance = this;
			this.options = options ?? new StartOptions();

			CurrentUser.Changed += CurrentUser_Changed;
		}

		/// <summary>The main window of the application (of the current session: a static is shared by all users).</summary>
		public static MainForm Instance
		{
			get => (MainForm)Application.Session["Relay.MainForm"];
			private set => Application.Session["Relay.MainForm"] = value;
		}

		/// <summary>The page or detail page shown in the content area.</summary>
		public Control CurrentView => this.panelMain.Controls.Count > 0 ? this.panelMain.Controls[0] : null;

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			CurrentUser.Changed -= CurrentUser_Changed;
			base.OnFormClosed(e);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			UpdateUser();
			RefreshBadges();
			SelectPage(string.IsNullOrEmpty(this.options.Page) ? "DashboardView" : this.options.Page);
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
			// development switches: open a record directly.
			if (this.options.ContactId != null)
				Navigator.OpenContact(this.options.ContactId.Value);
			if (this.options.CompanyId != null)
				Navigator.OpenCompany(this.options.CompanyId.Value);
			if (this.options.DealId != null)
				Navigator.OpenDeal(this.options.DealId.Value);
		}

		#region Navigation

		/// <summary>
		/// Selects the navigation item of a page and returns the view it shows.
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
				this.navigationBar.SelectedItemChanged -= navigationBar_SelectedItemChanged;
				this.navigationBar.SelectedItem = item;
				this.navigationBar.SelectedItemChanged += navigationBar_SelectedItemChanged;
				UpdateTitle(item);
				this.listView?.Dispose();
				this.listView = null;
			}
			else if (this.CurrentView != null && this.listView == null)
			{
				// keep the list to come back to it with its filters.
				this.listView = this.CurrentView;
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

		/// <summary>Shows the dashboard again with fresh data (after the demo data was reset).</summary>
		public void Reload()
		{
			this.listView?.Dispose();
			this.listView = null;
			UpdateUser();
			RefreshBadges();
			SelectPage("DashboardView");
		}

		private NavigationBarItem FindItem(string viewName)
		{
			return this.navigationBar.Items.Cast<NavigationBarItem>().FirstOrDefault(i => (string)i.Tag == viewName);
		}

		private void ShowView(string viewName)
		{
			this.listView?.Dispose();
			this.listView = null;
			ClearContent();

			var type = Type.GetType("RelayCrm.Views." + viewName);
			if (type == null)
				return;

			Mount((Control)Activator.CreateInstance(type));
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
			this.panelMain.Controls.Add(view);
			view.Focus();
			this.buttonBack.Visible = this.listView != null;

			// on a phone the navigation bar covers the page: close it once a page is chosen.
			if (Application.ActiveProfile?.Name == "Phone")
				this.navigationBar.Visible = false;
		}

		private void UpdateTitle(NavigationBarItem item)
		{
			this.labelTitle.Text = item.Text;
			Application.Title = "Relay CRM - " + item.Text;

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
		/// Updates the overdue tasks badge of the navigation bar and the notifications button.
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
			this.avatarUser.Text = CurrentUser.Initials;
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
				Close();
				return;
			}

			Reload();
			Show();
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

		private void commandPalette_QueryChanged(object sender, CommandQueryEventArgs e)
		{
			e.Results = SearchService.Search(e.Query, 40).Select(r => new PaletteCommand
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

		private void navigationBar_SelectedItemChanged(object sender, EventArgs e)
		{
			var item = this.navigationBar.SelectedItem;
			if (item == null)
				return;

			ShowView((string)item.Tag);
			UpdateTitle(item);
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

		private void MainForm_Accelerator(object sender, AcceleratorEventArgs e)
		{
			switch (e.KeyData)
			{
				case Keys.Alt | Keys.N: menuNewContact_Click(sender, e); break;
				case Keys.Alt | Keys.T: menuNewTask_Click(sender, e); break;
				case Keys.Alt | Keys.L: menuLogActivity_Click(sender, e); break;
				case Keys.Alt | Keys.B: buttonBack_Click(sender, e); break;
				case Keys.Alt | Keys.R: RefreshPage(); break;
				default:
					// Alt+1 ... Alt+8: the pages in the order of the navigation bar.
					var index = e.KeyCode - Keys.D1;
					if (e.Alt && index >= 0 && index < this.navigationBar.Items.Count)
						SelectPage((string)this.navigationBar.Items[index].Tag);
					break;
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
		}

		private void menuLogActivity_Click(object sender, EventArgs e)
		{
			RefreshAfter(LogActivityDialog.Show());
		}

		private void avatarUser_Click(object sender, EventArgs e)
		{
			this.contextMenuUser.Show(this.avatarUser, Placement.BottomRight);
		}

		private void menuSignOut_Click(object sender, EventArgs e)
		{
			SignOut();
		}

		private void menuUserProfile_Click(object sender, EventArgs e)
		{
			(Navigator.ShowPage("SettingsView") as SettingsView)?.ShowProfile();
		}

		private void menuAbout_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Relay CRM\n\nThe Windows Forms edition of the Relay sample CRM, migrated to the web with Wisej.NET 4.2.\n"
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
