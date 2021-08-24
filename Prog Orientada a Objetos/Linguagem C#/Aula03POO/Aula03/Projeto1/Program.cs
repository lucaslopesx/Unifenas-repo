using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario[] vetor = null;
            Console.Write("Digite quantos funcionarios deseja cadastrar: ");
            int x = int.Parse(Console.ReadLine());

            vetor = new Funcionario[x];

            for (int i = 0; i < x; i++)
            {
                vetor[i] = new Funcionario();

                Console.Write("Nome: ");
                vetor[i].Nome = Console.ReadLine();

                Console.Write("Salario: ");
                vetor[i].Salario = double.Parse(Console.ReadLine());
            }
            Console.Clear();
            foreach (var item in vetor)
            {
                Console.WriteLine(item.Mostra() + "\n");
            }
            Console.ReadKey();
        }
    }
}
