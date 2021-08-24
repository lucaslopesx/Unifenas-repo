using System;
using System.Collections.Generic;

namespace Projeto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Professor> lp = new List<Professor>();
            List<Aluno> la = new List<Aluno>();
            Professor p = null;
            Aluno a = null;
            Pessoa pe;
            int op;
            string nome;
            do
            {
                Console.Clear();
                Console.WriteLine("===============================");
                Console.WriteLine("1-Cadastrar Professor.");
                Console.WriteLine("2-Cadastrar Aluno.");
                Console.WriteLine("3-Pesquisar Professor pelo nome.");
                Console.WriteLine("4-Psquisar Aluno pela idade.");
                Console.WriteLine("5-Sair");
                Console.WriteLine("===============================");
                Console.Write("Digite sua opção  : ");
                op = int.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.Write("Digite o nome do professor : ");
                            nome = Console.ReadLine();
                            p = new Professor(nome);
                            Console.Write("Digite a idade do professor : ");
                            p.Idade = int.Parse(Console.ReadLine());
                            Console.Write("Digite a titulação : ");
                            p.Titulacao = Console.ReadLine();
                            lp.Add(p);
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.Write("Digite o nome do Aluno : ");
                            nome = Console.ReadLine();
                            a = new Aluno(nome) ;
                            Console.Write("Digite a idade do Aluno: ");
                            a.Idade = int.Parse(Console.ReadLine());
                            Console.Write("Digite a matricula  : ");
                            a.Matricula = Console.ReadLine();
                            la.Add(a);
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.Write("Qual nome do professor : ");
                            string aux = Console.ReadLine();
                            foreach (var item in lp)
                            {
                                if(item.Nome == aux)
                                {
                                    Console.WriteLine(item.MostraProfessor());
                                    Console.WriteLine();
                                }
                            }
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Console.Write("Qual a idade do aluno : ");
                            int aux = int.Parse(Console.ReadLine());
                            foreach (var item in la)
                            {
                                if (item.Idade==aux)
                                {
                                    Console.WriteLine(item.MostraAluno());
                                    Console.WriteLine();
                                }
                            }
                            Console.ReadKey();
                        }
                        break;
                
                }
            } while (op!=5);

        }
    }
}
