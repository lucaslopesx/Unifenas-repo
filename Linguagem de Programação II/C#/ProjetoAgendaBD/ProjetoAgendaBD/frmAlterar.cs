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
        public frmAlterar()
        {
            InitializeComponent();
        }
        private void frmAlterar_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = F038847\\SQLEXPRESS; Database=Agenda; UID=sa; PWD=123;";
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from DadosAgenda", cn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            cbNome.DisplayMember = "Nome";
            cbNome.ValueMember = "Codigo";
            cbNome.DataSource = ds.Tables[0];
            cbNome.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            int codigoAgenda = int.Parse(cbNome.SelectedValue.ToString());
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = F038847\\SQLEXPRESS; Database=Agenda; UID=sa; PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();

            cd.Connection = cn;
            cd.CommandText = $"update DadosAgenda set Telefone = '{txtTelefone.Text}', Cidade = '{txtCidade.Text}' where Codigo = {codigoAgenda}";


            cd.ExecuteNonQuery();
            MessageBox.Show("Registro alterado com sucesso!!");
            txtCidade.Clear();
            txtTelefone.Clear();
            cn.Close();
        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigoAgenda = int.Parse(cbNome.SelectedValue.ToString());
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = F038847\\SQLEXPRESS; Database=Agenda; UID=sa; PWD=123;";
            SqlCommand cd = new SqlCommand();
            cd.CommandText = $"Select * from DadosAgenda where Codigo = {codigoAgenda}";
            cd.Connection = cn;
            cn.Open();

            SqlDataReader dr = cd.ExecuteReader();

            if (dr.Read())
            {
                txtTelefone.Text = dr["Telefone"].ToString();
                txtCidade.Text = dr["Cidade"].ToString();
            }
            cn.Close();
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
