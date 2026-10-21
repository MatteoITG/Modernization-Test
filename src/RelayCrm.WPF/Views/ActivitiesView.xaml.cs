using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;

namespace RelayCrm.Views
{
	/// <summary>
	/// Activities as a month calendar or as a list, filtered by type and user.
	/// </summary>
	public partial class ActivitiesView : UserControl, IRefreshable
	{
		private const int ItemsPerDay = 4;

		/// <summary>An activity in a day of the calendar.</summary>
		public class CalendarItem
		{
			public ActivityRow Row { get; set; }
			public string Time { get; set; }
			public Brush Brush { get; set; }
			public string ToolTip { get; set; }
		}

		/// <summary>A day of the calendar.</summary>
		public class DayCell
		{
			public DateTime Date { get; set; }
			public string DayText { get; set; }
			public FontWeight DayWeight { get; set; }
			public Brush DayBrush { get; set; }
			public Brush Background { get; set; }
			public List<CalendarItem> Items { get; set; }
			public string MoreText { get; set; }
		}

		// first day of the month the calendar shows.
		private DateTime month = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

		// true after the first load: the filters' events reload the data only from then on.
		private bool ready;

		public ActivitiesView()
		{
			InitializeComponent();

			foreach (var day in Enumerable.Range(0, 7).Select(i => Fmt.Culture.DateTimeFormat.AbbreviatedDayNames[((int)DayOfWeek.Monday + i) % 7]))
				this.headerDays.Children.Add(new TextBlock { Text = day, FontWeight = FontWeights.SemiBold, Margin = new Thickness(5, 0, 0, 3) });

			LoadUsers();
			this.ready = true;
			UpdateMode();
		}

		/// <summary>Reloads the calendar or the list.</summary>
		public void RefreshData()
		{
			if (!this.ready)
				return;

			if (this.CalendarMode)
				LoadCalendar();
			else
				LoadList();
		}

		private bool CalendarMode => this.radioList.IsChecked != true;

		/// <summary>The selected type, or null for all.</summary>
		private ActivityType? SelectedType =>
			this.radioCall.IsChecked == true ? ActivityType.Call
			: this.radioEmail.IsChecked == true ? ActivityType.Email
			: this.radioMeeting.IsChecked == true ? ActivityType.Meeting
			: this.radioNote.IsChecked == true ? ActivityType.Note
			: (ActivityType?)null;

		/// <summary>The selected user, or null for all users.</summary>
		private int? SelectedUserId
		{
			get
			{
				var id = (this.comboBoxUser.SelectedItem as ListItem)?.Id ?? 0;
				return id == 0 ? (int?)null : id;
			}
		}

		// "All users" and the users; Sales see their own activities by default.
		private void LoadUsers()
		{
			var items = new List<ListItem> { new ListItem(0, "All users") };
			Notify.Try(() => items.AddRange(LookupService.Users().Select(u => new ListItem(u.Id, u.Name))), "Loading the users");
			this.comboBoxUser.ItemsSource = items;
			this.comboBoxUser.SelectedItem = !CurrentUser.SeesAll
				? items.FirstOrDefault(i => i.Id == CurrentUser.Id) ?? items[0]
				: items[0];
		}

		private void UpdateMode()
		{
			var calendar = this.CalendarMode;
			this.panelCalendar.Visibility = calendar ? Visibility.Visible : Visibility.Collapsed;
			this.panelList.Visibility = calendar ? Visibility.Collapsed : Visibility.Visible;
			this.buttonExport.Visibility = calendar ? Visibility.Collapsed : Visibility.Visible;
			RefreshData();
		}

		// loads the activities of the six weeks the calendar shows, starting on the Monday before the 1st.
		private void LoadCalendar()
		{
			var offset = ((int)this.month.DayOfWeek + 6) % 7;
			var from = this.month.AddDays(-offset);
			var to = from.AddDays(42);

			List<ActivityRow> rows = null;
			if (!Notify.Try(() => rows = ActivityService.Range(from, to, this.SelectedType, this.SelectedUserId), "Loading the calendar"))
				return;

			var today = DateTime.Today;
			var otherMonth = new SolidColorBrush(Color.FromRgb(0xF4, 0xF4, 0xF4));
			var todayBrush = new SolidColorBrush(Color.FromRgb(0xE8, 0xF1, 0xFB));
			var days = new List<DayCell>();
			for (var date = from; date < to; date = date.AddDays(1))
			{
				var day = date;
				var items = rows.Where(r => r.Date.Date == day).OrderBy(r => r.Date).ToList();
				days.Add(new DayCell
				{
					Date = day,
					DayText = day.Day == 1 ? day.ToString("MMM d", Fmt.Culture) : day.Day.ToString(Fmt.Culture),
					DayWeight = day == today ? FontWeights.Bold : FontWeights.Normal,
					DayBrush = day.Month == this.month.Month ? SystemColors.ControlTextBrush : SystemColors.GrayTextBrush,
					Background = day == today ? todayBrush : day.Month == this.month.Month ? SystemColors.WindowBrush : otherMonth,
					Items = items.Take(ItemsPerDay).Select(r => new CalendarItem
					{
						Row = r,
						Time = r.Date.ToString("HH:mm", Fmt.Culture),
						Brush = ActivityService.Tone(r.Type) == Tone.Neutral ? SystemColors.ControlTextBrush : ActivityService.Tone(r.Type).ToBrush(),
						ToolTip = r.Details + " · " + Fmt.DateAndTime(r.Date) + "\n" + r.Subject
							+ (string.IsNullOrEmpty(r.RelatedText) ? "" : "\n" + r.RelatedText)
							+ (string.IsNullOrEmpty(r.UserName) ? "" : "\nby " + r.UserName),
					}).ToList(),
					MoreText = items.Count > ItemsPerDay ? "+" + (items.Count - ItemsPerDay) + " more" : "",
				});
			}

			this.calendar.ItemsSource = days;
			this.labelMonth.Text = this.month.ToString("MMMM yyyy", Fmt.Culture);
			var inMonth = rows.Count(r => r.Date.Month == this.month.Month && r.Date.Year == this.month.Year);
			this.labelCount.Text = inMonth == 1 ? "1 activity in " + this.labelMonth.Text : inMonth + " activities in " + this.labelMonth.Text;
		}

