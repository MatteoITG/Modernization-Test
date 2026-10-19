using System;
using System.Drawing;
using System.Linq;
using Wisej.Web;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using RelayCrm.Views;

namespace RelayCrm
{
	/// <summary>
	/// The main window: menu, toolbar with the search box and the user menu, the page tree on the left,
	/// the current page on the right and the status bar.
	/// </summary>
	public partial class MainForm : Form
	{
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

			this.treeNav.ImageList = IconImages.List(16, this.treeNav.Nodes.Cast<TreeNode>().Select(n => n.ImageKey).ToArray());
			IconImages.Apply(this.menuStrip);
			IconImages.Apply(this.toolStrip);
			this.textSearch.Watermark = "Search pages, contacts, companies, deals (Ctrl+K)";

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
		/// Selects the tree node of a page and returns the view it shows.
		/// </summary>
		public Control SelectPage(string viewName)
		{
			var node = FindNode(viewName);
			if (node == null)
				return null;

			if (this.treeNav.SelectedNode == node)
				ShowView(viewName);
			else
				this.treeNav.SelectedNode = node;

			return this.CurrentView;
		}

		/// <summary>
		/// Shows a detail page (a contact, a company) in place of the list it belongs to.
		/// </summary>
		public void ShowDetail(Control detail, string listViewName)
		{
			var node = FindNode(listViewName);
			if (node != null && this.treeNav.SelectedNode != node)
			{
				// coming from another page: select the list's node without loading the list.
				this.treeNav.AfterSelect -= treeNav_AfterSelect;
				this.treeNav.SelectedNode = node;
				this.treeNav.AfterSelect += treeNav_AfterSelect;
				UpdateTitle(node);
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
			else if (this.treeNav.SelectedNode != null)
			{
				ShowView((string)this.treeNav.SelectedNode.Tag);
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

		private TreeNode FindNode(string viewName)
		{
			return this.treeNav.Nodes.Cast<TreeNode>().FirstOrDefault(n => (string)n.Tag == viewName);
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
			this.buttonBack.Enabled = this.menuBack.Enabled = this.listView != null;
		}

		private void UpdateTitle(TreeNode node)
		{
			var page = (string)node.Tag == "TasksView" ? "Tasks" : node.Text;
			this.Text = "Relay CRM - " + page;
		}

		#endregion

		#region User, badges and status

		/// <summary>
		/// Updates the overdue tasks counter of the tree, the toolbar and the status bar.
		/// </summary>
		public void RefreshBadges()
		{
			if (!CurrentUser.IsSignedIn)
				return;

			var overdue = 0;
			Notify.Try(() => overdue = TaskService.OverdueCount(CurrentUser.Id), "Loading the overdue tasks");

			var tasks = FindNode("TasksView");
			if (tasks != null)
				tasks.Text = overdue > 0 ? "Tasks (" + overdue + ")" : "Tasks";

			this.buttonNotifications.Text = overdue > 0 ? overdue.ToString() : "";
			this.buttonNotifications.ToolTipText = overdue > 0 ? overdue + " overdue tasks" : "No new notifications";
			this.statusOverdue.Text = overdue == 0 ? "No overdue tasks" : overdue == 1 ? "1 overdue task" : overdue + " overdue tasks";
		}

		/// <summary>
		/// Shows a short message in the status bar; it goes away after a few seconds.
		/// </summary>
		public void ShowStatus(string text, ToolTipIcon icon)
		{
			this.statusMessage.Text = DateTime.Now.ToString("HH:mm") + "   " + text;
			this.statusMessage.IconSource = icon == ToolTipIcon.Warning ? "messagebox-warning"
				: icon == ToolTipIcon.Error ? "messagebox-error"
				: icon == ToolTipIcon.Info ? "messagebox-information"
				: null;
			this.timerStatus.Stop();
			this.timerStatus.Start();
		}

		private void timerStatus_Tick(object sender, EventArgs e)
		{
			this.timerStatus.Stop();
			this.statusMessage.Text = "Ready";
			this.statusMessage.IconSource = null;
		}

		private void UpdateUser()
		{
			this.dropDownUser.Text = CurrentUser.Name;
			this.dropDownUser.ToolTipText = CurrentUser.Email;
			this.statusUser.Text = CurrentUser.Name + " · " + CurrentUser.Role;
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

		#region Search

		private void OpenSearch(string text)
		{
			SearchResult result;
			using (var dialog = new SearchDialog())
			{
				dialog.Query = text;
				if (dialog.ShowDialog(this) != DialogResult.OK)
					return;
				result = dialog.Result;
			}

			this.textSearch.Text = "";
			switch (result?.Kind)
			{
				case SearchKind.Page: Navigator.ShowPage(result.Target); break;
				case SearchKind.Contact: Navigator.OpenContact(result.Id); break;
				case SearchKind.Company: Navigator.OpenCompany(result.Id); break;
				case SearchKind.Deal: RefreshAfter(Navigator.OpenDeal(result.Id)); break;
			}
		}

		private void menuSearch_Click(object sender, EventArgs e)
		{
			OpenSearch(this.textSearch.Text);
		}

		private void textSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
			{
				OpenSearch(this.textSearch.Text);
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

		private void treeNav_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node == null)
				return;

			ShowView((string)e.Node.Tag);
			UpdateTitle(e.Node);
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

		private void menuRefresh_Click(object sender, EventArgs e)
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
		}

		private void menuLogActivity_Click(object sender, EventArgs e)
		{
			RefreshAfter(LogActivityDialog.Show());
		}

		private void menuSignOut_Click(object sender, EventArgs e)
		{
			SignOut();
		}

		private void menuExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void menuUserProfile_Click(object sender, EventArgs e)
		{
			(Navigator.ShowPage("SettingsView") as SettingsView)?.ShowProfile();
		}

		private void menuAbout_Click(object sender, EventArgs e)
		{
			MessageBox.Show(this,
				"Relay CRM\n\nThe classic Windows Forms edition of the Relay sample CRM.\n"
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

			var answer = MessageBox.Show(this,
				$"You have {overdue} overdue task{(overdue == 1 ? "" : "s")}.\n\nOpen your tasks now?",
				"Notifications", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (answer == DialogResult.Yes)
				Navigator.ShowPage("TasksView");
		}

		private void statusOverdue_Click(object sender, EventArgs e)
		{
			Navigator.ShowPage("TasksView");
		}

		#endregion
	}
}
