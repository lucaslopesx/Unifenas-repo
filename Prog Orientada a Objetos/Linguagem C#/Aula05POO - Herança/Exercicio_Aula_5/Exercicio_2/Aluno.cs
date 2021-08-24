using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    class Aluno : Pessoa
    {
        private string matricula;

        public string Matricula { get => matricula; set => matricula = value; }

        public string MostraAluno()
        {
            return MostraPessoa() + "\nMatricula : " + matricula;
        }
    }
}
