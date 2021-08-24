using System;
using System.Collections.Generic;

namespace Projeto2
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    List<Funcionario> listFun = new List<Funcionario>();
        //    char ok = 's';

        //    Funcionario f;
        //    do
        //    {
        //        f = new Funcionario();

        //        Console.Write("Nome: ");
        //        f.Nome = Console.ReadLine();

        //        Console.Write("Salario: ");
        //        f.Salario = double.Parse(Console.ReadLine());
        //        listFun.Add(f);

        //        Console.WriteLine("Deseja continuar? (s/n): ");
        //        ok = char.Parse(Console.ReadLine());
        //    } while (ok == 's');
        //    Console.Clear();
        //    foreach (var item in listFun)
        //    {
        //        Console.WriteLine(item.Mostra() + "\n");
        //    }
        //    Console.ReadKey();
        //}


        static void Main(string[] args)
        {
            List<Funcionario> listFun = new List<Funcionario>();
            int op;

            Funcionario f;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Cadastrar Funcionario");
                Console.WriteLine("2. Mostrar Funcionarios");
                Console.WriteLine("3. Consultar um funcionario");
                Console.WriteLine("4. Sair");

                Console.Write("Digite sua opção ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        f = new Funcionario();

                        Console.Write("Nome: ");
                        f.Nome = Console.ReadLine();
                        Console.Write("Salario: ");
                        f.Salario = double.Parse(Console.ReadLine());

                        listFun.Add(f);
                        break;

                    case 2:
                        foreach (var item in listFun)
                        {
                            Console.WriteLine(item.Mostra() + "\n");
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Write("Nome do funcionario: ");
                        string nomeAux = Console.ReadLine();

                        foreach (var item in listFun)
                        {
                            if(item.Nome == nomeAux)
                            {
                                Console.WriteLine(item.Mostra() + "\n");
                                
                            }
                            
                        }
                        Console.ReadKey();
                        break;
                }
            } while (op != 4);


            Console.Clear();
            
            Console.ReadKey();
        }
    }
}
