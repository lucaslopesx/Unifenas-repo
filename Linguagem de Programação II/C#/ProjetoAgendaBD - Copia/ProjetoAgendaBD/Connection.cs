using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendaBD
{
    class Connection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cd = new SqlCommand();
        public SqlDataReader dr;
        SqlDataAdapter da;
        public DataSet ds;

        public void Connect()
        {
            cn.ConnectionString = "SERVER = F038847\\SQLEXPRESS; Database=Agenda; UID=sa; PWD=123;";
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
        public void Execute(string sql, Byte[] Foto)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            if(Foto != null)
            {
                cd.Parameters.Clear();
                cd.Parameters.Add("@image", SqlDbType.Image);
                cd.Parameters["@image"].Value = Foto;
            }
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
