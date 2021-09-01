using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto01_MatrizForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void cmdMatriz_Click(object sender, EventArgs e)
		{
			dgvMatriz.RowCount = (int)nudLinhas.Value;
			dgvMatriz.ColumnCount = (int)nudColunas.Value;

			for (int i = 0; i < nudColunas.Value; i++)
			{
				dgvMatriz.Columns[i].Width = 50;
			}
			for (int i = 0; i < nudLinhas.Value; i++)
			{
				for (int j = 0; j < nudColunas.Value; j++)
				{
					dgvMatriz.Rows[i].Cells[j].Value = 0;
				}
			}			
		}

		private void cmdSomar_Click(object sender, EventArgs e)
		{
			int soma = 0;
			for (int i = 0; i < nudLinhas.Value; i++)
			{
				for (int j = 0; j < nudColunas.Value; j++)
				{
					soma += Convert.ToInt32(dgvMatriz.Rows[i].Cells[j].Value);
				}
			}
			lblSoma.Text = soma.ToString();
		}

		private void lblSoma_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void dgvMatriz_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void nudColunas_ValueChanged(object sender, EventArgs e)
		{

		}

		private void nudLinhas_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
