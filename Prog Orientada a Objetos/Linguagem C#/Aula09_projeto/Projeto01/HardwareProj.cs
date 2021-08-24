using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01
{
    class HardwareProj:Projeto
    {
        private double placa;
        private double componentes;

        public double Placa { set => placa = value; }
        public double Componentes { set => componentes = value; }

        public override double CalculoCusto()
        {
            return base.CalculoCusto() + placa + componentes;
        }
    }
}
