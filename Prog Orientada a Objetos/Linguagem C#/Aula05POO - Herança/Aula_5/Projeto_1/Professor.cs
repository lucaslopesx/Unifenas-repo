using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_1
{
    class Professor:Pessoa
    {
        private string titulacao;

        public Professor(string nome) : base(nome)
        {

        }
        public string Titulacao { get => titulacao; set => titulacao = value; }

        public string MostraProfessor()
        {
            return MostraPessoa() + "\nTitulação : " + titulacao;
        }
    }
}
