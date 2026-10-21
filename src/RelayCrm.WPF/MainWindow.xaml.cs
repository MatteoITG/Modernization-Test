using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using RelayCrm.Views;

namespace RelayCrm
{
	/// <summary>
	/// The main window: menu, toolbar with the search box and the user menu, the page list on the left,
	/// the current page on the right and the status bar.
	/// </summary>
	public partial class MainWindow : Window
	{
		/// <summary>An entry of the navigation list.</summary>
		public class NavItem : INotifyPropertyChanged
		{
			private string badge;

			public NavItem(string text, string target)
			{
				this.Text = text;
				this.Target = target;
			}

			public string Text { get; }

			/// <summary>The view class name (DashboardView, ...).</summary>
			public string Target { get; }

			/// <summary>Counter shown at the right (overdue tasks).</summary>
			public string Badge
			{
				get { return this.badge; }
				set
				{
					this.badge = value;
					this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Badge)));
				}
			}

			public event PropertyChangedEventHandler PropertyChanged;

			public override string ToString() => this.Text;
		}

		private readonly List<NavItem> navItems;
		private readonly StartOptions options;
		private readonly DispatcherTimer timerStatus = new DispatcherTimer { Interval = TimeSpan.FromSeconds(8) };

		// the list page a detail page was opened from, to go back to it.
		private FrameworkElement listView;

		// true while the navigation list is changed by code, to not load the page twice.
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

			this.navItems = SearchService.Pages.Select(p => new NavItem(p.Text, p.Target)).ToList();
			this.listNav.ItemsSource = this.navItems;

			this.timerStatus.Tick += timerStatus_Tick;
			CurrentUser.Changed += CurrentUser_Changed;

			this.Loaded += MainWindow_Loaded;
			this.ContentRendered += MainWindow_ContentRendered;
		}

		/// <summary>The main window of the application.</summary>
		public static MainWindow Instance { get; private set; }

		/// <summary>The page or detail page shown in the content area.</summary>
		public FrameworkElement CurrentView => this.contentHost.Content as FrameworkElement;

		protected override void OnClosed(EventArgs e)
		{
			CurrentUser.Changed -= CurrentUser_Changed;
			this.timerStatus.Stop();
			base.OnClosed(e);
		}

		private void MainWindow_Loaded(object sender, RoutedEventArgs e)
		{
			UpdateUser();
			RefreshBadges();
			if (string.IsNullOrEmpty(this.options.Page) || SelectPage(this.options.Page) == null)
				SelectPage("DashboardView");
		}

		private void MainWindow_ContentRendered(object sender, EventArgs e)
		{
			this.ContentRendered -= MainWindow_ContentRendered;

			// development switches: open a record directly, once the window is on screen.
			this.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
			{
				if (this.options.ContactId != null)
					Navigator.OpenContact(this.options.ContactId.Value);
				if (this.options.CompanyId != null)
					Navigator.OpenCompany(this.options.CompanyId.Value);
				if (this.options.DealId != null)
					RefreshAfter(Navigator.OpenDeal(this.options.DealId.Value));
			}));
		}

		#region Navigation

		/// <summary>
		/// Selects the navigation entry of a page and returns the view it shows; null for an unknown page.
		/// </summary>
		public FrameworkElement SelectPage(string viewName)
		{
			var item = FindItem(viewName);
			if (item == null)
				return null;

			if (this.listNav.SelectedItem == item)
				ShowView(viewName);
			else
				this.listNav.SelectedItem = item;

			return this.CurrentView;
		}

		/// <summary>
		/// Shows a detail page (a contact, a company) in place of the list it belongs to.
		/// </summary>
		public void ShowDetail(FrameworkElement detail, string listViewName)
		{
			var item = FindItem(listViewName);
			if (item != null && this.listNav.SelectedItem != item)
			{
				// coming from another page: select the list's entry without loading the list.
				this.selectingNav = true;
				try
				{
					this.listNav.SelectedItem = item;
				}
				finally
				{
					this.selectingNav = false;
				}
				UpdateTitle(item);
				this.listView = null;
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
			else if (this.listNav.SelectedItem is NavItem item)
			{
				ShowView(item.Target);
			}
		}

		/// <summary>Shows the dashboard again with fresh data (after the demo data was reset or a new sign-in).</summary>
		public void Reload()
		{
			this.listView = null;
			UpdateUser();
			RefreshBadges();
			SelectPage("DashboardView");
		}

		private NavItem FindItem(string viewName)
		{
			return this.navItems.FirstOrDefault(n => string.Equals(n.Target, viewName, StringComparison.OrdinalIgnoreCase));
		}

		private void ShowView(string viewName)
		{
			this.listView = null;

			var type = Type.GetType("RelayCrm.Views." + viewName);
			if (type == null)
				return;

			Mouse.OverrideCursor = Cursors.Wait;
			try
			{
				Mount((FrameworkElement)Activator.CreateInstance(type));
			}
			finally
			{
				Mouse.OverrideCursor = null;
			}
		}

		private void Mount(FrameworkElement view)
		{
			this.contentHost.Content = view;
			this.buttonBack.IsEnabled = this.menuBack.IsEnabled = this.listView != null;
		}

		private void UpdateTitle(NavItem item)
		{
			this.Title = "Relay CRM - " + item.Text;
		}

		#endregion

		#region User, badges and status

		/// <summary>
		/// Updates the overdue tasks counter of the navigation list, the toolbar and the status bar.
		/// </summary>
		public void RefreshBadges()
		{
			if (!CurrentUser.IsSignedIn)
				return;

			var overdue = 0;
			Notify.Try(() => overdue = TaskService.OverdueCount(CurrentUser.Id), "Loading the overdue tasks");

			var tasks = FindItem("TasksView");
			if (tasks != null)
				tasks.Badge = overdue > 0 ? overdue.ToString() : null;

			this.buttonNotifications.Content = overdue > 0 ? "🔔 " + overdue : "🔔";
			this.buttonNotifications.ToolTip = overdue > 0 ? overdue + " overdue tasks" : "No new notifications";
			this.statusOverdue.Text = overdue == 0 ? "No overdue tasks" : overdue == 1 ? "1 overdue task" : overdue + " overdue tasks";
			this.linkOverdue.Foreground = overdue > 0 ? Tone.Danger.ToBrush() : SystemColors.HotTrackBrush;
		}

		/// <summary>
		/// Shows a short message in the status bar; it goes away after a few seconds.
		/// </summary>
		public void ShowStatus(string text, StatusKind kind)
		{
			var prefix = kind == StatusKind.Warning ? "⚠ " : kind == StatusKind.Info ? "ℹ " : "";
			this.statusMessage.Text = DateTime.Now.ToString("HH:mm") + "   " + prefix + text;
			this.statusMessage.Foreground = kind == StatusKind.Warning ? Tone.Warning.ToBrush() : SystemColors.ControlTextBrush;
			this.statusMessage.ToolTip = text;
			this.timerStatus.Stop();
			this.timerStatus.Start();
		}

		private void timerStatus_Tick(object sender, EventArgs e)
		{
			this.timerStatus.Stop();
			this.statusMessage.Text = "Ready";
			this.statusMessage.ToolTip = null;
			this.statusMessage.Foreground = SystemColors.ControlTextBrush;
		}

		private void UpdateUser()
		{
			this.menuUser.Header = "👤 " + CurrentUser.Name;
			this.menuUser.ToolTip = CurrentUser.Email;
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

			Show();
			Reload();
		}

		#endregion

		#region Search

		private void ShowSearchResults()
		{
			List<SearchResult> results = null;
			if (!Notify.Try(() => results = SearchService.Search(this.textSearch.Text), "Searching"))
				return;

			this.listSearch.ItemsSource = results;
			this.popupSearch.IsOpen = results.Count > 0;
			if (results.Count > 0)
				this.listSearch.SelectedIndex = 0;
		}

		private void OpenSearchResult(SearchResult result)
		{
			if (result == null)
				return;

			this.popupSearch.IsOpen = false;
			this.textSearch.Text = "";
			switch (result.Kind)
			{
				case SearchKind.Page: Navigator.ShowPage(result.Target); break;
				case SearchKind.Contact: Navigator.OpenContact(result.Id); break;
				case SearchKind.Company: Navigator.OpenCompany(result.Id); break;
				case SearchKind.Deal: RefreshAfter(Navigator.OpenDeal(result.Id)); break;
			}
		}

		private void FocusSearch()
		{
			this.textSearch.Focus();
			this.textSearch.SelectAll();
			ShowSearchResults();
		}

		private void textSearch_TextChanged(object sender, TextChangedEventArgs e)
		{
			this.labelSearchHint.Visibility = this.textSearch.Text.Length == 0 ? Visibility.Visible : Visibility.Collapsed;
			if (this.textSearch.IsKeyboardFocused)
				ShowSearchResults();
		}

		private void textSearch_PreviewKeyDown(object sender, KeyEventArgs e)
		{
			switch (e.Key)
			{
				case Key.Down:
					if (!this.popupSearch.IsOpen)
						ShowSearchResults();
					if (this.listSearch.Items.Count > 0)
					{
						this.listSearch.SelectedIndex = Math.Min(this.listSearch.Items.Count - 1, this.listSearch.SelectedIndex + 1);
						this.listSearch.ScrollIntoView(this.listSearch.SelectedItem);
					}
					e.Handled = true;
					break;

				case Key.Up:
					if (this.listSearch.SelectedIndex > 0)
					{
						this.listSearch.SelectedIndex--;
						this.listSearch.ScrollIntoView(this.listSearch.SelectedItem);
					}
					e.Handled = true;
					break;

				case Key.Enter:
					if (!this.popupSearch.IsOpen)
						ShowSearchResults();
					OpenSearchResult(this.listSearch.SelectedItem as SearchResult);
					e.Handled = true;
					break;

				case Key.Escape:
					this.popupSearch.IsOpen = false;
					e.Handled = true;
					break;
			}
		}

		private void textSearch_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
		{
			if (!(e.NewFocus is DependencyObject target) || !this.listSearch.IsAncestorOf(target))
				this.popupSearch.IsOpen = false;
		}

		private void listSearch_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			var item = UiHelper.RowItem<SearchResult>(e);
			if (item != null)
				OpenSearchResult(item);
		}

		private void listSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
				OpenSearchResult(this.listSearch.SelectedItem as SearchResult);
			else if (e.Key == Key.Escape)
				this.popupSearch.IsOpen = false;
		}

		private void menuSearch_Click(object sender, RoutedEventArgs e)
		{
			FocusSearch();
		}

		#endregion

		#region Handlers

		// reloads the current page after a dialog changed data.
		private void RefreshAfter(bool changed)
		{
			if (changed && this.CurrentView is IRefreshable refreshable)
				refreshable.RefreshData();
		}

		private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
		{
			var ctrl = Keyboard.Modifiers == ModifierKeys.Control;
			if (ctrl && e.Key == Key.K)
			{
				FocusSearch();
				e.Handled = true;
			}
			else if (e.Key == Key.F5)
			{
				menuRefresh_Click(sender, e);
				e.Handled = true;
			}
			else if (Keyboard.Modifiers == ModifierKeys.Alt && e.SystemKey == Key.Left)
			{
				if (this.listView != null)
					GoBack();
				e.Handled = true;
			}
			else if (ctrl && e.Key >= Key.D1 && e.Key <= Key.D8)
			{
				SelectPage(this.navItems[e.Key - Key.D1].Target);
				e.Handled = true;
			}
		}

		private void listNav_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (!(this.listNav.SelectedItem is NavItem item))
				return;

			UpdateTitle(item);
			if (!this.selectingNav)
				ShowView(item.Target);
		}

		private void labelLogo_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			SelectPage("DashboardView");
		}

		private void menuPage_Click(object sender, RoutedEventArgs e)
		{
			SelectPage((string)((FrameworkElement)sender).Tag);
		}

		private void buttonBack_Click(object sender, RoutedEventArgs e)
		{
			if (this.listView != null)
				GoBack();
		}

		private void menuRefresh_Click(object sender, RoutedEventArgs e)
		{
			if (this.CurrentView is IRefreshable refreshable)
			{
				refreshable.RefreshData();
				RefreshBadges();
				Notify.Info("Refreshed.");
			}
		}

		private void menuNewContact_Click(object sender, RoutedEventArgs e)
		{
			RefreshAfter(ContactEditDialog.Edit(null));
		}

		private void menuNewCompany_Click(object sender, RoutedEventArgs e)
		{
			RefreshAfter(CompanyEditDialog.Edit(null));
		}

		private void menuNewDeal_Click(object sender, RoutedEventArgs e)
		{
			RefreshAfter(DealEditDialog.Edit(null));
		}

		private void menuNewTask_Click(object sender, RoutedEventArgs e)
		{
			RefreshAfter(TaskEditDialog.Edit(null));
		}

		private void menuLogActivity_Click(object sender, RoutedEventArgs e)
		{
			RefreshAfter(LogActivityDialog.Log());
		}

		private void menuSignOut_Click(object sender, RoutedEventArgs e)
		{
			SignOut();
		}

		private void menuExit_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void menuUserProfile_Click(object sender, RoutedEventArgs e)
		{
			(Navigator.ShowPage("SettingsView") as SettingsView)?.ShowProfile();
		}

		private void menuAbout_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show(this,
				"Relay CRM\n\nThe classic WPF edition of the Relay sample CRM.\n"
				+ "Data: " + Data.RelayDbContext.DatabasePath + "\n\nAll names and companies are fictional.",
				"About Relay", MessageBoxButton.OK, MessageBoxImage.Information);
		}

		private void buttonNotifications_Click(object sender, RoutedEventArgs e)
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
				"Notifications", MessageBoxButton.YesNo, MessageBoxImage.Warning);
			if (answer == MessageBoxResult.Yes)
				Navigator.ShowPage("TasksView");
		}

		private void statusOverdue_Click(object sender, RoutedEventArgs e)
		{
			Navigator.ShowPage("TasksView");
		}

		#endregion
	}
}
