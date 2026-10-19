using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using RelayCrm.Data;

namespace RelayCrm.Services
{
	/// <summary>A contact as shown in the contacts list. Property names are the QueryBuilder field names.</summary>
	public class ContactRow
	{
		public int Id { get; set; }
		public string FullName { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Title { get; set; }
		public int? CompanyId { get; set; }
		public string Company { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Stage { get; set; }
		public LifecycleStage LifecycleStage { get; set; }
		public string LeadSource { get; set; }
		public string Tags { get; set; }
		public int? OwnerId { get; set; }
		public string Owner { get; set; }
		public DateTime? LastContacted { get; set; }
		public string LastContactedText { get; set; }
		public DateTime CreatedAt { get; set; }
	}

	/// <summary>Everything the contact detail page shows in its header and Overview tab.</summary>
	public class ContactDetail
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get; set; }
		public string Title { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public int? CompanyId { get; set; }
		public string CompanyName { get; set; }
		public LifecycleStage Stage { get; set; }
		public string LeadSource { get; set; }
		public string Tags { get; set; }
		public int? OwnerId { get; set; }
		public string OwnerName { get; set; }
		public DateTime? LastContacted { get; set; }
		public DateTime CreatedAt { get; set; }
	}

	/// <summary>An activity of a contact, for its timeline.</summary>
	public class ContactActivityItem
	{
		public int Id { get; set; }
		public ActivityType Type { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public DateTime Date { get; set; }
		public int Duration { get; set; }
		public string UserName { get; set; }
	}

	/// <summary>A deal of a contact, as a card.</summary>
	public class ContactDealItem
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Meta { get; set; }
		public string Icon { get; set; }
		public string StageName { get; set; }
		public Tone StageTone { get; set; }
		public Tone IconTone { get; set; }
	}

	/// <summary>A task of a contact, as a grid row.</summary>
	public class ContactTaskItem
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime DueDate { get; set; }
		public string Due { get; set; }
		public string Priority { get; set; }
		public string Status { get; set; }
		public string Assignee { get; set; }
	}

	/// <summary>
	/// Contacts: list rows, quick filters, detail, save with validation and delete.
	/// </summary>
	public static class ContactService
	{
		private static readonly Regex EmailPattern = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

		/// <summary>The quick filter a user starts with: Sales see their own contacts, Managers and Admins all.</summary>
		public static ContactQuickFilter DefaultQuickFilter => CurrentUser.SeesAll ? ContactQuickFilter.All : ContactQuickFilter.Mine;

		/// <summary>All contacts as list rows, ordered by name.</summary>
		public static List<ContactRow> Rows()
		{
			using (var uow = Store.Open())
			{
				var rows = uow.Contacts.Query()
					.Select(c => new
					{
						c.Id,
						c.FirstName,
						c.LastName,
						c.Title,
						c.CompanyId,
						CompanyName = c.Company.Name,
						c.Email,
						c.Phone,
						c.Stage,
						c.LeadSource,
						c.Tags,
						c.OwnerId,
						OwnerName = c.Owner.Name,
						c.LastContacted,
						c.CreatedAt,
					})
					.ToList();

				return rows
					.Select(c => new ContactRow
					{
						Id = c.Id,
						FirstName = c.FirstName,
						LastName = c.LastName,
						FullName = ((c.FirstName ?? "") + " " + (c.LastName ?? "")).Trim(),
						Title = c.Title,
						CompanyId = c.CompanyId,
						Company = c.CompanyName,
						Email = c.Email,
						Phone = c.Phone,
						Stage = c.Stage.ToString(),
						LifecycleStage = c.Stage,
						LeadSource = c.LeadSource,
						Tags = c.Tags,
						OwnerId = c.OwnerId,
						Owner = c.OwnerName,
						LastContacted = c.LastContacted,
						LastContactedText = Fmt.Relative(c.LastContacted),
						CreatedAt = c.CreatedAt,
					})
					.OrderBy(r => r.FullName, StringComparer.OrdinalIgnoreCase)
					.ToList();
			}
		}

		/// <summary>True when <paramref name="row"/> belongs to <paramref name="filter"/>.</summary>
		public static bool InQuickFilter(ContactRow row, ContactQuickFilter filter)
		{
			switch (filter)
			{
				case ContactQuickFilter.Leads: return row.LifecycleStage == LifecycleStage.Lead;
				case ContactQuickFilter.Prospects: return row.LifecycleStage == LifecycleStage.Prospect;
				case ContactQuickFilter.Customers: return row.LifecycleStage == LifecycleStage.Customer;
				case ContactQuickFilter.Mine: return row.OwnerId == CurrentUser.Id;
				default: return true;
			}
		}

