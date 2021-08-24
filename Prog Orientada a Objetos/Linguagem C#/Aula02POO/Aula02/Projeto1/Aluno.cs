using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto1
{
    class Aluno
    {
        private string nome;
        private string matricula;
        private double[] vetNota;

        //public void gravaNome(string value)
        //{
        //    this.nome = value;
        //}
        //public string leNome()
        //{
        //    return nome;
        //}

        public Aluno()
        {
            vetNota = new double[4];
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value != "")
                {
                    this.nome = value;
                }
            }
            
        }

        public string Matricula { get => matricula; set => matricula = value.ToUpper(); }
        public double[] VetNota { set => vetNota = value; }

        public string MostraNota
        {
            get
            {
                string aux = "";               
                foreach (var item in vetNota)
                {
                    aux += "\n" + item;
                }
                return aux;
            }
        }

        public string MostraAluno()
        {
            string aux = "";
            aux = "Nome: " + nome;
            aux += "\nMatricula: " + matricula;
            aux += "\nNotas: ";
            foreach (var item in vetNota)
            {
                aux += "\n" + item;
            }
            return aux;
        }
    }
}
