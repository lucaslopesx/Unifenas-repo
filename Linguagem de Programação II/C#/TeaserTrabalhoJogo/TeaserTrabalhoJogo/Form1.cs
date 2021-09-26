using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaserTrabalhoJogo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        frmCadastrar fc = new frmCadastrar();

        private void mnuCadastrar_Click(object sender, EventArgs e)
        {
            fc.ShowDialog();
        }
        frmJogo fj = new frmJogo();
        private void mnuJogar_Click(object sender, EventArgs e)
        {
            fj.ListaJogador = fc.ListaJogador;
            fj.ShowDialog();
        }

        private void mnuRanking_Click(object sender, EventArgs e)
        {
            frmRanking fr = new frmRanking();
            fr.ListaJogador = fj.ListaJogador;
            fr.ShowDialog();
        }
    }
}
