using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01
{
    class SoftwareProj:Projeto
    {

        private double consultoria;

        public SoftwareProj(string nomeProj) : base(nomeProj) { }

        public double Consultoria { get => consultoria; set => consultoria = value; }

        override public double CalculoCusto()
        {
            return base.CalculoCusto() + Consultoria;
        }
    }
}
