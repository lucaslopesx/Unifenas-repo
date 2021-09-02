using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto02
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void cmdImage1_Click_1(object sender, EventArgs e)
		{
			pictureBox1.Image = Properties.Resources.Anotação_2021_09_01_213443;
		}

		private void cmdImage2_Click(object sender, EventArgs e)
		{
			pictureBox1.Image = Properties.Resources.IMG_20190711_WA0047;
		}
	}
}
