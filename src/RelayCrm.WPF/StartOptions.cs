using System;

namespace RelayCrm
{
	/// <summary>
	/// Command line switches of the development build.
	/// </summary>
	/// <remarks>
	/// --user=1 signs in without the dialog, --page=DealsView opens a page,
	/// --contact=5, --company=5 or --deal=5 open that record.
	/// </remarks>
	public class StartOptions
	{
		public int? UserId { get; set; }
		public string Page { get; set; }
		public int? ContactId { get; set; }
		public int? CompanyId { get; set; }
		public int? DealId { get; set; }

		public static StartOptions Parse(string[] args)
		{
			var options = new StartOptions();
			foreach (var arg in args ?? new string[0])
			{
				var parts = arg.TrimStart('-', '/').Split(new[] { '=' }, 2);
				if (parts.Length != 2)
					continue;

				var value = parts[1];
				int.TryParse(value, out var id);
				switch (parts[0].ToLowerInvariant())
				{
					case "user": options.UserId = id > 0 ? id : (int?)null; break;
					case "page": options.Page = value; break;
					case "contact": options.ContactId = id > 0 ? id : (int?)null; break;
					case "company": options.CompanyId = id > 0 ? id : (int?)null; break;
					case "deal": options.DealId = id > 0 ? id : (int?)null; break;
				}
			}
			return options;
		}
	}
}
