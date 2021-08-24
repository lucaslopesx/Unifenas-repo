using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioAula
{
    public partial class Form1 : Form
    {
        int carne;
        int pao;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdPao_Click_Click(object sender, EventArgs e)
        {
            lblMostra.Text = "Uma fatia de pão integral possui 200 calorias.";
            if (listIngredientes.Items.Contains("Pao"))
            {
                MessageBox.Show("Ingrediente ja selecionado");
            }
            else
            {
                listIngredientes.Items.Add("Pao");
                pao += 200;
            }
        }

        private void cmdCarne_Click(object sender, EventArgs e)
        {
            lblMostra.Text = "Uma porção de carne de hamburguer possui 350 calorias.";
            if (listIngredientes.Items.Contains("Carne"))
            {
                MessageBox.Show("Ingrediente ja selecionado");
            }
            else
            {
                listIngredientes.Items.Add("Carne");
                carne += 350;
            }
        }
        private void txtSenha_Validating(object sender, CancelEventArgs e)
        {
            if (txtSenha.Text == "123")
            {
                MessageBox.Show("Senha correta");
            }
            else
            {
                MessageBox.Show("Senha incorreta");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTotal.Text = Convert.ToString(carne + pao);
        }
    }
}
