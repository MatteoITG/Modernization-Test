using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Views
{
	/// <summary>
	/// Activities as a calendar (SchedulerView) or as a list, filtered by type and user.
	/// </summary>
	public partial class ActivitiesView : UserControl, IRefreshable
	{
		// true after the first load: the filters' events reload the data only from then on.
		private bool ready;

		public ActivitiesView()
		{
			InitializeComponent();

			this.scheduler.Date = DateTime.Today;
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

		private bool CalendarMode => this.segmentedMode.SelectedIndex != 1;

		/// <summary>The selected type, or null for all.</summary>
		private ActivityType? SelectedType =>
			this.chipGroupType.SelectedIndex > 0 ? (ActivityType)(this.chipGroupType.SelectedIndex - 1) : (ActivityType?)null;

		/// <summary>The selected user, or null for all users.</summary>
		private int? SelectedUserId
		{
			get
			{
				var id = (this.comboBoxUser.SelectedItem as RelayCrm.Services.ListItem)?.Id ?? 0;
				return id == 0 ? (int?)null : id;
			}
		}

		// "All users" and the users; Sales see their own activities by default.
		private void LoadUsers()
		{
			this.comboBoxUser.Items.Add(new RelayCrm.Services.ListItem(0, "All users"));
			this.comboBoxUser.SelectedIndex = 0;

			Notify.Try(() =>
			{
				foreach (var user in LookupService.Users())
				{
					var index = this.comboBoxUser.Items.Add(new RelayCrm.Services.ListItem(user.Id, user.Name));
					if (!CurrentUser.SeesAll && user.Id == CurrentUser.Id)
						this.comboBoxUser.SelectedIndex = index;
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
			this.scheduler.Visible = calendar;
			this.buttonExport.Visible = !calendar;
			if (calendar)
			{
				this.grid.Visible = false;
				this.emptyState.Visible = false;
			}
			RefreshData();
		}

		// loads the activities of the range the calendar shows.
		private void LoadCalendar()
		{
			DateTime from = this.scheduler.RangeStart.Date;
			DateTime to = this.scheduler.RangeEnd.Date.AddDays(1);
			if (from == DateTime.MinValue || to <= from)
			{
				// range not known yet: the month of the calendar's date with the weeks around it.
				var month = new DateTime(this.scheduler.Date.Year, this.scheduler.Date.Month, 1);
				from = month.AddDays(-7);
				to = month.AddMonths(1).AddDays(7);
			}

			List<ActivityRow> rows = null;
			if (!Notify.Try(() => rows = ActivityService.Range(from, to, this.SelectedType, this.SelectedUserId), "Loading the calendar"))
				return;

			this.scheduler.Appointments.Clear();
			foreach (var row in rows)
			{
				this.scheduler.Appointments.Add(new SchedulerAppointment
				{
					Id = row.Id.ToString(),
					Start = row.Date,
					End = row.End,
					Text = row.Subject,
					Tone = ActivityService.Tone(row.Type).ToMeter(),
					Tag = row,
				});
			}

			this.labelCount.Text = rows.Count == 1 ? "1 activity in view" : rows.Count + " activities in view";
		}

		private void LoadList()
		{
			List<ActivityRow> rows = null;
			if (!Notify.Try(() => rows = ActivityService.List(this.SelectedType, this.SelectedUserId), "Loading the activities"))
				return;

			this.grid.DataSource = rows;
			this.grid.Visible = rows.Count > 0;
			this.emptyState.Visible = rows.Count == 0;
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
			if (LogActivityDialog.Show(type: type, date: date))
				RefreshData();
		}

		private void buttonLog_Click(object sender, EventArgs e)
		{
			LogActivity(null, this.SelectedType ?? ActivityType.Call);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			CsvExport.Download(this.grid, "activities.csv");
		}

		private void segmentedMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.ready)
				UpdateMode();
		}

		private void filter_Changed(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void scheduler_RangeChanged(object sender, EventArgs e)
		{
			if (this.CalendarMode)
				RefreshData();
		}

		private void scheduler_SlotDoubleClick(object sender, SchedulerSlotEventArgs e)
		{
			// a month cell starts at midnight: propose the morning instead.
			var start = e.Start.TimeOfDay == TimeSpan.Zero ? e.Start.Date.AddHours(9) : e.Start;
			LogActivity(start, ActivityType.Meeting);
		}

		private void scheduler_AppointmentClick(object sender, SchedulerAppointmentEventArgs e)
		{
			if (e.Appointment?.Tag is ActivityRow row)
				OpenRelated(row);
		}

		private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex != this.colRelated.Index)
				return;

			if (this.grid.Rows[e.RowIndex].DataBoundItem is ActivityRow row && !string.IsNullOrEmpty(row.RelatedText))
				OpenRelated(row);
		}

		private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex == this.colRelated.Index || e.ColumnIndex == this.colActions.Index)
				return;

			if (this.grid.Rows[e.RowIndex].DataBoundItem is ActivityRow row)
				OpenRelated(row);
		}

		private void colActions_ActionClick(object sender, DataGridViewVisualCellEventArgs e)
		{
			if (!(e.DataBoundItem is ActivityRow row))
				return;

			switch (e.Action?.Name)
			{
				case "open":
					OpenRelated(row);
					break;

				case "delete":
					if (ConfirmDialog.Ask("Delete activity", "Delete \"" + row.Subject + "\"? This cannot be undone.", "Delete")
						&& Notify.Try(() => ActivityService.Delete(row.Id), "Deleting the activity"))
					{
						Notify.Success(row.TypeName + " deleted.");
						RefreshData();
					}
					break;
			}
		}
	}
}
