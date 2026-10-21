using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Views
{
	/// <summary>
	/// Activities as a calendar or as a list, filtered by type and user.
	/// </summary>
	/// <remarks>
	/// Migration step 2: step 1 built the month grid of the WPF ItemsControl (7 x 6 day cells) in code. The Wisej 4.2
	/// SchedulerView shows the activities as appointments (month, week, day and agenda views, with its own navigation),
	/// and a Timeline next to it lists the activities of the day that was clicked. The type radio buttons became a
	/// ChipGroup and the Calendar/List radio buttons a SegmentedButton; the list got chip and avatar columns.
	/// </remarks>
	public partial class ActivitiesView : UserControl, IRefreshable
	{
		// true after the first load: the filters' events reload the data only from then on.
		private bool ready;

		// the activities of the range the scheduler shows.
		private List<ActivityRow> calendarRows = new List<ActivityRow>();

		// the day the timeline next to the calendar shows.
		private DateTime selectedDay = DateTime.Today;

		// the activity the context menu of the timeline acts on (the one clicked last).
		private ActivityRow calendarRow;

		public ActivitiesView()
		{
			InitializeComponent();
			GridHelper.UseConverters(this.grid);

			// the chips of the activity types, in the colours of the WPF calendar.
			foreach (ActivityType type in Enum.GetValues(typeof(ActivityType)))
				this.colType.ToneMap[type.ToString()] = ActivityService.Tone(type).ToChip();

			LoadUsers();
			Reflow(Application.ActiveProfile?.Name);
		}

		/// <summary>
		/// Phone profile (ClientProfiles.json): the user filter goes under the type chips and the calendar takes the
		/// whole width (the timeline of the day is hidden; a click on an activity still opens it with a double-click).
		/// </summary>
		protected override void OnResponsiveProfileChanged(ResponsiveProfileChangedEventArgs e)
		{
			base.OnResponsiveProfileChanged(e);
			Reflow(e.CurrentProfile?.Name);
		}

		private void Reflow(string profile)
		{
			var phone = profile == "Phone";
			this.panelFilters.Height = phone ? 124 : 56;
			this.flowUser.Dock = phone ? DockStyle.Bottom : DockStyle.Right;
			this.flowUser.Height = 40;
			if (phone == this.splitCalendar.Panel2Collapsed)
				return;

			this.splitCalendar.Panel2Collapsed = phone;
			// back from the phone layout: the timeline gets its designed width again.
			if (!phone)
				this.splitCalendar.SplitterDistance = Math.Max(300, this.splitCalendar.Width - 364);
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

		private bool CalendarMode => this.segmentedMode.SelectedIndex != 1;

		/// <summary>The selected type, or null for all.</summary>
		private ActivityType? SelectedType =>
			this.chipsType.SelectedIndex > 0 ? (ActivityType)(this.chipsType.SelectedIndex - 1) : (ActivityType?)null;

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
			this.comboBoxUser.DataSource = items;
			this.comboBoxUser.SelectedItem = !CurrentUser.SeesAll
				? items.FirstOrDefault(i => i.Id == CurrentUser.Id) ?? items[0]
				: items[0];
		}

		private void ActivitiesView_Load(object sender, EventArgs e)
		{
			if (this.DesignMode)
				return;

			this.ready = true;
			UpdateMode();
		}

		private void UpdateMode()
		{
			var calendar = this.CalendarMode;
			this.splitCalendar.Visible = calendar;
			this.panelList.Visible = !calendar;
			this.buttonExport.Visible = !calendar;
			RefreshData();
		}

		#region Calendar

		// loads the activities of the range the scheduler shows and lists the selected day.
		private void LoadCalendar()
		{
			var from = this.schedulerView.RangeStart.Date;
			var to = this.schedulerView.RangeEnd.Date.AddDays(1);

			List<ActivityRow> rows = null;
			if (!Notify.Try(() => rows = ActivityService.Range(from, to, this.SelectedType, this.SelectedUserId), "Loading the calendar"))
				return;

			this.calendarRows = rows;
			this.schedulerView.Appointments.Clear();
			foreach (var row in rows)
			{
				this.schedulerView.Appointments.Add(new SchedulerAppointment
				{
					Id = row.Id.ToString(CultureInfo.InvariantCulture),
					Start = row.Date,
					End = row.End,
					Text = row.Subject,
					// the colour of the type, as in the WPF calendar.
					Tone = ActivityService.Tone(row.Type).ToMeter(),
					Tag = row,
				});
			}

			var month = this.schedulerView.Date;
			var inMonth = rows.Count(r => r.Date.Month == month.Month && r.Date.Year == month.Year);
			var monthText = month.ToString("MMMM yyyy", Fmt.Culture);
			this.labelCount.Text = inMonth == 1 ? "1 activity in " + monthText : inMonth + " activities in " + monthText;
			ShowSelectedDay();
		}

		// the activities of the selected day in the timeline next to the calendar.
		private void ShowSelectedDay()
		{
			var start = this.selectedDay;
			var end = start.AddDays(1);
			var rows = this.calendarRows.Where(r => r.Date >= start && r.Date < end).OrderBy(r => r.Date).ToList();

			this.labelDay.Text = start.ToString("dddd, MMMM d", Fmt.Culture)
				+ "  ·  " + (rows.Count == 0 ? "no activities" : rows.Count == 1 ? "1 activity" : rows.Count + " activities");

			var now = DateTime.Now;
			this.timelineDay.Items.Clear();
			foreach (var row in rows)
			{
				this.timelineDay.Items.Add(new TimelineItem
				{
					Time = row.Date,
					Title = row.Subject ?? row.TypeName,
					Description = row.Details + (string.IsNullOrEmpty(row.RelatedText) ? "" : " · " + row.RelatedText)
						+ (string.IsNullOrEmpty(row.UserName) ? "" : " · by " + row.UserName),
					Icon = row.TypeIcon,
					// planned activities stand out.
					Tone = row.Date > now ? TimelineTone.Primary : ActivityService.Tone(row.Type).ToTimeline(),
					Tag = row,
				});
			}
			this.emptyDay.Visible = rows.Count == 0;
		}

		#endregion

		private void LoadList()
		{
			List<ActivityRow> rows = null;
			if (!Notify.Try(() => rows = ActivityService.List(this.SelectedType, this.SelectedUserId), "Loading the activities"))
				return;

			this.grid.DataSource = rows;
			this.emptyState.Visible = rows.Count == 0;
			this.labelCount.Text = rows.Count == 1 ? "1 activity" : rows.Count + " activities";
		}

		// opens the record an activity relates to: its deal, else its contact, else its company.
		private void OpenRelated(ActivityRow row)
		{
			if (row.DealId != null)
			{
				if (Navigator.OpenDeal(row.DealId.Value) && !this.IsDisposed)
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

		/// <summary>The activity the context menu acts on: the row of the list, or the activity clicked last in the calendar.</summary>
		private ActivityRow SelectedRow => this.CalendarMode ? this.calendarRow : UiHelper.SelectedItem<ActivityRow>(this.grid);

		#region Handlers

		private void buttonLog_Click(object sender, EventArgs e)
		{
			LogActivity(null, this.SelectedType ?? ActivityType.Call);
		}

		private void buttonLogOnDay_Click(object sender, EventArgs e)
		{
			// a day starts at midnight: propose the morning instead (as the double-click on a WPF day).
			LogActivity(this.selectedDay.AddHours(9), ActivityType.Meeting);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			CsvExport.Save(this.grid, "activities.csv");
		}

		private void segmentedMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.ready && this.segmentedMode.SelectedIndex >= 0)
				UpdateMode();
		}

		private void filter_Changed(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void schedulerView_RangeChanged(object sender, EventArgs e)
		{
			if (this.ready && this.CalendarMode)
				LoadCalendar();
		}

		private void schedulerView_AppointmentClick(object sender, SchedulerAppointmentEventArgs e)
		{
			this.calendarRow = e.Appointment?.Tag as ActivityRow;
			this.selectedDay = e.OccurrenceStart.Date;
			ShowSelectedDay();
		}

		private void schedulerView_AppointmentDoubleClick(object sender, SchedulerAppointmentEventArgs e)
		{
			if (e.Appointment?.Tag is ActivityRow row)
				OpenRelated(row);
		}

		private void schedulerView_SlotDoubleClick(object sender, SchedulerSlotEventArgs e)
		{
			// a day of the month starts at midnight: propose the morning; a slot of the week or day view: its time.
			this.selectedDay = e.Start.Date;
			ShowSelectedDay();
			LogActivity(e.Start.TimeOfDay == TimeSpan.Zero ? e.Start.AddHours(9) : e.Start, ActivityType.Meeting);
		}

		private void timelineDay_ItemClick(object sender, TimelineItemEventArgs e)
		{
			this.calendarRow = e.Item?.Tag as ActivityRow;
			if (this.calendarRow != null)
				OpenRelated(this.calendarRow);
		}

		private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (UiHelper.RowItem<ActivityRow>(this.grid, e) is ActivityRow row)
				OpenRelated(row);
		}

		private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// the link of the "Related to" column.
			if (e.ColumnIndex >= 0 && this.grid.Columns[e.ColumnIndex] == this.colRelated
				&& UiHelper.RowItem<ActivityRow>(this.grid, e) is ActivityRow row && !string.IsNullOrEmpty(row.RelatedText))
				OpenRelated(row);
		}

		private void grid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			// the WPF DataGrid selects the row under a right click: the context menu acts on it.
			if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
				this.grid.CurrentCell = this.grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
		}

		private void menuOpen_Click(object sender, EventArgs e)
		{
			if (this.SelectedRow is ActivityRow row)
				OpenRelated(row);
		}

		private void menuDelete_Click(object sender, EventArgs e)
		{
			if (!(this.SelectedRow is ActivityRow row))
				return;

			if (ConfirmDialog.Ask("Delete activity", "Delete \"" + row.Subject + "\"? This cannot be undone.", "Delete")
				&& Notify.Try(() => ActivityService.Delete(row.Id), "Deleting the activity"))
			{
				Notify.Success(row.TypeName + " deleted.");
				RefreshData();
			}
		}

		#endregion
	}
}
