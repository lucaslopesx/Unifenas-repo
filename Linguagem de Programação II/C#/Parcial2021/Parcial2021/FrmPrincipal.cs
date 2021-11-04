using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2021
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void pesquisaAlunoPorIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesquisaAlunoId fp = new FrmPesquisaAlunoId();
            fp.ShowDialog();
        }

        private void pesquisarPorSituaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesquisarPorSituacao fs = new FrmPesquisarPorSituacao();
            fs.ShowDialog();
        }

        private void calcularSituaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalcularSituacao fc = new FrmCalcularSituacao();
            fc.ShowDialog();
        }
    }
}
