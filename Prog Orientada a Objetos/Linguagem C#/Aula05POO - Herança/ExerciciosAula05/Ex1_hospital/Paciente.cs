using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_hospital
{
    class Paciente:Pessoa
    {
        string plano;
        public string Plano { get => plano; set => plano = value; }

        public string MostraPaciente()
        {
            string msg;
            return msg = MostraPessoa() + "\n Plano: " + Plano;
        }
    }
}
