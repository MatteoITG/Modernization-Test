using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace RelayCrm.Services
{
	/// <summary>Kind of value of a filter field: decides the operators and the value editor.</summary>
	public enum FilterFieldType { Text, Number, Date, Choice }

	/// <summary>Comparison of a filter rule.</summary>
	public enum FilterOperator
	{
		Contains,
		StartsWith,
		Equal,
		NotEqual,
		GreaterThan,
		GreaterThanOrEqual,
		LessThan,
		LessThanOrEqual,
		IsEmpty,
		IsNotEmpty,
	}

	/// <summary>A field the advanced filter offers; <see cref="Name"/> is the property name of the rows.</summary>
	public class FilterField
	{
		public FilterField(string name, string caption, FilterFieldType type, string[] choices = null)
		{
			this.Name = name;
			this.Caption = caption;
			this.Type = type;
			this.Choices = choices ?? new string[0];
		}

		public string Name { get; }
		public string Caption { get; }
		public FilterFieldType Type { get; }
		public string[] Choices { get; }

		public override string ToString() => this.Caption;
	}

	/// <summary>One condition of the advanced filter: field, operator and value.</summary>
	public class FilterRule
	{
		public FilterField Field { get; set; }
		public FilterOperator Operator { get; set; }
		/// <summary>The value as typed; dates and numbers in the invariant culture.</summary>
		public string Value { get; set; }

		public override string ToString()
		{
			var op = QueryFilter.OperatorText(this.Operator);
			return this.Operator == FilterOperator.IsEmpty || this.Operator == FilterOperator.IsNotEmpty
				? this.Field.Caption + " " + op
				: this.Field.Caption + " " + op + " \"" + this.Value + "\"";
		}
	}

	/// <summary>The rules of the advanced filter and how they combine.</summary>
	public class FilterQuery
	{
		public List<FilterRule> Rules { get; } = new List<FilterRule>();

		/// <summary>True: every rule must match; false: any rule.</summary>
		public bool MatchAll { get; set; } = true;

		public bool IsEmpty => this.Rules.Count == 0;

		public override string ToString()
		{
			return string.Join(this.MatchAll ? " and " : " or ", this.Rules);
		}
	}

	/// <summary>
	/// Applies the rules of the advanced filter dialog to a list of row objects.
	/// The field names are the property names of the rows.
	/// </summary>
	public static class QueryFilter
	{
		public static IEnumerable<T> Apply<T>(IEnumerable<T> rows, FilterQuery query)
		{
			if (IsEmpty(query))
				return rows;
			return rows.Where(r => Matches(r, query));
		}

		public static bool IsEmpty(FilterQuery query)
		{
			return query == null || query.IsEmpty;
		}

		/// <summary>The operators that make sense for a field type.</summary>
		public static FilterOperator[] OperatorsFor(FilterFieldType type)
		{
			switch (type)
			{
				case FilterFieldType.Number:
				case FilterFieldType.Date:
					return new[] {
						FilterOperator.Equal, FilterOperator.NotEqual, FilterOperator.GreaterThan, FilterOperator.GreaterThanOrEqual,
						FilterOperator.LessThan, FilterOperator.LessThanOrEqual, FilterOperator.IsEmpty, FilterOperator.IsNotEmpty };
				case FilterFieldType.Choice:
					return new[] { FilterOperator.Equal, FilterOperator.NotEqual, FilterOperator.IsEmpty, FilterOperator.IsNotEmpty };
				default:
					return new[] {
						FilterOperator.Contains, FilterOperator.StartsWith, FilterOperator.Equal, FilterOperator.NotEqual,
						FilterOperator.IsEmpty, FilterOperator.IsNotEmpty };
			}
		}

		public static string OperatorText(FilterOperator op)
		{
			switch (op)
			{
				case FilterOperator.Contains: return "contains";
				case FilterOperator.StartsWith: return "starts with";
				case FilterOperator.Equal: return "is";
				case FilterOperator.NotEqual: return "is not";
				case FilterOperator.GreaterThan: return "is greater than";
				case FilterOperator.GreaterThanOrEqual: return "is at least";
				case FilterOperator.LessThan: return "is less than";
				case FilterOperator.LessThanOrEqual: return "is at most";
				case FilterOperator.IsEmpty: return "is empty";
				default: return "is not empty";
			}
		}

		private static bool Matches(object row, FilterQuery query)
		{
			var results = query.Rules.Select(rule => Matches(row, rule));
			return query.MatchAll ? results.All(x => x) : results.Any(x => x);
		}

		private static bool Matches(object row, FilterRule rule)
		{
			if (rule.Field == null)
				return true;

			var prop = row.GetType().GetProperty(rule.Field.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
			if (prop == null)
				return true;

			var value = prop.GetValue(row);
			var text = Convert.ToString(value, CultureInfo.InvariantCulture) ?? "";
			var target = rule.Value ?? "";

			switch (rule.Operator)
			{
				case FilterOperator.IsEmpty: return string.IsNullOrEmpty(text);
				case FilterOperator.IsNotEmpty: return !string.IsNullOrEmpty(text);
				case FilterOperator.Contains: return Text.Has(text, target);
				case FilterOperator.StartsWith: return text.StartsWith(target, StringComparison.OrdinalIgnoreCase);
				case FilterOperator.Equal: return Compare(value, target) == 0;
				case FilterOperator.NotEqual: return Compare(value, target) != 0;
				case FilterOperator.GreaterThan: return Compare(value, target) > 0;
				case FilterOperator.GreaterThanOrEqual: return Compare(value, target) >= 0;
				case FilterOperator.LessThan: return Compare(value, target) < 0;
				case FilterOperator.LessThanOrEqual: return Compare(value, target) <= 0;
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
