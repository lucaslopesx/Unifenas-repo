using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto01_WinForms
{
    public partial class frnTrocaDeValores : Form
    {
        public frnTrocaDeValores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdTrocar_Click(object sender, EventArgs e)
        {
            string Aux;
            Aux = txtPrimeiroValor.Text;
            txtPrimeiroValor.Text = txtSegundoValor.Text;
            txtSegundoValor.Text = Aux;
        }
    }
}
