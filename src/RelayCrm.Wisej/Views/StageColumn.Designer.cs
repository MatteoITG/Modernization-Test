namespace RelayCrm.Views
{
	partial class StageColumn
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.flowCards = new Wisej.Web.FlowLayoutPanel();
			this.panelHeader = new Wisej.Web.Panel();
			this.labelTotals = new Wisej.Web.Label();
			this.labelName = new Wisej.Web.Label();
			this.flowCards.SuspendLayout();
			this.panelHeader.SuspendLayout();
			this.SuspendLayout();
			//
			// flowCards
			//
			this.flowCards.AllowDrop = true;
			this.flowCards.AutoScroll = true;
			this.flowCards.BackColor = System.Drawing.SystemColors.ControlLight;
			this.flowCards.Dock = Wisej.Web.DockStyle.Fill;
			this.flowCards.FlowDirection = Wisej.Web.FlowDirection.TopDown;
			this.flowCards.Location = new System.Drawing.Point(0, 46);
			this.flowCards.Name = "flowCards";
			this.flowCards.Padding = new Wisej.Web.Padding(2, 4, 2, 4);
			this.flowCards.Size = new System.Drawing.Size(224, 354);
			this.flowCards.TabIndex = 1;
			this.flowCards.WrapContents = false;
			this.flowCards.DragDrop += new Wisej.Web.DragEventHandler(this.flowCards_DragDrop);
			this.flowCards.DragEnter += new Wisej.Web.DragEventHandler(this.flowCards_DragEnter);
			this.flowCards.DragOver += new Wisej.Web.DragEventHandler(this.flowCards_DragOver);
			this.flowCards.DragLeave += new System.EventHandler(this.flowCards_DragLeave);
			this.flowCards.Resize += new System.EventHandler(this.flowCards_Resize);
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.labelTotals);
			this.panelHeader.Controls.Add(this.labelName);
			this.panelHeader.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(224, 46);
			this.panelHeader.TabIndex = 0;
			//
			// labelTotals
			//
			this.labelTotals.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right));
			this.labelTotals.AutoEllipsis = true;
			this.labelTotals.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelTotals.Location = new System.Drawing.Point(6, 24);
			this.labelTotals.Name = "labelTotals";
			this.labelTotals.Size = new System.Drawing.Size(212, 16);
			this.labelTotals.TabIndex = 1;
			this.labelTotals.Text = "0 deals · $0";
			//
			// labelName
			//
			this.labelName.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right));
			this.labelName.AutoEllipsis = true;
			this.labelName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.labelName.Location = new System.Drawing.Point(6, 4);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(212, 19);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Stage";
			//
			// StageColumn
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.flowCards);
			this.Controls.Add(this.panelHeader);
			this.Margin = new Wisej.Web.Padding(0, 0, 8, 0);
			this.Name = "StageColumn";
			this.Size = new System.Drawing.Size(224, 400);
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.flowCards.ResumeLayout(false);
			this.flowCards.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.FlowLayoutPanel flowCards;
		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.Label labelTotals;
		private Wisej.Web.Label labelName;
	}
}
