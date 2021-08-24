using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_1
{
    class Pessoa
    {
        private string cpf;
        private int idade;
        private string nome;

        public string Cpf {set => cpf = value; }
        public int Idade { set => idade = value; }
        public string Nome { set => nome = value; }

        public string Mostra()
        {
            string aux;
            aux = "Nome : " + nome + "\nCpf : " + cpf + "\nIdade : " + idade;
            return aux;
        }
    }
}
