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
    public partial class FrmPesquisarPorSituacao : Form
    {
        public FrmPesquisarPorSituacao()
        {
            InitializeComponent();
        }
        Matricula m = new Matricula();
        private void cmdpesquisar_Click(object sender, EventArgs e)
        {
            if (rbAprovado.Checked)
            {
                m.SituacaoConsulta = "Aprovado";
            }
            if (rbFinal.Checked)
            {
                m.SituacaoConsulta = "Final";
            }
            if (rbReprovado.Checked)
            {
                m.SituacaoConsulta = "Reprovado";
            }

            dataGridView1.DataSource = m.PesquisarMatriculaSituacao().Tables[0];
        }

       
    }
}
