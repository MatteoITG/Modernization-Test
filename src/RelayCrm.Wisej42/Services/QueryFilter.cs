using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Wisej.Web;

namespace RelayCrm.Services
{
	/// <summary>
	/// Applies the rules of a <see cref="QueryBuilder"/> to a list of row objects.
	/// The field names of the builder are the property names of the rows.
	/// </summary>
	public static class QueryFilter
	{
		public static IEnumerable<T> Apply<T>(IEnumerable<T> rows, QueryGroup root)
		{
			if (root == null || (root.Rules.Count == 0 && root.Groups.Count == 0))
				return rows;
			return rows.Where(r => Matches(r, root));
		}

		public static bool IsEmpty(QueryGroup root)
		{
			return root == null || (root.Rules.Count == 0 && root.Groups.All(IsEmpty));
		}

		private static bool Matches(object row, QueryGroup group)
		{
			var results = group.Rules.Select(rule => Matches(row, rule))
				.Concat(group.Groups.Where(g => !IsEmpty(g)).Select(g => Matches(row, g)))
				.ToList();
			if (results.Count == 0)
				return true;
			return group.Logic == QueryLogic.And ? results.All(x => x) : results.Any(x => x);
		}

		private static bool Matches(object row, QueryRule rule)
		{
			if (string.IsNullOrEmpty(rule.Field))
				return true;

			var prop = row.GetType().GetProperty(rule.Field, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
			if (prop == null)
				return true;

			var value = prop.GetValue(row);
			var text = Convert.ToString(value, CultureInfo.InvariantCulture) ?? "";
			var target = rule.Value ?? "";

			switch (rule.Operator)
			{
				case QueryOperator.IsNull: return string.IsNullOrEmpty(text);
				case QueryOperator.IsNotNull: return !string.IsNullOrEmpty(text);
				case QueryOperator.Contains: return Text.Has(text, target);
				case QueryOperator.StartsWith: return text.StartsWith(target, StringComparison.OrdinalIgnoreCase);
				case QueryOperator.Equal: return Compare(value, target) == 0;
				case QueryOperator.NotEqual: return Compare(value, target) != 0;
				case QueryOperator.GreaterThan: return Compare(value, target) > 0;
				case QueryOperator.GreaterThanOrEqual: return Compare(value, target) >= 0;
				case QueryOperator.LessThan: return Compare(value, target) < 0;
				case QueryOperator.LessThanOrEqual: return Compare(value, target) <= 0;
				default: return true;
			}
		}

		private static int Compare(object value, string target)
		{
			switch (value)
			{
				case null:
					return string.IsNullOrEmpty(target) ? 0 : -1;
				case DateTime d when DateTime.TryParse(target, CultureInfo.InvariantCulture, DateTimeStyles.None, out var td):
					return d.Date.CompareTo(td.Date);
				case bool b when bool.TryParse(target, out var tb):
					return b.CompareTo(tb);
				case decimal _:
				case double _:
				case float _:
				case int _:
				case long _:
					if (double.TryParse(target, NumberStyles.Any, CultureInfo.InvariantCulture, out var tn))
						return Convert.ToDouble(value, CultureInfo.InvariantCulture).CompareTo(tn);
					break;
			}
			return string.Compare(Convert.ToString(value, CultureInfo.InvariantCulture), target, StringComparison.OrdinalIgnoreCase);
		}
	}
}
