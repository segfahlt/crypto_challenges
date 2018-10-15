using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoChallenge
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ConvertHextStringToBase64(object sender, EventArgs e)
		{
			var ba = CryptoTools.HexStringToByteArray(txtHexString.Text);
			txtBase64String.Text = CryptoTools.ToBase64(ba);
		}

		private void DoXor(object sender, EventArgs e)
		{
			var b1 = CryptoTools.HexStringToByteArray(txtXor1.Text);
			var b2 = CryptoTools.HexStringToByteArray(txtXor2.Text);
			var bres = CryptoTools.Xor(b1, b2);
			txtXorResult.Text = CryptoTools.ByteArrayToHexString(bres);
		}

		private void ScoreXor(object sender, EventArgs e)
		{
			var highestScore = 0;
			byte encryptionChar = (byte)0;
			txtXorScoreResults.Text = CryptoTools.FindAndDecode(txtXorScore.Text, out highestScore, out encryptionChar);
		}

		private void DetectXor(object sender, EventArgs e)
		{
			var xord = new List<string>();
			var highestScore = 0;
			var encryptionChar = (byte)0;
			var textToDecrypt = string.Empty;
			var lineScore = 0;
			var lineEncryptionChar = (byte)0;
			for (var i = 0; i < txtDetectXor.Lines.Length; i++)
			{
				var str = txtDetectXor.Lines[i];
				CryptoTools.FindAndDecode(str, out lineScore, out lineEncryptionChar);
				if (lineScore > highestScore)
				{
					highestScore = lineScore;
					encryptionChar = lineEncryptionChar;
					textToDecrypt = str;
				}
				xord.Add(string.Format("{0} {1} {2}", lineScore, lineEncryptionChar, str));
			}
			txtDetectXor.Lines = xord.ToArray();

			var y = CryptoTools.Xor(encryptionChar, CryptoTools.HexStringToByteArray(textToDecrypt));
			lblDetectXor.Text = Encoding.UTF8.GetString(y);

		}

		private void RepeatingCharXor(object sender, EventArgs e)
		{
			var result = new List<string>();
			var l = string.Join("\n", txtRepeatingCharXor.Lines);
			var key = Encoding.UTF8.GetBytes("ICE");
			var ba = Encoding.UTF8.GetBytes(l);
			var r = CryptoTools.RepeatingCharXor(key, ba);
			var r2 = CryptoTools.ByteArrayToHexString(r);
			result.Add(r2);
			txtRepeatingCharXor.Lines = result.ToArray();
		}

		private void GetHammingDistance(object sender, EventArgs e)
		{
			lblHamming.Text = CryptoTools.HammingDistance(txtHamming1.Text, txtHamming2.Text).ToString();
		}

		private void BreakSimpleXorEncryption(object sender, EventArgs e)
		{
			var str = System.IO.File.ReadAllText("Files\\6.txt");
			str = CryptoTools.BreakRepeatingKeyXor(str);
			txtOutput.Text = str;
		}

		private void DecryptAesEcb(object sender, EventArgs e)
		{
			var str = System.IO.File.ReadAllText("Files\\7.txt");
			var ba = Convert.FromBase64String(str);
			var key = Encoding.UTF8.GetBytes("YELLOW SUBMARINE");
			var decryptedArray = CryptoTools.DecryptAesEcb(key, ba);
			txtOutput.Text = Encoding.UTF8.GetString(decryptedArray);
		}

		private void txtFindAesEcb_Click(object sender, EventArgs e)
		{
			var lines = System.IO.File.ReadAllLines("Files\\8.txt");
			var possibleEcb = new List<string>();
			foreach (var line in lines)
			{
				var chunks = new List<string>();
				for (var i = 0; i < line.Length / 16; i++)
				{
					chunks.Add(line.Substring(i*16,16));
				}

				var chunkGroups = chunks.GroupBy(f => f)
					.Select(g =>
					string.Format("{0} - {1}", g.Count(), g.Key)
				);
				var chunkCount = chunkGroups.Count();
				if(chunkCount < line.Length/16)
					possibleEcb.Add(string.Format("{0} unique chunks out of {1}: {2}", chunkCount, line.Length/16,line));
			}

			txtOutput.Lines = possibleEcb.ToArray();
		}
	}
}
