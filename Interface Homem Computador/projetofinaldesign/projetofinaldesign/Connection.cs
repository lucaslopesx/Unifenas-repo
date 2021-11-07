using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace projetofinaldesign
{
    class connection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cd = new SqlCommand();
        public SqlDataReader dr;
        SqlDataAdapter da;
        public DataSet ds;

        public void Connect()
        {
            cn.ConnectionString = "SERVER = DESKTOP-GM7EVH8\\SQLEXPRESS; Database=Estoque; UID=sa; PWD=1234;";
            //cn.ConnectionString = "SERVER = F038847\\SQLEXPRESS; Database=Estoque2; UID=sa; PWD=123;";
            cn.Open();
        }

        public void Disconnect()
        {
            cn.Close();
        }

        public void Execute(string sql)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            Disconnect();
        }

        public void ListInfo(string sql)
        {
            Connect();
            da = new SqlDataAdapter(sql, cn);
            ds = new DataSet();
            da.Fill(ds);
        }

        public void Consult(string sql)
        {
            Connect();
            cd.CommandText = sql;
            cd.Connection = cn;
            dr = cd.ExecuteReader();
        }
    }
}
