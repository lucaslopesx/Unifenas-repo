using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_1
{
    class Medico:Pessoa
    {
        private string crm;
        private string especialidade; 

        public string Crm {  set => crm = value; }
        public string Especialidade { set => especialidade = value; }

        public string MostraMedico()
        {
            string aux;
            aux =Mostra()+"\nCrm : " + crm + "\nEspecialidade : " + especialidade;
            return aux;
        }
    }
}
