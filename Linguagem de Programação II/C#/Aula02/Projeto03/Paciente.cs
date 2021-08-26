using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03
{
    class Paciente
    {
        private int codigo;
        private string nome;
        private char sexo;
        private string cidade;
        private bool febreamarela;
        private bool poliomelite;
        private bool catapora;

        public int Codigo { get => codigo; }
        public string Nome { get => nome; }
        public char Sexo { get => sexo; set => sexo = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public bool Febreamarela { get => febreamarela; set => febreamarela = value; }
        public bool Poliomelite { get => poliomelite; set => poliomelite = value; }
        public bool Catapora { get => catapora; set => catapora = value; }

        public Paciente(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }

        public string mostra()
        {
            string msg;
            msg = "Nome: " + Nome + "   Vacinas: ";
            msg += Febreamarela == true ? "Febre Amarela " : "";
            msg += Poliomelite == true ? "Poliomelite " : "";
            msg += Catapora == true ? "Catapora " : "";
            return msg;
        }
    }
}
