using System;
using System.Linq;
using System.Windows.Forms;
using RelayCrm.Data;
using RelayCrm.Services;

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
			using (var dialog = new TaskEditDialog())
			{
				if (!dialog.LoadTask(taskId, contactId, companyId, dealId))
					return false;

				return dialog.ShowDialog(Form.ActiveForm) == DialogResult.OK;
			}
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
				foreach (var user in LookupService.Users().Where(u => u.Active || u.Id == assigneeId))
				{
					var index = this.comboBoxAssignee.Items.Add(user);
					if (user.Id == assigneeId)
						this.comboBoxAssignee.SelectedIndex = index;
				}

				this.labelRelated.Text = DescribeRelated(contactId, companyId, dealId);
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
				this.dateTimePickerDue.Value = DateTime.Today.AddDays(1);
				this.comboBoxPriority.SelectedIndex = (int)TaskPriority.Normal;
				this.comboBoxStatus.SelectedIndex = (int)CrmTaskStatus.Open;
				this.comboBoxStatus.Visible = false;
				this.labelStatus.Visible = false;
			}
			else
			{
				this.Text = "Edit task";
				this.textBoxTitle.Text = task.Title;
				this.dateTimePickerDue.Value = task.DueDate;
				this.comboBoxPriority.SelectedIndex = (int)task.Priority;
				this.comboBoxStatus.SelectedIndex = (int)task.Status;
				this.buttonDelete.Visible = true;
			}
			return true;
		}

		private static string DescribeRelated(int? contactId, int? companyId, int? dealId)
		{
			var text = TaskService.DescribeRelated(contactId, companyId, dealId);
			return text.Length == 0 ? "Not related to a record" : "Related to " + text;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			var title = this.textBoxTitle.Text.Trim();
			if (title.Length == 0)
			{
				this.errorProvider.SetError(this.textBoxTitle, "Enter a title.");
				this.textBoxTitle.Focus();
				return;
			}

			var task = new CrmTask
			{
				Id = this.taskId ?? 0,
				Title = title,
				DueDate = this.dateTimePickerDue.Value.Date,
				Priority = (TaskPriority)Math.Max(0, this.comboBoxPriority.SelectedIndex),
				Status = (CrmTaskStatus)Math.Max(0, this.comboBoxStatus.SelectedIndex),
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

		private void textBoxTitle_TextChanged(object sender, EventArgs e)
		{
			this.errorProvider.SetError(this.textBoxTitle, "");
		}
	}
}
