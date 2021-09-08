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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private frmCadastro fc = new frmCadastro();
        private void mnuCadastro_Click(object sender, EventArgs e)
        {
            fc.ShowDialog();
        }

        private void mnuPesquisa_Click(object sender, EventArgs e)
        {
            frmPesquisa fp = new frmPesquisa();
            fp.Lista = fc.Lista;
            fp.ShowDialog();
        }
    }
}
