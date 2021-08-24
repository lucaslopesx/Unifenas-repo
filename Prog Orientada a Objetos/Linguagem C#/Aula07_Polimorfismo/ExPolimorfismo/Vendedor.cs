using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPolimorfismo
{
    class Vendedor:Funcionario
    {
        double vendas;

        public double Vendas { get => vendas; set => vendas = value; }

        override public double CalculoSalario()
        {
            return base.Salario + (0.4 * Vendas);
        }
        override public string mostra()
        {
            return base.mostra() + "Vendedor";
        }
    }
}
