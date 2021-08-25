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

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if(rbAdmin.Checked == true)
            {
                lblTipo.Text = txtNome.Text + " é " + rbAdmin.Text.ToLower();
            }
            else
            {
                lblTipo.Text = "";
            }
        }

        private void rbUser_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUser.Checked == true)
            {
                lblTipo.Text = txtNome.Text + " é " + rbUser.Text.ToLower();
            }
            else
            {
                lblTipo.Text = "";
            }
        }

        private void ckIncluir_CheckedChanged(object sender, EventArgs e)
        {
            if (ckIncluir.Checked == true)
            {
                lblIncluir.Text = "Direito de Inclusão";
            }
            else
            {
                lblIncluir.Text = "";
            }
        }

        private void ckAlterar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAlterar.Checked == true)
            {
                lblAlterar.Text = "Direito de Alteração";
            }
            else
            {
                lblAlterar.Text = "";
            }
        }

        private void ckApagar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckApagar.Checked == true)
            {
                lblApagar.Text = "Direito de Exclusão";
            }
            else
            {
                lblApagar.Text = "";
            }
        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
            string aux = "";
            aux = txtNome.Text;
            foreach (RadioButton item in gbTipo.Controls)
            {
                if (item.Checked == true)
                {
                    aux += " " + item.Text;
                }
            }
            aux += "\nPermissões:\n";
            foreach (CheckBox item in gbPermissao.Controls)
            {
                if (item.Checked == true)
                {
                    aux += item.Text;
                }
            }
            lblMostra.Text = aux;
        }
    }
}
