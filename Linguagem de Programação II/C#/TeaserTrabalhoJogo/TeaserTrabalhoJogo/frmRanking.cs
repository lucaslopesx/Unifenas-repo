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
    public partial class frmRanking : Form
    {
        public frmRanking()
        {
            InitializeComponent();
        }

        private List<Jogador> listaJogador = new List<Jogador>();

        internal List<Jogador> ListaJogador { get => listaJogador; set => listaJogador = value; }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Jogador item in ListaJogador)
            {
                listView1.Items.Add(item.Nome);
            }
        }
    }
}
