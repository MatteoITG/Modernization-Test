using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using RelayCrm.Data;

namespace RelayCrm.Services
{
	/// <summary>
	/// Time span summarized by the dashboard.
	/// </summary>
	public enum DashboardPeriod { Month, Quarter, Year }

	/// <summary>
	/// The colours of the charts: one fixed categorical order (accent indigo first) and a neutral grey for comparisons.
	/// Charts are the only place where colours appear in code.
	/// </summary>
	public static class ChartColors
	{
		public static readonly Color Indigo = ColorTranslator.FromHtml("#4F46E5");
		public static readonly Color Sky = ColorTranslator.FromHtml("#0EA5E9");
		public static readonly Color Emerald = ColorTranslator.FromHtml("#10B981");
		public static readonly Color Amber = ColorTranslator.FromHtml("#F59E0B");
		public static readonly Color Pink = ColorTranslator.FromHtml("#EC4899");
		public static readonly Color Violet = ColorTranslator.FromHtml("#8B5CF6");

		/// <summary>Previous period, totals and other comparison series.</summary>
		public static readonly Color Neutral = ColorTranslator.FromHtml("#94A3B8");

		/// <summary>The categorical palette, assigned in this order and never cycled.</summary>
		public static Color[] Palette => new[] { Indigo, Sky, Emerald, Amber, Pink, Violet, ColorTranslator.FromHtml("#64748B") };

		/// <summary>
		/// A round top for a value axis drawn with <paramref name="ticks"/> intervals (the charts draw 4),
		/// so that every tick is a round number: 739,000 becomes 800,000 (ticks of 200,000). Null when there is nothing to show.
		/// <paramref name="whole"/> keeps the ticks of counts on whole numbers.
		/// </summary>
		public static double? NiceMax(IEnumerable<double> values, bool whole = false, int ticks = 4)
		{
			var max = values.DefaultIfEmpty(0).Max();
			if (max <= 0)
				return null;

			var raw = max / ticks;
			var magnitude = Math.Pow(10, Math.Floor(Math.Log10(raw)));
			var factors = whole && magnitude < 10 ? new[] { 1d, 2d, 5d, 10d } : new[] { 1d, 2d, 2.5d, 5d, 10d };
			var step = factors.Select(f => f * magnitude).First(s => s >= raw * 0.999999);
			if (whole)
				step = Math.Max(1, Math.Round(step));
			return step * ticks;
		}
	}

	/// <summary>A deal projected for the dashboard and report aggregations.</summary>
	public class DashboardDeal
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public int? CompanyId { get; set; }
		public string CompanyName { get; set; }
		public decimal Amount { get; set; }
		public int StageId { get; set; }
		public string StageName { get; set; }
		public int StageOrder { get; set; }
		public bool IsWon { get; set; }
		public bool IsLost { get; set; }
		public DateTime ExpectedCloseDate { get; set; }
		public DateTime? ClosedDate { get; set; }
		public DateTime CreatedAt { get; set; }
		public int Probability { get; set; }
		public int? OwnerId { get; set; }
		public string OwnerName { get; set; }
		public string LostReason { get; set; }

		public bool IsOpen => !this.IsWon && !this.IsLost;

