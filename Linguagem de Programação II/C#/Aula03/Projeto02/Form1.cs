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

		private void cmdVetor_Click(object sender, EventArgs e)
		{
			dgvVetor.RowCount = 1;
			dgvVetor.ColumnCount = (int)nudColunas.Value;

			for (int i = 0; i < nudColunas.Value; i++)
			{
				dgvVetor.Columns[i].Width = 50;
				dgvVetor.Rows[0].Cells[i].Value = 0;
			}
		}
	}
}
