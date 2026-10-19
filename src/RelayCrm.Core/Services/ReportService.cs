using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Data;

namespace RelayCrm.Services
{
	/// <summary>One month of the sales forecast.</summary>
	public class ForecastRow
	{
		public string Month { get; set; }
		public DateTime MonthStart { get; set; }
		public int Deals { get; set; }
		public decimal Pipeline { get; set; }
		/// <summary>Sum of amount × probability.</summary>
		public decimal Weighted { get; set; }
	}

	/// <summary>One month of the win/loss analysis.</summary>
	public class WinLossRow
	{
		public string Month { get; set; }
		public DateTime MonthStart { get; set; }
		public int Won { get; set; }
		public int Lost { get; set; }
		public decimal WonValue { get; set; }
		public decimal LostValue { get; set; }
		/// <summary>Won / (won + lost) in percent; 0 without closed deals.</summary>
		public double WinRate { get; set; }
	}

	/// <summary>Lost deals of one reason.</summary>
	public class LostReasonRow
	{
		public string Reason { get; set; }
		public int Deals { get; set; }
		public decimal Value { get; set; }
		/// <summary>Share of the lost deals in percent.</summary>
		public double Share { get; set; }
	}

	/// <summary>Activities logged by one user.</summary>
	public class UserActivityRow
	{
		public int? UserId { get; set; }
		public string User { get; set; }
		public int Calls { get; set; }
		public int Emails { get; set; }
		public int Meetings { get; set; }
		public int Notes { get; set; }
		public int Total => this.Calls + this.Emails + this.Meetings + this.Notes;
	}

	/// <summary>Contacts and customers of one lead source.</summary>
	public class LeadSourceRow
	{
		public string Source { get; set; }
		public int Contacts { get; set; }
		public int Customers { get; set; }
		/// <summary>Customers / contacts in percent.</summary>
		public double Conversion { get; set; }
	}

	/// <summary>
	/// The reports: sales forecast, win/loss analysis, activity per user and lead source conversion.
	/// Sales see their own records, Managers and Admins all; data is read once per report and aggregated in memory.
	/// </summary>
	public static class ReportService
	{
		/// <summary>Months covered by the forecast.</summary>
		public const int ForecastMonths = 6;

		/// <summary>Months covered by the win/loss analysis.</summary>
		public const int WinLossMonths = 12;

		/// <summary>Days covered by the activity report.</summary>
		public const int ActivityDays = 90;

		/// <summary>Weighted pipeline (amount × probability) by expected close month for the next 6 months; overdue deals count in the current month.</summary>
		public static List<ForecastRow> SalesForecast()
		{
			List<DashboardDeal> deals;
			using (var uow = Store.Open())
				deals = DashboardService.LoadDeals(uow);

			var first = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
			var open = deals.Where(d => d.IsOpen).ToList();
			return Enumerable.Range(0, ForecastMonths).Select(i =>
			{
				var from = first.AddMonths(i);
				var to = from.AddMonths(1);
				var month = open.Where(d => (i == 0 ? d.ExpectedCloseDate < to : d.ExpectedCloseDate >= from && d.ExpectedCloseDate < to)).ToList();
				return new ForecastRow
				{
					Month = from.ToString("MMM yyyy", Fmt.Culture),
					MonthStart = from,
					Deals = month.Count,
					Pipeline = month.Sum(d => d.Amount),
					Weighted = Math.Round(month.Sum(d => d.Amount * d.Probability / 100m), 0),
				};
			}).ToList();
		}

		/// <summary>Won and lost deals per month over the last 12 months, and the lost reasons of the same deals.</summary>
		public static List<WinLossRow> WinLoss(out List<LostReasonRow> reasons)
		{
			List<DashboardDeal> deals;
			using (var uow = Store.Open())
				deals = DashboardService.LoadDeals(uow);

			var first = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-(WinLossMonths - 1));
			var end = first.AddMonths(WinLossMonths);
			var closed = deals.Where(d => (d.IsWon || d.IsLost) && d.CloseDate >= first && d.CloseDate < end).ToList();

