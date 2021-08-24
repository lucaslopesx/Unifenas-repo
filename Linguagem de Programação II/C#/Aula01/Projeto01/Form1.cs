using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto01
{
    public partial class frmCurso : Form
    {
        public frmCurso()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void cmdEscola_Click(object sender, EventArgs e)
        {
            lblEscola.Text += txtEscola.Text;
        }

        private void cmdMostraCurso_Click(object sender, EventArgs e)
        {
            frmCurso f1 = new frmCurso();
            f1.ShowDialog();
        }
    }
}
