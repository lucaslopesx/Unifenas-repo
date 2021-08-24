using System;

namespace exAula_03
{
    class Aluno
    {
        private string matricula;
        private string nome;
        private double[] vetor;


        public string Aux
        {
            get { return nome; }
            set { this.nome = value.ToUpper(); }
        }

        //public void setNome(string nome)
        //{
        //    this.nome = nome.ToUpper();
        //}
        //public string getNome()
        //{
        //    return nome;
        //}

        public Aluno()
        {
            vetor = new double[4];
        }
        public void GravaAluno(string matricula, string nome, double[] vetor)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.vetor = vetor;
        }
        public string MostraAluno()
        {
            string aux;
            aux = ("Nome: " + nome + "\nMatricula: " + matricula + "\n Notas: ");
            foreach (var item in vetor)
            {
                aux += "\n" + item;
            }
            return aux;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            Console.Write("Digite o nome do aluno: ");
            a1.Aux = "lucas";
            Console.WriteLine(a1.Aux);

            Console.ReadKey();
        }
    }
}
