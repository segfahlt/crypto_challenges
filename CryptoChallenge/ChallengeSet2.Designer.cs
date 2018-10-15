namespace CryptoChallenge
{
	partial class ChallengeSet2
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
			this.txtOutput = new System.Windows.Forms.RichTextBox();
			this.btnPad = new System.Windows.Forms.Button();
			this.txtPadSrc = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPadMultiple = new System.Windows.Forms.TextBox();
			this.btnCbcDecrypt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtOutput
			// 
			this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtOutput.Location = new System.Drawing.Point(538, 12);
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.Size = new System.Drawing.Size(438, 426);
			this.txtOutput.TabIndex = 0;
			this.txtOutput.Text = "";
			// 
			// btnPad
			// 
			this.btnPad.Location = new System.Drawing.Point(12, 10);
			this.btnPad.Name = "btnPad";
			this.btnPad.Size = new System.Drawing.Size(75, 23);
			this.btnPad.TabIndex = 1;
			this.btnPad.Text = "Pad";
			this.btnPad.UseVisualStyleBackColor = true;
			this.btnPad.Click += new System.EventHandler(this.PadText);
			// 
			// txtPadSrc
			// 
			this.txtPadSrc.Location = new System.Drawing.Point(93, 12);
			this.txtPadSrc.Name = "txtPadSrc";
			this.txtPadSrc.Size = new System.Drawing.Size(287, 20);
			this.txtPadSrc.TabIndex = 2;
			this.txtPadSrc.Text = "YELLOW SUBMARINE";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(386, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "to multiple of";
			// 
			// txtPadMultiple
			// 
			this.txtPadMultiple.Location = new System.Drawing.Point(458, 15);
			this.txtPadMultiple.Name = "txtPadMultiple";
			this.txtPadMultiple.Size = new System.Drawing.Size(74, 20);
			this.txtPadMultiple.TabIndex = 4;
			this.txtPadMultiple.Text = "20";
			// 
			// btnCbcDecrypt
			// 
			this.btnCbcDecrypt.Location = new System.Drawing.Point(12, 39);
			this.btnCbcDecrypt.Name = "btnCbcDecrypt";
			this.btnCbcDecrypt.Size = new System.Drawing.Size(75, 39);
			this.btnCbcDecrypt.TabIndex = 5;
			this.btnCbcDecrypt.Text = "CBC Decrypt";
			this.btnCbcDecrypt.UseVisualStyleBackColor = true;
			this.btnCbcDecrypt.Click += new System.EventHandler(this.button1_Click);
			// 
			// ChallengeSet2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(988, 450);
			this.Controls.Add(this.btnCbcDecrypt);
			this.Controls.Add(this.txtPadMultiple);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPadSrc);
			this.Controls.Add(this.btnPad);
			this.Controls.Add(this.txtOutput);
			this.Name = "ChallengeSet2";
			this.Text = "Challenge Set 2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox txtOutput;
		private System.Windows.Forms.Button btnPad;
		private System.Windows.Forms.TextBox txtPadSrc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPadMultiple;
		private System.Windows.Forms.Button btnCbcDecrypt;
	}
}