using System;
using System.Collections.Generic;
using System.Linq;

namespace RelayCrm.Data
{
	/// <summary>
	/// Creates the database and fills it with clearly fictional sample data when it is empty.
	/// </summary>
	public static class DbSeeder
	{
		private static readonly object SyncRoot = new object();
		private static bool ready;

		/// <summary>
		/// Creates and seeds the database once per process.
		/// </summary>
		public static void EnsureReady()
		{
			lock (SyncRoot)
			{
				if (ready)
					return;

				using (var db = new RelayDbContext())
				{
					db.Database.EnsureCreated();
					if (!db.Users.Any())
						Seed(db);
				}
				ready = true;
			}
		}

		/// <summary>
		/// Deletes all data and seeds it again ("Reset demo data").
		/// </summary>
		public static void Reset()
		{
			lock (SyncRoot)
			{
				using (var db = new RelayDbContext())
				{
					db.Database.EnsureDeleted();
					db.Database.EnsureCreated();
					Seed(db);
				}
				ready = true;
			}
		}

		private static readonly string[] FirstNames = {
			"Ava", "Liam", "Mia", "Noah", "Zoe", "Ethan", "Lena", "Oscar", "Nora", "Hugo", "Iris", "Felix",
			"Clara", "Mateo", "Elena", "Jonas", "Sofia", "Lucas", "Maya", "Leo", "Aria", "Theo", "Hanna", "Milo",
			"Lucia", "Emil", "Freya", "Adam", "Ines", "Kai", "Rosa", "Finn", "Yara", "Owen", "Alma", "Ravi" };

		private static readonly string[] LastNames = {
			"Hartley", "Moreno", "Lindqvist", "Okafor", "Brandt", "Castillo", "Novak", "Fischer", "Bianchi",
			"Dubois", "Kowalski", "Tanaka", "Andersen", "Ricci", "Weber", "Laurent", "Silva", "Kaur", "Nguyen",
			"Hoffmann", "Romero", "Petrov", "Jansen", "Costa", "Murphy", "Schulz", "Rossi", "Keller", "Varga" };

		private static readonly string[] CompanyPrefixes = {
			"Northwind", "Bluepeak", "Ironleaf", "Silverline", "Brightwave", "Cobalt", "Evergreen", "Fjord",
			"Granite", "Harbor", "Juniper", "Kestrel", "Lumen", "Maple", "Nimbus", "Orchid", "Pinecrest",
			"Quartz", "Redwood", "Summit" };

		private static readonly string[] CompanySuffixes = { "Labs", "Systems", "Logistics", "Health", "Foods", "Energy", "Analytics", "Studio" };

		private static readonly string[] Industries = { "Software", "Manufacturing", "Healthcare", "Retail", "Logistics", "Energy", "Finance", "Education" };

		private static readonly string[] Sizes = { "1-10", "11-50", "51-200", "201-500", "501-1000", "1000+" };

		private static readonly (string Country, string[] Cities)[] Places = {
			("United States", new[] { "Austin", "Denver", "Boston", "Seattle" }),
			("Germany", new[] { "Berlin", "Munich", "Hamburg" }),
			("United Kingdom", new[] { "London", "Manchester", "Leeds" }),
			("France", new[] { "Paris", "Lyon" }),
			("Italy", new[] { "Milan", "Turin" }),
			("Netherlands", new[] { "Amsterdam", "Utrecht" }),
			("Spain", new[] { "Madrid", "Valencia" }),
			("Canada", new[] { "Toronto", "Vancouver" }) };

		private static readonly string[] Titles = {
			"CEO", "CTO", "CFO", "VP Sales", "Head of Operations", "Procurement Manager", "IT Director",
			"Marketing Lead", "Product Manager", "Office Manager", "Engineering Manager", "Buyer" };

		private static readonly string[] LeadSources = { "Website", "Referral", "Event", "Cold outreach", "Partner", "Webinar" };

		private static readonly string[] TagNames = { "VIP", "Partner", "Enterprise", "SMB", "Renewal", "Newsletter", "Trial" };

		private static readonly string[] DealProducts = {
			"Platform license", "Annual renewal", "Onboarding package", "Data migration", "Premium support",
			"Analytics add-on", "Team expansion", "Pilot project", "Integration services", "Training program" };

		private static readonly string[] LostReasons = { "Price too high", "Chose a competitor", "No budget", "No decision", "Timing" };

