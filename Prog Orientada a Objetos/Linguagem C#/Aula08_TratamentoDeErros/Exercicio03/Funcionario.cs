using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Funcionario:Pessoa
    {
        string cargo;
        public string Cargo { get => cargo; set => cargo = value; }

        override public string Mostra()
        {
            return base.Mostra() + "\nCargo: " + Cargo;
        }
    }
}
