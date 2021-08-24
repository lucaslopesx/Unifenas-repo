using System;

namespace exFormasGeometricasParte2
{
    class Program
    {
        static void Main(string[] args)
        { 
            FormasGeometricas FG = new FormasGeometricas();
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("=========FORMAS GEOMETRICAS=========");
                Console.WriteLine("1. Gravar medidas do triangulo");
                Console.WriteLine("2. Mostrar dados");
                Console.WriteLine("3. Sair");
                Console.WriteLine("====================================");
                Console.Write("Digite a opção desejada: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Write("Digite a ALTURA: ");
                        FG.Altura = double.Parse(Console.ReadLine());

                        Console.Write("Digite a LARGURA: ");
                        FG.Largura = double.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("\n" + FG.Mostrar());
                        Console.ReadKey();
                        break;
                }

            } while (op != 3);


        }
    }
}
