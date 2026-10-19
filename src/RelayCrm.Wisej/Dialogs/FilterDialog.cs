using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;
using RelayCrm.Services;
// Wisej 4.2 has its own FilterField (QueryBuilder): the dialog maps the fields of the app to it.
using FilterField = RelayCrm.Services.FilterField;
using FilterFieldType = RelayCrm.Services.FilterFieldType;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// The advanced filter of the lists: conditions of the form "field operator value",
	/// combined with "all" or "any". Applied by <see cref="QueryFilter"/>.
	/// </summary>
	/// <remarks>
	/// Migration step 2: the WinForms dialog built the conditions with combo boxes and a list box;
	/// the Wisej 4.2 QueryBuilder edits them in place. The filter the lists apply (FilterQuery) is unchanged.
	/// </remarks>
	public partial class FilterDialog : Form
	{
		public FilterDialog()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Edits the advanced filter; returns the new filter, or null when the user cancelled.
		/// </summary>
		/// <param name="fields">The fields that can be filtered.</param>
		/// <param name="current">The filter in use, or null.</param>
		public static FilterQuery Edit(IEnumerable<FilterField> fields, FilterQuery current)
		{
			using (var dialog = new FilterDialog())
			{
				var list = fields.ToList();
				foreach (var field in list)
					dialog.queryBuilder.Fields.Add(new Wisej.Web.FilterField(field.Name, field.Caption, ToBuilder(field.Type), field.Choices));

				var root = dialog.queryBuilder.Root;
				if (current != null)
				{
					root.Logic = current.MatchAll ? QueryLogic.And : QueryLogic.Or;
					foreach (var rule in current.Rules)
						root.Rules.Add(new QueryRule(rule.Field.Name, ToBuilder(rule.Operator), rule.Value));
				}

				if (dialog.ShowDialog(Form.ActiveForm) != DialogResult.OK)
					return null;

				root = dialog.queryBuilder.Root;
				var query = new FilterQuery { MatchAll = root.Logic == QueryLogic.And };
				foreach (var rule in root.Rules)
				{
					var field = list.FirstOrDefault(f => f.Name == rule.Field);
					if (field != null)
						query.Rules.Add(new FilterRule { Field = field, Operator = FromBuilder(rule.Operator), Value = rule.Value });
				}
				return query;
			}
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
	}
}
