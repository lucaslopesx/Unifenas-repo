using System;

namespace prova
{
    class Program
    {
        static void Main(string[] args)
        {
            ImpostoRenda obj = null;
            int op;
            Console.WriteLine("Digite 0 - Imposto Renda \n 1 - Imposto Especial");

            op = int.Parse(Console.ReadLine());
            if (op == 0) obj = new ImpostoRenda(2, 8);
            if (op == 1) obj = new ImpostoRendaEspecial(3, 2, 1, 6);
            Mostra(obj);

        }

        static void Mostra(ImpostoRenda aux)
        {
            Console.WriteLine("Resultado: " + aux.Resultado().ToString());
            Console.ReadKey();
        }
    }
}
