using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoFuncionario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        frmFuncionario frmFunc = new frmFuncionario();
        frmDepartamento frmDep = new frmDepartamento();
        private void mnuFuncionario_Click(object sender, EventArgs e)
        {
            frmFunc.ShowDialog();
        }

        private void mnuDepartamento_Click(object sender, EventArgs e)
        {
            frmDep.ShowDialog();
            mnuFuncionario.Enabled = true;
        }
    }
}
