using System;

namespace Projeto3
{
    class MatrizExemplo
    {
        private int linha, coluna;
        private int[,] matriz;
        public MatrizExemplo(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;

            matriz = new int[linha, coluna];

            Console.WriteLine("Construindo sua matriz com " + linha + "linha(s) e " + coluna + " coluna(s)");
            Console.ReadKey();
        }
        public void Gravar()
        {
            Console.Clear();
            Console.WriteLine("=======GRAVANDO MATRIZ======");
            Console.WriteLine("");
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write("(" + i + "," + j + "): ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

        }
        public void MostrarM()
        {
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

        public void MostrarDiag()
        {
            for (int i = 0; i < linha; i++)
            {
                Console.Write(matriz[i, i] + "\t");
            }
            Console.ReadKey();
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int op;
            int linha, coluna;
            MatrizExemplo m1, m2;

            linha = 0;
            coluna = 0;
            Console.WriteLine("=============ENTRE COM AS MEDIDAS DA MATRIZ=============");
            Console.Write("Digite o numero de linhas da matriz: ");
            linha = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero de colunas da matriz: ");
            coluna = int.Parse(Console.ReadLine());
            Console.WriteLine("========================================================");

            m1 = new MatrizExemplo(linha, coluna);
            m2 = new MatrizExemplo(linha, coluna);
            do
            {
                Console.Clear();
                Console.WriteLine("=============MATRIZ=============");
                Console.WriteLine("1. Gravar conteudos das matrizes");
                Console.WriteLine("2. Mostrar 1a matriz tabular");
                Console.WriteLine("3. Mostrar 2a matriz tabular");
                Console.WriteLine("4. Mostrar diagonal da 1a matriz");
                Console.WriteLine("5. Mostrar diagonal da 2a matriz");
                Console.WriteLine("6. Sair");
                Console.WriteLine("================================");
                Console.Write("Digite a opção desejada: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        m1.Gravar();
                        m2.Gravar();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("=============MATRIZ 1=============");
                        Console.WriteLine("");
                        m1.MostrarM();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("=============MATRIZ 2=============");
                        Console.WriteLine("");
                        m2.MostrarM();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("========DIAGONAL MATRIZ 1=========");
                        Console.WriteLine("");
                        m1.MostrarDiag();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("========DIAGONAL MATRIZ 2=========");
                        Console.WriteLine("");
                        m2.MostrarDiag();
                        break;
                }
            } while (op != 6);

        }
    }
}
