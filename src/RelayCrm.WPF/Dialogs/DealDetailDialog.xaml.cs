using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using RelayCrm.Services;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// A deal: header, stage progress, fields, related contacts, activity timeline and tasks.
	/// Opened by <see cref="Navigator.OpenDeal"/>.
	/// </summary>
	public partial class DealDetailDialog : Window
	{
		/// <summary>One step of the stage progress.</summary>
		public class StepItem
		{
			public string Text { get; set; }
			public string Description { get; set; }
			public string ToolTip { get; set; }
			public Brush Background { get; set; }
			public Brush Foreground { get; set; }
			public FontWeight Weight { get; set; } = FontWeights.Normal;
			public TextDecorationCollection Decorations { get; set; }
		}

		private int dealId;
		private DealDetail detail;

		// navigation to run once the dialog is closed (company or contact page).
		private Action afterClose;

		public DealDetailDialog()
		{
			InitializeComponent();
		}

		/// <summary>True when anything was changed while the dialog was open.</summary>
		public bool Changed { get; private set; }

		/// <summary>Loads the deal to show.</summary>
		public void LoadDeal(int dealId)
		{
			this.dealId = dealId;
			Reload();
		}

		/// <summary>Runs the navigation the user asked for (company, contact) after the dialog closed.</summary>
		public void RunAfterClose()
		{
			var action = this.afterClose;
			this.afterClose = null;
			action?.Invoke();
		}

		private void Reload()
		{
			DealDetail loaded = null;
			if (!Notify.Try(() => loaded = DealService.Detail(this.dealId), "Loading the deal"))
				return;

			this.detail = loaded;
			if (loaded == null)
			{
				this.Title = "Deal not found";
				this.labelTitle.Text = "This deal no longer exists.";
				this.buttonEdit.IsEnabled = this.buttonDelete.IsEnabled = this.buttonLogActivity.IsEnabled = this.buttonAddTask.IsEnabled = false;
				this.linkCompany.IsEnabled = this.linkContact.IsEnabled = false;
				return;
			}

			var deal = loaded.Deal;
			this.Title = "Deal · " + deal.Title;
			ShowHeader(deal);
			ShowStages(loaded);
			ShowFields(loaded);
			ShowContacts(loaded);
			ShowActivities(loaded);
			ShowTasks(loaded);
		}

		private void ShowHeader(DealRow deal)
		{
			this.labelTitle.Text = deal.Title;
			this.runCompany.Text = string.IsNullOrEmpty(deal.CompanyName) ? "No company" : deal.CompanyName;
			this.linkCompany.IsEnabled = deal.CompanyId != null;
			this.runAmount.Text = deal.AmountText;
			this.runStage.Text = deal.StageName;
			this.runStage.Foreground = (deal.StageName == "Negotiation" && deal.IsOpen ? Tone.Warning : ToneExtensions.DealStageTone(deal.IsWon, deal.IsLost)).ToBrush();
			this.runOwner.Text = deal.OwnerName;
		}

		/// <summary>Open stages in order and the closing step: Won, or Lost in red.</summary>
		private void ShowStages(DealDetail detail)
		{
			var deal = detail.Deal;
			var open = detail.Stages.Where(s => !s.IsWon && !s.IsLost).OrderBy(s => s.Order).ToList();
			var won = detail.Stages.FirstOrDefault(s => s.IsWon);
			var lost = detail.Stages.FirstOrDefault(s => s.IsLost);
			var current = open.FindIndex(s => s.Id == deal.StageId);

			var steps = open.Select((stage, i) =>
			{
				var completed = deal.IsWon || (!deal.IsLost && i < current);
				var active = !deal.IsWon && !deal.IsLost && i == current;
				return Step(stage.Name, stage.Probability + "%",
					completed ? Tone.Success : active ? Tone.Primary : Tone.Neutral, active, skipped: deal.IsLost);
			}).ToList();

			if (deal.IsLost)
				steps.Add(Step(lost?.Name ?? "Lost", detail.ClosedDate == null ? "" : Fmt.Date(detail.ClosedDate.Value), Tone.Danger, true));
			else
				steps.Add(Step(won?.Name ?? "Won", deal.IsWon && detail.ClosedDate != null ? Fmt.Date(detail.ClosedDate.Value) : "100%",
					deal.IsWon ? Tone.Success : Tone.Neutral, deal.IsWon));

			this.listSteps.ItemsSource = steps;
		}

		private static StepItem Step(string text, string description, Tone tone, bool strong, bool skipped = false)
		{
			var filled = tone != Tone.Neutral;
			return new StepItem
			{
				Text = (tone == Tone.Success ? "✓ " : tone == Tone.Danger ? "✕ " : "") + text,
				Description = description,
				ToolTip = text + (string.IsNullOrEmpty(description) ? "" : " · " + description),
				Background = filled ? tone.ToBrush() : SystemColors.WindowBrush,
				Foreground = filled ? Brushes.White : SystemColors.GrayTextBrush,
				Weight = strong ? FontWeights.Bold : FontWeights.Normal,
				Decorations = skipped ? TextDecorations.Strikethrough : null,
			};
		}

		private void ShowFields(DealDetail detail)
		{
			var deal = detail.Deal;
			this.labelAmountValue.Text = deal.AmountText;
			this.labelCloseValue.Text = deal.IsOpen && deal.CloseTone != "Neutral"
				? deal.CloseText + "  (" + deal.CloseTag.Substring(deal.CloseTag.IndexOf('·') + 1).Trim() + ")"
				: deal.CloseText;
			this.labelCloseValue.Foreground = deal.IsOpen && deal.CloseTone != "Neutral" ? ToneExtensions.ParseTone(deal.CloseTone).ToBrush() : SystemColors.ControlTextBrush;
			this.labelProbabilityValue.Text = deal.Probability + "%";
			this.runContact.Text = string.IsNullOrEmpty(deal.ContactName) ? "None" : deal.ContactName;
			this.linkContact.IsEnabled = deal.ContactId != null;
			this.labelCreatedValue.Text = Fmt.Date(detail.CreatedAt);

			var closed = !deal.IsOpen && detail.ClosedDate != null;
			this.labelCapClosed.Visibility = this.labelClosedValue.Visibility = closed ? Visibility.Visible : Visibility.Collapsed;
			this.labelClosedValue.Text = closed ? Fmt.Date(detail.ClosedDate.Value) : "";

			this.labelCapLost.Visibility = this.labelLostValue.Visibility = deal.IsLost ? Visibility.Visible : Visibility.Collapsed;
			this.labelLostValue.Text = string.IsNullOrEmpty(detail.LostReason) ? "Not given" : detail.LostReason;
		}

		private void ShowContacts(DealDetail detail)
		{
			this.listContacts.ItemsSource = detail.Contacts;
			this.listContacts.Visibility = detail.Contacts.Count > 0 ? Visibility.Visible : Visibility.Collapsed;
			this.labelNoContacts.Visibility = detail.Contacts.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
		}

		private void ShowActivities(DealDetail detail)
		{
			var now = DateTime.Now;
			this.listActivities.ItemsSource = detail.Activities.Select(a =>
			{
				var description = a.Type + (string.IsNullOrEmpty(a.UserName) ? "" : " · " + a.UserName);
				if (!string.IsNullOrWhiteSpace(a.Body))
					description += "\n" + (a.Body.Length > 160 ? a.Body.Substring(0, 160) + "…" : a.Body);
				return new TimelineEntry(a.Date, a.Subject, description)
				{
					TitleBrush = a.Date > now ? Tone.Primary.ToBrush() : SystemColors.ControlTextBrush,
					Tag = a.Id,
				};
			}).ToList();
			this.labelNoActivity.Visibility = detail.Activities.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
			this.tabActivity.Header = detail.Activities.Count == 0 ? "Activity" : "Activity (" + detail.Activities.Count + ")";
		}

		private void ShowTasks(DealDetail detail)
		{
			this.listTasks.ItemsSource = detail.Tasks;
			this.labelNoTasks.Visibility = detail.Tasks.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
			var open = detail.Tasks.Count(t => !t.Done);
			this.tabTasks.Header = open == 0 ? "Tasks" : "Tasks (" + open + ")";
		}

		private void MarkChanged()
		{
			this.Changed = true;
			Reload();
		}

		private void buttonEdit_Click(object sender, RoutedEventArgs e)
		{
			if (DealEditDialog.Edit(this.dealId))
				MarkChanged();
		}

		private void buttonDelete_Click(object sender, RoutedEventArgs e)
		{
			if (this.detail == null)
				return;

			if (!ConfirmDialog.Ask("Delete deal", "Delete \"" + this.detail.Deal.Title + "\"? Its activities and tasks are kept.", "Delete"))
				return;

			if (Notify.Try(() => DealService.Delete(this.dealId), "Deleting the deal"))
			{
				Notify.Success("Deal deleted.");
				this.Changed = true;
				Close();
			}
		}

		private void buttonLogActivity_Click(object sender, RoutedEventArgs e)
		{
			if (this.detail == null)
				return;

			if (LogActivityDialog.Log(this.detail.Deal.ContactId, this.detail.Deal.CompanyId, this.dealId))
				MarkChanged();
		}

		private void buttonAddTask_Click(object sender, RoutedEventArgs e)
		{
			if (TaskEditDialog.Edit(null, null, null, this.dealId))
			{
				Navigator.RefreshBadges();
				MarkChanged();
			}
		}

		private void buttonClose_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void listTasks_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (UiHelper.RowItem<DealTaskItem>(e) is DealTaskItem task && TaskEditDialog.Edit(task.Id))
			{
				Navigator.RefreshBadges();
				MarkChanged();
			}
		}

		private void linkCompany_Click(object sender, RoutedEventArgs e)
		{
			var companyId = this.detail?.Deal.CompanyId;
			if (companyId == null)
				return;

			this.afterClose = () => Navigator.OpenCompany(companyId.Value);
			Close();
		}

		private void linkContact_Click(object sender, RoutedEventArgs e)
		{
			var contactId = this.detail?.Deal.ContactId;
			if (contactId == null)
				return;

			this.afterClose = () => Navigator.OpenContact(contactId.Value);
			Close();
		}

		private void listContacts_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (!(UiHelper.RowItem<DealContactItem>(e) is DealContactItem contact))
				return;

			var contactId = contact.Id;
			this.afterClose = () => Navigator.OpenContact(contactId);
			Close();
		}
	}
}
