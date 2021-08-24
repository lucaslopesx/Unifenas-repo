using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_1
{
    class Pessoa
    {
        private string nome;
        private int idade;

        //public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Nome { get => nome;}

        public Pessoa(string nome)
        {
            this.nome = nome;
        }
        public string MostraPessoa()
        {
            return "Nome : " + Nome + "\nIdade : " + idade;
        }
    }
}
