using System;

namespace InsertSort
{
    class Program
    {
        public static void InsertSort(int[] vet)
        {
            int tam = vet.Length;
            int aux, j;
            for (int i = 0; i < tam; i++)
            {
                aux = vet[i];
                j = i - 1;
                while (j >= 0 && vet[j] > aux)
                {
                    vet[j + 1] = vet[j];
                    j--;
                }
                vet[j + 1] = aux;
            }  
        }
        public static void InsertSortDec(int[] vet)
        {
            int tam = vet.Length;
            int aux, j;
            for (int i = 0; i < tam; i++)
            {
                aux = vet[i];
                j = i - 1;
                while (j >= 0 && vet[j] < aux)
                {
                    vet[j + 1] = vet[j];
                    j--;
                }
                vet[j + 1] = aux;
            }
        }
        static void Main(string[] args)
        {
            int[] vet = new int[5] { 3, 1, 0, 2, 4 };

            InsertSort(vet);

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }

            Console.WriteLine("");

            InsertSortDec(vet);

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
        }
    }
}
