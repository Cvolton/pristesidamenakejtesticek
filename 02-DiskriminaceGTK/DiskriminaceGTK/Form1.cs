using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskriminaceGTK
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			progressBar1.Value = (int)Math.Floor(numericUpDown1.Value);
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			progressBar2.Value = trackBar1.Value * 10;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Weeeeee");
		}

		private void btnNegnu_Click(object sender, EventArgs e)
		{
			lblHorni.Show();
			lblHorni.Text = "Windows 10";
		}
	}
}
