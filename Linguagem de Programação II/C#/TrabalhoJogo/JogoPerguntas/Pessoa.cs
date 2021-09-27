using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPerguntas
{
    class Pessoa
    {
        private string nome;
        private int pontos;

        public string Nome { get => nome; set => nome = value; }
        public int Pontos { get => pontos; set => pontos = value; }
    }
}
