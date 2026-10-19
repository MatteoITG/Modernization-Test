using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Data;

namespace RelayCrm.Services
{
	/// <summary>A deal as shown on the board and in the list.</summary>
	public class DealRow
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public int? CompanyId { get; set; }
		public string CompanyName { get; set; }
		public int? ContactId { get; set; }
		public string ContactName { get; set; }
		public decimal Amount { get; set; }
		public string AmountText { get; set; }
		public int StageId { get; set; }
		/// <summary>Stage id as text: the KanbanBoard status (matches KanbanColumn.Value).</summary>
		public string Status { get; set; }
		public string StageName { get; set; }
		public bool IsWon { get; set; }
		public bool IsLost { get; set; }
		public bool IsOpen => !this.IsWon && !this.IsLost;
		public int BoardOrder { get; set; }
		public int? OwnerId { get; set; }
		public string OwnerName { get; set; }
		public string OwnerInitials { get; set; }
		public DateTime ExpectedCloseDate { get; set; }
		public string CloseText { get; set; }
		/// <summary>Card tag: "Due in 3 days", "Overdue", "Closes Oct 20", "Won Oct 1"...</summary>
		public string CloseTag { get; set; }
		/// <summary>MeterTone name of the tag: Warning (within 7 days), Danger (overdue), Success (won), Neutral.</summary>
		public string CloseTone { get; set; }
		public int Probability { get; set; }
		/// <summary>"25%": the text of the list's probability meter.</summary>
		public string ProbabilityText => Probability + "%";
		/// <summary>Card meta line: "Bluepeak Labs · $24,000".</summary>
		public string Meta { get; set; }
	}

	/// <summary>Count and total amount of the deals in one stage.</summary>
	public class DealStageTotal
	{
		public int StageId { get; set; }
		public int Count { get; set; }
		public decimal Total { get; set; }
	}

	/// <summary>A contact related to a deal.</summary>
	public class DealContactItem
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Title { get; set; }
	}

	/// <summary>An activity of a deal, for the timeline.</summary>
	public class DealActivityItem
	{
		public int Id { get; set; }
		public ActivityType Type { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public DateTime Date { get; set; }
		public string UserName { get; set; }
	}

	/// <summary>A task of a deal.</summary>
	public class DealTaskItem
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime DueDate { get; set; }
		public string DueText { get; set; }
		public TaskPriority Priority { get; set; }
		public CrmTaskStatus Status { get; set; }
		public string AssigneeName { get; set; }
		public bool Done => this.Status == CrmTaskStatus.Done;
		public bool Overdue => !this.Done && this.DueDate.Date < DateTime.Today;
		public string Icon => this.Done
			? Icons.Get("check2-square")
			: Icons.Get("square");
	}

	/// <summary>Everything the deal detail dialog shows.</summary>
	public class DealDetail
	{
		public DealRow Deal { get; set; }
		public string LostReason { get; set; }
		public DateTime? ClosedDate { get; set; }
		public DateTime CreatedAt { get; set; }
		public List<StageItem> Stages { get; set; }
		public List<DealContactItem> Contacts { get; set; }
		public List<DealActivityItem> Activities { get; set; }
		public List<DealTaskItem> Tasks { get; set; }
	}

	/// <summary>The editable fields of a deal.</summary>
	public class DealInput
	{
		public int? Id { get; set; }
		public string Title { get; set; }
		public int? CompanyId { get; set; }
		public int? PrimaryContactId { get; set; }
		public decimal Amount { get; set; }
		public int StageId { get; set; }
		public DateTime ExpectedCloseDate { get; set; }
		public int? OwnerId { get; set; }
		public string LostReason { get; set; }
	}

	/// <summary>
	/// Deals pipeline: board and list rows, stage moves, detail, save and delete.
	/// </summary>
	public static class DealService
	{
		/// <summary>The filter a user starts with: Sales see their own deals, Managers and Admins all deals.</summary>
		public static DealFilter DefaultFilter()
		{
			return new DealFilter { OwnerId = CurrentUser.SeesAll || !CurrentUser.IsSignedIn ? (int?)null : CurrentUser.Id };
		}

		/// <summary>The deals matching <paramref name="filter"/>, by stage and board order.</summary>
		public static List<DealRow> Deals(DealFilter filter)
		{
			filter = filter ?? new DealFilter();
			using (var uow = Store.Open())
			{
				var query = uow.Deals.Query();
				if (filter.OwnerId != null)
					query = query.Where(d => d.OwnerId == filter.OwnerId);
				if (filter.StageId != null)
					query = query.Where(d => d.StageId == filter.StageId);
				if (filter.OpenOnly)
					query = query.Where(d => !d.Stage.IsWon && !d.Stage.IsLost);
				if (filter.WonOnly)
					query = query.Where(d => d.Stage.IsWon);

				var rows = Project(query).ToList();

				// dates and money are filtered in memory: amounts are stored as double.
				IEnumerable<DealRow> result = rows;
				if (filter.CloseFrom != null)
					result = result.Where(r => r.ExpectedCloseDate.Date >= filter.CloseFrom.Value.Date);
				if (filter.CloseTo != null)
					result = result.Where(r => r.ExpectedCloseDate.Date <= filter.CloseTo.Value.Date);
				if (filter.AmountMin != null)
					result = result.Where(r => r.Amount >= filter.AmountMin.Value);
				if (filter.AmountMax != null)
					result = result.Where(r => r.Amount <= filter.AmountMax.Value);
				if (!string.IsNullOrWhiteSpace(filter.Search))
					result = result.Where(r => Text.Has(r.Title, filter.Search) || Text.Has(r.CompanyName, filter.Search) || Text.Has(r.ContactName, filter.Search));

				return result.Select(Complete).OrderBy(r => r.StageId).ThenBy(r => r.BoardOrder).ThenBy(r => r.Id).ToList();
			}
		}

		/// <summary>Count and total amount per stage of <paramref name="rows"/>.</summary>
		public static Dictionary<int, DealStageTotal> Totals(IEnumerable<DealRow> rows)
		{
			return rows.GroupBy(r => r.StageId).ToDictionary(g => g.Key, g => new DealStageTotal { StageId = g.Key, Count = g.Count(), Total = g.Sum(r => r.Amount) });
		}

		/// <summary>
		/// Moves a deal to a stage at a position of its column: sets the stage probability, the closed date when it is
		/// won or lost (cleared when it goes back to an open stage), the lost reason, and persists the board order.
		/// </summary>
		/// <param name="dealId">The deal.</param>
		/// <param name="stageId">The destination stage.</param>
		/// <param name="index">Position in the destination column; -1 appends.</param>
		/// <param name="lostReason">Reason when the destination is a lost stage.</param>
		/// <param name="beforeDealId">The card that follows the deal on a filtered board: the deal is placed before it
		/// (takes precedence over <paramref name="index"/>, which counts the visible cards only).</param>
		public static void MoveToStage(int dealId, int stageId, int index, string lostReason = null, int? beforeDealId = null)
		{
			using (var uow = Store.Open())
			{
				var deal = uow.Deals.Query(tracking: true).First(d => d.Id == dealId);
				var stage = uow.Stages.Query().First(s => s.Id == stageId);

				if (deal.StageId != stageId)
				{
					deal.StageId = stageId;
					ApplyStage(deal, stage, lostReason);
				}

				// renumber the destination column with the deal at its new position.
				var column = uow.Deals.Query(tracking: true)
					.Where(d => d.StageId == stageId && d.Id != dealId)
					.OrderBy(d => d.BoardOrder).ThenBy(d => d.Id)
					.ToList();
				if (beforeDealId != null)
				{
					var before = column.FindIndex(d => d.Id == beforeDealId);
					index = before >= 0 ? before : column.Count;
				}
				if (index < 0 || index > column.Count)
					index = column.Count;
				column.Insert(index, deal);
				for (var i = 0; i < column.Count; i++)
				{
					if (column[i].BoardOrder != i)
						column[i].BoardOrder = i;
				}

				uow.Save();
			}
		}

		/// <summary>The deal with its stages, related contacts, activities (newest first) and tasks; null when it does not exist.</summary>
		public static DealDetail Detail(int dealId)
		{
			using (var uow = Store.Open())
			{
				var row = Project(uow.Deals.Query().Where(d => d.Id == dealId)).FirstOrDefault();
				if (row == null)
					return null;

				var extra = uow.Deals.Query().Where(d => d.Id == dealId)
					.Select(d => new { d.LostReason, d.ClosedDate, d.CreatedAt })
					.First();

				var contacts = row.CompanyId == null
					? new List<DealContactItem>()
					: uow.Contacts.Query()
						.Where(c => c.CompanyId == row.CompanyId)
						.OrderBy(c => c.FirstName).ThenBy(c => c.LastName)
						.Select(c => new DealContactItem { Id = c.Id, Name = c.FirstName + " " + c.LastName, Title = c.Title })
						.ToList();

				// the primary contact first.
				if (row.ContactId != null)
				{
					var primary = contacts.FirstOrDefault(c => c.Id == row.ContactId);
					if (primary != null)
					{
						contacts.Remove(primary);
						contacts.Insert(0, primary);
					}
					else
					{
						contacts.Insert(0, uow.Contacts.Query().Where(c => c.Id == row.ContactId)
							.Select(c => new DealContactItem { Id = c.Id, Name = c.FirstName + " " + c.LastName, Title = c.Title })
							.First());
					}
				}

				var activities = uow.Activities.Query()
					.Where(a => a.DealId == dealId)
					.OrderByDescending(a => a.Date)
					.Select(a => new DealActivityItem { Id = a.Id, Type = a.Type, Subject = a.Subject, Body = a.Body, Date = a.Date, UserName = a.User.Name })
					.ToList();

				var tasks = uow.Tasks.Query()
					.Where(t => t.DealId == dealId)
					.OrderBy(t => t.Status).ThenBy(t => t.DueDate)
					.Select(t => new DealTaskItem { Id = t.Id, Title = t.Title, DueDate = t.DueDate, Priority = t.Priority, Status = t.Status, AssigneeName = t.Assignee.Name })
					.ToList();
				foreach (var t in tasks)
					t.DueText = t.Done ? "Done" : t.Overdue ? "Overdue · " + Fmt.Date(t.DueDate) : "Due " + Fmt.Date(t.DueDate);

				return new DealDetail
				{
					Deal = Complete(row),
					LostReason = extra.LostReason,
					ClosedDate = extra.ClosedDate,
					CreatedAt = extra.CreatedAt,
					Stages = LookupService.Stages(),
					Contacts = contacts,
					Activities = activities,
					Tasks = tasks,
				};
			}
		}

		/// <summary>The editable fields of a deal, or null.</summary>
		public static DealInput Get(int dealId)
		{
			using (var uow = Store.Open())
			{
				return uow.Deals.Query().Where(d => d.Id == dealId)
					.Select(d => new DealInput
					{
						Id = d.Id,
						Title = d.Title,
						CompanyId = d.CompanyId,
						PrimaryContactId = d.PrimaryContactId,
						Amount = d.Amount,
						StageId = d.StageId,
						ExpectedCloseDate = d.ExpectedCloseDate,
						OwnerId = d.OwnerId,
						LostReason = d.LostReason,
					})
					.FirstOrDefault();
			}
		}

		/// <summary>Creates or updates a deal; returns its id.</summary>
		public static int Save(DealInput input)
		{
			using (var uow = Store.Open())
			{
				var stage = uow.Stages.Query().First(s => s.Id == input.StageId);
				Deal deal;
				if (input.Id == null)
				{
					deal = new Deal { Currency = "USD" };
					deal.BoardOrder = uow.Deals.Query().Where(d => d.StageId == input.StageId).Select(d => (int?)d.BoardOrder).Max() + 1 ?? 0;
					deal.StageId = input.StageId;
					ApplyStage(deal, stage, input.LostReason);
					uow.Deals.Add(deal);
				}
				else
				{
					deal = uow.Deals.Query(tracking: true).First(d => d.Id == input.Id);
					if (deal.StageId != input.StageId)
					{
						deal.StageId = input.StageId;
						deal.BoardOrder = uow.Deals.Query().Where(d => d.StageId == input.StageId).Select(d => (int?)d.BoardOrder).Max() + 1 ?? 0;
						ApplyStage(deal, stage, input.LostReason);
					}
					else if (stage.IsLost && !string.IsNullOrWhiteSpace(input.LostReason))
					{
						deal.LostReason = input.LostReason;
					}
				}

				deal.Title = input.Title;
				deal.CompanyId = input.CompanyId;
				deal.PrimaryContactId = input.PrimaryContactId;
				deal.Amount = input.Amount;
				deal.ExpectedCloseDate = input.ExpectedCloseDate.Date;
				deal.OwnerId = input.OwnerId;

				uow.Save();
				return deal.Id;
			}
		}

		/// <summary>Deletes a deal; its activities and tasks are kept without the deal.</summary>
		public static void Delete(int dealId)
		{
			using (var uow = Store.Open())
			{
				foreach (var a in uow.Activities.Query(tracking: true).Where(a => a.DealId == dealId).ToList())
					a.DealId = null;
				foreach (var t in uow.Tasks.Query(tracking: true).Where(t => t.DealId == dealId).ToList())
					t.DealId = null;

				var deal = uow.Deals.Query(tracking: true).FirstOrDefault(d => d.Id == dealId);
				if (deal != null)
					uow.Deals.Remove(deal);
				uow.Save();
			}
		}

		/// <summary>The company of a contact, or null.</summary>
		public static int? CompanyOfContact(int contactId)
		{
			using (var uow = Store.Open())
			{
				return uow.Contacts.Query().Where(c => c.Id == contactId).Select(c => c.CompanyId).FirstOrDefault();
			}
		}

		/// <summary>Close date tag of a deal: amber within 7 days, red when past and still open.</summary>
		public static void CloseTag(DealRow row, out string tag, out string tone)
		{
			var days = (row.ExpectedCloseDate.Date - DateTime.Today).Days;
			var date = row.ExpectedCloseDate.ToString("MMM d", Fmt.Culture);
			if (row.IsWon)
			{
				tag = "Won";
				tone = "Success";
			}
			else if (row.IsLost)
			{
				tag = "Lost";
				tone = "Neutral";
			}
			else if (days < 0)
			{
				tag = date + " · Overdue";
				tone = "Danger";
			}
			else if (days == 0)
			{
				tag = date + " · Due today";
				tone = "Warning";
			}
			else if (days <= 7)
			{
				tag = date + (days == 1 ? " · Due tomorrow" : " · Due in " + days + " days");
				tone = "Warning";
			}
			else
			{
				tag = "Closes " + date;
				tone = "Neutral";
			}
		}

		private static void ApplyStage(Deal deal, Stage stage, string lostReason)
		{
			deal.Probability = stage.Probability;
			if (stage.IsWon || stage.IsLost)
			{
				if (deal.ClosedDate == null)
					deal.ClosedDate = DateTime.Now;
			}
			else
			{
				deal.ClosedDate = null;
			}
			deal.LostReason = stage.IsLost ? lostReason : null;
		}

		private static IQueryable<DealRow> Project(IQueryable<Deal> query)
		{
			return query.Select(d => new DealRow
			{
				Id = d.Id,
				Title = d.Title,
				CompanyId = d.CompanyId,
				CompanyName = d.Company.Name,
				ContactId = d.PrimaryContactId,
				ContactName = d.PrimaryContact.FirstName + " " + d.PrimaryContact.LastName,
				Amount = d.Amount,
				StageId = d.StageId,
				StageName = d.Stage.Name,
				IsWon = d.Stage.IsWon,
				IsLost = d.Stage.IsLost,
				BoardOrder = d.BoardOrder,
				OwnerId = d.OwnerId,
				OwnerName = d.Owner.Name,
				ExpectedCloseDate = d.ExpectedCloseDate,
				Probability = d.Probability,
			});
		}

		/// <summary>Fills the display texts of a row read from the store.</summary>
		private static DealRow Complete(DealRow row)
		{
			if (row.ContactId == null)
				row.ContactName = null;
			row.Status = row.StageId.ToString(System.Globalization.CultureInfo.InvariantCulture);
			row.AmountText = Fmt.Money(row.Amount);
			row.OwnerName = row.OwnerName ?? "Unassigned";
			row.OwnerInitials = Text.Initials(row.OwnerName);
			row.CloseText = Fmt.Date(row.ExpectedCloseDate);
			row.Meta = string.IsNullOrEmpty(row.CompanyName) ? row.AmountText : row.CompanyName + " · " + row.AmountText;
			CloseTag(row, out var tag, out var tone);
			row.CloseTag = tag;
			row.CloseTone = tone;
			return row;
		}
	}
}
