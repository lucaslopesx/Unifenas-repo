using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01
{
    class RedeProj:HardwareProj
    {
        private double configuracao;

        public double Configuracao { set => configuracao = value; }

        override public double CalculoCusto()
        {
            return base.CalculoCusto() + configuracao;
        }
    }
}
