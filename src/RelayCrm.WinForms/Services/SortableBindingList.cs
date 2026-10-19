using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace RelayCrm.Services
{
	/// <summary>
	/// A binding list that sorts by any property, so that a DataGridView bound to it sorts when a column header is clicked.
	/// </summary>
	public class SortableBindingList<T> : BindingList<T>
	{
		private bool sorted;
		private PropertyDescriptor sortProperty;
		private ListSortDirection sortDirection;

		public SortableBindingList()
		{
		}

		public SortableBindingList(IEnumerable<T> items)
			: base(items.ToList())
		{
		}

		protected override bool SupportsSortingCore => true;

		protected override bool IsSortedCore => this.sorted;

		protected override PropertyDescriptor SortPropertyCore => this.sortProperty;

		protected override ListSortDirection SortDirectionCore => this.sortDirection;

		protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
		{
			if (!(this.Items is List<T> items))
				return;

			// sorting by a text column sorts by the value it shows: compare null as the smallest.
			Comparison<T> compare = (a, b) => CompareValues(property.GetValue(a), property.GetValue(b));
			items.Sort(direction == ListSortDirection.Ascending ? compare : (a, b) => compare(b, a));

			this.sortProperty = property;
			this.sortDirection = direction;
			this.sorted = true;
			OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
		}

		protected override void RemoveSortCore()
		{
			this.sorted = false;
			this.sortProperty = null;
		}

		private static int CompareValues(object a, object b)
		{
			if (a == null)
				return b == null ? 0 : -1;
			if (b == null)
				return 1;
			if (a is string sa && b is string sb)
				return string.Compare(sa, sb, StringComparison.CurrentCultureIgnoreCase);
			if (a is IComparable ca)
				return ca.CompareTo(b);
			if (a is double[] da && b is double[] db)
				return da.Sum().CompareTo(db.Sum());
			return string.Compare(a.ToString(), b.ToString(), StringComparison.CurrentCultureIgnoreCase);
		}
	}
}
