using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendaBD
{
    class Conexao
    {
        SqlConnection cn = new SqlConnection();
        public void Connect()
        {
            cn.ConnectionString = "SERVER = F038847\\SQLEXPRESS; Database=Agenda; UID=sa; PWD=123;";
            cn.Open();
        }

        public void Desconnect()
        {
            cn.Close();
        }

        public void Execute(string sql)
        {
            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Insert into DadosAgenda (Nome, Telefone, Cidade) values ('{txtNome.Text}', '{txtTelefone.Text}', '{txtCidade.Text}')";

            cd.ExecuteNonQuery();
        }
        
        

        string sql = $"Select * from DadosAgenda where Nome LIKE '{txtNome.Text}%'";
    }
}
