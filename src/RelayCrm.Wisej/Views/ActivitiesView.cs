using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;

namespace RelayCrm.Views
{
	/// <summary>
	/// Activities as a calendar (a month calendar and the activities of the selected days) or as a list,
	/// filtered by type and user.
	/// </summary>
	public partial class ActivitiesView : UserControl, IRefreshable
	{
		// true after the first load: the filters' events reload the data only from then on.
		private bool ready;

		// the activities of the months the calendar shows.
		private List<ActivityRow> calendarRows = new List<ActivityRow>();

		// the day the timeline next to the calendar shows, and the activity clicked last in the calendar.
		private DateTime selectedDay = DateTime.Today;
		private ActivityRow calendarRow;

		public ActivitiesView()
		{
			InitializeComponent();

			this.grid.AutoGenerateColumns = false;
			this.grid.DefaultCellStyle.FormatProvider = Fmt.Culture;
			IconImages.Apply(this.toolStrip);

			this.comboType.Items.AddRange(new object[] { "All types", "Call", "Email", "Meeting", "Note" });
			this.comboType.SelectedIndex = 0;
			LoadUsers();
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

		private bool CalendarMode => this.buttonCalendar.Pushed;

		/// <summary>The selected type, or null for all.</summary>
		private ActivityType? SelectedType =>
			this.comboType.SelectedIndex > 0 ? (ActivityType)(this.comboType.SelectedIndex - 1) : (ActivityType?)null;

		/// <summary>The selected user, or null for all users.</summary>
		private int? SelectedUserId
		{
			get
			{
				var id = (this.comboUser.SelectedItem as ListItem)?.Id ?? 0;
				return id == 0 ? (int?)null : id;
			}
		}

		// "All users" and the users; Sales see their own activities by default.
		private void LoadUsers()
		{
			this.comboUser.Items.Add(new ListItem(0, "All users"));
			this.comboUser.SelectedIndex = 0;

			Notify.Try(() =>
			{
				foreach (var user in LookupService.Users())
				{
					var index = this.comboUser.Items.Add(new ListItem(user.Id, user.Name));
					if (!CurrentUser.SeesAll && user.Id == CurrentUser.Id)
						this.comboUser.SelectedIndex = index;
				}
			}, "Loading the users");
		}

		private void ActivitiesView_Load(object sender, EventArgs e)
		{
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
			var now = DateTime.Now;
			this.schedulerView.Appointments.Clear();
			foreach (var row in rows)
			{
				this.schedulerView.Appointments.Add(new SchedulerAppointment
				{
					Id = row.Id.ToString(System.Globalization.CultureInfo.InvariantCulture),
					Start = row.Date,
					End = row.End,
					Text = row.TypeName + ": " + row.Subject,
					// planned activities stand out.
					Tone = row.Date > now ? MeterTone.Primary : row.Type == ActivityType.Meeting ? MeterTone.Success : MeterTone.Neutral,
					Tag = row,
				});
			}
			this.labelCount.Text = rows.Count == 1 ? "1 activity in view" : rows.Count + " activities in view";
			ShowSelectedDays();
		}

		private void ShowSelectedDays()
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
					Description = row.TypeName + (string.IsNullOrEmpty(row.RelatedText) ? "" : " · " + row.RelatedText)
						+ " · " + row.UserName + (row.Duration > 0 ? " · " + row.Duration + " min" : ""),
					Icon = row.TypeIcon,
					// planned activities stand out.
					Tone = row.Date > now ? TimelineTone.Primary : TimelineTone.Neutral,
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

			this.grid.DataSource = new SortableBindingList<ActivityRow>(rows);
			this.emptyList.Visible = rows.Count == 0;
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
				MessageBox.Show(row.TypeName + " · " + Fmt.DateAndTime(row.Date) + "\n\n" + row.Subject
					+ (string.IsNullOrWhiteSpace(row.Body) ? "" : "\n\n" + row.Body), "Activity", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void LogActivity(DateTime? date, ActivityType type)
		{
			if (LogActivityDialog.Show(type: type, date: date))
				RefreshData();
		}

		/// <summary>The activity the context menu or the keyboard acts on.</summary>
		private ActivityRow SelectedRow
		{
			get
			{
				if (this.CalendarMode)
					return this.calendarRow;
				return GridHelper.Current<ActivityRow>(this.grid);
			}
		}

		private void DeleteActivity(ActivityRow row)
		{
			if (ConfirmDialog.Ask("Delete activity", "Delete \"" + row.Subject + "\"? This cannot be undone.", "Delete")
				&& Notify.Try(() => ActivityService.Delete(row.Id), "Deleting the activity"))
			{
				Notify.Success(row.TypeName + " deleted.");
				RefreshData();
			}
		}

		#region Handlers

		private void buttonLog_Click(object sender, EventArgs e)
		{
			LogActivity(null, this.SelectedType ?? ActivityType.Call);
		}

		private void buttonLogOnDay_Click(object sender, EventArgs e)
		{
			// the day of the timeline: propose the morning, or now when it is today.
			var day = this.selectedDay;
			var date = day == DateTime.Today ? DateTime.Now : day.AddHours(9);
			LogActivity(date, this.SelectedType ?? ActivityType.Meeting);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			CsvExport.Save(this.grid, "activities.csv");
		}

		private void buttonMode_Click(object sender, EventArgs e)
		{
			var calendar = sender == this.buttonCalendar;
			if (calendar == this.CalendarMode)
				return;

			this.buttonCalendar.Pushed = calendar;
			this.buttonList.Pushed = !calendar;
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
			ShowSelectedDays();
		}

		private void schedulerView_AppointmentDoubleClick(object sender, SchedulerAppointmentEventArgs e)
		{
			if (e.Appointment?.Tag is ActivityRow row)
				OpenRelated(row);
		}

		private void schedulerView_SlotDoubleClick(object sender, SchedulerSlotEventArgs e)
		{
			// a day of the month: propose the morning; a slot of the week or day view: its time.
			this.selectedDay = e.Start.Date;
			ShowSelectedDays();
			LogActivity(e.Start.TimeOfDay == TimeSpan.Zero ? e.Start.AddHours(9) : e.Start, this.SelectedType ?? ActivityType.Meeting);
		}

		private void timelineDay_ItemClick(object sender, TimelineItemEventArgs e)
		{
			this.calendarRow = e.Item?.Tag as ActivityRow;
			if (this.calendarRow != null)
				OpenRelated(this.calendarRow);
		}

		private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex != this.colRelated.Index)
				return;

			var row = GridHelper.RowAt<ActivityRow>(this.grid, e.RowIndex);
			if (row != null && !string.IsNullOrEmpty(row.RelatedText))
				OpenRelated(row);
		}

		private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == this.colRelated.Index)
				return;

			var row = GridHelper.RowAt<ActivityRow>(this.grid, e.RowIndex);
			if (row != null)
				OpenRelated(row);
		}

		private void grid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			GridHelper.SelectOnRightClick(this.grid, e);
		}

		private void grid_KeyDown(object sender, KeyEventArgs e)
		{
			var row = this.SelectedRow;
			if (row == null)
				return;

			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = true;
				OpenRelated(row);
			}
			else if (e.KeyCode == Keys.Delete)
			{
				e.Handled = true;
				DeleteActivity(row);
			}
		}

		private void contextMenu_Opening(object sender, EventArgs e)
		{
			// the popup of a Wisej context menu cannot be cancelled: the commands check the selected row.
		}

		private void menuOpen_Click(object sender, EventArgs e)
		{
			if (this.SelectedRow != null)
				OpenRelated(this.SelectedRow);
		}

		private void menuDelete_Click(object sender, EventArgs e)
		{
			if (this.SelectedRow != null)
				DeleteActivity(this.SelectedRow);
		}

		#endregion
	}
}
