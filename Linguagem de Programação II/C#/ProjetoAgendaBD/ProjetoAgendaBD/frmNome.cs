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
    public partial class frmNome : Form
    {
        public frmNome()
        {
            InitializeComponent();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = DESKTOP-GM7EVH8\\SQLEXPRESS; Database=Agenda; UID=sa; PWD=1234;";
            cn.Open();

            string sql = $"Select * from DadosAgenda where Nome LIKE '{txtNome.Text}%'";

            SqlDataAdapter da = new SqlDataAdapter(sql, cn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = DESKTOP-GM7EVH8\\SQLEXPRESS; Database=Agenda; UID=sa; PWD=1234;";
            cn.Open();

            string sql = $"Select * from DadosAgenda where Nome LIKE '{txtNome.Text}%'";

            SqlDataAdapter da = new SqlDataAdapter(sql, cn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
