using System;

namespace projetoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraPadrao c = new CalculadoraPadrao(1, 4);
            Console.WriteLine(c.soma());
            CalculadoraCientifica cc = new CalculadoraCientifica(2, 5);
            Console.WriteLine(cc.cubo());
            Console.WriteLine(cc.soma());
            CalculadoraProgramador cp = new CalculadoraProgramador(2, 3);
            Console.WriteLine(cp.binario());
            Console.WriteLine(cp.soma());
            Console.ReadKey();
        }
    }
}
