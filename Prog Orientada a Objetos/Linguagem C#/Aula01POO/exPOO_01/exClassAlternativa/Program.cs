using System;

namespace exClassAlternativa
{
    class Aluno
    {
        private string matricula;
        private string nome;
        private double[] notas;

        public Aluno()
        {
            notas = new double[4];
        }
        public void GravaAluno(string matricula, string nome, double[] notas)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.notas = notas;
        }
        public string MostraAluno()
        {
            string aux;
            aux = ("Nome: " + nome + "\nMatricula: " + matricula + "\n Notas: ");
            foreach (var item in notas)
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
            string matricula, nome;
            double[] notas = new double[4];
            Aluno a1;
            Console.WriteLine("=======GRAVANDO ALUNO=======");
            Console.Write("Digite o numero da matricula do aluno: ");
            matricula = Console.ReadLine();
            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Digite a " + (i+1) + "a nota do aluno: ");
                notas[i] = double.Parse(Console.ReadLine());
            }
            a1 = new Aluno();
            a1.GravaAluno(matricula, nome, notas);
            Console.WriteLine("");

            Console.ReadKey();
            Console.WriteLine(a1.MostraAluno());
        }
    }
}
