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

		public ActivitiesView()
		{
			InitializeComponent();

			this.grid.AutoGenerateColumns = false;
			this.grid.DefaultCellStyle.FormatProvider = Fmt.Culture;
			IconImages.Apply(this.toolStrip);
			this.listViewDay.SmallImageList = IconImages.List(16, "telephone", "envelope", "people", "sticky");

			this.comboType.Items.AddRange(new object[] { "All types", "Call", "Email", "Meeting", "Note" });
			this.comboType.SelectedIndex = 0;
			this.monthCalendar.SetDate(DateTime.Today);
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

		// loads the activities of the months the calendar shows, bolds their days and lists the selected days.
		private void LoadCalendar()
		{
			var range = this.monthCalendar.GetDisplayRange();
			this.loadedStart = range.Start;
			this.loadedEnd = range.End;
			var from = range.Start.Date;
			var to = range.End.Date.AddDays(1);

			List<ActivityRow> rows = null;
			if (!Notify.Try(() => rows = ActivityService.Range(from, to, this.SelectedType, this.SelectedUserId), "Loading the calendar"))
				return;

			this.calendarRows = rows;
			this.monthCalendar.BoldedDates = rows.Select(r => r.Date.Date).Distinct().ToArray();
			this.labelCount.Text = rows.Count == 1 ? "1 activity in view" : rows.Count + " activities in view";
			ShowSelectedDays();
		}

		private void ShowSelectedDays()
		{
			var start = this.monthCalendar.SelectionStart.Date;
			var end = this.monthCalendar.SelectionEnd.Date.AddDays(1);
			var rows = this.calendarRows.Where(r => r.Date >= start && r.Date < end).OrderBy(r => r.Date).ToList();
			var oneDay = end == start.AddDays(1);

			this.labelDay.Text = (oneDay
				? start.ToString("dddd, MMMM d, yyyy", Fmt.Culture)
				: start.ToString("MMM d", Fmt.Culture) + " – " + end.AddDays(-1).ToString("MMM d, yyyy", Fmt.Culture))
				+ "   ·   " + (rows.Count == 0 ? "no activities" : rows.Count == 1 ? "1 activity" : rows.Count + " activities");

			var now = DateTime.Now;
			this.listViewDay.BeginUpdate();
			this.listViewDay.Items.Clear();
			foreach (var row in rows)
			{
				var time = oneDay ? row.Date.ToString("HH:mm", Fmt.Culture) : row.Date.ToString("ddd d, HH:mm", Fmt.Culture);
				var item = new ListViewItem(time, Icons.NameOf(row.TypeIcon)) { Tag = row, ToolTipText = row.Body };
				item.SubItems.Add(row.TypeName);
				item.SubItems.Add(row.Subject ?? "");
				item.SubItems.Add(row.RelatedText);
				item.SubItems.Add(row.UserName);
				item.SubItems.Add(row.Duration > 0 ? row.Duration + " min" : "");
				// planned activities stand out.
				if (row.Date > now)
					item.ForeColor = Tone.Primary.ToColor();
				this.listViewDay.Items.Add(item);
			}
			this.listViewDay.EndUpdate();
		}

		#endregion

		private void LoadList()
		{
			List<ActivityRow> rows = null;
			if (!Notify.Try(() => rows = ActivityService.List(this.SelectedType, this.SelectedUserId), "Loading the activities"))
				return;

			this.grid.DataSource = new SortableBindingList<ActivityRow>(rows);
			this.labelEmpty.Visible = rows.Count == 0;
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
					return this.listViewDay.SelectedItems.Count > 0 ? this.listViewDay.SelectedItems[0].Tag as ActivityRow : null;
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
			// a day of the calendar: propose the morning, or now when it is today.
			var day = this.monthCalendar.SelectionStart.Date;
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

		private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
		{
			if (!this.ready)
				return;

			// paging to another month needs its activities; a new selection in the same months only filters.
			var range = this.monthCalendar.GetDisplayRange();
			var loaded = range.Start == this.loadedStart && range.End == this.loadedEnd;
			this.loadedStart = range.Start;
			this.loadedEnd = range.End;
			if (loaded)
				ShowSelectedDays();
			else
				LoadCalendar();
		}

		// the months whose activities are loaded.
		private DateTime loadedStart, loadedEnd;

		private void listViewDay_ItemActivate(object sender, EventArgs e)
		{
			if (this.SelectedRow != null)
				OpenRelated(this.SelectedRow);
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
