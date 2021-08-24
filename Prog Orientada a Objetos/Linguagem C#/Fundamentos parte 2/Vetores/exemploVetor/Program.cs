using System;

namespace exemploVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 formas de declarar e inicializar vetores

            //1a. Forma
            int[] vetor1 = { 1, 2, 3, 4, 5 };

            //2a. Forma
            int[] vetor2 = new int[5];
            vetor2[0] = 2;
            vetor2[1] = 3;
            vetor2[2] = 4;
            vetor2[3] = 5;
            vetor2[4] = 6;

            //3a. Forma
            int[] vetor3;
            int tamanho;

            Console.Write("Tamanho do vetor 3: ");
            tamanho = int.Parse(Console.ReadLine());

            vetor3 = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Valor inteiro: ");
                vetor3[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vetor{1}");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vetor1[i]);
            }

            Console.WriteLine("Vetor {2}");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vetor2[i]);
            }

            Console.WriteLine("Vetor {3}");

            foreach (var item in vetor3)
            {
                Console.WriteLine(item);
            }
            //for (int i = 0; i < tamanho; i++)
            //{
            //    Console.WriteLine(vetor3[i]);
            //}
        }
    }
}
