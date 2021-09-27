using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoPerguntas
{
    
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
           
        }
        public string nome;

        Jogo j = null;

        private void cmdQuizz_Click(object sender, EventArgs e)
        {
            nome = txtName.Text;
            j = new Jogo(nome);
            j.ShowDialog();
        }

        private void mnuFechr_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuRank_Click(object sender, EventArgs e)
        { 
            Ranking r = new Ranking();
            r.ListRank = j.List;
            r.ShowDialog();
        }
    }
}
