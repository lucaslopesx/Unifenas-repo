using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto02
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuFormulario1_Click(object sender, EventArgs e)
        {
            Formm1 f1 = new Formm1();
            f1.ShowDialog();
            mnuFormulario2.Enabled = true;
        }

        private void mnuFormulario2_Click(object sender, EventArgs e)
        {
            Formm2 f2 = new Formm2();
            f2.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            mnuFormulario2.Enabled = false;
        }
    }
}
