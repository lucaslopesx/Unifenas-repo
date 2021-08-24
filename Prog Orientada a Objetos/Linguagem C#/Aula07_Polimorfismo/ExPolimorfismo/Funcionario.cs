using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPolimorfismo
{
    class Funcionario
    {
        string nome;
        double salario;

        public string Nome { get => nome; set => nome = value; }
        public double Salario { get => salario; set => salario = value; }

        virtual public double CalculoSalario()
        {
            return Salario;
        }

        virtual public string mostra()
        {
            return nome + " - ";
        }
    }
}
