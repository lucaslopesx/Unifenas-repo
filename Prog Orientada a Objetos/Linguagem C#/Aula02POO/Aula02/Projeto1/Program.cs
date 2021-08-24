using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            Console.Write("Digite o nome: ");
            a1.Nome = Console.ReadLine();
            Console.Write("Digite a matricula: ");
            a1.Matricula = Console.ReadLine();

            double[] aux = new double[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Digite a " + (i + 1) + "a nota: ");
                aux[i] = double.Parse(Console.ReadLine());
            }

            a1.VetNota = aux;

            Console.WriteLine("\n" + a1.Nome + " - " + a1.MostraNota);

            Console.WriteLine("\n" + a1.MostraAluno());
        }
    }
}
