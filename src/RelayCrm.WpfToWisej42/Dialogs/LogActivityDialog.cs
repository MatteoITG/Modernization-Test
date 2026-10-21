using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using RelayCrm.Data;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Logs a call, email, meeting or note, prefilled with the record it relates to.
	/// Used by contacts, companies, deals and activities.
	/// </summary>
	public partial class LogActivityDialog : Form
	{
		private int? contactId;
		private int? companyId;
		private int? dealId;

		public LogActivityDialog()
		{
			InitializeComponent();
			DialogHelper.KeepOpenOnAccept(this);
		}

		/// <summary>
		/// Shows the dialog; returns true when an activity was logged.
		/// </summary>
		/// <param name="contactId">Related contact, or null.</param>
		/// <param name="companyId">Related company, or null.</param>
		/// <param name="dealId">Related deal, or null.</param>
		/// <param name="type">Preselected type.</param>
		/// <param name="date">Preselected date and time (a calendar day).</param>
		/// <param name="subject">Prefilled subject.</param>
		/// <param name="body">Prefilled notes (e.g. an email draft).</param>
		public static bool Log(int? contactId = null, int? companyId = null, int? dealId = null,
			ActivityType type = ActivityType.Call, DateTime? date = null, string subject = null, string body = null)
		{
			var dialog = new LogActivityDialog
			{
				contactId = contactId,
				companyId = companyId,
				dealId = dealId,
			};

			var when = date ?? DateTime.Now;
			dialog.datePickerDate.NullableValue = when.Date;
			dialog.textBoxTime.Text = when.ToString("HH:mm", CultureInfo.InvariantCulture);
			dialog.textBoxSubject.Text = subject ?? "";
			dialog.textBoxBody.Text = body ?? "";
			dialog.TypeRadio(type).Checked = true;

			string related = null;
			if (!Notify.Try(() => related = dialog.DescribeRelated(), "Loading the related records"))
			{
				dialog.Dispose();
				return false;
			}
			dialog.labelRelated.Text = related;
			dialog.Load += (s, e) => dialog.textBoxSubject.Focus();

			return DialogHelper.ShowModal(dialog);
		}

		private string DescribeRelated()
		{
			var parts = new List<string>();
			using (var uow = Store.Open())
			{
				if (this.contactId != null)
					parts.Add(uow.Contacts.Query().Where(c => c.Id == this.contactId).Select(c => c.FirstName + " " + c.LastName).FirstOrDefault());
				if (this.companyId != null)
					parts.Add(uow.Companies.Query().Where(c => c.Id == this.companyId).Select(c => c.Name).FirstOrDefault());
				if (this.dealId != null)
					parts.Add(uow.Deals.Query().Where(d => d.Id == this.dealId).Select(d => d.Title).FirstOrDefault());
			}
			parts.RemoveAll(string.IsNullOrEmpty);
			return parts.Count == 0 ? "Not related to a record" : "Related to " + string.Join(" · ", parts);
		}

		private RadioButton TypeRadio(ActivityType type)
		{
			switch (type)
			{
				case ActivityType.Email: return this.radioEmail;
				case ActivityType.Meeting: return this.radioMeeting;
				case ActivityType.Note: return this.radioNote;
				default: return this.radioCall;
			}
		}

		private ActivityType SelectedType =>
			this.radioEmail.Checked ? ActivityType.Email
			: this.radioMeeting.Checked ? ActivityType.Meeting
			: this.radioNote.Checked ? ActivityType.Note
			: ActivityType.Call;

		private void UpdateDuration()
		{
			var hasDuration = this.SelectedType == ActivityType.Call || this.SelectedType == ActivityType.Meeting;
			this.textBoxDuration.Enabled = hasDuration;
			int.TryParse(this.textBoxDuration.Text, out var minutes);
			if (hasDuration && minutes == 0)
				this.textBoxDuration.Text = this.SelectedType == ActivityType.Meeting ? "60" : "30";
			if (!hasDuration)
				this.textBoxDuration.Text = "0";
		}

		private void radioType_CheckedChanged(object sender, EventArgs e)
		{
			if (this.textBoxDuration != null && ((RadioButton)sender).Checked)
				UpdateDuration();
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			DialogHelper.ClearError(this.labelError);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			var subject = this.textBoxSubject.Text.Trim();
			if (subject.Length == 0)
			{
				DialogHelper.ShowError(this.labelError, "Enter a subject.", this.textBoxSubject);
				return;
			}

			if (this.datePickerDate.NullableValue == null)
			{
				DialogHelper.ShowError(this.labelError, "Enter the date.", this.datePickerDate);
				return;
			}

			if (!TimeSpan.TryParseExact(this.textBoxTime.Text.Trim(), new[] { @"h\:mm", @"hh\:mm" }, CultureInfo.InvariantCulture, out var time)
				|| time < TimeSpan.Zero || time >= TimeSpan.FromDays(1))
			{
				DialogHelper.ShowError(this.labelError, "Enter the time as hours and minutes, like 14:30.", this.textBoxTime);
				return;
			}

			var duration = 0;
			if (this.textBoxDuration.Enabled && (!int.TryParse(this.textBoxDuration.Text.Trim(), out duration) || duration < 0 || duration > 24 * 60))
			{
				DialogHelper.ShowError(this.labelError, "Enter the duration in minutes (0 to 1440).", this.textBoxDuration);
				return;
			}

			var date = this.datePickerDate.NullableValue.Value.Date + time;
			var type = this.SelectedType;
			var saved = Notify.Try(() => ActivityLogService.Log(
				type, subject, this.textBoxBody.Text.Trim(), date, duration, this.contactId, this.companyId, this.dealId), "Saving the activity");

			if (saved)
			{
				Notify.Success(type + " logged.");
				this.DialogResult = DialogResult.OK;
			}
		}
	}
}
