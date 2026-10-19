using System;

namespace RelayCrm.Services
{
	/// <summary>
	/// Filter of the deals list and board. Also used by the dashboard to drill down into the deals it summarizes.
	/// </summary>
	public class DealFilter
	{
		public string Search { get; set; }
		public int? OwnerId { get; set; }
		public int? StageId { get; set; }
		public DateTime? CloseFrom { get; set; }
		public DateTime? CloseTo { get; set; }
		public decimal? AmountMin { get; set; }
		public decimal? AmountMax { get; set; }
		/// <summary>Only deals that are neither won nor lost.</summary>
		public bool OpenOnly { get; set; }
		/// <summary>Only won deals.</summary>
		public bool WonOnly { get; set; }
		/// <summary>Short text describing the drill-down, shown above the list ("Won in March 2026").</summary>
		public string Caption { get; set; }
	}

	/// <summary>
	/// Quick filters of the contacts list.
	/// </summary>
	public enum ContactQuickFilter { All, Leads, Prospects, Customers, Mine }
}
