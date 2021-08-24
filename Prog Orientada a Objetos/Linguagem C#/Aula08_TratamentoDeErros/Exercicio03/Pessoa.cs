using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Pessoa
    {
        string nome;
        int cpf;
        float salario;
        int taxa;

        public string Nome { get => nome; set => nome = value; }
        public int Cpf { get => cpf; set => cpf = value; }
        public float Salario { get => salario; set => salario = value; }
        public int Taxa { get => taxa; set => taxa = value; }
        public float MostraSalario()
        {
            return Salario / Taxa;
        }
        virtual public string Mostra()
        {
            return "Nome: " + Nome + "\nCPF: " + Cpf;
        }
    }
}
