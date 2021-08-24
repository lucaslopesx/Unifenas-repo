using System;
using System.Collections.Generic;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
                List<Funcionario> listFunc = new();
                int op;
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Cadastrar professor ");
                    Console.WriteLine("2. Mostrar professor ");
                    Console.WriteLine("3. Sair");
                    Console.Write("Digite sua opção: ");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Funcionario func = new Funcionario();
                            Console.Write("Nome: ");
                            func.Nome = Console.ReadLine();
                            Console.Write("Cpf: ");
                            func.Cpf = int.Parse(Console.ReadLine());
                            Console.Write("Cargo: ");
                            func.Cargo = Console.ReadLine();
                            Console.Write("Salario: ");
                            func.Salario = float.Parse(Console.ReadLine());
                            Console.Write("Taxa: ");
                            func.Taxa = int.Parse(Console.ReadLine());

                        listFunc.Add(func);
                            break;
                        case 2:
                            for (int i = 0; i < listFunc.Count; i++)
                            {
                                Console.WriteLine(listFunc[i].Mostra());
                            Console.WriteLine(listFunc[i].MostraSalario());
                            Console.WriteLine("-----------------------");
                            }
                            Console.ReadKey();
                            break;
                    }
                } while (op != 3);
            
            
        }
    }
}
