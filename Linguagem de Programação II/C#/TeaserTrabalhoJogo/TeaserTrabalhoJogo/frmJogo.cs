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
    public partial class frmJogo : Form
    {
        Jogador j = new Jogador();
        private List<Jogador> listaJogador = new List<Jogador>();
        internal List<Jogador> ListaJogador { get => listaJogador; set => listaJogador = value; }

        public frmJogo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        int i = 0;
        private void cmdEnviar_Click(object sender, EventArgs e)
        {
            j.Pontos++;
        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            foreach (var item in ListaJogador)
            {
                comboBox1.Items.Add(item.Nome);
            } 
        }

        private void cmdFinalizar_Click(object sender, EventArgs e)
        {
            ListaJogador.Add(j);
        }

        private void cmdComecar_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                lblTitle.Text = "ola";
                rbOpcao1.Text = "certo";
                rbOpcao2.Text = "errado";
                rbOpcao3.Text = "errado";
            }
            panelJogo.Visible = true;
            cmdComecar.Visible = false;
        }
    }
}
