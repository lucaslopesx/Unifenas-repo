using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Questao1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Vacina> lista = new List<Vacina>();

        private void cmdCadastrar_Click(object sender, EventArgs e)
        {
            Vacina V = new Vacina();
            if (radioButton1.Checked)
            {
                V.Nome_vacina = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                V.Nome_vacina = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                V.Nome_vacina = radioButton3.Text;
            }
            V.Nome = textBox1.Text;
            V.Dose1 = checkBox1.Checked;
            V.Dose2 = checkBox2.Checked;
            V.Dose3 = checkBox3.Checked;
            lista.Add(V);

        }

        private void cmdPesquisa_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach(var item in lista)
            {
                if (item.Nome_vacina == textBox2.Text && item.Dose1 == true )
                {
                    count++;
                }
            }
            label3.Text = count.ToString();

        }
    }
}
