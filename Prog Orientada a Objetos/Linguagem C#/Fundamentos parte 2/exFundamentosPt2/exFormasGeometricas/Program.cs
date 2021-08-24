using System;

namespace exFormasGeometricas
{
    class Program
    {
        struct FormasGeometricas
        {
            public double largura;
            public double altura;
        }

        static double AreaTriangulo(FormasGeometricas FG)
        {
            return (FG.largura * FG.altura)/2;
        }

        static void Gravar(ref FormasGeometricas FG)
        {
            Console.Clear();
            Console.Write("Digite a largura do triangulo: ");
            FG.largura = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura do triangulo: ");
            FG.altura = double.Parse(Console.ReadLine());
        }

        static void Mostrar(FormasGeometricas FG)
        {
            Console.Clear();
            Console.WriteLine("O triangulo possui " + FG.largura + "cm de largura e " + FG.altura + "cm de altura");
            Console.WriteLine("Logo sua area corresponde a " + AreaTriangulo(FG) + "cm");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int op;
            FormasGeometricas FG = new FormasGeometricas();
            do
           
                Console.Clear();
                Console.WriteLine("=========FORMAS GEOMETRICAS=========");
                Console.WriteLine("1. Gravar medidas do triangulo");
                Console.WriteLine("2. Mostrar resultado da area do triangulo");
                Console.WriteLine("3. Sair");
                Console.WriteLine("====================================");
                Console.Write("Digite a opção desejada: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Gravar(ref FG);
                        break;
                    case 2:
                        Mostrar(FG);
                        break;             
                }

            } while (op != 3);


        }
    }
}
