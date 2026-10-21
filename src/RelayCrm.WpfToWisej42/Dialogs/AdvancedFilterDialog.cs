using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Services;
using Wisej.Web;
// Wisej 4.2 has its own FilterField (QueryBuilder): the dialog maps the fields of the app to it.
using FilterField = RelayCrm.Services.FilterField;
using FilterFieldType = RelayCrm.Services.FilterFieldType;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Edits the rules of the advanced filter of a list (field, operator, value; all or any of them).
	/// </summary>
	/// <remarks>
	/// Migration step 2: step 1 built the XAML rule template (field, operator and value combo boxes, remove button)
	/// in code, one TableLayoutPanel per rule. The Wisej 4.2 QueryBuilder edits the rules in place, with the
	/// all/any switch and a preview of the expression. The result is the same <see cref="FilterQuery"/>, so the lists
	/// and <see cref="QueryFilter"/> are unchanged.
	/// </remarks>
	public partial class AdvancedFilterDialog : Form
	{
		private readonly List<FilterField> fields;

		public AdvancedFilterDialog(IEnumerable<FilterField> fields)
		{
			InitializeComponent();
			DialogHelper.KeepOpenOnAccept(this);

			this.fields = fields.ToList();
			foreach (var field in this.fields)
				this.queryBuilder.Fields.Add(new Wisej.Web.FilterField(field.Name, field.Caption, ToBuilder(field.Type), field.Choices));
		}

		/// <summary>The filter that was applied.</summary>
		public FilterQuery Query { get; private set; }

		/// <summary>
		/// Edits <paramref name="query"/>; returns the new filter (empty when cleared), or null when cancelled.
		/// </summary>
		public static FilterQuery Edit(IEnumerable<FilterField> fields, FilterQuery query)
		{
			var dialog = new AdvancedFilterDialog(fields);
			var root = dialog.queryBuilder.Root;
			root.Logic = query == null || query.MatchAll ? QueryLogic.And : QueryLogic.Or;
			if (query != null)
			{
				foreach (var rule in query.Rules)
					root.Rules.Add(new QueryRule(rule.Field.Name, ToBuilder(rule.Operator), rule.Value));
			}

			return DialogHelper.ShowModal(dialog) ? dialog.Query : null;
		}

		private static Wisej.Web.FilterFieldType ToBuilder(FilterFieldType type)
		{
			switch (type)
			{
				case FilterFieldType.Number: return Wisej.Web.FilterFieldType.Number;
				case FilterFieldType.Date: return Wisej.Web.FilterFieldType.Date;
				case FilterFieldType.Choice: return Wisej.Web.FilterFieldType.Choice;
				default: return Wisej.Web.FilterFieldType.Text;
			}
		}

		private static QueryOperator ToBuilder(FilterOperator op)
		{
			switch (op)
			{
				case FilterOperator.IsEmpty: return QueryOperator.IsNull;
				case FilterOperator.IsNotEmpty: return QueryOperator.IsNotNull;
				default: return (QueryOperator)Enum.Parse(typeof(QueryOperator), op.ToString());
			}
		}

		private static FilterOperator FromBuilder(QueryOperator op)
		{
			switch (op)
			{
				case QueryOperator.IsNull: return FilterOperator.IsEmpty;
				case QueryOperator.IsNotNull: return FilterOperator.IsNotEmpty;
				default: return (FilterOperator)Enum.Parse(typeof(FilterOperator), op.ToString());
			}
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			this.queryBuilder.Root.Rules.Clear();
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			var root = this.queryBuilder.Root;
			var query = new FilterQuery { MatchAll = root.Logic != QueryLogic.Or };
			foreach (var rule in root.Rules)
			{
				var field = this.fields.FirstOrDefault(f => f.Name == rule.Field);
				if (field == null)
					continue;

				// a condition without a value is skipped, unless it tests for an empty field (as in WPF).
				var op = FromBuilder(rule.Operator);
				var hasValue = op != FilterOperator.IsEmpty && op != FilterOperator.IsNotEmpty;
				if (hasValue && string.IsNullOrWhiteSpace(rule.Value))
					continue;
				query.Rules.Add(new FilterRule { Field = field, Operator = op, Value = hasValue ? rule.Value.Trim() : null });
			}

			this.Query = query;
			this.DialogResult = DialogResult.OK;
		}
	}
}