		/// <summary>Date the deal was won or lost (the expected close date when no close date was stored).</summary>
		public DateTime CloseDate => (this.ClosedDate ?? this.ExpectedCloseDate).Date;
	}

	/// <summary>One KPI of the dashboard.</summary>
	public class DashboardKpi
	{
		public string Value { get; set; }
		public string Caption { get; set; }
		/// <summary>Change in percent versus the previous period, or null.</summary>
		public decimal? Trend { get; set; }
		public double[] Sparkline { get; set; }
	}

	/// <summary>Open deals of one stage.</summary>
	public class DashboardStage
	{
		public int StageId { get; set; }
		public string Name { get; set; }
		public int Count { get; set; }
		public decimal Value { get; set; }
	}

	/// <summary>Won revenue of one bucket (week or month) and of the same bucket of the previous period.</summary>
	public class DashboardRevenueBucket
	{
		public string Label { get; set; }
		public string Caption { get; set; }
		public DateTime From { get; set; }
		public DateTime To { get; set; }
		public decimal Value { get; set; }
		public string PreviousCaption { get; set; }
		public DateTime PreviousFrom { get; set; }
		public DateTime PreviousTo { get; set; }
		public decimal PreviousValue { get; set; }
	}

	/// <summary>Open pipeline of one owner.</summary>
	public class DashboardOwner
	{
		public int? OwnerId { get; set; }
		public string Name { get; set; }
		public int Count { get; set; }
		public decimal Value { get; set; }
	}

	/// <summary>A task of the "My tasks today" card (property names used by the ActionCardList).</summary>
	public class DashboardTask
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Meta { get; set; }
		public string Icon { get; set; }
		public Tone IconTone { get; set; }
		public string Badge { get; set; }
		public Tone BadgeTone { get; set; }
	}

	/// <summary>An activity of the "Recent activity" card.</summary>
	public class DashboardActivity
	{
		public int Id { get; set; }
		public ActivityType Type { get; set; }
		public string Subject { get; set; }
		public string Description { get; set; }
		public DateTime Date { get; set; }
		public int? ContactId { get; set; }
		public int? CompanyId { get; set; }
		public int? DealId { get; set; }
	}

	/// <summary>A row of the "Deals closing soon" grid.</summary>
	public class DashboardClosingDeal
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string CompanyName { get; set; }
		public decimal Amount { get; set; }
		public DateTime CloseDate { get; set; }
		public int Probability { get; set; }
		public string ProbabilityText => this.Probability + "%";
	}

	/// <summary>A row of the "Top accounts" grid.</summary>
	public class DashboardAccount
	{
		public int CompanyId { get; set; }
		public string Company { get; set; }
		public decimal WonRevenue { get; set; }
		public int Deals { get; set; }
	}

	/// <summary>Everything the dashboard shows for one period.</summary>
	public class DashboardData
	{
		public DashboardPeriod Period { get; set; }
		/// <summary>First day of the period.</summary>
		public DateTime Start { get; set; }
		/// <summary>First day after the period.</summary>
		public DateTime End { get; set; }
		public string PeriodName { get; set; }

		public DashboardKpi OpenPipeline { get; set; }
		public DashboardKpi WonRevenue { get; set; }
		public DashboardKpi WinRate { get; set; }
		public DashboardKpi AverageDeal { get; set; }

		public List<DashboardStage> PipelineByStage { get; set; }
		public List<DashboardRevenueBucket> WonByBucket { get; set; }
		public string CurrentSeriesName { get; set; }
		public string PreviousSeriesName { get; set; }
		public List<DashboardOwner> DealsByOwner { get; set; }
		public List<DashboardTask> MyTasks { get; set; }
		public List<DashboardActivity> RecentActivity { get; set; }
		public List<DashboardClosingDeal> ClosingSoon { get; set; }
		public List<DashboardAccount> TopAccounts { get; set; }
	}

	/// <summary>
	/// Computes the dashboard of the signed in user: Sales see their own deals, Managers and Admins all.
	/// The deals are read once per refresh and aggregated in memory.
	/// </summary>
	public static class DashboardService
	{
		

		/// <summary>Reads the deals visible to the current user (own deals for Sales).</summary>
		public static List<DashboardDeal> LoadDeals(IUnitOfWork uow)
		{
			var mine = !CurrentUser.SeesAll;
			var userId = CurrentUser.Id;
			return uow.Deals.Query()
				.Where(d => !mine || d.OwnerId == userId)
				.Select(d => new DashboardDeal
				{
					Id = d.Id,
					Title = d.Title,
					CompanyId = d.CompanyId,
					CompanyName = d.Company.Name,
					Amount = d.Amount,
					StageId = d.StageId,
					StageName = d.Stage.Name,
					StageOrder = d.Stage.Order,
					IsWon = d.Stage.IsWon,
					IsLost = d.Stage.IsLost,
					ExpectedCloseDate = d.ExpectedCloseDate,
					ClosedDate = d.ClosedDate,
					CreatedAt = d.CreatedAt,
					Probability = d.Probability,
					OwnerId = d.OwnerId,
					OwnerName = d.Owner.Name,
					LostReason = d.LostReason,
				})
				.ToList();
		}

		/// <summary>First day of the period that contains <paramref name="date"/>.</summary>
		public static DateTime PeriodStart(DashboardPeriod period, DateTime date)
		{
			switch (period)
			{
				case DashboardPeriod.Quarter: return new DateTime(date.Year, (date.Month - 1) / 3 * 3 + 1, 1);
				case DashboardPeriod.Year: return new DateTime(date.Year, 1, 1);
				default: return new DateTime(date.Year, date.Month, 1);
			}
		}

		/// <summary>Adds whole periods to a period start.</summary>
		public static DateTime AddPeriods(DashboardPeriod period, DateTime start, int count)
		{
			switch (period)
			{
				case DashboardPeriod.Quarter: return start.AddMonths(3 * count);
				case DashboardPeriod.Year: return start.AddYears(count);
				default: return start.AddMonths(count);
			}
		}

		/// <summary>Loads the dashboard for <paramref name="period"/>.</summary>
		public static DashboardData Load(DashboardPeriod period)
		{
			var today = DateTime.Today;
			var start = PeriodStart(period, today);
			var end = AddPeriods(period, start, 1);
			var prevStart = AddPeriods(period, start, -1);
			// period to date, compared with the same span of the previous period.
			var elapsed = today.AddDays(1) - start;
			var prevEndToDate = prevStart + elapsed;
			if (prevEndToDate > start)
				prevEndToDate = start;

			List<DashboardDeal> deals;
			List<DashboardTask> tasks;
			List<DashboardActivity> activity;
			using (var uow = Store.Open())
			{
				deals = LoadDeals(uow);
				tasks = LoadMyTasks(uow, today);
				activity = LoadRecentActivity(uow);
			}

			var data = new DashboardData
			{
				Period = period,
				Start = start,
				End = end,
				PeriodName = PeriodName(period, start),
				MyTasks = tasks,
				RecentActivity = activity,
			};

			var buckets = SparkBuckets(period, today);
			var won = deals.Where(d => d.IsWon).ToList();
			var closed = deals.Where(d => d.IsWon || d.IsLost).ToList();
			var open = deals.Where(d => d.IsOpen).ToList();

			// KPIs
			var openValue = open.Sum(d => d.Amount);
			data.OpenPipeline = new DashboardKpi
			{
				Value = Fmt.MoneyShort(openValue),
				Caption = open.Count + (open.Count == 1 ? " open deal" : " open deals"),
				Sparkline = buckets.Select(b => (double)OpenValueAt(deals, b.Item2)).ToArray(),
			};

			var wonNow = won.Where(d => In(d.CloseDate, start, end)).ToList();
			var wonPrev = won.Where(d => In(d.CloseDate, prevStart, prevEndToDate)).ToList();
			var wonValue = wonNow.Sum(d => d.Amount);
			var wonPrevValue = wonPrev.Sum(d => d.Amount);
			data.WonRevenue = new DashboardKpi
			{
				Value = Fmt.MoneyShort(wonValue),
				Caption = "vs " + Fmt.MoneyShort(wonPrevValue) + " " + PreviousName(period),
				Trend = wonPrevValue == 0 ? (wonValue == 0 ? 0m : (decimal?)null) : Math.Round((wonValue - wonPrevValue) / wonPrevValue * 100m, 1),
				Sparkline = buckets.Select(b => (double)won.Where(d => In(d.CloseDate, b.Item1, b.Item2)).Sum(d => d.Amount)).ToArray(),
			};

			var closedNow = closed.Where(d => In(d.CloseDate, start, end)).ToList();
			var closedPrev = closed.Where(d => In(d.CloseDate, prevStart, prevEndToDate)).ToList();
			var rate = WinRate(closedNow);
			var ratePrev = WinRate(closedPrev);
			data.WinRate = new DashboardKpi
			{
				Value = rate == null ? "–" : Fmt.Percent(rate.Value),
				Caption = closedNow.Count(d => d.IsWon) + " won · " + closedNow.Count(d => d.IsLost) + " lost",
				Trend = rate != null && ratePrev != null ? (decimal?)Math.Round((decimal)(rate.Value - ratePrev.Value), 1) : null,
				Sparkline = buckets.Select(b => WinRate(closed.Where(d => In(d.CloseDate, b.Item1, b.Item2))) ?? 0d).ToArray(),
			};

			var average = wonNow.Count == 0 ? 0m : wonNow.Average(d => d.Amount);
			var averagePrev = wonPrev.Count == 0 ? 0m : wonPrev.Average(d => d.Amount);
			data.AverageDeal = new DashboardKpi
			{
				Value = wonNow.Count == 0 ? "–" : Fmt.MoneyShort(average),
				Caption = wonNow.Count + (wonNow.Count == 1 ? " deal won" : " deals won"),
				Trend = average > 0 && averagePrev > 0 ? (decimal?)Math.Round((average - averagePrev) / averagePrev * 100m, 1) : null,
				Sparkline = buckets.Select(b =>
				{
					var w = won.Where(d => In(d.CloseDate, b.Item1, b.Item2)).ToList();
					return w.Count == 0 ? 0d : (double)w.Average(d => d.Amount);
				}).ToArray(),
			};

			// pipeline by stage (open stages, in pipeline order, including empty ones)
			List<StageItem> stages = null;
			using (var uow = Store.Open())
			{
				stages = uow.Stages.Query()
					.Where(s => !s.IsWon && !s.IsLost)
					.OrderBy(s => s.Order)
					.Select(s => new StageItem { Id = s.Id, Name = s.Name, Order = s.Order })
					.ToList();
			}
			data.PipelineByStage = stages.Select(s => new DashboardStage
			{
				StageId = s.Id,
				Name = s.Name,
				Count = open.Count(d => d.StageId == s.Id),
				Value = open.Where(d => d.StageId == s.Id).Sum(d => d.Amount),
			}).ToList();

			// won revenue per bucket, with the same bucket of the previous period
			data.WonByBucket = RevenueBuckets(period, start, end, prevStart);
			foreach (var b in data.WonByBucket)
			{
				b.Value = won.Where(d => In(d.CloseDate, b.From, b.To)).Sum(d => d.Amount);
				b.PreviousValue = won.Where(d => In(d.CloseDate, b.PreviousFrom, b.PreviousTo)).Sum(d => d.Amount);
			}
			data.CurrentSeriesName = PeriodName(period, start);
			data.PreviousSeriesName = PeriodName(period, prevStart);

			// open pipeline per owner
			data.DealsByOwner = open
				.GroupBy(d => new { d.OwnerId, d.OwnerName })
				.Select(g => new DashboardOwner { OwnerId = g.Key.OwnerId, Name = g.Key.OwnerName ?? "Unassigned", Count = g.Count(), Value = g.Sum(d => d.Amount) })
				.OrderByDescending(o => o.Value)
				.ToList();

			// deals closing in the next 30 days
			data.ClosingSoon = open
				.Where(d => d.ExpectedCloseDate.Date >= today && d.ExpectedCloseDate.Date <= today.AddDays(30))
				.OrderBy(d => d.ExpectedCloseDate)
				.Select(d => new DashboardClosingDeal
				{
					Id = d.Id,
					Title = d.Title,
					CompanyName = d.CompanyName ?? "",
					Amount = d.Amount,
					CloseDate = d.ExpectedCloseDate.Date,
					Probability = d.Probability,
				})
				.ToList();

			// companies by won revenue in the period
			data.TopAccounts = wonNow
				.Where(d => d.CompanyId != null)
				.GroupBy(d => new { Id = d.CompanyId.Value, d.CompanyName })
				.Select(g => new DashboardAccount { CompanyId = g.Key.Id, Company = g.Key.CompanyName, WonRevenue = g.Sum(d => d.Amount), Deals = g.Count() })
				.OrderByDescending(a => a.WonRevenue)
				.Take(10)
				.ToList();

			return data;
		}

		/// <summary>"October 2026", "Q4 2026", "2026".</summary>
		public static string PeriodName(DashboardPeriod period, DateTime start)
		{
			switch (period)
			{
				case DashboardPeriod.Quarter: return "Q" + ((start.Month - 1) / 3 + 1) + " " + start.Year;
				case DashboardPeriod.Year: return start.Year.ToString();
				default: return start.ToString("MMMM yyyy", Fmt.Culture);
			}
		}

		/// <summary>"Won in March 2026", "Won Oct 1 – 7, 2026".</summary>
		public static string RangeCaption(string prefix, DateTime from, DateTime to)
		{
			var last = to.AddDays(-1);
			if (from.Day == 1 && to == from.AddMonths(1))
				return prefix + " in " + from.ToString("MMMM yyyy", Fmt.Culture);
			return prefix + " " + from.ToString("MMM d", Fmt.Culture) + " – " + last.ToString("MMM d, yyyy", Fmt.Culture);
		}

		private static string PreviousName(DashboardPeriod period)
		{
			switch (period)
			{
				case DashboardPeriod.Quarter: return "last quarter";
				case DashboardPeriod.Year: return "last year";
				default: return "last month";
			}
		}

		private static bool In(DateTime date, DateTime from, DateTime to)
		{
			return date >= from && date < to;
		}

		private static double? WinRate(IEnumerable<DashboardDeal> closed)
		{
			var list = closed.ToList();
			return list.Count == 0 ? (double?)null : list.Count(d => d.IsWon) * 100d / list.Count;
		}

		/// <summary>Value of the deals that were open at <paramref name="at"/>: created before and not yet closed.</summary>
		private static decimal OpenValueAt(List<DashboardDeal> deals, DateTime at)
		{
			return deals
				.Where(d => d.CreatedAt < at && (d.IsOpen || d.CloseDate >= at))
				.Sum(d => d.Amount);
		}

		/// <summary>Trailing buckets of the sparklines [from, to): 8 weeks, 13 weeks or 12 months up to today.</summary>
		private static List<Tuple<DateTime, DateTime>> SparkBuckets(DashboardPeriod period, DateTime today)
		{
			var list = new List<Tuple<DateTime, DateTime>>();
			var end = today.AddDays(1);
			if (period == DashboardPeriod.Year)
			{
				var month = new DateTime(today.Year, today.Month, 1);
				for (int i = 11; i >= 0; i--)
				{
					var from = month.AddMonths(-i);
					list.Add(Tuple.Create(from, i == 0 ? end : from.AddMonths(1)));
				}
			}
			else
			{
				var weeks = period == DashboardPeriod.Quarter ? 13 : 8;
				for (int i = weeks - 1; i >= 0; i--)
					list.Add(Tuple.Create(end.AddDays(-7 * (i + 1)), end.AddDays(-7 * i)));
			}
			return list;
		}

		/// <summary>Buckets of the won revenue chart: the weeks of a month, the months of a quarter or a year.</summary>
		private static List<DashboardRevenueBucket> RevenueBuckets(DashboardPeriod period, DateTime start, DateTime end, DateTime prevStart)
		{
			var list = new List<DashboardRevenueBucket>();
			if (period == DashboardPeriod.Month)
			{
				var prevEnd = start;
				for (int day = 1; start.AddDays(day - 1) < end; day += 7)
				{
					var from = start.AddDays(day - 1);
					var to = from.AddDays(7) > end ? end : from.AddDays(7);
					var pFrom = prevStart.AddDays(day - 1);
					var pTo = prevStart.AddDays(day + 6) > prevEnd ? prevEnd : prevStart.AddDays(day + 6);
					if (pFrom > prevEnd) pFrom = prevEnd;
					list.Add(new DashboardRevenueBucket
					{
						Label = from.ToString("MMM d", Fmt.Culture) + "–" + to.AddDays(-1).Day,
						From = from,
						To = to,
						Caption = RangeCaption("Won", from, to),
						PreviousFrom = pFrom,
						PreviousTo = pTo,
						PreviousCaption = pFrom < pTo ? RangeCaption("Won", pFrom, pTo) : null,
					});
				}
			}
			else
			{
				for (var from = start; from < end; from = from.AddMonths(1))
				{
					var pFrom = prevStart.AddMonths((from.Year - start.Year) * 12 + from.Month - start.Month);
					list.Add(new DashboardRevenueBucket
					{
						Label = from.ToString("MMM", Fmt.Culture),
						From = from,
						To = from.AddMonths(1),
						Caption = RangeCaption("Won", from, from.AddMonths(1)),
						PreviousFrom = pFrom,
						PreviousTo = pFrom.AddMonths(1),
						PreviousCaption = RangeCaption("Won", pFrom, pFrom.AddMonths(1)),
					});
				}
			}
			return list;
		}

		/// <summary>Open tasks of the current user due today or overdue.</summary>
		private static List<DashboardTask> LoadMyTasks(IUnitOfWork uow, DateTime today)
		{
			var userId = CurrentUser.Id;
			var tomorrow = today.AddDays(1);
			var rows = uow.Tasks.Query()
				.Where(t => t.AssigneeId == userId && t.Status == CrmTaskStatus.Open && t.DueDate < tomorrow)
				.OrderBy(t => t.DueDate)
				.Select(t => new
				{
					t.Id,
					t.Title,
					t.DueDate,
					t.Priority,
					Deal = t.Deal.Title,
					Contact = t.Contact.FirstName + " " + t.Contact.LastName,
					Company = t.Company.Name,
				})
				.Take(50)
				.ToList();

			return rows.Select(t =>
			{
				var overdue = t.DueDate.Date < today;
				var related = t.Deal ?? (string.IsNullOrWhiteSpace(t.Contact) ? t.Company : t.Contact.Trim() + (t.Company != null ? " · " + t.Company : ""));
				return new DashboardTask
				{
					Id = t.Id,
					Title = t.Title,
					Description = related ?? "",
					Meta = overdue ? "Overdue · due " + Fmt.Relative(t.DueDate) : "Due today",
					Icon = Icons.Get(overdue ? "exclamation-circle" : "check2-square"),
					IconTone = overdue ? Tone.Danger : Tone.Primary,
					Badge = t.Priority == TaskPriority.High ? "High" : null,
					BadgeTone = t.Priority == TaskPriority.High ? Tone.Warning : Tone.Neutral,
				};
			}).ToList();
		}

		/// <summary>The latest activities (own activities for Sales).</summary>
		private static List<DashboardActivity> LoadRecentActivity(IUnitOfWork uow)
		{
			var mine = !CurrentUser.SeesAll;
			var userId = CurrentUser.Id;
			var now = DateTime.Now;
			var rows = uow.Activities.Query()
				.Where(a => a.Date <= now && (!mine || a.UserId == userId))
				.OrderByDescending(a => a.Date)
				.Take(12)
				.Select(a => new
				{
					a.Id,
					a.Type,
					a.Subject,
					a.Date,
					a.ContactId,
					a.CompanyId,
					a.DealId,
					Contact = a.Contact.FirstName + " " + a.Contact.LastName,
					Company = a.Company.Name,
					User = a.User.Name,
				})
				.ToList();

			return rows.Select(a => new DashboardActivity
			{
				Id = a.Id,
				Type = a.Type,
				Subject = a.Subject,
				Date = a.Date,
				ContactId = a.ContactId,
				CompanyId = a.CompanyId,
				DealId = a.DealId,
				Description = string.Join(" · ", new[] { a.Contact?.Trim(), a.Company, a.User }.Where(s => !string.IsNullOrWhiteSpace(s))),
			}).ToList();
		}
	}
}
