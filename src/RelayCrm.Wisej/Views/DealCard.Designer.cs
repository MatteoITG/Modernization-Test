namespace RelayCrm.Views
{
	partial class DealCard
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
			this.components = new System.ComponentModel.Container();
			this.toolTip = new Wisej.Web.ToolTip(this.components);
			this.labelOwner = new Wisej.Web.Label();
			this.labelClose = new Wisej.Web.Label();
			this.labelMeta = new Wisej.Web.Label();
			this.labelTitle = new Wisej.Web.Label();
			this.SuspendLayout();
			//
			// toolTip
			//
			this.toolTip.AutoPopDelay = 10000;
			this.toolTip.InitialDelay = 600;
			//
			// labelOwner
			//
			this.labelOwner.Anchor = ((Wisej.Web.AnchorStyles)(Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right));
			this.labelOwner.Location = new System.Drawing.Point(150, 60);
			this.labelOwner.Name = "labelOwner";
			this.labelOwner.Size = new System.Drawing.Size(48, 16);
			this.labelOwner.TabIndex = 3;
			this.labelOwner.Text = "MP";
			this.labelOwner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelOwner.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// labelClose
			//
			this.labelClose.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right));
			this.labelClose.AutoEllipsis = true;
			this.labelClose.Location = new System.Drawing.Point(6, 60);
			this.labelClose.Name = "labelClose";
			this.labelClose.Size = new System.Drawing.Size(140, 16);
			this.labelClose.TabIndex = 2;
			this.labelClose.Text = "Closes Oct 20";
			//
			// labelMeta
			//
			this.labelMeta.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right));
			this.labelMeta.AutoEllipsis = true;
			this.labelMeta.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelMeta.Location = new System.Drawing.Point(6, 26);
			this.labelMeta.Name = "labelMeta";
			this.labelMeta.Size = new System.Drawing.Size(192, 30);
			this.labelMeta.TabIndex = 1;
			this.labelMeta.Text = "Company · $0";
			//
			// labelTitle
			//
			this.labelTitle.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right));
			this.labelTitle.AutoEllipsis = true;
			this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.labelTitle.Location = new System.Drawing.Point(6, 6);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(192, 18);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Deal title";
			//
			// DealCard
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.labelOwner);
			this.Controls.Add(this.labelClose);
			this.Controls.Add(this.labelMeta);
			this.Controls.Add(this.labelTitle);
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.Cursor = Wisej.Web.Cursors.Hand;
			this.Margin = new Wisej.Web.Padding(4, 3, 4, 3);
			this.Name = "DealCard";
			this.Size = new System.Drawing.Size(206, 84);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.ToolTip toolTip;
		private Wisej.Web.Label labelOwner;
		private Wisej.Web.Label labelClose;
		private Wisej.Web.Label labelMeta;
		private Wisej.Web.Label labelTitle;
	}
}