		/// <summary>True when the search text is found in the name, title, company, email, phone or tags.</summary>
		public static bool MatchesSearch(ContactRow row, string search)
		{
			if (string.IsNullOrWhiteSpace(search))
				return true;
			search = search.Trim();
			return Text.Has(row.FullName, search)
				|| Text.Has(row.Title, search)
				|| Text.Has(row.Company, search)
				|| Text.Has(row.Email, search)
				|| Text.Has(row.Phone, search)
				|| Text.Has(row.Tags, search);
		}

		/// <summary>Number of rows in each quick filter.</summary>
		public static Dictionary<ContactQuickFilter, int> QuickFilterCounts(IEnumerable<ContactRow> rows)
		{
			var list = rows.ToList();
			return Enum.GetValues(typeof(ContactQuickFilter))
				.Cast<ContactQuickFilter>()
				.ToDictionary(f => f, f => list.Count(r => InQuickFilter(r, f)));
		}

		/// <summary>The detail of one contact, or null when it does not exist.</summary>
		public static ContactDetail Detail(int contactId)
		{
			using (var uow = Store.Open())
			{
				var c = uow.Contacts.Query()
					.Where(x => x.Id == contactId)
					.Select(x => new ContactDetail
					{
						Id = x.Id,
						FirstName = x.FirstName,
						LastName = x.LastName,
						Title = x.Title,
						Email = x.Email,
						Phone = x.Phone,
						CompanyId = x.CompanyId,
						CompanyName = x.Company.Name,
						Stage = x.Stage,
						LeadSource = x.LeadSource,
						Tags = x.Tags,
						OwnerId = x.OwnerId,
						OwnerName = x.Owner.Name,
						LastContacted = x.LastContacted,
						CreatedAt = x.CreatedAt,
					})
					.FirstOrDefault();

				if (c != null)
					c.FullName = ((c.FirstName ?? "") + " " + (c.LastName ?? "")).Trim();
				return c;
			}
		}

		/// <summary>A contact to edit (not tracked), or null.</summary>
		public static Contact Get(int contactId)
		{
			using (var uow = Store.Open())
			{
				return uow.Contacts.Query().FirstOrDefault(c => c.Id == contactId);
			}
		}

		/// <summary>True when a first or last name is given.</summary>
		public static bool HasName(string firstName, string lastName)
		{
			return !string.IsNullOrWhiteSpace(firstName) || !string.IsNullOrWhiteSpace(lastName);
		}

		/// <summary>True when <paramref name="email"/> is empty or looks like an email address.</summary>
		public static bool IsValidEmail(string email)
		{
			return string.IsNullOrWhiteSpace(email) || EmailPattern.IsMatch(email.Trim());
		}

		/// <summary>True when another contact (not <paramref name="excludeId"/>) already uses <paramref name="email"/>.</summary>
		public static bool EmailExists(string email, int? excludeId)
		{
			return EmailUsedBy(email, excludeId) != null;
		}

		/// <summary>The name of another contact that uses <paramref name="email"/>, or null.</summary>
		public static string EmailUsedBy(string email, int? excludeId)
		{
			if (string.IsNullOrWhiteSpace(email))
				return null;
			var value = email.Trim().ToLowerInvariant();
			using (var uow = Store.Open())
			{
				return uow.Contacts.Query()
					.Where(c => c.Email != null && c.Email.ToLower() == value && (excludeId == null || c.Id != excludeId))
					.Select(c => c.FirstName + " " + c.LastName)
					.FirstOrDefault();
			}
		}

		/// <summary>Adds (Id 0) or updates a contact; returns its id.</summary>
		public static int Save(Contact contact)
		{
			if (!HasName(contact.FirstName, contact.LastName))
				throw new InvalidOperationException("A contact needs a first or last name.");
			if (!IsValidEmail(contact.Email))
				throw new InvalidOperationException("The email address is not valid.");

			using (var uow = Store.Open())
			{
				Contact target;
				if (contact.Id == 0)
				{
					target = new Contact();
					uow.Contacts.Add(target);
				}
				else
				{
					target = uow.Contacts.Query(tracking: true).First(c => c.Id == contact.Id);
				}

				target.FirstName = Clean(contact.FirstName);
				target.LastName = Clean(contact.LastName);
				target.Title = Clean(contact.Title);
				target.Email = Clean(contact.Email);
				target.Phone = Clean(contact.Phone);
				target.CompanyId = contact.CompanyId;
				target.Stage = contact.Stage;
				target.LeadSource = Clean(contact.LeadSource);
				target.Tags = string.Join(", ", Text.Tags(contact.Tags));
				target.OwnerId = contact.OwnerId;

				uow.Save();
				return target.Id;
			}
		}

