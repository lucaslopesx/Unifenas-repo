using System;

namespace exemploFuncao
{
    class Program
    {
        //Função com parametro por valor
        static void MetodoV(int parametro1)
        {
            parametro1 += 100;
        }

        //Função com parametro por referencia

        static void MetodoR(ref int parametro1)
        {
            parametro1 += 100;
        }
        static void MetodoVetorR(int[] parametro, int t)
        {
            for (int i = 0; i < 5; i++)
            {
                parametro[i] = 20;
            }
        }
        static void Main(string[] args)
        {
            int valor1 = 5;
            MetodoV(valor1);
            Console.WriteLine("Valor: " + valor1);
            Console.ReadKey();
            int valor2 = 3;
            MetodoR(ref valor2);
            Console.WriteLine("Valor: " + valor2);
            Console.ReadKey();
            int[] vetor = { 1, 2, 3, 4, 5 };
            MetodoVetorR(vetor, 5);
            foreach (var item in vetor)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
