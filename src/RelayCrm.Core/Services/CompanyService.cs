using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Data;

namespace RelayCrm.Services
{
	/// <summary>Quick filters of the companies list.</summary>
	public enum CompanyQuickFilter { All, Mine, OpenDeals, Customers }

	/// <summary>A company as shown in the companies list. Property names are the QueryBuilder field names.</summary>
	public class CompanyRow
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Industry { get; set; }
		public string Size { get; set; }
		public string Country { get; set; }
		public string City { get; set; }
		public int? OwnerId { get; set; }
		public string OwnerName { get; set; }
		public int Contacts { get; set; }
		public int OpenDeals { get; set; }
		public decimal OpenValue { get; set; }
		public decimal WonRevenue { get; set; }
		/// <summary>Won revenue of each of the last 12 months, oldest first.</summary>
		public double[] WonTrend { get; set; }
		public decimal AnnualRevenue { get; set; }
		public string Tags { get; set; }
		/// <summary>The first tag, shown as a chip.</summary>
		public string FirstTag { get; set; }
		public DateTime CreatedAt { get; set; }
	}

	/// <summary>A company with the figures of its detail page.</summary>
	public class CompanyDetail
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Industry { get; set; }
		public string Size { get; set; }
		public string Website { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public decimal AnnualRevenue { get; set; }
		public string Tags { get; set; }
		public int? OwnerId { get; set; }
		public string OwnerName { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

		// KPIs
		public decimal OpenPipeline { get; set; }
		public int OpenDeals { get; set; }
		public decimal WonThisYear { get; set; }
		public int WonThisYearCount { get; set; }
		/// <summary>Won revenue of each of the last 12 months, oldest first.</summary>
		public double[] WonTrend { get; set; }
		public int ContactCount { get; set; }
		public DateTime? LastActivity { get; set; }
	}

	/// <summary>A contact of a company.</summary>
	public class CompanyContactRow
	{
		public int Id { get; set; }
		public string FullName { get; set; }
		public string Title { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Stage { get; set; }
		public string LastContacted { get; set; }
	}

	/// <summary>A deal of a company.</summary>
	public class CompanyDealRow
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Stage { get; set; }
		public decimal Amount { get; set; }
		public DateTime CloseDate { get; set; }
		public int Probability { get; set; }
		public string OwnerName { get; set; }
	}

	/// <summary>An activity of a company.</summary>
	public class CompanyActivityRow
	{
		public int Id { get; set; }
		public ActivityType Type { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public DateTime Date { get; set; }
		public string ContactName { get; set; }
		public string UserName { get; set; }
	}

	/// <summary>A task of a company.</summary>
	public class CompanyTaskRow
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime DueDate { get; set; }
		public string Priority { get; set; }
		/// <summary>Done, Overdue, Due soon or Open.</summary>
		public string Status { get; set; }
		public string AssigneeName { get; set; }
	}

	/// <summary>
	/// Companies: list, detail, related records, save and delete.
	/// </summary>
	public static class CompanyService
	{
		/// <summary>
		/// All companies with their figures. Filtering (search, quick filters, advanced filter) is done by the view.
		/// </summary>
		public static List<CompanyRow> List()
		{
			using (var uow = Store.Open())
			{
				var companies = uow.Companies.Query()
					.OrderBy(c => c.Name)
					.Select(c => new
					{
						c.Id, c.Name, c.Industry, c.Size, c.Country, c.City, c.OwnerId,
						OwnerName = c.Owner.Name, c.AnnualRevenue, c.Tags, c.CreatedAt,
					})
					.ToList();

				var contactCompanies = uow.Contacts.Query()
					.Where(c => c.CompanyId != null)
					.Select(c => c.CompanyId.Value)
					.ToList();
				var contacts = contactCompanies.GroupBy(id => id).ToDictionary(g => g.Key, g => g.Count());

				var deals = LoadDeals(uow, null);
				var start = FirstMonth();

				return companies.Select(c =>
				{
					var own = deals.Where(d => d.CompanyId == c.Id).ToList();
					var tags = Text.Tags(c.Tags);
					return new CompanyRow
					{
						Id = c.Id,
						Name = c.Name,
						Industry = c.Industry,
						Size = c.Size,
						Country = c.Country,
						City = c.City,
						OwnerId = c.OwnerId,
						OwnerName = c.OwnerName ?? "",
						Contacts = contacts.TryGetValue(c.Id, out var n) ? n : 0,
						OpenDeals = own.Count(d => d.IsOpen),
						OpenValue = own.Where(d => d.IsOpen).Sum(d => d.Amount),
						WonRevenue = own.Where(d => d.IsWon).Sum(d => d.Amount),
						WonTrend = Trend(own, start),
						AnnualRevenue = c.AnnualRevenue,
						Tags = string.Join(", ", tags),
						// null, not "": the chip column draws no empty chip.
						FirstTag = tags.FirstOrDefault(),
						CreatedAt = c.CreatedAt,
					};
				}).ToList();
			}
		}

		/// <summary>Rows matching a quick filter.</summary>
		public static IEnumerable<CompanyRow> Apply(IEnumerable<CompanyRow> rows, CompanyQuickFilter filter, int userId)
		{
			switch (filter)
			{
				case CompanyQuickFilter.Mine: return rows.Where(r => r.OwnerId == userId);
				case CompanyQuickFilter.OpenDeals: return rows.Where(r => r.OpenDeals > 0);
				case CompanyQuickFilter.Customers: return rows.Where(r => r.WonRevenue > 0);
				default: return rows;
			}
		}

		/// <summary>The quick filter selected when the list opens: Sales see their own companies.</summary>
		public static CompanyQuickFilter DefaultQuickFilter => CurrentUser.SeesAll ? CompanyQuickFilter.All : CompanyQuickFilter.Mine;

		/// <summary>A company with its KPIs, or null when it does not exist.</summary>
		public static CompanyDetail Detail(int companyId)
		{
			using (var uow = Store.Open())
			{
				var c = uow.Companies.Query()
					.Where(x => x.Id == companyId)
					.Select(x => new CompanyDetail
					{
						Id = x.Id, Name = x.Name, Industry = x.Industry, Size = x.Size, Website = x.Website,
						Phone = x.Phone, Address = x.Address, City = x.City, Country = x.Country,
						AnnualRevenue = x.AnnualRevenue, Tags = x.Tags, OwnerId = x.OwnerId, OwnerName = x.Owner.Name,
						CreatedAt = x.CreatedAt, UpdatedAt = x.UpdatedAt,
					})
					.FirstOrDefault();
				if (c == null)
					return null;

				var deals = LoadDeals(uow, companyId);
				var yearStart = new DateTime(DateTime.Today.Year, 1, 1);
				var wonThisYear = deals.Where(d => d.IsWon && d.Closed >= yearStart).ToList();

				c.OpenPipeline = deals.Where(d => d.IsOpen).Sum(d => d.Amount);
				c.OpenDeals = deals.Count(d => d.IsOpen);
				c.WonThisYear = wonThisYear.Sum(d => d.Amount);
				c.WonThisYearCount = wonThisYear.Count;
				c.WonTrend = Trend(deals, FirstMonth());
				c.ContactCount = uow.Contacts.Query().Count(x => x.CompanyId == companyId);

				var now = DateTime.Now;
				c.LastActivity = uow.Activities.Query()
					.Where(a => a.CompanyId == companyId && a.Date <= now)
					.OrderByDescending(a => a.Date)
					.Select(a => (DateTime?)a.Date)
					.FirstOrDefault();
				return c;
			}
		}

		/// <summary>The contacts of a company.</summary>
		public static List<CompanyContactRow> Contacts(int companyId)
		{
			using (var uow = Store.Open())
			{
				return uow.Contacts.Query()
					.Where(c => c.CompanyId == companyId)
					.OrderBy(c => c.FirstName).ThenBy(c => c.LastName)
					.Select(c => new { c.Id, c.FirstName, c.LastName, c.Title, c.Email, c.Phone, c.Stage, c.LastContacted })
					.ToList()
					.Select(c => new CompanyContactRow
					{
						Id = c.Id,
						FullName = (c.FirstName + " " + c.LastName).Trim(),
						Title = c.Title,
						Email = c.Email,
						Phone = c.Phone,
						Stage = c.Stage.ToString(),
						LastContacted = Fmt.Relative(c.LastContacted),
					})
					.ToList();
			}
		}

		/// <summary>The deals of a company, the latest close date first.</summary>
		public static List<CompanyDealRow> Deals(int companyId)
		{
			using (var uow = Store.Open())
			{
				return uow.Deals.Query()
					.Where(d => d.CompanyId == companyId)
					.OrderByDescending(d => d.ExpectedCloseDate)
					.Select(d => new CompanyDealRow
					{
						Id = d.Id,
						Title = d.Title,
						Stage = d.Stage.Name,
						Amount = d.Amount,
						CloseDate = d.ClosedDate ?? d.ExpectedCloseDate,
						Probability = d.Probability,
						OwnerName = d.Owner.Name,
					})
					.ToList();
			}
		}

		/// <summary>The activities of a company, newest first.</summary>
		public static List<CompanyActivityRow> Activities(int companyId)
		{
			using (var uow = Store.Open())
			{
				return uow.Activities.Query()
					.Where(a => a.CompanyId == companyId)
					.OrderByDescending(a => a.Date)
					.Select(a => new
					{
						a.Id, a.Type, a.Subject, a.Body, a.Date,
						ContactFirst = a.Contact.FirstName, ContactLast = a.Contact.LastName, UserName = a.User.Name,
					})
					.ToList()
					.Select(a => new CompanyActivityRow
					{
						Id = a.Id,
						Type = a.Type,
						Subject = a.Subject,
						Body = a.Body,
						Date = a.Date,
						ContactName = (a.ContactFirst + " " + a.ContactLast).Trim(),
						UserName = a.UserName,
					})
					.ToList();
			}
		}

		/// <summary>The tasks of a company: open ones first, by due date.</summary>
		public static List<CompanyTaskRow> Tasks(int companyId)
		{
			using (var uow = Store.Open())
			{
				var today = DateTime.Today;
				return uow.Tasks.Query()
					.Where(t => t.CompanyId == companyId)
					.Select(t => new { t.Id, t.Title, t.DueDate, t.Priority, t.Status, AssigneeName = t.Assignee.Name })
					.ToList()
					.OrderBy(t => t.Status).ThenBy(t => t.DueDate)
					.Select(t => new CompanyTaskRow
					{
						Id = t.Id,
						Title = t.Title,
						DueDate = t.DueDate,
						Priority = t.Priority.ToString(),
						Status = t.Status == CrmTaskStatus.Done ? "Done"
							: t.DueDate.Date < today ? "Overdue"
							: t.DueDate.Date <= today.AddDays(2) ? "Due soon"
							: "Open",
						AssigneeName = t.AssigneeName,
					})
					.ToList();
			}
		}

		/// <summary>The stored company, for editing; null when it does not exist.</summary>
		public static Company Get(int companyId)
		{
			using (var uow = Store.Open())
			{
				return uow.Companies.Query().FirstOrDefault(c => c.Id == companyId);
			}
		}

		/// <summary>True when another company already has this name (ignoring case).</summary>
		public static bool NameExists(string name, int? exceptId)
		{
			if (string.IsNullOrWhiteSpace(name))
				return false;

			var lower = name.Trim().ToLower();
			using (var uow = Store.Open())
			{
				return uow.Companies.Query().Any(c => c.Name.ToLower() == lower && c.Id != (exceptId ?? 0));
			}
		}

		/// <summary>Adds (Id = 0) or updates a company; returns its id.</summary>
		public static int Save(Company values)
		{
			using (var uow = Store.Open())
			{
				Company company;
				if (values.Id == 0)
				{
					company = new Company();
					uow.Companies.Add(company);
				}
				else
				{
					company = uow.Companies.Query(tracking: true).First(c => c.Id == values.Id);
				}

				company.Name = values.Name;
				company.Industry = values.Industry;
				company.Size = values.Size;
				company.Website = values.Website;
				company.Phone = values.Phone;
				company.Address = values.Address;
				company.City = values.City;
				company.Country = values.Country;
				company.AnnualRevenue = values.AnnualRevenue;
				company.Tags = values.Tags;
				company.OwnerId = values.OwnerId;

				uow.Save();
				return company.Id;
			}
		}

		/// <summary>Deletes a company; its contacts, deals, activities and tasks are kept and unlinked.</summary>
		public static void Delete(int companyId)
		{
			using (var uow = Store.Open())
			{
				foreach (var c in uow.Contacts.Query(tracking: true).Where(x => x.CompanyId == companyId).ToList())
					c.CompanyId = null;
				foreach (var d in uow.Deals.Query(tracking: true).Where(x => x.CompanyId == companyId).ToList())
					d.CompanyId = null;
				foreach (var a in uow.Activities.Query(tracking: true).Where(x => x.CompanyId == companyId).ToList())
					a.CompanyId = null;
				foreach (var t in uow.Tasks.Query(tracking: true).Where(x => x.CompanyId == companyId).ToList())
					t.CompanyId = null;

				var company = uow.Companies.Query(tracking: true).FirstOrDefault(x => x.Id == companyId);
				if (company != null)
					uow.Companies.Remove(company);
				uow.Save();
			}
		}

		#region Implementation

		private class DealFigures
		{
			public int? CompanyId;
			public decimal Amount;
			public bool IsWon;
			public bool IsLost;
			public DateTime Closed;
			public bool IsOpen => !this.IsWon && !this.IsLost;
		}

		private static List<DealFigures> LoadDeals(IUnitOfWork uow, int? companyId)
		{
			return uow.Deals.Query()
				.Where(d => d.CompanyId != null && (companyId == null || d.CompanyId == companyId))
				.Select(d => new { d.CompanyId, d.Amount, d.Stage.IsWon, d.Stage.IsLost, d.ClosedDate, d.ExpectedCloseDate })
				.ToList()
				.Select(d => new DealFigures
				{
					CompanyId = d.CompanyId,
					Amount = d.Amount,
					IsWon = d.IsWon,
					IsLost = d.IsLost,
					Closed = d.ClosedDate ?? d.ExpectedCloseDate,
				})
				.ToList();
		}

		// first day of the month 11 months ago: the trend covers it and the current month.
		private static DateTime FirstMonth()
		{
			var today = DateTime.Today;
			return new DateTime(today.Year, today.Month, 1).AddMonths(-11);
		}

		private static double[] Trend(IEnumerable<DealFigures> deals, DateTime start)
		{
			var values = new double[12];
			foreach (var d in deals.Where(x => x.IsWon && x.Closed >= start))
			{
				var index = (d.Closed.Year - start.Year) * 12 + d.Closed.Month - start.Month;
				if (index >= 0 && index < 12)
					values[index] += (double)d.Amount;
			}
			return values;
		}

		#endregion
	}
}
