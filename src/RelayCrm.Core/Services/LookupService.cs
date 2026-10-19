using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Data;

namespace RelayCrm.Services
{
	/// <summary>A user as shown in lists, avatars and combo boxes.</summary>
	[Serializable]
	public class UserItem
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Initials { get; set; }
		public string AvatarColor { get; set; }
		public UserRole Role { get; set; }
		public bool Active { get; set; }
		public override string ToString() => this.Name;
	}

	/// <summary>A pipeline stage.</summary>
	public class StageItem
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Order { get; set; }
		public int Probability { get; set; }
		public bool IsWon { get; set; }
		public bool IsLost { get; set; }
		public override string ToString() => this.Name;
	}

	/// <summary>An id and a display text, for combo boxes.</summary>
	public class ListItem
	{
		public ListItem() { }
		public ListItem(int id, string text) { this.Id = id; this.Text = text; }
		public int Id { get; set; }
		public string Text { get; set; }
		public override string ToString() => this.Text;
	}

	/// <summary>
	/// Reference data shared by all modules: users, stages, companies, contacts and tags.
	/// </summary>
	public static class LookupService
	{
		public static List<UserItem> Users(bool activeOnly = false)
		{
			using (var uow = Store.Open())
			{
				return uow.Users.Query()
					.Where(u => !activeOnly || u.Active)
					.OrderBy(u => u.Name)
					.AsEnumerable()
					.Select(ToItem)
					.ToList();
			}
		}

		public static UserItem User(int id)
		{
			using (var uow = Store.Open())
			{
				var u = uow.Users.Query().FirstOrDefault(x => x.Id == id);
				return u == null ? null : ToItem(u);
			}
		}

		public static List<StageItem> Stages()
		{
			using (var uow = Store.Open())
			{
				return uow.Stages.Query()
					.OrderBy(s => s.Order)
					.Select(s => new StageItem { Id = s.Id, Name = s.Name, Order = s.Order, Probability = s.Probability, IsWon = s.IsWon, IsLost = s.IsLost })
					.ToList();
			}
		}

		public static List<ListItem> Companies()
		{
			using (var uow = Store.Open())
			{
				return uow.Companies.Query().OrderBy(c => c.Name).Select(c => new ListItem { Id = c.Id, Text = c.Name }).ToList();
			}
		}

		public static List<ListItem> Contacts(int? companyId = null)
		{
			using (var uow = Store.Open())
			{
				return uow.Contacts.Query()
					.Where(c => companyId == null || c.CompanyId == companyId)
					.OrderBy(c => c.FirstName).ThenBy(c => c.LastName)
					.Select(c => new ListItem { Id = c.Id, Text = c.FirstName + " " + c.LastName })
					.ToList();
			}
		}

		public static List<string> Tags()
		{
			using (var uow = Store.Open())
			{
				return uow.Tags.Query().OrderBy(t => t.Name).Select(t => t.Name).ToList();
			}
		}

		public static string[] LeadSources => new[] { "Website", "Referral", "Event", "Cold outreach", "Partner", "Webinar" };

		public static string[] Industries => new[] { "Software", "Manufacturing", "Healthcare", "Retail", "Logistics", "Energy", "Finance", "Education" };

		public static string[] CompanySizes => new[] { "1-10", "11-50", "51-200", "201-500", "501-1000", "1000+" };

		private static UserItem ToItem(User u)
		{
			return new UserItem
			{
				Id = u.Id,
				Name = u.Name,
				Email = u.Email,
				Initials = Text.Initials(u.Name),
				AvatarColor = u.AvatarColor,
				Role = u.Role,
				Active = u.Active,
			};
		}
	}
}