		private void LoadList()
		{
			List<ActivityRow> rows = null;
			if (!Notify.Try(() => rows = ActivityService.List(this.SelectedType, this.SelectedUserId), "Loading the activities"))
				return;

			this.grid.ItemsSource = rows;
			this.emptyState.Visibility = rows.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
			this.labelCount.Text = rows.Count == 1 ? "1 activity" : rows.Count + " activities";
		}

		// opens the record an activity relates to: its deal, else its contact, else its company.
		private void OpenRelated(ActivityRow row)
		{
			if (row.DealId != null)
			{
				if (Navigator.OpenDeal(row.DealId.Value))
					RefreshData();
			}
			else if (row.ContactId != null)
			{
				Navigator.OpenContact(row.ContactId.Value);
			}
			else if (row.CompanyId != null)
			{
				Navigator.OpenCompany(row.CompanyId.Value);
			}
			else
			{
				Notify.Info(row.TypeName + " · " + Fmt.DateAndTime(row.Date) + ": " + row.Subject
					+ (string.IsNullOrWhiteSpace(row.Body) ? "" : " – " + row.Body));
			}
		}

		private void LogActivity(DateTime? date, ActivityType type)
		{
			if (LogActivityDialog.Log(type: type, date: date))
				RefreshData();
		}

		private void buttonLog_Click(object sender, RoutedEventArgs e)
		{
			LogActivity(null, this.SelectedType ?? ActivityType.Call);
		}

		private void buttonExport_Click(object sender, RoutedEventArgs e)
		{
			CsvExport.Save(this.grid, "activities.csv");
		}

		private void radioMode_Checked(object sender, RoutedEventArgs e)
		{
			if (this.ready)
				UpdateMode();
		}

		private void filter_Changed(object sender, RoutedEventArgs e)
		{
			RefreshData();
		}

		private void buttonPrevious_Click(object sender, RoutedEventArgs e)
		{
			this.month = this.month.AddMonths(-1);
			RefreshData();
		}

		private void buttonNext_Click(object sender, RoutedEventArgs e)
		{
			this.month = this.month.AddMonths(1);
			RefreshData();
		}

		private void buttonToday_Click(object sender, RoutedEventArgs e)
		{
			this.month = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
			RefreshData();
		}

		private void day_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ClickCount != 2 || !(((FrameworkElement)sender).DataContext is DayCell day))
				return;

			// a day starts at midnight: propose the morning instead.
			e.Handled = true;
			LogActivity(day.Date.AddHours(9), ActivityType.Meeting);
		}

		private void appointment_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			if (((FrameworkElement)sender).DataContext is CalendarItem item)
			{
				e.Handled = true;
				OpenRelated(item.Row);
			}
		}

		private void grid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (UiHelper.RowItem<ActivityRow>(e) is ActivityRow row)
				OpenRelated(row);
		}

		private void linkRelated_Click(object sender, RoutedEventArgs e)
		{
			if (((FrameworkContentElement)sender).DataContext is ActivityRow row)
				OpenRelated(row);
		}

		private void menuOpen_Click(object sender, RoutedEventArgs e)
		{
			if (this.grid.SelectedItem is ActivityRow row)
				OpenRelated(row);
		}

		private void menuDelete_Click(object sender, RoutedEventArgs e)
		{
			if (!(this.grid.SelectedItem is ActivityRow row))
				return;

			if (ConfirmDialog.Ask("Delete activity", "Delete \"" + row.Subject + "\"? This cannot be undone.", "Delete")
				&& Notify.Try(() => ActivityService.Delete(row.Id), "Deleting the activity"))
			{
				Notify.Success(row.TypeName + " deleted.");
				RefreshData();
			}
		}
	}
}
