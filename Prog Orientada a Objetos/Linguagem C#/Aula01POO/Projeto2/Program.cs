using System;

namespace Projeto2
{
    class FormasGeometricas
    {
        string nomeForma;
        double largura;
        double altura;

        public FormasGeometricas(string aux)
        {
            nomeForma = aux;
            Console.WriteLine("Oi estou construindo seu objeto e logo te retornarei o endereço onde você será alocado" + nomeForma);
            Console.ReadKey();
        }
    

        double AreaTriangulo()
        {
            return (largura * altura) / 2;
        }

        public void Gravar()
        {
            Console.Clear();
            Console.Write("Informe a largura do triangulo: ");
            largura = double.Parse(Console.ReadLine());
            if (largura < 0) largura = 0;

            Console.Write("Informe a altura do triangulo: ");
            altura = double.Parse(Console.ReadLine());
            if (altura < 0) altura = 0;
        }

        public void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("O triangulo possui " + largura + "cm de largura e " + altura + "cm de altura");
            Console.WriteLine("Logo sua area corresponde a " + AreaTriangulo() + "cm");
            Console.ReadKey();
        }
    }

    class Program
    {
       

        static void Main(string[] args)
        {
            int op;
            string aux = "piramide";
            FormasGeometricas fg = new FormasGeometricas(aux);
            Console.WriteLine(fg);
            Console.ReadKey();
            fg.Gravar();
            fg.Mostrar();
            Console.ReadKey();
        }
    }
}

