using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto03
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{
			DateTime di;
			di = monthCalendar1.SelectionStart;

			if (di.Date.ToString("dd/MM/yyyy") == "25/12/2021")
			{
				pictureBox1.Image = Properties.Resources.Anotação_2021_09_01_214911;
			}
			else if (di.Date.ToString("dd/MM/yyyy")== "22/08/2021")
			{
				pictureBox1.Image = Properties.Resources._1535482050_UmaFlex_Capa_Primavera;
			}
			else if (di.Date.ToString("dd/MM/yyyy") == "21/06/2021")
			{
				pictureBox1.Image = Properties.Resources.Anotação_2021_09_01_215617;
			}
			else
			{
				pictureBox1.Image = Properties.Resources.aa;
			}

		}
	}
}
