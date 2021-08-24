using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_escola
{
    class Aluno:Pessoa
    {
        string matricula;

        public string Matricula { get => matricula; set => matricula = value; }

        public string MostraAluno()
        {
            string msg;
            return msg = MostraPessoa() + "Matricula do aluno;";
        }
    }
}
