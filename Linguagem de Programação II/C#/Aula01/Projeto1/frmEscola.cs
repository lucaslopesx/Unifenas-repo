using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class frmEscola : Form
    {
        public frmEscola()
        {
            InitializeComponent();
        }

        private void cmdEscola_Click(object sender, EventArgs e)
        {
            lblEscola.Text += txtEscola.Text;
        }

        private void cmdMostrarCurso_Click(object sender, EventArgs e)
        {
            frmCurso f1 = new frmCurso();
            f1.ShowDialog();
        }
    }
}
