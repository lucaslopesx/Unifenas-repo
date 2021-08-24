using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPolimorfismo
{
    class Gestor:Funcionario
    {
        string cargo;

        public string Cargo { get => cargo; set => cargo = value; }

        override public double CalculoSalario()
        {
            return Salario + 2000;
        }

        override public string mostra()
        {
            return base.mostra() + "Cargo: " + Cargo;
        }
    }
}
