using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoFuncionario
{
    public partial class frmFuncionario : Form
    {
        Funcionario f;
        List<Funcionario> list = new List<Funcionario>();
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f = new Funcionario();
            string nome = txtNome.Text;
            double salario = Convert.ToDouble(txtSalario.Text);
            string data = dateTimePicker1.Text;
            f.GravaDados(nome, salario, data);
            list.Add(f);
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            foreach (var item in list)
            {
                lblDados.Text += item.MostraDados();
            }
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSalario.Text = "";
        }

        private void cmdMaiorSalario_Click(object sender, EventArgs e)
        {
            double aux = list[0].Salario;
            int j = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Salario > aux)
                {
                    aux = list[i].Salario;
                    j = i;
                }
                lblMaiorSalario.Text = list[j].MostraDados();
            }
        }
    }
}
