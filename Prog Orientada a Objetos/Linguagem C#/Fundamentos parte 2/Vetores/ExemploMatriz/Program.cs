using System;

namespace ExemploMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 Formas de declarar e inicializar uma matriz

            //1a. Forma
            int[,] matriz1 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //2a. Forma
            int[,] matriz2 = new int[2, 3];
            matriz2[0, 0] = 1;
            matriz2[0, 1] = 2;
            matriz2[0, 2] = 3;
            matriz2[1, 0] = 4;
            matriz2[1, 1] = 5;
            matriz2[1, 2] = 6;

            //3a. Forma
            int[,] matriz3;
            int linha, coluna;
            Console.Write("Linhas: ");
            linha = int.Parse(Console.ReadLine());
            Console.Write("Colunas: ");
            coluna = int.Parse(Console.ReadLine());

            matriz3 = new int[linha, coluna];
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write("Valor: ");
                    matriz3[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz {1}");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matriz {2}");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matriz {3}");
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write(matriz3[i, j] + "\t");
                }
                Console.WriteLine();
            }
            
        }

    }
}
