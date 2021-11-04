using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Parcial2021
{
    class Matricula
    {
        public int IdMatricula { get; set; }
        public int IdAluno { get; set; }
        public int IdDisciplina { get; set; }
        public float Nota1 { get; set; }

        public float Nota2 { get; set; }
        public float Global { get; set; }
        public float Final { get; set; }
        public string Situacao { get; set; }
        public string SituacaoConsulta { get; set; }

        public void CalcularSituacaoporIdMatricula()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server = F038847\\SQLEXPRESS;Database = CURSO;UID=sa;PWD=123";
            cn.Open();
            SqlCommand cd = new SqlCommand();
            cd.CommandText = $"Select nota1, nota2, global from Matricula where idMatricula = {IdMatricula} ";
            cd.Connection = cn;
            SqlDataReader dr = cd.ExecuteReader();

            if (dr.Read())
            {
                Nota1 = float.Parse(dr["nota1"].ToString());
                Nota2 = float.Parse(dr["nota2"].ToString());
                Global = float.Parse(dr["global"].ToString());
                Final = (Nota1 + Nota2 + Global) / 3;
            }
            cn.Close();
            cn.Open();

            if (Final<4)
            {
                SituacaoConsulta = "Reprovado";
            }
            if (Final >=4 && Final<6)
            {
                SituacaoConsulta = "Final";
            }
            if (Final >= 6)
            {
                SituacaoConsulta = "Aprovado";
            }

            cd.CommandText = $"update Matricula set situacao = '{SituacaoConsulta}', final = {Final} where idMatricula={IdMatricula}";

            cd.ExecuteNonQuery();



        }

        public DataSet PesquisarMatriculaSituacao()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server = F038847\\SQLEXPRESS;Database = CURSO;UID=sa;PWD=123";
            cn.Open();

            

            string sql = $"Select * from Matricula where situacao like '{SituacaoConsulta}'";

            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);




            return ds;
        }


    }
}
