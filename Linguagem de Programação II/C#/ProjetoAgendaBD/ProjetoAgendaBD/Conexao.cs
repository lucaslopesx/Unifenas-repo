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
        cn.ConnectionString = "SERVER = F038847\\SQLEXPRESS; Database=Agenda; UID=sa; PWD=123;";
            cn.Open();

            string sql = $"Select * from DadosAgenda where Nome LIKE '{txtNome.Text}%'";
    }
}
