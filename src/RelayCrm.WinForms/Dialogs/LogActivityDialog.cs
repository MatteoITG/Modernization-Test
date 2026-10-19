using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RelayCrm.Data;
using RelayCrm.Services;

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
		public static bool Show(int? contactId = null, int? companyId = null, int? dealId = null,
			ActivityType type = ActivityType.Call, DateTime? date = null, string subject = null, string body = null)
		{
			using (var dialog = new LogActivityDialog())
			{
				dialog.contactId = contactId;
				dialog.companyId = companyId;
				dialog.dealId = dealId;
				dialog.SelectedType = type;
				dialog.dateTimePickerDate.Value = date ?? DateTime.Now;
				dialog.textBoxSubject.Text = subject ?? "";
				dialog.textBoxBody.Text = body ?? "";
				Notify.Try(() => dialog.labelRelated.Text = dialog.DescribeRelated(), "Loading the related records");
				dialog.UpdateDuration();
				return dialog.ShowDialog(Form.ActiveForm) == DialogResult.OK;
			}
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

		private RadioButton[] TypeButtons => new[] { this.radioCall, this.radioEmail, this.radioMeeting, this.radioNote };

		private ActivityType SelectedType
		{
			get { return (ActivityType)Math.Max(0, Array.FindIndex(this.TypeButtons, b => b.Checked)); }
			set { this.TypeButtons[(int)value].Checked = true; }
		}

		private void UpdateDuration()
		{
			var hasDuration = this.SelectedType == ActivityType.Call || this.SelectedType == ActivityType.Meeting;
			this.numericDuration.Enabled = hasDuration;
			if (hasDuration && this.numericDuration.Value == 0)
				this.numericDuration.Value = this.SelectedType == ActivityType.Meeting ? 60 : 30;
			if (!hasDuration)
				this.numericDuration.Value = 0;
		}

		private void radioType_CheckedChanged(object sender, EventArgs e)
		{
			if (((RadioButton)sender).Checked)
				UpdateDuration();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			var subject = this.textBoxSubject.Text.Trim();
			if (subject.Length == 0)
			{
				this.errorProvider.SetError(this.textBoxSubject, "Enter a subject.");
				this.textBoxSubject.Focus();
				return;
			}

			var saved = Notify.Try(() => ActivityLogService.Log(
				this.SelectedType, subject, this.textBoxBody.Text.Trim(), this.dateTimePickerDate.Value,
				(int)this.numericDuration.Value, this.contactId, this.companyId, this.dealId), "Saving the activity");

			if (saved)
			{
				Notify.Success(this.SelectedType + " logged.");
				this.DialogResult = DialogResult.OK;
			}
		}

		private void textBoxSubject_TextChanged(object sender, EventArgs e)
		{
			this.errorProvider.SetError(this.textBoxSubject, "");
		}
	}
}
