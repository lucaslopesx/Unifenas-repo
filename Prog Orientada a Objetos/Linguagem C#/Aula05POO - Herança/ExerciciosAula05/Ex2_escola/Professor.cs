using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_escola
{
    class Professor:Pessoa
    {
        string titulo;

        public string Titulo { get => titulo; set => titulo = value; }

        public string MostraProfessor()
        {
            string msg;
            return msg = MostraPessoa() + "Título do professor: " + Titulo;
        }
    }
}
