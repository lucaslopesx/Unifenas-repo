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

        //public void CalcularSituacaoporIdMatricula()
        //{
            
        //}

        //public DataSet PesquisarMatriculaSituacao()
        //{
           
        //}


    }
}
