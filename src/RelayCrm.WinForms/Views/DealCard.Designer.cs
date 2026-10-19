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
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.labelOwner = new System.Windows.Forms.Label();
			this.labelClose = new System.Windows.Forms.Label();
			this.labelMeta = new System.Windows.Forms.Label();
			this.labelTitle = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			// toolTip
			//
			this.toolTip.AutoPopDelay = 10000;
			this.toolTip.InitialDelay = 600;
			this.toolTip.ReshowDelay = 100;
			//
			// labelOwner
			//
			this.labelOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
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
			this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
			this.labelClose.AutoEllipsis = true;
			this.labelClose.Location = new System.Drawing.Point(6, 60);
			this.labelClose.Name = "labelClose";
			this.labelClose.Size = new System.Drawing.Size(140, 16);
			this.labelClose.TabIndex = 2;
			this.labelClose.Text = "Closes Oct 20";
			//
			// labelMeta
			//
			this.labelMeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
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
			this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
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
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelOwner);
			this.Controls.Add(this.labelClose);
			this.Controls.Add(this.labelMeta);
			this.Controls.Add(this.labelTitle);
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "DealCard";
			this.Size = new System.Drawing.Size(206, 84);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label labelOwner;
		private System.Windows.Forms.Label labelClose;
		private System.Windows.Forms.Label labelMeta;
		private System.Windows.Forms.Label labelTitle;
	}
}
