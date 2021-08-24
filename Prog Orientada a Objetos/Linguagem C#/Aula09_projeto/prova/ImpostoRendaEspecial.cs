using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    class ImpostoRendaEspecial : ImpostoRenda
    {
        int valor3;
        int valor4;

        public ImpostoRendaEspecial(int valor1, int valor2, int valor3, int valor4) : base(valor1, valor2)
        {
            this.valor3 = valor3;
            this.valor4 = valor4;
        }

        public override int Resultado()
        {
            return base.Resultado() + valor3 + valor4;
        }

    }
}
