namespace CryptoChallenge
{
	partial class ChallengeSet1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChallengeSet1));
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
			this.lblDetectXor = new System.Windows.Forms.Label();
			this.btnRepeatingCharXor = new System.Windows.Forms.Button();
			this.txtRepeatingCharXor = new System.Windows.Forms.TextBox();
			this.btnGetHamming = new System.Windows.Forms.Button();
			this.txtHamming1 = new System.Windows.Forms.TextBox();
			this.txtHamming2 = new System.Windows.Forms.TextBox();
			this.lblHamming = new System.Windows.Forms.Label();
			this.btnBreakSimplXorEncryption = new System.Windows.Forms.Button();
			this.btnDecryptAesEcb = new System.Windows.Forms.Button();
			this.txtOutput = new System.Windows.Forms.RichTextBox();
			this.txtFindAesEcb = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtHexString
			// 
			this.txtHexString.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHexString.Location = new System.Drawing.Point(108, -1);
			this.txtHexString.Name = "txtHexString";
			this.txtHexString.Size = new System.Drawing.Size(702, 20);
			this.txtHexString.TabIndex = 0;
			this.txtHexString.Text = "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206" +
    "d757368726f6f6d";
			// 
			// txtBase64String
			// 
			this.txtBase64String.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBase64String.Location = new System.Drawing.Point(108, 19);
			this.txtBase64String.Name = "txtBase64String";
			this.txtBase64String.Size = new System.Drawing.Size(702, 20);
			this.txtBase64String.TabIndex = 1;
			// 
			// btnConvert1
			// 
			this.btnConvert1.Location = new System.Drawing.Point(12, -1);
			this.btnConvert1.Name = "btnConvert1";
			this.btnConvert1.Size = new System.Drawing.Size(75, 23);
			this.btnConvert1.TabIndex = 2;
			this.btnConvert1.Text = "Convert";
			this.btnConvert1.UseVisualStyleBackColor = true;
			this.btnConvert1.Click += new System.EventHandler(this.ConvertHextStringToBase64);
			// 
			// txtXor1
			// 
			this.txtXor1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtXor1.Location = new System.Drawing.Point(108, 43);
			this.txtXor1.Name = "txtXor1";
			this.txtXor1.Size = new System.Drawing.Size(264, 20);
			this.txtXor1.TabIndex = 3;
			this.txtXor1.Text = "1c0111001f010100061a024b53535009181c";
			// 
			// txtXor2
			// 
			this.txtXor2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtXor2.Location = new System.Drawing.Point(378, 43);
			this.txtXor2.Name = "txtXor2";
			this.txtXor2.Size = new System.Drawing.Size(265, 20);
			this.txtXor2.TabIndex = 4;
			this.txtXor2.Text = "686974207468652062756c6c277320657965";
			// 
			// txtXorResult
			// 
			this.txtXorResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtXorResult.Location = new System.Drawing.Point(108, 64);
			this.txtXorResult.Name = "txtXorResult";
			this.txtXorResult.Size = new System.Drawing.Size(535, 20);
			this.txtXorResult.TabIndex = 5;
			// 
			// btnXor
			// 
			this.btnXor.Location = new System.Drawing.Point(12, 41);
			this.btnXor.Name = "btnXor";
			this.btnXor.Size = new System.Drawing.Size(75, 23);
			this.btnXor.TabIndex = 6;
			this.btnXor.Text = "XOR";
			this.btnXor.UseVisualStyleBackColor = true;
			this.btnXor.Click += new System.EventHandler(this.DoXor);
			// 
			// txtXorScore
			// 
			this.txtXorScore.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtXorScore.Location = new System.Drawing.Point(108, 90);
			this.txtXorScore.Name = "txtXorScore";
			this.txtXorScore.Size = new System.Drawing.Size(535, 20);
			this.txtXorScore.TabIndex = 7;
			this.txtXorScore.Text = "1b37373331363f78151b7f2b783431333d78397828372d363c78373e783a393b3736";
			// 
			// txtXorScoreResults
			// 
			this.txtXorScoreResults.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtXorScoreResults.Location = new System.Drawing.Point(108, 112);
			this.txtXorScoreResults.Multiline = true;
			this.txtXorScoreResults.Name = "txtXorScoreResults";
			this.txtXorScoreResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtXorScoreResults.Size = new System.Drawing.Size(535, 23);
			this.txtXorScoreResults.TabIndex = 8;
			// 
			// btnXorScore
			// 
			this.btnXorScore.Location = new System.Drawing.Point(12, 90);
			this.btnXorScore.Name = "btnXorScore";
			this.btnXorScore.Size = new System.Drawing.Size(75, 23);
			this.btnXorScore.TabIndex = 9;
			this.btnXorScore.Text = "XOR SC";
			this.btnXorScore.UseVisualStyleBackColor = true;
			this.btnXorScore.Click += new System.EventHandler(this.ScoreXor);
			// 
			// txtDetectXor
			// 
			this.txtDetectXor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDetectXor.Location = new System.Drawing.Point(108, 138);
			this.txtDetectXor.Multiline = true;
			this.txtDetectXor.Name = "txtDetectXor";
			this.txtDetectXor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtDetectXor.Size = new System.Drawing.Size(535, 97);
			this.txtDetectXor.TabIndex = 10;
			this.txtDetectXor.Text = resources.GetString("txtDetectXor.Text");
			// 
			// btnDetectXor
			// 
			this.btnDetectXor.Location = new System.Drawing.Point(13, 138);
			this.btnDetectXor.Name = "btnDetectXor";
			this.btnDetectXor.Size = new System.Drawing.Size(75, 23);
			this.btnDetectXor.TabIndex = 11;
			this.btnDetectXor.Text = "Detect Xor";
			this.btnDetectXor.UseVisualStyleBackColor = true;
			this.btnDetectXor.Click += new System.EventHandler(this.DetectXor);
			// 
			// lblDetectXor
			// 
			this.lblDetectXor.AutoSize = true;
			this.lblDetectXor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDetectXor.Location = new System.Drawing.Point(105, 238);
			this.lblDetectXor.Name = "lblDetectXor";
			this.lblDetectXor.Size = new System.Drawing.Size(56, 14);
			this.lblDetectXor.TabIndex = 12;
			this.lblDetectXor.Text = "Unknown";
			// 
			// btnRepeatingCharXor
			// 
			this.btnRepeatingCharXor.Location = new System.Drawing.Point(-2, 255);
			this.btnRepeatingCharXor.Name = "btnRepeatingCharXor";
			this.btnRepeatingCharXor.Size = new System.Drawing.Size(90, 45);
			this.btnRepeatingCharXor.TabIndex = 13;
			this.btnRepeatingCharXor.Text = "Repeating Char XOR";
			this.btnRepeatingCharXor.UseVisualStyleBackColor = true;
			this.btnRepeatingCharXor.Click += new System.EventHandler(this.RepeatingCharXor);
			// 
			// txtRepeatingCharXor
			// 
			this.txtRepeatingCharXor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRepeatingCharXor.Location = new System.Drawing.Point(108, 255);
			this.txtRepeatingCharXor.Multiline = true;
			this.txtRepeatingCharXor.Name = "txtRepeatingCharXor";
			this.txtRepeatingCharXor.Size = new System.Drawing.Size(535, 45);
			this.txtRepeatingCharXor.TabIndex = 14;
			this.txtRepeatingCharXor.Text = "Burning \'em, if you ain\'t quick and nimble\r\nI go crazy when I hear a cymbal";
			// 
			// btnGetHamming
			// 
			this.btnGetHamming.Location = new System.Drawing.Point(3, 306);
			this.btnGetHamming.Name = "btnGetHamming";
			this.btnGetHamming.Size = new System.Drawing.Size(85, 23);
			this.btnGetHamming.TabIndex = 15;
			this.btnGetHamming.Text = "Get Hamming";
			this.btnGetHamming.UseVisualStyleBackColor = true;
			this.btnGetHamming.Click += new System.EventHandler(this.GetHammingDistance);
			// 
			// txtHamming1
			// 
			this.txtHamming1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHamming1.Location = new System.Drawing.Point(108, 308);
			this.txtHamming1.Name = "txtHamming1";
			this.txtHamming1.Size = new System.Drawing.Size(263, 20);
			this.txtHamming1.TabIndex = 16;
			this.txtHamming1.Text = "this is a test";
			// 
			// txtHamming2
			// 
			this.txtHamming2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHamming2.Location = new System.Drawing.Point(377, 308);
			this.txtHamming2.Name = "txtHamming2";
			this.txtHamming2.Size = new System.Drawing.Size(263, 20);
			this.txtHamming2.TabIndex = 17;
			this.txtHamming2.Text = "wokka wokka!!!";
			// 
			// lblHamming
			// 
			this.lblHamming.AutoSize = true;
			this.lblHamming.Location = new System.Drawing.Point(646, 310);
			this.lblHamming.Name = "lblHamming";
			this.lblHamming.Size = new System.Drawing.Size(13, 13);
			this.lblHamming.TabIndex = 19;
			this.lblHamming.Text = "0";
			// 
			// btnBreakSimplXorEncryption
			// 
			this.btnBreakSimplXorEncryption.Location = new System.Drawing.Point(1, 335);
			this.btnBreakSimplXorEncryption.Name = "btnBreakSimplXorEncryption";
			this.btnBreakSimplXorEncryption.Size = new System.Drawing.Size(87, 49);
			this.btnBreakSimplXorEncryption.TabIndex = 20;
			this.btnBreakSimplXorEncryption.Text = "Break Simple XOR Encryption";
			this.btnBreakSimplXorEncryption.UseVisualStyleBackColor = true;
			this.btnBreakSimplXorEncryption.Click += new System.EventHandler(this.BreakSimpleXorEncryption);
			// 
			// btnDecryptAesEcb
			// 
			this.btnDecryptAesEcb.Location = new System.Drawing.Point(94, 337);
			this.btnDecryptAesEcb.Name = "btnDecryptAesEcb";
			this.btnDecryptAesEcb.Size = new System.Drawing.Size(85, 47);
			this.btnDecryptAesEcb.TabIndex = 22;
			this.btnDecryptAesEcb.Text = "AES ECB Decrypt";
			this.btnDecryptAesEcb.UseVisualStyleBackColor = true;
			this.btnDecryptAesEcb.Click += new System.EventHandler(this.DecryptAesEcb);
			// 
			// txtOutput
			// 
			this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOutput.Location = new System.Drawing.Point(649, 43);
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ReadOnly = true;
			this.txtOutput.Size = new System.Drawing.Size(671, 580);
			this.txtOutput.TabIndex = 23;
			this.txtOutput.Text = "";
			// 
			// txtFindAesEcb
			// 
			this.txtFindAesEcb.Location = new System.Drawing.Point(185, 337);
			this.txtFindAesEcb.Name = "txtFindAesEcb";
			this.txtFindAesEcb.Size = new System.Drawing.Size(104, 47);
			this.txtFindAesEcb.TabIndex = 24;
			this.txtFindAesEcb.Text = "Find AES ECB";
			this.txtFindAesEcb.UseVisualStyleBackColor = true;
			this.txtFindAesEcb.Click += new System.EventHandler(this.txtFindAesEcb_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1332, 635);
			this.Controls.Add(this.txtFindAesEcb);
			this.Controls.Add(this.txtOutput);
			this.Controls.Add(this.btnDecryptAesEcb);
			this.Controls.Add(this.btnBreakSimplXorEncryption);
			this.Controls.Add(this.lblHamming);
			this.Controls.Add(this.txtHamming2);
			this.Controls.Add(this.txtHamming1);
			this.Controls.Add(this.btnGetHamming);
			this.Controls.Add(this.txtRepeatingCharXor);
			this.Controls.Add(this.btnRepeatingCharXor);
			this.Controls.Add(this.lblDetectXor);
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
		private System.Windows.Forms.Label lblDetectXor;
		private System.Windows.Forms.Button btnRepeatingCharXor;
		private System.Windows.Forms.TextBox txtRepeatingCharXor;
		private System.Windows.Forms.Button btnGetHamming;
		private System.Windows.Forms.TextBox txtHamming1;
		private System.Windows.Forms.TextBox txtHamming2;
		private System.Windows.Forms.Label lblHamming;
		private System.Windows.Forms.Button btnBreakSimplXorEncryption;
		private System.Windows.Forms.Button btnDecryptAesEcb;
		private System.Windows.Forms.RichTextBox txtOutput;
		private System.Windows.Forms.Button txtFindAesEcb;
	}
}

