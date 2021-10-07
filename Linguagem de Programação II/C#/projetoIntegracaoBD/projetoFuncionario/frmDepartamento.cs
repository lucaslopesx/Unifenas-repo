using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoFuncionario
{
    public partial class frmDepartamento : Form
    {
        Departamento dep;
        List<Departamento> listDep = new List<Departamento>();
        public frmDepartamento()
        {
            InitializeComponent();
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtCodigo.Text = "";
        }

        private void cmdCadastra_Click(object sender, EventArgs e)
        {
            dep = new Departamento();
            int cod = Convert.ToInt32(txtCodigo.Text);
            string nome = txtNome.Text;
            dep.GravaDados(cod, nome);
            listDep.Add(dep);
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            lblDados.Text = " ";
            foreach (var item in listDep)
            {
                lblDados.Text += item.MostraDados();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        public bool usuarioCadastrado()
        {
            if (listDep == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
