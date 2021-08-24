using System;
using System.Collections.Generic;

namespace TrabalhoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Navio> listNavio = new List<Navio>();
            List<Automovel> listAuto = new List<Automovel>();
            Automovel a;
            Navio n;
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("1 – Cadastrar automovel");
                Console.WriteLine("2 – Cadastrar navio");
                Console.WriteLine("3 – Consultar um determinado automovel por seu tipo");
                Console.WriteLine("4 – Consultar um determinado navio por seu tipo");
                Console.WriteLine("5 - Sair");

                Console.Write("Digite sua opção: ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        string codigo, tipoV;

                        Console.Write("Digite o código do veiculo: ");
                        codigo = Console.ReadLine();
                        Console.Write("Digite o tipo do automovel: ");
                        tipoV = Console.ReadLine();

                        a = new Automovel(codigo, tipoV);

                        
                        Console.Write("Digite a marca do veículo: ");
                        a.Marca = Console.ReadLine();
                        Console.Write("Digite a cor do veiculo: ");
                        a.Cor = Console.ReadLine();
                        Console.Write("Digite a quantidade de portas: ");
                        a.QntdPortas = int.Parse(Console.ReadLine());
                        Console.Write("Digite o tipo de combustível: ");
                        a.TipoComb = Console.ReadLine();
                        listAuto.Add(a);
                        break;
                    case 2:
                        string cod;
                        float compN;
                        Console.Write("Digite o código do navio: ");
                        cod = Console.ReadLine();
                        Console.Write("Digite o comprimento do navio: ");
                        compN = float.Parse(Console.ReadLine());

                        n = new Navio(cod, compN);

                        Console.Write("Digite o tipo do navio: ");
                        n.TipoNavio = Console.ReadLine();
                        Console.Write("Digite a marca do navio: ");
                        n.Marca = Console.ReadLine();
                        Console.Write("Digite a cor do navio: ");
                        n.Cor = Console.ReadLine();
                        Console.Write("Digite a carga máxima: ");
                        n.CargaMax = float.Parse(Console.ReadLine());
                        listNavio.Add(n);
                        break;
                    case 3:
                        Console.WriteLine("======Pesquisa por automóveis======");
                        Console.Write("Digite o tipo do automóvel: ");
                        string nomeAux = Console.ReadLine();
                        foreach (var item in listAuto)
                        {
                            if(item.TipoVeiculo == nomeAux)
                            Console.WriteLine(item.MostraAutomovel() + "\n");
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("======Pesquisa por navios======");
                        Console.Write("Digite o tipo do navio: ");
                        string nomeAux2 = Console.ReadLine();
                        foreach (var item in listNavio)
                        {
                            if (item.TipoNavio == nomeAux2)
                                Console.WriteLine(item.MostraNavio() + "\n");
                        }
                        Console.ReadKey();
                        break;
                }

            } while (op != 5);


        }
    }
}