			var rows = Enumerable.Range(0, WinLossMonths).Select(i =>
			{
				var from = first.AddMonths(i);
				var to = from.AddMonths(1);
				var month = closed.Where(d => d.CloseDate >= from && d.CloseDate < to).ToList();
				var won = month.Where(d => d.IsWon).ToList();
				var lost = month.Where(d => d.IsLost).ToList();
				return new WinLossRow
				{
					Month = from.ToString("MMM yyyy", Fmt.Culture),
					MonthStart = from,
					Won = won.Count,
					Lost = lost.Count,
					WonValue = won.Sum(d => d.Amount),
					LostValue = lost.Sum(d => d.Amount),
					WinRate = month.Count == 0 ? 0 : Math.Round(won.Count * 100d / month.Count, 1),
				};
			}).ToList();

			var lostDeals = closed.Where(d => d.IsLost).ToList();
			reasons = lostDeals
				.GroupBy(d => string.IsNullOrWhiteSpace(d.LostReason) ? "Not specified" : d.LostReason.Trim())
				.Select(g => new LostReasonRow
				{
					Reason = g.Key,
					Deals = g.Count(),
					Value = g.Sum(d => d.Amount),
					Share = Math.Round(g.Count() * 100d / lostDeals.Count, 1),
				})
				.OrderByDescending(r => r.Deals)
				.ThenBy(r => r.Reason)
				.ToList();

			return rows;
		}

		/// <summary>Calls, emails, meetings and notes per user over the last 90 days.</summary>
		public static List<UserActivityRow> ActivityPerUser()
		{
			var now = DateTime.Now;
			var from = DateTime.Today.AddDays(-ActivityDays);
			var mine = !CurrentUser.SeesAll;
			var userId = CurrentUser.Id;

			using (var uow = Store.Open())
			{
				var activities = uow.Activities.Query()
					.Where(a => a.Date >= from && a.Date <= now && (!mine || a.UserId == userId))
					.Select(a => new { a.UserId, User = a.User.Name, a.Type })
					.ToList();

				var users = uow.Users.Query()
					.Where(u => u.Active && (!mine || u.Id == userId))
					.Select(u => new { u.Id, u.Name })
					.ToList();

				var rows = activities
					.GroupBy(a => new { a.UserId, a.User })
					.Select(g => new UserActivityRow
					{
						UserId = g.Key.UserId,
						User = g.Key.User ?? "Unassigned",
						Calls = g.Count(a => a.Type == ActivityType.Call),
						Emails = g.Count(a => a.Type == ActivityType.Email),
						Meetings = g.Count(a => a.Type == ActivityType.Meeting),
						Notes = g.Count(a => a.Type == ActivityType.Note),
					})
					.ToList();

				// active users without activities are listed too.
				rows.AddRange(users
					.Where(u => !rows.Any(r => r.UserId == u.Id))
					.Select(u => new UserActivityRow { UserId = u.Id, User = u.Name }));

				return rows.OrderByDescending(r => r.Total).ThenBy(r => r.User).ToList();
			}
		}

		/// <summary>Contacts and customers per lead source, with the conversion rate.</summary>
		public static List<LeadSourceRow> LeadSourceConversion()
		{
			var mine = !CurrentUser.SeesAll;
			var userId = CurrentUser.Id;

			using (var uow = Store.Open())
			{
				var contacts = uow.Contacts.Query()
					.Where(c => !mine || c.OwnerId == userId)
					.Select(c => new { c.LeadSource, c.Stage })
					.ToList();

				var sources = LookupService.LeadSources
					.Concat(contacts.Select(c => string.IsNullOrWhiteSpace(c.LeadSource) ? "Unknown" : c.LeadSource.Trim()))
					.Distinct(StringComparer.OrdinalIgnoreCase)
					.ToList();

				return sources.Select(s =>
				{
					var list = contacts.Where(c => string.Equals(string.IsNullOrWhiteSpace(c.LeadSource) ? "Unknown" : c.LeadSource.Trim(), s, StringComparison.OrdinalIgnoreCase)).ToList();
					var customers = list.Count(c => c.Stage == LifecycleStage.Customer);
					return new LeadSourceRow
					{
						Source = s,
						Contacts = list.Count,
						Customers = customers,
						Conversion = list.Count == 0 ? 0 : Math.Round(customers * 100d / list.Count, 1),
					};
				})
				.Where(r => r.Contacts > 0 || LookupService.LeadSources.Contains(r.Source))
				.OrderByDescending(r => r.Conversion)
				.ThenByDescending(r => r.Contacts)
				.ToList();
			}
		}
	}
}
