using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01
{
    class Animal
    {
        string nome;

        public string Nome { get => nome; set => nome = value; }

        virtual public string Mostra()
        {
            return "classe Animal";
        }
        
    }
}
