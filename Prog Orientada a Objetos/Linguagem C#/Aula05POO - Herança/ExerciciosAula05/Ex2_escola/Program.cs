using System;

namespace Ex2_escola
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p = new Professor();
            Console.WriteLine("CADASTRO PROFESSOR");
            CadastroPessoal(p);
            Console.Write("Titulo: ");
            p.Titulo = Console.ReadLine();

            Console.Clear();
            Funcionario f = new Funcionario();
            Console.WriteLine("CADASTRO FUNCIONARIO");
            CadastroPessoal(f);
            Console.Write("Data de nascimento: ");
            f.DataNascimento = Console.ReadLine();

            Console.Clear();
            FuncNoturno fn = new FuncNoturno();
            Console.WriteLine("CADASTRO FUNCIONARIO NOTURNO");
            CadastroPessoal(fn);
            Console.Write("Data de nascimento: ");
            fn.DataNascimento = Console.ReadLine();
            Console.Write("Horario de entrada: ");
            fn.AdicNoturno = float.Parse(Console.ReadLine());

            Console.Clear();
            Aluno a = new Aluno();
            Console.WriteLine("CADASTRO DO ALUNO");
            CadastroPessoal(a);
            Console.Write("Matricula do aluno: ");
            a.Matricula = Console.ReadLine();


            Console.Clear();


            Console.WriteLine("PROFESSOR");
            p.MostraProfessor();

            Console.WriteLine("FUNCIONÁRIO");
            f.MostraFunc();

            Console.WriteLine("FUNCIONÁRIO NOTURNO");
            fn.MostraFuncNot();

            Console.WriteLine("ALUNO");
            a.MostraAluno();
        }

        static void CadastroPessoal(Pessoa obj)
        {
            Console.Write("Nome: ");
            obj.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            obj.Idade = int.Parse(Console.ReadLine());
            Console.Write("CPF: ");
            string auxCPF = Console.ReadLine();
            if (obj.Cpf.ValidaCpf(auxCPF) == false)
            {
                Console.WriteLine("CPF inválido");
            }
        }
    }
}
