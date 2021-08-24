using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    class Funcionario : Pessoa
    {
        private string cargo;
        private double salario;

        public string Cargo { get => cargo; set => cargo = value; }
        public double Salario { get => salario; set => salario = value; }

        public string MostraFuncionario()
        {
            string aux;
            aux = MostraPessoa() + "\nCargo : " + cargo + "\nSalario : " + salario;
            return aux;
        }
    }
}
