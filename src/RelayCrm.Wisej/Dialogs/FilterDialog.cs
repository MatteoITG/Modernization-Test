using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Wisej.Web;
using RelayCrm.Services;
// Wisej 4.2 has its own FilterField (QueryBuilder): use the one of the app.
using FilterField = RelayCrm.Services.FilterField;
using FilterFieldType = RelayCrm.Services.FilterFieldType;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// The advanced filter of the lists: conditions of the form "field operator value",
	/// combined with "all" or "any". Applied by <see cref="QueryFilter"/>.
	/// </summary>
	public partial class FilterDialog : Form
	{
		// the conditions being edited; copied back only on OK.
		private readonly List<FilterRule> rules = new List<FilterRule>();

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
				dialog.comboBoxField.Items.AddRange(fields.Cast<object>().ToArray());
				dialog.comboBoxField.SelectedIndex = 0;
				if (current != null)
				{
					dialog.rules.AddRange(current.Rules);
					dialog.radioAny.Checked = !current.MatchAll;
				}
				dialog.ShowRules();

				if (dialog.ShowDialog(Form.ActiveForm) != DialogResult.OK)
					return null;

				var query = new FilterQuery { MatchAll = dialog.radioAll.Checked };
				query.Rules.AddRange(dialog.rules);
				return query;
			}
		}

		private FilterField SelectedField => this.comboBoxField.SelectedItem as FilterField;

		private FilterOperator SelectedOperator => ((OperatorItem)this.comboBoxOperator.SelectedItem)?.Operator ?? FilterOperator.Contains;

		private bool NeedsValue => this.SelectedOperator != FilterOperator.IsEmpty && this.SelectedOperator != FilterOperator.IsNotEmpty;

		// an operator with its text, for the combo box.
		private class OperatorItem
		{
			public FilterOperator Operator { get; set; }
			public override string ToString() => QueryFilter.OperatorText(this.Operator);
		}

		private void ShowRules()
		{
			this.listBoxRules.Items.Clear();
			foreach (var rule in this.rules)
				this.listBoxRules.Items.Add(rule);
			this.labelEmpty.Visible = this.rules.Count == 0;
			this.buttonRemove.Enabled = false;
			this.buttonClear.Enabled = this.rules.Count > 0;
		}

		private void comboBoxField_SelectedIndexChanged(object sender, EventArgs e)
		{
			var field = this.SelectedField;
			if (field == null)
				return;

			this.comboBoxOperator.Items.Clear();
			foreach (var op in QueryFilter.OperatorsFor(field.Type))
				this.comboBoxOperator.Items.Add(new OperatorItem { Operator = op });
			this.comboBoxOperator.SelectedIndex = 0;

			// dates are picked, choices are listed, text and numbers are typed.
			this.dateTimePickerValue.Visible = field.Type == FilterFieldType.Date;
			this.comboBoxValue.Visible = field.Type != FilterFieldType.Date;
			this.comboBoxValue.Items.Clear();
			this.comboBoxValue.Text = "";
			this.comboBoxValue.DropDownStyle = field.Type == FilterFieldType.Choice ? ComboBoxStyle.DropDownList : ComboBoxStyle.DropDown;
			if (field.Type == FilterFieldType.Choice)
			{
				this.comboBoxValue.Items.AddRange(field.Choices);
				if (field.Choices.Length > 0)
					this.comboBoxValue.SelectedIndex = 0;
			}
		}

		private void comboBoxOperator_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboBoxValue.Enabled = this.dateTimePickerValue.Enabled = this.NeedsValue;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var field = this.SelectedField;
			if (field == null)
				return;

			string value = null;
			if (this.NeedsValue)
			{
				if (field.Type == FilterFieldType.Date)
				{
					value = this.dateTimePickerValue.Value.Date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
				}
				else
				{
					value = this.comboBoxValue.Text.Trim();
					if (value.Length == 0)
					{
						this.errorProvider.SetError(this.comboBoxValue, "Enter a value.");
						this.comboBoxValue.Focus();
						return;
					}
					if (field.Type == FilterFieldType.Number)
					{
						if (!decimal.TryParse(value.TrimStart('$'), NumberStyles.Number, Fmt.Culture, out var number))
						{
							this.errorProvider.SetError(this.comboBoxValue, "Enter a number, like 25000.");
							this.comboBoxValue.Focus();
							return;
						}
						value = number.ToString(CultureInfo.InvariantCulture);
					}
				}
			}

			this.errorProvider.SetError(this.comboBoxValue, "");
			this.rules.Add(new FilterRule { Field = field, Operator = this.SelectedOperator, Value = value });
			ShowRules();
			if (field.Type != FilterFieldType.Choice)
				this.comboBoxValue.Text = "";
		}

		private void buttonRemove_Click(object sender, EventArgs e)
		{
			if (this.listBoxRules.SelectedItem is FilterRule rule)
			{
				this.rules.Remove(rule);
				ShowRules();
			}
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			this.rules.Clear();
			ShowRules();
		}

		private void listBoxRules_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.buttonRemove.Enabled = this.listBoxRules.SelectedIndex >= 0;
		}

		private void comboBoxValue_TextChanged(object sender, EventArgs e)
		{
			this.errorProvider.SetError(this.comboBoxValue, "");
		}
	}
}
