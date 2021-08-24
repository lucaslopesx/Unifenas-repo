using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_escola
{
    class FuncNoturno:Funcionario
    {
        float adicNoturno;

        public float AdicNoturno { get => adicNoturno; set => adicNoturno = value; }

        public string MostraFuncNot()
        {
            string msg;
            return msg = MostraFunc() + "Hora da entrada do funcionário: ";
        }
    }
}
