using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgendaBD
{
    public partial class frmCidade : Form
    {
        private DadosAgenda data = new DadosAgenda();
        public frmCidade()
        {
            InitializeComponent();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            data.Cidade = txtNome.Text;

            dataGridView1.DataSource = data.ListByCity().Tables[0];
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            data.Cidade = txtNome.Text;

            dataGridView1.DataSource = data.ListByCity().Tables[0];
        }
    }
}
