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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                lblSelecionado.Text = listBox1.SelectedItem.ToString();
            else
                lblSelecionado.Text = "";
        }

        private void cmdIncluir_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(txtCurso.Text) == false)
                listBox1.Items.Add(txtCurso.Text);
            else
                MessageBox.Show("Curso já existente!");
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
