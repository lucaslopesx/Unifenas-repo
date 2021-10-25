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
    public partial class frmIncluir : Form
    {
        public frmIncluir()
        {
            InitializeComponent();
        }

        private void cmdIncluir_Click(object sender, EventArgs e)
        {
            
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = DESKTOP-GM7EVH8\\SQLEXPRESS; Database=Agenda; UID=sa; PWD=1234;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Insert into DadosAgenda (Nome, Telefone, Cidade) values ('{txtNome.Text}', '{txtTelefone.Text}', '{txtCidade.Text}')";

            cd.ExecuteNonQuery();
            

            MessageBox.Show("Registro incluido com sucesso!!");
            txtNome.Clear();
            txtCidade.Clear();
            txtTelefone.Clear();
        }
    }
}
