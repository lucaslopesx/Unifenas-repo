using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04
{
    class Pessoa
    {
        private int codigo;
        private string nome;
        private int idade;
        private char sexo;
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public Pessoa(int codigo, string nome, short idade, char sexo)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
        }

    }
}
