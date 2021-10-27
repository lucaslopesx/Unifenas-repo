using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgendaBD
{
    public partial class frmAlterar : Form
    {
        private DadosAgenda data = new DadosAgenda();
        public frmAlterar()
        {
            InitializeComponent();
        }
        private void frmAlterar_Load(object sender, EventArgs e)
        {

            cbNome.DisplayMember = "Nome";
            cbNome.ValueMember = "Codigo";
            cbNome.DataSource = data.List().Tables[0];
            cbNome.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            int codigoAgenda = int.Parse(cbNome.SelectedValue.ToString());
            data.Telefone = txtTelefone.Text;
            data.Cidade = txtCidade.Text;
            data.Update();

            MessageBox.Show("Registro alterado com sucesso!!");
            txtCidade.Clear();
            txtTelefone.Clear();
        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.Codigo = int.Parse(cbNome.SelectedValue.ToString());
            data.Consult();

            txtTelefone.Text = data.Telefone;
            txtCidade.Text = data.Cidade;
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
