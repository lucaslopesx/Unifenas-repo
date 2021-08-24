using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro do professor");
            Console.WriteLine();
            Professor m = new Professor();
            cadastropessoal(m);
            Console.Write("Titulação : ");
            m.Titulacao = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Mostrando Professor");
            Console.WriteLine(m.MostraProfessor());
            Console.WriteLine("Tecle <ENTER> para continuar.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Cadastro do aluno");
            Console.WriteLine();
            Aluno a = new Aluno();
            cadastropessoal(a);
            Console.Write("Matricula : ");
            a.Matricula = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Mostrando Aluno");
            Console.WriteLine(a.MostraAluno());
            Console.WriteLine("Tecle <ENTER> para continuar.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Cadastro do funcionario");
            Console.WriteLine();
            Funcionario f = new Funcionario();
            cadastropessoal(f);
            Console.Write("Cargo : ");
            f.Cargo = Console.ReadLine();
            Console.Write("Salario : ");
            f.Salario = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Mostrando Funcionario ");
            Console.WriteLine(f.MostraFuncionario());
            Console.WriteLine("Tecle <ENTER> para continuar.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Cadastro do funcionario noturno");
            Console.WriteLine();
            Funcionario_Noturno FN = new Funcionario_Noturno();
            cadastropessoal(FN);
            Console.Write("Cargo : ");
            FN.Cargo = Console.ReadLine();
            Console.Write("Salario : ");
            FN.Salario = double.Parse(Console.ReadLine());
            Console.Write("Horario em que entra no trabalho Formato(XX:XX): ");
            FN.Hora_entrada = Console.ReadLine();
            Console.Write("Horario em que sai do trabalho Formato(XX:XX):");
            FN.Hora_saida = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Mostrando Funcionario Noturno ");
            Console.WriteLine(FN.MostraFuncionarioNoturno());
            Console.WriteLine("Tecle <ENTER> para sair.");
            Console.ReadKey();
            Console.Clear();

            static void cadastropessoal(Pessoa obj)
            {
                Console.Write("CPF : ");
                string auxcpf = Console.ReadLine();
                while((obj.Cpf.ValidaCpf(auxcpf) == false))
                {
                    Console.WriteLine();
                    Console.WriteLine("CPF_INVÁLIDO");
                    Console.WriteLine("Digite Novamente");
                    Console.Write("CPF : ");
                    auxcpf = Console.ReadLine();
                }
                Console.Write("Nome : ");
                obj.Nome = Console.ReadLine();
                Console.Write("Idade : ");
                obj.Idade = int.Parse(Console.ReadLine());

            }
        }
    }
}
