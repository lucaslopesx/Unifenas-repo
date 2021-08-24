using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    class Professor : Pessoa
    {
        private string titulacao;
            

        public string Titulacao { get => titulacao; set => titulacao = value; }

        public string MostraProfessor()
        {
            return MostraPessoa() + "\nTitulação : " + titulacao;
        }
    }
}