		/// <summary>Deletes a contact; its activities, tasks and deals stay, without the contact.</summary>
		public static void Delete(int contactId)
		{
			using (var uow = Store.Open())
			{
				foreach (var a in uow.Activities.Query(tracking: true).Where(a => a.ContactId == contactId).ToList())
					a.ContactId = null;
				foreach (var t in uow.Tasks.Query(tracking: true).Where(t => t.ContactId == contactId).ToList())
					t.ContactId = null;
				foreach (var d in uow.Deals.Query(tracking: true).Where(d => d.PrimaryContactId == contactId).ToList())
					d.PrimaryContactId = null;

				var contact = uow.Contacts.Query(tracking: true).FirstOrDefault(c => c.Id == contactId);
				if (contact != null)
					uow.Contacts.Remove(contact);
				uow.Save();
			}
		}

		/// <summary>The activities of a contact, newest first.</summary>
		public static List<ContactActivityItem> Activities(int contactId)
		{
			using (var uow = Store.Open())
			{
				return uow.Activities.Query()
					.Where(a => a.ContactId == contactId)
					.OrderByDescending(a => a.Date)
					.Select(a => new ContactActivityItem
					{
						Id = a.Id,
						Type = a.Type,
						Subject = a.Subject,
						Body = a.Body,
						Date = a.Date,
						Duration = a.Duration,
						UserName = a.User.Name,
					})
					.ToList();
			}
		}

		/// <summary>The deals whose primary contact is the contact, newest close date first.</summary>
		public static List<ContactDealItem> Deals(int contactId)
		{
			using (var uow = Store.Open())
			{
				var deals = uow.Deals.Query()
					.Where(d => d.PrimaryContactId == contactId)
					.OrderByDescending(d => d.ExpectedCloseDate)
					.Select(d => new
					{
						d.Id,
						d.Title,
						d.Amount,
						d.ExpectedCloseDate,
						d.ClosedDate,
						StageName = d.Stage.Name,
						d.Stage.IsWon,
						d.Stage.IsLost,
						CompanyName = d.Company.Name,
					})
					.ToList();

				return deals.Select(d => new ContactDealItem
				{
					Id = d.Id,
					Title = d.Title,
					Description = Fmt.Money(d.Amount) + (string.IsNullOrEmpty(d.CompanyName) ? "" : " · " + d.CompanyName),
					Meta = (d.IsWon || d.IsLost) && d.ClosedDate != null
						? "Closed " + Fmt.Date(d.ClosedDate.Value)
						: "Expected close " + Fmt.Date(d.ExpectedCloseDate),
					Icon = Icons.Get("briefcase"),
					StageName = d.StageName,
					StageTone = d.IsWon ? Tone.Success : d.IsLost ? Tone.Danger : Tone.Primary,
					IconTone = Tone.Primary,
				}).ToList();
			}
		}

		/// <summary>The tasks of a contact: open ones first, by due date.</summary>
		public static List<ContactTaskItem> Tasks(int contactId)
		{
			using (var uow = Store.Open())
			{
				var tasks = uow.Tasks.Query()
					.Where(t => t.ContactId == contactId)
					.Select(t => new { t.Id, t.Title, t.DueDate, t.Priority, t.Status, AssigneeName = t.Assignee.Name })
					.ToList();

				return tasks
					.OrderBy(t => t.Status)
					.ThenBy(t => t.DueDate)
					.Select(t => new ContactTaskItem
					{
						Id = t.Id,
						Title = t.Title,
						DueDate = t.DueDate,
						Due = Fmt.Date(t.DueDate) + " (" + Fmt.Relative(t.DueDate) + ")",
						Priority = t.Priority.ToString(),
						Status = t.Status == CrmTaskStatus.Done
							? "Done"
							: t.DueDate.Date < DateTime.Today ? "Overdue" : "Open",
						Assignee = t.AssigneeName,
					})
					.ToList();
			}
		}

		private static string Clean(string value)
		{
			return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
		}
	}
}
