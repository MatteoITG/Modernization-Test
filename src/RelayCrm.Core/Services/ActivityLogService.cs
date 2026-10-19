using System;
using System.Linq;
using RelayCrm.Data;

namespace RelayCrm.Services
{
	/// <summary>
	/// Logs activities (calls, emails, meetings, notes); used by the "Log activity" dialog from every module.
	/// </summary>
	public static class ActivityLogService
	{
		public static int Log(ActivityType type, string subject, string body, DateTime date, int duration, int? contactId, int? companyId, int? dealId)
		{
			using (var uow = Store.Open())
			{
				// complete the related records: a contact implies its company, a deal implies its company.
				if (companyId == null && contactId != null)
					companyId = uow.Contacts.Query().Where(c => c.Id == contactId).Select(c => c.CompanyId).FirstOrDefault();
				if (companyId == null && dealId != null)
					companyId = uow.Deals.Query().Where(d => d.Id == dealId).Select(d => d.CompanyId).FirstOrDefault();

				var activity = new Activity
				{
					Type = type,
					Subject = subject,
					Body = body,
					Date = date,
					Duration = duration,
					ContactId = contactId,
					CompanyId = companyId,
					DealId = dealId,
					UserId = CurrentUser.IsSignedIn ? CurrentUser.Id : (int?)null,
				};
				uow.Activities.Add(activity);

				if (contactId != null && date <= DateTime.Now)
				{
					var contact = uow.Contacts.Query(tracking: true).First(c => c.Id == contactId);
					if (contact.LastContacted == null || contact.LastContacted < date)
						contact.LastContacted = date;
				}

				uow.Save();
				return activity.Id;
			}
		}

		/// <summary>Icon of an activity type.</summary>
		public static string Icon(ActivityType type)
		{
			switch (type)
			{
				case ActivityType.Call: return Icons.Get("telephone");
				case ActivityType.Email: return Icons.Get("envelope");
				case ActivityType.Meeting: return Icons.Get("people");
				default: return Icons.Get("sticky");
			}
		}
	}
}
