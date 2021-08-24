using System;

namespace Projeto04
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            do
            {
                Console.Write("Digite um numero inteiro ( 0 para sair ): ");
                x = int.Parse(Console.ReadLine());

                if (x % 2 == 0)
                {
                    Console.WriteLine("O número é par!!! ");
                }
                else
                {
                    Console.WriteLine("O número é ímpar!!! ");
                }


            }
            while (x != 0);

            Console.ReadKey();
        }
    }
}
