using System;

namespace SelectSort
{
    class Program
    {
        public static void SelectSort(int[] vet)
        {
            int tam = vet.Length;
            for (int i = 0; i < tam; i++)
            {
                int min = i;
                for (int j = i + 1; j < tam; j++)
                {
                    if (vet[j] < vet[min])
                    {
                        min = j;
                    }
                }
                if (vet[i] != vet[min])
                {
                    int aux = vet[i];
                    vet[i] = vet[min];
                    vet[min] = aux;
                }
                
            }
        }
        public static void SelectSortDec(int[] vet)
        {
            int tam = vet.Length;
            for (int i = 0; i < tam; i++)
            {
                int max = i;
                for (int j = i + 1; j < tam; j++)
                {
                    if (vet[j] > vet[max])
                    {
                        max = j;
                    }
                }
                if (vet[i] != vet[max])
                {
                    int aux = vet[i];
                    vet[i] = vet[max];
                    vet[max] = aux;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] vet = new int[6] { 6, 1, 5, 4, 0, 8 };

            SelectSort(vet);

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }

            SelectSortDec(vet);
            Console.WriteLine("");

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
        }
    }
}
