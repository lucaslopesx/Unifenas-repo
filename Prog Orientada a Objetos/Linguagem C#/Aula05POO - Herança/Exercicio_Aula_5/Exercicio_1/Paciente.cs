using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_1
{
    class Paciente:Pessoa
    {
        private string plano;

        public string Plano { get => plano; set => plano = value; }

        public string MostraPaciente()
        {
            string aux;
            aux = Mostra() +  "\nPlano : " + plano;
            return aux;
        }
    }
}
