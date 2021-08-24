using System;

namespace ExMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, numPix;
            string nomeProd = "null", formPagStr = "null";
            double valorProd = 0, valorParc = 0;
            int formPag = 0, numParc = 0;

            


            do
            {
                Console.WriteLine("              MENU DE COMPRA");
                Console.WriteLine("==========================================");
                Console.WriteLine("  1.Nome do produto");
                Console.WriteLine("  2.Valor do produto");
                Console.WriteLine("  3.Forma de pagamento");
                Console.WriteLine("  4.Mostrar dados da compra");
                Console.WriteLine("  5.Apagar registros");
                Console.WriteLine("  6.Fechar menu");
                Console.WriteLine("===========================================");

                Console.Write("Digite a opção desejada: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Write("Nome do produto: ");
                        nomeProd = Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Write("Valor do produto: ");
                        valorProd = double.Parse(Console.ReadLine());
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("=====Formas de pagamento=====");
                        Console.WriteLine("1.A vista no dinheiro");// dar 10 % de desconto
                        Console.WriteLine("2.PIX");//ler numero do pix
                        Console.WriteLine("3.Parcelado");//ler o número de parcelas e fornecer o valor de cada parcela
                        Console.WriteLine("");
                        formPag = int.Parse(Console.ReadLine());
                        if (formPag == 1)
                        {
                            valorProd = valorProd * 0.9;
                            formPagStr = "A vista no dinheiro";
                        }
                        else if (formPag == 2)
                        {
                            Console.Write("Digite seu número cadastrado no PIX:");
                            numPix = int.Parse(Console.ReadLine());
                            formPagStr = "PIX";
                        }
                        else if (formPag == 3)
                        {
                            Console.Write("Número de parcelas: ");
                            numParc = int.Parse(Console.ReadLine());
                            formPagStr = "Parcelado";
                            valorParc = valorProd / numParc;
                        }
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("=====Resumo da compra=====");
                        Console.WriteLine("Produto: " + nomeProd);
                        if (numParc > 0)
                        {
                            Console.WriteLine("Parcelado em " + numParc + "x de " + valorParc.ToString("R$0.00"));
                        }
                        else
                        {
                            Console.WriteLine("Valor final: " + valorProd.ToString("R$0.00"));
                        }
                        
                        Console.WriteLine("Forma de pagamento: " + formPagStr);
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 5:
                        formPag = 0;
                        numParc = 0;
                        valorProd = 0;
                        valorParc = 0;
                        nomeProd = "null";
                        formPagStr = "null";
                        numPix = 0;
                        Console.Clear();
                        break;
                }
            } while (op !=6);
            
            
            

            

            

        }
    }
}
