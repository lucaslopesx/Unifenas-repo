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
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }
        private Jogador j;
        List<Jogador> listaJogador = new List<Jogador>();

        internal List<Jogador> ListaJogador { get => listaJogador; set => listaJogador = value; }

        private void cmdCadastrar_Click(object sender, EventArgs e)
        {
            j = new Jogador();
            j.Nome = txtNomeJogador.Text;
            ListaJogador.Add(j);
            MessageBox.Show("Cadastro concluido com sucesso!!");
        }
    }
}
