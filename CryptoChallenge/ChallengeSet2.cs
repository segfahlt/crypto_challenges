using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoChallenge
{
	public partial class ChallengeSet2 : Form
	{
		public ChallengeSet2()
		{
			InitializeComponent();
		}

		private void PadText(object sender, EventArgs e)
		{
			var source = Encoding.UTF8.GetBytes(txtPadSrc.Text);
			var multipleOf = Convert.ToInt32(txtPadMultiple.Text);
			var str = Encoding.UTF8.GetString(CryptoTools.PadToMultiple(source, multipleOf));
			txtOutput.Text= Regex.Replace(str,
				@"\p{Cc}",
				a => string.Format("\\x{0:X2}", (byte)a.Value[0])
			);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var txt = System.IO.File.ReadAllText("Files\\10.txt");
			var ba = Convert.FromBase64String(txt);
			ba = CryptoTools.PadToMultiple(ba, 16);
			var key = Encoding.UTF8.GetBytes("YELLOW SUBMARINE");
			txtOutput.Text = CryptoTools.CbcDecrypt(key, new byte[16], ba);

		}
	}
}
