using System;

namespace exemploStruct
{
    class Program
    {

        struct Funcionario
        {
            public string nome;
            public double salario;
        }

        static void Mostra(Funcionario p)
        {
            Console.WriteLine(p.nome + "   -   " + p.salario.ToString("0.00"));
        }

        static void Altera(ref Funcionario p)
        {
            p.nome = "Mauro";
            p.salario = 990.00;
        }
        static void Main(string[] args)
        {
            Funcionario f1, f2;
            f1.nome = "Lucas";
            f1.salario = 880.0;
            f2.nome = "Luiza";
            f2.salario = 900.0;


            Mostra(f1);
            Altera(ref f1);
            Mostra(f1);
            Mostra(f2);
            Console.ReadKey();
        }
    }
}
