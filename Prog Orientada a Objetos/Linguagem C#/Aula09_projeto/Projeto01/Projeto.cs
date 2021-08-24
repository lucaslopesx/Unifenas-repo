using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01
{
    class Projeto
    {
        private string responsavel;
        private string nome_proj;
        private double valor_hora;
        private int hora;
        
        public Projeto() { }

        public Projeto(string nomeProj)
        {
            this.nome_proj = nomeProj;
        }




        public string Responsavel { get => responsavel; set => responsavel = value; }
        public string Nome_proj { get => nome_proj; set => nome_proj = value; }
        public double Valor_hora { set => valor_hora = value; }
        public int Hora { get => hora; set => hora = value; }

        virtual public double CalculoCusto()
        {
            return (valor_hora * Hora);
        }
    }
}
