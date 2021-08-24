using System;

namespace exFuncionario
{
    class Program
    {
        struct Funcionario
        {
            public string nome;
            public float salario;
        }

        static void Gravar(ref Funcionario F)
        {
            Console.Clear();
            Console.Write("Digite o nome do funcionario: ");
            F.nome = Console.ReadLine();
            Console.Write("Digite o salario do funcionario: ");
            F.salario = float.Parse(Console.ReadLine());
        }

        static void Mostrar(Funcionario F)
        {
            Console.Clear();
            Console.WriteLine("Nome do funcionario: " + F.nome);
            Console.WriteLine("Salario do funcionario: " + F.salario.ToString("0.00"));
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int op;
            Funcionario F = new Funcionario
            {
                nome = "null",
                salario = 0
            };
            
            do
            {
                Console.Clear();
                Console.WriteLine("========MENU FUNCIONARIO========");
                Console.WriteLine("1. Gravar Nome e Salário do Funcionário");
                Console.WriteLine("2. Mostrar Nome e Salário do Funcionário.");
                Console.WriteLine("3. Sair");
                Console.WriteLine("================================");
                Console.Write("Digite a opção desejada: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Gravar(ref F);
                        break;
                    case 2:
                        Mostrar(F);
                        break;
                }
            } while (op != 3);
        }
    }
}
