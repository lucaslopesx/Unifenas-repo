using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto04
{
    public partial class FrmLista : Form
    {
        public FrmLista()
        {
            InitializeComponent();
        }

        private List<Pessoa> pLista = new List<Pessoa>();
        private void carregaLista()
        {
            pLista.Add(new Pessoa(1, "João", 29, 'M'));
            pLista.Add(new Pessoa(2, "Marcos", 35, 'M'));
            pLista.Add(new Pessoa(3, "Americo", 25, 'M'));
            pLista.Add(new Pessoa(4, "Katia", 21, 'F'));
            pLista.Add(new Pessoa(5, "Lena", 33, 'F'));
            pLista.Add(new Pessoa(6, "Suzana", 45, 'F'));
            pLista.Add(new Pessoa(7, "Jim", 38, 'M'));
            pLista.Add(new Pessoa(8, "Jane", 32, 'F'));
            pLista.Add(new Pessoa(9, "Roberto", 31, 'M'));
            pLista.Add(new Pessoa(10, "Cintia", 25, 'F'));
        }

        private void FrmLista_Load(object sender, EventArgs e)
        {
            carregaLista();
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in pLista)
            {
                listBox1.Items.Add(item.Codigo + "-" + item.Nome + "-" + item.Idade + "-" + item.Sexo);
            }
        }

        private void cmdNome_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var resultado = from p in pLista orderby p.Nome select p;
            foreach (var c in resultado)
            {
                listBox1.Items.Add(c.Nome);
            }
        }

        private void cmdIdade_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var resultado = from c in pLista where c.Idade > 30 select c;
            foreach (var c in resultado)
            {
                listBox1.Items.Add(c.Nome + " - " + c.Idade);
            }
        }

        private void cmdObjeto_Click(object sender, EventArgs e)
        {
            int Codigo = int.Parse(txtCodigo.Text);
            listBox1.Items.Clear();
            var resultado = from c in pLista where c.Codigo == Codigo select c;
            foreach (var c in resultado)
            {
                listBox1.Items.Add(c.Codigo + " - " + c.Nome + " - " + c.Idade);
            }
        }
    }
}
