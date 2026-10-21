using System;
using System.Collections.Specialized;

namespace RelayCrm
{
	/// <summary>
	/// URL arguments of the development build (the command line switches of the WPF app).
	/// </summary>
	/// <remarks>
	/// ?user=1 signs in without the dialog, ?page=DealsView opens a page,
	/// ?contact=5, ?company=5 or ?deal=5 open that record.
	/// </remarks>
	public class StartOptions
	{
		public int? UserId { get; set; }
		public string Page { get; set; }
		public int? ContactId { get; set; }
		public int? CompanyId { get; set; }
		public int? DealId { get; set; }

		public static StartOptions Parse(NameValueCollection args)
		{
			var options = new StartOptions();
			foreach (var key in args?.AllKeys ?? new string[0])
			{
				if (string.IsNullOrEmpty(key))
					continue;

				var value = args[key];
				int.TryParse(value, out var id);
				switch (key.ToLowerInvariant())
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
