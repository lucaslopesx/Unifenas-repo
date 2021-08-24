using System;

namespace BubbleSort
{
    class Program
    {
        public static void BubbleSort(int[] vet)
        {
            int tam = vet.Length;
            for (int ultimo = tam-1; ultimo > 0; ultimo--)
            {
                for (int i = 0; i < ultimo; i++)
                {
                    if (vet[i] > vet[i+1])
                    {
                        int aux = vet[i];
                        vet[i] = vet[i + 1];
                        vet[i + 1] = aux;
                    }
                }
            }
        }
        public static void BubbleSortDec(int[] vet)
        {
            int tam = vet.Length;
            for (int ultimo = tam - 1; ultimo > 0; ultimo--)
            {
                for (int i = 0; i < ultimo; i++)
                {
                    if (vet[i] < vet[i + 1])
                    {
                        int aux = vet[i];
                        vet[i] = vet[i + 1];
                        vet[i + 1] = aux;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] vet = new int[5] { 6, 4, 2, 1, 8 };
            

            BubbleSort(vet);

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }

            Console.WriteLine("");

            BubbleSortDec(vet);

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
        }
    }
}
