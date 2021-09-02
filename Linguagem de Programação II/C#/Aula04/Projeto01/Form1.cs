using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void cmdOk_Click(object sender, EventArgs e)
		{
			lblDTP.Text = dateTimePicker1.Value.Date.ToString();
			DateTime di, df;
			di = monthCalendar1.SelectionStart;
			df = monthCalendar1.SelectionEnd;

			lblMC.Text = "Data inicial: " + di.ToString("dd/MM/yyyy")+"\nData Final: "+ df.ToString("dd/MM/yyyy");
		}
	}
}
