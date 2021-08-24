using System;

namespace validaCPF
{
    class Program
    {
        static void Main(string[] args)
        {

            char ok = 's';

            while (ok == 's')
            {
                Cliente c1 = new Cliente();
                Console.Write("Nome Cliente: ");
                c1.Nome = Console.ReadLine();
                Console.Write("CPF: ");
                string auxCPF = Console.ReadLine();
                if (c1.Objeto_cpf.ValidaCpf(auxCPF) == false)
                {
                    Console.WriteLine("CPF inválido");
                }
                Console.Write("Dia Nascimento: ");
                c1.Objeto_data.Dia = int.Parse(Console.ReadLine());
                Console.Write("Mês Nascimento: ");
                c1.Objeto_data.Mes = int.Parse(Console.ReadLine());
                Console.Write("Ano Nascimento: ");
                c1.Objeto_data.Ano = int.Parse(Console.ReadLine());
                Console.Write("Rua: ");
                c1.Objeto_endereco.Rua = Console.ReadLine();
                Console.Write("Número: ");
                c1.Objeto_endereco.Numero = int.Parse(Console.ReadLine());
                Console.Write("Bairro: ");
                c1.Objeto_endereco.Bairro = Console.ReadLine();
                Console.Write("Cidade: ");
                c1.Objeto_endereco.Cidade = Console.ReadLine();
                Console.Write("Estado: ");
                c1.Objeto_endereco.Estado = Console.ReadLine();

                Console.Write("Deseja continuar? s/n: ");
                ok = char.Parse(Console.ReadLine());
            }
            

            

            Console.WriteLine("\nMostrando Cliente\n");
            Console.WriteLine(c1.Nome);
            Console.WriteLine(c1.Objeto_data.MDataBar());
            Console.WriteLine(c1.Objeto_data.MDataExt());
            Console.WriteLine(c1.Objeto_cpf.MostraCPF());
            Console.WriteLine(c1.Objeto_endereco.MostraEndereco());

            Console.WriteLine("datraaaaaa");
            c1.mostraData();

            Console.ReadKey();
        }
    }
}
