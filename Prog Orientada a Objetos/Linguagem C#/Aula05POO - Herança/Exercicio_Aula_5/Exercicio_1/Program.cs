using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Medico m = new Medico();
            Console.WriteLine("\n Cadastro de médico \n");
            cadastropessoal(m);
            Console.Write("CRM: ");
            m.Crm = Console.ReadLine();
            Console.Write("Especialidade: ");
            m.Especialidade = Console.ReadLine();
            Console.WriteLine("\n" + m.MostraMedico());
            Paciente p = new Paciente();
            Console.WriteLine("\n Cadastro de Paciente \n");
            cadastropessoal(p);
            Console.Write("Plano: ");
            p.Plano = Console.ReadLine();
            Console.WriteLine("\n" + p.MostraPaciente());
            Console.ReadKey();
        }
        static void cadastropessoal(Pessoa obj)
        {
            Console.Write("CPF: ");
            obj.Cpf = Console.ReadLine();
            Console.Write("Nome: ");
            obj.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            obj.Idade = int.Parse(Console.ReadLine());

            
        }
    }
}
