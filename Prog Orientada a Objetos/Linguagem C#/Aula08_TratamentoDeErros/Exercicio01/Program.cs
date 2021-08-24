using System;
using System.IO;

namespace Exercicio01
{ 
    namespace Exemplo3
    {
        class Program
        {
            static void Main(string[] args)
            {
                Stream entrada = null;
                StreamReader leitor = null;
                try
                {
                    entrada = File.Open("entrada.txt", FileMode.Open);
                    leitor = new StreamReader(entrada);
                    string linha = leitor.ReadLine();
                    while (linha != null)
                    {
                        Console.WriteLine(linha);
                        linha = leitor.ReadLine();
                    }
                    leitor.Close();
                    entrada.Close();
                    Console.ReadKey();
                }
                catch(FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if(leitor != null && entrada != null)
                    {
                        leitor.Close();
                        entrada.Close();
                    }
                }
            }
        }
    }

}
