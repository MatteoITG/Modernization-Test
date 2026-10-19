using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Data;

namespace RelayCrm.Services
{
	/// <summary>A user as shown in the Users tab of the settings.</summary>
	public class UserRow
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string AvatarColor { get; set; }
		/// <summary>Avatar picture in the user's colour (an SVG data URL).</summary>
		public string AvatarImage { get; set; }
		/// <summary>Role name: Admin, Manager or Sales.</summary>
		public string Role { get; set; }
		public bool Active { get; set; }
		/// <summary>Companies, contacts and deals owned by the user.</summary>
		public int OwnedRecords { get; set; }
		/// <summary>"12 companies · 30 contacts · 8 deals".</summary>
		public string OwnedText { get; set; }
	}

	/// <summary>A pipeline stage being edited in the settings.</summary>
	public class StageRow
	{
		public int Id { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public int Probability { get; set; }
		public bool IsWon { get; set; }
		public bool IsLost { get; set; }
		public int Deals { get; set; }
		public bool IsClosed => this.IsWon || this.IsLost;
		/// <summary>Open, Won or Lost.</summary>
		public string Kind => this.IsWon ? "Won" : this.IsLost ? "Lost" : "Open";
	}

	/// <summary>A tag with the number of companies and contacts that use it.</summary>
	public class TagRow
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Companies { get; set; }
		public int Contacts { get; set; }
		public int Usage => this.Companies + this.Contacts;
		public string UsageText => this.Usage == 0 ? "Not used" : $"{this.Companies} companies · {this.Contacts} contacts";
	}

	/// <summary>
	/// Settings of Relay: users and roles, pipeline stages, tags, the profile of the signed in user and the demo data.
	/// </summary>
	public static class SettingsService
	{
		/// <summary>The avatar colours a user can choose from.</summary>
		public static readonly string[] AvatarPalette = {
			"#4F46E5", "#0EA5E9", "#10B981", "#F59E0B", "#EC4899", "#8B5CF6", "#EF4444", "#64748B" };

		/// <summary>True when the signed in user may invite users and change roles.</summary>
		public static bool CanManageUsers => CurrentUser.IsAdmin;

		/// <summary>True when the signed in user may see the Users tab.</summary>
		public static bool CanSeeUsers => CurrentUser.Role != UserRole.Sales;

		/// <summary>True when the signed in user may change stages and tags.</summary>
		public static bool CanEditSettings => CurrentUser.Role != UserRole.Sales;

		#region Users

		public static List<UserRow> Users()
		{
			using (var uow = Store.Open())
			{
				var users = uow.Users.Query().OrderBy(u => u.Name).ToList();
				var companies = uow.Companies.Query().Where(c => c.OwnerId != null).GroupBy(c => c.OwnerId).Select(g => new { Id = g.Key, Count = g.Count() }).ToList();
				var contacts = uow.Contacts.Query().Where(c => c.OwnerId != null).GroupBy(c => c.OwnerId).Select(g => new { Id = g.Key, Count = g.Count() }).ToList();
				var deals = uow.Deals.Query().Where(d => d.OwnerId != null).GroupBy(d => d.OwnerId).Select(g => new { Id = g.Key, Count = g.Count() }).ToList();

				return users.Select(u =>
				{
					var co = companies.FirstOrDefault(x => x.Id == u.Id)?.Count ?? 0;
					var ct = contacts.FirstOrDefault(x => x.Id == u.Id)?.Count ?? 0;
					var de = deals.FirstOrDefault(x => x.Id == u.Id)?.Count ?? 0;
					return new UserRow
					{
						Id = u.Id,
						Name = u.Name,
						Email = u.Email,
						AvatarColor = u.AvatarColor,
						AvatarImage = AvatarImage(u.Name, u.AvatarColor),
						Role = u.Role.ToString(),
						Active = u.Active,
						OwnedRecords = co + ct + de,
						OwnedText = $"{co} companies · {ct} contacts · {de} deals",
					};
				}).ToList();
			}
		}

		/// <summary>
		/// Returns the reason why the email cannot be used, or null when it is valid and not used by another user.
		/// </summary>
		public static string ValidateEmail(string email, int? exceptUserId = null)
		{
			email = (email ?? "").Trim();
			if (email.Length == 0)
				return "Enter an email address.";
			if (!IsValidEmail(email))
				return "Enter a valid email address.";

			var lower = email.ToLowerInvariant();
			using (var uow = Store.Open())
			{
				if (uow.Users.Query().Any(u => u.Email.ToLower() == lower && u.Id != (exceptUserId ?? 0)))
					return "Another user already has this email.";
			}
			return null;
		}

		/// <summary>Creates a user (an invitation); returns the new user's id.</summary>
		public static int InviteUser(string name, string email, UserRole role)
		{
			RequireAdmin();
			name = (name ?? "").Trim();
			if (name.Length == 0)
				throw new InvalidOperationException("Enter a name.");
			var error = ValidateEmail(email);
			if (error != null)
				throw new InvalidOperationException(error);

			using (var uow = Store.Open())
			{
				var count = uow.Users.Query().Count();
				var user = new User
				{
					Name = name,
					Email = email.Trim(),
					Role = role,
					Active = true,
					AvatarColor = AvatarPalette[count % AvatarPalette.Length],
					CreatedAt = DateTime.Now,
					UpdatedAt = DateTime.Now,
				};
				uow.Users.Add(user);
				uow.Save();
				return user.Id;
			}
		}

		/// <summary>Changes the role of a user. At least one active Admin must remain.</summary>
		public static void ChangeRole(int userId, UserRole role)
		{
			RequireAdmin();
			using (var uow = Store.Open())
			{
				var user = uow.Users.Query(tracking: true).First(u => u.Id == userId);
				if (user.Role == role)
					return;
				if (user.Role == UserRole.Admin && !uow.Users.Query().Any(u => u.Id != userId && u.Active && u.Role == UserRole.Admin))
					throw new InvalidOperationException("Relay needs at least one active Admin.");

				user.Role = role;
				user.UpdatedAt = DateTime.Now;
				uow.Save();
			}
			if (userId == CurrentUser.Id)
				CurrentUser.Refresh();
		}

		/// <summary>Activates or deactivates a user. Users cannot deactivate themselves.</summary>
		public static void SetActive(int userId, bool active)
		{
			RequireAdmin();
			if (!active && userId == CurrentUser.Id)
				throw new InvalidOperationException("You cannot deactivate yourself.");

			using (var uow = Store.Open())
			{
				var user = uow.Users.Query(tracking: true).First(u => u.Id == userId);
				if (!active && user.Role == UserRole.Admin && !uow.Users.Query().Any(u => u.Id != userId && u.Active && u.Role == UserRole.Admin))
					throw new InvalidOperationException("Relay needs at least one active Admin.");

				user.Active = active;
				user.UpdatedAt = DateTime.Now;
				uow.Save();
			}
		}

		#endregion

		#region Stages

		/// <summary>The pipeline stages in their order, with the number of deals in each.</summary>
		public static List<StageRow> Stages()
		{
			using (var uow = Store.Open())
			{
				var counts = uow.Deals.Query().GroupBy(d => d.StageId).Select(g => new { Id = g.Key, Count = g.Count() }).ToList();
				var stages = uow.Stages.Query()
					.OrderBy(s => s.Order)
					.Select(s => new StageRow { Id = s.Id, Order = s.Order, Name = s.Name, Probability = s.Probability, IsWon = s.IsWon, IsLost = s.IsLost })
					.ToList();
				foreach (var s in stages)
					s.Deals = counts.FirstOrDefault(c => c.Id == s.Id)?.Count ?? 0;
				return stages;
			}
		}

		/// <summary>
		/// Saves names, probabilities and the order of the stages (in the order of the list; Won and Lost stay last).
		/// Open deals of a stage whose probability changed get the new probability. Returns the number of deals updated.
		/// </summary>
		public static int SaveStages(IList<StageRow> rows)
		{
			RequireEditor();
			foreach (var row in rows)
			{
				if (string.IsNullOrWhiteSpace(row.Name))
					throw new InvalidOperationException("Every stage needs a name.");
				if (row.Probability < 0 || row.Probability > 100)
					throw new InvalidOperationException($"The probability of \"{row.Name}\" must be between 0 and 100.");
			}
			if (rows.Select(r => r.Name.Trim().ToLowerInvariant()).Distinct().Count() != rows.Count)
				throw new InvalidOperationException("Two stages have the same name.");

			// open stages first in the given order, then Won, then Lost.
			var ordered = rows.Where(r => !r.IsClosed)
				.Concat(rows.Where(r => r.IsWon))
				.Concat(rows.Where(r => r.IsLost && !r.IsWon))
				.ToList();

			var updatedDeals = 0;
			using (var uow = Store.Open())
			{
				var stages = uow.Stages.Query(tracking: true).ToList();
				var changedProbability = new Dictionary<int, int>();

				for (var i = 0; i < ordered.Count; i++)
				{
					var row = ordered[i];
					var stage = stages.FirstOrDefault(s => s.Id == row.Id);
					if (stage == null)
						continue;

					if (stage.Probability != row.Probability && !stage.IsWon && !stage.IsLost)
						changedProbability[stage.Id] = row.Probability;

					stage.Name = row.Name.Trim();
					stage.Probability = row.Probability;
					stage.Order = i + 1;
					stage.UpdatedAt = DateTime.Now;
					row.Order = i + 1;
				}

				if (changedProbability.Count > 0)
				{
					var ids = changedProbability.Keys.ToList();
					var deals = uow.Deals.Query(tracking: true).Where(d => ids.Contains(d.StageId) && d.ClosedDate == null).ToList();
					foreach (var deal in deals)
					{
						deal.Probability = changedProbability[deal.StageId];
						deal.UpdatedAt = DateTime.Now;
					}
					updatedDeals = deals.Count;
				}

				uow.Save();
			}
			return updatedDeals;
		}

		#endregion

		#region Tags

		/// <summary>The tags with the number of companies and contacts that use them.</summary>
		public static List<TagRow> Tags()
		{
			using (var uow = Store.Open())
			{
				var tags = uow.Tags.Query().OrderBy(t => t.Name).Select(t => new TagRow { Id = t.Id, Name = t.Name }).ToList();
				var companyTags = uow.Companies.Query().Where(c => c.Tags != null && c.Tags != "").Select(c => c.Tags).ToList().SelectMany(Text.Tags).ToList();
				var contactTags = uow.Contacts.Query().Where(c => c.Tags != null && c.Tags != "").Select(c => c.Tags).ToList().SelectMany(Text.Tags).ToList();

				foreach (var tag in tags)
				{
					tag.Companies = companyTags.Count(t => string.Equals(t, tag.Name, StringComparison.OrdinalIgnoreCase));
					tag.Contacts = contactTags.Count(t => string.Equals(t, tag.Name, StringComparison.OrdinalIgnoreCase));
				}
				return tags;
			}
		}

		/// <summary>Adds a tag; the name must be unique (ignoring case).</summary>
		public static void AddTag(string name)
		{
			RequireEditor();
			name = (name ?? "").Trim();
			if (name.Length == 0)
				throw new InvalidOperationException("Enter a tag name.");
			if (name.Contains(","))
				throw new InvalidOperationException("A tag cannot contain a comma.");

			var lower = name.ToLowerInvariant();
			using (var uow = Store.Open())
			{
				if (uow.Tags.Query().Any(t => t.Name.ToLower() == lower))
					throw new InvalidOperationException($"The tag \"{name}\" already exists.");

				uow.Tags.Add(new Tag { Name = name, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now });
				uow.Save();
			}
		}

		/// <summary>Removes a tag and takes it off every company and contact.</summary>
		public static void RemoveTag(int tagId)
		{
			RequireEditor();
			using (var uow = Store.Open())
			{
				var tag = uow.Tags.Query(tracking: true).FirstOrDefault(t => t.Id == tagId);
				if (tag == null)
					return;

				var name = tag.Name;
				foreach (var company in uow.Companies.Query(tracking: true).Where(c => c.Tags != null && c.Tags.Contains(name)).ToList())
				{
					var tags = RemoveFromList(company.Tags, name);
					if (tags != company.Tags)
					{
						company.Tags = tags;
						company.UpdatedAt = DateTime.Now;
					}
				}
				foreach (var contact in uow.Contacts.Query(tracking: true).Where(c => c.Tags != null && c.Tags.Contains(name)).ToList())
				{
					var tags = RemoveFromList(contact.Tags, name);
					if (tags != contact.Tags)
					{
						contact.Tags = tags;
						contact.UpdatedAt = DateTime.Now;
					}
				}

				uow.Tags.Remove(tag);
				uow.Save();
			}
		}

		private static string RemoveFromList(string tags, string name)
		{
			var list = Text.Tags(tags);
			var kept = list.Where(t => !string.Equals(t, name, StringComparison.OrdinalIgnoreCase)).ToArray();
			return kept.Length == list.Length ? tags : string.Join(", ", kept);
		}

		#endregion

		#region Profile

		/// <summary>Saves the name, email and avatar colour of the signed in user.</summary>
		public static void SaveProfile(string name, string email, string avatarColor)
		{
			name = (name ?? "").Trim();
			if (name.Length == 0)
				throw new InvalidOperationException("Enter your name.");
			var error = ValidateEmail(email, CurrentUser.Id);
			if (error != null)
				throw new InvalidOperationException(error);
			if (!AvatarPalette.Contains(avatarColor))
				avatarColor = AvatarPalette[0];

			using (var uow = Store.Open())
			{
				var user = uow.Users.Query(tracking: true).First(u => u.Id == CurrentUser.Id);
				user.Name = name;
				user.Email = email.Trim();
				user.AvatarColor = avatarColor;
				user.UpdatedAt = DateTime.Now;
				uow.Save();
			}
			CurrentUser.Refresh();
		}

		#endregion

		/// <summary>Deletes all data and seeds the demo data again.</summary>
		public static void ResetDemoData()
		{
			if (!CurrentUser.IsAdmin)
				throw new InvalidOperationException("Only Admins can reset the demo data.");
			DbSeeder.Reset();
		}

		/// <summary>
		/// A round avatar picture with the initials of <paramref name="name"/> on <paramref name="color"/>, as an SVG data URL.
		/// </summary>
		public static string AvatarImage(string name, string color)
		{
			if (string.IsNullOrEmpty(color) || color[0] != '#')
				color = AvatarPalette[0];
			var initials = System.Net.WebUtility.HtmlEncode(Text.Initials(name));
			var svg = "<svg xmlns='http://www.w3.org/2000/svg' width='64' height='64' viewBox='0 0 64 64'>"
				+ $"<circle cx='32' cy='32' r='32' fill='{color}'/>"
				+ "<text x='32' y='33' dominant-baseline='middle' text-anchor='middle' font-family='Segoe UI,Arial,sans-serif' font-size='24' font-weight='600' fill='#FFFFFF'>"
				+ initials + "</text></svg>";
			return "data:image/svg+xml;base64," + Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(svg));
		}

		private static bool IsValidEmail(string email)
		{
			var at = email.IndexOf('@');
			return at > 0 && at == email.LastIndexOf('@') && email.IndexOf('.', at) > at + 1
				&& !email.EndsWith(".") && !email.Contains(" ");
		}

		private static void RequireAdmin()
		{
			if (!CanManageUsers)
				throw new InvalidOperationException("Only Admins can change users and roles.");
		}

		private static void RequireEditor()
		{
			if (!CanEditSettings)
				throw new InvalidOperationException("Only Managers and Admins can change the settings.");
		}
	}
}
