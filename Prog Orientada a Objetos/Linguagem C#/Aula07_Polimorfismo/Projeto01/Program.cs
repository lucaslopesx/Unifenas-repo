using System;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro c = new Cachorro();
            MetodoMostra(c);
        }

        static void MetodoMostra(Animal a)
        {
            a.Nome = "Bidu";
            Console.WriteLine(a.Mostra());
        }
    }
}
