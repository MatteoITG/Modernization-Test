using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using RelayCrm.Services;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Edits the rules of the advanced filter of a list (field, operator, value; all or any of them).
	/// The stock replacement of the Wisej QueryBuilder.
	/// </summary>
	public partial class AdvancedFilterDialog : Window
	{
		/// <summary>An operator with its text.</summary>
		public class OperatorItem
		{
			public FilterOperator Operator { get; set; }
			public string Text { get; set; }
		}

		/// <summary>A rule being edited.</summary>
		public class RuleRow : INotifyPropertyChanged
		{
			private FilterField field;
			private OperatorItem op;

			public RuleRow(IList<FilterField> fields)
			{
				this.Fields = fields;
			}

			public IList<FilterField> Fields { get; }

			public FilterField Field
			{
				get { return this.field; }
				set
				{
					this.field = value;
					this.Operators = value == null
						? new List<OperatorItem>()
						: QueryFilter.OperatorsFor(value.Type).Select(o => new OperatorItem { Operator = o, Text = QueryFilter.OperatorText(o) }).ToList();
					this.op = this.Operators.FirstOrDefault();
					Raise(nameof(this.Field));
					Raise(nameof(this.Operators));
					Raise(nameof(this.Operator));
					Raise(nameof(this.Choices));
					Raise(nameof(this.HasValue));
				}
			}

			public List<OperatorItem> Operators { get; private set; } = new List<OperatorItem>();

			public OperatorItem Operator
			{
				get { return this.op; }
				set
				{
					this.op = value;
					Raise(nameof(this.Operator));
					Raise(nameof(this.HasValue));
				}
			}

			public string[] Choices => this.field?.Choices ?? new string[0];

			public string Value { get; set; }

			/// <summary>False for "is empty" and "is not empty".</summary>
			public bool HasValue => this.op == null || (this.op.Operator != FilterOperator.IsEmpty && this.op.Operator != FilterOperator.IsNotEmpty);

			public event PropertyChangedEventHandler PropertyChanged;

			private void Raise(string name)
			{
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
			}
		}

		private readonly List<FilterField> fields;
		private readonly ObservableCollection<RuleRow> rules = new ObservableCollection<RuleRow>();

		public AdvancedFilterDialog(IEnumerable<FilterField> fields)
		{
			InitializeComponent();

			this.fields = fields.ToList();
			this.listRules.ItemsSource = this.rules;
		}

		/// <summary>The filter that was applied.</summary>
		public FilterQuery Query { get; private set; }

		/// <summary>
		/// Edits <paramref name="query"/>; returns the new filter (empty when cleared), or null when cancelled.
		/// </summary>
		public static FilterQuery Edit(IEnumerable<FilterField> fields, FilterQuery query)
		{
			var dialog = new AdvancedFilterDialog(fields);
			dialog.comboMatch.SelectedIndex = query == null || query.MatchAll ? 0 : 1;
			if (query != null)
			{
				foreach (var rule in query.Rules)
				{
					var row = new RuleRow(dialog.fields) { Field = dialog.fields.FirstOrDefault(f => f.Name == rule.Field.Name) ?? rule.Field };
					row.Operator = row.Operators.FirstOrDefault(o => o.Operator == rule.Operator) ?? row.Operators.FirstOrDefault();
					row.Value = rule.Value;
					dialog.rules.Add(row);
				}
			}
			if (dialog.rules.Count == 0)
				dialog.AddRule();

			return DialogHelper.ShowModal(dialog) ? dialog.Query : null;
		}

		private void AddRule()
		{
			this.rules.Add(new RuleRow(this.fields) { Field = this.fields.FirstOrDefault() });
		}

		private void buttonAdd_Click(object sender, RoutedEventArgs e)
		{
			AddRule();
		}

		private void buttonClear_Click(object sender, RoutedEventArgs e)
		{
			this.rules.Clear();
		}

		private void buttonRemove_Click(object sender, RoutedEventArgs e)
		{
			if (((FrameworkElement)sender).DataContext is RuleRow row)
				this.rules.Remove(row);
		}

		private void buttonApply_Click(object sender, RoutedEventArgs e)
		{
			var query = new FilterQuery { MatchAll = this.comboMatch.SelectedIndex != 1 };
			foreach (var row in this.rules.Where(r => r.Field != null && r.Operator != null))
			{
				// a condition without a value is skipped, unless it tests for an empty field.
				if (row.HasValue && string.IsNullOrWhiteSpace(row.Value))
					continue;
				query.Rules.Add(new FilterRule { Field = row.Field, Operator = row.Operator.Operator, Value = row.HasValue ? row.Value.Trim() : null });
			}

			this.Query = query;
			this.DialogResult = true;
		}
	}
}
