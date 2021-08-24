using System;

namespace InsertSort
{
    class Program
    {
        public static void InsertSort(int[] vet)
        {
            int tam = vet.Length;
            
             
        }
        static void Main(string[] args)
        {
            int[] vet = new int[5] { 3, 1, 0, 2, 4 };

            InsertSort(vet);

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
        }
    }
}
