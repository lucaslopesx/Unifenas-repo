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
    public partial class frmExcluir : Form
    {
        private DadosAgenda data = new DadosAgenda();
        public frmExcluir()
        {
            InitializeComponent();
        }

        private void frmExcluir_Load(object sender, EventArgs e)
        {
            cbNome.DisplayMember = "Nome";
            cbNome.ValueMember = "Codigo";
            cbNome.DataSource = data.List().Tables[0];
            cbNome.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            data.Codigo = int.Parse(cbNome.SelectedValue.ToString());
            data.Delete();

            MessageBox.Show("Registro excluido com sucesso!!");
            txtCidade.Clear();
            txtTelefone.Clear();
            frmExcluir_Load(sender, e);
        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.Codigo = int.Parse(cbNome.SelectedValue.ToString());
            data.Consult();

            txtTelefone.Text = data.Telefone;
            txtCidade.Text = data.Cidade;
        }
    }
}
