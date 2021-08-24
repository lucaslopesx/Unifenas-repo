using System;
using System.Collections.Generic;

namespace projetoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estoque> listEstoque = new List<Estoque>();
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("1 – Criar objeto e adicionar na Lista");
                Console.WriteLine("2 – Mostrar todos os objetos da Lista");
                Console.WriteLine("3 – Consultar um determinado objeto da Lista por um de seus atributos.");
                Console.WriteLine("4 – Sair.");

                Console.Write("Digite sua opção: ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        string nomeLocal;
                        Console.Write("Digite o nome do local do estoque: ");
                        nomeLocal = Console.ReadLine();
                        Estoque est = new Estoque(nomeLocal);

                        Console.Write("Digite o nome do produto: ");
                        est.NomeProd = Console.ReadLine();
                        
                        Console.Write("Digite a quantidade do produto: ");
                        est.Quantidade = int.Parse(Console.ReadLine());

                        listEstoque.Add(est);
                        break;
                    case 2:

                        
                        break;

                    case 3:
                        Console.Write("Nome do produto: ");
                        string nomeAux = Console.ReadLine();

                        foreach (var item in listEstoque)
                        {
                            if (item.NomeProd == nomeAux)
                            {
                                Console.WriteLine(item.MostraEstoque() + "\n");
                                break;
                            }

                        }
                        Console.ReadKey();
                        break;
                }

            } while (op!=4);
        }
    }
}
