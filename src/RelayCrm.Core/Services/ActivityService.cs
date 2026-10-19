using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Data;

namespace RelayCrm.Services
{
	/// <summary>
	/// An activity as shown in the calendar and in the activities list.
	/// </summary>
	public class ActivityRow
	{
		public int Id { get; set; }
		public ActivityType Type { get; set; }
		public string TypeName { get; set; }
		public string TypeIcon { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public DateTime Date { get; set; }
		/// <summary>Duration in minutes.</summary>
		public int Duration { get; set; }
		/// <summary>"Call · 30 min" – the second line under the subject.</summary>
		public string Details { get; set; }
		/// <summary>"Contact · Company · Deal".</summary>
		public string RelatedText { get; set; }
		public int? ContactId { get; set; }
		public int? CompanyId { get; set; }
		public int? DealId { get; set; }
		public int? UserId { get; set; }
		public string UserName { get; set; }
		public string UserInitials { get; set; }

		/// <summary>End of the activity in the calendar (at least 30 minutes long).</summary>
		public DateTime End => this.Date.AddMinutes(Math.Max(30, this.Duration));
	}

	/// <summary>
	/// Reads and deletes activities for the activities module. New activities are logged by <see cref="ActivityLogService"/>.
	/// </summary>
	public static class ActivityService
	{
		/// <summary>
		/// Activities filtered by type, user and date range (all optional), newest first.
		/// </summary>
		/// <param name="type">Only this type, or null for all.</param>
		/// <param name="userId">Only the activities of this user, or null for everybody.</param>
		/// <param name="from">Inclusive start, or null.</param>
		/// <param name="to">Exclusive end, or null.</param>
		public static List<ActivityRow> List(ActivityType? type = null, int? userId = null, DateTime? from = null, DateTime? to = null)
		{
			using (var uow = Store.Open())
			{
				var query = uow.Activities.Query();
				if (type != null)
					query = query.Where(a => a.Type == type.Value);
				if (userId != null)
					query = query.Where(a => a.UserId == userId.Value);
				if (from != null)
					query = query.Where(a => a.Date >= from.Value);
				if (to != null)
					query = query.Where(a => a.Date < to.Value);

				return Project(query.OrderByDescending(a => a.Date));
			}
		}

		/// <summary>
		/// Activities that fall in the range shown by the calendar.
		/// </summary>
		public static List<ActivityRow> Range(DateTime from, DateTime to, ActivityType? type = null, int? userId = null)
		{
			return List(type, userId, from, to);
		}

		/// <summary>One activity, or null.</summary>
		public static ActivityRow Get(int id)
		{
			using (var uow = Store.Open())
			{
				return Project(uow.Activities.Query().Where(a => a.Id == id)).FirstOrDefault();
			}
		}

		/// <summary>Deletes an activity.</summary>
		public static void Delete(int id)
		{
			using (var uow = Store.Open())
			{
				var activity = uow.Activities.Query(tracking: true).FirstOrDefault(a => a.Id == id);
				if (activity == null)
					return;
				uow.Activities.Remove(activity);
				uow.Save();
			}
		}

		/// <summary>Tone of an activity type: Meeting = Primary, Call = Success, Email = Warning, Note = Neutral.</summary>
		public static RelayCrm.Services.Tone Tone(ActivityType type)
		{
			switch (type)
			{
				case ActivityType.Meeting: return RelayCrm.Services.Tone.Primary;
				case ActivityType.Call: return RelayCrm.Services.Tone.Success;
				case ActivityType.Email: return RelayCrm.Services.Tone.Warning;
				default: return RelayCrm.Services.Tone.Neutral;
			}
		}

		private static List<ActivityRow> Project(IQueryable<Activity> query)
		{
			var items = query.Select(a => new
			{
				a.Id,
				a.Type,
				a.Subject,
				a.Body,
				a.Date,
				a.Duration,
				a.ContactId,
				a.CompanyId,
				a.DealId,
				a.UserId,
				ContactName = a.Contact != null ? a.Contact.FirstName + " " + a.Contact.LastName : null,
				CompanyName = a.Company != null ? a.Company.Name : null,
				DealTitle = a.Deal != null ? a.Deal.Title : null,
				UserName = a.User != null ? a.User.Name : null,
			}).ToList();

			return items.Select(a => new ActivityRow
			{
				Id = a.Id,
				Type = a.Type,
				TypeName = a.Type.ToString(),
				TypeIcon = ActivityLogService.Icon(a.Type),
				Subject = a.Subject,
				Body = a.Body,
				Date = a.Date,
				Duration = a.Duration,
				Details = a.Duration > 0 ? a.Type + " · " + a.Duration + " min" : a.Type.ToString(),
				RelatedText = Related(a.ContactName, a.CompanyName, a.DealTitle),
				ContactId = a.ContactId,
				CompanyId = a.CompanyId,
				DealId = a.DealId,
				UserId = a.UserId,
				UserName = a.UserName ?? "",
				UserInitials = Text.Initials(a.UserName),
			}).ToList();
		}

		/// <summary>"Contact · Company · Deal", skipping the missing parts.</summary>
		internal static string Related(string contact, string company, string deal)
		{
			var parts = new[] { contact, company, deal }.Where(p => !string.IsNullOrWhiteSpace(p)).Select(p => p.Trim());
			return string.Join(" · ", parts);
		}
	}
}
