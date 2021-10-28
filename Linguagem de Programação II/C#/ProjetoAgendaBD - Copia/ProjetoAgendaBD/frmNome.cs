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
    public partial class frmNome : Form
    {
        private DadosAgenda data = new DadosAgenda();
        public frmNome()
        {
            InitializeComponent();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            data.Nome = txtNome.Text;
            dataGridView1.DataSource = data.ListByName().Tables[0];

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            data.Nome = txtNome.Text;
            dataGridView1.DataSource = data.ListByName().Tables[0];
        }
    }
}
