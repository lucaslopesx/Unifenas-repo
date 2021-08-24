using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    class Pessoa
    {
        private string nome;
        private int idade;
        private TCPF cpf;

        public Pessoa()
        {
            cpf = new TCPF();
        }

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public TCPF Cpf { get => cpf; set => cpf = value; }

        public string MostraPessoa()
        {
            return "Nome : " + Nome + "\nIdade : " + idade + "\nCpf : " + cpf.MostraCPF();
        }
    }
}
