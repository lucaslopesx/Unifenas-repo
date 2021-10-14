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

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = F038847\\SQLEXPRESS; Database=Agenda; UID=sa; PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Select Nome from DadosAgenda";

            cd.ExecuteNonQuery();
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {

        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