		private static readonly string[] CallSubjects = { "Discovery call", "Follow-up call", "Pricing discussion", "Check-in call", "Renewal call" };
		private static readonly string[] EmailSubjects = { "Sent proposal", "Shared case study", "Meeting recap", "Pricing details", "Contract draft" };
		private static readonly string[] MeetingSubjects = { "Product demo", "Kick-off meeting", "Quarterly review", "Workshop", "Negotiation meeting" };
		private static readonly string[] NoteSubjects = { "Budget confirmed", "Decision maker identified", "Competitor in the loop", "Needs security review", "Champion on board" };

		private static readonly string[] TaskTitles = {
			"Send follow-up email", "Prepare proposal", "Schedule demo", "Call back about pricing", "Update contract",
			"Share case study", "Book quarterly review", "Confirm budget", "Send onboarding plan", "Check renewal date" };

		private static void Seed(RelayDbContext db)
		{
			var rnd = new Random(20261015);
			var today = DateTime.Today;
			T Pick<T>(IList<T> list) => list[rnd.Next(list.Count)];

			// Users
			var users = new List<User>
			{
				new User { Name = "Morgan Price", Email = "morgan.price@example.com", Role = UserRole.Admin, AvatarColor = "#4F46E5" },
				new User { Name = "Dana Whitfield", Email = "dana.whitfield@example.com", Role = UserRole.Manager, AvatarColor = "#0EA5E9" },
				new User { Name = "Sam Okoro", Email = "sam.okoro@example.com", Role = UserRole.Sales, AvatarColor = "#10B981" },
				new User { Name = "Riley Chen", Email = "riley.chen@example.com", Role = UserRole.Sales, AvatarColor = "#F59E0B" },
				new User { Name = "Jamie Novak", Email = "jamie.novak@example.com", Role = UserRole.Sales, AvatarColor = "#EC4899" },
				new User { Name = "Alex Moreau", Email = "alex.moreau@example.com", Role = UserRole.Sales, AvatarColor = "#8B5CF6", Active = false },
			};
			db.Users.AddRange(users);

			foreach (var t in TagNames)
				db.Tags.Add(new Tag { Name = t });

			// Companies
			var companies = new List<Company>();
			var usedNames = new HashSet<string>();
			while (companies.Count < 40)
			{
				var name = Pick(CompanyPrefixes) + " " + Pick(CompanySuffixes);
				if (!usedNames.Add(name))
					continue;
				var place = Pick(Places);
				var domain = name.ToLowerInvariant().Replace(" ", "") + ".example.com";
				companies.Add(new Company
				{
					Name = name,
					Industry = Pick(Industries),
					Size = Pick(Sizes),
					Website = "https://www." + domain,
					Phone = "+1 555 01" + rnd.Next(10, 99),
					Address = rnd.Next(1, 300) + " Market Street",
					Country = place.Country,
					City = Pick(place.Cities),
					AnnualRevenue = rnd.Next(5, 900) * 100000m,
					Tags = string.Join(",", Enumerable.Range(0, rnd.Next(0, 3)).Select(i => Pick(TagNames)).Distinct()),
					Owner = Pick(users.Take(5).ToList()),
					CreatedAt = today.AddDays(-rnd.Next(60, 720)),
				});
			}
			db.Companies.AddRange(companies);

			// Contacts
			var contacts = new List<Contact>();
			var stages = new[] { LifecycleStage.Lead, LifecycleStage.Lead, LifecycleStage.Prospect, LifecycleStage.Prospect, LifecycleStage.Customer, LifecycleStage.Customer, LifecycleStage.Customer, LifecycleStage.Churned };
			for (int i = 0; i < 150; i++)
			{
				var first = Pick(FirstNames);
				var last = Pick(LastNames);
				var company = companies[i % companies.Count];
				var domain = company.Name.ToLowerInvariant().Replace(" ", "") + ".example.com";
				contacts.Add(new Contact
				{
					FirstName = first,
					LastName = last,
					Title = Pick(Titles),
					Email = (first + "." + last + (i >= 100 ? i.ToString() : "")).ToLowerInvariant() + "@" + domain,
					Phone = "+1 555 02" + rnd.Next(10, 99),
					Company = company,
					Stage = Pick(stages),
					LeadSource = Pick(LeadSources),
					Tags = string.Join(",", Enumerable.Range(0, rnd.Next(0, 3)).Select(n => Pick(TagNames)).Distinct()),
					Owner = company.Owner,
					LastContacted = rnd.Next(10) < 8 ? today.AddDays(-rnd.Next(0, 120)).AddHours(rnd.Next(8, 18)) : (DateTime?)null,
					CreatedAt = today.AddDays(-rnd.Next(10, 600)),
				});
			}
			db.Contacts.AddRange(contacts);

			// Pipeline and stages
			var pipeline = new Pipeline { Name = "Sales pipeline" };
			db.Pipelines.Add(pipeline);
			var stageList = new List<Stage>
			{
				new Stage { Pipeline = pipeline, Name = "Qualification", Order = 1, Probability = 10 },
				new Stage { Pipeline = pipeline, Name = "Discovery", Order = 2, Probability = 25 },
				new Stage { Pipeline = pipeline, Name = "Proposal", Order = 3, Probability = 50 },
				new Stage { Pipeline = pipeline, Name = "Negotiation", Order = 4, Probability = 75 },
				new Stage { Pipeline = pipeline, Name = "Won", Order = 5, Probability = 100, IsWon = true },
				new Stage { Pipeline = pipeline, Name = "Lost", Order = 6, Probability = 0, IsLost = true },
			};
			db.Stages.AddRange(stageList);

			// Deals: spread over the last 12 months and the next 3
			var deals = new List<Deal>();
			for (int i = 0; i < 80; i++)
			{
				var company = Pick(companies);
				var contact = contacts.Where(c => c.Company == company).DefaultIfEmpty(Pick(contacts)).First();
				// 36 open deals closing between three weeks ago (overdue) and the next 3 months,
				// 44 closed deals (won or lost) over the last 12 months up to yesterday.
				var open = i < 36;
				var close = open ? today.AddDays(rnd.Next(-20, 92)) : today.AddDays(rnd.Next(-365, 0));
				var stage = open
					? stageList[rnd.Next(0, 4)]
					: (rnd.Next(10) < 6 ? stageList[4] : stageList[5]);

				var deal = new Deal
				{
					Title = company.Name + " – " + Pick(DealProducts),
					Company = company,
					PrimaryContact = contact,
					Amount = rnd.Next(4, 120) * 1000m,
					Stage = stage,
					ExpectedCloseDate = close,
					Probability = stage.Probability,
					Owner = company.Owner,
					CreatedAt = close.AddDays(-rnd.Next(20, 120)),
					BoardOrder = i,
				};
				if (stage.IsWon || stage.IsLost)
					deal.ClosedDate = close;
				if (stage.IsLost)
					deal.LostReason = Pick(LostReasons);
				deals.Add(deal);
			}
			db.Deals.AddRange(deals);

			// Activities
			for (int i = 0; i < 400; i++)
			{
				var type = (ActivityType)rnd.Next(4);
				var deal = rnd.Next(10) < 6 ? Pick(deals) : null;
				var contact = deal?.PrimaryContact ?? Pick(contacts);
				var date = today.AddDays(-rnd.Next(0, 365)).AddHours(rnd.Next(8, 18)).AddMinutes(rnd.Next(0, 4) * 15);
				if (type == ActivityType.Meeting || type == ActivityType.Call)
				{
					// some meetings and calls are planned in the next weeks, so the calendar has a future.
					if (rnd.Next(10) < 3)
						date = today.AddDays(rnd.Next(0, 30)).AddHours(rnd.Next(8, 18)).AddMinutes(rnd.Next(0, 4) * 15);
				}
				string subject;
				switch (type)
				{
					case ActivityType.Call: subject = Pick(CallSubjects); break;
					case ActivityType.Email: subject = Pick(EmailSubjects); break;
					case ActivityType.Meeting: subject = Pick(MeetingSubjects); break;
					default: subject = Pick(NoteSubjects); break;
				}
				db.Activities.Add(new Activity
				{
					Type = type,
					Subject = subject,
					Body = subject + " with " + contact.FullName + ".",
					Date = date,
					Duration = type == ActivityType.Meeting ? 60 : type == ActivityType.Call ? 30 : 0,
					Contact = contact,
					Company = contact.Company,
					Deal = deal,
					User = deal?.Owner ?? contact.Owner,
				});
			}

			// Tasks (some overdue)
			for (int i = 0; i < 120; i++)
			{
				var deal = rnd.Next(10) < 5 ? Pick(deals) : null;
				var contact = deal?.PrimaryContact ?? Pick(contacts);
				var due = today.AddDays(rnd.Next(-20, 30));
				db.Tasks.Add(new CrmTask
				{
					Title = Pick(TaskTitles),
					DueDate = due,
					Priority = (TaskPriority)rnd.Next(3),
					Status = due < today && rnd.Next(10) < 6 ? CrmTaskStatus.Done : (rnd.Next(10) < 2 ? CrmTaskStatus.Done : CrmTaskStatus.Open),
					Contact = contact,
					Company = contact.Company,
					Deal = deal,
					Assignee = Pick(users.Take(5).ToList()),
				});
			}

			db.SaveChanges();
		}
	}
}
