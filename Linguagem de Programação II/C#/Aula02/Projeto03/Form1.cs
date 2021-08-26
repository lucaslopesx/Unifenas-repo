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
        Paciente P;
        List<Paciente> ListPacientes = new List<Paciente>();
        private void cmdAdicionar_Click(object sender, EventArgs e)
        {
            P = new Paciente(int.Parse(txtCodigo.Text), txtNome.Text);
            if (cmbCidade.SelectedItem != null)
            {
                P.Cidade = cmbCidade.SelectedItem.ToString();
            }
            if (rbMasculino.Checked == true)
            {
                P.Sexo = 'M';
            }
            else
            {
                P.Sexo = 'F';
            }
            

            P.Febreamarela = ckbFebreAmarela.Checked;
            P.Catapora = ckbCatapora.Checked;
            P.Poliomelite = ckbPoliomielite.Checked;
            ListPacientes.Add(P);
            lbPacientes.Items.Add(P.mostra());

        }

        private void cmdAlfenas_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var item in ListPacientes)
            {
                if (item.Cidade == "Alfenas")
                {
                    count++;
                }
            }
            lblPesquisa1.Text = count.ToString();
        }

        private void cmdCatapora_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var item in ListPacientes)
            {
                if (item.Catapora == true)
                {
                    count++;
                }
            }
            lblPesquisa2.Text = count.ToString();
        }
    }
}
