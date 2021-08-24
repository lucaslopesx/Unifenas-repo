using System;

namespace exMatrizProp
{
    class Program
    {
        struct MatrizExemplo
        {
            public int[,] matriz;
        }

        static void Gravar(ref MatrizExemplo m, ref int linhas, ref int colunas)
        {
            Console.Clear();
            Console.WriteLine("=======GRAVANDO MATRIZ======");
            Console.WriteLine("");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write("(" + i + "," + j + "): ");
                    m.matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

        }
        static void MostrarM(MatrizExemplo m, int linha, int coluna)
        {
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write(m.matriz[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

        static void MostrarDiag(MatrizExemplo m, int linha, int coluna)
        {
            for (int i = 0; i < linha; i++)
            {
                Console.Write(m.matriz[i, i] + "\t");
            }
            Console.ReadKey();
        }
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

            m1.matriz = new int[linha, coluna];
            m2.matriz = new int[linha, coluna];
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
                        Gravar(ref m1, ref linha, ref coluna);
                        Gravar(ref m2, ref linha, ref coluna);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("=============MATRIZ 1=============");
                        Console.WriteLine("");
                        MostrarM(m1, linha, coluna);
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("=============MATRIZ 2=============");
                        Console.WriteLine("");
                        MostrarM(m2, linha, coluna);
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("========DIAGONAL MATRIZ 1=========");
                        Console.WriteLine("");
                        MostrarDiag(m1, linha, coluna);
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("========DIAGONAL MATRIZ 2=========");
                        Console.WriteLine("");
                        MostrarDiag(m2, linha, coluna);
                        break;
                }
            } while (op != 6);

        }
    }
}
