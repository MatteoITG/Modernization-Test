using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Data;

namespace RelayCrm.Services
{
	public enum SearchKind { Page, Contact, Company, Deal }

	/// <summary>One result of the global search (Ctrl+K).</summary>
	public class SearchResult
	{
		public SearchKind Kind { get; set; }
		public int Id { get; set; }
		/// <summary>For pages: the view class name (DashboardView, ...).</summary>
		public string Target { get; set; }
		public string Text { get; set; }
		public string Description { get; set; }
		public string Icon { get; set; }
	}

	/// <summary>
	/// Global search over pages, contacts, companies and deals.
	/// </summary>
	public static class SearchService
	{
		

		public static readonly (string Text, string Target, string Icon)[] Pages =
		{
			("Dashboard", "DashboardView", "speedometer2"),
			("Contacts", "ContactsView", "person"),
			("Companies", "CompaniesView", "building"),
			("Deals", "DealsView", "briefcase"),
			("Activities", "ActivitiesView", "calendar-event"),
			("Tasks", "TasksView", "check2-square"),
			("Reports", "ReportsView", "bar-chart"),
			("Settings", "SettingsView", "gear"),
		};

		public static List<SearchResult> Search(string query, int max = 20)
		{
			query = (query ?? "").Trim();
			var results = new List<SearchResult>();

			results.AddRange(Pages
				.Where(p => query.Length == 0 || Text.Has(p.Text, query))
				.Select(p => new SearchResult { Kind = SearchKind.Page, Target = p.Target, Text = p.Text, Description = "Go to page", Icon = Icons.Get(p.Icon) }));

			if (query.Length < 2)
				return results;

			using (var uow = Store.Open())
			{
				var q = query.ToLower();

				results.AddRange(uow.Contacts.Query()
					.Where(c => (c.FirstName + " " + c.LastName).ToLower().Contains(q) || c.Email.ToLower().Contains(q))
					.OrderBy(c => c.FirstName).Take(8)
					.Select(c => new { c.Id, Name = c.FirstName + " " + c.LastName, c.Title, Company = c.Company.Name })
					.AsEnumerable()
					.Select(c => new SearchResult { Kind = SearchKind.Contact, Id = c.Id, Text = c.Name, Description = "Contact · " + c.Title + (c.Company != null ? " at " + c.Company : ""), Icon = Icons.Get("person") }));

				results.AddRange(uow.Companies.Query()
					.Where(c => c.Name.ToLower().Contains(q))
					.OrderBy(c => c.Name).Take(6)
					.Select(c => new { c.Id, c.Name, c.Industry, c.City })
					.AsEnumerable()
					.Select(c => new SearchResult { Kind = SearchKind.Company, Id = c.Id, Text = c.Name, Description = "Company · " + c.Industry + " · " + c.City, Icon = Icons.Get("building") }));

				results.AddRange(uow.Deals.Query()
					.Where(d => d.Title.ToLower().Contains(q))
					.OrderByDescending(d => d.ExpectedCloseDate).Take(6)
					.Select(d => new { d.Id, d.Title, d.Amount, Stage = d.Stage.Name })
					.AsEnumerable()
					.Select(d => new SearchResult { Kind = SearchKind.Deal, Id = d.Id, Text = d.Title, Description = "Deal · " + d.Stage + " · " + Fmt.Money(d.Amount), Icon = Icons.Get("briefcase") }));
			}

			return results.Take(max).ToList();
		}
	}
}
