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
    public partial class Ranking : Form
    {
        List<Pessoa> listRank = new List<Pessoa>();
        internal List<Pessoa> ListRank { get => listRank; set => listRank = value; }

        public Ranking()
        {
            InitializeComponent();
        }


        private void Ranking_Load(object sender, EventArgs e)
        {
            foreach (var item in ListRank)
            {
                listView1.Items.Add(item.Nome);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
