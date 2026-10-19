using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Data;

namespace RelayCrm.Services
{
	/// <summary>The groups of the tasks list, in display order.</summary>
	public enum TaskGroup { Overdue, Today, ThisWeek, Later, Done }

	/// <summary>
	/// A task as shown in the grouped tasks list and in the Tasks tabs of the detail pages.
	/// </summary>
	public class TaskRow
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime DueDate { get; set; }
		/// <summary>"Today", "Tomorrow", "Oct 18", "3 days ago".</summary>
		public string DueText { get; set; }
		/// <summary>Tone of the due date chip: Danger when overdue, Warning today.</summary>
		public Tone DueTone { get; set; }
		public TaskPriority Priority { get; set; }
		/// <summary>"High", "Normal", "Low".</summary>
		public string PriorityText { get; set; }
		/// <summary>High = Danger, Normal = Primary, Low = Neutral.</summary>
		public Tone PriorityTone { get; set; }
		public CrmTaskStatus Status { get; set; }
		public bool Done { get; set; }
		/// <summary>"Contact · Company · Deal".</summary>
		public string RelatedText { get; set; }
		public int? ContactId { get; set; }
		public int? CompanyId { get; set; }
		public int? DealId { get; set; }
		public int? AssigneeId { get; set; }
		public string AssigneeName { get; set; }
		public string AssigneeInitials { get; set; }
		public TaskGroup Group { get; set; }
		/// <summary>"Overdue", "Today", "This week", "Later", "Done".</summary>
		public string GroupText => TaskService.GroupText(this.Group);
	}

	/// <summary>
	/// Tasks: the grouped list, completing, editing and the overdue counter of the sidebar.
	/// </summary>
	public static class TaskService
	{
		/// <summary>How many done tasks the list shows (the most recently completed).</summary>
		public const int DoneLimit = 30;

		/// <summary>Open tasks of <paramref name="userId"/> with a due date before today.</summary>
		public static int OverdueCount(int userId)
		{
			var today = DateTime.Today;
			using (var uow = Store.Open())
			{
				return uow.Tasks.Query().Count(t => t.AssigneeId == userId && t.Status == CrmTaskStatus.Open && t.DueDate < today);
			}
		}

		/// <summary>
		/// Tasks of the signed in user (<paramref name="mineOnly"/>) or of everybody, grouped and sorted:
		/// Overdue, Today, This week, Later and the most recently done.
		/// </summary>
		public static List<TaskRow> List(bool mineOnly)
		{
			int? assigneeId = mineOnly ? CurrentUser.Id : (int?)null;
			using (var uow = Store.Open())
			{
				var query = uow.Tasks.Query();
				if (assigneeId != null)
					query = query.Where(t => t.AssigneeId == assigneeId.Value);

				var open = Project(query.Where(t => t.Status == CrmTaskStatus.Open));
				var done = Project(query.Where(t => t.Status == CrmTaskStatus.Done).OrderByDescending(t => t.UpdatedAt).Take(DoneLimit));
				return Sort(open.Concat(done));
			}
		}

		/// <summary>Tasks related to a contact, a company or a deal (for the Tasks tabs), open first.</summary>
		public static List<TaskRow> ForRecord(int? contactId = null, int? companyId = null, int? dealId = null)
		{
			using (var uow = Store.Open())
			{
				var query = uow.Tasks.Query();
				if (contactId != null)
					query = query.Where(t => t.ContactId == contactId.Value);
				if (companyId != null)
					query = query.Where(t => t.CompanyId == companyId.Value);
				if (dealId != null)
					query = query.Where(t => t.DealId == dealId.Value);
				return Sort(Project(query));
			}
		}

		/// <summary>One task row, or null.</summary>
		public static TaskRow Get(int id)
		{
			using (var uow = Store.Open())
			{
				return Project(uow.Tasks.Query().Where(t => t.Id == id)).FirstOrDefault();
			}
		}

		/// <summary>The stored task for editing, or null.</summary>
		public static CrmTask Load(int id)
		{
			using (var uow = Store.Open())
			{
				return uow.Tasks.Query().FirstOrDefault(t => t.Id == id);
			}
		}

		/// <summary>Completes or reopens a task and returns its updated row.</summary>
		public static TaskRow SetDone(int id, bool done)
		{
			using (var uow = Store.Open())
			{
				var task = uow.Tasks.Query(tracking: true).FirstOrDefault(t => t.Id == id);
				if (task == null)
					return null;
				task.Status = done ? CrmTaskStatus.Done : CrmTaskStatus.Open;
				task.UpdatedAt = DateTime.Now;
				uow.Save();
			}
			return Get(id);
		}

		/// <summary>Adds (Id = 0) or updates a task; returns its id.</summary>
		public static int Save(CrmTask task)
		{
			using (var uow = Store.Open())
			{
				CrmTask target;
				if (task.Id == 0)
				{
					target = new CrmTask { CreatedAt = DateTime.Now };
					uow.Tasks.Add(target);
				}
				else
				{
					target = uow.Tasks.Query(tracking: true).First(t => t.Id == task.Id);
				}

				// a contact or a deal implies its company.
				var companyId = task.CompanyId;
				if (companyId == null && task.ContactId != null)
					companyId = uow.Contacts.Query().Where(c => c.Id == task.ContactId).Select(c => c.CompanyId).FirstOrDefault();
				if (companyId == null && task.DealId != null)
					companyId = uow.Deals.Query().Where(d => d.Id == task.DealId).Select(d => d.CompanyId).FirstOrDefault();

				target.Title = task.Title;
				target.DueDate = task.DueDate;
				target.Priority = task.Priority;
				target.Status = task.Status;
				target.AssigneeId = task.AssigneeId;
				target.ContactId = task.ContactId;
				target.CompanyId = companyId;
				target.DealId = task.DealId;
				target.UpdatedAt = DateTime.Now;
				uow.Save();
				return target.Id;
			}
		}

		/// <summary>Deletes a task.</summary>
		public static void Delete(int id)
		{
			using (var uow = Store.Open())
			{
				var task = uow.Tasks.Query(tracking: true).FirstOrDefault(t => t.Id == id);
				if (task == null)
					return;
				uow.Tasks.Remove(task);
				uow.Save();
			}
		}

		/// <summary>"Contact · Company · Deal" for the given ids ("" when none).</summary>
		public static string DescribeRelated(int? contactId, int? companyId, int? dealId)
		{
			using (var uow = Store.Open())
			{
				var contact = contactId == null ? null : uow.Contacts.Query().Where(c => c.Id == contactId.Value).Select(c => c.FirstName + " " + c.LastName).FirstOrDefault();
				var company = companyId == null ? null : uow.Companies.Query().Where(c => c.Id == companyId.Value).Select(c => c.Name).FirstOrDefault();
				var deal = dealId == null ? null : uow.Deals.Query().Where(d => d.Id == dealId.Value).Select(d => d.Title).FirstOrDefault();
				return ActivityService.Related(contact, company, deal);
			}
		}

		/// <summary>The group of a task due on <paramref name="dueDate"/>.</summary>
		public static TaskGroup GroupOf(DateTime dueDate, bool done)
		{
			if (done)
				return TaskGroup.Done;

			var today = DateTime.Today;
			var due = dueDate.Date;
			if (due < today)
				return TaskGroup.Overdue;
			if (due == today)
				return TaskGroup.Today;

			// weeks end on Sunday.
			var endOfWeek = today.AddDays((7 - (int)today.DayOfWeek) % 7);
			return due <= endOfWeek ? TaskGroup.ThisWeek : TaskGroup.Later;
		}

		/// <summary>Display name of a group.</summary>
		public static string GroupText(TaskGroup group)
		{
			return group == TaskGroup.ThisWeek ? "This week" : group.ToString();
		}

		/// <summary>Sorts rows the way the list shows them: by group, then due date (done: last completed first).</summary>
		public static List<TaskRow> Sort(IEnumerable<TaskRow> rows)
		{
			// done rows keep their incoming order (most recently completed first).
			return rows
				.Select((r, i) => new { Row = r, Index = i })
				.OrderBy(x => x.Row.Group)
				.ThenBy(x => x.Row.Group == TaskGroup.Done ? x.Index : 0)
				.ThenBy(x => x.Row.DueDate)
				.ThenByDescending(x => x.Row.Priority)
				.ThenBy(x => x.Row.Title)
				.Select(x => x.Row)
				.ToList();
		}

		/// <summary>Recomputes the group, due text and tones of a row after it was completed or reopened.</summary>
		public static void Update(TaskRow row)
		{
			row.Status = row.Done ? CrmTaskStatus.Done : CrmTaskStatus.Open;
			row.Group = GroupOf(row.DueDate, row.Done);
			row.DueText = DueText(row.DueDate, row.Group);
			row.DueTone = DueTone(row.Group);
		}

		private static List<TaskRow> Project(IQueryable<CrmTask> query)
		{
			var items = query.Select(t => new
			{
				t.Id,
				t.Title,
				t.DueDate,
				t.Priority,
				t.Status,
				t.ContactId,
				t.CompanyId,
				t.DealId,
				t.AssigneeId,
				ContactName = t.Contact != null ? t.Contact.FirstName + " " + t.Contact.LastName : null,
				CompanyName = t.Company != null ? t.Company.Name : null,
				DealTitle = t.Deal != null ? t.Deal.Title : null,
				AssigneeName = t.Assignee != null ? t.Assignee.Name : null,
			}).ToList();

			return items.Select(t =>
			{
				var row = new TaskRow
				{
					Id = t.Id,
					Title = t.Title,
					DueDate = t.DueDate,
					Priority = t.Priority,
					PriorityText = t.Priority.ToString(),
					PriorityTone = PriorityTone(t.Priority),
					Done = t.Status == CrmTaskStatus.Done,
					RelatedText = ActivityService.Related(t.ContactName, t.CompanyName, t.DealTitle),
					ContactId = t.ContactId,
					CompanyId = t.CompanyId,
					DealId = t.DealId,
					AssigneeId = t.AssigneeId,
					AssigneeName = t.AssigneeName ?? "Unassigned",
					AssigneeInitials = Text.Initials(t.AssigneeName),
				};
				Update(row);
				return row;
			}).ToList();
		}

		/// <summary>High = Danger, Normal = Primary, Low = Neutral.</summary>
		public static Tone PriorityTone(TaskPriority priority)
		{
			switch (priority)
			{
				case TaskPriority.High: return Tone.Danger;
				case TaskPriority.Normal: return Tone.Primary;
				default: return Tone.Neutral;
			}
		}

		private static Tone DueTone(TaskGroup group)
		{
			switch (group)
			{
				case TaskGroup.Overdue: return Tone.Danger;
				case TaskGroup.Today: return Tone.Warning;
				case TaskGroup.Done: return Tone.Success;
				default: return Tone.Neutral;
			}
		}

		private static string DueText(DateTime dueDate, TaskGroup group)
		{
			var days = (dueDate.Date - DateTime.Today).TotalDays;
			if (group == TaskGroup.Overdue)
				return days == -1 ? "Yesterday" : (-days) + " days late";
			if (days == 0)
				return "Today";
			if (days == 1)
				return "Tomorrow";
			return dueDate.ToString(dueDate.Year == DateTime.Today.Year ? "MMM d" : "MMM d, yyyy", Fmt.Culture);
		}
	}
}
