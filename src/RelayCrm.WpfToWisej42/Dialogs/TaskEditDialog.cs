using System;
using System.Linq;
using RelayCrm.Data;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Creates or edits a task, optionally related to a contact, a company or a deal.
	/// </summary>
	public partial class TaskEditDialog : Form
	{
		private int? taskId;
		private int? contactId;
		private int? companyId;
		private int? dealId;

		public TaskEditDialog()
		{
			InitializeComponent();
			DialogHelper.KeepOpenOnAccept(this);

			this.comboBoxPriority.DataSource = Enum.GetValues(typeof(TaskPriority));
			this.comboBoxStatus.DataSource = Enum.GetValues(typeof(CrmTaskStatus));
		}

		/// <summary>
		/// Shows the dialog to create (<paramref name="taskId"/> null) or edit a task; returns true when it was saved or deleted.
		/// </summary>
		/// <param name="taskId">The task to edit, or null for a new task.</param>
		/// <param name="contactId">Related contact of a new task.</param>
		/// <param name="companyId">Related company of a new task.</param>
		/// <param name="dealId">Related deal of a new task.</param>
		public static bool Edit(int? taskId, int? contactId = null, int? companyId = null, int? dealId = null)
		{
			var dialog = new TaskEditDialog();
			if (!dialog.LoadTask(taskId, contactId, companyId, dealId))
			{
				dialog.Dispose();
				return false;
			}
			return DialogHelper.ShowModal(dialog);
		}

		private bool LoadTask(int? taskId, int? contactId, int? companyId, int? dealId)
		{
			CrmTask task = null;
			var loaded = Notify.Try(() =>
			{
				task = taskId == null ? null : TaskService.Load(taskId.Value);
				if (task != null)
				{
					contactId = task.ContactId;
					companyId = task.CompanyId;
					dealId = task.DealId;
				}

				var assigneeId = task?.AssigneeId ?? (CurrentUser.IsSignedIn ? CurrentUser.Id : (int?)null);
				var users = LookupService.Users().Where(u => u.Active || u.Id == assigneeId).ToList();
				this.comboBoxAssignee.DataSource = users;
				this.comboBoxAssignee.SelectedItem = users.FirstOrDefault(u => u.Id == assigneeId);

				var related = TaskService.DescribeRelated(contactId, companyId, dealId);
				this.labelRelated.Text = related.Length == 0 ? "Not related to a record" : "Related to " + related;
			}, "Loading the task");

			if (!loaded)
				return false;

			if (taskId != null && task == null)
			{
				Notify.Warning("The task no longer exists.");
				return false;
			}

			this.taskId = taskId;
			this.contactId = contactId;
			this.companyId = companyId;
			this.dealId = dealId;

			if (task == null)
			{
				this.Text = "New task";
				this.datePickerDue.NullableValue = DateTime.Today.AddDays(1);
				this.comboBoxPriority.SelectedItem = TaskPriority.Normal;
				this.comboBoxStatus.SelectedItem = CrmTaskStatus.Open;
				this.comboBoxStatus.Visible = false;
				this.labelStatus.Visible = false;
			}
			else
			{
				this.Text = "Edit task";
				this.textBoxTitle.Text = task.Title;
				this.datePickerDue.NullableValue = task.DueDate;
				this.comboBoxPriority.SelectedItem = task.Priority;
				this.comboBoxStatus.SelectedItem = task.Status;
				this.buttonDelete.Visible = true;
			}

			this.Load += (s, e) => this.textBoxTitle.Focus();
			return true;
		}

		private void textBoxTitle_TextChanged(object sender, EventArgs e)
		{
			DialogHelper.ClearError(this.labelError);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			var title = this.textBoxTitle.Text.Trim();
			if (title.Length == 0)
			{
				DialogHelper.ShowError(this.labelError, "Enter a title.", this.textBoxTitle);
				return;
			}
			if (this.datePickerDue.NullableValue == null)
			{
				DialogHelper.ShowError(this.labelError, "Enter the due date.", this.datePickerDue);
				return;
			}

			var task = new CrmTask
			{
				Id = this.taskId ?? 0,
				Title = title,
				DueDate = this.datePickerDue.NullableValue.Value.Date,
				Priority = this.comboBoxPriority.SelectedItem is TaskPriority priority ? priority : TaskPriority.Normal,
				Status = this.comboBoxStatus.SelectedItem is CrmTaskStatus status ? status : CrmTaskStatus.Open,
				AssigneeId = (this.comboBoxAssignee.SelectedItem as UserItem)?.Id,
				ContactId = this.contactId,
				CompanyId = this.companyId,
				DealId = this.dealId,
			};

			if (Notify.Try(() => TaskService.Save(task), "Saving the task"))
			{
				Notify.Success(this.taskId == null ? "Task created." : "Task saved.");
				Navigator.RefreshBadges();
				this.DialogResult = DialogResult.OK;
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (this.taskId == null || !ConfirmDialog.Ask("Delete task", "Delete \"" + this.textBoxTitle.Text.Trim() + "\"? This cannot be undone.", "Delete"))
				return;

			if (Notify.Try(() => TaskService.Delete(this.taskId.Value), "Deleting the task"))
			{
				Notify.Success("Task deleted.");
				Navigator.RefreshBadges();
				this.DialogResult = DialogResult.OK;
			}
		}
	}
}
