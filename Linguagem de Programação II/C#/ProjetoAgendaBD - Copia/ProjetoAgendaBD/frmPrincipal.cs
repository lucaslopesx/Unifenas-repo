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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void incluirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmIncluir fi = new frmIncluir();
            fi.ShowDialog();
        }

        private void alterarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAlterar fa = new frmAlterar();
            fa.ShowDialog();
        }

        private void excluirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmExcluir fe = new frmExcluir();
            fe.ShowDialog();
        }

        private void porNomeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmNome fn = new frmNome();
            fn.ShowDialog();
        }

        private void porCidadeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCidade fc = new frmCidade();
            fc.ShowDialog();
        }
    }
}
