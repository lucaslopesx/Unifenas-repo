using System;

namespace POOIntro
{
    class Funcionario
    {
        public string nome;
        public float salario;
    

        public void Gravar()
        {
            Console.Clear();
            Console.Write("Digite o nome do funcionario: ");
            nome = Console.ReadLine();
            Console.Write("Informe o salario do funcionario (R$): ");
            salario = float.Parse(Console.ReadLine());
        }

        public void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("Nome do funcionario: " + nome);
            Console.WriteLine("Salario do funcionario: " + salario.ToString("0.00"));
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Funcionario f1 = new Funcionario();

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
                        f1.Gravar();
                        break;
                    case 2:
                        f1.Mostrar();
                        break;
                }
            } while (op != 3);
        }
    }
}
