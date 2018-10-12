namespace CryptoChallenge
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txtHexString = new System.Windows.Forms.TextBox();
			this.txtBase64String = new System.Windows.Forms.TextBox();
			this.btnConvert1 = new System.Windows.Forms.Button();
			this.txtXor1 = new System.Windows.Forms.TextBox();
			this.txtXor2 = new System.Windows.Forms.TextBox();
			this.txtXorResult = new System.Windows.Forms.TextBox();
			this.btnXor = new System.Windows.Forms.Button();
			this.txtXorScore = new System.Windows.Forms.TextBox();
			this.txtXorScoreResults = new System.Windows.Forms.TextBox();
			this.btnXorScore = new System.Windows.Forms.Button();
			this.txtDetectXor = new System.Windows.Forms.TextBox();
			this.btnDetectXor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtHexString
			// 
			this.txtHexString.Location = new System.Drawing.Point(12, 12);
			this.txtHexString.Name = "txtHexString";
			this.txtHexString.Size = new System.Drawing.Size(747, 20);
			this.txtHexString.TabIndex = 0;
			this.txtHexString.Text = "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206" +
    "d757368726f6f6d";
			// 
			// txtBase64String
			// 
			this.txtBase64String.Location = new System.Drawing.Point(12, 38);
			this.txtBase64String.Name = "txtBase64String";
			this.txtBase64String.Size = new System.Drawing.Size(747, 20);
			this.txtBase64String.TabIndex = 1;
			// 
			// btnConvert1
			// 
			this.btnConvert1.Location = new System.Drawing.Point(12, 64);
			this.btnConvert1.Name = "btnConvert1";
			this.btnConvert1.Size = new System.Drawing.Size(75, 23);
			this.btnConvert1.TabIndex = 2;
			this.btnConvert1.Text = "Convert";
			this.btnConvert1.UseVisualStyleBackColor = true;
			this.btnConvert1.Click += new System.EventHandler(this.ConvertHextStringToBase64);
			// 
			// txtXor1
			// 
			this.txtXor1.Location = new System.Drawing.Point(13, 94);
			this.txtXor1.Name = "txtXor1";
			this.txtXor1.Size = new System.Drawing.Size(746, 20);
			this.txtXor1.TabIndex = 3;
			this.txtXor1.Text = "1c0111001f010100061a024b53535009181c";
			// 
			// txtXor2
			// 
			this.txtXor2.Location = new System.Drawing.Point(12, 120);
			this.txtXor2.Name = "txtXor2";
			this.txtXor2.Size = new System.Drawing.Size(747, 20);
			this.txtXor2.TabIndex = 4;
			this.txtXor2.Text = "686974207468652062756c6c277320657965";
			// 
			// txtXorResult
			// 
			this.txtXorResult.Location = new System.Drawing.Point(12, 146);
			this.txtXorResult.Name = "txtXorResult";
			this.txtXorResult.Size = new System.Drawing.Size(747, 20);
			this.txtXorResult.TabIndex = 5;
			// 
			// btnXor
			// 
			this.btnXor.Location = new System.Drawing.Point(13, 172);
			this.btnXor.Name = "btnXor";
			this.btnXor.Size = new System.Drawing.Size(75, 23);
			this.btnXor.TabIndex = 6;
			this.btnXor.Text = "XOR";
			this.btnXor.UseVisualStyleBackColor = true;
			this.btnXor.Click += new System.EventHandler(this.DoXor);
			// 
			// txtXorScore
			// 
			this.txtXorScore.Location = new System.Drawing.Point(13, 203);
			this.txtXorScore.Name = "txtXorScore";
			this.txtXorScore.Size = new System.Drawing.Size(745, 20);
			this.txtXorScore.TabIndex = 7;
			this.txtXorScore.Text = "1b37373331363f78151b7f2b783431333d78397828372d363c78373e783a393b3736";
			// 
			// txtXorScoreResults
			// 
			this.txtXorScoreResults.Location = new System.Drawing.Point(92, 229);
			this.txtXorScoreResults.Multiline = true;
			this.txtXorScoreResults.Name = "txtXorScoreResults";
			this.txtXorScoreResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtXorScoreResults.Size = new System.Drawing.Size(666, 23);
			this.txtXorScoreResults.TabIndex = 8;
			// 
			// btnXorScore
			// 
			this.btnXorScore.Location = new System.Drawing.Point(13, 229);
			this.btnXorScore.Name = "btnXorScore";
			this.btnXorScore.Size = new System.Drawing.Size(75, 23);
			this.btnXorScore.TabIndex = 9;
			this.btnXorScore.Text = "XOR SC";
			this.btnXorScore.UseVisualStyleBackColor = true;
			this.btnXorScore.Click += new System.EventHandler(this.ScoreXor);
			// 
			// txtDetectXor
			// 
			this.txtDetectXor.Location = new System.Drawing.Point(92, 258);
			this.txtDetectXor.Multiline = true;
			this.txtDetectXor.Name = "txtDetectXor";
			this.txtDetectXor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtDetectXor.Size = new System.Drawing.Size(667, 97);
			this.txtDetectXor.TabIndex = 10;
			this.txtDetectXor.Text = resources.GetString("txtDetectXor.Text");
			// 
			// btnDetectXor
			// 
			this.btnDetectXor.Location = new System.Drawing.Point(13, 258);
			this.btnDetectXor.Name = "btnDetectXor";
			this.btnDetectXor.Size = new System.Drawing.Size(75, 23);
			this.btnDetectXor.TabIndex = 11;
			this.btnDetectXor.Text = "Detect Xor";
			this.btnDetectXor.UseVisualStyleBackColor = true;
			this.btnDetectXor.Click += new System.EventHandler(this.DetectXor);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDetectXor);
			this.Controls.Add(this.txtDetectXor);
			this.Controls.Add(this.btnXorScore);
			this.Controls.Add(this.txtXorScoreResults);
			this.Controls.Add(this.txtXorScore);
			this.Controls.Add(this.btnXor);
			this.Controls.Add(this.txtXorResult);
			this.Controls.Add(this.txtXor2);
			this.Controls.Add(this.txtXor1);
			this.Controls.Add(this.btnConvert1);
			this.Controls.Add(this.txtBase64String);
			this.Controls.Add(this.txtHexString);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtHexString;
		private System.Windows.Forms.TextBox txtBase64String;
		private System.Windows.Forms.Button btnConvert1;
		private System.Windows.Forms.TextBox txtXor1;
		private System.Windows.Forms.TextBox txtXor2;
		private System.Windows.Forms.TextBox txtXorResult;
		private System.Windows.Forms.Button btnXor;
		private System.Windows.Forms.TextBox txtXorScore;
		private System.Windows.Forms.TextBox txtXorScoreResults;
		private System.Windows.Forms.Button btnXorScore;
		private System.Windows.Forms.TextBox txtDetectXor;
		private System.Windows.Forms.Button btnDetectXor;
	}
}

