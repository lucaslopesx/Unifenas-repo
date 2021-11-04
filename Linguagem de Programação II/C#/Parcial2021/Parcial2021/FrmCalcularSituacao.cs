using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient ;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2021
{
    public partial class FrmCalcularSituacao : Form
    {
        public FrmCalcularSituacao()
        {
            InitializeComponent();
        }
        Matricula m = new Matricula();
        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            m.IdMatricula = int.Parse(textBox1.Text);

            m.CalcularSituacaoporIdMatricula();
        }
    }
}
