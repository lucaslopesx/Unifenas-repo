﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Parcial2021
{
    class Alunos
    {
        public int IdAluno { get; set; }
        public string Aluno { get; set; }

        public void PesquisarAlunoporId()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server = F038847\\SQLEXPRESS;Database = CURSO;UID=sa;PWD=123";
            cn.Open();
            string sql = $"Select Aluno from TabelaAluno where idAluno = {IdAluno}";
            SqlCommand cd = new SqlCommand(sql, cn);
            SqlDataReader dr = cd.ExecuteReader();
            if (dr.Read())
            {
                Aluno = dr["Aluno"].ToString();
            }

        }

    }
}
