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
    public partial class Jogo : Form
    {
        public Jogo(string nome)
        {
            InitializeComponent();
            this.nomejogo = nome;
        }

        string nomejogo;
        List<Pessoa> list = new List<Pessoa>();
        internal List<Pessoa> List { get => list; set => list = value; }

        private int flag;
        int i = 1;
        int pontos = 0;
        Pessoa P = new Pessoa();


        private void cmdVerificar_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1:
                    if(radioButton2.Checked == true)
                    {
                        pBFotos.Image = Properties.Resources.acertou;
                        pontos += flag;
                    }
                    else
                    {
                        pBFotos.Image = Properties.Resources.errou;
                    }
                    break;
                case 2:
                    if (radioButton1.Checked == true)
                    {
                        pBFotos.Image = Properties.Resources.acertou;
                        pontos += flag;
                    }
                    else
                    {
                        pBFotos.Image = Properties.Resources.errou;
                    }
                    break;
                case 3:
                    if (radioButton4.Checked == true)
                    {
                        pBFotos.Image = Properties.Resources.acertou;
                        pontos += flag;
                    }
                    else
                    {
                        pBFotos.Image = Properties.Resources.errou;
                    }
                    break;
                case 4:
                    if (radioButton3.Checked == true)
                    {
                        pBFotos.Image = Properties.Resources.acertou;
                        pontos += flag;
                    }
                    else
                    {
                        pBFotos.Image = Properties.Resources.errou;
                    }
                    break;
                case 5:
                    if (radioButton3.Checked == true)
                    {
                        pBFotos.Image = Properties.Resources.acertou;
                        pontos += flag;
                    }
                    else
                    {
                        pBFotos.Image = Properties.Resources.errou;
                    }
                    labelPerguntaVerd.Text = "Nome:" + nomejogo + "\nPontos :" + pontos + "\nO jogo acabou";
                    button1.Text = "Fim"; 
                    break;
                default:
                    {
                        
                    }
                    break;
            }
            flag = -1;
            i++;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            flag = 6;
            timer1.Enabled = true;
            if (i==1)
            {
                labelPerguntaVerd.Text = "Qual o componente utilizado para escrever no forms?";
                radioButton1.Text = "Ponteiro";
                radioButton2.Text = "Label";
                radioButton3.Text = "Conteiner";
                radioButton4.Text = "MouthnCalender";
                button1.Text = "Proximo";
                progressBar1.Value++;
            }
            else if (i==2)
            {
                labelPerguntaVerd.Text = "Qual o componente utilizado para criar um menu?";
                radioButton1.Text = "MenuStrip";
                radioButton2.Text = "Ponteiro";
                radioButton3.Text = "TextBox";
                radioButton4.Text = "Label";
                timer1.Enabled = true;
                progressBar1.Value++;
            }
            else if (i == 3)
            {
                labelPerguntaVerd.Text = "Qual o componente é utilizado para exibir um calendario?";
                radioButton1.Text = "Ponteiro";
                radioButton2.Text = "Forms";
                radioButton3.Text = "Ponteiro";
                radioButton4.Text = "MouthnCalender";
                timer1.Enabled = true;
                progressBar1.Value++;
            }
            else if (i == 4)
            {
                labelPerguntaVerd.Text = "Qual o componente é utilizado para para exibir arrays ?";
                radioButton1.Text = "TextBox";
                radioButton2.Text = "Label";
                radioButton3.Text = "DataGridView";
                radioButton4.Text = "MouthnCalender";
                timer1.Enabled = true;
                progressBar1.Value++;
            }
            else if (i == 5)
            {
                labelPerguntaVerd.Text = "Qual o componente é utilizado para fazer ações periodicamente ?";
                radioButton1.Text = "Ponteiro";
                radioButton2.Text = "Label";
                radioButton3.Text = "Timer";
                radioButton4.Text = "MouthnCalender";
                timer1.Enabled = true;
                progressBar1.Value++;
            }
            if (button1.Text=="Proximo")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            if (button1.Text=="Fim")
            {
                P.Nome = nomejogo;
                P.Pontos = pontos;
                List.Add(P);
                Close();
            }
        }

        private void Jogo_Load(object sender, EventArgs e)
        {
            List.OrderBy(P => P.Pontos);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(flag ==6)
            {
                pBFotos.Image = Properties.Resources._6;
                flag--;
            }
            else if (flag == 5)
            {
                pBFotos.Image = Properties.Resources._5;
                flag--;
            }
            else if (flag == 4)
            {
                pBFotos.Image = Properties.Resources._4;
                flag--;
            }
            else if (flag == 3)
            {
                pBFotos.Image = Properties.Resources._3;
                flag--;
            }
            else if (flag == 2)
            {
                pBFotos.Image = Properties.Resources._2;
                flag--;
            }
            else if (flag == 1)
            {
                pBFotos.Image = Properties.Resources._1;
                flag--;
            }
            else if (flag == 0)
            {
                pBFotos.Image = Properties.Resources.tempoPassou;
            }
        }
    }
}
