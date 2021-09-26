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
        private List<Jogador> listaJogador = new List<Jogador>();
        internal List<Jogador> ListaJogador { get => listaJogador; set => listaJogador = value; }

        public frmJogo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelJogo.Visible = true;
        }

        private void cmdEnviar_Click(object sender, EventArgs e)
        {

        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            foreach (var item in ListaJogador)
            {
                comboBox1.Items.Add(item.Nome);
            }
        }
    }
}
