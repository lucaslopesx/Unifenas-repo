using System;
using System.Collections.Generic;
using System.Text;

namespace projetoCalculadora
{
    class CalculadoraPadrao
    {
        protected double regx;
        protected double regy;

        public CalculadoraPadrao(double regx, double regy)
        {
            this.regx = regx;
            this.regy = regy;
        }

        public double soma()
        {
            return 1000 * (regx + regy);
        }
    }
}
