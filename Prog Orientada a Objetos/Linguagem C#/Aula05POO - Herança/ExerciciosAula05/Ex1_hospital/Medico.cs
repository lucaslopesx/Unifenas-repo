using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_hospital
{
    class Medico:Pessoa
    {
        string crm;
        string especialidade;

        public string Crm { get => crm; set => crm = value; }
        public string Especialidade { get => especialidade; set => especialidade = value; }

        public string MostraMedico()
        {
            string msg;

            return msg = MostraPessoa() + "\nCRM: " + Crm + "\nEspecialidade: " + Especialidade;
        }
    }
}
