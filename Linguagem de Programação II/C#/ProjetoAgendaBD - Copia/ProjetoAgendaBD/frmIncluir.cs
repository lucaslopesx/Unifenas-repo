using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgendaBD
{
    public partial class frmIncluir : Form
    {
        public frmIncluir()
        {
            InitializeComponent();
        }

        private DadosAgenda data = new DadosAgenda();

        private void cmdIncluir_Click(object sender, EventArgs e)
        {
            data.Nome = txtNome.Text;
            data.Telefone = txtTelefone.Text;
            data.Cidade = txtCidade.Text;
            data.Insert();

            MessageBox.Show("Registro incluido com sucesso!!");
            
            txtNome.Clear();
            txtCidade.Clear();
            txtTelefone.Clear();
        }
    }
}
