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
			var bres = CryptoTools.XorByteArrays(b1, b2);
			txtXorResult.Text = CryptoTools.ByteArrayToHexString(bres);
		}

		private void ScoreXor(object sender, EventArgs e)
		{
			txtXorScoreResults.Text = CryptoTools.ScoreXor(txtXorScore.Text);
		}

		private void DetectXor(object sender, EventArgs e)
		{
			var xord = new List<string>();
			for (var i = 0; i < txtDetectXor.Lines.Length; i++)
			{
				var str = txtDetectXor.Lines[i];
				xord.Add(CryptoTools.ScoreXor(str));
			}

			txtDetectXor.Text = string.Join(Environment.NewLine, xord);
		}
	}
}
