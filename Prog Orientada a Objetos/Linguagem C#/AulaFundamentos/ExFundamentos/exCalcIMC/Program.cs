using System;

namespace exCalcIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 1;
            float[] tam = new float[5];
            double[] imc = new double[5];
            float[] peso = new float[5];
            string[] nome = new string[5];

            Console.WriteLine("=====CALCULADORA DE IMC=====");//IMC = Peso ÷ (Altura × Altura)
            Console.WriteLine("");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o nome da " + j + "a pessoa: "); 
                nome[i] = Console.ReadLine();
                Console.Write("Informe seu peso (kg): ");
                peso[i] = float.Parse(Console.ReadLine());
                Console.Write("Informe sua altura (metro e cm): ");
                tam[i] = float.Parse(Console.ReadLine());

                imc[i] = (peso[i] / (tam[i] * tam[i]))*10000;
                j++;
            }
            j = 1;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("======Resultado IMC("+ j +"a pessoa)======");
                Console.WriteLine("Nome: "+ nome[i]);
                Console.WriteLine("IMC: " + imc[i].ToString("N2"));
                if(imc[i] < 18.5)
                {
                    Console.WriteLine("Categoria: Magreza");
                    Console.WriteLine("Grau: 0");
                }
                else if (imc[i] <= 24.9)
                {
                    Console.WriteLine("Categoria: Normal");
                    Console.WriteLine("Grau: 0");
                }
                else if (imc[i] <= 29.9)
                {
                    Console.WriteLine("Categoria: Sobrepeso");
                    Console.WriteLine("Grau: I");
                }
                else if (imc[i] <= 39.9)
                {
                    Console.WriteLine("Categoria: Obesidade");
                    Console.WriteLine("Grau: II");
                }
                else if (imc[i] >= 40)
                {
                    Console.WriteLine("Categoria: Obesidade Grave");
                    Console.WriteLine("Grau: III");
                }

                j++;
            }

            
        }
    }
}
//MENOR QUE 18,5	MAGREZA	0
//ENTRE 18,5 E 24,9	NORMAL	0
//ENTRE 25,0 E 29,9	SOBREPESO	I
//ENTRE 30,0 E 39,9	OBESIDADE	II
//MAIOR QUE 40,0	OBESIDADE GRAVE	III