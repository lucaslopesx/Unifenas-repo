using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_escola
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
        internal TCPF Cpf { get => cpf; set => cpf = value; }

        public string MostraPessoa()
        {
            string msg;
            return msg = "Nome: " + Nome + "\nIdade: " + Idade + cpf.MostraCPF();
        }
    }
}
