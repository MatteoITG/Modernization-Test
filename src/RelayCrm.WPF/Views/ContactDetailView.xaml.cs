using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using RelayCrm.Dialogs;
using RelayCrm.Services;

namespace RelayCrm.Views
{
	/// <summary>
	/// The page of one contact: header with avatar, name, title at company, stage and owner,
	/// actions, and the Overview, Activity, Deals and Tasks tabs.
	/// </summary>
	public partial class ContactDetailView : UserControl
	{
		private int contactId;
		private ContactDetail contact;

		public ContactDetailView()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Loads the contact and all its tabs.
		/// </summary>
		public void LoadContact(int contactId)
		{
			this.contactId = contactId;
			ReloadHeader();
			if (this.contact == null)
				return;
			LoadActivities();
			LoadDeals();
			LoadTasks();
		}

		private void ReloadHeader()
		{
			ContactDetail detail = null;
			if (!Notify.Try(() => detail = ContactService.Detail(this.contactId), "Loading the contact"))
				return;

			this.contact = detail;
			if (detail == null)
			{
				this.runName.Text = "Contact not found";
				this.labelTitleAt.Visibility = Visibility.Collapsed;
				this.labelOwner.Visibility = Visibility.Collapsed;
				this.labelInitials.Text = "?";
				this.tabControl.IsEnabled = false;
				foreach (var button in new[] { this.buttonLogActivity, this.buttonEdit, this.buttonNewDeal, this.buttonAddTask, this.buttonDelete })
					button.IsEnabled = false;
				return;
			}

			var name = string.IsNullOrEmpty(detail.FullName) ? "(No name)" : detail.FullName;
			this.labelInitials.Text = RelayCrm.Text.Initials(name);
			this.runName.Text = name;
			this.runStage.Text = detail.Stage.ToString();
			this.runStage.Foreground = ToneExtensions.StageTone(detail.Stage).ToBrush();

			var hasTitle = !string.IsNullOrEmpty(detail.Title);
			var hasCompany = detail.CompanyId != null && !string.IsNullOrEmpty(detail.CompanyName);
			this.runTitleAt.Text = hasTitle ? (hasCompany ? detail.Title + " at" : detail.Title) : (hasCompany ? "Works at" : "No title or company");
			this.runCompany.Text = hasCompany ? detail.CompanyName : "";
			this.linkCompany.IsEnabled = hasCompany;
			this.labelOwner.Text = "Owner: " + (detail.OwnerName ?? "Unassigned");

			// Overview
			this.textBoxEmail.Text = detail.Email ?? "";
			this.textBoxPhone.Text = detail.Phone ?? "";
			this.textBoxCompany.Text = detail.CompanyName ?? "";
			this.textBoxJobTitle.Text = detail.Title ?? "";
			this.textBoxStage.Text = detail.Stage.ToString();
			this.textBoxLeadSource.Text = detail.LeadSource ?? "";
			this.textBoxOwner.Text = detail.OwnerName ?? "Unassigned";
			this.textBoxLastContacted.Text = detail.LastContacted == null
				? "Never"
				: Fmt.DateAndTime(detail.LastContacted.Value) + " (" + Fmt.Relative(detail.LastContacted) + ")";
			this.textBoxCreated.Text = Fmt.Date(detail.CreatedAt);
			var tags = RelayCrm.Text.Tags(detail.Tags);
			this.textBoxTags.Text = tags.Length == 0 ? "No tags" : string.Join(", ", tags);
		}

