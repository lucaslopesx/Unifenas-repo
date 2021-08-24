using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_hospital
{
    class Pessoa
    {
        string nome;
        string cpf;
        int idade;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public int Idade { get => idade; set => idade = value; }

        public string MostraPessoa()
        {
            string msg;
            return msg = "Nome: " + Nome + "\nIdade: " + Idade + "\nCPF: " + Cpf;
        }
    }
}
