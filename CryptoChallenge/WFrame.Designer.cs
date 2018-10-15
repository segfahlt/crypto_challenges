namespace CryptoChallenge
{
	partial class WFrame
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._mFrame = new System.Windows.Forms.MenuStrip();
			this.challengesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this._mFrame.SuspendLayout();
			this.SuspendLayout();
			// 
			// _mFrame
			// 
			this._mFrame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.challengesToolStripMenuItem});
			this._mFrame.Location = new System.Drawing.Point(0, 0);
			this._mFrame.Name = "_mFrame";
			this._mFrame.Size = new System.Drawing.Size(960, 24);
			this._mFrame.TabIndex = 1;
			// 
			// challengesToolStripMenuItem
			// 
			this.challengesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
			this.challengesToolStripMenuItem.Name = "challengesToolStripMenuItem";
			this.challengesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.challengesToolStripMenuItem.Text = "Challenges";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem2.Text = "1";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.OpenChallengeSet1);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem3.Text = "2";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.OpenChallengeSet2);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem4.Text = "3";
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem5.Text = "4";
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem6.Text = "5";
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem7.Text = "6";
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem8.Text = "7";
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem9.Text = "8";
			// 
			// WFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(960, 669);
			this.Controls.Add(this._mFrame);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this._mFrame;
			this.Name = "WFrame";
			this.Text = "Crypto Challenges";
			this._mFrame.ResumeLayout(false);
			this._mFrame.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip _mFrame;
		private System.Windows.Forms.ToolStripMenuItem challengesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
	}
}