		private void LoadActivities()
		{
			List<ContactActivityItem> activities = null;
			if (!Notify.Try(() => activities = ContactService.Activities(this.contactId), "Loading the activities"))
				return;

			var now = DateTime.Now;
			this.listActivity.ItemsSource = activities.Select(a =>
			{
				var meta = new List<string>();
				if (a.Duration > 0)
					meta.Add(a.Duration + " min");
				if (!string.IsNullOrEmpty(a.UserName))
					meta.Add("by " + a.UserName);

				var description = a.Body ?? "";
				description = (description.Length > 0 ? description + "\n" : "") + a.Type + (meta.Count > 0 ? " · " + string.Join(" · ", meta) : "");

				return new TimelineEntry(a.Date, string.IsNullOrEmpty(a.Subject) ? a.Type.ToString() : a.Subject, description)
				{
					TitleBrush = a.Date > now ? Tone.Primary.ToBrush() : SystemColors.ControlTextBrush,
					Tag = a.Id,
				};
			}).ToList();

			this.emptyActivity.Visibility = activities.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
			this.tabActivity.Header = activities.Count == 0 ? "Activity" : "Activity (" + activities.Count + ")";
		}

		private void LoadDeals()
		{
			List<ContactDealItem> deals = null;
			if (!Notify.Try(() => deals = ContactService.Deals(this.contactId), "Loading the deals"))
				return;

			this.gridDeals.ItemsSource = deals;
			this.emptyDeals.Visibility = deals.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
			this.tabDeals.Header = deals.Count == 0 ? "Deals" : "Deals (" + deals.Count + ")";
		}

		private void LoadTasks()
		{
			List<ContactTaskItem> tasks = null;
			if (!Notify.Try(() => tasks = ContactService.Tasks(this.contactId), "Loading the tasks"))
				return;

			this.gridTasks.ItemsSource = tasks;
			this.emptyTasks.Visibility = tasks.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
			var open = tasks.Count(t => t.Status != "Done");
			this.tabTasks.Header = open == 0 ? "Tasks" : "Tasks (" + open + ")";
		}

		private void linkBack_Click(object sender, RoutedEventArgs e)
		{
			Navigator.Back();
		}

		private void linkCompany_Click(object sender, RoutedEventArgs e)
		{
			if (this.contact?.CompanyId != null)
				Navigator.OpenCompany(this.contact.CompanyId.Value);
		}

		private void buttonLogActivity_Click(object sender, RoutedEventArgs e)
		{
			if (this.contact == null)
				return;
			if (LogActivityDialog.Log(this.contactId, this.contact.CompanyId))
			{
				ReloadHeader();
				LoadActivities();
				this.tabControl.SelectedItem = this.tabActivity;
			}
		}

		private void buttonEdit_Click(object sender, RoutedEventArgs e)
		{
			if (this.contact != null && ContactEditDialog.Edit(this.contactId))
				ReloadHeader();
		}

		private void buttonNewDeal_Click(object sender, RoutedEventArgs e)
		{
			if (this.contact == null)
				return;
			if (DealEditDialog.Edit(null, this.contact.CompanyId, this.contactId))
			{
				LoadDeals();
				this.tabControl.SelectedItem = this.tabDeals;
			}
		}

		private void buttonAddTask_Click(object sender, RoutedEventArgs e)
		{
			if (this.contact == null)
				return;
			if (TaskEditDialog.Edit(null, this.contactId))
			{
				LoadTasks();
				Navigator.RefreshBadges();
				this.tabControl.SelectedItem = this.tabTasks;
			}
		}

		private void buttonDelete_Click(object sender, RoutedEventArgs e)
		{
			if (this.contact == null)
				return;
			if (!ConfirmDialog.Ask("Delete contact?",
				"Delete " + this.contact.FullName + "? Their activities, tasks and deals are kept without the contact.", "Delete"))
				return;

			if (Notify.Try(() => ContactService.Delete(this.contactId), "Deleting the contact"))
			{
				Notify.Success(this.contact.FullName + " deleted.");
				Navigator.Back();
			}
		}

		private void gridDeals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (UiHelper.RowItem<ContactDealItem>(e) is ContactDealItem deal && Navigator.OpenDeal(deal.Id))
				LoadDeals();
		}

		private void gridTasks_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (UiHelper.RowItem<ContactTaskItem>(e) is ContactTaskItem task && TaskEditDialog.Edit(task.Id))
			{
				LoadTasks();
				Navigator.RefreshBadges();
			}
		}
	}
}
