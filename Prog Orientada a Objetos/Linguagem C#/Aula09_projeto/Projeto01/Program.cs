using System;
using System.Collections.Generic;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Projeto> lista = new();
            HardwareProj hard = null;
            SoftwareProj soft = null;
            RedeProj rede = null;

            int op = 0;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1. Cadastrar Projeto de Hardware");
                    Console.WriteLine("2. Cadastrar Projeto de Software");
                    Console.WriteLine("3. Cadastrar Projeto de Rede");
                    Console.WriteLine("4. Consultar Projeto por Responsável");
                    Console.WriteLine("5. Consultar Projeto de Maior Custo");
                    Console.WriteLine("6. Consultar Projeto por quantidade de horas gasta");
                    Console.WriteLine("7. Sair");

                    Console.Write("Digite sua opção: ");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            hard = new();
                            Cadastra(hard);
                            CadastraHard(hard);
                            lista.Add(hard);
                            break;
                        case 2:
                            Console.Write("Nome do projeto: ");
                            string nomeProj = Console.ReadLine();
                            soft = new(nomeProj);
                            Cadastra(soft);
                            Console.Write("Custo da consultoria: ");
                            soft.Consultoria = double.Parse(Console.ReadLine());
                            lista.Add(soft);
                            break;
                        case 3:
                            rede = new();
                            Cadastra(rede);
                            CadastraHard(rede);
                            Console.Write("Custo da configuracao da rede: ");
                            rede.Configuracao = double.Parse(Console.ReadLine());
                            lista.Add(rede);
                            break;
                        case 4:
                            Console.Write("Digite o nome do responsável: ");
                            string resp = Console.ReadLine();

                            int countS = 0;
                            int countH = 0;
                            int countR = 0;


                            foreach (Projeto item in lista)
                            {
                                if (item.Responsavel == resp)
                                {
                                    Console.WriteLine(item.Nome_proj);
                                    if (item is HardwareProj)
                                        countH++;
                                    if (item is SoftwareProj)
                                        countS++;
                                    else if (item is RedeProj)
                                        countR++;
                                }
                            }
                            Console.WriteLine("Resumo... \n Projetos de Hardware: " + countH);
                            Console.WriteLine("\n Projetos de Software: " + countS);
                            Console.WriteLine("\n Projetos de Rede: " + countR);
                            Console.ReadKey();
                            break;

                        case 5:
                            double valorRef = lista[0].CalculoCusto();
                            Projeto aux = null;

                            foreach (Projeto item in lista)
                            {
                                if (item.CalculoCusto() > valorRef)
                                {
                                    valorRef = item.CalculoCusto();
                                    aux = item;
                                }
                            }
                            Console.WriteLine("Projeto: " + aux.Nome_proj + "\nCusto do Projeto: " + aux.CalculoCusto().ToString("0.00"));
                            Console.ReadKey();
                            break;

                        case 6:
                            Console.Write("Digite o nome do responsável: ");
                            string respo = Console.ReadLine();
                            int somaHora = 0;

                            foreach (Projeto item in lista)
                            {
                                if (item.Responsavel == respo)
                                {
                                    Console.WriteLine(item.Nome_proj);
                                    somaHora += item.Hora;
                                }
                            }
                            Console.WriteLine("Horas trabalhadas: " + somaHora.ToString());
                            Console.ReadKey();
                            break;
                    }
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Start again...");
                    Console.ReadKey();
                }
            } while (op != 7);
        }

        static void Cadastra(Projeto aux)
        {
            if(aux is HardwareProj)
            {
                Console.Write("Nome do projeto: ");
                aux.Nome_proj = Console.ReadLine();
            }
            Console.Write("Nome do responsavel: ");
            aux.Responsavel = Console.ReadLine();
            Console.Write("Valor por hora: ");
            aux.Valor_hora = double.Parse(Console.ReadLine());
            Console.Write("Quantidade de hora: ");
            aux.Hora = int.Parse(Console.ReadLine());
        }

        static void CadastraHard(HardwareProj aux)
        {
            Console.Write("Custo da placa: ");
            aux.Placa = double.Parse(Console.ReadLine());
            Console.Write("Custo dos componentes: ");
            aux.Componentes = double.Parse(Console.ReadLine());
        }
    }
}
