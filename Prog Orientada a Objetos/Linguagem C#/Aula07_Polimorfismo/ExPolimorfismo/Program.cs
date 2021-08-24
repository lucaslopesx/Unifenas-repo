using System;
using System.Collections.Generic;

namespace ExPolimorfismo
{
    class Program
    {
        static void Main()
        {
            List<Funcionario> lista = new List<Funcionario>();
            Gestor g;
            Vendedor v;
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("1.Cadastrar Gestor");
                Console.WriteLine("2.Cadastrar Vendedor");
                Console.WriteLine("3.Mostrar Dados de Gestor e Vendedor");
                Console.WriteLine("4.Mostrar Salários de um determinado Funcionário");
                Console.WriteLine("5.Sair");
                Console.Write("Digite sua opção: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        g = new Gestor();
                        cadastro(g);
                        Console.Write("Cargo: ");
                        g.Cargo = Console.ReadLine();
                        lista.Add(g);
                        break;
                    case 2:
                        v = new Vendedor();
                        cadastro(v);
                        Console.Write("Valor referente às Vendas: ");
                        v.Vendas = double.Parse(Console.ReadLine());
                        lista.Add(v);
                        break;
                    case 3:
                        for (int i = 0; i < lista.Count; i++)
                        {
                            Console.WriteLine(lista[i].mostra());
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("Nome: ");
                        string pesquisa = Console.ReadLine();
                        for (int i = 0; i < lista.Count; i++)
                        {
                            if (lista[i].Nome == pesquisa)
                            {
                                Console.WriteLine(lista[i].mostra());
                                Console.WriteLine("Salário: " + lista[i].CalculoSalario().ToString("0.00"));
                            }
                        }
                        Console.ReadKey();
                        break;
                } 
            } while (op != 5);
        }
        static void cadastro(Funcionario f)
        {
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f.Salario = double.Parse(Console.ReadLine());
        }
    }
    
}
