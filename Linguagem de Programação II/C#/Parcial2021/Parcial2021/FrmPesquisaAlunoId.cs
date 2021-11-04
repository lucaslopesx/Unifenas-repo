using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2021
{
    public partial class FrmPesquisaAlunoId : Form
    {
        public FrmPesquisaAlunoId()
        {
            InitializeComponent();
        }

        Alunos a = new Alunos();
        private void cmdPesquisa_Click(object sender, EventArgs e)
        {
            a.IdAluno = int.Parse(textBox1.Text);
            a.PesquisarAlunoporId();
            label2.Text = a.Aluno;

        }
    }
}
