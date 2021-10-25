using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetodeMetodosdeOrdenacao
{
    public partial class Form1 : Form
    {
		Metodos M = new Metodos();
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdRandom_Click(object sender, EventArgs e)
        {
            dgvVetor.RowCount = 1;
            dgvVetor.ColumnCount = (int)nudColunas.Value;

            for (int i = 0; i < nudColunas.Value; i++)
            {
                dgvVetor.Columns[i].Width = 30;
                dgvVetor.Rows[0].Height = 30;
                dgvVetor.Rows[0].Cells[i].Value = r.Next(1,1000);
            }
        }

        private void cmdOrdenar_Click(object sender, EventArgs e)
        {
            int[] vet = new int[(int)nudColunas.Value];

            for (int i = 0; i < (int)nudColunas.Value; i++)
            {
                vet[i] = Convert.ToInt32(dgvVetor.Rows[0].Cells[i].Value);
            }
            if(comboBox1.SelectedItem == "Select Sort")
            {
                M.SelectSort(vet);
                lblTroca.Text = M.T1.ToString();
                lblComp.Text = M.C1.ToString();
            }
            else if (comboBox1.SelectedItem == "Insertion Sort")
            {
                M.InsertSort(vet);
                lblTroca.Text = M.T1.ToString();
                lblComp.Text = M.C1.ToString();
            }
            else if (comboBox1.SelectedItem == "Bubble Sort")
            {
                M.BubbleSort(vet);
                lblTroca.Text = M.T1.ToString();
                lblComp.Text = M.C1.ToString();
            }
            else if (comboBox1.SelectedItem == "Quick Sort")
            {
                M.QuickSort(vet, 0, (int)nudColunas.Value - 1);
                lblTroca.Text = M.T1.ToString();
                lblComp.Text = M.C1.ToString();
            }
            dgvOrdenado.RowCount = 1;
            dgvOrdenado.ColumnCount = (int)nudColunas.Value;
            for (int i = 0; i < nudColunas.Value; i++)
            {
                dgvOrdenado.Columns[i].Width = 30;
                dgvOrdenado.Rows[0].Height = 30;
                dgvOrdenado.Rows[0].Cells[i].Value = 0;
            }
            for (int j = 0; j < (int)nudColunas.Value; j++)
            {
                dgvOrdenado.Rows[0].Cells[j].Value = vet[j];
            }
            M.C1 = 0;
            M.T1 = 0;
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            dgvOrdenado.Rows.Clear();
            dgvOrdenado.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvOrdenado.Rows.Clear();
            dgvOrdenado.Refresh();
            if (nudColunas.Value > 0)
            {
                cmdOrdenar.Enabled = true;
            }
        }

        private void nudColunas_ValueChanged(object sender, EventArgs e)
        {
            dgvVetor.RowCount = 1;
            dgvVetor.ColumnCount = (int)nudColunas.Value;

            for (int i = 0; i < nudColunas.Value; i++)
            {
                dgvVetor.Columns[i].Width = 30;
                dgvVetor.Rows[0].Height = 30;
                dgvVetor.Rows[0].Cells[i].Value = 0;
            }
        }
    }
}
