using System;
namespace Projeto01
{
    class Matematica
    {
        //Funçoes com o mesmo nome
        //porem com paramentros diferentes;

        int x;
        int y;

        public Matematica()
        {
            Console.WriteLine("Sou o construtor vazio");
        }
        public Matematica(int x)
        {
            Console.WriteLine("Sou o construtor de x");
            this.x = x;
        }
        public Matematica(int x, int y)
        {
            this.x = x;
            this.y = y;

            Console.WriteLine("Sou o construtor de x e y");
        }

        public string soma(int a, int b)
        {
            return "Soma de tipos inteiros: " + (a + b).ToString();
        }
        public string soma(double a, double b)
        {
            return "Soma de tipo double: " + (a + b).ToString();
        }
        public string soma(int a, int b, int c)
        {
            return "Soma 3 numeros tipo inteiros: " + (a + b + c).ToString();
        }

    }
}