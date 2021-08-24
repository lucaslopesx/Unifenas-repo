using System;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            //idade = int.Parse(Console.ReadLine());
            //idade = Convert.ToInt32(Console.ReadLine());
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Meu nome é: "+ nome +" e minha idade é "+ idade.ToString());
        }
    }
}
