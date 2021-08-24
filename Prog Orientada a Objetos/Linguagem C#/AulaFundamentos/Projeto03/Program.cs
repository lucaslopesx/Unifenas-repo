using System;

namespace Projeto03
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor, valorParc;
            string nomeProd;
            int parc;

            Console.Write("Digite o nome do produto: ");
            nomeProd = Console.ReadLine();
            Console.Write("Digite o valor do produto: ");
            valor = float.Parse(Console.ReadLine());

            Console.WriteLine("O produto " + nomeProd + " custa " + valor.ToString("R$0.00"));

            Console.Write("Em quantas parcelas deseja pagar o produto: ");
            parc = int.Parse(Console.ReadLine());

            valorParc = valor / parc;
           
            Console.WriteLine("O produto vai ser parcelado em " + parc.ToString() + " vezes, dando um total de " + valorParc.ToString("R$0.00") + " por parcela");
        }
    }
}
