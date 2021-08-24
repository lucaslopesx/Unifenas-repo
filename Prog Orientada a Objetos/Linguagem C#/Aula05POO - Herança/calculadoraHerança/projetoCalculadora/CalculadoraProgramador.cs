using System;
using System.Collections.Generic;
using System.Text;

namespace projetoCalculadora
{
    class CalculadoraProgramador:CalculadoraPadrao
    {
        public CalculadoraProgramador(double regx, double regy):base(regx, regy)
        { }
        public string binario()
        {
            int y = Convert.ToInt32(soma());
            return Convert.ToString(y, 2);
        }
    }
}
