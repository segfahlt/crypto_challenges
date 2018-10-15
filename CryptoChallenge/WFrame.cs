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
	public partial class WFrame : Form
	{
		private List<Form> _windows;
		public WFrame()
		{
			InitializeComponent();
			_windows = new List<Form>();
		}

		private void OpenChallengeSet1(object sender, EventArgs e)
		{
			var form = _windows.FirstOrDefault(f => f.Name == "ChallengeSet1");
			if (form == null)
			{
				form = new ChallengeSet1();
				form.StartPosition = FormStartPosition.CenterParent;
				form.WindowState = FormWindowState.Maximized;
				_windows.Add(form);
				form.MdiParent = this;
				form.BringToFront();
				form.Show();
			}
			else
			{
				form.BringToFront();
				form.Activate();
			}
		}
		private void OpenChallengeSet2(object sender, EventArgs e)
		{
			var form = _windows.FirstOrDefault(f => f.Name == "ChallengeSet2");
			if (form == null)
			{
				form = new ChallengeSet2();
				form.StartPosition = FormStartPosition.CenterParent;
				form.WindowState = FormWindowState.Maximized;
				_windows.Add(form);
				form.MdiParent = this;
				form.BringToFront();
				form.Show();
			}
			else
			{
				form.BringToFront();
				form.Activate();
			}
		}
	}
}
