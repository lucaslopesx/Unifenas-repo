using System;

namespace exVacinacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, j = 0;
            string[] nomeEstado = new string[27];
            int[] tamPop = new int[27];
            int[] popVacinada = new int[27];
            int popVacFinal = 0, tamPopFinal = 0, popNaoVac;
            float porcentagemNaoVac;

            Console.WriteLine("=====Vacinação=====");
            Console.WriteLine("");

            do
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Digite o nome de um estado: ");
                    nomeEstado[j] = Console.ReadLine();
                    Console.Write("Número de habitantes: ");
                    tamPop[j] = int.Parse(Console.ReadLine());
                    Console.Write("Número de habitantes já vacinados: ");
                    popVacinada[j] = int.Parse(Console.ReadLine());
                    j++;
                }
                Console.Write("Deseja cadastrar novos estados? (0 = sim, 1 = não): ");
                op = int.Parse(Console.ReadLine());
                
            } while (op != 1);

            for (int i = 0; i < tamPop.Length; i++)
            {
                tamPopFinal += tamPop[i];
                popVacFinal += popVacinada[i];
            }
            popNaoVac = tamPopFinal - popVacFinal;      // PS
            porcentagemNaoVac = float(popNaoVac / tamPopFinal) * 100;// Nao entendi porque a variavel porcentagemNaoVac nao recebe valor algum, testei na depuraçao e ela nao recebe de forma alguma nenhum valor pelo que testei

            Console.Clear();
            Console.WriteLine("Balanço final sobre a vacinação");
            Console.WriteLine("");

            Console.WriteLine("Pessoas vacinadas: " + popVacFinal);
            Console.WriteLine("Número total de pessoas: " + tamPopFinal);
            Console.WriteLine("Porcentagem de pessoas que não foram vacinadas: " + porcentagemNaoVac + "%");

        }
    }
}
