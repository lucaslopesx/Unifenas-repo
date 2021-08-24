using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    class ImpostoRenda
    {
        int valor1;
        int valor2;
        public ImpostoRenda(int valor1, int valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }

        virtual public int Resultado()
        {
            return valor1 + valor2;
        }
    }
}
